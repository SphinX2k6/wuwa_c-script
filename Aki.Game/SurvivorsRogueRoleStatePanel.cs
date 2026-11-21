using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011E3 RID: 4579
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueRoleStatePanel : UiPanelBase
{
	// Token: 0x17001244 RID: 4676
	// (get) Token: 0x0600B5C7 RID: 46535 RVA: 0x0035B8D0 File Offset: 0x00359AD0
	private float CurHp
	{
		get
		{
			if (this.AttrMap == null)
			{
				return 0f;
			}
			int num = this.AttrMap.Get(EKSC_AttrType.Life);
			if (num > 0)
			{
				return (float)num;
			}
			return 0f;
		}
	}

	// Token: 0x17001245 RID: 4677
	// (get) Token: 0x0600B5C8 RID: 46536 RVA: 0x0035B904 File Offset: 0x00359B04
	private float MaxHp
	{
		get
		{
			if (this.AttrMap == null)
			{
				return this.LastValidMaxHp;
			}
			int num = this.AttrMap.Get(EKSC_AttrType.LifeMax);
			if (num > 0)
			{
				this.LastValidMaxHp = (float)num;
				return (float)num;
			}
			return this.LastValidMaxHp;
		}
	}

	// Token: 0x0600B5C9 RID: 46537 RVA: 0x0035B942 File Offset: 0x00359B42
	public SurvivorsRogueRoleStatePanel()
	{
	}

	// Token: 0x0600B5CA RID: 46538 RVA: 0x0035B97C File Offset: 0x00359B7C
	public SurvivorsRogueRoleStatePanel(bool NeedRoleUpdate, bool NeedWeaponUpdate)
	{
		this.NeedRoleUpdate = NeedRoleUpdate;
		this.NeedWeaponUpdate = NeedWeaponUpdate;
	}

	// Token: 0x0600B5CB RID: 46539 RVA: 0x0035B9CC File Offset: 0x00359BCC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUISprite)),
			new ValueTuple<int, Type>(10, typeof(UUIItem))
		};
	}

	// Token: 0x0600B5CC RID: 46540 RVA: 0x0035BAD8 File Offset: 0x00359CD8
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueRoleStatePanel.<OnBeforeStartAsync>d__34 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueRoleStatePanel.<OnBeforeStartAsync>d__34>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B5CD RID: 46541 RVA: 0x0035BB1C File Offset: 0x00359D1C
	protected override void OnStart()
	{
		this.ShieldBarSprite = base.GetSprite(4);
		this.HpBarSprite = base.GetSprite(3);
		this.LowHpBarSprite = base.GetSprite(9);
		this.HpBufferSprite = base.GetSprite(6);
		this.HpText = base.GetText(5);
		this.HpText2 = base.GetText(8);
		this.HpTextMask = (base.GetItem(7).GetOwner().GetComponentByClass(ULGUICanvas.StaticClass()) as ULGUICanvas);
		this.RoleHpBarItem = base.GetItem(10);
		this.HpTextWidth = this.HpText.GetWidth();
		this.WeaponGridList = new GenericLayout<SurvivorsRogueWeaponStateGrid, ISurvivorsWeaponGridData>(base.GetHorizontalLayout(1), new Func<SurvivorsRogueWeaponStateGrid>(this.CreateWeaponItem), null, false, true);
		this.HpBufferAnimDuration = (float)ConfigCommonParamById.GetIntConfig("PlayerHPAttenuateBufferSpeed").GetValueOrDefault();
		this.ShieldBarPlayer = new LevelSequencePlayer(base.GetSprite(4));
		this.DeadEffectPlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600B5CE RID: 46542 RVA: 0x0035BC1A File Offset: 0x00359E1A
	private SurvivorsRogueWeaponStateGrid CreateWeaponItem()
	{
		return new SurvivorsRogueWeaponStateGrid();
	}

	// Token: 0x0600B5CF RID: 46543 RVA: 0x0035BC21 File Offset: 0x00359E21
	protected override void OnBeforeShow()
	{
		this.RefreshRoleGain();
		this.RefreshWeaponGain();
		this.OnAddEventListener();
		this.InitPlayerData();
	}

	// Token: 0x0600B5D0 RID: 46544 RVA: 0x0035BC3B File Offset: 0x00359E3B
	protected override void OnBeforeHide()
	{
		this.OnRemoveEventListener();
	}

	// Token: 0x0600B5D1 RID: 46545 RVA: 0x0035BC44 File Offset: 0x00359E44
	protected void OnAddEventListener()
	{
		EventSystem.Instance.Add<string, string>(EEventName.TextLanguageChange, new Action<string, string>(this.OnRefreshText));
		EventSystem.Instance.Add(EEventName.OnKscPlayerHpChanged, new Action(this.OnKscPlayerHpChanged));
		EventSystem.Instance.Add(EEventName.SurvivorsRoguePlayerEntityCreated, new Action(this.OnPlayerEntityCreated));
		if (this.NeedRoleUpdate)
		{
			EventSystem.Instance.Add<int>(EEventName.SurvivorsRogueRoleGainUpdate, new Action<int>(this.EventRefreshRoleGain));
		}
		if (this.NeedWeaponUpdate)
		{
			EventSystem.Instance.Add<int, bool>(EEventName.SurvivorsRogueWeaponGainUpdate, new Action<int, bool>(this.EventRefreshWeaponGain));
		}
	}

	// Token: 0x0600B5D2 RID: 46546 RVA: 0x0035BCF0 File Offset: 0x00359EF0
	protected void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.TextLanguageChange, new Action<string, string>(this.OnRefreshText));
		EventSystem.Instance.Remove(EEventName.OnKscPlayerHpChanged, new Action(this.OnKscPlayerHpChanged));
		EventSystem.Instance.Remove(EEventName.SurvivorsRoguePlayerEntityCreated, new Action(this.OnPlayerEntityCreated));
		if (this.NeedRoleUpdate)
		{
			EventSystem.Instance.Remove(EEventName.SurvivorsRogueRoleGainUpdate, new Action<int>(this.EventRefreshRoleGain));
		}
		if (this.NeedWeaponUpdate)
		{
			EventSystem.Instance.Remove(EEventName.SurvivorsRogueWeaponGainUpdate, new Action<int, bool>(this.EventRefreshWeaponGain));
		}
	}

	// Token: 0x0600B5D3 RID: 46547 RVA: 0x0035BD99 File Offset: 0x00359F99
	private void OnPlayerEntityCreated()
	{
		this.InitPlayerData();
	}

	// Token: 0x0600B5D4 RID: 46548 RVA: 0x0035BDA4 File Offset: 0x00359FA4
	public void InitPlayerData()
	{
		KscSubModelBase curSubModel = KuroSimpleCombatController.Instance.CurSubModel;
		AKSC_Entity aksc_Entity = (curSubModel != null) ? curSubModel.KscPlayerEntity : null;
		if (aksc_Entity == null)
		{
			this.RoleHpBarItem.SetUIActive(false);
			return;
		}
		UKSC_SkillComp skillComp = aksc_Entity.GetSkillComp();
		TMap<EKSC_AttrType, int> tmap;
		if (skillComp == null)
		{
			tmap = null;
		}
		else
		{
			UKSC_AttrSet attrSet_ = skillComp.AttrSet_;
			tmap = ((attrSet_ != null) ? attrSet_.Attrs_ : null);
		}
		TMap<EKSC_AttrType, int> tmap2 = tmap;
		if (tmap2 == null)
		{
			this.RoleHpBarItem.SetUIActive(false);
			return;
		}
		this.AttrMap = tmap2;
		this.RefreshHpAndShield(false);
		this.RoleHpBarItem.SetUIActive(true);
	}

	// Token: 0x0600B5D5 RID: 46549 RVA: 0x0035BE21 File Offset: 0x0035A021
	public void OnTick(float delta)
	{
		this.LerpBarPercent(delta);
	}

	// Token: 0x0600B5D6 RID: 46550 RVA: 0x0035BE2A File Offset: 0x0035A02A
	private void RefreshRoleGain()
	{
		this.RoleGrid.Refresh(SurvivorsRogueModel.Instance.CurRoleId, SurvivorsRogueModel.Instance.CurRoleLevel);
	}

	// Token: 0x0600B5D7 RID: 46551 RVA: 0x0035BE4B File Offset: 0x0035A04B
	private void EventRefreshRoleGain(int roleId)
	{
		this.RefreshRoleGain();
	}

	// Token: 0x0600B5D8 RID: 46552 RVA: 0x0035BE54 File Offset: 0x0035A054
	private void RefreshWeaponGain()
	{
		this.WeaponGridList.RefreshByData(SurvivorsRogueModel.Instance.GainData.GetWeaponGridDataList(null, null), null, false);
	}

	// Token: 0x0600B5D9 RID: 46553 RVA: 0x0035BE87 File Offset: 0x0035A087
	private void EventRefreshWeaponGain(int weaponId, bool isLevelUp)
	{
		this.RefreshWeaponGain();
	}

	// Token: 0x0600B5DA RID: 46554 RVA: 0x0035BE8F File Offset: 0x0035A08F
	private void OnRefreshText(string oldLang, string newLang)
	{
		this.RefreshHpAndShield(false);
	}

	// Token: 0x0600B5DB RID: 46555 RVA: 0x0035BE98 File Offset: 0x0035A098
	private void OnKscPlayerHpChanged()
	{
		this.RefreshHpAndShield(true);
	}

	// Token: 0x0600B5DC RID: 46556 RVA: 0x0035BEA4 File Offset: 0x0035A0A4
	private void RefreshHpAndShield(bool bPlayBarAnimation = false)
	{
		if (this.AttrMap == null)
		{
			return;
		}
		float num = (float)this.AttrMap.Get(EKSC_AttrType.Shield);
		float num2 = this.CurHp / this.MaxHp;
		float shieldBarPercent = Math.Min(num / this.MaxHp, 1f);
		this.UeMargin.Right = -(1f - num2) * this.HpTextWidth;
		this.HpTextMask.SetRectClipOffset(this.UeMargin);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>((int)Math.Ceiling((double)this.CurHp));
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>((int)Math.Ceiling((double)this.MaxHp));
		string newText = defaultInterpolatedStringHandler.ToStringAndClear();
		this.HpText.SetText(newText, true);
		this.HpText2.SetText(newText, true);
		this.SetHpBarPercent(num2);
		this.SetShieldBarPercent(shieldBarPercent);
		this.UeMargin.Right = -(1f - num2) * this.HpTextWidth;
		this.HpTextMask.SetRectClipOffset(this.UeMargin);
		if (bPlayBarAnimation)
		{
			this.PlayBarAnimation();
		}
		else
		{
			this.StopBarLerpAnimation();
		}
		this.CurrentBarPercent = num2;
		if (num2 <= 0f)
		{
			this.DeadEffectPlayer.PlayOrReplaySequenceByName("Dead", false, null);
		}
	}

	// Token: 0x0600B5DD RID: 46557 RVA: 0x0035BFE8 File Offset: 0x0035A1E8
	private void SetShieldBarPercent(float percent)
	{
		bool flag = percent > 0f;
		this.ShieldBarSprite.SetUIActive(flag);
		if (flag)
		{
			this.ShieldBarSprite.SetFillAmount(percent);
		}
		if (this.ExistShieldBar != flag)
		{
			this.ExistShieldBar = flag;
			if (flag)
			{
				this.ShieldBarPlayer.PlayLevelSequenceByName("Start", false, null, false);
			}
		}
	}

	// Token: 0x0600B5DE RID: 46558 RVA: 0x0035C048 File Offset: 0x0035A248
	private void SetHpBarPercent(float percent)
	{
		if (percent <= 0.2f)
		{
			this.LowHpBarSprite.SetUIActive(true);
			this.HpBarSprite.SetUIActive(false);
			this.LowHpBarSprite.SetFillAmount(percent);
			return;
		}
		this.LowHpBarSprite.SetUIActive(false);
		this.HpBarSprite.SetUIActive(true);
		this.HpBarSprite.SetFillAmount(percent);
	}

	// Token: 0x0600B5DF RID: 46559 RVA: 0x0035C0A8 File Offset: 0x0035A2A8
	private void PlayBarAnimation()
	{
		if (this.AttrMap == null)
		{
			return;
		}
		float num = this.CurHp / this.MaxHp;
		float currentBarPercent = this.CurrentBarPercent;
		if (num >= currentBarPercent)
		{
			return;
		}
		this.TargetBarPercent = num;
		this.SourceBarPercent = currentBarPercent;
		this.HpBufferAnimTime = 0f;
	}

	// Token: 0x0600B5E0 RID: 46560 RVA: 0x0035C0F1 File Offset: 0x0035A2F1
	private void StopBarLerpAnimation()
	{
		this.TargetBarPercent = 0f;
		this.SourceBarPercent = 0f;
		this.HpBufferAnimTime = -1f;
		this.HpBufferSprite.SetUIActive(false);
	}

	// Token: 0x0600B5E1 RID: 46561 RVA: 0x0035C120 File Offset: 0x0035A320
	private void SetBarBufferPercent(float percent)
	{
		this.HpBufferSprite.SetFillAmount(percent);
		this.HpBufferSprite.SetUIActive(true);
	}

	// Token: 0x0600B5E2 RID: 46562 RVA: 0x0035C13C File Offset: 0x0035A33C
	private void LerpBarPercent(float delta)
	{
		if (this.HpBufferAnimTime == -1f)
		{
			return;
		}
		if (this.HpBufferAnimTime >= this.HpBufferAnimDuration)
		{
			this.StopBarLerpAnimation();
		}
		if (this.TargetBarPercent >= this.SourceBarPercent)
		{
			return;
		}
		float alpha = this.HpBufferAnimTime / this.HpBufferAnimDuration;
		float barBufferPercent = MathUtils.Instance.Lerp(this.SourceBarPercent, this.TargetBarPercent, alpha);
		this.SetBarBufferPercent(barBufferPercent);
		this.HpBufferAnimTime += delta;
	}

	// Token: 0x0600B5E3 RID: 46563 RVA: 0x0035C1B5 File Offset: 0x0035A3B5
	[NullableContext(2)]
	public SurvivorsRogueWeaponStateGrid GetWeaponGrid(int weaponId)
	{
		return this.WeaponGridList.GetLayoutItemByKey(weaponId);
	}

	// Token: 0x0600B5E4 RID: 46564 RVA: 0x0035C1C8 File Offset: 0x0035A3C8
	[NullableContext(2)]
	public SurvivorsRogueWeaponStateGrid GetWeaponGridByIndex(int index)
	{
		return this.WeaponGridList.GetLayoutItemByIndex(index);
	}

	// Token: 0x0600B5E5 RID: 46565 RVA: 0x0035C1D6 File Offset: 0x0035A3D6
	public List<SurvivorsRogueWeaponStateGrid> GetAllWeaponGrid()
	{
		return this.WeaponGridList.GetLayoutItemList();
	}

	// Token: 0x0600B5E6 RID: 46566 RVA: 0x0035C1E4 File Offset: 0x0035A3E4
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length <= 2)
		{
			return null;
		}
		string a = configParams[2];
		if (a == "FirstWeapon")
		{
			GenericLayout<SurvivorsRogueWeaponStateGrid, ISurvivorsWeaponGridData> weaponGridList = this.WeaponGridList;
			SurvivorsRogueWeaponStateGrid survivorsRogueWeaponStateGrid = (weaponGridList != null) ? weaponGridList.GetLayoutItemByIndex(0) : null;
			if (survivorsRogueWeaponStateGrid == null)
			{
				return null;
			}
			return survivorsRogueWeaponStateGrid.GetGuideUiItemAndUiItemForShowEx(configParams);
		}
		else
		{
			if (!(a == "FirstTwoWeapon"))
			{
				return null;
			}
			UUIItem guideUiItem = base.GetGuideUiItem("1");
			if (guideUiItem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				guideUiItem,
				guideUiItem
			};
		}
	}

	// Token: 0x04006939 RID: 26937
	private const float LOW_HP_PERCENT = 0.2f;

	// Token: 0x0400693A RID: 26938
	private const string DEAD_SEQUENCE_NAME = "Dead";

	// Token: 0x0400693B RID: 26939
	[Nullable(2)]
	private TMap<EKSC_AttrType, int> AttrMap;

	// Token: 0x0400693C RID: 26940
	private UUISprite ShieldBarSprite;

	// Token: 0x0400693D RID: 26941
	private UUISprite HpBarSprite;

	// Token: 0x0400693E RID: 26942
	private UUISprite LowHpBarSprite;

	// Token: 0x0400693F RID: 26943
	private UUISprite HpBufferSprite;

	// Token: 0x04006940 RID: 26944
	private UUIText HpText;

	// Token: 0x04006941 RID: 26945
	private UUIText HpText2;

	// Token: 0x04006942 RID: 26946
	private ULGUICanvas HpTextMask;

	// Token: 0x04006943 RID: 26947
	private UUIItem RoleHpBarItem;

	// Token: 0x04006944 RID: 26948
	private float HpTextWidth;

	// Token: 0x04006945 RID: 26949
	private FMargin UeMargin;

	// Token: 0x04006946 RID: 26950
	private float CurrentBarPercent = -1f;

	// Token: 0x04006947 RID: 26951
	private float TargetBarPercent;

	// Token: 0x04006948 RID: 26952
	private float SourceBarPercent;

	// Token: 0x04006949 RID: 26953
	private float HpBufferAnimTime = -1f;

	// Token: 0x0400694A RID: 26954
	private float HpBufferAnimDuration;

	// Token: 0x0400694B RID: 26955
	private float LastValidMaxHp = -1f;

	// Token: 0x0400694C RID: 26956
	[Nullable(2)]
	private LevelSequencePlayer ShieldBarPlayer;

	// Token: 0x0400694D RID: 26957
	private bool ExistShieldBar;

	// Token: 0x0400694E RID: 26958
	[Nullable(2)]
	private LevelSequencePlayer DeadEffectPlayer;

	// Token: 0x0400694F RID: 26959
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SurvivorsRogueWeaponStateGrid, ISurvivorsWeaponGridData> WeaponGridList;

	// Token: 0x04006950 RID: 26960
	[Nullable(2)]
	public SurvivorsRogueRoleInfoGrid RoleGrid;

	// Token: 0x04006951 RID: 26961
	private readonly bool NeedRoleUpdate = true;

	// Token: 0x04006952 RID: 26962
	private readonly bool NeedWeaponUpdate = true;

	// Token: 0x020074A3 RID: 29859
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025F49 RID: 155465
		public const int RoleGrid = 0;

		// Token: 0x04025F4A RID: 155466
		public const int WeaponLayout = 1;

		// Token: 0x04025F4B RID: 155467
		public const int WeaponGrid = 2;

		// Token: 0x04025F4C RID: 155468
		public const int RoleHpBar = 3;

		// Token: 0x04025F4D RID: 155469
		public const int RoleShieldBar = 4;

		// Token: 0x04025F4E RID: 155470
		public const int RoleHpNumber = 5;

		// Token: 0x04025F4F RID: 155471
		public const int RoleHpBufferBar = 6;

		// Token: 0x04025F50 RID: 155472
		public const int RoleHpMask = 7;

		// Token: 0x04025F51 RID: 155473
		public const int RoleHpNumber2 = 8;

		// Token: 0x04025F52 RID: 155474
		public const int RoleLowHpBar = 9;

		// Token: 0x04025F53 RID: 155475
		public const int RoleHpBarItem = 10;
	}
}
