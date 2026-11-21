using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006451 RID: 25681
	[NullableContext(2)]
	[Nullable(0)]
	public class FreeCameraDisplayComponent : EntityComponent
	{
		// Token: 0x170076A3 RID: 30371
		// (get) Token: 0x0603E5F3 RID: 255475 RVA: 0x012224B5 File Offset: 0x012206B5
		// (set) Token: 0x0603E5F4 RID: 255476 RVA: 0x012224BD File Offset: 0x012206BD
		public ACameraActor CameraActor { get; private set; }

		// Token: 0x0603E5F5 RID: 255477 RVA: 0x012224C6 File Offset: 0x012206C6
		protected override bool OnCreate(IEntityArgs args = null)
		{
			this.CameraModelInstanceInternal = ((args != null) ? args.GetP1<CameraModelInstance>() : null);
			return base.OnCreate(args);
		}

		// Token: 0x0603E5F6 RID: 255478 RVA: 0x012224E4 File Offset: 0x012206E4
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

		// Token: 0x0603E5F7 RID: 255479 RVA: 0x0122253C File Offset: 0x0122073C
		private void OnWorldDone()
		{
			this.SpawnCamera();
		}

		// Token: 0x0603E5F8 RID: 255480 RVA: 0x01222544 File Offset: 0x01220744
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

		// Token: 0x0603E5F9 RID: 255481 RVA: 0x012225D6 File Offset: 0x012207D6
		private void OnClearWorld()
		{
			if (this.CameraActor != null)
			{
				ActorSystem.Instance.Put("FreeCameraDisplayComponent.OnClearWorld", this.CameraActor, null);
				this.CameraActor = null;
			}
		}

		// Token: 0x0603E5FA RID: 255482 RVA: 0x01222600 File Offset: 0x01220800
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

		// Token: 0x0603E5FB RID: 255483 RVA: 0x012226AD File Offset: 0x012208AD
		protected override void OnChangeTimeDilation(float timeDilation)
		{
			ACameraActor cameraActor = this.CameraActor;
			if (cameraActor != null && cameraActor.IsValid())
			{
				this.CameraActor.CustomTimeDilation = timeDilation;
			}
		}

		// Token: 0x0603E5FC RID: 255484 RVA: 0x012226D0 File Offset: 0x012208D0
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			FreeCameraDisplayComponent freeCameraDisplayComponent = (FreeCameraDisplayComponent)componentTemplate;
			if (freeCameraDisplayComponent.CameraModelInstanceInternal == null)
			{
				this.CameraModelInstanceInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraModelInstanceInternal), "CameraModelInstanceInternal"))
			{
				return false;
			}
			if (freeCameraDisplayComponent.CameraActor == null)
			{
				this.CameraActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraActor), "CameraActor"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x170076A4 RID: 30372
		// (get) Token: 0x0603E5FD RID: 255485 RVA: 0x01222746 File Offset: 0x01220946
		public override bool NeedCreateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076A5 RID: 30373
		// (get) Token: 0x0603E5FE RID: 255486 RVA: 0x01222749 File Offset: 0x01220949
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076A6 RID: 30374
		// (get) Token: 0x0603E5FF RID: 255487 RVA: 0x0122274C File Offset: 0x0122094C
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076A7 RID: 30375
		// (get) Token: 0x0603E600 RID: 255488 RVA: 0x0122274F File Offset: 0x0122094F
		public override bool NeedChangeTimeDilationInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040213AE RID: 136110
		private CameraModelInstance CameraModelInstanceInternal;
	}
}
