using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x02003B42 RID: 15170
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/BP_MaterialRuntimeParUpdate.BP_MaterialRuntimeParUpdate_C")]
	[UnrealStructLayout(1664, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1664)]
	public class BP_MaterialRuntimeParUpdate_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060218FE RID: 137470 RVA: 0x008EFA9A File Offset: 0x008EDC9A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MaterialRuntimeParUpdate_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Interaction/BP_MaterialRuntimeParUpdate.BP_MaterialRuntimeParUpdate_C");
			}
			return BP_MaterialRuntimeParUpdate_C._ClassPtr;
		}

		// Token: 0x060218FF RID: 137471 RVA: 0x008EFAC0 File Offset: 0x008EDCC0
		public BP_MaterialRuntimeParUpdate_C() : this(BuiltinUtils.AllocNativeUObject(BP_MaterialRuntimeParUpdate_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021900 RID: 137472 RVA: 0x008EFAE8 File Offset: 0x008EDCE8
		[NullableContext(1)]
		public BP_MaterialRuntimeParUpdate_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MaterialRuntimeParUpdate_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003736 RID: 14134
		// (get) Token: 0x06021901 RID: 137473 RVA: 0x008EFB1B File Offset: 0x008EDD1B
		// (set) Token: 0x06021902 RID: 137474 RVA: 0x008EFB2F File Offset: 0x008EDD2F
		public unsafe USceneComponent Target
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MaterialRuntimeParUpdate_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MaterialRuntimeParUpdate_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003737 RID: 14135
		// (get) Token: 0x06021903 RID: 137475 RVA: 0x008EFB44 File Offset: 0x008EDD44
		// (set) Token: 0x06021904 RID: 137476 RVA: 0x008EFB58 File Offset: 0x008EDD58
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MaterialRuntimeParUpdate_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MaterialRuntimeParUpdate_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003738 RID: 14136
		// (get) Token: 0x06021905 RID: 137477 RVA: 0x008EFB6D File Offset: 0x008EDD6D
		// (set) Token: 0x06021906 RID: 137478 RVA: 0x008EFB7D File Offset: 0x008EDD7D
		public unsafe int Material_Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17003739 RID: 14137
		// (get) Token: 0x06021907 RID: 137479 RVA: 0x008EFB8E File Offset: 0x008EDD8E
		// (set) Token: 0x06021908 RID: 137480 RVA: 0x008EFBA2 File Offset: 0x008EDDA2
		public unsafe FLinearColor NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700373A RID: 14138
		// (get) Token: 0x06021909 RID: 137481 RVA: 0x008EFBB7 File Offset: 0x008EDDB7
		// (set) Token: 0x0602190A RID: 137482 RVA: 0x008EFBCB File Offset: 0x008EDDCB
		public unsafe ItemMaterialControllerActorData DA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ItemMaterialControllerActorData>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MaterialRuntimeParUpdate_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MaterialRuntimeParUpdate_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700373B RID: 14139
		// (get) Token: 0x0602190B RID: 137483 RVA: 0x008EFBE0 File Offset: 0x008EDDE0
		// (set) Token: 0x0602190C RID: 137484 RVA: 0x008EFC19 File Offset: 0x008EDE19
		[Nullable(1)]
		public TMap<FName, FKuroCurveFloat> Custom_Scalar_Par_Map
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveFloat> result;
				if ((result = this._Custom_Scalar_Par_Map) == null)
				{
					result = (this._Custom_Scalar_Par_Map = new TMap<FName, FKuroCurveFloat>(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Custom_Scalar_Par_Map.CopyAssign(value);
			}
		}

		// Token: 0x1700373C RID: 14140
		// (get) Token: 0x0602190D RID: 137485 RVA: 0x008EFC27 File Offset: 0x008EDE27
		// (set) Token: 0x0602190E RID: 137486 RVA: 0x008EFC37 File Offset: 0x008EDE37
		public unsafe float DateTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700373D RID: 14141
		// (get) Token: 0x0602190F RID: 137487 RVA: 0x008EFC48 File Offset: 0x008EDE48
		// (set) Token: 0x06021910 RID: 137488 RVA: 0x008EFC5C File Offset: 0x008EDE5C
		public unsafe FName FloatParam_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700373E RID: 14142
		// (get) Token: 0x06021911 RID: 137489 RVA: 0x008EFC71 File Offset: 0x008EDE71
		// (set) Token: 0x06021912 RID: 137490 RVA: 0x008EFC81 File Offset: 0x008EDE81
		public unsafe float FloatParam_Value_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700373F RID: 14143
		// (get) Token: 0x06021913 RID: 137491 RVA: 0x008EFC92 File Offset: 0x008EDE92
		// (set) Token: 0x06021914 RID: 137492 RVA: 0x008EFCA6 File Offset: 0x008EDEA6
		public unsafe FName VectorParam_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003740 RID: 14144
		// (get) Token: 0x06021915 RID: 137493 RVA: 0x008EFCBB File Offset: 0x008EDEBB
		// (set) Token: 0x06021916 RID: 137494 RVA: 0x008EFCCF File Offset: 0x008EDECF
		public unsafe FLinearColor VectorParam_Value_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003741 RID: 14145
		// (get) Token: 0x06021917 RID: 137495 RVA: 0x008EFCE4 File Offset: 0x008EDEE4
		// (set) Token: 0x06021918 RID: 137496 RVA: 0x008EFD1D File Offset: 0x008EDF1D
		[Nullable(1)]
		public TArray<UMaterialInstance> Materials
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstance> result;
				if ((result = this._Materials) == null)
				{
					result = (this._Materials = new TArray<UMaterialInstance>(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_12, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Materials.CopyAssign(value);
			}
		}

		// Token: 0x17003742 RID: 14146
		// (get) Token: 0x06021919 RID: 137497 RVA: 0x008EFD2B File Offset: 0x008EDF2B
		// (set) Token: 0x0602191A RID: 137498 RVA: 0x008EFD3B File Offset: 0x008EDF3B
		public unsafe bool IsPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003743 RID: 14147
		// (get) Token: 0x0602191B RID: 137499 RVA: 0x008EFD4C File Offset: 0x008EDF4C
		// (set) Token: 0x0602191C RID: 137500 RVA: 0x008EFD5C File Offset: 0x008EDF5C
		public unsafe float Time_Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003744 RID: 14148
		// (get) Token: 0x0602191D RID: 137501 RVA: 0x008EFD6D File Offset: 0x008EDF6D
		// (set) Token: 0x0602191E RID: 137502 RVA: 0x008EFD7D File Offset: 0x008EDF7D
		public unsafe float MaxDurationTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003745 RID: 14149
		// (get) Token: 0x0602191F RID: 137503 RVA: 0x008EFD8E File Offset: 0x008EDF8E
		// (set) Token: 0x06021920 RID: 137504 RVA: 0x008EFD9E File Offset: 0x008EDF9E
		public unsafe float Timer_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x06021921 RID: 137505 RVA: 0x008EFDAF File Offset: 0x008EDFAF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CleanArray()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MaterialRuntimeParUpdate_C.__CleanArray_NativeFunctionPtr, null);
		}

		// Token: 0x06021922 RID: 137506 RVA: 0x008EFDC3 File Offset: 0x008EDFC3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Play()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MaterialRuntimeParUpdate_C.__Play_NativeFunctionPtr, null);
		}

		// Token: 0x06021923 RID: 137507 RVA: 0x008EFDD7 File Offset: 0x008EDFD7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_Initialize()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MaterialRuntimeParUpdate_C.__Set_Initialize_NativeFunctionPtr, null);
		}

		// Token: 0x06021924 RID: 137508 RVA: 0x008EFDEB File Offset: 0x008EDFEB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MaterialRuntimeParUpdate_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021925 RID: 137509 RVA: 0x008EFDFF File Offset: 0x008EDFFF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MaterialRuntimeParUpdate_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021926 RID: 137510 RVA: 0x008EFE14 File Offset: 0x008EE014
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MaterialRuntimeParUpdate_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021927 RID: 137511 RVA: 0x008EFE28 File Offset: 0x008EE028
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MaterialRuntimeParUpdate_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021928 RID: 137512 RVA: 0x008EFE40 File Offset: 0x008EE040
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_MaterialRuntimeParUpdate_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MaterialRuntimeParUpdate_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MaterialRuntimeParUpdate_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MaterialRuntimeParUpdate_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MaterialRuntimeParUpdate_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021929 RID: 137513 RVA: 0x008EFE88 File Offset: 0x008EE088
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_MaterialRuntimeParUpdate_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MaterialRuntimeParUpdate_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MaterialRuntimeParUpdate_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MaterialRuntimeParUpdate_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MaterialRuntimeParUpdate_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602192A RID: 137514 RVA: 0x008EFECF File Offset: 0x008EE0CF
		protected BP_MaterialRuntimeParUpdate_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040105C8 RID: 67016
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/BP_MaterialRuntimeParUpdate.BP_MaterialRuntimeParUpdate_C";

		// Token: 0x040105C9 RID: 67017
		private static IntPtr _ClassPtr;

		// Token: 0x040105CA RID: 67018
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040105CB RID: 67019
		internal static int __PropertyOffset_1;

		// Token: 0x040105CC RID: 67020
		internal static int __PropertyOffset_2;

		// Token: 0x040105CD RID: 67021
		internal static int __PropertyOffset_3;

		// Token: 0x040105CE RID: 67022
		internal static int __PropertyOffset_4;

		// Token: 0x040105CF RID: 67023
		internal static int __PropertyOffset_5;

		// Token: 0x040105D0 RID: 67024
		internal static int __PropertyOffset_6;

		// Token: 0x040105D1 RID: 67025
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _Custom_Scalar_Par_Map;

		// Token: 0x040105D2 RID: 67026
		internal static int __PropertyOffset_7;

		// Token: 0x040105D3 RID: 67027
		internal static int __PropertyOffset_8;

		// Token: 0x040105D4 RID: 67028
		internal static int __PropertyOffset_9;

		// Token: 0x040105D5 RID: 67029
		internal static int __PropertyOffset_10;

		// Token: 0x040105D6 RID: 67030
		internal static int __PropertyOffset_11;

		// Token: 0x040105D7 RID: 67031
		internal static int __PropertyOffset_12;

		// Token: 0x040105D8 RID: 67032
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _Materials;

		// Token: 0x040105D9 RID: 67033
		internal static int __PropertyOffset_13;

		// Token: 0x040105DA RID: 67034
		internal static int __PropertyOffset_14;

		// Token: 0x040105DB RID: 67035
		internal static int __PropertyOffset_15;

		// Token: 0x040105DC RID: 67036
		internal static int __PropertyOffset_16;

		// Token: 0x040105DD RID: 67037
		private static IntPtr __CleanArray_NativeFunctionPtr;

		// Token: 0x040105DE RID: 67038
		private static IntPtr __Play_NativeFunctionPtr;

		// Token: 0x040105DF RID: 67039
		private static IntPtr __Set_Initialize_NativeFunctionPtr;

		// Token: 0x040105E0 RID: 67040
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040105E1 RID: 67041
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040105E2 RID: 67042
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009CAB RID: 40107
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031378 RID: 201592
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
