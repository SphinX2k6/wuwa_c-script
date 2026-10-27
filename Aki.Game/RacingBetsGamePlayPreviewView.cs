using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002731 RID: 10033
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsGamePlayPreviewView : UiViewBase, IUiCameraBehavior
{
	// Token: 0x060148F8 RID: 84216 RVA: 0x00531CA5 File Offset: 0x0052FEA5
	public RacingBetsGamePlayPreviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060148F9 RID: 84217 RVA: 0x00531CBC File Offset: 0x0052FEBC
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

	// Token: 0x060148FA RID: 84218 RVA: 0x00531E90 File Offset: 0x00530090
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

	// Token: 0x060148FB RID: 84219 RVA: 0x00531F14 File Offset: 0x00530114
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

	// Token: 0x060148FC RID: 84220 RVA: 0x00531F8C File Offset: 0x0053018C
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsGamePlayPreviewView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsGamePlayPreviewView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060148FD RID: 84221 RVA: 0x00531FCF File Offset: 0x005301CF
	public void PushCameraHandle(EUiViewName viewName, int viewId, bool isBlend)
	{
		UiCameraAnimationController.Instance.PushCameraHandle(viewName, new int?(viewId), true);
	}

	// Token: 0x060148FE RID: 84222 RVA: 0x00531FE4 File Offset: 0x005301E4
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

	// Token: 0x060148FF RID: 84223 RVA: 0x00532043 File Offset: 0x00530243
	protected override void OnBeforeHide()
	{
		TimerHandle timerHandle = this.TimerHandle;
		if (timerHandle != null)
		{
			timerHandle.Remove();
		}
		this.TimerHandle = null;
	}

	// Token: 0x06014900 RID: 84224 RVA: 0x00532060 File Offset: 0x00530260
	[NullableContext(2)]
	public void PopCameraHandle(EUiViewName viewName, UiViewInfo stackTopInfo, int closeViewId, bool popOrDelete)
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
		UiCameraAnimationController.Instance.DeepCopyCamera(CameraController.Instance.MainModel.FreeCamera.DisplayComponent.CameraActor);
		CameraController instance = CameraController.Instance;
		UiCamera uiCamera = UiCameraAnimationManager.Instance.UiCamera;
		instance.SetViewTarget((uiCamera != null) ? uiCamera.GetCameraActor() : null, "RacingBetsGamePlayPreviewView", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, null, "MainCamera", null, null);
		UiCameraAnimationController.Instance.PopCameraHandle(viewName, stackTopInfo, closeViewId, popOrDelete);
	}

	// Token: 0x06014901 RID: 84225 RVA: 0x0053213C File Offset: 0x0053033C
	private void OnActivateUiCameraAnimationHandle(UiCameraHandleData handleData)
	{
		if (handleData.ViewName == EUiViewName.RacingBetsGamePlayPreviewView && this.CanCameraInput)
		{
			CameraController.Instance.MainModel.FreeCamera.LogicComponent.InitConfig(RacingBetsGamePlayPreviewView.ToFloatArray(ConfigCommonParamById.GetIntArrayConfig("RacingBetsPreviewViewCameraIdList"), RacingBetsGamePlayPreviewView.defaultFreeCameraConfigList));
			CameraController.Instance.MainModel.FreeCamera.InputComponent.CanCameraInput = true;
			CameraController.Instance.MainModel.FreeCamera.InputComponent.SetIsMoveBySelf(false);
			CameraController.Instance.MainModel.FreeCamera.InputComponent.BindAxes(base.GetDraggable(4));
			UiCameraAnimationController.Instance.ExitUiCameraMode();
		}
	}

	// Token: 0x06014902 RID: 84226 RVA: 0x005321F9 File Offset: 0x005303F9
	private RacingBetsPreviewViewOrganItem CreateOrganItem()
	{
		return new RacingBetsPreviewViewOrganItem
		{
			OnToggleCallBack = new Action<int, int>(this.OnOrganItemClick)
		};
	}

	// Token: 0x06014903 RID: 84227 RVA: 0x00532214 File Offset: 0x00530414
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

	// Token: 0x06014904 RID: 84228 RVA: 0x005322B5 File Offset: 0x005304B5
	private void OnClickCloseButton()
	{
		RacingBetsModel.Instance.CloseDangoGamePlayPreviewView();
	}

	// Token: 0x06014905 RID: 84229 RVA: 0x005322C4 File Offset: 0x005304C4
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

	// Token: 0x06014906 RID: 84230 RVA: 0x00532314 File Offset: 0x00530514
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

	// Token: 0x06014907 RID: 84231 RVA: 0x005323BC File Offset: 0x005305BC
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

	// Token: 0x06014908 RID: 84232 RVA: 0x00532434 File Offset: 0x00530634
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

	// Token: 0x06014909 RID: 84233 RVA: 0x005324C7 File Offset: 0x005306C7
	protected void OnUiMove(string axisName, float value, InputIdentification inputIdentification)
	{
		if (value == 0f)
		{
			return;
		}
		this.OnMovedCallback();
	}

	// Token: 0x0601490B RID: 84235 RVA: 0x005324EC File Offset: 0x005306EC
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

	// Token: 0x04009A8C RID: 39564
	private bool CanCameraInput;

	// Token: 0x04009A8D RID: 39565
	private List<RacingBetsDungeonDangoInfo> DungeonDangoSortList = new List<RacingBetsDungeonDangoInfo>();

	// Token: 0x04009A8E RID: 39566
	private RacingBetsDangoRankPanel DangoRankPanel;

	// Token: 0x04009A8F RID: 39567
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RacingBetsPreviewViewOrganItem, int> OrganLayout;

	// Token: 0x04009A90 RID: 39568
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04009A91 RID: 39569
	private bool IsDragTipShowed;

	// Token: 0x04009A92 RID: 39570
	private static readonly int[] defaultFreeCameraConfigList = new int[]
	{
		106
	};

	// Token: 0x02008D8F RID: 36239
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402DEF9 RID: 188153
		public const int CloseButton = 0;

		// Token: 0x0402DEFA RID: 188154
		public const int RaycastButton = 1;

		// Token: 0x0402DEFB RID: 188155
		public const int DangoPanel = 2;

		// Token: 0x0402DEFC RID: 188156
		public const int DangoItem = 3;

		// Token: 0x0402DEFD RID: 188157
		public const int Drag = 4;

		// Token: 0x0402DEFE RID: 188158
		public const int ToggleHide = 5;

		// Token: 0x0402DEFF RID: 188159
		public const int ItemHidePanel = 6;

		// Token: 0x0402DF00 RID: 188160
		public const int BtnDangoSkill = 7;

		// Token: 0x0402DF01 RID: 188161
		public const int LayoutOrgan = 8;

		// Token: 0x0402DF02 RID: 188162
		public const int ItemOrgan = 9;

		// Token: 0x0402DF03 RID: 188163
		public const int SpriteDetail1Bg = 10;

		// Token: 0x0402DF04 RID: 188164
		public const int SpriteDetail2Bg = 11;

		// Token: 0x0402DF05 RID: 188165
		public const int SpriteDetail3Bg = 12;

		// Token: 0x0402DF06 RID: 188166
		public const int SpriteDetail4Bg = 13;

		// Token: 0x0402DF07 RID: 188167
		public const int SpriteDetail5Bg = 14;

		// Token: 0x0402DF08 RID: 188168
		public const int TextName = 15;

		// Token: 0x0402DF09 RID: 188169
		public const int TextDesc = 16;

		// Token: 0x0402DF0A RID: 188170
		public const int ItemDragTip = 17;
	}
}
