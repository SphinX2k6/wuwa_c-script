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

// Token: 0x020001E0 RID: 480
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyTriggerGuide.TsAnimNotifyTriggerGuide_C")]
public class TsAnimNotifyTriggerGuide : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004D7 RID: 1239
	// (get) Token: 0x06001DFB RID: 7675 RVA: 0x000965D7 File Offset: 0x000947D7
	// (set) Token: 0x06001DFC RID: 7676 RVA: 0x000965E7 File Offset: 0x000947E7
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

	// Token: 0x06001DFD RID: 7677 RVA: 0x000965F8 File Offset: 0x000947F8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_Notify"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotify.__K2_Notify_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06001DFE RID: 7678 RVA: 0x00096698 File Offset: 0x00094898
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

	// Token: 0x06001DFF RID: 7679 RVA: 0x00096768 File Offset: 0x00094968
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

	// Token: 0x06001E00 RID: 7680 RVA: 0x000967E3 File Offset: 0x000949E3
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "执行行为组事件";
	}

	// Token: 0x06001E01 RID: 7681 RVA: 0x000967EC File Offset: 0x000949EC
	private int ParseEventGroupId2GuideGroupId(int eventGroupId)
	{
		if (ConfigGuideFromMontageByEventGroupId.GetConfig(eventGroupId, true) == null)
		{
			return 0;
		}
		GuideFromMontage? guideFromMontage;
		return guideFromMontage.GetValueOrDefault().GuideGroupId;
	}

	// Token: 0x06001E02 RID: 7682 RVA: 0x0009681B File Offset: 0x00094A1B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyTriggerGuide._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyTriggerGuide.TsAnimNotifyTriggerGuide_C");
		}
		return TsAnimNotifyTriggerGuide._ClassPtr;
	}

	// Token: 0x06001E03 RID: 7683 RVA: 0x00096840 File Offset: 0x00094A40
	public TsAnimNotifyTriggerGuide() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyTriggerGuide.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001E04 RID: 7684 RVA: 0x00096868 File Offset: 0x00094A68
	[NullableContext(1)]
	public TsAnimNotifyTriggerGuide(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyTriggerGuide.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001E05 RID: 7685 RVA: 0x0009689B File Offset: 0x00094A9B
	protected TsAnimNotifyTriggerGuide(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001E06 RID: 7686 RVA: 0x000968A4 File Offset: 0x00094AA4
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001E07 RID: 7687 RVA: 0x000968D7 File Offset: 0x00094AD7
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400128D RID: 4749
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyTriggerGuide.TsAnimNotifyTriggerGuide_C";

	// Token: 0x0400128E RID: 4750
	private static IntPtr _ClassPtr;

	// Token: 0x0400128F RID: 4751
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001290 RID: 4752
	private static int __PropertyOffset_EventGroupId;
}
