using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001160 RID: 4448
	public struct TrapDefenseDeathrattle : IFlatbufferObject
	{
		// Token: 0x17003C19 RID: 15385
		// (get) Token: 0x0600E35B RID: 58203 RVA: 0x00338201 File Offset: 0x00336401
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E35C RID: 58204 RVA: 0x0033820E File Offset: 0x0033640E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E35D RID: 58205 RVA: 0x00338218 File Offset: 0x00336418
		public static TrapDefenseDeathrattle GetRootAsTrapDefenseDeathrattle(ByteBuffer _bb)
		{
			return TrapDefenseDeathrattle.GetRootAsTrapDefenseDeathrattle(_bb, default(TrapDefenseDeathrattle));
		}

		// Token: 0x0600E35E RID: 58206 RVA: 0x00338234 File Offset: 0x00336434
		public static TrapDefenseDeathrattle GetRootAsTrapDefenseDeathrattle(ByteBuffer _bb, TrapDefenseDeathrattle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E35F RID: 58207 RVA: 0x00338251 File Offset: 0x00336451
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E360 RID: 58208 RVA: 0x00338260 File Offset: 0x00336460
		public TrapDefenseDeathrattle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C1A RID: 15386
		// (get) Token: 0x0600E361 RID: 58209 RVA: 0x00338270 File Offset: 0x00336470
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

		// Token: 0x17003C1B RID: 15387
		// (get) Token: 0x0600E362 RID: 58210 RVA: 0x003382AC File Offset: 0x003364AC
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

		// Token: 0x17003C1C RID: 15388
		// (get) Token: 0x0600E363 RID: 58211 RVA: 0x003382E8 File Offset: 0x003364E8
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

		// Token: 0x0600E364 RID: 58212 RVA: 0x00338324 File Offset: 0x00336524
		public int NearbyMonsterBuffs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C1D RID: 15389
		// (get) Token: 0x0600E365 RID: 58213 RVA: 0x00338364 File Offset: 0x00336564
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

		// Token: 0x0600E366 RID: 58214 RVA: 0x00338390 File Offset: 0x00336590
		public Span<int> GetNearbyMonsterBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600E367 RID: 58215 RVA: 0x003383A0 File Offset: 0x003365A0
		public int[] GetNearbyMonsterBuffsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17003C1E RID: 15390
		// (get) Token: 0x0600E368 RID: 58216 RVA: 0x003383B8 File Offset: 0x003365B8
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

		// Token: 0x17003C1F RID: 15391
		// (get) Token: 0x0600E369 RID: 58217 RVA: 0x003383F8 File Offset: 0x003365F8
		public int PolluteCellCount
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

		// Token: 0x0600E36A RID: 58218 RVA: 0x00338438 File Offset: 0x00336638
		public int SpawnMonsters(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C20 RID: 15392
		// (get) Token: 0x0600E36B RID: 58219 RVA: 0x00338478 File Offset: 0x00336678
		public int SpawnMonstersLength
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

		// Token: 0x0600E36C RID: 58220 RVA: 0x003384A4 File Offset: 0x003366A4
		public Span<int> GetSpawnMonstersBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600E36D RID: 58221 RVA: 0x003384B4 File Offset: 0x003366B4
		public int[] GetSpawnMonstersArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600E36E RID: 58222 RVA: 0x003384CC File Offset: 0x003366CC
		public int SpawnGoldenCoins(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C21 RID: 15393
		// (get) Token: 0x0600E36F RID: 58223 RVA: 0x0033850C File Offset: 0x0033670C
		public int SpawnGoldenCoinsLength
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

		// Token: 0x0600E370 RID: 58224 RVA: 0x00338538 File Offset: 0x00336738
		public Span<int> GetSpawnGoldenCoinsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600E371 RID: 58225 RVA: 0x00338548 File Offset: 0x00336748
		public int[] GetSpawnGoldenCoinsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600E372 RID: 58226 RVA: 0x00338560 File Offset: 0x00336760
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用NearbyMonsterBuffsIter()或GetNearbyMonsterBuffsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] NearbyMonsterBuffs()
		{
			TrapDefenseDeathrattle trapDefenseDeathrattle = this;
			return trapDefenseDeathrattle.GetNearbyMonsterBuffsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E373 RID: 58227 RVA: 0x00338584 File Offset: 0x00336784
		[NullableContext(1)]
		public readonly IEnumerable<int> NearbyMonsterBuffsIter()
		{
			TrapDefenseDeathrattle.<NearbyMonsterBuffsIter>d__34 <NearbyMonsterBuffsIter>d__ = new TrapDefenseDeathrattle.<NearbyMonsterBuffsIter>d__34(-2);
			<NearbyMonsterBuffsIter>d__.<>3__<>4__this = this;
			return <NearbyMonsterBuffsIter>d__;
		}

		// Token: 0x0600E374 RID: 58228 RVA: 0x0033859C File Offset: 0x0033679C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpawnGoldenCoinsIter()或GetSpawnGoldenCoinsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SpawnGoldenCoins()
		{
			TrapDefenseDeathrattle trapDefenseDeathrattle = this;
			return trapDefenseDeathrattle.GetSpawnGoldenCoinsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E375 RID: 58229 RVA: 0x003385C0 File Offset: 0x003367C0
		[NullableContext(1)]
		public readonly IEnumerable<int> SpawnGoldenCoinsIter()
		{
			TrapDefenseDeathrattle.<SpawnGoldenCoinsIter>d__36 <SpawnGoldenCoinsIter>d__ = new TrapDefenseDeathrattle.<SpawnGoldenCoinsIter>d__36(-2);
			<SpawnGoldenCoinsIter>d__.<>3__<>4__this = this;
			return <SpawnGoldenCoinsIter>d__;
		}

		// Token: 0x0600E376 RID: 58230 RVA: 0x003385D8 File Offset: 0x003367D8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpawnMonstersIter()或GetSpawnMonstersBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SpawnMonsters()
		{
			TrapDefenseDeathrattle trapDefenseDeathrattle = this;
			return trapDefenseDeathrattle.GetSpawnMonstersArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E377 RID: 58231 RVA: 0x003385FC File Offset: 0x003367FC
		[NullableContext(1)]
		public readonly IEnumerable<int> SpawnMonstersIter()
		{
			TrapDefenseDeathrattle.<SpawnMonstersIter>d__38 <SpawnMonstersIter>d__ = new TrapDefenseDeathrattle.<SpawnMonstersIter>d__38(-2);
			<SpawnMonstersIter>d__.<>3__<>4__this = this;
			return <SpawnMonstersIter>d__;
		}

		// Token: 0x040052A5 RID: 21157
		private Table __p;
	}
}
