using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DF6 RID: 3574
	public struct GuessJokerLevel : IFlatbufferObject
	{
		// Token: 0x17001689 RID: 5769
		// (get) Token: 0x06008221 RID: 33313 RVA: 0x0026D3A2 File Offset: 0x0026B5A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008222 RID: 33314 RVA: 0x0026D3AF File Offset: 0x0026B5AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008223 RID: 33315 RVA: 0x0026D3B8 File Offset: 0x0026B5B8
		public static GuessJokerLevel GetRootAsGuessJokerLevel(ByteBuffer _bb)
		{
			return GuessJokerLevel.GetRootAsGuessJokerLevel(_bb, default(GuessJokerLevel));
		}

		// Token: 0x06008224 RID: 33316 RVA: 0x0026D3D4 File Offset: 0x0026B5D4
		public static GuessJokerLevel GetRootAsGuessJokerLevel(ByteBuffer _bb, GuessJokerLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008225 RID: 33317 RVA: 0x0026D3F1 File Offset: 0x0026B5F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008226 RID: 33318 RVA: 0x0026D400 File Offset: 0x0026B600
		public GuessJokerLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700168A RID: 5770
		// (get) Token: 0x06008227 RID: 33319 RVA: 0x0026D410 File Offset: 0x0026B610
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

		// Token: 0x1700168B RID: 5771
		// (get) Token: 0x06008228 RID: 33320 RVA: 0x0026D44C File Offset: 0x0026B64C
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

		// Token: 0x1700168C RID: 5772
		// (get) Token: 0x06008229 RID: 33321 RVA: 0x0026D488 File Offset: 0x0026B688
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

		// Token: 0x1700168D RID: 5773
		// (get) Token: 0x0600822A RID: 33322 RVA: 0x0026D4C4 File Offset: 0x0026B6C4
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

		// Token: 0x1700168E RID: 5774
		// (get) Token: 0x0600822B RID: 33323 RVA: 0x0026D504 File Offset: 0x0026B704
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

		// Token: 0x1700168F RID: 5775
		// (get) Token: 0x0600822C RID: 33324 RVA: 0x0026D544 File Offset: 0x0026B744
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

		// Token: 0x17001690 RID: 5776
		// (get) Token: 0x0600822D RID: 33325 RVA: 0x0026D584 File Offset: 0x0026B784
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

		// Token: 0x17001691 RID: 5777
		// (get) Token: 0x0600822E RID: 33326 RVA: 0x0026D5C4 File Offset: 0x0026B7C4
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

		// Token: 0x17001692 RID: 5778
		// (get) Token: 0x0600822F RID: 33327 RVA: 0x0026D604 File Offset: 0x0026B804
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

		// Token: 0x17001693 RID: 5779
		// (get) Token: 0x06008230 RID: 33328 RVA: 0x0026D644 File Offset: 0x0026B844
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

		// Token: 0x06008231 RID: 33329 RVA: 0x0026D67C File Offset: 0x0026B87C
		public Span<byte> GetCoinIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008232 RID: 33330 RVA: 0x0026D68C File Offset: 0x0026B88C
		public byte[] GetCoinIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06008233 RID: 33331 RVA: 0x0026D6A4 File Offset: 0x0026B8A4
		public string WinEmojiPath(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001694 RID: 5780
		// (get) Token: 0x06008234 RID: 33332 RVA: 0x0026D6E0 File Offset: 0x0026B8E0
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

		// Token: 0x06008235 RID: 33333 RVA: 0x0026D70C File Offset: 0x0026B90C
		public string FailEmojiPath(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001695 RID: 5781
		// (get) Token: 0x06008236 RID: 33334 RVA: 0x0026D748 File Offset: 0x0026B948
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

		// Token: 0x06008237 RID: 33335 RVA: 0x0026D774 File Offset: 0x0026B974
		public DicIntString? WinText(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001696 RID: 5782
		// (get) Token: 0x06008238 RID: 33336 RVA: 0x0026D7D8 File Offset: 0x0026B9D8
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

		// Token: 0x06008239 RID: 33337 RVA: 0x0026D804 File Offset: 0x0026BA04
		public DicIntString? FailText(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001697 RID: 5783
		// (get) Token: 0x0600823A RID: 33338 RVA: 0x0026D868 File Offset: 0x0026BA68
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

		// Token: 0x17001698 RID: 5784
		// (get) Token: 0x0600823B RID: 33339 RVA: 0x0026D894 File Offset: 0x0026BA94
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

		// Token: 0x0600823C RID: 33340 RVA: 0x0026D8CC File Offset: 0x0026BACC
		public Span<byte> GetLockTextBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600823D RID: 33341 RVA: 0x0026D8DC File Offset: 0x0026BADC
		public byte[] GetLockTextArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x0600823E RID: 33342 RVA: 0x0026D8F4 File Offset: 0x0026BAF4
		public string FirstEnterFlow(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x0600823F RID: 33343 RVA: 0x0026D930 File Offset: 0x0026BB30
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

		// Token: 0x06008240 RID: 33344 RVA: 0x0026D95C File Offset: 0x0026BB5C
		public string FirstLeftFlow(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700169A RID: 5786
		// (get) Token: 0x06008241 RID: 33345 RVA: 0x0026D998 File Offset: 0x0026BB98
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

		// Token: 0x06008242 RID: 33346 RVA: 0x0026D9C4 File Offset: 0x0026BBC4
		[NullableContext(1)]
		public string[] FailEmojiPath()
		{
			return this.FailEmojiPathIter().ToArray<string>();
		}

		// Token: 0x06008243 RID: 33347 RVA: 0x0026D9D1 File Offset: 0x0026BBD1
		[NullableContext(1)]
		public IEnumerable<string> FailEmojiPathIter()
		{
			GuessJokerLevel.<FailEmojiPathIter>d__53 <FailEmojiPathIter>d__ = new GuessJokerLevel.<FailEmojiPathIter>d__53(-2);
			<FailEmojiPathIter>d__.<>3__<>4__this = this;
			return <FailEmojiPathIter>d__;
		}

		// Token: 0x06008244 RID: 33348 RVA: 0x0026D9E8 File Offset: 0x0026BBE8
		[NullableContext(1)]
		public Dictionary<int, string> FailText()
		{
			return this.FailTextIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x06008245 RID: 33349 RVA: 0x0026DA3E File Offset: 0x0026BC3E
		[NullableContext(1)]
		public IEnumerable<DicIntString> FailTextIter()
		{
			GuessJokerLevel.<FailTextIter>d__55 <FailTextIter>d__ = new GuessJokerLevel.<FailTextIter>d__55(-2);
			<FailTextIter>d__.<>3__<>4__this = this;
			return <FailTextIter>d__;
		}

		// Token: 0x06008246 RID: 33350 RVA: 0x0026DA53 File Offset: 0x0026BC53
		[NullableContext(1)]
		public string[] FirstEnterFlow()
		{
			return this.FirstEnterFlowIter().ToArray<string>();
		}

		// Token: 0x06008247 RID: 33351 RVA: 0x0026DA60 File Offset: 0x0026BC60
		[NullableContext(1)]
		public IEnumerable<string> FirstEnterFlowIter()
		{
			GuessJokerLevel.<FirstEnterFlowIter>d__57 <FirstEnterFlowIter>d__ = new GuessJokerLevel.<FirstEnterFlowIter>d__57(-2);
			<FirstEnterFlowIter>d__.<>3__<>4__this = this;
			return <FirstEnterFlowIter>d__;
		}

		// Token: 0x06008248 RID: 33352 RVA: 0x0026DA75 File Offset: 0x0026BC75
		[NullableContext(1)]
		public string[] FirstLeftFlow()
		{
			return this.FirstLeftFlowIter().ToArray<string>();
		}

		// Token: 0x06008249 RID: 33353 RVA: 0x0026DA82 File Offset: 0x0026BC82
		[NullableContext(1)]
		public IEnumerable<string> FirstLeftFlowIter()
		{
			GuessJokerLevel.<FirstLeftFlowIter>d__59 <FirstLeftFlowIter>d__ = new GuessJokerLevel.<FirstLeftFlowIter>d__59(-2);
			<FirstLeftFlowIter>d__.<>3__<>4__this = this;
			return <FirstLeftFlowIter>d__;
		}

		// Token: 0x0600824A RID: 33354 RVA: 0x0026DA97 File Offset: 0x0026BC97
		[NullableContext(1)]
		public string[] WinEmojiPath()
		{
			return this.WinEmojiPathIter().ToArray<string>();
		}

		// Token: 0x0600824B RID: 33355 RVA: 0x0026DAA4 File Offset: 0x0026BCA4
		[NullableContext(1)]
		public IEnumerable<string> WinEmojiPathIter()
		{
			GuessJokerLevel.<WinEmojiPathIter>d__61 <WinEmojiPathIter>d__ = new GuessJokerLevel.<WinEmojiPathIter>d__61(-2);
			<WinEmojiPathIter>d__.<>3__<>4__this = this;
			return <WinEmojiPathIter>d__;
		}

		// Token: 0x0600824C RID: 33356 RVA: 0x0026DABC File Offset: 0x0026BCBC
		[NullableContext(1)]
		public Dictionary<int, string> WinText()
		{
			return this.WinTextIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600824D RID: 33357 RVA: 0x0026DB12 File Offset: 0x0026BD12
		[NullableContext(1)]
		public IEnumerable<DicIntString> WinTextIter()
		{
			GuessJokerLevel.<WinTextIter>d__63 <WinTextIter>d__ = new GuessJokerLevel.<WinTextIter>d__63(-2);
			<WinTextIter>d__.<>3__<>4__this = this;
			return <WinTextIter>d__;
		}

		// Token: 0x0600824E RID: 33358 RVA: 0x0026DB28 File Offset: 0x0026BD28
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

		// Token: 0x0600824F RID: 33359 RVA: 0x0026DB50 File Offset: 0x0026BD50
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

		// Token: 0x06008250 RID: 33360 RVA: 0x0026DB78 File Offset: 0x0026BD78
		private void EnsureFailTextCacheIfNeeded()
		{
			if (this.FailTextCache != null)
			{
				return;
			}
			this.FailTextCache = this.FailTextIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x06008251 RID: 33361 RVA: 0x0026DBE0 File Offset: 0x0026BDE0
		private void EnsureWinTextCacheIfNeeded()
		{
			if (this.WinTextCache != null)
			{
				return;
			}
			this.WinTextCache = this.WinTextIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x06008252 RID: 33362 RVA: 0x0026DC46 File Offset: 0x0026BE46
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetFailTextFrozenDict()
		{
			this.EnsureFailTextCacheIfNeeded();
			return this.FailTextCache;
		}

		// Token: 0x06008253 RID: 33363 RVA: 0x0026DC54 File Offset: 0x0026BE54
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetWinTextFrozenDict()
		{
			this.EnsureWinTextCacheIfNeeded();
			return this.WinTextCache;
		}

		// Token: 0x0400536C RID: 21356
		private Table __p;

		// Token: 0x0400536D RID: 21357
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> FailTextCache;

		// Token: 0x0400536E RID: 21358
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> WinTextCache;
	}
}
