using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B03 RID: 15107
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_FloatLight.BP_FloatLight_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class BP_FloatLight_C : AKuroFloatLightActor, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06020D58 RID: 134488 RVA: 0x008DE568 File Offset: 0x008DC768
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FloatLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_FloatLight.BP_FloatLight_C");
			}
			return BP_FloatLight_C._ClassPtr;
		}

		// Token: 0x06020D59 RID: 134489 RVA: 0x008DE58C File Offset: 0x008DC78C
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_FloatLight_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x06020D5A RID: 134490 RVA: 0x008DE594 File Offset: 0x008DC794
		public BP_FloatLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_FloatLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020D5B RID: 134491 RVA: 0x008DE5BC File Offset: 0x008DC7BC
		[NullableContext(1)]
		public BP_FloatLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FloatLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032BF RID: 12991
		// (get) Token: 0x06020D5C RID: 134492 RVA: 0x008DE5EF File Offset: 0x008DC7EF
		// (set) Token: 0x06020D5D RID: 134493 RVA: 0x008DE603 File Offset: 0x008DC803
		[Nullable(2)]
		public unsafe UBillboardComponent Billboard
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatLight_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatLight_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06020D5E RID: 134494 RVA: 0x008DE618 File Offset: 0x008DC818
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_FloatLight_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_FloatLight_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FloatLight_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloatLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06020D5F RID: 134495 RVA: 0x008DE660 File Offset: 0x008DC860
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_FloatLight_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_FloatLight_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FloatLight_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloatLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FloatLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06020D60 RID: 134496 RVA: 0x008DE6A6 File Offset: 0x008DC8A6
		protected BP_FloatLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF3F RID: 65343
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x0400FF40 RID: 65344
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_FloatLight.BP_FloatLight_C";

		// Token: 0x0400FF41 RID: 65345
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF42 RID: 65346
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF43 RID: 65347
		internal static int __PropertyOffset_0;

		// Token: 0x0400FF44 RID: 65348
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x02009C42 RID: 40002
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x040312F3 RID: 201459
			[FieldOffset(0)]
			public int __Result;
		}
	}
}
