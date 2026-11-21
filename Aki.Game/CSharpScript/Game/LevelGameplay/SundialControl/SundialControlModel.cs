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
	// Token: 0x02005B65 RID: 23397
	[NullableContext(1)]
	[Nullable(0)]
	public class SundialControlModel : ModelBase
	{
		// Token: 0x17006D73 RID: 28019
		// (get) Token: 0x06039891 RID: 235665 RVA: 0x010279D6 File Offset: 0x01025BD6
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

		// Token: 0x17006D74 RID: 28020
		// (get) Token: 0x06039892 RID: 235666 RVA: 0x010279FD File Offset: 0x01025BFD
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

		// Token: 0x17006D75 RID: 28021
		// (get) Token: 0x06039893 RID: 235667 RVA: 0x01027A18 File Offset: 0x01025C18
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

		// Token: 0x06039894 RID: 235668 RVA: 0x01027A34 File Offset: 0x01025C34
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

		// Token: 0x06039895 RID: 235669 RVA: 0x01027B00 File Offset: 0x01025D00
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

		// Token: 0x06039896 RID: 235670 RVA: 0x01027BD0 File Offset: 0x01025DD0
		public void ChangeCurrentRingIndex(int offset = 1)
		{
			this.CurrentRingIndex = (this.CurrentRingIndex + offset) % this.Rings.Count;
			this.UpdateTips();
			EventSystem.Instance.Emit<int>(EEventName.OnSundialRingSwitch, this.CurrentRingIndex);
		}

		// Token: 0x06039897 RID: 235671 RVA: 0x01027C08 File Offset: 0x01025E08
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

		// Token: 0x06039898 RID: 235672 RVA: 0x01027CB0 File Offset: 0x01025EB0
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

		// Token: 0x06039899 RID: 235673 RVA: 0x01027DE8 File Offset: 0x01025FE8
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

		// Token: 0x0603989A RID: 235674 RVA: 0x01027E40 File Offset: 0x01026040
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

		// Token: 0x0603989B RID: 235675 RVA: 0x01027ED4 File Offset: 0x010260D4
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

		// Token: 0x0603989C RID: 235676 RVA: 0x0102806C File Offset: 0x0102626C
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

		// Token: 0x0603989D RID: 235677 RVA: 0x01028119 File Offset: 0x01026319
		public void UpdateTips()
		{
			EventSystem.Instance.Emit<int, int>(EEventName.OnNeedUpdateSundialTips, this.CurrentRingIndex, this.Rings[this.CurrentRingIndex].CurSocket);
		}

		// Token: 0x17006D76 RID: 28022
		// (get) Token: 0x0603989E RID: 235678 RVA: 0x01028147 File Offset: 0x01026347
		public static SundialControlModel Instance
		{
			get
			{
				return SundialControlModel._Instance;
			}
		}

		// Token: 0x0603989F RID: 235679 RVA: 0x0102814E File Offset: 0x0102634E
		public static SundialControlModel GetOrCreateInstance()
		{
			if (SundialControlModel._Instance == null)
			{
				SundialControlModel.CreateInstance();
			}
			return SundialControlModel._Instance;
		}

		// Token: 0x060398A0 RID: 235680 RVA: 0x01028162 File Offset: 0x01026362
		public static bool CreateInstance()
		{
			if (SundialControlModel._Instance != null)
			{
				return true;
			}
			SundialControlModel._Instance = new SundialControlModel();
			return true;
		}

		// Token: 0x060398A1 RID: 235681 RVA: 0x01028178 File Offset: 0x01026378
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060398A2 RID: 235682 RVA: 0x0102817A File Offset: 0x0102637A
		public static void ResetStaticDefaultValue()
		{
			SundialControlModel._Instance = null;
		}

		// Token: 0x060398A3 RID: 235683 RVA: 0x01028182 File Offset: 0x01026382
		static SundialControlModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SundialControlModel.CreateStaticDefaultValue), new Action(SundialControlModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401E5DF RID: 124383
		[StaticVariableRuleIgnore]
		public static readonly int[] finalSocket = new int[]
		{
			5,
			2
		};

		// Token: 0x0401E5E0 RID: 124384
		public const string SUNDIAL_MODEL_CONFIG_ID = "518056";

		// Token: 0x0401E5E1 RID: 124385
		public const string RING_ONE = "Ring_1";

		// Token: 0x0401E5E2 RID: 124386
		public const string RING_TWO = "Ring_2";

		// Token: 0x0401E5E3 RID: 124387
		public const string AK_ROTATING_1 = "play_amb_interact_sundial_outer_circle_loop";

		// Token: 0x0401E5E4 RID: 124388
		public const string AK_STOP_ROTATING_1 = "play_amb_interact_sundial_outer_circle_stuck";

		// Token: 0x0401E5E5 RID: 124389
		public const string AK_ROTATING_2 = "play_amb_interact_sundial_inner_circle_loop";

		// Token: 0x0401E5E6 RID: 124390
		public const string AK_STOP_ROTATING_2 = "play_amb_interact_sundial_inner_circle_stuck";

		// Token: 0x0401E5E7 RID: 124391
		public const string AK_SHOW_SHINE = "play_amb_interact_sundial_activate";

		// Token: 0x0401E5E8 RID: 124392
		public const string AK_HIDE_SHINE = "play_amb_interact_sundial_deactivate";

		// Token: 0x0401E5E9 RID: 124393
		public const string AK_FINISH = "play_amb_interact_sundial_finish";

		// Token: 0x0401E5EA RID: 124394
		[Nullable(2)]
		private SModelConfig ModelConfigInternal;

		// Token: 0x0401E5EB RID: 124395
		private bool TargetActorInternal;

		// Token: 0x0401E5EC RID: 124396
		private FVectorDouble? TargetLocationInternal;

		// Token: 0x0401E5ED RID: 124397
		private FRotator? TargetRotationInternal;

		// Token: 0x0401E5EE RID: 124398
		private List<RotatingRing> Rings = new List<RotatingRing>();

		// Token: 0x0401E5EF RID: 124399
		private int CurrentRingIndex;

		// Token: 0x0401E5F0 RID: 124400
		private double RotatedAngle;

		// Token: 0x0401E5F1 RID: 124401
		[Nullable(2)]
		private static SundialControlModel _Instance;
	}
}
