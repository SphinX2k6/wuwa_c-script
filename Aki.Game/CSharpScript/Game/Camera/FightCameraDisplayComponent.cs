using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SeamlessTravel;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x0200644F RID: 25679
	[NullableContext(2)]
	[Nullable(0)]
	public class FightCameraDisplayComponent : EntityComponent
	{
		// Token: 0x1700769B RID: 30363
		// (get) Token: 0x0603E5DB RID: 255451 RVA: 0x012220D0 File Offset: 0x012202D0
		public ACameraActor CameraActor
		{
			get
			{
				return this.CameraActorInternal;
			}
		}

		// Token: 0x0603E5DC RID: 255452 RVA: 0x012220D8 File Offset: 0x012202D8
		protected override bool OnCreate(IEntityArgs args = null)
		{
			this.CameraModelInstanceInternal = ((args != null) ? args.GetP1<CameraModelInstance>() : null);
			return base.OnCreate(args);
		}

		// Token: 0x0603E5DD RID: 255453 RVA: 0x012220F3 File Offset: 0x012202F3
		protected override bool OnInit()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.ClearWorld, new Action(this.OnClearWorld));
			return true;
		}

		// Token: 0x0603E5DE RID: 255454 RVA: 0x01222130 File Offset: 0x01220330
		private void OnWorldDone()
		{
			if (SeamlessTravelModel.Instance.IsSeamlessTravel)
			{
				CameraController.Instance.ReturnLockOnCameraMode(0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, this.CameraModelInstanceInternal.CameraName);
				return;
			}
			this.CameraActorInternal = CameraController.Instance.SpawnCameraActor();
			ECustomCameraMode? cameraMode = this.CameraModelInstanceInternal.CameraMode;
			ECustomCameraMode ecustomCameraMode = ECustomCameraMode.LockOn;
			if (cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null)
			{
				CameraController.Instance.SetViewTarget(this.CameraActorInternal, "FightCamera.OnWorldDone", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, new bool?(false), new bool?(false), this.CameraModelInstanceInternal.CameraName, null, null);
			}
		}

		// Token: 0x0603E5DF RID: 255455 RVA: 0x012221D8 File Offset: 0x012203D8
		private void OnClearWorld()
		{
			if (SeamlessTravelModel.Instance.IsSeamlessTravel)
			{
				CameraController.Instance.ReturnLockOnCameraMode(0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, this.CameraModelInstanceInternal.CameraName);
				return;
			}
			if (this.CameraActorInternal != null)
			{
				ActorSystem.Instance.Put("FightCameraDisplayComponent.OnClearWorld", this.CameraActorInternal, null);
				this.CameraActorInternal = null;
			}
		}

		// Token: 0x0603E5E0 RID: 255456 RVA: 0x0122223C File Offset: 0x0122043C
		protected override bool OnClear()
		{
			if (this.CameraActorInternal != null)
			{
				ActorSystem.Instance.Put("FightCameraDisplayComponent.OnClear", this.CameraActorInternal, null);
				this.CameraActorInternal = null;
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

		// Token: 0x0603E5E1 RID: 255457 RVA: 0x012222E9 File Offset: 0x012204E9
		protected override void OnChangeTimeDilation(float timeDilation)
		{
			ACameraActor cameraActorInternal = this.CameraActorInternal;
			if (cameraActorInternal != null && cameraActorInternal.IsValid())
			{
				this.CameraActorInternal.CustomTimeDilation = timeDilation;
			}
		}

		// Token: 0x0603E5E2 RID: 255458 RVA: 0x0122230C File Offset: 0x0122050C
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			FightCameraDisplayComponent fightCameraDisplayComponent = (FightCameraDisplayComponent)componentTemplate;
			if (fightCameraDisplayComponent.CameraModelInstanceInternal == null)
			{
				this.CameraModelInstanceInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraModelInstanceInternal), "CameraModelInstanceInternal"))
			{
				return false;
			}
			if (fightCameraDisplayComponent.CameraActorInternal == null)
			{
				this.CameraActorInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraActorInternal), "CameraActorInternal"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x1700769C RID: 30364
		// (get) Token: 0x0603E5E3 RID: 255459 RVA: 0x01222382 File Offset: 0x01220582
		public override bool NeedCreateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700769D RID: 30365
		// (get) Token: 0x0603E5E4 RID: 255460 RVA: 0x01222385 File Offset: 0x01220585
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700769E RID: 30366
		// (get) Token: 0x0603E5E5 RID: 255461 RVA: 0x01222388 File Offset: 0x01220588
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700769F RID: 30367
		// (get) Token: 0x0603E5E6 RID: 255462 RVA: 0x0122238B File Offset: 0x0122058B
		public override bool NeedChangeTimeDilationInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040213A9 RID: 136105
		private CameraModelInstance CameraModelInstanceInternal;

		// Token: 0x040213AA RID: 136106
		private ACameraActor CameraActorInternal;
	}
}
