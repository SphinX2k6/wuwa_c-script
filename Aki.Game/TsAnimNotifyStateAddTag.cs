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
	// Token: 0x17000280 RID: 640
	// (get) Token: 0x06000F83 RID: 3971 RVA: 0x0005A9D7 File Offset: 0x00058BD7
	// (set) Token: 0x06000F84 RID: 3972 RVA: 0x0005A9EB File Offset: 0x00058BEB
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

	// Token: 0x17000281 RID: 641
	// (get) Token: 0x06000F85 RID: 3973 RVA: 0x0005AA00 File Offset: 0x00058C00
	// (set) Token: 0x06000F86 RID: 3974 RVA: 0x0005AA10 File Offset: 0x00058C10
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

	// Token: 0x06000F87 RID: 3975 RVA: 0x0005AA24 File Offset: 0x00058C24
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAddTag) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateAddTag.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000F88 RID: 3976 RVA: 0x0005AAE4 File Offset: 0x00058CE4
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
					model.CheckGetComponent<UiModelAnsControllerComponent>().AddAns(this.UiTagAnsContext);
				}
			}
		}
		return false;
	}

	// Token: 0x06000F89 RID: 3977 RVA: 0x0005AC4C File Offset: 0x00058E4C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAddTag) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateAddTag.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyEnd_Implementation(meshComp, animation);
		}
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06000F8A RID: 3978 RVA: 0x0005AD04 File Offset: 0x00058F04
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
					model.CheckGetComponent<UiModelAnsControllerComponent>().ReduceAns(this.UiTagAnsContext);
				}
			}
		}
		return false;
	}

	// Token: 0x06000F8B RID: 3979 RVA: 0x0005AE64 File Offset: 0x00059064
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAddTag) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateAddTag.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000F8C RID: 3980 RVA: 0x0005AEF4 File Offset: 0x000590F4
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "添加TAG";
	}

	// Token: 0x06000F8D RID: 3981 RVA: 0x0005AEFB File Offset: 0x000590FB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAddTag._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddTag.TsAnimNotifyStateAddTag_C");
		}
		return TsAnimNotifyStateAddTag._ClassPtr;
	}

	// Token: 0x06000F8E RID: 3982 RVA: 0x0005AF20 File Offset: 0x00059120
	public TsAnimNotifyStateAddTag() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddTag.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000F8F RID: 3983 RVA: 0x0005AF48 File Offset: 0x00059148
	[NullableContext(1)]
	public TsAnimNotifyStateAddTag(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000F90 RID: 3984 RVA: 0x0005AF7B File Offset: 0x0005917B
	protected TsAnimNotifyStateAddTag(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000F91 RID: 3985 RVA: 0x0005AF84 File Offset: 0x00059184
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06000F92 RID: 3986 RVA: 0x0005AFC0 File Offset: 0x000591C0
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000F93 RID: 3987 RVA: 0x0005AFF3 File Offset: 0x000591F3
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000C2F RID: 3119
	[Nullable(2)]
	private UiTagAnsContext UiTagAnsContext;

	// Token: 0x04000C30 RID: 3120
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddTag.TsAnimNotifyStateAddTag_C";

	// Token: 0x04000C31 RID: 3121
	private static IntPtr _ClassPtr;

	// Token: 0x04000C32 RID: 3122
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C33 RID: 3123
	private static int __PropertyOffset_Tag;

	// Token: 0x04000C34 RID: 3124
	private static int __PropertyOffset_给召唤者添加;
}
