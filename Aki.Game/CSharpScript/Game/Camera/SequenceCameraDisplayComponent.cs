using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072DF RID: 29407
	[NullableContext(2)]
	[Nullable(0)]
	public class SequenceCameraDisplayComponent : EntityComponent
	{
		// Token: 0x17009F45 RID: 40773
		// (get) Token: 0x060482A5 RID: 295589 RVA: 0x012848D3 File Offset: 0x01282AD3
		public BP_CineCamera_C CineCamera
		{
			get
			{
				BP_CineCamera_C cineCameraInternal = this.CineCameraInternal;
				if (cineCameraInternal == null || !cineCameraInternal.IsValid())
				{
					this.CineCameraInternal = CameraController.Instance.SpawnCineCamera();
				}
				return this.CineCameraInternal;
			}
		}

		// Token: 0x060482A6 RID: 295590 RVA: 0x01284902 File Offset: 0x01282B02
		protected override bool OnCreate(IEntityArgs args = null)
		{
			this.CameraModelInstanceInternal = ((args != null) ? args.GetP1<CameraModelInstance>() : null);
			return base.OnCreate(args);
		}

		// Token: 0x060482A7 RID: 295591 RVA: 0x01284920 File Offset: 0x01282B20
		protected override bool OnInit()
		{
			this.CineCameraInternal = CameraController.Instance.SpawnCineCamera();
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.ClearWorld, new Action(this.OnClearWorld));
			return true;
		}

		// Token: 0x060482A8 RID: 295592 RVA: 0x01284978 File Offset: 0x01282B78
		protected void OnWorldDone()
		{
			this.CineCameraInternal = CameraController.Instance.SpawnCineCamera();
			ECustomCameraMode? cameraMode = this.CameraModelInstanceInternal.CameraMode;
			ECustomCameraMode ecustomCameraMode = ECustomCameraMode.Sequence;
			if (cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null)
			{
				CameraController.Instance.SetViewTarget(this.CineCameraInternal, "SequenceCamera.OnWorldDone", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, new bool?(false), new bool?(false), this.CameraModelInstanceInternal.CameraName, null, null);
			}
		}

		// Token: 0x060482A9 RID: 295593 RVA: 0x012849F0 File Offset: 0x01282BF0
		protected void OnClearWorld()
		{
			if (this.CineCameraInternal != null)
			{
				ActorSystem.Instance.Put("SequenceCameraDisplayComponent.OnClearWorld", this.CineCameraInternal, null);
				this.CineCameraInternal = null;
			}
		}

		// Token: 0x060482AA RID: 295594 RVA: 0x01284A18 File Offset: 0x01282C18
		protected override bool OnClear()
		{
			if (this.CineCameraInternal != null)
			{
				ActorSystem.Instance.Put("SequenceCameraDisplayComponent.OnClearWorld", this.CineCameraInternal, null);
				this.CineCameraInternal = null;
			}
			if (EventSystem.Instance.Has(EEventName.WorldDone, new Action(this.OnWorldDone)))
			{
				EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			}
			if (EventSystem.Instance.Has(EEventName.ClearWorld, new Action(this.OnClearWorld)))
			{
				EventSystem.Instance.Remove(EEventName.ClearWorld, new Action(this.OnClearWorld));
			}
			return true;
		}

		// Token: 0x060482AB RID: 295595 RVA: 0x01284ABE File Offset: 0x01282CBE
		protected override void OnChangeTimeDilation(float timeDilation)
		{
			BP_CineCamera_C cineCameraInternal = this.CineCameraInternal;
			if (cineCameraInternal != null && cineCameraInternal.IsValid())
			{
				this.CineCameraInternal.CustomTimeDilation = timeDilation;
			}
		}

		// Token: 0x060482AC RID: 295596 RVA: 0x01284AE0 File Offset: 0x01282CE0
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SequenceCameraDisplayComponent sequenceCameraDisplayComponent = (SequenceCameraDisplayComponent)componentTemplate;
			if (base.CanResetComponentProperty("CameraModelInstanceInternal"))
			{
				if (sequenceCameraDisplayComponent.CameraModelInstanceInternal == null)
				{
					this.CameraModelInstanceInternal = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CameraModelInstance>(this.CameraModelInstanceInternal), "CameraModelInstanceInternal"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CineCameraInternal"))
			{
				if (sequenceCameraDisplayComponent.CineCameraInternal == null)
				{
					this.CineCameraInternal = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BP_CineCamera_C>(this.CineCameraInternal), "CineCameraInternal"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04026166 RID: 156006
		private CameraModelInstance CameraModelInstanceInternal;

		// Token: 0x04026167 RID: 156007
		private BP_CineCamera_C CineCameraInternal;
	}
}
