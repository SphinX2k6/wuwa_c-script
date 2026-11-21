using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200122F RID: 4655
	public struct SurvivorsDeathrattle : IFlatbufferObject
	{
		// Token: 0x17003C0A RID: 15370
		// (get) Token: 0x0600E78F RID: 59279 RVA: 0x0034EA28 File Offset: 0x0034CC28
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E790 RID: 59280 RVA: 0x0034EA35 File Offset: 0x0034CC35
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E791 RID: 59281 RVA: 0x0034EA3C File Offset: 0x0034CC3C
		public static SurvivorsDeathrattle GetRootAsSurvivorsDeathrattle(ByteBuffer _bb)
		{
			return SurvivorsDeathrattle.GetRootAsSurvivorsDeathrattle(_bb, default(SurvivorsDeathrattle));
		}

		// Token: 0x0600E792 RID: 59282 RVA: 0x0034EA58 File Offset: 0x0034CC58
		public static SurvivorsDeathrattle GetRootAsSurvivorsDeathrattle(ByteBuffer _bb, SurvivorsDeathrattle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E793 RID: 59283 RVA: 0x0034EA75 File Offset: 0x0034CC75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E794 RID: 59284 RVA: 0x0034EA84 File Offset: 0x0034CC84
		public SurvivorsDeathrattle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C0B RID: 15371
		// (get) Token: 0x0600E795 RID: 59285 RVA: 0x0034EA94 File Offset: 0x0034CC94
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

		// Token: 0x17003C0C RID: 15372
		// (get) Token: 0x0600E796 RID: 59286 RVA: 0x0034EAD0 File Offset: 0x0034CCD0
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

		// Token: 0x17003C0D RID: 15373
		// (get) Token: 0x0600E797 RID: 59287 RVA: 0x0034EB0C File Offset: 0x0034CD0C
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

		// Token: 0x0600E798 RID: 59288 RVA: 0x0034EB48 File Offset: 0x0034CD48
		public int NearbyMonsterBuffs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C0E RID: 15374
		// (get) Token: 0x0600E799 RID: 59289 RVA: 0x0034EB88 File Offset: 0x0034CD88
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

		// Token: 0x0600E79A RID: 59290 RVA: 0x0034EBB4 File Offset: 0x0034CDB4
		public Span<int> GetNearbyMonsterBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600E79B RID: 59291 RVA: 0x0034EBC4 File Offset: 0x0034CDC4
		public int[] GetNearbyMonsterBuffsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17003C0F RID: 15375
		// (get) Token: 0x0600E79C RID: 59292 RVA: 0x0034EBDC File Offset: 0x0034CDDC
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

		// Token: 0x0600E79D RID: 59293 RVA: 0x0034EC1C File Offset: 0x0034CE1C
		public int SpawnMonsters(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C10 RID: 15376
		// (get) Token: 0x0600E79E RID: 59294 RVA: 0x0034EC5C File Offset: 0x0034CE5C
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

		// Token: 0x0600E79F RID: 59295 RVA: 0x0034EC88 File Offset: 0x0034CE88
		public Span<int> GetSpawnMonstersBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600E7A0 RID: 59296 RVA: 0x0034EC98 File Offset: 0x0034CE98
		public int[] GetSpawnMonstersArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600E7A1 RID: 59297 RVA: 0x0034ECB0 File Offset: 0x0034CEB0
		public int SpawnGoldenCoins(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C11 RID: 15377
		// (get) Token: 0x0600E7A2 RID: 59298 RVA: 0x0034ECF0 File Offset: 0x0034CEF0
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

		// Token: 0x0600E7A3 RID: 59299 RVA: 0x0034ED1C File Offset: 0x0034CF1C
		public Span<int> GetSpawnGoldenCoinsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600E7A4 RID: 59300 RVA: 0x0034ED2C File Offset: 0x0034CF2C
		public int[] GetSpawnGoldenCoinsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17003C12 RID: 15378
		// (get) Token: 0x0600E7A5 RID: 59301 RVA: 0x0034ED44 File Offset: 0x0034CF44
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

		// Token: 0x17003C13 RID: 15379
		// (get) Token: 0x0600E7A6 RID: 59302 RVA: 0x0034ED84 File Offset: 0x0034CF84
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

		// Token: 0x0600E7A7 RID: 59303 RVA: 0x0034EDC1 File Offset: 0x0034CFC1
		[NullableContext(1)]
		public int[] NearbyMonsterBuffs()
		{
			return this.GetNearbyMonsterBuffsArray();
		}

		// Token: 0x0600E7A8 RID: 59304 RVA: 0x0034EDC9 File Offset: 0x0034CFC9
		[NullableContext(1)]
		public IEnumerable<int> NearbyMonsterBuffsIter()
		{
			SurvivorsDeathrattle.<NearbyMonsterBuffsIter>d__36 <NearbyMonsterBuffsIter>d__ = new SurvivorsDeathrattle.<NearbyMonsterBuffsIter>d__36(-2);
			<NearbyMonsterBuffsIter>d__.<>3__<>4__this = this;
			return <NearbyMonsterBuffsIter>d__;
		}

		// Token: 0x0600E7A9 RID: 59305 RVA: 0x0034EDDE File Offset: 0x0034CFDE
		[NullableContext(1)]
		public int[] SpawnGoldenCoins()
		{
			return this.GetSpawnGoldenCoinsArray();
		}

		// Token: 0x0600E7AA RID: 59306 RVA: 0x0034EDE6 File Offset: 0x0034CFE6
		[NullableContext(1)]
		public IEnumerable<int> SpawnGoldenCoinsIter()
		{
			SurvivorsDeathrattle.<SpawnGoldenCoinsIter>d__38 <SpawnGoldenCoinsIter>d__ = new SurvivorsDeathrattle.<SpawnGoldenCoinsIter>d__38(-2);
			<SpawnGoldenCoinsIter>d__.<>3__<>4__this = this;
			return <SpawnGoldenCoinsIter>d__;
		}

		// Token: 0x0600E7AB RID: 59307 RVA: 0x0034EDFB File Offset: 0x0034CFFB
		[NullableContext(1)]
		public int[] SpawnMonsters()
		{
			return this.GetSpawnMonstersArray();
		}

		// Token: 0x0600E7AC RID: 59308 RVA: 0x0034EE03 File Offset: 0x0034D003
		[NullableContext(1)]
		public IEnumerable<int> SpawnMonstersIter()
		{
			SurvivorsDeathrattle.<SpawnMonstersIter>d__40 <SpawnMonstersIter>d__ = new SurvivorsDeathrattle.<SpawnMonstersIter>d__40(-2);
			<SpawnMonstersIter>d__.<>3__<>4__this = this;
			return <SpawnMonstersIter>d__;
		}

		// Token: 0x04005872 RID: 22642
		private Table __p;
	}
}
