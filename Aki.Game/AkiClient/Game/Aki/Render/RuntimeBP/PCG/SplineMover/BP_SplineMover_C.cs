using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SplineMover
{
	// Token: 0x02003BEB RID: 15339
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SplineMover/BP_SplineMover.BP_SplineMover_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1522)]
	public class BP_SplineMover_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022D29 RID: 142633 RVA: 0x009132E9 File Offset: 0x009114E9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SplineMover_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SplineMover/BP_SplineMover.BP_SplineMover_C");
			}
			return BP_SplineMover_C._ClassPtr;
		}

		// Token: 0x06022D2A RID: 142634 RVA: 0x00913310 File Offset: 0x00911510
		public BP_SplineMover_C() : this(BuiltinUtils.AllocNativeUObject(BP_SplineMover_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022D2B RID: 142635 RVA: 0x00913338 File Offset: 0x00911538
		[NullableContext(1)]
		public BP_SplineMover_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SplineMover_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003E00 RID: 15872
		// (get) Token: 0x06022D2C RID: 142636 RVA: 0x0091336B File Offset: 0x0091156B
		// (set) Token: 0x06022D2D RID: 142637 RVA: 0x0091337F File Offset: 0x0091157F
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineMover_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineMover_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003E01 RID: 15873
		// (get) Token: 0x06022D2E RID: 142638 RVA: 0x00913394 File Offset: 0x00911594
		// (set) Token: 0x06022D2F RID: 142639 RVA: 0x009133A8 File Offset: 0x009115A8
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineMover_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineMover_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003E02 RID: 15874
		// (get) Token: 0x06022D30 RID: 142640 RVA: 0x009133C0 File Offset: 0x009115C0
		// (set) Token: 0x06022D31 RID: 142641 RVA: 0x009133F9 File Offset: 0x009115F9
		[Nullable(1)]
		public TArray<FMoveData_splineMover> MoveStates
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FMoveData_splineMover> result;
				if ((result = this._MoveStates) == null)
				{
					result = (this._MoveStates = new TArray<FMoveData_splineMover>(base.NativePtr + (IntPtr)BP_SplineMover_C.__PropertyOffset_3, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MoveStates.CopyAssign(value);
			}
		}

		// Token: 0x17003E03 RID: 15875
		// (get) Token: 0x06022D32 RID: 142642 RVA: 0x00913407 File Offset: 0x00911607
		// (set) Token: 0x06022D33 RID: 142643 RVA: 0x00913417 File Offset: 0x00911617
		public unsafe float TotalSplineLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineMover_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineMover_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003E04 RID: 15876
		// (get) Token: 0x06022D34 RID: 142644 RVA: 0x00913428 File Offset: 0x00911628
		// (set) Token: 0x06022D35 RID: 142645 RVA: 0x00913438 File Offset: 0x00911638
		public unsafe float MoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineMover_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineMover_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003E05 RID: 15877
		// (get) Token: 0x06022D36 RID: 142646 RVA: 0x00913449 File Offset: 0x00911649
		// (set) Token: 0x06022D37 RID: 142647 RVA: 0x00913459 File Offset: 0x00911659
		public unsafe bool IsMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineMover_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineMover_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E06 RID: 15878
		// (get) Token: 0x06022D38 RID: 142648 RVA: 0x0091346A File Offset: 0x0091166A
		// (set) Token: 0x06022D39 RID: 142649 RVA: 0x0091347E File Offset: 0x0091167E
		public unsafe AStaticMeshActor mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AStaticMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineMover_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineMover_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003E07 RID: 15879
		// (get) Token: 0x06022D3A RID: 142650 RVA: 0x00913493 File Offset: 0x00911693
		// (set) Token: 0x06022D3B RID: 142651 RVA: 0x009134A7 File Offset: 0x009116A7
		public unsafe UMaterialInstanceDynamic DMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineMover_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineMover_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17003E08 RID: 15880
		// (get) Token: 0x06022D3C RID: 142652 RVA: 0x009134BC File Offset: 0x009116BC
		// (set) Token: 0x06022D3D RID: 142653 RVA: 0x009134CC File Offset: 0x009116CC
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineMover_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineMover_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003E09 RID: 15881
		// (get) Token: 0x06022D3E RID: 142654 RVA: 0x009134DD File Offset: 0x009116DD
		// (set) Token: 0x06022D3F RID: 142655 RVA: 0x009134ED File Offset: 0x009116ED
		public unsafe float CustomV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineMover_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineMover_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003E0A RID: 15882
		// (get) Token: 0x06022D40 RID: 142656 RVA: 0x009134FE File Offset: 0x009116FE
		// (set) Token: 0x06022D41 RID: 142657 RVA: 0x0091350E File Offset: 0x0091170E
		public unsafe bool NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineMover_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineMover_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E0B RID: 15883
		// (get) Token: 0x06022D42 RID: 142658 RVA: 0x0091351F File Offset: 0x0091171F
		// (set) Token: 0x06022D43 RID: 142659 RVA: 0x00913533 File Offset: 0x00911733
		[Nullable(0)]
		public unsafe TEnumAsByte<ECollisionEnabled> CollisionType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineMover_C.__PropertyOffset_12);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineMover_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x06022D44 RID: 142660 RVA: 0x00913548 File Offset: 0x00911748
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineMover_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022D45 RID: 142661 RVA: 0x0091355C File Offset: 0x0091175C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineMover_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022D46 RID: 142662 RVA: 0x00913574 File Offset: 0x00911774
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SplineMover_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SplineMover_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplineMover_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineMover_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineMover_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022D47 RID: 142663 RVA: 0x009135BC File Offset: 0x009117BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SplineMover_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SplineMover_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplineMover_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineMover_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineMover_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022D48 RID: 142664 RVA: 0x00913604 File Offset: 0x00911804
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveActorBeginOverlap(AActor OtherActor)
		{
			BP_SplineMover_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc BP_SplineMover_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SplineMover_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineMover_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineMover_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022D49 RID: 142665 RVA: 0x0091365C File Offset: 0x0091185C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveActorBeginOverlap_Implementation(AActor OtherActor)
		{
			BP_SplineMover_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc BP_SplineMover_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SplineMover_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineMover_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineMover_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022D4A RID: 142666 RVA: 0x009136B4 File Offset: 0x009118B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveActorEndOverlap(AActor OtherActor)
		{
			BP_SplineMover_C.__ReceiveActorEndOverlap_FunctionParams* ptr = stackalloc BP_SplineMover_C.__ReceiveActorEndOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SplineMover_C.__ReceiveActorEndOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineMover_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineMover_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022D4B RID: 142667 RVA: 0x0091370C File Offset: 0x0091190C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveActorEndOverlap_Implementation(AActor OtherActor)
		{
			BP_SplineMover_C.__ReceiveActorEndOverlap_FunctionParams* ptr = stackalloc BP_SplineMover_C.__ReceiveActorEndOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SplineMover_C.__ReceiveActorEndOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineMover_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineMover_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022D4C RID: 142668 RVA: 0x00913762 File Offset: 0x00911962
		protected BP_SplineMover_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401121E RID: 70174
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SplineMover/BP_SplineMover.BP_SplineMover_C";

		// Token: 0x0401121F RID: 70175
		private static IntPtr _ClassPtr;

		// Token: 0x04011220 RID: 70176
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011221 RID: 70177
		internal static int __PropertyOffset_1;

		// Token: 0x04011222 RID: 70178
		internal static int __PropertyOffset_2;

		// Token: 0x04011223 RID: 70179
		internal static int __PropertyOffset_3;

		// Token: 0x04011224 RID: 70180
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMoveData_splineMover> _MoveStates;

		// Token: 0x04011225 RID: 70181
		internal static int __PropertyOffset_4;

		// Token: 0x04011226 RID: 70182
		internal static int __PropertyOffset_5;

		// Token: 0x04011227 RID: 70183
		internal static int __PropertyOffset_6;

		// Token: 0x04011228 RID: 70184
		internal static int __PropertyOffset_7;

		// Token: 0x04011229 RID: 70185
		internal static int __PropertyOffset_8;

		// Token: 0x0401122A RID: 70186
		internal static int __PropertyOffset_9;

		// Token: 0x0401122B RID: 70187
		internal static int __PropertyOffset_10;

		// Token: 0x0401122C RID: 70188
		internal static int __PropertyOffset_11;

		// Token: 0x0401122D RID: 70189
		internal static int __PropertyOffset_12;

		// Token: 0x0401122E RID: 70190
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401122F RID: 70191
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011230 RID: 70192
		private static IntPtr __ReceiveActorBeginOverlap_NativeFunctionPtr;

		// Token: 0x04011231 RID: 70193
		private static IntPtr __ReceiveActorEndOverlap_NativeFunctionPtr;

		// Token: 0x02009DD8 RID: 40408
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040315DB RID: 202203
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009DD9 RID: 40409
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveActorBeginOverlap_FunctionParams
		{
			// Token: 0x040315DC RID: 202204
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}

		// Token: 0x02009DDA RID: 40410
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveActorEndOverlap_FunctionParams
		{
			// Token: 0x040315DD RID: 202205
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}
	}
}
