using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200281A RID: 10266
[UClass("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/BaseItem/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/BaseItem/TsBaseItem.TsBaseItem_C")]
public class TsBaseItem : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x06019D4A RID: 105802 RVA: 0x007F50EC File Offset: 0x007F32EC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void ReceiveBeginPlay()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsBaseItem) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveBeginPlay"), TsBaseItem.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ReceiveBeginPlay_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06019D4B RID: 105803 RVA: 0x007F5145 File Offset: 0x007F3345
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		this.EntityHandle = ActorUtils.GetEntityByActor(this, true);
		this.DebugComp = this.EntityHandle.Entity.GetComponent<SceneItemDebugComponent>();
	}

	// Token: 0x06019D4C RID: 105804 RVA: 0x007F516C File Offset: 0x007F336C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual string GetTagDebugStrings()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBaseItem) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetTagDebugStrings"), TsBaseItem.StaticClass(), out intPtr, out num))
		{
			return this.GetTagDebugStrings_Implementation();
		}
		TsBaseItem.__GetTagDebugStrings_FunctionParams* ptr = stackalloc TsBaseItem.__GetTagDebugStrings_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsBaseItem.__GetTagDebugStrings_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06019D4D RID: 105805 RVA: 0x007F51FC File Offset: 0x007F33FC
	[NullableContext(1)]
	protected string GetTagDebugStrings_Implementation()
	{
		return this.DebugComp.GetTagDebugStrings();
	}

	// Token: 0x06019D4E RID: 105806 RVA: 0x007F5209 File Offset: 0x007F3409
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsBaseItem._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/BaseItem/TsBaseItem.TsBaseItem_C");
		}
		return TsBaseItem._ClassPtr;
	}

	// Token: 0x06019D4F RID: 105807 RVA: 0x007F5230 File Offset: 0x007F3430
	public TsBaseItem() : this(BuiltinUtils.AllocNativeUObject(TsBaseItem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06019D50 RID: 105808 RVA: 0x007F5258 File Offset: 0x007F3458
	[NullableContext(1)]
	public TsBaseItem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBaseItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06019D51 RID: 105809 RVA: 0x007F528B File Offset: 0x007F348B
	protected TsBaseItem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x170029A6 RID: 10662
	// (get) Token: 0x06019D52 RID: 105810 RVA: 0x007F5294 File Offset: 0x007F3494
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseItem.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x06019D53 RID: 105811 RVA: 0x007F52A8 File Offset: 0x007F34A8
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x06019D54 RID: 105812 RVA: 0x007F52B0 File Offset: 0x007F34B0
	protected unsafe virtual void __CPPCALL_GetTagDebugStrings_Implementation(TsBaseItem.__GetTagDebugStrings_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetTagDebugStrings_Implementation());
	}

	// Token: 0x0400E284 RID: 57988
	[Nullable(2)]
	public EntityHandle EntityHandle;

	// Token: 0x0400E285 RID: 57989
	[Nullable(2)]
	private SceneItemDebugComponent DebugComp;

	// Token: 0x0400E286 RID: 57990
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/BaseItem/TsBaseItem.TsBaseItem_C";

	// Token: 0x0400E287 RID: 57991
	private static IntPtr _ClassPtr;

	// Token: 0x0400E288 RID: 57992
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E289 RID: 57993
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x02008967 RID: 35175
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetTagDebugStrings_FunctionParams
	{
		// Token: 0x0402BCED RID: 179437
		[FieldOffset(0)]
		public FString __Result;
	}
}
