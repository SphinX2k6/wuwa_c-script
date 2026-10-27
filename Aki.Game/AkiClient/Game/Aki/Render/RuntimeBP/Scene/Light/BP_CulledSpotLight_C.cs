using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003AFE RID: 15102
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_CulledSpotLight.BP_CulledSpotLight_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1521)]
	public class BP_CulledSpotLight_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06020C45 RID: 134213 RVA: 0x008DCB48 File Offset: 0x008DAD48
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CulledSpotLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_CulledSpotLight.BP_CulledSpotLight_C");
			}
			return BP_CulledSpotLight_C._ClassPtr;
		}

		// Token: 0x06020C46 RID: 134214 RVA: 0x008DCB6C File Offset: 0x008DAD6C
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_CulledSpotLight_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x06020C47 RID: 134215 RVA: 0x008DCB74 File Offset: 0x008DAD74
		public BP_CulledSpotLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_CulledSpotLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020C48 RID: 134216 RVA: 0x008DCB9C File Offset: 0x008DAD9C
		[NullableContext(1)]
		public BP_CulledSpotLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CulledSpotLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003259 RID: 12889
		// (get) Token: 0x06020C49 RID: 134217 RVA: 0x008DCBCF File Offset: 0x008DADCF
		// (set) Token: 0x06020C4A RID: 134218 RVA: 0x008DCBE3 File Offset: 0x008DADE3
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledSpotLight_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledSpotLight_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700325A RID: 12890
		// (get) Token: 0x06020C4B RID: 134219 RVA: 0x008DCBF8 File Offset: 0x008DADF8
		// (set) Token: 0x06020C4C RID: 134220 RVA: 0x008DCC0C File Offset: 0x008DAE0C
		public unsafe USpotLightComponent SpotLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpotLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledSpotLight_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledSpotLight_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700325B RID: 12891
		// (get) Token: 0x06020C4D RID: 134221 RVA: 0x008DCC21 File Offset: 0x008DAE21
		// (set) Token: 0x06020C4E RID: 134222 RVA: 0x008DCC35 File Offset: 0x008DAE35
		public unsafe UChildActorComponent PointC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledSpotLight_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledSpotLight_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700325C RID: 12892
		// (get) Token: 0x06020C4F RID: 134223 RVA: 0x008DCC4A File Offset: 0x008DAE4A
		// (set) Token: 0x06020C50 RID: 134224 RVA: 0x008DCC5E File Offset: 0x008DAE5E
		public unsafe UChildActorComponent PointB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledSpotLight_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledSpotLight_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700325D RID: 12893
		// (get) Token: 0x06020C51 RID: 134225 RVA: 0x008DCC73 File Offset: 0x008DAE73
		// (set) Token: 0x06020C52 RID: 134226 RVA: 0x008DCC87 File Offset: 0x008DAE87
		public unsafe UChildActorComponent PointA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledSpotLight_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledSpotLight_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700325E RID: 12894
		// (get) Token: 0x06020C53 RID: 134227 RVA: 0x008DCC9C File Offset: 0x008DAE9C
		// (set) Token: 0x06020C54 RID: 134228 RVA: 0x008DCCB0 File Offset: 0x008DAEB0
		public unsafe UChildActorComponent PointO
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledSpotLight_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledSpotLight_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x1700325F RID: 12895
		// (get) Token: 0x06020C55 RID: 134229 RVA: 0x008DCCC5 File Offset: 0x008DAEC5
		// (set) Token: 0x06020C56 RID: 134230 RVA: 0x008DCCD9 File Offset: 0x008DAED9
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledSpotLight_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledSpotLight_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003260 RID: 12896
		// (get) Token: 0x06020C57 RID: 134231 RVA: 0x008DCCEE File Offset: 0x008DAEEE
		// (set) Token: 0x06020C58 RID: 134232 RVA: 0x008DCCFE File Offset: 0x008DAEFE
		public unsafe bool bDirty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CulledSpotLight_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CulledSpotLight_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020C59 RID: 134233 RVA: 0x008DCD10 File Offset: 0x008DAF10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_CulledSpotLight_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_CulledSpotLight_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CulledSpotLight_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CulledSpotLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CulledSpotLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06020C5A RID: 134234 RVA: 0x008DCD58 File Offset: 0x008DAF58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_CulledSpotLight_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_CulledSpotLight_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CulledSpotLight_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CulledSpotLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CulledSpotLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06020C5B RID: 134235 RVA: 0x008DCDA0 File Offset: 0x008DAFA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_CulledSpotLight_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CulledSpotLight_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CulledSpotLight_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CulledSpotLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CulledSpotLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020C5C RID: 134236 RVA: 0x008DCDE8 File Offset: 0x008DAFE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_CulledSpotLight_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CulledSpotLight_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CulledSpotLight_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CulledSpotLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CulledSpotLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020C5D RID: 134237 RVA: 0x008DCE2F File Offset: 0x008DB02F
		protected BP_CulledSpotLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FEA6 RID: 65190
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x0400FEA7 RID: 65191
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_CulledSpotLight.BP_CulledSpotLight_C";

		// Token: 0x0400FEA8 RID: 65192
		private static IntPtr _ClassPtr;

		// Token: 0x0400FEA9 RID: 65193
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FEAA RID: 65194
		internal static int __PropertyOffset_1;

		// Token: 0x0400FEAB RID: 65195
		internal static int __PropertyOffset_2;

		// Token: 0x0400FEAC RID: 65196
		internal static int __PropertyOffset_3;

		// Token: 0x0400FEAD RID: 65197
		internal static int __PropertyOffset_4;

		// Token: 0x0400FEAE RID: 65198
		internal static int __PropertyOffset_5;

		// Token: 0x0400FEAF RID: 65199
		internal static int __PropertyOffset_6;

		// Token: 0x0400FEB0 RID: 65200
		internal static int __PropertyOffset_7;

		// Token: 0x0400FEB1 RID: 65201
		internal static int __PropertyOffset_8;

		// Token: 0x0400FEB2 RID: 65202
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x0400FEB3 RID: 65203
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009C37 RID: 39991
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x040312E7 RID: 201447
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02009C38 RID: 39992
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040312E8 RID: 201448
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
