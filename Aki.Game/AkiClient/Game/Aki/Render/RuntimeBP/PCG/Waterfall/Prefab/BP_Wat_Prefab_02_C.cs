using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.Waterfall.Prefab
{
	// Token: 0x02003BDF RID: 15327
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/Waterfall/Prefab/BP_Wat_Prefab_02.BP_Wat_Prefab_02_C")]
	[UnrealStructLayout(1096, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1092)]
	public class BP_Wat_Prefab_02_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022956 RID: 141654 RVA: 0x0090CADD File Offset: 0x0090ACDD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Wat_Prefab_02_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/Waterfall/Prefab/BP_Wat_Prefab_02.BP_Wat_Prefab_02_C");
			}
			return BP_Wat_Prefab_02_C._ClassPtr;
		}

		// Token: 0x06022957 RID: 141655 RVA: 0x0090CB04 File Offset: 0x0090AD04
		public BP_Wat_Prefab_02_C() : this(BuiltinUtils.AllocNativeUObject(BP_Wat_Prefab_02_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022958 RID: 141656 RVA: 0x0090CB2C File Offset: 0x0090AD2C
		[NullableContext(1)]
		public BP_Wat_Prefab_02_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Wat_Prefab_02_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003C89 RID: 15497
		// (get) Token: 0x06022959 RID: 141657 RVA: 0x0090CB5F File Offset: 0x0090AD5F
		// (set) Token: 0x0602295A RID: 141658 RVA: 0x0090CB73 File Offset: 0x0090AD73
		public unsafe UArrowComponent Arrow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UArrowComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wat_Prefab_02_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wat_Prefab_02_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17003C8A RID: 15498
		// (get) Token: 0x0602295B RID: 141659 RVA: 0x0090CB88 File Offset: 0x0090AD88
		// (set) Token: 0x0602295C RID: 141660 RVA: 0x0090CB9C File Offset: 0x0090AD9C
		public unsafe UBillboardComponent Billboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wat_Prefab_02_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wat_Prefab_02_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003C8B RID: 15499
		// (get) Token: 0x0602295D RID: 141661 RVA: 0x0090CBB1 File Offset: 0x0090ADB1
		// (set) Token: 0x0602295E RID: 141662 RVA: 0x0090CBC5 File Offset: 0x0090ADC5
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wat_Prefab_02_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wat_Prefab_02_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003C8C RID: 15500
		// (get) Token: 0x0602295F RID: 141663 RVA: 0x0090CBDA File Offset: 0x0090ADDA
		// (set) Token: 0x06022960 RID: 141664 RVA: 0x0090CBEE File Offset: 0x0090ADEE
		public unsafe UStaticMeshComponent SM_Wat_Seq_01
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wat_Prefab_02_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wat_Prefab_02_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003C8D RID: 15501
		// (get) Token: 0x06022961 RID: 141665 RVA: 0x0090CC03 File Offset: 0x0090AE03
		// (set) Token: 0x06022962 RID: 141666 RVA: 0x0090CC17 File Offset: 0x0090AE17
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wat_Prefab_02_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wat_Prefab_02_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003C8E RID: 15502
		// (get) Token: 0x06022963 RID: 141667 RVA: 0x0090CC2C File Offset: 0x0090AE2C
		// (set) Token: 0x06022964 RID: 141668 RVA: 0x0090CC3C File Offset: 0x0090AE3C
		public unsafe float 粒子数量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Wat_Prefab_02_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Wat_Prefab_02_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003C8F RID: 15503
		// (get) Token: 0x06022965 RID: 141669 RVA: 0x0090CC4D File Offset: 0x0090AE4D
		// (set) Token: 0x06022966 RID: 141670 RVA: 0x0090CC5D File Offset: 0x0090AE5D
		public unsafe float 粒子范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Wat_Prefab_02_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Wat_Prefab_02_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003C90 RID: 15504
		// (get) Token: 0x06022967 RID: 141671 RVA: 0x0090CC6E File Offset: 0x0090AE6E
		// (set) Token: 0x06022968 RID: 141672 RVA: 0x0090CC7E File Offset: 0x0090AE7E
		public unsafe float 粒子寿命
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Wat_Prefab_02_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Wat_Prefab_02_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x06022969 RID: 141673 RVA: 0x0090CC8F File Offset: 0x0090AE8F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Wat_Prefab_02_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602296A RID: 141674 RVA: 0x0090CCA3 File Offset: 0x0090AEA3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Wat_Prefab_02_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602296B RID: 141675 RVA: 0x0090CCB8 File Offset: 0x0090AEB8
		protected BP_Wat_Prefab_02_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010FC4 RID: 69572
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/Waterfall/Prefab/BP_Wat_Prefab_02.BP_Wat_Prefab_02_C";

		// Token: 0x04010FC5 RID: 69573
		private static IntPtr _ClassPtr;

		// Token: 0x04010FC6 RID: 69574
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010FC7 RID: 69575
		internal static int __PropertyOffset_0;

		// Token: 0x04010FC8 RID: 69576
		internal static int __PropertyOffset_1;

		// Token: 0x04010FC9 RID: 69577
		internal static int __PropertyOffset_2;

		// Token: 0x04010FCA RID: 69578
		internal static int __PropertyOffset_3;

		// Token: 0x04010FCB RID: 69579
		internal static int __PropertyOffset_4;

		// Token: 0x04010FCC RID: 69580
		internal static int __PropertyOffset_5;

		// Token: 0x04010FCD RID: 69581
		internal static int __PropertyOffset_6;

		// Token: 0x04010FCE RID: 69582
		internal static int __PropertyOffset_7;

		// Token: 0x04010FCF RID: 69583
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;
	}
}
