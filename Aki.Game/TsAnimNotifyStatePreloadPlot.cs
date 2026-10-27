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

// Token: 0x02000151 RID: 337
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStatePreloadPlot.TsAnimNotifyStatePreloadPlot_C")]
public class TsAnimNotifyStatePreloadPlot : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000369 RID: 873
	// (get) Token: 0x060014F9 RID: 5369 RVA: 0x00074363 File Offset: 0x00072563
	// (set) Token: 0x060014FA RID: 5370 RVA: 0x00074377 File Offset: 0x00072577
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

	// Token: 0x1700036A RID: 874
	// (get) Token: 0x060014FB RID: 5371 RVA: 0x0007438C File Offset: 0x0007258C
	// (set) Token: 0x060014FC RID: 5372 RVA: 0x0007439C File Offset: 0x0007259C
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

	// Token: 0x1700036B RID: 875
	// (get) Token: 0x060014FD RID: 5373 RVA: 0x000743AD File Offset: 0x000725AD
	// (set) Token: 0x060014FE RID: 5374 RVA: 0x000743BD File Offset: 0x000725BD
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

	// Token: 0x1700036C RID: 876
	// (get) Token: 0x060014FF RID: 5375 RVA: 0x000743CE File Offset: 0x000725CE
	// (set) Token: 0x06001500 RID: 5376 RVA: 0x000743DE File Offset: 0x000725DE
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

	// Token: 0x06001501 RID: 5377 RVA: 0x000743F0 File Offset: 0x000725F0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyBegin"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->TotalDuration = totalDuration;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06001502 RID: 5378 RVA: 0x00074498 File Offset: 0x00072698
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

	// Token: 0x06001503 RID: 5379 RVA: 0x000746A4 File Offset: 0x000728A4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotifyState.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x06001504 RID: 5380 RVA: 0x0007471F File Offset: 0x0007291F
	protected override string GetNotifyName_Implementation()
	{
		return "无缝进演出预准备";
	}

	// Token: 0x06001505 RID: 5381 RVA: 0x00074728 File Offset: 0x00072928
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

	// Token: 0x06001506 RID: 5382 RVA: 0x00074779 File Offset: 0x00072979
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStatePreloadPlot._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStatePreloadPlot.TsAnimNotifyStatePreloadPlot_C");
		}
		return TsAnimNotifyStatePreloadPlot._ClassPtr;
	}

	// Token: 0x06001507 RID: 5383 RVA: 0x000747A0 File Offset: 0x000729A0
	public TsAnimNotifyStatePreloadPlot() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStatePreloadPlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001508 RID: 5384 RVA: 0x000747C8 File Offset: 0x000729C8
	public TsAnimNotifyStatePreloadPlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStatePreloadPlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001509 RID: 5385 RVA: 0x000747FB File Offset: 0x000729FB
	protected TsAnimNotifyStatePreloadPlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600150A RID: 5386 RVA: 0x00074804 File Offset: 0x00072A04
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600150B RID: 5387 RVA: 0x0007483D File Offset: 0x00072A3D
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000EED RID: 3821
	[Nullable(2)]
	private string PlotListName;

	// Token: 0x04000EEE RID: 3822
	private int PlotId;

	// Token: 0x04000EEF RID: 3823
	private int StateId;

	// Token: 0x04000EF0 RID: 3824
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStatePreloadPlot.TsAnimNotifyStatePreloadPlot_C";

	// Token: 0x04000EF1 RID: 3825
	private static IntPtr _ClassPtr;

	// Token: 0x04000EF2 RID: 3826
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000EF3 RID: 3827
	private static int __PropertyOffset_PlotName;

	// Token: 0x04000EF4 RID: 3828
	private static int __PropertyOffset_跳过UI等待;

	// Token: 0x04000EF5 RID: 3829
	private static int __PropertyOffset_锁定镜头状态;

	// Token: 0x04000EF6 RID: 3830
	private static int __PropertyOffset_提前隐藏战斗界面;
}
