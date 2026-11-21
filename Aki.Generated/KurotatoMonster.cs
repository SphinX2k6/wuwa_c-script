using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E8D RID: 3725
	public struct KurotatoMonster : IFlatbufferObject
	{
		// Token: 0x17001C30 RID: 7216
		// (get) Token: 0x060090B6 RID: 37046 RVA: 0x0028EE58 File Offset: 0x0028D058
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060090B7 RID: 37047 RVA: 0x0028EE65 File Offset: 0x0028D065
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060090B8 RID: 37048 RVA: 0x0028EE6C File Offset: 0x0028D06C
		public static KurotatoMonster GetRootAsKurotatoMonster(ByteBuffer _bb)
		{
			return KurotatoMonster.GetRootAsKurotatoMonster(_bb, default(KurotatoMonster));
		}

		// Token: 0x060090B9 RID: 37049 RVA: 0x0028EE88 File Offset: 0x0028D088
		public static KurotatoMonster GetRootAsKurotatoMonster(ByteBuffer _bb, KurotatoMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060090BA RID: 37050 RVA: 0x0028EEA5 File Offset: 0x0028D0A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060090BB RID: 37051 RVA: 0x0028EEB4 File Offset: 0x0028D0B4
		public KurotatoMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C31 RID: 7217
		// (get) Token: 0x060090BC RID: 37052 RVA: 0x0028EEC4 File Offset: 0x0028D0C4
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

		// Token: 0x17001C32 RID: 7218
		// (get) Token: 0x060090BD RID: 37053 RVA: 0x0028EF00 File Offset: 0x0028D100
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

		// Token: 0x17001C33 RID: 7219
		// (get) Token: 0x060090BE RID: 37054 RVA: 0x0028EF3C File Offset: 0x0028D13C
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

		// Token: 0x060090BF RID: 37055 RVA: 0x0028EF73 File Offset: 0x0028D173
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060090C0 RID: 37056 RVA: 0x0028EF82 File Offset: 0x0028D182
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C34 RID: 7220
		// (get) Token: 0x060090C1 RID: 37057 RVA: 0x0028EF9C File Offset: 0x0028D19C
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

		// Token: 0x060090C2 RID: 37058 RVA: 0x0028EFD4 File Offset: 0x0028D1D4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060090C3 RID: 37059 RVA: 0x0028EFE4 File Offset: 0x0028D1E4
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x060090C4 RID: 37060 RVA: 0x0028EFFC File Offset: 0x0028D1FC
		public string DescArgs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C35 RID: 7221
		// (get) Token: 0x060090C5 RID: 37061 RVA: 0x0028F038 File Offset: 0x0028D238
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

		// Token: 0x17001C36 RID: 7222
		// (get) Token: 0x060090C6 RID: 37062 RVA: 0x0028F064 File Offset: 0x0028D264
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

		// Token: 0x17001C37 RID: 7223
		// (get) Token: 0x060090C7 RID: 37063 RVA: 0x0028F0A4 File Offset: 0x0028D2A4
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

		// Token: 0x060090C8 RID: 37064 RVA: 0x0028F0E4 File Offset: 0x0028D2E4
		public int InitBuffs(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C38 RID: 7224
		// (get) Token: 0x060090C9 RID: 37065 RVA: 0x0028F124 File Offset: 0x0028D324
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

		// Token: 0x060090CA RID: 37066 RVA: 0x0028F150 File Offset: 0x0028D350
		public Span<int> GetInitBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x060090CB RID: 37067 RVA: 0x0028F160 File Offset: 0x0028D360
		public int[] GetInitBuffsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x060090CC RID: 37068 RVA: 0x0028F178 File Offset: 0x0028D378
		public int Deathrattles(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C39 RID: 7225
		// (get) Token: 0x060090CD RID: 37069 RVA: 0x0028F1B8 File Offset: 0x0028D3B8
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

		// Token: 0x060090CE RID: 37070 RVA: 0x0028F1E4 File Offset: 0x0028D3E4
		public Span<int> GetDeathrattlesBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x060090CF RID: 37071 RVA: 0x0028F1F4 File Offset: 0x0028D3F4
		public int[] GetDeathrattlesArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x060090D0 RID: 37072 RVA: 0x0028F20C File Offset: 0x0028D40C
		public int Tag(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C3A RID: 7226
		// (get) Token: 0x060090D1 RID: 37073 RVA: 0x0028F24C File Offset: 0x0028D44C
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

		// Token: 0x060090D2 RID: 37074 RVA: 0x0028F278 File Offset: 0x0028D478
		public Span<int> GetTagBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x060090D3 RID: 37075 RVA: 0x0028F288 File Offset: 0x0028D488
		public int[] GetTagArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x060090D4 RID: 37076 RVA: 0x0028F2A0 File Offset: 0x0028D4A0
		public int AttrShow(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C3B RID: 7227
		// (get) Token: 0x060090D5 RID: 37077 RVA: 0x0028F2E0 File Offset: 0x0028D4E0
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

		// Token: 0x060090D6 RID: 37078 RVA: 0x0028F30C File Offset: 0x0028D50C
		public Span<int> GetAttrShowBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x060090D7 RID: 37079 RVA: 0x0028F31C File Offset: 0x0028D51C
		public int[] GetAttrShowArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x17001C3C RID: 7228
		// (get) Token: 0x060090D8 RID: 37080 RVA: 0x0028F334 File Offset: 0x0028D534
		public bool IsHideInBook
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060090D9 RID: 37081 RVA: 0x0028F374 File Offset: 0x0028D574
		[NullableContext(1)]
		public int[] AttrShow()
		{
			return this.GetAttrShowArray();
		}

		// Token: 0x060090DA RID: 37082 RVA: 0x0028F37C File Offset: 0x0028D57C
		[NullableContext(1)]
		public IEnumerable<int> AttrShowIter()
		{
			KurotatoMonster.<AttrShowIter>d__50 <AttrShowIter>d__ = new KurotatoMonster.<AttrShowIter>d__50(-2);
			<AttrShowIter>d__.<>3__<>4__this = this;
			return <AttrShowIter>d__;
		}

		// Token: 0x060090DB RID: 37083 RVA: 0x0028F391 File Offset: 0x0028D591
		[NullableContext(1)]
		public int[] Deathrattles()
		{
			return this.GetDeathrattlesArray();
		}

		// Token: 0x060090DC RID: 37084 RVA: 0x0028F399 File Offset: 0x0028D599
		[NullableContext(1)]
		public IEnumerable<int> DeathrattlesIter()
		{
			KurotatoMonster.<DeathrattlesIter>d__52 <DeathrattlesIter>d__ = new KurotatoMonster.<DeathrattlesIter>d__52(-2);
			<DeathrattlesIter>d__.<>3__<>4__this = this;
			return <DeathrattlesIter>d__;
		}

		// Token: 0x060090DD RID: 37085 RVA: 0x0028F3AE File Offset: 0x0028D5AE
		[NullableContext(1)]
		public string[] DescArgs()
		{
			return this.DescArgsIter().ToArray<string>();
		}

		// Token: 0x060090DE RID: 37086 RVA: 0x0028F3BB File Offset: 0x0028D5BB
		[NullableContext(1)]
		public IEnumerable<string> DescArgsIter()
		{
			KurotatoMonster.<DescArgsIter>d__54 <DescArgsIter>d__ = new KurotatoMonster.<DescArgsIter>d__54(-2);
			<DescArgsIter>d__.<>3__<>4__this = this;
			return <DescArgsIter>d__;
		}

		// Token: 0x060090DF RID: 37087 RVA: 0x0028F3D0 File Offset: 0x0028D5D0
		[NullableContext(1)]
		public int[] InitBuffs()
		{
			return this.GetInitBuffsArray();
		}

		// Token: 0x060090E0 RID: 37088 RVA: 0x0028F3D8 File Offset: 0x0028D5D8
		[NullableContext(1)]
		public IEnumerable<int> InitBuffsIter()
		{
			KurotatoMonster.<InitBuffsIter>d__56 <InitBuffsIter>d__ = new KurotatoMonster.<InitBuffsIter>d__56(-2);
			<InitBuffsIter>d__.<>3__<>4__this = this;
			return <InitBuffsIter>d__;
		}

		// Token: 0x060090E1 RID: 37089 RVA: 0x0028F3ED File Offset: 0x0028D5ED
		[NullableContext(1)]
		public int[] Tag()
		{
			return this.GetTagArray();
		}

		// Token: 0x060090E2 RID: 37090 RVA: 0x0028F3F5 File Offset: 0x0028D5F5
		[NullableContext(1)]
		public IEnumerable<int> TagIter()
		{
			KurotatoMonster.<TagIter>d__58 <TagIter>d__ = new KurotatoMonster.<TagIter>d__58(-2);
			<TagIter>d__.<>3__<>4__this = this;
			return <TagIter>d__;
		}

		// Token: 0x0400541F RID: 21535
		private Table __p;
	}
}
