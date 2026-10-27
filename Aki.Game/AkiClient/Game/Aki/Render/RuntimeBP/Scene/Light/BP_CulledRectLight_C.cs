using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003AFD RID: 15101
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_CulledRectLight.BP_CulledRectLight_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1521)]
	public class BP_CulledRectLight_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06020C2C RID: 134188 RVA: 0x008DC858 File Offset: 0x008DAA58
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CulledRectLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_CulledRectLight.BP_CulledRectLight_C");
			}
			return BP_CulledRectLight_C._ClassPtr;
		}

		// Token: 0x06020C2D RID: 134189 RVA: 0x008DC87C File Offset: 0x008DAA7C
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_CulledRectLight_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x06020C2E RID: 134190 RVA: 0x008DC884 File Offset: 0x008DAA84
		public BP_CulledRectLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_CulledRectLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020C2F RID: 134191 RVA: 0x008DC8AC File Offset: 0x008DAAAC
		[NullableContext(1)]
		public BP_CulledRectLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CulledRectLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003251 RID: 12881
		// (get) Token: 0x06020C30 RID: 134192 RVA: 0x008DC8DF File Offset: 0x008DAADF
		// (set) Token: 0x06020C31 RID: 134193 RVA: 0x008DC8F3 File Offset: 0x008DAAF3
		public unsafe URectLightComponent RectLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URectLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledRectLight_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledRectLight_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003252 RID: 12882
		// (get) Token: 0x06020C32 RID: 134194 RVA: 0x008DC908 File Offset: 0x008DAB08
		// (set) Token: 0x06020C33 RID: 134195 RVA: 0x008DC91C File Offset: 0x008DAB1C
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledRectLight_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledRectLight_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003253 RID: 12883
		// (get) Token: 0x06020C34 RID: 134196 RVA: 0x008DC931 File Offset: 0x008DAB31
		// (set) Token: 0x06020C35 RID: 134197 RVA: 0x008DC945 File Offset: 0x008DAB45
		public unsafe UChildActorComponent PointC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledRectLight_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledRectLight_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003254 RID: 12884
		// (get) Token: 0x06020C36 RID: 134198 RVA: 0x008DC95A File Offset: 0x008DAB5A
		// (set) Token: 0x06020C37 RID: 134199 RVA: 0x008DC96E File Offset: 0x008DAB6E
		public unsafe UChildActorComponent PointB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledRectLight_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledRectLight_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003255 RID: 12885
		// (get) Token: 0x06020C38 RID: 134200 RVA: 0x008DC983 File Offset: 0x008DAB83
		// (set) Token: 0x06020C39 RID: 134201 RVA: 0x008DC997 File Offset: 0x008DAB97
		public unsafe UChildActorComponent PointA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledRectLight_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledRectLight_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003256 RID: 12886
		// (get) Token: 0x06020C3A RID: 134202 RVA: 0x008DC9AC File Offset: 0x008DABAC
		// (set) Token: 0x06020C3B RID: 134203 RVA: 0x008DC9C0 File Offset: 0x008DABC0
		public unsafe UChildActorComponent PointO
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledRectLight_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledRectLight_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003257 RID: 12887
		// (get) Token: 0x06020C3C RID: 134204 RVA: 0x008DC9D5 File Offset: 0x008DABD5
		// (set) Token: 0x06020C3D RID: 134205 RVA: 0x008DC9E9 File Offset: 0x008DABE9
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledRectLight_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledRectLight_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003258 RID: 12888
		// (get) Token: 0x06020C3E RID: 134206 RVA: 0x008DC9FE File Offset: 0x008DABFE
		// (set) Token: 0x06020C3F RID: 134207 RVA: 0x008DCA0E File Offset: 0x008DAC0E
		public unsafe bool bDirty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CulledRectLight_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CulledRectLight_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020C40 RID: 134208 RVA: 0x008DCA20 File Offset: 0x008DAC20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_CulledRectLight_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_CulledRectLight_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CulledRectLight_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CulledRectLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CulledRectLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06020C41 RID: 134209 RVA: 0x008DCA68 File Offset: 0x008DAC68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_CulledRectLight_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_CulledRectLight_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CulledRectLight_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CulledRectLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CulledRectLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06020C42 RID: 134210 RVA: 0x008DCAB0 File Offset: 0x008DACB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_CulledRectLight_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CulledRectLight_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CulledRectLight_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CulledRectLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CulledRectLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020C43 RID: 134211 RVA: 0x008DCAF8 File Offset: 0x008DACF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_CulledRectLight_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CulledRectLight_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CulledRectLight_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CulledRectLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CulledRectLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020C44 RID: 134212 RVA: 0x008DCB3F File Offset: 0x008DAD3F
		protected BP_CulledRectLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE98 RID: 65176
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x0400FE99 RID: 65177
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_CulledRectLight.BP_CulledRectLight_C";

		// Token: 0x0400FE9A RID: 65178
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE9B RID: 65179
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE9C RID: 65180
		internal static int __PropertyOffset_1;

		// Token: 0x0400FE9D RID: 65181
		internal static int __PropertyOffset_2;

		// Token: 0x0400FE9E RID: 65182
		internal static int __PropertyOffset_3;

		// Token: 0x0400FE9F RID: 65183
		internal static int __PropertyOffset_4;

		// Token: 0x0400FEA0 RID: 65184
		internal static int __PropertyOffset_5;

		// Token: 0x0400FEA1 RID: 65185
		internal static int __PropertyOffset_6;

		// Token: 0x0400FEA2 RID: 65186
		internal static int __PropertyOffset_7;

		// Token: 0x0400FEA3 RID: 65187
		internal static int __PropertyOffset_8;

		// Token: 0x0400FEA4 RID: 65188
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x0400FEA5 RID: 65189
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009C35 RID: 39989
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x040312E5 RID: 201445
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02009C36 RID: 39990
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040312E6 RID: 201446
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
