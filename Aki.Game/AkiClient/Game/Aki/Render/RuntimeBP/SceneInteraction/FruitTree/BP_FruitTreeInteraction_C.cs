using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SceneInteraction.FruitTree
{
	// Token: 0x02003BB4 RID: 15284
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SceneInteraction/FruitTree/BP_FruitTreeInteraction.BP_FruitTreeInteraction_C")]
	[UnrealStructLayout(1480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1480)]
	public class BP_FruitTreeInteraction_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060221EC RID: 139756 RVA: 0x00900246 File Offset: 0x008FE446
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FruitTreeInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SceneInteraction/FruitTree/BP_FruitTreeInteraction.BP_FruitTreeInteraction_C");
			}
			return BP_FruitTreeInteraction_C._ClassPtr;
		}

		// Token: 0x060221ED RID: 139757 RVA: 0x0090026C File Offset: 0x008FE46C
		public BP_FruitTreeInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_FruitTreeInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060221EE RID: 139758 RVA: 0x00900294 File Offset: 0x008FE494
		[NullableContext(1)]
		public BP_FruitTreeInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FruitTreeInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170039D5 RID: 14805
		// (get) Token: 0x060221EF RID: 139759 RVA: 0x009002C7 File Offset: 0x008FE4C7
		// (set) Token: 0x060221F0 RID: 139760 RVA: 0x009002DB File Offset: 0x008FE4DB
		public unsafe UStaticMeshComponent TrunkMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FruitTreeInteraction_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FruitTreeInteraction_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170039D6 RID: 14806
		// (get) Token: 0x060221F1 RID: 139761 RVA: 0x009002F0 File Offset: 0x008FE4F0
		// (set) Token: 0x060221F2 RID: 139762 RVA: 0x00900304 File Offset: 0x008FE504
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FruitTreeInteraction_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FruitTreeInteraction_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170039D7 RID: 14807
		// (get) Token: 0x060221F3 RID: 139763 RVA: 0x00900319 File Offset: 0x008FE519
		// (set) Token: 0x060221F4 RID: 139764 RVA: 0x0090032D File Offset: 0x008FE52D
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FruitTreeInteraction_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FruitTreeInteraction_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170039D8 RID: 14808
		// (get) Token: 0x060221F5 RID: 139765 RVA: 0x00900342 File Offset: 0x008FE542
		// (set) Token: 0x060221F6 RID: 139766 RVA: 0x00900356 File Offset: 0x008FE556
		public unsafe UHoudiniPointCache HPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniPointCache>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FruitTreeInteraction_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FruitTreeInteraction_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x060221F7 RID: 139767 RVA: 0x0090036B File Offset: 0x008FE56B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FruitTreeInteraction_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060221F8 RID: 139768 RVA: 0x0090037F File Offset: 0x008FE57F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FruitTreeInteraction_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060221F9 RID: 139769 RVA: 0x00900394 File Offset: 0x008FE594
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnApplyWorldOffset(in FVector InWorldOffset, bool bWorldShift)
		{
			BP_FruitTreeInteraction_C.__OnApplyWorldOffset_FunctionParams* ptr = stackalloc BP_FruitTreeInteraction_C.__OnApplyWorldOffset_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_FruitTreeInteraction_C.__OnApplyWorldOffset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FruitTreeInteraction_C.__OnApplyWorldOffset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InWorldOffset = InWorldOffset;
			ptr->bWorldShift = bWorldShift;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FruitTreeInteraction_C.__OnApplyWorldOffset_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060221FA RID: 139770 RVA: 0x009003E8 File Offset: 0x008FE5E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnApplyWorldOffset_Implementation(in FVector InWorldOffset, bool bWorldShift)
		{
			BP_FruitTreeInteraction_C.__OnApplyWorldOffset_FunctionParams* ptr = stackalloc BP_FruitTreeInteraction_C.__OnApplyWorldOffset_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_FruitTreeInteraction_C.__OnApplyWorldOffset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FruitTreeInteraction_C.__OnApplyWorldOffset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InWorldOffset = InWorldOffset;
			ptr->bWorldShift = bWorldShift;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FruitTreeInteraction_C.__OnApplyWorldOffset_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060221FB RID: 139771 RVA: 0x0090043B File Offset: 0x008FE63B
		protected BP_FruitTreeInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010B5E RID: 68446
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SceneInteraction/FruitTree/BP_FruitTreeInteraction.BP_FruitTreeInteraction_C";

		// Token: 0x04010B5F RID: 68447
		private static IntPtr _ClassPtr;

		// Token: 0x04010B60 RID: 68448
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010B61 RID: 68449
		internal static int __PropertyOffset_1;

		// Token: 0x04010B62 RID: 68450
		internal static int __PropertyOffset_2;

		// Token: 0x04010B63 RID: 68451
		internal static int __PropertyOffset_3;

		// Token: 0x04010B64 RID: 68452
		internal static int __PropertyOffset_4;

		// Token: 0x04010B65 RID: 68453
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010B66 RID: 68454
		private static IntPtr __OnApplyWorldOffset_NativeFunctionPtr;

		// Token: 0x02009D41 RID: 40257
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected new ref struct __OnApplyWorldOffset_FunctionParams
		{
			// Token: 0x040314AB RID: 201899
			[FieldOffset(0)]
			public FVector InWorldOffset;

			// Token: 0x040314AC RID: 201900
			[FieldOffset(12)]
			public bool bWorldShift;
		}
	}
}
