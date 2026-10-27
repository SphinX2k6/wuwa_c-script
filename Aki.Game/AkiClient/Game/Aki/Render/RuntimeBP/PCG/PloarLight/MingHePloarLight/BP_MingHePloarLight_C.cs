using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.PloarLight.MingHePloarLight
{
	// Token: 0x02003C31 RID: 15409
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/PloarLight/MingHePloarLight/BP_MingHePloarLight.BP_MingHePloarLight_C")]
	[UnrealStructLayout(1592, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1592)]
	public class BP_MingHePloarLight_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602369C RID: 145052 RVA: 0x009234FD File Offset: 0x009216FD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MingHePloarLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/PloarLight/MingHePloarLight/BP_MingHePloarLight.BP_MingHePloarLight_C");
			}
			return BP_MingHePloarLight_C._ClassPtr;
		}

		// Token: 0x0602369D RID: 145053 RVA: 0x00923524 File Offset: 0x00921724
		public BP_MingHePloarLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_MingHePloarLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602369E RID: 145054 RVA: 0x0092354C File Offset: 0x0092174C
		[NullableContext(1)]
		public BP_MingHePloarLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MingHePloarLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004130 RID: 16688
		// (get) Token: 0x0602369F RID: 145055 RVA: 0x0092357F File Offset: 0x0092177F
		// (set) Token: 0x060236A0 RID: 145056 RVA: 0x00923593 File Offset: 0x00921793
		public unsafe UTextRenderComponent BP_PloarLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MingHePloarLight_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MingHePloarLight_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004131 RID: 16689
		// (get) Token: 0x060236A1 RID: 145057 RVA: 0x009235A8 File Offset: 0x009217A8
		// (set) Token: 0x060236A2 RID: 145058 RVA: 0x009235BC File Offset: 0x009217BC
		public unsafe UStaticMeshComponent SM_NewPloarLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MingHePloarLight_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MingHePloarLight_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004132 RID: 16690
		// (get) Token: 0x060236A3 RID: 145059 RVA: 0x009235D1 File Offset: 0x009217D1
		// (set) Token: 0x060236A4 RID: 145060 RVA: 0x009235E5 File Offset: 0x009217E5
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MingHePloarLight_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MingHePloarLight_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004133 RID: 16691
		// (get) Token: 0x060236A5 RID: 145061 RVA: 0x009235FA File Offset: 0x009217FA
		// (set) Token: 0x060236A6 RID: 145062 RVA: 0x0092360A File Offset: 0x0092180A
		public unsafe bool DebugView
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MingHePloarLight_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MingHePloarLight_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004134 RID: 16692
		// (get) Token: 0x060236A7 RID: 145063 RVA: 0x0092361B File Offset: 0x0092181B
		// (set) Token: 0x060236A8 RID: 145064 RVA: 0x0092362B File Offset: 0x0092182B
		public unsafe float Location_Z
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MingHePloarLight_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MingHePloarLight_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004135 RID: 16693
		// (get) Token: 0x060236A9 RID: 145065 RVA: 0x0092363C File Offset: 0x0092183C
		// (set) Token: 0x060236AA RID: 145066 RVA: 0x00923650 File Offset: 0x00921850
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MingHePloarLight_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MingHePloarLight_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004136 RID: 16694
		// (get) Token: 0x060236AB RID: 145067 RVA: 0x00923665 File Offset: 0x00921865
		// (set) Token: 0x060236AC RID: 145068 RVA: 0x00923679 File Offset: 0x00921879
		public unsafe FVector Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MingHePloarLight_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MingHePloarLight_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004137 RID: 16695
		// (get) Token: 0x060236AD RID: 145069 RVA: 0x0092368E File Offset: 0x0092188E
		// (set) Token: 0x060236AE RID: 145070 RVA: 0x009236A2 File Offset: 0x009218A2
		public unsafe UMaterialInstanceDynamic Material_DMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MingHePloarLight_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MingHePloarLight_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17004138 RID: 16696
		// (get) Token: 0x060236AF RID: 145071 RVA: 0x009236B7 File Offset: 0x009218B7
		// (set) Token: 0x060236B0 RID: 145072 RVA: 0x009236CB File Offset: 0x009218CB
		public unsafe UStaticMesh StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MingHePloarLight_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MingHePloarLight_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17004139 RID: 16697
		// (get) Token: 0x060236B1 RID: 145073 RVA: 0x009236E0 File Offset: 0x009218E0
		// (set) Token: 0x060236B2 RID: 145074 RVA: 0x009236F4 File Offset: 0x009218F4
		public unsafe UMaterialInstance Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MingHePloarLight_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MingHePloarLight_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x1700413A RID: 16698
		// (get) Token: 0x060236B3 RID: 145075 RVA: 0x00923709 File Offset: 0x00921909
		// (set) Token: 0x060236B4 RID: 145076 RVA: 0x0092371D File Offset: 0x0092191D
		public unsafe FLinearColor ColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MingHePloarLight_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MingHePloarLight_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700413B RID: 16699
		// (get) Token: 0x060236B5 RID: 145077 RVA: 0x00923732 File Offset: 0x00921932
		// (set) Token: 0x060236B6 RID: 145078 RVA: 0x00923742 File Offset: 0x00921942
		public unsafe float MaskContrast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MingHePloarLight_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MingHePloarLight_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700413C RID: 16700
		// (get) Token: 0x060236B7 RID: 145079 RVA: 0x00923753 File Offset: 0x00921953
		// (set) Token: 0x060236B8 RID: 145080 RVA: 0x00923763 File Offset: 0x00921963
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MingHePloarLight_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MingHePloarLight_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700413D RID: 16701
		// (get) Token: 0x060236B9 RID: 145081 RVA: 0x00923774 File Offset: 0x00921974
		// (set) Token: 0x060236BA RID: 145082 RVA: 0x00923784 File Offset: 0x00921984
		public unsafe bool Is_Android
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MingHePloarLight_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MingHePloarLight_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700413E RID: 16702
		// (get) Token: 0x060236BB RID: 145083 RVA: 0x00923795 File Offset: 0x00921995
		// (set) Token: 0x060236BC RID: 145084 RVA: 0x009237A9 File Offset: 0x009219A9
		public unsafe UMaterialInstance ES3_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MingHePloarLight_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MingHePloarLight_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x1700413F RID: 16703
		// (get) Token: 0x060236BD RID: 145085 RVA: 0x009237BE File Offset: 0x009219BE
		// (set) Token: 0x060236BE RID: 145086 RVA: 0x009237D2 File Offset: 0x009219D2
		public unsafe UMaterialInstanceDynamic Material_DMI_ES3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MingHePloarLight_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MingHePloarLight_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x060236BF RID: 145087 RVA: 0x009237E7 File Offset: 0x009219E7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Is_ES3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MingHePloarLight_C.__Is_ES3_NativeFunctionPtr, null);
		}

		// Token: 0x060236C0 RID: 145088 RVA: 0x009237FB File Offset: 0x009219FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MingHePloarLight_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060236C1 RID: 145089 RVA: 0x0092380F File Offset: 0x00921A0F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MingHePloarLight_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060236C2 RID: 145090 RVA: 0x00923824 File Offset: 0x00921A24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MingHePloarLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060236C3 RID: 145091 RVA: 0x00923838 File Offset: 0x00921A38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MingHePloarLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060236C4 RID: 145092 RVA: 0x0092384D File Offset: 0x00921A4D
		protected BP_MingHePloarLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040117A6 RID: 71590
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/PloarLight/MingHePloarLight/BP_MingHePloarLight.BP_MingHePloarLight_C";

		// Token: 0x040117A7 RID: 71591
		private static IntPtr _ClassPtr;

		// Token: 0x040117A8 RID: 71592
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040117A9 RID: 71593
		internal static int __PropertyOffset_1;

		// Token: 0x040117AA RID: 71594
		internal static int __PropertyOffset_2;

		// Token: 0x040117AB RID: 71595
		internal static int __PropertyOffset_3;

		// Token: 0x040117AC RID: 71596
		internal static int __PropertyOffset_4;

		// Token: 0x040117AD RID: 71597
		internal static int __PropertyOffset_5;

		// Token: 0x040117AE RID: 71598
		internal static int __PropertyOffset_6;

		// Token: 0x040117AF RID: 71599
		internal static int __PropertyOffset_7;

		// Token: 0x040117B0 RID: 71600
		internal static int __PropertyOffset_8;

		// Token: 0x040117B1 RID: 71601
		internal static int __PropertyOffset_9;

		// Token: 0x040117B2 RID: 71602
		internal static int __PropertyOffset_10;

		// Token: 0x040117B3 RID: 71603
		internal static int __PropertyOffset_11;

		// Token: 0x040117B4 RID: 71604
		internal static int __PropertyOffset_12;

		// Token: 0x040117B5 RID: 71605
		internal static int __PropertyOffset_13;

		// Token: 0x040117B6 RID: 71606
		internal static int __PropertyOffset_14;

		// Token: 0x040117B7 RID: 71607
		internal static int __PropertyOffset_15;

		// Token: 0x040117B8 RID: 71608
		internal static int __PropertyOffset_16;

		// Token: 0x040117B9 RID: 71609
		private static IntPtr __Is_ES3_NativeFunctionPtr;

		// Token: 0x040117BA RID: 71610
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040117BB RID: 71611
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
