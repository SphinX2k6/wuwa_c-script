using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BattleUi.SpecialRoleData
{
	// Token: 0x02005E53 RID: 24147
	public class BattleUiSpecialRoleDataSuoMing : BattleUiSpecialRoleDataBase
	{
		// Token: 0x0603D682 RID: 251522 RVA: 0x00ED00B8 File Offset: 0x00ECE2B8
		protected override void OnInit()
		{
			base.OnInit();
			if (this.RoleData != null)
			{
				this.RoleData.CheckEnergyTag = true;
				this.RoleData.ListenForTagSignificantChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1SuomingMd10011.大招状态.大招解锁"], new BaseTagComponent.TTagSwitchedCallback(this.OnEnergyTagChanged), false);
				BaseAttributeComponent attributeComponent = this.RoleData.AttributeComponent;
				if (attributeComponent != null)
				{
					attributeComponent.AddListener(EAttributeType.Energy, new Action<EAttributeType, float, float>(this.OnEnergyChanged), null);
				}
				BaseAttributeComponent attributeComponent2 = this.RoleData.AttributeComponent;
				if (attributeComponent2 != null)
				{
					attributeComponent2.AddListener(EAttributeType.EnergyMax, new Action<EAttributeType, float, float>(this.OnEnergyChanged), null);
				}
			}
			this.RefreshSuperSkillState();
		}

		// Token: 0x0603D683 RID: 251523 RVA: 0x00ED0158 File Offset: 0x00ECE358
		protected override void OnClear()
		{
			BattleUiRoleData roleData = this.RoleData;
			if (roleData != null)
			{
				BaseAttributeComponent attributeComponent = roleData.AttributeComponent;
				if (attributeComponent != null)
				{
					attributeComponent.RemoveListener(EAttributeType.Energy, new Action<EAttributeType, float, float>(this.OnEnergyChanged));
				}
			}
			BattleUiRoleData roleData2 = this.RoleData;
			if (roleData2 == null)
			{
				return;
			}
			BaseAttributeComponent attributeComponent2 = roleData2.AttributeComponent;
			if (attributeComponent2 == null)
			{
				return;
			}
			attributeComponent2.RemoveListener(EAttributeType.EnergyMax, new Action<EAttributeType, float, float>(this.OnEnergyChanged));
		}

		// Token: 0x0603D684 RID: 251524 RVA: 0x00ED01B9 File Offset: 0x00ECE3B9
		private void OnEnergyTagChanged(int tagId, bool tagExist)
		{
			this.RefreshSuperSkillState();
		}

		// Token: 0x0603D685 RID: 251525 RVA: 0x00ED01C1 File Offset: 0x00ECE3C1
		private void OnEnergyChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.RefreshSuperSkillState();
		}

		// Token: 0x0603D686 RID: 251526 RVA: 0x00ED01CC File Offset: 0x00ECE3CC
		private void RefreshSuperSkillState()
		{
			BattleUiRoleData roleData = this.RoleData;
			BaseAttributeComponent baseAttributeComponent = (roleData != null) ? roleData.AttributeComponent : null;
			BattleUiRoleData roleData2 = this.RoleData;
			BaseTagComponent baseTagComponent = (roleData2 != null) ? roleData2.GameplayTagComponent : null;
			if (baseAttributeComponent == null || baseTagComponent == null)
			{
				BattleUiRoleData roleData3 = this.RoleData;
				if (roleData3 == null)
				{
					return;
				}
				roleData3.SetHasEnergyTag(false);
				return;
			}
			else
			{
				float currentValue = baseAttributeComponent.GetCurrentValue(EAttributeType.Energy);
				float currentValue2 = baseAttributeComponent.GetCurrentValue(EAttributeType.EnergyMax);
				bool flag = baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1SuomingMd10011.大招状态.大招解锁"]);
				BattleUiRoleData roleData4 = this.RoleData;
				if (roleData4 == null)
				{
					return;
				}
				roleData4.SetHasEnergyTag(flag && currentValue >= currentValue2);
				return;
			}
		}
	}
}
