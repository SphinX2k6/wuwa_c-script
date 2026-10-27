using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.KuroSimpleCombat;
using CSharpScript.Game.KuroSimpleCombat.PB;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D0E RID: 7438
[NullableContext(2)]
[Nullable(0)]
public class PinballBattlePlayerHpBar : PinballBattleHeadStateUiBase
{
	// Token: 0x17001214 RID: 4628
	// (get) Token: 0x0600E0DA RID: 57562 RVA: 0x0034B95E File Offset: 0x00349B5E
	private PinballBattleSubController SubController
	{
		get
		{
			return KuroSimpleCombatController.Instance.CurSubController as PinballBattleSubController;
		}
	}

	// Token: 0x0600E0DB RID: 57563 RVA: 0x0034B970 File Offset: 0x00349B70
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600E0DC RID: 57564 RVA: 0x0034BAA0 File Offset: 0x00349CA0
	protected override UniTask OnBeforeStartAsync()
	{
		PinballBattlePlayerHpBar.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PinballBattlePlayerHpBar.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E0DD RID: 57565 RVA: 0x0034BAE4 File Offset: 0x00349CE4
	protected override void OnStart()
	{
		this.HpBar = base.GetSprite(4);
		this.ShieldBar = base.GetSprite(3);
		UUISprite hpBar = this.HpBar;
		this.HpBarMaxAnchorOffsetX = ((hpBar != null) ? hpBar.GetWidth() : 0f);
		FRotator frotator = new FRotator(180f, 0f, 0f);
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetUIRelativeRotation(frotator);
		}
		EventSystem.Instance.Add(EEventName.OnPinballRoleChargeMax, new Action<int>(this.OnRoleChargeMax));
		EventSystem.Instance.Add(EEventName.OnPinballRoleUseSkill, new Action<int>(this.OnRoleUseSkill));
		EventSystem.Instance.Add<int, bool>(EEventName.OnPinballRoleStateChange, new Action<int, bool>(this.OnRoleStateChange));
		base.OnStart();
	}

