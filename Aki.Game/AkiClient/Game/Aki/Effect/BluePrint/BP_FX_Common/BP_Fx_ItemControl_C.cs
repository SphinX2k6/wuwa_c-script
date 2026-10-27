using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.BluePrint.BP_FX_Common
{
	// Token: 0x02003E7E RID: 15998
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_ItemControl.BP_Fx_ItemControl_C")]
	[UnrealStructLayout(1160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1156)]
	public class BP_Fx_ItemControl_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060285A1 RID: 165281 RVA: 0x009AA6A0 File Offset: 0x009A88A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Fx_ItemControl_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_ItemControl.BP_Fx_ItemControl_C");
			}
			return BP_Fx_ItemControl_C._ClassPtr;
		}

		// Token: 0x060285A2 RID: 165282 RVA: 0x009AA6C4 File Offset: 0x009A88C4
		public BP_Fx_ItemControl_C() : this(BuiltinUtils.AllocNativeUObject(BP_Fx_ItemControl_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060285A3 RID: 165283 RVA: 0x009AA6EC File Offset: 0x009A88EC
		[NullableContext(1)]
		public BP_Fx_ItemControl_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Fx_ItemControl_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D4E RID: 23886
		// (get) Token: 0x060285A4 RID: 165284 RVA: 0x009AA71F File Offset: 0x009A891F
		// (set) Token: 0x060285A5 RID: 165285 RVA: 0x009AA733 File Offset: 0x009A8933
		public unsafe UNiagaraComponent NS_Fx_ControlSpline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_ItemControl_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_ItemControl_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005D4F RID: 23887
		// (get) Token: 0x060285A6 RID: 165286 RVA: 0x009AA748 File Offset: 0x009A8948
		// (set) Token: 0x060285A7 RID: 165287 RVA: 0x009AA75C File Offset: 0x009A895C
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_ItemControl_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_ItemControl_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005D50 RID: 23888
		// (get) Token: 0x060285A8 RID: 165288 RVA: 0x009AA771 File Offset: 0x009A8971
		// (set) Token: 0x060285A9 RID: 165289 RVA: 0x009AA785 File Offset: 0x009A8985
		public unsafe USceneComponent Scene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_ItemControl_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_ItemControl_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005D51 RID: 23889
		// (get) Token: 0x060285AA RID: 165290 RVA: 0x009AA79A File Offset: 0x009A899A
		// (set) Token: 0x060285AB RID: 165291 RVA: 0x009AA7AE File Offset: 0x009A89AE
		public unsafe FVectorDouble Item_Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_ItemControl_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_ItemControl_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005D52 RID: 23890
		// (get) Token: 0x060285AC RID: 165292 RVA: 0x009AA7C3 File Offset: 0x009A89C3
		// (set) Token: 0x060285AD RID: 165293 RVA: 0x009AA7D7 File Offset: 0x009A89D7
		public unsafe FVectorDouble Controller_Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_ItemControl_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_ItemControl_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005D53 RID: 23891
		// (get) Token: 0x060285AE RID: 165294 RVA: 0x009AA7EC File Offset: 0x009A89EC
		// (set) Token: 0x060285AF RID: 165295 RVA: 0x009AA800 File Offset: 0x009A8A00
		public unsafe FVector Controller_Forward
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_ItemControl_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_ItemControl_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005D54 RID: 23892
		// (get) Token: 0x060285B0 RID: 165296 RVA: 0x009AA815 File Offset: 0x009A8A15
		// (set) Token: 0x060285B1 RID: 165297 RVA: 0x009AA825 File Offset: 0x009A8A25
		public unsafe bool NeedUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_ItemControl_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_ItemControl_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D55 RID: 23893
		// (get) Token: 0x060285B2 RID: 165298 RVA: 0x009AA836 File Offset: 0x009A8A36
		// (set) Token: 0x060285B3 RID: 165299 RVA: 0x009AA846 File Offset: 0x009A8A46
		public unsafe float ForceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_ItemControl_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_ItemControl_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005D56 RID: 23894
		// (get) Token: 0x060285B4 RID: 165300 RVA: 0x009AA857 File Offset: 0x009A8A57
		// (set) Token: 0x060285B5 RID: 165301 RVA: 0x009AA867 File Offset: 0x009A8A67
		public unsafe float ForceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_ItemControl_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_ItemControl_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005D57 RID: 23895
		// (get) Token: 0x060285B6 RID: 165302 RVA: 0x009AA878 File Offset: 0x009A8A78
		// (set) Token: 0x060285B7 RID: 165303 RVA: 0x009AA888 File Offset: 0x009A8A88
		public unsafe float LengthAdjust
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_ItemControl_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_ItemControl_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x060285B8 RID: 165304 RVA: 0x009AA89C File Offset: 0x009A8A9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalculateTangents(ref FVector ControllerTangent, ref FVector ItemTangent)
		{
			BP_Fx_ItemControl_C.__CalculateTangents_FunctionParams* ptr = stackalloc BP_Fx_ItemControl_C.__CalculateTangents_FunctionParams[(UIntPtr)327] + 15L / (long)sizeof(BP_Fx_ItemControl_C.__CalculateTangents_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_ItemControl_C.__CalculateTangents_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ControllerTangent = ControllerTangent;
			ptr->ItemTangent = ItemTangent;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_ItemControl_C.__CalculateTangents_NativeFunctionPtr, (void*)ptr);
			ControllerTangent = ptr->ControllerTangent;
			ItemTangent = ptr->ItemTangent;
		}

		// Token: 0x060285B9 RID: 165305 RVA: 0x009AA910 File Offset: 0x009A8B10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetParameter(FVectorDouble ItemPosition)
		{
			BP_Fx_ItemControl_C.__SetParameter_FunctionParams* ptr = stackalloc BP_Fx_ItemControl_C.__SetParameter_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_Fx_ItemControl_C.__SetParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_ItemControl_C.__SetParameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ItemPosition = ItemPosition;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_ItemControl_C.__SetParameter_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060285BA RID: 165306 RVA: 0x009AA956 File Offset: 0x009A8B56
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_ItemControl_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060285BB RID: 165307 RVA: 0x009AA96A File Offset: 0x009A8B6A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Fx_ItemControl_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060285BC RID: 165308 RVA: 0x009AA980 File Offset: 0x009A8B80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Fx_ItemControl_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Fx_ItemControl_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_ItemControl_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_ItemControl_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_ItemControl_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060285BD RID: 165309 RVA: 0x009AA9C8 File Offset: 0x009A8BC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Fx_ItemControl_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Fx_ItemControl_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_ItemControl_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_ItemControl_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Fx_ItemControl_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060285BE RID: 165310 RVA: 0x009AAA0F File Offset: 0x009A8C0F
		protected BP_Fx_ItemControl_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014907 RID: 84231
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_ItemControl.BP_Fx_ItemControl_C";

		// Token: 0x04014908 RID: 84232
		private static IntPtr _ClassPtr;

		// Token: 0x04014909 RID: 84233
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401490A RID: 84234
		internal static int __PropertyOffset_1;

		// Token: 0x0401490B RID: 84235
		internal static int __PropertyOffset_2;

		// Token: 0x0401490C RID: 84236
		internal static int __PropertyOffset_3;

		// Token: 0x0401490D RID: 84237
		internal static int __PropertyOffset_4;

		// Token: 0x0401490E RID: 84238
		internal static int __PropertyOffset_5;

		// Token: 0x0401490F RID: 84239
		internal static int __PropertyOffset_6;

		// Token: 0x04014910 RID: 84240
		internal static int __PropertyOffset_7;

		// Token: 0x04014911 RID: 84241
		internal static int __PropertyOffset_8;

		// Token: 0x04014912 RID: 84242
		internal static int __PropertyOffset_9;

		// Token: 0x04014913 RID: 84243
		internal static int __PropertyOffset_10;

		// Token: 0x04014914 RID: 84244
		private static IntPtr __CalculateTangents_NativeFunctionPtr;

		// Token: 0x04014915 RID: 84245
		private static IntPtr __SetParameter_NativeFunctionPtr;

		// Token: 0x04014916 RID: 84246
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04014917 RID: 84247
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A2D2 RID: 41682
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 312)]
		protected ref struct __CalculateTangents_FunctionParams
		{
			// Token: 0x04032014 RID: 204820
			[FieldOffset(0)]
			public FVector ControllerTangent;

			// Token: 0x04032015 RID: 204821
			[FieldOffset(12)]
			public FVector ItemTangent;
		}

		// Token: 0x0200A2D3 RID: 41683
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __SetParameter_FunctionParams
		{
			// Token: 0x04032016 RID: 204822
			[FieldOffset(0)]
			public FVectorDouble ItemPosition;
		}

		// Token: 0x0200A2D4 RID: 41684
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04032017 RID: 204823
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
