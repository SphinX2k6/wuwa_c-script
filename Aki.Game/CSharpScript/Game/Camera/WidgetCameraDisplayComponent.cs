using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072E5 RID: 29413
	[NullableContext(2)]
	[Nullable(0)]
	public class WidgetCameraDisplayComponent : EntityComponent
	{
		// Token: 0x17009F4A RID: 40778
		// (get) Token: 0x0604830D RID: 295693 RVA: 0x01289DC1 File Offset: 0x01287FC1
		// (set) Token: 0x0604830E RID: 295694 RVA: 0x01289DC9 File Offset: 0x01287FC9
		public BP_CineCamera_C CineCamera { get; private set; }

		// Token: 0x0604830F RID: 295695 RVA: 0x01289DD2 File Offset: 0x01287FD2
		protected override bool OnCreate(IEntityArgs args = null)
		{
			this.CameraModelInstanceInternal = ((args != null) ? args.GetP1<CameraModelInstance>() : null);
			return base.OnCreate(args);
		}

		// Token: 0x06048310 RID: 295696 RVA: 0x01289DF0 File Offset: 0x01287FF0
		protected override bool OnInit()
		{
			this.CineCamera = CameraController.Instance.SpawnCineCamera();
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.OnUiManagerClearAsync, new Action(this.OnUiManagerClearAsync));
			return this.CineCamera != null;
		}

		// Token: 0x06048311 RID: 295697 RVA: 0x01289E50 File Offset: 0x01288050
		private void OnWorldDone()
		{
			this.CineCamera = CameraController.Instance.SpawnCineCamera();
			ECustomCameraMode? cameraMode = this.CameraModelInstanceInternal.CameraMode;
			ECustomCameraMode ecustomCameraMode = ECustomCameraMode.Widget;
			if (cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null)
			{
				CameraController.Instance.SetViewTarget(this.CineCamera, "WidgetCamera.OnWorldDone", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, new bool?(false), new bool?(false), this.CameraModelInstanceInternal.CameraName, null, null);
			}
		}

		// Token: 0x06048312 RID: 295698 RVA: 0x01289EC8 File Offset: 0x012880C8
		private void OnUiManagerClearAsync()
		{
			if (this.CineCamera != null)
			{
				ActorSystem.Instance.Put("WidgetCameraDisplayComponent.OnUiManagerClearAsync", this.CineCamera, null);
				this.CineCamera = null;
			}
		}

		// Token: 0x06048313 RID: 295699 RVA: 0x01289EF0 File Offset: 0x012880F0
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

		// Token: 0x06048314 RID: 295700 RVA: 0x01289F9D File Offset: 0x0128819D
		protected override void OnChangeTimeDilation(float timeDilation)
		{
			BP_CineCamera_C cineCamera = this.CineCamera;
			if (cineCamera != null && cineCamera.IsValid())
			{
				this.CineCamera.CustomTimeDilation = timeDilation;
			}
		}

		// Token: 0x06048315 RID: 295701 RVA: 0x01289FC0 File Offset: 0x012881C0
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			WidgetCameraDisplayComponent widgetCameraDisplayComponent = (WidgetCameraDisplayComponent)componentTemplate;
			if (base.CanResetComponentProperty("CameraModelInstanceInternal"))
			{
				if (widgetCameraDisplayComponent.CameraModelInstanceInternal == null)
				{
					this.CameraModelInstanceInternal = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CameraModelInstance>(this.CameraModelInstanceInternal), "CameraModelInstanceInternal"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("<CineCamera>k__BackingField"))
			{
				if (widgetCameraDisplayComponent.CineCamera == null)
				{
					this.CineCamera = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BP_CineCamera_C>(this.CineCamera), "<CineCamera>k__BackingField"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040261F7 RID: 156151
		private CameraModelInstance CameraModelInstanceInternal;
	}
}
