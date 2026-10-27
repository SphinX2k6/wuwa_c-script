using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.Setting.EffectDataAsset
{
	// Token: 0x02003E75 RID: 15989
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelNiagara.BP_EffectModelNiagara_C")]
	[UnrealStructLayout(1648, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1641)]
	public class BP_EffectModelNiagara_C : BP_EffectModelBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028455 RID: 164949 RVA: 0x009A81B9 File Offset: 0x009A63B9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EffectModelNiagara_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelNiagara.BP_EffectModelNiagara_C");
			}
			return BP_EffectModelNiagara_C._ClassPtr;
		}

		// Token: 0x06028456 RID: 164950 RVA: 0x009A81E0 File Offset: 0x009A63E0
		public BP_EffectModelNiagara_C() : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelNiagara_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028457 RID: 164951 RVA: 0x009A8208 File Offset: 0x009A6408
		public BP_EffectModelNiagara_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelNiagara_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005CC3 RID: 23747
		// (get) Token: 0x06028458 RID: 164952 RVA: 0x009A823C File Offset: 0x009A643C
		// (set) Token: 0x06028459 RID: 164953 RVA: 0x009A8275 File Offset: 0x009A6475
		public FKuroCurveVector Location
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Location) == null)
				{
					result = (this._Location = new FKuroCurveVector(base.NativePtr + (IntPtr)BP_EffectModelNiagara_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelNiagara_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CC4 RID: 23748
		// (get) Token: 0x0602845A RID: 164954 RVA: 0x009A8298 File Offset: 0x009A6498
		// (set) Token: 0x0602845B RID: 164955 RVA: 0x009A82D1 File Offset: 0x009A64D1
		public FKuroCurveVector Rotation
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new FKuroCurveVector(base.NativePtr + (IntPtr)BP_EffectModelNiagara_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelNiagara_C.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CC5 RID: 23749
		// (get) Token: 0x0602845C RID: 164956 RVA: 0x009A82F4 File Offset: 0x009A64F4
		// (set) Token: 0x0602845D RID: 164957 RVA: 0x009A832D File Offset: 0x009A652D
		public FKuroCurveVector Scale
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Scale) == null)
				{
					result = (this._Scale = new FKuroCurveVector(base.NativePtr + (IntPtr)BP_EffectModelNiagara_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelNiagara_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CC6 RID: 23750
		// (get) Token: 0x0602845E RID: 164958 RVA: 0x009A8350 File Offset: 0x009A6550
		// (set) Token: 0x0602845F RID: 164959 RVA: 0x009A8389 File Offset: 0x009A6589
		public TMap<FName, FKuroCurveFloat> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveFloat> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TMap<FName, FKuroCurveFloat>(base.NativePtr + (IntPtr)BP_EffectModelNiagara_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005CC7 RID: 23751
		// (get) Token: 0x06028460 RID: 164960 RVA: 0x009A8398 File Offset: 0x009A6598
		// (set) Token: 0x06028461 RID: 164961 RVA: 0x009A83D1 File Offset: 0x009A65D1
		public TMap<FName, FKuroCurveLinearColor> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveLinearColor> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TMap<FName, FKuroCurveLinearColor>(base.NativePtr + (IntPtr)BP_EffectModelNiagara_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005CC8 RID: 23752
		// (get) Token: 0x06028462 RID: 164962 RVA: 0x009A83E0 File Offset: 0x009A65E0
		// (set) Token: 0x06028463 RID: 164963 RVA: 0x009A8419 File Offset: 0x009A6619
		public TMap<FName, FKuroCurveVector> VectorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveVector> result;
				if ((result = this._VectorParameters) == null)
				{
					result = (this._VectorParameters = new TMap<FName, FKuroCurveVector>(base.NativePtr + (IntPtr)BP_EffectModelNiagara_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				this.VectorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005CC9 RID: 23753
		// (get) Token: 0x06028464 RID: 164964 RVA: 0x009A8427 File Offset: 0x009A6627
		// (set) Token: 0x06028465 RID: 164965 RVA: 0x009A8437 File Offset: 0x009A6637
		public unsafe bool ReceiveDecal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelNiagara_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelNiagara_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005CCA RID: 23754
		// (get) Token: 0x06028466 RID: 164966 RVA: 0x009A8448 File Offset: 0x009A6648
		// (set) Token: 0x06028467 RID: 164967 RVA: 0x009A8458 File Offset: 0x009A6658
		public unsafe int TranslucencySortPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelNiagara_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelNiagara_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005CCB RID: 23755
		// (get) Token: 0x06028468 RID: 164968 RVA: 0x009A8469 File Offset: 0x009A6669
		// (set) Token: 0x06028469 RID: 164969 RVA: 0x009A847D File Offset: 0x009A667D
		[Nullable(2)]
		public unsafe UNiagaraSystem NiagaraRef
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelNiagara_C.__PropertyOffset_8);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelNiagara_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17005CCC RID: 23756
		// (get) Token: 0x0602846A RID: 164970 RVA: 0x009A8492 File Offset: 0x009A6692
		// (set) Token: 0x0602846B RID: 164971 RVA: 0x009A84A2 File Offset: 0x009A66A2
		public unsafe bool DeactivateOnStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelNiagara_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelNiagara_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602846C RID: 164972 RVA: 0x009A84B3 File Offset: 0x009A66B3
		protected BP_EffectModelNiagara_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401481D RID: 83997
		public new const string __ObjectPath = "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelNiagara.BP_EffectModelNiagara_C";

		// Token: 0x0401481E RID: 83998
		private static IntPtr _ClassPtr;

		// Token: 0x0401481F RID: 83999
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014820 RID: 84000
		internal new static int __PropertyOffset_0;

		// Token: 0x04014821 RID: 84001
		[Nullable(2)]
		private FKuroCurveVector _Location;

		// Token: 0x04014822 RID: 84002
		internal new static int __PropertyOffset_1;

		// Token: 0x04014823 RID: 84003
		[Nullable(2)]
		private FKuroCurveVector _Rotation;

		// Token: 0x04014824 RID: 84004
		internal new static int __PropertyOffset_2;

		// Token: 0x04014825 RID: 84005
		[Nullable(2)]
		private FKuroCurveVector _Scale;

		// Token: 0x04014826 RID: 84006
		internal new static int __PropertyOffset_3;

		// Token: 0x04014827 RID: 84007
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _FloatParameters;

		// Token: 0x04014828 RID: 84008
		internal new static int __PropertyOffset_4;

		// Token: 0x04014829 RID: 84009
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _ColorParameters;

		// Token: 0x0401482A RID: 84010
		internal new static int __PropertyOffset_5;

		// Token: 0x0401482B RID: 84011
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveVector> _VectorParameters;

		// Token: 0x0401482C RID: 84012
		internal new static int __PropertyOffset_6;

		// Token: 0x0401482D RID: 84013
		internal new static int __PropertyOffset_7;

		// Token: 0x0401482E RID: 84014
		internal new static int __PropertyOffset_8;

		// Token: 0x0401482F RID: 84015
		internal new static int __PropertyOffset_9;
	}
}
