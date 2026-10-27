using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem.Model;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020032AC RID: 12972
[UClass("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/RangeItem/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/RangeItem/TsBoxRangeItem.TsBoxRangeItem_C")]
public class TsBoxRangeItem : AKuroEffectActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x170026C4 RID: 9924
	// (get) Token: 0x0601C12F RID: 114991 RVA: 0x007CE599 File Offset: 0x007CC799
	// (set) Token: 0x0601C130 RID: 114992 RVA: 0x007CE5AD File Offset: 0x007CC7AD
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string RangeId
	{
		[NullableContext(1)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsBoxRangeItem.__PropertyOffset_RangeId)));
		}
		[NullableContext(1)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsBoxRangeItem.__PropertyOffset_RangeId)), value);
		}
	}

	// Token: 0x170026C5 RID: 9925
	// (get) Token: 0x0601C131 RID: 114993 RVA: 0x007CE5C2 File Offset: 0x007CC7C2
	// (set) Token: 0x0601C132 RID: 114994 RVA: 0x007CE5D6 File Offset: 0x007CC7D6
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UBoxComponent BoxComp
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsBoxRangeItem.__PropertyOffset_BoxComp);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsBoxRangeItem.__PropertyOffset_BoxComp, value);
		}
	}

	// Token: 0x0601C133 RID: 114995 RVA: 0x007CE5EC File Offset: 0x007CC7EC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveBeginPlay()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveBeginPlay"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601C134 RID: 114996 RVA: 0x007CE65C File Offset: 0x007CC85C
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		if (!string.IsNullOrEmpty(this.RangeId))
		{
			RangeItemModel.Instance.AddBoxRange(this.RangeId, this);
			base.SetActorTickEnabled(false);
			return;
		}
		base.SetActorTickEnabled(true);
	}

	// Token: 0x0601C135 RID: 114997 RVA: 0x007CE68C File Offset: 0x007CC88C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTick(float deltaSeconds)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AActor.__ReceiveTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AActor.__ReceiveTick_FunctionParams*)ptr + 15L / (long)sizeof(AActor.__ReceiveTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->DeltaSeconds = deltaSeconds;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601C136 RID: 114998 RVA: 0x007CE702 File Offset: 0x007CC902
	protected virtual void ReceiveTick_Implementation(float deltaSeconds)
	{
		if (!string.IsNullOrEmpty(this.RangeId))
		{
			RangeItemModel.Instance.AddBoxRange(this.RangeId, this);
			base.SetActorTickEnabled(false);
		}
	}

	// Token: 0x0601C137 RID: 114999 RVA: 0x007CE72C File Offset: 0x007CC92C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveEndPlay(EEndPlayReason endPlayReason)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveEndPlay"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AActor.__ReceiveEndPlay_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AActor.__ReceiveEndPlay_FunctionParams*)ptr + 15L / (long)sizeof(AActor.__ReceiveEndPlay_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(byte*)(&ptr2->EndPlayReason) = (byte)endPlayReason;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601C138 RID: 115000 RVA: 0x007CE7A5 File Offset: 0x007CC9A5
	protected virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		if (!string.IsNullOrEmpty(this.RangeId))
		{
			RangeItemModel.Instance.RemoveBoxRange(this.RangeId);
		}
	}

	// Token: 0x0601C139 RID: 115001 RVA: 0x007CE7C4 File Offset: 0x007CC9C4
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsBoxRangeItem._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/RangeItem/TsBoxRangeItem.TsBoxRangeItem_C");
		}
		return TsBoxRangeItem._ClassPtr;
	}

	// Token: 0x0601C13A RID: 115002 RVA: 0x007CE7E8 File Offset: 0x007CC9E8
	public TsBoxRangeItem() : this(BuiltinUtils.AllocNativeUObject(TsBoxRangeItem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601C13B RID: 115003 RVA: 0x007CE810 File Offset: 0x007CCA10
	[NullableContext(1)]
	public TsBoxRangeItem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBoxRangeItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C13C RID: 115004 RVA: 0x007CE843 File Offset: 0x007CCA43
	protected TsBoxRangeItem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C13D RID: 115005 RVA: 0x007CE84C File Offset: 0x007CCA4C
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601C13E RID: 115006 RVA: 0x007CE854 File Offset: 0x007CCA54
	protected unsafe virtual void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		this.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601C13F RID: 115007 RVA: 0x007CE864 File Offset: 0x007CCA64
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		this.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0400DDF1 RID: 56817
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/RangeItem/TsBoxRangeItem.TsBoxRangeItem_C";

	// Token: 0x0400DDF2 RID: 56818
	private static IntPtr _ClassPtr;

	// Token: 0x0400DDF3 RID: 56819
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400DDF4 RID: 56820
	private static int __PropertyOffset_RangeId;

	// Token: 0x0400DDF5 RID: 56821
	private static int __PropertyOffset_BoxComp;
}
