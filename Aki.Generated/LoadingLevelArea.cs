using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DD5 RID: 3541
	public struct LoadingLevelArea : IFlatbufferObject
	{
		// Token: 0x17001D34 RID: 7476
		// (get) Token: 0x06008F10 RID: 36624 RVA: 0x00279F58 File Offset: 0x00278158
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008F11 RID: 36625 RVA: 0x00279F65 File Offset: 0x00278165
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008F12 RID: 36626 RVA: 0x00279F6C File Offset: 0x0027816C
		public static LoadingLevelArea GetRootAsLoadingLevelArea(ByteBuffer _bb)
		{
			return LoadingLevelArea.GetRootAsLoadingLevelArea(_bb, default(LoadingLevelArea));
		}

		// Token: 0x06008F13 RID: 36627 RVA: 0x00279F88 File Offset: 0x00278188
		public static LoadingLevelArea GetRootAsLoadingLevelArea(ByteBuffer _bb, LoadingLevelArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008F14 RID: 36628 RVA: 0x00279FA5 File Offset: 0x002781A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008F15 RID: 36629 RVA: 0x00279FB4 File Offset: 0x002781B4
		public LoadingLevelArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D35 RID: 7477
		// (get) Token: 0x06008F16 RID: 36630 RVA: 0x00279FC4 File Offset: 0x002781C4
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

		// Token: 0x06008F17 RID: 36631 RVA: 0x0027A000 File Offset: 0x00278200
		public int LevelRange(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D36 RID: 7478
		// (get) Token: 0x06008F18 RID: 36632 RVA: 0x0027A040 File Offset: 0x00278240
		public int LevelRangeLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008F19 RID: 36633 RVA: 0x0027A06B File Offset: 0x0027826B
		public Span<int> GetLevelRangeBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06008F1A RID: 36634 RVA: 0x0027A07A File Offset: 0x0027827A
		public int[] GetLevelRangeArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06008F1B RID: 36635 RVA: 0x0027A094 File Offset: 0x00278294
		public int AreaId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D37 RID: 7479
		// (get) Token: 0x06008F1C RID: 36636 RVA: 0x0027A0D4 File Offset: 0x002782D4
		public int AreaIdLength
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

		// Token: 0x06008F1D RID: 36637 RVA: 0x0027A0FF File Offset: 0x002782FF
		public Span<int> GetAreaIdBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06008F1E RID: 36638 RVA: 0x0027A10E File Offset: 0x0027830E
		public int[] GetAreaIdArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06008F1F RID: 36639 RVA: 0x0027A128 File Offset: 0x00278328
		public int MapId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D38 RID: 7480
		// (get) Token: 0x06008F20 RID: 36640 RVA: 0x0027A168 File Offset: 0x00278368
		public int MapIdLength
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

		// Token: 0x06008F21 RID: 36641 RVA: 0x0027A194 File Offset: 0x00278394
		public Span<int> GetMapIdBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06008F22 RID: 36642 RVA: 0x0027A1A4 File Offset: 0x002783A4
		public int[] GetMapIdArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17001D39 RID: 7481
		// (get) Token: 0x06008F23 RID: 36643 RVA: 0x0027A1BC File Offset: 0x002783BC
		public int ConditionGroup
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

		// Token: 0x17001D3A RID: 7482
		// (get) Token: 0x06008F24 RID: 36644 RVA: 0x0027A1FC File Offset: 0x002783FC
		public bool IsLimitShow
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001D3B RID: 7483
		// (get) Token: 0x06008F25 RID: 36645 RVA: 0x0027A23C File Offset: 0x0027843C
		public int BeginTime
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

		// Token: 0x17001D3C RID: 7484
		// (get) Token: 0x06008F26 RID: 36646 RVA: 0x0027A27C File Offset: 0x0027847C
		public int EndTime
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

		// Token: 0x17001D3D RID: 7485
		// (get) Token: 0x06008F27 RID: 36647 RVA: 0x0027A2BC File Offset: 0x002784BC
		public int ActivityId
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

		// Token: 0x17001D3E RID: 7486
		// (get) Token: 0x06008F28 RID: 36648 RVA: 0x0027A2FC File Offset: 0x002784FC
		public int Type
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

		// Token: 0x17001D3F RID: 7487
		// (get) Token: 0x06008F29 RID: 36649 RVA: 0x0027A33C File Offset: 0x0027853C
		public int DuringTime
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008F2A RID: 36650 RVA: 0x0027A37C File Offset: 0x0027857C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AreaIdIter()或GetAreaIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AreaId()
		{
			LoadingLevelArea loadingLevelArea = this;
			return loadingLevelArea.GetAreaIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008F2B RID: 36651 RVA: 0x0027A3A0 File Offset: 0x002785A0
		[NullableContext(1)]
		public readonly IEnumerable<int> AreaIdIter()
		{
			LoadingLevelArea.<AreaIdIter>d__40 <AreaIdIter>d__ = new LoadingLevelArea.<AreaIdIter>d__40(-2);
			<AreaIdIter>d__.<>3__<>4__this = this;
			return <AreaIdIter>d__;
		}

		// Token: 0x06008F2C RID: 36652 RVA: 0x0027A3B8 File Offset: 0x002785B8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LevelRangeIter()或GetLevelRangeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LevelRange()
		{
			LoadingLevelArea loadingLevelArea = this;
			return loadingLevelArea.GetLevelRangeArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008F2D RID: 36653 RVA: 0x0027A3DC File Offset: 0x002785DC
		[NullableContext(1)]
		public readonly IEnumerable<int> LevelRangeIter()
		{
			LoadingLevelArea.<LevelRangeIter>d__42 <LevelRangeIter>d__ = new LoadingLevelArea.<LevelRangeIter>d__42(-2);
			<LevelRangeIter>d__.<>3__<>4__this = this;
			return <LevelRangeIter>d__;
		}

		// Token: 0x06008F2E RID: 36654 RVA: 0x0027A3F4 File Offset: 0x002785F4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MapIdIter()或GetMapIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MapId()
		{
			LoadingLevelArea loadingLevelArea = this;
			return loadingLevelArea.GetMapIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008F2F RID: 36655 RVA: 0x0027A418 File Offset: 0x00278618
		[NullableContext(1)]
		public readonly IEnumerable<int> MapIdIter()
		{
			LoadingLevelArea.<MapIdIter>d__44 <MapIdIter>d__ = new LoadingLevelArea.<MapIdIter>d__44(-2);
			<MapIdIter>d__.<>3__<>4__this = this;
			return <MapIdIter>d__;
		}

		// Token: 0x04004E70 RID: 20080
		private Table __p;
	}
}
