using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SeamlessTravel;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072CD RID: 29389
	[NullableContext(2)]
	[Nullable(0)]
	public class FightCameraDisplayComponent : EntityComponent
	{
		// Token: 0x17009F32 RID: 40754
		// (get) Token: 0x060481D8 RID: 295384 RVA: 0x0127F5D4 File Offset: 0x0127D7D4
		public ACameraActor CameraActor
		{
			get
			{
				return this.CameraActorInternal;
			}
		}

		// Token: 0x060481D9 RID: 295385 RVA: 0x0127F5DC File Offset: 0x0127D7DC
		protected override bool OnCreate(IEntityArgs args = null)
		{
			this.CameraModelInstanceInternal = ((args != null) ? args.GetP1<CameraModelInstance>() : null);
			return base.OnCreate(args);
		}

		// Token: 0x060481DA RID: 295386 RVA: 0x0127F5F7 File Offset: 0x0127D7F7
		protected override bool OnInit()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.ClearWorld, new Action(this.OnClearWorld));
			return true;
		}

		// Token: 0x060481DB RID: 295387 RVA: 0x0127F634 File Offset: 0x0127D834
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

		// Token: 0x060481DC RID: 295388 RVA: 0x0127F6DC File Offset: 0x0127D8DC
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

		// Token: 0x060481DD RID: 295389 RVA: 0x0127F740 File Offset: 0x0127D940
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

		// Token: 0x060481DE RID: 295390 RVA: 0x0127F7ED File Offset: 0x0127D9ED
		protected override void OnChangeTimeDilation(float timeDilation)
		{
			ACameraActor cameraActorInternal = this.CameraActorInternal;
			if (cameraActorInternal != null && cameraActorInternal.IsValid())
			{
				this.CameraActorInternal.CustomTimeDilation = timeDilation;
			}
		}

		// Token: 0x060481DF RID: 295391 RVA: 0x0127F810 File Offset: 0x0127DA10
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			FightCameraDisplayComponent fightCameraDisplayComponent = (FightCameraDisplayComponent)componentTemplate;
			if (base.CanResetComponentProperty("CameraModelInstanceInternal"))
			{
				if (fightCameraDisplayComponent.CameraModelInstanceInternal == null)
				{
					this.CameraModelInstanceInternal = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CameraModelInstance>(this.CameraModelInstanceInternal), "CameraModelInstanceInternal"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CameraActorInternal"))
			{
				if (fightCameraDisplayComponent.CameraActorInternal == null)
				{
					this.CameraActorInternal = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ACameraActor>(this.CameraActorInternal), "CameraActorInternal"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040260C6 RID: 155846
		private CameraModelInstance CameraModelInstanceInternal;

		// Token: 0x040260C7 RID: 155847
		private ACameraActor CameraActorInternal;
	}
}
