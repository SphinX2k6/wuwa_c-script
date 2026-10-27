using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiCameraAnimation;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002C35 RID: 11317
[NullableContext(1)]
[Nullable(0)]
public class UiCameraAnimationManager : Singleton, ITickable
{
	// Token: 0x06017990 RID: 96656 RVA: 0x00600EB0 File Offset: 0x005FF0B0
	public void Initialize()
	{
		int? intConfig = ConfigCommonParamById.GetIntConfig("LoadingViewCameraAnimationLength");
		this.LoadingViewCameraAnimationLength = ((intConfig != null) ? new float?((float)intConfig.GetValueOrDefault()) : null);
		this.LoadingViewManualFocusDistance = ConfigCommonParamById.GetFloatConfig("LoadingViewManualFocusDistance");
		this.LoadingViewAperture = ConfigCommonParamById.GetFloatConfig("LoadingViewAperture");
		this.InitializeUiCameraMappingData();
		this.InitializeTargetTypeMap();
	}

	// Token: 0x06017991 RID: 96657 RVA: 0x00600F1B File Offset: 0x005FF11B
	public void Clear()
	{
		this.ClearDisplay();
		this.ClearUiCameraMappingData();
		this.TargetTypeMap.Clear();
	}

	// Token: 0x06017992 RID: 96658 RVA: 0x00600F34 File Offset: 0x005FF134
	private void InitializeUiCameraMappingData()
	{
		foreach (UiCameraMapping config in UiCameraAnimationConfig.Instance.GetAllUiCameraMappingConfig())
		{
			UiCameraMappingData value = new UiCameraMappingData(config);
			this.CameraMappingDataMap.Add(config.ViewName, value);
		}
		foreach (ChildUiCameraMapping config2 in UiCameraAnimationConfig.Instance.GetAllChildUiCameraMappingConfig())
		{
			UiCameraMappingData value2 = new UiCameraMappingData(config2);
			this.CameraMappingDataMap.Add(config2.ViewName, value2);
		}
	}

	// Token: 0x06017993 RID: 96659 RVA: 0x00600FF0 File Offset: 0x005FF1F0
	private void InitializeTargetTypeMap()
	{
		this.TargetTypeMap.Add(EUiCameraAnimationTargetType.Player, new UiCameraTargetTypePlayer());
		this.TargetTypeMap.Add(EUiCameraAnimationTargetType.Npc, new UiCameraTargetTypeNpc());
		this.TargetTypeMap.Add(EUiCameraAnimationTargetType.UiSceneRole, new UiCameraTargetTypeUiSceneRole());
		this.TargetTypeMap.Add(EUiCameraAnimationTargetType.UiSceneSkeletal, new UiCameraTargetTypeUiSceneSkeletal());
		this.TargetTypeMap.Add(EUiCameraAnimationTargetType.UiVisionHandBook, new UiCameraTargetTypeUiVisionHandBook());
		this.TargetTypeMap.Add(EUiCameraAnimationTargetType.UiGlider, new UiCameraTargetTypeUiGlider());
		this.TargetTypeMap.Add(EUiCameraAnimationTargetType.SailDock, new UiCameraTargetTypeSailDock());
		this.TargetTypeMap.Add(EUiCameraAnimationTargetType.UiSceneHulu, new UiCameraTargetTypeUiSceneHulu());
		this.TargetTypeMap.Add(EUiCameraAnimationTargetType.UiInfrastructure, new UiCameraTargetTypeUiSceneInfr());
		this.TargetTypeMap.Add(EUiCameraAnimationTargetType.UiSceneActor, new UiCameraTargetTypeUiSceneActor());
		this.TargetTypeMap.Add(EUiCameraAnimationTargetType.UiSceneFormationRole, new UiCameraTargetTypeUiSceneFormationRole());
	}

	// Token: 0x06017994 RID: 96660 RVA: 0x006010BB File Offset: 0x005FF2BB
	public void SetDynamicDisablePushCamera(string viewName, bool disable)
	{
		if (disable)
		{
			if (!this.DynamicDisablePushCamera.Contains(viewName))
			{
				this.DynamicDisablePushCamera.Add(viewName);
				return;
			}
		}
		else if (this.DynamicDisablePushCamera.Contains(viewName))
		{
			this.DynamicDisablePushCamera.Remove(viewName);
		}
	}

	// Token: 0x06017995 RID: 96661 RVA: 0x006010F7 File Offset: 0x005FF2F7
	[return: Nullable(2)]
	public UiCameraMappingData GetCameraMappingData(string viewName)
	{
		if (this.DynamicDisablePushCamera.Contains(viewName))
		{
			return null;
		}
		return this.CameraMappingDataMap.GetValueOrDefault(viewName);
	}

	// Token: 0x06017996 RID: 96662 RVA: 0x00601115 File Offset: 0x005FF315
	private void ClearUiCameraMappingData()
	{
		this.CameraMappingDataMap.Clear();
	}

	// Token: 0x06017997 RID: 96663 RVA: 0x00601122 File Offset: 0x005FF322
	private void PushHandleData(UiCameraHandleData handleData)
	{
		this.HandleDataStack.Push(handleData);
	}

	// Token: 0x06017998 RID: 96664 RVA: 0x00601130 File Offset: 0x005FF330
	private UiCameraHandleData PopHandleData(UiCameraHandleData handleData)
	{
		UiCameraHandleData uiCameraHandleData = this.HandleDataStack.Peek();
		int uniqueId = handleData.UniqueId;
		while (uiCameraHandleData != null && uiCameraHandleData.UniqueId != uniqueId)
		{
			this.HandleDataStack.Pop();
			uiCameraHandleData = (this.HandleDataStack.Any<UiCameraHandleData>() ? this.HandleDataStack.Peek() : null);
		}
		this.HandleDataStack.Pop();
		return this.GetLastHandleData();
	}

