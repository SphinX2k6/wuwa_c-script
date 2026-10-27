using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.Setting.EffectDataAsset
{
	// Token: 0x02003E72 RID: 15986
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelGroup.BP_EffectModelGroup_C")]
	[UnrealStructLayout(1464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1464)]
	public class BP_EffectModelGroup_C : BP_EffectModelBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028401 RID: 164865 RVA: 0x009A791A File Offset: 0x009A5B1A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EffectModelGroup_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelGroup.BP_EffectModelGroup_C");
			}
			return BP_EffectModelGroup_C._ClassPtr;
		}

		// Token: 0x06028402 RID: 164866 RVA: 0x009A7940 File Offset: 0x009A5B40
		public BP_EffectModelGroup_C() : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelGroup_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028403 RID: 164867 RVA: 0x009A7968 File Offset: 0x009A5B68
		public BP_EffectModelGroup_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelGroup_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005C9F RID: 23711
		// (get) Token: 0x06028404 RID: 164868 RVA: 0x009A799C File Offset: 0x009A5B9C
		// (set) Token: 0x06028405 RID: 164869 RVA: 0x009A79D5 File Offset: 0x009A5BD5
		public TMap<UEffectModelBase, float> EffectData
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UEffectModelBase, float> result;
				if ((result = this._EffectData) == null)
				{
					result = (this._EffectData = new TMap<UEffectModelBase, float>(base.NativePtr + (IntPtr)BP_EffectModelGroup_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.EffectData.CopyAssign(value);
			}
		}

		// Token: 0x17005CA0 RID: 23712
		// (get) Token: 0x06028406 RID: 164870 RVA: 0x009A79E4 File Offset: 0x009A5BE4
		// (set) Token: 0x06028407 RID: 164871 RVA: 0x009A7A1D File Offset: 0x009A5C1D
		public FKuroCurveVector Location
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Location) == null)
				{
					result = (this._Location = new FKuroCurveVector(base.NativePtr + (IntPtr)BP_EffectModelGroup_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelGroup_C.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CA1 RID: 23713
		// (get) Token: 0x06028408 RID: 164872 RVA: 0x009A7A40 File Offset: 0x009A5C40
		// (set) Token: 0x06028409 RID: 164873 RVA: 0x009A7A79 File Offset: 0x009A5C79
		public FKuroCurveVector Rotation
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new FKuroCurveVector(base.NativePtr + (IntPtr)BP_EffectModelGroup_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelGroup_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CA2 RID: 23714
		// (get) Token: 0x0602840A RID: 164874 RVA: 0x009A7A9C File Offset: 0x009A5C9C
		// (set) Token: 0x0602840B RID: 164875 RVA: 0x009A7AD5 File Offset: 0x009A5CD5
		public FKuroCurveVector Scale
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Scale) == null)
				{
					result = (this._Scale = new FKuroCurveVector(base.NativePtr + (IntPtr)BP_EffectModelGroup_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelGroup_C.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602840C RID: 164876 RVA: 0x009A7AF6 File Offset: 0x009A5CF6
		protected BP_EffectModelGroup_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040147E6 RID: 83942
		public new const string __ObjectPath = "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelGroup.BP_EffectModelGroup_C";

		// Token: 0x040147E7 RID: 83943
		private static IntPtr _ClassPtr;

		// Token: 0x040147E8 RID: 83944
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040147E9 RID: 83945
		internal new static int __PropertyOffset_0;

		// Token: 0x040147EA RID: 83946
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UEffectModelBase, float> _EffectData;

		// Token: 0x040147EB RID: 83947
		internal new static int __PropertyOffset_1;

		// Token: 0x040147EC RID: 83948
		[Nullable(2)]
		private FKuroCurveVector _Location;

		// Token: 0x040147ED RID: 83949
		internal new static int __PropertyOffset_2;

		// Token: 0x040147EE RID: 83950
		[Nullable(2)]
		private FKuroCurveVector _Rotation;

		// Token: 0x040147EF RID: 83951
		internal new static int __PropertyOffset_3;

		// Token: 0x040147F0 RID: 83952
		[Nullable(2)]
		private FKuroCurveVector _Scale;
	}
}
