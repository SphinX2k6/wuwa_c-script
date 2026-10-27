using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E42 RID: 24130
	public struct IProcessedValueConstraint : IFlatbufferObject
	{
		// Token: 0x1700B46C RID: 46188
		// (get) Token: 0x060294E6 RID: 169190 RVA: 0x005A9D8A File Offset: 0x005A7F8A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060294E7 RID: 169191 RVA: 0x005A9D97 File Offset: 0x005A7F97
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060294E8 RID: 169192 RVA: 0x005A9DA0 File Offset: 0x005A7FA0
		public static IProcessedValueConstraint GetRootAsIProcessedValueConstraint(ByteBuffer _bb)
		{
			return IProcessedValueConstraint.GetRootAsIProcessedValueConstraint(_bb, default(IProcessedValueConstraint));
		}

		// Token: 0x060294E9 RID: 169193 RVA: 0x005A9DBC File Offset: 0x005A7FBC
		public static IProcessedValueConstraint GetRootAsIProcessedValueConstraint(ByteBuffer _bb, IProcessedValueConstraint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060294EA RID: 169194 RVA: 0x005A9DD9 File Offset: 0x005A7FD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060294EB RID: 169195 RVA: 0x005A9DE8 File Offset: 0x005A7FE8
		public IProcessedValueConstraint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B46D RID: 46189
		// (get) Token: 0x060294EC RID: 169196 RVA: 0x005A9DF8 File Offset: 0x005A7FF8
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

		// Token: 0x1700B46E RID: 46190
		// (get) Token: 0x060294ED RID: 169197 RVA: 0x005A9E34 File Offset: 0x005A8034
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

		// Token: 0x060294EE RID: 169198 RVA: 0x005A9E70 File Offset: 0x005A8070
		public TTable? Value<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060294EF RID: 169199 RVA: 0x005A9EB4 File Offset: 0x005A80B4
		public IConstraintValueClamp ValueAsIConstraintValueClamp()
		{
			return this.Value<IConstraintValueClamp>().Value;
		}

		// Token: 0x060294F0 RID: 169200 RVA: 0x005A9ED0 File Offset: 0x005A80D0
		public IConstraintValueMax ValueAsIConstraintValueMax()
		{
			return this.Value<IConstraintValueMax>().Value;
		}

		// Token: 0x060294F1 RID: 169201 RVA: 0x005A9EEC File Offset: 0x005A80EC
		public IConstraintValueMin ValueAsIConstraintValueMin()
		{
			return this.Value<IConstraintValueMin>().Value;
		}

		// Token: 0x060294F2 RID: 169202 RVA: 0x005A9F07 File Offset: 0x005A8107
		public static Offset<IProcessedValueConstraint> CreateIProcessedValueConstraint(FlatBufferBuilder builder, EProcessedValueType Type = EProcessedValueType.Constant, TConstraintValue Value_type = TConstraintValue.NONE, int ValueOffset = 0)
		{
			builder.StartTable(3);
			IProcessedValueConstraint.AddValue(builder, ValueOffset);
			IProcessedValueConstraint.AddValueType(builder, Value_type);
			IProcessedValueConstraint.AddType(builder, Type);
			return IProcessedValueConstraint.EndIProcessedValueConstraint(builder);
		}

		// Token: 0x060294F3 RID: 169203 RVA: 0x005A9F2B File Offset: 0x005A812B
		public static void StartIProcessedValueConstraint(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060294F4 RID: 169204 RVA: 0x005A9F34 File Offset: 0x005A8134
		public static void AddType(FlatBufferBuilder builder, EProcessedValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060294F5 RID: 169205 RVA: 0x005A9F3F File Offset: 0x005A813F
		public static void AddValueType(FlatBufferBuilder builder, TConstraintValue valueType)
		{
			builder.AddByte(1, (byte)valueType, 0);
		}

		// Token: 0x060294F6 RID: 169206 RVA: 0x005A9F4A File Offset: 0x005A814A
		public static void AddValue(FlatBufferBuilder builder, int valueOffset)
		{
			builder.AddOffset(2, valueOffset, 0);
		}

		// Token: 0x060294F7 RID: 169207 RVA: 0x005A9F55 File Offset: 0x005A8155
		public static Offset<IProcessedValueConstraint> EndIProcessedValueConstraint(FlatBufferBuilder builder)
		{
			return new Offset<IProcessedValueConstraint>(builder.EndTable());
		}

		// Token: 0x060294F8 RID: 169208 RVA: 0x005A9F64 File Offset: 0x005A8164
		public IProcessedValueConstraintT UnPack()
		{
			IProcessedValueConstraintT processedValueConstraintT = new IProcessedValueConstraintT();
			this.UnPackTo(processedValueConstraintT);
			return processedValueConstraintT;
		}

		// Token: 0x060294F9 RID: 169209 RVA: 0x005A9F80 File Offset: 0x005A8180
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

		// Token: 0x060294FA RID: 169210 RVA: 0x005AA074 File Offset: 0x005A8274
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

		// Token: 0x0400F842 RID: 63554
		private Table __p;
	}
}
