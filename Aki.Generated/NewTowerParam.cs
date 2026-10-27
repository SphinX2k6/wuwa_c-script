using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E8E RID: 3726
	public struct NewTowerParam : IFlatbufferObject
	{
		// Token: 0x1700235A RID: 9050
		// (get) Token: 0x06009F63 RID: 40803 RVA: 0x0029E464 File Offset: 0x0029C664
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009F64 RID: 40804 RVA: 0x0029E471 File Offset: 0x0029C671
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009F65 RID: 40805 RVA: 0x0029E478 File Offset: 0x0029C678
		public static NewTowerParam GetRootAsNewTowerParam(ByteBuffer _bb)
		{
			return NewTowerParam.GetRootAsNewTowerParam(_bb, default(NewTowerParam));
		}

		// Token: 0x06009F66 RID: 40806 RVA: 0x0029E494 File Offset: 0x0029C694
		public static NewTowerParam GetRootAsNewTowerParam(ByteBuffer _bb, NewTowerParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009F67 RID: 40807 RVA: 0x0029E4B1 File Offset: 0x0029C6B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009F68 RID: 40808 RVA: 0x0029E4C0 File Offset: 0x0029C6C0
		public NewTowerParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700235B RID: 9051
		// (get) Token: 0x06009F69 RID: 40809 RVA: 0x0029E4D0 File Offset: 0x0029C6D0
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

		// Token: 0x1700235C RID: 9052
		// (get) Token: 0x06009F6A RID: 40810 RVA: 0x0029E50C File Offset: 0x0029C70C
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

		// Token: 0x1700235D RID: 9053
		// (get) Token: 0x06009F6B RID: 40811 RVA: 0x0029E548 File Offset: 0x0029C748
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

		// Token: 0x1700235E RID: 9054
		// (get) Token: 0x06009F6C RID: 40812 RVA: 0x0029E584 File Offset: 0x0029C784
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

		// Token: 0x1700235F RID: 9055
		// (get) Token: 0x06009F6D RID: 40813 RVA: 0x0029E5C4 File Offset: 0x0029C7C4
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

		// Token: 0x17002360 RID: 9056
		// (get) Token: 0x06009F6E RID: 40814 RVA: 0x0029E604 File Offset: 0x0029C804
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

		// Token: 0x17002361 RID: 9057
		// (get) Token: 0x06009F6F RID: 40815 RVA: 0x0029E644 File Offset: 0x0029C844
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

		// Token: 0x06009F70 RID: 40816 RVA: 0x0029E684 File Offset: 0x0029C884
		public DicIntInt? CostEnergy(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002362 RID: 9058
		// (get) Token: 0x06009F71 RID: 40817 RVA: 0x0029E6E8 File Offset: 0x0029C8E8
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

		// Token: 0x06009F72 RID: 40818 RVA: 0x0029E714 File Offset: 0x0029C914
		public int EnhanceRoleIds(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002363 RID: 9059
		// (get) Token: 0x06009F73 RID: 40819 RVA: 0x0029E754 File Offset: 0x0029C954
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

		// Token: 0x06009F74 RID: 40820 RVA: 0x0029E780 File Offset: 0x0029C980
		public Span<int> GetEnhanceRoleIdsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06009F75 RID: 40821 RVA: 0x0029E790 File Offset: 0x0029C990
		public int[] GetEnhanceRoleIdsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x06009F76 RID: 40822 RVA: 0x0029E7A8 File Offset: 0x0029C9A8
		public DicIntInt? SpecialUpRoleIds(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002364 RID: 9060
		// (get) Token: 0x06009F77 RID: 40823 RVA: 0x0029E80C File Offset: 0x0029CA0C
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

		// Token: 0x17002365 RID: 9061
		// (get) Token: 0x06009F78 RID: 40824 RVA: 0x0029E838 File Offset: 0x0029CA38
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

		// Token: 0x06009F79 RID: 40825 RVA: 0x0029E870 File Offset: 0x0029CA70
		public Span<byte> GetCycleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06009F7A RID: 40826 RVA: 0x0029E880 File Offset: 0x0029CA80
		public byte[] GetCycleNameArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x06009F7B RID: 40827 RVA: 0x0029E898 File Offset: 0x0029CA98
		[NullableContext(1)]
		[Obsolete("已废弃，请使用CostEnergyFrozenDict()缓存字典，遍历请使用CostEnergyIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> CostEnergy()
		{
			return this.CostEnergyIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06009F7C RID: 40828 RVA: 0x0029E8EE File Offset: 0x0029CAEE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> CostEnergyIter()
		{
			NewTowerParam.<CostEnergyIter>d__38 <CostEnergyIter>d__ = new NewTowerParam.<CostEnergyIter>d__38(-2);
			<CostEnergyIter>d__.<>3__<>4__this = this;
			return <CostEnergyIter>d__;
		}

		// Token: 0x06009F7D RID: 40829 RVA: 0x0029E904 File Offset: 0x0029CB04
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EnhanceRoleIdsIter()或GetEnhanceRoleIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] EnhanceRoleIds()
		{
			NewTowerParam newTowerParam = this;
			return newTowerParam.GetEnhanceRoleIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009F7E RID: 40830 RVA: 0x0029E928 File Offset: 0x0029CB28
		[NullableContext(1)]
		public readonly IEnumerable<int> EnhanceRoleIdsIter()
		{
			NewTowerParam.<EnhanceRoleIdsIter>d__40 <EnhanceRoleIdsIter>d__ = new NewTowerParam.<EnhanceRoleIdsIter>d__40(-2);
			<EnhanceRoleIdsIter>d__.<>3__<>4__this = this;
			return <EnhanceRoleIdsIter>d__;
		}

		// Token: 0x06009F7F RID: 40831 RVA: 0x0029E940 File Offset: 0x0029CB40
		[NullableContext(1)]
		[Obsolete("已废弃，请使用SpecialUpRoleIdsFrozenDict()缓存字典，遍历请使用SpecialUpRoleIdsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> SpecialUpRoleIds()
		{
			return this.SpecialUpRoleIdsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06009F80 RID: 40832 RVA: 0x0029E996 File Offset: 0x0029CB96
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> SpecialUpRoleIdsIter()
		{
			NewTowerParam.<SpecialUpRoleIdsIter>d__42 <SpecialUpRoleIdsIter>d__ = new NewTowerParam.<SpecialUpRoleIdsIter>d__42(-2);
			<SpecialUpRoleIdsIter>d__.<>3__<>4__this = this;
			return <SpecialUpRoleIdsIter>d__;
		}

		// Token: 0x06009F81 RID: 40833 RVA: 0x0029E9AC File Offset: 0x0029CBAC
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

		// Token: 0x06009F82 RID: 40834 RVA: 0x0029E9E0 File Offset: 0x0029CBE0
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

		// Token: 0x06009F83 RID: 40835 RVA: 0x0029EA14 File Offset: 0x0029CC14
		private void EnsureCostEnergyCacheIfNeeded()
		{
			if (this.CostEnergyCache != null)
			{
				return;
			}
			this.CostEnergyCache = this.CostEnergyIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06009F84 RID: 40836 RVA: 0x0029EA7C File Offset: 0x0029CC7C
		private void EnsureSpecialUpRoleIdsCacheIfNeeded()
		{
			if (this.SpecialUpRoleIdsCache != null)
			{
				return;
			}
			this.SpecialUpRoleIdsCache = this.SpecialUpRoleIdsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06009F85 RID: 40837 RVA: 0x0029EAE2 File Offset: 0x0029CCE2
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetCostEnergyFrozenDict(int key)
		{
			this.EnsureCostEnergyCacheIfNeeded();
			return this.CostEnergyCache;
		}

		// Token: 0x06009F86 RID: 40838 RVA: 0x0029EAF0 File Offset: 0x0029CCF0
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetSpecialUpRoleIdsFrozenDict(int key)
		{
			this.EnsureSpecialUpRoleIdsCacheIfNeeded();
			return this.SpecialUpRoleIdsCache;
		}

		// Token: 0x04004F3D RID: 20285
		private Table __p;

		// Token: 0x04004F3E RID: 20286
		[Nullable(2)]
		private FrozenDictionary<int, int> CostEnergyCache;

		// Token: 0x04004F3F RID: 20287
		[Nullable(2)]
		private FrozenDictionary<int, int> SpecialUpRoleIdsCache;
	}
}
