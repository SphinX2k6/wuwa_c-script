using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.Setting.EffectDataAsset
{
	// Token: 0x02003E6E RID: 15982
	[UnrealObjectPath("/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelBase.BP_EffectModelBase_C")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 111)]
	public class BP_EffectModelBase_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060283BB RID: 164795 RVA: 0x009A7258 File Offset: 0x009A5458
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EffectModelBase_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelBase.BP_EffectModelBase_C");
			}
			return BP_EffectModelBase_C._ClassPtr;
		}

		// Token: 0x060283BC RID: 164796 RVA: 0x009A727C File Offset: 0x009A547C
		public BP_EffectModelBase_C() : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelBase_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060283BD RID: 164797 RVA: 0x009A72A4 File Offset: 0x009A54A4
		[NullableContext(1)]
		public BP_EffectModelBase_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelBase_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005C84 RID: 23684
		// (get) Token: 0x060283BE RID: 164798 RVA: 0x009A72D7 File Offset: 0x009A54D7
		// (set) Token: 0x060283BF RID: 164799 RVA: 0x009A72E7 File Offset: 0x009A54E7
		public unsafe float StartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005C85 RID: 23685
		// (get) Token: 0x060283C0 RID: 164800 RVA: 0x009A72F8 File Offset: 0x009A54F8
		// (set) Token: 0x060283C1 RID: 164801 RVA: 0x009A7308 File Offset: 0x009A5508
		public unsafe float LoopTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005C86 RID: 23686
		// (get) Token: 0x060283C2 RID: 164802 RVA: 0x009A7319 File Offset: 0x009A5519
		// (set) Token: 0x060283C3 RID: 164803 RVA: 0x009A7329 File Offset: 0x009A5529
		public unsafe float EndTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005C87 RID: 23687
		// (get) Token: 0x060283C4 RID: 164804 RVA: 0x009A733A File Offset: 0x009A553A
		// (set) Token: 0x060283C5 RID: 164805 RVA: 0x009A734A File Offset: 0x009A554A
		public unsafe bool AutoPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C88 RID: 23688
		// (get) Token: 0x060283C6 RID: 164806 RVA: 0x009A735B File Offset: 0x009A555B
		// (set) Token: 0x060283C7 RID: 164807 RVA: 0x009A736B File Offset: 0x009A556B
		public unsafe bool AutoDestroy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C89 RID: 23689
		// (get) Token: 0x060283C8 RID: 164808 RVA: 0x009A737C File Offset: 0x009A557C
		// (set) Token: 0x060283C9 RID: 164809 RVA: 0x009A738C File Offset: 0x009A558C
		public unsafe bool IgnoreTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C8A RID: 23690
		// (get) Token: 0x060283CA RID: 164810 RVA: 0x009A739D File Offset: 0x009A559D
		// (set) Token: 0x060283CB RID: 164811 RVA: 0x009A73AD File Offset: 0x009A55AD
		public unsafe bool UiScenePrimitive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C8B RID: 23691
		// (get) Token: 0x060283CC RID: 164812 RVA: 0x009A73BE File Offset: 0x009A55BE
		// (set) Token: 0x060283CD RID: 164813 RVA: 0x009A73CE File Offset: 0x009A55CE
		public unsafe int ImportanceLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005C8C RID: 23692
		// (get) Token: 0x060283CE RID: 164814 RVA: 0x009A73DF File Offset: 0x009A55DF
		// (set) Token: 0x060283CF RID: 164815 RVA: 0x009A73EF File Offset: 0x009A55EF
		public unsafe float DefaultManualSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005C8D RID: 23693
		// (get) Token: 0x060283D0 RID: 164816 RVA: 0x009A7400 File Offset: 0x009A5600
		// (set) Token: 0x060283D1 RID: 164817 RVA: 0x009A7410 File Offset: 0x009A5610
		public unsafe float DefaultManualTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005C8E RID: 23694
		// (get) Token: 0x060283D2 RID: 164818 RVA: 0x009A7421 File Offset: 0x009A5621
		// (set) Token: 0x060283D3 RID: 164819 RVA: 0x009A7431 File Offset: 0x009A5631
		public unsafe bool DisableOnRemote
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C8F RID: 23695
		// (get) Token: 0x060283D4 RID: 164820 RVA: 0x009A7442 File Offset: 0x009A5642
		// (set) Token: 0x060283D5 RID: 164821 RVA: 0x009A7452 File Offset: 0x009A5652
		public unsafe bool DisableOnMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C90 RID: 23696
		// (get) Token: 0x060283D6 RID: 164822 RVA: 0x009A7463 File Offset: 0x009A5663
		// (set) Token: 0x060283D7 RID: 164823 RVA: 0x009A7473 File Offset: 0x009A5673
		public unsafe bool HideOnBurstSkill
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelBase_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x060283D8 RID: 164824 RVA: 0x009A7484 File Offset: 0x009A5684
		protected BP_EffectModelBase_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040147BA RID: 83898
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelBase.BP_EffectModelBase_C";

		// Token: 0x040147BB RID: 83899
		private static IntPtr _ClassPtr;

		// Token: 0x040147BC RID: 83900
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040147BD RID: 83901
		internal static int __PropertyOffset_0;

		// Token: 0x040147BE RID: 83902
		internal static int __PropertyOffset_1;

		// Token: 0x040147BF RID: 83903
		internal static int __PropertyOffset_2;

		// Token: 0x040147C0 RID: 83904
		internal static int __PropertyOffset_3;

		// Token: 0x040147C1 RID: 83905
		internal static int __PropertyOffset_4;

		// Token: 0x040147C2 RID: 83906
		internal static int __PropertyOffset_5;

		// Token: 0x040147C3 RID: 83907
		internal static int __PropertyOffset_6;

		// Token: 0x040147C4 RID: 83908
		internal static int __PropertyOffset_7;

		// Token: 0x040147C5 RID: 83909
		internal static int __PropertyOffset_8;

		// Token: 0x040147C6 RID: 83910
		internal static int __PropertyOffset_9;

		// Token: 0x040147C7 RID: 83911
		internal static int __PropertyOffset_10;

		// Token: 0x040147C8 RID: 83912
		internal static int __PropertyOffset_11;

		// Token: 0x040147C9 RID: 83913
		internal static int __PropertyOffset_12;
	}
}