	// Token: 0x0600E0DE RID: 57566 RVA: 0x0034BBAC File Offset: 0x00349DAC
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		EventSystem.Instance.Remove(EEventName.OnPinballRoleChargeMax, new Action<int>(this.OnRoleChargeMax));
		EventSystem.Instance.Remove(EEventName.OnPinballRoleUseSkill, new Action<int>(this.OnRoleUseSkill));
		EventSystem.Instance.Remove<int, bool>(EEventName.OnPinballRoleStateChange, new Action<int, bool>(this.OnRoleStateChange));
		LguiFloatTween hpBarTween = this.HpBarTween;
		if (hpBarTween != null)
		{
			hpBarTween.Destroy();
		}
		LguiFloatTween shieldBarTween = this.ShieldBarTween;
		if (shieldBarTween != null)
		{
			shieldBarTween.Destroy();
		}
		this.UnBindShieldDelegate();
	}

	// Token: 0x0600E0DF RID: 57567 RVA: 0x0034BC3C File Offset: 0x00349E3C
	[NullableContext(1)]
	protected override void OnUpdateByHeadInfo(FKSC_HeadHpContext headInfo)
	{
		if (this.RoleId == null)
		{
			PinballBattleSubModel pinballBattleSubModel = KuroSimpleCombatController.Instance.CurSubModel as PinballBattleSubModel;
			this.RoleId = pinballBattleSubModel.GetRoleIdByEntityId(headInfo.EntityId);
			KscEntityHandle kscEntityHandle;
			pinballBattleSubModel.KscEntities.TryGetValue(headInfo.EntityId, out kscEntityHandle);
			UKSC_AttrSet uksc_AttrSet;
			if (kscEntityHandle == null)
			{
				uksc_AttrSet = null;
			}
			else
			{
				AKSC_Entity kscEntity = kscEntityHandle.KscEntity;
				if (kscEntity == null)
				{
					uksc_AttrSet = null;
				}
				else
				{
					UKSC_SkillComp skillComp_ = kscEntity.SkillComp_;
					uksc_AttrSet = ((skillComp_ != null) ? skillComp_.AttrSet_ : null);
				}
			}
			UKSC_AttrSet uksc_AttrSet2 = uksc_AttrSet;
			this.OwnerAttrSet = uksc_AttrSet2;
			if (uksc_AttrSet2 != null)
			{
				this.BindShieldDelegate(uksc_AttrSet2);
			}
		}
		base.UpdateHeadStateLocation(headInfo.Location);
		float hpPercent = (float)headInfo.CurHp / (float)headInfo.MaxHp;
		float targetAnchorOffsetX = this.CalculateHpBarAnchorOffsetX(hpPercent);
		this.PlayHpBarTween(targetAnchorOffsetX, 0.3f);
	}

	// Token: 0x0600E0E0 RID: 57568 RVA: 0x0034BCF6 File Offset: 0x00349EF6
	private float CalculateHpBarAnchorOffsetX(float hpPercent)
	{
		return MathUtils.Instance.Lerp(-this.HpBarMaxAnchorOffsetX, -2f, hpPercent);
	}

	// Token: 0x0600E0E1 RID: 57569 RVA: 0x0034BD10 File Offset: 0x00349F10
	private void PlayHpBarTween(float targetAnchorOffsetX, float duration = 0.3f)
	{
		if (this.HpBar == null)
		{
			return;
		}
		if (this.HpBarTween == null)
		{
			this.HpBarTween = new LguiFloatTween();
		}
		float anchorOffsetX = this.HpBar.GetAnchorOffsetX();
		if (Math.Abs(anchorOffsetX - targetAnchorOffsetX) < 0.01f)
		{
			return;
		}
		this.HpBarTween.BindUpdateTween(delegate(float value)
		{
			UUISprite hpBar = this.HpBar;
			if (hpBar == null)
			{
				return;
			}
			hpBar.SetAnchorOffsetX(value);
		});
		this.HpBarTween.PlayTween(anchorOffsetX, targetAnchorOffsetX, duration, null);
	}

	// Token: 0x0600E0E2 RID: 57570 RVA: 0x0034BD7C File Offset: 0x00349F7C
	[NullableContext(1)]
	public void BindShieldDelegate(UKSC_AttrSet attrSet)
	{
		this.UnBindShieldDelegate();
		this.DelegateShieldChange = DelegateUtils.ToManualReleaseDelegate<FOnKSCAttrChange>(new Action<EKSC_AttrType, int>(this.OnShieldChange));
		attrSet.AssignAttrListen(EKSC_AttrType.Shield, this.DelegateShieldChange);
		attrSet.AssignAttrListen(EKSC_AttrType.ShieldMax, this.DelegateShieldChange);
		this.UpdateShieldBar(true);
	}

	// Token: 0x0600E0E3 RID: 57571 RVA: 0x0034BDC8 File Offset: 0x00349FC8
	public void UnBindShieldDelegate()
	{
		if (this.OwnerAttrSet != null)
		{
			this.OwnerAttrSet.RemoveAttrListen(EKSC_AttrType.Shield, this.DelegateShieldChange);
			this.OwnerAttrSet.RemoveAttrListen(EKSC_AttrType.ShieldMax, this.DelegateShieldChange);
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<EKSC_AttrType, int>(this.OnShieldChange));
			this.DelegateShieldChange = null;
		}
	}

	// Token: 0x0600E0E4 RID: 57572 RVA: 0x0034BE1A File Offset: 0x0034A01A
	private void OnShieldChange(EKSC_AttrType attrType, int value)
	{
		this.UpdateShieldBar(false);
	}

	// Token: 0x0600E0E5 RID: 57573 RVA: 0x0034BE24 File Offset: 0x0034A024
	private void PlayShieldBarTween(float targetFillAmount, float duration = 0.3f)
	{
		if (this.ShieldBar == null)
		{
			return;
		}
		if (this.ShieldBarTween == null)
		{
			this.ShieldBarTween = new LguiFloatTween();
		}
		float fillAmount = this.ShieldBar.GetFillAmount();
		if (Math.Abs(fillAmount - targetFillAmount) < 0.001f)
		{
			return;
		}
		this.ShieldBarTween.BindUpdateTween(delegate(float value)
		{
			UUISprite shieldBar = this.ShieldBar;
			if (shieldBar == null)
			{
				return;
			}
			shieldBar.SetFillAmount(value);
		});
		this.ShieldBarTween.PlayTween(fillAmount, targetFillAmount, duration, null);
	}

	// Token: 0x0600E0E6 RID: 57574 RVA: 0x0034BE90 File Offset: 0x0034A090
	private void UpdateShieldBar(bool disableTween = false)
	{
		if (this.OwnerAttrSet == null || this.ShieldBar == null)
		{
			return;
		}
		TMap<EKSC_AttrType, int> attrs_ = this.OwnerAttrSet.Attrs_;
		float valueOrDefault = (float)((attrs_ != null) ? attrs_.GetValueOrNull(EKSC_AttrType.Shield) : null).GetValueOrDefault();
		TMap<EKSC_AttrType, int> attrs_2 = this.OwnerAttrSet.Attrs_;
		int valueOrDefault2 = ((attrs_2 != null) ? attrs_2.GetValueOrNull(EKSC_AttrType.ShieldMax) : null).GetValueOrDefault(1);
		float num = valueOrDefault / (float)valueOrDefault2;
		if (disableTween)
		{
			this.ShieldBar.SetFillAmount(num);
			return;
		}
		this.PlayShieldBarTween(num, 0.3f);
	}

	// Token: 0x0600E0E7 RID: 57575 RVA: 0x0034BF24 File Offset: 0x0034A124
	private void OnRoleStateChange(int roleId, bool isAlive)
	{
		int? roleId2 = this.RoleId;
		if (roleId2.GetValueOrDefault() == roleId & roleId2 != null)
		{
			base.SetUiActive(isAlive);
		}
	}

	// Token: 0x0600E0E8 RID: 57576 RVA: 0x0034BF58 File Offset: 0x0034A158
	private void OnRoleChargeMax(int roleId)
	{
		int? roleId2 = this.RoleId;
		if (roleId2.GetValueOrDefault() == roleId & roleId2 != null)
		{
			PinballBattleSubController subController = this.SubController;
			if (subController == null)
			{
				return;
			}
			subController.AddRoleChargeMaxEffectBuff(roleId);
		}
	}

	// Token: 0x0600E0E9 RID: 57577 RVA: 0x0034BF94 File Offset: 0x0034A194
	private void OnRoleUseSkill(int roleId)
	{
		int? roleId2 = this.RoleId;
		if (roleId2.GetValueOrDefault() == roleId & roleId2 != null)
		{
			PinballBattleSubController subController = this.SubController;
			if (subController == null)
			{
				return;
			}
			subController.RemoveRoleChargeMaxEffectBuff(roleId);
		}
	}

	// Token: 0x040067D7 RID: 26583
	private const int HP_BAR_DEFAULT_OFFSET_X = -2;

	// Token: 0x040067D8 RID: 26584
	private const EKSC_AttrType CurShieldType = EKSC_AttrType.Shield;

	// Token: 0x040067D9 RID: 26585
	private const EKSC_AttrType MaxShieldType = EKSC_AttrType.ShieldMax;

	// Token: 0x040067DA RID: 26586
	private int? RoleId;

	// Token: 0x040067DB RID: 26587
	private UUISprite HpBar;

	// Token: 0x040067DC RID: 26588
	private UUISprite ShieldBar;

	// Token: 0x040067DD RID: 26589
	private float HpBarMaxAnchorOffsetX;

	// Token: 0x040067DE RID: 26590
	private LguiFloatTween HpBarTween;

	// Token: 0x040067DF RID: 26591
	private LguiFloatTween ShieldBarTween;

	// Token: 0x040067E0 RID: 26592
	private UKSC_AttrSet OwnerAttrSet;

	// Token: 0x040067E1 RID: 26593
	private FOnKSCAttrChange DelegateShieldChange;
}
