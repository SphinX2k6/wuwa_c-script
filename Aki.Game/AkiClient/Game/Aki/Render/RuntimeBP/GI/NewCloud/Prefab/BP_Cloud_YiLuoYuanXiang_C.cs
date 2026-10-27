using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.Prefab
{
	// Token: 0x02003D54 RID: 15700
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_YiLuoYuanXiang.BP_Cloud_YiLuoYuanXiang_C")]
	[UnrealStructLayout(1944, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1944)]
	public class BP_Cloud_YiLuoYuanXiang_C : BP_CloudPrefab_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060263E0 RID: 156640 RVA: 0x0096F954 File Offset: 0x0096DB54
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Cloud_YiLuoYuanXiang_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_YiLuoYuanXiang.BP_Cloud_YiLuoYuanXiang_C");
			}
			return BP_Cloud_YiLuoYuanXiang_C._ClassPtr;
		}

		// Token: 0x060263E1 RID: 156641 RVA: 0x0096F978 File Offset: 0x0096DB78
		public BP_Cloud_YiLuoYuanXiang_C() : this(BuiltinUtils.AllocNativeUObject(BP_Cloud_YiLuoYuanXiang_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060263E2 RID: 156642 RVA: 0x0096F9A0 File Offset: 0x0096DBA0
		[NullableContext(1)]
		public BP_Cloud_YiLuoYuanXiang_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Cloud_YiLuoYuanXiang_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060263E3 RID: 156643 RVA: 0x0096F9D3 File Offset: 0x0096DBD3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_YiLuoYuanXiang_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060263E4 RID: 156644 RVA: 0x0096F9E7 File Offset: 0x0096DBE7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_YiLuoYuanXiang_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060263E5 RID: 156645 RVA: 0x0096F9FC File Offset: 0x0096DBFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Cloud_YiLuoYuanXiang_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cloud_YiLuoYuanXiang_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_YiLuoYuanXiang_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_YiLuoYuanXiang_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_YiLuoYuanXiang_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263E6 RID: 156646 RVA: 0x0096FA44 File Offset: 0x0096DC44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Cloud_YiLuoYuanXiang_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cloud_YiLuoYuanXiang_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_YiLuoYuanXiang_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_YiLuoYuanXiang_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_YiLuoYuanXiang_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060263E7 RID: 156647 RVA: 0x0096FA8C File Offset: 0x0096DC8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Cloud_YiLuoYuanXiang_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Cloud_YiLuoYuanXiang_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_YiLuoYuanXiang_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_YiLuoYuanXiang_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_YiLuoYuanXiang_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060263E8 RID: 156648 RVA: 0x0096FAD4 File Offset: 0x0096DCD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Cloud_YiLuoYuanXiang_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Cloud_YiLuoYuanXiang_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_YiLuoYuanXiang_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_YiLuoYuanXiang_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_YiLuoYuanXiang_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060263E9 RID: 156649 RVA: 0x0096FB1B File Offset: 0x0096DD1B
		protected BP_Cloud_YiLuoYuanXiang_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013273 RID: 78451
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_YiLuoYuanXiang.BP_Cloud_YiLuoYuanXiang_C";

		// Token: 0x04013274 RID: 78452
		private static IntPtr _ClassPtr;

		// Token: 0x04013275 RID: 78453
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013276 RID: 78454
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013277 RID: 78455
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013278 RID: 78456
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A0D3 RID: 41171
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031BD8 RID: 203736
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A0D4 RID: 41172
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031BD9 RID: 203737
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
