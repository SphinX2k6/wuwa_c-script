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
	// Token: 0x02003D4C RID: 15692
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_Anomalies.BP_Cloud_Anomalies_C")]
	[UnrealStructLayout(1952, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1952)]
	public class BP_Cloud_Anomalies_C : BP_CloudPrefab_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602637E RID: 156542 RVA: 0x0096E68F File Offset: 0x0096C88F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Cloud_Anomalies_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_Anomalies.BP_Cloud_Anomalies_C");
			}
			return BP_Cloud_Anomalies_C._ClassPtr;
		}

		// Token: 0x0602637F RID: 156543 RVA: 0x0096E6B4 File Offset: 0x0096C8B4
		public BP_Cloud_Anomalies_C() : this(BuiltinUtils.AllocNativeUObject(BP_Cloud_Anomalies_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026380 RID: 156544 RVA: 0x0096E6DC File Offset: 0x0096C8DC
		[NullableContext(1)]
		public BP_Cloud_Anomalies_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Cloud_Anomalies_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005132 RID: 20786
		// (get) Token: 0x06026381 RID: 156545 RVA: 0x0096E70F File Offset: 0x0096C90F
		// (set) Token: 0x06026382 RID: 156546 RVA: 0x0096E723 File Offset: 0x0096C923
		[Nullable(2)]
		public unsafe UStaticMeshComponent Cloud_Anomalies
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cloud_Anomalies_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cloud_Anomalies_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06026383 RID: 156547 RVA: 0x0096E738 File Offset: 0x0096C938
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_Anomalies_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06026384 RID: 156548 RVA: 0x0096E74C File Offset: 0x0096C94C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_Anomalies_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026385 RID: 156549 RVA: 0x0096E761 File Offset: 0x0096C961
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_Anomalies_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06026386 RID: 156550 RVA: 0x0096E775 File Offset: 0x0096C975
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_Anomalies_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026387 RID: 156551 RVA: 0x0096E78C File Offset: 0x0096C98C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Cloud_Anomalies_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cloud_Anomalies_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_Anomalies_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_Anomalies_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_Anomalies_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026388 RID: 156552 RVA: 0x0096E7D4 File Offset: 0x0096C9D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Cloud_Anomalies_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cloud_Anomalies_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_Anomalies_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_Anomalies_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_Anomalies_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026389 RID: 156553 RVA: 0x0096E81C File Offset: 0x0096CA1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Cloud_Anomalies_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Cloud_Anomalies_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_Anomalies_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_Anomalies_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_Anomalies_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602638A RID: 156554 RVA: 0x0096E864 File Offset: 0x0096CA64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Cloud_Anomalies_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Cloud_Anomalies_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloud_Anomalies_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloud_Anomalies_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_Anomalies_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602638B RID: 156555 RVA: 0x0096E8AB File Offset: 0x0096CAAB
		protected BP_Cloud_Anomalies_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013233 RID: 78387
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/Prefab/BP_Cloud_Anomalies.BP_Cloud_Anomalies_C";

		// Token: 0x04013234 RID: 78388
		private static IntPtr _ClassPtr;

		// Token: 0x04013235 RID: 78389
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013236 RID: 78390
		internal new static int __PropertyOffset_1;

		// Token: 0x04013237 RID: 78391
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013238 RID: 78392
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013239 RID: 78393
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401323A RID: 78394
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A0B5 RID: 41141
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031BBA RID: 203706
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A0B6 RID: 41142
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031BBB RID: 203707
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
