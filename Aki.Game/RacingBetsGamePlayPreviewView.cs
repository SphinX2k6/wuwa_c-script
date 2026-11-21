using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C1C RID: 7196
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsGamePlayPreviewView : UiViewBase, IUiViewCameraBehavior
{
	// Token: 0x06011DDA RID: 73178 RVA: 0x005409BD File Offset: 0x0053EBBD
	public RacingBetsGamePlayPreviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011DDB RID: 73179 RVA: 0x005409D4 File Offset: 0x0053EBD4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIDraggableComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(10, typeof(UUISprite)),
			new ValueTuple<int, Type>(11, typeof(UUISprite)),
			new ValueTuple<int, Type>(12, typeof(UUISprite)),
			new ValueTuple<int, Type>(13, typeof(UUISprite)),
			new ValueTuple<int, Type>(14, typeof(UUISprite)),
			new ValueTuple<int, Type>(15, typeof(UUIText)),
			new ValueTuple<int, Type>(16, typeof(UUIText)),
			new ValueTuple<int, Type>(17, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickCloseButton)),
			new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.OnToggleClick)),
			new ValueTuple<int, Delegate>(7, new Action(this.OnDangoSkillBtnClick))
		};
	}

	// Token: 0x06011DDC RID: 73180 RVA: 0x00540BA8 File Offset: 0x0053EDA8
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
		InputDistributeController.Instance.BindAxis("UiMoveForward", new TInputHandle<float>(this.OnUiMove));
		InputDistributeController.Instance.BindAxis("UiMoveRight", new TInputHandle<float>(this.OnUiMove));
		UUIDraggableComponent draggable = base.GetDraggable(4);
		if (draggable == null)
		{
			return;
		}
		draggable.OnPointerDownCallBack.Bind(delegate(ULGUIPointerEventData _)
		{
			this.OnMovedCallback();
		});
	}

	// Token: 0x06011DDD RID: 73181 RVA: 0x00540C2C File Offset: 0x0053EE2C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
		InputDistributeController.Instance.UnBindAxis("UiMoveForward", new TInputHandle<float>(this.OnUiMove));
		InputDistributeController.Instance.UnBindAxis("UiMoveRight", new TInputHandle<float>(this.OnUiMove));
		UUIDraggableComponent draggable = base.GetDraggable(4);
		if (draggable == null)
		{
			return;
		}
		draggable.OnPointerDownCallBack.Unbind();
	}

	// Token: 0x06011DDE RID: 73182 RVA: 0x00540CA4 File Offset: 0x0053EEA4
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsGamePlayPreviewView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsGamePlayPreviewView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011DDF RID: 73183 RVA: 0x00540CE7 File Offset: 0x0053EEE7
	public void PushCameraHandleByOpenView(EUiViewName viewName, int viewId, EUiCameraHandleOperationType operationType)
	{
		UiCameraController.Instance.PushCameraHandleByOpenView(viewName, viewId, EUiCameraHandleOperationType.Blend);
	}

	// Token: 0x06011DE0 RID: 73184 RVA: 0x00540CF8 File Offset: 0x0053EEF8
	protected override void OnBeforeShow()
	{
		UUIItem item = base.GetItem(17);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		int valueOrDefault = ConfigCommonParamById.GetIntConfig("RacingBetsPreviewViewIntervalTime").GetValueOrDefault(5000);
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.TimerHandle = null;
			UUIItem item2 = base.GetItem(17);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			base.PlaySequence("DragTipsShow", null, false);
			this.IsDragTipShowed = true;
		}, (float)valueOrDefault, null, null, true, 1f);
	}

	// Token: 0x06011DE1 RID: 73185 RVA: 0x00540D57 File Offset: 0x0053EF57
	protected override void OnBeforeHide()
	{
		TimerHandle timerHandle = this.TimerHandle;
		if (timerHandle != null)
		{
			timerHandle.Remove();
		}
		this.TimerHandle = null;
	}

	// Token: 0x06011DE2 RID: 73186 RVA: 0x00540D74 File Offset: 0x0053EF74
	public void PopCameraHandleByCloseView(EUiViewName viewName, EUiViewName? nextViewName, int closeViewId, EUiCameraHandleOperationType operationType)
	{
		if (this.CanCameraInput)
		{
			FreeCamera freeCamera = CameraController.Instance.MainModel.FreeCamera;
			if (freeCamera != null)
			{
				FreeCameraInputComponent inputComponent = freeCamera.InputComponent;
				if (inputComponent != null)
				{
					inputComponent.ResetInputData();
				}
			}
			FreeCamera freeCamera2 = CameraController.Instance.MainModel.FreeCamera;
			if (freeCamera2 != null)
			{
				FreeCameraInputComponent inputComponent2 = freeCamera2.InputComponent;
				if (inputComponent2 != null)
				{
					inputComponent2.UnBindAxes();
				}
			}
		}
		UiCameraController.Instance.DeepCopyCamera(CameraController.Instance.MainModel.FreeCamera.DisplayComponent.CameraActor);
		CameraController instance = CameraController.Instance;
		UiCamera uiCamera = UiCameraModel.Instance.UiCamera;
		instance.SetViewTarget((uiCamera != null) ? uiCamera.GetCameraActor() : null, "RacingBetsGamePlayPreviewView", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, null, "MainCamera", null, null);
		UiCameraController.Instance.PopCameraHandleByCloseView(viewName, nextViewName, closeViewId, operationType);
	}

	// Token: 0x06011DE3 RID: 73187 RVA: 0x00540E50 File Offset: 0x0053F050
	private void OnActivateUiCameraAnimationHandle(UiCameraHandleData handleData)
	{
		if (handleData.GetViewName() == EUiViewName.RacingBetsGamePlayPreviewView && this.CanCameraInput)
		{
			CameraController.Instance.MainModel.FreeCamera.LogicComponent.InitConfig(RacingBetsGamePlayPreviewView.ToFloatArray(ConfigCommonParamById.GetIntArrayConfig("RacingBetsPreviewViewCameraIdList"), RacingBetsGamePlayPreviewView.defaultFreeCameraConfigList));
			CameraController.Instance.MainModel.FreeCamera.InputComponent.CanCameraInput = true;
			CameraController.Instance.MainModel.FreeCamera.InputComponent.SetIsMoveBySelf(false);
			CameraController.Instance.MainModel.FreeCamera.InputComponent.BindAxes(base.GetDraggable(4));
			UiCameraController.Instance.ExitUiCameraMode();
		}
	}

	// Token: 0x06011DE4 RID: 73188 RVA: 0x00540F0D File Offset: 0x0053F10D
	private RacingBetsPreviewViewOrganItem CreateOrganItem()
	{
		return new RacingBetsPreviewViewOrganItem
		{
			OnToggleCallBack = new Action<int, int>(this.OnOrganItemClick)
		};
	}

	// Token: 0x06011DE5 RID: 73189 RVA: 0x00540F28 File Offset: 0x0053F128
	private void OnOrganItemClick(int index, int id)
	{
		GenericLayout<RacingBetsPreviewViewOrganItem, int> organLayout = this.OrganLayout;
		if (organLayout != null)
		{
			organLayout.SelectGridProxy(index, false);
		}
		RacingBetsOrgan? organConfig = RacingBetsConfig.Instance.GetOrganConfig(id);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(15), organConfig.Value.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(16), organConfig.Value.Description, Array.Empty<object>());
		int num = 10 + index;
		for (int i = 10; i <= 14; i++)
		{
			UUISprite sprite = base.GetSprite(i);
			if (sprite != null)
			{
				sprite.SetUIActive(i == num);
			}
		}
	}

	// Token: 0x06011DE6 RID: 73190 RVA: 0x00540FC9 File Offset: 0x0053F1C9
	private void OnClickCloseButton()
	{
		RacingBetsModel.Instance.CloseDangoGamePlayPreviewView();
	}

	// Token: 0x06011DE7 RID: 73191 RVA: 0x00540FD8 File Offset: 0x0053F1D8
	private void OnToggleClick(EToggleState state)
	{
		bool hide = state == EToggleState.ETT_Checked;
		string sequenceName = hide ? "Hide" : "Show";
		base.PlaySequence(sequenceName, delegate
		{
			UUIItem item = this.GetItem(6);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(!hide);
		}, false);
	}

	// Token: 0x06011DE8 RID: 73192 RVA: 0x00541028 File Offset: 0x0053F228
	private void OnDangoSkillBtnClick()
	{
		if (this.CanCameraInput)
		{
			FreeCamera freeCamera = CameraController.Instance.MainModel.FreeCamera;
			if (freeCamera != null)
			{
				FreeCameraInputComponent inputComponent = freeCamera.InputComponent;
				if (inputComponent != null)
				{
					inputComponent.UnBindAxes();
				}
			}
		}
		InputDistributeController.Instance.UnBindAxis("UiMoveForward", new TInputHandle<float>(this.OnUiMove));
		InputDistributeController.Instance.UnBindAxis("UiMoveRight", new TInputHandle<float>(this.OnUiMove));
		RacingBetsDangoSkillViewParam param = new RacingBetsDangoSkillViewParam
		{
			DangoList = this.DungeonDangoSortList,
			CloseCallback = new Action(this.OnDangoSkillViewClose)
		};
		UiManager.Instance.OpenView(EUiViewName.RacingBetsDangoSkillView, param, null);
	}

	// Token: 0x06011DE9 RID: 73193 RVA: 0x005410D0 File Offset: 0x0053F2D0
	private void OnDangoSkillViewClose()
	{
		if (this.CanCameraInput)
		{
			FreeCamera freeCamera = CameraController.Instance.MainModel.FreeCamera;
			if (freeCamera != null)
			{
				FreeCameraInputComponent inputComponent = freeCamera.InputComponent;
				if (inputComponent != null)
				{
					inputComponent.BindAxes(base.GetDraggable(4));
				}
			}
		}
		InputDistributeController.Instance.BindAxis("UiMoveForward", new TInputHandle<float>(this.OnUiMove));
		InputDistributeController.Instance.BindAxis("UiMoveRight", new TInputHandle<float>(this.OnUiMove));
	}

	// Token: 0x06011DEA RID: 73194 RVA: 0x00541148 File Offset: 0x0053F348
	private void OnMovedCallback()
	{
		TimerHandle timerHandle = this.TimerHandle;
		if (timerHandle != null)
		{
			timerHandle.Remove();
		}
		this.TimerHandle = null;
		if (this.IsDragTipShowed)
		{
			base.PlaySequence("DragTipsHide", delegate
			{
				UUIItem item = base.GetItem(17);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
			}, false);
		}
		UUIDraggableComponent draggable = base.GetDraggable(4);
		if (draggable != null)
		{
			draggable.OnPointerDownCallBack.Unbind();
		}
		InputDistributeController.Instance.UnBindAxis("UiMoveForward", new TInputHandle<float>(this.OnUiMove));
		InputDistributeController.Instance.UnBindAxis("UiMoveRight", new TInputHandle<float>(this.OnUiMove));
	}

	// Token: 0x06011DEB RID: 73195 RVA: 0x005411DB File Offset: 0x0053F3DB
	protected void OnUiMove(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f)
		{
			return;
		}
		this.OnMovedCallback();
	}

	// Token: 0x06011DED RID: 73197 RVA: 0x00541200 File Offset: 0x0053F400
	private static float[] ToFloatArray([Nullable(2)] IReadOnlyList<int> intList, int[] fallback)
	{
		IReadOnlyList<int> readOnlyList = intList ?? fallback;
		float[] array = new float[readOnlyList.Count];
		for (int i = 0; i < readOnlyList.Count; i++)
		{
			array[i] = (float)readOnlyList[i];
		}
		return array;
	}

	// Token: 0x04009BE4 RID: 39908
	private bool CanCameraInput;

	// Token: 0x04009BE5 RID: 39909
	private List<RacingBetsDungeonDangoInfo> DungeonDangoSortList = new List<RacingBetsDungeonDangoInfo>();

	// Token: 0x04009BE6 RID: 39910
	private RacingBetsDangoRankPanel DangoRankPanel;

	// Token: 0x04009BE7 RID: 39911
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RacingBetsPreviewViewOrganItem, int> OrganLayout;

	// Token: 0x04009BE8 RID: 39912
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04009BE9 RID: 39913
	private bool IsDragTipShowed;

	// Token: 0x04009BEA RID: 39914
	private static readonly int[] defaultFreeCameraConfigList = new int[]
	{
		106
	};

	// Token: 0x02007F17 RID: 32535
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402920F RID: 168463
		public const int CloseButton = 0;

		// Token: 0x04029210 RID: 168464
		public const int RaycastButton = 1;

		// Token: 0x04029211 RID: 168465
		public const int DangoPanel = 2;

		// Token: 0x04029212 RID: 168466
		public const int DangoItem = 3;

		// Token: 0x04029213 RID: 168467
		public const int Drag = 4;

		// Token: 0x04029214 RID: 168468
		public const int ToggleHide = 5;

		// Token: 0x04029215 RID: 168469
		public const int ItemHidePanel = 6;

		// Token: 0x04029216 RID: 168470
		public const int BtnDangoSkill = 7;

		// Token: 0x04029217 RID: 168471
		public const int LayoutOrgan = 8;

		// Token: 0x04029218 RID: 168472
		public const int ItemOrgan = 9;

		// Token: 0x04029219 RID: 168473
		public const int SpriteDetail1Bg = 10;

		// Token: 0x0402921A RID: 168474
		public const int SpriteDetail2Bg = 11;

		// Token: 0x0402921B RID: 168475
		public const int SpriteDetail3Bg = 12;

		// Token: 0x0402921C RID: 168476
		public const int SpriteDetail4Bg = 13;

		// Token: 0x0402921D RID: 168477
		public const int SpriteDetail5Bg = 14;

		// Token: 0x0402921E RID: 168478
		public const int TextName = 15;

		// Token: 0x0402921F RID: 168479
		public const int TextDesc = 16;

		// Token: 0x04029220 RID: 168480
		public const int ItemDragTip = 17;
	}
}
