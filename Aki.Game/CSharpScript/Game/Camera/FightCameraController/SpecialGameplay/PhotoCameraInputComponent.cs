using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x02006481 RID: 25729
	[NullableContext(1)]
	[Nullable(0)]
	[RegisterPhotoCameraComponent(EPhotoCameraComponent.Input)]
	public class PhotoCameraInputComponent : PhotoCameraComponentBase
	{
		// Token: 0x0603E826 RID: 256038 RVA: 0x01232048 File Offset: 0x01230248
		protected override void OnActivate()
		{
			this.Context = new PhotoInputContext
			{
				Character = this.Host.Character,
				Logic = this.Host.GetComponent<PhotoCameraLogicComponent>(EPhotoCameraComponent.Logic)
			};
			this.MaskWorldInput();
			this.BindAxes();
			PhotoJoystickOwnerController currentJoystickOwner = PhotographController.Instance.CurrentJoystickOwner;
			if (currentJoystickOwner != null)
			{
				PhotoJoystickOwnerController photoJoystickOwnerController = currentJoystickOwner;
				photoJoystickOwnerController.OnOwnerChanged = (Action<EPhotoJoystickOwner, EPhotoJoystickOwner>)Delegate.Combine(photoJoystickOwnerController.OnOwnerChanged, new Action<EPhotoJoystickOwner, EPhotoJoystickOwner>(this.OnJoystickOwnerChanged));
			}
		}

		// Token: 0x0603E827 RID: 256039 RVA: 0x012320C0 File Offset: 0x012302C0
		protected override void OnDeactivate()
		{
			PhotoJoystickOwnerController currentJoystickOwner = PhotographController.Instance.CurrentJoystickOwner;
			if (currentJoystickOwner != null)
			{
				PhotoJoystickOwnerController photoJoystickOwnerController = currentJoystickOwner;
				photoJoystickOwnerController.OnOwnerChanged = (Action<EPhotoJoystickOwner, EPhotoJoystickOwner>)Delegate.Remove(photoJoystickOwnerController.OnOwnerChanged, new Action<EPhotoJoystickOwner, EPhotoJoystickOwner>(this.OnJoystickOwnerChanged));
			}
			this.UnbindAxes();
			this.ClearCharacterMoveAxis();
			this.UnmaskWorldInput();
			if (this.CurrentProcessor != null && this.Context != null)
			{
				this.CurrentProcessor.OnExit(this.Context);
			}
			this.CurrentProcessor = null;
			this.Context = null;
			this.ResetSnapshot();
		}

		// Token: 0x0603E828 RID: 256040 RVA: 0x01232144 File Offset: 0x01230344
		[NullableContext(2)]
		protected override void OnCharacterChanged(TsBaseCharacter character)
		{
			PhotoInputContext photoInputContext = this.Context as PhotoInputContext;
			if (photoInputContext != null)
			{
				photoInputContext.Character = character;
			}
		}

		// Token: 0x0603E829 RID: 256041 RVA: 0x01232168 File Offset: 0x01230368
		protected override void OnTick(float deltaTime)
		{
			if (this.CurrentProcessor != null && this.Context != null)
			{
				this.CurrentProcessor.Process(this.RawSnapshot, this.Context, this.Snapshot);
			}
			this.RawSnapshot.MoveForward = 0f;
			this.RawSnapshot.MoveRight = 0f;
			this.RawSnapshot.MoveUp = 0f;
			this.RawSnapshot.Pitch = 0f;
			this.RawSnapshot.Yaw = 0f;
			this.RawSnapshot.Roll = 0f;
			this.RawSnapshot.Fov = 0f;
		}

		// Token: 0x0603E82A RID: 256042 RVA: 0x01232212 File Offset: 0x01230412
		public IPhotoInputSnapshot GetSnapshot()
		{
			return this.Snapshot;
		}

		// Token: 0x0603E82B RID: 256043 RVA: 0x0123221A File Offset: 0x0123041A
		protected override void OnDestroy()
		{
			this.Processors.Clear();
			this.CurrentProcessor = null;
			this.Context = null;
		}

		// Token: 0x0603E82C RID: 256044 RVA: 0x01232238 File Offset: 0x01230438
		protected override void OnModeChangeFinish(PhotoCameraType? prev, PhotoCameraType next)
		{
			if (this.Context == null)
			{
				return;
			}
			if (this.CurrentProcessor != null)
			{
				this.CurrentProcessor.OnExit(this.Context);
			}
			this.CurrentProcessor = this.GetOrCreateProcessor(next);
			this.CurrentProcessor.OnEnter(this.Context);
			this.ApplyMoveControlByMode(new PhotoCameraType?(next));
		}

		// Token: 0x0603E82D RID: 256045 RVA: 0x01232294 File Offset: 0x01230494
		private void ApplyMoveControlByMode(PhotoCameraType? mode)
		{
			bool flag = PhotoCameraUtil.IsModeAllowCharacterMove(mode) && !PhotoCameraUtil.IsMoveBlocked();
			InputController.Instance.SetMoveControlEnabled(flag, flag, flag, flag);
		}

		// Token: 0x0603E82E RID: 256046 RVA: 0x012322C4 File Offset: 0x012304C4
		private PhotoInputProcessorBase GetOrCreateProcessor(PhotoCameraType mode)
		{
			PhotoInputProcessorBase photoInputProcessorBase;
			if (!this.Processors.TryGetValue(mode, out photoInputProcessorBase))
			{
				Func<PhotoInputProcessorBase> func;
				Func<PhotoInputProcessorBase> func2;
				if (!PhotoInputProcessorDefine.PhotoInputProcessorMap.TryGetValue(mode, out func))
				{
					func2 = (() => new PhotoInputProcessorBase());
				}
				else
				{
					func2 = func;
				}
				photoInputProcessorBase = func2();
				this.Processors.Add(mode, photoInputProcessorBase);
			}
			return photoInputProcessorBase;
		}

		// Token: 0x0603E82F RID: 256047 RVA: 0x01232326 File Offset: 0x01230526
		private void MaskWorldInput()
		{
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData == null)
			{
				return;
			}
			childViewData.SetChildVisible(EBattleUiVisibleReason.Custom, EBattleUiChild.Joystick, false, true, 0);
		}

		// Token: 0x0603E830 RID: 256048 RVA: 0x01232343 File Offset: 0x01230543
		private void UnmaskWorldInput()
		{
			InputController.Instance.SetMoveControlEnabled(true, true, true, true);
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData == null)
			{
				return;
			}
			childViewData.SetChildVisible(EBattleUiVisibleReason.Custom, EBattleUiChild.Joystick, true, true, 0);
		}

		// Token: 0x0603E831 RID: 256049 RVA: 0x01232370 File Offset: 0x01230570
		private void BindAxes()
		{
			InputDistributeController.Instance.BindAxisIgnoreLimit("PhotoMoveForward", new TInputHandle<float>(this.OnPhotoMoveForward));
			InputDistributeController.Instance.BindAxisIgnoreLimit("PhotoMoveRight", new TInputHandle<float>(this.OnPhotoMoveRight));
			InputDistributeController.Instance.BindAxisIgnoreLimit("PhotoMoveUp", new TInputHandle<float>(this.OnPhotoMoveUp));
			InputDistributeController.Instance.BindAxisIgnoreLimit("PhotoPitch", new TInputHandle<float>(this.OnPhotoPitch));
			InputDistributeController.Instance.BindAxisIgnoreLimit("PhotoYaw", new TInputHandle<float>(this.OnPhotoYaw));
			InputDistributeController.Instance.BindAxisIgnoreLimit("PhotoRoll", new TInputHandle<float>(this.OnPhotoRoll));
			InputDistributeController.Instance.BindAxisIgnoreLimit("PhotoFov", new TInputHandle<float>(this.OnPhotoFov));
		}

		// Token: 0x0603E832 RID: 256050 RVA: 0x0123243C File Offset: 0x0123063C
		private void UnbindAxes()
		{
			InputDistributeController.Instance.UnBindAxisIgnoreLimit("PhotoMoveForward", new TInputHandle<float>(this.OnPhotoMoveForward));
			InputDistributeController.Instance.UnBindAxisIgnoreLimit("PhotoMoveRight", new TInputHandle<float>(this.OnPhotoMoveRight));
			InputDistributeController.Instance.UnBindAxisIgnoreLimit("PhotoMoveUp", new TInputHandle<float>(this.OnPhotoMoveUp));
			InputDistributeController.Instance.UnBindAxisIgnoreLimit("PhotoPitch", new TInputHandle<float>(this.OnPhotoPitch));
			InputDistributeController.Instance.UnBindAxisIgnoreLimit("PhotoYaw", new TInputHandle<float>(this.OnPhotoYaw));
			InputDistributeController.Instance.UnBindAxisIgnoreLimit("PhotoRoll", new TInputHandle<float>(this.OnPhotoRoll));
			InputDistributeController.Instance.UnBindAxisIgnoreLimit("PhotoFov", new TInputHandle<float>(this.OnPhotoFov));
		}

		// Token: 0x0603E833 RID: 256051 RVA: 0x01232508 File Offset: 0x01230708
		private void OnJoystickOwnerChanged(EPhotoJoystickOwner prev, EPhotoJoystickOwner next)
		{
			if (prev == EPhotoJoystickOwner.CameraMove)
			{
				this.ResetSnapshot();
			}
			if (next == EPhotoJoystickOwner.CameraMove)
			{
				this.ClearCharacterMoveAxis();
			}
			IPhotoCameraHost host = this.Host;
			this.ApplyMoveControlByMode((host != null) ? host.CurrentMode : null);
			InputDistributeModel.Instance.RefreshInputDistributeTag();
		}

		// Token: 0x0603E834 RID: 256052 RVA: 0x01232551 File Offset: 0x01230751
		private void ClearCharacterMoveAxis()
		{
			EventSystem.Instance.Emit<string>(EEventName.ClearAxisInputCache, "MoveForward");
			EventSystem.Instance.Emit<string>(EEventName.ClearAxisInputCache, "MoveRight");
		}

		// Token: 0x0603E835 RID: 256053 RVA: 0x01232580 File Offset: 0x01230780
		private void ResetSnapshot()
		{
			this.RawSnapshot.MoveForward = 0f;
			this.RawSnapshot.MoveRight = 0f;
			this.RawSnapshot.MoveUp = 0f;
			this.RawSnapshot.Pitch = 0f;
			this.RawSnapshot.Yaw = 0f;
			this.RawSnapshot.Roll = 0f;
			this.RawSnapshot.Fov = 0f;
			this.Snapshot.MoveForward = 0f;
			this.Snapshot.MoveRight = 0f;
			this.Snapshot.MoveUp = 0f;
			this.Snapshot.Pitch = 0f;
			this.Snapshot.Yaw = 0f;
			this.Snapshot.Roll = 0f;
			this.Snapshot.Fov = 0f;
		}

		// Token: 0x0603E836 RID: 256054 RVA: 0x0123266D File Offset: 0x0123086D
		private void OnPhotoMoveForward(string name, float value, InputIdentification inputIdentification)
		{
			if (value == 0f || PhotoCameraUtil.IsCameraMoveBlockedByUi())
			{
				return;
			}
			this.RawSnapshot.MoveForward = value;
		}

		// Token: 0x0603E837 RID: 256055 RVA: 0x0123268B File Offset: 0x0123088B
		private void OnPhotoMoveRight(string name, float value, InputIdentification inputIdentification)
		{
			if (value == 0f || PhotoCameraUtil.IsMoveBlocked())
			{
				return;
			}
			this.RawSnapshot.MoveRight = value;
		}

		// Token: 0x0603E838 RID: 256056 RVA: 0x012326A9 File Offset: 0x012308A9
		private void OnPhotoMoveUp(string name, float value, InputIdentification inputIdentification)
		{
			if (value == 0f || PhotoCameraUtil.IsMoveBlocked())
			{
				return;
			}
			this.RawSnapshot.MoveUp = value;
		}

		// Token: 0x0603E839 RID: 256057 RVA: 0x012326C7 File Offset: 0x012308C7
		private void OnPhotoPitch(string name, float value, InputIdentification inputIdentification)
		{
			if (value == 0f || PhotoCameraUtil.IsInCursorMode())
			{
				return;
			}
			this.RawSnapshot.Pitch = value;
		}

		// Token: 0x0603E83A RID: 256058 RVA: 0x012326E5 File Offset: 0x012308E5
		private void OnPhotoYaw(string name, float value, InputIdentification inputIdentification)
		{
			if (value == 0f || PhotoCameraUtil.IsInCursorMode())
			{
				return;
			}
			this.RawSnapshot.Yaw = value;
		}

		// Token: 0x0603E83B RID: 256059 RVA: 0x01232703 File Offset: 0x01230903
		private void OnPhotoRoll(string name, float value, InputIdentification inputIdentification)
		{
			if (value == 0f || PhotoCameraUtil.IsCameraMoveBlockedByUi())
			{
				return;
			}
			this.RawSnapshot.Roll = value;
		}

		// Token: 0x0603E83C RID: 256060 RVA: 0x01232721 File Offset: 0x01230921
		private void OnPhotoFov(string name, float value, InputIdentification inputIdentification)
		{
			if (value == 0f || PhotoCameraUtil.IsInCursorMode())
			{
				return;
			}
			this.RawSnapshot.Fov = value;
		}

		// Token: 0x04021596 RID: 136598
		private readonly IPhotoInputSnapshot RawSnapshot = new PhotoInputSnapshot
		{
			MoveForward = 0f,
			MoveRight = 0f,
			MoveUp = 0f,
			Pitch = 0f,
			Yaw = 0f,
			Roll = 0f,
			Fov = 0f
		};

		// Token: 0x04021597 RID: 136599
		private readonly IPhotoInputSnapshot Snapshot = new PhotoInputSnapshot
		{
			MoveForward = 0f,
			MoveRight = 0f,
			MoveUp = 0f,
			Pitch = 0f,
			Yaw = 0f,
			Roll = 0f,
			Fov = 0f
		};

		// Token: 0x04021598 RID: 136600
		private readonly Dictionary<PhotoCameraType, PhotoInputProcessorBase> Processors = new Dictionary<PhotoCameraType, PhotoInputProcessorBase>();

		// Token: 0x04021599 RID: 136601
		[Nullable(2)]
		private PhotoInputProcessorBase CurrentProcessor;

		// Token: 0x0402159A RID: 136602
		[Nullable(2)]
		private IPhotoInputContext Context;
	}
}
