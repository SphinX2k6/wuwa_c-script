using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011C1 RID: 4545
	public struct SkillTree : IFlatbufferObject
	{
		// Token: 0x17003806 RID: 14342
		// (get) Token: 0x0600DD66 RID: 56678 RVA: 0x0033792A File Offset: 0x00335B2A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DD67 RID: 56679 RVA: 0x00337937 File Offset: 0x00335B37
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DD68 RID: 56680 RVA: 0x00337940 File Offset: 0x00335B40
		public static SkillTree GetRootAsSkillTree(ByteBuffer _bb)
		{
			return SkillTree.GetRootAsSkillTree(_bb, default(SkillTree));
		}

		// Token: 0x0600DD69 RID: 56681 RVA: 0x0033795C File Offset: 0x00335B5C
		public static SkillTree GetRootAsSkillTree(ByteBuffer _bb, SkillTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DD6A RID: 56682 RVA: 0x00337979 File Offset: 0x00335B79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DD6B RID: 56683 RVA: 0x00337988 File Offset: 0x00335B88
		public SkillTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003807 RID: 14343
		// (get) Token: 0x0600DD6C RID: 56684 RVA: 0x00337998 File Offset: 0x00335B98
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

		// Token: 0x17003808 RID: 14344
		// (get) Token: 0x0600DD6D RID: 56685 RVA: 0x003379D4 File Offset: 0x00335BD4
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

		// Token: 0x17003809 RID: 14345
		// (get) Token: 0x0600DD6E RID: 56686 RVA: 0x00337A10 File Offset: 0x00335C10
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

		// Token: 0x0600DD6F RID: 56687 RVA: 0x00337A4C File Offset: 0x00335C4C
		public int ParentNodes(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700380A RID: 14346
		// (get) Token: 0x0600DD70 RID: 56688 RVA: 0x00337A8C File Offset: 0x00335C8C
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

		// Token: 0x0600DD71 RID: 56689 RVA: 0x00337AB8 File Offset: 0x00335CB8
		public Span<int> GetParentNodesBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600DD72 RID: 56690 RVA: 0x00337AC8 File Offset: 0x00335CC8
		public int[] GetParentNodesArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x1700380B RID: 14347
		// (get) Token: 0x0600DD73 RID: 56691 RVA: 0x00337AE0 File Offset: 0x00335CE0
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

		// Token: 0x1700380C RID: 14348
		// (get) Token: 0x0600DD74 RID: 56692 RVA: 0x00337B20 File Offset: 0x00335D20
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

		// Token: 0x0600DD75 RID: 56693 RVA: 0x00337B60 File Offset: 0x00335D60
		public int Condition(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700380D RID: 14349
		// (get) Token: 0x0600DD76 RID: 56694 RVA: 0x00337BA0 File Offset: 0x00335DA0
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

		// Token: 0x0600DD77 RID: 56695 RVA: 0x00337BCC File Offset: 0x00335DCC
		public Span<int> GetConditionBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600DD78 RID: 56696 RVA: 0x00337BDC File Offset: 0x00335DDC
		public int[] GetConditionArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x1700380E RID: 14350
		// (get) Token: 0x0600DD79 RID: 56697 RVA: 0x00337BF4 File Offset: 0x00335DF4
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

		// Token: 0x0600DD7A RID: 56698 RVA: 0x00337C34 File Offset: 0x00335E34
		public int SkillBranchIds(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700380F RID: 14351
		// (get) Token: 0x0600DD7B RID: 56699 RVA: 0x00337C74 File Offset: 0x00335E74
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

		// Token: 0x0600DD7C RID: 56700 RVA: 0x00337CA0 File Offset: 0x00335EA0
		public Span<int> GetSkillBranchIdsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600DD7D RID: 56701 RVA: 0x00337CB0 File Offset: 0x00335EB0
		public int[] GetSkillBranchIdsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600DD7E RID: 56702 RVA: 0x00337CC8 File Offset: 0x00335EC8
		public string SkillBranchDescList(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003810 RID: 14352
		// (get) Token: 0x0600DD7F RID: 56703 RVA: 0x00337D04 File Offset: 0x00335F04
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

		// Token: 0x17003811 RID: 14353
		// (get) Token: 0x0600DD80 RID: 56704 RVA: 0x00337D30 File Offset: 0x00335F30
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

		// Token: 0x0600DD81 RID: 56705 RVA: 0x00337D68 File Offset: 0x00335F68
		public Span<byte> GetPropertyNodeTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600DD82 RID: 56706 RVA: 0x00337D78 File Offset: 0x00335F78
		public byte[] GetPropertyNodeTitleArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17003812 RID: 14354
		// (get) Token: 0x0600DD83 RID: 56707 RVA: 0x00337D90 File Offset: 0x00335F90
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

		// Token: 0x0600DD84 RID: 56708 RVA: 0x00337DC8 File Offset: 0x00335FC8
		public Span<byte> GetPropertyNodeDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600DD85 RID: 56709 RVA: 0x00337DD8 File Offset: 0x00335FD8
		public byte[] GetPropertyNodeDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DD86 RID: 56710 RVA: 0x00337DF0 File Offset: 0x00335FF0
		public string PropertyNodeParam(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003813 RID: 14355
		// (get) Token: 0x0600DD87 RID: 56711 RVA: 0x00337E2C File Offset: 0x0033602C
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

		// Token: 0x17003814 RID: 14356
		// (get) Token: 0x0600DD88 RID: 56712 RVA: 0x00337E58 File Offset: 0x00336058
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

		// Token: 0x0600DD89 RID: 56713 RVA: 0x00337E90 File Offset: 0x00336090
		public Span<byte> GetPropertyNodeIconBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600DD8A RID: 56714 RVA: 0x00337EA0 File Offset: 0x003360A0
		public byte[] GetPropertyNodeIconArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DD8B RID: 56715 RVA: 0x00337EB8 File Offset: 0x003360B8
		public ConfigPropValue? Property(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new ConfigPropValue?(default(ConfigPropValue).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003815 RID: 14357
		// (get) Token: 0x0600DD8C RID: 56716 RVA: 0x00337F1C File Offset: 0x0033611C
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

		// Token: 0x0600DD8D RID: 56717 RVA: 0x00337F48 File Offset: 0x00336148
		public DicIntInt? Consume(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003816 RID: 14358
		// (get) Token: 0x0600DD8E RID: 56718 RVA: 0x00337FAC File Offset: 0x003361AC
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

		// Token: 0x17003817 RID: 14359
		// (get) Token: 0x0600DD8F RID: 56719 RVA: 0x00337FD8 File Offset: 0x003361D8
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

		// Token: 0x0600DD90 RID: 56720 RVA: 0x00338015 File Offset: 0x00336215
		[NullableContext(1)]
		public int[] Condition()
		{
			return this.GetConditionArray();
		}

		// Token: 0x0600DD91 RID: 56721 RVA: 0x0033801D File Offset: 0x0033621D
		[NullableContext(1)]
		public IEnumerable<int> ConditionIter()
		{
			SkillTree.<ConditionIter>d__62 <ConditionIter>d__ = new SkillTree.<ConditionIter>d__62(-2);
			<ConditionIter>d__.<>3__<>4__this = this;
			return <ConditionIter>d__;
		}

		// Token: 0x0600DD92 RID: 56722 RVA: 0x00338034 File Offset: 0x00336234
		[NullableContext(1)]
		public Dictionary<int, int> Consume()
		{
			return this.ConsumeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DD93 RID: 56723 RVA: 0x0033808A File Offset: 0x0033628A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ConsumeIter()
		{
			SkillTree.<ConsumeIter>d__64 <ConsumeIter>d__ = new SkillTree.<ConsumeIter>d__64(-2);
			<ConsumeIter>d__.<>3__<>4__this = this;
			return <ConsumeIter>d__;
		}

		// Token: 0x0600DD94 RID: 56724 RVA: 0x0033809F File Offset: 0x0033629F
		[NullableContext(1)]
		public int[] ParentNodes()
		{
			return this.GetParentNodesArray();
		}

		// Token: 0x0600DD95 RID: 56725 RVA: 0x003380A7 File Offset: 0x003362A7
		[NullableContext(1)]
		public IEnumerable<int> ParentNodesIter()
		{
			SkillTree.<ParentNodesIter>d__66 <ParentNodesIter>d__ = new SkillTree.<ParentNodesIter>d__66(-2);
			<ParentNodesIter>d__.<>3__<>4__this = this;
			return <ParentNodesIter>d__;
		}

		// Token: 0x0600DD96 RID: 56726 RVA: 0x003380BC File Offset: 0x003362BC
		[NullableContext(1)]
		public ConfigPropValue[] Property()
		{
			return this.PropertyIter().ToArray<ConfigPropValue>();
		}

		// Token: 0x0600DD97 RID: 56727 RVA: 0x003380C9 File Offset: 0x003362C9
		[NullableContext(1)]
		public IEnumerable<ConfigPropValue> PropertyIter()
		{
			SkillTree.<PropertyIter>d__68 <PropertyIter>d__ = new SkillTree.<PropertyIter>d__68(-2);
			<PropertyIter>d__.<>3__<>4__this = this;
			return <PropertyIter>d__;
		}

		// Token: 0x0600DD98 RID: 56728 RVA: 0x003380DE File Offset: 0x003362DE
		[NullableContext(1)]
		public string[] PropertyNodeParam()
		{
			return this.PropertyNodeParamIter().ToArray<string>();
		}

		// Token: 0x0600DD99 RID: 56729 RVA: 0x003380EB File Offset: 0x003362EB
		[NullableContext(1)]
		public IEnumerable<string> PropertyNodeParamIter()
		{
			SkillTree.<PropertyNodeParamIter>d__70 <PropertyNodeParamIter>d__ = new SkillTree.<PropertyNodeParamIter>d__70(-2);
			<PropertyNodeParamIter>d__.<>3__<>4__this = this;
			return <PropertyNodeParamIter>d__;
		}

		// Token: 0x0600DD9A RID: 56730 RVA: 0x00338100 File Offset: 0x00336300
		[NullableContext(1)]
		public string[] SkillBranchDescList()
		{
			return this.SkillBranchDescListIter().ToArray<string>();
		}

		// Token: 0x0600DD9B RID: 56731 RVA: 0x0033810D File Offset: 0x0033630D
		[NullableContext(1)]
		public IEnumerable<string> SkillBranchDescListIter()
		{
			SkillTree.<SkillBranchDescListIter>d__72 <SkillBranchDescListIter>d__ = new SkillTree.<SkillBranchDescListIter>d__72(-2);
			<SkillBranchDescListIter>d__.<>3__<>4__this = this;
			return <SkillBranchDescListIter>d__;
		}

		// Token: 0x0600DD9C RID: 56732 RVA: 0x00338122 File Offset: 0x00336322
		[NullableContext(1)]
		public int[] SkillBranchIds()
		{
			return this.GetSkillBranchIdsArray();
		}

		// Token: 0x0600DD9D RID: 56733 RVA: 0x0033812A File Offset: 0x0033632A
		[NullableContext(1)]
		public IEnumerable<int> SkillBranchIdsIter()
		{
			SkillTree.<SkillBranchIdsIter>d__74 <SkillBranchIdsIter>d__ = new SkillTree.<SkillBranchIdsIter>d__74(-2);
			<SkillBranchIdsIter>d__.<>3__<>4__this = this;
			return <SkillBranchIdsIter>d__;
		}

		// Token: 0x0600DD9E RID: 56734 RVA: 0x00338140 File Offset: 0x00336340
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

		// Token: 0x0600DD9F RID: 56735 RVA: 0x00338174 File Offset: 0x00336374
		private void EnsureConsumeCacheIfNeeded()
		{
			if (this.ConsumeCache != null)
			{
				return;
			}
			this.ConsumeCache = this.ConsumeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DDA0 RID: 56736 RVA: 0x003381DA File Offset: 0x003363DA
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetConsumeFrozenDict()
		{
			this.EnsureConsumeCacheIfNeeded();
			return this.ConsumeCache;
		}

		// Token: 0x040057F2 RID: 22514
		private Table __p;

		// Token: 0x040057F3 RID: 22515
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeCache;
	}
}
