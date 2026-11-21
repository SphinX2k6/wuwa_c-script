using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using Cysharp.Threading.Tasks;

// Token: 0x020013EA RID: 5098
[NullableContext(1)]
[Nullable(0)]
public class AiMiSiHudHandle : HudUnitHandleBase
{
	// Token: 0x0600C9BF RID: 51647 RVA: 0x003BFC72 File Offset: 0x003BDE72
	protected override void OnInitialize()
	{
		base.OnInitialize();
		this.RefreshCurRole();
		base.NewHudUnit<AiMiSiHudUnit>(typeof(AiMiSiHudUnit), "UiItem_AimisiHUD", false, false).ContinueWith(delegate(AiMiSiHudUnit aimUnit)
		{
			this.HudUnit = aimUnit;
			if (this.HudUnit == null)
			{
				return;
			}
			this.HudUnit.InitData(this.Data);
			this.RefreshHudVisible();
			this.RefreshSprintAttribute();
			this.RefreshHp();
		});
	}

	// Token: 0x0600C9C0 RID: 51648 RVA: 0x003BFCA9 File Offset: 0x003BDEA9
	protected override void OnDestroyed()
	{
		if (this.HudUnit != null)
		{
			base.DestroyHudUnit(this.HudUnit);
			this.HudUnit = null;
		}
		this.ClearCurRoleData();
	}

