using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057F9 RID: 22521
	public struct IRangeByTag : IFlatbufferObject
	{
		// Token: 0x1700A83A RID: 43066
		// (get) Token: 0x06025DA4 RID: 155044 RVA: 0x005386E2 File Offset: 0x005368E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025DA5 RID: 155045 RVA: 0x005386EF File Offset: 0x005368EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025DA6 RID: 155046 RVA: 0x005386F8 File Offset: 0x005368F8
		public static IRangeByTag GetRootAsIRangeByTag(ByteBuffer _bb)
		{
			return IRangeByTag.GetRootAsIRangeByTag(_bb, default(IRangeByTag));
		}

		// Token: 0x06025DA7 RID: 155047 RVA: 0x00538714 File Offset: 0x00536914
		public static IRangeByTag GetRootAsIRangeByTag(ByteBuffer _bb, IRangeByTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025DA8 RID: 155048 RVA: 0x00538731 File Offset: 0x00536931
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025DA9 RID: 155049 RVA: 0x00538740 File Offset: 0x00536940
		public IRangeByTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A83B RID: 43067
		// (get) Token: 0x06025DAA RID: 155050 RVA: 0x00538750 File Offset: 0x00536950
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

		// Token: 0x1700A83C RID: 43068
		// (get) Token: 0x06025DAB RID: 155051 RVA: 0x0053878C File Offset: 0x0053698C
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

		// Token: 0x1700A83D RID: 43069
		// (get) Token: 0x06025DAC RID: 155052 RVA: 0x005387CC File Offset: 0x005369CC
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

		// Token: 0x1700A83E RID: 43070
		// (get) Token: 0x06025DAD RID: 155053 RVA: 0x0053880C File Offset: 0x00536A0C
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

		// Token: 0x06025DAE RID: 155054 RVA: 0x00538849 File Offset: 0x00536A49
		public static Offset<IRangeByTag> CreateIRangeByTag(FlatBufferBuilder builder, int Tag = 0, float Range = 0f, float ExitRange = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IRangeByTag.AddExitRange(builder, ExitRange);
			IRangeByTag.AddRange(builder, Range);
			IRangeByTag.AddTag(builder, Tag);
			IRangeByTag.AddNullMask(builder, NullMask);
			return IRangeByTag.EndIRangeByTag(builder);
		}

		// Token: 0x06025DAF RID: 155055 RVA: 0x00538875 File Offset: 0x00536A75
		public static void StartIRangeByTag(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06025DB0 RID: 155056 RVA: 0x0053887E File Offset: 0x00536A7E
		public static void AddTag(FlatBufferBuilder builder, int tag)
		{
			builder.AddInt(0, tag, 0);
		}

		// Token: 0x06025DB1 RID: 155057 RVA: 0x00538889 File Offset: 0x00536A89
		public static void AddRange(FlatBufferBuilder builder, float range)
		{
			builder.AddFloat(1, range, 0.0);
		}

		// Token: 0x06025DB2 RID: 155058 RVA: 0x0053889C File Offset: 0x00536A9C
		public static void AddExitRange(FlatBufferBuilder builder, float exitRange)
		{
			builder.AddFloat(2, exitRange, 0.0);
		}

		// Token: 0x06025DB3 RID: 155059 RVA: 0x005388AF File Offset: 0x00536AAF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06025DB4 RID: 155060 RVA: 0x005388BA File Offset: 0x00536ABA
		public static Offset<IRangeByTag> EndIRangeByTag(FlatBufferBuilder builder)
		{
			return new Offset<IRangeByTag>(builder.EndTable());
		}

		// Token: 0x06025DB5 RID: 155061 RVA: 0x005388C8 File Offset: 0x00536AC8
		public IRangeByTagT UnPack()
		{
			IRangeByTagT rangeByTagT = new IRangeByTagT();
			this.UnPackTo(rangeByTagT);
			return rangeByTagT;
		}

		// Token: 0x06025DB6 RID: 155062 RVA: 0x005388E3 File Offset: 0x00536AE3
		public void UnPackTo(IRangeByTagT _o)
		{
			_o.Tag = this.Tag;
			_o.Range = this.Range;
			_o.ExitRange = this.ExitRange;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025DB7 RID: 155063 RVA: 0x00538918 File Offset: 0x00536B18
		public static Offset<IRangeByTag> Pack(FlatBufferBuilder builder, IRangeByTagT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRangeByTag>);
			}
			return IRangeByTag.CreateIRangeByTag(builder, _o.Tag, _o.Range, _o.ExitRange, _o.NullMask);
		}

		// Token: 0x0400ECEF RID: 60655
		private Table __p;
	}
}
