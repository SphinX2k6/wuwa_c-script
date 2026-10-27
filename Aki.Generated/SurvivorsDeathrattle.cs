using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010F9 RID: 4345
	public struct SurvivorsDeathrattle : IFlatbufferObject
	{
		// Token: 0x170038B4 RID: 14516
		// (get) Token: 0x0600DA44 RID: 55876 RVA: 0x003235F1 File Offset: 0x003217F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DA45 RID: 55877 RVA: 0x003235FE File Offset: 0x003217FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DA46 RID: 55878 RVA: 0x00323608 File Offset: 0x00321808
		public static SurvivorsDeathrattle GetRootAsSurvivorsDeathrattle(ByteBuffer _bb)
		{
			return SurvivorsDeathrattle.GetRootAsSurvivorsDeathrattle(_bb, default(SurvivorsDeathrattle));
		}

		// Token: 0x0600DA47 RID: 55879 RVA: 0x00323624 File Offset: 0x00321824
		public static SurvivorsDeathrattle GetRootAsSurvivorsDeathrattle(ByteBuffer _bb, SurvivorsDeathrattle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DA48 RID: 55880 RVA: 0x00323641 File Offset: 0x00321841
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DA49 RID: 55881 RVA: 0x00323650 File Offset: 0x00321850
		public SurvivorsDeathrattle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170038B5 RID: 14517
		// (get) Token: 0x0600DA4A RID: 55882 RVA: 0x00323660 File Offset: 0x00321860
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

		// Token: 0x170038B6 RID: 14518
		// (get) Token: 0x0600DA4B RID: 55883 RVA: 0x0032369C File Offset: 0x0032189C
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

		// Token: 0x170038B7 RID: 14519
		// (get) Token: 0x0600DA4C RID: 55884 RVA: 0x003236D8 File Offset: 0x003218D8
		public int NearbyMonsterRadius
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

		// Token: 0x0600DA4D RID: 55885 RVA: 0x00323714 File Offset: 0x00321914
		public int NearbyMonsterBuffs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170038B8 RID: 14520
		// (get) Token: 0x0600DA4E RID: 55886 RVA: 0x00323754 File Offset: 0x00321954
		public int NearbyMonsterBuffsLength
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

		// Token: 0x0600DA4F RID: 55887 RVA: 0x00323780 File Offset: 0x00321980
		public Span<int> GetNearbyMonsterBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600DA50 RID: 55888 RVA: 0x00323790 File Offset: 0x00321990
		public int[] GetNearbyMonsterBuffsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170038B9 RID: 14521
		// (get) Token: 0x0600DA51 RID: 55889 RVA: 0x003237A8 File Offset: 0x003219A8
		public int PolluteRadius
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

		// Token: 0x0600DA52 RID: 55890 RVA: 0x003237E8 File Offset: 0x003219E8
		public int SpawnMonsters(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170038BA RID: 14522
		// (get) Token: 0x0600DA53 RID: 55891 RVA: 0x00323828 File Offset: 0x00321A28
		public int SpawnMonstersLength
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

		// Token: 0x0600DA54 RID: 55892 RVA: 0x00323854 File Offset: 0x00321A54
		public Span<int> GetSpawnMonstersBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600DA55 RID: 55893 RVA: 0x00323864 File Offset: 0x00321A64
		public int[] GetSpawnMonstersArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600DA56 RID: 55894 RVA: 0x0032387C File Offset: 0x00321A7C
		public int SpawnGoldenCoins(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170038BB RID: 14523
		// (get) Token: 0x0600DA57 RID: 55895 RVA: 0x003238BC File Offset: 0x00321ABC
		public int SpawnGoldenCoinsLength
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

		// Token: 0x0600DA58 RID: 55896 RVA: 0x003238E8 File Offset: 0x00321AE8
		public Span<int> GetSpawnGoldenCoinsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600DA59 RID: 55897 RVA: 0x003238F8 File Offset: 0x00321AF8
		public int[] GetSpawnGoldenCoinsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x170038BC RID: 14524
		// (get) Token: 0x0600DA5A RID: 55898 RVA: 0x00323910 File Offset: 0x00321B10
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

		// Token: 0x170038BD RID: 14525
		// (get) Token: 0x0600DA5B RID: 55899 RVA: 0x00323950 File Offset: 0x00321B50
		public int Effect
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

		// Token: 0x0600DA5C RID: 55900 RVA: 0x00323990 File Offset: 0x00321B90
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用NearbyMonsterBuffsIter()或GetNearbyMonsterBuffsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] NearbyMonsterBuffs()
		{
			SurvivorsDeathrattle survivorsDeathrattle = this;
			return survivorsDeathrattle.GetNearbyMonsterBuffsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DA5D RID: 55901 RVA: 0x003239B4 File Offset: 0x00321BB4
		[NullableContext(1)]
		public readonly IEnumerable<int> NearbyMonsterBuffsIter()
		{
			SurvivorsDeathrattle.<NearbyMonsterBuffsIter>d__36 <NearbyMonsterBuffsIter>d__ = new SurvivorsDeathrattle.<NearbyMonsterBuffsIter>d__36(-2);
			<NearbyMonsterBuffsIter>d__.<>3__<>4__this = this;
			return <NearbyMonsterBuffsIter>d__;
		}

		// Token: 0x0600DA5E RID: 55902 RVA: 0x003239CC File Offset: 0x00321BCC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpawnGoldenCoinsIter()或GetSpawnGoldenCoinsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SpawnGoldenCoins()
		{
			SurvivorsDeathrattle survivorsDeathrattle = this;
			return survivorsDeathrattle.GetSpawnGoldenCoinsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DA5F RID: 55903 RVA: 0x003239F0 File Offset: 0x00321BF0
		[NullableContext(1)]
		public readonly IEnumerable<int> SpawnGoldenCoinsIter()
		{
			SurvivorsDeathrattle.<SpawnGoldenCoinsIter>d__38 <SpawnGoldenCoinsIter>d__ = new SurvivorsDeathrattle.<SpawnGoldenCoinsIter>d__38(-2);
			<SpawnGoldenCoinsIter>d__.<>3__<>4__this = this;
			return <SpawnGoldenCoinsIter>d__;
		}

		// Token: 0x0600DA60 RID: 55904 RVA: 0x00323A08 File Offset: 0x00321C08
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpawnMonstersIter()或GetSpawnMonstersBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SpawnMonsters()
		{
			SurvivorsDeathrattle survivorsDeathrattle = this;
			return survivorsDeathrattle.GetSpawnMonstersArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DA61 RID: 55905 RVA: 0x00323A2C File Offset: 0x00321C2C
		[NullableContext(1)]
		public readonly IEnumerable<int> SpawnMonstersIter()
		{
			SurvivorsDeathrattle.<SpawnMonstersIter>d__40 <SpawnMonstersIter>d__ = new SurvivorsDeathrattle.<SpawnMonstersIter>d__40(-2);
			<SpawnMonstersIter>d__.<>3__<>4__this = this;
			return <SpawnMonstersIter>d__;
		}

		// Token: 0x0400522F RID: 21039
		private Table __p;
	}
}
