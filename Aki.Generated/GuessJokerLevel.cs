using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D11 RID: 3345
	public struct GuessJokerLevel : IFlatbufferObject
	{
		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x06007C09 RID: 31753 RVA: 0x0024E981 File Offset: 0x0024CB81
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007C0A RID: 31754 RVA: 0x0024E98E File Offset: 0x0024CB8E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007C0B RID: 31755 RVA: 0x0024E998 File Offset: 0x0024CB98
		public static GuessJokerLevel GetRootAsGuessJokerLevel(ByteBuffer _bb)
		{
			return GuessJokerLevel.GetRootAsGuessJokerLevel(_bb, default(GuessJokerLevel));
		}

		// Token: 0x06007C0C RID: 31756 RVA: 0x0024E9B4 File Offset: 0x0024CBB4
		public static GuessJokerLevel GetRootAsGuessJokerLevel(ByteBuffer _bb, GuessJokerLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007C0D RID: 31757 RVA: 0x0024E9D1 File Offset: 0x0024CBD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007C0E RID: 31758 RVA: 0x0024E9E0 File Offset: 0x0024CBE0
		public GuessJokerLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x06007C0F RID: 31759 RVA: 0x0024E9F0 File Offset: 0x0024CBF0
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

		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x06007C10 RID: 31760 RVA: 0x0024EA2C File Offset: 0x0024CC2C
		public int InstId
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

		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x06007C11 RID: 31761 RVA: 0x0024EA68 File Offset: 0x0024CC68
		public int AiRole
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

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x06007C12 RID: 31762 RVA: 0x0024EAA4 File Offset: 0x0024CCA4
		public int PreLevelId
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

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x06007C13 RID: 31763 RVA: 0x0024EAE4 File Offset: 0x0024CCE4
		public int UnLockCondition
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

		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x06007C14 RID: 31764 RVA: 0x0024EB24 File Offset: 0x0024CD24
		public int PassReward
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

		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x06007C15 RID: 31765 RVA: 0x0024EB64 File Offset: 0x0024CD64
		public int WhoCardSkill
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

		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x06007C16 RID: 31766 RVA: 0x0024EBA4 File Offset: 0x0024CDA4
		public int AiCardSkill
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

		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x06007C17 RID: 31767 RVA: 0x0024EBE4 File Offset: 0x0024CDE4
		public int InitHP
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x06007C18 RID: 31768 RVA: 0x0024EC24 File Offset: 0x0024CE24
		public string CoinIconPath
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

		// Token: 0x06007C19 RID: 31769 RVA: 0x0024EC5C File Offset: 0x0024CE5C
		public Span<byte> GetCoinIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06007C1A RID: 31770 RVA: 0x0024EC6C File Offset: 0x0024CE6C
		public byte[] GetCoinIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06007C1B RID: 31771 RVA: 0x0024EC84 File Offset: 0x0024CE84
		public string WinEmojiPath(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x06007C1C RID: 31772 RVA: 0x0024ECC0 File Offset: 0x0024CEC0
		public int WinEmojiPathLength
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

		// Token: 0x06007C1D RID: 31773 RVA: 0x0024ECEC File Offset: 0x0024CEEC
		public string FailEmojiPath(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x06007C1E RID: 31774 RVA: 0x0024ED28 File Offset: 0x0024CF28
		public int FailEmojiPathLength
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

		// Token: 0x06007C1F RID: 31775 RVA: 0x0024ED54 File Offset: 0x0024CF54
		public DicIntString? WinText(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x06007C20 RID: 31776 RVA: 0x0024EDB8 File Offset: 0x0024CFB8
		public int WinTextLength
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

		// Token: 0x06007C21 RID: 31777 RVA: 0x0024EDE4 File Offset: 0x0024CFE4
		public DicIntString? FailText(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x06007C22 RID: 31778 RVA: 0x0024EE48 File Offset: 0x0024D048
		public int FailTextLength
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

		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x06007C23 RID: 31779 RVA: 0x0024EE74 File Offset: 0x0024D074
		public string LockText
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

		// Token: 0x06007C24 RID: 31780 RVA: 0x0024EEAC File Offset: 0x0024D0AC
		public Span<byte> GetLockTextBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06007C25 RID: 31781 RVA: 0x0024EEBC File Offset: 0x0024D0BC
		public byte[] GetLockTextArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x06007C26 RID: 31782 RVA: 0x0024EED4 File Offset: 0x0024D0D4
		public string FirstEnterFlow(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x06007C27 RID: 31783 RVA: 0x0024EF10 File Offset: 0x0024D110
		public int FirstEnterFlowLength
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

		// Token: 0x06007C28 RID: 31784 RVA: 0x0024EF3C File Offset: 0x0024D13C
		public string FirstLeftFlow(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x06007C29 RID: 31785 RVA: 0x0024EF78 File Offset: 0x0024D178
		public int FirstLeftFlowLength
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

		// Token: 0x06007C2A RID: 31786 RVA: 0x0024EFA4 File Offset: 0x0024D1A4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FailEmojiPathIter()或GetFailEmojiPathBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] FailEmojiPath()
		{
			return this.FailEmojiPathIter().ToArray<string>();
		}

		// Token: 0x06007C2B RID: 31787 RVA: 0x0024EFB1 File Offset: 0x0024D1B1
		[NullableContext(1)]
		public readonly IEnumerable<string> FailEmojiPathIter()
		{
			GuessJokerLevel.<FailEmojiPathIter>d__53 <FailEmojiPathIter>d__ = new GuessJokerLevel.<FailEmojiPathIter>d__53(-2);
			<FailEmojiPathIter>d__.<>3__<>4__this = this;
			return <FailEmojiPathIter>d__;
		}

		// Token: 0x06007C2C RID: 31788 RVA: 0x0024EFC8 File Offset: 0x0024D1C8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用FailTextFrozenDict()缓存字典，遍历请使用FailTextIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> FailText()
		{
			return this.FailTextIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x06007C2D RID: 31789 RVA: 0x0024F01E File Offset: 0x0024D21E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> FailTextIter()
		{
			GuessJokerLevel.<FailTextIter>d__55 <FailTextIter>d__ = new GuessJokerLevel.<FailTextIter>d__55(-2);
			<FailTextIter>d__.<>3__<>4__this = this;
			return <FailTextIter>d__;
		}

		// Token: 0x06007C2E RID: 31790 RVA: 0x0024F033 File Offset: 0x0024D233
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FirstEnterFlowIter()或GetFirstEnterFlowBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] FirstEnterFlow()
		{
			return this.FirstEnterFlowIter().ToArray<string>();
		}

		// Token: 0x06007C2F RID: 31791 RVA: 0x0024F040 File Offset: 0x0024D240
		[NullableContext(1)]
		public readonly IEnumerable<string> FirstEnterFlowIter()
		{
			GuessJokerLevel.<FirstEnterFlowIter>d__57 <FirstEnterFlowIter>d__ = new GuessJokerLevel.<FirstEnterFlowIter>d__57(-2);
			<FirstEnterFlowIter>d__.<>3__<>4__this = this;
			return <FirstEnterFlowIter>d__;
		}

		// Token: 0x06007C30 RID: 31792 RVA: 0x0024F055 File Offset: 0x0024D255
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FirstLeftFlowIter()或GetFirstLeftFlowBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] FirstLeftFlow()
		{
			return this.FirstLeftFlowIter().ToArray<string>();
		}

		// Token: 0x06007C31 RID: 31793 RVA: 0x0024F062 File Offset: 0x0024D262
		[NullableContext(1)]
		public readonly IEnumerable<string> FirstLeftFlowIter()
		{
			GuessJokerLevel.<FirstLeftFlowIter>d__59 <FirstLeftFlowIter>d__ = new GuessJokerLevel.<FirstLeftFlowIter>d__59(-2);
			<FirstLeftFlowIter>d__.<>3__<>4__this = this;
			return <FirstLeftFlowIter>d__;
		}

		// Token: 0x06007C32 RID: 31794 RVA: 0x0024F077 File Offset: 0x0024D277
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WinEmojiPathIter()或GetWinEmojiPathBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] WinEmojiPath()
		{
			return this.WinEmojiPathIter().ToArray<string>();
		}

		// Token: 0x06007C33 RID: 31795 RVA: 0x0024F084 File Offset: 0x0024D284
		[NullableContext(1)]
		public readonly IEnumerable<string> WinEmojiPathIter()
		{
			GuessJokerLevel.<WinEmojiPathIter>d__61 <WinEmojiPathIter>d__ = new GuessJokerLevel.<WinEmojiPathIter>d__61(-2);
			<WinEmojiPathIter>d__.<>3__<>4__this = this;
			return <WinEmojiPathIter>d__;
		}

		// Token: 0x06007C34 RID: 31796 RVA: 0x0024F09C File Offset: 0x0024D29C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用WinTextFrozenDict()缓存字典，遍历请使用WinTextIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> WinText()
		{
			return this.WinTextIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x06007C35 RID: 31797 RVA: 0x0024F0F2 File Offset: 0x0024D2F2
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> WinTextIter()
		{
			GuessJokerLevel.<WinTextIter>d__63 <WinTextIter>d__ = new GuessJokerLevel.<WinTextIter>d__63(-2);
			<WinTextIter>d__.<>3__<>4__this = this;
			return <WinTextIter>d__;
		}

		// Token: 0x06007C36 RID: 31798 RVA: 0x0024F108 File Offset: 0x0024D308
		[NullableContext(2)]
		public string GetFailText(int key)
		{
			this.EnsureFailTextCacheIfNeeded();
			string result;
			if (!this.FailTextCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06007C37 RID: 31799 RVA: 0x0024F130 File Offset: 0x0024D330
		[NullableContext(2)]
		public string GetWinText(int key)
		{
			this.EnsureWinTextCacheIfNeeded();
			string result;
			if (!this.WinTextCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06007C38 RID: 31800 RVA: 0x0024F158 File Offset: 0x0024D358
		private void EnsureFailTextCacheIfNeeded()
		{
			if (this.FailTextCache != null)
			{
				return;
			}
			this.FailTextCache = this.FailTextIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x06007C39 RID: 31801 RVA: 0x0024F1C0 File Offset: 0x0024D3C0
		private void EnsureWinTextCacheIfNeeded()
		{
			if (this.WinTextCache != null)
			{
				return;
			}
			this.WinTextCache = this.WinTextIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x06007C3A RID: 31802 RVA: 0x0024F226 File Offset: 0x0024D426
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetFailTextFrozenDict(int key)
		{
			this.EnsureFailTextCacheIfNeeded();
			return this.FailTextCache;
		}

		// Token: 0x06007C3B RID: 31803 RVA: 0x0024F234 File Offset: 0x0024D434
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetWinTextFrozenDict(int key)
		{
			this.EnsureWinTextCacheIfNeeded();
			return this.WinTextCache;
		}

		// Token: 0x04004D87 RID: 19847
		private Table __p;

		// Token: 0x04004D88 RID: 19848
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> FailTextCache;

		// Token: 0x04004D89 RID: 19849
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> WinTextCache;
	}
}
