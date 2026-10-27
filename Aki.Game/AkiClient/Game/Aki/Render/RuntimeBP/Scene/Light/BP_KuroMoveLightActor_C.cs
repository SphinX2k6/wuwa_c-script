using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B0E RID: 15118
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_KuroMoveLightActor.BP_KuroMoveLightActor_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class BP_KuroMoveLightActor_C : AKuroMoveLightActor, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06020F65 RID: 135013 RVA: 0x008E14D0 File Offset: 0x008DF6D0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroMoveLightActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_KuroMoveLightActor.BP_KuroMoveLightActor_C");
			}
			return BP_KuroMoveLightActor_C._ClassPtr;
		}

		// Token: 0x06020F66 RID: 135014 RVA: 0x008E14F4 File Offset: 0x008DF6F4
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_KuroMoveLightActor_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x06020F67 RID: 135015 RVA: 0x008E14FC File Offset: 0x008DF6FC
		public BP_KuroMoveLightActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroMoveLightActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020F68 RID: 135016 RVA: 0x008E1524 File Offset: 0x008DF724
		[NullableContext(1)]
		public BP_KuroMoveLightActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroMoveLightActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06020F69 RID: 135017 RVA: 0x008E1558 File Offset: 0x008DF758
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_KuroMoveLightActor_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_KuroMoveLightActor_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroMoveLightActor_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMoveLightActor_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMoveLightActor_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06020F6A RID: 135018 RVA: 0x008E15A0 File Offset: 0x008DF7A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_KuroMoveLightActor_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_KuroMoveLightActor_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroMoveLightActor_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMoveLightActor_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroMoveLightActor_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06020F6B RID: 135019 RVA: 0x008E15E6 File Offset: 0x008DF7E6
		protected BP_KuroMoveLightActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010068 RID: 65640
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x04010069 RID: 65641
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_KuroMoveLightActor.BP_KuroMoveLightActor_C";

		// Token: 0x0401006A RID: 65642
		private static IntPtr _ClassPtr;

		// Token: 0x0401006B RID: 65643
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401006C RID: 65644
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x02009C52 RID: 40018
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x04031306 RID: 201478
			[FieldOffset(0)]
			public int __Result;
		}
	}
}
