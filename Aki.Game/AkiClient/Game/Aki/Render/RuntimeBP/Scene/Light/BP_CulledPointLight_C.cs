using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003AFC RID: 15100
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_CulledPointLight.BP_CulledPointLight_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1521)]
	public class BP_CulledPointLight_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06020C13 RID: 134163 RVA: 0x008DC568 File Offset: 0x008DA768
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CulledPointLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_CulledPointLight.BP_CulledPointLight_C");
			}
			return BP_CulledPointLight_C._ClassPtr;
		}

		// Token: 0x06020C14 RID: 134164 RVA: 0x008DC58C File Offset: 0x008DA78C
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_CulledPointLight_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x06020C15 RID: 134165 RVA: 0x008DC594 File Offset: 0x008DA794
		public BP_CulledPointLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_CulledPointLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020C16 RID: 134166 RVA: 0x008DC5BC File Offset: 0x008DA7BC
		[NullableContext(1)]
		public BP_CulledPointLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CulledPointLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003249 RID: 12873
		// (get) Token: 0x06020C17 RID: 134167 RVA: 0x008DC5EF File Offset: 0x008DA7EF
		// (set) Token: 0x06020C18 RID: 134168 RVA: 0x008DC603 File Offset: 0x008DA803
		public unsafe UPointLightComponent PointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledPointLight_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledPointLight_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700324A RID: 12874
		// (get) Token: 0x06020C19 RID: 134169 RVA: 0x008DC618 File Offset: 0x008DA818
		// (set) Token: 0x06020C1A RID: 134170 RVA: 0x008DC62C File Offset: 0x008DA82C
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledPointLight_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledPointLight_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700324B RID: 12875
		// (get) Token: 0x06020C1B RID: 134171 RVA: 0x008DC641 File Offset: 0x008DA841
		// (set) Token: 0x06020C1C RID: 134172 RVA: 0x008DC655 File Offset: 0x008DA855
		public unsafe UChildActorComponent PointC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledPointLight_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledPointLight_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700324C RID: 12876
		// (get) Token: 0x06020C1D RID: 134173 RVA: 0x008DC66A File Offset: 0x008DA86A
		// (set) Token: 0x06020C1E RID: 134174 RVA: 0x008DC67E File Offset: 0x008DA87E
		public unsafe UChildActorComponent PointB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledPointLight_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledPointLight_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700324D RID: 12877
		// (get) Token: 0x06020C1F RID: 134175 RVA: 0x008DC693 File Offset: 0x008DA893
		// (set) Token: 0x06020C20 RID: 134176 RVA: 0x008DC6A7 File Offset: 0x008DA8A7
		public unsafe UChildActorComponent PointA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledPointLight_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledPointLight_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700324E RID: 12878
		// (get) Token: 0x06020C21 RID: 134177 RVA: 0x008DC6BC File Offset: 0x008DA8BC
		// (set) Token: 0x06020C22 RID: 134178 RVA: 0x008DC6D0 File Offset: 0x008DA8D0
		public unsafe UChildActorComponent PointO
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledPointLight_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledPointLight_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x1700324F RID: 12879
		// (get) Token: 0x06020C23 RID: 134179 RVA: 0x008DC6E5 File Offset: 0x008DA8E5
		// (set) Token: 0x06020C24 RID: 134180 RVA: 0x008DC6F9 File Offset: 0x008DA8F9
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledPointLight_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CulledPointLight_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003250 RID: 12880
		// (get) Token: 0x06020C25 RID: 134181 RVA: 0x008DC70E File Offset: 0x008DA90E
		// (set) Token: 0x06020C26 RID: 134182 RVA: 0x008DC71E File Offset: 0x008DA91E
		public unsafe bool bDirty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CulledPointLight_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CulledPointLight_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020C27 RID: 134183 RVA: 0x008DC730 File Offset: 0x008DA930
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_CulledPointLight_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_CulledPointLight_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CulledPointLight_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CulledPointLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CulledPointLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06020C28 RID: 134184 RVA: 0x008DC778 File Offset: 0x008DA978
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_CulledPointLight_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_CulledPointLight_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CulledPointLight_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CulledPointLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CulledPointLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06020C29 RID: 134185 RVA: 0x008DC7C0 File Offset: 0x008DA9C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_CulledPointLight_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CulledPointLight_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CulledPointLight_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CulledPointLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CulledPointLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020C2A RID: 134186 RVA: 0x008DC808 File Offset: 0x008DAA08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_CulledPointLight_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CulledPointLight_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CulledPointLight_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CulledPointLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CulledPointLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020C2B RID: 134187 RVA: 0x008DC84F File Offset: 0x008DAA4F
		protected BP_CulledPointLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE8A RID: 65162
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x0400FE8B RID: 65163
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_CulledPointLight.BP_CulledPointLight_C";

		// Token: 0x0400FE8C RID: 65164
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE8D RID: 65165
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE8E RID: 65166
		internal static int __PropertyOffset_1;

		// Token: 0x0400FE8F RID: 65167
		internal static int __PropertyOffset_2;

		// Token: 0x0400FE90 RID: 65168
		internal static int __PropertyOffset_3;

		// Token: 0x0400FE91 RID: 65169
		internal static int __PropertyOffset_4;

		// Token: 0x0400FE92 RID: 65170
		internal static int __PropertyOffset_5;

		// Token: 0x0400FE93 RID: 65171
		internal static int __PropertyOffset_6;

		// Token: 0x0400FE94 RID: 65172
		internal static int __PropertyOffset_7;

		// Token: 0x0400FE95 RID: 65173
		internal static int __PropertyOffset_8;

		// Token: 0x0400FE96 RID: 65174
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x0400FE97 RID: 65175
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009C33 RID: 39987
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x040312E3 RID: 201443
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02009C34 RID: 39988
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040312E4 RID: 201444
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
