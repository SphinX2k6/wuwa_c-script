using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200114F RID: 4431
	public struct RoleTowerLevel : IFlatbufferObject
	{
		// Token: 0x17003419 RID: 13337
		// (get) Token: 0x0600D223 RID: 53795 RVA: 0x0031DDF5 File Offset: 0x0031BFF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D224 RID: 53796 RVA: 0x0031DE02 File Offset: 0x0031C002
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D225 RID: 53797 RVA: 0x0031DE0C File Offset: 0x0031C00C
		public static RoleTowerLevel GetRootAsRoleTowerLevel(ByteBuffer _bb)
		{
			return RoleTowerLevel.GetRootAsRoleTowerLevel(_bb, default(RoleTowerLevel));
		}

		// Token: 0x0600D226 RID: 53798 RVA: 0x0031DE28 File Offset: 0x0031C028
		public static RoleTowerLevel GetRootAsRoleTowerLevel(ByteBuffer _bb, RoleTowerLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D227 RID: 53799 RVA: 0x0031DE45 File Offset: 0x0031C045
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D228 RID: 53800 RVA: 0x0031DE54 File Offset: 0x0031C054
		public RoleTowerLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700341A RID: 13338
		// (get) Token: 0x0600D229 RID: 53801 RVA: 0x0031DE64 File Offset: 0x0031C064
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

		// Token: 0x1700341B RID: 13339
		// (get) Token: 0x0600D22A RID: 53802 RVA: 0x0031DEA0 File Offset: 0x0031C0A0
		public int GroupId
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

		// Token: 0x1700341C RID: 13340
		// (get) Token: 0x0600D22B RID: 53803 RVA: 0x0031DEDC File Offset: 0x0031C0DC
		public int MainRoleId
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

		// Token: 0x1700341D RID: 13341
		// (get) Token: 0x0600D22C RID: 53804 RVA: 0x0031DF18 File Offset: 0x0031C118
		public int FloorGroupId
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

		// Token: 0x1700341E RID: 13342
		// (get) Token: 0x0600D22D RID: 53805 RVA: 0x0031DF58 File Offset: 0x0031C158
		public int InstId
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

		// Token: 0x0600D22E RID: 53806 RVA: 0x0031DF98 File Offset: 0x0031C198
		public int PerLevels(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700341F RID: 13343
		// (get) Token: 0x0600D22F RID: 53807 RVA: 0x0031DFD8 File Offset: 0x0031C1D8
		public int PerLevelsLength
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

		// Token: 0x0600D230 RID: 53808 RVA: 0x0031E004 File Offset: 0x0031C204
		public Span<int> GetPerLevelsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600D231 RID: 53809 RVA: 0x0031E014 File Offset: 0x0031C214
		public int[] GetPerLevelsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17003420 RID: 13344
		// (get) Token: 0x0600D232 RID: 53810 RVA: 0x0031E02C File Offset: 0x0031C22C
		public int SortId
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

		// Token: 0x17003421 RID: 13345
		// (get) Token: 0x0600D233 RID: 53811 RVA: 0x0031E06C File Offset: 0x0031C26C
		public int TrialMainRoleId
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

		// Token: 0x0600D234 RID: 53812 RVA: 0x0031E0AC File Offset: 0x0031C2AC
		public int AssistRoleIds(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003422 RID: 13346
		// (get) Token: 0x0600D235 RID: 53813 RVA: 0x0031E0EC File Offset: 0x0031C2EC
		public int AssistRoleIdsLength
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

		// Token: 0x0600D236 RID: 53814 RVA: 0x0031E118 File Offset: 0x0031C318
		public Span<int> GetAssistRoleIdsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600D237 RID: 53815 RVA: 0x0031E128 File Offset: 0x0031C328
		public int[] GetAssistRoleIdsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600D238 RID: 53816 RVA: 0x0031E140 File Offset: 0x0031C340
		public int TrialAssistRoleIds(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003423 RID: 13347
		// (get) Token: 0x0600D239 RID: 53817 RVA: 0x0031E180 File Offset: 0x0031C380
		public int TrialAssistRoleIdsLength
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

		// Token: 0x0600D23A RID: 53818 RVA: 0x0031E1AC File Offset: 0x0031C3AC
		public Span<int> GetTrialAssistRoleIdsBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600D23B RID: 53819 RVA: 0x0031E1BC File Offset: 0x0031C3BC
		public int[] GetTrialAssistRoleIdsArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x17003424 RID: 13348
		// (get) Token: 0x0600D23C RID: 53820 RVA: 0x0031E1D4 File Offset: 0x0031C3D4
		public int OpenTime
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003425 RID: 13349
		// (get) Token: 0x0600D23D RID: 53821 RVA: 0x0031E214 File Offset: 0x0031C414
		public int DefaultMaxEnergy
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 10;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D23E RID: 53822 RVA: 0x0031E254 File Offset: 0x0031C454
		public DicIntInt? MaxEnergy(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003426 RID: 13350
		// (get) Token: 0x0600D23F RID: 53823 RVA: 0x0031E2B8 File Offset: 0x0031C4B8
		public int MaxEnergyLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D240 RID: 53824 RVA: 0x0031E2E4 File Offset: 0x0031C4E4
		public DicIntInt? InitTokenDict(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003427 RID: 13351
		// (get) Token: 0x0600D241 RID: 53825 RVA: 0x0031E348 File Offset: 0x0031C548
		public int InitTokenDictLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003428 RID: 13352
		// (get) Token: 0x0600D242 RID: 53826 RVA: 0x0031E374 File Offset: 0x0031C574
		public int InitTime
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003429 RID: 13353
		// (get) Token: 0x0600D243 RID: 53827 RVA: 0x0031E3B4 File Offset: 0x0031C5B4
		public string RoleTowerLevelIcon
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D244 RID: 53828 RVA: 0x0031E3EC File Offset: 0x0031C5EC
		public Span<byte> GetRoleTowerLevelIconBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600D245 RID: 53829 RVA: 0x0031E3FC File Offset: 0x0031C5FC
		public byte[] GetRoleTowerLevelIconArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x1700342A RID: 13354
		// (get) Token: 0x0600D246 RID: 53830 RVA: 0x0031E414 File Offset: 0x0031C614
		public string VideoName
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D247 RID: 53831 RVA: 0x0031E44C File Offset: 0x0031C64C
		public Span<byte> GetVideoNameBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600D248 RID: 53832 RVA: 0x0031E45C File Offset: 0x0031C65C
		public byte[] GetVideoNameArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x1700342B RID: 13355
		// (get) Token: 0x0600D249 RID: 53833 RVA: 0x0031E474 File Offset: 0x0031C674
		public string VideoPath
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D24A RID: 53834 RVA: 0x0031E4AC File Offset: 0x0031C6AC
		public Span<byte> GetVideoPathBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600D24B RID: 53835 RVA: 0x0031E4BC File Offset: 0x0031C6BC
		public byte[] GetVideoPathArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x1700342C RID: 13356
		// (get) Token: 0x0600D24C RID: 53836 RVA: 0x0031E4D4 File Offset: 0x0031C6D4
		public int HelpId
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700342D RID: 13357
		// (get) Token: 0x0600D24D RID: 53837 RVA: 0x0031E514 File Offset: 0x0031C714
		public int RoleTowerRankRewardItemId
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700342E RID: 13358
		// (get) Token: 0x0600D24E RID: 53838 RVA: 0x0031E554 File Offset: 0x0031C754
		public string RoleTowerRankRewardItemDes
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D24F RID: 53839 RVA: 0x0031E58C File Offset: 0x0031C78C
		public Span<byte> GetRoleTowerRankRewardItemDesBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600D250 RID: 53840 RVA: 0x0031E59C File Offset: 0x0031C79C
		public byte[] GetRoleTowerRankRewardItemDesArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D251 RID: 53841 RVA: 0x0031E5B4 File Offset: 0x0031C7B4
		[NullableContext(1)]
		public int[] AssistRoleIds()
		{
			return this.GetAssistRoleIdsArray();
		}

		// Token: 0x0600D252 RID: 53842 RVA: 0x0031E5BC File Offset: 0x0031C7BC
		[NullableContext(1)]
		public IEnumerable<int> AssistRoleIdsIter()
		{
			RoleTowerLevel.<AssistRoleIdsIter>d__70 <AssistRoleIdsIter>d__ = new RoleTowerLevel.<AssistRoleIdsIter>d__70(-2);
			<AssistRoleIdsIter>d__.<>3__<>4__this = this;
			return <AssistRoleIdsIter>d__;
		}

		// Token: 0x0600D253 RID: 53843 RVA: 0x0031E5D4 File Offset: 0x0031C7D4
		[NullableContext(1)]
		public Dictionary<int, int> InitTokenDict()
		{
			return this.InitTokenDictIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D254 RID: 53844 RVA: 0x0031E62A File Offset: 0x0031C82A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> InitTokenDictIter()
		{
			RoleTowerLevel.<InitTokenDictIter>d__72 <InitTokenDictIter>d__ = new RoleTowerLevel.<InitTokenDictIter>d__72(-2);
			<InitTokenDictIter>d__.<>3__<>4__this = this;
			return <InitTokenDictIter>d__;
		}

		// Token: 0x0600D255 RID: 53845 RVA: 0x0031E640 File Offset: 0x0031C840
		[NullableContext(1)]
		public Dictionary<int, int> MaxEnergy()
		{
			return this.MaxEnergyIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D256 RID: 53846 RVA: 0x0031E696 File Offset: 0x0031C896
		[NullableContext(1)]
		public IEnumerable<DicIntInt> MaxEnergyIter()
		{
			RoleTowerLevel.<MaxEnergyIter>d__74 <MaxEnergyIter>d__ = new RoleTowerLevel.<MaxEnergyIter>d__74(-2);
			<MaxEnergyIter>d__.<>3__<>4__this = this;
			return <MaxEnergyIter>d__;
		}

		// Token: 0x0600D257 RID: 53847 RVA: 0x0031E6AB File Offset: 0x0031C8AB
		[NullableContext(1)]
		public int[] PerLevels()
		{
			return this.GetPerLevelsArray();
		}

		// Token: 0x0600D258 RID: 53848 RVA: 0x0031E6B3 File Offset: 0x0031C8B3
		[NullableContext(1)]
		public IEnumerable<int> PerLevelsIter()
		{
			RoleTowerLevel.<PerLevelsIter>d__76 <PerLevelsIter>d__ = new RoleTowerLevel.<PerLevelsIter>d__76(-2);
			<PerLevelsIter>d__.<>3__<>4__this = this;
			return <PerLevelsIter>d__;
		}

		// Token: 0x0600D259 RID: 53849 RVA: 0x0031E6C8 File Offset: 0x0031C8C8
		[NullableContext(1)]
		public int[] TrialAssistRoleIds()
		{
			return this.GetTrialAssistRoleIdsArray();
		}

		// Token: 0x0600D25A RID: 53850 RVA: 0x0031E6D0 File Offset: 0x0031C8D0
		[NullableContext(1)]
		public IEnumerable<int> TrialAssistRoleIdsIter()
		{
			RoleTowerLevel.<TrialAssistRoleIdsIter>d__78 <TrialAssistRoleIdsIter>d__ = new RoleTowerLevel.<TrialAssistRoleIdsIter>d__78(-2);
			<TrialAssistRoleIdsIter>d__.<>3__<>4__this = this;
			return <TrialAssistRoleIdsIter>d__;
		}

		// Token: 0x0600D25B RID: 53851 RVA: 0x0031E6E8 File Offset: 0x0031C8E8
		public int? GetInitTokenDict(int key)
		{
			this.EnsureInitTokenDictCacheIfNeeded();
			int value;
			if (!this.InitTokenDictCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600D25C RID: 53852 RVA: 0x0031E71C File Offset: 0x0031C91C
		public int? GetMaxEnergy(int key)
		{
			this.EnsureMaxEnergyCacheIfNeeded();
			int value;
			if (!this.MaxEnergyCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600D25D RID: 53853 RVA: 0x0031E750 File Offset: 0x0031C950
		private void EnsureInitTokenDictCacheIfNeeded()
		{
			if (this.InitTokenDictCache != null)
			{
				return;
			}
			this.InitTokenDictCache = this.InitTokenDictIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D25E RID: 53854 RVA: 0x0031E7B8 File Offset: 0x0031C9B8
		private void EnsureMaxEnergyCacheIfNeeded()
		{
			if (this.MaxEnergyCache != null)
			{
				return;
			}
			this.MaxEnergyCache = this.MaxEnergyIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D25F RID: 53855 RVA: 0x0031E81E File Offset: 0x0031CA1E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetInitTokenDictFrozenDict()
		{
			this.EnsureInitTokenDictCacheIfNeeded();
			return this.InitTokenDictCache;
		}

		// Token: 0x0600D260 RID: 53856 RVA: 0x0031E82C File Offset: 0x0031CA2C
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetMaxEnergyFrozenDict()
		{
			this.EnsureMaxEnergyCacheIfNeeded();
			return this.MaxEnergyCache;
		}

		// Token: 0x04005754 RID: 22356
		private Table __p;

		// Token: 0x04005755 RID: 22357
		[Nullable(2)]
		private FrozenDictionary<int, int> InitTokenDictCache;

		// Token: 0x04005756 RID: 22358
		[Nullable(2)]
		private FrozenDictionary<int, int> MaxEnergyCache;
	}
}
