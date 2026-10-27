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
	// Token: 0x020072FE RID: 29438
	[NullableContext(1)]
	[Nullable(0)]
	[RegisterPhotoCameraComponent(EPhotoCameraComponent.Input)]
	public class PhotoCameraInputComponent : PhotoCameraComponentBase
	{
		// Token: 0x060483DA RID: 295898 RVA: 0x0128F694 File Offset: 0x0128D894
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

		// Token: 0x060483DB RID: 295899 RVA: 0x0128F70C File Offset: 0x0128D90C
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

		// Token: 0x060483DC RID: 295900 RVA: 0x0128F790 File Offset: 0x0128D990
		[NullableContext(2)]
		protected override void OnCharacterChanged(TsBaseCharacter character)
		{
			PhotoInputContext photoInputContext = this.Context as PhotoInputContext;
			if (photoInputContext != null)
			{
				photoInputContext.Character = character;
			}
		}

		// Token: 0x060483DD RID: 295901 RVA: 0x0128F7B4 File Offset: 0x0128D9B4
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

		// Token: 0x060483DE RID: 295902 RVA: 0x0128F85E File Offset: 0x0128DA5E
		public IPhotoInputSnapshot GetSnapshot()
		{
			return this.Snapshot;
		}

		// Token: 0x060483DF RID: 295903 RVA: 0x0128F866 File Offset: 0x0128DA66
		protected override void OnDestroy()
		{
			this.Processors.Clear();
			this.CurrentProcessor = null;
			this.Context = null;
		}

		// Token: 0x060483E0 RID: 295904 RVA: 0x0128F884 File Offset: 0x0128DA84
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

		// Token: 0x060483E1 RID: 295905 RVA: 0x0128F8E0 File Offset: 0x0128DAE0
		private void ApplyMoveControlByMode(PhotoCameraType? mode)
		{
			bool flag = PhotoCameraUtil.IsModeAllowCharacterMove(mode) && !PhotoCameraUtil.IsMoveBlocked();
			InputController.Instance.SetMoveControlEnabled(flag, flag, flag, flag);
		}

		// Token: 0x060483E2 RID: 295906 RVA: 0x0128F910 File Offset: 0x0128DB10
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

		// Token: 0x060483E3 RID: 295907 RVA: 0x0128F972 File Offset: 0x0128DB72
		private void MaskWorldInput()
		{
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData == null)
			{
				return;
			}
			childViewData.SetChildVisible(EBattleUiVisibleReason.Custom, EBattleUiChild.Joystick, false, true, 0);
		}

		// Token: 0x060483E4 RID: 295908 RVA: 0x0128F98F File Offset: 0x0128DB8F
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

		// Token: 0x060483E5 RID: 295909 RVA: 0x0128F9BC File Offset: 0x0128DBBC
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

		// Token: 0x060483E6 RID: 295910 RVA: 0x0128FA88 File Offset: 0x0128DC88
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

		// Token: 0x060483E7 RID: 295911 RVA: 0x0128FB54 File Offset: 0x0128DD54
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

		// Token: 0x060483E8 RID: 295912 RVA: 0x0128FB9D File Offset: 0x0128DD9D
		private void ClearCharacterMoveAxis()
		{
			EventSystem.Instance.Emit<string>(EEventName.ClearAxisInputCache, "MoveForward");
			EventSystem.Instance.Emit<string>(EEventName.ClearAxisInputCache, "MoveRight");
		}

		// Token: 0x060483E9 RID: 295913 RVA: 0x0128FBCC File Offset: 0x0128DDCC
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

		// Token: 0x060483EA RID: 295914 RVA: 0x0128FCB9 File Offset: 0x0128DEB9
		private void OnPhotoMoveForward(string name, float value, InputIdentification inputIdentification)
		{
			if (value == 0f || PhotoCameraUtil.IsCameraMoveBlockedByUi())
			{
				return;
			}
			this.RawSnapshot.MoveForward = value;
		}

		// Token: 0x060483EB RID: 295915 RVA: 0x0128FCD7 File Offset: 0x0128DED7
		private void OnPhotoMoveRight(string name, float value, InputIdentification inputIdentification)
		{
			if (value == 0f || PhotoCameraUtil.IsMoveBlocked())
			{
				return;
			}
			this.RawSnapshot.MoveRight = value;
		}

		// Token: 0x060483EC RID: 295916 RVA: 0x0128FCF5 File Offset: 0x0128DEF5
		private void OnPhotoMoveUp(string name, float value, InputIdentification inputIdentification)
		{
			if (value == 0f || PhotoCameraUtil.IsMoveBlocked())
			{
				return;
			}
			this.RawSnapshot.MoveUp = value;
		}

		// Token: 0x060483ED RID: 295917 RVA: 0x0128FD13 File Offset: 0x0128DF13
		private void OnPhotoPitch(string name, float value, InputIdentification inputIdentification)
		{
			if (value == 0f || PhotoCameraUtil.IsInCursorMode())
			{
				return;
			}
			this.RawSnapshot.Pitch = value;
		}

		// Token: 0x060483EE RID: 295918 RVA: 0x0128FD31 File Offset: 0x0128DF31
		private void OnPhotoYaw(string name, float value, InputIdentification inputIdentification)
		{
			if (value == 0f || PhotoCameraUtil.IsInCursorMode())
			{
				return;
			}
			this.RawSnapshot.Yaw = value;
		}

		// Token: 0x060483EF RID: 295919 RVA: 0x0128FD4F File Offset: 0x0128DF4F
		private void OnPhotoRoll(string name, float value, InputIdentification inputIdentification)
		{
			if (value == 0f || PhotoCameraUtil.IsCameraMoveBlockedByUi())
			{
				return;
			}
			this.RawSnapshot.Roll = value;
		}

		// Token: 0x060483F0 RID: 295920 RVA: 0x0128FD6D File Offset: 0x0128DF6D
		private void OnPhotoFov(string name, float value, InputIdentification inputIdentification)
		{
			if (value == 0f || PhotoCameraUtil.IsInCursorMode())
			{
				return;
			}
			this.RawSnapshot.Fov = value;
		}

		// Token: 0x040262AB RID: 156331
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

		// Token: 0x040262AC RID: 156332
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

		// Token: 0x040262AD RID: 156333
		private readonly Dictionary<PhotoCameraType, PhotoInputProcessorBase> Processors = new Dictionary<PhotoCameraType, PhotoInputProcessorBase>();

		// Token: 0x040262AE RID: 156334
		[Nullable(2)]
		private PhotoInputProcessorBase CurrentProcessor;

		// Token: 0x040262AF RID: 156335
		[Nullable(2)]
		private IPhotoInputContext Context;
	}
}
