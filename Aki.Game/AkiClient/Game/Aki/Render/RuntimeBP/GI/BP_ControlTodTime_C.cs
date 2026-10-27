using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI
{
	// Token: 0x02003D2A RID: 15658
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/BP_ControlTodTime.BP_ControlTodTime_C")]
	[UnrealStructLayout(1344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1344)]
	public class BP_ControlTodTime_C : AKuroControlTodTime, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025ADD RID: 154333 RVA: 0x0096028C File Offset: 0x0095E48C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ControlTodTime_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/BP_ControlTodTime.BP_ControlTodTime_C");
			}
			return BP_ControlTodTime_C._ClassPtr;
		}

		// Token: 0x06025ADE RID: 154334 RVA: 0x009602B0 File Offset: 0x0095E4B0
		public BP_ControlTodTime_C() : this(BuiltinUtils.AllocNativeUObject(BP_ControlTodTime_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025ADF RID: 154335 RVA: 0x009602D8 File Offset: 0x0095E4D8
		public BP_ControlTodTime_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ControlTodTime_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004E05 RID: 19973
		// (get) Token: 0x06025AE0 RID: 154336 RVA: 0x0096030B File Offset: 0x0095E50B
		// (set) Token: 0x06025AE1 RID: 154337 RVA: 0x0096031F File Offset: 0x0095E51F
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ControlTodTime_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ControlTodTime_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004E06 RID: 19974
		// (get) Token: 0x06025AE2 RID: 154338 RVA: 0x00960334 File Offset: 0x0095E534
		// (set) Token: 0x06025AE3 RID: 154339 RVA: 0x00960344 File Offset: 0x0095E544
		public unsafe float TodTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ControlTodTime_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ControlTodTime_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17004E07 RID: 19975
		// (get) Token: 0x06025AE4 RID: 154340 RVA: 0x00960355 File Offset: 0x0095E555
		// (set) Token: 0x06025AE5 RID: 154341 RVA: 0x00960365 File Offset: 0x0095E565
		public unsafe bool EnableTodTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ControlTodTime_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ControlTodTime_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E08 RID: 19976
		// (get) Token: 0x06025AE6 RID: 154342 RVA: 0x00960376 File Offset: 0x0095E576
		// (set) Token: 0x06025AE7 RID: 154343 RVA: 0x00960386 File Offset: 0x0095E586
		public unsafe float SunVerticalAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ControlTodTime_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ControlTodTime_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004E09 RID: 19977
		// (get) Token: 0x06025AE8 RID: 154344 RVA: 0x00960397 File Offset: 0x0095E597
		// (set) Token: 0x06025AE9 RID: 154345 RVA: 0x009603A7 File Offset: 0x0095E5A7
		public unsafe bool EnableSunVerticalAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ControlTodTime_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ControlTodTime_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E0A RID: 19978
		// (get) Token: 0x06025AEA RID: 154346 RVA: 0x009603B8 File Offset: 0x0095E5B8
		// (set) Token: 0x06025AEB RID: 154347 RVA: 0x009603C8 File Offset: 0x0095E5C8
		public unsafe float SunHorizontalAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ControlTodTime_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ControlTodTime_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004E0B RID: 19979
		// (get) Token: 0x06025AEC RID: 154348 RVA: 0x009603D9 File Offset: 0x0095E5D9
		// (set) Token: 0x06025AED RID: 154349 RVA: 0x009603E9 File Offset: 0x0095E5E9
		public unsafe bool EnableSunHorizontalAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ControlTodTime_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ControlTodTime_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E0C RID: 19980
		// (get) Token: 0x06025AEE RID: 154350 RVA: 0x009603FA File Offset: 0x0095E5FA
		// (set) Token: 0x06025AEF RID: 154351 RVA: 0x0096040A File Offset: 0x0095E60A
		public unsafe float MainLightAngelLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ControlTodTime_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ControlTodTime_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004E0D RID: 19981
		// (get) Token: 0x06025AF0 RID: 154352 RVA: 0x0096041B File Offset: 0x0095E61B
		// (set) Token: 0x06025AF1 RID: 154353 RVA: 0x0096042B File Offset: 0x0095E62B
		public unsafe bool EnableMainLightAngelLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ControlTodTime_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ControlTodTime_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E0E RID: 19982
		// (get) Token: 0x06025AF2 RID: 154354 RVA: 0x0096043C File Offset: 0x0095E63C
		// (set) Token: 0x06025AF3 RID: 154355 RVA: 0x0096044C File Offset: 0x0095E64C
		public unsafe float AccumulatedTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ControlTodTime_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ControlTodTime_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004E0F RID: 19983
		// (get) Token: 0x06025AF4 RID: 154356 RVA: 0x00960460 File Offset: 0x0095E660
		// (set) Token: 0x06025AF5 RID: 154357 RVA: 0x00960499 File Offset: 0x0095E699
		public TSet<int> CameraChangedTime
		{
			get
			{
				base.FastCheckIsValid();
				TSet<int> result;
				if ((result = this._CameraChangedTime) == null)
				{
					result = (this._CameraChangedTime = new TSet<int>(base.NativePtr + (IntPtr)BP_ControlTodTime_C.__PropertyOffset_11, this));
				}
				return result;
			}
			set
			{
				this.CameraChangedTime.CopyAssign(value);
			}
		}

		// Token: 0x17004E10 RID: 19984
		// (get) Token: 0x06025AF6 RID: 154358 RVA: 0x009604A8 File Offset: 0x0095E6A8
		// (set) Token: 0x06025AF7 RID: 154359 RVA: 0x009604E1 File Offset: 0x0095E6E1
		public TSet<int> TSetCall
		{
			get
			{
				base.FastCheckIsValid();
				TSet<int> result;
				if ((result = this._TSetCall) == null)
				{
					result = (this._TSetCall = new TSet<int>(base.NativePtr + (IntPtr)BP_ControlTodTime_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				this.TSetCall.CopyAssign(value);
			}
		}

		// Token: 0x17004E11 RID: 19985
		// (get) Token: 0x06025AF8 RID: 154360 RVA: 0x009604F0 File Offset: 0x0095E6F0
		// (set) Token: 0x06025AF9 RID: 154361 RVA: 0x00960529 File Offset: 0x0095E729
		public TSet<int> TSetUncall
		{
			get
			{
				base.FastCheckIsValid();
				TSet<int> result;
				if ((result = this._TSetUncall) == null)
				{
					result = (this._TSetUncall = new TSet<int>(base.NativePtr + (IntPtr)BP_ControlTodTime_C.__PropertyOffset_13, this));
				}
				return result;
			}
			set
			{
				this.TSetUncall.CopyAssign(value);
			}
		}

		// Token: 0x06025AFA RID: 154362 RVA: 0x00960537 File Offset: 0x0095E737
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ControlTodTime_C.__Update_NativeFunctionPtr, null);
		}

		// Token: 0x06025AFB RID: 154363 RVA: 0x0096054B File Offset: 0x0095E74B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ControlTodTime_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025AFC RID: 154364 RVA: 0x0096055F File Offset: 0x0095E75F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ControlTodTime_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025AFD RID: 154365 RVA: 0x00960574 File Offset: 0x0095E774
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_ControlTodTime_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_ControlTodTime_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_ControlTodTime_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ControlTodTime_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ControlTodTime_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025AFE RID: 154366 RVA: 0x009605C0 File Offset: 0x0095E7C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_ControlTodTime_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_ControlTodTime_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_ControlTodTime_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ControlTodTime_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ControlTodTime_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025AFF RID: 154367 RVA: 0x0096060C File Offset: 0x0095E80C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ControlTodTime_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x06025B00 RID: 154368 RVA: 0x00960620 File Offset: 0x0095E820
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ControlTodTime_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025B01 RID: 154369 RVA: 0x00960638 File Offset: 0x0095E838
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void DoUpdate(float DeltaTime)
		{
			BP_ControlTodTime_C.__DoUpdate_FunctionParams* ptr = stackalloc BP_ControlTodTime_C.__DoUpdate_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ControlTodTime_C.__DoUpdate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ControlTodTime_C.__DoUpdate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ControlTodTime_C.__DoUpdate_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025B02 RID: 154370 RVA: 0x00960680 File Offset: 0x0095E880
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void DoUpdate_Implementation(float DeltaTime)
		{
			BP_ControlTodTime_C.__DoUpdate_FunctionParams* ptr = stackalloc BP_ControlTodTime_C.__DoUpdate_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ControlTodTime_C.__DoUpdate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ControlTodTime_C.__DoUpdate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ControlTodTime_C.__DoUpdate_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025B03 RID: 154371 RVA: 0x009606C7 File Offset: 0x0095E8C7
		protected BP_ControlTodTime_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012D22 RID: 77090
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/BP_ControlTodTime.BP_ControlTodTime_C";

		// Token: 0x04012D23 RID: 77091
		private static IntPtr _ClassPtr;

		// Token: 0x04012D24 RID: 77092
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012D25 RID: 77093
		internal static int __PropertyOffset_1;

		// Token: 0x04012D26 RID: 77094
		internal static int __PropertyOffset_2;

		// Token: 0x04012D27 RID: 77095
		internal static int __PropertyOffset_3;

		// Token: 0x04012D28 RID: 77096
		internal static int __PropertyOffset_4;

		// Token: 0x04012D29 RID: 77097
		internal static int __PropertyOffset_5;

		// Token: 0x04012D2A RID: 77098
		internal static int __PropertyOffset_6;

		// Token: 0x04012D2B RID: 77099
		internal static int __PropertyOffset_7;

		// Token: 0x04012D2C RID: 77100
		internal static int __PropertyOffset_8;

		// Token: 0x04012D2D RID: 77101
		internal static int __PropertyOffset_9;

		// Token: 0x04012D2E RID: 77102
		internal static int __PropertyOffset_10;

		// Token: 0x04012D2F RID: 77103
		internal static int __PropertyOffset_11;

		// Token: 0x04012D30 RID: 77104
		[Nullable(2)]
		private TSet<int> _CameraChangedTime;

		// Token: 0x04012D31 RID: 77105
		internal static int __PropertyOffset_12;

		// Token: 0x04012D32 RID: 77106
		[Nullable(2)]
		private TSet<int> _TSetCall;

		// Token: 0x04012D33 RID: 77107
		internal static int __PropertyOffset_13;

		// Token: 0x04012D34 RID: 77108
		[Nullable(2)]
		private TSet<int> _TSetUncall;

		// Token: 0x04012D35 RID: 77109
		private static IntPtr __Update_NativeFunctionPtr;

		// Token: 0x04012D36 RID: 77110
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012D37 RID: 77111
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04012D38 RID: 77112
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x04012D39 RID: 77113
		private static IntPtr __DoUpdate_NativeFunctionPtr;

		// Token: 0x0200A022 RID: 40994
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031ACB RID: 203467
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x0200A023 RID: 40995
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __DoUpdate_FunctionParams
		{
			// Token: 0x04031ACC RID: 203468
			[FieldOffset(0)]
			public float DeltaTime;
		}
	}
}
