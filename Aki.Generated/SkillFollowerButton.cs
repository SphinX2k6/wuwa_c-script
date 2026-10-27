using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010BF RID: 4287
	public struct SkillFollowerButton : IFlatbufferObject
	{
		// Token: 0x170036B4 RID: 14004
		// (get) Token: 0x0600D4AE RID: 54446 RVA: 0x0031648B File Offset: 0x0031468B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D4AF RID: 54447 RVA: 0x00316498 File Offset: 0x00314698
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D4B0 RID: 54448 RVA: 0x003164A0 File Offset: 0x003146A0
		public static SkillFollowerButton GetRootAsSkillFollowerButton(ByteBuffer _bb)
		{
			return SkillFollowerButton.GetRootAsSkillFollowerButton(_bb, default(SkillFollowerButton));
		}

		// Token: 0x0600D4B1 RID: 54449 RVA: 0x003164BC File Offset: 0x003146BC
		public static SkillFollowerButton GetRootAsSkillFollowerButton(ByteBuffer _bb, SkillFollowerButton obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D4B2 RID: 54450 RVA: 0x003164D9 File Offset: 0x003146D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D4B3 RID: 54451 RVA: 0x003164E8 File Offset: 0x003146E8
		public SkillFollowerButton __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170036B5 RID: 14005
		// (get) Token: 0x0600D4B4 RID: 54452 RVA: 0x003164F8 File Offset: 0x003146F8
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

		// Token: 0x170036B6 RID: 14006
		// (get) Token: 0x0600D4B5 RID: 54453 RVA: 0x00316534 File Offset: 0x00314734
		public int PbDataId
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

		// Token: 0x170036B7 RID: 14007
		// (get) Token: 0x0600D4B6 RID: 54454 RVA: 0x00316570 File Offset: 0x00314770
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

		// Token: 0x0600D4B7 RID: 54455 RVA: 0x003165A7 File Offset: 0x003147A7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D4B8 RID: 54456 RVA: 0x003165B6 File Offset: 0x003147B6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170036B8 RID: 14008
		// (get) Token: 0x0600D4B9 RID: 54457 RVA: 0x003165D0 File Offset: 0x003147D0
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

		// Token: 0x170036B9 RID: 14009
		// (get) Token: 0x0600D4BA RID: 54458 RVA: 0x00316610 File Offset: 0x00314810
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

		// Token: 0x170036BA RID: 14010
		// (get) Token: 0x0600D4BB RID: 54459 RVA: 0x00316650 File Offset: 0x00314850
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

		// Token: 0x0600D4BC RID: 54460 RVA: 0x00316690 File Offset: 0x00314890
		public DicIntInt? SkillIdTagMap(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170036BB RID: 14011
		// (get) Token: 0x0600D4BD RID: 54461 RVA: 0x003166F4 File Offset: 0x003148F4
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

		// Token: 0x170036BC RID: 14012
		// (get) Token: 0x0600D4BE RID: 54462 RVA: 0x00316720 File Offset: 0x00314920
		public string SkillIcon
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

		// Token: 0x0600D4BF RID: 54463 RVA: 0x00316758 File Offset: 0x00314958
		public Span<byte> GetSkillIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D4C0 RID: 54464 RVA: 0x00316768 File Offset: 0x00314968
		public byte[] GetSkillIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D4C1 RID: 54465 RVA: 0x00316780 File Offset: 0x00314980
		public int SkillIconTags(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036BD RID: 14013
		// (get) Token: 0x0600D4C2 RID: 54466 RVA: 0x003167C0 File Offset: 0x003149C0
		public int SkillIconTagsLength
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

		// Token: 0x0600D4C3 RID: 54467 RVA: 0x003167EC File Offset: 0x003149EC
		public Span<int> GetSkillIconTagsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600D4C4 RID: 54468 RVA: 0x003167FC File Offset: 0x003149FC
		public int[] GetSkillIconTagsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600D4C5 RID: 54469 RVA: 0x00316814 File Offset: 0x00314A14
		public int DisableTags(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036BE RID: 14014
		// (get) Token: 0x0600D4C6 RID: 54470 RVA: 0x00316854 File Offset: 0x00314A54
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

		// Token: 0x0600D4C7 RID: 54471 RVA: 0x00316880 File Offset: 0x00314A80
		public Span<int> GetDisableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600D4C8 RID: 54472 RVA: 0x00316890 File Offset: 0x00314A90
		public int[] GetDisableTagsArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600D4C9 RID: 54473 RVA: 0x003168A8 File Offset: 0x00314AA8
		public DicIntIntArray? DisableSkillIdTags(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170036BF RID: 14015
		// (get) Token: 0x0600D4CA RID: 54474 RVA: 0x0031690C File Offset: 0x00314B0C
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

		// Token: 0x170036C0 RID: 14016
		// (get) Token: 0x0600D4CB RID: 54475 RVA: 0x00316938 File Offset: 0x00314B38
		public bool IsVisible
		{
			get
			{
				int num = this.__p.__offset(26);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600D4CC RID: 54476 RVA: 0x00316978 File Offset: 0x00314B78
		public int NotOccupyTags(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036C1 RID: 14017
		// (get) Token: 0x0600D4CD RID: 54477 RVA: 0x003169B8 File Offset: 0x00314BB8
		public int NotOccupyTagsLength
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

		// Token: 0x0600D4CE RID: 54478 RVA: 0x003169E4 File Offset: 0x00314BE4
		public Span<int> GetNotOccupyTagsBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600D4CF RID: 54479 RVA: 0x003169F4 File Offset: 0x00314BF4
		public int[] GetNotOccupyTagsArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x170036C2 RID: 14018
		// (get) Token: 0x0600D4D0 RID: 54480 RVA: 0x00316A0C File Offset: 0x00314C0C
		public int ElementId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170036C3 RID: 14019
		// (get) Token: 0x0600D4D1 RID: 54481 RVA: 0x00316A4C File Offset: 0x00314C4C
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

		// Token: 0x170036C4 RID: 14020
		// (get) Token: 0x0600D4D2 RID: 54482 RVA: 0x00316A8C File Offset: 0x00314C8C
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

		// Token: 0x0600D4D3 RID: 54483 RVA: 0x00316ACC File Offset: 0x00314CCC
		public DicIntIntArray? AttributeIdTagMap(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170036C5 RID: 14021
		// (get) Token: 0x0600D4D4 RID: 54484 RVA: 0x00316B30 File Offset: 0x00314D30
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

		// Token: 0x0600D4D5 RID: 54485 RVA: 0x00316B5C File Offset: 0x00314D5C
		public int AttributeEnableTags(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036C6 RID: 14022
		// (get) Token: 0x0600D4D6 RID: 54486 RVA: 0x00316B9C File Offset: 0x00314D9C
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

		// Token: 0x0600D4D7 RID: 54487 RVA: 0x00316BC8 File Offset: 0x00314DC8
		public Span<int> GetAttributeEnableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x0600D4D8 RID: 54488 RVA: 0x00316BD8 File Offset: 0x00314DD8
		public int[] GetAttributeEnableTagsArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x170036C7 RID: 14023
		// (get) Token: 0x0600D4D9 RID: 54489 RVA: 0x00316BF0 File Offset: 0x00314DF0
		public bool IsLongPressControlCamera
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170036C8 RID: 14024
		// (get) Token: 0x0600D4DA RID: 54490 RVA: 0x00316C30 File Offset: 0x00314E30
		public int LongPressTime
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

		// Token: 0x0600D4DB RID: 54491 RVA: 0x00316C70 File Offset: 0x00314E70
		public DicIntInt? DynamicEffectTagMap(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170036C9 RID: 14025
		// (get) Token: 0x0600D4DC RID: 54492 RVA: 0x00316CD4 File Offset: 0x00314ED4
		public int DynamicEffectTagMapLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170036CA RID: 14026
		// (get) Token: 0x0600D4DD RID: 54493 RVA: 0x00316D00 File Offset: 0x00314F00
		public int CustomHandleId
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D4DE RID: 54494 RVA: 0x00316D40 File Offset: 0x00314F40
		public int CustomHandleIds(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036CB RID: 14027
		// (get) Token: 0x0600D4DF RID: 54495 RVA: 0x00316D80 File Offset: 0x00314F80
		public int CustomHandleIdsLength
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D4E0 RID: 54496 RVA: 0x00316DAC File Offset: 0x00314FAC
		public Span<int> GetCustomHandleIdsBytes()
		{
			return this.__p.__vector_as_span<int>(48, 4);
		}

		// Token: 0x0600D4E1 RID: 54497 RVA: 0x00316DBC File Offset: 0x00314FBC
		public int[] GetCustomHandleIdsArray()
		{
			return this.__p.__vector_as_array<int>(48) ?? Array.Empty<int>();
		}

		// Token: 0x0600D4E2 RID: 54498 RVA: 0x00316DD4 File Offset: 0x00314FD4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AttributeEnableTagsIter()或GetAttributeEnableTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AttributeEnableTags()
		{
			SkillFollowerButton skillFollowerButton = this;
			return skillFollowerButton.GetAttributeEnableTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D4E3 RID: 54499 RVA: 0x00316DF8 File Offset: 0x00314FF8
		[NullableContext(1)]
		public readonly IEnumerable<int> AttributeEnableTagsIter()
		{
			SkillFollowerButton.<AttributeEnableTagsIter>d__78 <AttributeEnableTagsIter>d__ = new SkillFollowerButton.<AttributeEnableTagsIter>d__78(-2);
			<AttributeEnableTagsIter>d__.<>3__<>4__this = this;
			return <AttributeEnableTagsIter>d__;
		}

		// Token: 0x0600D4E4 RID: 54500 RVA: 0x00316E10 File Offset: 0x00315010
		[NullableContext(1)]
		[Obsolete("已废弃，请使用AttributeIdTagMapFrozenDict()缓存字典，遍历请使用AttributeIdTagMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> AttributeIdTagMap()
		{
			return this.AttributeIdTagMapIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600D4E5 RID: 54501 RVA: 0x00316E66 File Offset: 0x00315066
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntArray> AttributeIdTagMapIter()
		{
			SkillFollowerButton.<AttributeIdTagMapIter>d__80 <AttributeIdTagMapIter>d__ = new SkillFollowerButton.<AttributeIdTagMapIter>d__80(-2);
			<AttributeIdTagMapIter>d__.<>3__<>4__this = this;
			return <AttributeIdTagMapIter>d__;
		}

		// Token: 0x0600D4E6 RID: 54502 RVA: 0x00316E7C File Offset: 0x0031507C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CustomHandleIdsIter()或GetCustomHandleIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] CustomHandleIds()
		{
			SkillFollowerButton skillFollowerButton = this;
			return skillFollowerButton.GetCustomHandleIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D4E7 RID: 54503 RVA: 0x00316EA0 File Offset: 0x003150A0
		[NullableContext(1)]
		public readonly IEnumerable<int> CustomHandleIdsIter()
		{
			SkillFollowerButton.<CustomHandleIdsIter>d__82 <CustomHandleIdsIter>d__ = new SkillFollowerButton.<CustomHandleIdsIter>d__82(-2);
			<CustomHandleIdsIter>d__.<>3__<>4__this = this;
			return <CustomHandleIdsIter>d__;
		}

		// Token: 0x0600D4E8 RID: 54504 RVA: 0x00316EB8 File Offset: 0x003150B8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DisableSkillIdTagsFrozenDict()缓存字典，遍历请使用DisableSkillIdTagsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> DisableSkillIdTags()
		{
			return this.DisableSkillIdTagsIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600D4E9 RID: 54505 RVA: 0x00316F0E File Offset: 0x0031510E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntArray> DisableSkillIdTagsIter()
		{
			SkillFollowerButton.<DisableSkillIdTagsIter>d__84 <DisableSkillIdTagsIter>d__ = new SkillFollowerButton.<DisableSkillIdTagsIter>d__84(-2);
			<DisableSkillIdTagsIter>d__.<>3__<>4__this = this;
			return <DisableSkillIdTagsIter>d__;
		}

		// Token: 0x0600D4EA RID: 54506 RVA: 0x00316F24 File Offset: 0x00315124
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DisableTagsIter()或GetDisableTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DisableTags()
		{
			SkillFollowerButton skillFollowerButton = this;
			return skillFollowerButton.GetDisableTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D4EB RID: 54507 RVA: 0x00316F48 File Offset: 0x00315148
		[NullableContext(1)]
		public readonly IEnumerable<int> DisableTagsIter()
		{
			SkillFollowerButton.<DisableTagsIter>d__86 <DisableTagsIter>d__ = new SkillFollowerButton.<DisableTagsIter>d__86(-2);
			<DisableTagsIter>d__.<>3__<>4__this = this;
			return <DisableTagsIter>d__;
		}

		// Token: 0x0600D4EC RID: 54508 RVA: 0x00316F60 File Offset: 0x00315160
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DynamicEffectTagMapFrozenDict()缓存字典，遍历请使用DynamicEffectTagMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> DynamicEffectTagMap()
		{
			return this.DynamicEffectTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D4ED RID: 54509 RVA: 0x00316FB6 File Offset: 0x003151B6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> DynamicEffectTagMapIter()
		{
			SkillFollowerButton.<DynamicEffectTagMapIter>d__88 <DynamicEffectTagMapIter>d__ = new SkillFollowerButton.<DynamicEffectTagMapIter>d__88(-2);
			<DynamicEffectTagMapIter>d__.<>3__<>4__this = this;
			return <DynamicEffectTagMapIter>d__;
		}

		// Token: 0x0600D4EE RID: 54510 RVA: 0x00316FCC File Offset: 0x003151CC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用NotOccupyTagsIter()或GetNotOccupyTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] NotOccupyTags()
		{
			SkillFollowerButton skillFollowerButton = this;
			return skillFollowerButton.GetNotOccupyTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D4EF RID: 54511 RVA: 0x00316FF0 File Offset: 0x003151F0
		[NullableContext(1)]
		public readonly IEnumerable<int> NotOccupyTagsIter()
		{
			SkillFollowerButton.<NotOccupyTagsIter>d__90 <NotOccupyTagsIter>d__ = new SkillFollowerButton.<NotOccupyTagsIter>d__90(-2);
			<NotOccupyTagsIter>d__.<>3__<>4__this = this;
			return <NotOccupyTagsIter>d__;
		}

		// Token: 0x0600D4F0 RID: 54512 RVA: 0x00317008 File Offset: 0x00315208
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillIconTagsIter()或GetSkillIconTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SkillIconTags()
		{
			SkillFollowerButton skillFollowerButton = this;
			return skillFollowerButton.GetSkillIconTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D4F1 RID: 54513 RVA: 0x0031702C File Offset: 0x0031522C
		[NullableContext(1)]
		public readonly IEnumerable<int> SkillIconTagsIter()
		{
			SkillFollowerButton.<SkillIconTagsIter>d__92 <SkillIconTagsIter>d__ = new SkillFollowerButton.<SkillIconTagsIter>d__92(-2);
			<SkillIconTagsIter>d__.<>3__<>4__this = this;
			return <SkillIconTagsIter>d__;
		}

		// Token: 0x0600D4F2 RID: 54514 RVA: 0x00317044 File Offset: 0x00315244
		[NullableContext(1)]
		[Obsolete("已废弃，请使用SkillIdTagMapFrozenDict()缓存字典，遍历请使用SkillIdTagMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> SkillIdTagMap()
		{
			return this.SkillIdTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D4F3 RID: 54515 RVA: 0x0031709A File Offset: 0x0031529A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> SkillIdTagMapIter()
		{
			SkillFollowerButton.<SkillIdTagMapIter>d__94 <SkillIdTagMapIter>d__ = new SkillFollowerButton.<SkillIdTagMapIter>d__94(-2);
			<SkillIdTagMapIter>d__.<>3__<>4__this = this;
			return <SkillIdTagMapIter>d__;
		}

		// Token: 0x0600D4F4 RID: 54516 RVA: 0x003170B0 File Offset: 0x003152B0
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

		// Token: 0x0600D4F5 RID: 54517 RVA: 0x003170E4 File Offset: 0x003152E4
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

		// Token: 0x0600D4F6 RID: 54518 RVA: 0x00317118 File Offset: 0x00315318
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

		// Token: 0x0600D4F7 RID: 54519 RVA: 0x0031714C File Offset: 0x0031534C
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

		// Token: 0x0600D4F8 RID: 54520 RVA: 0x00317180 File Offset: 0x00315380
		private void EnsureAttributeIdTagMapCacheIfNeeded()
		{
			if (this.AttributeIdTagMapCache != null)
			{
				return;
			}
			this.AttributeIdTagMapCache = this.AttributeIdTagMapIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600D4F9 RID: 54521 RVA: 0x003171E8 File Offset: 0x003153E8
		private void EnsureDisableSkillIdTagsCacheIfNeeded()
		{
			if (this.DisableSkillIdTagsCache != null)
			{
				return;
			}
			this.DisableSkillIdTagsCache = this.DisableSkillIdTagsIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600D4FA RID: 54522 RVA: 0x00317250 File Offset: 0x00315450
		private void EnsureDynamicEffectTagMapCacheIfNeeded()
		{
			if (this.DynamicEffectTagMapCache != null)
			{
				return;
			}
			this.DynamicEffectTagMapCache = this.DynamicEffectTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D4FB RID: 54523 RVA: 0x003172B8 File Offset: 0x003154B8
		private void EnsureSkillIdTagMapCacheIfNeeded()
		{
			if (this.SkillIdTagMapCache != null)
			{
				return;
			}
			this.SkillIdTagMapCache = this.SkillIdTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D4FC RID: 54524 RVA: 0x0031731E File Offset: 0x0031551E
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetAttributeIdTagMapFrozenDict(int key)
		{
			this.EnsureAttributeIdTagMapCacheIfNeeded();
			return this.AttributeIdTagMapCache;
		}

		// Token: 0x0600D4FD RID: 54525 RVA: 0x0031732C File Offset: 0x0031552C
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetDisableSkillIdTagsFrozenDict(int key)
		{
			this.EnsureDisableSkillIdTagsCacheIfNeeded();
			return this.DisableSkillIdTagsCache;
		}

		// Token: 0x0600D4FE RID: 54526 RVA: 0x0031733A File Offset: 0x0031553A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetDynamicEffectTagMapFrozenDict(int key)
		{
			this.EnsureDynamicEffectTagMapCacheIfNeeded();
			return this.DynamicEffectTagMapCache;
		}

		// Token: 0x0600D4FF RID: 54527 RVA: 0x00317348 File Offset: 0x00315548
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetSkillIdTagMapFrozenDict(int key)
		{
			this.EnsureSkillIdTagMapCacheIfNeeded();
			return this.SkillIdTagMapCache;
		}

		// Token: 0x040051E4 RID: 20964
		private Table __p;

		// Token: 0x040051E5 RID: 20965
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> AttributeIdTagMapCache;

		// Token: 0x040051E6 RID: 20966
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> DisableSkillIdTagsCache;

		// Token: 0x040051E7 RID: 20967
		[Nullable(2)]
		private FrozenDictionary<int, int> DynamicEffectTagMapCache;

		// Token: 0x040051E8 RID: 20968
		[Nullable(2)]
		private FrozenDictionary<int, int> SkillIdTagMapCache;
	}
}
