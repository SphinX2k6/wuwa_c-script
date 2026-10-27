using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D99 RID: 3481
	public struct KurotatoDeathrattle : IFlatbufferObject
	{
		// Token: 0x17001B3F RID: 6975
		// (get) Token: 0x06008918 RID: 35096 RVA: 0x0026CDA5 File Offset: 0x0026AFA5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008919 RID: 35097 RVA: 0x0026CDB2 File Offset: 0x0026AFB2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600891A RID: 35098 RVA: 0x0026CDBC File Offset: 0x0026AFBC
		public static KurotatoDeathrattle GetRootAsKurotatoDeathrattle(ByteBuffer _bb)
		{
			return KurotatoDeathrattle.GetRootAsKurotatoDeathrattle(_bb, default(KurotatoDeathrattle));
		}

		// Token: 0x0600891B RID: 35099 RVA: 0x0026CDD8 File Offset: 0x0026AFD8
		public static KurotatoDeathrattle GetRootAsKurotatoDeathrattle(ByteBuffer _bb, KurotatoDeathrattle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600891C RID: 35100 RVA: 0x0026CDF5 File Offset: 0x0026AFF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600891D RID: 35101 RVA: 0x0026CE04 File Offset: 0x0026B004
		public KurotatoDeathrattle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001B40 RID: 6976
		// (get) Token: 0x0600891E RID: 35102 RVA: 0x0026CE14 File Offset: 0x0026B014
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

		// Token: 0x17001B41 RID: 6977
		// (get) Token: 0x0600891F RID: 35103 RVA: 0x0026CE50 File Offset: 0x0026B050
		public int Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008920 RID: 35104 RVA: 0x0026CE8C File Offset: 0x0026B08C
		public int SpawnDrops(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B42 RID: 6978
		// (get) Token: 0x06008921 RID: 35105 RVA: 0x0026CECC File Offset: 0x0026B0CC
		public int SpawnDropsLength
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

		// Token: 0x06008922 RID: 35106 RVA: 0x0026CEF7 File Offset: 0x0026B0F7
		public Span<int> GetSpawnDropsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06008923 RID: 35107 RVA: 0x0026CF06 File Offset: 0x0026B106
		public int[] GetSpawnDropsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17001B43 RID: 6979
		// (get) Token: 0x06008924 RID: 35108 RVA: 0x0026CF20 File Offset: 0x0026B120
		public int SpawnDropProbability
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008925 RID: 35109 RVA: 0x0026CF60 File Offset: 0x0026B160
		public int SpawnMonsters(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B44 RID: 6980
		// (get) Token: 0x06008926 RID: 35110 RVA: 0x0026CFA0 File Offset: 0x0026B1A0
		public int SpawnMonstersLength
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

		// Token: 0x06008927 RID: 35111 RVA: 0x0026CFCC File Offset: 0x0026B1CC
		public Span<int> GetSpawnMonstersBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06008928 RID: 35112 RVA: 0x0026CFDC File Offset: 0x0026B1DC
		public int[] GetSpawnMonstersArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17001B45 RID: 6981
		// (get) Token: 0x06008929 RID: 35113 RVA: 0x0026CFF4 File Offset: 0x0026B1F4
		public int SpawnEntityRadius
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001B46 RID: 6982
		// (get) Token: 0x0600892A RID: 35114 RVA: 0x0026D034 File Offset: 0x0026B234
		public float SpawnEntityDelay
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600892B RID: 35115 RVA: 0x0026D078 File Offset: 0x0026B278
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpawnDropsIter()或GetSpawnDropsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SpawnDrops()
		{
			KurotatoDeathrattle kurotatoDeathrattle = this;
			return kurotatoDeathrattle.GetSpawnDropsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600892C RID: 35116 RVA: 0x0026D09C File Offset: 0x0026B29C
		[NullableContext(1)]
		public readonly IEnumerable<int> SpawnDropsIter()
		{
			KurotatoDeathrattle.<SpawnDropsIter>d__29 <SpawnDropsIter>d__ = new KurotatoDeathrattle.<SpawnDropsIter>d__29(-2);
			<SpawnDropsIter>d__.<>3__<>4__this = this;
			return <SpawnDropsIter>d__;
		}

		// Token: 0x0600892D RID: 35117 RVA: 0x0026D0B4 File Offset: 0x0026B2B4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpawnMonstersIter()或GetSpawnMonstersBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SpawnMonsters()
		{
			KurotatoDeathrattle kurotatoDeathrattle = this;
			return kurotatoDeathrattle.GetSpawnMonstersArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600892E RID: 35118 RVA: 0x0026D0D8 File Offset: 0x0026B2D8
		[NullableContext(1)]
		public readonly IEnumerable<int> SpawnMonstersIter()
		{
			KurotatoDeathrattle.<SpawnMonstersIter>d__31 <SpawnMonstersIter>d__ = new KurotatoDeathrattle.<SpawnMonstersIter>d__31(-2);
			<SpawnMonstersIter>d__.<>3__<>4__this = this;
			return <SpawnMonstersIter>d__;
		}

		// Token: 0x04004E29 RID: 20009
		private Table __p;
	}
}
