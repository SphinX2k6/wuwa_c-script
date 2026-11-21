using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A65 RID: 6757
[NullableContext(1)]
[Nullable(0)]
public class PhotoMoveCtrlPanel : UiPanelBase
{
	// Token: 0x06010AFA RID: 68346 RVA: 0x004E1670 File Offset: 0x004DF870
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

	// Token: 0x06010AFB RID: 68347 RVA: 0x004E1750 File Offset: 0x004DF950
	protected override UniTask OnBeforeStartAsync()
	{
		PhotoMoveCtrlPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhotoMoveCtrlPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010AFC RID: 68348 RVA: 0x004E1794 File Offset: 0x004DF994
	protected override void OnStart()
	{
		this.BindMoveButton(PhotoMoveCtrlPanel.EComponents.BtnFront, "PhotoMoveForward", 1f);
		this.BindMoveButton(PhotoMoveCtrlPanel.EComponents.BtnBack, "PhotoMoveForward", -1f);
		this.BindMoveButton(PhotoMoveCtrlPanel.EComponents.BtnLeft, "PhotoMoveRight", -1f);
		this.BindMoveButton(PhotoMoveCtrlPanel.EComponents.BtnRight, "PhotoMoveRight", 1f);
		this.BindMoveButton(PhotoMoveCtrlPanel.EComponents.BtnUp, "PhotoMoveUp", 1f);
		this.BindMoveButton(PhotoMoveCtrlPanel.EComponents.BtnDown, "PhotoMoveUp", -1f);
	}

	// Token: 0x06010AFD RID: 68349 RVA: 0x004E1807 File Offset: 0x004DFA07
	public void TickJoystick(float delta)
	{
		PhotoJoystickPanel joystickPanel = this.JoystickPanel;
		if (joystickPanel == null)
		{
			return;
		}
		joystickPanel.Tick(delta);
	}

	// Token: 0x06010AFE RID: 68350 RVA: 0x004E181C File Offset: 0x004DFA1C
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

	// Token: 0x06010AFF RID: 68351 RVA: 0x004E1898 File Offset: 0x004DFA98
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

	// Token: 0x06010B00 RID: 68352 RVA: 0x004E1908 File Offset: 0x004DFB08
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

	// Token: 0x06010B01 RID: 68353 RVA: 0x004E1984 File Offset: 0x004DFB84
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

	// Token: 0x06010B02 RID: 68354 RVA: 0x004E19DE File Offset: 0x004DFBDE
	private void ReleaseMoveInput(string axisName)
	{
		this.SetMoveInput(axisName, 0f);
		InputDistributeController.Instance.InputAxis(axisName, 0f, false);
	}

	// Token: 0x06010B03 RID: 68355 RVA: 0x004E1A00 File Offset: 0x004DFC00
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

	// Token: 0x06010B04 RID: 68356 RVA: 0x004E1A3A File Offset: 0x004DFC3A
	public void SetViewModel(PhotoMainViewModel viewModel)
	{
		this.ViewModel = viewModel;
	}

	// Token: 0x04009347 RID: 37703
	private PhotoMainViewModel ViewModel;

	// Token: 0x04009348 RID: 37704
	[Nullable(2)]
	private PhotoJoystickPanel JoystickPanel;

	// Token: 0x04009349 RID: 37705
	private const float MOVE_AXIS_VALUE = 1f;

	// Token: 0x02007CF7 RID: 31991
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402877F RID: 165759
		BtnUp,
		// Token: 0x04028780 RID: 165760
		BtnDown,
		// Token: 0x04028781 RID: 165761
		BtnLeft,
		// Token: 0x04028782 RID: 165762
		BtnRight,
		// Token: 0x04028783 RID: 165763
		BtnFront,
		// Token: 0x04028784 RID: 165764
		BtnBack,
		// Token: 0x04028785 RID: 165765
		ItemMoveCharacter,
		// Token: 0x04028786 RID: 165766
		ItemJoystick,
		// Token: 0x04028787 RID: 165767
		ItemMoveCamera
	}
}
