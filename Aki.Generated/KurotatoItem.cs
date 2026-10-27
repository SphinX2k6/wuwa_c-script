using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DA1 RID: 3489
	public struct KurotatoItem : IFlatbufferObject
	{
		// Token: 0x17001B7E RID: 7038
		// (get) Token: 0x060089AF RID: 35247 RVA: 0x0026E37D File Offset: 0x0026C57D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060089B0 RID: 35248 RVA: 0x0026E38A File Offset: 0x0026C58A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060089B1 RID: 35249 RVA: 0x0026E394 File Offset: 0x0026C594
		public static KurotatoItem GetRootAsKurotatoItem(ByteBuffer _bb)
		{
			return KurotatoItem.GetRootAsKurotatoItem(_bb, default(KurotatoItem));
		}

		// Token: 0x060089B2 RID: 35250 RVA: 0x0026E3B0 File Offset: 0x0026C5B0
		public static KurotatoItem GetRootAsKurotatoItem(ByteBuffer _bb, KurotatoItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060089B3 RID: 35251 RVA: 0x0026E3CD File Offset: 0x0026C5CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060089B4 RID: 35252 RVA: 0x0026E3DC File Offset: 0x0026C5DC
		public KurotatoItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001B7F RID: 7039
		// (get) Token: 0x060089B5 RID: 35253 RVA: 0x0026E3EC File Offset: 0x0026C5EC
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

		// Token: 0x17001B80 RID: 7040
		// (get) Token: 0x060089B6 RID: 35254 RVA: 0x0026E428 File Offset: 0x0026C628
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

		// Token: 0x17001B81 RID: 7041
		// (get) Token: 0x060089B7 RID: 35255 RVA: 0x0026E468 File Offset: 0x0026C668
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

		// Token: 0x060089B8 RID: 35256 RVA: 0x0026E4A4 File Offset: 0x0026C6A4
		public int Effect(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B82 RID: 7042
		// (get) Token: 0x060089B9 RID: 35257 RVA: 0x0026E4E4 File Offset: 0x0026C6E4
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

		// Token: 0x060089BA RID: 35258 RVA: 0x0026E510 File Offset: 0x0026C710
		public Span<int> GetEffectBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060089BB RID: 35259 RVA: 0x0026E520 File Offset: 0x0026C720
		public int[] GetEffectArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17001B83 RID: 7043
		// (get) Token: 0x060089BC RID: 35260 RVA: 0x0026E538 File Offset: 0x0026C738
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

		// Token: 0x060089BD RID: 35261 RVA: 0x0026E570 File Offset: 0x0026C770
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060089BE RID: 35262 RVA: 0x0026E580 File Offset: 0x0026C780
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x060089BF RID: 35263 RVA: 0x0026E598 File Offset: 0x0026C798
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

		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x060089C0 RID: 35264 RVA: 0x0026E5D8 File Offset: 0x0026C7D8
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

		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x060089C1 RID: 35265 RVA: 0x0026E61C File Offset: 0x0026C81C
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

		// Token: 0x060089C2 RID: 35266 RVA: 0x0026E654 File Offset: 0x0026C854
		public Span<byte> GetEffectivePeriodBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060089C3 RID: 35267 RVA: 0x0026E664 File Offset: 0x0026C864
		public byte[] GetEffectivePeriodArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001B87 RID: 7047
		// (get) Token: 0x060089C4 RID: 35268 RVA: 0x0026E67C File Offset: 0x0026C87C
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

		// Token: 0x17001B88 RID: 7048
		// (get) Token: 0x060089C5 RID: 35269 RVA: 0x0026E6BC File Offset: 0x0026C8BC
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

		// Token: 0x060089C6 RID: 35270 RVA: 0x0026E6F4 File Offset: 0x0026C8F4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060089C7 RID: 35271 RVA: 0x0026E704 File Offset: 0x0026C904
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x060089C8 RID: 35272 RVA: 0x0026E71C File Offset: 0x0026C91C
		public string DescParams(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B89 RID: 7049
		// (get) Token: 0x060089C9 RID: 35273 RVA: 0x0026E758 File Offset: 0x0026C958
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

		// Token: 0x17001B8A RID: 7050
		// (get) Token: 0x060089CA RID: 35274 RVA: 0x0026E784 File Offset: 0x0026C984
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

		// Token: 0x060089CB RID: 35275 RVA: 0x0026E7BC File Offset: 0x0026C9BC
		public Span<byte> GetBgDescBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060089CC RID: 35276 RVA: 0x0026E7CC File Offset: 0x0026C9CC
		public byte[] GetBgDescArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001B8B RID: 7051
		// (get) Token: 0x060089CD RID: 35277 RVA: 0x0026E7E4 File Offset: 0x0026C9E4
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

		// Token: 0x060089CE RID: 35278 RVA: 0x0026E81C File Offset: 0x0026CA1C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x060089CF RID: 35279 RVA: 0x0026E82C File Offset: 0x0026CA2C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17001B8C RID: 7052
		// (get) Token: 0x060089D0 RID: 35280 RVA: 0x0026E844 File Offset: 0x0026CA44
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

		// Token: 0x060089D1 RID: 35281 RVA: 0x0026E87C File Offset: 0x0026CA7C
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x060089D2 RID: 35282 RVA: 0x0026E88C File Offset: 0x0026CA8C
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17001B8D RID: 7053
		// (get) Token: 0x060089D3 RID: 35283 RVA: 0x0026E8A4 File Offset: 0x0026CAA4
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

		// Token: 0x17001B8E RID: 7054
		// (get) Token: 0x060089D4 RID: 35284 RVA: 0x0026E8E4 File Offset: 0x0026CAE4
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

		// Token: 0x17001B8F RID: 7055
		// (get) Token: 0x060089D5 RID: 35285 RVA: 0x0026E924 File Offset: 0x0026CB24
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

		// Token: 0x060089D6 RID: 35286 RVA: 0x0026E968 File Offset: 0x0026CB68
		public string Tags(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B90 RID: 7056
		// (get) Token: 0x060089D7 RID: 35287 RVA: 0x0026E9A4 File Offset: 0x0026CBA4
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

		// Token: 0x060089D8 RID: 35288 RVA: 0x0026E9D0 File Offset: 0x0026CBD0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescParamsIter()或GetDescParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescParams()
		{
			return this.DescParamsIter().ToArray<string>();
		}

		// Token: 0x060089D9 RID: 35289 RVA: 0x0026E9DD File Offset: 0x0026CBDD
		[NullableContext(1)]
		public readonly IEnumerable<string> DescParamsIter()
		{
			KurotatoItem.<DescParamsIter>d__62 <DescParamsIter>d__ = new KurotatoItem.<DescParamsIter>d__62(-2);
			<DescParamsIter>d__.<>3__<>4__this = this;
			return <DescParamsIter>d__;
		}

		// Token: 0x060089DA RID: 35290 RVA: 0x0026E9F4 File Offset: 0x0026CBF4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectIter()或GetEffectBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Effect()
		{
			KurotatoItem kurotatoItem = this;
			return kurotatoItem.GetEffectArray() ?? Array.Empty<int>();
		}

		// Token: 0x060089DB RID: 35291 RVA: 0x0026EA18 File Offset: 0x0026CC18
		[NullableContext(1)]
		public readonly IEnumerable<int> EffectIter()
		{
			KurotatoItem.<EffectIter>d__64 <EffectIter>d__ = new KurotatoItem.<EffectIter>d__64(-2);
			<EffectIter>d__.<>3__<>4__this = this;
			return <EffectIter>d__;
		}

		// Token: 0x060089DC RID: 35292 RVA: 0x0026EA2D File Offset: 0x0026CC2D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TagsIter()或GetTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Tags()
		{
			return this.TagsIter().ToArray<string>();
		}

		// Token: 0x060089DD RID: 35293 RVA: 0x0026EA3A File Offset: 0x0026CC3A
		[NullableContext(1)]
		public readonly IEnumerable<string> TagsIter()
		{
			KurotatoItem.<TagsIter>d__66 <TagsIter>d__ = new KurotatoItem.<TagsIter>d__66(-2);
			<TagsIter>d__.<>3__<>4__this = this;
			return <TagsIter>d__;
		}

		// Token: 0x04004E32 RID: 20018
		private Table __p;
	}
}
