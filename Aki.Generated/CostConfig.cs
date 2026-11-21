using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012E8 RID: 4840
	public struct CostConfig : IFlatbufferObject
	{
		// Token: 0x17004218 RID: 16920
		// (get) Token: 0x0600F745 RID: 63301 RVA: 0x00371B5F File Offset: 0x0036FD5F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F746 RID: 63302 RVA: 0x00371B6C File Offset: 0x0036FD6C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F747 RID: 63303 RVA: 0x00371B74 File Offset: 0x0036FD74
		public static CostConfig GetRootAsCostConfig(ByteBuffer _bb)
		{
			return CostConfig.GetRootAsCostConfig(_bb, default(CostConfig));
		}

		// Token: 0x0600F748 RID: 63304 RVA: 0x00371B90 File Offset: 0x0036FD90
		public static CostConfig GetRootAsCostConfig(ByteBuffer _bb, CostConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F749 RID: 63305 RVA: 0x00371BAD File Offset: 0x0036FDAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F74A RID: 63306 RVA: 0x00371BBC File Offset: 0x0036FDBC
		public CostConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600F74B RID: 63307 RVA: 0x00371BCC File Offset: 0x0036FDCC
		public DicIntInt? Cost(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17004219 RID: 16921
		// (get) Token: 0x0600F74C RID: 63308 RVA: 0x00371C2C File Offset: 0x0036FE2C
		public int CostLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600F74D RID: 63309 RVA: 0x00371C58 File Offset: 0x0036FE58
		[NullableContext(1)]
		public Dictionary<int, int> Cost()
		{
			return this.CostIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600F74E RID: 63310 RVA: 0x00371CAE File Offset: 0x0036FEAE
		[NullableContext(1)]
		public IEnumerable<DicIntInt> CostIter()
		{
			CostConfig.<CostIter>d__12 <CostIter>d__ = new CostConfig.<CostIter>d__12(-2);
			<CostIter>d__.<>3__<>4__this = this;
			return <CostIter>d__;
		}

		// Token: 0x0600F74F RID: 63311 RVA: 0x00371CC4 File Offset: 0x0036FEC4
		public int? GetCost(int key)
		{
			this.EnsureCostCacheIfNeeded();
			int value;
			if (!this.CostCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600F750 RID: 63312 RVA: 0x00371CF8 File Offset: 0x0036FEF8
		private void EnsureCostCacheIfNeeded()
		{
			if (this.CostCache != null)
			{
				return;
			}
			this.CostCache = this.CostIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600F751 RID: 63313 RVA: 0x00371D5E File Offset: 0x0036FF5E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetCostFrozenDict()
		{
			this.EnsureCostCacheIfNeeded();
			return this.CostCache;
		}

		// Token: 0x04005942 RID: 22850
		private Table __p;

		// Token: 0x04005943 RID: 22851
		[Nullable(2)]
		private FrozenDictionary<int, int> CostCache;
	}
}
