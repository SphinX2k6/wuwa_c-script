using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001206 RID: 4614
	public struct SolarSchoolShopRefresh : IFlatbufferObject
	{
		// Token: 0x17003AB5 RID: 15029
		// (get) Token: 0x0600E40E RID: 58382 RVA: 0x00346E69 File Offset: 0x00345069
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E40F RID: 58383 RVA: 0x00346E76 File Offset: 0x00345076
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E410 RID: 58384 RVA: 0x00346E80 File Offset: 0x00345080
		public static SolarSchoolShopRefresh GetRootAsSolarSchoolShopRefresh(ByteBuffer _bb)
		{
			return SolarSchoolShopRefresh.GetRootAsSolarSchoolShopRefresh(_bb, default(SolarSchoolShopRefresh));
		}

		// Token: 0x0600E411 RID: 58385 RVA: 0x00346E9C File Offset: 0x0034509C
		public static SolarSchoolShopRefresh GetRootAsSolarSchoolShopRefresh(ByteBuffer _bb, SolarSchoolShopRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E412 RID: 58386 RVA: 0x00346EB9 File Offset: 0x003450B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E413 RID: 58387 RVA: 0x00346EC8 File Offset: 0x003450C8
		public SolarSchoolShopRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003AB6 RID: 15030
		// (get) Token: 0x0600E414 RID: 58388 RVA: 0x00346ED8 File Offset: 0x003450D8
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

		// Token: 0x17003AB7 RID: 15031
		// (get) Token: 0x0600E415 RID: 58389 RVA: 0x00346F14 File Offset: 0x00345114
		public int ShopId
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

		// Token: 0x17003AB8 RID: 15032
		// (get) Token: 0x0600E416 RID: 58390 RVA: 0x00346F50 File Offset: 0x00345150
		public int Week
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

		// Token: 0x0600E417 RID: 58391 RVA: 0x00346F8C File Offset: 0x0034518C
		public DicIntInt? GroupWeights(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003AB9 RID: 15033
		// (get) Token: 0x0600E418 RID: 58392 RVA: 0x00346FF0 File Offset: 0x003451F0
		public int GroupWeightsLength
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

		// Token: 0x0600E419 RID: 58393 RVA: 0x0034701C File Offset: 0x0034521C
		[NullableContext(1)]
		public Dictionary<int, int> GroupWeights()
		{
			return this.GroupWeightsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600E41A RID: 58394 RVA: 0x00347072 File Offset: 0x00345272
		[NullableContext(1)]
		public IEnumerable<DicIntInt> GroupWeightsIter()
		{
			SolarSchoolShopRefresh.<GroupWeightsIter>d__18 <GroupWeightsIter>d__ = new SolarSchoolShopRefresh.<GroupWeightsIter>d__18(-2);
			<GroupWeightsIter>d__.<>3__<>4__this = this;
			return <GroupWeightsIter>d__;
		}

		// Token: 0x0600E41B RID: 58395 RVA: 0x00347088 File Offset: 0x00345288
		public int? GetGroupWeights(int key)
		{
			this.EnsureGroupWeightsCacheIfNeeded();
			int value;
			if (!this.GroupWeightsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600E41C RID: 58396 RVA: 0x003470BC File Offset: 0x003452BC
		private void EnsureGroupWeightsCacheIfNeeded()
		{
			if (this.GroupWeightsCache != null)
			{
				return;
			}
			this.GroupWeightsCache = this.GroupWeightsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600E41D RID: 58397 RVA: 0x00347122 File Offset: 0x00345322
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetGroupWeightsFrozenDict()
		{
			this.EnsureGroupWeightsCacheIfNeeded();
			return this.GroupWeightsCache;
		}

		// Token: 0x04005844 RID: 22596
		private Table __p;

		// Token: 0x04005845 RID: 22597
		[Nullable(2)]
		private FrozenDictionary<int, int> GroupWeightsCache;
	}
}
