using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E51 RID: 3665
	public struct InfrV2Reward : IFlatbufferObject
	{
		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x06008A26 RID: 35366 RVA: 0x0027EBF4 File Offset: 0x0027CDF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008A27 RID: 35367 RVA: 0x0027EC01 File Offset: 0x0027CE01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008A28 RID: 35368 RVA: 0x0027EC08 File Offset: 0x0027CE08
		public static InfrV2Reward GetRootAsInfrV2Reward(ByteBuffer _bb)
		{
			return InfrV2Reward.GetRootAsInfrV2Reward(_bb, default(InfrV2Reward));
		}

		// Token: 0x06008A29 RID: 35369 RVA: 0x0027EC24 File Offset: 0x0027CE24
		public static InfrV2Reward GetRootAsInfrV2Reward(ByteBuffer _bb, InfrV2Reward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008A2A RID: 35370 RVA: 0x0027EC41 File Offset: 0x0027CE41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008A2B RID: 35371 RVA: 0x0027EC50 File Offset: 0x0027CE50
		public InfrV2Reward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x06008A2C RID: 35372 RVA: 0x0027EC60 File Offset: 0x0027CE60
		public int Id
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

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x06008A2D RID: 35373 RVA: 0x0027EC9C File Offset: 0x0027CE9C
		public int ActivityId
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

		// Token: 0x17001996 RID: 6550
		// (get) Token: 0x06008A2E RID: 35374 RVA: 0x0027ECD8 File Offset: 0x0027CED8
		public int TabId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x06008A2F RID: 35375 RVA: 0x0027ED14 File Offset: 0x0027CF14
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x06008A30 RID: 35376 RVA: 0x0027ED54 File Offset: 0x0027CF54
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008A31 RID: 35377 RVA: 0x0027ED8C File Offset: 0x0027CF8C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008A32 RID: 35378 RVA: 0x0027ED9C File Offset: 0x0027CF9C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x06008A33 RID: 35379 RVA: 0x0027EDB4 File Offset: 0x0027CFB4
		public int ConditionGroup
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700199A RID: 6554
		// (get) Token: 0x06008A34 RID: 35380 RVA: 0x0027EDF4 File Offset: 0x0027CFF4
		public int DropId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700199B RID: 6555
		// (get) Token: 0x06008A35 RID: 35381 RVA: 0x0027EE34 File Offset: 0x0027D034
		public int SkipType
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008A36 RID: 35382 RVA: 0x0027EE74 File Offset: 0x0027D074
		public string SkipParam(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700199C RID: 6556
		// (get) Token: 0x06008A37 RID: 35383 RVA: 0x0027EEB0 File Offset: 0x0027D0B0
		public int SkipParamLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008A38 RID: 35384 RVA: 0x0027EEDC File Offset: 0x0027D0DC
		[NullableContext(1)]
		public string[] SkipParam()
		{
			return this.SkipParamIter().ToArray<string>();
		}

		// Token: 0x06008A39 RID: 35385 RVA: 0x0027EEE9 File Offset: 0x0027D0E9
		[NullableContext(1)]
		public IEnumerable<string> SkipParamIter()
		{
			InfrV2Reward.<SkipParamIter>d__30 <SkipParamIter>d__ = new InfrV2Reward.<SkipParamIter>d__30(-2);
			<SkipParamIter>d__.<>3__<>4__this = this;
			return <SkipParamIter>d__;
		}

		// Token: 0x040053D4 RID: 21460
		private Table __p;
	}
}
