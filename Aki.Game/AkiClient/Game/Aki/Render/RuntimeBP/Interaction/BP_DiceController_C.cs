using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D0E RID: 15630
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_DiceController.BP_DiceController_C")]
	[UnrealStructLayout(1184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1184)]
	public class BP_DiceController_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025738 RID: 153400 RVA: 0x0095A1B4 File Offset: 0x009583B4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DiceController_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_DiceController.BP_DiceController_C");
			}
			return BP_DiceController_C._ClassPtr;
		}

		// Token: 0x06025739 RID: 153401 RVA: 0x0095A1D8 File Offset: 0x009583D8
		public BP_DiceController_C() : this(BuiltinUtils.AllocNativeUObject(BP_DiceController_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602573A RID: 153402 RVA: 0x0095A200 File Offset: 0x00958400
		public BP_DiceController_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DiceController_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004CBC RID: 19644
		// (get) Token: 0x0602573B RID: 153403 RVA: 0x0095A233 File Offset: 0x00958433
		// (set) Token: 0x0602573C RID: 153404 RVA: 0x0095A247 File Offset: 0x00958447
		[Nullable(2)]
		public unsafe UStaticMeshComponent SM_Act_Pro_101AS
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceController_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceController_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004CBD RID: 19645
		// (get) Token: 0x0602573D RID: 153405 RVA: 0x0095A25C File Offset: 0x0095845C
		// (set) Token: 0x0602573E RID: 153406 RVA: 0x0095A270 File Offset: 0x00958470
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceController_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceController_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004CBE RID: 19646
		// (get) Token: 0x0602573F RID: 153407 RVA: 0x0095A288 File Offset: 0x00958488
		// (set) Token: 0x06025740 RID: 153408 RVA: 0x0095A2C1 File Offset: 0x009584C1
		public TArray<UMaterialInstanceDynamic> DynamicMaterialInstance
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._DynamicMaterialInstance) == null)
				{
					result = (this._DynamicMaterialInstance = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_DiceController_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.DynamicMaterialInstance.CopyAssign(value);
			}
		}

		// Token: 0x17004CBF RID: 19647
		// (get) Token: 0x06025741 RID: 153409 RVA: 0x0095A2CF File Offset: 0x009584CF
		// (set) Token: 0x06025742 RID: 153410 RVA: 0x0095A2DF File Offset: 0x009584DF
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DiceController_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DiceController_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004CC0 RID: 19648
		// (get) Token: 0x06025743 RID: 153411 RVA: 0x0095A2F0 File Offset: 0x009584F0
		// (set) Token: 0x06025744 RID: 153412 RVA: 0x0095A329 File Offset: 0x00958529
		public TMap<FName, float> DicePoints
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._DicePoints) == null)
				{
					result = (this._DicePoints = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_DiceController_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				this.DicePoints.CopyAssign(value);
			}
		}

		// Token: 0x17004CC1 RID: 19649
		// (get) Token: 0x06025745 RID: 153413 RVA: 0x0095A337 File Offset: 0x00958537
		// (set) Token: 0x06025746 RID: 153414 RVA: 0x0095A347 File Offset: 0x00958547
		public unsafe bool IsPlaying
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DiceController_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DiceController_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CC2 RID: 19650
		// (get) Token: 0x06025747 RID: 153415 RVA: 0x0095A358 File Offset: 0x00958558
		// (set) Token: 0x06025748 RID: 153416 RVA: 0x0095A368 File Offset: 0x00958568
		public unsafe float Timer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DiceController_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DiceController_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x06025749 RID: 153417 RVA: 0x0095A379 File Offset: 0x00958579
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Play()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DiceController_C.__Play_NativeFunctionPtr, null);
		}

		// Token: 0x0602574A RID: 153418 RVA: 0x0095A38D File Offset: 0x0095858D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DiceController_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602574B RID: 153419 RVA: 0x0095A3A1 File Offset: 0x009585A1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DiceController_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602574C RID: 153420 RVA: 0x0095A3B6 File Offset: 0x009585B6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DiceController_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602574D RID: 153421 RVA: 0x0095A3CA File Offset: 0x009585CA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DiceController_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602574E RID: 153422 RVA: 0x0095A3E0 File Offset: 0x009585E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_DiceController_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DiceController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DiceController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DiceController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DiceController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602574F RID: 153423 RVA: 0x0095A428 File Offset: 0x00958628
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_DiceController_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DiceController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DiceController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DiceController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DiceController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025750 RID: 153424 RVA: 0x0095A46F File Offset: 0x0095866F
		protected BP_DiceController_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012AF8 RID: 76536
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_DiceController.BP_DiceController_C";

		// Token: 0x04012AF9 RID: 76537
		private static IntPtr _ClassPtr;

		// Token: 0x04012AFA RID: 76538
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012AFB RID: 76539
		internal static int __PropertyOffset_1;

		// Token: 0x04012AFC RID: 76540
		internal static int __PropertyOffset_2;

		// Token: 0x04012AFD RID: 76541
		internal static int __PropertyOffset_3;

		// Token: 0x04012AFE RID: 76542
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _DynamicMaterialInstance;

		// Token: 0x04012AFF RID: 76543
		internal static int __PropertyOffset_4;

		// Token: 0x04012B00 RID: 76544
		internal static int __PropertyOffset_5;

		// Token: 0x04012B01 RID: 76545
		[Nullable(2)]
		private TMap<FName, float> _DicePoints;

		// Token: 0x04012B02 RID: 76546
		internal static int __PropertyOffset_6;

		// Token: 0x04012B03 RID: 76547
		internal static int __PropertyOffset_7;

		// Token: 0x04012B04 RID: 76548
		private static IntPtr __Play_NativeFunctionPtr;

		// Token: 0x04012B05 RID: 76549
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012B06 RID: 76550
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012B07 RID: 76551
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009FFC RID: 40956
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A97 RID: 203415
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
