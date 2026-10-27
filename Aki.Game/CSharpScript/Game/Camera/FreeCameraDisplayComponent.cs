using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072CF RID: 29391
	[NullableContext(2)]
	[Nullable(0)]
	public class FreeCameraDisplayComponent : EntityComponent
	{
		// Token: 0x17009F36 RID: 40758
		// (get) Token: 0x060481EC RID: 295404 RVA: 0x0127F9C9 File Offset: 0x0127DBC9
		// (set) Token: 0x060481ED RID: 295405 RVA: 0x0127F9D1 File Offset: 0x0127DBD1
		public ACameraActor CameraActor { get; private set; }

		// Token: 0x060481EE RID: 295406 RVA: 0x0127F9DA File Offset: 0x0127DBDA
		protected override bool OnCreate(IEntityArgs args = null)
		{
			this.CameraModelInstanceInternal = ((args != null) ? args.GetP1<CameraModelInstance>() : null);
			return base.OnCreate(args);
		}

		// Token: 0x060481EF RID: 295407 RVA: 0x0127F9F8 File Offset: 0x0127DBF8
		protected override bool OnInit()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.ClearWorld, new Action(this.OnClearWorld));
			if (GameModeModel.Instance.WorldDone)
			{
				this.SpawnCamera();
			}
			return true;
		}

		// Token: 0x060481F0 RID: 295408 RVA: 0x0127FA50 File Offset: 0x0127DC50
		private void OnWorldDone()
		{
			this.SpawnCamera();
		}

		// Token: 0x060481F1 RID: 295409 RVA: 0x0127FA58 File Offset: 0x0127DC58
		private void SpawnCamera()
		{
			if (this.CameraActor != null)
			{
				return;
			}
			this.CameraActor = CameraController.Instance.SpawnCameraActor();
			this.CameraActor.CustomTimeDilation = base.TimeDilation;
			ECustomCameraMode? cameraMode = this.CameraModelInstanceInternal.CameraMode;
			ECustomCameraMode ecustomCameraMode = ECustomCameraMode.Free;
			if (cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null)
			{
				CameraController.Instance.SetViewTarget(this.CameraActor, "FreeCamera.OnWorldDone", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, new bool?(false), new bool?(false), this.CameraModelInstanceInternal.CameraName, null, null);
			}
		}

		// Token: 0x060481F2 RID: 295410 RVA: 0x0127FAEA File Offset: 0x0127DCEA
		private void OnClearWorld()
		{
			if (this.CameraActor != null)
			{
				ActorSystem.Instance.Put("FreeCameraDisplayComponent.OnClearWorld", this.CameraActor, null);
				this.CameraActor = null;
			}
		}

		// Token: 0x060481F3 RID: 295411 RVA: 0x0127FB14 File Offset: 0x0127DD14
		protected override bool OnClear()
		{
			if (this.CameraActor != null)
			{
				ActorSystem.Instance.Put("FreeCameraDisplayComponent.OnClear", this.CameraActor, null);
				this.CameraActor = null;
			}
			if (EventSystem.Instance.Has(EEventName.WorldDone, new Action(this.OnWorldDone)))
			{
				EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			}
			if (EventSystem.Instance.Has(EEventName.ClearWorld, new Action(this.OnClearWorld)))
			{
				EventSystem.Instance.Remove(EEventName.ClearWorld, new Action(this.OnClearWorld));
			}
			this.CameraModelInstanceInternal = null;
			return true;
		}

		// Token: 0x060481F4 RID: 295412 RVA: 0x0127FBC1 File Offset: 0x0127DDC1
		protected override void OnChangeTimeDilation(float timeDilation)
		{
			ACameraActor cameraActor = this.CameraActor;
			if (cameraActor != null && cameraActor.IsValid())
			{
				this.CameraActor.CustomTimeDilation = timeDilation;
			}
		}

		// Token: 0x060481F5 RID: 295413 RVA: 0x0127FBE4 File Offset: 0x0127DDE4
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			FreeCameraDisplayComponent freeCameraDisplayComponent = (FreeCameraDisplayComponent)componentTemplate;
			if (base.CanResetComponentProperty("CameraModelInstanceInternal"))
			{
				if (freeCameraDisplayComponent.CameraModelInstanceInternal == null)
				{
					this.CameraModelInstanceInternal = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CameraModelInstance>(this.CameraModelInstanceInternal), "CameraModelInstanceInternal"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("<CameraActor>k__BackingField"))
			{
				if (freeCameraDisplayComponent.CameraActor == null)
				{
					this.CameraActor = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ACameraActor>(this.CameraActor), "<CameraActor>k__BackingField"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040260CB RID: 155851
		private CameraModelInstance CameraModelInstanceInternal;
	}
}
