using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DA8 RID: 3496
	public struct KurotatoMonster : IFlatbufferObject
	{
		// Token: 0x17001BCC RID: 7116
		// (get) Token: 0x06008A9A RID: 35482 RVA: 0x00270484 File Offset: 0x0026E684
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008A9B RID: 35483 RVA: 0x00270491 File Offset: 0x0026E691
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008A9C RID: 35484 RVA: 0x00270498 File Offset: 0x0026E698
		public static KurotatoMonster GetRootAsKurotatoMonster(ByteBuffer _bb)
		{
			return KurotatoMonster.GetRootAsKurotatoMonster(_bb, default(KurotatoMonster));
		}

		// Token: 0x06008A9D RID: 35485 RVA: 0x002704B4 File Offset: 0x0026E6B4
		public static KurotatoMonster GetRootAsKurotatoMonster(ByteBuffer _bb, KurotatoMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008A9E RID: 35486 RVA: 0x002704D1 File Offset: 0x0026E6D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008A9F RID: 35487 RVA: 0x002704E0 File Offset: 0x0026E6E0
		public KurotatoMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001BCD RID: 7117
		// (get) Token: 0x06008AA0 RID: 35488 RVA: 0x002704F0 File Offset: 0x0026E6F0
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

		// Token: 0x17001BCE RID: 7118
		// (get) Token: 0x06008AA1 RID: 35489 RVA: 0x0027052C File Offset: 0x0026E72C
		public int BasicProperty
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

		// Token: 0x17001BCF RID: 7119
		// (get) Token: 0x06008AA2 RID: 35490 RVA: 0x00270568 File Offset: 0x0026E768
		public string Name
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

		// Token: 0x06008AA3 RID: 35491 RVA: 0x0027059F File Offset: 0x0026E79F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008AA4 RID: 35492 RVA: 0x002705AE File Offset: 0x0026E7AE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BD0 RID: 7120
		// (get) Token: 0x06008AA5 RID: 35493 RVA: 0x002705C8 File Offset: 0x0026E7C8
		public string Desc
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

		// Token: 0x06008AA6 RID: 35494 RVA: 0x00270600 File Offset: 0x0026E800
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008AA7 RID: 35495 RVA: 0x00270610 File Offset: 0x0026E810
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06008AA8 RID: 35496 RVA: 0x00270628 File Offset: 0x0026E828
		public string DescArgs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BD1 RID: 7121
		// (get) Token: 0x06008AA9 RID: 35497 RVA: 0x00270664 File Offset: 0x0026E864
		public int DescArgsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001BD2 RID: 7122
		// (get) Token: 0x06008AAA RID: 35498 RVA: 0x00270690 File Offset: 0x0026E890
		public int MonsterType
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

		// Token: 0x17001BD3 RID: 7123
		// (get) Token: 0x06008AAB RID: 35499 RVA: 0x002706D0 File Offset: 0x0026E8D0
		public int SimpleCombatSubtypeId
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

		// Token: 0x06008AAC RID: 35500 RVA: 0x00270710 File Offset: 0x0026E910
		public int InitBuffs(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BD4 RID: 7124
		// (get) Token: 0x06008AAD RID: 35501 RVA: 0x00270750 File Offset: 0x0026E950
		public int InitBuffsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008AAE RID: 35502 RVA: 0x0027077C File Offset: 0x0026E97C
		public Span<int> GetInitBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06008AAF RID: 35503 RVA: 0x0027078C File Offset: 0x0026E98C
		public int[] GetInitBuffsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x06008AB0 RID: 35504 RVA: 0x002707A4 File Offset: 0x0026E9A4
		public int Deathrattles(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BD5 RID: 7125
		// (get) Token: 0x06008AB1 RID: 35505 RVA: 0x002707E4 File Offset: 0x0026E9E4
		public int DeathrattlesLength
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

		// Token: 0x06008AB2 RID: 35506 RVA: 0x00270810 File Offset: 0x0026EA10
		public Span<int> GetDeathrattlesBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06008AB3 RID: 35507 RVA: 0x00270820 File Offset: 0x0026EA20
		public int[] GetDeathrattlesArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x06008AB4 RID: 35508 RVA: 0x00270838 File Offset: 0x0026EA38
		public int Tag(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BD6 RID: 7126
		// (get) Token: 0x06008AB5 RID: 35509 RVA: 0x00270878 File Offset: 0x0026EA78
		public int TagLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008AB6 RID: 35510 RVA: 0x002708A4 File Offset: 0x0026EAA4
		public Span<int> GetTagBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x06008AB7 RID: 35511 RVA: 0x002708B4 File Offset: 0x0026EAB4
		public int[] GetTagArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x06008AB8 RID: 35512 RVA: 0x002708CC File Offset: 0x0026EACC
		public int AttrShow(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BD7 RID: 7127
		// (get) Token: 0x06008AB9 RID: 35513 RVA: 0x0027090C File Offset: 0x0026EB0C
		public int AttrShowLength
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

		// Token: 0x06008ABA RID: 35514 RVA: 0x00270938 File Offset: 0x0026EB38
		public Span<int> GetAttrShowBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06008ABB RID: 35515 RVA: 0x00270948 File Offset: 0x0026EB48
		public int[] GetAttrShowArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x17001BD8 RID: 7128
		// (get) Token: 0x06008ABC RID: 35516 RVA: 0x00270960 File Offset: 0x0026EB60
		public bool IsHideInBook
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06008ABD RID: 35517 RVA: 0x002709A0 File Offset: 0x0026EBA0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AttrShowIter()或GetAttrShowBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AttrShow()
		{
			KurotatoMonster kurotatoMonster = this;
			return kurotatoMonster.GetAttrShowArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008ABE RID: 35518 RVA: 0x002709C4 File Offset: 0x0026EBC4
		[NullableContext(1)]
		public readonly IEnumerable<int> AttrShowIter()
		{
			KurotatoMonster.<AttrShowIter>d__50 <AttrShowIter>d__ = new KurotatoMonster.<AttrShowIter>d__50(-2);
			<AttrShowIter>d__.<>3__<>4__this = this;
			return <AttrShowIter>d__;
		}

		// Token: 0x06008ABF RID: 35519 RVA: 0x002709DC File Offset: 0x0026EBDC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DeathrattlesIter()或GetDeathrattlesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Deathrattles()
		{
			KurotatoMonster kurotatoMonster = this;
			return kurotatoMonster.GetDeathrattlesArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008AC0 RID: 35520 RVA: 0x00270A00 File Offset: 0x0026EC00
		[NullableContext(1)]
		public readonly IEnumerable<int> DeathrattlesIter()
		{
			KurotatoMonster.<DeathrattlesIter>d__52 <DeathrattlesIter>d__ = new KurotatoMonster.<DeathrattlesIter>d__52(-2);
			<DeathrattlesIter>d__.<>3__<>4__this = this;
			return <DeathrattlesIter>d__;
		}

		// Token: 0x06008AC1 RID: 35521 RVA: 0x00270A15 File Offset: 0x0026EC15
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescArgsIter()或GetDescArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescArgs()
		{
			return this.DescArgsIter().ToArray<string>();
		}

		// Token: 0x06008AC2 RID: 35522 RVA: 0x00270A22 File Offset: 0x0026EC22
		[NullableContext(1)]
		public readonly IEnumerable<string> DescArgsIter()
		{
			KurotatoMonster.<DescArgsIter>d__54 <DescArgsIter>d__ = new KurotatoMonster.<DescArgsIter>d__54(-2);
			<DescArgsIter>d__.<>3__<>4__this = this;
			return <DescArgsIter>d__;
		}

		// Token: 0x06008AC3 RID: 35523 RVA: 0x00270A38 File Offset: 0x0026EC38
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InitBuffsIter()或GetInitBuffsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InitBuffs()
		{
			KurotatoMonster kurotatoMonster = this;
			return kurotatoMonster.GetInitBuffsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008AC4 RID: 35524 RVA: 0x00270A5C File Offset: 0x0026EC5C
		[NullableContext(1)]
		public readonly IEnumerable<int> InitBuffsIter()
		{
			KurotatoMonster.<InitBuffsIter>d__56 <InitBuffsIter>d__ = new KurotatoMonster.<InitBuffsIter>d__56(-2);
			<InitBuffsIter>d__.<>3__<>4__this = this;
			return <InitBuffsIter>d__;
		}

		// Token: 0x06008AC5 RID: 35525 RVA: 0x00270A74 File Offset: 0x0026EC74
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TagIter()或GetTagBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Tag()
		{
			KurotatoMonster kurotatoMonster = this;
			return kurotatoMonster.GetTagArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008AC6 RID: 35526 RVA: 0x00270A98 File Offset: 0x0026EC98
		[NullableContext(1)]
		public readonly IEnumerable<int> TagIter()
		{
			KurotatoMonster.<TagIter>d__58 <TagIter>d__ = new KurotatoMonster.<TagIter>d__58(-2);
			<TagIter>d__.<>3__<>4__this = this;
			return <TagIter>d__;
		}

		// Token: 0x04004E3A RID: 20026
		private Table __p;
	}
}
