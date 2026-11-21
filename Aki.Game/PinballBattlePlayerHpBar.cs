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

// Token: 0x020011D0 RID: 4560
[NullableContext(2)]
[Nullable(0)]
public class PinballBattlePlayerHpBar : PinballBattleHeadStateUiBase
{
	// Token: 0x1700123E RID: 4670
	// (get) Token: 0x0600B4F7 RID: 46327 RVA: 0x0035738E File Offset: 0x0035558E
	private PinballBattleSubController SubController
	{
		get
		{
			return KuroSimpleCombatController.Instance.CurSubController as PinballBattleSubController;
		}
	}

	// Token: 0x0600B4F8 RID: 46328 RVA: 0x003573A0 File Offset: 0x003555A0
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

	// Token: 0x0600B4F9 RID: 46329 RVA: 0x003574D0 File Offset: 0x003556D0
	protected override UniTask OnBeforeStartAsync()
	{
		PinballBattlePlayerHpBar.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PinballBattlePlayerHpBar.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B4FA RID: 46330 RVA: 0x00357514 File Offset: 0x00355714
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

	// Token: 0x0600B4FB RID: 46331 RVA: 0x003575DC File Offset: 0x003557DC
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

	// Token: 0x0600B4FC RID: 46332 RVA: 0x0035766C File Offset: 0x0035586C
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

	// Token: 0x0600B4FD RID: 46333 RVA: 0x00357726 File Offset: 0x00355926
	private float CalculateHpBarAnchorOffsetX(float hpPercent)
	{
		return MathUtils.Instance.Lerp(-this.HpBarMaxAnchorOffsetX, -2f, hpPercent);
	}

	// Token: 0x0600B4FE RID: 46334 RVA: 0x00357740 File Offset: 0x00355940
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

	// Token: 0x0600B4FF RID: 46335 RVA: 0x003577AC File Offset: 0x003559AC
	[NullableContext(1)]
	public void BindShieldDelegate(UKSC_AttrSet attrSet)
	{
		this.UnBindShieldDelegate();
		this.DelegateShieldChange = DelegateUtils.ToManualReleaseDelegate<FOnKSCAttrChange>(new Action<EKSC_AttrType, int>(this.OnShieldChange));
		attrSet.AssignAttrListen(EKSC_AttrType.Shield, this.DelegateShieldChange);
		attrSet.AssignAttrListen(EKSC_AttrType.ShieldMax, this.DelegateShieldChange);
		this.UpdateShieldBar(true);
	}

	// Token: 0x0600B500 RID: 46336 RVA: 0x003577F8 File Offset: 0x003559F8
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

	// Token: 0x0600B501 RID: 46337 RVA: 0x0035784A File Offset: 0x00355A4A
	private void OnShieldChange(EKSC_AttrType attrType, int value)
	{
		this.UpdateShieldBar(false);
	}

	// Token: 0x0600B502 RID: 46338 RVA: 0x00357854 File Offset: 0x00355A54
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

	// Token: 0x0600B503 RID: 46339 RVA: 0x003578C0 File Offset: 0x00355AC0
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

	// Token: 0x0600B504 RID: 46340 RVA: 0x00357954 File Offset: 0x00355B54
	private void OnRoleStateChange(int roleId, bool isAlive)
	{
		int? roleId2 = this.RoleId;
		if (roleId2.GetValueOrDefault() == roleId & roleId2 != null)
		{
			base.SetUiActive(isAlive);
		}
	}

	// Token: 0x0600B505 RID: 46341 RVA: 0x00357988 File Offset: 0x00355B88
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

	// Token: 0x0600B506 RID: 46342 RVA: 0x003579C4 File Offset: 0x00355BC4
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

	// Token: 0x040068B6 RID: 26806
	private const int HP_BAR_DEFAULT_OFFSET_X = -2;

	// Token: 0x040068B7 RID: 26807
	private const EKSC_AttrType CurShieldType = EKSC_AttrType.Shield;

	// Token: 0x040068B8 RID: 26808
	private const EKSC_AttrType MaxShieldType = EKSC_AttrType.ShieldMax;

	// Token: 0x040068B9 RID: 26809
	private int? RoleId;

	// Token: 0x040068BA RID: 26810
	private UUISprite HpBar;

	// Token: 0x040068BB RID: 26811
	private UUISprite ShieldBar;

	// Token: 0x040068BC RID: 26812
	private float HpBarMaxAnchorOffsetX;

	// Token: 0x040068BD RID: 26813
	private LguiFloatTween HpBarTween;

	// Token: 0x040068BE RID: 26814
	private LguiFloatTween ShieldBarTween;

	// Token: 0x040068BF RID: 26815
	private UKSC_AttrSet OwnerAttrSet;

	// Token: 0x040068C0 RID: 26816
	private FOnKSCAttrChange DelegateShieldChange;
}
