using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.MagneticStorm
{
	// Token: 0x02003CED RID: 15597
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/MagneticStorm/BP_MagneticStorm.BP_MagneticStorm_C")]
	[UnrealStructLayout(1504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1501)]
	public class BP_MagneticStorm_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060252B1 RID: 152241 RVA: 0x00952D15 File Offset: 0x00950F15
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MagneticStorm_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/MagneticStorm/BP_MagneticStorm.BP_MagneticStorm_C");
			}
			return BP_MagneticStorm_C._ClassPtr;
		}

		// Token: 0x060252B2 RID: 152242 RVA: 0x00952D3C File Offset: 0x00950F3C
		public BP_MagneticStorm_C() : this(BuiltinUtils.AllocNativeUObject(BP_MagneticStorm_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060252B3 RID: 152243 RVA: 0x00952D64 File Offset: 0x00950F64
		[NullableContext(1)]
		public BP_MagneticStorm_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MagneticStorm_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B37 RID: 19255
		// (get) Token: 0x060252B4 RID: 152244 RVA: 0x00952D97 File Offset: 0x00950F97
		// (set) Token: 0x060252B5 RID: 152245 RVA: 0x00952DAB File Offset: 0x00950FAB
		public unsafe UNiagaraComponent NS_Fx_SC3_MagneticStorm_Mobile_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004B38 RID: 19256
		// (get) Token: 0x060252B6 RID: 152246 RVA: 0x00952DC0 File Offset: 0x00950FC0
		// (set) Token: 0x060252B7 RID: 152247 RVA: 0x00952DD4 File Offset: 0x00950FD4
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004B39 RID: 19257
		// (get) Token: 0x060252B8 RID: 152248 RVA: 0x00952DE9 File Offset: 0x00950FE9
		// (set) Token: 0x060252B9 RID: 152249 RVA: 0x00952DFD File Offset: 0x00950FFD
		public unsafe UNiagaraComponent NS_Fx_MagneticStorm
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004B3A RID: 19258
		// (get) Token: 0x060252BA RID: 152250 RVA: 0x00952E12 File Offset: 0x00951012
		// (set) Token: 0x060252BB RID: 152251 RVA: 0x00952E26 File Offset: 0x00951026
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004B3B RID: 19259
		// (get) Token: 0x060252BC RID: 152252 RVA: 0x00952E3B File Offset: 0x0095103B
		// (set) Token: 0x060252BD RID: 152253 RVA: 0x00952E4F File Offset: 0x0095104F
		public unsafe FVector WroldOriginLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004B3C RID: 19260
		// (get) Token: 0x060252BE RID: 152254 RVA: 0x00952E64 File Offset: 0x00951064
		// (set) Token: 0x060252BF RID: 152255 RVA: 0x00952E74 File Offset: 0x00951074
		public unsafe bool DisplayShockwave
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B3D RID: 19261
		// (get) Token: 0x060252C0 RID: 152256 RVA: 0x00952E85 File Offset: 0x00951085
		// (set) Token: 0x060252C1 RID: 152257 RVA: 0x00952E95 File Offset: 0x00951095
		public unsafe bool DisplayParticle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B3E RID: 19262
		// (get) Token: 0x060252C2 RID: 152258 RVA: 0x00952EA6 File Offset: 0x009510A6
		// (set) Token: 0x060252C3 RID: 152259 RVA: 0x00952EB6 File Offset: 0x009510B6
		public unsafe bool DisplayGrid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B3F RID: 19263
		// (get) Token: 0x060252C4 RID: 152260 RVA: 0x00952EC7 File Offset: 0x009510C7
		// (set) Token: 0x060252C5 RID: 152261 RVA: 0x00952ED7 File Offset: 0x009510D7
		public unsafe float AttenuationDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004B40 RID: 19264
		// (get) Token: 0x060252C6 RID: 152262 RVA: 0x00952EE8 File Offset: 0x009510E8
		// (set) Token: 0x060252C7 RID: 152263 RVA: 0x00952EF8 File Offset: 0x009510F8
		public unsafe bool bInTheBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x060252C8 RID: 152264 RVA: 0x00952F09 File Offset: 0x00951109
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateNS()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_C.__UpdateNS_NativeFunctionPtr, null);
		}

		// Token: 0x060252C9 RID: 152265 RVA: 0x00952F1D File Offset: 0x0095111D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RemoveParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_C.__RemoveParam_NativeFunctionPtr, null);
		}

		// Token: 0x060252CA RID: 152266 RVA: 0x00952F31 File Offset: 0x00951131
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CloseAllShockwave()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_C.__CloseAllShockwave_NativeFunctionPtr, null);
		}

		// Token: 0x060252CB RID: 152267 RVA: 0x00952F48 File Offset: 0x00951148
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InTheBox(FVector pos, ref bool IntheBox)
		{
			BP_MagneticStorm_C.__InTheBox_FunctionParams* ptr = stackalloc BP_MagneticStorm_C.__InTheBox_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(BP_MagneticStorm_C.__InTheBox_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MagneticStorm_C.__InTheBox_NativeFunctionPtr, (void*)ptr, 1);
			ptr->pos = pos;
			ptr->IntheBox = IntheBox;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_C.__InTheBox_NativeFunctionPtr, (void*)ptr);
			IntheBox = ptr->IntheBox;
		}

		// Token: 0x060252CC RID: 152268 RVA: 0x00952F9E File Offset: 0x0095119E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OpenShockwave()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_C.__OpenShockwave_NativeFunctionPtr, null);
		}

		// Token: 0x060252CD RID: 152269 RVA: 0x00952FB2 File Offset: 0x009511B2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_C.__UpdateParam_NativeFunctionPtr, null);
		}

		// Token: 0x060252CE RID: 152270 RVA: 0x00952FC6 File Offset: 0x009511C6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_C.__SetParam_NativeFunctionPtr, null);
		}

		// Token: 0x060252CF RID: 152271 RVA: 0x00952FDA File Offset: 0x009511DA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060252D0 RID: 152272 RVA: 0x00952FEE File Offset: 0x009511EE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MagneticStorm_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060252D1 RID: 152273 RVA: 0x00953003 File Offset: 0x00951203
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060252D2 RID: 152274 RVA: 0x00953017 File Offset: 0x00951217
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MagneticStorm_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060252D3 RID: 152275 RVA: 0x0095302C File Offset: 0x0095122C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_MagneticStorm_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MagneticStorm_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MagneticStorm_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MagneticStorm_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060252D4 RID: 152276 RVA: 0x00953074 File Offset: 0x00951274
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_MagneticStorm_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MagneticStorm_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MagneticStorm_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MagneticStorm_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MagneticStorm_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060252D5 RID: 152277 RVA: 0x009530BB File Offset: 0x009512BB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_C.__CustomTick_NativeFunctionPtr, null);
		}

		// Token: 0x060252D6 RID: 152278 RVA: 0x009530CF File Offset: 0x009512CF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x060252D7 RID: 152279 RVA: 0x009530E3 File Offset: 0x009512E3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MagneticStorm_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060252D8 RID: 152280 RVA: 0x009530F8 File Offset: 0x009512F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_MagneticStorm_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_MagneticStorm_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_MagneticStorm_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MagneticStorm_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060252D9 RID: 152281 RVA: 0x00953144 File Offset: 0x00951344
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_MagneticStorm_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_MagneticStorm_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_MagneticStorm_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MagneticStorm_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MagneticStorm_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060252DA RID: 152282 RVA: 0x00953190 File Offset: 0x00951390
		protected BP_MagneticStorm_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012828 RID: 75816
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/MagneticStorm/BP_MagneticStorm.BP_MagneticStorm_C";

		// Token: 0x04012829 RID: 75817
		private static IntPtr _ClassPtr;

		// Token: 0x0401282A RID: 75818
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401282B RID: 75819
		internal static int __PropertyOffset_1;

		// Token: 0x0401282C RID: 75820
		internal static int __PropertyOffset_2;

		// Token: 0x0401282D RID: 75821
		internal static int __PropertyOffset_3;

		// Token: 0x0401282E RID: 75822
		internal static int __PropertyOffset_4;

		// Token: 0x0401282F RID: 75823
		internal static int __PropertyOffset_5;

		// Token: 0x04012830 RID: 75824
		internal static int __PropertyOffset_6;

		// Token: 0x04012831 RID: 75825
		internal static int __PropertyOffset_7;

		// Token: 0x04012832 RID: 75826
		internal static int __PropertyOffset_8;

		// Token: 0x04012833 RID: 75827
		internal static int __PropertyOffset_9;

		// Token: 0x04012834 RID: 75828
		internal static int __PropertyOffset_10;

		// Token: 0x04012835 RID: 75829
		private static IntPtr __UpdateNS_NativeFunctionPtr;

		// Token: 0x04012836 RID: 75830
		private static IntPtr __RemoveParam_NativeFunctionPtr;

		// Token: 0x04012837 RID: 75831
		private static IntPtr __CloseAllShockwave_NativeFunctionPtr;

		// Token: 0x04012838 RID: 75832
		private static IntPtr __InTheBox_NativeFunctionPtr;

		// Token: 0x04012839 RID: 75833
		private static IntPtr __OpenShockwave_NativeFunctionPtr;

		// Token: 0x0401283A RID: 75834
		private static IntPtr __UpdateParam_NativeFunctionPtr;

		// Token: 0x0401283B RID: 75835
		private static IntPtr __SetParam_NativeFunctionPtr;

		// Token: 0x0401283C RID: 75836
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401283D RID: 75837
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401283E RID: 75838
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401283F RID: 75839
		private static IntPtr __CustomTick_NativeFunctionPtr;

		// Token: 0x04012840 RID: 75840
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x04012841 RID: 75841
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009FBD RID: 40893
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __InTheBox_FunctionParams
		{
			// Token: 0x04031A1F RID: 203295
			[FieldOffset(0)]
			public FVector pos;

			// Token: 0x04031A20 RID: 203296
			[FieldOffset(12)]
			public bool IntheBox;
		}

		// Token: 0x02009FBE RID: 40894
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A21 RID: 203297
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009FBF RID: 40895
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031A22 RID: 203298
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
