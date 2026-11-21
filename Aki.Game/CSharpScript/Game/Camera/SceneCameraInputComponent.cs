using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera.SceneCameraRotator;

namespace CSharpScript.Game.Camera
{
	// Token: 0x0200645E RID: 25694
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneCameraInputComponent : EntityComponent
	{
		// Token: 0x170076C2 RID: 30402
		// (get) Token: 0x0603E695 RID: 255637 RVA: 0x0122615A File Offset: 0x0122435A
		public CameraModelInstance CameraModel
		{
			get
			{
				return this.CameraModelInstanceInternal;
			}
		}

		// Token: 0x0603E696 RID: 255638 RVA: 0x01226162 File Offset: 0x01224362
		protected override bool OnCreate(IEntityArgs args = null)
		{
			this.CameraModelInstanceInternal = ((args != null) ? args.GetP1<CameraModelInstance>() : null);
			return base.OnCreate(args);
		}

		// Token: 0x0603E697 RID: 255639 RVA: 0x0122617D File Offset: 0x0122437D
		protected override bool OnStart()
		{
			this.DisplayComponent = base.Entity.GetComponent<SceneCameraDisplayComponent>();
			return this.DisplayComponent != null && this.DisplayComponent.Valid;
		}

		// Token: 0x0603E698 RID: 255640 RVA: 0x012261A5 File Offset: 0x012243A5
		protected override bool OnEnd()
		{
			this.ClearAllRotator();
			this.LastBuiltSubCamera = null;
			this.LastBuiltFixInputData = null;
			this.LastBuiltFollowConfig = null;
			this.DisplayComponent = null;
			return true;
		}

		// Token: 0x0603E699 RID: 255641 RVA: 0x012261CC File Offset: 0x012243CC
		protected override void OnTick(float deltaTime)
		{
			if (this.DisplayComponent == null)
			{
				return;
			}
			SceneSubCamera curSceneSubCamera = this.DisplayComponent.CurSceneSubCamera;
			FightCameraLogicComponent fightLogic = this.GetFightLogic();
			if (this.ShouldRebuildConfig(curSceneSubCamera))
			{
				this.RebuildConfigRotator(curSceneSubCamera);
			}
			if (curSceneSubCamera == null || fightLogic == null)
			{
				return;
			}
			SceneCameraRotatorBase activeRotator = this.GetActiveRotator();
			if (activeRotator == null)
			{
				return;
			}
			activeRotator.OnTick(curSceneSubCamera, fightLogic, deltaTime);
		}

		// Token: 0x0603E69A RID: 255642 RVA: 0x01226220 File Offset: 0x01224420
		[NullableContext(1)]
		public void SetLookAtTarget(Vector targetPosition, float blendInMs)
		{
			SceneCameraDisplayComponent displayComponent = this.DisplayComponent;
			SceneSubCamera sceneSubCamera = (displayComponent != null) ? displayComponent.CurSceneSubCamera : null;
			FightCameraLogicComponent fightLogic = this.GetFightLogic();
			if (sceneSubCamera == null || fightLogic == null)
			{
				return;
			}
			if (this.ShouldRebuildConfig(sceneSubCamera))
			{
				this.RebuildConfigRotator(sceneSubCamera);
			}
			SceneCameraBlendToTargetRotator sceneCameraBlendToTargetRotator = new SceneCameraBlendToTargetRotator();
			if (!sceneCameraBlendToTargetRotator.InitFromLookAtTarget(sceneSubCamera, fightLogic, targetPosition, blendInMs))
			{
				return;
			}
			this.SetOverrideRotator(sceneCameraBlendToTargetRotator);
		}

		// Token: 0x0603E69B RID: 255643 RVA: 0x01226278 File Offset: 0x01224478
		private SceneCameraRotatorBase GetActiveRotator()
		{
			if (this.OverrideRotator != null)
			{
				if (this.OverrideRotator.IsValid())
				{
					return this.OverrideRotator;
				}
				this.OverrideRotator.OnDeactivate();
				this.OverrideRotator = null;
			}
			if (this.ConfigRotator != null)
			{
				if (this.ConfigRotator.IsValid())
				{
					return this.ConfigRotator;
				}
				this.ConfigRotator.OnDeactivate();
				this.ConfigRotator = null;
			}
			return null;
		}

		// Token: 0x0603E69C RID: 255644 RVA: 0x012262E2 File Offset: 0x012244E2
		private bool ShouldRebuildConfig(SceneSubCamera subCamera)
		{
			return subCamera != this.LastBuiltSubCamera || ((subCamera != null) ? subCamera.FixInputData : null) != this.LastBuiltFixInputData || ((subCamera != null) ? subCamera.FollowConfig : null) != this.LastBuiltFollowConfig;
		}

		// Token: 0x0603E69D RID: 255645 RVA: 0x0122631C File Offset: 0x0122451C
		private void RebuildConfigRotator(SceneSubCamera subCamera)
		{
			this.ClearAllRotator();
			if (subCamera != null)
			{
				if (subCamera.CanAcceptInput && subCamera.FixInputData != null)
				{
					this.ConfigRotator = new SceneCameraInputRotator(subCamera.FixInputData);
					this.ConfigRotator.OnActivate();
				}
				else if (subCamera.FollowConfig != null)
				{
					this.ConfigRotator = new SceneCameraFollowTargetRotator(subCamera.FollowConfig);
					this.ConfigRotator.OnActivate();
				}
			}
			this.LastBuiltSubCamera = subCamera;
			this.LastBuiltFixInputData = ((subCamera != null) ? subCamera.FixInputData : null);
			this.LastBuiltFollowConfig = ((subCamera != null) ? subCamera.FollowConfig : null);
		}

		// Token: 0x0603E69E RID: 255646 RVA: 0x012263AF File Offset: 0x012245AF
		[NullableContext(1)]
		private void SetOverrideRotator(SceneCameraRotatorBase rotator)
		{
			if (this.OverrideRotator != null)
			{
				this.OverrideRotator.OnDeactivate();
			}
			this.OverrideRotator = rotator;
			this.OverrideRotator.OnActivate();
		}

		// Token: 0x0603E69F RID: 255647 RVA: 0x012263D6 File Offset: 0x012245D6
		private void ClearAllRotator()
		{
			if (this.OverrideRotator != null)
			{
				this.OverrideRotator.OnDeactivate();
				this.OverrideRotator = null;
			}
			if (this.ConfigRotator != null)
			{
				this.ConfigRotator.OnDeactivate();
				this.ConfigRotator = null;
			}
		}

		// Token: 0x0603E6A0 RID: 255648 RVA: 0x0122640C File Offset: 0x0122460C
		private FightCameraLogicComponent GetFightLogic()
		{
			CameraModelInstance cameraModel = this.CameraModel;
			if (cameraModel == null)
			{
				return null;
			}
			FightCamera fightCamera = cameraModel.FightCamera;
			if (fightCamera == null)
			{
				return null;
			}
			return fightCamera.LogicComponent;
		}

		// Token: 0x0603E6A1 RID: 255649 RVA: 0x0122642A File Offset: 0x0122462A
		protected override bool OnClear()
		{
			this.CameraModelInstanceInternal = null;
			return true;
		}

		// Token: 0x0603E6A2 RID: 255650 RVA: 0x01226434 File Offset: 0x01224634
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneCameraInputComponent sceneCameraInputComponent = (SceneCameraInputComponent)componentTemplate;
			if (sceneCameraInputComponent.CameraModelInstanceInternal == null)
			{
				this.CameraModelInstanceInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraModelInstanceInternal), "CameraModelInstanceInternal"))
			{
				return false;
			}
			if (sceneCameraInputComponent.DisplayComponent == null)
			{
				this.DisplayComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DisplayComponent), "DisplayComponent"))
			{
				return false;
			}
			if (sceneCameraInputComponent.ConfigRotator == null)
			{
				this.ConfigRotator = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ConfigRotator), "ConfigRotator"))
			{
				return false;
			}
			if (sceneCameraInputComponent.OverrideRotator == null)
			{
				this.OverrideRotator = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OverrideRotator), "OverrideRotator"))
			{
				return false;
			}
			if (sceneCameraInputComponent.LastBuiltSubCamera == null)
			{
				this.LastBuiltSubCamera = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastBuiltSubCamera), "LastBuiltSubCamera"))
			{
				return false;
			}
			if (sceneCameraInputComponent.LastBuiltFixInputData == null)
			{
				this.LastBuiltFixInputData = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastBuiltFixInputData), "LastBuiltFixInputData"))
			{
				return false;
			}
			if (sceneCameraInputComponent.LastBuiltFollowConfig == null)
			{
				this.LastBuiltFollowConfig = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastBuiltFollowConfig), "LastBuiltFollowConfig"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x170076C3 RID: 30403
		// (get) Token: 0x0603E6A3 RID: 255651 RVA: 0x01226581 File Offset: 0x01224781
		public override bool NeedCreateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076C4 RID: 30404
		// (get) Token: 0x0603E6A4 RID: 255652 RVA: 0x01226584 File Offset: 0x01224784
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076C5 RID: 30405
		// (get) Token: 0x0603E6A5 RID: 255653 RVA: 0x01226587 File Offset: 0x01224787
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076C6 RID: 30406
		// (get) Token: 0x0603E6A6 RID: 255654 RVA: 0x0122658A File Offset: 0x0122478A
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076C7 RID: 30407
		// (get) Token: 0x0603E6A7 RID: 255655 RVA: 0x0122658D File Offset: 0x0122478D
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0402143B RID: 136251
		private CameraModelInstance CameraModelInstanceInternal;

		// Token: 0x0402143C RID: 136252
		private SceneCameraDisplayComponent DisplayComponent;

		// Token: 0x0402143D RID: 136253
		private SceneCameraRotatorBase ConfigRotator;

		// Token: 0x0402143E RID: 136254
		private SceneCameraRotatorBase OverrideRotator;

		// Token: 0x0402143F RID: 136255
		private SceneSubCamera LastBuiltSubCamera;

		// Token: 0x04021440 RID: 136256
		private SceneFixInputData LastBuiltFixInputData;

		// Token: 0x04021441 RID: 136257
		private SceneCameraFollowConfig LastBuiltFollowConfig;
	}
}
