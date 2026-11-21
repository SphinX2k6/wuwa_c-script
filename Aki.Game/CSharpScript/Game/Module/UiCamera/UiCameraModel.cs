using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x020039B6 RID: 14774
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class UiCameraModel : ModelBase, ITickable
	{
		// Token: 0x17004D9E RID: 19870
		// (get) Token: 0x060260A4 RID: 155812 RVA: 0x00AAC7AC File Offset: 0x00AAA9AC
		public IReadOnlyList<UiCameraHandleData> NormalHandleStack
		{
			get
			{
				return this.NormalHandleStackInternal;
			}
		}

		// Token: 0x17004D9F RID: 19871
		// (get) Token: 0x060260A5 RID: 155813 RVA: 0x00AAC7B4 File Offset: 0x00AAA9B4
		// (set) Token: 0x060260A6 RID: 155814 RVA: 0x00AAC7BC File Offset: 0x00AAA9BC
		[Nullable(2)]
		public UiCamera Camera { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x17004DA0 RID: 19872
		// (get) Token: 0x060260A7 RID: 155815 RVA: 0x00AAC7C5 File Offset: 0x00AAA9C5
		// (set) Token: 0x060260A8 RID: 155816 RVA: 0x00AAC7CD File Offset: 0x00AAA9CD
		[Nullable(2)]
		public UiCameraHandleData CurrentHandle { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x17004DA1 RID: 19873
		// (get) Token: 0x060260A9 RID: 155817 RVA: 0x00AAC7D6 File Offset: 0x00AAA9D6
		// (set) Token: 0x060260AA RID: 155818 RVA: 0x00AAC7DE File Offset: 0x00AAA9DE
		[Nullable(2)]
		public UiCameraHandleData RevertingHandle { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x17004DA2 RID: 19874
		// (get) Token: 0x060260AB RID: 155819 RVA: 0x00AAC7E7 File Offset: 0x00AAA9E7
		public UiCameraDebugTool UiCameraDebugTool { get; } = new UiCameraDebugTool();

		// Token: 0x17004DA3 RID: 19875
		// (get) Token: 0x060260AC RID: 155820 RVA: 0x00AAC7EF File Offset: 0x00AAA9EF
		[Nullable(2)]
		public UiCamera UiCamera
		{
			[NullableContext(2)]
			get
			{
				return this.Camera;
			}
		}

		// Token: 0x060260AD RID: 155821 RVA: 0x00AAC7F7 File Offset: 0x00AAA9F7
		protected override bool OnInit()
		{
			this.RegisterTargetTypes();
			return true;
		}

		// Token: 0x060260AE RID: 155822 RVA: 0x00AAC800 File Offset: 0x00AAAA00
		public UiCamera GetOrCreateCamera()
		{
			if (this.Camera != null)
			{
				return this.Camera;
			}
			this.Camera = new UiCamera();
			this.Camera.Initialize(this);
			return this.Camera;
		}

		// Token: 0x060260AF RID: 155823 RVA: 0x00AAC830 File Offset: 0x00AAAA30
		private int GenerateHandleId()
		{
			int num = this.NextHandleId + 1;
			this.NextHandleId = num;
			return num;
		}

		// Token: 0x060260B0 RID: 155824 RVA: 0x00AAC850 File Offset: 0x00AAAA50
		private unsafe bool PushHandleData(UiCameraHandleData handleData, bool blend = true, bool playSequence = true, [Nullable(2)] string blendName = null, [Nullable(new byte[]
		{
			2,
			1
		})] Action<UiCameraDefine.IFinishData> animationFinished = null)
		{
			if (handleData.GetHandleId() == 0)
			{
				if (handleData.GetViewId() == null)
				{
					UiCameraHandleData currentHandle = this.CurrentHandle;
					handleData.SetViewId((currentHandle != null) ? currentHandle.GetViewId() : null);
				}
				handleData.AssignHandleId(this.GenerateHandleId());
			}
			UiCameraHandleData currentHandle2 = this.CurrentHandle;
			this.NormalHandleStackInternal.Add(handleData);
			this.CurrentHandle = handleData;
			this.RevertingHandle = null;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiCamera;
			ELogAuthor author = ELogAuthor.BB;
			string message = "镜头状态数据------入栈";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PushHandleData", handleData.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("LastTopHandleData", (currentHandle2 != null) ? currentHandle2.ToString() : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Blend", blend);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("BlendName", blendName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("StackCount", this.NormalHandleStackInternal.Count);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			UiCamera orCreateCamera = this.GetOrCreateCamera();
			UiCameraNormalMode mode = orCreateCamera.GetMode<UiCameraNormalMode>();
			if (!mode.RefreshHandleForActivation(handleData))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiCamera;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "镜头状态数据刷新失败，保留在栈中等待重新激活";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("HandleData", handleData.ToString());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("HandleType", handleData.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("TargetType", handleData.GetTargetType());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("HasCameraSettings", handleData.GetUiCameraAnimationConfig() != null);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
				UiCameraModel.NotifyActivateFailed(handleData);
				return true;
			}
			orCreateCamera.SwitchMode(EUiCameraMode.Normal);
			if (!mode.PushCameraHandle(handleData, currentHandle2, blend, playSequence, blendName, animationFinished))
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.UiCamera;
				ELogAuthor author3 = ELogAuthor.BB;
				string message3 = "镜头状态激活失败，保留在栈中等待重新激活";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("HandleData", handleData.ToString());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("HandleType", handleData.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("TargetType", handleData.GetTargetType());
				instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
				UiCameraModel.NotifyActivateFailed(handleData);
				return true;
			}
			UiCameraSequenceHandleData uiCameraSequenceHandleData = handleData as UiCameraSequenceHandleData;
			if (uiCameraSequenceHandleData != null && uiCameraSequenceHandleData.GetSequenceCameraData() != null)
			{
				CameraModel.Instance.MainModel.ResetSavedSeqCameraThings();
			}
			return true;
		}

		// Token: 0x060260B1 RID: 155825 RVA: 0x00AACB1C File Offset: 0x00AAAD1C
		[NullableContext(2)]
		public unsafe UiCameraHandleData PushCameraHandle(UiCameraHandleData handleData, bool blend = true, bool playSequence = true, string blendName = null, bool checkSameHandle = false, [Nullable(new byte[]
		{
			2,
			1
		})] Action<UiCameraDefine.IFinishData> callback = null)
		{
			if (handleData == null)
			{
				return null;
			}
			if (checkSameHandle && this.CurrentHandle != null)
			{
				UiCamera camera = this.Camera;
				if (camera != null && camera.IsEntered && this.CurrentHandle.IsSameState(handleData))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.UiCamera;
					ELogAuthor author = ELogAuthor.BB;
					string message = "新的镜头状态与当前镜头状态一致，跳过重复入栈和表现";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CurrentHandleData", this.CurrentHandle.ToString());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("NewHandleData", handleData.ToString());
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return this.CurrentHandle;
				}
			}
			if (!this.PushHandleData(handleData, blend, playSequence, blendName, callback))
			{
				return null;
			}
			return handleData;
		}

		// Token: 0x060260B2 RID: 155826 RVA: 0x00AACBE0 File Offset: 0x00AAADE0
		[NullableContext(2)]
		public UiCameraHandleData PushCameraHandleByHandleName([Nullable(1)] string handleName, bool blend = true, bool playSequence = true, string blendName = "1001", bool checkSameHandle = false, [Nullable(new byte[]
		{
			2,
			1
		})] Action<UiCameraDefine.IFinishData> callback = null)
		{
			UiCameraHandleData currentHandle = this.CurrentHandle;
			string viewName = (currentHandle != null) ? currentHandle.GetViewName() : null;
			UiCameraHandleData handleData = UiCameraUtil.CreateHandleData(handleName, viewName);
			return this.PushCameraHandle(handleData, blend, playSequence, blendName, checkSameHandle, callback);
		}

		// Token: 0x060260B3 RID: 155827 RVA: 0x00AACC18 File Offset: 0x00AAAE18
		[return: Nullable(2)]
		public UiCameraHandleData PushCameraHandleByViewName(string viewName, bool blend = true)
		{
			if (!this.CanPushCameraHandle(viewName))
			{
				return null;
			}
			UiCameraHandleData handleData = UiCameraUtil.CreateHandleData(this.GetHandleNameByView(viewName), viewName);
			return this.PushMappedCameraHandle(handleData, viewName, blend);
		}

		// Token: 0x060260B4 RID: 155828 RVA: 0x00AACC48 File Offset: 0x00AAAE48
		[return: Nullable(2)]
		public UiCameraTransformHandleData PushTransformCameraHandleByViewName(string viewName, FTransformDouble? transform, bool blend = true)
		{
			if (!this.CanPushCameraHandle(viewName))
			{
				return null;
			}
			UiCameraTransformHandleData handleData = UiCameraUtil.CreateTransformHandleData(this.GetHandleNameByView(viewName), transform, viewName);
			return this.PushMappedCameraHandle(handleData, viewName, blend) as UiCameraTransformHandleData;
		}

		// Token: 0x060260B5 RID: 155829 RVA: 0x00AACC80 File Offset: 0x00AAAE80
		[NullableContext(2)]
		private UiCameraHandleData PushMappedCameraHandle(UiCameraHandleData handleData, [Nullable(1)] string viewName, bool blend)
		{
			if (handleData == null)
			{
				return null;
			}
			string text;
			if (this.CurrentHandle != null)
			{
				UiCameraConfig instance = UiCameraConfig.Instance;
				text = ((instance != null) ? instance.GetBlendName(this.CurrentHandle.GetViewName(), viewName) : null);
			}
			else
			{
				text = null;
			}
			string blendName = text;
			return this.PushCameraHandle(handleData, blend, true, blendName, true, null);
		}

		// Token: 0x060260B6 RID: 155830 RVA: 0x00AACCC8 File Offset: 0x00AAAEC8
		[return: Nullable(2)]
		public unsafe UiCameraHandleData PushCameraHandleByOpenView(string viewName, int viewId, EUiCameraHandleOperationType operationType = EUiCameraHandleOperationType.Blend)
		{
			if (operationType == EUiCameraHandleOperationType.Delete)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCamera;
				ELogAuthor author = ELogAuthor.BB;
				string message = "PushCameraHandleByOpenView不支持Delete操作";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ViewName", viewName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ViewId", viewId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return null;
			}
			if (!this.CanPushCameraHandle(viewName))
			{
				return null;
			}
			UiCameraHandleData currentHandle = this.CurrentHandle;
			if (currentHandle != null)
			{
				if (!(currentHandle.GetViewName() == viewName))
				{
					int? viewId2 = currentHandle.GetViewId();
					int viewId3 = viewId;
					if (!(viewId2.GetValueOrDefault() == viewId3 & viewId2 != null))
					{
						goto IL_137;
					}
				}
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiCamera;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "界面镜头状态已在栈顶，跳过重复入栈";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("HandleData", currentHandle.ToString());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ViewName", viewName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("ViewId", viewId);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return null;
			}
			IL_137:
			UiCameraHandleData uiCameraHandleData = this.NormalHandleStackInternal.Find(delegate(UiCameraHandleData handle)
			{
				int? viewId4 = handle.GetViewId();
				int viewId5 = viewId;
				return viewId4.GetValueOrDefault() == viewId5 & viewId4 != null;
			});
			if (uiCameraHandleData != null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.UiCamera;
				ELogAuthor author3 = ELogAuthor.BB;
				string message3 = "界面镜头状态已经入栈，跳过重复Push";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("HandleData", uiCameraHandleData.ToString());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("ViewName", viewName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("ViewId", viewId);
				instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
				return null;
			}
			string handleNameByView = this.GetHandleNameByView(viewName);
			bool blend = operationType == EUiCameraHandleOperationType.Blend;
			UiCameraHandleData uiCameraHandleData2 = UiCameraUtil.CreateHandleData(handleNameByView, viewName);
			if (uiCameraHandleData2 == null)
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.UiCamera;
				ELogAuthor author4 = ELogAuthor.BB;
				string message4 = "创建界面镜头状态数据失败";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("ViewName", viewName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("ViewId", viewId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("HandleName", handleNameByView);
				instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 3));
				return null;
			}
			uiCameraHandleData2.SetViewId(new int?(viewId));
			string text;
			if (this.CurrentHandle != null)
			{
				UiCameraConfig instance5 = UiCameraConfig.Instance;
				text = ((instance5 != null) ? instance5.GetBlendName(this.CurrentHandle.GetViewName(), viewName) : null);
			}
			else
			{
				text = null;
			}
			string blendName = text;
			if (!this.PushHandleData(uiCameraHandleData2, blend, true, blendName, null))
			{
				return null;
			}
			return uiCameraHandleData2;
		}

		// Token: 0x060260B7 RID: 155831 RVA: 0x00AACF85 File Offset: 0x00AAB185
		[NullableContext(2)]
		public UiCameraHandleData PushCameraHandleByOpenView(EUiViewName viewName, int viewId, EUiCameraHandleOperationType operationType = EUiCameraHandleOperationType.Blend)
		{
			return this.PushCameraHandleByOpenView(viewName.ToString(), viewId, operationType);
		}

		// Token: 0x060260B8 RID: 155832 RVA: 0x00AACF9C File Offset: 0x00AAB19C
		[NullableContext(2)]
		public unsafe UiCameraHandleData PushCameraHandleByOpenTab(EUiTabViewName viewName, bool blend = true)
		{
			string text = viewName.ToString();
			if (!this.CanPushCameraHandle(text))
			{
				return null;
			}
			UiCameraHandleData currentHandle = this.CurrentHandle;
			if (((currentHandle != null) ? currentHandle.GetViewName() : null) == text)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCamera;
				ELogAuthor author = ELogAuthor.BB;
				string message = "页签镜头状态已在栈顶，跳过重复入栈";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("HandleData", currentHandle.ToString());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ViewName", text);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return currentHandle;
			}
			UiCameraHandleData uiCameraHandleData = UiCameraUtil.CreateHandleDataByView(viewName);
			if (uiCameraHandleData == null)
			{
				return null;
			}
			UiCameraHandleData uiCameraHandleData2 = uiCameraHandleData;
			UiCameraHandleData currentHandle2 = this.CurrentHandle;
			uiCameraHandleData2.SetViewId((currentHandle2 != null) ? currentHandle2.GetViewId() : null);
			string text2;
			if (this.CurrentHandle != null)
			{
				UiCameraConfig instance2 = UiCameraConfig.Instance;
				text2 = ((instance2 != null) ? instance2.GetBlendName(this.CurrentHandle.GetViewName(), text) : null);
			}
			else
			{
				text2 = null;
			}
			string blendName = text2;
			if (!this.PushHandleData(uiCameraHandleData, blend, true, blendName, null))
			{
				return null;
			}
			return uiCameraHandleData;
		}

		// Token: 0x060260B9 RID: 155833 RVA: 0x00AAD0A0 File Offset: 0x00AAB2A0
		private unsafe bool PopHandleData(UiCameraHandleData handleData, bool blend, [Nullable(2)] string blendName = null)
		{
			int num = this.NormalHandleStackInternal.LastIndexOf(handleData);
			if (num < 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCamera;
				ELogAuthor author = ELogAuthor.BB;
				string message = "镜头状态数据出栈失败，栈中不存在指定Handle";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PopHandleData", handleData.ToString());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("StackCount", this.NormalHandleStackInternal.Count);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			UiCameraHandleData fromHandle = this.CurrentHandle ?? handleData;
			UiCameraNormalMode mode = this.GetOrCreateCamera().GetMode<UiCameraNormalMode>();
			this.NormalHandleStackInternal.RemoveRange(num, this.NormalHandleStackInternal.Count - num);
			this.CurrentHandle = null;
			bool flag = false;
			if (this.NormalHandleStackInternal.Count > 0)
			{
				List<UiCameraHandleData> normalHandleStackInternal = this.NormalHandleStackInternal;
				UiCameraHandleData uiCameraHandleData = normalHandleStackInternal[normalHandleStackInternal.Count - 1];
				this.CurrentHandle = uiCameraHandleData;
				this.RefreshMappedHandleName(uiCameraHandleData);
				if (mode.RefreshHandleForActivation(uiCameraHandleData))
				{
					flag = true;
				}
				else
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.UiCamera;
					ELogAuthor author2 = ELogAuthor.BB;
					string message2 = "出栈后栈顶镜头状态刷新失败，保留在栈中等待重新激活";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("HandleData", uiCameraHandleData.ToString());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("HandleType", uiCameraHandleData.GetType().Name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("TargetType", uiCameraHandleData.GetTargetType());
					instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
					UiCameraModel.NotifyActivateFailed(uiCameraHandleData);
				}
			}
			this.RevertingHandle = ((this.CurrentHandle == null) ? fromHandle : null);
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.UiCamera;
			ELogAuthor author3 = ELogAuthor.BB;
			string message3 = "镜头状态数据------出栈";
			<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray6<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("PopHandleData", handleData.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("FromHandleData", fromHandle.ToString());
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2);
			string item = "TopHandleData";
			UiCameraHandleData currentHandle = this.CurrentHandle;
			ptr = new ValueTuple<string, object>(item, (currentHandle != null) ? currentHandle.ToString() : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("Blend", blend);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 4) = new ValueTuple<string, object>("BlendName", blendName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 5) = new ValueTuple<string, object>("StackCount", this.NormalHandleStackInternal.Count);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 6));
			if (this.CurrentHandle != null && !flag)
			{
				mode.SuspendCameraHandle(this.CurrentHandle);
				return true;
			}
			mode.PopCameraHandle(fromHandle, this.CurrentHandle, blend, blendName, delegate
			{
				this.FinishRevertingHandle(fromHandle);
			});
			return true;
		}

		// Token: 0x060260BA RID: 155834 RVA: 0x00AAD380 File Offset: 0x00AAB580
		[NullableContext(2)]
		public bool PopCameraHandle(UiCameraHandleData handleData, string blendName = null)
		{
			if (handleData == null)
			{
				return false;
			}
			for (int i = this.NormalHandleStackInternal.Count - 1; i >= 0; i--)
			{
				if (this.NormalHandleStackInternal[i] == handleData)
				{
					return this.PopHandleData(this.NormalHandleStackInternal[i], true, blendName);
				}
			}
			return false;
		}

		// Token: 0x060260BB RID: 155835 RVA: 0x00AAD3D0 File Offset: 0x00AAB5D0
		[NullableContext(2)]
		public unsafe bool PopCameraHandleByCloseView(int viewId, EUiCameraHandleOperationType operationType, string blendName = null)
		{
			if (operationType == EUiCameraHandleOperationType.Delete)
			{
				return this.DeleteCameraHandlesByViewId(viewId);
			}
			int num = this.NormalHandleStackInternal.FindIndex(delegate(UiCameraHandleData handle)
			{
				int? viewId2 = handle.GetViewId();
				int viewId3 = viewId;
				return viewId2.GetValueOrDefault() == viewId3 & viewId2 != null;
			});
			bool blend = operationType == EUiCameraHandleOperationType.Blend;
			if (num < 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCamera;
				ELogAuthor author = ELogAuthor.BB;
				string message = "界面关闭时未找到对应的镜头状态数据";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ViewId", viewId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("OperationType", operationType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("StackCount", this.NormalHandleStackInternal.Count);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return false;
			}
			return this.PopHandleData(this.NormalHandleStackInternal[num], blend, blendName);
		}

		// Token: 0x060260BC RID: 155836 RVA: 0x00AAD4C0 File Offset: 0x00AAB6C0
		private unsafe bool DeleteCameraHandlesByViewId(int viewId)
		{
			UiCameraHandleData currentHandle = this.CurrentHandle;
			bool flag;
			if (currentHandle == null)
			{
				flag = false;
			}
			else
			{
				int? viewId2 = currentHandle.GetViewId();
				int viewId3 = viewId;
				flag = (viewId2.GetValueOrDefault() == viewId3 & viewId2 != null);
			}
			if (flag)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCamera;
				ELogAuthor author = ELogAuthor.BB;
				string message = "不能仅删除当前界面的镜头状态数据";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ViewId", viewId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurrentHandleData", this.CurrentHandle.ToString());
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			int num = this.NormalHandleStackInternal.RemoveAll(delegate(UiCameraHandleData handle)
			{
				int? viewId4 = handle.GetViewId();
				int viewId5 = viewId;
				return viewId4.GetValueOrDefault() == viewId5 & viewId4 != null;
			});
			if (num == 0)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiCamera;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "仅删除镜头状态时未找到对应界面数据";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("ViewId", viewId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("StackCount", this.NormalHandleStackInternal.Count);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return false;
			}
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.UiCamera;
			ELogAuthor author3 = ELogAuthor.BB;
			string message3 = "仅删除镜头状态，不做任何表现";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("ViewId", viewId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("RemovedCount", num);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2);
			string item = "TopHandleData";
			UiCameraHandleData currentHandle2 = this.CurrentHandle;
			ptr = new ValueTuple<string, object>(item, (currentHandle2 != null) ? currentHandle2.ToString() : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("StackCount", this.NormalHandleStackInternal.Count);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 4));
			return true;
		}

		// Token: 0x060260BD RID: 155837 RVA: 0x00AAD6B0 File Offset: 0x00AAB8B0
		public unsafe bool RestoreCameraHandle()
		{
			UiCamera camera = this.Camera;
			UiCameraHandleData currentHandle = this.CurrentHandle;
			if (camera == null || currentHandle == null || camera.CurrentMode != EUiCameraMode.Normal)
			{
				return false;
			}
			if (!camera.GetMode<UiCameraNormalMode>().RestoreCameraHandle(currentHandle))
			{
				return false;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiCamera;
			ELogAuthor author = ELogAuthor.BB;
			string message = "恢复已应用的Ui镜头状态，不重新获取目标";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("HandleData", currentHandle.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("HandleType", currentHandle.GetType().Name);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return true;
		}

		// Token: 0x060260BE RID: 155838 RVA: 0x00AAD750 File Offset: 0x00AAB950
		public bool ReactivateCameraHandle()
		{
			if (this.Camera == null && this.CurrentHandle == null)
			{
				return false;
			}
			UiCameraHandleData reactivationHandle = this.GetOrCreateCamera().GetMode<UiCameraNormalMode>().GetReactivationHandle(this.CurrentHandle);
			return reactivationHandle != null && this.RefreshCameraHandle(reactivationHandle, true);
		}

		// Token: 0x060260BF RID: 155839 RVA: 0x00AAD794 File Offset: 0x00AAB994
		private unsafe bool RefreshCameraHandle(UiCameraHandleData handleData, bool preserveTransition)
		{
			UiCameraNormalMode mode = this.GetOrCreateCamera().GetMode<UiCameraNormalMode>();
			this.RefreshMappedHandleName(handleData);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiCamera;
			ELogAuthor author = ELogAuthor.BB;
			string message = "重新激活镜头状态";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("HandleData", handleData.ToString());
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "StackTopHandleData";
			UiCameraHandleData currentHandle = this.CurrentHandle;
			ptr = new ValueTuple<string, object>(item, (currentHandle != null) ? currentHandle.ToString() : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("IsStackTopHandle", handleData == this.CurrentHandle);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (!mode.RefreshHandleForActivation(handleData))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiCamera;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "重新激活镜头状态失败，刷新HandleData失败";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("HandleData", handleData.ToString());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("HandleType", handleData.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("TargetType", handleData.GetTargetType());
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				UiCameraModel.NotifyActivateFailed(handleData);
				return false;
			}
			if (preserveTransition && mode.TryReactivateHandleDuringTransition(handleData))
			{
				return true;
			}
			if (!mode.PushCameraHandle(handleData, null, false, false, null, null))
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.UiCamera;
				ELogAuthor author3 = ELogAuthor.BB;
				string message3 = "重新激活镜头状态失败，NormalMode激活失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("HandleData", handleData.ToString());
				instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				UiCameraModel.NotifyActivateFailed(handleData);
				return false;
			}
			return true;
		}

		// Token: 0x060260C0 RID: 155840 RVA: 0x00AAD92B File Offset: 0x00AABB2B
		public void SetDynamicDisablePushCamera(string viewName, bool disable)
		{
			if (disable)
			{
				this.DynamicDisabledViewNames.Add(viewName);
				return;
			}
			this.DynamicDisabledViewNames.Remove(viewName);
		}

		// Token: 0x060260C1 RID: 155841 RVA: 0x00AAD94B File Offset: 0x00AABB4B
		public bool CanPushCameraHandle(string viewName)
		{
			if (this.DynamicDisabledViewNames.Contains(viewName))
			{
				return false;
			}
			UiCameraConfig instance = UiCameraConfig.Instance;
			return UiCameraModel.IsValidHandleName((instance != null) ? instance.GetDefaultHandleName(viewName) : null);
		}

		// Token: 0x060260C2 RID: 155842 RVA: 0x00AAD974 File Offset: 0x00AABB74
		public void ResetFightCameraRotation()
		{
			if (Global.BaseCharacter == null)
			{
				return;
			}
			FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
			FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
			if (fightCameraLogicComponent != null)
			{
				CameraGuideController cameraGuideController = fightCameraLogicComponent.CameraGuideController;
				if (((cameraGuideController != null) ? new bool?(cameraGuideController.IsLockCameraInput()) : null).GetValueOrDefault())
				{
					return;
				}
			}
			if (fightCameraLogicComponent != null)
			{
				fightCameraLogicComponent.SetRotation(CameraUtility.GetCameraDefaultFocusUeRotator());
			}
			if (fightCameraLogicComponent != null)
			{
				fightCameraLogicComponent.ResetFightCameraLogic(false, false);
			}
		}

		// Token: 0x060260C3 RID: 155843 RVA: 0x00AAD9EB File Offset: 0x00AABBEB
		public void SwitchMode(EUiCameraMode mode)
		{
			this.GetOrCreateCamera().SwitchMode(mode);
		}

		// Token: 0x060260C4 RID: 155844 RVA: 0x00AAD9FC File Offset: 0x00AABBFC
		[NullableContext(2)]
		public UiCameraTargetType GetTargetType(EUiCameraAnimationTargetType targetType, SUiCameraAnimationSettings settings)
		{
			UiCameraTargetType uiCameraTargetType;
			if (settings == null || !this.TargetTypes.TryGetValue(targetType, out uiCameraTargetType))
			{
				return null;
			}
			uiCameraTargetType.Refresh(settings);
			return uiCameraTargetType;
		}

		// Token: 0x060260C5 RID: 155845 RVA: 0x00AADA2C File Offset: 0x00AABC2C
		[return: Nullable(2)]
		public string GetHandleNameByView(string viewName)
		{
			UiCameraConfig instance = UiCameraConfig.Instance;
			string text = (instance != null) ? instance.GetDefaultHandleName(viewName) : null;
			if (instance == null || !UiCameraModel.IsValidHandleName(text))
			{
				return text;
			}
			EUiCameraAnimationTargetType bodyTargetType = instance.GetBodyTargetType(viewName);
			UiCameraTargetType uiCameraTargetType;
			if (bodyTargetType == EUiCameraAnimationTargetType.None || !this.TargetTypes.TryGetValue(bodyTargetType, out uiCameraTargetType))
			{
				return text;
			}
			string text2 = uiCameraTargetType.RefreshBodyKey();
			if (string.IsNullOrEmpty(text2))
			{
				return text;
			}
			string bodyHandleName = instance.GetBodyHandleName(viewName, text2);
			if (!UiCameraModel.IsValidHandleName(bodyHandleName))
			{
				return text;
			}
			return bodyHandleName;
		}

		// Token: 0x060260C6 RID: 155846 RVA: 0x00AADAA2 File Offset: 0x00AABCA2
		[NullableContext(2)]
		public UiCameraHandleData GetLastHandleData()
		{
			return this.CurrentHandle;
		}

		// Token: 0x060260C7 RID: 155847 RVA: 0x00AADAAA File Offset: 0x00AABCAA
		public bool IsActivate()
		{
			return this.CurrentHandle != null;
		}

		// Token: 0x060260C8 RID: 155848 RVA: 0x00AADAB5 File Offset: 0x00AABCB5
		public bool IsPlayingAnimation()
		{
			UiCamera camera = this.Camera;
			return camera != null && camera.GetMode<UiCameraNormalMode>().IsBlending;
		}

		// Token: 0x060260C9 RID: 155849 RVA: 0x00AADACD File Offset: 0x00AABCCD
		public bool IsPlayingBlendInSequence()
		{
			UiCamera camera = this.Camera;
			return camera != null && camera.GetMode<UiCameraNormalMode>().IsPlayingBlendInSequence;
		}

		// Token: 0x060260CA RID: 155850 RVA: 0x00AADAE5 File Offset: 0x00AABCE5
		[return: Nullable(2)]
		public UiCameraHandleData PlayCameraAnimationFromCurrent(string handleName, string blendName)
		{
			UiCameraHandleData currentHandle = this.CurrentHandle;
			this.PushCameraHandleByHandleName(handleName, true, true, blendName, false, null);
			return currentHandle;
		}

		// Token: 0x060260CB RID: 155851 RVA: 0x00AADAFC File Offset: 0x00AABCFC
		public bool RefreshCurrentTransformHandle(FTransformDouble transform, bool blend = false)
		{
			UiCameraTransformHandleData uiCameraTransformHandleData = this.CurrentHandle as UiCameraTransformHandleData;
			if (uiCameraTransformHandleData == null || !transform.IsValid())
			{
				return false;
			}
			uiCameraTransformHandleData.SetTransform(new FTransformDouble?(transform));
			return this.RefreshCameraHandle(uiCameraTransformHandleData, blend);
		}

		// Token: 0x060260CC RID: 155852 RVA: 0x00AADB37 File Offset: 0x00AABD37
		public void BroadUiCameraSequenceEvent(string sequenceEventName)
		{
			UiCamera camera = this.Camera;
			if (camera != null)
			{
				UiCameraSequenceComponent uiCameraSequenceComponent = camera.GetMode<UiCameraNormalMode>().TryGetComponent<UiCameraSequenceComponent>();
				if (uiCameraSequenceComponent != null)
				{
					uiCameraSequenceComponent.ExecuteEvent(sequenceEventName);
				}
			}
			EventSystem.Instance.Emit<string>(EEventName.OnExecuteUiCameraSequenceEvent, sequenceEventName);
		}

		// Token: 0x060260CD RID: 155853 RVA: 0x00AADB6C File Offset: 0x00AABD6C
		[NullableContext(2)]
		public UiCameraHandleData FindHandleDataByHandleId(int handleId)
		{
			return this.NormalHandleStackInternal.Find((UiCameraHandleData handle) => handle.GetHandleId() == handleId);
		}

		// Token: 0x060260CE RID: 155854 RVA: 0x00AADBA0 File Offset: 0x00AABDA0
		[NullableContext(2)]
		public UiCameraHandleData FindFirstHandleDataByViewId(int viewId)
		{
			return this.NormalHandleStackInternal.Find(delegate(UiCameraHandleData handle)
			{
				int? viewId2 = handle.GetViewId();
				int viewId3 = viewId;
				return viewId2.GetValueOrDefault() == viewId3 & viewId2 != null;
			});
		}

		// Token: 0x060260CF RID: 155855 RVA: 0x00AADBD1 File Offset: 0x00AABDD1
		public bool IsLoadingCameraEffectActive()
		{
			UiCamera camera = this.Camera;
			return camera != null && camera.GetMode<UiCameraNormalMode>().GetComponent<UiCameraLoadingEffectComponent>().HasEffect;
		}

		// Token: 0x060260D0 RID: 155856 RVA: 0x00AADBEE File Offset: 0x00AABDEE
		public void DisablePlayerActor()
		{
			UiCamera camera = this.Camera;
			if (camera == null)
			{
				return;
			}
			camera.GetMode<UiCameraNormalMode>().GetComponent<UiCameraActorDisplayComponent>().DisablePlayerActor();
		}

		// Token: 0x060260D1 RID: 155857 RVA: 0x00AADC0A File Offset: 0x00AABE0A
		public void EnablePlayerActor()
		{
			UiCamera camera = this.Camera;
			if (camera == null)
			{
				return;
			}
			camera.GetMode<UiCameraNormalMode>().GetComponent<UiCameraActorDisplayComponent>().EnablePlayerActor();
		}

		// Token: 0x060260D2 RID: 155858 RVA: 0x00AADC26 File Offset: 0x00AABE26
		public bool IsDisablePlayer()
		{
			if (this.IsActivate())
			{
				UiCamera camera = this.Camera;
				return camera != null && camera.GetMode<UiCameraNormalMode>().GetComponent<UiCameraActorDisplayComponent>().IsPlayerDisabled;
			}
			return false;
		}

		// Token: 0x060260D3 RID: 155859 RVA: 0x00AADC4D File Offset: 0x00AABE4D
		public void DisableCustomCreatureActor(int position)
		{
			UiCamera camera = this.Camera;
			if (camera == null)
			{
				return;
			}
			camera.GetMode<UiCameraNormalMode>().GetComponent<UiCameraActorDisplayComponent>().DisableCustomCreatureActor(position);
		}

		// Token: 0x060260D4 RID: 155860 RVA: 0x00AADC6A File Offset: 0x00AABE6A
		public void EnableCustomCreatureActor()
		{
			UiCamera camera = this.Camera;
			if (camera == null)
			{
				return;
			}
			camera.GetMode<UiCameraNormalMode>().GetComponent<UiCameraActorDisplayComponent>().EnableCustomCreatureActor();
		}

		// Token: 0x060260D5 RID: 155861 RVA: 0x00AADC86 File Offset: 0x00AABE86
		public void ClearDisplay()
		{
			this.NormalHandleStackInternal.Clear();
			this.CurrentHandle = null;
			this.RevertingHandle = null;
			UiCamera camera = this.Camera;
			if (camera != null)
			{
				camera.Clear();
			}
			this.Camera = null;
		}

		// Token: 0x060260D6 RID: 155862 RVA: 0x00AADCBC File Offset: 0x00AABEBC
		public void Tick(float deltaTime)
		{
			float deltaTime2 = deltaTime * Time.Instance.InverseSelfCenteredTimeDilation / (float)TimeUtil.Instance.InverseMillisecond;
			UiCamera camera = this.Camera;
			if (camera == null)
			{
				return;
			}
			camera.Tick(deltaTime2);
		}

		// Token: 0x060260D7 RID: 155863 RVA: 0x00AADCF3 File Offset: 0x00AABEF3
		protected override bool OnClear()
		{
			this.UiCameraDebugTool.EndDtSync();
			this.ClearDisplay();
			this.DynamicDisabledViewNames.Clear();
			this.TargetTypes.Clear();
			return true;
		}

		// Token: 0x060260D8 RID: 155864 RVA: 0x00AADD1D File Offset: 0x00AABF1D
		protected override bool OnLeaveLevel()
		{
			this.ClearDisplay();
			return true;
		}

		// Token: 0x060260D9 RID: 155865 RVA: 0x00AADD28 File Offset: 0x00AABF28
		private void RegisterTargetTypes()
		{
			this.RegisterTargetType(new UiCameraTargetTypePlayer());
			this.RegisterTargetType(new UiCameraTargetTypeNpc());
			this.RegisterTargetType(new UiCameraTargetTypeUiSceneRole());
			this.RegisterTargetType(new UiCameraTargetTypeUiSceneSkeletal());
			this.RegisterTargetType(new UiCameraTargetTypeUiVisionHandBook());
			this.RegisterTargetType(new UiCameraTargetTypeUiGlider());
			this.RegisterTargetType(new UiCameraTargetTypeSailDock());
			this.RegisterTargetType(new UiCameraTargetTypeUiSceneHulu());
			this.RegisterTargetType(new UiCameraTargetTypeUiInfrastructure());
			this.RegisterTargetType(new UiCameraTargetTypeUiSceneActor());
			this.RegisterTargetType(new UiCameraTargetTypeUiSceneFormationRole());
		}

		// Token: 0x060260DA RID: 155866 RVA: 0x00AADDAE File Offset: 0x00AABFAE
		private void RegisterTargetType(UiCameraTargetType targetType)
		{
			this.TargetTypes[targetType.TargetType] = targetType;
		}

		// Token: 0x060260DB RID: 155867 RVA: 0x00AADDC4 File Offset: 0x00AABFC4
		private void RefreshMappedHandleName(UiCameraHandleData handleData)
		{
			string viewName = handleData.GetViewName();
			if (string.IsNullOrEmpty(viewName))
			{
				return;
			}
			UiCameraConfig instance = UiCameraConfig.Instance;
			EUiCameraAnimationTargetType euiCameraAnimationTargetType = (instance != null) ? instance.GetBodyTargetType(viewName) : EUiCameraAnimationTargetType.None;
			UiCameraTargetType uiCameraTargetType;
			if (euiCameraAnimationTargetType == EUiCameraAnimationTargetType.None || !this.TargetTypes.TryGetValue(euiCameraAnimationTargetType, out uiCameraTargetType))
			{
				return;
			}
			if (string.IsNullOrEmpty(uiCameraTargetType.RefreshBodyKey()))
			{
				return;
			}
			string handleNameByView = this.GetHandleNameByView(viewName);
			if (UiCameraModel.IsValidHandleName(handleNameByView))
			{
				handleData.SetHandleName(handleNameByView);
			}
		}

		// Token: 0x060260DC RID: 155868 RVA: 0x00AADE2D File Offset: 0x00AAC02D
		private void FinishRevertingHandle(UiCameraHandleData handleData)
		{
			if (this.RevertingHandle == handleData)
			{
				this.RevertingHandle = null;
				this.ClearDisplay();
			}
		}

		// Token: 0x060260DD RID: 155869 RVA: 0x00AADE45 File Offset: 0x00AAC045
		[NullableContext(2)]
		private static bool IsValidHandleName(string handleName)
		{
			return !string.IsNullOrEmpty(handleName) && handleName != "None";
		}

		// Token: 0x060260DE RID: 155870 RVA: 0x00AADE5C File Offset: 0x00AAC05C
		private static void NotifyActivateFailed(UiCameraHandleData handleData)
		{
			EventSystem.Instance.Emit<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandleFail, handleData);
		}

		// Token: 0x17004DA4 RID: 19876
		// (get) Token: 0x060260DF RID: 155871 RVA: 0x00AADE6F File Offset: 0x00AAC06F
		public static UiCameraModel Instance
		{
			get
			{
				return UiCameraModel._Instance;
			}
		}

		// Token: 0x060260E0 RID: 155872 RVA: 0x00AADE76 File Offset: 0x00AAC076
		public static UiCameraModel GetOrCreateInstance()
		{
			if (UiCameraModel._Instance == null)
			{
				UiCameraModel.CreateInstance();
			}
			return UiCameraModel._Instance;
		}

		// Token: 0x060260E1 RID: 155873 RVA: 0x00AADE8A File Offset: 0x00AAC08A
		public static bool CreateInstance()
		{
			if (UiCameraModel._Instance != null)
			{
				return true;
			}
			UiCameraModel._Instance = new UiCameraModel();
			return true;
		}

		// Token: 0x060260E2 RID: 155874 RVA: 0x00AADEA0 File Offset: 0x00AAC0A0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060260E3 RID: 155875 RVA: 0x00AADEA2 File Offset: 0x00AAC0A2
		public static void ResetStaticDefaultValue()
		{
			UiCameraModel._Instance = null;
		}

		// Token: 0x060260E4 RID: 155876 RVA: 0x00AADEAA File Offset: 0x00AAC0AA
		static UiCameraModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiCameraModel.CreateStaticDefaultValue), new Action(UiCameraModel.ResetStaticDefaultValue));
		}

		// Token: 0x04014E60 RID: 85600
		private readonly List<UiCameraHandleData> NormalHandleStackInternal = new List<UiCameraHandleData>();

		// Token: 0x04014E61 RID: 85601
		private readonly Dictionary<EUiCameraAnimationTargetType, UiCameraTargetType> TargetTypes = new Dictionary<EUiCameraAnimationTargetType, UiCameraTargetType>();

		// Token: 0x04014E62 RID: 85602
		private readonly HashSet<string> DynamicDisabledViewNames = new HashSet<string>();

		// Token: 0x04014E63 RID: 85603
		private int NextHandleId;

		// Token: 0x04014E68 RID: 85608
		[Nullable(2)]
		private static UiCameraModel _Instance;
	}
}
