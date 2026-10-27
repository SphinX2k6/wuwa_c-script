using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Billboard;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.Setting.EffectDataAsset
{
	// Token: 0x02003E6F RID: 15983
	[UnrealObjectPath("/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelBillboard.BP_EffectModelBillboard_C")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 132)]
	public class BP_EffectModelBillboard_C : BP_EffectModelBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060283D9 RID: 164825 RVA: 0x009A748D File Offset: 0x009A568D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EffectModelBillboard_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelBillboard.BP_EffectModelBillboard_C");
			}
			return BP_EffectModelBillboard_C._ClassPtr;
		}

		// Token: 0x060283DA RID: 164826 RVA: 0x009A74B4 File Offset: 0x009A56B4
		public BP_EffectModelBillboard_C() : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelBillboard_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060283DB RID: 164827 RVA: 0x009A74DC File Offset: 0x009A56DC
		[NullableContext(1)]
		public BP_EffectModelBillboard_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelBillboard_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005C91 RID: 23697
		// (get) Token: 0x060283DC RID: 164828 RVA: 0x009A750F File Offset: 0x009A570F
		// (set) Token: 0x060283DD RID: 164829 RVA: 0x009A751F File Offset: 0x009A571F
		public unsafe bool IsUpdateEveryFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelBillboard_C.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelBillboard_C.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C92 RID: 23698
		// (get) Token: 0x060283DE RID: 164830 RVA: 0x009A7530 File Offset: 0x009A5730
		// (set) Token: 0x060283DF RID: 164831 RVA: 0x009A7540 File Offset: 0x009A5740
		public unsafe bool IsFixSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelBillboard_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelBillboard_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C93 RID: 23699
		// (get) Token: 0x060283E0 RID: 164832 RVA: 0x009A7551 File Offset: 0x009A5751
		// (set) Token: 0x060283E1 RID: 164833 RVA: 0x009A7561 File Offset: 0x009A5761
		public unsafe float ScaleSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelBillboard_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelBillboard_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005C94 RID: 23700
		// (get) Token: 0x060283E2 RID: 164834 RVA: 0x009A7572 File Offset: 0x009A5772
		// (set) Token: 0x060283E3 RID: 164835 RVA: 0x009A7582 File Offset: 0x009A5782
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelBillboard_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelBillboard_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005C95 RID: 23701
		// (get) Token: 0x060283E4 RID: 164836 RVA: 0x009A7593 File Offset: 0x009A5793
		// (set) Token: 0x060283E5 RID: 164837 RVA: 0x009A75A7 File Offset: 0x009A57A7
		public unsafe TEnumAsByte<E_BillboardMode> OrientAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelBillboard_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelBillboard_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005C96 RID: 23702
		// (get) Token: 0x060283E6 RID: 164838 RVA: 0x009A75BC File Offset: 0x009A57BC
		// (set) Token: 0x060283E7 RID: 164839 RVA: 0x009A75CC File Offset: 0x009A57CC
		public unsafe float MinSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelBillboard_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelBillboard_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x060283E8 RID: 164840 RVA: 0x009A75DD File Offset: 0x009A57DD
		protected BP_EffectModelBillboard_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040147CA RID: 83914
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelBillboard.BP_EffectModelBillboard_C";

		// Token: 0x040147CB RID: 83915
		private static IntPtr _ClassPtr;

		// Token: 0x040147CC RID: 83916
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040147CD RID: 83917
		internal new static int __PropertyOffset_0;

		// Token: 0x040147CE RID: 83918
		internal new static int __PropertyOffset_1;

		// Token: 0x040147CF RID: 83919
		internal new static int __PropertyOffset_2;

		// Token: 0x040147D0 RID: 83920
		internal new static int __PropertyOffset_3;

		// Token: 0x040147D1 RID: 83921
		internal new static int __PropertyOffset_4;

		// Token: 0x040147D2 RID: 83922
		internal new static int __PropertyOffset_5;
	}
}
