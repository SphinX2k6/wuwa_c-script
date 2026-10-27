using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneInteraction
{
	// Token: 0x02003C1C RID: 15388
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_PlantGrowthPoint_Sequence.BP_PlantGrowthPoint_Sequence_C")]
	[UnrealStructLayout(1488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1481)]
	public class BP_PlantGrowthPoint_Sequence_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060233F0 RID: 144368 RVA: 0x0091EB2F File Offset: 0x0091CD2F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PlantGrowthPoint_Sequence_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_PlantGrowthPoint_Sequence.BP_PlantGrowthPoint_Sequence_C");
			}
			return BP_PlantGrowthPoint_Sequence_C._ClassPtr;
		}

		// Token: 0x060233F1 RID: 144369 RVA: 0x0091EB54 File Offset: 0x0091CD54
		public BP_PlantGrowthPoint_Sequence_C() : this(BuiltinUtils.AllocNativeUObject(BP_PlantGrowthPoint_Sequence_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060233F2 RID: 144370 RVA: 0x0091EB7C File Offset: 0x0091CD7C
		[NullableContext(1)]
		public BP_PlantGrowthPoint_Sequence_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PlantGrowthPoint_Sequence_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004046 RID: 16454
		// (get) Token: 0x060233F3 RID: 144371 RVA: 0x0091EBAF File Offset: 0x0091CDAF
		// (set) Token: 0x060233F4 RID: 144372 RVA: 0x0091EBC3 File Offset: 0x0091CDC3
		public unsafe USphereComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantGrowthPoint_Sequence_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantGrowthPoint_Sequence_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004047 RID: 16455
		// (get) Token: 0x060233F5 RID: 144373 RVA: 0x0091EBD8 File Offset: 0x0091CDD8
		// (set) Token: 0x060233F6 RID: 144374 RVA: 0x0091EBEC File Offset: 0x0091CDEC
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantGrowthPoint_Sequence_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantGrowthPoint_Sequence_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004048 RID: 16456
		// (get) Token: 0x060233F7 RID: 144375 RVA: 0x0091EC01 File Offset: 0x0091CE01
		// (set) Token: 0x060233F8 RID: 144376 RVA: 0x0091EC11 File Offset: 0x0091CE11
		public unsafe bool IsDone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantGrowthPoint_Sequence_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantGrowthPoint_Sequence_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x060233F9 RID: 144377 RVA: 0x0091EC22 File Offset: 0x0091CE22
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetPos()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlantGrowthPoint_Sequence_C.__SetPos_NativeFunctionPtr, null);
		}

		// Token: 0x060233FA RID: 144378 RVA: 0x0091EC38 File Offset: 0x0091CE38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_PlantGrowthPoint_Sequence_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PlantGrowthPoint_Sequence_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PlantGrowthPoint_Sequence_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PlantGrowthPoint_Sequence_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlantGrowthPoint_Sequence_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060233FB RID: 144379 RVA: 0x0091EC80 File Offset: 0x0091CE80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_PlantGrowthPoint_Sequence_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PlantGrowthPoint_Sequence_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PlantGrowthPoint_Sequence_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PlantGrowthPoint_Sequence_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PlantGrowthPoint_Sequence_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060233FC RID: 144380 RVA: 0x0091ECC7 File Offset: 0x0091CEC7
		protected BP_PlantGrowthPoint_Sequence_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011611 RID: 71185
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_PlantGrowthPoint_Sequence.BP_PlantGrowthPoint_Sequence_C";

		// Token: 0x04011612 RID: 71186
		private static IntPtr _ClassPtr;

		// Token: 0x04011613 RID: 71187
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011614 RID: 71188
		internal static int __PropertyOffset_1;

		// Token: 0x04011615 RID: 71189
		internal static int __PropertyOffset_2;

		// Token: 0x04011616 RID: 71190
		internal static int __PropertyOffset_3;

		// Token: 0x04011617 RID: 71191
		private static IntPtr __SetPos_NativeFunctionPtr;

		// Token: 0x04011618 RID: 71192
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009E41 RID: 40513
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040316B0 RID: 202416
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
