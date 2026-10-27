using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera.SceneCameraRotator;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072DC RID: 29404
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneCameraInputComponent : EntityComponent
	{
		// Token: 0x17009F42 RID: 40770
		// (get) Token: 0x0604827B RID: 295547 RVA: 0x012839BB File Offset: 0x01281BBB
		public CameraModelInstance CameraModel
		{
			get
			{
				return this.CameraModelInstanceInternal;
			}
		}

		// Token: 0x0604827C RID: 295548 RVA: 0x012839C3 File Offset: 0x01281BC3
		protected override bool OnCreate(IEntityArgs args = null)
		{
			this.CameraModelInstanceInternal = ((args != null) ? args.GetP1<CameraModelInstance>() : null);
			return base.OnCreate(args);
		}

		// Token: 0x0604827D RID: 295549 RVA: 0x012839DE File Offset: 0x01281BDE
		protected override bool OnStart()
		{
			this.DisplayComponent = base.Entity.GetComponent<SceneCameraDisplayComponent>();
			return this.DisplayComponent != null && this.DisplayComponent.Valid;
		}

		// Token: 0x0604827E RID: 295550 RVA: 0x01283A06 File Offset: 0x01281C06
		protected override bool OnEnd()
		{
			this.ClearAllRotator();
			this.LastBuiltSubCamera = null;
			this.LastBuiltFixInputData = null;
			this.LastBuiltFollowConfig = null;
			this.DisplayComponent = null;
			return true;
		}

		// Token: 0x0604827F RID: 295551 RVA: 0x01283A2C File Offset: 0x01281C2C
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

		// Token: 0x06048280 RID: 295552 RVA: 0x01283A80 File Offset: 0x01281C80
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

		// Token: 0x06048281 RID: 295553 RVA: 0x01283AD8 File Offset: 0x01281CD8
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

		// Token: 0x06048282 RID: 295554 RVA: 0x01283B42 File Offset: 0x01281D42
		private bool ShouldRebuildConfig(SceneSubCamera subCamera)
		{
			return subCamera != this.LastBuiltSubCamera || ((subCamera != null) ? subCamera.FixInputData : null) != this.LastBuiltFixInputData || ((subCamera != null) ? subCamera.FollowConfig : null) != this.LastBuiltFollowConfig;
		}

		// Token: 0x06048283 RID: 295555 RVA: 0x01283B7C File Offset: 0x01281D7C
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

		// Token: 0x06048284 RID: 295556 RVA: 0x01283C0F File Offset: 0x01281E0F
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

		// Token: 0x06048285 RID: 295557 RVA: 0x01283C36 File Offset: 0x01281E36
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

		// Token: 0x06048286 RID: 295558 RVA: 0x01283C6C File Offset: 0x01281E6C
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

		// Token: 0x06048287 RID: 295559 RVA: 0x01283C8A File Offset: 0x01281E8A
		protected override bool OnClear()
		{
			this.CameraModelInstanceInternal = null;
			return true;
		}

		// Token: 0x06048288 RID: 295560 RVA: 0x01283C94 File Offset: 0x01281E94
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneCameraInputComponent sceneCameraInputComponent = (SceneCameraInputComponent)componentTemplate;
			if (base.CanResetComponentProperty("CameraModelInstanceInternal"))
			{
				if (sceneCameraInputComponent.CameraModelInstanceInternal == null)
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
				if (sceneCameraInputComponent.DisplayComponent == null)
				{
					this.DisplayComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneCameraDisplayComponent>(this.DisplayComponent), "DisplayComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ConfigRotator"))
			{
				if (sceneCameraInputComponent.ConfigRotator == null)
				{
					this.ConfigRotator = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneCameraRotatorBase>(this.ConfigRotator), "ConfigRotator"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("OverrideRotator"))
			{
				if (sceneCameraInputComponent.OverrideRotator == null)
				{
					this.OverrideRotator = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneCameraRotatorBase>(this.OverrideRotator), "OverrideRotator"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("LastBuiltSubCamera"))
			{
				if (sceneCameraInputComponent.LastBuiltSubCamera == null)
				{
					this.LastBuiltSubCamera = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneSubCamera>(this.LastBuiltSubCamera), "LastBuiltSubCamera"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("LastBuiltFixInputData"))
			{
				if (sceneCameraInputComponent.LastBuiltFixInputData == null)
				{
					this.LastBuiltFixInputData = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneFixInputData>(this.LastBuiltFixInputData), "LastBuiltFixInputData"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("LastBuiltFollowConfig"))
			{
				if (sceneCameraInputComponent.LastBuiltFollowConfig == null)
				{
					this.LastBuiltFollowConfig = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneCameraFollowConfig>(this.LastBuiltFollowConfig), "LastBuiltFollowConfig"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04026158 RID: 155992
		private CameraModelInstance CameraModelInstanceInternal;

		// Token: 0x04026159 RID: 155993
		private SceneCameraDisplayComponent DisplayComponent;

		// Token: 0x0402615A RID: 155994
		private SceneCameraRotatorBase ConfigRotator;

		// Token: 0x0402615B RID: 155995
		private SceneCameraRotatorBase OverrideRotator;

		// Token: 0x0402615C RID: 155996
		private SceneSubCamera LastBuiltSubCamera;

		// Token: 0x0402615D RID: 155997
		private SceneFixInputData LastBuiltFixInputData;

		// Token: 0x0402615E RID: 155998
		private SceneCameraFollowConfig LastBuiltFollowConfig;
	}
}
