using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C4D RID: 27725
	public struct IDisableInRangeMotorRadioOperation : IFlatbufferObject
	{
		// Token: 0x1700CB3A RID: 52026
		// (get) Token: 0x0602FB98 RID: 195480 RVA: 0x0067FD6A File Offset: 0x0067DF6A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FB99 RID: 195481 RVA: 0x0067FD77 File Offset: 0x0067DF77
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FB9A RID: 195482 RVA: 0x0067FD80 File Offset: 0x0067DF80
		public static IDisableInRangeMotorRadioOperation GetRootAsIDisableInRangeMotorRadioOperation(ByteBuffer _bb)
		{
			return IDisableInRangeMotorRadioOperation.GetRootAsIDisableInRangeMotorRadioOperation(_bb, default(IDisableInRangeMotorRadioOperation));
		}

		// Token: 0x0602FB9B RID: 195483 RVA: 0x0067FD9C File Offset: 0x0067DF9C
		public static IDisableInRangeMotorRadioOperation GetRootAsIDisableInRangeMotorRadioOperation(ByteBuffer _bb, IDisableInRangeMotorRadioOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FB9C RID: 195484 RVA: 0x0067FDB9 File Offset: 0x0067DFB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FB9D RID: 195485 RVA: 0x0067FDC8 File Offset: 0x0067DFC8
		public IDisableInRangeMotorRadioOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB3B RID: 52027
		// (get) Token: 0x0602FB9E RID: 195486 RVA: 0x0067FDD8 File Offset: 0x0067DFD8
		public EMotorRadioOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorRadioOperationType.EnableAll;
				}
				return (EMotorRadioOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CB3C RID: 52028
		// (get) Token: 0x0602FB9F RID: 195487 RVA: 0x0067FE14 File Offset: 0x0067E014
		public string RangeKey
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FBA0 RID: 195488 RVA: 0x0067FE4B File Offset: 0x0067E04B
		public Span<byte> GetRangeKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602FBA1 RID: 195489 RVA: 0x0067FE5A File Offset: 0x0067E05A
		public byte[] GetRangeKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700CB3D RID: 52029
		// (get) Token: 0x0602FBA2 RID: 195490 RVA: 0x0067FE68 File Offset: 0x0067E068
		public TMotorRadioDisableRange DisableRangeTypeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TMotorRadioDisableRange.NONE;
				}
				return (TMotorRadioDisableRange)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FBA3 RID: 195491 RVA: 0x0067FEA4 File Offset: 0x0067E0A4
		public TTable? DisableRangeType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602FBA4 RID: 195492 RVA: 0x0067FEEC File Offset: 0x0067E0EC
		public IMotorRadioDisableByAbsoluteRange DisableRangeTypeAsIMotorRadioDisableByAbsoluteRange()
		{
			return this.DisableRangeType<IMotorRadioDisableByAbsoluteRange>().Value;
		}

		// Token: 0x0602FBA5 RID: 195493 RVA: 0x0067FF08 File Offset: 0x0067E108
		public IMotorRadioDisableByAreaId DisableRangeTypeAsIMotorRadioDisableByAreaId()
		{
			return this.DisableRangeType<IMotorRadioDisableByAreaId>().Value;
		}

		// Token: 0x0602FBA6 RID: 195494 RVA: 0x0067FF24 File Offset: 0x0067E124
		public IMotorRadioDisableByRangeEntities DisableRangeTypeAsIMotorRadioDisableByRangeEntities()
		{
			return this.DisableRangeType<IMotorRadioDisableByRangeEntities>().Value;
		}

		// Token: 0x0602FBA7 RID: 195495 RVA: 0x0067FF3F File Offset: 0x0067E13F
		public static Offset<IDisableInRangeMotorRadioOperation> CreateIDisableInRangeMotorRadioOperation(FlatBufferBuilder builder, EMotorRadioOperationType Type = EMotorRadioOperationType.EnableAll, StringOffset RangeKeyOffset = default(StringOffset), TMotorRadioDisableRange DisableRangeType_type = TMotorRadioDisableRange.NONE, int DisableRangeTypeOffset = 0)
		{
			builder.StartTable(4);
			IDisableInRangeMotorRadioOperation.AddDisableRangeType(builder, DisableRangeTypeOffset);
			IDisableInRangeMotorRadioOperation.AddRangeKey(builder, RangeKeyOffset);
			IDisableInRangeMotorRadioOperation.AddDisableRangeTypeType(builder, DisableRangeType_type);
			IDisableInRangeMotorRadioOperation.AddType(builder, Type);
			return IDisableInRangeMotorRadioOperation.EndIDisableInRangeMotorRadioOperation(builder);
		}

		// Token: 0x0602FBA8 RID: 195496 RVA: 0x0067FF6B File Offset: 0x0067E16B
		public static void StartIDisableInRangeMotorRadioOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602FBA9 RID: 195497 RVA: 0x0067FF74 File Offset: 0x0067E174
		public static void AddType(FlatBufferBuilder builder, EMotorRadioOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FBAA RID: 195498 RVA: 0x0067FF7F File Offset: 0x0067E17F
		public static void AddRangeKey(FlatBufferBuilder builder, StringOffset rangeKeyOffset)
		{
			builder.AddOffset(1, rangeKeyOffset.Value, 0);
		}

		// Token: 0x0602FBAB RID: 195499 RVA: 0x0067FF8F File Offset: 0x0067E18F
		public static void AddDisableRangeTypeType(FlatBufferBuilder builder, TMotorRadioDisableRange disableRangeTypeType)
		{
			builder.AddByte(2, (byte)disableRangeTypeType, 0);
		}

		// Token: 0x0602FBAC RID: 195500 RVA: 0x0067FF9A File Offset: 0x0067E19A
		public static void AddDisableRangeType(FlatBufferBuilder builder, int disableRangeTypeOffset)
		{
			builder.AddOffset(3, disableRangeTypeOffset, 0);
		}

		// Token: 0x0602FBAD RID: 195501 RVA: 0x0067FFA5 File Offset: 0x0067E1A5
		public static Offset<IDisableInRangeMotorRadioOperation> EndIDisableInRangeMotorRadioOperation(FlatBufferBuilder builder)
		{
			return new Offset<IDisableInRangeMotorRadioOperation>(builder.EndTable());
		}

		// Token: 0x0602FBAE RID: 195502 RVA: 0x0067FFB4 File Offset: 0x0067E1B4
		public IDisableInRangeMotorRadioOperationT UnPack()
		{
			IDisableInRangeMotorRadioOperationT disableInRangeMotorRadioOperationT = new IDisableInRangeMotorRadioOperationT();
			this.UnPackTo(disableInRangeMotorRadioOperationT);
			return disableInRangeMotorRadioOperationT;
		}

		// Token: 0x0602FBAF RID: 195503 RVA: 0x0067FFD0 File Offset: 0x0067E1D0
		public void UnPackTo(IDisableInRangeMotorRadioOperationT _o)
		{
			_o.Type = this.Type;
			_o.RangeKey = this.RangeKey;
			_o.DisableRangeType = new TMotorRadioDisableRangeUnion();
			_o.DisableRangeType.Type = this.DisableRangeTypeType;
			switch (this.DisableRangeTypeType)
			{
			case TMotorRadioDisableRange.IMotorRadioDisableByAbsoluteRange:
				_o.DisableRangeType.Value = ((this.DisableRangeType<IMotorRadioDisableByAbsoluteRange>() != null) ? this.DisableRangeType<IMotorRadioDisableByAbsoluteRange>().Value.UnPack() : null);
				return;
			case TMotorRadioDisableRange.IMotorRadioDisableByAreaId:
				_o.DisableRangeType.Value = ((this.DisableRangeType<IMotorRadioDisableByAreaId>() != null) ? this.DisableRangeType<IMotorRadioDisableByAreaId>().Value.UnPack() : null);
				return;
			case TMotorRadioDisableRange.IMotorRadioDisableByRangeEntities:
				_o.DisableRangeType.Value = ((this.DisableRangeType<IMotorRadioDisableByRangeEntities>() != null) ? this.DisableRangeType<IMotorRadioDisableByRangeEntities>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602FBB0 RID: 195504 RVA: 0x006800D0 File Offset: 0x0067E2D0
		public static Offset<IDisableInRangeMotorRadioOperation> Pack(FlatBufferBuilder builder, IDisableInRangeMotorRadioOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableInRangeMotorRadioOperation>);
			}
			StringOffset rangeKeyOffset = (_o.RangeKey == null) ? default(StringOffset) : builder.CreateString(_o.RangeKey);
			TMotorRadioDisableRange disableRangeType_type = (_o.DisableRangeType == null) ? TMotorRadioDisableRange.NONE : _o.DisableRangeType.Type;
			int disableRangeTypeOffset = (_o.DisableRangeType == null) ? 0 : TMotorRadioDisableRangeUnion.Pack(builder, _o.DisableRangeType);
			return IDisableInRangeMotorRadioOperation.CreateIDisableInRangeMotorRadioOperation(builder, _o.Type, rangeKeyOffset, disableRangeType_type, disableRangeTypeOffset);
		}

		// Token: 0x04011A66 RID: 72294
		private Table __p;
	}
}
