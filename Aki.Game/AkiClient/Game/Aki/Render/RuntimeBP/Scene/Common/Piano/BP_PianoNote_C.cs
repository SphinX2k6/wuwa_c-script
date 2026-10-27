using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.Piano
{
	// Token: 0x02003B68 RID: 15208
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/Piano/BP_PianoNote.BP_PianoNote_C")]
	[UnrealStructLayout(1192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1192)]
	public class BP_PianoNote_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021CDE RID: 138462 RVA: 0x008F642C File Offset: 0x008F462C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PianoNote_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/Piano/BP_PianoNote.BP_PianoNote_C");
			}
			return BP_PianoNote_C._ClassPtr;
		}

		// Token: 0x06021CDF RID: 138463 RVA: 0x008F6450 File Offset: 0x008F4650
		public BP_PianoNote_C() : this(BuiltinUtils.AllocNativeUObject(BP_PianoNote_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021CE0 RID: 138464 RVA: 0x008F6478 File Offset: 0x008F4678
		[NullableContext(1)]
		public BP_PianoNote_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PianoNote_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700386F RID: 14447
		// (get) Token: 0x06021CE1 RID: 138465 RVA: 0x008F64AB File Offset: 0x008F46AB
		// (set) Token: 0x06021CE2 RID: 138466 RVA: 0x008F64BF File Offset: 0x008F46BF
		public unsafe USceneComponent Effect_Slot_4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoNote_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoNote_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003870 RID: 14448
		// (get) Token: 0x06021CE3 RID: 138467 RVA: 0x008F64D4 File Offset: 0x008F46D4
		// (set) Token: 0x06021CE4 RID: 138468 RVA: 0x008F64E8 File Offset: 0x008F46E8
		public unsafe USceneComponent Effect_Slot_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoNote_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoNote_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003871 RID: 14449
		// (get) Token: 0x06021CE5 RID: 138469 RVA: 0x008F64FD File Offset: 0x008F46FD
		// (set) Token: 0x06021CE6 RID: 138470 RVA: 0x008F6511 File Offset: 0x008F4711
		public unsafe USceneComponent Effect_Slot_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoNote_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoNote_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003872 RID: 14450
		// (get) Token: 0x06021CE7 RID: 138471 RVA: 0x008F6526 File Offset: 0x008F4726
		// (set) Token: 0x06021CE8 RID: 138472 RVA: 0x008F653A File Offset: 0x008F473A
		public unsafe USceneComponent Effect_Slot_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoNote_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoNote_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003873 RID: 14451
		// (get) Token: 0x06021CE9 RID: 138473 RVA: 0x008F654F File Offset: 0x008F474F
		// (set) Token: 0x06021CEA RID: 138474 RVA: 0x008F6563 File Offset: 0x008F4763
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoNote_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoNote_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003874 RID: 14452
		// (get) Token: 0x06021CEB RID: 138475 RVA: 0x008F6578 File Offset: 0x008F4778
		// (set) Token: 0x06021CEC RID: 138476 RVA: 0x008F658C File Offset: 0x008F478C
		public unsafe FLinearColor Active_Material_Rim_Light_Color_A888AF6A45124F81A06A9CB54FC79F6B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoNote_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoNote_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003875 RID: 14453
		// (get) Token: 0x06021CED RID: 138477 RVA: 0x008F65A1 File Offset: 0x008F47A1
		// (set) Token: 0x06021CEE RID: 138478 RVA: 0x008F65B1 File Offset: 0x008F47B1
		public unsafe float Active_Material_Rim_Power_A888AF6A45124F81A06A9CB54FC79F6B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoNote_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoNote_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003876 RID: 14454
		// (get) Token: 0x06021CEF RID: 138479 RVA: 0x008F65C2 File Offset: 0x008F47C2
		// (set) Token: 0x06021CF0 RID: 138480 RVA: 0x008F65D6 File Offset: 0x008F47D6
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Active_Material__Direction_A888AF6A45124F81A06A9CB54FC79F6B
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoNote_C.__PropertyOffset_8);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoNote_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003877 RID: 14455
		// (get) Token: 0x06021CF1 RID: 138481 RVA: 0x008F65EB File Offset: 0x008F47EB
		// (set) Token: 0x06021CF2 RID: 138482 RVA: 0x008F65FF File Offset: 0x008F47FF
		public unsafe UTimelineComponent Active_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoNote_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoNote_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003878 RID: 14456
		// (get) Token: 0x06021CF3 RID: 138483 RVA: 0x008F6614 File Offset: 0x008F4814
		// (set) Token: 0x06021CF4 RID: 138484 RVA: 0x008F6628 File Offset: 0x008F4828
		public unsafe USceneComponent RootSceneComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoNote_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoNote_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17003879 RID: 14457
		// (get) Token: 0x06021CF5 RID: 138485 RVA: 0x008F663D File Offset: 0x008F483D
		// (set) Token: 0x06021CF6 RID: 138486 RVA: 0x008F6651 File Offset: 0x008F4851
		public unsafe UKuroMaterialControllerComponent MaterialController
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoNote_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoNote_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x1700387A RID: 14458
		// (get) Token: 0x06021CF7 RID: 138487 RVA: 0x008F6666 File Offset: 0x008F4866
		// (set) Token: 0x06021CF8 RID: 138488 RVA: 0x008F6676 File Offset: 0x008F4876
		public unsafe int TriggerCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoNote_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoNote_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700387B RID: 14459
		// (get) Token: 0x06021CF9 RID: 138489 RVA: 0x008F6687 File Offset: 0x008F4887
		// (set) Token: 0x06021CFA RID: 138490 RVA: 0x008F6697 File Offset: 0x008F4897
		public unsafe bool IsTriggerd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoNote_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoNote_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700387C RID: 14460
		// (get) Token: 0x06021CFB RID: 138491 RVA: 0x008F66A8 File Offset: 0x008F48A8
		// (set) Token: 0x06021CFC RID: 138492 RVA: 0x008F66E1 File Offset: 0x008F48E1
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> MaterialInstanceArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._MaterialInstanceArray) == null)
				{
					result = (this._MaterialInstanceArray = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_PianoNote_C.__PropertyOffset_14, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialInstanceArray.CopyAssign(value);
			}
		}

		// Token: 0x1700387D RID: 14461
		// (get) Token: 0x06021CFD RID: 138493 RVA: 0x008F66EF File Offset: 0x008F48EF
		// (set) Token: 0x06021CFE RID: 138494 RVA: 0x008F6703 File Offset: 0x008F4903
		public unsafe UObject ActiveEffectDA_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoNote_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoNote_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x1700387E RID: 14462
		// (get) Token: 0x06021CFF RID: 138495 RVA: 0x008F6718 File Offset: 0x008F4918
		// (set) Token: 0x06021D00 RID: 138496 RVA: 0x008F672C File Offset: 0x008F492C
		public unsafe UObject ActiveEffectDA_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoNote_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoNote_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x1700387F RID: 14463
		// (get) Token: 0x06021D01 RID: 138497 RVA: 0x008F6741 File Offset: 0x008F4941
		// (set) Token: 0x06021D02 RID: 138498 RVA: 0x008F6755 File Offset: 0x008F4955
		public unsafe UObject ActiveEffectDA_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoNote_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoNote_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x06021D03 RID: 138499 RVA: 0x008F676A File Offset: 0x008F496A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void AddTriggerCount()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoNote_C.__AddTriggerCount_NativeFunctionPtr, null);
		}

		// Token: 0x06021D04 RID: 138500 RVA: 0x008F677E File Offset: 0x008F497E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Active_Material__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoNote_C.__Active_Material__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D05 RID: 138501 RVA: 0x008F6792 File Offset: 0x008F4992
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Active_Material__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoNote_C.__Active_Material__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D06 RID: 138502 RVA: 0x008F67A6 File Offset: 0x008F49A6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoNote_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021D07 RID: 138503 RVA: 0x008F67BA File Offset: 0x008F49BA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PianoNote_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021D08 RID: 138504 RVA: 0x008F67CF File Offset: 0x008F49CF
		protected BP_PianoNote_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401080E RID: 67598
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/Piano/BP_PianoNote.BP_PianoNote_C";

		// Token: 0x0401080F RID: 67599
		private static IntPtr _ClassPtr;

		// Token: 0x04010810 RID: 67600
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010811 RID: 67601
		internal static int __PropertyOffset_1;

		// Token: 0x04010812 RID: 67602
		internal static int __PropertyOffset_2;

		// Token: 0x04010813 RID: 67603
		internal static int __PropertyOffset_3;

		// Token: 0x04010814 RID: 67604
		internal static int __PropertyOffset_4;

		// Token: 0x04010815 RID: 67605
		internal static int __PropertyOffset_5;

		// Token: 0x04010816 RID: 67606
		internal static int __PropertyOffset_6;

		// Token: 0x04010817 RID: 67607
		internal static int __PropertyOffset_7;

		// Token: 0x04010818 RID: 67608
		internal static int __PropertyOffset_8;

		// Token: 0x04010819 RID: 67609
		internal static int __PropertyOffset_9;

		// Token: 0x0401081A RID: 67610
		internal static int __PropertyOffset_10;

		// Token: 0x0401081B RID: 67611
		internal static int __PropertyOffset_11;

		// Token: 0x0401081C RID: 67612
		internal static int __PropertyOffset_12;

		// Token: 0x0401081D RID: 67613
		internal static int __PropertyOffset_13;

		// Token: 0x0401081E RID: 67614
		internal static int __PropertyOffset_14;

		// Token: 0x0401081F RID: 67615
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _MaterialInstanceArray;

		// Token: 0x04010820 RID: 67616
		internal static int __PropertyOffset_15;

		// Token: 0x04010821 RID: 67617
		internal static int __PropertyOffset_16;

		// Token: 0x04010822 RID: 67618
		internal static int __PropertyOffset_17;

		// Token: 0x04010823 RID: 67619
		private static IntPtr __AddTriggerCount_NativeFunctionPtr;

		// Token: 0x04010824 RID: 67620
		private static IntPtr __Active_Material__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04010825 RID: 67621
		private static IntPtr __Active_Material__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04010826 RID: 67622
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
