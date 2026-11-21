using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Ui;
using UnrealEngine;
using UnrealEngine.Extension;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000155 RID: 341
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStatePreloadPlot.TsAnimNotifyStatePreloadPlot_C")]
public class TsAnimNotifyStatePreloadPlot : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700038B RID: 907
	// (get) Token: 0x06001596 RID: 5526 RVA: 0x00079853 File Offset: 0x00077A53
	// (set) Token: 0x06001597 RID: 5527 RVA: 0x00079867 File Offset: 0x00077A67
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string PlotName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStatePreloadPlot.__PropertyOffset_PlotName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStatePreloadPlot.__PropertyOffset_PlotName)), value);
		}
	}

	// Token: 0x1700038C RID: 908
	// (get) Token: 0x06001598 RID: 5528 RVA: 0x0007987C File Offset: 0x00077A7C
	// (set) Token: 0x06001599 RID: 5529 RVA: 0x0007988C File Offset: 0x00077A8C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 跳过UI等待
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePreloadPlot.__PropertyOffset_跳过UI等待) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePreloadPlot.__PropertyOffset_跳过UI等待) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700038D RID: 909
	// (get) Token: 0x0600159A RID: 5530 RVA: 0x0007989D File Offset: 0x00077A9D
	// (set) Token: 0x0600159B RID: 5531 RVA: 0x000798AD File Offset: 0x00077AAD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 锁定镜头状态
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePreloadPlot.__PropertyOffset_锁定镜头状态) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePreloadPlot.__PropertyOffset_锁定镜头状态) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700038E RID: 910
	// (get) Token: 0x0600159C RID: 5532 RVA: 0x000798BE File Offset: 0x00077ABE
	// (set) Token: 0x0600159D RID: 5533 RVA: 0x000798CE File Offset: 0x00077ACE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 提前隐藏战斗界面
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePreloadPlot.__PropertyOffset_提前隐藏战斗界面) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePreloadPlot.__PropertyOffset_提前隐藏战斗界面) = (value ? 1 : 0);
		}
	}

	// Token: 0x0600159E RID: 5534 RVA: 0x000798E0 File Offset: 0x00077AE0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStatePreloadPlot) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStatePreloadPlot.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyBegin_Implementation(meshComp, animation, totalDuration);
		}
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->TotalDuration = totalDuration;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0600159F RID: 5535 RVA: 0x000799A0 File Offset: 0x00077BA0
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor aactor = (meshComp != null) ? meshComp.GetOwner() : null;
		if (aactor == null)
		{
			return false;
		}
		BP_EWorldType worldType = UKuroRenderingRuntimeBPPluginBPLibrary.GetWorldType(aactor.GetWorld());
		if (worldType == BP_EWorldType.Editor || worldType == BP_EWorldType.EditorPreview)
		{
			return false;
		}
		if (this.PlotName == null || this.PlotName.Length == 0)
		{
			Log.Instance.Error(ELogModule.Plot, ELogAuthor.HYF, "TsAnimNotifyStatePreloadPlot 剧情引用未填写", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		string[] array = this.PlotName.Split(',', StringSplitOptions.None);
		if (array.Length != 3)
		{
			Log.Instance.Error(ELogModule.Plot, ELogAuthor.HYF, "TsAnimNotifyStatePreloadPlot PlotArray数量不对", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		string text = array[0];
		string text2 = array[1];
		string text3 = array[2];
		int num;
		bool flag = int.TryParse(text2, out num);
		int num2;
		bool flag2 = int.TryParse(text3, out num2);
		if (text.Length == 0 || text2.Length == 0 || text3.Length == 0 || !flag || !flag2)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "TsAnimNotifyStatePreloadPlot 不存在的播放信息";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PlotName", this.PlotName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PlotId", text2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("StateId", text3);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		this.PlotListName = text;
		this.PlotId = num;
		this.StateId = num2;
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Plot;
		ELogAuthor author2 = ELogAuthor.HYF;
		string message2 = "蒙太奇触发预加载剧情";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PlotName", this.PlotName);
		instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.Preload(text, num, num2);
		PlotModel.Instance.AnsPreloadMark = true;
		if (this.提前隐藏战斗界面)
		{
			EUiViewName mainViewName = UiModel.Instance.MainViewName;
			UiViewBase viewByName = UiManager.Instance.GetViewByName(mainViewName);
			if (viewByName != null)
			{
				viewByName.HideAsync();
			}
		}
		PlotController.Instance.RegisterOnMontageEnd(this.PlotListName, this.PlotId, this.StateId, (meshComp != null) ? meshComp.GetAnimInstance() : null);
		return true;
	}

	// Token: 0x060015A0 RID: 5536 RVA: 0x00079BAC File Offset: 0x00077DAC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStatePreloadPlot) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStatePreloadPlot.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotifyState.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x060015A1 RID: 5537 RVA: 0x00079C3C File Offset: 0x00077E3C
	protected override string GetNotifyName_Implementation()
	{
		return "无缝进演出预准备";
	}

	// Token: 0x060015A2 RID: 5538 RVA: 0x00079C44 File Offset: 0x00077E44
	private void Preload(string plotListName, int intPlotId, int intStateId)
	{
		PreloadControllerNew instance = PreloadControllerNew.Instance;
		if (instance != null)
		{
			instance.PreloadPlot(plotListName, intPlotId, intStateId, 999);
		}
		PreloadControllerNew instance2 = PreloadControllerNew.Instance;
		if (instance2 != null)
		{
			instance2.PreloadPlotUi(plotListName, intPlotId, intStateId);
		}
		if (PlotModel.Instance != null)
		{
			PlotModel.Instance.SeamlessLockState = this.锁定镜头状态;
		}
	}

	// Token: 0x060015A3 RID: 5539 RVA: 0x00079C95 File Offset: 0x00077E95
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStatePreloadPlot._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStatePreloadPlot.TsAnimNotifyStatePreloadPlot_C");
		}
		return TsAnimNotifyStatePreloadPlot._ClassPtr;
	}

	// Token: 0x060015A4 RID: 5540 RVA: 0x00079CBC File Offset: 0x00077EBC
	public TsAnimNotifyStatePreloadPlot() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStatePreloadPlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060015A5 RID: 5541 RVA: 0x00079CE4 File Offset: 0x00077EE4
	public TsAnimNotifyStatePreloadPlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStatePreloadPlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060015A6 RID: 5542 RVA: 0x00079D17 File Offset: 0x00077F17
	protected TsAnimNotifyStatePreloadPlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060015A7 RID: 5543 RVA: 0x00079D20 File Offset: 0x00077F20
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060015A8 RID: 5544 RVA: 0x00079D59 File Offset: 0x00077F59
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000F30 RID: 3888
	[Nullable(2)]
	private string PlotListName;

	// Token: 0x04000F31 RID: 3889
	private int PlotId;

	// Token: 0x04000F32 RID: 3890
	private int StateId;

	// Token: 0x04000F33 RID: 3891
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStatePreloadPlot.TsAnimNotifyStatePreloadPlot_C";

	// Token: 0x04000F34 RID: 3892
	private static IntPtr _ClassPtr;

	// Token: 0x04000F35 RID: 3893
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000F36 RID: 3894
	private static int __PropertyOffset_PlotName;

	// Token: 0x04000F37 RID: 3895
	private static int __PropertyOffset_跳过UI等待;

	// Token: 0x04000F38 RID: 3896
	private static int __PropertyOffset_锁定镜头状态;

	// Token: 0x04000F39 RID: 3897
	private static int __PropertyOffset_提前隐藏战斗界面;
}
