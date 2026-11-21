using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001E4 RID: 484
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyTriggerGuide.TsAnimNotifyTriggerGuide_C")]
public class TsAnimNotifyTriggerGuide : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004F9 RID: 1273
	// (get) Token: 0x06001E98 RID: 7832 RVA: 0x0009D5EB File Offset: 0x0009B7EB
	// (set) Token: 0x06001E99 RID: 7833 RVA: 0x0009D5FB File Offset: 0x0009B7FB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int EventGroupId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyTriggerGuide.__PropertyOffset_EventGroupId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyTriggerGuide.__PropertyOffset_EventGroupId) = value;
		}
	}

	// Token: 0x06001E9A RID: 7834 RVA: 0x0009D60C File Offset: 0x0009B80C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyTriggerGuide) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyTriggerGuide.StaticClass(), out intPtr, out num))
		{
			return this.K2_Notify_Implementation(meshComp, animation);
		}
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_Notify_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001E9B RID: 7835 RVA: 0x0009D6C4 File Offset: 0x0009B8C4
	[NullableContext(2)]
	protected unsafe virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num = this.ParseEventGroupId2GuideGroupId(this.EventGroupId);
		GuideTrigger @params = new GuideTrigger
		{
			Type = EGuideTriggerType.BeginnerGuide,
			GuideId = num
		};
		List<ActionInfo> actions = new List<ActionInfo>
		{
			new ActionInfo
			{
				Name = EAction.GuideTrigger,
				Params = @params
			}
		};
		LevelGeneralController.Instance.ExecuteActionsNew(actions, EntityContext.Create(0, null), null);
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Guide;
		ELogAuthor author = ELogAuthor.WZ;
		string message = "由蒙太奇触发的引导";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EventGroupId", this.EventGroupId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("GuideGroupId", num);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return true;
	}

	// Token: 0x06001E9C RID: 7836 RVA: 0x0009D794 File Offset: 0x0009B994
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyTriggerGuide) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyTriggerGuide.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001E9D RID: 7837 RVA: 0x0009D824 File Offset: 0x0009BA24
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "执行行为组事件";
	}

	// Token: 0x06001E9E RID: 7838 RVA: 0x0009D82C File Offset: 0x0009BA2C
	private int ParseEventGroupId2GuideGroupId(int eventGroupId)
	{
		if (ConfigGuideFromMontageByEventGroupId.GetConfig(eventGroupId, true) == null)
		{
			return 0;
		}
		GuideFromMontage? guideFromMontage;
		return guideFromMontage.GetValueOrDefault().GuideGroupId;
	}

	// Token: 0x06001E9F RID: 7839 RVA: 0x0009D85B File Offset: 0x0009BA5B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyTriggerGuide._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyTriggerGuide.TsAnimNotifyTriggerGuide_C");
		}
		return TsAnimNotifyTriggerGuide._ClassPtr;
	}

	// Token: 0x06001EA0 RID: 7840 RVA: 0x0009D880 File Offset: 0x0009BA80
	public TsAnimNotifyTriggerGuide() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyTriggerGuide.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001EA1 RID: 7841 RVA: 0x0009D8A8 File Offset: 0x0009BAA8
	[NullableContext(1)]
	public TsAnimNotifyTriggerGuide(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyTriggerGuide.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001EA2 RID: 7842 RVA: 0x0009D8DB File Offset: 0x0009BADB
	protected TsAnimNotifyTriggerGuide(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001EA3 RID: 7843 RVA: 0x0009D8E4 File Offset: 0x0009BAE4
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001EA4 RID: 7844 RVA: 0x0009D917 File Offset: 0x0009BB17
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040012D0 RID: 4816
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyTriggerGuide.TsAnimNotifyTriggerGuide_C";

	// Token: 0x040012D1 RID: 4817
	private static IntPtr _ClassPtr;

	// Token: 0x040012D2 RID: 4818
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040012D3 RID: 4819
	private static int __PropertyOffset_EventGroupId;
}
