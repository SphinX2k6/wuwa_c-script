using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C52 RID: 3154
	public struct ExploreRouletteReplace : IFlatbufferObject
	{
		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x06006BB9 RID: 27577 RVA: 0x00228E9D File Offset: 0x0022709D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006BBA RID: 27578 RVA: 0x00228EAA File Offset: 0x002270AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006BBB RID: 27579 RVA: 0x00228EB4 File Offset: 0x002270B4
		public static ExploreRouletteReplace GetRootAsExploreRouletteReplace(ByteBuffer _bb)
		{
			return ExploreRouletteReplace.GetRootAsExploreRouletteReplace(_bb, default(ExploreRouletteReplace));
		}

		// Token: 0x06006BBC RID: 27580 RVA: 0x00228ED0 File Offset: 0x002270D0
		public static ExploreRouletteReplace GetRootAsExploreRouletteReplace(ByteBuffer _bb, ExploreRouletteReplace obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006BBD RID: 27581 RVA: 0x00228EED File Offset: 0x002270ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006BBE RID: 27582 RVA: 0x00228EFC File Offset: 0x002270FC
		public ExploreRouletteReplace __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x06006BBF RID: 27583 RVA: 0x00228F0C File Offset: 0x0022710C
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

		// Token: 0x06006BC0 RID: 27584 RVA: 0x00228F48 File Offset: 0x00227148
		public string TagsInForce(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x06006BC1 RID: 27585 RVA: 0x00228F84 File Offset: 0x00227184
		public int TagsInForceLength
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

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x06006BC2 RID: 27586 RVA: 0x00228FB0 File Offset: 0x002271B0
		public int Priority
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

		// Token: 0x06006BC3 RID: 27587 RVA: 0x00228FEC File Offset: 0x002271EC
		public int RouletteSkillIdList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x06006BC4 RID: 27588 RVA: 0x0022902C File Offset: 0x0022722C
		public int RouletteSkillIdListLength
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

		// Token: 0x06006BC5 RID: 27589 RVA: 0x00229058 File Offset: 0x00227258
		public Span<int> GetRouletteSkillIdListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06006BC6 RID: 27590 RVA: 0x00229068 File Offset: 0x00227268
		public int[] GetRouletteSkillIdListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x06006BC7 RID: 27591 RVA: 0x00229080 File Offset: 0x00227280
		public int RouletteItemId
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

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x06006BC8 RID: 27592 RVA: 0x002290C0 File Offset: 0x002272C0
		public int ReplaceSkillId
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

		// Token: 0x06006BC9 RID: 27593 RVA: 0x00229100 File Offset: 0x00227300
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RouletteSkillIdListIter()或GetRouletteSkillIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RouletteSkillIdList()
		{
			ExploreRouletteReplace exploreRouletteReplace = this;
			return exploreRouletteReplace.GetRouletteSkillIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006BCA RID: 27594 RVA: 0x00229124 File Offset: 0x00227324
		[NullableContext(1)]
		public readonly IEnumerable<int> RouletteSkillIdListIter()
		{
			ExploreRouletteReplace.<RouletteSkillIdListIter>d__25 <RouletteSkillIdListIter>d__ = new ExploreRouletteReplace.<RouletteSkillIdListIter>d__25(-2);
			<RouletteSkillIdListIter>d__.<>3__<>4__this = this;
			return <RouletteSkillIdListIter>d__;
		}

		// Token: 0x06006BCB RID: 27595 RVA: 0x00229139 File Offset: 0x00227339
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TagsInForceIter()或GetTagsInForceBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] TagsInForce()
		{
			return this.TagsInForceIter().ToArray<string>();
		}

		// Token: 0x06006BCC RID: 27596 RVA: 0x00229146 File Offset: 0x00227346
		[NullableContext(1)]
		public readonly IEnumerable<string> TagsInForceIter()
		{
			ExploreRouletteReplace.<TagsInForceIter>d__27 <TagsInForceIter>d__ = new ExploreRouletteReplace.<TagsInForceIter>d__27(-2);
			<TagsInForceIter>d__.<>3__<>4__this = this;
			return <TagsInForceIter>d__;
		}

		// Token: 0x04004C99 RID: 19609
		private Table __p;
	}
}
