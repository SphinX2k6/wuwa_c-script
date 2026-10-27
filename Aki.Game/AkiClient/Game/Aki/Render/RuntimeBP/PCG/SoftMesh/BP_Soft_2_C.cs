using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SoftMesh
{
	// Token: 0x02003BF2 RID: 15346
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SoftMesh/BP_Soft_2.BP_Soft_2_C")]
	[UnrealStructLayout(1152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1152)]
	public class BP_Soft_2_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022DD1 RID: 142801 RVA: 0x009144F1 File Offset: 0x009126F1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Soft_2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SoftMesh/BP_Soft_2.BP_Soft_2_C");
			}
			return BP_Soft_2_C._ClassPtr;
		}

		// Token: 0x06022DD2 RID: 142802 RVA: 0x00914518 File Offset: 0x00912718
		public BP_Soft_2_C() : this(BuiltinUtils.AllocNativeUObject(BP_Soft_2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022DD3 RID: 142803 RVA: 0x00914540 File Offset: 0x00912740
		[NullableContext(1)]
		public BP_Soft_2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Soft_2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003E35 RID: 15925
		// (get) Token: 0x06022DD4 RID: 142804 RVA: 0x00914573 File Offset: 0x00912773
		// (set) Token: 0x06022DD5 RID: 142805 RVA: 0x00914587 File Offset: 0x00912787
		public unsafe UStaticMeshComponent SM
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_2_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_2_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003E36 RID: 15926
		// (get) Token: 0x06022DD6 RID: 142806 RVA: 0x0091459C File Offset: 0x0091279C
		// (set) Token: 0x06022DD7 RID: 142807 RVA: 0x009145B0 File Offset: 0x009127B0
		public unsafe UBoxComponent ValidBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_2_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_2_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003E37 RID: 15927
		// (get) Token: 0x06022DD8 RID: 142808 RVA: 0x009145C5 File Offset: 0x009127C5
		// (set) Token: 0x06022DD9 RID: 142809 RVA: 0x009145D9 File Offset: 0x009127D9
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_2_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_2_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003E38 RID: 15928
		// (get) Token: 0x06022DDA RID: 142810 RVA: 0x009145EE File Offset: 0x009127EE
		// (set) Token: 0x06022DDB RID: 142811 RVA: 0x00914602 File Offset: 0x00912802
		public unsafe FVector BoxExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_2_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_2_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003E39 RID: 15929
		// (get) Token: 0x06022DDC RID: 142812 RVA: 0x00914617 File Offset: 0x00912817
		// (set) Token: 0x06022DDD RID: 142813 RVA: 0x00914627 File Offset: 0x00912827
		public unsafe float Mass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_2_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_2_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003E3A RID: 15930
		// (get) Token: 0x06022DDE RID: 142814 RVA: 0x00914638 File Offset: 0x00912838
		// (set) Token: 0x06022DDF RID: 142815 RVA: 0x0091464C File Offset: 0x0091284C
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_2_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_2_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003E3B RID: 15931
		// (get) Token: 0x06022DE0 RID: 142816 RVA: 0x00914661 File Offset: 0x00912861
		// (set) Token: 0x06022DE1 RID: 142817 RVA: 0x00914671 File Offset: 0x00912871
		public unsafe float Tightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_2_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_2_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003E3C RID: 15932
		// (get) Token: 0x06022DE2 RID: 142818 RVA: 0x00914682 File Offset: 0x00912882
		// (set) Token: 0x06022DE3 RID: 142819 RVA: 0x00914696 File Offset: 0x00912896
		public unsafe UTextureRenderTarget2D RT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_2_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_2_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17003E3D RID: 15933
		// (get) Token: 0x06022DE4 RID: 142820 RVA: 0x009146AB File Offset: 0x009128AB
		// (set) Token: 0x06022DE5 RID: 142821 RVA: 0x009146BF File Offset: 0x009128BF
		public unsafe UHoudiniPointCache HoudiniPointCache
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniPointCache>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_2_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_2_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003E3E RID: 15934
		// (get) Token: 0x06022DE6 RID: 142822 RVA: 0x009146D4 File Offset: 0x009128D4
		// (set) Token: 0x06022DE7 RID: 142823 RVA: 0x009146E8 File Offset: 0x009128E8
		public unsafe UMaterialInstanceDynamic Dmaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_2_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_2_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17003E3F RID: 15935
		// (get) Token: 0x06022DE8 RID: 142824 RVA: 0x009146FD File Offset: 0x009128FD
		// (set) Token: 0x06022DE9 RID: 142825 RVA: 0x00914711 File Offset: 0x00912911
		public unsafe UMaterialInstance InputMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_2_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_2_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x06022DEA RID: 142826 RVA: 0x00914726 File Offset: 0x00912926
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_2_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022DEB RID: 142827 RVA: 0x0091473A File Offset: 0x0091293A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Soft_2_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022DEC RID: 142828 RVA: 0x0091474F File Offset: 0x0091294F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_2_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022DED RID: 142829 RVA: 0x00914763 File Offset: 0x00912963
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Soft_2_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022DEE RID: 142830 RVA: 0x00914778 File Offset: 0x00912978
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Soft_2_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Soft_2_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Soft_2_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Soft_2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022DEF RID: 142831 RVA: 0x009147C0 File Offset: 0x009129C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Soft_2_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Soft_2_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Soft_2_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Soft_2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Soft_2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022DF0 RID: 142832 RVA: 0x00914807 File Offset: 0x00912A07
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent_0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_2_C.__CustomEvent_0_NativeFunctionPtr, null);
		}

		// Token: 0x06022DF1 RID: 142833 RVA: 0x0091481B File Offset: 0x00912A1B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_2_C.__CustomEvent1_NativeFunctionPtr, null);
		}

		// Token: 0x06022DF2 RID: 142834 RVA: 0x0091482F File Offset: 0x00912A2F
		protected BP_Soft_2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401127D RID: 70269
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SoftMesh/BP_Soft_2.BP_Soft_2_C";

		// Token: 0x0401127E RID: 70270
		private static IntPtr _ClassPtr;

		// Token: 0x0401127F RID: 70271
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011280 RID: 70272
		internal static int __PropertyOffset_1;

		// Token: 0x04011281 RID: 70273
		internal static int __PropertyOffset_2;

		// Token: 0x04011282 RID: 70274
		internal static int __PropertyOffset_3;

		// Token: 0x04011283 RID: 70275
		internal static int __PropertyOffset_4;

		// Token: 0x04011284 RID: 70276
		internal static int __PropertyOffset_5;

		// Token: 0x04011285 RID: 70277
		internal static int __PropertyOffset_6;

		// Token: 0x04011286 RID: 70278
		internal static int __PropertyOffset_7;

		// Token: 0x04011287 RID: 70279
		internal static int __PropertyOffset_8;

		// Token: 0x04011288 RID: 70280
		internal static int __PropertyOffset_9;

		// Token: 0x04011289 RID: 70281
		internal static int __PropertyOffset_10;

		// Token: 0x0401128A RID: 70282
		internal static int __PropertyOffset_11;

		// Token: 0x0401128B RID: 70283
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401128C RID: 70284
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401128D RID: 70285
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401128E RID: 70286
		private static IntPtr __CustomEvent_0_NativeFunctionPtr;

		// Token: 0x0401128F RID: 70287
		private static IntPtr __CustomEvent1_NativeFunctionPtr;

		// Token: 0x02009DE5 RID: 40421
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040315E8 RID: 202216
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
