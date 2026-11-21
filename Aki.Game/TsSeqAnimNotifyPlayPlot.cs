using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.Flow;
using UnrealEngine;
using UnrealEngine.Extension;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001ED RID: 493
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsSeqAnimNotifyPlayPlot.TsSeqAnimNotifyPlayPlot_C")]
public class TsSeqAnimNotifyPlayPlot : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000512 RID: 1298
	// (get) Token: 0x06001F22 RID: 7970 RVA: 0x0009F787 File Offset: 0x0009D987
	// (set) Token: 0x06001F23 RID: 7971 RVA: 0x0009F79B File Offset: 0x0009D99B
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string PlotName
	{
		[NullableContext(2)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsSeqAnimNotifyPlayPlot.__PropertyOffset_PlotName)));
		}
		[NullableContext(2)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsSeqAnimNotifyPlayPlot.__PropertyOffset_PlotName)), value);
		}
	}

	// Token: 0x06001F24 RID: 7972 RVA: 0x0009F7B0 File Offset: 0x0009D9B0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsSeqAnimNotifyPlayPlot) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsSeqAnimNotifyPlayPlot.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotify.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotify.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06001F25 RID: 7973 RVA: 0x0009F840 File Offset: 0x0009DA40
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "播客户端剧情";
	}

	// Token: 0x06001F26 RID: 7974 RVA: 0x0009F848 File Offset: 0x0009DA48
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComponent, UAnimSequenceBase animSequence)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsSeqAnimNotifyPlayPlot) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsSeqAnimNotifyPlayPlot.StaticClass(), out intPtr, out num))
		{
			return this.K2_Notify_Implementation(meshComponent, animSequence);
		}
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_Notify_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComponent != null) ? meshComponent.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animSequence != null) ? animSequence.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001F27 RID: 7975 RVA: 0x0009F900 File Offset: 0x0009DB00
	[NullableContext(2)]
	protected unsafe virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComponent, UAnimSequenceBase animSequence)
	{
		AActor aactor = (meshComponent != null) ? meshComponent.GetOwner() : null;
		if (aactor == null)
		{
			return false;
		}
		BP_EWorldType worldType = UKuroRenderingRuntimeBPPluginBPLibrary.GetWorldType(aactor.GetWorld());
		bool flag = worldType == BP_EWorldType.Editor || worldType == BP_EWorldType.EditorPreview;
		if (flag)
		{
			return false;
		}
		if (this.PlotName == null)
		{
			Log.Instance.Error(ELogModule.Plot, ELogAuthor.JYS, "TsSeqAnimNotifyPlayPlot 不存在的PlotName播放信息", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		string[] array = this.PlotName.Split(',', StringSplitOptions.None);
		if (array == null || array.Length != 3)
		{
			Log.Instance.Error(ELogModule.Plot, ELogAuthor.JYS, "TsSeqAnimNotifyPlayPlot PlotArray数量不对", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		string text = array[0];
		string text2 = array[1];
		string text3 = array[2];
		if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2) || string.IsNullOrEmpty(text3))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.JYS;
			string message = "TsSeqAnimNotifyPlayPlot 不存在的播放信息";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("this.PlotName", text);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("this.PlotId", text2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("this.StateId", text3);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		FlowController.Instance.StartFlowForView(text, int.Parse(text2), int.Parse(text3), new UiParam
		{
			AudioAttachActor = meshComponent.GetOwner()
		}, false);
		return true;
	}

	// Token: 0x06001F28 RID: 7976 RVA: 0x0009FA63 File Offset: 0x0009DC63
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSeqAnimNotifyPlayPlot._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsSeqAnimNotifyPlayPlot.TsSeqAnimNotifyPlayPlot_C");
		}
		return TsSeqAnimNotifyPlayPlot._ClassPtr;
	}

	// Token: 0x06001F29 RID: 7977 RVA: 0x0009FA88 File Offset: 0x0009DC88
	public TsSeqAnimNotifyPlayPlot() : this(BuiltinUtils.AllocNativeUObject(TsSeqAnimNotifyPlayPlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001F2A RID: 7978 RVA: 0x0009FAB0 File Offset: 0x0009DCB0
	[NullableContext(1)]
	public TsSeqAnimNotifyPlayPlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSeqAnimNotifyPlayPlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001F2B RID: 7979 RVA: 0x0009FAE3 File Offset: 0x0009DCE3
	protected TsSeqAnimNotifyPlayPlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001F2C RID: 7980 RVA: 0x0009FAEC File Offset: 0x0009DCEC
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x06001F2D RID: 7981 RVA: 0x0009FB00 File Offset: 0x0009DD00
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400130F RID: 4879
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsSeqAnimNotifyPlayPlot.TsSeqAnimNotifyPlayPlot_C";

	// Token: 0x04001310 RID: 4880
	private static IntPtr _ClassPtr;

	// Token: 0x04001311 RID: 4881
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001312 RID: 4882
	private static int __PropertyOffset_PlotName;
}
