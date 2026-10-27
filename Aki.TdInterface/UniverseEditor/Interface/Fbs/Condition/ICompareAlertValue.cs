using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B83 RID: 19331
	public struct ICompareAlertValue : IFlatbufferObject
	{
		// Token: 0x17008C47 RID: 35911
		// (get) Token: 0x0601E76D RID: 124781 RVA: 0x00443DD4 File Offset: 0x00441FD4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E76E RID: 124782 RVA: 0x00443DE1 File Offset: 0x00441FE1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E76F RID: 124783 RVA: 0x00443DE8 File Offset: 0x00441FE8
		public static ICompareAlertValue GetRootAsICompareAlertValue(ByteBuffer _bb)
		{
			return ICompareAlertValue.GetRootAsICompareAlertValue(_bb, default(ICompareAlertValue));
		}

		// Token: 0x0601E770 RID: 124784 RVA: 0x00443E04 File Offset: 0x00442004
		public static ICompareAlertValue GetRootAsICompareAlertValue(ByteBuffer _bb, ICompareAlertValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E771 RID: 124785 RVA: 0x00443E21 File Offset: 0x00442021
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E772 RID: 124786 RVA: 0x00443E30 File Offset: 0x00442030
		public ICompareAlertValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C48 RID: 35912
		// (get) Token: 0x0601E773 RID: 124787 RVA: 0x00443E40 File Offset: 0x00442040
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008C49 RID: 35913
		// (get) Token: 0x0601E774 RID: 124788 RVA: 0x00443E7C File Offset: 0x0044207C
		public int AreaId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008C4A RID: 35914
		// (get) Token: 0x0601E775 RID: 124789 RVA: 0x00443EB8 File Offset: 0x004420B8
		public ECompare CompareType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008C4B RID: 35915
		// (get) Token: 0x0601E776 RID: 124790 RVA: 0x00443EF4 File Offset: 0x004420F4
		public TComparedAlertValue CompareValueType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TComparedAlertValue.NONE;
				}
				return (TComparedAlertValue)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E777 RID: 124791 RVA: 0x00443F34 File Offset: 0x00442134
		public TTable? CompareValue<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601E778 RID: 124792 RVA: 0x00443F7C File Offset: 0x0044217C
		public ICompareCustomAlertValue CompareValueAsICompareCustomAlertValue()
		{
			return this.CompareValue<ICompareCustomAlertValue>().Value;
		}

		// Token: 0x0601E779 RID: 124793 RVA: 0x00443F98 File Offset: 0x00442198
		public ICompareMaxAlertValue CompareValueAsICompareMaxAlertValue()
		{
			return this.CompareValue<ICompareMaxAlertValue>().Value;
		}

		// Token: 0x0601E77A RID: 124794 RVA: 0x00443FB4 File Offset: 0x004421B4
		public ICompareMinAlertValue CompareValueAsICompareMinAlertValue()
		{
			return this.CompareValue<ICompareMinAlertValue>().Value;
		}

		// Token: 0x0601E77B RID: 124795 RVA: 0x00443FCF File Offset: 0x004421CF
		public static Offset<ICompareAlertValue> CreateICompareAlertValue(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int AreaId = 0, ECompare CompareType = ECompare.Eq, TComparedAlertValue CompareValue_type = TComparedAlertValue.NONE, int CompareValueOffset = 0)
		{
			builder.StartTable(5);
			ICompareAlertValue.AddCompareValue(builder, CompareValueOffset);
			ICompareAlertValue.AddAreaId(builder, AreaId);
			ICompareAlertValue.AddCompareValueType(builder, CompareValue_type);
			ICompareAlertValue.AddCompareType(builder, CompareType);
			ICompareAlertValue.AddType(builder, Type);
			return ICompareAlertValue.EndICompareAlertValue(builder);
		}

		// Token: 0x0601E77C RID: 124796 RVA: 0x00444003 File Offset: 0x00442203
		public static void StartICompareAlertValue(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601E77D RID: 124797 RVA: 0x0044400C File Offset: 0x0044220C
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E77E RID: 124798 RVA: 0x00444017 File Offset: 0x00442217
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(1, areaId, 0);
		}

		// Token: 0x0601E77F RID: 124799 RVA: 0x00444022 File Offset: 0x00442222
		public static void AddCompareType(FlatBufferBuilder builder, ECompare compareType)
		{
			builder.AddByte(2, (byte)compareType, 0);
		}

		// Token: 0x0601E780 RID: 124800 RVA: 0x0044402D File Offset: 0x0044222D
		public static void AddCompareValueType(FlatBufferBuilder builder, TComparedAlertValue compareValueType)
		{
			builder.AddByte(3, (byte)compareValueType, 0);
		}

		// Token: 0x0601E781 RID: 124801 RVA: 0x00444038 File Offset: 0x00442238
		public static void AddCompareValue(FlatBufferBuilder builder, int compareValueOffset)
		{
			builder.AddOffset(4, compareValueOffset, 0);
		}

		// Token: 0x0601E782 RID: 124802 RVA: 0x00444043 File Offset: 0x00442243
		public static Offset<ICompareAlertValue> EndICompareAlertValue(FlatBufferBuilder builder)
		{
			return new Offset<ICompareAlertValue>(builder.EndTable());
		}

		// Token: 0x0601E783 RID: 124803 RVA: 0x00444050 File Offset: 0x00442250
		public ICompareAlertValueT UnPack()
		{
			ICompareAlertValueT compareAlertValueT = new ICompareAlertValueT();
			this.UnPackTo(compareAlertValueT);
			return compareAlertValueT;
		}

		// Token: 0x0601E784 RID: 124804 RVA: 0x0044406C File Offset: 0x0044226C
		public void UnPackTo(ICompareAlertValueT _o)
		{
			_o.Type = this.Type;
			_o.AreaId = this.AreaId;
			_o.CompareType = this.CompareType;
			_o.CompareValue = new TComparedAlertValueUnion();
			_o.CompareValue.Type = this.CompareValueType;
			switch (this.CompareValueType)
			{
			case TComparedAlertValue.ICompareCustomAlertValue:
				_o.CompareValue.Value = ((this.CompareValue<ICompareCustomAlertValue>() != null) ? this.CompareValue<ICompareCustomAlertValue>().Value.UnPack() : null);
				return;
			case TComparedAlertValue.ICompareMaxAlertValue:
				_o.CompareValue.Value = ((this.CompareValue<ICompareMaxAlertValue>() != null) ? this.CompareValue<ICompareMaxAlertValue>().Value.UnPack() : null);
				return;
			case TComparedAlertValue.ICompareMinAlertValue:
				_o.CompareValue.Value = ((this.CompareValue<ICompareMinAlertValue>() != null) ? this.CompareValue<ICompareMinAlertValue>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0601E785 RID: 124805 RVA: 0x00444178 File Offset: 0x00442378
		public static Offset<ICompareAlertValue> Pack(FlatBufferBuilder builder, ICompareAlertValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareAlertValue>);
			}
			TComparedAlertValue compareValue_type = (_o.CompareValue == null) ? TComparedAlertValue.NONE : _o.CompareValue.Type;
			int compareValueOffset = (_o.CompareValue == null) ? 0 : TComparedAlertValueUnion.Pack(builder, _o.CompareValue);
			return ICompareAlertValue.CreateICompareAlertValue(builder, _o.Type, _o.AreaId, _o.CompareType, compareValue_type, compareValueOffset);
		}

		// Token: 0x0400D453 RID: 54355
		private Table __p;
	}
}
