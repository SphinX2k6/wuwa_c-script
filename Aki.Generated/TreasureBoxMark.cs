using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001176 RID: 4470
	public struct TreasureBoxMark : IFlatbufferObject
	{
		// Token: 0x17003CCC RID: 15564
		// (get) Token: 0x0600E53F RID: 58687 RVA: 0x0033C511 File Offset: 0x0033A711
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E540 RID: 58688 RVA: 0x0033C51E File Offset: 0x0033A71E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E541 RID: 58689 RVA: 0x0033C528 File Offset: 0x0033A728
		public static TreasureBoxMark GetRootAsTreasureBoxMark(ByteBuffer _bb)
		{
			return TreasureBoxMark.GetRootAsTreasureBoxMark(_bb, default(TreasureBoxMark));
		}

		// Token: 0x0600E542 RID: 58690 RVA: 0x0033C544 File Offset: 0x0033A744
		public static TreasureBoxMark GetRootAsTreasureBoxMark(ByteBuffer _bb, TreasureBoxMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E543 RID: 58691 RVA: 0x0033C561 File Offset: 0x0033A761
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E544 RID: 58692 RVA: 0x0033C570 File Offset: 0x0033A770
		public TreasureBoxMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003CCD RID: 15565
		// (get) Token: 0x0600E545 RID: 58693 RVA: 0x0033C580 File Offset: 0x0033A780
		public int MarkId
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

		// Token: 0x17003CCE RID: 15566
		// (get) Token: 0x0600E546 RID: 58694 RVA: 0x0033C5BC File Offset: 0x0033A7BC
		public string MarkPic
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

		// Token: 0x0600E547 RID: 58695 RVA: 0x0033C5F3 File Offset: 0x0033A7F3
		public Span<byte> GetMarkPicBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E548 RID: 58696 RVA: 0x0033C602 File Offset: 0x0033A802
		public byte[] GetMarkPicArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003CCF RID: 15567
		// (get) Token: 0x0600E549 RID: 58697 RVA: 0x0033C61C File Offset: 0x0033A81C
		public string MarkTitle
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E54A RID: 58698 RVA: 0x0033C653 File Offset: 0x0033A853
		public Span<byte> GetMarkTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E54B RID: 58699 RVA: 0x0033C662 File Offset: 0x0033A862
		public byte[] GetMarkTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003CD0 RID: 15568
		// (get) Token: 0x0600E54C RID: 58700 RVA: 0x0033C67C File Offset: 0x0033A87C
		public string MarkDesc
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E54D RID: 58701 RVA: 0x0033C6B4 File Offset: 0x0033A8B4
		public Span<byte> GetMarkDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E54E RID: 58702 RVA: 0x0033C6C4 File Offset: 0x0033A8C4
		public byte[] GetMarkDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003CD1 RID: 15569
		// (get) Token: 0x0600E54F RID: 58703 RVA: 0x0033C6DC File Offset: 0x0033A8DC
		public int ShowPriority
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

		// Token: 0x0600E550 RID: 58704 RVA: 0x0033C71C File Offset: 0x0033A91C
		public int ShowRange(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003CD2 RID: 15570
		// (get) Token: 0x0600E551 RID: 58705 RVA: 0x0033C75C File Offset: 0x0033A95C
		public int ShowRangeLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E552 RID: 58706 RVA: 0x0033C788 File Offset: 0x0033A988
		public Span<int> GetShowRangeBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600E553 RID: 58707 RVA: 0x0033C798 File Offset: 0x0033A998
		public int[] GetShowRangeArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17003CD3 RID: 15571
		// (get) Token: 0x0600E554 RID: 58708 RVA: 0x0033C7B0 File Offset: 0x0033A9B0
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E555 RID: 58709 RVA: 0x0033C7F4 File Offset: 0x0033A9F4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowRangeIter()或GetShowRangeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowRange()
		{
			TreasureBoxMark treasureBoxMark = this;
			return treasureBoxMark.GetShowRangeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E556 RID: 58710 RVA: 0x0033C818 File Offset: 0x0033AA18
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowRangeIter()
		{
			TreasureBoxMark.<ShowRangeIter>d__32 <ShowRangeIter>d__ = new TreasureBoxMark.<ShowRangeIter>d__32(-2);
			<ShowRangeIter>d__.<>3__<>4__this = this;
			return <ShowRangeIter>d__;
		}

		// Token: 0x040052BC RID: 21180
		private Table __p;
	}
}
