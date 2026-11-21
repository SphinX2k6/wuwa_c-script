using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006468 RID: 25704
	[NullableContext(2)]
	[Nullable(0)]
	public class WidgetCameraDisplayComponent : EntityComponent
	{
		// Token: 0x170076E4 RID: 30436
		// (get) Token: 0x0603E754 RID: 255828 RVA: 0x0122C765 File Offset: 0x0122A965
		// (set) Token: 0x0603E755 RID: 255829 RVA: 0x0122C76D File Offset: 0x0122A96D
		public BP_CineCamera_C CineCamera { get; private set; }

		// Token: 0x0603E756 RID: 255830 RVA: 0x0122C776 File Offset: 0x0122A976
		protected override bool OnCreate(IEntityArgs args = null)
		{
			this.CameraModelInstanceInternal = ((args != null) ? args.GetP1<CameraModelInstance>() : null);
			return base.OnCreate(args);
		}

		// Token: 0x0603E757 RID: 255831 RVA: 0x0122C791 File Offset: 0x0122A991
		protected override bool OnInit()
		{
			bool result = this.RefreshCineCamera();
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.OnUiManagerClearAsync, new Action(this.OnUiManagerClearAsync));
			return result;
		}

		// Token: 0x0603E758 RID: 255832 RVA: 0x0122C7D4 File Offset: 0x0122A9D4
		private void OnWorldDone()
		{
			if (this.RefreshCineCamera())
			{
				ECustomCameraMode? cameraMode = this.CameraModelInstanceInternal.CameraMode;
				ECustomCameraMode ecustomCameraMode = ECustomCameraMode.Widget;
				if (cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null)
				{
					CameraController.Instance.SetViewTarget(this.CineCamera, "WidgetCamera.OnWorldDone", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, new bool?(false), new bool?(false), this.CameraModelInstanceInternal.CameraName, null, null);
				}
			}
		}

		// Token: 0x0603E759 RID: 255833 RVA: 0x0122C844 File Offset: 0x0122AA44
		public bool RefreshCineCamera()
		{
			BP_CineCamera_C cineCamera = this.CineCamera;
			if (cineCamera != null && cineCamera.IsValid())
			{
				return true;
			}
			this.CineCamera = CameraController.Instance.SpawnCineCamera();
			BP_CineCamera_C cineCamera2 = this.CineCamera;
			return cineCamera2 != null && cineCamera2.IsValid();
		}

		// Token: 0x0603E75A RID: 255834 RVA: 0x0122C87D File Offset: 0x0122AA7D
		private void OnUiManagerClearAsync()
		{
			if (this.CineCamera != null)
			{
				ActorSystem.Instance.Put("WidgetCameraDisplayComponent.OnUiManagerClearAsync", this.CineCamera, null);
				this.CineCamera = null;
			}
		}

		// Token: 0x0603E75B RID: 255835 RVA: 0x0122C8A8 File Offset: 0x0122AAA8
		protected override bool OnClear()
		{
			if (this.CineCamera != null)
			{
				ActorSystem.Instance.Put("WidgetCameraDisplayComponent.OnClear", this.CineCamera, null);
				this.CineCamera = null;
			}
			if (EventSystem.Instance.Has(EEventName.WorldDone, new Action(this.OnWorldDone)))
			{
				EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			}
			if (EventSystem.Instance.Has(EEventName.OnUiManagerClearAsync, new Action(this.OnUiManagerClearAsync)))
			{
				EventSystem.Instance.Remove(EEventName.OnUiManagerClearAsync, new Action(this.OnUiManagerClearAsync));
			}
			this.CameraModelInstanceInternal = null;
			return true;
		}

		// Token: 0x0603E75C RID: 255836 RVA: 0x0122C955 File Offset: 0x0122AB55
		protected override void OnChangeTimeDilation(float timeDilation)
		{
			BP_CineCamera_C cineCamera = this.CineCamera;
			if (cineCamera != null && cineCamera.IsValid())
			{
				this.CineCamera.CustomTimeDilation = timeDilation;
			}
		}

		// Token: 0x0603E75D RID: 255837 RVA: 0x0122C978 File Offset: 0x0122AB78
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			WidgetCameraDisplayComponent widgetCameraDisplayComponent = (WidgetCameraDisplayComponent)componentTemplate;
			if (widgetCameraDisplayComponent.CameraModelInstanceInternal == null)
			{
				this.CameraModelInstanceInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraModelInstanceInternal), "CameraModelInstanceInternal"))
			{
				return false;
			}
			if (widgetCameraDisplayComponent.CineCamera == null)
			{
				this.CineCamera = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CineCamera), "CineCamera"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x170076E5 RID: 30437
		// (get) Token: 0x0603E75E RID: 255838 RVA: 0x0122C9EE File Offset: 0x0122ABEE
		public override bool NeedCreateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076E6 RID: 30438
		// (get) Token: 0x0603E75F RID: 255839 RVA: 0x0122C9F1 File Offset: 0x0122ABF1
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076E7 RID: 30439
		// (get) Token: 0x0603E760 RID: 255840 RVA: 0x0122C9F4 File Offset: 0x0122ABF4
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076E8 RID: 30440
		// (get) Token: 0x0603E761 RID: 255841 RVA: 0x0122C9F7 File Offset: 0x0122ABF7
		public override bool NeedChangeTimeDilationInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040214E2 RID: 136418
		private CameraModelInstance CameraModelInstanceInternal;
	}
}
