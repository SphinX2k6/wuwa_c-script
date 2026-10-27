using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.LongGrass
{
	// Token: 0x02003CF2 RID: 15602
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/LongGrass/BP_InstanceGrassInteraction.BP_InstanceGrassInteraction_C")]
	[UnrealStructLayout(1568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1568)]
	public class BP_InstanceGrassInteraction_C : AKuroInstanceGrassInteraction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602532D RID: 152365 RVA: 0x00953ACC File Offset: 0x00951CCC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_InstanceGrassInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/LongGrass/BP_InstanceGrassInteraction.BP_InstanceGrassInteraction_C");
			}
			return BP_InstanceGrassInteraction_C._ClassPtr;
		}

		// Token: 0x0602532E RID: 152366 RVA: 0x00953AF0 File Offset: 0x00951CF0
		public BP_InstanceGrassInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_InstanceGrassInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602532F RID: 152367 RVA: 0x00953B18 File Offset: 0x00951D18
		[NullableContext(1)]
		public BP_InstanceGrassInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_InstanceGrassInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B5B RID: 19291
		// (get) Token: 0x06025330 RID: 152368 RVA: 0x00953B4B File Offset: 0x00951D4B
		// (set) Token: 0x06025331 RID: 152369 RVA: 0x00953B5F File Offset: 0x00951D5F
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InstanceGrassInteraction_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InstanceGrassInteraction_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06025332 RID: 152370 RVA: 0x00953B74 File Offset: 0x00951D74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalcTexCoord(FVectorDouble MainPlayerPos, FVectorDouble OtherPlayerPos, float InteractionSize, ref FVector2D TexCoord)
		{
			BP_InstanceGrassInteraction_C.__CalcTexCoord_FunctionParams* ptr = stackalloc BP_InstanceGrassInteraction_C.__CalcTexCoord_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BP_InstanceGrassInteraction_C.__CalcTexCoord_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InstanceGrassInteraction_C.__CalcTexCoord_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MainPlayerPos = MainPlayerPos;
			ptr->OtherPlayerPos = OtherPlayerPos;
			ptr->InteractionSize = InteractionSize;
			ptr->TexCoord = TexCoord;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InstanceGrassInteraction_C.__CalcTexCoord_NativeFunctionPtr, (void*)ptr);
			TexCoord = ptr->TexCoord;
		}

		// Token: 0x06025333 RID: 152371 RVA: 0x00953BE5 File Offset: 0x00951DE5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearRT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InstanceGrassInteraction_C.__ClearRT_NativeFunctionPtr, null);
		}

		// Token: 0x06025334 RID: 152372 RVA: 0x00953BF9 File Offset: 0x00951DF9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Create_MID()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InstanceGrassInteraction_C.__Create_MID_NativeFunctionPtr, null);
		}

		// Token: 0x06025335 RID: 152373 RVA: 0x00953C0D File Offset: 0x00951E0D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InstanceGrassInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025336 RID: 152374 RVA: 0x00953C21 File Offset: 0x00951E21
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InstanceGrassInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025337 RID: 152375 RVA: 0x00953C36 File Offset: 0x00951E36
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearRenderTarget()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InstanceGrassInteraction_C.__ClearRenderTarget_NativeFunctionPtr, null);
		}

		// Token: 0x06025338 RID: 152376 RVA: 0x00953C4C File Offset: 0x00951E4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_InstanceGrassInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_InstanceGrassInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InstanceGrassInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InstanceGrassInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InstanceGrassInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025339 RID: 152377 RVA: 0x00953C94 File Offset: 0x00951E94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_InstanceGrassInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_InstanceGrassInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InstanceGrassInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InstanceGrassInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InstanceGrassInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602533A RID: 152378 RVA: 0x00953CDB File Offset: 0x00951EDB
		protected BP_InstanceGrassInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012876 RID: 75894
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/LongGrass/BP_InstanceGrassInteraction.BP_InstanceGrassInteraction_C";

		// Token: 0x04012877 RID: 75895
		private static IntPtr _ClassPtr;

		// Token: 0x04012878 RID: 75896
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012879 RID: 75897
		internal static int __PropertyOffset_1;

		// Token: 0x0401287A RID: 75898
		private static IntPtr __CalcTexCoord_NativeFunctionPtr;

		// Token: 0x0401287B RID: 75899
		private static IntPtr __ClearRT_NativeFunctionPtr;

		// Token: 0x0401287C RID: 75900
		private static IntPtr __Create_MID_NativeFunctionPtr;

		// Token: 0x0401287D RID: 75901
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401287E RID: 75902
		private static IntPtr __ClearRenderTarget_NativeFunctionPtr;

		// Token: 0x0401287F RID: 75903
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009FC6 RID: 40902
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __CalcTexCoord_FunctionParams
		{
			// Token: 0x04031A32 RID: 203314
			[FieldOffset(0)]
			public FVectorDouble MainPlayerPos;

			// Token: 0x04031A33 RID: 203315
			[FieldOffset(24)]
			public FVectorDouble OtherPlayerPos;

			// Token: 0x04031A34 RID: 203316
			[FieldOffset(48)]
			public float InteractionSize;

			// Token: 0x04031A35 RID: 203317
			[FieldOffset(52)]
			public FVector2D TexCoord;
		}

		// Token: 0x02009FC7 RID: 40903
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A36 RID: 203318
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
