using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001146 RID: 4422
	public struct TrackMoonActivity : IFlatbufferObject
	{
		// Token: 0x17003B14 RID: 15124
		// (get) Token: 0x0600E091 RID: 57489 RVA: 0x00331B71 File Offset: 0x0032FD71
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E092 RID: 57490 RVA: 0x00331B7E File Offset: 0x0032FD7E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E093 RID: 57491 RVA: 0x00331B88 File Offset: 0x0032FD88
		public static TrackMoonActivity GetRootAsTrackMoonActivity(ByteBuffer _bb)
		{
			return TrackMoonActivity.GetRootAsTrackMoonActivity(_bb, default(TrackMoonActivity));
		}

		// Token: 0x0600E094 RID: 57492 RVA: 0x00331BA4 File Offset: 0x0032FDA4
		public static TrackMoonActivity GetRootAsTrackMoonActivity(ByteBuffer _bb, TrackMoonActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E095 RID: 57493 RVA: 0x00331BC1 File Offset: 0x0032FDC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E096 RID: 57494 RVA: 0x00331BD0 File Offset: 0x0032FDD0
		public TrackMoonActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B15 RID: 15125
		// (get) Token: 0x0600E097 RID: 57495 RVA: 0x00331BE0 File Offset: 0x0032FDE0
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

		// Token: 0x17003B16 RID: 15126
		// (get) Token: 0x0600E098 RID: 57496 RVA: 0x00331C1C File Offset: 0x0032FE1C
		public bool ActivityReward
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003B17 RID: 15127
		// (get) Token: 0x0600E099 RID: 57497 RVA: 0x00331C5C File Offset: 0x0032FE5C
		public bool PermanentTarget
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003B18 RID: 15128
		// (get) Token: 0x0600E09A RID: 57498 RVA: 0x00331C9C File Offset: 0x0032FE9C
		public int ActivityButtonType
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

		// Token: 0x0600E09B RID: 57499 RVA: 0x00331CDC File Offset: 0x0032FEDC
		public int RewardList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B19 RID: 15129
		// (get) Token: 0x0600E09C RID: 57500 RVA: 0x00331D1C File Offset: 0x0032FF1C
		public int RewardListLength
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

		// Token: 0x0600E09D RID: 57501 RVA: 0x00331D48 File Offset: 0x0032FF48
		public Span<int> GetRewardListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600E09E RID: 57502 RVA: 0x00331D58 File Offset: 0x0032FF58
		public int[] GetRewardListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17003B1A RID: 15130
		// (get) Token: 0x0600E09F RID: 57503 RVA: 0x00331D70 File Offset: 0x0032FF70
		public int FocusMarkId
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

		// Token: 0x17003B1B RID: 15131
		// (get) Token: 0x0600E0A0 RID: 57504 RVA: 0x00331DB0 File Offset: 0x0032FFB0
		public string StageQuestTips
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E0A1 RID: 57505 RVA: 0x00331DE8 File Offset: 0x0032FFE8
		public Span<byte> GetStageQuestTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E0A2 RID: 57506 RVA: 0x00331DF8 File Offset: 0x0032FFF8
		public byte[] GetStageQuestTipsArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B1C RID: 15132
		// (get) Token: 0x0600E0A3 RID: 57507 RVA: 0x00331E10 File Offset: 0x00330010
		public int StageQuestId
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

		// Token: 0x0600E0A4 RID: 57508 RVA: 0x00331E50 File Offset: 0x00330050
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RewardListIter()或GetRewardListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RewardList()
		{
			TrackMoonActivity trackMoonActivity = this;
			return trackMoonActivity.GetRewardListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E0A5 RID: 57509 RVA: 0x00331E74 File Offset: 0x00330074
		[NullableContext(1)]
		public readonly IEnumerable<int> RewardListIter()
		{
			TrackMoonActivity.<RewardListIter>d__30 <RewardListIter>d__ = new TrackMoonActivity.<RewardListIter>d__30(-2);
			<RewardListIter>d__.<>3__<>4__this = this;
			return <RewardListIter>d__;
		}

		// Token: 0x04005288 RID: 21128
		private Table __p;
	}
}
