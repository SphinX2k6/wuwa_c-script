using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F8C RID: 3980
	public struct RacingBetsMatch : IFlatbufferObject
	{
		// Token: 0x17002CB5 RID: 11445
		// (get) Token: 0x0600B851 RID: 47185 RVA: 0x002D5C59 File Offset: 0x002D3E59
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B852 RID: 47186 RVA: 0x002D5C66 File Offset: 0x002D3E66
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B853 RID: 47187 RVA: 0x002D5C70 File Offset: 0x002D3E70
		public static RacingBetsMatch GetRootAsRacingBetsMatch(ByteBuffer _bb)
		{
			return RacingBetsMatch.GetRootAsRacingBetsMatch(_bb, default(RacingBetsMatch));
		}

		// Token: 0x0600B854 RID: 47188 RVA: 0x002D5C8C File Offset: 0x002D3E8C
		public static RacingBetsMatch GetRootAsRacingBetsMatch(ByteBuffer _bb, RacingBetsMatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B855 RID: 47189 RVA: 0x002D5CA9 File Offset: 0x002D3EA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B856 RID: 47190 RVA: 0x002D5CB8 File Offset: 0x002D3EB8
		public RacingBetsMatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002CB6 RID: 11446
		// (get) Token: 0x0600B857 RID: 47191 RVA: 0x002D5CC8 File Offset: 0x002D3EC8
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

		// Token: 0x17002CB7 RID: 11447
		// (get) Token: 0x0600B858 RID: 47192 RVA: 0x002D5D04 File Offset: 0x002D3F04
		public int SeasonId
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

		// Token: 0x17002CB8 RID: 11448
		// (get) Token: 0x0600B859 RID: 47193 RVA: 0x002D5D40 File Offset: 0x002D3F40
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

		// Token: 0x0600B85A RID: 47194 RVA: 0x002D5D77 File Offset: 0x002D3F77
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B85B RID: 47195 RVA: 0x002D5D86 File Offset: 0x002D3F86
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B85C RID: 47196 RVA: 0x002D5DA0 File Offset: 0x002D3FA0
		public int GroupMatchList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002CB9 RID: 11449
		// (get) Token: 0x0600B85D RID: 47197 RVA: 0x002D5DE0 File Offset: 0x002D3FE0
		public int GroupMatchListLength
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

		// Token: 0x0600B85E RID: 47198 RVA: 0x002D5E0C File Offset: 0x002D400C
		public Span<int> GetGroupMatchListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600B85F RID: 47199 RVA: 0x002D5E1C File Offset: 0x002D401C
		public int[] GetGroupMatchListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600B860 RID: 47200 RVA: 0x002D5E34 File Offset: 0x002D4034
		public int AdvancedDangoIdSourceGroupMatchList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002CBA RID: 11450
		// (get) Token: 0x0600B861 RID: 47201 RVA: 0x002D5E74 File Offset: 0x002D4074
		public int AdvancedDangoIdSourceGroupMatchListLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B862 RID: 47202 RVA: 0x002D5EA0 File Offset: 0x002D40A0
		public Span<int> GetAdvancedDangoIdSourceGroupMatchListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600B863 RID: 47203 RVA: 0x002D5EB0 File Offset: 0x002D40B0
		public int[] GetAdvancedDangoIdSourceGroupMatchListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600B864 RID: 47204 RVA: 0x002D5EC8 File Offset: 0x002D40C8
		public int AdvancedDangoIdTargetGroupMatchList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002CBB RID: 11451
		// (get) Token: 0x0600B865 RID: 47205 RVA: 0x002D5F08 File Offset: 0x002D4108
		public int AdvancedDangoIdTargetGroupMatchListLength
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

		// Token: 0x0600B866 RID: 47206 RVA: 0x002D5F34 File Offset: 0x002D4134
		public Span<int> GetAdvancedDangoIdTargetGroupMatchListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600B867 RID: 47207 RVA: 0x002D5F44 File Offset: 0x002D4144
		public int[] GetAdvancedDangoIdTargetGroupMatchListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17002CBC RID: 11452
		// (get) Token: 0x0600B868 RID: 47208 RVA: 0x002D5F5C File Offset: 0x002D415C
		public int FarewellMatchId
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

		// Token: 0x0600B869 RID: 47209 RVA: 0x002D5F9C File Offset: 0x002D419C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AdvancedDangoIdSourceGroupMatchListIter()或GetAdvancedDangoIdSourceGroupMatchListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AdvancedDangoIdSourceGroupMatchList()
		{
			RacingBetsMatch racingBetsMatch = this;
			return racingBetsMatch.GetAdvancedDangoIdSourceGroupMatchListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B86A RID: 47210 RVA: 0x002D5FC0 File Offset: 0x002D41C0
		[NullableContext(1)]
		public readonly IEnumerable<int> AdvancedDangoIdSourceGroupMatchListIter()
		{
			RacingBetsMatch.<AdvancedDangoIdSourceGroupMatchListIter>d__34 <AdvancedDangoIdSourceGroupMatchListIter>d__ = new RacingBetsMatch.<AdvancedDangoIdSourceGroupMatchListIter>d__34(-2);
			<AdvancedDangoIdSourceGroupMatchListIter>d__.<>3__<>4__this = this;
			return <AdvancedDangoIdSourceGroupMatchListIter>d__;
		}

		// Token: 0x0600B86B RID: 47211 RVA: 0x002D5FD8 File Offset: 0x002D41D8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AdvancedDangoIdTargetGroupMatchListIter()或GetAdvancedDangoIdTargetGroupMatchListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AdvancedDangoIdTargetGroupMatchList()
		{
			RacingBetsMatch racingBetsMatch = this;
			return racingBetsMatch.GetAdvancedDangoIdTargetGroupMatchListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B86C RID: 47212 RVA: 0x002D5FFC File Offset: 0x002D41FC
		[NullableContext(1)]
		public readonly IEnumerable<int> AdvancedDangoIdTargetGroupMatchListIter()
		{
			RacingBetsMatch.<AdvancedDangoIdTargetGroupMatchListIter>d__36 <AdvancedDangoIdTargetGroupMatchListIter>d__ = new RacingBetsMatch.<AdvancedDangoIdTargetGroupMatchListIter>d__36(-2);
			<AdvancedDangoIdTargetGroupMatchListIter>d__.<>3__<>4__this = this;
			return <AdvancedDangoIdTargetGroupMatchListIter>d__;
		}

		// Token: 0x0600B86D RID: 47213 RVA: 0x002D6014 File Offset: 0x002D4214
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GroupMatchListIter()或GetGroupMatchListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] GroupMatchList()
		{
			RacingBetsMatch racingBetsMatch = this;
			return racingBetsMatch.GetGroupMatchListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B86E RID: 47214 RVA: 0x002D6038 File Offset: 0x002D4238
		[NullableContext(1)]
		public readonly IEnumerable<int> GroupMatchListIter()
		{
			RacingBetsMatch.<GroupMatchListIter>d__38 <GroupMatchListIter>d__ = new RacingBetsMatch.<GroupMatchListIter>d__38(-2);
			<GroupMatchListIter>d__.<>3__<>4__this = this;
			return <GroupMatchListIter>d__;
		}

		// Token: 0x0400505B RID: 20571
		private Table __p;
	}
}
