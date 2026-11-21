using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200127C RID: 4732
	public struct TrackMoonActivity : IFlatbufferObject
	{
		// Token: 0x17003E78 RID: 15992
		// (get) Token: 0x0600EDFF RID: 60927 RVA: 0x0035CFBD File Offset: 0x0035B1BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EE00 RID: 60928 RVA: 0x0035CFCA File Offset: 0x0035B1CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EE01 RID: 60929 RVA: 0x0035CFD4 File Offset: 0x0035B1D4
		public static TrackMoonActivity GetRootAsTrackMoonActivity(ByteBuffer _bb)
		{
			return TrackMoonActivity.GetRootAsTrackMoonActivity(_bb, default(TrackMoonActivity));
		}

		// Token: 0x0600EE02 RID: 60930 RVA: 0x0035CFF0 File Offset: 0x0035B1F0
		public static TrackMoonActivity GetRootAsTrackMoonActivity(ByteBuffer _bb, TrackMoonActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EE03 RID: 60931 RVA: 0x0035D00D File Offset: 0x0035B20D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EE04 RID: 60932 RVA: 0x0035D01C File Offset: 0x0035B21C
		public TrackMoonActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E79 RID: 15993
		// (get) Token: 0x0600EE05 RID: 60933 RVA: 0x0035D02C File Offset: 0x0035B22C
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

		// Token: 0x17003E7A RID: 15994
		// (get) Token: 0x0600EE06 RID: 60934 RVA: 0x0035D068 File Offset: 0x0035B268
		public bool ActivityReward
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003E7B RID: 15995
		// (get) Token: 0x0600EE07 RID: 60935 RVA: 0x0035D0A8 File Offset: 0x0035B2A8
		public bool PermanentTarget
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003E7C RID: 15996
		// (get) Token: 0x0600EE08 RID: 60936 RVA: 0x0035D0E8 File Offset: 0x0035B2E8
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

		// Token: 0x0600EE09 RID: 60937 RVA: 0x0035D128 File Offset: 0x0035B328
		public int RewardList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003E7D RID: 15997
		// (get) Token: 0x0600EE0A RID: 60938 RVA: 0x0035D168 File Offset: 0x0035B368
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

		// Token: 0x0600EE0B RID: 60939 RVA: 0x0035D194 File Offset: 0x0035B394
		public Span<int> GetRewardListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600EE0C RID: 60940 RVA: 0x0035D1A4 File Offset: 0x0035B3A4
		public int[] GetRewardListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17003E7E RID: 15998
		// (get) Token: 0x0600EE0D RID: 60941 RVA: 0x0035D1BC File Offset: 0x0035B3BC
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

		// Token: 0x17003E7F RID: 15999
		// (get) Token: 0x0600EE0E RID: 60942 RVA: 0x0035D1FC File Offset: 0x0035B3FC
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

		// Token: 0x0600EE0F RID: 60943 RVA: 0x0035D234 File Offset: 0x0035B434
		public Span<byte> GetStageQuestTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600EE10 RID: 60944 RVA: 0x0035D244 File Offset: 0x0035B444
		public byte[] GetStageQuestTipsArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E80 RID: 16000
		// (get) Token: 0x0600EE11 RID: 60945 RVA: 0x0035D25C File Offset: 0x0035B45C
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

		// Token: 0x0600EE12 RID: 60946 RVA: 0x0035D299 File Offset: 0x0035B499
		[NullableContext(1)]
		public int[] RewardList()
		{
			return this.GetRewardListArray();
		}

		// Token: 0x0600EE13 RID: 60947 RVA: 0x0035D2A1 File Offset: 0x0035B4A1
		[NullableContext(1)]
		public IEnumerable<int> RewardListIter()
		{
			TrackMoonActivity.<RewardListIter>d__30 <RewardListIter>d__ = new TrackMoonActivity.<RewardListIter>d__30(-2);
			<RewardListIter>d__.<>3__<>4__this = this;
			return <RewardListIter>d__;
		}

		// Token: 0x040058CB RID: 22731
		private Table __p;
	}
}
