using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F27 RID: 3879
	public struct PinballCreature : IFlatbufferObject
	{
		// Token: 0x17002921 RID: 10529
		// (get) Token: 0x0600AE8A RID: 44682 RVA: 0x002C0CC5 File Offset: 0x002BEEC5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AE8B RID: 44683 RVA: 0x002C0CD2 File Offset: 0x002BEED2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AE8C RID: 44684 RVA: 0x002C0CDC File Offset: 0x002BEEDC
		public static PinballCreature GetRootAsPinballCreature(ByteBuffer _bb)
		{
			return PinballCreature.GetRootAsPinballCreature(_bb, default(PinballCreature));
		}

		// Token: 0x0600AE8D RID: 44685 RVA: 0x002C0CF8 File Offset: 0x002BEEF8
		public static PinballCreature GetRootAsPinballCreature(ByteBuffer _bb, PinballCreature obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AE8E RID: 44686 RVA: 0x002C0D15 File Offset: 0x002BEF15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AE8F RID: 44687 RVA: 0x002C0D24 File Offset: 0x002BEF24
		public PinballCreature __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002922 RID: 10530
		// (get) Token: 0x0600AE90 RID: 44688 RVA: 0x002C0D34 File Offset: 0x002BEF34
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

		// Token: 0x17002923 RID: 10531
		// (get) Token: 0x0600AE91 RID: 44689 RVA: 0x002C0D70 File Offset: 0x002BEF70
		public int KscEntityId
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

		// Token: 0x17002924 RID: 10532
		// (get) Token: 0x0600AE92 RID: 44690 RVA: 0x002C0DAC File Offset: 0x002BEFAC
		public int AttrId
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

		// Token: 0x0600AE93 RID: 44691 RVA: 0x002C0DE8 File Offset: 0x002BEFE8
		public int BornBuff(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002925 RID: 10533
		// (get) Token: 0x0600AE94 RID: 44692 RVA: 0x002C0E28 File Offset: 0x002BF028
		public int BornBuffLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AE95 RID: 44693 RVA: 0x002C0E54 File Offset: 0x002BF054
		public Span<int> GetBornBuffBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600AE96 RID: 44694 RVA: 0x002C0E64 File Offset: 0x002BF064
		public int[] GetBornBuffArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17002926 RID: 10534
		// (get) Token: 0x0600AE97 RID: 44695 RVA: 0x002C0E7C File Offset: 0x002BF07C
		public int SummonBuffId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002927 RID: 10535
		// (get) Token: 0x0600AE98 RID: 44696 RVA: 0x002C0EBC File Offset: 0x002BF0BC
		public int SummonLifeInherit
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

		// Token: 0x0600AE99 RID: 44697 RVA: 0x002C0EFC File Offset: 0x002BF0FC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BornBuffIter()或GetBornBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BornBuff()
		{
			PinballCreature pinballCreature = this;
			return pinballCreature.GetBornBuffArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AE9A RID: 44698 RVA: 0x002C0F20 File Offset: 0x002BF120
		[NullableContext(1)]
		public readonly IEnumerable<int> BornBuffIter()
		{
			PinballCreature.<BornBuffIter>d__24 <BornBuffIter>d__ = new PinballCreature.<BornBuffIter>d__24(-2);
			<BornBuffIter>d__.<>3__<>4__this = this;
			return <BornBuffIter>d__;
		}

		// Token: 0x04004FF0 RID: 20464
		private Table __p;
	}
}
