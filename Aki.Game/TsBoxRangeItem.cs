using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem.Model;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200281D RID: 10269
[UClass("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/RangeItem/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/RangeItem/TsBoxRangeItem.TsBoxRangeItem_C")]
public class TsBoxRangeItem : AKuroEffectActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x170029A8 RID: 10664
	// (get) Token: 0x06019D67 RID: 105831 RVA: 0x007F5769 File Offset: 0x007F3969
	// (set) Token: 0x06019D68 RID: 105832 RVA: 0x007F577D File Offset: 0x007F397D
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

	// Token: 0x170029A9 RID: 10665
	// (get) Token: 0x06019D69 RID: 105833 RVA: 0x007F5792 File Offset: 0x007F3992
	// (set) Token: 0x06019D6A RID: 105834 RVA: 0x007F57A6 File Offset: 0x007F39A6
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

	// Token: 0x06019D6B RID: 105835 RVA: 0x007F57BC File Offset: 0x007F39BC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void ReceiveBeginPlay()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsBoxRangeItem) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveBeginPlay"), TsBoxRangeItem.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ReceiveBeginPlay_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06019D6C RID: 105836 RVA: 0x007F5815 File Offset: 0x007F3A15
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

	// Token: 0x06019D6D RID: 105837 RVA: 0x007F5844 File Offset: 0x007F3A44
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTick(float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBoxRangeItem) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTick"), TsBoxRangeItem.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTick_Implementation(deltaSeconds);
			return;
		}
		AActor.__ReceiveTick_FunctionParams* ptr = stackalloc AActor.__ReceiveTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AActor.__ReceiveTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06019D6E RID: 105838 RVA: 0x007F58D0 File Offset: 0x007F3AD0
	protected virtual void ReceiveTick_Implementation(float deltaSeconds)
	{
		if (!string.IsNullOrEmpty(this.RangeId))
		{
			RangeItemModel.Instance.AddBoxRange(this.RangeId, this);
			base.SetActorTickEnabled(false);
		}
	}

	// Token: 0x06019D6F RID: 105839 RVA: 0x007F58F8 File Offset: 0x007F3AF8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveEndPlay(EEndPlayReason endPlayReason)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBoxRangeItem) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveEndPlay"), TsBoxRangeItem.StaticClass(), out intPtr, out num))
		{
			this.ReceiveEndPlay_Implementation(endPlayReason);
			return;
		}
		AActor.__ReceiveEndPlay_FunctionParams* ptr = stackalloc AActor.__ReceiveEndPlay_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AActor.__ReceiveEndPlay_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(byte*)(&ptr->EndPlayReason) = (byte)endPlayReason;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06019D70 RID: 105840 RVA: 0x007F5987 File Offset: 0x007F3B87
	protected virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		if (!string.IsNullOrEmpty(this.RangeId))
		{
			RangeItemModel.Instance.RemoveBoxRange(this.RangeId);
		}
	}

	// Token: 0x06019D71 RID: 105841 RVA: 0x007F59A6 File Offset: 0x007F3BA6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsBoxRangeItem._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/RangeItem/TsBoxRangeItem.TsBoxRangeItem_C");
		}
		return TsBoxRangeItem._ClassPtr;
	}

	// Token: 0x06019D72 RID: 105842 RVA: 0x007F59CC File Offset: 0x007F3BCC
	public TsBoxRangeItem() : this(BuiltinUtils.AllocNativeUObject(TsBoxRangeItem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06019D73 RID: 105843 RVA: 0x007F59F4 File Offset: 0x007F3BF4
	[NullableContext(1)]
	public TsBoxRangeItem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBoxRangeItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06019D74 RID: 105844 RVA: 0x007F5A27 File Offset: 0x007F3C27
	protected TsBoxRangeItem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06019D75 RID: 105845 RVA: 0x007F5A30 File Offset: 0x007F3C30
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x06019D76 RID: 105846 RVA: 0x007F5A38 File Offset: 0x007F3C38
	protected unsafe virtual void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		this.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x06019D77 RID: 105847 RVA: 0x007F5A48 File Offset: 0x007F3C48
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		this.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0400E297 RID: 58007
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/RangeItem/TsBoxRangeItem.TsBoxRangeItem_C";

	// Token: 0x0400E298 RID: 58008
	private static IntPtr _ClassPtr;

	// Token: 0x0400E299 RID: 58009
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E29A RID: 58010
	private static int __PropertyOffset_RangeId;

	// Token: 0x0400E29B RID: 58011
	private static int __PropertyOffset_BoxComp;
}
