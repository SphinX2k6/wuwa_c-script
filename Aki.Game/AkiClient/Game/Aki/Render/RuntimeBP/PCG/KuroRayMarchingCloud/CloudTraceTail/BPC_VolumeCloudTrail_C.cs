using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroRayMarchingCloud.CloudTraceTail
{
	// Token: 0x02003C84 RID: 15492
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/CloudTraceTail/BPC_VolumeCloudTrail.BPC_VolumeCloudTrail_C")]
	[UnrealStructLayout(848, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 838)]
	public class BPC_VolumeCloudTrail_C : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602422C RID: 148012 RVA: 0x00935CE4 File Offset: 0x00933EE4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BPC_VolumeCloudTrail_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/CloudTraceTail/BPC_VolumeCloudTrail.BPC_VolumeCloudTrail_C");
			}
			return BPC_VolumeCloudTrail_C._ClassPtr;
		}

		// Token: 0x0602422D RID: 148013 RVA: 0x00935D08 File Offset: 0x00933F08
		public BPC_VolumeCloudTrail_C() : this(BuiltinUtils.AllocNativeUObject(BPC_VolumeCloudTrail_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602422E RID: 148014 RVA: 0x00935D30 File Offset: 0x00933F30
		[NullableContext(1)]
		public BPC_VolumeCloudTrail_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BPC_VolumeCloudTrail_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700456E RID: 17774
		// (get) Token: 0x0602422F RID: 148015 RVA: 0x00935D63 File Offset: 0x00933F63
		// (set) Token: 0x06024230 RID: 148016 RVA: 0x00935D77 File Offset: 0x00933F77
		public unsafe FVector LastMotionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700456F RID: 17775
		// (get) Token: 0x06024231 RID: 148017 RVA: 0x00935D8C File Offset: 0x00933F8C
		// (set) Token: 0x06024232 RID: 148018 RVA: 0x00935DA0 File Offset: 0x00933FA0
		public unsafe UMaterialInstanceDynamic RTMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BPC_VolumeCloudTrail_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BPC_VolumeCloudTrail_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004570 RID: 17776
		// (get) Token: 0x06024233 RID: 148019 RVA: 0x00935DB5 File Offset: 0x00933FB5
		// (set) Token: 0x06024234 RID: 148020 RVA: 0x00935DC9 File Offset: 0x00933FC9
		public unsafe AActor BindActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BPC_VolumeCloudTrail_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BPC_VolumeCloudTrail_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004571 RID: 17777
		// (get) Token: 0x06024235 RID: 148021 RVA: 0x00935DDE File Offset: 0x00933FDE
		// (set) Token: 0x06024236 RID: 148022 RVA: 0x00935DEE File Offset: 0x00933FEE
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004572 RID: 17778
		// (get) Token: 0x06024237 RID: 148023 RVA: 0x00935DFF File Offset: 0x00933FFF
		// (set) Token: 0x06024238 RID: 148024 RVA: 0x00935E13 File Offset: 0x00934013
		public unsafe UMaterialInstanceDynamic RTMaterial_Pre
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BPC_VolumeCloudTrail_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BPC_VolumeCloudTrail_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004573 RID: 17779
		// (get) Token: 0x06024239 RID: 148025 RVA: 0x00935E28 File Offset: 0x00934028
		// (set) Token: 0x0602423A RID: 148026 RVA: 0x00935E3C File Offset: 0x0093403C
		public unsafe FVectorDouble LastPostion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004574 RID: 17780
		// (get) Token: 0x0602423B RID: 148027 RVA: 0x00935E51 File Offset: 0x00934051
		// (set) Token: 0x0602423C RID: 148028 RVA: 0x00935E61 File Offset: 0x00934061
		public unsafe bool bFadeWhenStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004575 RID: 17781
		// (get) Token: 0x0602423D RID: 148029 RVA: 0x00935E72 File Offset: 0x00934072
		// (set) Token: 0x0602423E RID: 148030 RVA: 0x00935E82 File Offset: 0x00934082
		public unsafe bool bFirstTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004576 RID: 17782
		// (get) Token: 0x0602423F RID: 148031 RVA: 0x00935E93 File Offset: 0x00934093
		// (set) Token: 0x06024240 RID: 148032 RVA: 0x00935EA7 File Offset: 0x009340A7
		public unsafe UTexture2D CloudMask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BPC_VolumeCloudTrail_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BPC_VolumeCloudTrail_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17004577 RID: 17783
		// (get) Token: 0x06024241 RID: 148033 RVA: 0x00935EBC File Offset: 0x009340BC
		// (set) Token: 0x06024242 RID: 148034 RVA: 0x00935ECC File Offset: 0x009340CC
		public unsafe bool bDrawBound
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004578 RID: 17784
		// (get) Token: 0x06024243 RID: 148035 RVA: 0x00935EDD File Offset: 0x009340DD
		// (set) Token: 0x06024244 RID: 148036 RVA: 0x00935EF1 File Offset: 0x009340F1
		public unsafe UMaterialInstanceDynamic lowCloudMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BPC_VolumeCloudTrail_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BPC_VolumeCloudTrail_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17004579 RID: 17785
		// (get) Token: 0x06024245 RID: 148037 RVA: 0x00935F06 File Offset: 0x00934106
		// (set) Token: 0x06024246 RID: 148038 RVA: 0x00935F16 File Offset: 0x00934116
		public unsafe float BoundSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700457A RID: 17786
		// (get) Token: 0x06024247 RID: 148039 RVA: 0x00935F27 File Offset: 0x00934127
		// (set) Token: 0x06024248 RID: 148040 RVA: 0x00935F3B File Offset: 0x0093413B
		public unsafe UMaterialInstanceDynamic bottomMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BPC_VolumeCloudTrail_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BPC_VolumeCloudTrail_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x1700457B RID: 17787
		// (get) Token: 0x06024249 RID: 148041 RVA: 0x00935F50 File Offset: 0x00934150
		// (set) Token: 0x0602424A RID: 148042 RVA: 0x00935F64 File Offset: 0x00934164
		public unsafe FVectorDouble targetPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700457C RID: 17788
		// (get) Token: 0x0602424B RID: 148043 RVA: 0x00935F79 File Offset: 0x00934179
		// (set) Token: 0x0602424C RID: 148044 RVA: 0x00935F89 File Offset: 0x00934189
		public unsafe float radialSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x1700457D RID: 17789
		// (get) Token: 0x0602424D RID: 148045 RVA: 0x00935F9A File Offset: 0x0093419A
		// (set) Token: 0x0602424E RID: 148046 RVA: 0x00935FAA File Offset: 0x009341AA
		public unsafe float radialSize_boat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x1700457E RID: 17790
		// (get) Token: 0x0602424F RID: 148047 RVA: 0x00935FBB File Offset: 0x009341BB
		// (set) Token: 0x06024250 RID: 148048 RVA: 0x00935FCB File Offset: 0x009341CB
		public unsafe float radialSize_kanteleila
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x1700457F RID: 17791
		// (get) Token: 0x06024251 RID: 148049 RVA: 0x00935FDC File Offset: 0x009341DC
		// (set) Token: 0x06024252 RID: 148050 RVA: 0x00935FEC File Offset: 0x009341EC
		public unsafe float BoundSize_boat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17004580 RID: 17792
		// (get) Token: 0x06024253 RID: 148051 RVA: 0x00935FFD File Offset: 0x009341FD
		// (set) Token: 0x06024254 RID: 148052 RVA: 0x0093600D File Offset: 0x0093420D
		public unsafe float BoundSize_man
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17004581 RID: 17793
		// (get) Token: 0x06024255 RID: 148053 RVA: 0x0093601E File Offset: 0x0093421E
		// (set) Token: 0x06024256 RID: 148054 RVA: 0x0093602E File Offset: 0x0093422E
		public unsafe double MinHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17004582 RID: 17794
		// (get) Token: 0x06024257 RID: 148055 RVA: 0x0093603F File Offset: 0x0093423F
		// (set) Token: 0x06024258 RID: 148056 RVA: 0x0093604F File Offset: 0x0093424F
		public unsafe float BoatOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17004583 RID: 17795
		// (get) Token: 0x06024259 RID: 148057 RVA: 0x00936060 File Offset: 0x00934260
		// (set) Token: 0x0602425A RID: 148058 RVA: 0x00936074 File Offset: 0x00934274
		public unsafe FVectorDouble LastPostion_raw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17004584 RID: 17796
		// (get) Token: 0x0602425B RID: 148059 RVA: 0x00936089 File Offset: 0x00934289
		// (set) Token: 0x0602425C RID: 148060 RVA: 0x0093609D File Offset: 0x0093429D
		public unsafe FVectorDouble targetPosition_raw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17004585 RID: 17797
		// (get) Token: 0x0602425D RID: 148061 RVA: 0x009360B2 File Offset: 0x009342B2
		// (set) Token: 0x0602425E RID: 148062 RVA: 0x009360C2 File Offset: 0x009342C2
		public unsafe float FadeMinSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17004586 RID: 17798
		// (get) Token: 0x0602425F RID: 148063 RVA: 0x009360D3 File Offset: 0x009342D3
		// (set) Token: 0x06024260 RID: 148064 RVA: 0x009360E3 File Offset: 0x009342E3
		public unsafe float StaticMinSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17004587 RID: 17799
		// (get) Token: 0x06024261 RID: 148065 RVA: 0x009360F4 File Offset: 0x009342F4
		// (set) Token: 0x06024262 RID: 148066 RVA: 0x00936104 File Offset: 0x00934304
		public unsafe float FlakeSP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17004588 RID: 17800
		// (get) Token: 0x06024263 RID: 148067 RVA: 0x00936115 File Offset: 0x00934315
		// (set) Token: 0x06024264 RID: 148068 RVA: 0x00936125 File Offset: 0x00934325
		public unsafe bool bKanteleila
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004589 RID: 17801
		// (get) Token: 0x06024265 RID: 148069 RVA: 0x00936136 File Offset: 0x00934336
		// (set) Token: 0x06024266 RID: 148070 RVA: 0x00936146 File Offset: 0x00934346
		public unsafe bool bBoat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPC_VolumeCloudTrail_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024267 RID: 148071 RVA: 0x00936157 File Offset: 0x00934357
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TrailTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BPC_VolumeCloudTrail_C.__TrailTick_NativeFunctionPtr, null);
		}

		// Token: 0x06024268 RID: 148072 RVA: 0x0093616C File Offset: 0x0093436C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BPC_VolumeCloudTrail_C.__ReceiveTick_FunctionParams* ptr = stackalloc BPC_VolumeCloudTrail_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BPC_VolumeCloudTrail_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPC_VolumeCloudTrail_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BPC_VolumeCloudTrail_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024269 RID: 148073 RVA: 0x009361B4 File Offset: 0x009343B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BPC_VolumeCloudTrail_C.__ReceiveTick_FunctionParams* ptr = stackalloc BPC_VolumeCloudTrail_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BPC_VolumeCloudTrail_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPC_VolumeCloudTrail_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BPC_VolumeCloudTrail_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602426A RID: 148074 RVA: 0x009361FB File Offset: 0x009343FB
		protected BPC_VolumeCloudTrail_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011E48 RID: 73288
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/CloudTraceTail/BPC_VolumeCloudTrail.BPC_VolumeCloudTrail_C";

		// Token: 0x04011E49 RID: 73289
		private static IntPtr _ClassPtr;

		// Token: 0x04011E4A RID: 73290
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011E4B RID: 73291
		internal static int __PropertyOffset_1;

		// Token: 0x04011E4C RID: 73292
		internal static int __PropertyOffset_2;

		// Token: 0x04011E4D RID: 73293
		internal static int __PropertyOffset_3;

		// Token: 0x04011E4E RID: 73294
		internal static int __PropertyOffset_4;

		// Token: 0x04011E4F RID: 73295
		internal static int __PropertyOffset_5;

		// Token: 0x04011E50 RID: 73296
		internal static int __PropertyOffset_6;

		// Token: 0x04011E51 RID: 73297
		internal static int __PropertyOffset_7;

		// Token: 0x04011E52 RID: 73298
		internal static int __PropertyOffset_8;

		// Token: 0x04011E53 RID: 73299
		internal static int __PropertyOffset_9;

		// Token: 0x04011E54 RID: 73300
		internal static int __PropertyOffset_10;

		// Token: 0x04011E55 RID: 73301
		internal static int __PropertyOffset_11;

		// Token: 0x04011E56 RID: 73302
		internal static int __PropertyOffset_12;

		// Token: 0x04011E57 RID: 73303
		internal static int __PropertyOffset_13;

		// Token: 0x04011E58 RID: 73304
		internal static int __PropertyOffset_14;

		// Token: 0x04011E59 RID: 73305
		internal static int __PropertyOffset_15;

		// Token: 0x04011E5A RID: 73306
		internal static int __PropertyOffset_16;

		// Token: 0x04011E5B RID: 73307
		internal static int __PropertyOffset_17;

		// Token: 0x04011E5C RID: 73308
		internal static int __PropertyOffset_18;

		// Token: 0x04011E5D RID: 73309
		internal static int __PropertyOffset_19;

		// Token: 0x04011E5E RID: 73310
		internal static int __PropertyOffset_20;

		// Token: 0x04011E5F RID: 73311
		internal static int __PropertyOffset_21;

		// Token: 0x04011E60 RID: 73312
		internal static int __PropertyOffset_22;

		// Token: 0x04011E61 RID: 73313
		internal static int __PropertyOffset_23;

		// Token: 0x04011E62 RID: 73314
		internal static int __PropertyOffset_24;

		// Token: 0x04011E63 RID: 73315
		internal static int __PropertyOffset_25;

		// Token: 0x04011E64 RID: 73316
		internal static int __PropertyOffset_26;

		// Token: 0x04011E65 RID: 73317
		internal static int __PropertyOffset_27;

		// Token: 0x04011E66 RID: 73318
		internal static int __PropertyOffset_28;

		// Token: 0x04011E67 RID: 73319
		private static IntPtr __TrailTick_NativeFunctionPtr;

		// Token: 0x04011E68 RID: 73320
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009ED6 RID: 40662
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040317C3 RID: 202691
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
