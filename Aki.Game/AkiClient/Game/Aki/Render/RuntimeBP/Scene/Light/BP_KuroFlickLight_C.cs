using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B09 RID: 15113
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_KuroFlickLight.BP_KuroFlickLight_C")]
	[UnrealStructLayout(1504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1504)]
	public class BP_KuroFlickLight_C : AKuroFlickerLightActor, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06020EF3 RID: 134899 RVA: 0x008E08AC File Offset: 0x008DEAAC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroFlickLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_KuroFlickLight.BP_KuroFlickLight_C");
			}
			return BP_KuroFlickLight_C._ClassPtr;
		}

		// Token: 0x06020EF4 RID: 134900 RVA: 0x008E08D0 File Offset: 0x008DEAD0
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_KuroFlickLight_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x06020EF5 RID: 134901 RVA: 0x008E08D8 File Offset: 0x008DEAD8
		public BP_KuroFlickLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroFlickLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020EF6 RID: 134902 RVA: 0x008E0900 File Offset: 0x008DEB00
		[NullableContext(1)]
		public BP_KuroFlickLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroFlickLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06020EF7 RID: 134903 RVA: 0x008E0934 File Offset: 0x008DEB34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_KuroFlickLight_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_KuroFlickLight_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroFlickLight_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroFlickLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroFlickLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06020EF8 RID: 134904 RVA: 0x008E097C File Offset: 0x008DEB7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_KuroFlickLight_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_KuroFlickLight_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroFlickLight_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroFlickLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroFlickLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06020EF9 RID: 134905 RVA: 0x008E09C2 File Offset: 0x008DEBC2
		protected BP_KuroFlickLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401001E RID: 65566
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x0401001F RID: 65567
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_KuroFlickLight.BP_KuroFlickLight_C";

		// Token: 0x04010020 RID: 65568
		private static IntPtr _ClassPtr;

		// Token: 0x04010021 RID: 65569
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010022 RID: 65570
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x02009C4E RID: 40014
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x04031302 RID: 201474
			[FieldOffset(0)]
			public int __Result;
		}
	}
}
