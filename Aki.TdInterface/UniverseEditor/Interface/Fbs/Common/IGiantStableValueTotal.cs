using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006416 RID: 25622
	public struct IGiantStableValueTotal : IFlatbufferObject
	{
		// Token: 0x1700BD41 RID: 48449
		// (get) Token: 0x0602B880 RID: 178304 RVA: 0x005EDA67 File Offset: 0x005EBC67
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B881 RID: 178305 RVA: 0x005EDA74 File Offset: 0x005EBC74
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B882 RID: 178306 RVA: 0x005EDA7C File Offset: 0x005EBC7C
		public static IGiantStableValueTotal GetRootAsIGiantStableValueTotal(ByteBuffer _bb)
		{
			return IGiantStableValueTotal.GetRootAsIGiantStableValueTotal(_bb, default(IGiantStableValueTotal));
		}

		// Token: 0x0602B883 RID: 178307 RVA: 0x005EDA98 File Offset: 0x005EBC98
		public static IGiantStableValueTotal GetRootAsIGiantStableValueTotal(ByteBuffer _bb, IGiantStableValueTotal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B884 RID: 178308 RVA: 0x005EDAB5 File Offset: 0x005EBCB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B885 RID: 178309 RVA: 0x005EDAC4 File Offset: 0x005EBCC4
		public IGiantStableValueTotal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD42 RID: 48450
		// (get) Token: 0x0602B886 RID: 178310 RVA: 0x005EDAD4 File Offset: 0x005EBCD4
		public EGiantStableValueType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGiantStableValueType.Region;
				}
				return (EGiantStableValueType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BD43 RID: 48451
		// (get) Token: 0x0602B887 RID: 178311 RVA: 0x005EDB10 File Offset: 0x005EBD10
		public IGiantStableValueRange? Range
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IGiantStableValueRange?(default(IGiantStableValueRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602B888 RID: 178312 RVA: 0x005EDB6D File Offset: 0x005EBD6D
		public static Offset<IGiantStableValueTotal> CreateIGiantStableValueTotal(FlatBufferBuilder builder, EGiantStableValueType Type = EGiantStableValueType.Region, Offset<IGiantStableValueRange> RangeOffset = default(Offset<IGiantStableValueRange>))
		{
			builder.StartTable(2);
			IGiantStableValueTotal.AddRange(builder, RangeOffset);
			IGiantStableValueTotal.AddType(builder, Type);
			return IGiantStableValueTotal.EndIGiantStableValueTotal(builder);
		}

		// Token: 0x0602B889 RID: 178313 RVA: 0x005EDB8A File Offset: 0x005EBD8A
		public static void StartIGiantStableValueTotal(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B88A RID: 178314 RVA: 0x005EDB93 File Offset: 0x005EBD93
		public static void AddType(FlatBufferBuilder builder, EGiantStableValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B88B RID: 178315 RVA: 0x005EDB9E File Offset: 0x005EBD9E
		public static void AddRange(FlatBufferBuilder builder, Offset<IGiantStableValueRange> rangeOffset)
		{
			builder.AddOffset(1, rangeOffset.Value, 0);
		}

		// Token: 0x0602B88C RID: 178316 RVA: 0x005EDBAE File Offset: 0x005EBDAE
		public static Offset<IGiantStableValueTotal> EndIGiantStableValueTotal(FlatBufferBuilder builder)
		{
			return new Offset<IGiantStableValueTotal>(builder.EndTable());
		}

		// Token: 0x0602B88D RID: 178317 RVA: 0x005EDBBC File Offset: 0x005EBDBC
		public IGiantStableValueTotalT UnPack()
		{
			IGiantStableValueTotalT giantStableValueTotalT = new IGiantStableValueTotalT();
			this.UnPackTo(giantStableValueTotalT);
			return giantStableValueTotalT;
		}

		// Token: 0x0602B88E RID: 178318 RVA: 0x005EDBD8 File Offset: 0x005EBDD8
		public void UnPackTo(IGiantStableValueTotalT _o)
		{
			_o.Type = this.Type;
			_o.Range = ((this.Range != null) ? this.Range.Value.UnPack() : null);
		}

		// Token: 0x0602B88F RID: 178319 RVA: 0x005EDC20 File Offset: 0x005EBE20
		public static Offset<IGiantStableValueTotal> Pack(FlatBufferBuilder builder, IGiantStableValueTotalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantStableValueTotal>);
			}
			Offset<IGiantStableValueRange> rangeOffset = (_o.Range == null) ? default(Offset<IGiantStableValueRange>) : IGiantStableValueRange.Pack(builder, _o.Range);
			return IGiantStableValueTotal.CreateIGiantStableValueTotal(builder, _o.Type, rangeOffset);
		}

		// Token: 0x0401051B RID: 66843
		private Table __p;
	}
}
