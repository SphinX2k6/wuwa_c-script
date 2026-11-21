using System;
using System.Collections.Generic;
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
	// Token: 0x0200643A RID: 25658
	[NullableContext(1)]
	[Nullable(0)]
	public class CameraModelInstance
	{
		// Token: 0x17007677 RID: 30327
		// (get) Token: 0x0603E49F RID: 255135 RVA: 0x0121AA55 File Offset: 0x01218C55
		public string CameraName { get; }

		// Token: 0x0603E4A0 RID: 255136 RVA: 0x0121AA60 File Offset: 0x01218C60
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

		// Token: 0x17007678 RID: 30328
		// (get) Token: 0x0603E4A1 RID: 255137 RVA: 0x0121AC0F File Offset: 0x01218E0F
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

		// Token: 0x17007679 RID: 30329
		// (get) Token: 0x0603E4A2 RID: 255138 RVA: 0x0121AC2F File Offset: 0x01218E2F
		public double CameraBaseYawSensitivity
		{
			get
			{
				return this.CameraBaseYawSensitivityInternal;
			}
		}

		// Token: 0x1700767A RID: 30330
		// (get) Token: 0x0603E4A3 RID: 255139 RVA: 0x0121AC37 File Offset: 0x01218E37
		public double CameraBasePitchSensitivity
		{
			get
			{
				return this.CameraBasePitchSensitivityInternal;
			}
		}

		// Token: 0x1700767B RID: 30331
		// (get) Token: 0x0603E4A4 RID: 255140 RVA: 0x0121AC3F File Offset: 0x01218E3F
		public double CameraAimingYawSensitivity
		{
			get
			{
				return this.CameraAimingYawSensitivityInternal;
			}
		}

		// Token: 0x1700767C RID: 30332
		// (get) Token: 0x0603E4A5 RID: 255141 RVA: 0x0121AC47 File Offset: 0x01218E47
		public double CameraAimingPitchSensitivity
		{
			get
			{
				return this.CameraAimingPitchSensitivityInternal;
			}
		}

		// Token: 0x1700767D RID: 30333
		// (get) Token: 0x0603E4A6 RID: 255142 RVA: 0x0121AC4F File Offset: 0x01218E4F
		public bool IsEnableSoftLockCameraExternal
		{
			get
			{
				return this.IsEnableSoftLockCamera;
			}
		}

		// Token: 0x1700767E RID: 30334
		// (get) Token: 0x0603E4A7 RID: 255143 RVA: 0x0121AC58 File Offset: 0x01218E58
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

		// Token: 0x1700767F RID: 30335
		// (get) Token: 0x0603E4A8 RID: 255144 RVA: 0x0121AD58 File Offset: 0x01218F58
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

		// Token: 0x17007680 RID: 30336
		// (get) Token: 0x0603E4A9 RID: 255145 RVA: 0x0121AE58 File Offset: 0x01219058
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

		// Token: 0x17007681 RID: 30337
		// (get) Token: 0x0603E4AA RID: 255146 RVA: 0x0121AF58 File Offset: 0x01219158
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

		// Token: 0x17007682 RID: 30338
		// (get) Token: 0x0603E4AB RID: 255147 RVA: 0x0121B058 File Offset: 0x01219258
		public bool IsCameraResetPitch
		{
			get
			{
				return this.IsCameraResetPitchInternal;
			}
		}

		// Token: 0x17007683 RID: 30339
		// (get) Token: 0x0603E4AC RID: 255148 RVA: 0x0121B060 File Offset: 0x01219260
		public double MotionBlurModifier
		{
			get
			{
				return (double)((this.MotionBlurValueInternal < 50f) ? MathUtils.Instance.RangeClamp(this.MotionBlurValueInternal, 0f, 50f, 0.1f, 0.25f) : MathUtils.Instance.RangeClamp(this.MotionBlurValueInternal, 50f, 100f, 0.25f, 0.4f));
			}
		}

		// Token: 0x17007684 RID: 30340
		// (get) Token: 0x0603E4AD RID: 255149 RVA: 0x0121B0C8 File Offset: 0x012192C8
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

		// Token: 0x17007685 RID: 30341
		// (get) Token: 0x0603E4AE RID: 255150 RVA: 0x0121B160 File Offset: 0x01219360
		public EAimAssistMode AimAssistMode
		{
			get
			{
				return this.CurrentAimAssistMode;
			}
		}

		// Token: 0x17007686 RID: 30342
		// (get) Token: 0x0603E4AF RID: 255151 RVA: 0x0121B168 File Offset: 0x01219368
		[Nullable(2)]
		public FightCamera FightCamera
		{
			[NullableContext(2)]
			get
			{
				return this.FightCameraInternal;
			}
		}

		// Token: 0x17007687 RID: 30343
		// (get) Token: 0x0603E4B0 RID: 255152 RVA: 0x0121B170 File Offset: 0x01219370
		[Nullable(2)]
		public SequenceCamera SequenceCamera
		{
			[NullableContext(2)]
			get
			{
				return this.SequenceCameraInternal;
			}
		}

		// Token: 0x17007688 RID: 30344
		// (get) Token: 0x0603E4B1 RID: 255153 RVA: 0x0121B178 File Offset: 0x01219378
		[Nullable(2)]
		public WidgetCamera WidgetCamera
		{
			[NullableContext(2)]
			get
			{
				return this.WidgetCameraInternal;
			}
		}

		// Token: 0x17007689 RID: 30345
		// (get) Token: 0x0603E4B2 RID: 255154 RVA: 0x0121B180 File Offset: 0x01219380
		[Nullable(2)]
		public SceneCamera SceneCamera
		{
			[NullableContext(2)]
			get
			{
				return this.SceneCameraInternal;
			}
		}

		// Token: 0x1700768A RID: 30346
		// (get) Token: 0x0603E4B3 RID: 255155 RVA: 0x0121B188 File Offset: 0x01219388
		[Nullable(2)]
		public OrbitalCamera OrbitalCamera
		{
			[NullableContext(2)]
			get
			{
				return this.OrbitalCameraInternal;
			}
		}

		// Token: 0x1700768B RID: 30347
		// (get) Token: 0x0603E4B4 RID: 255156 RVA: 0x0121B190 File Offset: 0x01219390
		[Nullable(2)]
		public FreeCamera FreeCamera
		{
			[NullableContext(2)]
			get
			{
				return this.FreeCameraInternal;
			}
		}

		// Token: 0x1700768C RID: 30348
		// (get) Token: 0x0603E4B5 RID: 255157 RVA: 0x0121B198 File Offset: 0x01219398
		public ECustomCameraMode? CameraMode
		{
			get
			{
				return this.CameraModeInternal;
			}
		}

		// Token: 0x1700768D RID: 30349
		// (get) Token: 0x0603E4B6 RID: 255158 RVA: 0x0121B1A0 File Offset: 0x012193A0
		public float ShakeModify
		{
			get
			{
				return this.ShakeModifyInternal;
			}
		}

		// Token: 0x1700768E RID: 30350
		// (get) Token: 0x0603E4B7 RID: 255159 RVA: 0x0121B1A8 File Offset: 0x012193A8
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

		// Token: 0x1700768F RID: 30351
		// (get) Token: 0x0603E4B8 RID: 255160 RVA: 0x0121B1F1 File Offset: 0x012193F1
		public bool ViewHideHeadEnabled
		{
			get
			{
				return this.HideHeadDisabledInternal.Count <= 0 && this.HideHeadEnabledInternal.Count > 0;
			}
		}

		// Token: 0x17007690 RID: 30352
		// (get) Token: 0x0603E4B9 RID: 255161 RVA: 0x0121B211 File Offset: 0x01219411
		public bool LogicHideHeadEnabled
		{
			get
			{
				return this.HideHeadEnabledInternal.Count > 0;
			}
		}

		// Token: 0x17007691 RID: 30353
		// (get) Token: 0x0603E4BA RID: 255162 RVA: 0x0121B221 File Offset: 0x01219421
		public bool Blending
		{
			get
			{
				return this.BlendingInternal;
			}
		}

		// Token: 0x17007692 RID: 30354
		// (get) Token: 0x0603E4BB RID: 255163 RVA: 0x0121B229 File Offset: 0x01219429
		[Nullable(2)]
		public TimerHandle BlendTimerId
		{
			[NullableContext(2)]
			get
			{
				return this.BlendTimerIdInternal;
			}
		}

		// Token: 0x0603E4BC RID: 255164 RVA: 0x0121B234 File Offset: 0x01219434
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

		// Token: 0x0603E4BD RID: 255165 RVA: 0x0121B2D8 File Offset: 0x012194D8
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

		// Token: 0x0603E4BE RID: 255166 RVA: 0x0121B324 File Offset: 0x01219524
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

		// Token: 0x0603E4BF RID: 255167 RVA: 0x0121B654 File Offset: 0x01219854
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

		// Token: 0x0603E4C0 RID: 255168 RVA: 0x0121B9C8 File Offset: 0x01219BC8
		public void SetCameraShakeModify(double modify)
		{
			this.ShakeModifyInternal = (float)MathUtils.Instance.Clamp(modify, 0.0, 2.0);
		}

		// Token: 0x0603E4C1 RID: 255169 RVA: 0x0121B9EE File Offset: 0x01219BEE
		public void SetCameraMode(ECustomCameraMode mode)
		{
			EventSystem.Instance.Emit<ECustomCameraMode, ECustomCameraMode?, string>(EEventName.CameraModeChanged, mode, this.CameraModeInternal, this.CameraName);
			this.CameraModeInternal = new ECustomCameraMode?(mode);
			Global.PlayerController.ClientSetCameraMode(CameraUtility.GetCameraMode(mode));
		}

		// Token: 0x0603E4C2 RID: 255170 RVA: 0x0121BA2C File Offset: 0x01219C2C
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

		// Token: 0x0603E4C3 RID: 255171 RVA: 0x0121BAB4 File Offset: 0x01219CB4
		public void SetAimAssistMode(EAimAssistMode mode)
		{
			this.DefaultAimAssistModeInternal = mode;
			this.RefreshAimAssetMode();
		}

		// Token: 0x0603E4C4 RID: 255172 RVA: 0x0121BAC3 File Offset: 0x01219CC3
		public void SetAimAssistModeWithKey(string key, EAimAssistMode mode)
		{
			this.AimAssistModeMap[key] = mode;
			this.RefreshAimAssetMode();
		}

		// Token: 0x0603E4C5 RID: 255173 RVA: 0x0121BAD8 File Offset: 0x01219CD8
		public void ClearAimAssistModeWithKey(string key)
		{
			this.AimAssistModeMap.Remove(key);
			this.RefreshAimAssetMode();
		}

		// Token: 0x0603E4C6 RID: 255174 RVA: 0x0121BAED File Offset: 0x01219CED
		public void SetIsCameraResetPitch(bool isReset)
		{
			this.IsCameraResetPitchInternal = isReset;
		}

		// Token: 0x0603E4C7 RID: 255175 RVA: 0x0121BAF6 File Offset: 0x01219CF6
		public void SetCameraBaseYawSensitivity(double sensitivity)
		{
			this.CameraBaseYawSensitivityInternal = MathUtils.Instance.Clamp(sensitivity, 0.0, 100.0);
		}

		// Token: 0x0603E4C8 RID: 255176 RVA: 0x0121BB1B File Offset: 0x01219D1B
		public void SetCameraBasePitchSensitivity(double sensitivity)
		{
			this.CameraBasePitchSensitivityInternal = MathUtils.Instance.Clamp(sensitivity, 0.0, 100.0);
		}

		// Token: 0x0603E4C9 RID: 255177 RVA: 0x0121BB40 File Offset: 0x01219D40
		public void SetCameraAimingYawSensitivity(double sensitivity)
		{
			this.CameraAimingYawSensitivityInternal = MathUtils.Instance.Clamp(sensitivity, 0.0, 100.0);
		}

		// Token: 0x0603E4CA RID: 255178 RVA: 0x0121BB65 File Offset: 0x01219D65
		public void SetCameraAimingPitchSensitivity(double sensitivity)
		{
			this.CameraAimingPitchSensitivityInternal = MathUtils.Instance.Clamp(sensitivity, 0.0, 100.0);
		}

		// Token: 0x0603E4CB RID: 255179 RVA: 0x0121BB8A File Offset: 0x01219D8A
		public void SetCameraBaseYawReverse(bool bIsReverse)
		{
			this.CameraBaseYawReverseInternal = bIsReverse;
		}

		// Token: 0x0603E4CC RID: 255180 RVA: 0x0121BB93 File Offset: 0x01219D93
		public void SetCameraBasePitchReverse(bool bIsReverse)
		{
			this.CameraBasePitchReverseInternal = bIsReverse;
		}

		// Token: 0x0603E4CD RID: 255181 RVA: 0x0121BB9C File Offset: 0x01219D9C
		public void SetCameraAimingYawReverse(bool bIsReverse)
		{
			this.CameraAimingYawReverseInternal = bIsReverse;
		}

		// Token: 0x0603E4CE RID: 255182 RVA: 0x0121BBA5 File Offset: 0x01219DA5
		public void SetCameraAimingPitchReverse(bool bIsReverse)
		{
			this.CameraAimingPitchReverseInternal = bIsReverse;
		}

		// Token: 0x0603E4CF RID: 255183 RVA: 0x0121BBAE File Offset: 0x01219DAE
		public void SetMotionBlurValue(double value)
		{
			this.MotionBlurValueInternal = (float)MathUtils.Instance.Clamp(value, 0.0, 100.0);
			GameSettingsManager.Instance.HandleValueChange(EFunction.MOTIONBLUR, (int)this.MotionBlurValueInternal, EGameSettingsApplyReason.AnyTime);
		}

		// Token: 0x0603E4D0 RID: 255184 RVA: 0x0121BBE8 File Offset: 0x01219DE8
		public void SetBlending(bool blending)
		{
			this.BlendingInternal = blending;
		}

		// Token: 0x0603E4D1 RID: 255185 RVA: 0x0121BBF1 File Offset: 0x01219DF1
		[NullableContext(2)]
		public void SetBlendTimerId(TimerHandle timerId)
		{
			this.BlendTimerIdInternal = timerId;
		}

		// Token: 0x0603E4D2 RID: 255186 RVA: 0x0121BBFA File Offset: 0x01219DFA
		public void EnableMode(ECustomCameraMode mode)
		{
			this.CameraModeEnabledArray[(int)mode] = true;
		}

		// Token: 0x0603E4D3 RID: 255187 RVA: 0x0121BC09 File Offset: 0x01219E09
		public void DisableMode(ECustomCameraMode mode)
		{
			this.CameraModeEnabledArray[(int)mode] = false;
		}

		// Token: 0x0603E4D4 RID: 255188 RVA: 0x0121BC18 File Offset: 0x01219E18
		public bool IsModeEnabled(ECustomCameraMode mode)
		{
			return this.CameraModeEnabledArray[(int)mode];
		}

		// Token: 0x0603E4D5 RID: 255189 RVA: 0x0121BC28 File Offset: 0x01219E28
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

		// Token: 0x0603E4D6 RID: 255190 RVA: 0x0121BC8C File Offset: 0x01219E8C
		public bool IsInHigherMode(ECustomCameraMode mode)
		{
			return this.CameraMode != null && this.CameraModePriorityValues[(int)this.CameraMode.Value] > this.CameraModePriorityValues[(int)mode];
		}

		// Token: 0x0603E4D7 RID: 255191 RVA: 0x0121BCD2 File Offset: 0x01219ED2
		public void SetAimAssistEnable(bool isEnable)
		{
			this.IsAimAssistEnable = isEnable;
		}

		// Token: 0x0603E4D8 RID: 255192 RVA: 0x0121BCDB File Offset: 0x01219EDB
		public bool GetAimAssistEnable()
		{
			return this.IsAimAssistEnable;
		}

		// Token: 0x0603E4D9 RID: 255193 RVA: 0x0121BCE4 File Offset: 0x01219EE4
		public int EnableSoftLock(string reason)
		{
			HashSet<int> softLockEnableHandleSet = this.SoftLockEnableHandleSet;
			int num = this.SoftLockEnableHandle + 1;
			this.SoftLockEnableHandle = num;
			softLockEnableHandleSet.Add(num);
			return this.SoftLockEnableHandle;
		}

		// Token: 0x0603E4DA RID: 255194 RVA: 0x0121BD14 File Offset: 0x01219F14
		public void DisableSoftLock(int enableHandle, string reason)
		{
			if (!this.SoftLockEnableHandleSet.Contains(enableHandle))
			{
				return;
			}
			this.SoftLockEnableHandleSet.Remove(enableHandle);
		}

		// Token: 0x0603E4DB RID: 255195 RVA: 0x0121BD32 File Offset: 0x01219F32
		public void SetSettingSoftLockState(bool isEnable)
		{
			this.IsEnableSoftLockCamera = isEnable;
		}

		// Token: 0x0603E4DC RID: 255196 RVA: 0x0121BD3B File Offset: 0x01219F3B
		public bool IsSoftLockEnable()
		{
			return this.IsEnableSoftLockCamera || this.SoftLockEnableHandleSet.Count > 0;
		}

		// Token: 0x0603E4DD RID: 255197 RVA: 0x0121BD58 File Offset: 0x01219F58
		public int EnableCameraSpecificLockEntity(int entityId, int priority, ECameraSpecificLockGroup group = ECameraSpecificLockGroup.Normal)
		{
			int num = this.CameraLockId + 1;
			this.CameraLockId = num;
			CameraSpecificLockEntity cameraSpecificLockEntity = new CameraSpecificLockEntity(entityId, priority, num, group);
			this.CameraSpecificLockTargetList.Push(cameraSpecificLockEntity);
			this.CameraSpecificLockTargetMap[cameraSpecificLockEntity.Id] = cameraSpecificLockEntity;
			return cameraSpecificLockEntity.Id;
		}

		// Token: 0x0603E4DE RID: 255198 RVA: 0x0121BDA4 File Offset: 0x01219FA4
		public int EnableCameraSpecificLockLocation(Vector location, int priority, ECameraSpecificLockGroup group = ECameraSpecificLockGroup.Normal)
		{
			int num = this.CameraLockId + 1;
			this.CameraLockId = num;
			CameraSpecificLocLocation cameraSpecificLocLocation = new CameraSpecificLocLocation(location, priority, num, group);
			this.CameraSpecificLockTargetList.Push(cameraSpecificLocLocation);
			this.CameraSpecificLockTargetMap[cameraSpecificLocLocation.Id] = cameraSpecificLocLocation;
			return cameraSpecificLocLocation.Id;
		}

		// Token: 0x0603E4DF RID: 255199 RVA: 0x0121BDF0 File Offset: 0x01219FF0
		public void DisableCameraSpecificLockTarget(int id)
		{
			CameraSpecificLockTarget cameraSpecificLockTarget;
			if (!this.CameraSpecificLockTargetMap.TryGetValue(id, out cameraSpecificLockTarget))
			{
				return;
			}
			cameraSpecificLockTarget.MarkDelete = true;
		}

		// Token: 0x0603E4E0 RID: 255200 RVA: 0x0121BE18 File Offset: 0x0121A018
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

		// Token: 0x0603E4E1 RID: 255201 RVA: 0x0121BE78 File Offset: 0x0121A078
		public void PlaySpecialMovieCamera(string movieCameraConfigRowName, [Nullable(2)] Action<bool> callback = null)
		{
			if (this.CameraMovieModeController == null)
			{
				return;
			}
			this.CameraMovieModeController.PlaySpecialMovieCamera(movieCameraConfigRowName, callback).Forget();
		}

		// Token: 0x0603E4E2 RID: 255202 RVA: 0x0121BE95 File Offset: 0x0121A095
		public bool IsPlayingSpecialMovieCamera(string specialMovieCameraConfigKey)
		{
			return this.CameraMovieModeController != null && this.CameraMovieModeController.IsPlayingSpecialMovieCamera(specialMovieCameraConfigKey);
		}

		// Token: 0x0603E4E3 RID: 255203 RVA: 0x0121BEAD File Offset: 0x0121A0AD
		public void PlayMovieCamera(string movieCameraConfigRowName, int initialPlayCameraIndex = -1, [Nullable(2)] Action<bool> callback = null)
		{
			if (this.CameraMovieModeController == null)
			{
				return;
			}
			this.CameraMovieModeController.PlayMovieCamera(movieCameraConfigRowName, initialPlayCameraIndex, callback).Forget();
		}

		// Token: 0x0603E4E4 RID: 255204 RVA: 0x0121BECB File Offset: 0x0121A0CB
		public void PauseMovieCamera()
		{
			if (this.CameraMovieModeController == null)
			{
				return;
			}
			this.CameraMovieModeController.PauseMovieCamera();
		}

		// Token: 0x0603E4E5 RID: 255205 RVA: 0x0121BEE1 File Offset: 0x0121A0E1
		public void ResumeMovieCamera()
		{
			if (this.CameraMovieModeController == null)
			{
				return;
			}
			this.CameraMovieModeController.ResumeMovieCamera();
		}

		// Token: 0x0603E4E6 RID: 255206 RVA: 0x0121BEF7 File Offset: 0x0121A0F7
		public void StopMovieCamera([Nullable(2)] Action<bool> callback = null, string reason = "外部调用,停止播放")
		{
			if (this.CameraMovieModeController == null)
			{
				return;
			}
			this.CameraMovieModeController.StopMovieCamera(callback, reason);
		}

		// Token: 0x0603E4E7 RID: 255207 RVA: 0x0121BF10 File Offset: 0x0121A110
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

		// Token: 0x0603E4E8 RID: 255208 RVA: 0x0121BF63 File Offset: 0x0121A163
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

		// Token: 0x0603E4E9 RID: 255209 RVA: 0x0121BF8C File Offset: 0x0121A18C
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

		// Token: 0x0603E4EA RID: 255210 RVA: 0x0121BFB2 File Offset: 0x0121A1B2
		[NullableContext(2)]
		public SeqCameraThings GetSavedSeqCameraThings()
		{
			return this.SavedSeqCameraThings;
		}

		// Token: 0x0603E4EB RID: 255211 RVA: 0x0121BFBA File Offset: 0x0121A1BA
		public void ResetSavedSeqCameraThings()
		{
			this.SavedSeqCameraThings = null;
		}

		// Token: 0x0603E4EC RID: 255212 RVA: 0x0121BFC4 File Offset: 0x0121A1C4
		public bool IsToLockOnCameraMode()
		{
			ECustomCameraMode? cameraMode = this.CameraMode;
			ECustomCameraMode ecustomCameraMode = ECustomCameraMode.LockOn;
			return cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null;
		}

		// Token: 0x0603E4ED RID: 255213 RVA: 0x0121BFEC File Offset: 0x0121A1EC
		public bool IsToSceneCameraMode()
		{
			ECustomCameraMode? cameraMode = this.CameraMode;
			ECustomCameraMode ecustomCameraMode = ECustomCameraMode.Scene;
			return cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null;
		}

		// Token: 0x0603E4EE RID: 255214 RVA: 0x0121C014 File Offset: 0x0121A214
		public void SetViewInfo(Vector2D viewLocation, Vector2D viewSize, bool enableScissorOffset)
		{
			this.SeparateCameraLayout.SetViewInfo(viewLocation, viewSize, enableScissorOffset);
		}

		// Token: 0x0603E4EF RID: 255215 RVA: 0x0121C024 File Offset: 0x0121A224
		public void ReleaseOwnedSequenceSeparateCamera(string cameraName)
		{
			if (CameraController.Instance.GetSeparateCameraModel(cameraName) != this)
			{
				return;
			}
			CameraController.Instance.DestroySeparateCameraModelImmediately(cameraName);
		}

		// Token: 0x0603E4F0 RID: 255216 RVA: 0x0121C040 File Offset: 0x0121A240
		public void ResetMainCameraLayout()
		{
			this.SetViewInfo(Vector2D.Create(0.0, 0.0), Vector2D.Create(1.0, 1.0), false);
		}

		// Token: 0x0603E4F1 RID: 255217 RVA: 0x0121C077 File Offset: 0x0121A277
		public void SetTargetViewInfo(float blendTime, Vector2D targetViewLocation, Vector2D targetViewSize, bool enableScissorOffset = false, [Nullable(2)] UCurveFloat blendCurve = null, [Nullable(2)] Action callback = null)
		{
			this.SeparateCameraLayout.SetTargetViewInfo(blendTime, targetViewLocation, targetViewSize, enableScissorOffset, blendCurve, callback);
		}

		// Token: 0x0603E4F2 RID: 255218 RVA: 0x0121C08D File Offset: 0x0121A28D
		public void UpdateCameraLayout(float deltaTime)
		{
			this.SeparateCameraLayout.BlendToTarget(deltaTime);
			this.UpdateBoundScreenEffectsAlpha();
		}

		// Token: 0x0603E4F3 RID: 255219 RVA: 0x0121C0A1 File Offset: 0x0121A2A1
		public void BindScreenEffect(int handleId)
		{
			this.BoundScreenEffectHandleIds.Add(handleId);
		}

		// Token: 0x0603E4F4 RID: 255220 RVA: 0x0121C0B0 File Offset: 0x0121A2B0
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

		// Token: 0x0603E4F5 RID: 255221 RVA: 0x0121C0D8 File Offset: 0x0121A2D8
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
			int[] array = new int[this.BoundScreenEffectHandleIds.Count];
			this.BoundScreenEffectHandleIds.CopyTo(array);
			foreach (int num3 in array)
			{
				if (!instance.TrySetScreenEffectAlpha(num3, (float)num2))
				{
					this.BoundScreenEffectHandleIds.Remove(num3);
				}
			}
		}

		// Token: 0x0603E4F6 RID: 255222 RVA: 0x0121C1A4 File Offset: 0x0121A3A4
		public bool IsEnableScissorOffsetCenter()
		{
			SeparateCameraLayout separateCameraLayout = this.SeparateCameraLayout;
			return separateCameraLayout != null && separateCameraLayout.EnableScissorOffset;
		}

		// Token: 0x0603E4F7 RID: 255223 RVA: 0x0121C1B8 File Offset: 0x0121A3B8
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

		// Token: 0x0603E4F8 RID: 255224 RVA: 0x0121C2A4 File Offset: 0x0121A4A4
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

		// Token: 0x0603E4F9 RID: 255225 RVA: 0x0121C730 File Offset: 0x0121A930
		public bool Clear()
		{
			EventSystem.Instance.Remove<float, string>(EEventName.CameraViewTargetChanged, new Action<float, string>(this.OnCameraViewTargetChanged));
			this.BoundScreenEffectHandleIds.Clear();
			this.CameraSpecificLockTargetList.Clear();
			this.CameraSpecificLockTargetMap.Clear();
			Global.CharacterCameraManager.CameraModifyCustomTimeDilation = 1f;
			bool flag = EntitySystem.Instance.Destroy(this.FightCameraInternal);
			this.FightCameraInternal = null;
			bool flag2 = flag & EntitySystem.Instance.Destroy(this.SequenceCameraInternal);
			this.SequenceCameraInternal = null;
			bool flag3 = flag2 & EntitySystem.Instance.Destroy(this.WidgetCameraInternal);
			this.WidgetCameraInternal = null;
			bool flag4 = flag3 & EntitySystem.Instance.Destroy(this.SceneCameraInternal);
			this.SceneCameraInternal = null;
			bool flag5 = flag4 & EntitySystem.Instance.Destroy(this.OrbitalCameraInternal);
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

		// Token: 0x0603E4FA RID: 255226 RVA: 0x0121C888 File Offset: 0x0121AA88
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

		// Token: 0x0603E4FB RID: 255227 RVA: 0x0121C914 File Offset: 0x0121AB14
		public bool DestroyFreeCamera()
		{
			if (this.FreeCameraInternal == null)
			{
				return true;
			}
			bool result = EntitySystem.Instance.Destroy(this.FreeCameraInternal);
			this.FreeCameraInternal = null;
			return result;
		}

		// Token: 0x0603E4FC RID: 255228 RVA: 0x0121C938 File Offset: 0x0121AB38
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

		// Token: 0x0603E4FD RID: 255229 RVA: 0x0121CA1F File Offset: 0x0121AC1F
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

		// Token: 0x040212CC RID: 135884
		private const int CAMERA_TICK_PRIORITY = -100;

		// Token: 0x040212CD RID: 135885
		private const int CAMERA_DEFAULT_SENSITIVITY = 50;

		// Token: 0x040212CE RID: 135886
		private const int CAMERA_MAX_SENSITIVITY = 100;

		// Token: 0x040212CF RID: 135887
		private const int CAMERA_MIN_SENSITIVITY = 0;

		// Token: 0x040212D0 RID: 135888
		private const int CAMERA_DEFAULT_SENSITIVITY_MODIFIER = 1;

		// Token: 0x040212D1 RID: 135889
		private const int CAMERA_MAX_SENSITIVITY_MODIFIER = 2;

		// Token: 0x040212D2 RID: 135890
		private const float CAMERA_MIN_SENSITIVITY_MODIFIER = 0.1f;

		// Token: 0x040212D3 RID: 135891
		private const int MOTION_BLUR_DEFAULT_VALUE = 50;

		// Token: 0x040212D4 RID: 135892
		private const int MOTION_BLUR_MAX_VALUE = 100;

		// Token: 0x040212D5 RID: 135893
		private const int MOTION_BLUR_MIN_VALUE = 0;

		// Token: 0x040212D6 RID: 135894
		private const float MOTION_BLUR_DEFAULT_MODIFIER = 0.25f;

		// Token: 0x040212D7 RID: 135895
		private const float MOTION_BLUR_MAX_MODIFIER = 0.4f;

		// Token: 0x040212D8 RID: 135896
		private const float MOTION_BLUR_MIN_MODIFIER = 0.1f;

		// Token: 0x040212D9 RID: 135897
		private const bool CAMERA_DEFAULT_REVERSE = false;

		// Token: 0x040212DA RID: 135898
		private const int CAMERA_ADDITION_ARM_LENGTH_VALUE_MAX = 100;

		// Token: 0x040212DB RID: 135899
		private const int CAMERA_ADDITION_ARM_LENGTH_VALUE_DEFAULT = 50;

		// Token: 0x040212DC RID: 135900
		private const int CAMERA_ADDITION_ARM_LENGTH_VALUE_MIN = 0;

		// Token: 0x040212DD RID: 135901
		private const int CAMERA_SHAKE_MODIFIER_MIN = 0;

		// Token: 0x040212DE RID: 135902
		private const int CAMERA_SHAKE_MODIFIER_MAX = 2;

		// Token: 0x040212DF RID: 135903
		private const float HIDE_PLAYER_DITHER_SPEED_RATE = 2f;

		// Token: 0x040212E1 RID: 135905
		public bool AimAssistDebugDraw;

		// Token: 0x040212E2 RID: 135906
		public bool CameraDebugToolEnabled;

		// Token: 0x040212E3 RID: 135907
		public bool CameraDebugToolDrawRotator;

		// Token: 0x040212E4 RID: 135908
		public bool CameraDebugToolDrawCameraCollision;

		// Token: 0x040212E5 RID: 135909
		public bool CameraDebugToolDrawSpringArm;

		// Token: 0x040212E6 RID: 135910
		public bool CameraDebugToolDrawFocusTargetLine;

		// Token: 0x040212E7 RID: 135911
		public bool CameraDebugToolDrawSpringArmEdgeRange;

		// Token: 0x040212E8 RID: 135912
		public bool CameraDebugToolDrawLockCameraMoveLine;

		// Token: 0x040212E9 RID: 135913
		public bool CameraDebugToolDrawSettlementCamera;

		// Token: 0x040212EA RID: 135914
		public bool CameraDebugToolDrawCameraZone;

		// Token: 0x040212EB RID: 135915
		public bool CameraDebugToolDrawCameraRotator;

		// Token: 0x040212EC RID: 135916
		public bool UiCameraDebugToolEnabled;

		// Token: 0x040212ED RID: 135917
		[Nullable(2)]
		private APlayerCameraManager PlayerCameraManagerInternal;

		// Token: 0x040212EE RID: 135918
		[Nullable(2)]
		public AActor CurrentCameraActor;

		// Token: 0x040212EF RID: 135919
		[Nullable(2)]
		public UCameraComponent CurrentCameraComponent;

		// Token: 0x040212F0 RID: 135920
		public Vector CameraLocation = Vector.Create();

		// Token: 0x040212F1 RID: 135921
		public Rotator CameraRotator = Rotator.Create();

		// Token: 0x040212F2 RID: 135922
		public FTransformDouble? CameraTransform;

		// Token: 0x040212F3 RID: 135923
		public float CameraDitherStartHideDistance;

		// Token: 0x040212F4 RID: 135924
		public float NextFindStartHideDistanceTime;

		// Token: 0x040212F5 RID: 135925
		[Nullable(2)]
		private FightCamera FightCameraInternal;

		// Token: 0x040212F6 RID: 135926
		[Nullable(2)]
		private SequenceCamera SequenceCameraInternal;

		// Token: 0x040212F7 RID: 135927
		[Nullable(2)]
		private WidgetCamera WidgetCameraInternal;

		// Token: 0x040212F8 RID: 135928
		[Nullable(2)]
		private SceneCamera SceneCameraInternal;

		// Token: 0x040212F9 RID: 135929
		[Nullable(2)]
		private OrbitalCamera OrbitalCameraInternal;

		// Token: 0x040212FA RID: 135930
		[Nullable(2)]
		private FreeCamera FreeCameraInternal;

		// Token: 0x040212FB RID: 135931
		private ECustomCameraMode? CameraModeInternal;

		// Token: 0x040212FC RID: 135932
		private readonly List<bool> CameraModeEnabledArray = new List<bool>();

		// Token: 0x040212FD RID: 135933
		private readonly List<int> CameraModeSequence = new List<int>();

		// Token: 0x040212FE RID: 135934
		private readonly List<int> CameraModePriorityValues = new List<int>();

		// Token: 0x040212FF RID: 135935
		[Nullable(2)]
		public CameraMovieModeController CameraMovieModeController;

		// Token: 0x04021300 RID: 135936
		public bool IsInCameraModeBlending;

		// Token: 0x04021301 RID: 135937
		private bool BlendingInternal;

		// Token: 0x04021302 RID: 135938
		[Nullable(2)]
		private TimerHandle BlendTimerIdInternal;

		// Token: 0x04021303 RID: 135939
		private float ShakeModifyInternal = 1f;

		// Token: 0x04021304 RID: 135940
		private EAimAssistMode DefaultAimAssistModeInternal = EAimAssistMode.OpenOnStart;

		// Token: 0x04021305 RID: 135941
		private readonly Dictionary<string, EAimAssistMode> AimAssistModeMap = new Dictionary<string, EAimAssistMode>();

		// Token: 0x04021306 RID: 135942
		private EAimAssistMode CurrentAimAssistMode;

		// Token: 0x04021307 RID: 135943
		public int CameraShakeInstanceId = -1;

		// Token: 0x04021308 RID: 135944
		public readonly Dictionary<int, UCameraShakeBase> CameraShakeMap = new Dictionary<int, UCameraShakeBase>();

		// Token: 0x04021309 RID: 135945
		[Nullable(2)]
		public SeparateCameraLayout SeparateCameraLayout;

		// Token: 0x0402130A RID: 135946
		private readonly HashSet<int> BoundScreenEffectHandleIds = new HashSet<int>();

		// Token: 0x0402130B RID: 135947
		private double CameraBaseYawSensitivityInternal = 50.0;

		// Token: 0x0402130C RID: 135948
		private double CameraBasePitchSensitivityInternal = 50.0;

		// Token: 0x0402130D RID: 135949
		private double CameraAimingYawSensitivityInternal = 50.0;

		// Token: 0x0402130E RID: 135950
		private double CameraAimingPitchSensitivityInternal = 50.0;

		// Token: 0x0402130F RID: 135951
		public bool IsEnableSpecificCameraSensitivity;

		// Token: 0x04021310 RID: 135952
		public float SpecificCameraBaseYawSensitivity = 1f;

		// Token: 0x04021311 RID: 135953
		public float SpecificCameraBasePitchSensitivity = 1f;

		// Token: 0x04021312 RID: 135954
		public float SpecificCameraAimingYawSensitivity = 1f;

		// Token: 0x04021313 RID: 135955
		public float SpecificCameraAimingPitchSensitivity = 1f;

		// Token: 0x04021314 RID: 135956
		private bool CameraBaseYawReverseInternal;

		// Token: 0x04021315 RID: 135957
		private bool CameraBasePitchReverseInternal;

		// Token: 0x04021316 RID: 135958
		private bool CameraAimingYawReverseInternal;

		// Token: 0x04021317 RID: 135959
		private bool CameraAimingPitchReverseInternal;

		// Token: 0x04021318 RID: 135960
		private bool IsCameraResetPitchInternal = true;

		// Token: 0x04021319 RID: 135961
		private float MotionBlurValueInternal = 50f;

		// Token: 0x0402131A RID: 135962
		public bool IsEnableResetFocus = true;

		// Token: 0x0402131B RID: 135963
		public bool IsEnableSidestepCamera = true;

		// Token: 0x0402131C RID: 135964
		private bool IsEnableSoftLockCamera = true;

		// Token: 0x0402131D RID: 135965
		public double CameraSettingFightAdditionArmLength = 50.0;

		// Token: 0x0402131E RID: 135966
		public double CameraSettingNormalAdditionArmLength = 50.0;

		// Token: 0x0402131F RID: 135967
		[Nullable(2)]
		private SeqCameraThings SavedSeqCameraThings;

		// Token: 0x04021320 RID: 135968
		private bool IsAimAssistEnable = true;

		// Token: 0x04021321 RID: 135969
		private readonly HashSet<int> SoftLockEnableHandleSet = new HashSet<int>();

		// Token: 0x04021322 RID: 135970
		private int SoftLockEnableHandle;

		// Token: 0x04021323 RID: 135971
		private int CameraLockId;

		// Token: 0x04021324 RID: 135972
		private readonly Dictionary<int, CameraSpecificLockTarget> CameraSpecificLockTargetMap = new Dictionary<int, CameraSpecificLockTarget>();

		// Token: 0x04021325 RID: 135973
		private readonly PriorityQueue<CameraSpecificLockTarget> CameraSpecificLockTargetList;

		// Token: 0x04021326 RID: 135974
		public readonly DisjointSet<long> DitherEntityGroups;

		// Token: 0x04021327 RID: 135975
		private readonly HashSet<EHideHeadEnum> HideHeadEnabledInternal;

		// Token: 0x04021328 RID: 135976
		private readonly HashSet<EHideHeadDisabledEnum> HideHeadDisabledInternal;

		// Token: 0x04021329 RID: 135977
		private int HidePlayerHandle;

		// Token: 0x0402132A RID: 135978
		private int HidePlayerEntityId;

		// Token: 0x0402132B RID: 135979
		private CameraModelInstance.ECameraHidePlayerMode HidePlayerMode;

		// Token: 0x0402132C RID: 135980
		public int CurSeqCameraIndex;

		// Token: 0x0200BBA3 RID: 48035
		[NullableContext(0)]
		private enum ECameraHidePlayerMode
		{
			// Token: 0x04039BF4 RID: 236532
			None,
			// Token: 0x04039BF5 RID: 236533
			Instant,
			// Token: 0x04039BF6 RID: 236534
			Dither
		}

		// Token: 0x0200BBA4 RID: 48036
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04039BF7 RID: 236535
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Comparison<CameraSpecificLockTarget> <0>__CompareCameraSpecificLockIdPriority;
		}
	}
}
