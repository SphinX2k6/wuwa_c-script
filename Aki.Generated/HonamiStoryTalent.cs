using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D50 RID: 3408
	public struct HonamiStoryTalent : IFlatbufferObject
	{
		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x06008150 RID: 33104 RVA: 0x0025A664 File Offset: 0x00258864
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008151 RID: 33105 RVA: 0x0025A671 File Offset: 0x00258871
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008152 RID: 33106 RVA: 0x0025A678 File Offset: 0x00258878
		public static HonamiStoryTalent GetRootAsHonamiStoryTalent(ByteBuffer _bb)
		{
			return HonamiStoryTalent.GetRootAsHonamiStoryTalent(_bb, default(HonamiStoryTalent));
		}

		// Token: 0x06008153 RID: 33107 RVA: 0x0025A694 File Offset: 0x00258894
		public static HonamiStoryTalent GetRootAsHonamiStoryTalent(ByteBuffer _bb, HonamiStoryTalent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008154 RID: 33108 RVA: 0x0025A6B1 File Offset: 0x002588B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008155 RID: 33109 RVA: 0x0025A6C0 File Offset: 0x002588C0
		public HonamiStoryTalent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x06008156 RID: 33110 RVA: 0x0025A6D0 File Offset: 0x002588D0
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

		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x06008157 RID: 33111 RVA: 0x0025A70C File Offset: 0x0025890C
		public int ActivityId
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

		// Token: 0x06008158 RID: 33112 RVA: 0x0025A748 File Offset: 0x00258948
		public int PreId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x06008159 RID: 33113 RVA: 0x0025A788 File Offset: 0x00258988
		public int PreIdLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600815A RID: 33114 RVA: 0x0025A7B3 File Offset: 0x002589B3
		public Span<int> GetPreIdBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600815B RID: 33115 RVA: 0x0025A7C2 File Offset: 0x002589C2
		public int[] GetPreIdArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600815C RID: 33116 RVA: 0x0025A7DC File Offset: 0x002589DC
		public int EffectIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x0600815D RID: 33117 RVA: 0x0025A81C File Offset: 0x00258A1C
		public int EffectIdsLength
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

		// Token: 0x0600815E RID: 33118 RVA: 0x0025A848 File Offset: 0x00258A48
		public Span<int> GetEffectIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600815F RID: 33119 RVA: 0x0025A858 File Offset: 0x00258A58
		public int[] GetEffectIdsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17001843 RID: 6211
		// (get) Token: 0x06008160 RID: 33120 RVA: 0x0025A870 File Offset: 0x00258A70
		public int Area
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

		// Token: 0x17001844 RID: 6212
		// (get) Token: 0x06008161 RID: 33121 RVA: 0x0025A8B0 File Offset: 0x00258AB0
		public int Type
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

		// Token: 0x17001845 RID: 6213
		// (get) Token: 0x06008162 RID: 33122 RVA: 0x0025A8F0 File Offset: 0x00258AF0
		public int IndexId
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

		// Token: 0x17001846 RID: 6214
		// (get) Token: 0x06008163 RID: 33123 RVA: 0x0025A930 File Offset: 0x00258B30
		public int IndexSortId
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

		// Token: 0x06008164 RID: 33124 RVA: 0x0025A970 File Offset: 0x00258B70
		public DicIntInt? ConsumeItems(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001847 RID: 6215
		// (get) Token: 0x06008165 RID: 33125 RVA: 0x0025A9D4 File Offset: 0x00258BD4
		public int ConsumeItemsLength
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

		// Token: 0x17001848 RID: 6216
		// (get) Token: 0x06008166 RID: 33126 RVA: 0x0025AA00 File Offset: 0x00258C00
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008167 RID: 33127 RVA: 0x0025AA38 File Offset: 0x00258C38
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008168 RID: 33128 RVA: 0x0025AA48 File Offset: 0x00258C48
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001849 RID: 6217
		// (get) Token: 0x06008169 RID: 33129 RVA: 0x0025AA60 File Offset: 0x00258C60
		public string GreyIcon
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

		// Token: 0x0600816A RID: 33130 RVA: 0x0025AA98 File Offset: 0x00258C98
		public Span<byte> GetGreyIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600816B RID: 33131 RVA: 0x0025AAA8 File Offset: 0x00258CA8
		public byte[] GetGreyIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700184A RID: 6218
		// (get) Token: 0x0600816C RID: 33132 RVA: 0x0025AAC0 File Offset: 0x00258CC0
		public string Name
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

		// Token: 0x0600816D RID: 33133 RVA: 0x0025AAF8 File Offset: 0x00258CF8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600816E RID: 33134 RVA: 0x0025AB08 File Offset: 0x00258D08
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700184B RID: 6219
		// (get) Token: 0x0600816F RID: 33135 RVA: 0x0025AB20 File Offset: 0x00258D20
		public string Desc
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

		// Token: 0x06008170 RID: 33136 RVA: 0x0025AB58 File Offset: 0x00258D58
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06008171 RID: 33137 RVA: 0x0025AB68 File Offset: 0x00258D68
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x1700184C RID: 6220
		// (get) Token: 0x06008172 RID: 33138 RVA: 0x0025AB80 File Offset: 0x00258D80
		public string MidTitle
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

		// Token: 0x06008173 RID: 33139 RVA: 0x0025ABB8 File Offset: 0x00258DB8
		public Span<byte> GetMidTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06008174 RID: 33140 RVA: 0x0025ABC8 File Offset: 0x00258DC8
		public byte[] GetMidTitleArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x1700184D RID: 6221
		// (get) Token: 0x06008175 RID: 33141 RVA: 0x0025ABE0 File Offset: 0x00258DE0
		public string MidDexc
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008176 RID: 33142 RVA: 0x0025AC18 File Offset: 0x00258E18
		public Span<byte> GetMidDexcBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06008177 RID: 33143 RVA: 0x0025AC28 File Offset: 0x00258E28
		public byte[] GetMidDexcArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x1700184E RID: 6222
		// (get) Token: 0x06008178 RID: 33144 RVA: 0x0025AC40 File Offset: 0x00258E40
		public string LockPopTip
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

		// Token: 0x06008179 RID: 33145 RVA: 0x0025AC78 File Offset: 0x00258E78
		public Span<byte> GetLockPopTipBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600817A RID: 33146 RVA: 0x0025AC88 File Offset: 0x00258E88
		public byte[] GetLockPopTipArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x1700184F RID: 6223
		// (get) Token: 0x0600817B RID: 33147 RVA: 0x0025ACA0 File Offset: 0x00258EA0
		public string LockPanelTip
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

		// Token: 0x0600817C RID: 33148 RVA: 0x0025ACD8 File Offset: 0x00258ED8
		public Span<byte> GetLockPanelTipBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600817D RID: 33149 RVA: 0x0025ACE8 File Offset: 0x00258EE8
		public byte[] GetLockPanelTipArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17001850 RID: 6224
		// (get) Token: 0x0600817E RID: 33150 RVA: 0x0025AD00 File Offset: 0x00258F00
		public string SuccessTitle
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

		// Token: 0x0600817F RID: 33151 RVA: 0x0025AD38 File Offset: 0x00258F38
		public Span<byte> GetSuccessTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06008180 RID: 33152 RVA: 0x0025AD48 File Offset: 0x00258F48
		public byte[] GetSuccessTitleArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17001851 RID: 6225
		// (get) Token: 0x06008181 RID: 33153 RVA: 0x0025AD60 File Offset: 0x00258F60
		public string SuccessDesc
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008182 RID: 33154 RVA: 0x0025AD98 File Offset: 0x00258F98
		public Span<byte> GetSuccessDescBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06008183 RID: 33155 RVA: 0x0025ADA8 File Offset: 0x00258FA8
		public byte[] GetSuccessDescArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x06008184 RID: 33156 RVA: 0x0025ADC0 File Offset: 0x00258FC0
		public string SuccessDescParams(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001852 RID: 6226
		// (get) Token: 0x06008185 RID: 33157 RVA: 0x0025ADFC File Offset: 0x00258FFC
		public int SuccessDescParamsLength
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001853 RID: 6227
		// (get) Token: 0x06008186 RID: 33158 RVA: 0x0025AE28 File Offset: 0x00259028
		public string FlowListName
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

		// Token: 0x06008187 RID: 33159 RVA: 0x0025AE60 File Offset: 0x00259060
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06008188 RID: 33160 RVA: 0x0025AE70 File Offset: 0x00259070
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17001854 RID: 6228
		// (get) Token: 0x06008189 RID: 33161 RVA: 0x0025AE88 File Offset: 0x00259088
		public int FlowId
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

		// Token: 0x17001855 RID: 6229
		// (get) Token: 0x0600818A RID: 33162 RVA: 0x0025AEC8 File Offset: 0x002590C8
		public int StateId
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

		// Token: 0x17001856 RID: 6230
		// (get) Token: 0x0600818B RID: 33163 RVA: 0x0025AF08 File Offset: 0x00259108
		public string BoZaiTalk
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600818C RID: 33164 RVA: 0x0025AF40 File Offset: 0x00259140
		public Span<byte> GetBoZaiTalkBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0600818D RID: 33165 RVA: 0x0025AF50 File Offset: 0x00259150
		public byte[] GetBoZaiTalkArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x0600818E RID: 33166 RVA: 0x0025AF68 File Offset: 0x00259168
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ConsumeItemsFrozenDict()缓存字典，遍历请使用ConsumeItemsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ConsumeItems()
		{
			return this.ConsumeItemsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600818F RID: 33167 RVA: 0x0025AFBE File Offset: 0x002591BE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ConsumeItemsIter()
		{
			HonamiStoryTalent.<ConsumeItemsIter>d__89 <ConsumeItemsIter>d__ = new HonamiStoryTalent.<ConsumeItemsIter>d__89(-2);
			<ConsumeItemsIter>d__.<>3__<>4__this = this;
			return <ConsumeItemsIter>d__;
		}

		// Token: 0x06008190 RID: 33168 RVA: 0x0025AFD4 File Offset: 0x002591D4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectIdsIter()或GetEffectIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] EffectIds()
		{
			HonamiStoryTalent honamiStoryTalent = this;
			return honamiStoryTalent.GetEffectIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008191 RID: 33169 RVA: 0x0025AFF8 File Offset: 0x002591F8
		[NullableContext(1)]
		public readonly IEnumerable<int> EffectIdsIter()
		{
			HonamiStoryTalent.<EffectIdsIter>d__91 <EffectIdsIter>d__ = new HonamiStoryTalent.<EffectIdsIter>d__91(-2);
			<EffectIdsIter>d__.<>3__<>4__this = this;
			return <EffectIdsIter>d__;
		}

		// Token: 0x06008192 RID: 33170 RVA: 0x0025B010 File Offset: 0x00259210
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PreIdIter()或GetPreIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PreId()
		{
			HonamiStoryTalent honamiStoryTalent = this;
			return honamiStoryTalent.GetPreIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008193 RID: 33171 RVA: 0x0025B034 File Offset: 0x00259234
		[NullableContext(1)]
		public readonly IEnumerable<int> PreIdIter()
		{
			HonamiStoryTalent.<PreIdIter>d__93 <PreIdIter>d__ = new HonamiStoryTalent.<PreIdIter>d__93(-2);
			<PreIdIter>d__.<>3__<>4__this = this;
			return <PreIdIter>d__;
		}

		// Token: 0x06008194 RID: 33172 RVA: 0x0025B049 File Offset: 0x00259249
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SuccessDescParamsIter()或GetSuccessDescParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SuccessDescParams()
		{
			return this.SuccessDescParamsIter().ToArray<string>();
		}

		// Token: 0x06008195 RID: 33173 RVA: 0x0025B056 File Offset: 0x00259256
		[NullableContext(1)]
		public readonly IEnumerable<string> SuccessDescParamsIter()
		{
			HonamiStoryTalent.<SuccessDescParamsIter>d__95 <SuccessDescParamsIter>d__ = new HonamiStoryTalent.<SuccessDescParamsIter>d__95(-2);
			<SuccessDescParamsIter>d__.<>3__<>4__this = this;
			return <SuccessDescParamsIter>d__;
		}

		// Token: 0x06008196 RID: 33174 RVA: 0x0025B06C File Offset: 0x0025926C
		public int? GetConsumeItems(int key)
		{
			this.EnsureConsumeItemsCacheIfNeeded();
			int value;
			if (!this.ConsumeItemsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06008197 RID: 33175 RVA: 0x0025B0A0 File Offset: 0x002592A0
		private void EnsureConsumeItemsCacheIfNeeded()
		{
			if (this.ConsumeItemsCache != null)
			{
				return;
			}
			this.ConsumeItemsCache = this.ConsumeItemsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008198 RID: 33176 RVA: 0x0025B106 File Offset: 0x00259306
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetConsumeItemsFrozenDict(int key)
		{
			this.EnsureConsumeItemsCacheIfNeeded();
			return this.ConsumeItemsCache;
		}

		// Token: 0x04004DCD RID: 19917
		private Table __p;

		// Token: 0x04004DCE RID: 19918
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeItemsCache;
	}
}
