using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C09 RID: 3081
	public struct DrinksRoleLikeDrink : IFlatbufferObject
	{
		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x060064F9 RID: 25849 RVA: 0x00219F79 File Offset: 0x00218179
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060064FA RID: 25850 RVA: 0x00219F86 File Offset: 0x00218186
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060064FB RID: 25851 RVA: 0x00219F90 File Offset: 0x00218190
		public static DrinksRoleLikeDrink GetRootAsDrinksRoleLikeDrink(ByteBuffer _bb)
		{
			return DrinksRoleLikeDrink.GetRootAsDrinksRoleLikeDrink(_bb, default(DrinksRoleLikeDrink));
		}

		// Token: 0x060064FC RID: 25852 RVA: 0x00219FAC File Offset: 0x002181AC
		public static DrinksRoleLikeDrink GetRootAsDrinksRoleLikeDrink(ByteBuffer _bb, DrinksRoleLikeDrink obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060064FD RID: 25853 RVA: 0x00219FC9 File Offset: 0x002181C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060064FE RID: 25854 RVA: 0x00219FD8 File Offset: 0x002181D8
		public DrinksRoleLikeDrink __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x060064FF RID: 25855 RVA: 0x00219FE8 File Offset: 0x002181E8
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

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06006500 RID: 25856 RVA: 0x0021A024 File Offset: 0x00218224
		public bool LikeStatus
		{
			get
			{
				int num = this.__p.__offset(6);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06006501 RID: 25857 RVA: 0x0021A064 File Offset: 0x00218264
		public int LinkDrinkBase(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06006502 RID: 25858 RVA: 0x0021A0A4 File Offset: 0x002182A4
		public int LinkDrinkBaseLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006503 RID: 25859 RVA: 0x0021A0CF File Offset: 0x002182CF
		public Span<int> GetLinkDrinkBaseBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06006504 RID: 25860 RVA: 0x0021A0DE File Offset: 0x002182DE
		public int[] GetLinkDrinkBaseArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06006505 RID: 25861 RVA: 0x0021A0F8 File Offset: 0x002182F8
		public int DrinkLikePoint
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

		// Token: 0x06006506 RID: 25862 RVA: 0x0021A138 File Offset: 0x00218338
		public int LinkOrnament(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x06006507 RID: 25863 RVA: 0x0021A178 File Offset: 0x00218378
		public int LinkOrnamentLength
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

		// Token: 0x06006508 RID: 25864 RVA: 0x0021A1A4 File Offset: 0x002183A4
		public Span<int> GetLinkOrnamentBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06006509 RID: 25865 RVA: 0x0021A1B4 File Offset: 0x002183B4
		public int[] GetLinkOrnamentArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x0600650A RID: 25866 RVA: 0x0021A1CC File Offset: 0x002183CC
		public int OrnamentLikePoint
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

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x0600650B RID: 25867 RVA: 0x0021A20C File Offset: 0x0021840C
		public string OrnamentHintId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600650C RID: 25868 RVA: 0x0021A244 File Offset: 0x00218444
		public Span<byte> GetOrnamentHintIdBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600650D RID: 25869 RVA: 0x0021A254 File Offset: 0x00218454
		public byte[] GetOrnamentHintIdArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600650E RID: 25870 RVA: 0x0021A26C File Offset: 0x0021846C
		public int LinkBatching(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x0600650F RID: 25871 RVA: 0x0021A2AC File Offset: 0x002184AC
		public int LinkBatchingLength
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

		// Token: 0x06006510 RID: 25872 RVA: 0x0021A2D8 File Offset: 0x002184D8
		public Span<int> GetLinkBatchingBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06006511 RID: 25873 RVA: 0x0021A2E8 File Offset: 0x002184E8
		public int[] GetLinkBatchingArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06006512 RID: 25874 RVA: 0x0021A300 File Offset: 0x00218500
		public int BatchingLikePoint
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006513 RID: 25875 RVA: 0x0021A340 File Offset: 0x00218540
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LinkBatchingIter()或GetLinkBatchingBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LinkBatching()
		{
			DrinksRoleLikeDrink drinksRoleLikeDrink = this;
			return drinksRoleLikeDrink.GetLinkBatchingArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006514 RID: 25876 RVA: 0x0021A364 File Offset: 0x00218564
		[NullableContext(1)]
		public readonly IEnumerable<int> LinkBatchingIter()
		{
			DrinksRoleLikeDrink.<LinkBatchingIter>d__38 <LinkBatchingIter>d__ = new DrinksRoleLikeDrink.<LinkBatchingIter>d__38(-2);
			<LinkBatchingIter>d__.<>3__<>4__this = this;
			return <LinkBatchingIter>d__;
		}

		// Token: 0x06006515 RID: 25877 RVA: 0x0021A37C File Offset: 0x0021857C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LinkDrinkBaseIter()或GetLinkDrinkBaseBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LinkDrinkBase()
		{
			DrinksRoleLikeDrink drinksRoleLikeDrink = this;
			return drinksRoleLikeDrink.GetLinkDrinkBaseArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006516 RID: 25878 RVA: 0x0021A3A0 File Offset: 0x002185A0
		[NullableContext(1)]
		public readonly IEnumerable<int> LinkDrinkBaseIter()
		{
			DrinksRoleLikeDrink.<LinkDrinkBaseIter>d__40 <LinkDrinkBaseIter>d__ = new DrinksRoleLikeDrink.<LinkDrinkBaseIter>d__40(-2);
			<LinkDrinkBaseIter>d__.<>3__<>4__this = this;
			return <LinkDrinkBaseIter>d__;
		}

		// Token: 0x06006517 RID: 25879 RVA: 0x0021A3B8 File Offset: 0x002185B8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LinkOrnamentIter()或GetLinkOrnamentBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LinkOrnament()
		{
			DrinksRoleLikeDrink drinksRoleLikeDrink = this;
			return drinksRoleLikeDrink.GetLinkOrnamentArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006518 RID: 25880 RVA: 0x0021A3DC File Offset: 0x002185DC
		[NullableContext(1)]
		public readonly IEnumerable<int> LinkOrnamentIter()
		{
			DrinksRoleLikeDrink.<LinkOrnamentIter>d__42 <LinkOrnamentIter>d__ = new DrinksRoleLikeDrink.<LinkOrnamentIter>d__42(-2);
			<LinkOrnamentIter>d__.<>3__<>4__this = this;
			return <LinkOrnamentIter>d__;
		}

		// Token: 0x04004C45 RID: 19525
		private Table __p;
	}
}
