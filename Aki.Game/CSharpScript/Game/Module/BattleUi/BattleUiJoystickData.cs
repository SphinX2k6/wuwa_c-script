using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C91 RID: 23697
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiJoystickData
	{
		// Token: 0x0603BDA1 RID: 245153 RVA: 0x00E4B888 File Offset: 0x00E49A88
		public void Init()
		{
		}

		// Token: 0x0603BDA2 RID: 245154 RVA: 0x00E4B88A File Offset: 0x00E49A8A
		public void Clear()
		{
			this.ClearTasks();
		}

		// Token: 0x0603BDA3 RID: 245155 RVA: 0x00E4B892 File Offset: 0x00E49A92
		public void OnLeaveLevel()
		{
			this.ClearTasks();
		}

		// Token: 0x0603BDA4 RID: 245156 RVA: 0x00E4B89C File Offset: 0x00E49A9C
		public void EnterVehicle(VehiclePassengerInfo info)
		{
			if (!info.IsRolePassenger(true))
			{
				return;
			}
			CreatureModel instance = CreatureModel.Instance;
			Entity vehicleEntity = info.VehicleEntity;
			EntityHandle entityById = instance.GetEntityById((vehicleEntity != null) ? vehicleEntity.Id : 0);
			if (entityById != null && entityById.Valid)
			{
				BaseTagComponent component = entityById.Entity.GetComponent<BaseTagComponent>();
				foreach (string tagName in ConfigCommonParamById.GetStringArrayConfig("VehicleRoundJoystickTriggerTags"))
				{
					int tagIdByName = GameplayTagUtils.GetTagIdByName(tagName);
					if (component.HasTag(tagIdByName))
					{
						this.ForceRoundJoystickTagSet.Add(tagIdByName);
					}
					ITagTask item = component.ListenForTagAddOrRemove(new int?(tagIdByName), new BaseTagComponent.TTagSwitchedCallback(this.OnEnableRoundJoystick), null);
					this.SwitchJoystickTasks.Add(item);
				}
			}
			this.RefreshMotorMobileButtonLayout(null);
		}

		// Token: 0x0603BDA5 RID: 245157 RVA: 0x00E4B97C File Offset: 0x00E49B7C
		public void LeaveVehicle(VehiclePassengerInfo info)
		{
			this.ClearTasks();
		}

		// Token: 0x0603BDA6 RID: 245158 RVA: 0x00E4B984 File Offset: 0x00E49B84
		private void OnEnableRoundJoystick(int tagId, bool tagExists)
		{
			if (tagExists)
			{
				this.ForceRoundJoystickTagSet.Add(tagId);
			}
			else
			{
				this.ForceRoundJoystickTagSet.Remove(tagId);
			}
			this.RefreshMotorcycleRoundJoystick(null);
		}

		// Token: 0x0603BDA7 RID: 245159 RVA: 0x00E4B9C0 File Offset: 0x00E49BC0
		public void RefreshMotorcycleRoundJoystick(bool? isRoundJoystickButtonLayout = null)
		{
			bool motorMobileButtonLayout = this.GetMotorMobileButtonLayout(isRoundJoystickButtonLayout);
			bool isRoundJoystick = this.ForceRoundJoystickTagSet.Count > 0 || motorMobileButtonLayout;
			BattleUiModel.Instance.MotorcycleData.SetIsRoundJoystick(isRoundJoystick);
		}

		// Token: 0x0603BDA8 RID: 245160 RVA: 0x00E4B9F8 File Offset: 0x00E49BF8
		public void RefreshMotorMobileSkillButtonLayout(bool? isRoundJoystickButtonLayout = null)
		{
			bool motorMobileButtonLayout = this.GetMotorMobileButtonLayout(isRoundJoystickButtonLayout);
			BattleUiModel.Instance.MotorcycleData.SetIsRoundJoystickButtonLayout(motorMobileButtonLayout);
		}

		// Token: 0x0603BDA9 RID: 245161 RVA: 0x00E4BA1D File Offset: 0x00E49C1D
		public void RefreshMotorMobileButtonLayout(bool? isRoundJoystickButtonLayout = null)
		{
			this.RefreshMotorMobileSkillButtonLayout(isRoundJoystickButtonLayout);
			this.RefreshMotorcycleRoundJoystick(isRoundJoystickButtonLayout);
		}

		// Token: 0x0603BDAA RID: 245162 RVA: 0x00E4BA30 File Offset: 0x00E49C30
		private bool GetMotorMobileButtonLayout(bool? isRoundJoystickButtonLayout = null)
		{
			if (isRoundJoystickButtonLayout != null)
			{
				return isRoundJoystickButtonLayout.Value;
			}
			int? currentValue = GameSettingsManager.Instance.GetCurrentValue(EFunction.MotorMobileButtonLayout, true, true);
			int num = 0;
			return currentValue.GetValueOrDefault() == num & currentValue != null;
		}

		// Token: 0x0603BDAB RID: 245163 RVA: 0x00E4BA74 File Offset: 0x00E49C74
		private void ClearTasks()
		{
			foreach (ITagTask tagTask in this.SwitchJoystickTasks)
			{
				tagTask.EndTask();
			}
			this.SwitchJoystickTasks.Clear();
			this.ForceRoundJoystickTagSet.Clear();
		}

		// Token: 0x0401F34B RID: 127819
		private List<ITagTask> SwitchJoystickTasks = new List<ITagTask>();

		// Token: 0x0401F34C RID: 127820
		private HashSet<int> ForceRoundJoystickTagSet = new HashSet<int>();
	}
}
