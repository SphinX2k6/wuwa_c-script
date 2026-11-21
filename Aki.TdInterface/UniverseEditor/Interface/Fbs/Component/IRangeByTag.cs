using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E00 RID: 24064
	public struct IRangeByTag : IFlatbufferObject
	{
		// Token: 0x1700B15E RID: 45406
		// (get) Token: 0x060282C4 RID: 164548 RVA: 0x0057E86E File Offset: 0x0057CA6E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060282C5 RID: 164549 RVA: 0x0057E87B File Offset: 0x0057CA7B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060282C6 RID: 164550 RVA: 0x0057E884 File Offset: 0x0057CA84
		public static IRangeByTag GetRootAsIRangeByTag(ByteBuffer _bb)
		{
			return IRangeByTag.GetRootAsIRangeByTag(_bb, default(IRangeByTag));
		}

		// Token: 0x060282C7 RID: 164551 RVA: 0x0057E8A0 File Offset: 0x0057CAA0
		public static IRangeByTag GetRootAsIRangeByTag(ByteBuffer _bb, IRangeByTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060282C8 RID: 164552 RVA: 0x0057E8BD File Offset: 0x0057CABD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060282C9 RID: 164553 RVA: 0x0057E8CC File Offset: 0x0057CACC
		public IRangeByTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B15F RID: 45407
		// (get) Token: 0x060282CA RID: 164554 RVA: 0x0057E8DC File Offset: 0x0057CADC
		public int Tag
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B160 RID: 45408
		// (get) Token: 0x060282CB RID: 164555 RVA: 0x0057E918 File Offset: 0x0057CB18
		public float Range
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B161 RID: 45409
		// (get) Token: 0x060282CC RID: 164556 RVA: 0x0057E958 File Offset: 0x0057CB58
		public float ExitRange
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B162 RID: 45410
		// (get) Token: 0x060282CD RID: 164557 RVA: 0x0057E998 File Offset: 0x0057CB98
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060282CE RID: 164558 RVA: 0x0057E9D5 File Offset: 0x0057CBD5
		public static Offset<IRangeByTag> CreateIRangeByTag(FlatBufferBuilder builder, int Tag = 0, float Range = 0f, float ExitRange = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IRangeByTag.AddExitRange(builder, ExitRange);
			IRangeByTag.AddRange(builder, Range);
			IRangeByTag.AddTag(builder, Tag);
			IRangeByTag.AddNullMask(builder, NullMask);
			return IRangeByTag.EndIRangeByTag(builder);
		}

		// Token: 0x060282CF RID: 164559 RVA: 0x0057EA01 File Offset: 0x0057CC01
		public static void StartIRangeByTag(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060282D0 RID: 164560 RVA: 0x0057EA0A File Offset: 0x0057CC0A
		public static void AddTag(FlatBufferBuilder builder, int tag)
		{
			builder.AddInt(0, tag, 0);
		}

		// Token: 0x060282D1 RID: 164561 RVA: 0x0057EA15 File Offset: 0x0057CC15
		public static void AddRange(FlatBufferBuilder builder, float range)
		{
			builder.AddFloat(1, range, 0.0);
		}

		// Token: 0x060282D2 RID: 164562 RVA: 0x0057EA28 File Offset: 0x0057CC28
		public static void AddExitRange(FlatBufferBuilder builder, float exitRange)
		{
			builder.AddFloat(2, exitRange, 0.0);
		}

		// Token: 0x060282D3 RID: 164563 RVA: 0x0057EA3B File Offset: 0x0057CC3B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060282D4 RID: 164564 RVA: 0x0057EA46 File Offset: 0x0057CC46
		public static Offset<IRangeByTag> EndIRangeByTag(FlatBufferBuilder builder)
		{
			return new Offset<IRangeByTag>(builder.EndTable());
		}

		// Token: 0x060282D5 RID: 164565 RVA: 0x0057EA54 File Offset: 0x0057CC54
		public IRangeByTagT UnPack()
		{
			IRangeByTagT rangeByTagT = new IRangeByTagT();
			this.UnPackTo(rangeByTagT);
			return rangeByTagT;
		}

		// Token: 0x060282D6 RID: 164566 RVA: 0x0057EA6F File Offset: 0x0057CC6F
		public void UnPackTo(IRangeByTagT _o)
		{
			_o.Tag = this.Tag;
			_o.Range = this.Range;
			_o.ExitRange = this.ExitRange;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060282D7 RID: 164567 RVA: 0x0057EAA4 File Offset: 0x0057CCA4
		public static Offset<IRangeByTag> Pack(FlatBufferBuilder builder, IRangeByTagT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRangeByTag>);
			}
			return IRangeByTag.CreateIRangeByTag(builder, _o.Tag, _o.Range, _o.ExitRange, _o.NullMask);
		}

		// Token: 0x0400F9DA RID: 63962
		private Table __p;
	}
}
