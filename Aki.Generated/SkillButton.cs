using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010B7 RID: 4279
	public struct SkillButton : IFlatbufferObject
	{
		// Token: 0x17003654 RID: 13908
		// (get) Token: 0x0600D341 RID: 54081 RVA: 0x00312664 File Offset: 0x00310864
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D342 RID: 54082 RVA: 0x00312671 File Offset: 0x00310871
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D343 RID: 54083 RVA: 0x00312678 File Offset: 0x00310878
		public static SkillButton GetRootAsSkillButton(ByteBuffer _bb)
		{
			return SkillButton.GetRootAsSkillButton(_bb, default(SkillButton));
		}

		// Token: 0x0600D344 RID: 54084 RVA: 0x00312694 File Offset: 0x00310894
		public static SkillButton GetRootAsSkillButton(ByteBuffer _bb, SkillButton obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D345 RID: 54085 RVA: 0x003126B1 File Offset: 0x003108B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D346 RID: 54086 RVA: 0x003126C0 File Offset: 0x003108C0
		public SkillButton __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003655 RID: 13909
		// (get) Token: 0x0600D347 RID: 54087 RVA: 0x003126D0 File Offset: 0x003108D0
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

		// Token: 0x17003656 RID: 13910
		// (get) Token: 0x0600D348 RID: 54088 RVA: 0x0031270C File Offset: 0x0031090C
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

		// Token: 0x17003657 RID: 13911
		// (get) Token: 0x0600D349 RID: 54089 RVA: 0x00312748 File Offset: 0x00310948
		public string Name
		{
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

		// Token: 0x0600D34A RID: 54090 RVA: 0x0031277F File Offset: 0x0031097F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D34B RID: 54091 RVA: 0x0031278E File Offset: 0x0031098E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003658 RID: 13912
		// (get) Token: 0x0600D34C RID: 54092 RVA: 0x003127A8 File Offset: 0x003109A8
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

		// Token: 0x17003659 RID: 13913
		// (get) Token: 0x0600D34D RID: 54093 RVA: 0x003127E8 File Offset: 0x003109E8
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

		// Token: 0x1700365A RID: 13914
		// (get) Token: 0x0600D34E RID: 54094 RVA: 0x00312828 File Offset: 0x00310A28
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

		// Token: 0x0600D34F RID: 54095 RVA: 0x00312868 File Offset: 0x00310A68
		public DicIntInt? SkillIdTagMap(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700365B RID: 13915
		// (get) Token: 0x0600D350 RID: 54096 RVA: 0x003128CC File Offset: 0x00310ACC
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

		// Token: 0x0600D351 RID: 54097 RVA: 0x003128F8 File Offset: 0x00310AF8
		public int SkillIconTags(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700365C RID: 13916
		// (get) Token: 0x0600D352 RID: 54098 RVA: 0x00312938 File Offset: 0x00310B38
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

		// Token: 0x0600D353 RID: 54099 RVA: 0x00312964 File Offset: 0x00310B64
		public Span<int> GetSkillIconTagsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600D354 RID: 54100 RVA: 0x00312974 File Offset: 0x00310B74
		public int[] GetSkillIconTagsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600D355 RID: 54101 RVA: 0x0031298C File Offset: 0x00310B8C
		public int EnableTags(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700365D RID: 13917
		// (get) Token: 0x0600D356 RID: 54102 RVA: 0x003129CC File Offset: 0x00310BCC
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

		// Token: 0x0600D357 RID: 54103 RVA: 0x003129F8 File Offset: 0x00310BF8
		public Span<int> GetEnableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600D358 RID: 54104 RVA: 0x00312A08 File Offset: 0x00310C08
		public int[] GetEnableTagsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600D359 RID: 54105 RVA: 0x00312A20 File Offset: 0x00310C20
		public int DisableTags(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700365E RID: 13918
		// (get) Token: 0x0600D35A RID: 54106 RVA: 0x00312A60 File Offset: 0x00310C60
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

		// Token: 0x0600D35B RID: 54107 RVA: 0x00312A8C File Offset: 0x00310C8C
		public Span<int> GetDisableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600D35C RID: 54108 RVA: 0x00312A9C File Offset: 0x00310C9C
		public int[] GetDisableTagsArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600D35D RID: 54109 RVA: 0x00312AB4 File Offset: 0x00310CB4
		public DicIntIntArray? DisableSkillIdTags(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700365F RID: 13919
		// (get) Token: 0x0600D35E RID: 54110 RVA: 0x00312B18 File Offset: 0x00310D18
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

		// Token: 0x0600D35F RID: 54111 RVA: 0x00312B44 File Offset: 0x00310D44
		public int VisibleTags(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003660 RID: 13920
		// (get) Token: 0x0600D360 RID: 54112 RVA: 0x00312B84 File Offset: 0x00310D84
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

		// Token: 0x0600D361 RID: 54113 RVA: 0x00312BB0 File Offset: 0x00310DB0
		public Span<int> GetVisibleTagsBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600D362 RID: 54114 RVA: 0x00312BC0 File Offset: 0x00310DC0
		public int[] GetVisibleTagsArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x0600D363 RID: 54115 RVA: 0x00312BD8 File Offset: 0x00310DD8
		public int HiddenTags(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003661 RID: 13921
		// (get) Token: 0x0600D364 RID: 54116 RVA: 0x00312C18 File Offset: 0x00310E18
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

		// Token: 0x0600D365 RID: 54117 RVA: 0x00312C44 File Offset: 0x00310E44
		public Span<int> GetHiddenTagsBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600D366 RID: 54118 RVA: 0x00312C54 File Offset: 0x00310E54
		public int[] GetHiddenTagsArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x17003662 RID: 13922
		// (get) Token: 0x0600D367 RID: 54119 RVA: 0x00312C6C File Offset: 0x00310E6C
		public bool IsCdVisible
		{
			get
			{
				int num = this.__p.__offset(30);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003663 RID: 13923
		// (get) Token: 0x0600D368 RID: 54120 RVA: 0x00312CAC File Offset: 0x00310EAC
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

		// Token: 0x17003664 RID: 13924
		// (get) Token: 0x0600D369 RID: 54121 RVA: 0x00312CEC File Offset: 0x00310EEC
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

		// Token: 0x0600D36A RID: 54122 RVA: 0x00312D2C File Offset: 0x00310F2C
		public DicIntIntArray? AttributeIdTagMap(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003665 RID: 13925
		// (get) Token: 0x0600D36B RID: 54123 RVA: 0x00312D90 File Offset: 0x00310F90
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

		// Token: 0x0600D36C RID: 54124 RVA: 0x00312DBC File Offset: 0x00310FBC
		public int AttributeEnableTags(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003666 RID: 13926
		// (get) Token: 0x0600D36D RID: 54125 RVA: 0x00312DFC File Offset: 0x00310FFC
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

		// Token: 0x0600D36E RID: 54126 RVA: 0x00312E28 File Offset: 0x00311028
		public Span<int> GetAttributeEnableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x0600D36F RID: 54127 RVA: 0x00312E38 File Offset: 0x00311038
		public int[] GetAttributeEnableTagsArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x0600D370 RID: 54128 RVA: 0x00312E50 File Offset: 0x00311050
		public DicIntInt? FormationAttributeIdTagMap(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003667 RID: 13927
		// (get) Token: 0x0600D371 RID: 54129 RVA: 0x00312EB4 File Offset: 0x003110B4
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

		// Token: 0x17003668 RID: 13928
		// (get) Token: 0x0600D372 RID: 54130 RVA: 0x00312EE0 File Offset: 0x003110E0
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

		// Token: 0x17003669 RID: 13929
		// (get) Token: 0x0600D373 RID: 54131 RVA: 0x00312F20 File Offset: 0x00311120
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

		// Token: 0x1700366A RID: 13930
		// (get) Token: 0x0600D374 RID: 54132 RVA: 0x00312F60 File Offset: 0x00311160
		public bool IsLongPressControlCamera
		{
			get
			{
				int num = this.__p.__offset(46);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700366B RID: 13931
		// (get) Token: 0x0600D375 RID: 54133 RVA: 0x00312FA0 File Offset: 0x003111A0
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

		// Token: 0x0600D376 RID: 54134 RVA: 0x00312FE0 File Offset: 0x003111E0
		public DicIntInt? DynamicEffectTagMap(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700366C RID: 13932
		// (get) Token: 0x0600D377 RID: 54135 RVA: 0x00313044 File Offset: 0x00311244
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

		// Token: 0x1700366D RID: 13933
		// (get) Token: 0x0600D378 RID: 54136 RVA: 0x00313070 File Offset: 0x00311270
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

		// Token: 0x0600D379 RID: 54137 RVA: 0x003130B0 File Offset: 0x003112B0
		public int CustomHandleIds(int j)
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700366E RID: 13934
		// (get) Token: 0x0600D37A RID: 54138 RVA: 0x003130F0 File Offset: 0x003112F0
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

		// Token: 0x0600D37B RID: 54139 RVA: 0x0031311C File Offset: 0x0031131C
		public Span<int> GetCustomHandleIdsBytes()
		{
			return this.__p.__vector_as_span<int>(54, 4);
		}

		// Token: 0x0600D37C RID: 54140 RVA: 0x0031312C File Offset: 0x0031132C
		public int[] GetCustomHandleIdsArray()
		{
			return this.__p.__vector_as_array<int>(54) ?? Array.Empty<int>();
		}

		// Token: 0x0600D37D RID: 54141 RVA: 0x00313144 File Offset: 0x00311344
		public int ShowLongPressTags(int j)
		{
			int num = this.__p.__offset(56);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700366F RID: 13935
		// (get) Token: 0x0600D37E RID: 54142 RVA: 0x00313184 File Offset: 0x00311384
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

		// Token: 0x0600D37F RID: 54143 RVA: 0x003131B0 File Offset: 0x003113B0
		public Span<int> GetShowLongPressTagsBytes()
		{
			return this.__p.__vector_as_span<int>(56, 4);
		}

		// Token: 0x0600D380 RID: 54144 RVA: 0x003131C0 File Offset: 0x003113C0
		public int[] GetShowLongPressTagsArray()
		{
			return this.__p.__vector_as_array<int>(56) ?? Array.Empty<int>();
		}

		// Token: 0x0600D381 RID: 54145 RVA: 0x003131D8 File Offset: 0x003113D8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AttributeEnableTagsIter()或GetAttributeEnableTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AttributeEnableTags()
		{
			SkillButton skillButton = this;
			return skillButton.GetAttributeEnableTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D382 RID: 54146 RVA: 0x003131FC File Offset: 0x003113FC
		[NullableContext(1)]
		public readonly IEnumerable<int> AttributeEnableTagsIter()
		{
			SkillButton.<AttributeEnableTagsIter>d__94 <AttributeEnableTagsIter>d__ = new SkillButton.<AttributeEnableTagsIter>d__94(-2);
			<AttributeEnableTagsIter>d__.<>3__<>4__this = this;
			return <AttributeEnableTagsIter>d__;
		}

		// Token: 0x0600D383 RID: 54147 RVA: 0x00313214 File Offset: 0x00311414
		[NullableContext(1)]
		[Obsolete("已废弃，请使用AttributeIdTagMapFrozenDict()缓存字典，遍历请使用AttributeIdTagMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> AttributeIdTagMap()
		{
			return this.AttributeIdTagMapIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600D384 RID: 54148 RVA: 0x0031326A File Offset: 0x0031146A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntArray> AttributeIdTagMapIter()
		{
			SkillButton.<AttributeIdTagMapIter>d__96 <AttributeIdTagMapIter>d__ = new SkillButton.<AttributeIdTagMapIter>d__96(-2);
			<AttributeIdTagMapIter>d__.<>3__<>4__this = this;
			return <AttributeIdTagMapIter>d__;
		}

		// Token: 0x0600D385 RID: 54149 RVA: 0x00313280 File Offset: 0x00311480
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CustomHandleIdsIter()或GetCustomHandleIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] CustomHandleIds()
		{
			SkillButton skillButton = this;
			return skillButton.GetCustomHandleIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D386 RID: 54150 RVA: 0x003132A4 File Offset: 0x003114A4
		[NullableContext(1)]
		public readonly IEnumerable<int> CustomHandleIdsIter()
		{
			SkillButton.<CustomHandleIdsIter>d__98 <CustomHandleIdsIter>d__ = new SkillButton.<CustomHandleIdsIter>d__98(-2);
			<CustomHandleIdsIter>d__.<>3__<>4__this = this;
			return <CustomHandleIdsIter>d__;
		}

		// Token: 0x0600D387 RID: 54151 RVA: 0x003132BC File Offset: 0x003114BC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DisableSkillIdTagsFrozenDict()缓存字典，遍历请使用DisableSkillIdTagsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> DisableSkillIdTags()
		{
			return this.DisableSkillIdTagsIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600D388 RID: 54152 RVA: 0x00313312 File Offset: 0x00311512
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntArray> DisableSkillIdTagsIter()
		{
			SkillButton.<DisableSkillIdTagsIter>d__100 <DisableSkillIdTagsIter>d__ = new SkillButton.<DisableSkillIdTagsIter>d__100(-2);
			<DisableSkillIdTagsIter>d__.<>3__<>4__this = this;
			return <DisableSkillIdTagsIter>d__;
		}

		// Token: 0x0600D389 RID: 54153 RVA: 0x00313328 File Offset: 0x00311528
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DisableTagsIter()或GetDisableTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DisableTags()
		{
			SkillButton skillButton = this;
			return skillButton.GetDisableTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D38A RID: 54154 RVA: 0x0031334C File Offset: 0x0031154C
		[NullableContext(1)]
		public readonly IEnumerable<int> DisableTagsIter()
		{
			SkillButton.<DisableTagsIter>d__102 <DisableTagsIter>d__ = new SkillButton.<DisableTagsIter>d__102(-2);
			<DisableTagsIter>d__.<>3__<>4__this = this;
			return <DisableTagsIter>d__;
		}

		// Token: 0x0600D38B RID: 54155 RVA: 0x00313364 File Offset: 0x00311564
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DynamicEffectTagMapFrozenDict()缓存字典，遍历请使用DynamicEffectTagMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> DynamicEffectTagMap()
		{
			return this.DynamicEffectTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D38C RID: 54156 RVA: 0x003133BA File Offset: 0x003115BA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> DynamicEffectTagMapIter()
		{
			SkillButton.<DynamicEffectTagMapIter>d__104 <DynamicEffectTagMapIter>d__ = new SkillButton.<DynamicEffectTagMapIter>d__104(-2);
			<DynamicEffectTagMapIter>d__.<>3__<>4__this = this;
			return <DynamicEffectTagMapIter>d__;
		}

		// Token: 0x0600D38D RID: 54157 RVA: 0x003133D0 File Offset: 0x003115D0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EnableTagsIter()或GetEnableTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] EnableTags()
		{
			SkillButton skillButton = this;
			return skillButton.GetEnableTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D38E RID: 54158 RVA: 0x003133F4 File Offset: 0x003115F4
		[NullableContext(1)]
		public readonly IEnumerable<int> EnableTagsIter()
		{
			SkillButton.<EnableTagsIter>d__106 <EnableTagsIter>d__ = new SkillButton.<EnableTagsIter>d__106(-2);
			<EnableTagsIter>d__.<>3__<>4__this = this;
			return <EnableTagsIter>d__;
		}

		// Token: 0x0600D38F RID: 54159 RVA: 0x0031340C File Offset: 0x0031160C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用FormationAttributeIdTagMapFrozenDict()缓存字典，遍历请使用FormationAttributeIdTagMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> FormationAttributeIdTagMap()
		{
			return this.FormationAttributeIdTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D390 RID: 54160 RVA: 0x00313462 File Offset: 0x00311662
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> FormationAttributeIdTagMapIter()
		{
			SkillButton.<FormationAttributeIdTagMapIter>d__108 <FormationAttributeIdTagMapIter>d__ = new SkillButton.<FormationAttributeIdTagMapIter>d__108(-2);
			<FormationAttributeIdTagMapIter>d__.<>3__<>4__this = this;
			return <FormationAttributeIdTagMapIter>d__;
		}

		// Token: 0x0600D391 RID: 54161 RVA: 0x00313478 File Offset: 0x00311678
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用HiddenTagsIter()或GetHiddenTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] HiddenTags()
		{
			SkillButton skillButton = this;
			return skillButton.GetHiddenTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D392 RID: 54162 RVA: 0x0031349C File Offset: 0x0031169C
		[NullableContext(1)]
		public readonly IEnumerable<int> HiddenTagsIter()
		{
			SkillButton.<HiddenTagsIter>d__110 <HiddenTagsIter>d__ = new SkillButton.<HiddenTagsIter>d__110(-2);
			<HiddenTagsIter>d__.<>3__<>4__this = this;
			return <HiddenTagsIter>d__;
		}

		// Token: 0x0600D393 RID: 54163 RVA: 0x003134B4 File Offset: 0x003116B4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowLongPressTagsIter()或GetShowLongPressTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowLongPressTags()
		{
			SkillButton skillButton = this;
			return skillButton.GetShowLongPressTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D394 RID: 54164 RVA: 0x003134D8 File Offset: 0x003116D8
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowLongPressTagsIter()
		{
			SkillButton.<ShowLongPressTagsIter>d__112 <ShowLongPressTagsIter>d__ = new SkillButton.<ShowLongPressTagsIter>d__112(-2);
			<ShowLongPressTagsIter>d__.<>3__<>4__this = this;
			return <ShowLongPressTagsIter>d__;
		}

		// Token: 0x0600D395 RID: 54165 RVA: 0x003134F0 File Offset: 0x003116F0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillIconTagsIter()或GetSkillIconTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SkillIconTags()
		{
			SkillButton skillButton = this;
			return skillButton.GetSkillIconTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D396 RID: 54166 RVA: 0x00313514 File Offset: 0x00311714
		[NullableContext(1)]
		public readonly IEnumerable<int> SkillIconTagsIter()
		{
			SkillButton.<SkillIconTagsIter>d__114 <SkillIconTagsIter>d__ = new SkillButton.<SkillIconTagsIter>d__114(-2);
			<SkillIconTagsIter>d__.<>3__<>4__this = this;
			return <SkillIconTagsIter>d__;
		}

		// Token: 0x0600D397 RID: 54167 RVA: 0x0031352C File Offset: 0x0031172C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用SkillIdTagMapFrozenDict()缓存字典，遍历请使用SkillIdTagMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> SkillIdTagMap()
		{
			return this.SkillIdTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D398 RID: 54168 RVA: 0x00313582 File Offset: 0x00311782
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> SkillIdTagMapIter()
		{
			SkillButton.<SkillIdTagMapIter>d__116 <SkillIdTagMapIter>d__ = new SkillButton.<SkillIdTagMapIter>d__116(-2);
			<SkillIdTagMapIter>d__.<>3__<>4__this = this;
			return <SkillIdTagMapIter>d__;
		}

		// Token: 0x0600D399 RID: 54169 RVA: 0x00313598 File Offset: 0x00311798
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用VisibleTagsIter()或GetVisibleTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] VisibleTags()
		{
			SkillButton skillButton = this;
			return skillButton.GetVisibleTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D39A RID: 54170 RVA: 0x003135BC File Offset: 0x003117BC
		[NullableContext(1)]
		public readonly IEnumerable<int> VisibleTagsIter()
		{
			SkillButton.<VisibleTagsIter>d__118 <VisibleTagsIter>d__ = new SkillButton.<VisibleTagsIter>d__118(-2);
			<VisibleTagsIter>d__.<>3__<>4__this = this;
			return <VisibleTagsIter>d__;
		}

		// Token: 0x0600D39B RID: 54171 RVA: 0x003135D4 File Offset: 0x003117D4
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

		// Token: 0x0600D39C RID: 54172 RVA: 0x00313608 File Offset: 0x00311808
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

		// Token: 0x0600D39D RID: 54173 RVA: 0x0031363C File Offset: 0x0031183C
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

		// Token: 0x0600D39E RID: 54174 RVA: 0x00313670 File Offset: 0x00311870
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

		// Token: 0x0600D39F RID: 54175 RVA: 0x003136A4 File Offset: 0x003118A4
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

		// Token: 0x0600D3A0 RID: 54176 RVA: 0x003136D8 File Offset: 0x003118D8
		private void EnsureAttributeIdTagMapCacheIfNeeded()
		{
			if (this.AttributeIdTagMapCache != null)
			{
				return;
			}
			this.AttributeIdTagMapCache = this.AttributeIdTagMapIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600D3A1 RID: 54177 RVA: 0x00313740 File Offset: 0x00311940
		private void EnsureDisableSkillIdTagsCacheIfNeeded()
		{
			if (this.DisableSkillIdTagsCache != null)
			{
				return;
			}
			this.DisableSkillIdTagsCache = this.DisableSkillIdTagsIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600D3A2 RID: 54178 RVA: 0x003137A8 File Offset: 0x003119A8
		private void EnsureDynamicEffectTagMapCacheIfNeeded()
		{
			if (this.DynamicEffectTagMapCache != null)
			{
				return;
			}
			this.DynamicEffectTagMapCache = this.DynamicEffectTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D3A3 RID: 54179 RVA: 0x00313810 File Offset: 0x00311A10
		private void EnsureFormationAttributeIdTagMapCacheIfNeeded()
		{
			if (this.FormationAttributeIdTagMapCache != null)
			{
				return;
			}
			this.FormationAttributeIdTagMapCache = this.FormationAttributeIdTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D3A4 RID: 54180 RVA: 0x00313878 File Offset: 0x00311A78
		private void EnsureSkillIdTagMapCacheIfNeeded()
		{
			if (this.SkillIdTagMapCache != null)
			{
				return;
			}
			this.SkillIdTagMapCache = this.SkillIdTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D3A5 RID: 54181 RVA: 0x003138DE File Offset: 0x00311ADE
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetAttributeIdTagMapFrozenDict(int key)
		{
			this.EnsureAttributeIdTagMapCacheIfNeeded();
			return this.AttributeIdTagMapCache;
		}

		// Token: 0x0600D3A6 RID: 54182 RVA: 0x003138EC File Offset: 0x00311AEC
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetDisableSkillIdTagsFrozenDict(int key)
		{
			this.EnsureDisableSkillIdTagsCacheIfNeeded();
			return this.DisableSkillIdTagsCache;
		}

		// Token: 0x0600D3A7 RID: 54183 RVA: 0x003138FA File Offset: 0x00311AFA
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetDynamicEffectTagMapFrozenDict(int key)
		{
			this.EnsureDynamicEffectTagMapCacheIfNeeded();
			return this.DynamicEffectTagMapCache;
		}

		// Token: 0x0600D3A8 RID: 54184 RVA: 0x00313908 File Offset: 0x00311B08
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetFormationAttributeIdTagMapFrozenDict(int key)
		{
			this.EnsureFormationAttributeIdTagMapCacheIfNeeded();
			return this.FormationAttributeIdTagMapCache;
		}

		// Token: 0x0600D3A9 RID: 54185 RVA: 0x00313916 File Offset: 0x00311B16
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetSkillIdTagMapFrozenDict(int key)
		{
			this.EnsureSkillIdTagMapCacheIfNeeded();
			return this.SkillIdTagMapCache;
		}

		// Token: 0x040051CC RID: 20940
		private Table __p;

		// Token: 0x040051CD RID: 20941
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> AttributeIdTagMapCache;

		// Token: 0x040051CE RID: 20942
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> DisableSkillIdTagsCache;

		// Token: 0x040051CF RID: 20943
		[Nullable(2)]
		private FrozenDictionary<int, int> DynamicEffectTagMapCache;

		// Token: 0x040051D0 RID: 20944
		[Nullable(2)]
		private FrozenDictionary<int, int> FormationAttributeIdTagMapCache;

		// Token: 0x040051D1 RID: 20945
		[Nullable(2)]
		private FrozenDictionary<int, int> SkillIdTagMapCache;
	}
}
