using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001296 RID: 4758
	public struct TrapDefenseDeathrattle : IFlatbufferObject
	{
		// Token: 0x17003F7D RID: 16253
		// (get) Token: 0x0600F0C9 RID: 61641 RVA: 0x003632B9 File Offset: 0x003614B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F0CA RID: 61642 RVA: 0x003632C6 File Offset: 0x003614C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F0CB RID: 61643 RVA: 0x003632D0 File Offset: 0x003614D0
		public static TrapDefenseDeathrattle GetRootAsTrapDefenseDeathrattle(ByteBuffer _bb)
		{
			return TrapDefenseDeathrattle.GetRootAsTrapDefenseDeathrattle(_bb, default(TrapDefenseDeathrattle));
		}

		// Token: 0x0600F0CC RID: 61644 RVA: 0x003632EC File Offset: 0x003614EC
		public static TrapDefenseDeathrattle GetRootAsTrapDefenseDeathrattle(ByteBuffer _bb, TrapDefenseDeathrattle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F0CD RID: 61645 RVA: 0x00363309 File Offset: 0x00361509
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F0CE RID: 61646 RVA: 0x00363318 File Offset: 0x00361518
		public TrapDefenseDeathrattle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F7E RID: 16254
		// (get) Token: 0x0600F0CF RID: 61647 RVA: 0x00363328 File Offset: 0x00361528
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

		// Token: 0x17003F7F RID: 16255
		// (get) Token: 0x0600F0D0 RID: 61648 RVA: 0x00363364 File Offset: 0x00361564
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

		// Token: 0x17003F80 RID: 16256
		// (get) Token: 0x0600F0D1 RID: 61649 RVA: 0x003633A0 File Offset: 0x003615A0
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

		// Token: 0x0600F0D2 RID: 61650 RVA: 0x003633DC File Offset: 0x003615DC
		public int NearbyMonsterBuffs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F81 RID: 16257
		// (get) Token: 0x0600F0D3 RID: 61651 RVA: 0x0036341C File Offset: 0x0036161C
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

		// Token: 0x0600F0D4 RID: 61652 RVA: 0x00363448 File Offset: 0x00361648
		public Span<int> GetNearbyMonsterBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600F0D5 RID: 61653 RVA: 0x00363458 File Offset: 0x00361658
		public int[] GetNearbyMonsterBuffsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17003F82 RID: 16258
		// (get) Token: 0x0600F0D6 RID: 61654 RVA: 0x00363470 File Offset: 0x00361670
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

		// Token: 0x17003F83 RID: 16259
		// (get) Token: 0x0600F0D7 RID: 61655 RVA: 0x003634B0 File Offset: 0x003616B0
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

		// Token: 0x0600F0D8 RID: 61656 RVA: 0x003634F0 File Offset: 0x003616F0
		public int SpawnMonsters(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F84 RID: 16260
		// (get) Token: 0x0600F0D9 RID: 61657 RVA: 0x00363530 File Offset: 0x00361730
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

		// Token: 0x0600F0DA RID: 61658 RVA: 0x0036355C File Offset: 0x0036175C
		public Span<int> GetSpawnMonstersBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600F0DB RID: 61659 RVA: 0x0036356C File Offset: 0x0036176C
		public int[] GetSpawnMonstersArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600F0DC RID: 61660 RVA: 0x00363584 File Offset: 0x00361784
		public int SpawnGoldenCoins(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F85 RID: 16261
		// (get) Token: 0x0600F0DD RID: 61661 RVA: 0x003635C4 File Offset: 0x003617C4
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

		// Token: 0x0600F0DE RID: 61662 RVA: 0x003635F0 File Offset: 0x003617F0
		public Span<int> GetSpawnGoldenCoinsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600F0DF RID: 61663 RVA: 0x00363600 File Offset: 0x00361800
		public int[] GetSpawnGoldenCoinsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600F0E0 RID: 61664 RVA: 0x00363618 File Offset: 0x00361818
		[NullableContext(1)]
		public int[] NearbyMonsterBuffs()
		{
			return this.GetNearbyMonsterBuffsArray();
		}

		// Token: 0x0600F0E1 RID: 61665 RVA: 0x00363620 File Offset: 0x00361820
		[NullableContext(1)]
		public IEnumerable<int> NearbyMonsterBuffsIter()
		{
			TrapDefenseDeathrattle.<NearbyMonsterBuffsIter>d__34 <NearbyMonsterBuffsIter>d__ = new TrapDefenseDeathrattle.<NearbyMonsterBuffsIter>d__34(-2);
			<NearbyMonsterBuffsIter>d__.<>3__<>4__this = this;
			return <NearbyMonsterBuffsIter>d__;
		}

		// Token: 0x0600F0E2 RID: 61666 RVA: 0x00363635 File Offset: 0x00361835
		[NullableContext(1)]
		public int[] SpawnGoldenCoins()
		{
			return this.GetSpawnGoldenCoinsArray();
		}

		// Token: 0x0600F0E3 RID: 61667 RVA: 0x0036363D File Offset: 0x0036183D
		[NullableContext(1)]
		public IEnumerable<int> SpawnGoldenCoinsIter()
		{
			TrapDefenseDeathrattle.<SpawnGoldenCoinsIter>d__36 <SpawnGoldenCoinsIter>d__ = new TrapDefenseDeathrattle.<SpawnGoldenCoinsIter>d__36(-2);
			<SpawnGoldenCoinsIter>d__.<>3__<>4__this = this;
			return <SpawnGoldenCoinsIter>d__;
		}

		// Token: 0x0600F0E4 RID: 61668 RVA: 0x00363652 File Offset: 0x00361852
		[NullableContext(1)]
		public int[] SpawnMonsters()
		{
			return this.GetSpawnMonstersArray();
		}

		// Token: 0x0600F0E5 RID: 61669 RVA: 0x0036365A File Offset: 0x0036185A
		[NullableContext(1)]
		public IEnumerable<int> SpawnMonstersIter()
		{
			TrapDefenseDeathrattle.<SpawnMonstersIter>d__38 <SpawnMonstersIter>d__ = new TrapDefenseDeathrattle.<SpawnMonstersIter>d__38(-2);
			<SpawnMonstersIter>d__.<>3__<>4__this = this;
			return <SpawnMonstersIter>d__;
		}

		// Token: 0x040058E8 RID: 22760
		private Table __p;
	}
}
