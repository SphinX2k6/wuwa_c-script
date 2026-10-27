using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.CharacterWetTrace
{
	// Token: 0x02003CC8 RID: 15560
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/CharacterWetTrace/BP_CharacterWetDecal.BP_CharacterWetDecal_C")]
	[UnrealStructLayout(1640, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1638)]
	public class BP_CharacterWetDecal_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024CEA RID: 150762 RVA: 0x00948DE9 File Offset: 0x00946FE9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CharacterWetDecal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/CharacterWetTrace/BP_CharacterWetDecal.BP_CharacterWetDecal_C");
			}
			return BP_CharacterWetDecal_C._ClassPtr;
		}

		// Token: 0x06024CEB RID: 150763 RVA: 0x00948E10 File Offset: 0x00947010
		public BP_CharacterWetDecal_C() : this(BuiltinUtils.AllocNativeUObject(BP_CharacterWetDecal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024CEC RID: 150764 RVA: 0x00948E38 File Offset: 0x00947038
		[NullableContext(1)]
		public BP_CharacterWetDecal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CharacterWetDecal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004931 RID: 18737
		// (get) Token: 0x06024CED RID: 150765 RVA: 0x00948E6B File Offset: 0x0094706B
		// (set) Token: 0x06024CEE RID: 150766 RVA: 0x00948E7F File Offset: 0x0094707F
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterWetDecal_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterWetDecal_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004932 RID: 18738
		// (get) Token: 0x06024CEF RID: 150767 RVA: 0x00948E94 File Offset: 0x00947094
		// (set) Token: 0x06024CF0 RID: 150768 RVA: 0x00948EA8 File Offset: 0x009470A8
		public unsafe UMaterialInstance WetButtDecalMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterWetDecal_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterWetDecal_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004933 RID: 18739
		// (get) Token: 0x06024CF1 RID: 150769 RVA: 0x00948EBD File Offset: 0x009470BD
		// (set) Token: 0x06024CF2 RID: 150770 RVA: 0x00948ED1 File Offset: 0x009470D1
		public unsafe UDecalComponent WetButtDecal
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDecalComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterWetDecal_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterWetDecal_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004934 RID: 18740
		// (get) Token: 0x06024CF3 RID: 150771 RVA: 0x00948EE6 File Offset: 0x009470E6
		// (set) Token: 0x06024CF4 RID: 150772 RVA: 0x00948EF6 File Offset: 0x009470F6
		public unsafe bool HasDecal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004935 RID: 18741
		// (get) Token: 0x06024CF5 RID: 150773 RVA: 0x00948F07 File Offset: 0x00947107
		// (set) Token: 0x06024CF6 RID: 150774 RVA: 0x00948F17 File Offset: 0x00947117
		public unsafe bool Test湿身
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004936 RID: 18742
		// (get) Token: 0x06024CF7 RID: 150775 RVA: 0x00948F28 File Offset: 0x00947128
		// (set) Token: 0x06024CF8 RID: 150776 RVA: 0x00948F3C File Offset: 0x0094713C
		public unsafe FVector DecalPositionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004937 RID: 18743
		// (get) Token: 0x06024CF9 RID: 150777 RVA: 0x00948F51 File Offset: 0x00947151
		// (set) Token: 0x06024CFA RID: 150778 RVA: 0x00948F61 File Offset: 0x00947161
		public unsafe float DecalRotationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004938 RID: 18744
		// (get) Token: 0x06024CFB RID: 150779 RVA: 0x00948F72 File Offset: 0x00947172
		// (set) Token: 0x06024CFC RID: 150780 RVA: 0x00948F86 File Offset: 0x00947186
		public unsafe FVector Decal_Size_Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004939 RID: 18745
		// (get) Token: 0x06024CFD RID: 150781 RVA: 0x00948F9B File Offset: 0x0094719B
		// (set) Token: 0x06024CFE RID: 150782 RVA: 0x00948FAB File Offset: 0x009471AB
		public unsafe float DecalDisapearTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700493A RID: 18746
		// (get) Token: 0x06024CFF RID: 150783 RVA: 0x00948FBC File Offset: 0x009471BC
		// (set) Token: 0x06024D00 RID: 150784 RVA: 0x00948FF5 File Offset: 0x009471F5
		[Nullable(1)]
		public TMap<string, FVector> BodyType
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<string, FVector> result;
				if ((result = this._BodyType) == null)
				{
					result = (this._BodyType = new TMap<string, FVector>(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_10, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BodyType.CopyAssign(value);
			}
		}

		// Token: 0x1700493B RID: 18747
		// (get) Token: 0x06024D01 RID: 150785 RVA: 0x00949003 File Offset: 0x00947203
		// (set) Token: 0x06024D02 RID: 150786 RVA: 0x00949013 File Offset: 0x00947213
		public unsafe float CharWetProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700493C RID: 18748
		// (get) Token: 0x06024D03 RID: 150787 RVA: 0x00949024 File Offset: 0x00947224
		// (set) Token: 0x06024D04 RID: 150788 RVA: 0x00949038 File Offset: 0x00947238
		public unsafe UMaterialInstanceDynamic ButtDecalDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterWetDecal_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterWetDecal_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x1700493D RID: 18749
		// (get) Token: 0x06024D05 RID: 150789 RVA: 0x0094904D File Offset: 0x0094724D
		// (set) Token: 0x06024D06 RID: 150790 RVA: 0x0094905D File Offset: 0x0094725D
		public unsafe float DisappearDecalLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700493E RID: 18750
		// (get) Token: 0x06024D07 RID: 150791 RVA: 0x0094906E File Offset: 0x0094726E
		// (set) Token: 0x06024D08 RID: 150792 RVA: 0x00949082 File Offset: 0x00947282
		public unsafe FVector Decal_Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700493F RID: 18751
		// (get) Token: 0x06024D09 RID: 150793 RVA: 0x00949097 File Offset: 0x00947297
		// (set) Token: 0x06024D0A RID: 150794 RVA: 0x009490AB File Offset: 0x009472AB
		public unsafe FVector DecalScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004940 RID: 18752
		// (get) Token: 0x06024D0B RID: 150795 RVA: 0x009490C0 File Offset: 0x009472C0
		// (set) Token: 0x06024D0C RID: 150796 RVA: 0x009490D0 File Offset: 0x009472D0
		public unsafe bool DecalLocationDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004941 RID: 18753
		// (get) Token: 0x06024D0D RID: 150797 RVA: 0x009490E1 File Offset: 0x009472E1
		// (set) Token: 0x06024D0E RID: 150798 RVA: 0x009490F1 File Offset: 0x009472F1
		public unsafe bool DebugWetStat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterWetDecal_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024D0F RID: 150799 RVA: 0x00949102 File Offset: 0x00947302
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetDecalScale()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterWetDecal_C.__SetDecalScale_NativeFunctionPtr, null);
		}

		// Token: 0x06024D10 RID: 150800 RVA: 0x00949116 File Offset: 0x00947316
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterWetDecal_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024D11 RID: 150801 RVA: 0x0094912A File Offset: 0x0094732A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CharacterWetDecal_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024D12 RID: 150802 RVA: 0x0094913F File Offset: 0x0094733F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterWetDecal_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024D13 RID: 150803 RVA: 0x00949153 File Offset: 0x00947353
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CharacterWetDecal_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024D14 RID: 150804 RVA: 0x00949168 File Offset: 0x00947368
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CharacterWetDecal_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CharacterWetDecal_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CharacterWetDecal_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterWetDecal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterWetDecal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024D15 RID: 150805 RVA: 0x009491B0 File Offset: 0x009473B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CharacterWetDecal_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CharacterWetDecal_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CharacterWetDecal_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterWetDecal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CharacterWetDecal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024D16 RID: 150806 RVA: 0x009491F7 File Offset: 0x009473F7
		protected BP_CharacterWetDecal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124AA RID: 74922
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/CharacterWetTrace/BP_CharacterWetDecal.BP_CharacterWetDecal_C";

		// Token: 0x040124AB RID: 74923
		private static IntPtr _ClassPtr;

		// Token: 0x040124AC RID: 74924
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124AD RID: 74925
		internal static int __PropertyOffset_1;

		// Token: 0x040124AE RID: 74926
		internal static int __PropertyOffset_2;

		// Token: 0x040124AF RID: 74927
		internal static int __PropertyOffset_3;

		// Token: 0x040124B0 RID: 74928
		internal static int __PropertyOffset_4;

		// Token: 0x040124B1 RID: 74929
		internal static int __PropertyOffset_5;

		// Token: 0x040124B2 RID: 74930
		internal static int __PropertyOffset_6;

		// Token: 0x040124B3 RID: 74931
		internal static int __PropertyOffset_7;

		// Token: 0x040124B4 RID: 74932
		internal static int __PropertyOffset_8;

		// Token: 0x040124B5 RID: 74933
		internal static int __PropertyOffset_9;

		// Token: 0x040124B6 RID: 74934
		internal static int __PropertyOffset_10;

		// Token: 0x040124B7 RID: 74935
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FVector> _BodyType;

		// Token: 0x040124B8 RID: 74936
		internal static int __PropertyOffset_11;

		// Token: 0x040124B9 RID: 74937
		internal static int __PropertyOffset_12;

		// Token: 0x040124BA RID: 74938
		internal static int __PropertyOffset_13;

		// Token: 0x040124BB RID: 74939
		internal static int __PropertyOffset_14;

		// Token: 0x040124BC RID: 74940
		internal static int __PropertyOffset_15;

		// Token: 0x040124BD RID: 74941
		internal static int __PropertyOffset_16;

		// Token: 0x040124BE RID: 74942
		internal static int __PropertyOffset_17;

		// Token: 0x040124BF RID: 74943
		private static IntPtr __SetDecalScale_NativeFunctionPtr;

		// Token: 0x040124C0 RID: 74944
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040124C1 RID: 74945
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040124C2 RID: 74946
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009F6F RID: 40815
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403196E RID: 203118
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
