using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUClothSimulation
{
	// Token: 0x02003CAB RID: 15531
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUClothSimulation/BP_PhysicCloth_v1.BP_PhysicCloth_v1_C")]
	[UnrealStructLayout(1144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1138)]
	public class BP_PhysicCloth_v1_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602483B RID: 149563 RVA: 0x00940D2C File Offset: 0x0093EF2C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PhysicCloth_v1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GPUClothSimulation/BP_PhysicCloth_v1.BP_PhysicCloth_v1_C");
			}
			return BP_PhysicCloth_v1_C._ClassPtr;
		}

		// Token: 0x0602483C RID: 149564 RVA: 0x00940D50 File Offset: 0x0093EF50
		public BP_PhysicCloth_v1_C() : this(BuiltinUtils.AllocNativeUObject(BP_PhysicCloth_v1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602483D RID: 149565 RVA: 0x00940D78 File Offset: 0x0093EF78
		[NullableContext(1)]
		public BP_PhysicCloth_v1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PhysicCloth_v1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004779 RID: 18297
		// (get) Token: 0x0602483E RID: 149566 RVA: 0x00940DAB File Offset: 0x0093EFAB
		// (set) Token: 0x0602483F RID: 149567 RVA: 0x00940DBF File Offset: 0x0093EFBF
		public unsafe UStaticMeshComponent CollsionCube
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v1_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v1_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700477A RID: 18298
		// (get) Token: 0x06024840 RID: 149568 RVA: 0x00940DD4 File Offset: 0x0093EFD4
		// (set) Token: 0x06024841 RID: 149569 RVA: 0x00940DE8 File Offset: 0x0093EFE8
		public unsafe UNiagaraComponent NS_cloth
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v1_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v1_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700477B RID: 18299
		// (get) Token: 0x06024842 RID: 149570 RVA: 0x00940DFD File Offset: 0x0093EFFD
		// (set) Token: 0x06024843 RID: 149571 RVA: 0x00940E11 File Offset: 0x0093F011
		public unsafe UStaticMeshComponent SM_Ves_Clo_01AS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v1_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v1_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700477C RID: 18300
		// (get) Token: 0x06024844 RID: 149572 RVA: 0x00940E26 File Offset: 0x0093F026
		// (set) Token: 0x06024845 RID: 149573 RVA: 0x00940E3A File Offset: 0x0093F03A
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v1_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v1_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700477D RID: 18301
		// (get) Token: 0x06024846 RID: 149574 RVA: 0x00940E4F File Offset: 0x0093F04F
		// (set) Token: 0x06024847 RID: 149575 RVA: 0x00940E63 File Offset: 0x0093F063
		public unsafe UMaterialInterface Static_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v1_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v1_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700477E RID: 18302
		// (get) Token: 0x06024848 RID: 149576 RVA: 0x00940E78 File Offset: 0x0093F078
		// (set) Token: 0x06024849 RID: 149577 RVA: 0x00940E8C File Offset: 0x0093F08C
		public unsafe UTextureRenderTarget2D RT_Pos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v1_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v1_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x1700477F RID: 18303
		// (get) Token: 0x0602484A RID: 149578 RVA: 0x00940EA1 File Offset: 0x0093F0A1
		// (set) Token: 0x0602484B RID: 149579 RVA: 0x00940EB1 File Offset: 0x0093F0B1
		public unsafe int YCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicCloth_v1_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicCloth_v1_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004780 RID: 18304
		// (get) Token: 0x0602484C RID: 149580 RVA: 0x00940EC2 File Offset: 0x0093F0C2
		// (set) Token: 0x0602484D RID: 149581 RVA: 0x00940ED2 File Offset: 0x0093F0D2
		public unsafe int XCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicCloth_v1_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicCloth_v1_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004781 RID: 18305
		// (get) Token: 0x0602484E RID: 149582 RVA: 0x00940EE3 File Offset: 0x0093F0E3
		// (set) Token: 0x0602484F RID: 149583 RVA: 0x00940EF3 File Offset: 0x0093F0F3
		public unsafe float Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicCloth_v1_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicCloth_v1_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004782 RID: 18306
		// (get) Token: 0x06024850 RID: 149584 RVA: 0x00940F04 File Offset: 0x0093F104
		// (set) Token: 0x06024851 RID: 149585 RVA: 0x00940F18 File Offset: 0x0093F118
		public unsafe UMaterialInstanceDynamic DMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v1_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v1_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17004783 RID: 18307
		// (get) Token: 0x06024852 RID: 149586 RVA: 0x00940F2D File Offset: 0x0093F12D
		// (set) Token: 0x06024853 RID: 149587 RVA: 0x00940F3D File Offset: 0x0093F13D
		public unsafe float RestorationRigidity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicCloth_v1_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicCloth_v1_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004784 RID: 18308
		// (get) Token: 0x06024854 RID: 149588 RVA: 0x00940F4E File Offset: 0x0093F14E
		// (set) Token: 0x06024855 RID: 149589 RVA: 0x00940F5E File Offset: 0x0093F15E
		public unsafe float RestorationDamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicCloth_v1_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicCloth_v1_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004785 RID: 18309
		// (get) Token: 0x06024856 RID: 149590 RVA: 0x00940F6F File Offset: 0x0093F16F
		// (set) Token: 0x06024857 RID: 149591 RVA: 0x00940F7F File Offset: 0x0093F17F
		public unsafe bool EnableRestoration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicCloth_v1_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicCloth_v1_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004786 RID: 18310
		// (get) Token: 0x06024858 RID: 149592 RVA: 0x00940F90 File Offset: 0x0093F190
		// (set) Token: 0x06024859 RID: 149593 RVA: 0x00940FA0 File Offset: 0x0093F1A0
		public unsafe bool EnableWpo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicCloth_v1_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicCloth_v1_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602485A RID: 149594 RVA: 0x00940FB1 File Offset: 0x0093F1B1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Input_Niagara()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicCloth_v1_C.__Input_Niagara_NativeFunctionPtr, null);
		}

		// Token: 0x0602485B RID: 149595 RVA: 0x00940FC5 File Offset: 0x0093F1C5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Input_Parameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicCloth_v1_C.__Input_Parameters_NativeFunctionPtr, null);
		}

		// Token: 0x0602485C RID: 149596 RVA: 0x00940FD9 File Offset: 0x0093F1D9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicCloth_v1_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602485D RID: 149597 RVA: 0x00940FED File Offset: 0x0093F1ED
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicCloth_v1_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602485E RID: 149598 RVA: 0x00941002 File Offset: 0x0093F202
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicCloth_v1_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602485F RID: 149599 RVA: 0x00941016 File Offset: 0x0093F216
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicCloth_v1_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024860 RID: 149600 RVA: 0x0094102C File Offset: 0x0093F22C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_PhysicCloth_v1_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PhysicCloth_v1_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PhysicCloth_v1_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PhysicCloth_v1_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicCloth_v1_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024861 RID: 149601 RVA: 0x00941074 File Offset: 0x0093F274
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_PhysicCloth_v1_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PhysicCloth_v1_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PhysicCloth_v1_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PhysicCloth_v1_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicCloth_v1_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024862 RID: 149602 RVA: 0x009410BB File Offset: 0x0093F2BB
		protected BP_PhysicCloth_v1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012210 RID: 74256
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUClothSimulation/BP_PhysicCloth_v1.BP_PhysicCloth_v1_C";

		// Token: 0x04012211 RID: 74257
		private static IntPtr _ClassPtr;

		// Token: 0x04012212 RID: 74258
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012213 RID: 74259
		internal static int __PropertyOffset_1;

		// Token: 0x04012214 RID: 74260
		internal static int __PropertyOffset_2;

		// Token: 0x04012215 RID: 74261
		internal static int __PropertyOffset_3;

		// Token: 0x04012216 RID: 74262
		internal static int __PropertyOffset_4;

		// Token: 0x04012217 RID: 74263
		internal static int __PropertyOffset_5;

		// Token: 0x04012218 RID: 74264
		internal static int __PropertyOffset_6;

		// Token: 0x04012219 RID: 74265
		internal static int __PropertyOffset_7;

		// Token: 0x0401221A RID: 74266
		internal static int __PropertyOffset_8;

		// Token: 0x0401221B RID: 74267
		internal static int __PropertyOffset_9;

		// Token: 0x0401221C RID: 74268
		internal static int __PropertyOffset_10;

		// Token: 0x0401221D RID: 74269
		internal static int __PropertyOffset_11;

		// Token: 0x0401221E RID: 74270
		internal static int __PropertyOffset_12;

		// Token: 0x0401221F RID: 74271
		internal static int __PropertyOffset_13;

		// Token: 0x04012220 RID: 74272
		internal static int __PropertyOffset_14;

		// Token: 0x04012221 RID: 74273
		private static IntPtr __Input_Niagara_NativeFunctionPtr;

		// Token: 0x04012222 RID: 74274
		private static IntPtr __Input_Parameters_NativeFunctionPtr;

		// Token: 0x04012223 RID: 74275
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012224 RID: 74276
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012225 RID: 74277
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009F30 RID: 40752
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040318B2 RID: 202930
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
