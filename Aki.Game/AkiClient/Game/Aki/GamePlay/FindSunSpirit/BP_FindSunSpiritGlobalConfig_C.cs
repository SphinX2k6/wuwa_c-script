using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.FindSunSpirit
{
	// Token: 0x02003E65 RID: 15973
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/GamePlay/FindSunSpirit/BP_FindSunSpiritGlobalConfig.BP_FindSunSpiritGlobalConfig_C")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 488)]
	public class BP_FindSunSpiritGlobalConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060282A3 RID: 164515 RVA: 0x009A5AD8 File Offset: 0x009A3CD8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FindSunSpiritGlobalConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/GamePlay/FindSunSpirit/BP_FindSunSpiritGlobalConfig.BP_FindSunSpiritGlobalConfig_C");
			}
			return BP_FindSunSpiritGlobalConfig_C._ClassPtr;
		}

		// Token: 0x060282A4 RID: 164516 RVA: 0x009A5AFC File Offset: 0x009A3CFC
		public BP_FindSunSpiritGlobalConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_FindSunSpiritGlobalConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060282A5 RID: 164517 RVA: 0x009A5B24 File Offset: 0x009A3D24
		public BP_FindSunSpiritGlobalConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FindSunSpiritGlobalConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005C0C RID: 23564
		// (get) Token: 0x060282A6 RID: 164518 RVA: 0x009A5B57 File Offset: 0x009A3D57
		// (set) Token: 0x060282A7 RID: 164519 RVA: 0x009A5B6B File Offset: 0x009A3D6B
		[Nullable(2)]
		public unsafe UAnimMontage 跳跃蒙太奇
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005C0D RID: 23565
		// (get) Token: 0x060282A8 RID: 164520 RVA: 0x009A5B80 File Offset: 0x009A3D80
		// (set) Token: 0x060282A9 RID: 164521 RVA: 0x009A5B90 File Offset: 0x009A3D90
		public unsafe int 跳跃旋转速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005C0E RID: 23566
		// (get) Token: 0x060282AA RID: 164522 RVA: 0x009A5BA1 File Offset: 0x009A3DA1
		// (set) Token: 0x060282AB RID: 164523 RVA: 0x009A5BB1 File Offset: 0x009A3DB1
		public unsafe int 跳跃高度偏移基准
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005C0F RID: 23567
		// (get) Token: 0x060282AC RID: 164524 RVA: 0x009A5BC2 File Offset: 0x009A3DC2
		// (set) Token: 0x060282AD RID: 164525 RVA: 0x009A5BD2 File Offset: 0x009A3DD2
		public unsafe int 跳跃时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005C10 RID: 23568
		// (get) Token: 0x060282AE RID: 164526 RVA: 0x009A5BE3 File Offset: 0x009A3DE3
		// (set) Token: 0x060282AF RID: 164527 RVA: 0x009A5BF3 File Offset: 0x009A3DF3
		public unsafe int 跳跃上升偏移曲线高度范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005C11 RID: 23569
		// (get) Token: 0x060282B0 RID: 164528 RVA: 0x009A5C04 File Offset: 0x009A3E04
		// (set) Token: 0x060282B1 RID: 164529 RVA: 0x009A5C14 File Offset: 0x009A3E14
		public unsafe int 跳跃下降偏移曲线高度范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005C12 RID: 23570
		// (get) Token: 0x060282B2 RID: 164530 RVA: 0x009A5C25 File Offset: 0x009A3E25
		// (set) Token: 0x060282B3 RID: 164531 RVA: 0x009A5C39 File Offset: 0x009A3E39
		[Nullable(2)]
		public unsafe UCurveFloat 跳跃上升偏移曲线
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_6);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17005C13 RID: 23571
		// (get) Token: 0x060282B4 RID: 164532 RVA: 0x009A5C4E File Offset: 0x009A3E4E
		// (set) Token: 0x060282B5 RID: 164533 RVA: 0x009A5C62 File Offset: 0x009A3E62
		[Nullable(2)]
		public unsafe UCurveFloat 跳跃下降偏移曲线
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_7);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17005C14 RID: 23572
		// (get) Token: 0x060282B6 RID: 164534 RVA: 0x009A5C77 File Offset: 0x009A3E77
		// (set) Token: 0x060282B7 RID: 164535 RVA: 0x009A5C8B File Offset: 0x009A3E8B
		[Nullable(2)]
		public unsafe UAnimMontage 奔跑蒙太奇
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_8);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17005C15 RID: 23573
		// (get) Token: 0x060282B8 RID: 164536 RVA: 0x009A5CA0 File Offset: 0x009A3EA0
		// (set) Token: 0x060282B9 RID: 164537 RVA: 0x009A5CB0 File Offset: 0x009A3EB0
		public unsafe int 奔跑移动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005C16 RID: 23574
		// (get) Token: 0x060282BA RID: 164538 RVA: 0x009A5CC1 File Offset: 0x009A3EC1
		// (set) Token: 0x060282BB RID: 164539 RVA: 0x009A5CD1 File Offset: 0x009A3ED1
		public unsafe int 奔跑旋转速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005C17 RID: 23575
		// (get) Token: 0x060282BC RID: 164540 RVA: 0x009A5CE2 File Offset: 0x009A3EE2
		// (set) Token: 0x060282BD RID: 164541 RVA: 0x009A5CF2 File Offset: 0x009A3EF2
		public unsafe int 奔跑结束停顿时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005C18 RID: 23576
		// (get) Token: 0x060282BE RID: 164542 RVA: 0x009A5D03 File Offset: 0x009A3F03
		// (set) Token: 0x060282BF RID: 164543 RVA: 0x009A5D13 File Offset: 0x009A3F13
		public unsafe int 导航线持续时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17005C19 RID: 23577
		// (get) Token: 0x060282C0 RID: 164544 RVA: 0x009A5D24 File Offset: 0x009A3F24
		// (set) Token: 0x060282C1 RID: 164545 RVA: 0x009A5D39 File Offset: 0x009A3F39
		public TSoftObjectPtr<UEffectModelGroup> 成功导航线特效
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_13, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_13, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005C1A RID: 23578
		// (get) Token: 0x060282C2 RID: 164546 RVA: 0x009A5D5E File Offset: 0x009A3F5E
		// (set) Token: 0x060282C3 RID: 164547 RVA: 0x009A5D73 File Offset: 0x009A3F73
		public TSoftObjectPtr<UEffectModelGroup> 失败导航线特效
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_14, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_14, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005C1B RID: 23579
		// (get) Token: 0x060282C4 RID: 164548 RVA: 0x009A5D98 File Offset: 0x009A3F98
		// (set) Token: 0x060282C5 RID: 164549 RVA: 0x009A5DD1 File Offset: 0x009A3FD1
		public FSoftObjectPath 扩散装置路径
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._扩散装置路径) == null)
				{
					result = (this._扩散装置路径 = new FSoftObjectPath(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_15, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_15, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005C1C RID: 23580
		// (get) Token: 0x060282C6 RID: 164550 RVA: 0x009A5DF2 File Offset: 0x009A3FF2
		// (set) Token: 0x060282C7 RID: 164551 RVA: 0x009A5E02 File Offset: 0x009A4002
		public unsafe int 扩散触发持续时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005C1D RID: 23581
		// (get) Token: 0x060282C8 RID: 164552 RVA: 0x009A5E14 File Offset: 0x009A4014
		// (set) Token: 0x060282C9 RID: 164553 RVA: 0x009A5E4D File Offset: 0x009A404D
		public TArray<FIntPoint> 扩散影响范围
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FIntPoint> result;
				if ((result = this._扩散影响范围) == null)
				{
					result = (this._扩散影响范围 = new TArray<FIntPoint>(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_17, this));
				}
				return result;
			}
			set
			{
				this.扩散影响范围.CopyAssign(value);
			}
		}

		// Token: 0x17005C1E RID: 23582
		// (get) Token: 0x060282CA RID: 164554 RVA: 0x009A5E5B File Offset: 0x009A405B
		// (set) Token: 0x060282CB RID: 164555 RVA: 0x009A5E70 File Offset: 0x009A4070
		public TSoftObjectPtr<UNiagaraSystem> 关卡地板Niagara
		{
			get
			{
				return new TSoftObjectPtr<UNiagaraSystem>(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_18, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_18, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005C1F RID: 23583
		// (get) Token: 0x060282CC RID: 164556 RVA: 0x009A5E95 File Offset: 0x009A4095
		// (set) Token: 0x060282CD RID: 164557 RVA: 0x009A5EA5 File Offset: 0x009A40A5
		public unsafe int 关卡地板单位大小
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17005C20 RID: 23584
		// (get) Token: 0x060282CE RID: 164558 RVA: 0x009A5EB6 File Offset: 0x009A40B6
		// (set) Token: 0x060282CF RID: 164559 RVA: 0x009A5ECA File Offset: 0x009A40CA
		[Nullable(2)]
		public unsafe UAnimMontage 寻路失败蒙太奇
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_20);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17005C21 RID: 23585
		// (get) Token: 0x060282D0 RID: 164560 RVA: 0x009A5EDF File Offset: 0x009A40DF
		// (set) Token: 0x060282D1 RID: 164561 RVA: 0x009A5EF3 File Offset: 0x009A40F3
		[Nullable(2)]
		public unsafe UAnimMontage 到达终点蒙太奇
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_21);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17005C22 RID: 23586
		// (get) Token: 0x060282D2 RID: 164562 RVA: 0x009A5F08 File Offset: 0x009A4108
		// (set) Token: 0x060282D3 RID: 164563 RVA: 0x009A5F1C File Offset: 0x009A411C
		[Nullable(2)]
		public unsafe UAnimMontage 终点待机蒙太奇
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_22);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17005C23 RID: 23587
		// (get) Token: 0x060282D4 RID: 164564 RVA: 0x009A5F31 File Offset: 0x009A4131
		// (set) Token: 0x060282D5 RID: 164565 RVA: 0x009A5F46 File Offset: 0x009A4146
		public TSoftObjectPtr<UEffectModelGroup> 射击轨迹特效
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_23, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_23, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005C24 RID: 23588
		// (get) Token: 0x060282D6 RID: 164566 RVA: 0x009A5F6B File Offset: 0x009A416B
		// (set) Token: 0x060282D7 RID: 164567 RVA: 0x009A5F80 File Offset: 0x009A4180
		public TSoftObjectPtr<UEffectModelGroup> 射击终点特效
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_24, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_24, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005C25 RID: 23589
		// (get) Token: 0x060282D8 RID: 164568 RVA: 0x009A5FA5 File Offset: 0x009A41A5
		// (set) Token: 0x060282D9 RID: 164569 RVA: 0x009A5FB5 File Offset: 0x009A41B5
		public unsafe int 射击冷却时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17005C26 RID: 23590
		// (get) Token: 0x060282DA RID: 164570 RVA: 0x009A5FC6 File Offset: 0x009A41C6
		// (set) Token: 0x060282DB RID: 164571 RVA: 0x009A5FD6 File Offset: 0x009A41D6
		public unsafe int 失败重置延迟时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x060282DC RID: 164572 RVA: 0x009A5FE7 File Offset: 0x009A41E7
		protected BP_FindSunSpiritGlobalConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401471C RID: 83740
		public new const string __ObjectPath = "/Game/Aki/GamePlay/FindSunSpirit/BP_FindSunSpiritGlobalConfig.BP_FindSunSpiritGlobalConfig_C";

		// Token: 0x0401471D RID: 83741
		private static IntPtr _ClassPtr;

		// Token: 0x0401471E RID: 83742
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401471F RID: 83743
		internal static int __PropertyOffset_0;

		// Token: 0x04014720 RID: 83744
		internal static int __PropertyOffset_1;

		// Token: 0x04014721 RID: 83745
		internal static int __PropertyOffset_2;

		// Token: 0x04014722 RID: 83746
		internal static int __PropertyOffset_3;

		// Token: 0x04014723 RID: 83747
		internal static int __PropertyOffset_4;

		// Token: 0x04014724 RID: 83748
		internal static int __PropertyOffset_5;

		// Token: 0x04014725 RID: 83749
		internal static int __PropertyOffset_6;

		// Token: 0x04014726 RID: 83750
		internal static int __PropertyOffset_7;

		// Token: 0x04014727 RID: 83751
		internal static int __PropertyOffset_8;

		// Token: 0x04014728 RID: 83752
		internal static int __PropertyOffset_9;

		// Token: 0x04014729 RID: 83753
		internal static int __PropertyOffset_10;

		// Token: 0x0401472A RID: 83754
		internal static int __PropertyOffset_11;

		// Token: 0x0401472B RID: 83755
		internal static int __PropertyOffset_12;

		// Token: 0x0401472C RID: 83756
		internal static int __PropertyOffset_13;

		// Token: 0x0401472D RID: 83757
		internal static int __PropertyOffset_14;

		// Token: 0x0401472E RID: 83758
		internal static int __PropertyOffset_15;

		// Token: 0x0401472F RID: 83759
		[Nullable(2)]
		private FSoftObjectPath _扩散装置路径;

		// Token: 0x04014730 RID: 83760
		internal static int __PropertyOffset_16;

		// Token: 0x04014731 RID: 83761
		internal static int __PropertyOffset_17;

		// Token: 0x04014732 RID: 83762
		[Nullable(2)]
		private TArray<FIntPoint> _扩散影响范围;

		// Token: 0x04014733 RID: 83763
		internal static int __PropertyOffset_18;

		// Token: 0x04014734 RID: 83764
		internal static int __PropertyOffset_19;

		// Token: 0x04014735 RID: 83765
		internal static int __PropertyOffset_20;

		// Token: 0x04014736 RID: 83766
		internal static int __PropertyOffset_21;

		// Token: 0x04014737 RID: 83767
		internal static int __PropertyOffset_22;

		// Token: 0x04014738 RID: 83768
		internal static int __PropertyOffset_23;

		// Token: 0x04014739 RID: 83769
		internal static int __PropertyOffset_24;

		// Token: 0x0401473A RID: 83770
		internal static int __PropertyOffset_25;

		// Token: 0x0401473B RID: 83771
		internal static int __PropertyOffset_26;
	}
}
