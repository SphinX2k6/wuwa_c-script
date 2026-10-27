using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.UltraDynamicSky.Blueprints.Weather_Effects
{
	// Token: 0x02003A94 RID: 14996
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/UltraDynamicSky/Blueprints/Weather_Effects/Rain_Drip_Spline.Rain_Drip_Spline_C")]
	[UnrealStructLayout(1160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1158)]
	public class Rain_Drip_Spline_C : AActor, IUnrealUObject, IUnrealObject, IWeather_Effects_Interface_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0602017F RID: 131455 RVA: 0x008C95FE File Offset: 0x008C77FE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (Rain_Drip_Spline_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/UltraDynamicSky/Blueprints/Weather_Effects/Rain_Drip_Spline.Rain_Drip_Spline_C");
			}
			return Rain_Drip_Spline_C._ClassPtr;
		}

		// Token: 0x06020180 RID: 131456 RVA: 0x008C9624 File Offset: 0x008C7824
		public Rain_Drip_Spline_C() : this(BuiltinUtils.AllocNativeUObject(Rain_Drip_Spline_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020181 RID: 131457 RVA: 0x008C964C File Offset: 0x008C784C
		[NullableContext(1)]
		public Rain_Drip_Spline_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(Rain_Drip_Spline_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002EF1 RID: 12017
		// (get) Token: 0x06020182 RID: 131458 RVA: 0x008C967F File Offset: 0x008C787F
		// (set) Token: 0x06020183 RID: 131459 RVA: 0x008C9693 File Offset: 0x008C7893
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Rain_Drip_Spline_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Rain_Drip_Spline_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002EF2 RID: 12018
		// (get) Token: 0x06020184 RID: 131460 RVA: 0x008C96A8 File Offset: 0x008C78A8
		// (set) Token: 0x06020185 RID: 131461 RVA: 0x008C96BC File Offset: 0x008C78BC
		public unsafe USceneComponent Floor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Rain_Drip_Spline_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Rain_Drip_Spline_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002EF3 RID: 12019
		// (get) Token: 0x06020186 RID: 131462 RVA: 0x008C96D1 File Offset: 0x008C78D1
		// (set) Token: 0x06020187 RID: 131463 RVA: 0x008C96E5 File Offset: 0x008C78E5
		public unsafe USceneComponent End_Point
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Rain_Drip_Spline_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Rain_Drip_Spline_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002EF4 RID: 12020
		// (get) Token: 0x06020188 RID: 131464 RVA: 0x008C96FA File Offset: 0x008C78FA
		// (set) Token: 0x06020189 RID: 131465 RVA: 0x008C970E File Offset: 0x008C790E
		public unsafe UNiagaraComponent Dripping_Curve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Rain_Drip_Spline_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Rain_Drip_Spline_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002EF5 RID: 12021
		// (get) Token: 0x0602018A RID: 131466 RVA: 0x008C9723 File Offset: 0x008C7923
		// (set) Token: 0x0602018B RID: 131467 RVA: 0x008C9737 File Offset: 0x008C7937
		public unsafe UBillboardComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Rain_Drip_Spline_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Rain_Drip_Spline_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17002EF6 RID: 12022
		// (get) Token: 0x0602018C RID: 131468 RVA: 0x008C974C File Offset: 0x008C794C
		// (set) Token: 0x0602018D RID: 131469 RVA: 0x008C975C File Offset: 0x008C795C
		public unsafe bool Refresh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Rain_Drip_Spline_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Rain_Drip_Spline_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002EF7 RID: 12023
		// (get) Token: 0x0602018E RID: 131470 RVA: 0x008C976D File Offset: 0x008C796D
		// (set) Token: 0x0602018F RID: 131471 RVA: 0x008C977D File Offset: 0x008C797D
		public unsafe float Spawn_Rate_Per_Meter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Rain_Drip_Spline_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Rain_Drip_Spline_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17002EF8 RID: 12024
		// (get) Token: 0x06020190 RID: 131472 RVA: 0x008C978E File Offset: 0x008C798E
		// (set) Token: 0x06020191 RID: 131473 RVA: 0x008C979E File Offset: 0x008C799E
		public unsafe float Additional_Spawn_Rate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Rain_Drip_Spline_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Rain_Drip_Spline_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002EF9 RID: 12025
		// (get) Token: 0x06020192 RID: 131474 RVA: 0x008C97AF File Offset: 0x008C79AF
		// (set) Token: 0x06020193 RID: 131475 RVA: 0x008C97BF File Offset: 0x008C79BF
		public unsafe float Splash_Frequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Rain_Drip_Spline_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Rain_Drip_Spline_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17002EFA RID: 12026
		// (get) Token: 0x06020194 RID: 131476 RVA: 0x008C97D0 File Offset: 0x008C79D0
		// (set) Token: 0x06020195 RID: 131477 RVA: 0x008C9809 File Offset: 0x008C7A09
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EObjectTypeQuery>> Collision_Object_Types
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EObjectTypeQuery>> result;
				if ((result = this._Collision_Object_Types) == null)
				{
					result = (this._Collision_Object_Types = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)Rain_Drip_Spline_C.__PropertyOffset_10, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.Collision_Object_Types.CopyAssign(value);
			}
		}

		// Token: 0x17002EFB RID: 12027
		// (get) Token: 0x06020196 RID: 131478 RVA: 0x008C9818 File Offset: 0x008C7A18
		// (set) Token: 0x06020197 RID: 131479 RVA: 0x008C9851 File Offset: 0x008C7A51
		[Nullable(1)]
		public TArray<AActor> Collision_Actors_to_Ignore
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._Collision_Actors_to_Ignore) == null)
				{
					result = (this._Collision_Actors_to_Ignore = new TArray<AActor>(base.NativePtr + (IntPtr)Rain_Drip_Spline_C.__PropertyOffset_11, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Collision_Actors_to_Ignore.CopyAssign(value);
			}
		}

		// Token: 0x17002EFC RID: 12028
		// (get) Token: 0x06020198 RID: 131480 RVA: 0x008C985F File Offset: 0x008C7A5F
		// (set) Token: 0x06020199 RID: 131481 RVA: 0x008C986F File Offset: 0x008C7A6F
		public unsafe float Collision_Line_Trace_Head_Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Rain_Drip_Spline_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Rain_Drip_Spline_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17002EFD RID: 12029
		// (get) Token: 0x0602019A RID: 131482 RVA: 0x008C9880 File Offset: 0x008C7A80
		// (set) Token: 0x0602019B RID: 131483 RVA: 0x008C9890 File Offset: 0x008C7A90
		public unsafe float Point_Spacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Rain_Drip_Spline_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Rain_Drip_Spline_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17002EFE RID: 12030
		// (get) Token: 0x0602019C RID: 131484 RVA: 0x008C98A1 File Offset: 0x008C7AA1
		// (set) Token: 0x0602019D RID: 131485 RVA: 0x008C98B1 File Offset: 0x008C7AB1
		public unsafe float Curl_Noise_Force
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Rain_Drip_Spline_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Rain_Drip_Spline_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17002EFF RID: 12031
		// (get) Token: 0x0602019E RID: 131486 RVA: 0x008C98C2 File Offset: 0x008C7AC2
		// (set) Token: 0x0602019F RID: 131487 RVA: 0x008C98D2 File Offset: 0x008C7AD2
		public unsafe bool Update_Collision_Regularly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Rain_Drip_Spline_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Rain_Drip_Spline_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F00 RID: 12032
		// (get) Token: 0x060201A0 RID: 131488 RVA: 0x008C98E3 File Offset: 0x008C7AE3
		// (set) Token: 0x060201A1 RID: 131489 RVA: 0x008C98F3 File Offset: 0x008C7AF3
		public unsafe bool Runtime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Rain_Drip_Spline_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Rain_Drip_Spline_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x060201A2 RID: 131490 RVA: 0x008C9904 File Offset: 0x008C7B04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Create_Curve_Data()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Rain_Drip_Spline_C.__Create_Curve_Data_NativeFunctionPtr, null);
		}

		// Token: 0x060201A3 RID: 131491 RVA: 0x008C9918 File Offset: 0x008C7B18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_with_Weather()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Rain_Drip_Spline_C.__Update_with_Weather_NativeFunctionPtr, null);
		}

		// Token: 0x060201A4 RID: 131492 RVA: 0x008C992C File Offset: 0x008C7B2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Rain_Drip_Spline_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060201A5 RID: 131493 RVA: 0x008C9940 File Offset: 0x008C7B40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, Rain_Drip_Spline_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060201A6 RID: 131494 RVA: 0x008C9955 File Offset: 0x008C7B55
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Editor_Update()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Rain_Drip_Spline_C.__Editor_Update_NativeFunctionPtr, null);
		}

		// Token: 0x060201A7 RID: 131495 RVA: 0x008C996C File Offset: 0x008C7B6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			Rain_Drip_Spline_C.__ReceiveTick_FunctionParams* ptr = stackalloc Rain_Drip_Spline_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(Rain_Drip_Spline_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Rain_Drip_Spline_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Rain_Drip_Spline_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060201A8 RID: 131496 RVA: 0x008C99B4 File Offset: 0x008C7BB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			Rain_Drip_Spline_C.__ReceiveTick_FunctionParams* ptr = stackalloc Rain_Drip_Spline_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(Rain_Drip_Spline_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Rain_Drip_Spline_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, Rain_Drip_Spline_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060201A9 RID: 131497 RVA: 0x008C99FB File Offset: 0x008C7BFB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Rain_Drip_Spline_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060201AA RID: 131498 RVA: 0x008C9A0F File Offset: 0x008C7C0F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, Rain_Drip_Spline_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060201AB RID: 131499 RVA: 0x008C9A24 File Offset: 0x008C7C24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Reset_Emitters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Rain_Drip_Spline_C.__Reset_Emitters_NativeFunctionPtr, null);
		}

		// Token: 0x060201AC RID: 131500 RVA: 0x008C9A38 File Offset: 0x008C7C38
		protected Rain_Drip_Spline_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7C4 RID: 63428
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/UltraDynamicSky/Blueprints/Weather_Effects/Rain_Drip_Spline.Rain_Drip_Spline_C";

		// Token: 0x0400F7C5 RID: 63429
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7C6 RID: 63430
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F7C7 RID: 63431
		internal static int __PropertyOffset_1;

		// Token: 0x0400F7C8 RID: 63432
		internal static int __PropertyOffset_2;

		// Token: 0x0400F7C9 RID: 63433
		internal static int __PropertyOffset_3;

		// Token: 0x0400F7CA RID: 63434
		internal static int __PropertyOffset_4;

		// Token: 0x0400F7CB RID: 63435
		internal static int __PropertyOffset_5;

		// Token: 0x0400F7CC RID: 63436
		internal static int __PropertyOffset_6;

		// Token: 0x0400F7CD RID: 63437
		internal static int __PropertyOffset_7;

		// Token: 0x0400F7CE RID: 63438
		internal static int __PropertyOffset_8;

		// Token: 0x0400F7CF RID: 63439
		internal static int __PropertyOffset_9;

		// Token: 0x0400F7D0 RID: 63440
		internal static int __PropertyOffset_10;

		// Token: 0x0400F7D1 RID: 63441
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _Collision_Object_Types;

		// Token: 0x0400F7D2 RID: 63442
		internal static int __PropertyOffset_11;

		// Token: 0x0400F7D3 RID: 63443
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _Collision_Actors_to_Ignore;

		// Token: 0x0400F7D4 RID: 63444
		internal static int __PropertyOffset_12;

		// Token: 0x0400F7D5 RID: 63445
		internal static int __PropertyOffset_13;

		// Token: 0x0400F7D6 RID: 63446
		internal static int __PropertyOffset_14;

		// Token: 0x0400F7D7 RID: 63447
		internal static int __PropertyOffset_15;

		// Token: 0x0400F7D8 RID: 63448
		internal static int __PropertyOffset_16;

		// Token: 0x0400F7D9 RID: 63449
		private static IntPtr __Create_Curve_Data_NativeFunctionPtr;

		// Token: 0x0400F7DA RID: 63450
		private static IntPtr __Update_with_Weather_NativeFunctionPtr;

		// Token: 0x0400F7DB RID: 63451
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F7DC RID: 63452
		private static IntPtr __Editor_Update_NativeFunctionPtr;

		// Token: 0x0400F7DD RID: 63453
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F7DE RID: 63454
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F7DF RID: 63455
		private static IntPtr __Reset_Emitters_NativeFunctionPtr;

		// Token: 0x02009B71 RID: 39793
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040311B4 RID: 201140
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