	// Token: 0x06017999 RID: 96665 RVA: 0x00601198 File Offset: 0x005FF398
	private bool DeleteHandleDataByVieId(int viewId)
	{
		UiCameraHandleData handleDataByViewId = this.GetHandleDataByViewId(viewId);
		if (handleDataByViewId == null)
		{
			return false;
		}
		List<UiDynamicTab> viewTabList = DynamicTabConfig.Instance.GetViewTabList(handleDataByViewId.OwnerViewName);
		List<UiCameraHandleData> list = new List<UiCameraHandleData>();
		bool flag = false;
		foreach (UiCameraHandleData uiCameraHandleData in this.HandleDataStack)
		{
			if (uiCameraHandleData.UniqueId == viewId)
			{
				list.Add(uiCameraHandleData);
				flag = true;
			}
			else if (flag)
			{
				if (!this.IsDynamicTabListContainView(viewTabList, uiCameraHandleData.OwnerViewName) && !(handleDataByViewId.OwnerViewName == uiCameraHandleData.OwnerViewName))
				{
					break;
				}
				list.Add(uiCameraHandleData);
			}
		}
		foreach (UiCameraHandleData element in list)
		{
			this.HandleDataStack.Delete(element);
		}
		return true;
	}

	// Token: 0x0601799A RID: 96666 RVA: 0x00601298 File Offset: 0x005FF498
	private bool IsDynamicTabListContainView(List<UiDynamicTab> uiDynamicTabList, string tabViewName)
	{
		foreach (UiDynamicTab uiDynamicTab in uiDynamicTabList)
		{
			if (uiDynamicTab.ChildViewName == tabViewName)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0601799B RID: 96667 RVA: 0x006012F8 File Offset: 0x005FF4F8
	[NullableContext(2)]
	private UiCameraHandleData GetHandleDataByViewId(int viewId)
	{
		foreach (UiCameraHandleData uiCameraHandleData in this.HandleDataStack)
		{
			if (uiCameraHandleData.UniqueId == viewId)
			{
				return uiCameraHandleData;
			}
		}
		return null;
	}

	// Token: 0x0601799C RID: 96668 RVA: 0x00601350 File Offset: 0x005FF550
	[NullableContext(2)]
	public UiCameraHandleData GetLastHandleData()
	{
		if (!this.HandleDataStack.Any<UiCameraHandleData>())
		{
			return null;
		}
		return this.HandleDataStack.Peek();
	}

	// Token: 0x0601799D RID: 96669 RVA: 0x0060136C File Offset: 0x005FF56C
	public UiCameraAnimationHandle NewCameraHandle()
	{
		UiCameraAnimationHandle uiCameraAnimationHandle = new UiCameraAnimationHandle();
		uiCameraAnimationHandle.Initialize();
		return uiCameraAnimationHandle;
	}

	// Token: 0x0601799E RID: 96670 RVA: 0x00601379 File Offset: 0x005FF579
	public void ActivateCameraHandle(UiCameraHandleData handleData, bool bBlend = true, bool bPlayBlendInSequence = true)
	{
		if (this.CurrentCameraHandle != null)
		{
			this.CurrentCameraHandle.Deactivate();
		}
		else
		{
			this.CurrentCameraHandle = this.NewCameraHandle();
		}
		this.CurrentCameraHandle.Activate(handleData, bBlend, bPlayBlendInSequence);
	}

	// Token: 0x0601799F RID: 96671 RVA: 0x006013AC File Offset: 0x005FF5AC
	private void ActivateCameraHandleWaitAnimation(UiCameraHandleData handleData, bool bBlend = true, bool bPlayBlendInSequence = true)
	{
		if (this.IsPlayingAnimation())
		{
			this.CurrentUiCameraAnimation.WaitCameraAnimationFinished().ContinueWith(delegate(UiCameraAnimationDefine.IFinishData finishData)
			{
				if (finishData.FinishType == UiCameraAnimationDefine.ECameraAnimationFinishType.Finished)
				{
					this.ActivateCameraHandle(handleData, bBlend, bPlayBlendInSequence);
				}
			});
			return;
		}
		this.ActivateCameraHandle(handleData, bBlend, bPlayBlendInSequence);
	}

	// Token: 0x060179A0 RID: 96672 RVA: 0x0060141C File Offset: 0x005FF61C
	public unsafe void PushCameraHandleByOpenView(string viewName, int? viewId = null, bool bBlend = true, FTransformDouble? externalTransform = null, [Nullable(2)] string ownerViewName = null)
	{
		if (!this.CanPushCameraHandle(viewName))
		{
			return;
		}
		UiCameraHandleData lastHandleData = this.GetLastHandleData();
		if (lastHandleData != null)
		{
			if (!(lastHandleData.ViewName == viewName))
			{
				int uniqueId = lastHandleData.UniqueId;
				int? num = viewId;
				if (!(uniqueId == num.GetValueOrDefault() & num != null))
				{
					goto IL_A5;
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CameraAnimation;
			ELogAuthor author = ELogAuthor.BB;
			string message = "此界面已经在栈顶";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PushHandleData", (lastHandleData != null) ? lastHandleData.ToString() : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("viewId", viewId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		IL_A5:
		if (viewId != null)
		{
			UiCameraHandleData handleDataByViewId = this.GetHandleDataByViewId(viewId.Value);
			if (handleDataByViewId != null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.CameraAnimation;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "此界面已经入栈,直接返回";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PushHandleData", handleDataByViewId.ToString());
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
		}
		UiCameraHandleData uiCameraHandleData = UiCameraHandleData.NewByView(viewName, viewId, externalTransform);
		if (!string.IsNullOrEmpty(ownerViewName))
		{
			uiCameraHandleData.OwnerViewName = ownerViewName;
		}
		string blendName = null;
		string text = (lastHandleData != null) ? lastHandleData.ViewName : null;
		if (!string.IsNullOrEmpty(text))
		{
			blendName = this.GetBlendName(text, viewName);
		}
		this.PushCameraHandle(uiCameraHandleData, bBlend, true, blendName, true, null);
	}

	// Token: 0x060179A1 RID: 96673 RVA: 0x00601560 File Offset: 0x005FF760
	public unsafe UiCameraHandleData PushCameraHandleByHandleName(string handleName, bool bBlend = true, bool bPlayBlendInSequence = true, string blendName = "1001", bool bCheckSameHandleData = false, Action<UiCameraAnimationDefine.IFinishData> cameraAnimationFinishedCallback = null, FTransformDouble? externalTransformInternal = null)
	{
		if (StringUtils.IsBlank(handleName))
		{
			Log.Instance.Error(ELogModule.CameraAnimation, ELogAuthor.BB, "镜头动画的HandleName为空，镜头动画异常", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		UiCameraHandleData uiCameraHandleData = UiCameraHandleData.NewByHandleName(handleName, externalTransformInternal);
		UiCameraHandleData lastHandleData = this.GetLastHandleData();
		if (lastHandleData != null)
		{
			string viewName = lastHandleData.ViewName;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CameraAnimation;
			ELogAuthor author = ELogAuthor.BB;
			string message = "手动播放镜头动画，将镜头数据的ViewName设置为栈顶的数据";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("HandleName", handleName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ViewName", viewName);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			uiCameraHandleData.ViewName = viewName;
			uiCameraHandleData.OwnerViewName = lastHandleData.OwnerViewName;
		}
		else
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.CameraAnimation;
			ELogAuthor author2 = ELogAuthor.BB;
			string message2 = "手动播放镜头动画时，当前没有播放任何Ui镜头状态";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("HandleName", handleName);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		this.PushCameraHandle(uiCameraHandleData, bBlend, bPlayBlendInSequence, blendName, bCheckSameHandleData, cameraAnimationFinishedCallback);
		return uiCameraHandleData;
	}

	// Token: 0x060179A2 RID: 96674 RVA: 0x00601650 File Offset: 0x005FF850
	public unsafe void PushCameraHandle(UiCameraHandleData newHandleData, bool bBlend = true, bool bPlayBlendInSequence = true, string blendName = null, bool bCheckSameHandleData = false, Action<UiCameraAnimationDefine.IFinishData> cameraAnimationFinishedCallback = null)
	{
		UiCameraHandleData lastHandleData = this.GetLastHandleData();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CameraAnimation;
		ELogAuthor author = ELogAuthor.BB;
		string message = "镜头状态数据------入栈";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PushHandleData", newHandleData.ToString());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("LastTopHandleData", (lastHandleData != null) ? lastHandleData.ToString() : null);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		if (bCheckSameHandleData && this.TryRefreshSameHandleData(newHandleData))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.CameraAnimation;
			ELogAuthor author2 = ELogAuthor.BB;
			string message2 = "镜头状态数据------新的镜头状态和旧的镜头状态一致，不会再次播放推入镜头状态表现";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
			string item = "CurrentHandleData";
			UiCameraAnimationHandle currentCameraHandle = this.CurrentCameraHandle;
			ptr = new ValueTuple<string, object>(item, (currentCameraHandle != null) ? currentCameraHandle.GetHandleData().ToString() : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("NewHandleData", newHandleData.ToString());
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return;
		}
		this.PushHandleData(newHandleData);
		this.StopUiCameraAnimation();
		this.PlayCameraHandle(newHandleData, lastHandleData, bBlend, bPlayBlendInSequence, blendName, cameraAnimationFinishedCallback);
	}

	// Token: 0x060179A3 RID: 96675 RVA: 0x00601760 File Offset: 0x005FF960
	public unsafe void PopCameraHandleByCloseView(string closeViewName, string toViewName, int closeViewId, bool popOrDelete = true)
	{
		if (!this.CanPushCameraHandle(closeViewName))
		{
			return;
		}
		UiCameraHandleData handleDataByViewId = this.GetHandleDataByViewId(closeViewId);
		if (popOrDelete || (handleDataByViewId != null && this.HandleDataStack.Count<UiCameraHandleData>() <= 1))
		{
			string blendName = this.GetBlendName(closeViewName, toViewName);
			this.PopCameraHandle(handleDataByViewId, blendName);
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CameraAnimation;
		ELogAuthor author = ELogAuthor.BB;
		string message = "仅删除镜头状态，不做任何表现";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("closeViewName", closeViewName);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("closeViewId", closeViewId);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.DeleteHandleDataByVieId(closeViewId);
	}

	// Token: 0x060179A4 RID: 96676 RVA: 0x00601808 File Offset: 0x005FFA08
	public unsafe void PopCameraHandle(UiCameraHandleData popHandleData, string blendName = null)
	{
		if (popHandleData == null)
		{
			this.ClearDisplay();
			return;
		}
		UiCameraHandleData lastHandleData = this.GetLastHandleData();
		UiCameraHandleData uiCameraHandleData = this.PopHandleData(popHandleData);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CameraAnimation;
		ELogAuthor author = ELogAuthor.BB;
		string message = "镜头状态数据------出栈";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("popHandleData", popHandleData.ToString());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TopHandleData", (uiCameraHandleData != null) ? uiCameraHandleData.ToString() : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("blendName", blendName);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		this.RefreshHandleDataByMappingData(uiCameraHandleData);
		this.StopUiCameraAnimation();
		this.PlayCameraHandle(uiCameraHandleData, lastHandleData, blendName != null, true, blendName, null);
	}

	// Token: 0x060179A5 RID: 96677 RVA: 0x006018C8 File Offset: 0x005FFAC8
	private void RefreshHandleDataByMappingData(UiCameraHandleData handleData)
	{
		if (handleData == null)
		{
			return;
		}
		string viewName = handleData.ViewName;
		if (StringUtils.IsEmpty(viewName))
		{
			return;
		}
		UiCameraMappingData cameraMappingData = this.GetCameraMappingData(viewName);
		UiCameraAnimationDefine.IUiCameraMapping uiCameraMapping = (cameraMappingData != null) ? cameraMappingData.GetUiCameraMappingConfig() : null;
		if (cameraMappingData == null || (uiCameraMapping != null && uiCameraMapping.BodyTargetType == 0))
		{
			return;
		}
		if (cameraMappingData.GetTargetBodyKey() != null)
		{
			handleData.HandleName = cameraMappingData.GetSourceHandleName();
		}
		handleData.Refresh();
	}

	// Token: 0x060179A6 RID: 96678 RVA: 0x00601928 File Offset: 0x005FFB28
	private bool TryRefreshSameHandleData(UiCameraHandleData newHandleData)
	{
		if (this.CurrentCameraHandle == null)
		{
			return false;
		}
		UiCameraHandleData uiCameraHandleData = this.HandleDataStack.Any<UiCameraHandleData>() ? this.HandleDataStack.Peek() : null;
		if (uiCameraHandleData == null)
		{
			return false;
		}
		UiCamera uiCamera = this.UiCamera;
		if (uiCamera == null || !uiCamera.GetIsEntered())
		{
			return false;
		}
		if (!uiCameraHandleData.IsEqual(newHandleData))
		{
			return false;
		}
		this.CurrentCameraHandle.SetHandleData(newHandleData);
		return true;
	}

	// Token: 0x060179A7 RID: 96679 RVA: 0x00601994 File Offset: 0x005FFB94
	private unsafe UiCameraAnimationDefine.EPlayCameraHandleResult PlayCameraHandle(UiCameraHandleData toHandleData = null, UiCameraHandleData fromHandleData = null, bool bBlend = true, bool bPlayBlendInSequence = true, string blendName = null, Action<UiCameraAnimationDefine.IFinishData> cameraAnimationFinishedCallback = null)
	{
		this.UiCamera = UiCameraManager.Get();
		this.UiCameraPostEffectComponent = this.UiCamera.GetUiCameraComponent<UiCameraPostEffectComponent>();
		this.UiCameraSequenceComponent = this.UiCamera.GetUiCameraComponent<UiCameraSequenceComponent>();
		if (this.CurrentPopCameraHandle != null)
		{
			this.CurrentPopCameraHandle.StopSequence();
			this.CurrentPopCameraHandle = null;
			this.UiCamera.Exit(0f, EViewTargetBlendFunction.VTBlend_Linear, 0f);
		}
		if (toHandleData == null)
		{
			UiCameraAnimationHandle currentCameraHandle = this.GetCurrentCameraHandle();
			if (currentCameraHandle != null)
			{
				this.CurrentPopCameraHandle = currentCameraHandle;
				currentCameraHandle.Revert(true, new Action(this.ClearDisplay));
			}
			else
			{
				this.ClearDisplay();
			}
			return UiCameraAnimationDefine.EPlayCameraHandleResult.RevertAnimation;
		}
		toHandleData.Refresh();
		this.TryPushCameraSpringStructure(toHandleData);
		if (string.IsNullOrEmpty(blendName))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CameraAnimation;
			ELogAuthor author = ELogAuthor.BB;
			string message = "镜头状态数据------入栈是BlendName为空，直接激活镜头状态";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PushHandleData", toHandleData.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("blendName", blendName);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.ActivateCameraHandleWaitAnimation(toHandleData, bBlend, bPlayBlendInSequence);
			return UiCameraAnimationDefine.EPlayCameraHandleResult.Activate;
		}
		if (fromHandleData == null)
		{
			this.ActivateCameraHandleWaitAnimation(toHandleData, bBlend, bPlayBlendInSequence);
			return UiCameraAnimationDefine.EPlayCameraHandleResult.Activate;
		}
		if (!bBlend)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.CameraAnimation;
			ELogAuthor author2 = ELogAuthor.BB;
			string message2 = "镜头状态数据------不需要播放镜头动画，直接激活镜头状态";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("LastHandleData", fromHandleData.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("PushHandleData", toHandleData.ToString());
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			this.ActivateCameraHandle(toHandleData, false, false);
			return UiCameraAnimationDefine.EPlayCameraHandleResult.Activate;
		}
		SUiCameraAnimationBlendSettings uiCameraAnimationBlendData = UiCameraAnimationConfig.Instance.GetUiCameraAnimationBlendData(blendName);
		if (uiCameraAnimationBlendData == null || uiCameraAnimationBlendData.Time <= 0f)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.CameraAnimation;
			ELogAuthor author3 = ELogAuthor.BB;
			string message3 = "没有混合配置或播放界面摄像机动画时间<=0，直接激活镜头";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("blendName", blendName);
			instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.ActivateCameraHandle(toHandleData, false, false);
			return UiCameraAnimationDefine.EPlayCameraHandleResult.Activate;
		}
		this.AsyncPlayCameraAnimation(fromHandleData, toHandleData, blendName).ContinueWith(delegate(UiCameraAnimationDefine.IFinishData finishData)
		{
			this.OnPlayCameraAnimationFinish(finishData, cameraAnimationFinishedCallback);
		});
		return UiCameraAnimationDefine.EPlayCameraHandleResult.PlayAnimation;
	}

	// Token: 0x060179A8 RID: 96680 RVA: 0x00601BB0 File Offset: 0x005FFDB0
	private void TryPushCameraSpringStructure(UiCameraHandleData toHandleData)
	{
		if ((this.UiCameraSpringStructure == null || !this.UiCameraSpringStructure.IsValid()) && !toHandleData.IsEmptyState)
		{
			this.UiCameraSpringStructure = this.UiCamera.PushStructure<UiCameraSpringStructure>();
		}
	}

	// Token: 0x060179A9 RID: 96681 RVA: 0x00601BE0 File Offset: 0x005FFDE0
	private unsafe void OnPlayCameraAnimationFinish(UiCameraAnimationDefine.IFinishData finishData, Action<UiCameraAnimationDefine.IFinishData> cameraAnimationFinishedCallback = null)
	{
		UiCameraHandleData fromHandleData = finishData.FromHandleData;
		UiCameraHandleData toHandleData = finishData.ToHandleData;
		if (finishData.FinishType == UiCameraAnimationDefine.ECameraAnimationFinishType.Finished)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CameraAnimation;
			ELogAuthor author = ELogAuthor.BB;
			string message = "镜头状态数据------入栈动画结束";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("LastHandleData", fromHandleData.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PushHandleData", toHandleData.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("FinishType", finishData.FinishType);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.ActivateCameraHandle(toHandleData, false, false);
		}
		else
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.CameraAnimation;
			ELogAuthor author2 = ELogAuthor.BB;
			string message2 = "镜头状态数据------入栈动画被停止";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("LastHandleData", fromHandleData.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("PushHandleData", toHandleData.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("FinishType", finishData.FinishType);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		}
		if (cameraAnimationFinishedCallback != null)
		{
			cameraAnimationFinishedCallback(finishData);
		}
		EventSystem.Instance.Emit<UiCameraAnimationDefine.IFinishData>(EEventName.OnPlayCameraAnimationFinish, finishData);
	}

	// Token: 0x060179AA RID: 96682 RVA: 0x00601D2C File Offset: 0x005FFF2C
	public bool CanPushCameraHandle(string viewName)
	{
		UiCameraMappingData cameraMappingData = this.GetCameraMappingData(viewName);
		return cameraMappingData != null && cameraMappingData.CanPushCameraHandle();
	}

	// Token: 0x060179AB RID: 96683 RVA: 0x00601D4C File Offset: 0x005FFF4C
	public void RefreshCurrentCameraExternalTransform(FTransformDouble externalTransform, bool bBlend = true)
	{
		UiCameraHandleData lastHandleData = this.GetLastHandleData();
		if (lastHandleData == null)
		{
			return;
		}
		lastHandleData.ExternalTransform = new FTransformDouble?(externalTransform);
		if (this.IsPlayingAnimation())
		{
			if (bBlend)
			{
				return;
			}
			this.StopUiCameraAnimation();
		}
		this.ActivateCameraHandle(lastHandleData, bBlend, false);
	}

	// Token: 0x060179AC RID: 96684 RVA: 0x00601D8C File Offset: 0x005FFF8C
	public void ReactivateCameraHandle(bool bBlend = false, bool bPlayBlendInSequence = false)
	{
		if (this.CurrentCameraHandle == null)
		{
			return;
		}
		if (this.CurrentCameraHandle.GetIsPendingRevert())
		{
			return;
		}
		if (this.UiCameraSpringStructure == null || !this.UiCameraSpringStructure.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CameraAnimation;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "Ui相机未处于工作状态，不重新激活镜头状态";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", this.CurrentCameraHandle.GetViewName());
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		UiCameraHandleData handleData = this.CurrentCameraHandle.GetHandleData();
		if (handleData == null)
		{
			return;
		}
		string viewName = handleData.ViewName;
		if (!StringUtils.IsEmpty(viewName))
		{
			UiCameraMappingData cameraMappingData = this.GetCameraMappingData(viewName);
			if (cameraMappingData != null)
			{
				if (cameraMappingData.GetTargetBodyKey() != null)
				{
					handleData.HandleName = cameraMappingData.GetSourceHandleName();
				}
				handleData.Refresh();
			}
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.CameraAnimation;
		ELogAuthor author2 = ELogAuthor.BB;
		string message2 = "重新激活镜头状态";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("handleData", handleData.ToString());
		instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		this.CurrentCameraHandle.Activate(handleData, bBlend, bPlayBlendInSequence);
	}

	// Token: 0x060179AD RID: 96685 RVA: 0x00601E79 File Offset: 0x00600079
	public void DeactivateCurrentCameraHandle()
	{
		if (this.CurrentCameraHandle == null)
		{
			return;
		}
		this.CurrentCameraHandle.Deactivate();
	}

	// Token: 0x060179AE RID: 96686 RVA: 0x00601E8F File Offset: 0x0060008F
	public UiCameraAnimationHandle GetCurrentCameraHandle()
	{
		return this.CurrentCameraHandle;
	}

	// Token: 0x060179AF RID: 96687 RVA: 0x00601E98 File Offset: 0x00600098
	public string GetBlendName(string fromViewName, string toViewName)
	{
		UiCameraMappingData cameraMappingData = this.GetCameraMappingData(fromViewName);
		if (cameraMappingData == null)
		{
			return null;
		}
		return cameraMappingData.GetToBlendName(toViewName);
	}

	// Token: 0x060179B0 RID: 96688 RVA: 0x00601EB9 File Offset: 0x006000B9
	public bool IsPlayingAnimation()
	{
		return this.CurrentUiCameraAnimation != null && this.CurrentUiCameraAnimation.IsPlaying();
	}

	// Token: 0x060179B1 RID: 96689 RVA: 0x00601ED0 File Offset: 0x006000D0
	public bool IsPlayingBlendInSequence()
	{
		return this.CurrentCameraHandle != null && this.CurrentCameraHandle.GetIsPlayingBlendInSequence();
	}

	// Token: 0x060179B2 RID: 96690 RVA: 0x00601EE8 File Offset: 0x006000E8
	public void ClearDisplay()
	{
		this.StopUiCameraAnimation();
		this.ResetPlayerHiddenDisplay();
		UiCameraManager.Destroy(0f, EViewTargetBlendFunction.VTBlend_Linear, 0f);
		foreach (UiCameraHandleData uiCameraHandleData in this.HandleDataStack)
		{
			uiCameraHandleData.Reset();
		}
		this.HandleDataStack.Clear();
		UiCameraAnimationHandle currentCameraHandle = this.CurrentCameraHandle;
		if (currentCameraHandle != null)
		{
			currentCameraHandle.Reset();
		}
		this.UiCamera = null;
		this.UiCameraSpringStructure = null;
		this.UiCameraPostEffectComponent = null;
		this.CurrentCameraHandle = null;
		this.CurrentPopCameraHandle = null;
		this.PlayerActorDisableHandleIdMap.Clear();
		this.CustomCreatureActorHandleIdMap.Clear();
	}

	// Token: 0x060179B3 RID: 96691 RVA: 0x00601FA4 File Offset: 0x006001A4
	public int GenerateHandleDataUniqueId()
	{
		int handleDataUniqueId = this.HandleDataUniqueId;
		this.HandleDataUniqueId = handleDataUniqueId + 1;
		return handleDataUniqueId;
	}

	// Token: 0x060179B4 RID: 96692 RVA: 0x00601FC4 File Offset: 0x006001C4
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<UiCameraAnimationDefine.IFinishData> AsyncPlayCameraAnimation(UiCameraHandleData fromHandleData, UiCameraHandleData toHandleData, string blendName)
	{
		UiCameraAnimationManager.<AsyncPlayCameraAnimation>d__54 <AsyncPlayCameraAnimation>d__;
		<AsyncPlayCameraAnimation>d__.<>t__builder = AsyncUniTaskMethodBuilder<UiCameraAnimationDefine.IFinishData>.Create();
		<AsyncPlayCameraAnimation>d__.<>4__this = this;
		<AsyncPlayCameraAnimation>d__.fromHandleData = fromHandleData;
		<AsyncPlayCameraAnimation>d__.toHandleData = toHandleData;
		<AsyncPlayCameraAnimation>d__.blendName = blendName;
		<AsyncPlayCameraAnimation>d__.<>1__state = -1;
		<AsyncPlayCameraAnimation>d__.<>t__builder.Start<UiCameraAnimationManager.<AsyncPlayCameraAnimation>d__54>(ref <AsyncPlayCameraAnimation>d__);
		return <AsyncPlayCameraAnimation>d__.<>t__builder.Task;
	}

	// Token: 0x060179B5 RID: 96693 RVA: 0x00602020 File Offset: 0x00600220
	public UiCameraHandleData PlayCameraAnimationFromCurrent(string toHandleName, string blendName)
	{
		UiCameraHandleData lastHandleData = this.GetLastHandleData();
		this.PushCameraHandleByHandleName(toHandleName, true, true, blendName, false, null, null);
		return lastHandleData;
	}

	// Token: 0x060179B6 RID: 96694 RVA: 0x0060204C File Offset: 0x0060024C
	public void PlayBackCurrent(string blendName = "1001")
	{
		UiCameraAnimationManager.<>c__DisplayClass56_0 CS$<>8__locals1 = new UiCameraAnimationManager.<>c__DisplayClass56_0();
		CS$<>8__locals1.<>4__this = this;
		UiCameraAnimationManager.<>c__DisplayClass56_0 CS$<>8__locals2 = CS$<>8__locals1;
		UiCameraAnimationHandle currentCameraHandle = this.CurrentCameraHandle;
		CS$<>8__locals2.currentHandleData = ((currentCameraHandle != null) ? currentCameraHandle.GetHandleData() : null);
		if (CS$<>8__locals1.currentHandleData == null)
		{
			return;
		}
		SUiCameraAnimationBlendSettings uiCameraAnimationBlendData = UiCameraAnimationConfig.Instance.GetUiCameraAnimationBlendData(blendName);
		if (uiCameraAnimationBlendData == null || uiCameraAnimationBlendData.Time <= 0f)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CameraAnimation;
			ELogAuthor author = ELogAuthor.BB;
			string message = "没有混合配置或播放界面摄像机动画时间<=0，直接激活镜头";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("blendName", blendName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.ActivateCameraHandle(CS$<>8__locals1.currentHandleData, false, false);
			return;
		}
		this.AsyncPlayCameraAnimation(CS$<>8__locals1.currentHandleData, CS$<>8__locals1.currentHandleData, blendName).ContinueWith(delegate(UiCameraAnimationDefine.IFinishData finishData)
		{
			if (finishData.FinishType == UiCameraAnimationDefine.ECameraAnimationFinishType.Finished)
			{
				CS$<>8__locals1.<>4__this.ActivateCameraHandle(CS$<>8__locals1.currentHandleData, true, true);
			}
		});
	}

	// Token: 0x060179B7 RID: 96695 RVA: 0x00602104 File Offset: 0x00600304
	public void StopUiCameraAnimation()
	{
		if (this.CurrentUiCameraAnimation == null)
		{
			return;
		}
		this.CurrentUiCameraAnimation.StopUiCameraAnimation();
		this.CurrentUiCameraAnimation = null;
	}

	// Token: 0x060179B8 RID: 96696 RVA: 0x00602124 File Offset: 0x00600324
	public void Tick(float delta)
	{
		float delta2 = delta * Time.Instance.InverseSelfCenteredTimeDilation;
		if (this.CurrentUiCameraAnimation != null)
		{
			this.CurrentUiCameraAnimation.Tick(delta2);
		}
		if (this.CurrentCameraHandle != null)
		{
			this.CurrentCameraHandle.Tick(delta2);
		}
	}

	// Token: 0x060179B9 RID: 96697 RVA: 0x00602166 File Offset: 0x00600366
	public void BroadUiCameraSequenceEvent(string sequenceEventName)
	{
		UiCameraManager.Get().GetUiCameraComponent<UiCameraSequenceComponent>().ExecuteUiCameraSequenceEvent(sequenceEventName);
		EventSystem.Instance.Emit<string>(EEventName.OnExecuteUiCameraSequenceEvent, sequenceEventName);
	}

	// Token: 0x060179BA RID: 96698 RVA: 0x00602189 File Offset: 0x00600389
	public bool IsActivate()
	{
		return this.HandleDataStack.Any<UiCameraHandleData>();
	}

	// Token: 0x060179BB RID: 96699 RVA: 0x00602196 File Offset: 0x00600396
	public global::Stack<UiCameraHandleData> GetHandleDataStack()
	{
		return this.HandleDataStack;
	}

	// Token: 0x060179BC RID: 96700 RVA: 0x006021A0 File Offset: 0x006003A0
	public AActor GetTargetActor(EUiCameraAnimationTargetType targetType, SUiCameraAnimationSettings config)
	{
		UiCameraTargetTypeBase uiCameraTargetTypeBase;
		if (this.TargetTypeMap.TryGetValue(targetType, out uiCameraTargetTypeBase))
		{
			return uiCameraTargetTypeBase.GetTargetActor(config);
		}
		return null;
	}

	// Token: 0x060179BD RID: 96701 RVA: 0x006021C8 File Offset: 0x006003C8
	public string GetTargetBodyKey(EUiCameraAnimationTargetType targetType)
	{
		UiCameraTargetTypeBase uiCameraTargetTypeBase;
		if (this.TargetTypeMap.TryGetValue(targetType, out uiCameraTargetTypeBase))
		{
			return uiCameraTargetTypeBase.GetTargetBodyKey();
		}
		return null;
	}

	// Token: 0x060179BE RID: 96702 RVA: 0x006021F0 File Offset: 0x006003F0
	public USkeletalMeshComponent GetTargetActorSkeletalMesh(EUiCameraAnimationTargetType targetType, SUiCameraAnimationSettings config)
	{
		UiCameraTargetTypeBase uiCameraTargetTypeBase;
		if (this.TargetTypeMap.TryGetValue(targetType, out uiCameraTargetTypeBase))
		{
			return uiCameraTargetTypeBase.GetTargetSkeletalMesh(config);
		}
		return null;
	}

	// Token: 0x060179BF RID: 96703 RVA: 0x00602216 File Offset: 0x00600416
	private void ResetPlayerHiddenDisplay()
	{
		this.EnablePlayerActor();
		this.EnableCustomCreatureActor();
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (baseCharacter == null)
		{
			return;
		}
		baseCharacter.SetDitherEffect(1f, ECharacterDitherType.Sequence);
	}

	// Token: 0x060179C0 RID: 96704 RVA: 0x0060223C File Offset: 0x0060043C
	public unsafe void DisablePlayerActor()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null || !getCurrentEntity.Valid)
		{
			Log.Instance.Info(ELogModule.CameraAnimation, ELogAuthor.BB, "Ui镜头隐藏玩家Actor-失败，因为找不到当前玩家EntityHandle", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		WorldEntity entity = getCurrentEntity.Entity;
		if (entity == null || !entity.Valid)
		{
			Log.Instance.Info(ELogModule.CameraAnimation, ELogAuthor.BB, "Ui镜头隐藏玩家Actor-失败，因为找不到当前玩家Entity", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		Log.Instance.Info(ELogModule.CameraAnimation, ELogAuthor.BB, "Ui镜头隐藏玩家Actor", default(ReadOnlySpan<ValueTuple<string, object>>));
		BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
		if (component != null)
		{
			int id = entity.Id;
			if (this.PlayerActorDisableHandleIdMap.ContainsKey(id))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.CameraAnimation;
				ELogAuthor author = ELogAuthor.BB;
				string message = "已经隐藏过对应的玩家Actor";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entityId", id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PlayerActorDisableHandleIdMap", this.PlayerActorDisableHandleIdMap);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			int value = component.DisableActor("Ui镜头Sequence中隐藏角色");
			this.PlayerActorDisableHandleIdMap.Add(id, value);
		}
	}

	// Token: 0x060179C1 RID: 96705 RVA: 0x00602369 File Offset: 0x00600569
	public bool IsDisablePlayer()
	{
		return this.IsActivate() && this.PlayerActorDisableHandleIdMap.Count > 0;
	}

	// Token: 0x060179C2 RID: 96706 RVA: 0x00602384 File Offset: 0x00600584
	public void EnablePlayerActor()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CameraAnimation;
		ELogAuthor author = ELogAuthor.BB;
		string message = "Ui镜头在清理表现时显示玩家Actor";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DisableHandleId", this.PlayerActorDisableHandleIdMap);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		foreach (KeyValuePair<int, int> keyValuePair in this.PlayerActorDisableHandleIdMap)
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			Entity entity = EntitySystem.Instance.Get(key);
			if (entity == null || !entity.Valid)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.CameraAnimation;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "Ui镜头在清理表现时显示玩家Actor-失败，因为找不到当前玩家Entity";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("EntityId", key);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
			if (component != null)
			{
				component.EnableActor(value);
			}
			else
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.CameraAnimation;
				ELogAuthor author3 = ELogAuthor.BB;
				string message3 = "Ui镜头在清理表现时显示玩家Actor-失败，因为当前玩家实体找不到BaseActorComponent";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("EntityId", key);
				instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			}
		}
		this.PlayerActorDisableHandleIdMap.Clear();
	}

	// Token: 0x060179C3 RID: 96707 RVA: 0x006024B0 File Offset: 0x006006B0
	public void DisableCustomCreatureActor(int position)
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null || !getCurrentEntity.Valid)
		{
			return;
		}
		CreatureDataComponent component = getCurrentEntity.Entity.GetComponent<CreatureDataComponent>();
		if (component == null)
		{
			return;
		}
		IList<long> customServerEntityIds = component.CustomServerEntityIds;
		if (position > customServerEntityIds.Count || position == 0)
		{
			return;
		}
		int id = getCurrentEntity.Entity.Id;
		long creatureDataId = customServerEntityIds[position - 1];
		EntityHandle entity = CreatureModel.Instance.GetEntity(creatureDataId);
		if (entity == null || !entity.Valid)
		{
			return;
		}
		BaseActorComponent component2 = entity.Entity.GetComponent<BaseActorComponent>();
		if (component2 == null)
		{
			return;
		}
		Dictionary<int, int> dictionary;
		if (!this.CustomCreatureActorHandleIdMap.TryGetValue(id, out dictionary))
		{
			dictionary = new Dictionary<int, int>();
			this.CustomCreatureActorHandleIdMap.Add(id, dictionary);
		}
		if (!dictionary.ContainsKey(position))
		{
			int value = component2.DisableActor("Ui镜头Sequence中隐藏角色伴生物");
			dictionary.Add(position, value);
		}
	}

	// Token: 0x060179C4 RID: 96708 RVA: 0x00602588 File Offset: 0x00600788
	public void EnableCustomCreatureActor()
	{
		foreach (KeyValuePair<int, Dictionary<int, int>> keyValuePair in this.CustomCreatureActorHandleIdMap)
		{
			int key = keyValuePair.Key;
			Dictionary<int, int> value = keyValuePair.Value;
			Entity entity = EntitySystem.Instance.Get(key);
			CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
			if (creatureDataComponent == null)
			{
				return;
			}
			IList<long> customServerEntityIds = creatureDataComponent.CustomServerEntityIds;
			foreach (KeyValuePair<int, int> keyValuePair2 in value)
			{
				int key2 = keyValuePair2.Key;
				int value2 = keyValuePair2.Value;
				long creatureDataId = customServerEntityIds[key2 - 1];
				EntityHandle entity2 = CreatureModel.Instance.GetEntity(creatureDataId);
				if (entity2 == null)
				{
					return;
				}
				BaseActorComponent component = entity2.Entity.GetComponent<BaseActorComponent>();
				if (component == null)
				{
					return;
				}
				component.EnableActor(value2);
			}
		}
		this.CustomCreatureActorHandleIdMap.Clear();
	}

	// Token: 0x060179C5 RID: 96709 RVA: 0x006026AC File Offset: 0x006008AC
	public void ResetFightCameraRotation()
	{
		if (Global.BaseCharacter == null)
		{
			return;
		}
		FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
		if (logicComponent != null)
		{
			CameraGuideController cameraGuideController = logicComponent.CameraGuideController;
			if (((cameraGuideController != null) ? new bool?(cameraGuideController.IsLockCameraInput()) : null).GetValueOrDefault())
			{
				return;
			}
		}
		logicComponent.SetRotation(CameraUtility.GetCameraDefaultFocusUeRotator());
		logicComponent.ResetFightCameraLogic(false, false);
	}

	// Token: 0x17001FC8 RID: 8136
	// (get) Token: 0x060179C6 RID: 96710 RVA: 0x00602716 File Offset: 0x00600916
	public static UiCameraAnimationManager Instance
	{
		get
		{
			if (UiCameraAnimationManager._instance == null)
			{
				UiCameraAnimationManager._instance = new UiCameraAnimationManager();
				UiCameraAnimationManager._instance.OnInit();
			}
			return UiCameraAnimationManager._instance;
		}
	}

	// Token: 0x060179C7 RID: 96711 RVA: 0x00602739 File Offset: 0x00600939
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060179C8 RID: 96712 RVA: 0x0060273B File Offset: 0x0060093B
	public static void ResetStaticDefaultValue()
	{
		UiCameraAnimationManager instance = UiCameraAnimationManager._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		UiCameraAnimationManager._instance = null;
	}

	// Token: 0x060179C9 RID: 96713 RVA: 0x00602754 File Offset: 0x00600954
	static UiCameraAnimationManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiCameraAnimationManager.CreateStaticDefaultValue), new Action(UiCameraAnimationManager.ResetStaticDefaultValue));
	}

	// Token: 0x0400AFF9 RID: 45049
	private int HandleDataUniqueId;

	// Token: 0x0400AFFA RID: 45050
	private Dictionary<string, UiCameraMappingData> CameraMappingDataMap = new Dictionary<string, UiCameraMappingData>();

	// Token: 0x0400AFFB RID: 45051
	private HashSet<string> DynamicDisablePushCamera = new HashSet<string>();

	// Token: 0x0400AFFC RID: 45052
	private global::Stack<UiCameraHandleData> HandleDataStack = new global::Stack<UiCameraHandleData>();

	// Token: 0x0400AFFD RID: 45053
	public UiCameraAnimationHandle CurrentCameraHandle;

	// Token: 0x0400AFFE RID: 45054
	private UiCameraAnimation CurrentUiCameraAnimation;

	// Token: 0x0400AFFF RID: 45055
	private UiCameraAnimationHandle CurrentPopCameraHandle;

	// Token: 0x0400B000 RID: 45056
	public float? LoadingViewCameraAnimationLength = new float?(0f);

	// Token: 0x0400B001 RID: 45057
	public float? LoadingViewManualFocusDistance = new float?(0f);

	// Token: 0x0400B002 RID: 45058
	public float? LoadingViewAperture;

	// Token: 0x0400B003 RID: 45059
	private Dictionary<int, int> PlayerActorDisableHandleIdMap = new Dictionary<int, int>();

	// Token: 0x0400B004 RID: 45060
	private Dictionary<int, Dictionary<int, int>> CustomCreatureActorHandleIdMap = new Dictionary<int, Dictionary<int, int>>();

	// Token: 0x0400B005 RID: 45061
	[Nullable(2)]
	public UiCamera UiCamera;

	// Token: 0x0400B006 RID: 45062
	public UiCameraSpringStructure UiCameraSpringStructure;

	// Token: 0x0400B007 RID: 45063
	public UiCameraPostEffectComponent UiCameraPostEffectComponent;

	// Token: 0x0400B008 RID: 45064
	[Nullable(2)]
	public UiCameraSequenceComponent UiCameraSequenceComponent;

	// Token: 0x0400B009 RID: 45065
	public UiCameraDebugTool UiCameraDebugTool;

	// Token: 0x0400B00A RID: 45066
	private Dictionary<EUiCameraAnimationTargetType, UiCameraTargetTypeBase> TargetTypeMap = new Dictionary<EUiCameraAnimationTargetType, UiCameraTargetTypeBase>();

	// Token: 0x0400B00B RID: 45067
	[Nullable(2)]
	private static UiCameraAnimationManager _instance;
}
