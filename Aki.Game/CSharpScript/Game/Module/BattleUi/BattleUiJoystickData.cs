using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C73 RID: 19571
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiJoystickData
	{
		// Token: 0x06030CF2 RID: 199922 RVA: 0x00D9BE10 File Offset: 0x00D9A010
		public void Init()
		{
		}

		// Token: 0x06030CF3 RID: 199923 RVA: 0x00D9BE12 File Offset: 0x00D9A012
		public void Clear()
		{
			this.ForceWalkRunRate = -1f;
			this.ClearTasks();
		}

		// Token: 0x06030CF4 RID: 199924 RVA: 0x00D9BE25 File Offset: 0x00D9A025
		public void OnLeaveLevel()
		{
			this.ClearTasks();
		}

		// Token: 0x06030CF5 RID: 199925 RVA: 0x00D9BE30 File Offset: 0x00D9A030
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

		// Token: 0x06030CF6 RID: 199926 RVA: 0x00D9BF10 File Offset: 0x00D9A110
		public void LeaveVehicle(VehiclePassengerInfo info)
		{
			this.ClearTasks();
		}

		// Token: 0x06030CF7 RID: 199927 RVA: 0x00D9BF18 File Offset: 0x00D9A118
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

		// Token: 0x06030CF8 RID: 199928 RVA: 0x00D9BF54 File Offset: 0x00D9A154
		public void RefreshMotorcycleRoundJoystick(bool? isRoundJoystickButtonLayout = null)
		{
			bool motorMobileButtonLayout = this.GetMotorMobileButtonLayout(isRoundJoystickButtonLayout);
			bool isRoundJoystick = this.ForceRoundJoystickTagSet.Count > 0 || motorMobileButtonLayout;
			BattleUiModel.Instance.MotorcycleData.SetIsRoundJoystick(isRoundJoystick);
		}

		// Token: 0x06030CF9 RID: 199929 RVA: 0x00D9BF8C File Offset: 0x00D9A18C
		public void RefreshMotorMobileSkillButtonLayout(bool? isRoundJoystickButtonLayout = null)
		{
			bool motorMobileButtonLayout = this.GetMotorMobileButtonLayout(isRoundJoystickButtonLayout);
			BattleUiModel.Instance.MotorcycleData.SetIsRoundJoystickButtonLayout(motorMobileButtonLayout);
		}

		// Token: 0x06030CFA RID: 199930 RVA: 0x00D9BFB1 File Offset: 0x00D9A1B1
		public void RefreshMotorMobileButtonLayout(bool? isRoundJoystickButtonLayout = null)
		{
			this.RefreshMotorMobileSkillButtonLayout(isRoundJoystickButtonLayout);
			this.RefreshMotorcycleRoundJoystick(isRoundJoystickButtonLayout);
		}

		// Token: 0x06030CFB RID: 199931 RVA: 0x00D9BFC4 File Offset: 0x00D9A1C4
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

		// Token: 0x06030CFC RID: 199932 RVA: 0x00D9C008 File Offset: 0x00D9A208
		private void ClearTasks()
		{
			foreach (ITagTask tagTask in this.SwitchJoystickTasks)
			{
				tagTask.EndTask();
			}
			this.SwitchJoystickTasks.Clear();
			this.ForceRoundJoystickTagSet.Clear();
		}

		// Token: 0x06030CFD RID: 199933 RVA: 0x00D9C070 File Offset: 0x00D9A270
		public void SetForceWalkRunRate(float value = -1f)
		{
			this.ForceWalkRunRate = value;
			EventSystem.Instance.Emit(EEventName.OnJoystickWalkRunRateChanged);
		}

		// Token: 0x06030CFE RID: 199934 RVA: 0x00D9C08C File Offset: 0x00D9A28C
		public float GetWalkRunRate()
		{
			if (this.ForceWalkRunRate >= 0f)
			{
				return this.ForceWalkRunRate;
			}
			return GameSettingsManager.Instance.GetCurrentValueFloat(EFunction.WalkOrRunRate, true, true).GetValueOrDefault(0.3f);
		}

		// Token: 0x04019E02 RID: 105986
		private const float WALK_TO_RUN_RATE = 0.3f;

		// Token: 0x04019E03 RID: 105987
		private float ForceWalkRunRate = -1f;

		// Token: 0x04019E04 RID: 105988
		private List<ITagTask> SwitchJoystickTasks = new List<ITagTask>();

		// Token: 0x04019E05 RID: 105989
		private HashSet<int> ForceRoundJoystickTagSet = new HashSet<int>();
	}
}
