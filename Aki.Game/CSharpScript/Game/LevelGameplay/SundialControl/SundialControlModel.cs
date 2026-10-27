using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.Data.Entity.Struct;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SundialControl
{
	// Token: 0x02006A08 RID: 27144
	[NullableContext(1)]
	[Nullable(0)]
	public class SundialControlModel : ModelBase
	{
		// Token: 0x1700988E RID: 39054
		// (get) Token: 0x06043845 RID: 276549 RVA: 0x010833B2 File Offset: 0x010815B2
		public SModelConfig ModelConfig
		{
			get
			{
				if (this.ModelConfigInternal == null)
				{
					this.ModelConfigInternal = DataTableUtil.GetDataTableRowFromName<SModelConfig>(EDataTable.ModelConfig, "518056");
				}
				return this.ModelConfigInternal;
			}
		}

		// Token: 0x1700988F RID: 39055
		// (get) Token: 0x06043846 RID: 276550 RVA: 0x010833D9 File Offset: 0x010815D9
		public FVectorDouble TargetLocation
		{
			get
			{
				if (!this.TargetActorInternal)
				{
					this.InitTargetActor();
				}
				return this.TargetLocationInternal.Value;
			}
		}

		// Token: 0x17009890 RID: 39056
		// (get) Token: 0x06043847 RID: 276551 RVA: 0x010833F4 File Offset: 0x010815F4
		public FRotator TargetRotation
		{
			get
			{
				if (!this.TargetActorInternal)
				{
					this.InitTargetActor();
				}
				return this.TargetRotationInternal.Value;
			}
		}

		// Token: 0x06043848 RID: 276552 RVA: 0x01083410 File Offset: 0x01081610
		private void InitTargetActor()
		{
			if (!this.TargetActorInternal)
			{
				this.TargetActorInternal = true;
				BP_CineCamera_C cineCamera = CameraController.Instance.MainModel.WidgetCamera.DisplayComponent.CineCamera;
				this.TargetLocationInternal = new FVectorDouble?(cineCamera.D_K2_GetActorLocation());
				this.TargetRotationInternal = new FRotator?(cineCamera.K2_GetActorRotation());
				FVectorDouble fvectorDouble = this.TargetRotationInternal.Value.VectorDouble();
				fvectorDouble.Normalize(9.99999993922529E-09);
				FVectorDouble? targetLocationInternal = this.TargetLocationInternal;
				FVectorDouble fvectorDouble2 = fvectorDouble * 200.0;
				FVectorDouble? targetLocationInternal2;
				if (targetLocationInternal == null)
				{
					targetLocationInternal2 = null;
				}
				else
				{
					FVectorDouble valueOrDefault = targetLocationInternal.GetValueOrDefault();
					targetLocationInternal2 = new FVectorDouble?(valueOrDefault + fvectorDouble2);
				}
				this.TargetLocationInternal = targetLocationInternal2;
			}
		}

		// Token: 0x06043849 RID: 276553 RVA: 0x010834DC File Offset: 0x010816DC
		public void InitRingActors(SceneInteractionLevel sceneInteractionInfo)
		{
			this.Rings = new List<RotatingRing>();
			float rotateSpeed = 0f;
			float rotateSpeed2 = 0f;
			GlobalConfigFromCsv? config = ConfigGlobalConfigFromCsvByName.GetConfig("SundialGamePlay.AngularSpeed1", true);
			if (config != null)
			{
				rotateSpeed = float.Parse(config.Value.Value);
			}
			config = ConfigGlobalConfigFromCsvByName.GetConfig("SundialGamePlay.AngularSpeed2", true);
			if (config != null)
			{
				rotateSpeed2 = float.Parse(config.Value.Value);
			}
			RotatingRing rotatingRing = new RotatingRing(sceneInteractionInfo.GetActorByKey("Ring_1"), 30f, rotateSpeed);
			if (rotatingRing != null)
			{
				this.Rings.Add(rotatingRing);
			}
			RotatingRing rotatingRing2 = new RotatingRing(sceneInteractionInfo.GetActorByKey("Ring_2"), 90f, rotateSpeed2);
			if (rotatingRing2 != null)
			{
				this.Rings.Add(rotatingRing2);
			}
			this.CurrentRingIndex = 0;
		}

		// Token: 0x0604384A RID: 276554 RVA: 0x010835AC File Offset: 0x010817AC
		public void ChangeCurrentRingIndex(int offset = 1)
		{
			this.CurrentRingIndex = (this.CurrentRingIndex + offset) % this.Rings.Count;
			this.UpdateTips();
			EventSystem.Instance.Emit<int>(EEventName.OnSundialRingSwitch, this.CurrentRingIndex);
		}

		// Token: 0x0604384B RID: 276555 RVA: 0x010835E4 File Offset: 0x010817E4
		public void SimpleAddCurRingSocket(int offset = 1)
		{
			RotatingRing rotatingRing = this.Rings[this.CurrentRingIndex];
			rotatingRing.CurSocket = (rotatingRing.CurSocket + offset) % rotatingRing.TotalSocket;
			Audio? audio;
			string text = (AudioConfig.Instance.GetAudioPath((this.CurrentRingIndex == 0) ? "play_amb_interact_sundial_outer_circle_loop" : "play_amb_interact_sundial_inner_circle_loop") != null) ? audio.GetValueOrDefault().Path : null;
			if (!string.IsNullOrEmpty(text))
			{
				AudioController.Instance.PostEvent(text, SundialControlController.Instance.GetMainActor(), null, null, null, null, true, "");
			}
		}

		// Token: 0x0604384C RID: 276556 RVA: 0x0108368C File Offset: 0x0108188C
		public bool RotateCurrentRing(double delta)
		{
			RotatingRing rotatingRing = this.Rings[this.CurrentRingIndex];
			USceneComponent rootComponent = rotatingRing.RingActor.RootComponent;
			if (rootComponent != null)
			{
				float rotateSpeed = rotatingRing.RotateSpeed;
				double num = delta * TimeUtil.Instance.Millisecond * (double)rotateSpeed;
				this.RotatedAngle += num;
				bool flag = false;
				if (this.RotatedAngle > rotatingRing.SimpleRotateAngle)
				{
					num -= this.RotatedAngle - rotatingRing.SimpleRotateAngle;
					flag = true;
				}
				rootComponent.K2_AddRelativeRotation(new FRotator(0f, (float)num, 0f), false, ref WorldGlobal.SweepHitResult, false);
				if (flag)
				{
					Audio? audio;
					string text = (AudioConfig.Instance.GetAudioPath((this.CurrentRingIndex == 0) ? "play_amb_interact_sundial_outer_circle_stuck" : "play_amb_interact_sundial_inner_circle_stuck") != null) ? audio.GetValueOrDefault().Path : null;
					if (!string.IsNullOrEmpty(text))
					{
						AudioController.Instance.PostEvent(text, SundialControlController.Instance.GetMainActor(), null, null, null, null, true, "");
					}
					this.RotatedAngle = 0.0;
					this.CheckRingShine();
					this.CheckFinish();
					return true;
				}
			}
			return false;
		}

		// Token: 0x0604384D RID: 276557 RVA: 0x010837C4 File Offset: 0x010819C4
		public void ClearCacheActor()
		{
			if (this.TargetActorInternal)
			{
				this.TargetActorInternal = false;
				this.TargetLocationInternal = null;
				this.TargetRotationInternal = null;
			}
			if (this.Rings != null && this.Rings.Count > 0)
			{
				this.Rings = new List<RotatingRing>();
			}
		}

		// Token: 0x0604384E RID: 276558 RVA: 0x0108381C File Offset: 0x01081A1C
		public void ResetAll()
		{
			this.CurrentRingIndex = 0;
			for (int i = 0; i < this.Rings.Count; i++)
			{
				RotatingRing rotatingRing = this.Rings[i];
				USceneComponent rootComponent = rotatingRing.RingActor.RootComponent;
				FRotator relativeRotation = rootComponent.RelativeRotation;
				relativeRotation.Yaw = rotatingRing.InitYaw;
				rootComponent.K2_SetRelativeRotation(relativeRotation, false, ref WorldGlobal.SweepHitResult, false);
				rotatingRing.IsShine = false;
				EventSystem.Instance.Emit<int, bool>(EEventName.OnSundialRingChangeShine, i, false);
				rotatingRing.CurSocket = 0;
			}
			EventSystem.Instance.Emit<int>(EEventName.OnSundialRingSwitch, 0);
		}

		// Token: 0x0604384F RID: 276559 RVA: 0x010838B0 File Offset: 0x01081AB0
		private void CheckRingShine()
		{
			for (int i = 0; i < this.Rings.Count; i++)
			{
				if (this.Rings[i].IsShine)
				{
					if (this.Rings[i].CurSocket != SundialControlModel.finalSocket[i])
					{
						this.Rings[i].IsShine = false;
						EventSystem.Instance.Emit<int, bool>(EEventName.OnSundialRingChangeShine, i, false);
						Audio? audioPath = AudioConfig.Instance.GetAudioPath("play_amb_interact_sundial_deactivate");
						string text = (audioPath != null) ? audioPath.GetValueOrDefault().Path : null;
						if (!string.IsNullOrEmpty(text))
						{
							AudioController.Instance.PostEvent(text, SundialControlController.Instance.GetMainActor(), null, null, null, null, true, "");
						}
					}
				}
				else if (this.Rings[i].CurSocket == SundialControlModel.finalSocket[i])
				{
					this.Rings[i].IsShine = true;
					EventSystem.Instance.Emit<int, bool>(EEventName.OnSundialRingChangeShine, i, true);
					Audio? audioPath = AudioConfig.Instance.GetAudioPath("play_amb_interact_sundial_activate");
					string text2 = (audioPath != null) ? audioPath.GetValueOrDefault().Path : null;
					if (!string.IsNullOrEmpty(text2))
					{
						AudioController.Instance.PostEvent(text2, SundialControlController.Instance.GetMainActor(), null, null, null, null, true, "");
					}
				}
			}
		}

		// Token: 0x06043850 RID: 276560 RVA: 0x01083A48 File Offset: 0x01081C48
		private void CheckFinish()
		{
			for (int i = 0; i < this.Rings.Count; i++)
			{
				if (this.Rings[i].CurSocket != SundialControlModel.finalSocket[i])
				{
					return;
				}
			}
			Audio? audio;
			string text = (AudioConfig.Instance.GetAudioPath("play_amb_interact_sundial_finish") != null) ? audio.GetValueOrDefault().Path : null;
			if (!string.IsNullOrEmpty(text))
			{
				AudioController.Instance.PostEvent(text, SundialControlController.Instance.GetMainActor(), null, null, null, null, true, "");
			}
			SundialControlController.Instance.PlayFinishAnimation();
		}

		// Token: 0x06043851 RID: 276561 RVA: 0x01083AF5 File Offset: 0x01081CF5
		public void UpdateTips()
		{
			EventSystem.Instance.Emit<int, int>(EEventName.OnNeedUpdateSundialTips, this.CurrentRingIndex, this.Rings[this.CurrentRingIndex].CurSocket);
		}

		// Token: 0x17009891 RID: 39057
		// (get) Token: 0x06043852 RID: 276562 RVA: 0x01083B23 File Offset: 0x01081D23
		public static SundialControlModel Instance
		{
			get
			{
				return SundialControlModel._Instance;
			}
		}

		// Token: 0x06043853 RID: 276563 RVA: 0x01083B2A File Offset: 0x01081D2A
		public static SundialControlModel GetOrCreateInstance()
		{
			if (SundialControlModel._Instance == null)
			{
				SundialControlModel.CreateInstance();
			}
			return SundialControlModel._Instance;
		}

		// Token: 0x06043854 RID: 276564 RVA: 0x01083B3E File Offset: 0x01081D3E
		public static bool CreateInstance()
		{
			if (SundialControlModel._Instance != null)
			{
				return true;
			}
			SundialControlModel._Instance = new SundialControlModel();
			return true;
		}

		// Token: 0x06043855 RID: 276565 RVA: 0x01083B54 File Offset: 0x01081D54
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06043856 RID: 276566 RVA: 0x01083B56 File Offset: 0x01081D56
		public static void ResetStaticDefaultValue()
		{
			SundialControlModel._Instance = null;
		}

		// Token: 0x06043857 RID: 276567 RVA: 0x01083B5E File Offset: 0x01081D5E
		static SundialControlModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SundialControlModel.CreateStaticDefaultValue), new Action(SundialControlModel.ResetStaticDefaultValue));
		}

		// Token: 0x040233ED RID: 144365
		[StaticVariableRuleIgnore]
		public static readonly int[] finalSocket = new int[]
		{
			5,
			2
		};

		// Token: 0x040233EE RID: 144366
		public const string SUNDIAL_MODEL_CONFIG_ID = "518056";

		// Token: 0x040233EF RID: 144367
		public const string RING_ONE = "Ring_1";

		// Token: 0x040233F0 RID: 144368
		public const string RING_TWO = "Ring_2";

		// Token: 0x040233F1 RID: 144369
		public const string AK_ROTATING_1 = "play_amb_interact_sundial_outer_circle_loop";

		// Token: 0x040233F2 RID: 144370
		public const string AK_STOP_ROTATING_1 = "play_amb_interact_sundial_outer_circle_stuck";

		// Token: 0x040233F3 RID: 144371
		public const string AK_ROTATING_2 = "play_amb_interact_sundial_inner_circle_loop";

		// Token: 0x040233F4 RID: 144372
		public const string AK_STOP_ROTATING_2 = "play_amb_interact_sundial_inner_circle_stuck";

		// Token: 0x040233F5 RID: 144373
		public const string AK_SHOW_SHINE = "play_amb_interact_sundial_activate";

		// Token: 0x040233F6 RID: 144374
		public const string AK_HIDE_SHINE = "play_amb_interact_sundial_deactivate";

		// Token: 0x040233F7 RID: 144375
		public const string AK_FINISH = "play_amb_interact_sundial_finish";

		// Token: 0x040233F8 RID: 144376
		[Nullable(2)]
		private SModelConfig ModelConfigInternal;

		// Token: 0x040233F9 RID: 144377
		private bool TargetActorInternal;

		// Token: 0x040233FA RID: 144378
		private FVectorDouble? TargetLocationInternal;

		// Token: 0x040233FB RID: 144379
		private FRotator? TargetRotationInternal;

		// Token: 0x040233FC RID: 144380
		private List<RotatingRing> Rings = new List<RotatingRing>();

		// Token: 0x040233FD RID: 144381
		private int CurrentRingIndex;

		// Token: 0x040233FE RID: 144382
		private double RotatedAngle;

		// Token: 0x040233FF RID: 144383
		[Nullable(2)]
		private static SundialControlModel _Instance;
	}
}
