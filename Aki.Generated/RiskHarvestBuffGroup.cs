using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010B3 RID: 4275
	public struct RiskHarvestBuffGroup : IFlatbufferObject
	{
		// Token: 0x17002EF8 RID: 12024
		// (get) Token: 0x0600C37C RID: 50044 RVA: 0x002FD1CF File Offset: 0x002FB3CF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C37D RID: 50045 RVA: 0x002FD1DC File Offset: 0x002FB3DC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C37E RID: 50046 RVA: 0x002FD1E4 File Offset: 0x002FB3E4
		public static RiskHarvestBuffGroup GetRootAsRiskHarvestBuffGroup(ByteBuffer _bb)
		{
			return RiskHarvestBuffGroup.GetRootAsRiskHarvestBuffGroup(_bb, default(RiskHarvestBuffGroup));
		}

		// Token: 0x0600C37F RID: 50047 RVA: 0x002FD200 File Offset: 0x002FB400
		public static RiskHarvestBuffGroup GetRootAsRiskHarvestBuffGroup(ByteBuffer _bb, RiskHarvestBuffGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C380 RID: 50048 RVA: 0x002FD21D File Offset: 0x002FB41D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C381 RID: 50049 RVA: 0x002FD22C File Offset: 0x002FB42C
		public RiskHarvestBuffGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002EF9 RID: 12025
		// (get) Token: 0x0600C382 RID: 50050 RVA: 0x002FD23C File Offset: 0x002FB43C
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

		// Token: 0x17002EFA RID: 12026
		// (get) Token: 0x0600C383 RID: 50051 RVA: 0x002FD278 File Offset: 0x002FB478
		public int ActivityId
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

		// Token: 0x0600C384 RID: 50052 RVA: 0x002FD2B4 File Offset: 0x002FB4B4
		public long Buff(int j)
		{
			int num = this.__p.__offset(8);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002EFB RID: 12027
		// (get) Token: 0x0600C385 RID: 50053 RVA: 0x002FD300 File Offset: 0x002FB500
		public int BuffLength
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

		// Token: 0x0600C386 RID: 50054 RVA: 0x002FD32B File Offset: 0x002FB52B
		public Span<long> GetBuffBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(8, 8));
		}

		// Token: 0x0600C387 RID: 50055 RVA: 0x002FD33F File Offset: 0x002FB53F
		public long[] GetBuffArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(8) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17002EFC RID: 12028
		// (get) Token: 0x0600C388 RID: 50056 RVA: 0x002FD37C File Offset: 0x002FB57C
		public string BuffName
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

		// Token: 0x0600C389 RID: 50057 RVA: 0x002FD3B4 File Offset: 0x002FB5B4
		public Span<byte> GetBuffNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C38A RID: 50058 RVA: 0x002FD3C4 File Offset: 0x002FB5C4
		public byte[] GetBuffNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EFD RID: 12029
		// (get) Token: 0x0600C38B RID: 50059 RVA: 0x002FD3DC File Offset: 0x002FB5DC
		public string BuffDesc
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

		// Token: 0x0600C38C RID: 50060 RVA: 0x002FD414 File Offset: 0x002FB614
		public Span<byte> GetBuffDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C38D RID: 50061 RVA: 0x002FD424 File Offset: 0x002FB624
		public byte[] GetBuffDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C38E RID: 50062 RVA: 0x002FD43C File Offset: 0x002FB63C
		public string BuffFactors(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002EFE RID: 12030
		// (get) Token: 0x0600C38F RID: 50063 RVA: 0x002FD478 File Offset: 0x002FB678
		public int BuffFactorsLength
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

		// Token: 0x17002EFF RID: 12031
		// (get) Token: 0x0600C390 RID: 50064 RVA: 0x002FD4A4 File Offset: 0x002FB6A4
		public int BuffType
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

		// Token: 0x17002F00 RID: 12032
		// (get) Token: 0x0600C391 RID: 50065 RVA: 0x002FD4E4 File Offset: 0x002FB6E4
		public int BuffProgress
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

		// Token: 0x17002F01 RID: 12033
		// (get) Token: 0x0600C392 RID: 50066 RVA: 0x002FD524 File Offset: 0x002FB724
		public string BuffIcon
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C393 RID: 50067 RVA: 0x002FD55C File Offset: 0x002FB75C
		public Span<byte> GetBuffIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600C394 RID: 50068 RVA: 0x002FD56C File Offset: 0x002FB76C
		public byte[] GetBuffIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F02 RID: 12034
		// (get) Token: 0x0600C395 RID: 50069 RVA: 0x002FD584 File Offset: 0x002FB784
		public int Reward
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

		// Token: 0x17002F03 RID: 12035
		// (get) Token: 0x0600C396 RID: 50070 RVA: 0x002FD5C4 File Offset: 0x002FB7C4
		public string RewardDesc
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C397 RID: 50071 RVA: 0x002FD5FC File Offset: 0x002FB7FC
		public Span<byte> GetRewardDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600C398 RID: 50072 RVA: 0x002FD60C File Offset: 0x002FB80C
		public byte[] GetRewardDescArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C399 RID: 50073 RVA: 0x002FD624 File Offset: 0x002FB824
		[NullableContext(1)]
		public long[] Buff()
		{
			return this.GetBuffArray();
		}

		// Token: 0x0600C39A RID: 50074 RVA: 0x002FD62C File Offset: 0x002FB82C
		[NullableContext(1)]
		public IEnumerable<long> BuffIter()
		{
			RiskHarvestBuffGroup.<BuffIter>d__43 <BuffIter>d__ = new RiskHarvestBuffGroup.<BuffIter>d__43(-2);
			<BuffIter>d__.<>3__<>4__this = this;
			return <BuffIter>d__;
		}

		// Token: 0x0600C39B RID: 50075 RVA: 0x002FD641 File Offset: 0x002FB841
		[NullableContext(1)]
		public string[] BuffFactors()
		{
			return this.BuffFactorsIter().ToArray<string>();
		}

		// Token: 0x0600C39C RID: 50076 RVA: 0x002FD64E File Offset: 0x002FB84E
		[NullableContext(1)]
		public IEnumerable<string> BuffFactorsIter()
		{
			RiskHarvestBuffGroup.<BuffFactorsIter>d__45 <BuffFactorsIter>d__ = new RiskHarvestBuffGroup.<BuffFactorsIter>d__45(-2);
			<BuffFactorsIter>d__.<>3__<>4__this = this;
			return <BuffFactorsIter>d__;
		}

		// Token: 0x0400568E RID: 22158
		private Table __p;
	}
}