	// Token: 0x0600C9C1 RID: 51649 RVA: 0x003BFCCC File Offset: 0x003BDECC
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRole));
	}

	// Token: 0x0600C9C2 RID: 51650 RVA: 0x003BFCEA File Offset: 0x003BDEEA
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRole));
	}

	// Token: 0x0600C9C3 RID: 51651 RVA: 0x003BFD08 File Offset: 0x003BDF08
	private void OnChangeRole(int newEntityId, int oldEntityId)
	{
		this.RefreshCurRole();
		this.RefreshHudVisible();
		this.RefreshSprintAttribute();
		this.RefreshHp();
	}

	// Token: 0x0600C9C4 RID: 51652 RVA: 0x003BFD24 File Offset: 0x003BDF24
	private void RefreshCurRole()
	{
		BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
		if (curRoleData != null)
		{
			BattleUiRoleData battleUiRoleData = curRoleData;
			if (battleUiRoleData.RoleConfig != null && battleUiRoleData.RoleConfig.GetValueOrDefault().Id == 1210)
			{
				this.ClearCurRoleData();
				this.RoleData = curRoleData;
				this.TagComponent = curRoleData.GameplayTagComponent;
				this.Data.IsForeground = true;
				if (this.TagComponent != null)
				{
					this.ListenForTagAddOrRemove(GameplayTagDefine.EGameplayTagId["角色.AimisiMd10011.状态.主控机甲"], new Action<int, bool>(this.OnMechanismTagChanged));
					this.ListenForTagAddOrRemove(GameplayTagDefine.EGameplayTagId["角色.AimisiMd10011.事件.可触发合击"], new Action<int, bool>(this.OnJointTagChanged));
					this.ListenForTagAddOrRemove(GameplayTagDefine.EGameplayTagId["角色.AimisiMd10011.事件.强化合击可释放"], new Action<int, bool>(this.OnSpecialJointTagChanged));
					this.ListenForTagAddOrRemove(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.悬浮.冲刺移动"], new Action<int, bool>(this.OnSprintTagChanged));
					this.ListenForTagAddOrRemove(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"], new Action<int, bool>(this.OnFightTagChanged));
					this.ListenForTagAddOrRemove(GameplayTagDefine.EGameplayTagId["角色.Common.双模式.模式1"], new Action<int, bool>(this.OnModeTagChanged));
					this.ListenForTagAddOrRemove(GameplayTagDefine.EGameplayTagId["角色.AimisiMd10011.机制标记.悬浮贴地中标记"], new Action<int, bool>(this.OnAirTagChanged));
					this.ListenForTagAddOrRemove(GameplayTagDefine.EGameplayTagId["角色.AimisiMd10011.状态.解锁炮大招前置条件"], new Action<int, bool>(this.OnUltraBuffTagChanged));
					this.ListenForTagAddOrRemove(GameplayTagDefine.EGameplayTagId["角色.AimisiMd10011.状态.空冲刺能量惩罚"], new Action<int, bool>(this.OnEmptyEnduranceTagChanged));
					this.Data.IsMechanism = this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.AimisiMd10011.状态.主控机甲"]);
					this.Data.IsJoint = this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.AimisiMd10011.事件.可触发合击"]);
					this.Data.IsSpecialJoint = this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.AimisiMd10011.事件.强化合击可释放"]);
					this.Data.IsSprint = this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.悬浮.冲刺移动"]);
					this.Data.InFight = this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]);
					this.Data.IsModeOne = this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.双模式.模式1"]);
					this.Data.InAir = !this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.AimisiMd10011.机制标记.悬浮贴地中标记"]);
					this.Data.IsUltraBuff = this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.AimisiMd10011.状态.解锁炮大招前置条件"]);
					this.Data.EmptyEndurance = this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.AimisiMd10011.状态.空冲刺能量惩罚"]);
					AiMiSiHudUnit hudUnit = this.HudUnit;
					if (hudUnit != null)
					{
						hudUnit.RefreshModeIcon();
					}
				}
				else
				{
					this.Data.IsMechanism = false;
					this.Data.IsJoint = false;
					this.Data.IsSpecialJoint = false;
					this.Data.IsSprint = false;
					this.Data.InFight = false;
					this.Data.IsModeOne = false;
					this.Data.InAir = false;
					this.Data.IsUltraBuff = false;
					this.Data.EmptyEndurance = false;
				}
				BattleUiRoleData roleData = this.RoleData;
				WorldEntity worldEntity;
				if (roleData == null)
				{
					worldEntity = null;
				}
				else
				{
					EntityHandle entityHandle = roleData.EntityHandle;
					worldEntity = ((entityHandle != null) ? entityHandle.Entity : null);
				}
				WorldEntity worldEntity2 = worldEntity;
				if (worldEntity2 != null && !EventSystem.Instance.HasWithTarget<global::HitInformation, HitContext>(worldEntity2, EEventName.CharBeHitLocal, new Action<global::HitInformation, HitContext>(this.OnBeHit)))
				{
					EventSystem.Instance.AddWithTarget<global::HitInformation, HitContext>(worldEntity2, EEventName.CharBeHitLocal, new Action<global::HitInformation, HitContext>(this.OnBeHit));
				}
				BattleUiRoleData roleData2 = this.RoleData;
				BaseAttributeComponent baseAttributeComponent = (roleData2 != null) ? roleData2.AttributeComponent : null;
				if (baseAttributeComponent != null)
				{
					baseAttributeComponent.AddListener(EAttributeType.SpecialEnergy5, new Action<EAttributeType, float, float>(this.OnSprintAttributeChanged), null);
				}
				if (baseAttributeComponent != null)
				{
					baseAttributeComponent.AddListener(EAttributeType.SpecialEnergy5Max, new Action<EAttributeType, float, float>(this.OnSprintAttributeChanged), null);
				}
				if (baseAttributeComponent != null)
				{
					baseAttributeComponent.AddListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.OnHpChanged), null);
				}
				if (baseAttributeComponent != null)
				{
					baseAttributeComponent.AddListener(EAttributeType.LifeMax, new Action<EAttributeType, float, float>(this.OnHpChanged), null);
				}
				AiMiSiHudUnit hudUnit2 = this.HudUnit;
				if (hudUnit2 == null)
				{
					return;
				}
				hudUnit2.MarkDataDirty();
				return;
			}
		}
		this.ClearCurRoleData();
		this.Data.IsForeground = false;
		AiMiSiHudUnit hudUnit3 = this.HudUnit;
		if (hudUnit3 == null)
		{
			return;
		}
		hudUnit3.MarkDataDirty();
	}

	// Token: 0x0600C9C5 RID: 51653 RVA: 0x003C0198 File Offset: 0x003BE398
	private void ClearCurRoleData()
	{
		if (this.RoleData != null)
		{
			EntityHandle entityHandle = this.RoleData.EntityHandle;
			WorldEntity worldEntity = (entityHandle != null) ? entityHandle.Entity : null;
			if (worldEntity != null)
			{
				EventSystem.Instance.RemoveWithTarget<global::HitInformation, HitContext>(worldEntity, EEventName.CharBeHitLocal, new Action<global::HitInformation, HitContext>(this.OnBeHit));
			}
			BaseAttributeComponent attributeComponent = this.RoleData.AttributeComponent;
			if (attributeComponent != null)
			{
				attributeComponent.RemoveListener(EAttributeType.SpecialEnergy5, new Action<EAttributeType, float, float>(this.OnSprintAttributeChanged));
			}
			if (attributeComponent != null)
			{
				attributeComponent.RemoveListener(EAttributeType.SpecialEnergy5Max, new Action<EAttributeType, float, float>(this.OnSprintAttributeChanged));
			}
			if (attributeComponent != null)
			{
				attributeComponent.RemoveListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.OnHpChanged));
			}
			if (attributeComponent != null)
			{
				attributeComponent.RemoveListener(EAttributeType.LifeMax, new Action<EAttributeType, float, float>(this.OnHpChanged));
			}
			this.RoleData = null;
		}
		this.TagComponent = null;
		foreach (ITagTask tagTask in this.TagTaskList)
		{
			tagTask.EndTask();
		}
		this.TagTaskList.Clear();
	}

	// Token: 0x0600C9C6 RID: 51654 RVA: 0x003C02B8 File Offset: 0x003BE4B8
	private void RefreshHudVisible()
	{
		AiMiSiHudUnit hudUnit = this.HudUnit;
		if (hudUnit == null)
		{
			return;
		}
		hudUnit.SetTargetVisible(this.RoleData != null);
	}

	// Token: 0x0600C9C7 RID: 51655 RVA: 0x003C02D3 File Offset: 0x003BE4D3
	private void OnMechanismTagChanged(int tagId, bool tagExist)
	{
		this.Data.IsMechanism = tagExist;
		AiMiSiHudUnit hudUnit = this.HudUnit;
		if (hudUnit == null)
		{
			return;
		}
		hudUnit.MarkDataDirty();
	}

	// Token: 0x0600C9C8 RID: 51656 RVA: 0x003C02F1 File Offset: 0x003BE4F1
	private void OnJointTagChanged(int tagId, bool tagExist)
	{
		this.Data.IsJoint = tagExist;
		AiMiSiHudUnit hudUnit = this.HudUnit;
		if (hudUnit == null)
		{
			return;
		}
		hudUnit.MarkDataDirty();
	}

	// Token: 0x0600C9C9 RID: 51657 RVA: 0x003C030F File Offset: 0x003BE50F
	private void OnSpecialJointTagChanged(int tagId, bool tagExist)
	{
		this.Data.IsSpecialJoint = tagExist;
		AiMiSiHudUnit hudUnit = this.HudUnit;
		if (hudUnit == null)
		{
			return;
		}
		hudUnit.MarkDataDirty();
	}

	// Token: 0x0600C9CA RID: 51658 RVA: 0x003C032D File Offset: 0x003BE52D
	private void OnSprintTagChanged(int tagId, bool tagExist)
	{
		this.Data.IsSprint = tagExist;
		AiMiSiHudUnit hudUnit = this.HudUnit;
		if (hudUnit == null)
		{
			return;
		}
		hudUnit.MarkDataDirty();
	}

	// Token: 0x0600C9CB RID: 51659 RVA: 0x003C034B File Offset: 0x003BE54B
	private void OnFightTagChanged(int tagId, bool tagExist)
	{
		this.Data.InFight = tagExist;
		AiMiSiHudUnit hudUnit = this.HudUnit;
		if (hudUnit == null)
		{
			return;
		}
		hudUnit.MarkDataDirty();
	}

	// Token: 0x0600C9CC RID: 51660 RVA: 0x003C0369 File Offset: 0x003BE569
	private void OnModeTagChanged(int tagId, bool tagExist)
	{
		this.Data.IsModeOne = tagExist;
		AiMiSiHudUnit hudUnit = this.HudUnit;
		if (hudUnit == null)
		{
			return;
		}
		hudUnit.RefreshModeIcon();
	}

	// Token: 0x0600C9CD RID: 51661 RVA: 0x003C0387 File Offset: 0x003BE587
	private void OnAirTagChanged(int tagId, bool tagExist)
	{
		this.Data.InAir = !tagExist;
		AiMiSiHudUnit hudUnit = this.HudUnit;
		if (hudUnit == null)
		{
			return;
		}
		hudUnit.MarkDataDirty();
	}

	// Token: 0x0600C9CE RID: 51662 RVA: 0x003C03A8 File Offset: 0x003BE5A8
	private void OnUltraBuffTagChanged(int tagId, bool tagExist)
	{
		this.Data.IsUltraBuff = tagExist;
		AiMiSiHudUnit hudUnit = this.HudUnit;
		if (hudUnit == null)
		{
			return;
		}
		hudUnit.MarkDataDirty();
	}

	// Token: 0x0600C9CF RID: 51663 RVA: 0x003C03C6 File Offset: 0x003BE5C6
	private void OnEmptyEnduranceTagChanged(int tagId, bool tagExist)
	{
		this.Data.EmptyEndurance = tagExist;
		AiMiSiHudUnit hudUnit = this.HudUnit;
		if (hudUnit == null)
		{
			return;
		}
		hudUnit.MarkDataDirty();
	}

	// Token: 0x0600C9D0 RID: 51664 RVA: 0x003C03E4 File Offset: 0x003BE5E4
	private void OnBeHit(global::HitInformation hitData, HitContext hitContext)
	{
		AiMiSiHudUnit hudUnit = this.HudUnit;
		if (hudUnit == null)
		{
			return;
		}
		hudUnit.OnHurt();
	}

	// Token: 0x0600C9D1 RID: 51665 RVA: 0x003C03F6 File Offset: 0x003BE5F6
	private void OnSprintAttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
	{
		this.RefreshSprintAttribute();
	}

	// Token: 0x0600C9D2 RID: 51666 RVA: 0x003C03FE File Offset: 0x003BE5FE
	private void OnHpChanged(EAttributeType attributeId, float newValue, float oldValue)
	{
		this.RefreshHp();
	}

	// Token: 0x0600C9D3 RID: 51667 RVA: 0x003C0408 File Offset: 0x003BE608
	private void RefreshSprintAttribute()
	{
		if (this.HudUnit == null)
		{
			return;
		}
		BattleUiRoleData roleData = this.RoleData;
		BaseAttributeComponent baseAttributeComponent = (roleData != null) ? roleData.AttributeComponent : null;
		if (baseAttributeComponent != null)
		{
			float enduranceProgress = 0f;
			float currentValue = baseAttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy5);
			float currentValue2 = baseAttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy5Max);
			if (currentValue2 > 0f)
			{
				enduranceProgress = currentValue / currentValue2;
			}
			this.HudUnit.SetEnduranceProgress(enduranceProgress);
		}
	}

	// Token: 0x0600C9D4 RID: 51668 RVA: 0x003C0464 File Offset: 0x003BE664
	private void RefreshHp()
	{
		if (this.HudUnit == null)
		{
			return;
		}
		float hpPercent = 0f;
		BattleUiRoleData roleData = this.RoleData;
		BaseAttributeComponent baseAttributeComponent = (roleData != null) ? roleData.AttributeComponent : null;
		if (baseAttributeComponent != null)
		{
			float currentValue = baseAttributeComponent.GetCurrentValue(EAttributeType.Life);
			float currentValue2 = baseAttributeComponent.GetCurrentValue(EAttributeType.LifeMax);
			if (currentValue2 > 0f)
			{
				hpPercent = currentValue / currentValue2;
			}
		}
		this.HudUnit.SetHpPercent(hpPercent);
	}

	// Token: 0x0600C9D5 RID: 51669 RVA: 0x003C04C0 File Offset: 0x003BE6C0
	private void ListenForTagAddOrRemove(int tagId, Action<int, bool> callback)
	{
		if (this.TagComponent == null)
		{
			return;
		}
		ITagTask tagTask = this.TagComponent.ListenForTagAddOrRemove(new int?(tagId), new BaseTagComponent.TTagSwitchedCallback(callback.Invoke), null);
		if (tagTask != null)
		{
			this.TagTaskList.Add(tagTask);
		}
	}

	// Token: 0x0600C9D6 RID: 51670 RVA: 0x003C0504 File Offset: 0x003BE704
	public override void OnInputControllerChanged(EInputControllerType last, EInputControllerType now)
	{
		if (this.HudUnit == null)
		{
			return;
		}
		if (last != now && (last == EInputControllerType.Touch || now == EInputControllerType.Touch))
		{
			this.HudUnit.RefreshKeyNode();
			this.HudUnit.RefreshRotateMachineSpeed();
		}
	}

	// Token: 0x04007290 RID: 29328
	[Nullable(2)]
	private AiMiSiHudUnit HudUnit;

	// Token: 0x04007291 RID: 29329
	[Nullable(2)]
	private BattleUiRoleData RoleData;

	// Token: 0x04007292 RID: 29330
	[Nullable(2)]
	private BaseTagComponent TagComponent;

	// Token: 0x04007293 RID: 29331
	private readonly List<ITagTask> TagTaskList = new List<ITagTask>();

	// Token: 0x04007294 RID: 29332
	private readonly AiMiSiHudData Data = new AiMiSiHudData();
}
