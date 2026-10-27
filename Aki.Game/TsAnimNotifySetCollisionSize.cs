using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001D5 RID: 469
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySetCollisionSize.TsAnimNotifySetCollisionSize_C")]
public class TsAnimNotifySetCollisionSize : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004AF RID: 1199
	// (get) Token: 0x06001D3D RID: 7485 RVA: 0x00093C5B File Offset: 0x00091E5B
	// (set) Token: 0x06001D3E RID: 7486 RVA: 0x00093C6B File Offset: 0x00091E6B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Radius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySetCollisionSize.__PropertyOffset_Radius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySetCollisionSize.__PropertyOffset_Radius) = value;
		}
	}

	// Token: 0x170004B0 RID: 1200
	// (get) Token: 0x06001D3F RID: 7487 RVA: 0x00093C7C File Offset: 0x00091E7C
	// (set) Token: 0x06001D40 RID: 7488 RVA: 0x00093C8C File Offset: 0x00091E8C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float HalfHeight
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySetCollisionSize.__PropertyOffset_HalfHeight);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySetCollisionSize.__PropertyOffset_HalfHeight) = value;
		}
	}

	// Token: 0x06001D41 RID: 7489 RVA: 0x00093CA0 File Offset: 0x00091EA0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_Notify"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotify.__K2_Notify_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((MeshComp != null) ? MeshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((Animation != null) ? Animation.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06001D42 RID: 7490 RVA: 0x00093D40 File Offset: 0x00091F40
	[NullableContext(2)]
	protected unsafe virtual bool K2_Notify_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
	{
		AActor owner = MeshComp.GetOwner();
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		if (this.HalfHeight <= 0f || this.Radius <= 0f)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CH;
			string message = "TsAnimNotifySetCollisionSize配置了错误的大小。为避免穿墙，必须大于0";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", owner);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("HalfHeight", this.HalfHeight);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Radius", this.Radius);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		tsBaseCharacter.CharacterActorComponent.SetRadiusAndHalfHeight(this.Radius, this.HalfHeight, false, false);
		return true;
	}

	// Token: 0x06001D43 RID: 7491 RVA: 0x00093E14 File Offset: 0x00092014
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

	// Token: 0x06001D44 RID: 7492 RVA: 0x00093E8F File Offset: 0x0009208F
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置碰撞大小";
	}

	// Token: 0x06001D45 RID: 7493 RVA: 0x00093E96 File Offset: 0x00092096
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifySetCollisionSize._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySetCollisionSize.TsAnimNotifySetCollisionSize_C");
		}
		return TsAnimNotifySetCollisionSize._ClassPtr;
	}

	// Token: 0x06001D46 RID: 7494 RVA: 0x00093EBC File Offset: 0x000920BC
	public TsAnimNotifySetCollisionSize() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySetCollisionSize.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001D47 RID: 7495 RVA: 0x00093EE4 File Offset: 0x000920E4
	[NullableContext(1)]
	public TsAnimNotifySetCollisionSize(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySetCollisionSize.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001D48 RID: 7496 RVA: 0x00093F17 File Offset: 0x00092117
	protected TsAnimNotifySetCollisionSize(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001D49 RID: 7497 RVA: 0x00093F20 File Offset: 0x00092120
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001D4A RID: 7498 RVA: 0x00093F53 File Offset: 0x00092153
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400123A RID: 4666
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySetCollisionSize.TsAnimNotifySetCollisionSize_C";

	// Token: 0x0400123B RID: 4667
	private static IntPtr _ClassPtr;

	// Token: 0x0400123C RID: 4668
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400123D RID: 4669
	private static int __PropertyOffset_Radius;

	// Token: 0x0400123E RID: 4670
	private static int __PropertyOffset_HalfHeight;
}
