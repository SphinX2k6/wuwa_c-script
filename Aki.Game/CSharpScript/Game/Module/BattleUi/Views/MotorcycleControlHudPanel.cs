using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D7A RID: 19834
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorcycleControlHudPanel : BattleVisibleChildView
	{
		// Token: 0x06031C49 RID: 203849 RVA: 0x00DEA644 File Offset: 0x00DE8844
		[NullableContext(1)]
		public UniTask Init(UUIItem parentItem, string resourceId)
		{
			MotorcycleControlHudPanel.<Init>d__31 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.parentItem = parentItem;
			<Init>d__.resourceId = resourceId;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MotorcycleControlHudPanel.<Init>d__31>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06031C4A RID: 203850 RVA: 0x00DEA698 File Offset: 0x00DE8898
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031C4B RID: 203851 RVA: 0x00DEA724 File Offset: 0x00DE8924
		protected override UniTask OnBeforeStartAsync()
		{
			MotorcycleControlHudPanel.<OnBeforeStartAsync>d__33 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleControlHudPanel.<OnBeforeStartAsync>d__33>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031C4C RID: 203852 RVA: 0x00DEA768 File Offset: 0x00DE8968
		protected override void OnStart()
		{
			base.InitChildType(EBattleUiChild.MotorcycleControlHud);
			this.ConfigRotateYaw = ConfigCommonParamById.GetFloatConfig("MotorHudRotateYaw").Value;
			this.ConfigRotateSpeed = ConfigCommonParamById.GetFloatConfig("MotorHudRotateSpeed").Value;
			this.ConfigRotateBackSpeed = ConfigCommonParamById.GetFloatConfig("MotorHudRotateBackSpeed").Value;
			this.ConfigRotateOutSpeed = ConfigCommonParamById.GetFloatConfig("MotorHudRotateOutSpeed").Value;
			this.ConfigSoarPitch = ConfigCommonParamById.GetFloatConfig("MotorHudSoarPitch").Value;
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.RotateItem = base.GetItem(2);
			this.AddEvents();
			this.RefreshMotorcycleSpeed(true);
			base.SetVisible(1, BattleUiModel.Instance.MotorcycleData.GetHudVisible());
		}

		// Token: 0x06031C4D RID: 203853 RVA: 0x00DEA836 File Offset: 0x00DE8A36
		public void OnShowBattleChildViewPanel()
		{
		}

		// Token: 0x06031C4E RID: 203854 RVA: 0x00DEA838 File Offset: 0x00DE8A38
		public void OnHideBattleChildViewPanel()
		{
		}

		// Token: 0x06031C4F RID: 203855 RVA: 0x00DEA83A File Offset: 0x00DE8A3A
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			this.RefreshMotorcycleSpeed(true);
		}

		// Token: 0x06031C50 RID: 203856 RVA: 0x00DEA849 File Offset: 0x00DE8A49
		protected override void OnAfterHide()
		{
			base.OnAfterHide();
			this.MotorcycleEntityHandle = null;
			this.VehicleActorComponent = null;
			this.ClearTagTask();
		}

		// Token: 0x06031C51 RID: 203857 RVA: 0x00DEA868 File Offset: 0x00DE8A68
		protected override void OnAfterShow()
		{
			this.UpdateAlpha(0f, true);
			this.IsEnableAlphaUpdate = true;
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06031C52 RID: 203858 RVA: 0x00DEA8A8 File Offset: 0x00DE8AA8
		protected override UniTask OnBeforeHideAsync()
		{
			MotorcycleControlHudPanel.<OnBeforeHideAsync>d__40 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<MotorcycleControlHudPanel.<OnBeforeHideAsync>d__40>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031C53 RID: 203859 RVA: 0x00DEA8EC File Offset: 0x00DE8AEC
		protected override void OnBeforeDestroy()
		{
			this.Reset();
			this.RemoveEvents();
			this.ClearTagTask();
			this.SpeedColorMPC = null;
			foreach (MotorcycleControlHudPanel.SpeedColorObj speedColorObj in this.SpeedColorObjs)
			{
				speedColorObj.Clear();
			}
			this.SpeedColorObjs.Clear();
		}

		// Token: 0x06031C54 RID: 203860 RVA: 0x00DEA960 File Offset: 0x00DE8B60
		private void AddEvents()
		{
			EventSystem.Instance.Add<bool>(EEventName.BattleUiMotorcycleHudVisibleChanged, new Action<bool>(this.OnMotorcycleHudVisibleChanged));
			EventSystem.Instance.Add<EMotorcycleHudColorState>(EEventName.BattleUiMotorcycleHudColorStateChanged, new Action<EMotorcycleHudColorState>(this.OnHudColorStateChanged));
			EventSystem.Instance.Add<ERoleSpecialState, bool>(EEventName.BattleUiRoleSpecialStateChanged, new Action<ERoleSpecialState, bool>(this.OnBattleUiRoleSpecialStateChanged));
		}

		// Token: 0x06031C55 RID: 203861 RVA: 0x00DEA9C4 File Offset: 0x00DE8BC4
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiMotorcycleHudVisibleChanged, new Action<bool>(this.OnMotorcycleHudVisibleChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiMotorcycleHudColorStateChanged, new Action<EMotorcycleHudColorState>(this.OnHudColorStateChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiRoleSpecialStateChanged, new Action<ERoleSpecialState, bool>(this.OnBattleUiRoleSpecialStateChanged));
		}

		// Token: 0x06031C56 RID: 203862 RVA: 0x00DEAA25 File Offset: 0x00DE8C25
		private void OnMotorcycleHudVisibleChanged(bool visible)
		{
			base.SetVisible(1, visible);
		}

		// Token: 0x06031C57 RID: 203863 RVA: 0x00DEAA30 File Offset: 0x00DE8C30
		private void OnHudColorStateChanged(EMotorcycleHudColorState state)
		{
			if (this.ColorState == EMotorcycleHudColorState.Normal && state != EMotorcycleHudColorState.Normal)
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null && levelSequencePlayer.IsPlayingSequence("BoostOut"))
				{
					LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
					if (levelSequencePlayer2 != null)
					{
						levelSequencePlayer2.StopSequenceByKey("BoostOut", false, false);
					}
				}
				LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
				if (levelSequencePlayer3 != null)
				{
					levelSequencePlayer3.PlayLevelSequenceByName("BoostIn", false, null, false);
				}
			}
			else if (this.ColorState != EMotorcycleHudColorState.Normal && state == EMotorcycleHudColorState.Normal)
			{
				LevelSequencePlayer levelSequencePlayer4 = this.LevelSequencePlayer;
				if (levelSequencePlayer4 != null && levelSequencePlayer4.IsPlayingSequence("BoostIn"))
				{
					LevelSequencePlayer levelSequencePlayer5 = this.LevelSequencePlayer;
					if (levelSequencePlayer5 != null)
					{
						levelSequencePlayer5.StopSequenceByKey("BoostIn", false, false);
					}
				}
				LevelSequencePlayer levelSequencePlayer6 = this.LevelSequencePlayer;
				if (levelSequencePlayer6 != null)
				{
					levelSequencePlayer6.PlayLevelSequenceByName("BoostOut", false, null, false);
				}
			}
			this.SetColorState(state);
		}

		// Token: 0x06031C58 RID: 203864 RVA: 0x00DEAB00 File Offset: 0x00DE8D00
		private void OnBattleUiRoleSpecialStateChanged(ERoleSpecialState state, bool enable)
		{
			if (state == ERoleSpecialState.MotorcycleFirstPersonDisabled)
			{
				bool isFirstPersonDisabled = false;
				BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
				if (curRoleData != null)
				{
					curRoleData.SpecialStateMap.TryGetValue(state, out isFirstPersonDisabled);
				}
				this.IsFirstPersonDisabled = isFirstPersonDisabled;
			}
		}

		// Token: 0x06031C59 RID: 203865 RVA: 0x00DEAB38 File Offset: 0x00DE8D38
		private unsafe void RefreshMotorcycleSpeed(bool isStart)
		{
			this.NextRefreshSpeedTime = 100f;
			if (this.MotorcycleEntityHandle == BattleUiModel.Instance.MotorcycleData.MotorcycleEntityHandle)
			{
				EntityHandle motorcycleEntityHandle = this.MotorcycleEntityHandle;
				if (motorcycleEntityHandle != null && motorcycleEntityHandle.Valid)
				{
					goto IL_3F;
				}
			}
			this.InitMotorcycleEntity();
			IL_3F:
			VehicleActorComponent vehicleActorComponent = this.VehicleActorComponent;
			UKuroVehicleMovementComponent ukuroVehicleMovementComponent;
			if (vehicleActorComponent == null)
			{
				ukuroVehicleMovementComponent = null;
			}
			else
			{
				VehicleMoveComponent vehicleMoveComp = vehicleActorComponent.VehicleMoveComp;
				ukuroVehicleMovementComponent = ((vehicleMoveComp != null) ? vehicleMoveComp.VehicleMovement : null);
			}
			UKuroVehicleMovementComponent ukuroVehicleMovementComponent2 = ukuroVehicleMovementComponent;
			if (ukuroVehicleMovementComponent2 == null)
			{
				return;
			}
			UMotorWheelDisplayInfoObject wheelDisplayInfosObj = ukuroVehicleMovementComponent2.WheelDisplayInfosObj;
			TArray<FMotorWheelDisplayInfo> tarray = (wheelDisplayInfosObj != null) ? wheelDisplayInfosObj.DisplayInfos : null;
			float num = 0f;
			if (this.IsVehicleSoar)
			{
				num = ukuroVehicleMovementComponent2.Velocity.Size();
			}
			else if (tarray != null && tarray.Num() >= 2)
			{
				FMotorShapeConfig motorShapeConfig = ukuroVehicleMovementComponent2.MotorShapeConfig;
				num = Math.Max(Math.Abs(tarray.Get(0).WheelSpeed * motorShapeConfig.FrontWheelShape.Radius), Math.Abs(tarray.Get(1).WheelSpeed * motorShapeConfig.BackWheelShape.Radius));
				if (BattleUiModel.Instance.MotorcycleData.DebugLog)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Battle;
					ELogAuthor author = ELogAuthor.CFT;
					string message = "MotorcycleControlHud WheelInfo";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("speed0", tarray.Get(0).WheelSpeed.ToString("F2"));
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("speed1", tarray.Get(1).WheelSpeed.ToString("F2"));
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("radius0", motorShapeConfig.FrontWheelShape.Radius.ToString("F2"));
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("radius1", motorShapeConfig.BackWheelShape.Radius.ToString("F2"));
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				}
			}
			float maxSpeed = ukuroVehicleMovementComponent2.MotorAccelConfig.MaxSpeed;
			this.LeftSpeedItem.SetSpeed(num, maxSpeed);
			if (this.IsVehicleSoar)
			{
				float configSoarPitch = this.ConfigSoarPitch;
				float num2 = MathUtils.Instance.Clamp(this.VehicleActorComponent.ActorRotationProxy.Pitch, -configSoarPitch, configSoarPitch);
				float num3 = (num2 + configSoarPitch) / (configSoarPitch * 2f) * configSoarPitch;
				this.RightSpeedItem.SetSpeed(num3, configSoarPitch);
				if (BattleUiModel.Instance.MotorcycleData.DebugLog)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Battle;
					ELogAuthor author2 = ELogAuthor.HWR;
					string message2 = "MotorcycleControlHud Soar";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("speed", num);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("mSpeed", maxSpeed);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("pitch", num2);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("value", num3);
					instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
					return;
				}
			}
			else
			{
				float toMax = ukuroVehicleMovementComponent2.MotorAccelConfig.PowerAccel.ToMax;
				float currentMotorPower = ukuroVehicleMovementComponent2.GetCurrentMotorPower();
				this.RightSpeedItem.SetSpeed(currentMotorPower, toMax);
				if (BattleUiModel.Instance.MotorcycleData.DebugLog)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.Battle;
					ELogAuthor author3 = ELogAuthor.CFT;
					string message3 = "MotorcycleControlHud";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("speed", num);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("mSpeed", maxSpeed);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("acc", currentMotorPower);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("mAcc", toMax);
					instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 4));
				}
			}
		}

		// Token: 0x06031C5A RID: 203866 RVA: 0x00DEAF28 File Offset: 0x00DE9128
		private void InitMotorcycleEntity()
		{
			BattleUiMotorcycleData motorcycleData = BattleUiModel.Instance.MotorcycleData;
			this.MotorcycleEntityHandle = motorcycleData.MotorcycleEntityHandle;
			EntityHandle motorcycleEntityHandle = this.MotorcycleEntityHandle;
			this.VehicleActorComponent = ((motorcycleEntityHandle != null && motorcycleEntityHandle.Valid) ? this.MotorcycleEntityHandle.Entity.GetComponent<VehicleActorComponent>() : null);
			this.ClearTagTask();
			if (this.VehicleActorComponent != null)
			{
				BaseTagComponent component = this.MotorcycleEntityHandle.Entity.GetComponent<BaseTagComponent>();
				this.VehicleSoarTagTask = component.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中.翱翔"]), delegate(int tagId, bool tagExist)
				{
					this.IsVehicleSoar = tagExist;
					MotorcycleHudSpeedItem rightSpeedItem = this.RightSpeedItem;
					if (rightSpeedItem == null)
					{
						return;
					}
					rightSpeedItem.SetSoarMode(tagExist);
				}, null);
				this.IsVehicleSoar = component.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中.翱翔"]);
				this.RightSpeedItem.SetSoarMode(this.IsVehicleSoar);
			}
		}

		// Token: 0x06031C5B RID: 203867 RVA: 0x00DEAFF1 File Offset: 0x00DE91F1
		private void ClearTagTask()
		{
			if (this.VehicleSoarTagTask != null)
			{
				this.VehicleSoarTagTask.EndTask();
				this.VehicleSoarTagTask = null;
			}
		}

		// Token: 0x06031C5C RID: 203868 RVA: 0x00DEB010 File Offset: 0x00DE9210
		public void Tick(float delta)
		{
			if (!base.IsShowOrShowing)
			{
				return;
			}
			this.NextRefreshSpeedTime -= delta;
			if (this.NextRefreshSpeedTime <= 0f)
			{
				this.RefreshMotorcycleSpeed(false);
			}
			this.LeftSpeedItem.Tick(delta);
			this.RightSpeedItem.Tick(delta);
			if (this.IsEnableAlphaUpdate)
			{
				this.UpdateAlpha(delta, false);
			}
			foreach (MotorcycleControlHudPanel.SpeedColorObj speedColorObj in this.SpeedColorObjs)
			{
				speedColorObj.Update(delta);
			}
			this.OnTickRotateHud(delta);
		}

		// Token: 0x06031C5D RID: 203869 RVA: 0x00DEB0BC File Offset: 0x00DE92BC
		private void UpdateAlpha(float delta, bool force = false)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
			if (characterActorComponent == null)
			{
				return;
			}
			if (Math.Abs((double)(CameraController.Instance.MainModel.CameraRotator.Yaw * 0.017453292f) - characterActorComponent.ActorForwardProxy.HeadingAngle()) < (double)this.AlphaAngleRange)
			{
				this.SetAlphaState(MotorcycleControlHudPanel.EAlphaState.Normal, force);
			}
			else
			{
				this.SetAlphaState(MotorcycleControlHudPanel.EAlphaState.Transparent, force);
			}
			if (force || this.AlphaMachine.Update(delta))
			{
				base.GetRootItem().SetAlpha(this.AlphaMachine.GetCurPercent());
			}
		}

		// Token: 0x06031C5E RID: 203870 RVA: 0x00DEB150 File Offset: 0x00DE9350
		private void SetAlphaState(MotorcycleControlHudPanel.EAlphaState state, bool force = false)
		{
			if (state == this.AlphaState && !force)
			{
				return;
			}
			this.AlphaState = state;
			float num = (state == MotorcycleControlHudPanel.EAlphaState.Normal) ? 1f : this.AlphaTargetValue;
			if (!force)
			{
				this.AlphaMachine.SetTargetPercent(num);
				return;
			}
			this.AlphaMachine.Init(num, new float?(this.AlphaChangeDuration));
		}

		// Token: 0x06031C5F RID: 203871 RVA: 0x00DEB1AC File Offset: 0x00DE93AC
		private void InitAlphaParams()
		{
			IReadOnlyList<float> floatArrayConfig = ConfigCommonParamById.GetFloatArrayConfig("MotorHudAlphaParams");
			if (floatArrayConfig != null)
			{
				if (floatArrayConfig.Count > 0)
				{
					this.AlphaAngleRange = floatArrayConfig[0] * 0.5f * 0.017453292f;
				}
				if (floatArrayConfig.Count > 1)
				{
					this.AlphaTargetValue = floatArrayConfig[1];
				}
				if (floatArrayConfig.Count > 2)
				{
					this.AlphaChangeDuration = floatArrayConfig[2] * (float)TimeUtil.Instance.InverseMillisecond;
				}
			}
		}

		// Token: 0x06031C60 RID: 203872 RVA: 0x00DEB224 File Offset: 0x00DE9424
		private void SetColorState(EMotorcycleHudColorState state)
		{
			if (this.ColorState == state)
			{
				return;
			}
			this.ColorState = state;
			foreach (MotorcycleControlHudPanel.SpeedColorObj speedColorObj in this.SpeedColorObjs)
			{
				string targetColor;
				if (speedColorObj.ColorMap.TryGetValue(state, out targetColor))
				{
					speedColorObj.ColorMachine.SetTargetColor(targetColor);
				}
			}
		}

		// Token: 0x06031C61 RID: 203873 RVA: 0x00DEB2A0 File Offset: 0x00DE94A0
		private void OnMainColorUpdate(in FLinearColor color)
		{
			if (this.SpeedColorMPC != null)
			{
				UKismetMaterialLibrary.SetVectorParameterValue(GlobalData.World, this.SpeedColorMPC, FNameUtil.GetDynamicFName("MainColor").Value, color);
			}
			MotorcycleHudSpeedItem leftSpeedItem = this.LeftSpeedItem;
			if (leftSpeedItem != null)
			{
				leftSpeedItem.SetMainColor(color);
			}
			MotorcycleHudSpeedItem rightSpeedItem = this.RightSpeedItem;
			if (rightSpeedItem == null)
			{
				return;
			}
			rightSpeedItem.SetMainColor(color);
		}

		// Token: 0x06031C62 RID: 203874 RVA: 0x00DEB2FC File Offset: 0x00DE94FC
		private void OnColorAUpdate(in FLinearColor color)
		{
			if (this.SpeedColorMPC != null)
			{
				UKismetMaterialLibrary.SetVectorParameterValue(GlobalData.World, this.SpeedColorMPC, FNameUtil.GetDynamicFName("ColorA").Value, color);
			}
		}

		// Token: 0x06031C63 RID: 203875 RVA: 0x00DEB334 File Offset: 0x00DE9534
		private void OnColorBUpdate(in FLinearColor color)
		{
			if (this.SpeedColorMPC != null)
			{
				UKismetMaterialLibrary.SetVectorParameterValue(GlobalData.World, this.SpeedColorMPC, FNameUtil.GetDynamicFName("ColorB").Value, color);
			}
		}

		// Token: 0x06031C64 RID: 203876 RVA: 0x00DEB36C File Offset: 0x00DE956C
		private void OnPointerColorUpdate(in FLinearColor color)
		{
			MotorcycleHudSpeedItem leftSpeedItem = this.LeftSpeedItem;
			if (leftSpeedItem != null)
			{
				leftSpeedItem.SetPointerColor(color);
			}
			MotorcycleHudSpeedItem rightSpeedItem = this.RightSpeedItem;
			if (rightSpeedItem == null)
			{
				return;
			}
			rightSpeedItem.SetPointerColor(color);
		}

		// Token: 0x06031C65 RID: 203877 RVA: 0x00DEB391 File Offset: 0x00DE9591
		private void OnTextColorUpdate(in FLinearColor color)
		{
			MotorcycleHudSpeedItem leftSpeedItem = this.LeftSpeedItem;
			if (leftSpeedItem == null)
			{
				return;
			}
			leftSpeedItem.SetNumTextColor(color);
		}

		// Token: 0x06031C66 RID: 203878 RVA: 0x00DEB3A4 File Offset: 0x00DE95A4
		private void OnTextStrokeColorUpdate(in FLinearColor color)
		{
			MotorcycleHudSpeedItem leftSpeedItem = this.LeftSpeedItem;
			if (leftSpeedItem == null)
			{
				return;
			}
			leftSpeedItem.SetNumTextStrokeColor(color);
		}

		// Token: 0x06031C67 RID: 203879 RVA: 0x00DEB3B7 File Offset: 0x00DE95B7
		private void OnTextGlowColorUpdate(in FLinearColor color)
		{
			MotorcycleHudSpeedItem leftSpeedItem = this.LeftSpeedItem;
			if (leftSpeedItem == null)
			{
				return;
			}
			leftSpeedItem.SetNumTextGlowColor(color);
		}

		// Token: 0x06031C68 RID: 203880 RVA: 0x00DEB3CC File Offset: 0x00DE95CC
		private void OnDecoColorUpdate(in FLinearColor color)
		{
			if (this.SpeedColorMPC != null)
			{
				UKismetMaterialLibrary.SetVectorParameterValue(GlobalData.World, this.SpeedColorMPC, FNameUtil.GetDynamicFName("DecoColor").Value, color);
			}
		}

		// Token: 0x06031C69 RID: 203881 RVA: 0x00DEB404 File Offset: 0x00DE9604
		[NullableContext(0)]
		private UniTask<bool> LoadSpeedColorMPC()
		{
			MotorcycleControlHudPanel.<LoadSpeedColorMPC>d__66 <LoadSpeedColorMPC>d__;
			<LoadSpeedColorMPC>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LoadSpeedColorMPC>d__.<>4__this = this;
			<LoadSpeedColorMPC>d__.<>1__state = -1;
			<LoadSpeedColorMPC>d__.<>t__builder.Start<MotorcycleControlHudPanel.<LoadSpeedColorMPC>d__66>(ref <LoadSpeedColorMPC>d__);
			return <LoadSpeedColorMPC>d__.<>t__builder.Task;
		}

		// Token: 0x06031C6A RID: 203882 RVA: 0x00DEB448 File Offset: 0x00DE9648
		private void InitSpeedColorObjs()
		{
			string[] array = new string[]
			{
				"MotorHudMainColor",
				"MotorHudColorA",
				"MotorHudColorB",
				"MotorHudPointerColor",
				"MotorHudTextColor",
				"MotorHudTextStrokeColor",
				"MotorHudTextGlowColor",
				"MotorHudDecoColor"
			};
			MotorcycleControlHudPanel.SpeedColorObj.UpdateFuncDelegate[] array2 = new MotorcycleControlHudPanel.SpeedColorObj.UpdateFuncDelegate[]
			{
				new MotorcycleControlHudPanel.SpeedColorObj.UpdateFuncDelegate(this.OnMainColorUpdate),
				new MotorcycleControlHudPanel.SpeedColorObj.UpdateFuncDelegate(this.OnColorAUpdate),
				new MotorcycleControlHudPanel.SpeedColorObj.UpdateFuncDelegate(this.OnColorBUpdate),
				new MotorcycleControlHudPanel.SpeedColorObj.UpdateFuncDelegate(this.OnPointerColorUpdate),
				new MotorcycleControlHudPanel.SpeedColorObj.UpdateFuncDelegate(this.OnTextColorUpdate),
				new MotorcycleControlHudPanel.SpeedColorObj.UpdateFuncDelegate(this.OnTextStrokeColorUpdate),
				new MotorcycleControlHudPanel.SpeedColorObj.UpdateFuncDelegate(this.OnTextGlowColorUpdate),
				new MotorcycleControlHudPanel.SpeedColorObj.UpdateFuncDelegate(this.OnDecoColorUpdate)
			};
			for (int i = 0; i < array.Length; i++)
			{
				MotorcycleControlHudPanel.SpeedColorObj speedColorObj = new MotorcycleControlHudPanel.SpeedColorObj();
				speedColorObj.UpdateFunc = array2[i];
				IReadOnlyList<string> stringArrayConfig = ConfigCommonParamById.GetStringArrayConfig(array[i]);
				if (stringArrayConfig != null)
				{
					for (int j = 0; j < 3; j++)
					{
						if (j < stringArrayConfig.Count && !string.IsNullOrEmpty(stringArrayConfig[j]))
						{
							speedColorObj.ColorMap[(EMotorcycleHudColorState)j] = stringArrayConfig[j];
						}
					}
				}
				speedColorObj.Init();
				this.SpeedColorObjs.Add(speedColorObj);
			}
		}

		// Token: 0x06031C6B RID: 203883 RVA: 0x00DEB59C File Offset: 0x00DE979C
		private void OnTickRotateHud(float delta)
		{
			bool flag = BattleUiModel.Instance.MotorcycleData.IsInFirstPersonMode() && !this.IsFirstPersonDisabled;
			if (this.IsPlayingFirstPerson != flag)
			{
				this.IsPlayingFirstPerson = flag;
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.PlaySequencePurely(flag ? "FPVIn" : "FPVOut", false, false, null, null, false);
				}
			}
			if (flag)
			{
				float valueOrDefault = InputModel.Instance.GetAxisValues().GetValueOrDefault(EInputAxis.MoveRight, 0f);
				if (valueOrDefault == 0f)
				{
					this.TargetYaw = 0f;
					this.RotateSpeed = this.ConfigRotateBackSpeed;
				}
				else if (valueOrDefault > 0f)
				{
					this.TargetYaw = -this.ConfigRotateYaw;
					this.RotateSpeed = this.ConfigRotateSpeed;
				}
				else
				{
					this.TargetYaw = this.ConfigRotateYaw;
					this.RotateSpeed = this.ConfigRotateSpeed;
				}
			}
			else
			{
				this.TargetYaw = 0f;
				this.RotateSpeed = this.ConfigRotateOutSpeed;
			}
			if (this.CurYaw == this.TargetYaw)
			{
				return;
			}
			if (this.CurYaw < this.TargetYaw)
			{
				this.CurYaw += this.RotateSpeed * delta;
				this.CurYaw = Math.Min(this.CurYaw, this.TargetYaw);
			}
			else
			{
				this.CurYaw -= this.RotateSpeed * delta;
				this.CurYaw = Math.Max(this.CurYaw, this.TargetYaw);
			}
			UUIItem rotateItem = this.RotateItem;
			if (rotateItem == null)
			{
				return;
			}
			FRotator frotator = new FRotator();
			frotator.Yaw = this.CurYaw;
			rotateItem.SetUIRelativeRotation(frotator);
		}

		// Token: 0x0401A581 RID: 107905
		private const float TICK_INTERVAL = 100f;

		// Token: 0x0401A582 RID: 107906
		[Nullable(1)]
		private const string SPEED_COLOR_MPC_PATH = "/Game/Aki/UI/Framework/MPC/UiActivity/Activity30/MotoParkour/GamePlay/MPC_MotoHUD_MainColor.MPC_MotoHUD_MainColor";

		// Token: 0x0401A583 RID: 107907
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A584 RID: 107908
		private MotorcycleHudSpeedItem LeftSpeedItem;

		// Token: 0x0401A585 RID: 107909
		private MotorcycleHudSpeedItem RightSpeedItem;

		// Token: 0x0401A586 RID: 107910
		private EntityHandle MotorcycleEntityHandle;

		// Token: 0x0401A587 RID: 107911
		private VehicleActorComponent VehicleActorComponent;

		// Token: 0x0401A588 RID: 107912
		private float NextRefreshSpeedTime;

		// Token: 0x0401A589 RID: 107913
		private bool IsPlayingFirstPerson;

		// Token: 0x0401A58A RID: 107914
		private MotorcycleControlHudPanel.EAlphaState AlphaState;

		// Token: 0x0401A58B RID: 107915
		private float AlphaAngleRange;

		// Token: 0x0401A58C RID: 107916
		private float AlphaChangeDuration = 300f;

		// Token: 0x0401A58D RID: 107917
		private float AlphaTargetValue;

		// Token: 0x0401A58E RID: 107918
		private bool IsEnableAlphaUpdate;

		// Token: 0x0401A58F RID: 107919
		[Nullable(1)]
		private readonly MotorcyclePercentMachine AlphaMachine = new MotorcyclePercentMachine();

		// Token: 0x0401A590 RID: 107920
		private EMotorcycleHudColorState ColorState;

		// Token: 0x0401A591 RID: 107921
		private UMaterialParameterCollection SpeedColorMPC;

		// Token: 0x0401A592 RID: 107922
		[Nullable(1)]
		private readonly List<MotorcycleControlHudPanel.SpeedColorObj> SpeedColorObjs = new List<MotorcycleControlHudPanel.SpeedColorObj>();

		// Token: 0x0401A593 RID: 107923
		private UUIItem RotateItem;

		// Token: 0x0401A594 RID: 107924
		private float TargetYaw;

		// Token: 0x0401A595 RID: 107925
		private float CurYaw;

		// Token: 0x0401A596 RID: 107926
		private float RotateSpeed;

		// Token: 0x0401A597 RID: 107927
		private float ConfigRotateYaw;

		// Token: 0x0401A598 RID: 107928
		private float ConfigRotateSpeed;

		// Token: 0x0401A599 RID: 107929
		private float ConfigRotateBackSpeed;

		// Token: 0x0401A59A RID: 107930
		private float ConfigRotateOutSpeed;

		// Token: 0x0401A59B RID: 107931
		private float ConfigSoarPitch;

		// Token: 0x0401A59C RID: 107932
		private bool IsFirstPersonDisabled;

		// Token: 0x0401A59D RID: 107933
		private ITagTask VehicleSoarTagTask;

		// Token: 0x0401A59E RID: 107934
		private bool IsVehicleSoar;

		// Token: 0x0200AA61 RID: 43617
		[NullableContext(0)]
		private class SpeedColorObj
		{
			// Token: 0x06046859 RID: 288857 RVA: 0x01542B68 File Offset: 0x01540D68
			public void Init()
			{
				string color;
				if (this.ColorMap.TryGetValue(EMotorcycleHudColorState.Normal, out color))
				{
					this.ColorMachine.Init(color, null);
					MotorcycleControlHudPanel.SpeedColorObj.UpdateFuncDelegate updateFunc = this.UpdateFunc;
					if (updateFunc == null)
					{
						return;
					}
					FLinearColor color2 = this.ColorMachine.GetColor();
					updateFunc(color2);
				}
			}

			// Token: 0x0604685A RID: 288858 RVA: 0x01542BB8 File Offset: 0x01540DB8
			public void Update(float delta)
			{
				if (this.ColorMachine.Update((double)delta))
				{
					MotorcycleControlHudPanel.SpeedColorObj.UpdateFuncDelegate updateFunc = this.UpdateFunc;
					if (updateFunc == null)
					{
						return;
					}
					FLinearColor color = this.ColorMachine.GetColor();
					updateFunc(color);
				}
			}

			// Token: 0x0604685B RID: 288859 RVA: 0x01542BF2 File Offset: 0x01540DF2
			public void Clear()
			{
				this.UpdateFunc = null;
			}

			// Token: 0x04034A7D RID: 215677
			[Nullable(1)]
			public readonly Dictionary<EMotorcycleHudColorState, string> ColorMap = new Dictionary<EMotorcycleHudColorState, string>();

			// Token: 0x04034A7E RID: 215678
			[Nullable(1)]
			public readonly MotorcycleSpeedColorMachine ColorMachine = new MotorcycleSpeedColorMachine();

			// Token: 0x04034A7F RID: 215679
			[Nullable(2)]
			public MotorcycleControlHudPanel.SpeedColorObj.UpdateFuncDelegate UpdateFunc;

			// Token: 0x0200BD68 RID: 48488
			// (Invoke) Token: 0x06048DF4 RID: 298484
			public delegate void UpdateFuncDelegate(in FLinearColor color);
		}

		// Token: 0x0200AA62 RID: 43618
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034A81 RID: 215681
			LeftItem,
			// Token: 0x04034A82 RID: 215682
			RightItem,
			// Token: 0x04034A83 RID: 215683
			RotateItem
		}

		// Token: 0x0200AA63 RID: 43619
		[NullableContext(0)]
		private enum EAlphaState
		{
			// Token: 0x04034A85 RID: 215685
			Normal,
			// Token: 0x04034A86 RID: 215686
			Transparent
		}

		// Token: 0x0200AA64 RID: 43620
		[NullableContext(0)]
		private enum EVisibleReason
		{
			// Token: 0x04034A88 RID: 215688
			MotorcycleHudVisible = 1
		}
	}
}
