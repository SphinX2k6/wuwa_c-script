using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010A3 RID: 4259
	public struct ResonantChain : IFlatbufferObject
	{
		// Token: 0x17002E73 RID: 11891
		// (get) Token: 0x0600C208 RID: 49672 RVA: 0x002FA05E File Offset: 0x002F825E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C209 RID: 49673 RVA: 0x002FA06B File Offset: 0x002F826B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C20A RID: 49674 RVA: 0x002FA074 File Offset: 0x002F8274
		public static ResonantChain GetRootAsResonantChain(ByteBuffer _bb)
		{
			return ResonantChain.GetRootAsResonantChain(_bb, default(ResonantChain));
		}

		// Token: 0x0600C20B RID: 49675 RVA: 0x002FA090 File Offset: 0x002F8290
		public static ResonantChain GetRootAsResonantChain(ByteBuffer _bb, ResonantChain obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C20C RID: 49676 RVA: 0x002FA0AD File Offset: 0x002F82AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C20D RID: 49677 RVA: 0x002FA0BC File Offset: 0x002F82BC
		public ResonantChain __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E74 RID: 11892
		// (get) Token: 0x0600C20E RID: 49678 RVA: 0x002FA0CC File Offset: 0x002F82CC
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

		// Token: 0x17002E75 RID: 11893
		// (get) Token: 0x0600C20F RID: 49679 RVA: 0x002FA108 File Offset: 0x002F8308
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

		// Token: 0x17002E76 RID: 11894
		// (get) Token: 0x0600C210 RID: 49680 RVA: 0x002FA144 File Offset: 0x002F8344
		public int GroupIndex
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

		// Token: 0x17002E77 RID: 11895
		// (get) Token: 0x0600C211 RID: 49681 RVA: 0x002FA180 File Offset: 0x002F8380
		public int NodeType
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

		// Token: 0x17002E78 RID: 11896
		// (get) Token: 0x0600C212 RID: 49682 RVA: 0x002FA1C0 File Offset: 0x002F83C0
		public string NodeIndex
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

		// Token: 0x0600C213 RID: 49683 RVA: 0x002FA1F8 File Offset: 0x002F83F8
		public Span<byte> GetNodeIndexBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C214 RID: 49684 RVA: 0x002FA208 File Offset: 0x002F8408
		public byte[] GetNodeIndexArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E79 RID: 11897
		// (get) Token: 0x0600C215 RID: 49685 RVA: 0x002FA220 File Offset: 0x002F8420
		public string NodeName
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C216 RID: 49686 RVA: 0x002FA258 File Offset: 0x002F8458
		public Span<byte> GetNodeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C217 RID: 49687 RVA: 0x002FA268 File Offset: 0x002F8468
		public byte[] GetNodeNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E7A RID: 11898
		// (get) Token: 0x0600C218 RID: 49688 RVA: 0x002FA280 File Offset: 0x002F8480
		public string AttributesDescription
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C219 RID: 49689 RVA: 0x002FA2B8 File Offset: 0x002F84B8
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C21A RID: 49690 RVA: 0x002FA2C8 File Offset: 0x002F84C8
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E7B RID: 11899
		// (get) Token: 0x0600C21B RID: 49691 RVA: 0x002FA2E0 File Offset: 0x002F84E0
		public string BgDescription
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C21C RID: 49692 RVA: 0x002FA318 File Offset: 0x002F8518
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C21D RID: 49693 RVA: 0x002FA328 File Offset: 0x002F8528
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C21E RID: 49694 RVA: 0x002FA340 File Offset: 0x002F8540
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(20);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002E7C RID: 11900
		// (get) Token: 0x0600C21F RID: 49695 RVA: 0x002FA38C File Offset: 0x002F858C
		public int BuffIdsLength
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

		// Token: 0x0600C220 RID: 49696 RVA: 0x002FA3B8 File Offset: 0x002F85B8
		public Span<long> GetBuffIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(20, 8));
		}

		// Token: 0x0600C221 RID: 49697 RVA: 0x002FA3CD File Offset: 0x002F85CD
		public long[] GetBuffIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(20) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600C222 RID: 49698 RVA: 0x002FA40C File Offset: 0x002F860C
		public ConfigPropValue? AddProp(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new ConfigPropValue?(default(ConfigPropValue).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002E7D RID: 11901
		// (get) Token: 0x0600C223 RID: 49699 RVA: 0x002FA470 File Offset: 0x002F8670
		public int AddPropLength
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

		// Token: 0x0600C224 RID: 49700 RVA: 0x002FA49C File Offset: 0x002F869C
		public DicIntInt? ActivateConsume(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002E7E RID: 11902
		// (get) Token: 0x0600C225 RID: 49701 RVA: 0x002FA500 File Offset: 0x002F8700
		public int ActivateConsumeLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C226 RID: 49702 RVA: 0x002FA52C File Offset: 0x002F872C
		public string AttributesDescriptionParams(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002E7F RID: 11903
		// (get) Token: 0x0600C227 RID: 49703 RVA: 0x002FA568 File Offset: 0x002F8768
		public int AttributesDescriptionParamsLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17002E80 RID: 11904
		// (get) Token: 0x0600C228 RID: 49704 RVA: 0x002FA594 File Offset: 0x002F8794
		public string NodeIcon
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C229 RID: 49705 RVA: 0x002FA5CC File Offset: 0x002F87CC
		public Span<byte> GetNodeIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600C22A RID: 49706 RVA: 0x002FA5DC File Offset: 0x002F87DC
		public byte[] GetNodeIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C22B RID: 49707 RVA: 0x002FA5F4 File Offset: 0x002F87F4
		[NullableContext(1)]
		public Dictionary<int, int> ActivateConsume()
		{
			return this.ActivateConsumeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C22C RID: 49708 RVA: 0x002FA64A File Offset: 0x002F884A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ActivateConsumeIter()
		{
			ResonantChain.<ActivateConsumeIter>d__51 <ActivateConsumeIter>d__ = new ResonantChain.<ActivateConsumeIter>d__51(-2);
			<ActivateConsumeIter>d__.<>3__<>4__this = this;
			return <ActivateConsumeIter>d__;
		}

		// Token: 0x0600C22D RID: 49709 RVA: 0x002FA65F File Offset: 0x002F885F
		[NullableContext(1)]
		public ConfigPropValue[] AddProp()
		{
			return this.AddPropIter().ToArray<ConfigPropValue>();
		}

		// Token: 0x0600C22E RID: 49710 RVA: 0x002FA66C File Offset: 0x002F886C
		[NullableContext(1)]
		public IEnumerable<ConfigPropValue> AddPropIter()
		{
			ResonantChain.<AddPropIter>d__53 <AddPropIter>d__ = new ResonantChain.<AddPropIter>d__53(-2);
			<AddPropIter>d__.<>3__<>4__this = this;
			return <AddPropIter>d__;
		}

		// Token: 0x0600C22F RID: 49711 RVA: 0x002FA681 File Offset: 0x002F8881
		[NullableContext(1)]
		public string[] AttributesDescriptionParams()
		{
			return this.AttributesDescriptionParamsIter().ToArray<string>();
		}

		// Token: 0x0600C230 RID: 49712 RVA: 0x002FA68E File Offset: 0x002F888E
		[NullableContext(1)]
		public IEnumerable<string> AttributesDescriptionParamsIter()
		{
			ResonantChain.<AttributesDescriptionParamsIter>d__55 <AttributesDescriptionParamsIter>d__ = new ResonantChain.<AttributesDescriptionParamsIter>d__55(-2);
			<AttributesDescriptionParamsIter>d__.<>3__<>4__this = this;
			return <AttributesDescriptionParamsIter>d__;
		}

		// Token: 0x0600C231 RID: 49713 RVA: 0x002FA6A3 File Offset: 0x002F88A3
		[NullableContext(1)]
		public long[] BuffIds()
		{
			return this.GetBuffIdsArray();
		}

		// Token: 0x0600C232 RID: 49714 RVA: 0x002FA6AB File Offset: 0x002F88AB
		[NullableContext(1)]
		public IEnumerable<long> BuffIdsIter()
		{
			ResonantChain.<BuffIdsIter>d__57 <BuffIdsIter>d__ = new ResonantChain.<BuffIdsIter>d__57(-2);
			<BuffIdsIter>d__.<>3__<>4__this = this;
			return <BuffIdsIter>d__;
		}

		// Token: 0x0600C233 RID: 49715 RVA: 0x002FA6C0 File Offset: 0x002F88C0
		public int? GetActivateConsume(int key)
		{
			this.EnsureActivateConsumeCacheIfNeeded();
			int value;
			if (!this.ActivateConsumeCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C234 RID: 49716 RVA: 0x002FA6F4 File Offset: 0x002F88F4
		private void EnsureActivateConsumeCacheIfNeeded()
		{
			if (this.ActivateConsumeCache != null)
			{
				return;
			}
			this.ActivateConsumeCache = this.ActivateConsumeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C235 RID: 49717 RVA: 0x002FA75A File Offset: 0x002F895A
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetActivateConsumeFrozenDict()
		{
			this.EnsureActivateConsumeCacheIfNeeded();
			return this.ActivateConsumeCache;
		}

		// Token: 0x0400567C RID: 22140
		private Table __p;

		// Token: 0x0400567D RID: 22141
		[Nullable(2)]
		private FrozenDictionary<int, int> ActivateConsumeCache;
	}
}
