using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x0200398E RID: 14734
	[NullableContext(1)]
	[Nullable(0)]
	public class UiCameraInputComponent : UiCameraComponent
	{
		// Token: 0x06025ED6 RID: 155350 RVA: 0x00AA6173 File Offset: 0x00AA4373
		internal void Bind(object owner, SUiRoleCameraSetting cameraSettingConfig, SUiRoleCameraOffsetSetting? cameraOffsetConfig, FVector sourceLocation)
		{
			this.BindingOwner = owner;
			this.CameraSettingConfig = cameraSettingConfig;
			this.CameraOffsetConfig = cameraOffsetConfig;
			this.SourceLocation = sourceLocation;
			this.HasConfiguration = true;
			this.InputActive = true;
			this.TickPaused = false;
			this.RefreshConfiguration();
		}

		// Token: 0x06025ED7 RID: 155351 RVA: 0x00AA61AD File Offset: 0x00AA43AD
		internal void Unbind(object owner)
		{
			if (this.BindingOwner != owner)
			{
				return;
			}
			this.BindingOwner = null;
			this.HasConfiguration = false;
			this.Deactivate();
		}

		// Token: 0x06025ED8 RID: 155352 RVA: 0x00AA61CD File Offset: 0x00AA43CD
		public void Activate()
		{
			this.BindingOwner = null;
			this.HasConfiguration = false;
			this.InputActive = true;
			this.TickPaused = false;
		}

		// Token: 0x06025ED9 RID: 155353 RVA: 0x00AA61EB File Offset: 0x00AA43EB
		public void Deactivate()
		{
			this.BindingOwner = null;
			this.InputActive = false;
			this.ResetInput();
		}

		// Token: 0x06025EDA RID: 155354 RVA: 0x00AA6201 File Offset: 0x00AA4401
		public void PauseTick()
		{
			this.TickPaused = true;
			this.ResetInput();
		}

		// Token: 0x06025EDB RID: 155355 RVA: 0x00AA6210 File Offset: 0x00AA4410
		public void ResumeTick()
		{
			this.TickPaused = false;
		}

		// Token: 0x06025EDC RID: 155356 RVA: 0x00AA6219 File Offset: 0x00AA4419
		public void AddZoomInput(float value)
		{
			if (!this.CanReceiveInput())
			{
				return;
			}
			this.ZoomInput += value;
		}

		// Token: 0x06025EDD RID: 155357 RVA: 0x00AA6232 File Offset: 0x00AA4432
		internal void AddZoomInput(object owner, float value)
		{
			if (this.CanReceiveInput(owner))
			{
				this.ZoomInput += value;
			}
		}

		// Token: 0x06025EDE RID: 155358 RVA: 0x00AA624B File Offset: 0x00AA444B
		public void AddYawInput(float value)
		{
			if (!this.CanReceiveInput())
			{
				return;
			}
			this.YawInput += value;
		}

		// Token: 0x06025EDF RID: 155359 RVA: 0x00AA6264 File Offset: 0x00AA4464
		internal void AddYawInput(object owner, float value)
		{
			if (this.CanReceiveInput(owner))
			{
				this.YawInput += value;
			}
		}

		// Token: 0x06025EE0 RID: 155360 RVA: 0x00AA627D File Offset: 0x00AA447D
		public void AddPitchInput(float value)
		{
			if (!this.CanReceiveInput())
			{
				return;
			}
			this.PitchInput += value;
		}

		// Token: 0x06025EE1 RID: 155361 RVA: 0x00AA6296 File Offset: 0x00AA4496
		internal void AddPitchInput(object owner, float value)
		{
			if (this.CanReceiveInput(owner))
			{
				this.PitchInput += value;
			}
		}

		// Token: 0x06025EE2 RID: 155362 RVA: 0x00AA62AF File Offset: 0x00AA44AF
		internal void SetModeBlocked(bool blocked)
		{
			this.ModeBlocked = blocked;
			if (blocked)
			{
				this.ResetInput();
			}
		}

		// Token: 0x06025EE3 RID: 155363 RVA: 0x00AA62C1 File Offset: 0x00AA44C1
		public override void Tick(float deltaTime)
		{
			if (!this.CanReceiveInput())
			{
				return;
			}
			base.Mode.GetComponent<UiCameraLogicComponent>().ApplyInput(this.YawInput, this.PitchInput, this.ZoomInput, deltaTime);
			this.ResetInput();
		}

		// Token: 0x06025EE4 RID: 155364 RVA: 0x00AA62F5 File Offset: 0x00AA44F5
		protected override void OnEnterMode()
		{
			if (this.BindingOwner != null && this.HasConfiguration)
			{
				this.InputActive = true;
				this.RefreshConfiguration();
			}
		}

		// Token: 0x06025EE5 RID: 155365 RVA: 0x00AA6314 File Offset: 0x00AA4514
		protected override void OnExitMode()
		{
			this.InputActive = false;
			this.ResetInput();
		}

		// Token: 0x06025EE6 RID: 155366 RVA: 0x00AA6323 File Offset: 0x00AA4523
		public override void Clear()
		{
			this.Deactivate();
			this.HasConfiguration = false;
		}

		// Token: 0x06025EE7 RID: 155367 RVA: 0x00AA6334 File Offset: 0x00AA4534
		internal void RefreshConfiguration()
		{
			if (!this.InputActive || !this.HasConfiguration)
			{
				return;
			}
			UiCameraLogicComponent component = base.Mode.GetComponent<UiCameraLogicComponent>();
			component.InitDataByConfig(this.CameraSettingConfig);
			component.SetNeedFloorReflection(true);
			if (this.CameraOffsetConfig != null)
			{
				SUiRoleCameraOffsetSetting value = this.CameraOffsetConfig.Value;
				component.UpdateData(this.SourceLocation, value.镜头浮动最大高度, value.镜头浮动最低高度, value.镜头浮动最长臂长, value.镜头浮动最短臂长);
				return;
			}
			component.UpdateData(this.SourceLocation, 0f, 0f, 0f, 0f);
		}

		// Token: 0x06025EE8 RID: 155368 RVA: 0x00AA63CF File Offset: 0x00AA45CF
		private void ResetInput()
		{
			this.YawInput = 0f;
			this.PitchInput = 0f;
			this.ZoomInput = 0f;
		}

		// Token: 0x06025EE9 RID: 155369 RVA: 0x00AA63F2 File Offset: 0x00AA45F2
		internal bool CanReceiveInput()
		{
			return this.InputActive && !this.TickPaused && !this.ModeBlocked;
		}

		// Token: 0x06025EEA RID: 155370 RVA: 0x00AA640F File Offset: 0x00AA460F
		internal bool CanReceiveInput(object owner)
		{
			return this.BindingOwner == owner && this.CanReceiveInput();
		}

		// Token: 0x04014DB9 RID: 85433
		private float YawInput;

		// Token: 0x04014DBA RID: 85434
		private float PitchInput;

		// Token: 0x04014DBB RID: 85435
		private float ZoomInput;

		// Token: 0x04014DBC RID: 85436
		private bool InputActive;

		// Token: 0x04014DBD RID: 85437
		private bool TickPaused;

		// Token: 0x04014DBE RID: 85438
		private bool ModeBlocked;

		// Token: 0x04014DBF RID: 85439
		private bool HasConfiguration;

		// Token: 0x04014DC0 RID: 85440
		[Nullable(2)]
		private object BindingOwner;

		// Token: 0x04014DC1 RID: 85441
		private SUiRoleCameraSetting CameraSettingConfig;

		// Token: 0x04014DC2 RID: 85442
		private SUiRoleCameraOffsetSetting? CameraOffsetConfig;

		// Token: 0x04014DC3 RID: 85443
		private FVector SourceLocation;
	}
}
