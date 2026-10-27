using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001122 RID: 4386
	public struct Tetris : IFlatbufferObject
	{
		// Token: 0x17003A16 RID: 14870
		// (get) Token: 0x0600DDDB RID: 56795 RVA: 0x0032B9F1 File Offset: 0x00329BF1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DDDC RID: 56796 RVA: 0x0032B9FE File Offset: 0x00329BFE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DDDD RID: 56797 RVA: 0x0032BA08 File Offset: 0x00329C08
		public static Tetris GetRootAsTetris(ByteBuffer _bb)
		{
			return Tetris.GetRootAsTetris(_bb, default(Tetris));
		}

		// Token: 0x0600DDDE RID: 56798 RVA: 0x0032BA24 File Offset: 0x00329C24
		public static Tetris GetRootAsTetris(ByteBuffer _bb, Tetris obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DDDF RID: 56799 RVA: 0x0032BA41 File Offset: 0x00329C41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DDE0 RID: 56800 RVA: 0x0032BA50 File Offset: 0x00329C50
		public Tetris __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A17 RID: 14871
		// (get) Token: 0x0600DDE1 RID: 56801 RVA: 0x0032BA60 File Offset: 0x00329C60
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

		// Token: 0x17003A18 RID: 14872
		// (get) Token: 0x0600DDE2 RID: 56802 RVA: 0x0032BA9C File Offset: 0x00329C9C
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

		// Token: 0x17003A19 RID: 14873
		// (get) Token: 0x0600DDE3 RID: 56803 RVA: 0x0032BAD8 File Offset: 0x00329CD8
		public int GroupId
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

		// Token: 0x17003A1A RID: 14874
		// (get) Token: 0x0600DDE4 RID: 56804 RVA: 0x0032BB14 File Offset: 0x00329D14
		public int UnlockId
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

		// Token: 0x17003A1B RID: 14875
		// (get) Token: 0x0600DDE5 RID: 56805 RVA: 0x0032BB54 File Offset: 0x00329D54
		public int Mode
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

		// Token: 0x0600DDE6 RID: 56806 RVA: 0x0032BB94 File Offset: 0x00329D94
		public DicIntInt? TargetResult(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003A1C RID: 14876
		// (get) Token: 0x0600DDE7 RID: 56807 RVA: 0x0032BBF8 File Offset: 0x00329DF8
		public int TargetResultLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DDE8 RID: 56808 RVA: 0x0032BC24 File Offset: 0x00329E24
		public IntIntMap? TargetResults(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IntIntMap?(default(IntIntMap).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003A1D RID: 14877
		// (get) Token: 0x0600DDE9 RID: 56809 RVA: 0x0032BC88 File Offset: 0x00329E88
		public int TargetResultsLength
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

		// Token: 0x17003A1E RID: 14878
		// (get) Token: 0x0600DDEA RID: 56810 RVA: 0x0032BCB4 File Offset: 0x00329EB4
		public int OpenDay
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

		// Token: 0x17003A1F RID: 14879
		// (get) Token: 0x0600DDEB RID: 56811 RVA: 0x0032BCF4 File Offset: 0x00329EF4
		public int DropId
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

		// Token: 0x17003A20 RID: 14880
		// (get) Token: 0x0600DDEC RID: 56812 RVA: 0x0032BD34 File Offset: 0x00329F34
		public int BlockNum
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003A21 RID: 14881
		// (get) Token: 0x0600DDED RID: 56813 RVA: 0x0032BD74 File Offset: 0x00329F74
		public string TotalLevelName
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

		// Token: 0x0600DDEE RID: 56814 RVA: 0x0032BDAC File Offset: 0x00329FAC
		public Span<byte> GetTotalLevelNameBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600DDEF RID: 56815 RVA: 0x0032BDBC File Offset: 0x00329FBC
		public byte[] GetTotalLevelNameArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A22 RID: 14882
		// (get) Token: 0x0600DDF0 RID: 56816 RVA: 0x0032BDD4 File Offset: 0x00329FD4
		public string LevelName
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

		// Token: 0x0600DDF1 RID: 56817 RVA: 0x0032BE0C File Offset: 0x0032A00C
		public Span<byte> GetLevelNameBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600DDF2 RID: 56818 RVA: 0x0032BE1C File Offset: 0x0032A01C
		public byte[] GetLevelNameArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A23 RID: 14883
		// (get) Token: 0x0600DDF3 RID: 56819 RVA: 0x0032BE34 File Offset: 0x0032A034
		public string LevelDes
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

		// Token: 0x0600DDF4 RID: 56820 RVA: 0x0032BE6C File Offset: 0x0032A06C
		public Span<byte> GetLevelDesBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600DDF5 RID: 56821 RVA: 0x0032BE7C File Offset: 0x0032A07C
		public byte[] GetLevelDesArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DDF6 RID: 56822 RVA: 0x0032BE94 File Offset: 0x0032A094
		public int ReduceDiffCnt(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A24 RID: 14884
		// (get) Token: 0x0600DDF7 RID: 56823 RVA: 0x0032BED4 File Offset: 0x0032A0D4
		public int ReduceDiffCntLength
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

		// Token: 0x0600DDF8 RID: 56824 RVA: 0x0032BF00 File Offset: 0x0032A100
		public Span<int> GetReduceDiffCntBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x0600DDF9 RID: 56825 RVA: 0x0032BF10 File Offset: 0x0032A110
		public int[] GetReduceDiffCntArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x17003A25 RID: 14885
		// (get) Token: 0x0600DDFA RID: 56826 RVA: 0x0032BF28 File Offset: 0x0032A128
		public int TakeBackCnt
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

		// Token: 0x17003A26 RID: 14886
		// (get) Token: 0x0600DDFB RID: 56827 RVA: 0x0032BF68 File Offset: 0x0032A168
		public int HelpId
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

		// Token: 0x0600DDFC RID: 56828 RVA: 0x0032BFA8 File Offset: 0x0032A1A8
		public string FlowId(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A27 RID: 14887
		// (get) Token: 0x0600DDFD RID: 56829 RVA: 0x0032BFE4 File Offset: 0x0032A1E4
		public int FlowIdLength
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

		// Token: 0x17003A28 RID: 14888
		// (get) Token: 0x0600DDFE RID: 56830 RVA: 0x0032C010 File Offset: 0x0032A210
		public int ConditionGroup
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DDFF RID: 56831 RVA: 0x0032C04D File Offset: 0x0032A24D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FlowIdIter()或GetFlowIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] FlowId()
		{
			return this.FlowIdIter().ToArray<string>();
		}

		// Token: 0x0600DE00 RID: 56832 RVA: 0x0032C05A File Offset: 0x0032A25A
		[NullableContext(1)]
		public readonly IEnumerable<string> FlowIdIter()
		{
			Tetris.<FlowIdIter>d__57 <FlowIdIter>d__ = new Tetris.<FlowIdIter>d__57(-2);
			<FlowIdIter>d__.<>3__<>4__this = this;
			return <FlowIdIter>d__;
		}

		// Token: 0x0600DE01 RID: 56833 RVA: 0x0032C070 File Offset: 0x0032A270
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ReduceDiffCntIter()或GetReduceDiffCntBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ReduceDiffCnt()
		{
			Tetris tetris = this;
			return tetris.GetReduceDiffCntArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DE02 RID: 56834 RVA: 0x0032C094 File Offset: 0x0032A294
		[NullableContext(1)]
		public readonly IEnumerable<int> ReduceDiffCntIter()
		{
			Tetris.<ReduceDiffCntIter>d__59 <ReduceDiffCntIter>d__ = new Tetris.<ReduceDiffCntIter>d__59(-2);
			<ReduceDiffCntIter>d__.<>3__<>4__this = this;
			return <ReduceDiffCntIter>d__;
		}

		// Token: 0x0600DE03 RID: 56835 RVA: 0x0032C0AC File Offset: 0x0032A2AC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用TargetResultFrozenDict()缓存字典，遍历请使用TargetResultIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> TargetResult()
		{
			return this.TargetResultIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DE04 RID: 56836 RVA: 0x0032C102 File Offset: 0x0032A302
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> TargetResultIter()
		{
			Tetris.<TargetResultIter>d__61 <TargetResultIter>d__ = new Tetris.<TargetResultIter>d__61(-2);
			<TargetResultIter>d__.<>3__<>4__this = this;
			return <TargetResultIter>d__;
		}

		// Token: 0x0600DE05 RID: 56837 RVA: 0x0032C117 File Offset: 0x0032A317
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TargetResultsIter()或GetTargetResultsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntIntMap[] TargetResults()
		{
			return this.TargetResultsIter().ToArray<IntIntMap>();
		}

		// Token: 0x0600DE06 RID: 56838 RVA: 0x0032C124 File Offset: 0x0032A324
		[NullableContext(1)]
		public readonly IEnumerable<IntIntMap> TargetResultsIter()
		{
			Tetris.<TargetResultsIter>d__63 <TargetResultsIter>d__ = new Tetris.<TargetResultsIter>d__63(-2);
			<TargetResultsIter>d__.<>3__<>4__this = this;
			return <TargetResultsIter>d__;
		}

		// Token: 0x0600DE07 RID: 56839 RVA: 0x0032C13C File Offset: 0x0032A33C
		public int? GetTargetResult(int key)
		{
			this.EnsureTargetResultCacheIfNeeded();
			int value;
			if (!this.TargetResultCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600DE08 RID: 56840 RVA: 0x0032C170 File Offset: 0x0032A370
		private void EnsureTargetResultCacheIfNeeded()
		{
			if (this.TargetResultCache != null)
			{
				return;
			}
			this.TargetResultCache = this.TargetResultIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DE09 RID: 56841 RVA: 0x0032C1D6 File Offset: 0x0032A3D6
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetTargetResultFrozenDict(int key)
		{
			this.EnsureTargetResultCacheIfNeeded();
			return this.TargetResultCache;
		}

		// Token: 0x0400525F RID: 21087
		private Table __p;

		// Token: 0x04005260 RID: 21088
		[Nullable(2)]
		private FrozenDictionary<int, int> TargetResultCache;
	}
}
