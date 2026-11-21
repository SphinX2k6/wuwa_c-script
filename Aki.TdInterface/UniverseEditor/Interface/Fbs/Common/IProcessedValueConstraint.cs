using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006482 RID: 25730
	public struct IProcessedValueConstraint : IFlatbufferObject
	{
		// Token: 0x1700BDD5 RID: 48597
		// (get) Token: 0x0602BB82 RID: 179074 RVA: 0x005F2C32 File Offset: 0x005F0E32
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BB83 RID: 179075 RVA: 0x005F2C3F File Offset: 0x005F0E3F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BB84 RID: 179076 RVA: 0x005F2C48 File Offset: 0x005F0E48
		public static IProcessedValueConstraint GetRootAsIProcessedValueConstraint(ByteBuffer _bb)
		{
			return IProcessedValueConstraint.GetRootAsIProcessedValueConstraint(_bb, default(IProcessedValueConstraint));
		}

		// Token: 0x0602BB85 RID: 179077 RVA: 0x005F2C64 File Offset: 0x005F0E64
		public static IProcessedValueConstraint GetRootAsIProcessedValueConstraint(ByteBuffer _bb, IProcessedValueConstraint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BB86 RID: 179078 RVA: 0x005F2C81 File Offset: 0x005F0E81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BB87 RID: 179079 RVA: 0x005F2C90 File Offset: 0x005F0E90
		public IProcessedValueConstraint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDD6 RID: 48598
		// (get) Token: 0x0602BB88 RID: 179080 RVA: 0x005F2CA0 File Offset: 0x005F0EA0
		public EProcessedValueType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EProcessedValueType.Constant;
				}
				return (EProcessedValueType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BDD7 RID: 48599
		// (get) Token: 0x0602BB89 RID: 179081 RVA: 0x005F2CDC File Offset: 0x005F0EDC
		public TConstraintValue ValueType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TConstraintValue.NONE;
				}
				return (TConstraintValue)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BB8A RID: 179082 RVA: 0x005F2D18 File Offset: 0x005F0F18
		public TTable? Value<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602BB8B RID: 179083 RVA: 0x005F2D5C File Offset: 0x005F0F5C
		public IConstraintValueClamp ValueAsIConstraintValueClamp()
		{
			return this.Value<IConstraintValueClamp>().Value;
		}

		// Token: 0x0602BB8C RID: 179084 RVA: 0x005F2D78 File Offset: 0x005F0F78
		public IConstraintValueMax ValueAsIConstraintValueMax()
		{
			return this.Value<IConstraintValueMax>().Value;
		}

		// Token: 0x0602BB8D RID: 179085 RVA: 0x005F2D94 File Offset: 0x005F0F94
		public IConstraintValueMin ValueAsIConstraintValueMin()
		{
			return this.Value<IConstraintValueMin>().Value;
		}

		// Token: 0x0602BB8E RID: 179086 RVA: 0x005F2DAF File Offset: 0x005F0FAF
		public static Offset<IProcessedValueConstraint> CreateIProcessedValueConstraint(FlatBufferBuilder builder, EProcessedValueType Type = EProcessedValueType.Constant, TConstraintValue Value_type = TConstraintValue.NONE, int ValueOffset = 0)
		{
			builder.StartTable(3);
			IProcessedValueConstraint.AddValue(builder, ValueOffset);
			IProcessedValueConstraint.AddValueType(builder, Value_type);
			IProcessedValueConstraint.AddType(builder, Type);
			return IProcessedValueConstraint.EndIProcessedValueConstraint(builder);
		}

		// Token: 0x0602BB8F RID: 179087 RVA: 0x005F2DD3 File Offset: 0x005F0FD3
		public static void StartIProcessedValueConstraint(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602BB90 RID: 179088 RVA: 0x005F2DDC File Offset: 0x005F0FDC
		public static void AddType(FlatBufferBuilder builder, EProcessedValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BB91 RID: 179089 RVA: 0x005F2DE7 File Offset: 0x005F0FE7
		public static void AddValueType(FlatBufferBuilder builder, TConstraintValue valueType)
		{
			builder.AddByte(1, (byte)valueType, 0);
		}

		// Token: 0x0602BB92 RID: 179090 RVA: 0x005F2DF2 File Offset: 0x005F0FF2
		public static void AddValue(FlatBufferBuilder builder, int valueOffset)
		{
			builder.AddOffset(2, valueOffset, 0);
		}

		// Token: 0x0602BB93 RID: 179091 RVA: 0x005F2DFD File Offset: 0x005F0FFD
		public static Offset<IProcessedValueConstraint> EndIProcessedValueConstraint(FlatBufferBuilder builder)
		{
			return new Offset<IProcessedValueConstraint>(builder.EndTable());
		}

		// Token: 0x0602BB94 RID: 179092 RVA: 0x005F2E0C File Offset: 0x005F100C
		public IProcessedValueConstraintT UnPack()
		{
			IProcessedValueConstraintT processedValueConstraintT = new IProcessedValueConstraintT();
			this.UnPackTo(processedValueConstraintT);
			return processedValueConstraintT;
		}

		// Token: 0x0602BB95 RID: 179093 RVA: 0x005F2E28 File Offset: 0x005F1028
		public void UnPackTo(IProcessedValueConstraintT _o)
		{
			_o.Type = this.Type;
			_o.Value = new TConstraintValueUnion();
			_o.Value.Type = this.ValueType;
			switch (this.ValueType)
			{
			case TConstraintValue.IConstraintValueClamp:
				_o.Value.Value = ((this.Value<IConstraintValueClamp>() != null) ? this.Value<IConstraintValueClamp>().Value.UnPack() : null);
				return;
			case TConstraintValue.IConstraintValueMax:
				_o.Value.Value = ((this.Value<IConstraintValueMax>() != null) ? this.Value<IConstraintValueMax>().Value.UnPack() : null);
				return;
			case TConstraintValue.IConstraintValueMin:
				_o.Value.Value = ((this.Value<IConstraintValueMin>() != null) ? this.Value<IConstraintValueMin>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602BB96 RID: 179094 RVA: 0x005F2F1C File Offset: 0x005F111C
		public static Offset<IProcessedValueConstraint> Pack(FlatBufferBuilder builder, IProcessedValueConstraintT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProcessedValueConstraint>);
			}
			TConstraintValue value_type = (_o.Value == null) ? TConstraintValue.NONE : _o.Value.Type;
			int valueOffset = (_o.Value == null) ? 0 : TConstraintValueUnion.Pack(builder, _o.Value);
			return IProcessedValueConstraint.CreateIProcessedValueConstraint(builder, _o.Type, value_type, valueOffset);
		}

		// Token: 0x0401059F RID: 66975
		private Table __p;
	}
}
