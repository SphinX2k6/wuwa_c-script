using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.ShipTrailing.BP
{
	// Token: 0x02003DC6 RID: 15814
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/ShipTrailing/BP/BP_ShipTrailing.BP_ShipTrailing_C")]
	[UnrealStructLayout(1232, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1228)]
	public class BP_ShipTrailing_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060275AA RID: 161194 RVA: 0x0098EEC4 File Offset: 0x0098D0C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ShipTrailing_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/ShipTrailing/BP/BP_ShipTrailing.BP_ShipTrailing_C");
			}
			return BP_ShipTrailing_C._ClassPtr;
		}

		// Token: 0x060275AB RID: 161195 RVA: 0x0098EEE8 File Offset: 0x0098D0E8
		public BP_ShipTrailing_C() : this(BuiltinUtils.AllocNativeUObject(BP_ShipTrailing_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060275AC RID: 161196 RVA: 0x0098EF10 File Offset: 0x0098D110
		[NullableContext(1)]
		public BP_ShipTrailing_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ShipTrailing_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170057A5 RID: 22437
		// (get) Token: 0x060275AD RID: 161197 RVA: 0x0098EF43 File Offset: 0x0098D143
		// (set) Token: 0x060275AE RID: 161198 RVA: 0x0098EF57 File Offset: 0x0098D157
		public unsafe UStaticMeshComponent Plane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShipTrailing_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShipTrailing_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170057A6 RID: 22438
		// (get) Token: 0x060275AF RID: 161199 RVA: 0x0098EF6C File Offset: 0x0098D16C
		// (set) Token: 0x060275B0 RID: 161200 RVA: 0x0098EF80 File Offset: 0x0098D180
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShipTrailing_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShipTrailing_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170057A7 RID: 22439
		// (get) Token: 0x060275B1 RID: 161201 RVA: 0x0098EF98 File Offset: 0x0098D198
		// (set) Token: 0x060275B2 RID: 161202 RVA: 0x0098EFD1 File Offset: 0x0098D1D1
		[Nullable(1)]
		public TArray<float> offsetList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._offsetList) == null)
				{
					result = (this._offsetList = new TArray<float>(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_3, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.offsetList.CopyAssign(value);
			}
		}

		// Token: 0x170057A8 RID: 22440
		// (get) Token: 0x060275B3 RID: 161203 RVA: 0x0098EFDF File Offset: 0x0098D1DF
		// (set) Token: 0x060275B4 RID: 161204 RVA: 0x0098EFF3 File Offset: 0x0098D1F3
		public unsafe AActor player
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShipTrailing_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShipTrailing_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170057A9 RID: 22441
		// (get) Token: 0x060275B5 RID: 161205 RVA: 0x0098F008 File Offset: 0x0098D208
		// (set) Token: 0x060275B6 RID: 161206 RVA: 0x0098F01C File Offset: 0x0098D21C
		public unsafe FVector playerPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170057AA RID: 22442
		// (get) Token: 0x060275B7 RID: 161207 RVA: 0x0098F031 File Offset: 0x0098D231
		// (set) Token: 0x060275B8 RID: 161208 RVA: 0x0098F041 File Offset: 0x0098D241
		public unsafe float playerSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170057AB RID: 22443
		// (get) Token: 0x060275B9 RID: 161209 RVA: 0x0098F052 File Offset: 0x0098D252
		// (set) Token: 0x060275BA RID: 161210 RVA: 0x0098F062 File Offset: 0x0098D262
		public unsafe bool showDebugInfo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x170057AC RID: 22444
		// (get) Token: 0x060275BB RID: 161211 RVA: 0x0098F073 File Offset: 0x0098D273
		// (set) Token: 0x060275BC RID: 161212 RVA: 0x0098F083 File Offset: 0x0098D283
		public unsafe float timePerStamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170057AD RID: 22445
		// (get) Token: 0x060275BD RID: 161213 RVA: 0x0098F094 File Offset: 0x0098D294
		// (set) Token: 0x060275BE RID: 161214 RVA: 0x0098F0A8 File Offset: 0x0098D2A8
		public unsafe UMaterialInstanceDynamic dynamicMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShipTrailing_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShipTrailing_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x170057AE RID: 22446
		// (get) Token: 0x060275BF RID: 161215 RVA: 0x0098F0BD File Offset: 0x0098D2BD
		// (set) Token: 0x060275C0 RID: 161216 RVA: 0x0098F0CD File Offset: 0x0098D2CD
		public unsafe float timeSum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170057AF RID: 22447
		// (get) Token: 0x060275C1 RID: 161217 RVA: 0x0098F0E0 File Offset: 0x0098D2E0
		// (set) Token: 0x060275C2 RID: 161218 RVA: 0x0098F119 File Offset: 0x0098D319
		[Nullable(1)]
		public TArray<FVector> posList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._posList) == null)
				{
					result = (this._posList = new TArray<FVector>(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_11, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.posList.CopyAssign(value);
			}
		}

		// Token: 0x170057B0 RID: 22448
		// (get) Token: 0x060275C3 RID: 161219 RVA: 0x0098F127 File Offset: 0x0098D327
		// (set) Token: 0x060275C4 RID: 161220 RVA: 0x0098F13B File Offset: 0x0098D33B
		public unsafe FVector4 offsets
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170057B1 RID: 22449
		// (get) Token: 0x060275C5 RID: 161221 RVA: 0x0098F150 File Offset: 0x0098D350
		// (set) Token: 0x060275C6 RID: 161222 RVA: 0x0098F164 File Offset: 0x0098D364
		public unsafe FVector4 offsets_foe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170057B2 RID: 22450
		// (get) Token: 0x060275C7 RID: 161223 RVA: 0x0098F179 File Offset: 0x0098D379
		// (set) Token: 0x060275C8 RID: 161224 RVA: 0x0098F189 File Offset: 0x0098D389
		public unsafe float playerSpeedFoe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170057B3 RID: 22451
		// (get) Token: 0x060275C9 RID: 161225 RVA: 0x0098F19A File Offset: 0x0098D39A
		// (set) Token: 0x060275CA RID: 161226 RVA: 0x0098F1AE File Offset: 0x0098D3AE
		public unsafe FVector playerPosFoe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170057B4 RID: 22452
		// (get) Token: 0x060275CB RID: 161227 RVA: 0x0098F1C3 File Offset: 0x0098D3C3
		// (set) Token: 0x060275CC RID: 161228 RVA: 0x0098F1D3 File Offset: 0x0098D3D3
		public unsafe float SpeedLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170057B5 RID: 22453
		// (get) Token: 0x060275CD RID: 161229 RVA: 0x0098F1E4 File Offset: 0x0098D3E4
		// (set) Token: 0x060275CE RID: 161230 RVA: 0x0098F1F4 File Offset: 0x0098D3F4
		public unsafe float OffsetLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170057B6 RID: 22454
		// (get) Token: 0x060275CF RID: 161231 RVA: 0x0098F205 File Offset: 0x0098D405
		// (set) Token: 0x060275D0 RID: 161232 RVA: 0x0098F215 File Offset: 0x0098D415
		public unsafe float Delta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170057B7 RID: 22455
		// (get) Token: 0x060275D1 RID: 161233 RVA: 0x0098F226 File Offset: 0x0098D426
		// (set) Token: 0x060275D2 RID: 161234 RVA: 0x0098F23A File Offset: 0x0098D43A
		public unsafe UMaterialInterface Mat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShipTrailing_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShipTrailing_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x170057B8 RID: 22456
		// (get) Token: 0x060275D3 RID: 161235 RVA: 0x0098F24F File Offset: 0x0098D44F
		// (set) Token: 0x060275D4 RID: 161236 RVA: 0x0098F25F File Offset: 0x0098D45F
		public unsafe float TexZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShipTrailing_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x060275D5 RID: 161237 RVA: 0x0098F270 File Offset: 0x0098D470
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ShipTrailing_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060275D6 RID: 161238 RVA: 0x0098F284 File Offset: 0x0098D484
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ShipTrailing_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060275D7 RID: 161239 RVA: 0x0098F29C File Offset: 0x0098D49C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_ShipTrailing_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ShipTrailing_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ShipTrailing_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ShipTrailing_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ShipTrailing_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060275D8 RID: 161240 RVA: 0x0098F2E4 File Offset: 0x0098D4E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_ShipTrailing_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ShipTrailing_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ShipTrailing_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ShipTrailing_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ShipTrailing_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060275D9 RID: 161241 RVA: 0x0098F32B File Offset: 0x0098D52B
		protected BP_ShipTrailing_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013DD0 RID: 81360
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/ShipTrailing/BP/BP_ShipTrailing.BP_ShipTrailing_C";

		// Token: 0x04013DD1 RID: 81361
		private static IntPtr _ClassPtr;

		// Token: 0x04013DD2 RID: 81362
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013DD3 RID: 81363
		internal static int __PropertyOffset_1;

		// Token: 0x04013DD4 RID: 81364
		internal static int __PropertyOffset_2;

		// Token: 0x04013DD5 RID: 81365
		internal static int __PropertyOffset_3;

		// Token: 0x04013DD6 RID: 81366
		private TArray<float> _offsetList;

		// Token: 0x04013DD7 RID: 81367
		internal static int __PropertyOffset_4;

		// Token: 0x04013DD8 RID: 81368
		internal static int __PropertyOffset_5;

		// Token: 0x04013DD9 RID: 81369
		internal static int __PropertyOffset_6;

		// Token: 0x04013DDA RID: 81370
		internal static int __PropertyOffset_7;

		// Token: 0x04013DDB RID: 81371
		internal static int __PropertyOffset_8;

		// Token: 0x04013DDC RID: 81372
		internal static int __PropertyOffset_9;

		// Token: 0x04013DDD RID: 81373
		internal static int __PropertyOffset_10;

		// Token: 0x04013DDE RID: 81374
		internal static int __PropertyOffset_11;

		// Token: 0x04013DDF RID: 81375
		private TArray<FVector> _posList;

		// Token: 0x04013DE0 RID: 81376
		internal static int __PropertyOffset_12;

		// Token: 0x04013DE1 RID: 81377
		internal static int __PropertyOffset_13;

		// Token: 0x04013DE2 RID: 81378
		internal static int __PropertyOffset_14;

		// Token: 0x04013DE3 RID: 81379
		internal static int __PropertyOffset_15;

		// Token: 0x04013DE4 RID: 81380
		internal static int __PropertyOffset_16;

		// Token: 0x04013DE5 RID: 81381
		internal static int __PropertyOffset_17;

		// Token: 0x04013DE6 RID: 81382
		internal static int __PropertyOffset_18;

		// Token: 0x04013DE7 RID: 81383
		internal static int __PropertyOffset_19;

		// Token: 0x04013DE8 RID: 81384
		internal static int __PropertyOffset_20;

		// Token: 0x04013DE9 RID: 81385
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013DEA RID: 81386
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A21B RID: 41499
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031E85 RID: 204421
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
