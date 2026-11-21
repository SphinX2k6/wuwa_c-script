using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011B2 RID: 4530
	[NullableContext(1)]
	[Nullable(0)]
	public struct SkillButton : IFlatbufferObject
	{
		// Token: 0x17003765 RID: 14181
		// (get) Token: 0x0600DB1E RID: 56094 RVA: 0x00331B24 File Offset: 0x0032FD24
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DB1F RID: 56095 RVA: 0x00331B31 File Offset: 0x0032FD31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DB20 RID: 56096 RVA: 0x00331B38 File Offset: 0x0032FD38
		[NullableContext(0)]
		public static SkillButton GetRootAsSkillButton(ByteBuffer _bb)
		{
			return SkillButton.GetRootAsSkillButton(_bb, default(SkillButton));
		}

		// Token: 0x0600DB21 RID: 56097 RVA: 0x00331B54 File Offset: 0x0032FD54
		[NullableContext(0)]
		public static SkillButton GetRootAsSkillButton(ByteBuffer _bb, SkillButton obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DB22 RID: 56098 RVA: 0x00331B71 File Offset: 0x0032FD71
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DB23 RID: 56099 RVA: 0x00331B80 File Offset: 0x0032FD80
		[NullableContext(0)]
		public SkillButton __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003766 RID: 14182
		// (get) Token: 0x0600DB24 RID: 56100 RVA: 0x00331B90 File Offset: 0x0032FD90
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

		// Token: 0x17003767 RID: 14183
		// (get) Token: 0x0600DB25 RID: 56101 RVA: 0x00331BCC File Offset: 0x0032FDCC
		public int RoleId
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

		// Token: 0x17003768 RID: 14184
		// (get) Token: 0x0600DB26 RID: 56102 RVA: 0x00331C08 File Offset: 0x0032FE08
		[Nullable(0)]
		public string Name
		{
			[NullableContext(0)]
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DB27 RID: 56103 RVA: 0x00331C3F File Offset: 0x0032FE3F
		[NullableContext(0)]
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DB28 RID: 56104 RVA: 0x00331C4E File Offset: 0x0032FE4E
		[NullableContext(0)]
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003769 RID: 14185
		// (get) Token: 0x0600DB29 RID: 56105 RVA: 0x00331C68 File Offset: 0x0032FE68
		public int ButtonType
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

		// Token: 0x1700376A RID: 14186
		// (get) Token: 0x0600DB2A RID: 56106 RVA: 0x00331CA8 File Offset: 0x0032FEA8
		public int ActionType
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

		// Token: 0x1700376B RID: 14187
		// (get) Token: 0x0600DB2B RID: 56107 RVA: 0x00331CE8 File Offset: 0x0032FEE8
		public int SkillId
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

		// Token: 0x0600DB2C RID: 56108 RVA: 0x00331D28 File Offset: 0x0032FF28
		public DicIntInt? SkillIdTagMap(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700376C RID: 14188
		// (get) Token: 0x0600DB2D RID: 56109 RVA: 0x00331D8C File Offset: 0x0032FF8C
		public int SkillIdTagMapLength
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

		// Token: 0x0600DB2E RID: 56110 RVA: 0x00331DB8 File Offset: 0x0032FFB8
		public int SkillIconTags(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700376D RID: 14189
		// (get) Token: 0x0600DB2F RID: 56111 RVA: 0x00331DF8 File Offset: 0x0032FFF8
		public int SkillIconTagsLength
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

		// Token: 0x0600DB30 RID: 56112 RVA: 0x00331E24 File Offset: 0x00330024
		[NullableContext(0)]
		public Span<int> GetSkillIconTagsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600DB31 RID: 56113 RVA: 0x00331E34 File Offset: 0x00330034
		[NullableContext(0)]
		public int[] GetSkillIconTagsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600DB32 RID: 56114 RVA: 0x00331E4C File Offset: 0x0033004C
		public int EnableTags(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700376E RID: 14190
		// (get) Token: 0x0600DB33 RID: 56115 RVA: 0x00331E8C File Offset: 0x0033008C
		public int EnableTagsLength
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

		// Token: 0x0600DB34 RID: 56116 RVA: 0x00331EB8 File Offset: 0x003300B8
		[NullableContext(0)]
		public Span<int> GetEnableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600DB35 RID: 56117 RVA: 0x00331EC8 File Offset: 0x003300C8
		[NullableContext(0)]
		public int[] GetEnableTagsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600DB36 RID: 56118 RVA: 0x00331EE0 File Offset: 0x003300E0
		public int DisableTags(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700376F RID: 14191
		// (get) Token: 0x0600DB37 RID: 56119 RVA: 0x00331F20 File Offset: 0x00330120
		public int DisableTagsLength
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

		// Token: 0x0600DB38 RID: 56120 RVA: 0x00331F4C File Offset: 0x0033014C
		[NullableContext(0)]
		public Span<int> GetDisableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600DB39 RID: 56121 RVA: 0x00331F5C File Offset: 0x0033015C
		[NullableContext(0)]
		public int[] GetDisableTagsArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600DB3A RID: 56122 RVA: 0x00331F74 File Offset: 0x00330174
		public DicIntIntArray? DisableSkillIdTags(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003770 RID: 14192
		// (get) Token: 0x0600DB3B RID: 56123 RVA: 0x00331FD8 File Offset: 0x003301D8
		public int DisableSkillIdTagsLength
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

		// Token: 0x0600DB3C RID: 56124 RVA: 0x00332004 File Offset: 0x00330204
		public int VisibleTags(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003771 RID: 14193
		// (get) Token: 0x0600DB3D RID: 56125 RVA: 0x00332044 File Offset: 0x00330244
		public int VisibleTagsLength
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

		// Token: 0x0600DB3E RID: 56126 RVA: 0x00332070 File Offset: 0x00330270
		[NullableContext(0)]
		public Span<int> GetVisibleTagsBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600DB3F RID: 56127 RVA: 0x00332080 File Offset: 0x00330280
		[NullableContext(0)]
		public int[] GetVisibleTagsArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x0600DB40 RID: 56128 RVA: 0x00332098 File Offset: 0x00330298
		public int HiddenTags(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003772 RID: 14194
		// (get) Token: 0x0600DB41 RID: 56129 RVA: 0x003320D8 File Offset: 0x003302D8
		public int HiddenTagsLength
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

		// Token: 0x0600DB42 RID: 56130 RVA: 0x00332104 File Offset: 0x00330304
		[NullableContext(0)]
		public Span<int> GetHiddenTagsBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600DB43 RID: 56131 RVA: 0x00332114 File Offset: 0x00330314
		[NullableContext(0)]
		public int[] GetHiddenTagsArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x17003773 RID: 14195
		// (get) Token: 0x0600DB44 RID: 56132 RVA: 0x0033212C File Offset: 0x0033032C
		public bool IsCdVisible
		{
			get
			{
				int num = this.__p.__offset(30);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003774 RID: 14196
		// (get) Token: 0x0600DB45 RID: 56133 RVA: 0x0033216C File Offset: 0x0033036C
		public int AttributeId
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

		// Token: 0x17003775 RID: 14197
		// (get) Token: 0x0600DB46 RID: 56134 RVA: 0x003321AC File Offset: 0x003303AC
		public int MaxAttributeId
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DB47 RID: 56135 RVA: 0x003321EC File Offset: 0x003303EC
		public DicIntIntArray? AttributeIdTagMap(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003776 RID: 14198
		// (get) Token: 0x0600DB48 RID: 56136 RVA: 0x00332250 File Offset: 0x00330450
		public int AttributeIdTagMapLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DB49 RID: 56137 RVA: 0x0033227C File Offset: 0x0033047C
		public int AttributeEnableTags(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003777 RID: 14199
		// (get) Token: 0x0600DB4A RID: 56138 RVA: 0x003322BC File Offset: 0x003304BC
		public int AttributeEnableTagsLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DB4B RID: 56139 RVA: 0x003322E8 File Offset: 0x003304E8
		[NullableContext(0)]
		public Span<int> GetAttributeEnableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x0600DB4C RID: 56140 RVA: 0x003322F8 File Offset: 0x003304F8
		[NullableContext(0)]
		public int[] GetAttributeEnableTagsArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x0600DB4D RID: 56141 RVA: 0x00332310 File Offset: 0x00330510
		public DicIntInt? FormationAttributeIdTagMap(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003778 RID: 14200
		// (get) Token: 0x0600DB4E RID: 56142 RVA: 0x00332374 File Offset: 0x00330574
		public int FormationAttributeIdTagMapLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003779 RID: 14201
		// (get) Token: 0x0600DB4F RID: 56143 RVA: 0x003323A0 File Offset: 0x003305A0
		public int MaxAttributeBurstEffectId
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

		// Token: 0x1700377A RID: 14202
		// (get) Token: 0x0600DB50 RID: 56144 RVA: 0x003323E0 File Offset: 0x003305E0
		public int CdCompletedEffectId
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700377B RID: 14203
		// (get) Token: 0x0600DB51 RID: 56145 RVA: 0x00332420 File Offset: 0x00330620
		public bool IsLongPressControlCamera
		{
			get
			{
				int num = this.__p.__offset(46);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700377C RID: 14204
		// (get) Token: 0x0600DB52 RID: 56146 RVA: 0x00332460 File Offset: 0x00330660
		public int LongPressTime
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DB53 RID: 56147 RVA: 0x003324A0 File Offset: 0x003306A0
		public DicIntInt? DynamicEffectTagMap(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700377D RID: 14205
		// (get) Token: 0x0600DB54 RID: 56148 RVA: 0x00332504 File Offset: 0x00330704
		public int DynamicEffectTagMapLength
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700377E RID: 14206
		// (get) Token: 0x0600DB55 RID: 56149 RVA: 0x00332530 File Offset: 0x00330730
		public int CustomHandleId
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DB56 RID: 56150 RVA: 0x00332570 File Offset: 0x00330770
		public int CustomHandleIds(int j)
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700377F RID: 14207
		// (get) Token: 0x0600DB57 RID: 56151 RVA: 0x003325B0 File Offset: 0x003307B0
		public int CustomHandleIdsLength
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DB58 RID: 56152 RVA: 0x003325DC File Offset: 0x003307DC
		[NullableContext(0)]
		public Span<int> GetCustomHandleIdsBytes()
		{
			return this.__p.__vector_as_span<int>(54, 4);
		}

		// Token: 0x0600DB59 RID: 56153 RVA: 0x003325EC File Offset: 0x003307EC
		[NullableContext(0)]
		public int[] GetCustomHandleIdsArray()
		{
			return this.__p.__vector_as_array<int>(54) ?? Array.Empty<int>();
		}

		// Token: 0x0600DB5A RID: 56154 RVA: 0x00332604 File Offset: 0x00330804
		public int ShowLongPressTags(int j)
		{
			int num = this.__p.__offset(56);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003780 RID: 14208
		// (get) Token: 0x0600DB5B RID: 56155 RVA: 0x00332644 File Offset: 0x00330844
		public int ShowLongPressTagsLength
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DB5C RID: 56156 RVA: 0x00332670 File Offset: 0x00330870
		[NullableContext(0)]
		public Span<int> GetShowLongPressTagsBytes()
		{
			return this.__p.__vector_as_span<int>(56, 4);
		}

		// Token: 0x0600DB5D RID: 56157 RVA: 0x00332680 File Offset: 0x00330880
		[NullableContext(0)]
		public int[] GetShowLongPressTagsArray()
		{
			return this.__p.__vector_as_array<int>(56) ?? Array.Empty<int>();
		}

		// Token: 0x0600DB5E RID: 56158 RVA: 0x00332698 File Offset: 0x00330898
		public int[] AttributeEnableTags()
		{
			return this.GetAttributeEnableTagsArray();
		}

		// Token: 0x0600DB5F RID: 56159 RVA: 0x003326A0 File Offset: 0x003308A0
		public IEnumerable<int> AttributeEnableTagsIter()
		{
			SkillButton.<AttributeEnableTagsIter>d__94 <AttributeEnableTagsIter>d__ = new SkillButton.<AttributeEnableTagsIter>d__94(-2);
			<AttributeEnableTagsIter>d__.<>3__<>4__this = this;
			return <AttributeEnableTagsIter>d__;
		}

		// Token: 0x0600DB60 RID: 56160 RVA: 0x003326B8 File Offset: 0x003308B8
		public Dictionary<int, IntArray> AttributeIdTagMap()
		{
			return this.AttributeIdTagMapIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600DB61 RID: 56161 RVA: 0x0033270E File Offset: 0x0033090E
		public IEnumerable<DicIntIntArray> AttributeIdTagMapIter()
		{
			SkillButton.<AttributeIdTagMapIter>d__96 <AttributeIdTagMapIter>d__ = new SkillButton.<AttributeIdTagMapIter>d__96(-2);
			<AttributeIdTagMapIter>d__.<>3__<>4__this = this;
			return <AttributeIdTagMapIter>d__;
		}

		// Token: 0x0600DB62 RID: 56162 RVA: 0x00332723 File Offset: 0x00330923
		public int[] CustomHandleIds()
		{
			return this.GetCustomHandleIdsArray();
		}

		// Token: 0x0600DB63 RID: 56163 RVA: 0x0033272B File Offset: 0x0033092B
		public IEnumerable<int> CustomHandleIdsIter()
		{
			SkillButton.<CustomHandleIdsIter>d__98 <CustomHandleIdsIter>d__ = new SkillButton.<CustomHandleIdsIter>d__98(-2);
			<CustomHandleIdsIter>d__.<>3__<>4__this = this;
			return <CustomHandleIdsIter>d__;
		}

		// Token: 0x0600DB64 RID: 56164 RVA: 0x00332740 File Offset: 0x00330940
		public Dictionary<int, IntArray> DisableSkillIdTags()
		{
			return this.DisableSkillIdTagsIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600DB65 RID: 56165 RVA: 0x00332796 File Offset: 0x00330996
		public IEnumerable<DicIntIntArray> DisableSkillIdTagsIter()
		{
			SkillButton.<DisableSkillIdTagsIter>d__100 <DisableSkillIdTagsIter>d__ = new SkillButton.<DisableSkillIdTagsIter>d__100(-2);
			<DisableSkillIdTagsIter>d__.<>3__<>4__this = this;
			return <DisableSkillIdTagsIter>d__;
		}

		// Token: 0x0600DB66 RID: 56166 RVA: 0x003327AB File Offset: 0x003309AB
		public int[] DisableTags()
		{
			return this.GetDisableTagsArray();
		}

		// Token: 0x0600DB67 RID: 56167 RVA: 0x003327B3 File Offset: 0x003309B3
		public IEnumerable<int> DisableTagsIter()
		{
			SkillButton.<DisableTagsIter>d__102 <DisableTagsIter>d__ = new SkillButton.<DisableTagsIter>d__102(-2);
			<DisableTagsIter>d__.<>3__<>4__this = this;
			return <DisableTagsIter>d__;
		}

		// Token: 0x0600DB68 RID: 56168 RVA: 0x003327C8 File Offset: 0x003309C8
		public Dictionary<int, int> DynamicEffectTagMap()
		{
			return this.DynamicEffectTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DB69 RID: 56169 RVA: 0x0033281E File Offset: 0x00330A1E
		public IEnumerable<DicIntInt> DynamicEffectTagMapIter()
		{
			SkillButton.<DynamicEffectTagMapIter>d__104 <DynamicEffectTagMapIter>d__ = new SkillButton.<DynamicEffectTagMapIter>d__104(-2);
			<DynamicEffectTagMapIter>d__.<>3__<>4__this = this;
			return <DynamicEffectTagMapIter>d__;
		}

		// Token: 0x0600DB6A RID: 56170 RVA: 0x00332833 File Offset: 0x00330A33
		public int[] EnableTags()
		{
			return this.GetEnableTagsArray();
		}

		// Token: 0x0600DB6B RID: 56171 RVA: 0x0033283B File Offset: 0x00330A3B
		public IEnumerable<int> EnableTagsIter()
		{
			SkillButton.<EnableTagsIter>d__106 <EnableTagsIter>d__ = new SkillButton.<EnableTagsIter>d__106(-2);
			<EnableTagsIter>d__.<>3__<>4__this = this;
			return <EnableTagsIter>d__;
		}

		// Token: 0x0600DB6C RID: 56172 RVA: 0x00332850 File Offset: 0x00330A50
		public Dictionary<int, int> FormationAttributeIdTagMap()
		{
			return this.FormationAttributeIdTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DB6D RID: 56173 RVA: 0x003328A6 File Offset: 0x00330AA6
		public IEnumerable<DicIntInt> FormationAttributeIdTagMapIter()
		{
			SkillButton.<FormationAttributeIdTagMapIter>d__108 <FormationAttributeIdTagMapIter>d__ = new SkillButton.<FormationAttributeIdTagMapIter>d__108(-2);
			<FormationAttributeIdTagMapIter>d__.<>3__<>4__this = this;
			return <FormationAttributeIdTagMapIter>d__;
		}

		// Token: 0x0600DB6E RID: 56174 RVA: 0x003328BB File Offset: 0x00330ABB
		public int[] HiddenTags()
		{
			return this.GetHiddenTagsArray();
		}

		// Token: 0x0600DB6F RID: 56175 RVA: 0x003328C3 File Offset: 0x00330AC3
		public IEnumerable<int> HiddenTagsIter()
		{
			SkillButton.<HiddenTagsIter>d__110 <HiddenTagsIter>d__ = new SkillButton.<HiddenTagsIter>d__110(-2);
			<HiddenTagsIter>d__.<>3__<>4__this = this;
			return <HiddenTagsIter>d__;
		}

		// Token: 0x0600DB70 RID: 56176 RVA: 0x003328D8 File Offset: 0x00330AD8
		public int[] ShowLongPressTags()
		{
			return this.GetShowLongPressTagsArray();
		}

		// Token: 0x0600DB71 RID: 56177 RVA: 0x003328E0 File Offset: 0x00330AE0
		public IEnumerable<int> ShowLongPressTagsIter()
		{
			SkillButton.<ShowLongPressTagsIter>d__112 <ShowLongPressTagsIter>d__ = new SkillButton.<ShowLongPressTagsIter>d__112(-2);
			<ShowLongPressTagsIter>d__.<>3__<>4__this = this;
			return <ShowLongPressTagsIter>d__;
		}

		// Token: 0x0600DB72 RID: 56178 RVA: 0x003328F5 File Offset: 0x00330AF5
		public int[] SkillIconTags()
		{
			return this.GetSkillIconTagsArray();
		}

		// Token: 0x0600DB73 RID: 56179 RVA: 0x003328FD File Offset: 0x00330AFD
		public IEnumerable<int> SkillIconTagsIter()
		{
			SkillButton.<SkillIconTagsIter>d__114 <SkillIconTagsIter>d__ = new SkillButton.<SkillIconTagsIter>d__114(-2);
			<SkillIconTagsIter>d__.<>3__<>4__this = this;
			return <SkillIconTagsIter>d__;
		}

		// Token: 0x0600DB74 RID: 56180 RVA: 0x00332914 File Offset: 0x00330B14
		public Dictionary<int, int> SkillIdTagMap()
		{
			return this.SkillIdTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DB75 RID: 56181 RVA: 0x0033296A File Offset: 0x00330B6A
		public IEnumerable<DicIntInt> SkillIdTagMapIter()
		{
			SkillButton.<SkillIdTagMapIter>d__116 <SkillIdTagMapIter>d__ = new SkillButton.<SkillIdTagMapIter>d__116(-2);
			<SkillIdTagMapIter>d__.<>3__<>4__this = this;
			return <SkillIdTagMapIter>d__;
		}

		// Token: 0x0600DB76 RID: 56182 RVA: 0x0033297F File Offset: 0x00330B7F
		public int[] VisibleTags()
		{
			return this.GetVisibleTagsArray();
		}

		// Token: 0x0600DB77 RID: 56183 RVA: 0x00332987 File Offset: 0x00330B87
		public IEnumerable<int> VisibleTagsIter()
		{
			SkillButton.<VisibleTagsIter>d__118 <VisibleTagsIter>d__ = new SkillButton.<VisibleTagsIter>d__118(-2);
			<VisibleTagsIter>d__.<>3__<>4__this = this;
			return <VisibleTagsIter>d__;
		}

		// Token: 0x0600DB78 RID: 56184 RVA: 0x0033299C File Offset: 0x00330B9C
		public IntArray? GetAttributeIdTagMap(int key)
		{
			this.EnsureAttributeIdTagMapCacheIfNeeded();
			IntArray value;
			if (!this.AttributeIdTagMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600DB79 RID: 56185 RVA: 0x003329D0 File Offset: 0x00330BD0
		public IntArray? GetDisableSkillIdTags(int key)
		{
			this.EnsureDisableSkillIdTagsCacheIfNeeded();
			IntArray value;
			if (!this.DisableSkillIdTagsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600DB7A RID: 56186 RVA: 0x00332A04 File Offset: 0x00330C04
		public int? GetDynamicEffectTagMap(int key)
		{
			this.EnsureDynamicEffectTagMapCacheIfNeeded();
			int value;
			if (!this.DynamicEffectTagMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600DB7B RID: 56187 RVA: 0x00332A38 File Offset: 0x00330C38
		public int? GetFormationAttributeIdTagMap(int key)
		{
			this.EnsureFormationAttributeIdTagMapCacheIfNeeded();
			int value;
			if (!this.FormationAttributeIdTagMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600DB7C RID: 56188 RVA: 0x00332A6C File Offset: 0x00330C6C
		public int? GetSkillIdTagMap(int key)
		{
			this.EnsureSkillIdTagMapCacheIfNeeded();
			int value;
			if (!this.SkillIdTagMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600DB7D RID: 56189 RVA: 0x00332AA0 File Offset: 0x00330CA0
		private void EnsureAttributeIdTagMapCacheIfNeeded()
		{
			if (this.AttributeIdTagMapCache != null)
			{
				return;
			}
			this.AttributeIdTagMapCache = this.AttributeIdTagMapIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600DB7E RID: 56190 RVA: 0x00332B08 File Offset: 0x00330D08
		private void EnsureDisableSkillIdTagsCacheIfNeeded()
		{
			if (this.DisableSkillIdTagsCache != null)
			{
				return;
			}
			this.DisableSkillIdTagsCache = this.DisableSkillIdTagsIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600DB7F RID: 56191 RVA: 0x00332B70 File Offset: 0x00330D70
		private void EnsureDynamicEffectTagMapCacheIfNeeded()
		{
			if (this.DynamicEffectTagMapCache != null)
			{
				return;
			}
			this.DynamicEffectTagMapCache = this.DynamicEffectTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DB80 RID: 56192 RVA: 0x00332BD8 File Offset: 0x00330DD8
		private void EnsureFormationAttributeIdTagMapCacheIfNeeded()
		{
			if (this.FormationAttributeIdTagMapCache != null)
			{
				return;
			}
			this.FormationAttributeIdTagMapCache = this.FormationAttributeIdTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DB81 RID: 56193 RVA: 0x00332C40 File Offset: 0x00330E40
		private void EnsureSkillIdTagMapCacheIfNeeded()
		{
			if (this.SkillIdTagMapCache != null)
			{
				return;
			}
			this.SkillIdTagMapCache = this.SkillIdTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DB82 RID: 56194 RVA: 0x00332CA6 File Offset: 0x00330EA6
		public FrozenDictionary<int, IntArray> GetAttributeIdTagMapFrozenDict()
		{
			this.EnsureAttributeIdTagMapCacheIfNeeded();
			return this.AttributeIdTagMapCache;
		}

		// Token: 0x0600DB83 RID: 56195 RVA: 0x00332CB4 File Offset: 0x00330EB4
		public FrozenDictionary<int, IntArray> GetDisableSkillIdTagsFrozenDict()
		{
			this.EnsureDisableSkillIdTagsCacheIfNeeded();
			return this.DisableSkillIdTagsCache;
		}

		// Token: 0x0600DB84 RID: 56196 RVA: 0x00332CC2 File Offset: 0x00330EC2
		public FrozenDictionary<int, int> GetDynamicEffectTagMapFrozenDict()
		{
			this.EnsureDynamicEffectTagMapCacheIfNeeded();
			return this.DynamicEffectTagMapCache;
		}

		// Token: 0x0600DB85 RID: 56197 RVA: 0x00332CD0 File Offset: 0x00330ED0
		public FrozenDictionary<int, int> GetFormationAttributeIdTagMapFrozenDict()
		{
			this.EnsureFormationAttributeIdTagMapCacheIfNeeded();
			return this.FormationAttributeIdTagMapCache;
		}

		// Token: 0x0600DB86 RID: 56198 RVA: 0x00332CDE File Offset: 0x00330EDE
		public FrozenDictionary<int, int> GetSkillIdTagMapFrozenDict()
		{
			this.EnsureSkillIdTagMapCacheIfNeeded();
			return this.SkillIdTagMapCache;
		}

		// Token: 0x040057CB RID: 22475
		private Table __p;

		// Token: 0x040057CC RID: 22476
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> AttributeIdTagMapCache;

		// Token: 0x040057CD RID: 22477
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> DisableSkillIdTagsCache;

		// Token: 0x040057CE RID: 22478
		[Nullable(2)]
		private FrozenDictionary<int, int> DynamicEffectTagMapCache;

		// Token: 0x040057CF RID: 22479
		[Nullable(2)]
		private FrozenDictionary<int, int> FormationAttributeIdTagMapCache;

		// Token: 0x040057D0 RID: 22480
		[Nullable(2)]
		private FrozenDictionary<int, int> SkillIdTagMapCache;
	}
}
