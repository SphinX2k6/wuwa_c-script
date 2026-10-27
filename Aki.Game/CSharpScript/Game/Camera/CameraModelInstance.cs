using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using CSharpScript.Game.Camera.CameraSubModeController;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072B8 RID: 29368
	[NullableContext(1)]
	[Nullable(0)]
	public class CameraModelInstance
	{
		// Token: 0x17009F10 RID: 40720
		// (get) Token: 0x060480AD RID: 295085 RVA: 0x01278725 File Offset: 0x01276925
		public string CameraName { get; }

		// Token: 0x060480AE RID: 295086 RVA: 0x01278730 File Offset: 0x01276930
		public CameraModelInstance(string cameraName)
		{
			Comparison<CameraSpecificLockTarget> compare;
			if ((compare = CameraModelInstance.<>O.<0>__CompareCameraSpecificLockIdPriority) == null)
			{
				compare = (CameraModelInstance.<>O.<0>__CompareCameraSpecificLockIdPriority = new Comparison<CameraSpecificLockTarget>(CameraModelInstance.CompareCameraSpecificLockIdPriority));
			}
			this.CameraSpecificLockTargetList = new PriorityQueue<CameraSpecificLockTarget>(compare);
			this.DitherEntityGroups = new DisjointSet<long>();
			this.HideHeadEnabledInternal = new HashSet<EHideHeadEnum>();
			this.HideHeadDisabledInternal = new HashSet<EHideHeadDisabledEnum>();
			this.HidePlayerHandle = -1;
			base..ctor();
			this.CameraName = cameraName;
			this.CurrentAimAssistMode = this.DefaultAimAssistModeInternal;
		}

		// Token: 0x17009F11 RID: 40721
		// (get) Token: 0x060480AF RID: 295087 RVA: 0x012788DF File Offset: 0x01276ADF
		[Nullable(2)]
		public APlayerCameraManager PlayerCameraManager
		{
			[NullableContext(2)]
			get
			{
				if (this.CameraName == "MainCamera")
				{
					return Global.CharacterCameraManager;
				}
				return this.PlayerCameraManagerInternal;
			}
		}

		// Token: 0x17009F12 RID: 40722
		// (get) Token: 0x060480B0 RID: 295088 RVA: 0x012788FF File Offset: 0x01276AFF
		public double CameraBaseYawSensitivity
		{
			get
			{
				return this.CameraBaseYawSensitivityInternal;
			}
		}

		// Token: 0x17009F13 RID: 40723
		// (get) Token: 0x060480B1 RID: 295089 RVA: 0x01278907 File Offset: 0x01276B07
		public double CameraBasePitchSensitivity
		{
			get
			{
				return this.CameraBasePitchSensitivityInternal;
			}
		}

		// Token: 0x17009F14 RID: 40724
		// (get) Token: 0x060480B2 RID: 295090 RVA: 0x0127890F File Offset: 0x01276B0F
		public double CameraAimingYawSensitivity
		{
			get
			{
				return this.CameraAimingYawSensitivityInternal;
			}
		}

		// Token: 0x17009F15 RID: 40725
		// (get) Token: 0x060480B3 RID: 295091 RVA: 0x01278917 File Offset: 0x01276B17
		public double CameraAimingPitchSensitivity
		{
			get
			{
				return this.CameraAimingPitchSensitivityInternal;
			}
		}

		// Token: 0x17009F16 RID: 40726
		// (get) Token: 0x060480B4 RID: 295092 RVA: 0x0127891F File Offset: 0x01276B1F
		public bool IsEnableSoftLockCameraExternal
		{
			get
			{
				return this.IsEnableSoftLockCamera;
			}
		}

		// Token: 0x17009F17 RID: 40727
		// (get) Token: 0x060480B5 RID: 295093 RVA: 0x01278928 File Offset: 0x01276B28
		public float CameraBaseYawSensitivityInputModifier
		{
			get
			{
				if (this.IsEnableSpecificCameraSensitivity)
				{
					return this.SpecificCameraBaseYawSensitivity;
				}
				FightCamera fightCamera = this.FightCamera;
				float? num;
				if (fightCamera == null)
				{
					num = null;
				}
				else
				{
					FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
					num = ((logicComponent != null) ? new float?(logicComponent.CameraInputController.SpecificCameraBaseYawSensitivity) : null);
				}
				float? num2 = num;
				if (num2.GetValueOrDefault(-1f) > 0f)
				{
					return this.FightCamera.LogicComponent.CameraInputController.SpecificCameraBaseYawSensitivity;
				}
				double cameraBaseYawSensitivityInternal = this.CameraBaseYawSensitivityInternal;
				double num3 = (cameraBaseYawSensitivityInternal < 50.0) ? MathUtils.Instance.RangeClamp(cameraBaseYawSensitivityInternal, 0.0, 50.0, 0.10000000149011612, 1.0) : MathUtils.Instance.RangeClamp(cameraBaseYawSensitivityInternal, 50.0, 100.0, 1.0, 2.0);
				return (float)(this.CameraBaseYawReverseInternal ? (-(float)num3) : num3);
			}
		}

		// Token: 0x17009F18 RID: 40728
		// (get) Token: 0x060480B6 RID: 295094 RVA: 0x01278A28 File Offset: 0x01276C28
		public float CameraBasePitchSensitivityInputModifier
		{
			get
			{
				if (this.IsEnableSpecificCameraSensitivity)
				{
					return this.SpecificCameraBasePitchSensitivity;
				}
				FightCamera fightCamera = this.FightCamera;
				float? num;
				if (fightCamera == null)
				{
					num = null;
				}
				else
				{
					FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
					num = ((logicComponent != null) ? new float?(logicComponent.CameraInputController.SpecificCameraBasePitchSensitivity) : null);
				}
				float? num2 = num;
				if (num2.GetValueOrDefault(-1f) > 0f)
				{
					return this.FightCamera.LogicComponent.CameraInputController.SpecificCameraBasePitchSensitivity;
				}
				double cameraBasePitchSensitivityInternal = this.CameraBasePitchSensitivityInternal;
				double num3 = (cameraBasePitchSensitivityInternal < 50.0) ? MathUtils.Instance.RangeClamp(cameraBasePitchSensitivityInternal, 0.0, 50.0, 0.10000000149011612, 1.0) : MathUtils.Instance.RangeClamp(cameraBasePitchSensitivityInternal, 50.0, 100.0, 1.0, 2.0);
				return (float)(this.CameraBasePitchReverseInternal ? (-(float)num3) : num3);
			}
		}

		// Token: 0x17009F19 RID: 40729
		// (get) Token: 0x060480B7 RID: 295095 RVA: 0x01278B28 File Offset: 0x01276D28
		public float CameraAimingYawSensitivityInputModifier
		{
			get
			{
				if (this.IsEnableSpecificCameraSensitivity)
				{
					return this.SpecificCameraAimingYawSensitivity;
				}
				FightCamera fightCamera = this.FightCamera;
				float? num;
				if (fightCamera == null)
				{
					num = null;
				}
				else
				{
					FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
					num = ((logicComponent != null) ? new float?(logicComponent.CameraInputController.SpecificCameraAimingYawSensitivity) : null);
				}
				float? num2 = num;
				if (num2.GetValueOrDefault(-1f) > 0f)
				{
					return this.FightCamera.LogicComponent.CameraInputController.SpecificCameraAimingYawSensitivity;
				}
				double cameraAimingYawSensitivityInternal = this.CameraAimingYawSensitivityInternal;
				double num3 = (cameraAimingYawSensitivityInternal < 50.0) ? MathUtils.Instance.RangeClamp(cameraAimingYawSensitivityInternal, 0.0, 50.0, 0.10000000149011612, 1.0) : MathUtils.Instance.RangeClamp(cameraAimingYawSensitivityInternal, 50.0, 100.0, 1.0, 2.0);
				return (float)(this.CameraAimingYawReverseInternal ? (-(float)num3) : num3);
			}
		}

		// Token: 0x17009F1A RID: 40730
		// (get) Token: 0x060480B8 RID: 295096 RVA: 0x01278C28 File Offset: 0x01276E28
		public float CameraAimingPitchSensitivityInputModifier
		{
			get
			{
				if (this.IsEnableSpecificCameraSensitivity)
				{
					return this.SpecificCameraAimingPitchSensitivity;
				}
				FightCamera fightCamera = this.FightCamera;
				float? num;
				if (fightCamera == null)
				{
					num = null;
				}
				else
				{
					FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
					num = ((logicComponent != null) ? new float?(logicComponent.CameraInputController.SpecificCameraAimingPitchSensitivity) : null);
				}
				float? num2 = num;
				if (num2.GetValueOrDefault(-1f) > 0f)
				{
					return this.FightCamera.LogicComponent.CameraInputController.SpecificCameraAimingPitchSensitivity;
				}
				double cameraAimingPitchSensitivityInternal = this.CameraAimingPitchSensitivityInternal;
				double num3 = (cameraAimingPitchSensitivityInternal < 50.0) ? MathUtils.Instance.RangeClamp(cameraAimingPitchSensitivityInternal, 0.0, 50.0, 0.10000000149011612, 1.0) : MathUtils.Instance.RangeClamp(cameraAimingPitchSensitivityInternal, 50.0, 100.0, 1.0, 2.0);
				return (float)(this.CameraAimingPitchReverseInternal ? (-(float)num3) : num3);
			}
		}

		// Token: 0x17009F1B RID: 40731
		// (get) Token: 0x060480B9 RID: 295097 RVA: 0x01278D28 File Offset: 0x01276F28
		public bool IsCameraResetPitch
		{
			get
			{
				return this.IsCameraResetPitchInternal;
			}
		}

		// Token: 0x17009F1C RID: 40732
		// (get) Token: 0x060480BA RID: 295098 RVA: 0x01278D30 File Offset: 0x01276F30
		public double MotionBlurModifier
		{
			get
			{
				return (double)((this.MotionBlurValueInternal < 50f) ? MathUtils.Instance.RangeClamp(this.MotionBlurValueInternal, 0f, 50f, 0.1f, 0.25f) : MathUtils.Instance.RangeClamp(this.MotionBlurValueInternal, 50f, 100f, 0.25f, 0.4f));
			}
		}

		// Token: 0x17009F1D RID: 40733
		// (get) Token: 0x060480BB RID: 295099 RVA: 0x01278D98 File Offset: 0x01276F98
		public double CameraSettingArmLengthPercentage
		{
			get
			{
				if (!this.FightCamera.LogicComponent.ContainsTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"], false))
				{
					return MathUtils.Instance.RangeClamp(this.CameraSettingNormalAdditionArmLength, 0.0, 100.0, 0.0, 1.0);
				}
				return MathUtils.Instance.RangeClamp(this.CameraSettingFightAdditionArmLength, 0.0, 100.0, 0.0, 1.0);
			}
		}

		// Token: 0x17009F1E RID: 40734
		// (get) Token: 0x060480BC RID: 295100 RVA: 0x01278E30 File Offset: 0x01277030
		public EAimAssistMode AimAssistMode
		{
			get
			{
				return this.CurrentAimAssistMode;
			}
		}

		// Token: 0x17009F1F RID: 40735
		// (get) Token: 0x060480BD RID: 295101 RVA: 0x01278E38 File Offset: 0x01277038
		[Nullable(2)]
		public FightCamera FightCamera
		{
			[NullableContext(2)]
			get
			{
				return this.FightCameraInternal;
			}
		}

		// Token: 0x17009F20 RID: 40736
		// (get) Token: 0x060480BE RID: 295102 RVA: 0x01278E40 File Offset: 0x01277040
		[Nullable(2)]
		public SequenceCamera SequenceCamera
		{
			[NullableContext(2)]
			get
			{
				return this.SequenceCameraInternal;
			}
		}

		// Token: 0x17009F21 RID: 40737
		// (get) Token: 0x060480BF RID: 295103 RVA: 0x01278E48 File Offset: 0x01277048
		[Nullable(2)]
		public WidgetCamera WidgetCamera
		{
			[NullableContext(2)]
			get
			{
				return this.WidgetCameraInternal;
			}
		}

		// Token: 0x17009F22 RID: 40738
		// (get) Token: 0x060480C0 RID: 295104 RVA: 0x01278E50 File Offset: 0x01277050
		[Nullable(2)]
		public SceneCamera SceneCamera
		{
			[NullableContext(2)]
			get
			{
				return this.SceneCameraInternal;
			}
		}

		// Token: 0x17009F23 RID: 40739
		// (get) Token: 0x060480C1 RID: 295105 RVA: 0x01278E58 File Offset: 0x01277058
		[Nullable(2)]
		public OrbitalCamera OrbitalCamera
		{
			[NullableContext(2)]
			get
			{
				return this.OrbitalCameraInternal;
			}
		}

		// Token: 0x17009F24 RID: 40740
		// (get) Token: 0x060480C2 RID: 295106 RVA: 0x01278E60 File Offset: 0x01277060
		[Nullable(2)]
		public FreeCamera FreeCamera
		{
			[NullableContext(2)]
			get
			{
				return this.FreeCameraInternal;
			}
		}

		// Token: 0x17009F25 RID: 40741
		// (get) Token: 0x060480C3 RID: 295107 RVA: 0x01278E68 File Offset: 0x01277068
		public ECustomCameraMode? CameraMode
		{
			get
			{
				return this.CameraModeInternal;
			}
		}

		// Token: 0x17009F26 RID: 40742
		// (get) Token: 0x060480C4 RID: 295108 RVA: 0x01278E70 File Offset: 0x01277070
		public float ShakeModify
		{
			get
			{
				return this.ShakeModifyInternal;
			}
		}

		// Token: 0x17009F27 RID: 40743
		// (get) Token: 0x060480C5 RID: 295109 RVA: 0x01278E78 File Offset: 0x01277078
		public double FightCameraFinalDistance
		{
			get
			{
				FightCamera fightCamera = this.FightCamera;
				float? num;
				if (fightCamera == null)
				{
					num = null;
				}
				else
				{
					FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
					num = ((logicComponent != null) ? new float?(logicComponent.FinalCameraDistance) : null);
				}
				float? num2 = num;
				return (double)num2.GetValueOrDefault();
			}
		}

		// Token: 0x17009F28 RID: 40744
		// (get) Token: 0x060480C6 RID: 295110 RVA: 0x01278EC1 File Offset: 0x012770C1
		public bool ViewHideHeadEnabled
		{
			get
			{
				return this.HideHeadDisabledInternal.Count <= 0 && this.HideHeadEnabledInternal.Count > 0;
			}
		}

		// Token: 0x17009F29 RID: 40745
		// (get) Token: 0x060480C7 RID: 295111 RVA: 0x01278EE1 File Offset: 0x012770E1
		public bool LogicHideHeadEnabled
		{
			get
			{
				return this.HideHeadEnabledInternal.Count > 0;
			}
		}

		// Token: 0x17009F2A RID: 40746
		// (get) Token: 0x060480C8 RID: 295112 RVA: 0x01278EF1 File Offset: 0x012770F1
		public bool Blending
		{
			get
			{
				return this.BlendingInternal;
			}
		}

		// Token: 0x17009F2B RID: 40747
		// (get) Token: 0x060480C9 RID: 295113 RVA: 0x01278EF9 File Offset: 0x012770F9
		[Nullable(2)]
		public TimerHandle BlendTimerId
		{
			[NullableContext(2)]
			get
			{
				return this.BlendTimerIdInternal;
			}
		}

		// Token: 0x060480CA RID: 295114 RVA: 0x01278F04 File Offset: 0x01277104
		public void SetHideHeadEnabled(bool v, EHideHeadEnum firstPersonType)
		{
			bool flag = this.HideHeadEnabledInternal.Contains(firstPersonType);
			if ((v && flag) || (!v && !flag))
			{
				return;
			}
			if (v)
			{
				this.HideHeadEnabledInternal.Add(firstPersonType);
			}
			else
			{
				this.HideHeadEnabledInternal.Remove(firstPersonType);
				foreach (object obj in Enum.GetValues(typeof(EHideHeadDisabledEnum)))
				{
					EHideHeadDisabledEnum firstPersonDisableType = (EHideHeadDisabledEnum)obj;
					this.SetHideHeadDisabled(false, firstPersonDisableType);
				}
			}
			this.UpdateHeadState();
		}

		// Token: 0x060480CB RID: 295115 RVA: 0x01278FA8 File Offset: 0x012771A8
		public void SetHideHeadDisabled(bool v, EHideHeadDisabledEnum firstPersonDisableType)
		{
			bool flag = this.HideHeadDisabledInternal.Contains(firstPersonDisableType);
			if ((v && flag) || (!v && !flag))
			{
				return;
			}
			if (v)
			{
				this.HideHeadDisabledInternal.Add(firstPersonDisableType);
			}
			else
			{
				this.HideHeadDisabledInternal.Remove(firstPersonDisableType);
			}
			this.UpdateHeadState();
		}

		// Token: 0x060480CC RID: 295116 RVA: 0x01278FF4 File Offset: 0x012771F4
		private void UpdateHeadState()
		{
			if (this.ViewHideHeadEnabled)
			{
				FightCamera fightCamera = this.FightCamera;
				bool flag;
				if (fightCamera == null)
				{
					flag = false;
				}
				else
				{
					FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
					flag = ((logicComponent != null) ? new bool?(logicComponent.ContainsTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托骑乘状态"], false)) : null).GetValueOrDefault();
				}
				if (!flag)
				{
					FightCamera fightCamera2 = this.FightCamera;
					bool flag2;
					if (fightCamera2 == null)
					{
						flag2 = false;
					}
					else
					{
						FightCameraLogicComponent logicComponent2 = fightCamera2.LogicComponent;
						flag2 = ((logicComponent2 != null) ? new bool?(logicComponent2.ContainsTag(GameplayTagDefine.EGameplayTagId["功能.第一人称.隐藏头部配置.基于头骨"], false)) : null).GetValueOrDefault();
					}
					if (!flag2)
					{
						FightCamera fightCamera3 = this.FightCamera;
						if (fightCamera3 == null)
						{
							goto IL_107;
						}
						FightCameraLogicComponent logicComponent3 = fightCamera3.LogicComponent;
						if (logicComponent3 == null)
						{
							goto IL_107;
						}
						TsBaseCharacter character = logicComponent3.Character;
						if (character == null)
						{
							goto IL_107;
						}
						CharRenderingComponent charRenderingComponent = character.CharRenderingComponent;
						if (charRenderingComponent == null)
						{
							goto IL_107;
						}
						charRenderingComponent.SetDitherApplyHeadsOnly();
						goto IL_107;
					}
				}
				FightCamera fightCamera4 = this.FightCamera;
				if (fightCamera4 != null)
				{
					FightCameraLogicComponent logicComponent4 = fightCamera4.LogicComponent;
					if (logicComponent4 != null)
					{
						TsBaseCharacter character2 = logicComponent4.Character;
						if (character2 != null)
						{
							CharRenderingComponent charRenderingComponent2 = character2.CharRenderingComponent;
							if (charRenderingComponent2 != null)
							{
								charRenderingComponent2.SetDitherUseHeadMaskHideEffect(true);
							}
						}
					}
				}
				UKuroStaticLibrary.SetConsoleVariableWithCurrentPriority_Int("r.Shadow.EnableCSMStable", 0);
				IL_107:
				FightCamera fightCamera5 = this.FightCamera;
				if (fightCamera5 != null)
				{
					FightCameraLogicComponent logicComponent5 = fightCamera5.LogicComponent;
					if (logicComponent5 != null)
					{
						TsBaseCharacter character3 = logicComponent5.Character;
						if (character3 != null)
						{
							CharRenderingComponent charRenderingComponent3 = character3.CharRenderingComponent;
							if (charRenderingComponent3 != null)
							{
								charRenderingComponent3.SetDitherEffect(0f, ECharacterDitherType.Fight);
							}
						}
					}
				}
				FightCamera fightCamera6 = this.FightCamera;
				if (fightCamera6 != null)
				{
					FightCameraLogicComponent logicComponent6 = fightCamera6.LogicComponent;
					if (logicComponent6 != null)
					{
						TsBaseCharacter character4 = logicComponent6.Character;
						if (character4 != null)
						{
							CharRenderingComponent charRenderingComponent4 = character4.CharRenderingComponent;
							if (charRenderingComponent4 != null)
							{
								charRenderingComponent4.UpdateMaterialEffectsOnly();
							}
						}
					}
				}
				FightCamera fightCamera7 = this.FightCamera;
				if (fightCamera7 == null)
				{
					return;
				}
				FightCameraLogicComponent logicComponent7 = fightCamera7.LogicComponent;
				if (logicComponent7 == null)
				{
					return;
				}
				VehicleActorComponent vehicleActorComponent = logicComponent7.VehicleActorComponent;
				if (vehicleActorComponent == null)
				{
					return;
				}
				vehicleActorComponent.EnterFirstPersonMode();
				return;
			}
			else
			{
				FightCamera fightCamera8 = this.FightCamera;
				bool flag3;
				if (fightCamera8 == null)
				{
					flag3 = false;
				}
				else
				{
					FightCameraLogicComponent logicComponent8 = fightCamera8.LogicComponent;
					flag3 = ((logicComponent8 != null) ? new bool?(logicComponent8.ContainsTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托骑乘状态"], false)) : null).GetValueOrDefault();
				}
				if (!flag3)
				{
					FightCamera fightCamera9 = this.FightCamera;
					bool flag4;
					if (fightCamera9 == null)
					{
						flag4 = false;
					}
					else
					{
						FightCameraLogicComponent logicComponent9 = fightCamera9.LogicComponent;
						flag4 = ((logicComponent9 != null) ? new bool?(logicComponent9.ContainsTag(GameplayTagDefine.EGameplayTagId["功能.第一人称.隐藏头部配置.基于头骨"], false)) : null).GetValueOrDefault();
					}
					if (!flag4)
					{
						FightCamera fightCamera10 = this.FightCamera;
						if (fightCamera10 == null)
						{
							goto IL_292;
						}
						FightCameraLogicComponent logicComponent10 = fightCamera10.LogicComponent;
						if (logicComponent10 == null)
						{
							goto IL_292;
						}
						TsBaseCharacter character5 = logicComponent10.Character;
						if (character5 == null)
						{
							goto IL_292;
						}
						CharRenderingComponent charRenderingComponent5 = character5.CharRenderingComponent;
						if (charRenderingComponent5 == null)
						{
							goto IL_292;
						}
						charRenderingComponent5.SetDitherApplyAll();
						goto IL_292;
					}
				}
				FightCamera fightCamera11 = this.FightCamera;
				if (fightCamera11 != null)
				{
					FightCameraLogicComponent logicComponent11 = fightCamera11.LogicComponent;
					if (logicComponent11 != null)
					{
						TsBaseCharacter character6 = logicComponent11.Character;
						if (character6 != null)
						{
							CharRenderingComponent charRenderingComponent6 = character6.CharRenderingComponent;
							if (charRenderingComponent6 != null)
							{
								charRenderingComponent6.SetDitherUseHeadMaskHideEffect(false);
							}
						}
					}
				}
				UKuroStaticLibrary.SetConsoleVariableWithCurrentPriority_Int("r.Shadow.EnableCSMStable", 1);
				IL_292:
				FightCamera fightCamera12 = this.FightCamera;
				if (fightCamera12 != null)
				{
					FightCameraLogicComponent logicComponent12 = fightCamera12.LogicComponent;
					if (logicComponent12 != null)
					{
						TsBaseCharacter character7 = logicComponent12.Character;
						if (character7 != null)
						{
							CharRenderingComponent charRenderingComponent7 = character7.CharRenderingComponent;
							if (charRenderingComponent7 != null)
							{
								charRenderingComponent7.SetDitherEffect(1f, ECharacterDitherType.Fight);
							}
						}
					}
				}
				FightCamera fightCamera13 = this.FightCamera;
				if (fightCamera13 != null)
				{
					FightCameraLogicComponent logicComponent13 = fightCamera13.LogicComponent;
					if (logicComponent13 != null)
					{
						TsBaseCharacter character8 = logicComponent13.Character;
						if (character8 != null)
						{
							CharRenderingComponent charRenderingComponent8 = character8.CharRenderingComponent;
							if (charRenderingComponent8 != null)
							{
								charRenderingComponent8.UpdateMaterialEffectsOnly();
							}
						}
					}
				}
				FightCamera fightCamera14 = this.FightCamera;
				if (fightCamera14 == null)
				{
					return;
				}
				FightCameraLogicComponent logicComponent14 = fightCamera14.LogicComponent;
				if (logicComponent14 == null)
				{
					return;
				}
				VehicleActorComponent vehicleActorComponent2 = logicComponent14.VehicleActorComponent;
				if (vehicleActorComponent2 == null)
				{
					return;
				}
				vehicleActorComponent2.ExitFirstPersonMode();
				return;
			}
		}

		// Token: 0x060480CD RID: 295117 RVA: 0x01279324 File Offset: 0x01277524
		public unsafe void SetHidePlayer(bool v, bool useDither = false)
		{
			if (!v)
			{
				if (this.HidePlayerEntityId != 0)
				{
					EntityHandle entityById = CreatureModel.Instance.GetEntityById(this.HidePlayerEntityId);
					CharacterActorComponent characterActorComponent;
					if (entityById == null)
					{
						characterActorComponent = null;
					}
					else
					{
						WorldEntity entity = entityById.Entity;
						characterActorComponent = ((entity != null) ? entity.GetComponent<CharacterActorComponent>() : null);
					}
					CharacterActorComponent characterActorComponent2 = characterActorComponent;
					if (characterActorComponent2 != null)
					{
						if (this.HidePlayerMode == CameraModelInstance.ECameraHidePlayerMode.Dither)
						{
							CharacterDitherEffectController ditherEffectController = characterActorComponent2.Actor.DitherEffectController;
							if (ditherEffectController != null)
							{
								ditherEffectController.EnterAppearEffect(2f, ECharacterDitherType.Temporary, true);
							}
							Log instance = Log.Instance;
							ELogModule module = ELogModule.Camera;
							ELogAuthor author = ELogAuthor.FZX;
							string message = "[CameraHidePlayer] 渐显恢复玩家";
							ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", this.HidePlayerEntityId);
							instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						}
						else if (this.HidePlayerHandle != -1)
						{
							characterActorComponent2.EnableActor(this.HidePlayerHandle);
							Log instance2 = Log.Instance;
							ELogModule module2 = ELogModule.Camera;
							ELogAuthor author2 = ELogAuthor.FZX;
							string message2 = "[CameraHidePlayer] 恢复第一人称隐藏玩家";
							<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.HidePlayerEntityId);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Handle", this.HidePlayerHandle);
							instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						}
					}
					else if (this.HidePlayerMode == CameraModelInstance.ECameraHidePlayerMode.Instant && this.HidePlayerHandle != -1)
					{
						Log instance3 = Log.Instance;
						ELogModule module3 = ELogModule.Camera;
						ELogAuthor author3 = ELogAuthor.FZX;
						string message3 = "[CameraHidePlayer] 恢复第一人称隐藏玩家失败，隐藏实体不存在";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Id", this.HidePlayerEntityId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Handle", this.HidePlayerHandle);
						instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					}
				}
				this.HidePlayerHandle = -1;
				this.HidePlayerEntityId = 0;
				this.HidePlayerMode = CameraModelInstance.ECameraHidePlayerMode.None;
				return;
			}
			if (this.HidePlayerEntityId != 0)
			{
				Log.Instance.Info(ELogModule.Camera, ELogAuthor.FZX, "[CameraHidePlayer] 隐藏玩家失败，已经隐藏过一次", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null || !getCurrentEntity.Valid || getCurrentEntity.Entity == null)
			{
				Log.Instance.Info(ELogModule.Camera, ELogAuthor.FZX, "[CameraHidePlayer] 显隐玩家失败，当前操控角色不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			CharacterActorComponent component = getCurrentEntity.Entity.GetComponent<CharacterActorComponent>();
			if (((component != null) ? component.Actor : null) == null)
			{
				Log.Instance.Info(ELogModule.Camera, ELogAuthor.FZX, "[CameraHidePlayer] 显隐玩家失败，角色Actor不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.HidePlayerEntityId = getCurrentEntity.Id;
			if (!useDither)
			{
				this.HidePlayerMode = CameraModelInstance.ECameraHidePlayerMode.Instant;
				this.HidePlayerHandle = component.DisableActor("LevelEventAdjustPlayerCamera.HidePlayer");
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.Camera;
				ELogAuthor author4 = ELogAuthor.FZX;
				string message4 = "[CameraHidePlayer] 第一人称隐藏玩家";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("Id", this.HidePlayerEntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Handle", this.HidePlayerHandle);
				instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
				return;
			}
			CharacterDitherEffectController ditherEffectController2 = component.Actor.DitherEffectController;
			if (ditherEffectController2 == null)
			{
				Log.Instance.Info(ELogModule.Camera, ELogAuthor.FZX, "[CameraHidePlayer] 渐隐玩家失败，Dither组件不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.HidePlayerEntityId = 0;
				return;
			}
			this.HidePlayerMode = CameraModelInstance.ECameraHidePlayerMode.Dither;
			ditherEffectController2.EnterDisappearEffect(2f, ECharacterDitherType.Temporary, true);
			Log instance5 = Log.Instance;
			ELogModule module5 = ELogModule.Camera;
			ELogAuthor author5 = ELogAuthor.FZX;
			string message5 = "[CameraHidePlayer] 渐隐隐藏玩家";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Id", this.HidePlayerEntityId);
			instance5.Info(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}

		// Token: 0x060480CE RID: 295118 RVA: 0x01279698 File Offset: 0x01277898
		public void SetCameraShakeModify(double modify)
		{
			this.ShakeModifyInternal = (float)MathUtils.Instance.Clamp(modify, 0.0, 2.0);
		}

		// Token: 0x060480CF RID: 295119 RVA: 0x012796BE File Offset: 0x012778BE
		public void SetCameraMode(ECustomCameraMode mode)
		{
			EventSystem.Instance.Emit<ECustomCameraMode, ECustomCameraMode?, string>(EEventName.CameraModeChanged, mode, this.CameraModeInternal, this.CameraName);
			this.CameraModeInternal = new ECustomCameraMode?(mode);
			Global.PlayerController.ClientSetCameraMode(CameraUtility.GetCameraMode(mode));
		}

		// Token: 0x060480D0 RID: 295120 RVA: 0x012796FC File Offset: 0x012778FC
		private void RefreshAimAssetMode()
		{
			if (this.AimAssistModeMap.Count == 0)
			{
				this.CurrentAimAssistMode = this.DefaultAimAssistModeInternal;
				return;
			}
			this.CurrentAimAssistMode = EAimAssistMode.Closed;
			foreach (KeyValuePair<string, EAimAssistMode> keyValuePair in this.AimAssistModeMap)
			{
				this.CurrentAimAssistMode = (EAimAssistMode)Math.Max((int)this.CurrentAimAssistMode, (int)keyValuePair.Value);
			}
		}

		// Token: 0x060480D1 RID: 295121 RVA: 0x01279784 File Offset: 0x01277984
		public void SetAimAssistMode(EAimAssistMode mode)
		{
			this.DefaultAimAssistModeInternal = mode;
			this.RefreshAimAssetMode();
		}

		// Token: 0x060480D2 RID: 295122 RVA: 0x01279793 File Offset: 0x01277993
		public void SetAimAssistModeWithKey(string key, EAimAssistMode mode)
		{
			this.AimAssistModeMap[key] = mode;
			this.RefreshAimAssetMode();
		}

		// Token: 0x060480D3 RID: 295123 RVA: 0x012797A8 File Offset: 0x012779A8
		public void ClearAimAssistModeWithKey(string key)
		{
			this.AimAssistModeMap.Remove(key);
			this.RefreshAimAssetMode();
		}

		// Token: 0x060480D4 RID: 295124 RVA: 0x012797BD File Offset: 0x012779BD
		public void SetIsCameraResetPitch(bool isReset)
		{
			this.IsCameraResetPitchInternal = isReset;
		}

		// Token: 0x060480D5 RID: 295125 RVA: 0x012797C6 File Offset: 0x012779C6
		public void SetCameraBaseYawSensitivity(double sensitivity)
		{
			this.CameraBaseYawSensitivityInternal = MathUtils.Instance.Clamp(sensitivity, 0.0, 100.0);
		}

		// Token: 0x060480D6 RID: 295126 RVA: 0x012797EB File Offset: 0x012779EB
		public void SetCameraBasePitchSensitivity(double sensitivity)
		{
			this.CameraBasePitchSensitivityInternal = MathUtils.Instance.Clamp(sensitivity, 0.0, 100.0);
		}

		// Token: 0x060480D7 RID: 295127 RVA: 0x01279810 File Offset: 0x01277A10
		public void SetCameraAimingYawSensitivity(double sensitivity)
		{
			this.CameraAimingYawSensitivityInternal = MathUtils.Instance.Clamp(sensitivity, 0.0, 100.0);
		}

		// Token: 0x060480D8 RID: 295128 RVA: 0x01279835 File Offset: 0x01277A35
		public void SetCameraAimingPitchSensitivity(double sensitivity)
		{
			this.CameraAimingPitchSensitivityInternal = MathUtils.Instance.Clamp(sensitivity, 0.0, 100.0);
		}

		// Token: 0x060480D9 RID: 295129 RVA: 0x0127985A File Offset: 0x01277A5A
		public void SetCameraBaseYawReverse(bool bIsReverse)
		{
			this.CameraBaseYawReverseInternal = bIsReverse;
		}

		// Token: 0x060480DA RID: 295130 RVA: 0x01279863 File Offset: 0x01277A63
		public void SetCameraBasePitchReverse(bool bIsReverse)
		{
			this.CameraBasePitchReverseInternal = bIsReverse;
		}

		// Token: 0x060480DB RID: 295131 RVA: 0x0127986C File Offset: 0x01277A6C
		public void SetCameraAimingYawReverse(bool bIsReverse)
		{
			this.CameraAimingYawReverseInternal = bIsReverse;
		}

		// Token: 0x060480DC RID: 295132 RVA: 0x01279875 File Offset: 0x01277A75
		public void SetCameraAimingPitchReverse(bool bIsReverse)
		{
			this.CameraAimingPitchReverseInternal = bIsReverse;
		}

		// Token: 0x060480DD RID: 295133 RVA: 0x0127987E File Offset: 0x01277A7E
		public void SetMotionBlurValue(double value)
		{
			this.MotionBlurValueInternal = (float)MathUtils.Instance.Clamp(value, 0.0, 100.0);
			GameSettingsManager.Instance.HandleValueChange(EFunction.MOTIONBLUR, (int)this.MotionBlurValueInternal, EGameSettingsApplyReason.AnyTime);
		}

		// Token: 0x060480DE RID: 295134 RVA: 0x012798B8 File Offset: 0x01277AB8
		public void SetBlending(bool blending)
		{
			this.BlendingInternal = blending;
		}

		// Token: 0x060480DF RID: 295135 RVA: 0x012798C1 File Offset: 0x01277AC1
		[NullableContext(2)]
		public void SetBlendTimerId(TimerHandle timerId)
		{
			this.BlendTimerIdInternal = timerId;
		}

		// Token: 0x060480E0 RID: 295136 RVA: 0x012798CA File Offset: 0x01277ACA
		public void EnableMode(ECustomCameraMode mode)
		{
			this.CameraModeEnabledArray[(int)mode] = true;
		}

		// Token: 0x060480E1 RID: 295137 RVA: 0x012798D9 File Offset: 0x01277AD9
		public void DisableMode(ECustomCameraMode mode)
		{
			this.CameraModeEnabledArray[(int)mode] = false;
		}

		// Token: 0x060480E2 RID: 295138 RVA: 0x012798E8 File Offset: 0x01277AE8
		public bool IsModeEnabled(ECustomCameraMode mode)
		{
			return this.CameraModeEnabledArray[(int)mode];
		}

		// Token: 0x060480E3 RID: 295139 RVA: 0x012798F8 File Offset: 0x01277AF8
		public ECustomCameraMode GetNextMode()
		{
			foreach (int num in this.CameraModeSequence)
			{
				if (this.CameraModeEnabledArray[num])
				{
					return (ECustomCameraMode)num;
				}
			}
			return ECustomCameraMode.LockOn;
		}

		// Token: 0x060480E4 RID: 295140 RVA: 0x0127995C File Offset: 0x01277B5C
		public bool IsInHigherMode(ECustomCameraMode mode)
		{
			return this.CameraMode != null && this.CameraModePriorityValues[(int)this.CameraMode.Value] > this.CameraModePriorityValues[(int)mode];
		}

		// Token: 0x060480E5 RID: 295141 RVA: 0x012799A2 File Offset: 0x01277BA2
		public void SetAimAssistEnable(bool isEnable)
		{
			this.IsAimAssistEnable = isEnable;
		}

		// Token: 0x060480E6 RID: 295142 RVA: 0x012799AB File Offset: 0x01277BAB
		public bool GetAimAssistEnable()
		{
			return this.IsAimAssistEnable;
		}

		// Token: 0x060480E7 RID: 295143 RVA: 0x012799B4 File Offset: 0x01277BB4
		public int EnableSoftLock(string reason)
		{
			HashSet<int> softLockEnableHandleSet = this.SoftLockEnableHandleSet;
			int num = this.SoftLockEnableHandle + 1;
			this.SoftLockEnableHandle = num;
			softLockEnableHandleSet.Add(num);
			return this.SoftLockEnableHandle;
		}

		// Token: 0x060480E8 RID: 295144 RVA: 0x012799E4 File Offset: 0x01277BE4
		public void DisableSoftLock(int enableHandle, string reason)
		{
			if (!this.SoftLockEnableHandleSet.Contains(enableHandle))
			{
				return;
			}
			this.SoftLockEnableHandleSet.Remove(enableHandle);
		}

		// Token: 0x060480E9 RID: 295145 RVA: 0x01279A02 File Offset: 0x01277C02
		public void SetSettingSoftLockState(bool isEnable)
		{
			this.IsEnableSoftLockCamera = isEnable;
		}

		// Token: 0x060480EA RID: 295146 RVA: 0x01279A0B File Offset: 0x01277C0B
		public bool IsSoftLockEnable()
		{
			return this.IsEnableSoftLockCamera || this.SoftLockEnableHandleSet.Count > 0;
		}

		// Token: 0x060480EB RID: 295147 RVA: 0x01279A28 File Offset: 0x01277C28
		public int EnableCameraSpecificLockEntity(int entityId, int priority, ECameraSpecificLockGroup group = ECameraSpecificLockGroup.Normal)
		{
			int num = this.CameraLockId + 1;
			this.CameraLockId = num;
			CameraSpecificLockEntity cameraSpecificLockEntity = new CameraSpecificLockEntity(entityId, priority, num, group);
			this.CameraSpecificLockTargetList.Push(cameraSpecificLockEntity);
			this.CameraSpecificLockTargetMap[cameraSpecificLockEntity.Id] = cameraSpecificLockEntity;
			return cameraSpecificLockEntity.Id;
		}

		// Token: 0x060480EC RID: 295148 RVA: 0x01279A74 File Offset: 0x01277C74
		public int EnableCameraSpecificLockLocation(Vector location, int priority, ECameraSpecificLockGroup group = ECameraSpecificLockGroup.Normal)
		{
			int num = this.CameraLockId + 1;
			this.CameraLockId = num;
			CameraSpecificLocLocation cameraSpecificLocLocation = new CameraSpecificLocLocation(location, priority, num, group);
			this.CameraSpecificLockTargetList.Push(cameraSpecificLocLocation);
			this.CameraSpecificLockTargetMap[cameraSpecificLocLocation.Id] = cameraSpecificLocLocation;
			return cameraSpecificLocLocation.Id;
		}

		// Token: 0x060480ED RID: 295149 RVA: 0x01279AC0 File Offset: 0x01277CC0
		public void DisableCameraSpecificLockTarget(int id)
		{
			CameraSpecificLockTarget cameraSpecificLockTarget;
			if (!this.CameraSpecificLockTargetMap.TryGetValue(id, out cameraSpecificLockTarget))
			{
				return;
			}
			cameraSpecificLockTarget.MarkDelete = true;
		}

		// Token: 0x060480EE RID: 295150 RVA: 0x01279AE8 File Offset: 0x01277CE8
		[NullableContext(2)]
		public CameraSpecificLockTarget GetCameraSpecificLockTarget()
		{
			while (!this.CameraSpecificLockTargetList.Empty)
			{
				CameraSpecificLockTarget top = this.CameraSpecificLockTargetList.Top;
				if (top == null)
				{
					return null;
				}
				if (!top.MarkDelete && top.IsValid())
				{
					return top;
				}
				this.CameraSpecificLockTargetList.Pop();
				this.CameraSpecificLockTargetMap.Remove(top.Id);
			}
			return null;
		}

		// Token: 0x060480EF RID: 295151 RVA: 0x01279B48 File Offset: 0x01277D48
		public void PlaySpecialMovieCamera(string movieCameraConfigRowName, [Nullable(2)] Action<bool> callback = null)
		{
			if (this.CameraMovieModeController == null)
			{
				return;
			}
			this.CameraMovieModeController.PlaySpecialMovieCamera(movieCameraConfigRowName, callback).Forget();
		}

		// Token: 0x060480F0 RID: 295152 RVA: 0x01279B65 File Offset: 0x01277D65
		public bool IsPlayingSpecialMovieCamera(string specialMovieCameraConfigKey)
		{
			return this.CameraMovieModeController != null && this.CameraMovieModeController.IsPlayingSpecialMovieCamera(specialMovieCameraConfigKey);
		}

		// Token: 0x060480F1 RID: 295153 RVA: 0x01279B7D File Offset: 0x01277D7D
		public void PlayMovieCamera(string movieCameraConfigRowName, int initialPlayCameraIndex = -1, [Nullable(2)] Action<bool> callback = null)
		{
			if (this.CameraMovieModeController == null)
			{
				return;
			}
			this.CameraMovieModeController.PlayMovieCamera(movieCameraConfigRowName, initialPlayCameraIndex, callback).Forget();
		}

		// Token: 0x060480F2 RID: 295154 RVA: 0x01279B9B File Offset: 0x01277D9B
		public void PauseMovieCamera()
		{
			if (this.CameraMovieModeController == null)
			{
				return;
			}
			this.CameraMovieModeController.PauseMovieCamera();
		}

		// Token: 0x060480F3 RID: 295155 RVA: 0x01279BB1 File Offset: 0x01277DB1
		public void ResumeMovieCamera()
		{
			if (this.CameraMovieModeController == null)
			{
				return;
			}
			this.CameraMovieModeController.ResumeMovieCamera();
		}

		// Token: 0x060480F4 RID: 295156 RVA: 0x01279BC7 File Offset: 0x01277DC7
		public void StopMovieCamera([Nullable(2)] Action<bool> callback = null, string reason = "外部调用,停止播放")
		{
			if (this.CameraMovieModeController == null)
			{
				return;
			}
			this.CameraMovieModeController.StopMovieCamera(callback, reason);
		}

		// Token: 0x060480F5 RID: 295157 RVA: 0x01279BE0 File Offset: 0x01277DE0
		public bool HasLockTarget()
		{
			FightCamera fightCamera = this.FightCamera;
			if (((fightCamera != null) ? fightCamera.LogicComponent : null) == null)
			{
				return false;
			}
			EntityHandle targetEntity = this.FightCamera.LogicComponent.TargetEntity;
			return targetEntity != null && targetEntity.Valid && this.FightCamera.LogicComponent.IsTargetLocationValid;
		}

		// Token: 0x060480F6 RID: 295158 RVA: 0x01279C33 File Offset: 0x01277E33
		public bool GetLockTargetLocation(Vector outVector)
		{
			outVector.Reset();
			if (!this.HasLockTarget())
			{
				return false;
			}
			outVector.DeepCopy(this.FightCamera.LogicComponent.TargetLocation);
			return true;
		}

		// Token: 0x060480F7 RID: 295159 RVA: 0x01279C5C File Offset: 0x01277E5C
		public void SaveSeqCamera()
		{
			SequenceCamera sequenceCamera = this.SequenceCamera;
			SeqCameraThings savedSeqCameraThings;
			if (sequenceCamera == null)
			{
				savedSeqCameraThings = null;
			}
			else
			{
				SequenceCameraPlayerComponent playerComponent = sequenceCamera.PlayerComponent;
				savedSeqCameraThings = ((playerComponent != null) ? playerComponent.SaveSeqCamera() : null);
			}
			this.SavedSeqCameraThings = savedSeqCameraThings;
		}

		// Token: 0x060480F8 RID: 295160 RVA: 0x01279C82 File Offset: 0x01277E82
		[NullableContext(2)]
		public SeqCameraThings GetSavedSeqCameraThings()
		{
			return this.SavedSeqCameraThings;
		}

		// Token: 0x060480F9 RID: 295161 RVA: 0x01279C8A File Offset: 0x01277E8A
		public void ResetSavedSeqCameraThings()
		{
			this.SavedSeqCameraThings = null;
		}

		// Token: 0x060480FA RID: 295162 RVA: 0x01279C94 File Offset: 0x01277E94
		public bool IsToLockOnCameraMode()
		{
			ECustomCameraMode? cameraMode = this.CameraMode;
			ECustomCameraMode ecustomCameraMode = ECustomCameraMode.LockOn;
			return cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null;
		}

		// Token: 0x060480FB RID: 295163 RVA: 0x01279CBC File Offset: 0x01277EBC
		public bool IsToSceneCameraMode()
		{
			ECustomCameraMode? cameraMode = this.CameraMode;
			ECustomCameraMode ecustomCameraMode = ECustomCameraMode.Scene;
			return cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null;
		}

		// Token: 0x060480FC RID: 295164 RVA: 0x01279CE4 File Offset: 0x01277EE4
		public void SetViewInfo(Vector2D viewLocation, Vector2D viewSize, bool enableScissorOffset)
		{
			this.SeparateCameraLayout.SetViewInfo(viewLocation, viewSize, enableScissorOffset);
		}

		// Token: 0x060480FD RID: 295165 RVA: 0x01279CF4 File Offset: 0x01277EF4
		public void SetTargetViewInfo(float blendTime, Vector2D targetViewLocation, Vector2D targetViewSize, bool enableScissorOffset = false, [Nullable(2)] UCurveFloat blendCurve = null, [Nullable(2)] Action callback = null)
		{
			this.SeparateCameraLayout.SetTargetViewInfo(blendTime, targetViewLocation, targetViewSize, enableScissorOffset, blendCurve, callback);
		}

		// Token: 0x060480FE RID: 295166 RVA: 0x01279D0A File Offset: 0x01277F0A
		public void UpdateCameraLayout(float deltaTime)
		{
			this.SeparateCameraLayout.BlendToTarget(deltaTime);
			this.UpdateBoundScreenEffectsAlpha();
		}

		// Token: 0x060480FF RID: 295167 RVA: 0x01279D1E File Offset: 0x01277F1E
		public void BindScreenEffect(int handleId)
		{
			this.BoundScreenEffectHandleIds.Add(handleId);
		}

		// Token: 0x06048100 RID: 295168 RVA: 0x01279D2D File Offset: 0x01277F2D
		public void UnbindScreenEffect(int handleId)
		{
			this.BoundScreenEffectHandleIds.Remove(handleId);
			ScreenEffectModel instance = ScreenEffectModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.TrySetScreenEffectAlpha(handleId, 0f);
		}

		// Token: 0x06048101 RID: 295169 RVA: 0x01279D54 File Offset: 0x01277F54
		private void UpdateBoundScreenEffectsAlpha()
		{
			if (this.BoundScreenEffectHandleIds.Count == 0)
			{
				return;
			}
			SeparateCameraLayout separateCameraLayout = this.SeparateCameraLayout;
			if (separateCameraLayout == null)
			{
				return;
			}
			ScreenEffectModel instance = ScreenEffectModel.Instance;
			double num = separateCameraLayout.CurrentViewLocation.X + separateCameraLayout.CurrentViewSize.X;
			double num2 = double.IsFinite(num) ? MathUtils.Instance.Clamp(num, 0.0, 1.0) : 0.0;
			foreach (int num3 in this.BoundScreenEffectHandleIds.ToArray<int>())
			{
				if (!instance.TrySetScreenEffectAlpha(num3, (float)num2))
				{
					this.BoundScreenEffectHandleIds.Remove(num3);
				}
			}
		}

		// Token: 0x06048102 RID: 295170 RVA: 0x01279E0A File Offset: 0x0127800A
		public bool IsEnableScissorOffsetCenter()
		{
			SeparateCameraLayout separateCameraLayout = this.SeparateCameraLayout;
			return separateCameraLayout != null && separateCameraLayout.EnableScissorOffset;
		}

		// Token: 0x06048103 RID: 295171 RVA: 0x01279E20 File Offset: 0x01278020
		public void UpdateCameraDitherRadius()
		{
			if (Time.Instance.Now < (double)this.NextFindStartHideDistanceTime)
			{
				return;
			}
			this.NextFindStartHideDistanceTime = (float)(Time.Instance.Now + 1000.0);
			List<EntityHandle> list = new List<EntityHandle>();
			CreatureModel.Instance.GetEntitiesInRange(2000f, EEntityTypeQuery.Character, list, true, false);
			this.CameraDitherStartHideDistance = this.FightCamera.LogicComponent.StartHideDistance;
			foreach (EntityHandle entityHandle in list)
			{
				WorldEntity entity = entityHandle.Entity;
				if (entity != null && entity.Active)
				{
					CharacterActorComponent component = entityHandle.Entity.GetComponent<CharacterActorComponent>();
					if (component != null && component.StartHideDistance > this.CameraDitherStartHideDistance)
					{
						this.CameraDitherStartHideDistance = component.StartHideDistance;
					}
				}
			}
		}

		// Token: 0x06048104 RID: 295172 RVA: 0x01279F0C File Offset: 0x0127810C
		public bool Init()
		{
			if (this.CameraName != "MainCamera")
			{
				APlayerController playerController = Global.PlayerController;
				this.PlayerCameraManagerInternal = ((playerController != null) ? playerController.SpawnPlayerCameraManager() : null);
				if (this.PlayerCameraManagerInternal != null)
				{
					UActorComponent componentByClass = this.PlayerCameraManagerInternal.GetComponentByClass(UAkComponent.StaticClass());
					this.PlayerCameraManagerInternal.K2_DestroyComponent(componentByClass);
				}
			}
			this.SeparateCameraLayout = new SeparateCameraLayout(this);
			if (this.CameraName == "MainCamera")
			{
				this.SeparateCameraLayout.SetViewInfo(Vector2D.Create(0.0, 0.0), Vector2D.Create(1.0, 1.0), false);
			}
			else
			{
				this.SeparateCameraLayout.SetViewInfo(Vector2D.Create(1.0, 0.0), Vector2D.Create(0.0, 1.0), false);
			}
			this.SequenceCameraInternal = EntitySystem.Instance.Create<SequenceCamera>(-100, new EntityArgs<CameraModelInstance>(this));
			EntitySystem.Instance.Init(this.SequenceCameraInternal);
			EntitySystem.Instance.Start(this.SequenceCameraInternal);
			EntitySystem.Instance.Activate(this.SequenceCameraInternal);
			EntitySystem.Instance.PostActive(this.SequenceCameraInternal);
			this.SequenceCameraInternal.SetTimeDilation(Time.Instance.TimeDilation);
			this.FightCameraInternal = EntitySystem.Instance.Create<FightCamera>(-100, new EntityArgs<CameraModelInstance>(this));
			EntitySystem.Instance.Init(this.FightCameraInternal);
			EntitySystem.Instance.Start(this.FightCameraInternal);
			EntitySystem.Instance.Activate(this.FightCameraInternal);
			EntitySystem.Instance.PostActive(this.FightCameraInternal);
			this.FightCameraInternal.SetTimeDilation(Time.Instance.TimeDilation);
			this.WidgetCameraInternal = EntitySystem.Instance.Create<WidgetCamera>(-100, new EntityArgs<CameraModelInstance>(this));
			EntitySystem.Instance.Init(this.WidgetCameraInternal);
			EntitySystem.Instance.Start(this.WidgetCameraInternal);
			EntitySystem.Instance.Activate(this.WidgetCameraInternal);
			EntitySystem.Instance.PostActive(this.WidgetCameraInternal);
			this.WidgetCameraInternal.SetTimeDilation(Time.Instance.TimeDilation);
			this.SceneCameraInternal = EntitySystem.Instance.Create<SceneCamera>(-100, new EntityArgs<CameraModelInstance>(this));
			EntitySystem.Instance.Init(this.SceneCameraInternal);
			EntitySystem.Instance.Start(this.SceneCameraInternal);
			EntitySystem.Instance.Activate(this.SceneCameraInternal);
			EntitySystem.Instance.PostActive(this.SceneCameraInternal);
			this.SceneCameraInternal.SetTimeDilation(Time.Instance.TimeDilation);
			this.OrbitalCameraInternal = EntitySystem.Instance.Create<OrbitalCamera>(-100, new EntityArgs<CameraModelInstance>(this));
			EntitySystem.Instance.Init(this.OrbitalCameraInternal);
			EntitySystem.Instance.Start(this.OrbitalCameraInternal);
			EntitySystem.Instance.Activate(this.OrbitalCameraInternal);
			EntitySystem.Instance.PostActive(this.OrbitalCameraInternal);
			this.OrbitalCameraInternal.SetTimeDilation(Time.Instance.TimeDilation);
			Global.CharacterCameraManager.CameraModifyCustomTimeDilation = Time.Instance.TimeDilation;
			this.CameraTransform = new FTransformDouble?(new FTransformDouble());
			this.CameraMovieModeController = new CameraMovieModeController();
			this.CameraMovieModeController.Start(this);
			for (int i = 0; i <= 5; i++)
			{
				this.CameraModeEnabledArray.Add(false);
				this.CameraModePriorityValues.Add(0);
			}
			this.CameraModeEnabledArray[0] = true;
			this.CameraModeSequence.Add(1);
			this.CameraModeSequence.Add(2);
			this.CameraModeSequence.Add(3);
			this.CameraModeSequence.Add(4);
			this.CameraModeSequence.Add(5);
			this.CameraModeSequence.Add(0);
			for (int j = 0; j < this.CameraModeSequence.Count; j++)
			{
				this.CameraModePriorityValues[this.CameraModeSequence[j]] = this.CameraModeSequence.Count - j;
			}
			this.SavedSeqCameraThings = null;
			EventSystem.Instance.Add<float, string>(EEventName.CameraViewTargetChanged, new Action<float, string>(this.OnCameraViewTargetChanged));
			return this.FightCameraInternal.Valid && this.SequenceCameraInternal.Valid && this.WidgetCameraInternal.Valid && this.SceneCameraInternal.Valid && this.OrbitalCameraInternal.Valid;
		}

		// Token: 0x06048105 RID: 295173 RVA: 0x0127A398 File Offset: 0x01278598
		public bool Clear()
		{
			EventSystem.Instance.Remove<float, string>(EEventName.CameraViewTargetChanged, new Action<float, string>(this.OnCameraViewTargetChanged));
			this.BoundScreenEffectHandleIds.Clear();
			this.CameraSpecificLockTargetList.Clear();
			this.CameraSpecificLockTargetMap.Clear();
			Global.CharacterCameraManager.CameraModifyCustomTimeDilation = 1f;
			bool flag = EntitySystem.Instance.Destroy<FightCamera>(this.FightCameraInternal);
			this.FightCameraInternal = null;
			bool flag2 = flag & EntitySystem.Instance.Destroy<SequenceCamera>(this.SequenceCameraInternal);
			this.SequenceCameraInternal = null;
			bool flag3 = flag2 & EntitySystem.Instance.Destroy<WidgetCamera>(this.WidgetCameraInternal);
			this.WidgetCameraInternal = null;
			bool flag4 = flag3 & EntitySystem.Instance.Destroy<SceneCamera>(this.SceneCameraInternal);
			this.SceneCameraInternal = null;
			bool flag5 = flag4 & EntitySystem.Instance.Destroy<OrbitalCamera>(this.OrbitalCameraInternal);
			this.OrbitalCameraInternal = null;
			bool result = flag5 & this.DestroyFreeCamera();
			this.CameraTransform = null;
			this.SavedSeqCameraThings = null;
			CameraMovieModeController cameraMovieModeController = this.CameraMovieModeController;
			if (cameraMovieModeController != null)
			{
				cameraMovieModeController.End();
			}
			this.CameraMovieModeController = null;
			this.DitherEntityGroups.Clear();
			if (this.CameraName != "MainCamera" && this.PlayerCameraManagerInternal != null)
			{
				APlayerController playerController = Global.PlayerController;
				if (playerController != null)
				{
					playerController.AdditionalPlayerCameraManagers.Remove(this.PlayerCameraManagerInternal);
				}
				this.PlayerCameraManagerInternal.K2_DestroyActor();
				this.PlayerCameraManagerInternal = null;
			}
			return result;
		}

		// Token: 0x06048106 RID: 295174 RVA: 0x0127A4F0 File Offset: 0x012786F0
		public bool CreateFreeCamera()
		{
			this.FreeCameraInternal = EntitySystem.Instance.Create<FreeCamera>(-100, new EntityArgs<CameraModelInstance>(this));
			EntitySystem.Instance.Init(this.FreeCameraInternal);
			EntitySystem.Instance.Start(this.FreeCameraInternal);
			EntitySystem.Instance.Activate(this.FreeCameraInternal);
			EntitySystem.Instance.PostActive(this.FreeCameraInternal);
			this.FreeCameraInternal.SetTimeDilation(Time.Instance.TimeDilation);
			return this.FreeCameraInternal.Valid;
		}

		// Token: 0x06048107 RID: 295175 RVA: 0x0127A57C File Offset: 0x0127877C
		public bool DestroyFreeCamera()
		{
			if (this.FreeCameraInternal == null)
			{
				return true;
			}
			bool result = EntitySystem.Instance.Destroy<FreeCamera>(this.FreeCameraInternal);
			this.FreeCameraInternal = null;
			return result;
		}

		// Token: 0x06048108 RID: 295176 RVA: 0x0127A5A0 File Offset: 0x012787A0
		private void OnCameraViewTargetChanged(float blendTime, string cameraName)
		{
			if (cameraName != this.CameraName)
			{
				return;
			}
			if (!this.LogicHideHeadEnabled)
			{
				return;
			}
			ECustomCameraMode? cameraMode = this.CameraMode;
			ECustomCameraMode ecustomCameraMode = ECustomCameraMode.Widget;
			if (cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null)
			{
				this.SetHideHeadDisabled(true, EHideHeadDisabledEnum.UI);
				FightCamera fightCamera = this.FightCamera;
				if (fightCamera != null)
				{
					FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
					if (logicComponent != null)
					{
						logicComponent.ForceTickOutSide();
					}
				}
				FightCamera fightCamera2 = this.FightCamera;
				if (fightCamera2 == null)
				{
					return;
				}
				FightCameraLogicComponent logicComponent2 = fightCamera2.LogicComponent;
				if (logicComponent2 == null)
				{
					return;
				}
				TsBaseCharacter character = logicComponent2.Character;
				if (character == null)
				{
					return;
				}
				CharRenderingComponent charRenderingComponent = character.CharRenderingComponent;
				if (charRenderingComponent == null)
				{
					return;
				}
				charRenderingComponent.UpdateMaterialEffectsOnly();
				return;
			}
			else
			{
				this.SetHideHeadDisabled(false, EHideHeadDisabledEnum.UI);
				FightCamera fightCamera3 = this.FightCamera;
				if (fightCamera3 != null)
				{
					FightCameraLogicComponent logicComponent3 = fightCamera3.LogicComponent;
					if (logicComponent3 != null)
					{
						logicComponent3.ForceTickOutSide();
					}
				}
				FightCamera fightCamera4 = this.FightCamera;
				if (fightCamera4 == null)
				{
					return;
				}
				FightCameraLogicComponent logicComponent4 = fightCamera4.LogicComponent;
				if (logicComponent4 == null)
				{
					return;
				}
				TsBaseCharacter character2 = logicComponent4.Character;
				if (character2 == null)
				{
					return;
				}
				CharRenderingComponent charRenderingComponent2 = character2.CharRenderingComponent;
				if (charRenderingComponent2 == null)
				{
					return;
				}
				charRenderingComponent2.UpdateMaterialEffectsOnly();
				return;
			}
		}

		// Token: 0x06048109 RID: 295177 RVA: 0x0127A687 File Offset: 0x01278887
		private static int CompareCameraSpecificLockIdPriority(CameraSpecificLockTarget a, CameraSpecificLockTarget b)
		{
			if (a.Group != b.Group)
			{
				return b.Group - a.Group;
			}
			if (a.Priority == b.Priority)
			{
				return -1;
			}
			return b.Priority - a.Priority;
		}

		// Token: 0x04025FEC RID: 155628
		private const int CAMERA_TICK_PRIORITY = -100;

		// Token: 0x04025FED RID: 155629
		private const int CAMERA_DEFAULT_SENSITIVITY = 50;

		// Token: 0x04025FEE RID: 155630
		private const int CAMERA_MAX_SENSITIVITY = 100;

		// Token: 0x04025FEF RID: 155631
		private const int CAMERA_MIN_SENSITIVITY = 0;

		// Token: 0x04025FF0 RID: 155632
		private const int CAMERA_DEFAULT_SENSITIVITY_MODIFIER = 1;

		// Token: 0x04025FF1 RID: 155633
		private const int CAMERA_MAX_SENSITIVITY_MODIFIER = 2;

		// Token: 0x04025FF2 RID: 155634
		private const float CAMERA_MIN_SENSITIVITY_MODIFIER = 0.1f;

		// Token: 0x04025FF3 RID: 155635
		private const int MOTION_BLUR_DEFAULT_VALUE = 50;

		// Token: 0x04025FF4 RID: 155636
		private const int MOTION_BLUR_MAX_VALUE = 100;

		// Token: 0x04025FF5 RID: 155637
		private const int MOTION_BLUR_MIN_VALUE = 0;

		// Token: 0x04025FF6 RID: 155638
		private const float MOTION_BLUR_DEFAULT_MODIFIER = 0.25f;

		// Token: 0x04025FF7 RID: 155639
		private const float MOTION_BLUR_MAX_MODIFIER = 0.4f;

		// Token: 0x04025FF8 RID: 155640
		private const float MOTION_BLUR_MIN_MODIFIER = 0.1f;

		// Token: 0x04025FF9 RID: 155641
		private const bool CAMERA_DEFAULT_REVERSE = false;

		// Token: 0x04025FFA RID: 155642
		private const int CAMERA_ADDITION_ARM_LENGTH_VALUE_MAX = 100;

		// Token: 0x04025FFB RID: 155643
		private const int CAMERA_ADDITION_ARM_LENGTH_VALUE_DEFAULT = 50;

		// Token: 0x04025FFC RID: 155644
		private const int CAMERA_ADDITION_ARM_LENGTH_VALUE_MIN = 0;

		// Token: 0x04025FFD RID: 155645
		private const int CAMERA_SHAKE_MODIFIER_MIN = 0;

		// Token: 0x04025FFE RID: 155646
		private const int CAMERA_SHAKE_MODIFIER_MAX = 2;

		// Token: 0x04025FFF RID: 155647
		private const float HIDE_PLAYER_DITHER_SPEED_RATE = 2f;

		// Token: 0x04026001 RID: 155649
		public bool AimAssistDebugDraw;

		// Token: 0x04026002 RID: 155650
		public bool CameraDebugToolEnabled;

		// Token: 0x04026003 RID: 155651
		public bool CameraDebugToolDrawRotator;

		// Token: 0x04026004 RID: 155652
		public bool CameraDebugToolDrawCameraCollision;

		// Token: 0x04026005 RID: 155653
		public bool CameraDebugToolDrawSpringArm;

		// Token: 0x04026006 RID: 155654
		public bool CameraDebugToolDrawFocusTargetLine;

		// Token: 0x04026007 RID: 155655
		public bool CameraDebugToolDrawSpringArmEdgeRange;

		// Token: 0x04026008 RID: 155656
		public bool CameraDebugToolDrawLockCameraMoveLine;

		// Token: 0x04026009 RID: 155657
		public bool CameraDebugToolDrawSettlementCamera;

		// Token: 0x0402600A RID: 155658
		public bool CameraDebugToolDrawCameraZone;

		// Token: 0x0402600B RID: 155659
		public bool CameraDebugToolDrawCameraRotator;

		// Token: 0x0402600C RID: 155660
		public bool UiCameraDebugToolEnabled;

		// Token: 0x0402600D RID: 155661
		[Nullable(2)]
		private APlayerCameraManager PlayerCameraManagerInternal;

		// Token: 0x0402600E RID: 155662
		[Nullable(2)]
		public AActor CurrentCameraActor;

		// Token: 0x0402600F RID: 155663
		[Nullable(2)]
		public UCameraComponent CurrentCameraComponent;

		// Token: 0x04026010 RID: 155664
		public Vector CameraLocation = Vector.Create();

		// Token: 0x04026011 RID: 155665
		public Rotator CameraRotator = Rotator.Create();

		// Token: 0x04026012 RID: 155666
		public FTransformDouble? CameraTransform;

		// Token: 0x04026013 RID: 155667
		public float CameraDitherStartHideDistance;

		// Token: 0x04026014 RID: 155668
		public float NextFindStartHideDistanceTime;

		// Token: 0x04026015 RID: 155669
		[Nullable(2)]
		private FightCamera FightCameraInternal;

		// Token: 0x04026016 RID: 155670
		[Nullable(2)]
		private SequenceCamera SequenceCameraInternal;

		// Token: 0x04026017 RID: 155671
		[Nullable(2)]
		private WidgetCamera WidgetCameraInternal;

		// Token: 0x04026018 RID: 155672
		[Nullable(2)]
		private SceneCamera SceneCameraInternal;

		// Token: 0x04026019 RID: 155673
		[Nullable(2)]
		private OrbitalCamera OrbitalCameraInternal;

		// Token: 0x0402601A RID: 155674
		[Nullable(2)]
		private FreeCamera FreeCameraInternal;

		// Token: 0x0402601B RID: 155675
		private ECustomCameraMode? CameraModeInternal;

		// Token: 0x0402601C RID: 155676
		private readonly List<bool> CameraModeEnabledArray = new List<bool>();

		// Token: 0x0402601D RID: 155677
		private readonly List<int> CameraModeSequence = new List<int>();

		// Token: 0x0402601E RID: 155678
		private readonly List<int> CameraModePriorityValues = new List<int>();

		// Token: 0x0402601F RID: 155679
		[Nullable(2)]
		public CameraMovieModeController CameraMovieModeController;

		// Token: 0x04026020 RID: 155680
		public bool IsInCameraModeBlending;

		// Token: 0x04026021 RID: 155681
		private bool BlendingInternal;

		// Token: 0x04026022 RID: 155682
		[Nullable(2)]
		private TimerHandle BlendTimerIdInternal;

		// Token: 0x04026023 RID: 155683
		private float ShakeModifyInternal = 1f;

		// Token: 0x04026024 RID: 155684
		private EAimAssistMode DefaultAimAssistModeInternal = EAimAssistMode.OpenOnStart;

		// Token: 0x04026025 RID: 155685
		private readonly Dictionary<string, EAimAssistMode> AimAssistModeMap = new Dictionary<string, EAimAssistMode>();

		// Token: 0x04026026 RID: 155686
		private EAimAssistMode CurrentAimAssistMode;

		// Token: 0x04026027 RID: 155687
		public int CameraShakeInstanceId = -1;

		// Token: 0x04026028 RID: 155688
		public readonly Dictionary<int, UCameraShakeBase> CameraShakeMap = new Dictionary<int, UCameraShakeBase>();

		// Token: 0x04026029 RID: 155689
		[Nullable(2)]
		public SeparateCameraLayout SeparateCameraLayout;

		// Token: 0x0402602A RID: 155690
		private readonly HashSet<int> BoundScreenEffectHandleIds = new HashSet<int>();

		// Token: 0x0402602B RID: 155691
		private double CameraBaseYawSensitivityInternal = 50.0;

		// Token: 0x0402602C RID: 155692
		private double CameraBasePitchSensitivityInternal = 50.0;

		// Token: 0x0402602D RID: 155693
		private double CameraAimingYawSensitivityInternal = 50.0;

		// Token: 0x0402602E RID: 155694
		private double CameraAimingPitchSensitivityInternal = 50.0;

		// Token: 0x0402602F RID: 155695
		public bool IsEnableSpecificCameraSensitivity;

		// Token: 0x04026030 RID: 155696
		public float SpecificCameraBaseYawSensitivity = 1f;

		// Token: 0x04026031 RID: 155697
		public float SpecificCameraBasePitchSensitivity = 1f;

		// Token: 0x04026032 RID: 155698
		public float SpecificCameraAimingYawSensitivity = 1f;

		// Token: 0x04026033 RID: 155699
		public float SpecificCameraAimingPitchSensitivity = 1f;

		// Token: 0x04026034 RID: 155700
		private bool CameraBaseYawReverseInternal;

		// Token: 0x04026035 RID: 155701
		private bool CameraBasePitchReverseInternal;

		// Token: 0x04026036 RID: 155702
		private bool CameraAimingYawReverseInternal;

		// Token: 0x04026037 RID: 155703
		private bool CameraAimingPitchReverseInternal;

		// Token: 0x04026038 RID: 155704
		private bool IsCameraResetPitchInternal = true;

		// Token: 0x04026039 RID: 155705
		private float MotionBlurValueInternal = 50f;

		// Token: 0x0402603A RID: 155706
		public bool IsEnableResetFocus = true;

		// Token: 0x0402603B RID: 155707
		public bool IsEnableSidestepCamera = true;

		// Token: 0x0402603C RID: 155708
		private bool IsEnableSoftLockCamera = true;

		// Token: 0x0402603D RID: 155709
		public double CameraSettingFightAdditionArmLength = 50.0;

		// Token: 0x0402603E RID: 155710
		public double CameraSettingNormalAdditionArmLength = 50.0;

		// Token: 0x0402603F RID: 155711
		[Nullable(2)]
		private SeqCameraThings SavedSeqCameraThings;

		// Token: 0x04026040 RID: 155712
		private bool IsAimAssistEnable = true;

		// Token: 0x04026041 RID: 155713
		private readonly HashSet<int> SoftLockEnableHandleSet = new HashSet<int>();

		// Token: 0x04026042 RID: 155714
		private int SoftLockEnableHandle;

		// Token: 0x04026043 RID: 155715
		private int CameraLockId;

		// Token: 0x04026044 RID: 155716
		private readonly Dictionary<int, CameraSpecificLockTarget> CameraSpecificLockTargetMap = new Dictionary<int, CameraSpecificLockTarget>();

		// Token: 0x04026045 RID: 155717
		private readonly PriorityQueue<CameraSpecificLockTarget> CameraSpecificLockTargetList;

		// Token: 0x04026046 RID: 155718
		public readonly DisjointSet<long> DitherEntityGroups;

		// Token: 0x04026047 RID: 155719
		private readonly HashSet<EHideHeadEnum> HideHeadEnabledInternal;

		// Token: 0x04026048 RID: 155720
		private readonly HashSet<EHideHeadDisabledEnum> HideHeadDisabledInternal;

		// Token: 0x04026049 RID: 155721
		private int HidePlayerHandle;

		// Token: 0x0402604A RID: 155722
		private int HidePlayerEntityId;

		// Token: 0x0402604B RID: 155723
		private CameraModelInstance.ECameraHidePlayerMode HidePlayerMode;

		// Token: 0x0402604C RID: 155724
		public int CurSeqCameraIndex;

		// Token: 0x0200CFC8 RID: 53192
		[NullableContext(0)]
		private enum ECameraHidePlayerMode
		{
			// Token: 0x0403E7B7 RID: 255927
			None,
			// Token: 0x0403E7B8 RID: 255928
			Instant,
			// Token: 0x0403E7B9 RID: 255929
			Dither
		}

		// Token: 0x0200CFC9 RID: 53193
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403E7BA RID: 255930
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Comparison<CameraSpecificLockTarget> <0>__CompareCameraSpecificLockIdPriority;
		}
	}
}
