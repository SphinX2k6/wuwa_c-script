using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.PathLine
{
	// Token: 0x02003EE4 RID: 16100
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/PathLine/BP_Miaozhunxian.BP_Miaozhunxian_C")]
	[UnrealStructLayout(1120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1113)]
	public class BP_Miaozhunxian_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028C22 RID: 166946 RVA: 0x009B3F09 File Offset: 0x009B2109
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Miaozhunxian_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/PathLine/BP_Miaozhunxian.BP_Miaozhunxian_C");
			}
			return BP_Miaozhunxian_C._ClassPtr;
		}

		// Token: 0x06028C23 RID: 166947 RVA: 0x009B3F30 File Offset: 0x009B2130
		public BP_Miaozhunxian_C() : this(BuiltinUtils.AllocNativeUObject(BP_Miaozhunxian_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028C24 RID: 166948 RVA: 0x009B3F58 File Offset: 0x009B2158
		[NullableContext(1)]
		public BP_Miaozhunxian_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Miaozhunxian_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005F7C RID: 24444
		// (get) Token: 0x06028C25 RID: 166949 RVA: 0x009B3F8B File Offset: 0x009B218B
		// (set) Token: 0x06028C26 RID: 166950 RVA: 0x009B3F9F File Offset: 0x009B219F
		public unsafe UInstancedStaticMeshComponent InstancedStaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInstancedStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Miaozhunxian_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Miaozhunxian_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005F7D RID: 24445
		// (get) Token: 0x06028C27 RID: 166951 RVA: 0x009B3FB4 File Offset: 0x009B21B4
		// (set) Token: 0x06028C28 RID: 166952 RVA: 0x009B3FC8 File Offset: 0x009B21C8
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Miaozhunxian_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Miaozhunxian_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005F7E RID: 24446
		// (get) Token: 0x06028C29 RID: 166953 RVA: 0x009B3FDD File Offset: 0x009B21DD
		// (set) Token: 0x06028C2A RID: 166954 RVA: 0x009B3FF1 File Offset: 0x009B21F1
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Miaozhunxian_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Miaozhunxian_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005F7F RID: 24447
		// (get) Token: 0x06028C2B RID: 166955 RVA: 0x009B4006 File Offset: 0x009B2206
		// (set) Token: 0x06028C2C RID: 166956 RVA: 0x009B401A File Offset: 0x009B221A
		public unsafe UStaticMesh BasicStaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Miaozhunxian_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Miaozhunxian_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17005F80 RID: 24448
		// (get) Token: 0x06028C2D RID: 166957 RVA: 0x009B402F File Offset: 0x009B222F
		// (set) Token: 0x06028C2E RID: 166958 RVA: 0x009B403F File Offset: 0x009B223F
		public unsafe float SamplingNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Miaozhunxian_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Miaozhunxian_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005F81 RID: 24449
		// (get) Token: 0x06028C2F RID: 166959 RVA: 0x009B4050 File Offset: 0x009B2250
		// (set) Token: 0x06028C30 RID: 166960 RVA: 0x009B4089 File Offset: 0x009B2289
		[Nullable(1)]
		public TArray<UStaticMeshComponent> BasicStaticMeshs
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._BasicStaticMeshs) == null)
				{
					result = (this._BasicStaticMeshs = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_Miaozhunxian_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BasicStaticMeshs.CopyAssign(value);
			}
		}

		// Token: 0x17005F82 RID: 24450
		// (get) Token: 0x06028C31 RID: 166961 RVA: 0x009B4097 File Offset: 0x009B2297
		// (set) Token: 0x06028C32 RID: 166962 RVA: 0x009B40A7 File Offset: 0x009B22A7
		public unsafe bool Showing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Miaozhunxian_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Miaozhunxian_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x06028C33 RID: 166963 RVA: 0x009B40B8 File Offset: 0x009B22B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ShowMesh()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Miaozhunxian_C.__ShowMesh_NativeFunctionPtr, null);
		}

		// Token: 0x06028C34 RID: 166964 RVA: 0x009B40CC File Offset: 0x009B22CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void HideMesh()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Miaozhunxian_C.__HideMesh_NativeFunctionPtr, null);
		}

		// Token: 0x06028C35 RID: 166965 RVA: 0x009B40E0 File Offset: 0x009B22E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateMesh()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Miaozhunxian_C.__UpdateMesh_NativeFunctionPtr, null);
		}

		// Token: 0x06028C36 RID: 166966 RVA: 0x009B40F4 File Offset: 0x009B22F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Miaozhunxian_C.__Init_NativeFunctionPtr, null);
		}

		// Token: 0x06028C37 RID: 166967 RVA: 0x009B4108 File Offset: 0x009B2308
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Miaozhunxian_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06028C38 RID: 166968 RVA: 0x009B411C File Offset: 0x009B231C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Miaozhunxian_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06028C39 RID: 166969 RVA: 0x009B4134 File Offset: 0x009B2334
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Miaozhunxian_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Miaozhunxian_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Miaozhunxian_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Miaozhunxian_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Miaozhunxian_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06028C3A RID: 166970 RVA: 0x009B417C File Offset: 0x009B237C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Miaozhunxian_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Miaozhunxian_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Miaozhunxian_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Miaozhunxian_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Miaozhunxian_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06028C3B RID: 166971 RVA: 0x009B41C3 File Offset: 0x009B23C3
		protected BP_Miaozhunxian_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014D54 RID: 85332
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/PathLine/BP_Miaozhunxian.BP_Miaozhunxian_C";

		// Token: 0x04014D55 RID: 85333
		private static IntPtr _ClassPtr;

		// Token: 0x04014D56 RID: 85334
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014D57 RID: 85335
		internal static int __PropertyOffset_1;

		// Token: 0x04014D58 RID: 85336
		internal static int __PropertyOffset_2;

		// Token: 0x04014D59 RID: 85337
		internal static int __PropertyOffset_3;

		// Token: 0x04014D5A RID: 85338
		internal static int __PropertyOffset_4;

		// Token: 0x04014D5B RID: 85339
		internal static int __PropertyOffset_5;

		// Token: 0x04014D5C RID: 85340
		internal static int __PropertyOffset_6;

		// Token: 0x04014D5D RID: 85341
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _BasicStaticMeshs;

		// Token: 0x04014D5E RID: 85342
		internal static int __PropertyOffset_7;

		// Token: 0x04014D5F RID: 85343
		private static IntPtr __ShowMesh_NativeFunctionPtr;

		// Token: 0x04014D60 RID: 85344
		private static IntPtr __HideMesh_NativeFunctionPtr;

		// Token: 0x04014D61 RID: 85345
		private static IntPtr __UpdateMesh_NativeFunctionPtr;

		// Token: 0x04014D62 RID: 85346
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x04014D63 RID: 85347
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04014D64 RID: 85348
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A2DA RID: 41690
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403201E RID: 204830
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
