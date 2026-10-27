using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010C6 RID: 4294
	public struct SkillTree : IFlatbufferObject
	{
		// Token: 0x170036F5 RID: 14069
		// (get) Token: 0x0600D589 RID: 54665 RVA: 0x003187E6 File Offset: 0x003169E6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D58A RID: 54666 RVA: 0x003187F3 File Offset: 0x003169F3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D58B RID: 54667 RVA: 0x003187FC File Offset: 0x003169FC
		public static SkillTree GetRootAsSkillTree(ByteBuffer _bb)
		{
			return SkillTree.GetRootAsSkillTree(_bb, default(SkillTree));
		}

		// Token: 0x0600D58C RID: 54668 RVA: 0x00318818 File Offset: 0x00316A18
		public static SkillTree GetRootAsSkillTree(ByteBuffer _bb, SkillTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D58D RID: 54669 RVA: 0x00318835 File Offset: 0x00316A35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D58E RID: 54670 RVA: 0x00318844 File Offset: 0x00316A44
		public SkillTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170036F6 RID: 14070
		// (get) Token: 0x0600D58F RID: 54671 RVA: 0x00318854 File Offset: 0x00316A54
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

		// Token: 0x170036F7 RID: 14071
		// (get) Token: 0x0600D590 RID: 54672 RVA: 0x00318890 File Offset: 0x00316A90
		public int NodeIndex
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

		// Token: 0x170036F8 RID: 14072
		// (get) Token: 0x0600D591 RID: 54673 RVA: 0x003188CC File Offset: 0x00316ACC
		public int NodeGroup
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

		// Token: 0x0600D592 RID: 54674 RVA: 0x00318908 File Offset: 0x00316B08
		public int ParentNodes(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036F9 RID: 14073
		// (get) Token: 0x0600D593 RID: 54675 RVA: 0x00318948 File Offset: 0x00316B48
		public int ParentNodesLength
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

		// Token: 0x0600D594 RID: 54676 RVA: 0x00318974 File Offset: 0x00316B74
		public Span<int> GetParentNodesBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600D595 RID: 54677 RVA: 0x00318984 File Offset: 0x00316B84
		public int[] GetParentNodesArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170036FA RID: 14074
		// (get) Token: 0x0600D596 RID: 54678 RVA: 0x0031899C File Offset: 0x00316B9C
		public int NodeType
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

		// Token: 0x170036FB RID: 14075
		// (get) Token: 0x0600D597 RID: 54679 RVA: 0x003189DC File Offset: 0x00316BDC
		public int Coordinate
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

		// Token: 0x0600D598 RID: 54680 RVA: 0x00318A1C File Offset: 0x00316C1C
		public int Condition(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036FC RID: 14076
		// (get) Token: 0x0600D599 RID: 54681 RVA: 0x00318A5C File Offset: 0x00316C5C
		public int ConditionLength
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

		// Token: 0x0600D59A RID: 54682 RVA: 0x00318A88 File Offset: 0x00316C88
		public Span<int> GetConditionBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600D59B RID: 54683 RVA: 0x00318A98 File Offset: 0x00316C98
		public int[] GetConditionArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x170036FD RID: 14077
		// (get) Token: 0x0600D59C RID: 54684 RVA: 0x00318AB0 File Offset: 0x00316CB0
		public int SkillId
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

		// Token: 0x0600D59D RID: 54685 RVA: 0x00318AF0 File Offset: 0x00316CF0
		public int SkillBranchIds(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036FE RID: 14078
		// (get) Token: 0x0600D59E RID: 54686 RVA: 0x00318B30 File Offset: 0x00316D30
		public int SkillBranchIdsLength
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

		// Token: 0x0600D59F RID: 54687 RVA: 0x00318B5C File Offset: 0x00316D5C
		public Span<int> GetSkillBranchIdsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600D5A0 RID: 54688 RVA: 0x00318B6C File Offset: 0x00316D6C
		public int[] GetSkillBranchIdsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600D5A1 RID: 54689 RVA: 0x00318B84 File Offset: 0x00316D84
		public string SkillBranchDescList(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036FF RID: 14079
		// (get) Token: 0x0600D5A2 RID: 54690 RVA: 0x00318BC0 File Offset: 0x00316DC0
		public int SkillBranchDescListLength
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

		// Token: 0x17003700 RID: 14080
		// (get) Token: 0x0600D5A3 RID: 54691 RVA: 0x00318BEC File Offset: 0x00316DEC
		public string PropertyNodeTitle
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

		// Token: 0x0600D5A4 RID: 54692 RVA: 0x00318C24 File Offset: 0x00316E24
		public Span<byte> GetPropertyNodeTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600D5A5 RID: 54693 RVA: 0x00318C34 File Offset: 0x00316E34
		public byte[] GetPropertyNodeTitleArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17003701 RID: 14081
		// (get) Token: 0x0600D5A6 RID: 54694 RVA: 0x00318C4C File Offset: 0x00316E4C
		public string PropertyNodeDescribe
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D5A7 RID: 54695 RVA: 0x00318C84 File Offset: 0x00316E84
		public Span<byte> GetPropertyNodeDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600D5A8 RID: 54696 RVA: 0x00318C94 File Offset: 0x00316E94
		public byte[] GetPropertyNodeDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D5A9 RID: 54697 RVA: 0x00318CAC File Offset: 0x00316EAC
		public string PropertyNodeParam(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003702 RID: 14082
		// (get) Token: 0x0600D5AA RID: 54698 RVA: 0x00318CE8 File Offset: 0x00316EE8
		public int PropertyNodeParamLength
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

		// Token: 0x17003703 RID: 14083
		// (get) Token: 0x0600D5AB RID: 54699 RVA: 0x00318D14 File Offset: 0x00316F14
		public string PropertyNodeIcon
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D5AC RID: 54700 RVA: 0x00318D4C File Offset: 0x00316F4C
		public Span<byte> GetPropertyNodeIconBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600D5AD RID: 54701 RVA: 0x00318D5C File Offset: 0x00316F5C
		public byte[] GetPropertyNodeIconArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D5AE RID: 54702 RVA: 0x00318D74 File Offset: 0x00316F74
		public ConfigPropValue? Property(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new ConfigPropValue?(default(ConfigPropValue).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003704 RID: 14084
		// (get) Token: 0x0600D5AF RID: 54703 RVA: 0x00318DD8 File Offset: 0x00316FD8
		public int PropertyLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D5B0 RID: 54704 RVA: 0x00318E04 File Offset: 0x00317004
		public DicIntInt? Consume(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003705 RID: 14085
		// (get) Token: 0x0600D5B1 RID: 54705 RVA: 0x00318E68 File Offset: 0x00317068
		public int ConsumeLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003706 RID: 14086
		// (get) Token: 0x0600D5B2 RID: 54706 RVA: 0x00318E94 File Offset: 0x00317094
		public int UnLockCondition
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D5B3 RID: 54707 RVA: 0x00318ED4 File Offset: 0x003170D4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ConditionIter()或GetConditionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Condition()
		{
			SkillTree skillTree = this;
			return skillTree.GetConditionArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D5B4 RID: 54708 RVA: 0x00318EF8 File Offset: 0x003170F8
		[NullableContext(1)]
		public readonly IEnumerable<int> ConditionIter()
		{
			SkillTree.<ConditionIter>d__62 <ConditionIter>d__ = new SkillTree.<ConditionIter>d__62(-2);
			<ConditionIter>d__.<>3__<>4__this = this;
			return <ConditionIter>d__;
		}

		// Token: 0x0600D5B5 RID: 54709 RVA: 0x00318F10 File Offset: 0x00317110
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ConsumeFrozenDict()缓存字典，遍历请使用ConsumeIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Consume()
		{
			return this.ConsumeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D5B6 RID: 54710 RVA: 0x00318F66 File Offset: 0x00317166
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ConsumeIter()
		{
			SkillTree.<ConsumeIter>d__64 <ConsumeIter>d__ = new SkillTree.<ConsumeIter>d__64(-2);
			<ConsumeIter>d__.<>3__<>4__this = this;
			return <ConsumeIter>d__;
		}

		// Token: 0x0600D5B7 RID: 54711 RVA: 0x00318F7C File Offset: 0x0031717C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ParentNodesIter()或GetParentNodesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ParentNodes()
		{
			SkillTree skillTree = this;
			return skillTree.GetParentNodesArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D5B8 RID: 54712 RVA: 0x00318FA0 File Offset: 0x003171A0
		[NullableContext(1)]
		public readonly IEnumerable<int> ParentNodesIter()
		{
			SkillTree.<ParentNodesIter>d__66 <ParentNodesIter>d__ = new SkillTree.<ParentNodesIter>d__66(-2);
			<ParentNodesIter>d__.<>3__<>4__this = this;
			return <ParentNodesIter>d__;
		}

		// Token: 0x0600D5B9 RID: 54713 RVA: 0x00318FB5 File Offset: 0x003171B5
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PropertyIter()或GetPropertyBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly ConfigPropValue[] Property()
		{
			return this.PropertyIter().ToArray<ConfigPropValue>();
		}

		// Token: 0x0600D5BA RID: 54714 RVA: 0x00318FC2 File Offset: 0x003171C2
		[NullableContext(1)]
		public readonly IEnumerable<ConfigPropValue> PropertyIter()
		{
			SkillTree.<PropertyIter>d__68 <PropertyIter>d__ = new SkillTree.<PropertyIter>d__68(-2);
			<PropertyIter>d__.<>3__<>4__this = this;
			return <PropertyIter>d__;
		}

		// Token: 0x0600D5BB RID: 54715 RVA: 0x00318FD7 File Offset: 0x003171D7
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PropertyNodeParamIter()或GetPropertyNodeParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] PropertyNodeParam()
		{
			return this.PropertyNodeParamIter().ToArray<string>();
		}

		// Token: 0x0600D5BC RID: 54716 RVA: 0x00318FE4 File Offset: 0x003171E4
		[NullableContext(1)]
		public readonly IEnumerable<string> PropertyNodeParamIter()
		{
			SkillTree.<PropertyNodeParamIter>d__70 <PropertyNodeParamIter>d__ = new SkillTree.<PropertyNodeParamIter>d__70(-2);
			<PropertyNodeParamIter>d__.<>3__<>4__this = this;
			return <PropertyNodeParamIter>d__;
		}

		// Token: 0x0600D5BD RID: 54717 RVA: 0x00318FF9 File Offset: 0x003171F9
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillBranchDescListIter()或GetSkillBranchDescListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SkillBranchDescList()
		{
			return this.SkillBranchDescListIter().ToArray<string>();
		}

		// Token: 0x0600D5BE RID: 54718 RVA: 0x00319006 File Offset: 0x00317206
		[NullableContext(1)]
		public readonly IEnumerable<string> SkillBranchDescListIter()
		{
			SkillTree.<SkillBranchDescListIter>d__72 <SkillBranchDescListIter>d__ = new SkillTree.<SkillBranchDescListIter>d__72(-2);
			<SkillBranchDescListIter>d__.<>3__<>4__this = this;
			return <SkillBranchDescListIter>d__;
		}

		// Token: 0x0600D5BF RID: 54719 RVA: 0x0031901C File Offset: 0x0031721C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillBranchIdsIter()或GetSkillBranchIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SkillBranchIds()
		{
			SkillTree skillTree = this;
			return skillTree.GetSkillBranchIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D5C0 RID: 54720 RVA: 0x00319040 File Offset: 0x00317240
		[NullableContext(1)]
		public readonly IEnumerable<int> SkillBranchIdsIter()
		{
			SkillTree.<SkillBranchIdsIter>d__74 <SkillBranchIdsIter>d__ = new SkillTree.<SkillBranchIdsIter>d__74(-2);
			<SkillBranchIdsIter>d__.<>3__<>4__this = this;
			return <SkillBranchIdsIter>d__;
		}

		// Token: 0x0600D5C1 RID: 54721 RVA: 0x00319058 File Offset: 0x00317258
		public int? GetConsume(int key)
		{
			this.EnsureConsumeCacheIfNeeded();
			int value;
			if (!this.ConsumeCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600D5C2 RID: 54722 RVA: 0x0031908C File Offset: 0x0031728C
		private void EnsureConsumeCacheIfNeeded()
		{
			if (this.ConsumeCache != null)
			{
				return;
			}
			this.ConsumeCache = this.ConsumeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D5C3 RID: 54723 RVA: 0x003190F2 File Offset: 0x003172F2
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetConsumeFrozenDict(int key)
		{
			this.EnsureConsumeCacheIfNeeded();
			return this.ConsumeCache;
		}

		// Token: 0x040051F3 RID: 20979
		private Table __p;

		// Token: 0x040051F4 RID: 20980
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeCache;
	}
}
