using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BF1 RID: 3057
	public struct DirectTrainActivity : IFlatbufferObject
	{
		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x0600622C RID: 25132 RVA: 0x002134E5 File Offset: 0x002116E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600622D RID: 25133 RVA: 0x002134F2 File Offset: 0x002116F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600622E RID: 25134 RVA: 0x002134FC File Offset: 0x002116FC
		public static DirectTrainActivity GetRootAsDirectTrainActivity(ByteBuffer _bb)
		{
			return DirectTrainActivity.GetRootAsDirectTrainActivity(_bb, default(DirectTrainActivity));
		}

		// Token: 0x0600622F RID: 25135 RVA: 0x00213518 File Offset: 0x00211718
		public static DirectTrainActivity GetRootAsDirectTrainActivity(ByteBuffer _bb, DirectTrainActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006230 RID: 25136 RVA: 0x00213535 File Offset: 0x00211735
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006231 RID: 25137 RVA: 0x00213544 File Offset: 0x00211744
		public DirectTrainActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x06006232 RID: 25138 RVA: 0x00213554 File Offset: 0x00211754
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

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06006233 RID: 25139 RVA: 0x00213590 File Offset: 0x00211790
		public int SkipQuestId
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

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06006234 RID: 25140 RVA: 0x002135CC File Offset: 0x002117CC
		public bool IsForceRemind
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06006235 RID: 25141 RVA: 0x0021360C File Offset: 0x0021180C
		public int ForceRemindCond
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

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06006236 RID: 25142 RVA: 0x0021364C File Offset: 0x0021184C
		public int SkipQuestCondition
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

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x06006237 RID: 25143 RVA: 0x0021368C File Offset: 0x0021188C
		public string PrefabResource
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

		// Token: 0x06006238 RID: 25144 RVA: 0x002136C4 File Offset: 0x002118C4
		public Span<byte> GetPrefabResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006239 RID: 25145 RVA: 0x002136D4 File Offset: 0x002118D4
		public byte[] GetPrefabResourceArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x0600623A RID: 25146 RVA: 0x002136EC File Offset: 0x002118EC
		public int RecommendQuestId
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

		// Token: 0x0600623B RID: 25147 RVA: 0x0021372C File Offset: 0x0021192C
		public int RecommendQuestLinkList(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x0600623C RID: 25148 RVA: 0x0021376C File Offset: 0x0021196C
		public int RecommendQuestLinkListLength
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

		// Token: 0x0600623D RID: 25149 RVA: 0x00213798 File Offset: 0x00211998
		public Span<int> GetRecommendQuestLinkListBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600623E RID: 25150 RVA: 0x002137A8 File Offset: 0x002119A8
		public int[] GetRecommendQuestLinkListArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x0600623F RID: 25151 RVA: 0x002137C0 File Offset: 0x002119C0
		public string RecommendQuestLabel
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006240 RID: 25152 RVA: 0x002137F8 File Offset: 0x002119F8
		public Span<byte> GetRecommendQuestLabelBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06006241 RID: 25153 RVA: 0x00213808 File Offset: 0x00211A08
		public byte[] GetRecommendQuestLabelArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x06006242 RID: 25154 RVA: 0x00213820 File Offset: 0x00211A20
		public string SkipButton
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

		// Token: 0x06006243 RID: 25155 RVA: 0x00213858 File Offset: 0x00211A58
		public Span<byte> GetSkipButtonBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06006244 RID: 25156 RVA: 0x00213868 File Offset: 0x00211A68
		public byte[] GetSkipButtonArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06006245 RID: 25157 RVA: 0x00213880 File Offset: 0x00211A80
		public string SkipTipTitle
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

		// Token: 0x06006246 RID: 25158 RVA: 0x002138B8 File Offset: 0x00211AB8
		public Span<byte> GetSkipTipTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06006247 RID: 25159 RVA: 0x002138C8 File Offset: 0x00211AC8
		public byte[] GetSkipTipTitleArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06006248 RID: 25160 RVA: 0x002138E0 File Offset: 0x00211AE0
		public string SkipTipContent
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

		// Token: 0x06006249 RID: 25161 RVA: 0x00213918 File Offset: 0x00211B18
		public Span<byte> GetSkipTipContentBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600624A RID: 25162 RVA: 0x00213928 File Offset: 0x00211B28
		public byte[] GetSkipTipContentArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600624B RID: 25163 RVA: 0x00213940 File Offset: 0x00211B40
		public int LimitInstanceId(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x0600624C RID: 25164 RVA: 0x00213980 File Offset: 0x00211B80
		public int LimitInstanceIdLength
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

		// Token: 0x0600624D RID: 25165 RVA: 0x002139AC File Offset: 0x00211BAC
		public Span<int> GetLimitInstanceIdBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600624E RID: 25166 RVA: 0x002139BC File Offset: 0x00211BBC
		public int[] GetLimitInstanceIdArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x0600624F RID: 25167 RVA: 0x002139D4 File Offset: 0x00211BD4
		public string LimitInstanceText
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

		// Token: 0x06006250 RID: 25168 RVA: 0x00213A0C File Offset: 0x00211C0C
		public Span<byte> GetLimitInstanceTextBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06006251 RID: 25169 RVA: 0x00213A1C File Offset: 0x00211C1C
		public byte[] GetLimitInstanceTextArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x06006252 RID: 25170 RVA: 0x00213A34 File Offset: 0x00211C34
		public bool OpenQuestViewOnConfirm
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x06006253 RID: 25171 RVA: 0x00213A74 File Offset: 0x00211C74
		public string VersionTitle
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

		// Token: 0x06006254 RID: 25172 RVA: 0x00213AAC File Offset: 0x00211CAC
		public Span<byte> GetVersionTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06006255 RID: 25173 RVA: 0x00213ABC File Offset: 0x00211CBC
		public byte[] GetVersionTitleArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x06006256 RID: 25174 RVA: 0x00213AD4 File Offset: 0x00211CD4
		public bool ShowRecommend
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x06006257 RID: 25175 RVA: 0x00213B14 File Offset: 0x00211D14
		public string EntryPicMale
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

		// Token: 0x06006258 RID: 25176 RVA: 0x00213B4C File Offset: 0x00211D4C
		public Span<byte> GetEntryPicMaleBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06006259 RID: 25177 RVA: 0x00213B5C File Offset: 0x00211D5C
		public byte[] GetEntryPicMaleArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x0600625A RID: 25178 RVA: 0x00213B74 File Offset: 0x00211D74
		public string EntryPicFemale
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

		// Token: 0x0600625B RID: 25179 RVA: 0x00213BAC File Offset: 0x00211DAC
		public Span<byte> GetEntryPicFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600625C RID: 25180 RVA: 0x00213BBC File Offset: 0x00211DBC
		public byte[] GetEntryPicFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x0600625D RID: 25181 RVA: 0x00213BD4 File Offset: 0x00211DD4
		public string BgPicMale
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600625E RID: 25182 RVA: 0x00213C0C File Offset: 0x00211E0C
		public Span<byte> GetBgPicMaleBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600625F RID: 25183 RVA: 0x00213C1C File Offset: 0x00211E1C
		public byte[] GetBgPicMaleArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x06006260 RID: 25184 RVA: 0x00213C34 File Offset: 0x00211E34
		public string BgPicFemale
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

		// Token: 0x06006261 RID: 25185 RVA: 0x00213C6C File Offset: 0x00211E6C
		public Span<byte> GetBgPicFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06006262 RID: 25186 RVA: 0x00213C7C File Offset: 0x00211E7C
		public byte[] GetBgPicFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x06006263 RID: 25187 RVA: 0x00213C94 File Offset: 0x00211E94
		public string SubTitle
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006264 RID: 25188 RVA: 0x00213CCC File Offset: 0x00211ECC
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x06006265 RID: 25189 RVA: 0x00213CDC File Offset: 0x00211EDC
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x06006266 RID: 25190 RVA: 0x00213CF4 File Offset: 0x00211EF4
		public int HighlightList(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06006267 RID: 25191 RVA: 0x00213D34 File Offset: 0x00211F34
		public int HighlightListLength
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

		// Token: 0x06006268 RID: 25192 RVA: 0x00213D60 File Offset: 0x00211F60
		public Span<int> GetHighlightListBytes()
		{
			return this.__p.__vector_as_span<int>(48, 4);
		}

		// Token: 0x06006269 RID: 25193 RVA: 0x00213D70 File Offset: 0x00211F70
		public int[] GetHighlightListArray()
		{
			return this.__p.__vector_as_array<int>(48) ?? Array.Empty<int>();
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x0600626A RID: 25194 RVA: 0x00213D88 File Offset: 0x00211F88
		public string LockHint
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

		// Token: 0x0600626B RID: 25195 RVA: 0x00213DC0 File Offset: 0x00211FC0
		public Span<byte> GetLockHintBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0600626C RID: 25196 RVA: 0x00213DD0 File Offset: 0x00211FD0
		public byte[] GetLockHintArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x0600626D RID: 25197 RVA: 0x00213DE8 File Offset: 0x00211FE8
		public string ButtonText
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600626E RID: 25198 RVA: 0x00213E20 File Offset: 0x00212020
		public Span<byte> GetButtonTextBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x0600626F RID: 25199 RVA: 0x00213E30 File Offset: 0x00212030
		public byte[] GetButtonTextArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x06006270 RID: 25200 RVA: 0x00213E48 File Offset: 0x00212048
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用HighlightListIter()或GetHighlightListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] HighlightList()
		{
			DirectTrainActivity directTrainActivity = this;
			return directTrainActivity.GetHighlightListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006271 RID: 25201 RVA: 0x00213E6C File Offset: 0x0021206C
		[NullableContext(1)]
		public readonly IEnumerable<int> HighlightListIter()
		{
			DirectTrainActivity.<HighlightListIter>d__96 <HighlightListIter>d__ = new DirectTrainActivity.<HighlightListIter>d__96(-2);
			<HighlightListIter>d__.<>3__<>4__this = this;
			return <HighlightListIter>d__;
		}

		// Token: 0x06006272 RID: 25202 RVA: 0x00213E84 File Offset: 0x00212084
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LimitInstanceIdIter()或GetLimitInstanceIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LimitInstanceId()
		{
			DirectTrainActivity directTrainActivity = this;
			return directTrainActivity.GetLimitInstanceIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006273 RID: 25203 RVA: 0x00213EA8 File Offset: 0x002120A8
		[NullableContext(1)]
		public readonly IEnumerable<int> LimitInstanceIdIter()
		{
			DirectTrainActivity.<LimitInstanceIdIter>d__98 <LimitInstanceIdIter>d__ = new DirectTrainActivity.<LimitInstanceIdIter>d__98(-2);
			<LimitInstanceIdIter>d__.<>3__<>4__this = this;
			return <LimitInstanceIdIter>d__;
		}

		// Token: 0x06006274 RID: 25204 RVA: 0x00213EC0 File Offset: 0x002120C0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendQuestLinkListIter()或GetRecommendQuestLinkListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendQuestLinkList()
		{
			DirectTrainActivity directTrainActivity = this;
			return directTrainActivity.GetRecommendQuestLinkListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006275 RID: 25205 RVA: 0x00213EE4 File Offset: 0x002120E4
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendQuestLinkListIter()
		{
			DirectTrainActivity.<RecommendQuestLinkListIter>d__100 <RecommendQuestLinkListIter>d__ = new DirectTrainActivity.<RecommendQuestLinkListIter>d__100(-2);
			<RecommendQuestLinkListIter>d__.<>3__<>4__this = this;
			return <RecommendQuestLinkListIter>d__;
		}

		// Token: 0x04004C1E RID: 19486
		private Table __p;
	}
}
