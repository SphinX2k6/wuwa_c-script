using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D76 RID: 3446
	public struct FlagChallengeLevel : IFlatbufferObject
	{
		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x0600772C RID: 30508 RVA: 0x002547B7 File Offset: 0x002529B7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600772D RID: 30509 RVA: 0x002547C4 File Offset: 0x002529C4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600772E RID: 30510 RVA: 0x002547CC File Offset: 0x002529CC
		public static FlagChallengeLevel GetRootAsFlagChallengeLevel(ByteBuffer _bb)
		{
			return FlagChallengeLevel.GetRootAsFlagChallengeLevel(_bb, default(FlagChallengeLevel));
		}

		// Token: 0x0600772F RID: 30511 RVA: 0x002547E8 File Offset: 0x002529E8
		public static FlagChallengeLevel GetRootAsFlagChallengeLevel(ByteBuffer _bb, FlagChallengeLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007730 RID: 30512 RVA: 0x00254805 File Offset: 0x00252A05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007731 RID: 30513 RVA: 0x00254814 File Offset: 0x00252A14
		public FlagChallengeLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x06007732 RID: 30514 RVA: 0x00254824 File Offset: 0x00252A24
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

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x06007733 RID: 30515 RVA: 0x00254860 File Offset: 0x00252A60
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

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x06007734 RID: 30516 RVA: 0x0025489C File Offset: 0x00252A9C
		public int InstId
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

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x06007735 RID: 30517 RVA: 0x002548D8 File Offset: 0x00252AD8
		public int UnlockLevel
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

		// Token: 0x06007736 RID: 30518 RVA: 0x00254918 File Offset: 0x00252B18
		public int PreLevelId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x06007737 RID: 30519 RVA: 0x00254958 File Offset: 0x00252B58
		public int PreLevelIdLength
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

		// Token: 0x06007738 RID: 30520 RVA: 0x00254984 File Offset: 0x00252B84
		public Span<int> GetPreLevelIdBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06007739 RID: 30521 RVA: 0x00254994 File Offset: 0x00252B94
		public int[] GetPreLevelIdArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x0600773A RID: 30522 RVA: 0x002549AC File Offset: 0x00252BAC
		public string Name
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

		// Token: 0x0600773B RID: 30523 RVA: 0x002549E4 File Offset: 0x00252BE4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600773C RID: 30524 RVA: 0x002549F4 File Offset: 0x00252BF4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x0600773D RID: 30525 RVA: 0x00254A0C File Offset: 0x00252C0C
		public string Desc
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

		// Token: 0x0600773E RID: 30526 RVA: 0x00254A44 File Offset: 0x00252C44
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600773F RID: 30527 RVA: 0x00254A54 File Offset: 0x00252C54
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x06007740 RID: 30528 RVA: 0x00254A6C File Offset: 0x00252C6C
		public int UiStyle
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

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x06007741 RID: 30529 RVA: 0x00254AAC File Offset: 0x00252CAC
		public bool IsHiddenLevel
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06007742 RID: 30530 RVA: 0x00254AEC File Offset: 0x00252CEC
		public int RecommendLevels(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x06007743 RID: 30531 RVA: 0x00254B2C File Offset: 0x00252D2C
		public int RecommendLevelsLength
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

		// Token: 0x06007744 RID: 30532 RVA: 0x00254B58 File Offset: 0x00252D58
		public Span<int> GetRecommendLevelsBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x06007745 RID: 30533 RVA: 0x00254B68 File Offset: 0x00252D68
		public int[] GetRecommendLevelsArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x06007746 RID: 30534 RVA: 0x00254B80 File Offset: 0x00252D80
		[NullableContext(1)]
		public int[] PreLevelId()
		{
			return this.GetPreLevelIdArray();
		}

		// Token: 0x06007747 RID: 30535 RVA: 0x00254B88 File Offset: 0x00252D88
		[NullableContext(1)]
		public IEnumerable<int> PreLevelIdIter()
		{
			FlagChallengeLevel.<PreLevelIdIter>d__39 <PreLevelIdIter>d__ = new FlagChallengeLevel.<PreLevelIdIter>d__39(-2);
			<PreLevelIdIter>d__.<>3__<>4__this = this;
			return <PreLevelIdIter>d__;
		}

		// Token: 0x06007748 RID: 30536 RVA: 0x00254B9D File Offset: 0x00252D9D
		[NullableContext(1)]
		public int[] RecommendLevels()
		{
			return this.GetRecommendLevelsArray();
		}

		// Token: 0x06007749 RID: 30537 RVA: 0x00254BA5 File Offset: 0x00252DA5
		[NullableContext(1)]
		public IEnumerable<int> RecommendLevelsIter()
		{
			FlagChallengeLevel.<RecommendLevelsIter>d__41 <RecommendLevelsIter>d__ = new FlagChallengeLevel.<RecommendLevelsIter>d__41(-2);
			<RecommendLevelsIter>d__.<>3__<>4__this = this;
			return <RecommendLevelsIter>d__;
		}

		// Token: 0x040052CD RID: 21197
		private Table __p;
	}
}
