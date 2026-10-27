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
	// Token: 0x02005D98 RID: 23960
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorcycleControlHudPanel : BattleVisibleChildView
	{
		// Token: 0x0603CCEC RID: 249068 RVA: 0x00E99D8C File Offset: 0x00E97F8C
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

		// Token: 0x0603CCED RID: 249069 RVA: 0x00E99DE0 File Offset: 0x00E97FE0
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

		// Token: 0x0603CCEE RID: 249070 RVA: 0x00E99E6C File Offset: 0x00E9806C
		protected override UniTask OnBeforeStartAsync()
		{
			MotorcycleControlHudPanel.<OnBeforeStartAsync>d__33 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleControlHudPanel.<OnBeforeStartAsync>d__33>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CCEF RID: 249071 RVA: 0x00E99EB0 File Offset: 0x00E980B0
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

		// Token: 0x0603CCF0 RID: 249072 RVA: 0x00E99F7E File Offset: 0x00E9817E
		public void OnShowBattleChildViewPanel()
		{
		}

		// Token: 0x0603CCF1 RID: 249073 RVA: 0x00E99F80 File Offset: 0x00E98180
		public void OnHideBattleChildViewPanel()
		{
		}

		// Token: 0x0603CCF2 RID: 249074 RVA: 0x00E99F82 File Offset: 0x00E98182
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			this.RefreshMotorcycleSpeed(true);
		}

		// Token: 0x0603CCF3 RID: 249075 RVA: 0x00E99F91 File Offset: 0x00E98191
		protected override void OnAfterHide()
		{
			base.OnAfterHide();
			this.MotorcycleEntityHandle = null;
			this.VehicleActorComponent = null;
			this.ClearTagTask();
		}

		// Token: 0x0603CCF4 RID: 249076 RVA: 0x00E99FB0 File Offset: 0x00E981B0
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

		// Token: 0x0603CCF5 RID: 249077 RVA: 0x00E99FF0 File Offset: 0x00E981F0
		protected override UniTask OnBeforeHideAsync()
		{
			MotorcycleControlHudPanel.<OnBeforeHideAsync>d__40 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<MotorcycleControlHudPanel.<OnBeforeHideAsync>d__40>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CCF6 RID: 249078 RVA: 0x00E9A034 File Offset: 0x00E98234
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

		// Token: 0x0603CCF7 RID: 249079 RVA: 0x00E9A0A8 File Offset: 0x00E982A8
		private void AddEvents()
		{
			EventSystem.Instance.Add<bool>(EEventName.BattleUiMotorcycleHudVisibleChanged, new Action<bool>(this.OnMotorcycleHudVisibleChanged));
			EventSystem.Instance.Add<EMotorcycleHudColorState>(EEventName.BattleUiMotorcycleHudColorStateChanged, new Action<EMotorcycleHudColorState>(this.OnHudColorStateChanged));
			EventSystem.Instance.Add<ERoleSpecialState, bool>(EEventName.BattleUiRoleSpecialStateChanged, new Action<ERoleSpecialState, bool>(this.OnBattleUiRoleSpecialStateChanged));
		}

		// Token: 0x0603CCF8 RID: 249080 RVA: 0x00E9A10C File Offset: 0x00E9830C
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiMotorcycleHudVisibleChanged, new Action<bool>(this.OnMotorcycleHudVisibleChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiMotorcycleHudColorStateChanged, new Action<EMotorcycleHudColorState>(this.OnHudColorStateChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiRoleSpecialStateChanged, new Action<ERoleSpecialState, bool>(this.OnBattleUiRoleSpecialStateChanged));
		}

		// Token: 0x0603CCF9 RID: 249081 RVA: 0x00E9A16D File Offset: 0x00E9836D
		private void OnMotorcycleHudVisibleChanged(bool visible)
		{
			base.SetVisible(1, visible);
		}

		// Token: 0x0603CCFA RID: 249082 RVA: 0x00E9A178 File Offset: 0x00E98378
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

		// Token: 0x0603CCFB RID: 249083 RVA: 0x00E9A248 File Offset: 0x00E98448
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

		// Token: 0x0603CCFC RID: 249084 RVA: 0x00E9A280 File Offset: 0x00E98480
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

		// Token: 0x0603CCFD RID: 249085 RVA: 0x00E9A670 File Offset: 0x00E98870
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

		// Token: 0x0603CCFE RID: 249086 RVA: 0x00E9A739 File Offset: 0x00E98939
		private void ClearTagTask()
		{
			if (this.VehicleSoarTagTask != null)
			{
				this.VehicleSoarTagTask.EndTask();
				this.VehicleSoarTagTask = null;
			}
		}

		// Token: 0x0603CCFF RID: 249087 RVA: 0x00E9A758 File Offset: 0x00E98958
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

		// Token: 0x0603CD00 RID: 249088 RVA: 0x00E9A804 File Offset: 0x00E98A04
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

		// Token: 0x0603CD01 RID: 249089 RVA: 0x00E9A898 File Offset: 0x00E98A98
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

		// Token: 0x0603CD02 RID: 249090 RVA: 0x00E9A8F4 File Offset: 0x00E98AF4
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

		// Token: 0x0603CD03 RID: 249091 RVA: 0x00E9A96C File Offset: 0x00E98B6C
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

		// Token: 0x0603CD04 RID: 249092 RVA: 0x00E9A9E8 File Offset: 0x00E98BE8
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

		// Token: 0x0603CD05 RID: 249093 RVA: 0x00E9AA44 File Offset: 0x00E98C44
		private void OnColorAUpdate(in FLinearColor color)
		{
			if (this.SpeedColorMPC != null)
			{
				UKismetMaterialLibrary.SetVectorParameterValue(GlobalData.World, this.SpeedColorMPC, FNameUtil.GetDynamicFName("ColorA").Value, color);
			}
		}

		// Token: 0x0603CD06 RID: 249094 RVA: 0x00E9AA7C File Offset: 0x00E98C7C
		private void OnColorBUpdate(in FLinearColor color)
		{
			if (this.SpeedColorMPC != null)
			{
				UKismetMaterialLibrary.SetVectorParameterValue(GlobalData.World, this.SpeedColorMPC, FNameUtil.GetDynamicFName("ColorB").Value, color);
			}
		}

		// Token: 0x0603CD07 RID: 249095 RVA: 0x00E9AAB4 File Offset: 0x00E98CB4
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

		// Token: 0x0603CD08 RID: 249096 RVA: 0x00E9AAD9 File Offset: 0x00E98CD9
		private void OnTextColorUpdate(in FLinearColor color)
		{
			MotorcycleHudSpeedItem leftSpeedItem = this.LeftSpeedItem;
			if (leftSpeedItem == null)
			{
				return;
			}
			leftSpeedItem.SetNumTextColor(color);
		}

		// Token: 0x0603CD09 RID: 249097 RVA: 0x00E9AAEC File Offset: 0x00E98CEC
		private void OnTextStrokeColorUpdate(in FLinearColor color)
		{
			MotorcycleHudSpeedItem leftSpeedItem = this.LeftSpeedItem;
			if (leftSpeedItem == null)
			{
				return;
			}
			leftSpeedItem.SetNumTextStrokeColor(color);
		}

		// Token: 0x0603CD0A RID: 249098 RVA: 0x00E9AAFF File Offset: 0x00E98CFF
		private void OnTextGlowColorUpdate(in FLinearColor color)
		{
			MotorcycleHudSpeedItem leftSpeedItem = this.LeftSpeedItem;
			if (leftSpeedItem == null)
			{
				return;
			}
			leftSpeedItem.SetNumTextGlowColor(color);
		}

		// Token: 0x0603CD0B RID: 249099 RVA: 0x00E9AB14 File Offset: 0x00E98D14
		private void OnDecoColorUpdate(in FLinearColor color)
		{
			if (this.SpeedColorMPC != null)
			{
				UKismetMaterialLibrary.SetVectorParameterValue(GlobalData.World, this.SpeedColorMPC, FNameUtil.GetDynamicFName("DecoColor").Value, color);
			}
		}

		// Token: 0x0603CD0C RID: 249100 RVA: 0x00E9AB4C File Offset: 0x00E98D4C
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

		// Token: 0x0603CD0D RID: 249101 RVA: 0x00E9AB90 File Offset: 0x00E98D90
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

		// Token: 0x0603CD0E RID: 249102 RVA: 0x00E9ACE4 File Offset: 0x00E98EE4
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

		// Token: 0x0401FAC9 RID: 129737
		private const float TICK_INTERVAL = 100f;

		// Token: 0x0401FACA RID: 129738
		[Nullable(1)]
		private const string SPEED_COLOR_MPC_PATH = "/Game/Aki/UI/Framework/MPC/UiActivity/Activity30/MotoParkour/GamePlay/MPC_MotoHUD_MainColor.MPC_MotoHUD_MainColor";

		// Token: 0x0401FACB RID: 129739
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401FACC RID: 129740
		private MotorcycleHudSpeedItem LeftSpeedItem;

		// Token: 0x0401FACD RID: 129741
		private MotorcycleHudSpeedItem RightSpeedItem;

		// Token: 0x0401FACE RID: 129742
		private EntityHandle MotorcycleEntityHandle;

		// Token: 0x0401FACF RID: 129743
		private VehicleActorComponent VehicleActorComponent;

		// Token: 0x0401FAD0 RID: 129744
		private float NextRefreshSpeedTime;

		// Token: 0x0401FAD1 RID: 129745
		private bool IsPlayingFirstPerson;

		// Token: 0x0401FAD2 RID: 129746
		private MotorcycleControlHudPanel.EAlphaState AlphaState;

		// Token: 0x0401FAD3 RID: 129747
		private float AlphaAngleRange;

		// Token: 0x0401FAD4 RID: 129748
		private float AlphaChangeDuration = 300f;

		// Token: 0x0401FAD5 RID: 129749
		private float AlphaTargetValue;

		// Token: 0x0401FAD6 RID: 129750
		private bool IsEnableAlphaUpdate;

		// Token: 0x0401FAD7 RID: 129751
		[Nullable(1)]
		private readonly MotorcyclePercentMachine AlphaMachine = new MotorcyclePercentMachine();

		// Token: 0x0401FAD8 RID: 129752
		private EMotorcycleHudColorState ColorState;

		// Token: 0x0401FAD9 RID: 129753
		private UMaterialParameterCollection SpeedColorMPC;

		// Token: 0x0401FADA RID: 129754
		[Nullable(1)]
		private readonly List<MotorcycleControlHudPanel.SpeedColorObj> SpeedColorObjs = new List<MotorcycleControlHudPanel.SpeedColorObj>();

		// Token: 0x0401FADB RID: 129755
		private UUIItem RotateItem;

		// Token: 0x0401FADC RID: 129756
		private float TargetYaw;

		// Token: 0x0401FADD RID: 129757
		private float CurYaw;

		// Token: 0x0401FADE RID: 129758
		private float RotateSpeed;

		// Token: 0x0401FADF RID: 129759
		private float ConfigRotateYaw;

		// Token: 0x0401FAE0 RID: 129760
		private float ConfigRotateSpeed;

		// Token: 0x0401FAE1 RID: 129761
		private float ConfigRotateBackSpeed;

		// Token: 0x0401FAE2 RID: 129762
		private float ConfigRotateOutSpeed;

		// Token: 0x0401FAE3 RID: 129763
		private float ConfigSoarPitch;

		// Token: 0x0401FAE4 RID: 129764
		private bool IsFirstPersonDisabled;

		// Token: 0x0401FAE5 RID: 129765
		private ITagTask VehicleSoarTagTask;

		// Token: 0x0401FAE6 RID: 129766
		private bool IsVehicleSoar;

		// Token: 0x0200C05B RID: 49243
		[NullableContext(0)]
		private class SpeedColorObj
		{
			// Token: 0x06050316 RID: 328470 RVA: 0x015897D0 File Offset: 0x015879D0
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

			// Token: 0x06050317 RID: 328471 RVA: 0x01589820 File Offset: 0x01587A20
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

			// Token: 0x06050318 RID: 328472 RVA: 0x0158985A File Offset: 0x01587A5A
			public void Clear()
			{
				this.UpdateFunc = null;
			}

			// Token: 0x0403A0BA RID: 237754
			[Nullable(1)]
			public readonly Dictionary<EMotorcycleHudColorState, string> ColorMap = new Dictionary<EMotorcycleHudColorState, string>();

			// Token: 0x0403A0BB RID: 237755
			[Nullable(1)]
			public readonly MotorcycleSpeedColorMachine ColorMachine = new MotorcycleSpeedColorMachine();

			// Token: 0x0403A0BC RID: 237756
			[Nullable(2)]
			public MotorcycleControlHudPanel.SpeedColorObj.UpdateFuncDelegate UpdateFunc;

			// Token: 0x0200D18A RID: 53642
			// (Invoke) Token: 0x06052555 RID: 337237
			public delegate void UpdateFuncDelegate(in FLinearColor color);
		}

		// Token: 0x0200C05C RID: 49244
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A0BE RID: 237758
			LeftItem,
			// Token: 0x0403A0BF RID: 237759
			RightItem,
			// Token: 0x0403A0C0 RID: 237760
			RotateItem
		}

		// Token: 0x0200C05D RID: 49245
		[NullableContext(0)]
		private enum EAlphaState
		{
			// Token: 0x0403A0C2 RID: 237762
			Normal,
			// Token: 0x0403A0C3 RID: 237763
			Transparent
		}

		// Token: 0x0200C05E RID: 49246
		[NullableContext(0)]
		private enum EVisibleReason
		{
			// Token: 0x0403A0C5 RID: 237765
			MotorcycleHudVisible = 1
		}
	}
}
