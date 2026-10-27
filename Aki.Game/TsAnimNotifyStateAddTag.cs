using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000109 RID: 265
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddTag.TsAnimNotifyStateAddTag_C")]
public class TsAnimNotifyStateAddTag : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700027D RID: 637
	// (get) Token: 0x06000F7D RID: 3965 RVA: 0x00059953 File Offset: 0x00057B53
	// (set) Token: 0x06000F7E RID: 3966 RVA: 0x00059967 File Offset: 0x00057B67
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag Tag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAddTag.__PropertyOffset_Tag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAddTag.__PropertyOffset_Tag) = value;
		}
	}

	// Token: 0x1700027E RID: 638
	// (get) Token: 0x06000F7F RID: 3967 RVA: 0x0005997C File Offset: 0x00057B7C
	// (set) Token: 0x06000F80 RID: 3968 RVA: 0x0005998C File Offset: 0x00057B8C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 给召唤者添加
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAddTag.__PropertyOffset_给召唤者添加) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAddTag.__PropertyOffset_给召唤者添加) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000F81 RID: 3969 RVA: 0x000599A0 File Offset: 0x00057BA0
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

	// Token: 0x06000F82 RID: 3970 RVA: 0x00059A48 File Offset: 0x00057C48
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		if (meshComp == null)
		{
			return false;
		}
		AActor owner = meshComp.GetOwner();
		int num = this.Tag.TagId();
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter != null && num != 0)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
			if (this.给召唤者添加)
			{
				long? num2;
				if (entity == null)
				{
					num2 = null;
				}
				else
				{
					CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
					num2 = ((component != null) ? new long?(component.GetSummonerId()) : null);
				}
				long? num3 = num2;
				long valueOrDefault = num3.GetValueOrDefault();
				EntityHandle entity2 = CreatureModel.Instance.GetEntity(valueOrDefault);
				entity = ((entity2 != null) ? entity2.Entity : null);
			}
			if (entity != null)
			{
				BaseTagComponent component2 = entity.GetComponent<BaseTagComponent>();
				if (component2 != null)
				{
					component2.TagContainer.UpdateExactTag(ETagChannel.Anim, num, 1);
					return true;
				}
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Test;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "No Entity for TsBaseCharacter";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", owner);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("location", owner.D_K2_GetActorLocation());
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
		else if (num != 0)
		{
			TsUiSceneRoleActor tsUiSceneRoleActor = owner as TsUiSceneRoleActor;
			if (tsUiSceneRoleActor != null)
			{
				this.UiTagAnsContext = new UiTagAnsContext(num);
				UiModelBase model = tsUiSceneRoleActor.Model;
				if (model != null)
				{
					model.CheckGetComponent<UiModelAnsControllerComponent>().AddAns<UiTagAnsContext>("UiTagAnsContext", this.UiTagAnsContext);
				}
			}
		}
		return false;
	}

	// Token: 0x06000F83 RID: 3971 RVA: 0x00059BB4 File Offset: 0x00057DB4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyEnd"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L);
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

	// Token: 0x06000F84 RID: 3972 RVA: 0x00059C54 File Offset: 0x00057E54
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (meshComp == null)
		{
			return false;
		}
		AActor owner = meshComp.GetOwner();
		int num = this.Tag.TagId();
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter != null && num != 0)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
			if (this.给召唤者添加)
			{
				long? num2;
				if (entity == null)
				{
					num2 = null;
				}
				else
				{
					CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
					num2 = ((component != null) ? new long?(component.GetSummonerId()) : null);
				}
				long? num3 = num2;
				long valueOrDefault = num3.GetValueOrDefault();
				EntityHandle entity2 = CreatureModel.Instance.GetEntity(valueOrDefault);
				entity = ((entity2 != null) ? entity2.Entity : null);
			}
			if (entity != null)
			{
				BaseTagComponent component2 = entity.GetComponent<BaseTagComponent>();
				if (component2 != null)
				{
					component2.TagContainer.UpdateExactTag(ETagChannel.Anim, num, -1);
					return true;
				}
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Test;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "No Entity for TsBaseCharacter";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", owner);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("location", owner.D_K2_GetActorLocation());
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
		else if (this.UiTagAnsContext != null)
		{
			TsUiSceneRoleActor tsUiSceneRoleActor = owner as TsUiSceneRoleActor;
			if (tsUiSceneRoleActor != null)
			{
				UiModelBase model = tsUiSceneRoleActor.Model;
				if (model != null)
				{
					model.CheckGetComponent<UiModelAnsControllerComponent>().ReduceAns<UiTagAnsContext>("UiTagAnsContext", this.UiTagAnsContext);
				}
			}
		}
		return false;
	}

	// Token: 0x06000F85 RID: 3973 RVA: 0x00059DB8 File Offset: 0x00057FB8
	[NullableContext(1)]
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

	// Token: 0x06000F86 RID: 3974 RVA: 0x00059E33 File Offset: 0x00058033
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "添加TAG";
	}

	// Token: 0x06000F87 RID: 3975 RVA: 0x00059E3A File Offset: 0x0005803A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAddTag._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddTag.TsAnimNotifyStateAddTag_C");
		}
		return TsAnimNotifyStateAddTag._ClassPtr;
	}

	// Token: 0x06000F88 RID: 3976 RVA: 0x00059E60 File Offset: 0x00058060
	public TsAnimNotifyStateAddTag() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddTag.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000F89 RID: 3977 RVA: 0x00059E88 File Offset: 0x00058088
	[NullableContext(1)]
	public TsAnimNotifyStateAddTag(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000F8A RID: 3978 RVA: 0x00059EBB File Offset: 0x000580BB
	protected TsAnimNotifyStateAddTag(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000F8B RID: 3979 RVA: 0x00059EC4 File Offset: 0x000580C4
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06000F8C RID: 3980 RVA: 0x00059F00 File Offset: 0x00058100
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000F8D RID: 3981 RVA: 0x00059F33 File Offset: 0x00058133
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000C27 RID: 3111
	[Nullable(2)]
	private UiTagAnsContext UiTagAnsContext;

	// Token: 0x04000C28 RID: 3112
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddTag.TsAnimNotifyStateAddTag_C";

	// Token: 0x04000C29 RID: 3113
	private static IntPtr _ClassPtr;

	// Token: 0x04000C2A RID: 3114
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C2B RID: 3115
	private static int __PropertyOffset_Tag;

	// Token: 0x04000C2C RID: 3116
	private static int __PropertyOffset_给召唤者添加;
}
