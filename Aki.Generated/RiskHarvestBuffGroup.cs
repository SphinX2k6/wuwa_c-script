using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FCB RID: 4043
	public struct RiskHarvestBuffGroup : IFlatbufferObject
	{
		// Token: 0x17002E7D RID: 11901
		// (get) Token: 0x0600BD32 RID: 48434 RVA: 0x002E0BC5 File Offset: 0x002DEDC5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BD33 RID: 48435 RVA: 0x002E0BD2 File Offset: 0x002DEDD2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BD34 RID: 48436 RVA: 0x002E0BDC File Offset: 0x002DEDDC
		public static RiskHarvestBuffGroup GetRootAsRiskHarvestBuffGroup(ByteBuffer _bb)
		{
			return RiskHarvestBuffGroup.GetRootAsRiskHarvestBuffGroup(_bb, default(RiskHarvestBuffGroup));
		}

		// Token: 0x0600BD35 RID: 48437 RVA: 0x002E0BF8 File Offset: 0x002DEDF8
		public static RiskHarvestBuffGroup GetRootAsRiskHarvestBuffGroup(ByteBuffer _bb, RiskHarvestBuffGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BD36 RID: 48438 RVA: 0x002E0C15 File Offset: 0x002DEE15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BD37 RID: 48439 RVA: 0x002E0C24 File Offset: 0x002DEE24
		public RiskHarvestBuffGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E7E RID: 11902
		// (get) Token: 0x0600BD38 RID: 48440 RVA: 0x002E0C34 File Offset: 0x002DEE34
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

		// Token: 0x17002E7F RID: 11903
		// (get) Token: 0x0600BD39 RID: 48441 RVA: 0x002E0C70 File Offset: 0x002DEE70
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

		// Token: 0x0600BD3A RID: 48442 RVA: 0x002E0CAC File Offset: 0x002DEEAC
		public long Buff(int j)
		{
			int num = this.__p.__offset(8);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002E80 RID: 11904
		// (get) Token: 0x0600BD3B RID: 48443 RVA: 0x002E0CF8 File Offset: 0x002DEEF8
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

		// Token: 0x0600BD3C RID: 48444 RVA: 0x002E0D23 File Offset: 0x002DEF23
		public Span<long> GetBuffBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(8, 8));
		}

		// Token: 0x0600BD3D RID: 48445 RVA: 0x002E0D37 File Offset: 0x002DEF37
		public long[] GetBuffArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(8) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17002E81 RID: 11905
		// (get) Token: 0x0600BD3E RID: 48446 RVA: 0x002E0D74 File Offset: 0x002DEF74
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

		// Token: 0x0600BD3F RID: 48447 RVA: 0x002E0DAC File Offset: 0x002DEFAC
		public Span<byte> GetBuffNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BD40 RID: 48448 RVA: 0x002E0DBC File Offset: 0x002DEFBC
		public byte[] GetBuffNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E82 RID: 11906
		// (get) Token: 0x0600BD41 RID: 48449 RVA: 0x002E0DD4 File Offset: 0x002DEFD4
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

		// Token: 0x0600BD42 RID: 48450 RVA: 0x002E0E0C File Offset: 0x002DF00C
		public Span<byte> GetBuffDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BD43 RID: 48451 RVA: 0x002E0E1C File Offset: 0x002DF01C
		public byte[] GetBuffDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BD44 RID: 48452 RVA: 0x002E0E34 File Offset: 0x002DF034
		public string BuffFactors(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002E83 RID: 11907
		// (get) Token: 0x0600BD45 RID: 48453 RVA: 0x002E0E70 File Offset: 0x002DF070
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

		// Token: 0x17002E84 RID: 11908
		// (get) Token: 0x0600BD46 RID: 48454 RVA: 0x002E0E9C File Offset: 0x002DF09C
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

		// Token: 0x17002E85 RID: 11909
		// (get) Token: 0x0600BD47 RID: 48455 RVA: 0x002E0EDC File Offset: 0x002DF0DC
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

		// Token: 0x17002E86 RID: 11910
		// (get) Token: 0x0600BD48 RID: 48456 RVA: 0x002E0F1C File Offset: 0x002DF11C
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

		// Token: 0x0600BD49 RID: 48457 RVA: 0x002E0F54 File Offset: 0x002DF154
		public Span<byte> GetBuffIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600BD4A RID: 48458 RVA: 0x002E0F64 File Offset: 0x002DF164
		public byte[] GetBuffIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E87 RID: 11911
		// (get) Token: 0x0600BD4B RID: 48459 RVA: 0x002E0F7C File Offset: 0x002DF17C
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

		// Token: 0x17002E88 RID: 11912
		// (get) Token: 0x0600BD4C RID: 48460 RVA: 0x002E0FBC File Offset: 0x002DF1BC
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

		// Token: 0x0600BD4D RID: 48461 RVA: 0x002E0FF4 File Offset: 0x002DF1F4
		public Span<byte> GetRewardDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600BD4E RID: 48462 RVA: 0x002E1004 File Offset: 0x002DF204
		public byte[] GetRewardDescArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BD4F RID: 48463 RVA: 0x002E101C File Offset: 0x002DF21C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffIter()或GetBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] Buff()
		{
			RiskHarvestBuffGroup riskHarvestBuffGroup = this;
			return riskHarvestBuffGroup.GetBuffArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600BD50 RID: 48464 RVA: 0x002E1040 File Offset: 0x002DF240
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffIter()
		{
			RiskHarvestBuffGroup.<BuffIter>d__43 <BuffIter>d__ = new RiskHarvestBuffGroup.<BuffIter>d__43(-2);
			<BuffIter>d__.<>3__<>4__this = this;
			return <BuffIter>d__;
		}

		// Token: 0x0600BD51 RID: 48465 RVA: 0x002E1055 File Offset: 0x002DF255
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffFactorsIter()或GetBuffFactorsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BuffFactors()
		{
			return this.BuffFactorsIter().ToArray<string>();
		}

		// Token: 0x0600BD52 RID: 48466 RVA: 0x002E1062 File Offset: 0x002DF262
		[NullableContext(1)]
		public readonly IEnumerable<string> BuffFactorsIter()
		{
			RiskHarvestBuffGroup.<BuffFactorsIter>d__45 <BuffFactorsIter>d__ = new RiskHarvestBuffGroup.<BuffFactorsIter>d__45(-2);
			<BuffFactorsIter>d__.<>3__<>4__this = this;
			return <BuffFactorsIter>d__;
		}

		// Token: 0x040050A6 RID: 20646
		private Table __p;
	}
}
