using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000198 RID: 408
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBounce.TsAnimNotifyBounce_C")]
public class TsAnimNotifyBounce : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000436 RID: 1078
	// (get) Token: 0x060019F5 RID: 6645 RVA: 0x00088867 File Offset: 0x00086A67
	// (set) Token: 0x060019F6 RID: 6646 RVA: 0x00088877 File Offset: 0x00086A77
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Time
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyBounce.__PropertyOffset_Time);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyBounce.__PropertyOffset_Time) = value;
		}
	}

	// Token: 0x17000437 RID: 1079
	// (get) Token: 0x060019F7 RID: 6647 RVA: 0x00088888 File Offset: 0x00086A88
	// (set) Token: 0x060019F8 RID: 6648 RVA: 0x00088898 File Offset: 0x00086A98
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Height
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyBounce.__PropertyOffset_Height);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyBounce.__PropertyOffset_Height) = value;
		}
	}

	// Token: 0x17000438 RID: 1080
	// (get) Token: 0x060019F9 RID: 6649 RVA: 0x000888AC File Offset: 0x00086AAC
	// (set) Token: 0x060019FA RID: 6650 RVA: 0x000888E5 File Offset: 0x00086AE5
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UCurveFloat> MotionCurve
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UCurveFloat> result;
			if ((result = this._MotionCurve) == null)
			{
				result = (this._MotionCurve = new TSoftObjectPtr<UCurveFloat>(base.NativePtr + (IntPtr)TsAnimNotifyBounce.__PropertyOffset_MotionCurve, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsAnimNotifyBounce.__PropertyOffset_MotionCurve, 1);
		}
	}

	// Token: 0x060019FB RID: 6651 RVA: 0x0008890C File Offset: 0x00086B0C
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

	// Token: 0x060019FC RID: 6652 RVA: 0x000889AC File Offset: 0x00086BAC
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return true;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		CharacterActionComponent characterActionComponent = (entity != null) ? entity.GetComponent<CharacterActionComponent>() : null;
		CharacterCatapultComponent characterCatapultComponent = (entity != null) ? entity.GetComponent<CharacterCatapultComponent>() : null;
		if (characterActionComponent == null || characterCatapultComponent == null)
		{
			return true;
		}
		TSoftObjectPtr<UCurveFloat> motionCurve = this.MotionCurve;
		string curvePath = ((motionCurve != null) ? motionCurve.ToAssetPathName() : null) ?? "";
		characterActionComponent.StartBounceFromAns(this.Time, this.Height, curvePath);
		characterCatapultComponent.StartCatapult();
		return true;
	}

	// Token: 0x060019FD RID: 6653 RVA: 0x00088A3C File Offset: 0x00086C3C
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

	// Token: 0x060019FE RID: 6654 RVA: 0x00088AB7 File Offset: 0x00086CB7
	protected override string GetNotifyName_Implementation()
	{
		return "弹射运动";
	}

	// Token: 0x060019FF RID: 6655 RVA: 0x00088ABE File Offset: 0x00086CBE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyBounce._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBounce.TsAnimNotifyBounce_C");
		}
		return TsAnimNotifyBounce._ClassPtr;
	}

	// Token: 0x06001A00 RID: 6656 RVA: 0x00088AE4 File Offset: 0x00086CE4
	public TsAnimNotifyBounce() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBounce.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001A01 RID: 6657 RVA: 0x00088B0C File Offset: 0x00086D0C
	public TsAnimNotifyBounce(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBounce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001A02 RID: 6658 RVA: 0x00088B3F File Offset: 0x00086D3F
	protected TsAnimNotifyBounce(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001A03 RID: 6659 RVA: 0x00088B48 File Offset: 0x00086D48
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001A04 RID: 6660 RVA: 0x00088B7B File Offset: 0x00086D7B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040010F5 RID: 4341
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBounce.TsAnimNotifyBounce_C";

	// Token: 0x040010F6 RID: 4342
	private static IntPtr _ClassPtr;

	// Token: 0x040010F7 RID: 4343
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040010F8 RID: 4344
	private static int __PropertyOffset_Time;

	// Token: 0x040010F9 RID: 4345
	private static int __PropertyOffset_Height;

	// Token: 0x040010FA RID: 4346
	private static int __PropertyOffset_MotionCurve;

	// Token: 0x040010FB RID: 4347
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UCurveFloat> _MotionCurve;
}
