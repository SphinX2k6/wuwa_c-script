using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200117C RID: 4476
	public struct RoverRogueRefresh : IFlatbufferObject
	{
		// Token: 0x1700359B RID: 13723
		// (get) Token: 0x0600D667 RID: 54887 RVA: 0x00327224 File Offset: 0x00325424
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D668 RID: 54888 RVA: 0x00327231 File Offset: 0x00325431
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D669 RID: 54889 RVA: 0x00327238 File Offset: 0x00325438
		public static RoverRogueRefresh GetRootAsRoverRogueRefresh(ByteBuffer _bb)
		{
			return RoverRogueRefresh.GetRootAsRoverRogueRefresh(_bb, default(RoverRogueRefresh));
		}

		// Token: 0x0600D66A RID: 54890 RVA: 0x00327254 File Offset: 0x00325454
		public static RoverRogueRefresh GetRootAsRoverRogueRefresh(ByteBuffer _bb, RoverRogueRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D66B RID: 54891 RVA: 0x00327271 File Offset: 0x00325471
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D66C RID: 54892 RVA: 0x00327280 File Offset: 0x00325480
		public RoverRogueRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700359C RID: 13724
		// (get) Token: 0x0600D66D RID: 54893 RVA: 0x00327290 File Offset: 0x00325490
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

		// Token: 0x1700359D RID: 13725
		// (get) Token: 0x0600D66E RID: 54894 RVA: 0x003272CC File Offset: 0x003254CC
		public int Cost
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

		// Token: 0x0600D66F RID: 54895 RVA: 0x00327308 File Offset: 0x00325508
		public DicIntInt? CostGrow(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700359E RID: 13726
		// (get) Token: 0x0600D670 RID: 54896 RVA: 0x00327368 File Offset: 0x00325568
		public int CostGrowLength
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

		// Token: 0x0600D671 RID: 54897 RVA: 0x00327394 File Offset: 0x00325594
		[NullableContext(1)]
		public Dictionary<int, int> CostGrow()
		{
			return this.CostGrowIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D672 RID: 54898 RVA: 0x003273EA File Offset: 0x003255EA
		[NullableContext(1)]
		public IEnumerable<DicIntInt> CostGrowIter()
		{
			RoverRogueRefresh.<CostGrowIter>d__16 <CostGrowIter>d__ = new RoverRogueRefresh.<CostGrowIter>d__16(-2);
			<CostGrowIter>d__.<>3__<>4__this = this;
			return <CostGrowIter>d__;
		}

		// Token: 0x0600D673 RID: 54899 RVA: 0x00327400 File Offset: 0x00325600
		public int? GetCostGrow(int key)
		{
			this.EnsureCostGrowCacheIfNeeded();
			int value;
			if (!this.CostGrowCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600D674 RID: 54900 RVA: 0x00327434 File Offset: 0x00325634
		private void EnsureCostGrowCacheIfNeeded()
		{
			if (this.CostGrowCache != null)
			{
				return;
			}
			this.CostGrowCache = this.CostGrowIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D675 RID: 54901 RVA: 0x0032749A File Offset: 0x0032569A
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetCostGrowFrozenDict()
		{
			this.EnsureCostGrowCacheIfNeeded();
			return this.CostGrowCache;
		}

		// Token: 0x0400578A RID: 22410
		private Table __p;

		// Token: 0x0400578B RID: 22411
		[Nullable(2)]
		private FrozenDictionary<int, int> CostGrowCache;
	}
}
