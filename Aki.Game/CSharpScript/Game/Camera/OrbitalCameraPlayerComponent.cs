using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072D3 RID: 29395
	[NullableContext(1)]
	[Nullable(0)]
	public class OrbitalCameraPlayerComponent : EntityComponent
	{
		// Token: 0x06048231 RID: 295473 RVA: 0x01281BA7 File Offset: 0x0127FDA7
		[NullableContext(2)]
		protected override bool OnCreate(IEntityArgs args = null)
		{
			this.CameraModelInstanceInternal = ((args != null) ? args.GetP1<CameraModelInstance>() : null);
			return base.OnCreate(args);
		}

		// Token: 0x06048232 RID: 295474 RVA: 0x01281BC4 File Offset: 0x0127FDC4
		protected override bool OnStart()
		{
			this.DisplayComponent = base.Entity.GetComponent<SequenceCameraDisplayComponent>();
			this.DisableKey = new int?(base.Disable("[OrbitalCameraPlayerComponent.OnStart]"));
			EventSystem.Instance.Add<ECustomCameraMode, ECustomCameraMode?, string>(EEventName.CameraModeChanged, new Action<ECustomCameraMode, ECustomCameraMode?, string>(this.OnModeChanged));
			return true;
		}

		// Token: 0x06048233 RID: 295475 RVA: 0x01281C18 File Offset: 0x0127FE18
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

		// Token: 0x06048234 RID: 295476 RVA: 0x01281C8C File Offset: 0x0127FE8C
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

		// Token: 0x06048235 RID: 295477 RVA: 0x01281D38 File Offset: 0x0127FF38
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

		// Token: 0x06048236 RID: 295478 RVA: 0x01281DAC File Offset: 0x0127FFAC
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

		// Token: 0x06048237 RID: 295479 RVA: 0x01281E48 File Offset: 0x01280048
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

		// Token: 0x06048238 RID: 295480 RVA: 0x01281EE4 File Offset: 0x012800E4
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

		// Token: 0x06048239 RID: 295481 RVA: 0x01281FD8 File Offset: 0x012801D8
		private void SetupCameraSpline()
		{
			ResourceSystem.Instance.LoadAsync<ULevelSequence>(this.ResourcePath, new Action<ULevelSequence, string>(this.LoadComplete), 100, "js_undefined");
		}

		// Token: 0x0604823A RID: 295482 RVA: 0x01282000 File Offset: 0x01280200
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

		// Token: 0x0604823B RID: 295483 RVA: 0x01282044 File Offset: 0x01280244
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

		// Token: 0x0604823C RID: 295484 RVA: 0x0128216C File Offset: 0x0128036C
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

		// Token: 0x0604823D RID: 295485 RVA: 0x012821F4 File Offset: 0x012803F4
		private void GetCurrentFrame(float process)
		{
			float num = process * this.FrameLength;
			float num2 = (float)Math.Floor((double)num);
			float subFrame = num - num2;
			this.CurrentFrame.FrameNumber = new FFrameNumber((int)num2);
			this.CurrentFrame.SubFrame = subFrame;
		}

		// Token: 0x0604823E RID: 295486 RVA: 0x01282233 File Offset: 0x01280433
		protected override bool OnClear()
		{
			this.CameraModelInstanceInternal = null;
			return true;
		}

		// Token: 0x0604823F RID: 295487 RVA: 0x01282240 File Offset: 0x01280440
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			OrbitalCameraPlayerComponent orbitalCameraPlayerComponent = (OrbitalCameraPlayerComponent)componentTemplate;
			if (base.CanResetComponentProperty("CameraModelInstanceInternal"))
			{
				if (orbitalCameraPlayerComponent.CameraModelInstanceInternal == null)
				{
					this.CameraModelInstanceInternal = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CameraModelInstance>(this.CameraModelInstanceInternal), "CameraModelInstanceInternal"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("DisplayComponent"))
			{
				if (orbitalCameraPlayerComponent.DisplayComponent == null)
				{
					this.DisplayComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SequenceCameraDisplayComponent>(this.DisplayComponent), "DisplayComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CameraSequence"))
			{
				if (orbitalCameraPlayerComponent.CameraSequence == null)
				{
					this.CameraSequence = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ULevelSequence>(this.CameraSequence), "CameraSequence"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CameraSequenceActor"))
			{
				if (orbitalCameraPlayerComponent.CameraSequenceActor == null)
				{
					this.CameraSequenceActor = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ALevelSequenceActor>(this.CameraSequenceActor), "CameraSequenceActor"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CameraSequencePlayer"))
			{
				if (orbitalCameraPlayerComponent.CameraSequencePlayer == null)
				{
					this.CameraSequencePlayer = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ULevelSequencePlayer>(this.CameraSequencePlayer), "CameraSequencePlayer"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ResourcePath"))
			{
				this.ResourcePath = orbitalCameraPlayerComponent.ResourcePath;
			}
			if (base.CanResetComponentProperty("StartLocation") && orbitalCameraPlayerComponent.StartLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.StartLocation), "StartLocation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("EndLocation") && orbitalCameraPlayerComponent.EndLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.EndLocation), "EndLocation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("Direct") && orbitalCameraPlayerComponent.Direct != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.Direct), "Direct"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("Distance"))
			{
				this.Distance = orbitalCameraPlayerComponent.Distance;
			}
			if (base.CanResetComponentProperty("BlendInTime"))
			{
				this.BlendInTime = orbitalCameraPlayerComponent.BlendInTime;
			}
			if (base.CanResetComponentProperty("BlendOutTime"))
			{
				this.BlendOutTime = orbitalCameraPlayerComponent.BlendOutTime;
			}
			if (base.CanResetComponentProperty("FrameLength"))
			{
				this.FrameLength = orbitalCameraPlayerComponent.FrameLength;
			}
			if (base.CanResetComponentProperty("BindingActors") && orbitalCameraPlayerComponent.BindingActors != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.BindingActors), "BindingActors"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("CurrentFrame") && orbitalCameraPlayerComponent.CurrentFrame != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<FFrameTime>(this.CurrentFrame), "CurrentFrame"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TmpVector") && orbitalCameraPlayerComponent.TmpVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TmpVector), "TmpVector"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("DisableKey"))
			{
				this.DisableKey = orbitalCameraPlayerComponent.DisableKey;
			}
			return true;
		}

		// Token: 0x04026104 RID: 155908
		[Nullable(2)]
		private CameraModelInstance CameraModelInstanceInternal;

		// Token: 0x04026105 RID: 155909
		private static readonly FName SequenceCamera = new FName("SequenceCamera");

		// Token: 0x04026106 RID: 155910
		[Nullable(2)]
		private SequenceCameraDisplayComponent DisplayComponent;

		// Token: 0x04026107 RID: 155911
		[Nullable(2)]
		private ULevelSequence CameraSequence;

		// Token: 0x04026108 RID: 155912
		[Nullable(2)]
		private ALevelSequenceActor CameraSequenceActor;

		// Token: 0x04026109 RID: 155913
		[Nullable(2)]
		private ULevelSequencePlayer CameraSequencePlayer;

		// Token: 0x0402610A RID: 155914
		[Nullable(2)]
		private string ResourcePath;

		// Token: 0x0402610B RID: 155915
		private readonly Vector StartLocation = Vector.Create();

		// Token: 0x0402610C RID: 155916
		private readonly Vector EndLocation = Vector.Create();

		// Token: 0x0402610D RID: 155917
		private readonly Vector Direct = Vector.Create();

		// Token: 0x0402610E RID: 155918
		private float Distance;

		// Token: 0x0402610F RID: 155919
		private float BlendInTime;

		// Token: 0x04026110 RID: 155920
		private float BlendOutTime;

		// Token: 0x04026111 RID: 155921
		private float FrameLength;

		// Token: 0x04026112 RID: 155922
		private readonly TArray<AActor> BindingActors = new TArray<AActor>();

		// Token: 0x04026113 RID: 155923
		private readonly FFrameTime CurrentFrame = new FFrameTime();

		// Token: 0x04026114 RID: 155924
		private readonly Vector TmpVector = Vector.Create();

		// Token: 0x04026115 RID: 155925
		private int? DisableKey;
	}
}
