using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common
{
	// Token: 0x02003B60 RID: 15200
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/BP_KuroSmartLight.BP_KuroSmartLight_C")]
	[UnrealStructLayout(1264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1257)]
	public class BP_KuroSmartLight_C : AKuroSmartLightActor, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06021BA2 RID: 138146 RVA: 0x008F42DC File Offset: 0x008F24DC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroSmartLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/BP_KuroSmartLight.BP_KuroSmartLight_C");
			}
			return BP_KuroSmartLight_C._ClassPtr;
		}

		// Token: 0x06021BA3 RID: 138147 RVA: 0x008F4300 File Offset: 0x008F2500
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_KuroSmartLight_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x06021BA4 RID: 138148 RVA: 0x008F4308 File Offset: 0x008F2508
		public BP_KuroSmartLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroSmartLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021BA5 RID: 138149 RVA: 0x008F4330 File Offset: 0x008F2530
		[NullableContext(1)]
		public BP_KuroSmartLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroSmartLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170037FE RID: 14334
		// (get) Token: 0x06021BA6 RID: 138150 RVA: 0x008F4363 File Offset: 0x008F2563
		// (set) Token: 0x06021BA7 RID: 138151 RVA: 0x008F4377 File Offset: 0x008F2577
		[Nullable(2)]
		public unsafe UBillboardComponent Billboard
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroSmartLight_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroSmartLight_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170037FF RID: 14335
		// (get) Token: 0x06021BA8 RID: 138152 RVA: 0x008F438C File Offset: 0x008F258C
		// (set) Token: 0x06021BA9 RID: 138153 RVA: 0x008F43A0 File Offset: 0x008F25A0
		[Nullable(2)]
		public unsafe UAkAudioEvent AudioEventLightOn
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroSmartLight_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroSmartLight_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003800 RID: 14336
		// (get) Token: 0x06021BAA RID: 138154 RVA: 0x008F43B5 File Offset: 0x008F25B5
		// (set) Token: 0x06021BAB RID: 138155 RVA: 0x008F43C9 File Offset: 0x008F25C9
		[Nullable(2)]
		public unsafe UAkAudioEvent AudioEventLightOff
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroSmartLight_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroSmartLight_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003801 RID: 14337
		// (get) Token: 0x06021BAC RID: 138156 RVA: 0x008F43DE File Offset: 0x008F25DE
		// (set) Token: 0x06021BAD RID: 138157 RVA: 0x008F43EE File Offset: 0x008F25EE
		public unsafe bool LightOn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroSmartLight_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroSmartLight_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021BAE RID: 138158 RVA: 0x008F4400 File Offset: 0x008F2600
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_KuroSmartLight_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_KuroSmartLight_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroSmartLight_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroSmartLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSmartLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06021BAF RID: 138159 RVA: 0x008F4448 File Offset: 0x008F2648
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_KuroSmartLight_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_KuroSmartLight_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroSmartLight_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroSmartLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroSmartLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021BB0 RID: 138160 RVA: 0x008F4490 File Offset: 0x008F2690
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnUpdateLightOn(float Time)
		{
			BP_KuroSmartLight_C.__OnUpdateLightOn_FunctionParams* ptr = stackalloc BP_KuroSmartLight_C.__OnUpdateLightOn_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroSmartLight_C.__OnUpdateLightOn_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroSmartLight_C.__OnUpdateLightOn_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Time = Time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSmartLight_C.__OnUpdateLightOn_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021BB1 RID: 138161 RVA: 0x008F44D8 File Offset: 0x008F26D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void OnUpdateLightOn_Implementation(float Time)
		{
			BP_KuroSmartLight_C.__OnUpdateLightOn_FunctionParams* ptr = stackalloc BP_KuroSmartLight_C.__OnUpdateLightOn_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroSmartLight_C.__OnUpdateLightOn_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroSmartLight_C.__OnUpdateLightOn_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Time = Time;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroSmartLight_C.__OnUpdateLightOn_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021BB2 RID: 138162 RVA: 0x008F4520 File Offset: 0x008F2720
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnUpdateLightOff(float Time)
		{
			BP_KuroSmartLight_C.__OnUpdateLightOff_FunctionParams* ptr = stackalloc BP_KuroSmartLight_C.__OnUpdateLightOff_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroSmartLight_C.__OnUpdateLightOff_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroSmartLight_C.__OnUpdateLightOff_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Time = Time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSmartLight_C.__OnUpdateLightOff_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021BB3 RID: 138163 RVA: 0x008F4568 File Offset: 0x008F2768
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void OnUpdateLightOff_Implementation(float Time)
		{
			BP_KuroSmartLight_C.__OnUpdateLightOff_FunctionParams* ptr = stackalloc BP_KuroSmartLight_C.__OnUpdateLightOff_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroSmartLight_C.__OnUpdateLightOff_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroSmartLight_C.__OnUpdateLightOff_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Time = Time;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroSmartLight_C.__OnUpdateLightOff_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021BB4 RID: 138164 RVA: 0x008F45AF File Offset: 0x008F27AF
		protected BP_KuroSmartLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010756 RID: 67414
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x04010757 RID: 67415
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/BP_KuroSmartLight.BP_KuroSmartLight_C";

		// Token: 0x04010758 RID: 67416
		private static IntPtr _ClassPtr;

		// Token: 0x04010759 RID: 67417
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401075A RID: 67418
		internal static int __PropertyOffset_1;

		// Token: 0x0401075B RID: 67419
		internal static int __PropertyOffset_2;

		// Token: 0x0401075C RID: 67420
		internal static int __PropertyOffset_3;

		// Token: 0x0401075D RID: 67421
		internal static int __PropertyOffset_4;

		// Token: 0x0401075E RID: 67422
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x0401075F RID: 67423
		private static IntPtr __OnUpdateLightOn_NativeFunctionPtr;

		// Token: 0x04010760 RID: 67424
		private static IntPtr __OnUpdateLightOff_NativeFunctionPtr;

		// Token: 0x02009CC5 RID: 40133
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x040313AA RID: 201642
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02009CC6 RID: 40134
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __OnUpdateLightOn_FunctionParams
		{
			// Token: 0x040313AB RID: 201643
			[FieldOffset(0)]
			public float Time;
		}

		// Token: 0x02009CC7 RID: 40135
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __OnUpdateLightOff_FunctionParams
		{
			// Token: 0x040313AC RID: 201644
			[FieldOffset(0)]
			public float Time;
		}
	}
}
