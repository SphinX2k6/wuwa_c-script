using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.ClothWindField
{
	// Token: 0x02003DF0 RID: 15856
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/ClothWindField/BP_Cloth.BP_Cloth_C")]
	[UnrealStructLayout(1112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1112)]
	public class BP_Cloth_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027904 RID: 162052 RVA: 0x00994D24 File Offset: 0x00992F24
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Cloth_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/ClothWindField/BP_Cloth.BP_Cloth_C");
			}
			return BP_Cloth_C._ClassPtr;
		}

		// Token: 0x06027905 RID: 162053 RVA: 0x00994D48 File Offset: 0x00992F48
		public BP_Cloth_C() : this(BuiltinUtils.AllocNativeUObject(BP_Cloth_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027906 RID: 162054 RVA: 0x00994D70 File Offset: 0x00992F70
		[NullableContext(1)]
		public BP_Cloth_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Cloth_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170058C1 RID: 22721
		// (get) Token: 0x06027907 RID: 162055 RVA: 0x00994DA3 File Offset: 0x00992FA3
		// (set) Token: 0x06027908 RID: 162056 RVA: 0x00994DB7 File Offset: 0x00992FB7
		public unsafe UKuroCSClothWindComponent KuroCSClothWind2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroCSClothWindComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cloth_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cloth_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170058C2 RID: 22722
		// (get) Token: 0x06027909 RID: 162057 RVA: 0x00994DCC File Offset: 0x00992FCC
		// (set) Token: 0x0602790A RID: 162058 RVA: 0x00994DE0 File Offset: 0x00992FE0
		public unsafe UKuroCSClothWindComponent KuroCSClothWind1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroCSClothWindComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cloth_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cloth_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170058C3 RID: 22723
		// (get) Token: 0x0602790B RID: 162059 RVA: 0x00994DF5 File Offset: 0x00992FF5
		// (set) Token: 0x0602790C RID: 162060 RVA: 0x00994E09 File Offset: 0x00993009
		public unsafe UKuroCSClothWindComponent KuroCSClothWind
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroCSClothWindComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cloth_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cloth_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170058C4 RID: 22724
		// (get) Token: 0x0602790D RID: 162061 RVA: 0x00994E1E File Offset: 0x0099301E
		// (set) Token: 0x0602790E RID: 162062 RVA: 0x00994E32 File Offset: 0x00993032
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cloth_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cloth_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170058C5 RID: 22725
		// (get) Token: 0x0602790F RID: 162063 RVA: 0x00994E47 File Offset: 0x00993047
		// (set) Token: 0x06027910 RID: 162064 RVA: 0x00994E5B File Offset: 0x0099305B
		public unsafe FVector Grid_Start_Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cloth_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cloth_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170058C6 RID: 22726
		// (get) Token: 0x06027911 RID: 162065 RVA: 0x00994E70 File Offset: 0x00993070
		// (set) Token: 0x06027912 RID: 162066 RVA: 0x00994E84 File Offset: 0x00993084
		public unsafe UTextureRenderTarget2D WindAtlasRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cloth_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cloth_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x06027913 RID: 162067 RVA: 0x00994E99 File Offset: 0x00993099
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloth_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06027914 RID: 162068 RVA: 0x00994EAD File Offset: 0x009930AD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloth_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027915 RID: 162069 RVA: 0x00994EC2 File Offset: 0x009930C2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloth_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x06027916 RID: 162070 RVA: 0x00994ED6 File Offset: 0x009930D6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloth_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027917 RID: 162071 RVA: 0x00994EEC File Offset: 0x009930EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Cloth_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cloth_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloth_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloth_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloth_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027918 RID: 162072 RVA: 0x00994F34 File Offset: 0x00993134
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Cloth_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cloth_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cloth_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cloth_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloth_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027919 RID: 162073 RVA: 0x00994F7B File Offset: 0x0099317B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloth_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602791A RID: 162074 RVA: 0x00994F8F File Offset: 0x0099318F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloth_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602791B RID: 162075 RVA: 0x00994FA4 File Offset: 0x009931A4
		protected BP_Cloth_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014016 RID: 81942
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/ClothWindField/BP_Cloth.BP_Cloth_C";

		// Token: 0x04014017 RID: 81943
		private static IntPtr _ClassPtr;

		// Token: 0x04014018 RID: 81944
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014019 RID: 81945
		internal static int __PropertyOffset_1;

		// Token: 0x0401401A RID: 81946
		internal static int __PropertyOffset_2;

		// Token: 0x0401401B RID: 81947
		internal static int __PropertyOffset_3;

		// Token: 0x0401401C RID: 81948
		internal static int __PropertyOffset_4;

		// Token: 0x0401401D RID: 81949
		internal static int __PropertyOffset_5;

		// Token: 0x0401401E RID: 81950
		internal static int __PropertyOffset_6;

		// Token: 0x0401401F RID: 81951
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04014020 RID: 81952
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x04014021 RID: 81953
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04014022 RID: 81954
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0200A24B RID: 41547
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031EDC RID: 204508
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
