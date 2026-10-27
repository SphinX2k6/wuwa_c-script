using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200257A RID: 9594
[NullableContext(1)]
[Nullable(0)]
public class PhotoMoveCtrlPanel : UiPanelBase
{
	// Token: 0x06013617 RID: 79383 RVA: 0x004D2A08 File Offset: 0x004D0C08
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem))
		};
	}

	// Token: 0x06013618 RID: 79384 RVA: 0x004D2AE8 File Offset: 0x004D0CE8
	protected override UniTask OnBeforeStartAsync()
	{
		PhotoMoveCtrlPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhotoMoveCtrlPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013619 RID: 79385 RVA: 0x004D2B2C File Offset: 0x004D0D2C
	protected override void OnStart()
	{
		this.BindMoveButton(PhotoMoveCtrlPanel.EComponents.BtnFront, "PhotoMoveForward", 1f);
		this.BindMoveButton(PhotoMoveCtrlPanel.EComponents.BtnBack, "PhotoMoveForward", -1f);
		this.BindMoveButton(PhotoMoveCtrlPanel.EComponents.BtnLeft, "PhotoMoveRight", -1f);
		this.BindMoveButton(PhotoMoveCtrlPanel.EComponents.BtnRight, "PhotoMoveRight", 1f);
		this.BindMoveButton(PhotoMoveCtrlPanel.EComponents.BtnUp, "PhotoMoveUp", 1f);
		this.BindMoveButton(PhotoMoveCtrlPanel.EComponents.BtnDown, "PhotoMoveUp", -1f);
	}

	// Token: 0x0601361A RID: 79386 RVA: 0x004D2B9F File Offset: 0x004D0D9F
	public void TickJoystick(float delta)
	{
		PhotoJoystickPanel joystickPanel = this.JoystickPanel;
		if (joystickPanel == null)
		{
			return;
		}
		joystickPanel.Tick(delta);
	}

	// Token: 0x0601361B RID: 79387 RVA: 0x004D2BB4 File Offset: 0x004D0DB4
	public void RefreshByMode(PhotoCameraType mode)
	{
		bool flag = PhotoCameraUtil.IsModeAllowCharacterMove(new PhotoCameraType?(mode));
		if (flag)
		{
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			PhotoJoystickPanel joystickPanel = this.JoystickPanel;
			if (joystickPanel != null)
			{
				joystickPanel.ShowBattleVisibleChildView();
			}
		}
		else
		{
			PhotoJoystickPanel joystickPanel2 = this.JoystickPanel;
			if (joystickPanel2 != null)
			{
				joystickPanel2.HideBattleVisibleChildView();
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
		}
		UUIItem item3 = base.GetItem(8);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(!flag);
	}

	// Token: 0x0601361C RID: 79388 RVA: 0x004D2C30 File Offset: 0x004D0E30
	protected override void OnBeforeDestroy()
	{
		this.JoystickPanel = null;
		this.UnbindMoveButton(PhotoMoveCtrlPanel.EComponents.BtnFront);
		this.UnbindMoveButton(PhotoMoveCtrlPanel.EComponents.BtnBack);
		this.UnbindMoveButton(PhotoMoveCtrlPanel.EComponents.BtnLeft);
		this.UnbindMoveButton(PhotoMoveCtrlPanel.EComponents.BtnRight);
		this.UnbindMoveButton(PhotoMoveCtrlPanel.EComponents.BtnUp);
		this.UnbindMoveButton(PhotoMoveCtrlPanel.EComponents.BtnDown);
		this.ViewModel.MoveForwardInputValue = 0f;
		this.ViewModel.MoveRightInputValue = 0f;
		this.ViewModel.MoveUpInputValue = 0f;
	}

	// Token: 0x0601361D RID: 79389 RVA: 0x004D2CA0 File Offset: 0x004D0EA0
	private void BindMoveButton(PhotoMoveCtrlPanel.EComponents comp, string axisName, float value)
	{
		UUIButtonComponent button = base.GetButton((int)comp);
		if (button == null)
		{
			return;
		}
		button.OnPointDownCallBack.Bind(delegate()
		{
			this.SetMoveInput(axisName, value);
		});
		button.OnPointUpCallBack.Bind(delegate()
		{
			this.ReleaseMoveInput(axisName);
		});
		button.OnPointCancelCallBack.Bind(delegate()
		{
			this.ReleaseMoveInput(axisName);
		});
	}

	// Token: 0x0601361E RID: 79390 RVA: 0x004D2D1C File Offset: 0x004D0F1C
	private void SetMoveInput(string axisName, float value)
	{
		if (axisName == "PhotoMoveForward")
		{
			this.ViewModel.MoveForwardInputValue = value;
			return;
		}
		if (axisName == "PhotoMoveRight")
		{
			this.ViewModel.MoveRightInputValue = value;
			return;
		}
		if (axisName == "PhotoMoveUp")
		{
			this.ViewModel.MoveUpInputValue = value;
		}
	}

	// Token: 0x0601361F RID: 79391 RVA: 0x004D2D76 File Offset: 0x004D0F76
	private void ReleaseMoveInput(string axisName)
	{
		this.SetMoveInput(axisName, 0f);
		InputDistributeController.Instance.InputAxis(axisName, 0f, false);
	}

	// Token: 0x06013620 RID: 79392 RVA: 0x004D2D98 File Offset: 0x004D0F98
	private void UnbindMoveButton(PhotoMoveCtrlPanel.EComponents comp)
	{
		UUIButtonComponent button = base.GetButton((int)comp);
		if (button == null)
		{
			return;
		}
		button.OnPointDownCallBack.Unbind();
		button.OnPointUpCallBack.Unbind();
		button.OnPointCancelCallBack.Unbind();
	}

	// Token: 0x06013621 RID: 79393 RVA: 0x004D2DD2 File Offset: 0x004D0FD2
	public void SetViewModel(PhotoMainViewModel viewModel)
	{
		this.ViewModel = viewModel;
	}

	// Token: 0x040091EE RID: 37358
	private PhotoMainViewModel ViewModel;

	// Token: 0x040091EF RID: 37359
	[Nullable(2)]
	private PhotoJoystickPanel JoystickPanel;

	// Token: 0x040091F0 RID: 37360
	private const float MOVE_AXIS_VALUE = 1f;

	// Token: 0x02008B71 RID: 35697
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402D472 RID: 185458
		BtnUp,
		// Token: 0x0402D473 RID: 185459
		BtnDown,
		// Token: 0x0402D474 RID: 185460
		BtnLeft,
		// Token: 0x0402D475 RID: 185461
		BtnRight,
		// Token: 0x0402D476 RID: 185462
		BtnFront,
		// Token: 0x0402D477 RID: 185463
		BtnBack,
		// Token: 0x0402D478 RID: 185464
		ItemMoveCharacter,
		// Token: 0x0402D479 RID: 185465
		ItemJoystick,
		// Token: 0x0402D47A RID: 185466
		ItemMoveCamera
	}
}
