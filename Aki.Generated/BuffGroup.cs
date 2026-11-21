using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C35 RID: 3125
	public struct BuffGroup : IFlatbufferObject
	{
		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x060056CC RID: 22220 RVA: 0x0020BFA9 File Offset: 0x0020A1A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060056CD RID: 22221 RVA: 0x0020BFB6 File Offset: 0x0020A1B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060056CE RID: 22222 RVA: 0x0020BFC0 File Offset: 0x0020A1C0
		public static BuffGroup GetRootAsBuffGroup(ByteBuffer _bb)
		{
			return BuffGroup.GetRootAsBuffGroup(_bb, default(BuffGroup));
		}

		// Token: 0x060056CF RID: 22223 RVA: 0x0020BFDC File Offset: 0x0020A1DC
		public static BuffGroup GetRootAsBuffGroup(ByteBuffer _bb, BuffGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060056D0 RID: 22224 RVA: 0x0020BFF9 File Offset: 0x0020A1F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060056D1 RID: 22225 RVA: 0x0020C008 File Offset: 0x0020A208
		public BuffGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x060056D2 RID: 22226 RVA: 0x0020C018 File Offset: 0x0020A218
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

		// Token: 0x060056D3 RID: 22227 RVA: 0x0020C054 File Offset: 0x0020A254
		public long Buffs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x060056D4 RID: 22228 RVA: 0x0020C094 File Offset: 0x0020A294
		public int BuffsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060056D5 RID: 22229 RVA: 0x0020C0BF File Offset: 0x0020A2BF
		public Span<long> GetBuffsBytes()
		{
			return this.__p.__vector_as_span<long>(6, 8);
		}

		// Token: 0x060056D6 RID: 22230 RVA: 0x0020C0CE File Offset: 0x0020A2CE
		public long[] GetBuffsArray()
		{
			return this.__p.__vector_as_array<long>(6) ?? Array.Empty<long>();
		}

		// Token: 0x060056D7 RID: 22231 RVA: 0x0020C0E5 File Offset: 0x0020A2E5
		[NullableContext(1)]
		public long[] Buffs()
		{
			return this.GetBuffsArray();
		}

		// Token: 0x060056D8 RID: 22232 RVA: 0x0020C0ED File Offset: 0x0020A2ED
		[NullableContext(1)]
		public IEnumerable<long> BuffsIter()
		{
			BuffGroup.<BuffsIter>d__16 <BuffsIter>d__ = new BuffGroup.<BuffsIter>d__16(-2);
			<BuffsIter>d__.<>3__<>4__this = this;
			return <BuffsIter>d__;
		}

		// Token: 0x04005132 RID: 20786
		private Table __p;
	}
}
