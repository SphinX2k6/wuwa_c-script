using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive
{
	// Token: 0x02003D8E RID: 15758
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLive_InterfaceController.NinjaLive_InterfaceController_C")]
	[UnrealStructLayout(1136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1132)]
	public class NinjaLive_InterfaceController_C : AActor, IUnrealUObject, IUnrealObject, INinjaLiveInterface_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06026F57 RID: 159575 RVA: 0x0098297B File Offset: 0x00980B7B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NinjaLive_InterfaceController_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLive_InterfaceController.NinjaLive_InterfaceController_C");
			}
			return NinjaLive_InterfaceController_C._ClassPtr;
		}

		// Token: 0x06026F58 RID: 159576 RVA: 0x009829A0 File Offset: 0x00980BA0
		public NinjaLive_InterfaceController_C() : this(BuiltinUtils.AllocNativeUObject(NinjaLive_InterfaceController_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026F59 RID: 159577 RVA: 0x009829C8 File Offset: 0x00980BC8
		[NullableContext(1)]
		public NinjaLive_InterfaceController_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NinjaLive_InterfaceController_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005582 RID: 21890
		// (get) Token: 0x06026F5A RID: 159578 RVA: 0x009829FB File Offset: 0x00980BFB
		// (set) Token: 0x06026F5B RID: 159579 RVA: 0x00982A0F File Offset: 0x00980C0F
		[Nullable(2)]
		public unsafe USceneComponent Scene
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_InterfaceController_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_InterfaceController_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005583 RID: 21891
		// (get) Token: 0x06026F5C RID: 159580 RVA: 0x00982A24 File Offset: 0x00980C24
		// (set) Token: 0x06026F5D RID: 159581 RVA: 0x00982A38 File Offset: 0x00980C38
		[Nullable(2)]
		public unsafe UBillboardComponent Billboard
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_InterfaceController_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_InterfaceController_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005584 RID: 21892
		// (get) Token: 0x06026F5E RID: 159582 RVA: 0x00982A4D File Offset: 0x00980C4D
		// (set) Token: 0x06026F5F RID: 159583 RVA: 0x00982A5D File Offset: 0x00980C5D
		public unsafe bool DisableCommandbasedControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_InterfaceController_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_InterfaceController_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005585 RID: 21893
		// (get) Token: 0x06026F60 RID: 159584 RVA: 0x00982A6E File Offset: 0x00980C6E
		// (set) Token: 0x06026F61 RID: 159585 RVA: 0x00982A7E File Offset: 0x00980C7E
		public unsafe bool EnableOnTickControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_InterfaceController_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_InterfaceController_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005586 RID: 21894
		// (get) Token: 0x06026F62 RID: 159586 RVA: 0x00982A90 File Offset: 0x00980C90
		// (set) Token: 0x06026F63 RID: 159587 RVA: 0x00982AC9 File Offset: 0x00980CC9
		[Nullable(1)]
		public TArray<AActor> InterfaceTargetActors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._InterfaceTargetActors) == null)
				{
					result = (this._InterfaceTargetActors = new TArray<AActor>(base.NativePtr + (IntPtr)NinjaLive_InterfaceController_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.InterfaceTargetActors.CopyAssign(value);
			}
		}

		// Token: 0x17005587 RID: 21895
		// (get) Token: 0x06026F64 RID: 159588 RVA: 0x00982AD8 File Offset: 0x00980CD8
		// (set) Token: 0x06026F65 RID: 159589 RVA: 0x00982B11 File Offset: 0x00980D11
		[Nullable(1)]
		public TArray<FName> InterfaceCommands
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._InterfaceCommands) == null)
				{
					result = (this._InterfaceCommands = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLive_InterfaceController_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.InterfaceCommands.CopyAssign(value);
			}
		}

		// Token: 0x17005588 RID: 21896
		// (get) Token: 0x06026F66 RID: 159590 RVA: 0x00982B1F File Offset: 0x00980D1F
		// (set) Token: 0x06026F67 RID: 159591 RVA: 0x00982B2F File Offset: 0x00980D2F
		public unsafe int CommandToBeExecuted
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_InterfaceController_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_InterfaceController_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005589 RID: 21897
		// (get) Token: 0x06026F68 RID: 159592 RVA: 0x00982B40 File Offset: 0x00980D40
		// (set) Token: 0x06026F69 RID: 159593 RVA: 0x00982B50 File Offset: 0x00980D50
		public unsafe float DelayBeforeExecutingCommand
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_InterfaceController_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_InterfaceController_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700558A RID: 21898
		// (get) Token: 0x06026F6A RID: 159594 RVA: 0x00982B61 File Offset: 0x00980D61
		// (set) Token: 0x06026F6B RID: 159595 RVA: 0x00982B71 File Offset: 0x00980D71
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_InterfaceController_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_InterfaceController_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700558B RID: 21899
		// (get) Token: 0x06026F6C RID: 159596 RVA: 0x00982B82 File Offset: 0x00980D82
		// (set) Token: 0x06026F6D RID: 159597 RVA: 0x00982B92 File Offset: 0x00980D92
		public unsafe float FadeTimeOfBrush
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_InterfaceController_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_InterfaceController_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700558C RID: 21900
		// (get) Token: 0x06026F6E RID: 159598 RVA: 0x00982BA3 File Offset: 0x00980DA3
		// (set) Token: 0x06026F6F RID: 159599 RVA: 0x00982BB3 File Offset: 0x00980DB3
		public unsafe float FadeTimeOfCanvas
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_InterfaceController_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_InterfaceController_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x06026F70 RID: 159600 RVA: 0x00982BC4 File Offset: 0x00980DC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void LiveActivation(FName ParamName, float FadeTimeOfBrush, float FadeTimeOfCanvas)
		{
			NinjaLive_InterfaceController_C.__LiveActivation_FunctionParams* ptr = stackalloc NinjaLive_InterfaceController_C.__LiveActivation_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(NinjaLive_InterfaceController_C.__LiveActivation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_InterfaceController_C.__LiveActivation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ParamName = ParamName;
			ptr->FadeTimeOfBrush = FadeTimeOfBrush;
			ptr->FadeTimeOfCanvas = FadeTimeOfCanvas;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_InterfaceController_C.__LiveActivation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026F71 RID: 159601 RVA: 0x00982C18 File Offset: 0x00980E18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void LiveFluidParams(float BrushSize)
		{
			NinjaLive_InterfaceController_C.__LiveFluidParams_FunctionParams* ptr = stackalloc NinjaLive_InterfaceController_C.__LiveFluidParams_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLive_InterfaceController_C.__LiveFluidParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_InterfaceController_C.__LiveFluidParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BrushSize = BrushSize;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_InterfaceController_C.__LiveFluidParams_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026F72 RID: 159602 RVA: 0x00982C5E File Offset: 0x00980E5E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_InterfaceController_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06026F73 RID: 159603 RVA: 0x00982C72 File Offset: 0x00980E72
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLive_InterfaceController_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026F74 RID: 159604 RVA: 0x00982C88 File Offset: 0x00980E88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			NinjaLive_InterfaceController_C.__ReceiveTick_FunctionParams* ptr = stackalloc NinjaLive_InterfaceController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLive_InterfaceController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_InterfaceController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_InterfaceController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026F75 RID: 159605 RVA: 0x00982CD0 File Offset: 0x00980ED0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			NinjaLive_InterfaceController_C.__ReceiveTick_FunctionParams* ptr = stackalloc NinjaLive_InterfaceController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLive_InterfaceController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_InterfaceController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLive_InterfaceController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026F76 RID: 159606 RVA: 0x00982D17 File Offset: 0x00980F17
		protected NinjaLive_InterfaceController_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040139D8 RID: 80344
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLive_InterfaceController.NinjaLive_InterfaceController_C";

		// Token: 0x040139D9 RID: 80345
		private static IntPtr _ClassPtr;

		// Token: 0x040139DA RID: 80346
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040139DB RID: 80347
		internal static int __PropertyOffset_1;

		// Token: 0x040139DC RID: 80348
		internal static int __PropertyOffset_2;

		// Token: 0x040139DD RID: 80349
		internal static int __PropertyOffset_3;

		// Token: 0x040139DE RID: 80350
		internal static int __PropertyOffset_4;

		// Token: 0x040139DF RID: 80351
		internal static int __PropertyOffset_5;

		// Token: 0x040139E0 RID: 80352
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _InterfaceTargetActors;

		// Token: 0x040139E1 RID: 80353
		internal static int __PropertyOffset_6;

		// Token: 0x040139E2 RID: 80354
		[Nullable(2)]
		private TArray<FName> _InterfaceCommands;

		// Token: 0x040139E3 RID: 80355
		internal static int __PropertyOffset_7;

		// Token: 0x040139E4 RID: 80356
		internal static int __PropertyOffset_8;

		// Token: 0x040139E5 RID: 80357
		internal static int __PropertyOffset_9;

		// Token: 0x040139E6 RID: 80358
		internal static int __PropertyOffset_10;

		// Token: 0x040139E7 RID: 80359
		internal static int __PropertyOffset_11;

		// Token: 0x040139E8 RID: 80360
		private static IntPtr __LiveActivation_NativeFunctionPtr;

		// Token: 0x040139E9 RID: 80361
		private static IntPtr __LiveFluidParams_NativeFunctionPtr;

		// Token: 0x040139EA RID: 80362
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040139EB RID: 80363
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A167 RID: 41319
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __LiveActivation_FunctionParams
		{
			// Token: 0x04031D23 RID: 204067
			[FieldOffset(0)]
			public FName ParamName;

			// Token: 0x04031D24 RID: 204068
			[FieldOffset(12)]
			public float FadeTimeOfBrush;

			// Token: 0x04031D25 RID: 204069
			[FieldOffset(16)]
			public float FadeTimeOfCanvas;
		}

		// Token: 0x0200A168 RID: 41320
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __LiveFluidParams_FunctionParams
		{
			// Token: 0x04031D26 RID: 204070
			[FieldOffset(0)]
			public float BrushSize;
		}

		// Token: 0x0200A169 RID: 41321
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031D27 RID: 204071
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
