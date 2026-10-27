using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001166 RID: 4454
	public struct TrapDefenseMonster : IFlatbufferObject
	{
		// Token: 0x17003C4A RID: 15434
		// (get) Token: 0x0600E3F9 RID: 58361 RVA: 0x00339859 File Offset: 0x00337A59
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E3FA RID: 58362 RVA: 0x00339866 File Offset: 0x00337A66
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E3FB RID: 58363 RVA: 0x00339870 File Offset: 0x00337A70
		public static TrapDefenseMonster GetRootAsTrapDefenseMonster(ByteBuffer _bb)
		{
			return TrapDefenseMonster.GetRootAsTrapDefenseMonster(_bb, default(TrapDefenseMonster));
		}

		// Token: 0x0600E3FC RID: 58364 RVA: 0x0033988C File Offset: 0x00337A8C
		public static TrapDefenseMonster GetRootAsTrapDefenseMonster(ByteBuffer _bb, TrapDefenseMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E3FD RID: 58365 RVA: 0x003398A9 File Offset: 0x00337AA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E3FE RID: 58366 RVA: 0x003398B8 File Offset: 0x00337AB8
		public TrapDefenseMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C4B RID: 15435
		// (get) Token: 0x0600E3FF RID: 58367 RVA: 0x003398C8 File Offset: 0x00337AC8
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

		// Token: 0x17003C4C RID: 15436
		// (get) Token: 0x0600E400 RID: 58368 RVA: 0x00339904 File Offset: 0x00337B04
		public string Name
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

		// Token: 0x0600E401 RID: 58369 RVA: 0x0033993B File Offset: 0x00337B3B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E402 RID: 58370 RVA: 0x0033994A File Offset: 0x00337B4A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C4D RID: 15437
		// (get) Token: 0x0600E403 RID: 58371 RVA: 0x00339964 File Offset: 0x00337B64
		public string Desc
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

		// Token: 0x0600E404 RID: 58372 RVA: 0x0033999B File Offset: 0x00337B9B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E405 RID: 58373 RVA: 0x003399AA File Offset: 0x00337BAA
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E406 RID: 58374 RVA: 0x003399C4 File Offset: 0x00337BC4
		public string DescArgs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C4E RID: 15438
		// (get) Token: 0x0600E407 RID: 58375 RVA: 0x00339A00 File Offset: 0x00337C00
		public int DescArgsLength
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

		// Token: 0x17003C4F RID: 15439
		// (get) Token: 0x0600E408 RID: 58376 RVA: 0x00339A2C File Offset: 0x00337C2C
		public int MonsterType
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

		// Token: 0x17003C50 RID: 15440
		// (get) Token: 0x0600E409 RID: 58377 RVA: 0x00339A6C File Offset: 0x00337C6C
		public int SimpleCombatSubtypeId
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

		// Token: 0x0600E40A RID: 58378 RVA: 0x00339AAC File Offset: 0x00337CAC
		public int InitBuffs(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C51 RID: 15441
		// (get) Token: 0x0600E40B RID: 58379 RVA: 0x00339AEC File Offset: 0x00337CEC
		public int InitBuffsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E40C RID: 58380 RVA: 0x00339B18 File Offset: 0x00337D18
		public Span<int> GetInitBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600E40D RID: 58381 RVA: 0x00339B28 File Offset: 0x00337D28
		public int[] GetInitBuffsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17003C52 RID: 15442
		// (get) Token: 0x0600E40E RID: 58382 RVA: 0x00339B40 File Offset: 0x00337D40
		public int DropGold
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

		// Token: 0x17003C53 RID: 15443
		// (get) Token: 0x0600E40F RID: 58383 RVA: 0x00339B80 File Offset: 0x00337D80
		public int Deathrattle
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

		// Token: 0x17003C54 RID: 15444
		// (get) Token: 0x0600E410 RID: 58384 RVA: 0x00339BC0 File Offset: 0x00337DC0
		public int CampDamage
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E411 RID: 58385 RVA: 0x00339C00 File Offset: 0x00337E00
		public int Tag(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C55 RID: 15445
		// (get) Token: 0x0600E412 RID: 58386 RVA: 0x00339C40 File Offset: 0x00337E40
		public int TagLength
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

		// Token: 0x0600E413 RID: 58387 RVA: 0x00339C6C File Offset: 0x00337E6C
		public Span<int> GetTagBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600E414 RID: 58388 RVA: 0x00339C7C File Offset: 0x00337E7C
		public int[] GetTagArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x0600E415 RID: 58389 RVA: 0x00339C94 File Offset: 0x00337E94
		public string TagDesc(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C56 RID: 15446
		// (get) Token: 0x0600E416 RID: 58390 RVA: 0x00339CD0 File Offset: 0x00337ED0
		public int TagDescLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E417 RID: 58391 RVA: 0x00339CFC File Offset: 0x00337EFC
		public int AttrShow(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C57 RID: 15447
		// (get) Token: 0x0600E418 RID: 58392 RVA: 0x00339D3C File Offset: 0x00337F3C
		public int AttrShowLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E419 RID: 58393 RVA: 0x00339D68 File Offset: 0x00337F68
		public Span<int> GetAttrShowBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600E41A RID: 58394 RVA: 0x00339D78 File Offset: 0x00337F78
		public int[] GetAttrShowArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x17003C58 RID: 15448
		// (get) Token: 0x0600E41B RID: 58395 RVA: 0x00339D90 File Offset: 0x00337F90
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E41C RID: 58396 RVA: 0x00339DD0 File Offset: 0x00337FD0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AttrShowIter()或GetAttrShowBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AttrShow()
		{
			TrapDefenseMonster trapDefenseMonster = this;
			return trapDefenseMonster.GetAttrShowArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E41D RID: 58397 RVA: 0x00339DF4 File Offset: 0x00337FF4
		[NullableContext(1)]
		public readonly IEnumerable<int> AttrShowIter()
		{
			TrapDefenseMonster.<AttrShowIter>d__52 <AttrShowIter>d__ = new TrapDefenseMonster.<AttrShowIter>d__52(-2);
			<AttrShowIter>d__.<>3__<>4__this = this;
			return <AttrShowIter>d__;
		}

		// Token: 0x0600E41E RID: 58398 RVA: 0x00339E09 File Offset: 0x00338009
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescArgsIter()或GetDescArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescArgs()
		{
			return this.DescArgsIter().ToArray<string>();
		}

		// Token: 0x0600E41F RID: 58399 RVA: 0x00339E16 File Offset: 0x00338016
		[NullableContext(1)]
		public readonly IEnumerable<string> DescArgsIter()
		{
			TrapDefenseMonster.<DescArgsIter>d__54 <DescArgsIter>d__ = new TrapDefenseMonster.<DescArgsIter>d__54(-2);
			<DescArgsIter>d__.<>3__<>4__this = this;
			return <DescArgsIter>d__;
		}

		// Token: 0x0600E420 RID: 58400 RVA: 0x00339E2C File Offset: 0x0033802C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InitBuffsIter()或GetInitBuffsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InitBuffs()
		{
			TrapDefenseMonster trapDefenseMonster = this;
			return trapDefenseMonster.GetInitBuffsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E421 RID: 58401 RVA: 0x00339E50 File Offset: 0x00338050
		[NullableContext(1)]
		public readonly IEnumerable<int> InitBuffsIter()
		{
			TrapDefenseMonster.<InitBuffsIter>d__56 <InitBuffsIter>d__ = new TrapDefenseMonster.<InitBuffsIter>d__56(-2);
			<InitBuffsIter>d__.<>3__<>4__this = this;
			return <InitBuffsIter>d__;
		}

		// Token: 0x0600E422 RID: 58402 RVA: 0x00339E68 File Offset: 0x00338068
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TagIter()或GetTagBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Tag()
		{
			TrapDefenseMonster trapDefenseMonster = this;
			return trapDefenseMonster.GetTagArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E423 RID: 58403 RVA: 0x00339E8C File Offset: 0x0033808C
		[NullableContext(1)]
		public readonly IEnumerable<int> TagIter()
		{
			TrapDefenseMonster.<TagIter>d__58 <TagIter>d__ = new TrapDefenseMonster.<TagIter>d__58(-2);
			<TagIter>d__.<>3__<>4__this = this;
			return <TagIter>d__;
		}

		// Token: 0x0600E424 RID: 58404 RVA: 0x00339EA1 File Offset: 0x003380A1
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TagDescIter()或GetTagDescBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] TagDesc()
		{
			return this.TagDescIter().ToArray<string>();
		}

		// Token: 0x0600E425 RID: 58405 RVA: 0x00339EAE File Offset: 0x003380AE
		[NullableContext(1)]
		public readonly IEnumerable<string> TagDescIter()
		{
			TrapDefenseMonster.<TagDescIter>d__60 <TagDescIter>d__ = new TrapDefenseMonster.<TagDescIter>d__60(-2);
			<TagDescIter>d__.<>3__<>4__this = this;
			return <TagDescIter>d__;
		}

		// Token: 0x040052AC RID: 21164
		private Table __p;
	}
}
