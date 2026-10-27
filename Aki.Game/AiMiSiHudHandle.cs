using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using Cysharp.Threading.Tasks;

// Token: 0x02001F28 RID: 7976
[NullableContext(1)]
[Nullable(0)]
public class AiMiSiHudHandle : HudUnitHandleBase
{
	// Token: 0x0600F5A0 RID: 62880 RVA: 0x003B4186 File Offset: 0x003B2386
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

	// Token: 0x0600F5A1 RID: 62881 RVA: 0x003B41BD File Offset: 0x003B23BD
	protected override void OnDestroyed()
	{
		if (this.HudUnit != null)
		{
			base.DestroyHudUnit(this.HudUnit);
			this.HudUnit = null;
		}
		this.ClearCurRoleData();
	}

	// Token: 0x0600F5A2 RID: 62882 RVA: 0x003B41E0 File Offset: 0x003B23E0
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRole));
	}

	// Token: 0x0600F5A3 RID: 62883 RVA: 0x003B41FE File Offset: 0x003B23FE
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRole));
	}

	// Token: 0x0600F5A4 RID: 62884 RVA: 0x003B421C File Offset: 0x003B241C
	private void OnChangeRole(int newEntityId, int oldEntityId)
	{
		this.RefreshCurRole();
		this.RefreshHudVisible();
		this.RefreshSprintAttribute();
		this.RefreshHp();
	}

	// Token: 0x0600F5A5 RID: 62885 RVA: 0x003B4238 File Offset: 0x003B2438
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

	// Token: 0x0600F5A6 RID: 62886 RVA: 0x003B46AC File Offset: 0x003B28AC
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

	// Token: 0x0600F5A7 RID: 62887 RVA: 0x003B47CC File Offset: 0x003B29CC
	private void RefreshHudVisible()
	{
		AiMiSiHudUnit hudUnit = this.HudUnit;
		if (hudUnit == null)
		{
			return;
		}
		hudUnit.SetTargetVisible(this.RoleData != null);
	}

	// Token: 0x0600F5A8 RID: 62888 RVA: 0x003B47E7 File Offset: 0x003B29E7
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

	// Token: 0x0600F5A9 RID: 62889 RVA: 0x003B4805 File Offset: 0x003B2A05
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

	// Token: 0x0600F5AA RID: 62890 RVA: 0x003B4823 File Offset: 0x003B2A23
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

	// Token: 0x0600F5AB RID: 62891 RVA: 0x003B4841 File Offset: 0x003B2A41
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

	// Token: 0x0600F5AC RID: 62892 RVA: 0x003B485F File Offset: 0x003B2A5F
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

	// Token: 0x0600F5AD RID: 62893 RVA: 0x003B487D File Offset: 0x003B2A7D
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

	// Token: 0x0600F5AE RID: 62894 RVA: 0x003B489B File Offset: 0x003B2A9B
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

	// Token: 0x0600F5AF RID: 62895 RVA: 0x003B48BC File Offset: 0x003B2ABC
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

	// Token: 0x0600F5B0 RID: 62896 RVA: 0x003B48DA File Offset: 0x003B2ADA
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

	// Token: 0x0600F5B1 RID: 62897 RVA: 0x003B48F8 File Offset: 0x003B2AF8
	private void OnBeHit(global::HitInformation hitData, HitContext hitContext)
	{
		AiMiSiHudUnit hudUnit = this.HudUnit;
		if (hudUnit == null)
		{
			return;
		}
		hudUnit.OnHurt();
	}

	// Token: 0x0600F5B2 RID: 62898 RVA: 0x003B490A File Offset: 0x003B2B0A
	private void OnSprintAttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
	{
		this.RefreshSprintAttribute();
	}

	// Token: 0x0600F5B3 RID: 62899 RVA: 0x003B4912 File Offset: 0x003B2B12
	private void OnHpChanged(EAttributeType attributeId, float newValue, float oldValue)
	{
		this.RefreshHp();
	}

	// Token: 0x0600F5B4 RID: 62900 RVA: 0x003B491C File Offset: 0x003B2B1C
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

	// Token: 0x0600F5B5 RID: 62901 RVA: 0x003B4978 File Offset: 0x003B2B78
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

	// Token: 0x0600F5B6 RID: 62902 RVA: 0x003B49D4 File Offset: 0x003B2BD4
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

	// Token: 0x0600F5B7 RID: 62903 RVA: 0x003B4A18 File Offset: 0x003B2C18
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

	// Token: 0x040071AF RID: 29103
	[Nullable(2)]
	private AiMiSiHudUnit HudUnit;

	// Token: 0x040071B0 RID: 29104
	[Nullable(2)]
	private BattleUiRoleData RoleData;

	// Token: 0x040071B1 RID: 29105
	[Nullable(2)]
	private BaseTagComponent TagComponent;

	// Token: 0x040071B2 RID: 29106
	private readonly List<ITagTask> TagTaskList = new List<ITagTask>();

	// Token: 0x040071B3 RID: 29107
	private readonly AiMiSiHudData Data = new AiMiSiHudData();
}
