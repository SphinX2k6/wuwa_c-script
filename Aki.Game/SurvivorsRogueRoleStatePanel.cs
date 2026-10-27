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

// Token: 0x02001D21 RID: 7457
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueRoleStatePanel : UiPanelBase
{
	// Token: 0x1700121A RID: 4634
	// (get) Token: 0x0600E1AA RID: 57770 RVA: 0x0034FEA0 File Offset: 0x0034E0A0
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

	// Token: 0x1700121B RID: 4635
	// (get) Token: 0x0600E1AB RID: 57771 RVA: 0x0034FED4 File Offset: 0x0034E0D4
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

	// Token: 0x0600E1AC RID: 57772 RVA: 0x0034FF12 File Offset: 0x0034E112
	public SurvivorsRogueRoleStatePanel()
	{
	}

	// Token: 0x0600E1AD RID: 57773 RVA: 0x0034FF4C File Offset: 0x0034E14C
	public SurvivorsRogueRoleStatePanel(bool NeedRoleUpdate, bool NeedWeaponUpdate)
	{
		this.NeedRoleUpdate = NeedRoleUpdate;
		this.NeedWeaponUpdate = NeedWeaponUpdate;
	}

	// Token: 0x0600E1AE RID: 57774 RVA: 0x0034FF9C File Offset: 0x0034E19C
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

	// Token: 0x0600E1AF RID: 57775 RVA: 0x003500A8 File Offset: 0x0034E2A8
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueRoleStatePanel.<OnBeforeStartAsync>d__34 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueRoleStatePanel.<OnBeforeStartAsync>d__34>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E1B0 RID: 57776 RVA: 0x003500EC File Offset: 0x0034E2EC
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

	// Token: 0x0600E1B1 RID: 57777 RVA: 0x003501EA File Offset: 0x0034E3EA
	private SurvivorsRogueWeaponStateGrid CreateWeaponItem()
	{
		return new SurvivorsRogueWeaponStateGrid();
	}

	// Token: 0x0600E1B2 RID: 57778 RVA: 0x003501F1 File Offset: 0x0034E3F1
	protected override void OnBeforeShow()
	{
		this.RefreshRoleGain();
		this.RefreshWeaponGain();
		this.OnAddEventListener();
		this.InitPlayerData();
	}

	// Token: 0x0600E1B3 RID: 57779 RVA: 0x0035020B File Offset: 0x0034E40B
	protected override void OnBeforeHide()
	{
		this.OnRemoveEventListener();
	}

	// Token: 0x0600E1B4 RID: 57780 RVA: 0x00350214 File Offset: 0x0034E414
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

	// Token: 0x0600E1B5 RID: 57781 RVA: 0x003502C0 File Offset: 0x0034E4C0
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

	// Token: 0x0600E1B6 RID: 57782 RVA: 0x00350369 File Offset: 0x0034E569
	private void OnPlayerEntityCreated()
	{
		this.InitPlayerData();
	}

	// Token: 0x0600E1B7 RID: 57783 RVA: 0x00350374 File Offset: 0x0034E574
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

	// Token: 0x0600E1B8 RID: 57784 RVA: 0x003503F1 File Offset: 0x0034E5F1
	public void OnTick(float delta)
	{
		this.LerpBarPercent(delta);
	}

	// Token: 0x0600E1B9 RID: 57785 RVA: 0x003503FA File Offset: 0x0034E5FA
	private void RefreshRoleGain()
	{
		this.RoleGrid.Refresh(SurvivorsRogueModel.Instance.CurRoleId, SurvivorsRogueModel.Instance.CurRoleLevel);
	}

	// Token: 0x0600E1BA RID: 57786 RVA: 0x0035041B File Offset: 0x0034E61B
	private void EventRefreshRoleGain(int roleId)
	{
		this.RefreshRoleGain();
	}

	// Token: 0x0600E1BB RID: 57787 RVA: 0x00350424 File Offset: 0x0034E624
	private void RefreshWeaponGain()
	{
		this.WeaponGridList.RefreshByData(SurvivorsRogueModel.Instance.GainData.GetWeaponGridDataList(null, null), null, false);
	}

	// Token: 0x0600E1BC RID: 57788 RVA: 0x00350457 File Offset: 0x0034E657
	private void EventRefreshWeaponGain(int weaponId, bool isLevelUp)
	{
		this.RefreshWeaponGain();
	}

	// Token: 0x0600E1BD RID: 57789 RVA: 0x0035045F File Offset: 0x0034E65F
	private void OnRefreshText(string oldLang, string newLang)
	{
		this.RefreshHpAndShield(false);
	}

	// Token: 0x0600E1BE RID: 57790 RVA: 0x00350468 File Offset: 0x0034E668
	private void OnKscPlayerHpChanged()
	{
		this.RefreshHpAndShield(true);
	}

	// Token: 0x0600E1BF RID: 57791 RVA: 0x00350474 File Offset: 0x0034E674
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

	// Token: 0x0600E1C0 RID: 57792 RVA: 0x003505B8 File Offset: 0x0034E7B8
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

	// Token: 0x0600E1C1 RID: 57793 RVA: 0x00350618 File Offset: 0x0034E818
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

	// Token: 0x0600E1C2 RID: 57794 RVA: 0x00350678 File Offset: 0x0034E878
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

	// Token: 0x0600E1C3 RID: 57795 RVA: 0x003506C1 File Offset: 0x0034E8C1
	private void StopBarLerpAnimation()
	{
		this.TargetBarPercent = 0f;
		this.SourceBarPercent = 0f;
		this.HpBufferAnimTime = -1f;
		this.HpBufferSprite.SetUIActive(false);
	}

	// Token: 0x0600E1C4 RID: 57796 RVA: 0x003506F0 File Offset: 0x0034E8F0
	private void SetBarBufferPercent(float percent)
	{
		this.HpBufferSprite.SetFillAmount(percent);
		this.HpBufferSprite.SetUIActive(true);
	}

	// Token: 0x0600E1C5 RID: 57797 RVA: 0x0035070C File Offset: 0x0034E90C
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

	// Token: 0x0600E1C6 RID: 57798 RVA: 0x00350785 File Offset: 0x0034E985
	[NullableContext(2)]
	public SurvivorsRogueWeaponStateGrid GetWeaponGrid(int weaponId)
	{
		return this.WeaponGridList.GetLayoutItemByKey(weaponId);
	}

	// Token: 0x0600E1C7 RID: 57799 RVA: 0x00350798 File Offset: 0x0034E998
	[NullableContext(2)]
	public SurvivorsRogueWeaponStateGrid GetWeaponGridByIndex(int index)
	{
		return this.WeaponGridList.GetLayoutItemByIndex(index);
	}

	// Token: 0x0600E1C8 RID: 57800 RVA: 0x003507A6 File Offset: 0x0034E9A6
	public List<SurvivorsRogueWeaponStateGrid> GetAllWeaponGrid()
	{
		return this.WeaponGridList.GetLayoutItemList();
	}

	// Token: 0x0600E1C9 RID: 57801 RVA: 0x003507B4 File Offset: 0x0034E9B4
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

	// Token: 0x0400685A RID: 26714
	private const float LOW_HP_PERCENT = 0.2f;

	// Token: 0x0400685B RID: 26715
	private const string DEAD_SEQUENCE_NAME = "Dead";

	// Token: 0x0400685C RID: 26716
	[Nullable(2)]
	private TMap<EKSC_AttrType, int> AttrMap;

	// Token: 0x0400685D RID: 26717
	private UUISprite ShieldBarSprite;

	// Token: 0x0400685E RID: 26718
	private UUISprite HpBarSprite;

	// Token: 0x0400685F RID: 26719
	private UUISprite LowHpBarSprite;

	// Token: 0x04006860 RID: 26720
	private UUISprite HpBufferSprite;

	// Token: 0x04006861 RID: 26721
	private UUIText HpText;

	// Token: 0x04006862 RID: 26722
	private UUIText HpText2;

	// Token: 0x04006863 RID: 26723
	private ULGUICanvas HpTextMask;

	// Token: 0x04006864 RID: 26724
	private UUIItem RoleHpBarItem;

	// Token: 0x04006865 RID: 26725
	private float HpTextWidth;

	// Token: 0x04006866 RID: 26726
	private FMargin UeMargin;

	// Token: 0x04006867 RID: 26727
	private float CurrentBarPercent = -1f;

	// Token: 0x04006868 RID: 26728
	private float TargetBarPercent;

	// Token: 0x04006869 RID: 26729
	private float SourceBarPercent;

	// Token: 0x0400686A RID: 26730
	private float HpBufferAnimTime = -1f;

	// Token: 0x0400686B RID: 26731
	private float HpBufferAnimDuration;

	// Token: 0x0400686C RID: 26732
	private float LastValidMaxHp = -1f;

	// Token: 0x0400686D RID: 26733
	[Nullable(2)]
	private LevelSequencePlayer ShieldBarPlayer;

	// Token: 0x0400686E RID: 26734
	private bool ExistShieldBar;

	// Token: 0x0400686F RID: 26735
	[Nullable(2)]
	private LevelSequencePlayer DeadEffectPlayer;

	// Token: 0x04006870 RID: 26736
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SurvivorsRogueWeaponStateGrid, ISurvivorsWeaponGridData> WeaponGridList;

	// Token: 0x04006871 RID: 26737
	[Nullable(2)]
	public SurvivorsRogueRoleInfoGrid RoleGrid;

	// Token: 0x04006872 RID: 26738
	private readonly bool NeedRoleUpdate = true;

	// Token: 0x04006873 RID: 26739
	private readonly bool NeedWeaponUpdate = true;

	// Token: 0x0200831A RID: 33562
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402AC21 RID: 175137
		public const int RoleGrid = 0;

		// Token: 0x0402AC22 RID: 175138
		public const int WeaponLayout = 1;

		// Token: 0x0402AC23 RID: 175139
		public const int WeaponGrid = 2;

		// Token: 0x0402AC24 RID: 175140
		public const int RoleHpBar = 3;

		// Token: 0x0402AC25 RID: 175141
		public const int RoleShieldBar = 4;

		// Token: 0x0402AC26 RID: 175142
		public const int RoleHpNumber = 5;

		// Token: 0x0402AC27 RID: 175143
		public const int RoleHpBufferBar = 6;

		// Token: 0x0402AC28 RID: 175144
		public const int RoleHpMask = 7;

		// Token: 0x0402AC29 RID: 175145
		public const int RoleHpNumber2 = 8;

		// Token: 0x0402AC2A RID: 175146
		public const int RoleLowHpBar = 9;

		// Token: 0x0402AC2B RID: 175147
		public const int RoleHpBarItem = 10;
	}
}
