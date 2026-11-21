using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006462 RID: 25698
	[NullableContext(2)]
	[Nullable(0)]
	public class SequenceCameraDisplayComponent : EntityComponent
	{
		// Token: 0x170076D1 RID: 30417
		// (get) Token: 0x0603E6D8 RID: 255704 RVA: 0x01227396 File Offset: 0x01225596
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

		// Token: 0x0603E6D9 RID: 255705 RVA: 0x012273C5 File Offset: 0x012255C5
		protected override bool OnCreate(IEntityArgs args = null)
		{
			this.CameraModelInstanceInternal = ((args != null) ? args.GetP1<CameraModelInstance>() : null);
			return base.OnCreate(args);
		}

		// Token: 0x0603E6DA RID: 255706 RVA: 0x012273E0 File Offset: 0x012255E0
		protected override bool OnInit()
		{
			this.CineCameraInternal = CameraController.Instance.SpawnCineCamera();
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.ClearWorld, new Action(this.OnClearWorld));
			return true;
		}

		// Token: 0x0603E6DB RID: 255707 RVA: 0x01227438 File Offset: 0x01225638
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

		// Token: 0x0603E6DC RID: 255708 RVA: 0x012274B0 File Offset: 0x012256B0
		protected void OnClearWorld()
		{
			if (this.CineCameraInternal != null)
			{
				ActorSystem.Instance.Put("SequenceCameraDisplayComponent.OnClearWorld", this.CineCameraInternal, null);
				this.CineCameraInternal = null;
			}
		}

		// Token: 0x0603E6DD RID: 255709 RVA: 0x012274D8 File Offset: 0x012256D8
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

		// Token: 0x0603E6DE RID: 255710 RVA: 0x0122757E File Offset: 0x0122577E
		protected override void OnChangeTimeDilation(float timeDilation)
		{
			BP_CineCamera_C cineCameraInternal = this.CineCameraInternal;
			if (cineCameraInternal != null && cineCameraInternal.IsValid())
			{
				this.CineCameraInternal.CustomTimeDilation = timeDilation;
			}
		}

		// Token: 0x0603E6DF RID: 255711 RVA: 0x012275A0 File Offset: 0x012257A0
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SequenceCameraDisplayComponent sequenceCameraDisplayComponent = (SequenceCameraDisplayComponent)componentTemplate;
			if (sequenceCameraDisplayComponent.CameraModelInstanceInternal == null)
			{
				this.CameraModelInstanceInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraModelInstanceInternal), "CameraModelInstanceInternal"))
			{
				return false;
			}
			if (sequenceCameraDisplayComponent.CineCameraInternal == null)
			{
				this.CineCameraInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CineCameraInternal), "CineCameraInternal"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x170076D2 RID: 30418
		// (get) Token: 0x0603E6E0 RID: 255712 RVA: 0x01227616 File Offset: 0x01225816
		public override bool NeedCreateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076D3 RID: 30419
		// (get) Token: 0x0603E6E1 RID: 255713 RVA: 0x01227619 File Offset: 0x01225819
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076D4 RID: 30420
		// (get) Token: 0x0603E6E2 RID: 255714 RVA: 0x0122761C File Offset: 0x0122581C
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076D5 RID: 30421
		// (get) Token: 0x0603E6E3 RID: 255715 RVA: 0x0122761F File Offset: 0x0122581F
		public override bool NeedChangeTimeDilationInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04021450 RID: 136272
		private CameraModelInstance CameraModelInstanceInternal;

		// Token: 0x04021451 RID: 136273
		private BP_CineCamera_C CineCameraInternal;
	}
}
