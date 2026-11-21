using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F73 RID: 3955
	public struct NewTowerParam : IFlatbufferObject
	{
		// Token: 0x170023BF RID: 9151
		// (get) Token: 0x0600A583 RID: 42371 RVA: 0x002BBA24 File Offset: 0x002B9C24
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A584 RID: 42372 RVA: 0x002BBA31 File Offset: 0x002B9C31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A585 RID: 42373 RVA: 0x002BBA38 File Offset: 0x002B9C38
		public static NewTowerParam GetRootAsNewTowerParam(ByteBuffer _bb)
		{
			return NewTowerParam.GetRootAsNewTowerParam(_bb, default(NewTowerParam));
		}

		// Token: 0x0600A586 RID: 42374 RVA: 0x002BBA54 File Offset: 0x002B9C54
		public static NewTowerParam GetRootAsNewTowerParam(ByteBuffer _bb, NewTowerParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A587 RID: 42375 RVA: 0x002BBA71 File Offset: 0x002B9C71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A588 RID: 42376 RVA: 0x002BBA80 File Offset: 0x002B9C80
		public NewTowerParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170023C0 RID: 9152
		// (get) Token: 0x0600A589 RID: 42377 RVA: 0x002BBA90 File Offset: 0x002B9C90
		public int CycleId
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

		// Token: 0x170023C1 RID: 9153
		// (get) Token: 0x0600A58A RID: 42378 RVA: 0x002BBACC File Offset: 0x002B9CCC
		public int SeasonId
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

		// Token: 0x170023C2 RID: 9154
		// (get) Token: 0x0600A58B RID: 42379 RVA: 0x002BBB08 File Offset: 0x002B9D08
		public int ActivityId
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

		// Token: 0x170023C3 RID: 9155
		// (get) Token: 0x0600A58C RID: 42380 RVA: 0x002BBB44 File Offset: 0x002B9D44
		public int TimerId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170023C4 RID: 9156
		// (get) Token: 0x0600A58D RID: 42381 RVA: 0x002BBB84 File Offset: 0x002B9D84
		public int ShowTimerId
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

		// Token: 0x170023C5 RID: 9157
		// (get) Token: 0x0600A58E RID: 42382 RVA: 0x002BBBC4 File Offset: 0x002B9DC4
		public int RoleCount
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 3;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170023C6 RID: 9158
		// (get) Token: 0x0600A58F RID: 42383 RVA: 0x002BBC04 File Offset: 0x002B9E04
		public int DefaultCostEnergy
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 10;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A590 RID: 42384 RVA: 0x002BBC44 File Offset: 0x002B9E44
		public DicIntInt? CostEnergy(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170023C7 RID: 9159
		// (get) Token: 0x0600A591 RID: 42385 RVA: 0x002BBCA8 File Offset: 0x002B9EA8
		public int CostEnergyLength
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

		// Token: 0x0600A592 RID: 42386 RVA: 0x002BBCD4 File Offset: 0x002B9ED4
		public int EnhanceRoleIds(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170023C8 RID: 9160
		// (get) Token: 0x0600A593 RID: 42387 RVA: 0x002BBD14 File Offset: 0x002B9F14
		public int EnhanceRoleIdsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A594 RID: 42388 RVA: 0x002BBD40 File Offset: 0x002B9F40
		public Span<int> GetEnhanceRoleIdsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600A595 RID: 42389 RVA: 0x002BBD50 File Offset: 0x002B9F50
		public int[] GetEnhanceRoleIdsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600A596 RID: 42390 RVA: 0x002BBD68 File Offset: 0x002B9F68
		public DicIntInt? SpecialUpRoleIds(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170023C9 RID: 9161
		// (get) Token: 0x0600A597 RID: 42391 RVA: 0x002BBDCC File Offset: 0x002B9FCC
		public int SpecialUpRoleIdsLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170023CA RID: 9162
		// (get) Token: 0x0600A598 RID: 42392 RVA: 0x002BBDF8 File Offset: 0x002B9FF8
		public string CycleName
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

		// Token: 0x0600A599 RID: 42393 RVA: 0x002BBE30 File Offset: 0x002BA030
		public Span<byte> GetCycleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600A59A RID: 42394 RVA: 0x002BBE40 File Offset: 0x002BA040
		public byte[] GetCycleNameArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A59B RID: 42395 RVA: 0x002BBE58 File Offset: 0x002BA058
		[NullableContext(1)]
		public Dictionary<int, int> CostEnergy()
		{
			return this.CostEnergyIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600A59C RID: 42396 RVA: 0x002BBEAE File Offset: 0x002BA0AE
		[NullableContext(1)]
		public IEnumerable<DicIntInt> CostEnergyIter()
		{
			NewTowerParam.<CostEnergyIter>d__38 <CostEnergyIter>d__ = new NewTowerParam.<CostEnergyIter>d__38(-2);
			<CostEnergyIter>d__.<>3__<>4__this = this;
			return <CostEnergyIter>d__;
		}

		// Token: 0x0600A59D RID: 42397 RVA: 0x002BBEC3 File Offset: 0x002BA0C3
		[NullableContext(1)]
		public int[] EnhanceRoleIds()
		{
			return this.GetEnhanceRoleIdsArray();
		}

		// Token: 0x0600A59E RID: 42398 RVA: 0x002BBECB File Offset: 0x002BA0CB
		[NullableContext(1)]
		public IEnumerable<int> EnhanceRoleIdsIter()
		{
			NewTowerParam.<EnhanceRoleIdsIter>d__40 <EnhanceRoleIdsIter>d__ = new NewTowerParam.<EnhanceRoleIdsIter>d__40(-2);
			<EnhanceRoleIdsIter>d__.<>3__<>4__this = this;
			return <EnhanceRoleIdsIter>d__;
		}

		// Token: 0x0600A59F RID: 42399 RVA: 0x002BBEE0 File Offset: 0x002BA0E0
		[NullableContext(1)]
		public Dictionary<int, int> SpecialUpRoleIds()
		{
			return this.SpecialUpRoleIdsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600A5A0 RID: 42400 RVA: 0x002BBF36 File Offset: 0x002BA136
		[NullableContext(1)]
		public IEnumerable<DicIntInt> SpecialUpRoleIdsIter()
		{
			NewTowerParam.<SpecialUpRoleIdsIter>d__42 <SpecialUpRoleIdsIter>d__ = new NewTowerParam.<SpecialUpRoleIdsIter>d__42(-2);
			<SpecialUpRoleIdsIter>d__.<>3__<>4__this = this;
			return <SpecialUpRoleIdsIter>d__;
		}

		// Token: 0x0600A5A1 RID: 42401 RVA: 0x002BBF4C File Offset: 0x002BA14C
		public int? GetCostEnergy(int key)
		{
			this.EnsureCostEnergyCacheIfNeeded();
			int value;
			if (!this.CostEnergyCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600A5A2 RID: 42402 RVA: 0x002BBF80 File Offset: 0x002BA180
		public int? GetSpecialUpRoleIds(int key)
		{
			this.EnsureSpecialUpRoleIdsCacheIfNeeded();
			int value;
			if (!this.SpecialUpRoleIdsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600A5A3 RID: 42403 RVA: 0x002BBFB4 File Offset: 0x002BA1B4
		private void EnsureCostEnergyCacheIfNeeded()
		{
			if (this.CostEnergyCache != null)
			{
				return;
			}
			this.CostEnergyCache = this.CostEnergyIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600A5A4 RID: 42404 RVA: 0x002BC01C File Offset: 0x002BA21C
		private void EnsureSpecialUpRoleIdsCacheIfNeeded()
		{
			if (this.SpecialUpRoleIdsCache != null)
			{
				return;
			}
			this.SpecialUpRoleIdsCache = this.SpecialUpRoleIdsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600A5A5 RID: 42405 RVA: 0x002BC082 File Offset: 0x002BA282
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetCostEnergyFrozenDict()
		{
			this.EnsureCostEnergyCacheIfNeeded();
			return this.CostEnergyCache;
		}

		// Token: 0x0600A5A6 RID: 42406 RVA: 0x002BC090 File Offset: 0x002BA290
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetSpecialUpRoleIdsFrozenDict()
		{
			this.EnsureSpecialUpRoleIdsCacheIfNeeded();
			return this.SpecialUpRoleIdsCache;
		}

		// Token: 0x04005522 RID: 21794
		private Table __p;

		// Token: 0x04005523 RID: 21795
		[Nullable(2)]
		private FrozenDictionary<int, int> CostEnergyCache;

		// Token: 0x04005524 RID: 21796
		[Nullable(2)]
		private FrozenDictionary<int, int> SpecialUpRoleIdsCache;
	}
}
