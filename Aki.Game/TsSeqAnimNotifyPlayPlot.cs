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

// Token: 0x020001E9 RID: 489
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsSeqAnimNotifyPlayPlot.TsSeqAnimNotifyPlayPlot_C")]
public class TsSeqAnimNotifyPlayPlot : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004F0 RID: 1264
	// (get) Token: 0x06001E85 RID: 7813 RVA: 0x00098637 File Offset: 0x00096837
	// (set) Token: 0x06001E86 RID: 7814 RVA: 0x0009864B File Offset: 0x0009684B
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

	// Token: 0x06001E87 RID: 7815 RVA: 0x00098660 File Offset: 0x00096860
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotify.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotify.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L);
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

	// Token: 0x06001E88 RID: 7816 RVA: 0x000986DB File Offset: 0x000968DB
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "播客户端剧情";
	}

	// Token: 0x06001E89 RID: 7817 RVA: 0x000986E4 File Offset: 0x000968E4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComponent, UAnimSequenceBase animSequence)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_Notify"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotify.__K2_Notify_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComponent != null) ? meshComponent.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animSequence != null) ? animSequence.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06001E8A RID: 7818 RVA: 0x00098784 File Offset: 0x00096984
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

	// Token: 0x06001E8B RID: 7819 RVA: 0x000988E7 File Offset: 0x00096AE7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSeqAnimNotifyPlayPlot._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsSeqAnimNotifyPlayPlot.TsSeqAnimNotifyPlayPlot_C");
		}
		return TsSeqAnimNotifyPlayPlot._ClassPtr;
	}

	// Token: 0x06001E8C RID: 7820 RVA: 0x0009890C File Offset: 0x00096B0C
	public TsSeqAnimNotifyPlayPlot() : this(BuiltinUtils.AllocNativeUObject(TsSeqAnimNotifyPlayPlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001E8D RID: 7821 RVA: 0x00098934 File Offset: 0x00096B34
	[NullableContext(1)]
	public TsSeqAnimNotifyPlayPlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSeqAnimNotifyPlayPlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001E8E RID: 7822 RVA: 0x00098967 File Offset: 0x00096B67
	protected TsSeqAnimNotifyPlayPlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001E8F RID: 7823 RVA: 0x00098970 File Offset: 0x00096B70
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x06001E90 RID: 7824 RVA: 0x00098984 File Offset: 0x00096B84
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040012CC RID: 4812
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsSeqAnimNotifyPlayPlot.TsSeqAnimNotifyPlayPlot_C";

	// Token: 0x040012CD RID: 4813
	private static IntPtr _ClassPtr;

	// Token: 0x040012CE RID: 4814
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040012CF RID: 4815
	private static int __PropertyOffset_PlotName;
}
