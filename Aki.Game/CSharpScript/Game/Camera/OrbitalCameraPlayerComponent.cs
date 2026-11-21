using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006455 RID: 25685
	[NullableContext(1)]
	[Nullable(0)]
	public class OrbitalCameraPlayerComponent : EntityComponent
	{
		// Token: 0x0603E640 RID: 255552 RVA: 0x0122445B File Offset: 0x0122265B
		[NullableContext(2)]
		protected override bool OnCreate(IEntityArgs args = null)
		{
			this.CameraModelInstanceInternal = ((args != null) ? args.GetP1<CameraModelInstance>() : null);
			return base.OnCreate(args);
		}

		// Token: 0x0603E641 RID: 255553 RVA: 0x01224478 File Offset: 0x01222678
		protected override bool OnStart()
		{
			this.DisplayComponent = base.Entity.GetComponent<SequenceCameraDisplayComponent>();
			this.DisableKey = new int?(base.Disable("[OrbitalCameraPlayerComponent.OnStart]"));
			EventSystem.Instance.Add<ECustomCameraMode, ECustomCameraMode?, string>(EEventName.CameraModeChanged, new Action<ECustomCameraMode, ECustomCameraMode?, string>(this.OnModeChanged));
			return true;
		}

		// Token: 0x0603E642 RID: 255554 RVA: 0x012244CC File Offset: 0x012226CC
		protected override bool OnEnd()
		{
			this.CameraSequence = null;
			if (this.CameraSequenceActor != null)
			{
				ALevelSequenceActor tmp = this.CameraSequenceActor;
				TimerSystem.Instance.Next(delegate(float _)
				{
					ActorSystem.Instance.Put("OrbitalCameraPlayerComponent.OnEnd", tmp, null);
				}, null, null);
				this.CameraSequenceActor = null;
				this.CameraSequencePlayer = null;
			}
			EventSystem.Instance.Remove<ECustomCameraMode, ECustomCameraMode?, string>(EEventName.CameraModeChanged, new Action<ECustomCameraMode, ECustomCameraMode?, string>(this.OnModeChanged));
			return true;
		}

		// Token: 0x0603E643 RID: 255555 RVA: 0x01224540 File Offset: 0x01222740
		protected void OnModeChanged(ECustomCameraMode newMode, ECustomCameraMode? oldMode, string cameraName)
		{
			CameraModelInstance cameraModelInstanceInternal = this.CameraModelInstanceInternal;
			if (cameraName != ((cameraModelInstanceInternal != null) ? cameraModelInstanceInternal.CameraName : null))
			{
				return;
			}
			if (newMode == ECustomCameraMode.Orbital)
			{
				if (this.DisableKey != null)
				{
					base.Enable(new int?(this.DisableKey.Value), "[OrbitalCameraPlayerComponent.OnModeChanged] newMode == Orbital");
					this.DisableKey = null;
					return;
				}
			}
			else
			{
				ECustomCameraMode? ecustomCameraMode = oldMode;
				ECustomCameraMode ecustomCameraMode2 = ECustomCameraMode.Orbital;
				if (ecustomCameraMode.GetValueOrDefault() == ecustomCameraMode2 & ecustomCameraMode != null)
				{
					int value = this.DisableKey.GetValueOrDefault();
					if (this.DisableKey == null)
					{
						value = base.Disable("[OrbitalCameraPlayerComponent.OnModeChanged] oldMode == Orbital");
						this.DisableKey = new int?(value);
					}
				}
			}
		}

		// Token: 0x0603E644 RID: 255556 RVA: 0x012245EC File Offset: 0x012227EC
		protected override void OnTick(float delta)
		{
			if (this.CameraSequenceActor != null)
			{
				float process = this.GetProcess();
				this.GetCurrentFrame(process);
				this.CameraSequencePlayer.PlayToFrame(this.CurrentFrame);
				return;
			}
			if (this.DisableKey != null)
			{
				Log.Instance.Error(ELogModule.Camera, ELogAuthor.LCZ, "OrbitalCamera Impossible Tick!", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.DisableKey = new int?(base.Disable("[OrbitalCameraPlayerComponent.OnTick] CameraSequenceActor无效"));
		}

		// Token: 0x0603E645 RID: 255557 RVA: 0x01224660 File Offset: 0x01222860
		public void PlayCameraOrbitalPath(string levelSequencePath, Vector startLocation, Vector endLocation, float blendInTime, float blendOutTime)
		{
			Log.Instance.Info(ELogModule.Test, ELogAuthor.LCZ, "Orbital Play", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.ResourcePath = levelSequencePath;
			this.StartLocation.FromUeVector(startLocation);
			this.EndLocation.FromUeVector(endLocation);
			this.BlendInTime = blendInTime;
			this.BlendOutTime = blendOutTime;
			this.EndLocation.Subtraction(this.StartLocation, this.Direct);
			this.Distance = (float)this.Direct.Size();
			this.Direct.DivisionEqual((double)this.Distance);
			this.SetupCameraSpline();
		}

		// Token: 0x0603E646 RID: 255558 RVA: 0x012246FC File Offset: 0x012228FC
		public void PlayCameraOrbital(ULevelSequence levelSequence, FVector startLocation, FVector endLocation, float blendInTime, float blendOutTime)
		{
			Log.Instance.Info(ELogModule.Test, ELogAuthor.LCZ, "Orbital Play", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.CameraSequence = levelSequence;
			this.StartLocation.FromUeVector(startLocation);
			this.EndLocation.FromUeVector(endLocation);
			this.BlendInTime = blendInTime;
			this.BlendOutTime = blendOutTime;
			this.EndLocation.Subtraction(this.StartLocation, this.Direct);
			this.Distance = (float)this.Direct.Size();
			this.Direct.DivisionEqual((double)this.Distance);
			this.PlayInternal();
		}

		// Token: 0x0603E647 RID: 255559 RVA: 0x01224798 File Offset: 0x01222998
		public void StopCameraOrbital()
		{
			Log.Instance.Info(ELogModule.Camera, ELogAuthor.LCZ, "Orbital Stop", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (string.IsNullOrEmpty(this.ResourcePath) && this.CameraSequence == null)
			{
				return;
			}
			this.CameraModelInstanceInternal.FightCamera.LogicComponent.SetRotation(CameraUtility.GetCameraDefaultFocusUeRotator());
			CameraController.Instance.ExitCameraMode(ECustomCameraMode.Orbital, this.BlendOutTime, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, this.CameraModelInstanceInternal.CameraName, null);
			this.CameraSequence = null;
			if (this.CameraSequenceActor != null)
			{
				this.CameraSequencePlayer.Stop();
				ALevelSequenceActor tmp = this.CameraSequenceActor;
				TimerSystem.Instance.Next(delegate(float _)
				{
					ActorSystem.Instance.Put("OrbitalCameraPlayerComponent.StopCameraOrbital", tmp, null);
				}, null, null);
				this.CameraSequenceActor = null;
				this.CameraSequencePlayer = null;
			}
			else
			{
				Log.Instance.Warn(ELogModule.Camera, ELogAuthor.LCZ, "Orbital: No CameraSequenceActor", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.ResourcePath = null;
		}

		// Token: 0x0603E648 RID: 255560 RVA: 0x0122488C File Offset: 0x01222A8C
		private void SetupCameraSpline()
		{
			ResourceSystem.Instance.LoadAsync<ULevelSequence>(this.ResourcePath, new Action<ULevelSequence, string>(this.LoadComplete), 100, "js_undefined");
		}

		// Token: 0x0603E649 RID: 255561 RVA: 0x012248B4 File Offset: 0x01222AB4
		private void LoadComplete([Nullable(2)] ULevelSequence levelSequence, string path)
		{
			Log.Instance.Info(ELogModule.Camera, ELogAuthor.LCZ, "Orbital LoadComplete", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (path != this.ResourcePath)
			{
				return;
			}
			this.CameraSequence = levelSequence;
			this.PlayInternal();
		}

		// Token: 0x0603E64A RID: 255562 RVA: 0x012248F8 File Offset: 0x01222AF8
		private void PlayInternal()
		{
			FMovieSceneSequencePlaybackSettings fmovieSceneSequencePlaybackSettings = new FMovieSceneSequencePlaybackSettings();
			fmovieSceneSequencePlaybackSettings.bDisableMovementInput = false;
			fmovieSceneSequencePlaybackSettings.bDisableLookAtInput = false;
			this.CameraSequenceActor = (ActorSystem.Instance.Get(ALevelSequenceActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, false) as ALevelSequenceActor);
			this.CameraSequenceActor.PlaybackSettings = fmovieSceneSequencePlaybackSettings;
			this.CameraSequenceActor.SetSequence(this.CameraSequence);
			this.CameraSequenceActor.bOverrideInstanceData = true;
			this.CameraSequencePlayer = this.CameraSequenceActor.SequencePlayer;
			this.CameraSequencePlayer.Play();
			this.CameraSequencePlayer.SetPlayRate(0f);
			this.CameraSequencePlayer.Pause();
			this.BindingActors.Add(this.DisplayComponent.CineCamera);
			this.CameraSequenceActor.SetBindingByTag(OrbitalCameraPlayerComponent.SequenceCamera, this.BindingActors, false, false);
			this.BindingActors.Empty(true);
			this.FrameLength = (float)this.CameraSequencePlayer.GetEndTime().Time.FrameNumber.Value;
			CameraController.Instance.EnterCameraMode(ECustomCameraMode.Orbital, this.BlendInTime, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, false, this.CameraModelInstanceInternal.CameraName, null);
		}

		// Token: 0x0603E64B RID: 255563 RVA: 0x01224A20 File Offset: 0x01222C20
		private float GetProcess()
		{
			if (Global.BaseCharacter == null || (double)this.Distance < 1E-08)
			{
				return 0f;
			}
			Global.BaseCharacter.CharacterActorComponent.ActorLocationProxy.Subtraction(this.StartLocation, this.TmpVector);
			double currentValue = this.TmpVector.DotProduct(this.Direct) / (double)this.Distance;
			return (float)MathUtils.Instance.Clamp(currentValue, 0.0, 1.0);
		}

		// Token: 0x0603E64C RID: 255564 RVA: 0x01224AA8 File Offset: 0x01222CA8
		private void GetCurrentFrame(float process)
		{
			float num = process * this.FrameLength;
			float num2 = (float)Math.Floor((double)num);
			float subFrame = num - num2;
			this.CurrentFrame.FrameNumber = new FFrameNumber
			{
				Value = (int)num2
			};
			this.CurrentFrame.SubFrame = subFrame;
		}

		// Token: 0x0603E64D RID: 255565 RVA: 0x01224AED File Offset: 0x01222CED
		protected override bool OnClear()
		{
			this.CameraModelInstanceInternal = null;
			return true;
		}

		// Token: 0x0603E64E RID: 255566 RVA: 0x01224AF8 File Offset: 0x01222CF8
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			OrbitalCameraPlayerComponent orbitalCameraPlayerComponent = (OrbitalCameraPlayerComponent)componentTemplate;
			if (orbitalCameraPlayerComponent.CameraModelInstanceInternal == null)
			{
				this.CameraModelInstanceInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraModelInstanceInternal), "CameraModelInstanceInternal"))
			{
				return false;
			}
			if (orbitalCameraPlayerComponent.DisplayComponent == null)
			{
				this.DisplayComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DisplayComponent), "DisplayComponent"))
			{
				return false;
			}
			if (orbitalCameraPlayerComponent.CameraSequence == null)
			{
				this.CameraSequence = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraSequence), "CameraSequence"))
			{
				return false;
			}
			if (orbitalCameraPlayerComponent.CameraSequenceActor == null)
			{
				this.CameraSequenceActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraSequenceActor), "CameraSequenceActor"))
			{
				return false;
			}
			if (orbitalCameraPlayerComponent.CameraSequencePlayer == null)
			{
				this.CameraSequencePlayer = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraSequencePlayer), "CameraSequencePlayer"))
			{
				return false;
			}
			this.ResourcePath = orbitalCameraPlayerComponent.ResourcePath;
			if (orbitalCameraPlayerComponent.StartLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.StartLocation), "StartLocation"))
			{
				return false;
			}
			if (orbitalCameraPlayerComponent.EndLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.EndLocation), "EndLocation"))
			{
				return false;
			}
			if (orbitalCameraPlayerComponent.Direct != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.Direct), "Direct"))
			{
				return false;
			}
			this.Distance = orbitalCameraPlayerComponent.Distance;
			this.BlendInTime = orbitalCameraPlayerComponent.BlendInTime;
			this.BlendOutTime = orbitalCameraPlayerComponent.BlendOutTime;
			this.FrameLength = orbitalCameraPlayerComponent.FrameLength;
			if (orbitalCameraPlayerComponent.BindingActors != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.BindingActors), "BindingActors"))
			{
				return false;
			}
			if (orbitalCameraPlayerComponent.CurrentFrame != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentFrame), "CurrentFrame"))
			{
				return false;
			}
			if (orbitalCameraPlayerComponent.TmpVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpVector), "TmpVector"))
			{
				return false;
			}
			this.DisableKey = orbitalCameraPlayerComponent.DisableKey;
			return true;
		}

		// Token: 0x170076B0 RID: 30384
		// (get) Token: 0x0603E64F RID: 255567 RVA: 0x01224D09 File Offset: 0x01222F09
		public override bool NeedCreateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076B1 RID: 30385
		// (get) Token: 0x0603E650 RID: 255568 RVA: 0x01224D0C File Offset: 0x01222F0C
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076B2 RID: 30386
		// (get) Token: 0x0603E651 RID: 255569 RVA: 0x01224D0F File Offset: 0x01222F0F
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076B3 RID: 30387
		// (get) Token: 0x0603E652 RID: 255570 RVA: 0x01224D12 File Offset: 0x01222F12
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076B4 RID: 30388
		// (get) Token: 0x0603E653 RID: 255571 RVA: 0x01224D15 File Offset: 0x01222F15
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040213E7 RID: 136167
		[Nullable(2)]
		private CameraModelInstance CameraModelInstanceInternal;

		// Token: 0x040213E8 RID: 136168
		private static readonly FName SequenceCamera = new FName("SequenceCamera");

		// Token: 0x040213E9 RID: 136169
		[Nullable(2)]
		private SequenceCameraDisplayComponent DisplayComponent;

		// Token: 0x040213EA RID: 136170
		[Nullable(2)]
		private ULevelSequence CameraSequence;

		// Token: 0x040213EB RID: 136171
		[Nullable(2)]
		private ALevelSequenceActor CameraSequenceActor;

		// Token: 0x040213EC RID: 136172
		[Nullable(2)]
		private ULevelSequencePlayer CameraSequencePlayer;

		// Token: 0x040213ED RID: 136173
		[Nullable(2)]
		private string ResourcePath;

		// Token: 0x040213EE RID: 136174
		private readonly Vector StartLocation = Vector.Create();

		// Token: 0x040213EF RID: 136175
		private readonly Vector EndLocation = Vector.Create();

		// Token: 0x040213F0 RID: 136176
		private readonly Vector Direct = Vector.Create();

		// Token: 0x040213F1 RID: 136177
		private float Distance;

		// Token: 0x040213F2 RID: 136178
		private float BlendInTime;

		// Token: 0x040213F3 RID: 136179
		private float BlendOutTime;

		// Token: 0x040213F4 RID: 136180
		private float FrameLength;

		// Token: 0x040213F5 RID: 136181
		private readonly TArray<AActor> BindingActors = new TArray<AActor>();

		// Token: 0x040213F6 RID: 136182
		private readonly FFrameTime CurrentFrame = new FFrameTime();

		// Token: 0x040213F7 RID: 136183
		private readonly Vector TmpVector = Vector.Create();

		// Token: 0x040213F8 RID: 136184
		private int? DisableKey;
	}
}
