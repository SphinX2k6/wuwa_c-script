using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E86 RID: 3718
	public struct KurotatoItem : IFlatbufferObject
	{
		// Token: 0x17001BE2 RID: 7138
		// (get) Token: 0x06008FCB RID: 36811 RVA: 0x0028CEF9 File Offset: 0x0028B0F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008FCC RID: 36812 RVA: 0x0028CF06 File Offset: 0x0028B106
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008FCD RID: 36813 RVA: 0x0028CF10 File Offset: 0x0028B110
		public static KurotatoItem GetRootAsKurotatoItem(ByteBuffer _bb)
		{
			return KurotatoItem.GetRootAsKurotatoItem(_bb, default(KurotatoItem));
		}

		// Token: 0x06008FCE RID: 36814 RVA: 0x0028CF2C File Offset: 0x0028B12C
		public static KurotatoItem GetRootAsKurotatoItem(ByteBuffer _bb, KurotatoItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008FCF RID: 36815 RVA: 0x0028CF49 File Offset: 0x0028B149
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008FD0 RID: 36816 RVA: 0x0028CF58 File Offset: 0x0028B158
		public KurotatoItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001BE3 RID: 7139
		// (get) Token: 0x06008FD1 RID: 36817 RVA: 0x0028CF68 File Offset: 0x0028B168
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

		// Token: 0x17001BE4 RID: 7140
		// (get) Token: 0x06008FD2 RID: 36818 RVA: 0x0028CFA4 File Offset: 0x0028B1A4
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 3401;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001BE5 RID: 7141
		// (get) Token: 0x06008FD3 RID: 36819 RVA: 0x0028CFE4 File Offset: 0x0028B1E4
		public int UnlockConditionId
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

		// Token: 0x06008FD4 RID: 36820 RVA: 0x0028D020 File Offset: 0x0028B220
		public int Effect(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BE6 RID: 7142
		// (get) Token: 0x06008FD5 RID: 36821 RVA: 0x0028D060 File Offset: 0x0028B260
		public int EffectLength
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

		// Token: 0x06008FD6 RID: 36822 RVA: 0x0028D08C File Offset: 0x0028B28C
		public Span<int> GetEffectBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06008FD7 RID: 36823 RVA: 0x0028D09C File Offset: 0x0028B29C
		public int[] GetEffectArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17001BE7 RID: 7143
		// (get) Token: 0x06008FD8 RID: 36824 RVA: 0x0028D0B4 File Offset: 0x0028B2B4
		public string Name
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

		// Token: 0x06008FD9 RID: 36825 RVA: 0x0028D0EC File Offset: 0x0028B2EC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008FDA RID: 36826 RVA: 0x0028D0FC File Offset: 0x0028B2FC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BE8 RID: 7144
		// (get) Token: 0x06008FDB RID: 36827 RVA: 0x0028D114 File Offset: 0x0028B314
		public int SortId
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

		// Token: 0x17001BE9 RID: 7145
		// (get) Token: 0x06008FDC RID: 36828 RVA: 0x0028D154 File Offset: 0x0028B354
		public int MaxStackCount
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 999;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001BEA RID: 7146
		// (get) Token: 0x06008FDD RID: 36829 RVA: 0x0028D198 File Offset: 0x0028B398
		public string EffectivePeriod
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008FDE RID: 36830 RVA: 0x0028D1D0 File Offset: 0x0028B3D0
		public Span<byte> GetEffectivePeriodBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06008FDF RID: 36831 RVA: 0x0028D1E0 File Offset: 0x0028B3E0
		public byte[] GetEffectivePeriodArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BEB RID: 7147
		// (get) Token: 0x06008FE0 RID: 36832 RVA: 0x0028D1F8 File Offset: 0x0028B3F8
		public int Type
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001BEC RID: 7148
		// (get) Token: 0x06008FE1 RID: 36833 RVA: 0x0028D238 File Offset: 0x0028B438
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008FE2 RID: 36834 RVA: 0x0028D270 File Offset: 0x0028B470
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008FE3 RID: 36835 RVA: 0x0028D280 File Offset: 0x0028B480
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06008FE4 RID: 36836 RVA: 0x0028D298 File Offset: 0x0028B498
		public string DescParams(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BED RID: 7149
		// (get) Token: 0x06008FE5 RID: 36837 RVA: 0x0028D2D4 File Offset: 0x0028B4D4
		public int DescParamsLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001BEE RID: 7150
		// (get) Token: 0x06008FE6 RID: 36838 RVA: 0x0028D300 File Offset: 0x0028B500
		public string BgDesc
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008FE7 RID: 36839 RVA: 0x0028D338 File Offset: 0x0028B538
		public Span<byte> GetBgDescBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06008FE8 RID: 36840 RVA: 0x0028D348 File Offset: 0x0028B548
		public byte[] GetBgDescArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BEF RID: 7151
		// (get) Token: 0x06008FE9 RID: 36841 RVA: 0x0028D360 File Offset: 0x0028B560
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008FEA RID: 36842 RVA: 0x0028D398 File Offset: 0x0028B598
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06008FEB RID: 36843 RVA: 0x0028D3A8 File Offset: 0x0028B5A8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BF0 RID: 7152
		// (get) Token: 0x06008FEC RID: 36844 RVA: 0x0028D3C0 File Offset: 0x0028B5C0
		public string Tag
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008FED RID: 36845 RVA: 0x0028D3F8 File Offset: 0x0028B5F8
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06008FEE RID: 36846 RVA: 0x0028D408 File Offset: 0x0028B608
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BF1 RID: 7153
		// (get) Token: 0x06008FEF RID: 36847 RVA: 0x0028D420 File Offset: 0x0028B620
		public int Quality
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001BF2 RID: 7154
		// (get) Token: 0x06008FF0 RID: 36848 RVA: 0x0028D460 File Offset: 0x0028B660
		public int ShopBasicCost
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001BF3 RID: 7155
		// (get) Token: 0x06008FF1 RID: 36849 RVA: 0x0028D4A0 File Offset: 0x0028B6A0
		public float ShopSellMutiply
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0.6f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008FF2 RID: 36850 RVA: 0x0028D4E4 File Offset: 0x0028B6E4
		public string Tags(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BF4 RID: 7156
		// (get) Token: 0x06008FF3 RID: 36851 RVA: 0x0028D520 File Offset: 0x0028B720
		public int TagsLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008FF4 RID: 36852 RVA: 0x0028D54C File Offset: 0x0028B74C
		[NullableContext(1)]
		public string[] DescParams()
		{
			return this.DescParamsIter().ToArray<string>();
		}

		// Token: 0x06008FF5 RID: 36853 RVA: 0x0028D559 File Offset: 0x0028B759
		[NullableContext(1)]
		public IEnumerable<string> DescParamsIter()
		{
			KurotatoItem.<DescParamsIter>d__62 <DescParamsIter>d__ = new KurotatoItem.<DescParamsIter>d__62(-2);
			<DescParamsIter>d__.<>3__<>4__this = this;
			return <DescParamsIter>d__;
		}

		// Token: 0x06008FF6 RID: 36854 RVA: 0x0028D56E File Offset: 0x0028B76E
		[NullableContext(1)]
		public int[] Effect()
		{
			return this.GetEffectArray();
		}

		// Token: 0x06008FF7 RID: 36855 RVA: 0x0028D576 File Offset: 0x0028B776
		[NullableContext(1)]
		public IEnumerable<int> EffectIter()
		{
			KurotatoItem.<EffectIter>d__64 <EffectIter>d__ = new KurotatoItem.<EffectIter>d__64(-2);
			<EffectIter>d__.<>3__<>4__this = this;
			return <EffectIter>d__;
		}

		// Token: 0x06008FF8 RID: 36856 RVA: 0x0028D58B File Offset: 0x0028B78B
		[NullableContext(1)]
		public string[] Tags()
		{
			return this.TagsIter().ToArray<string>();
		}

		// Token: 0x06008FF9 RID: 36857 RVA: 0x0028D598 File Offset: 0x0028B798
		[NullableContext(1)]
		public IEnumerable<string> TagsIter()
		{
			KurotatoItem.<TagsIter>d__66 <TagsIter>d__ = new KurotatoItem.<TagsIter>d__66(-2);
			<TagsIter>d__.<>3__<>4__this = this;
			return <TagsIter>d__;
		}

		// Token: 0x04005417 RID: 21527
		private Table __p;
	}
}
