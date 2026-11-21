using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D75 RID: 3445
	public struct FlagChallengeArea : IFlatbufferObject
	{
		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x0600770E RID: 30478 RVA: 0x00254411 File Offset: 0x00252611
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600770F RID: 30479 RVA: 0x0025441E File Offset: 0x0025261E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007710 RID: 30480 RVA: 0x00254428 File Offset: 0x00252628
		public static FlagChallengeArea GetRootAsFlagChallengeArea(ByteBuffer _bb)
		{
			return FlagChallengeArea.GetRootAsFlagChallengeArea(_bb, default(FlagChallengeArea));
		}

		// Token: 0x06007711 RID: 30481 RVA: 0x00254444 File Offset: 0x00252644
		public static FlagChallengeArea GetRootAsFlagChallengeArea(ByteBuffer _bb, FlagChallengeArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007712 RID: 30482 RVA: 0x00254461 File Offset: 0x00252661
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007713 RID: 30483 RVA: 0x00254470 File Offset: 0x00252670
		public FlagChallengeArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x06007714 RID: 30484 RVA: 0x00254480 File Offset: 0x00252680
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

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x06007715 RID: 30485 RVA: 0x002544BC File Offset: 0x002526BC
		public int LevelId
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

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x06007716 RID: 30486 RVA: 0x002544F8 File Offset: 0x002526F8
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

		// Token: 0x06007717 RID: 30487 RVA: 0x0025452F File Offset: 0x0025272F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007718 RID: 30488 RVA: 0x0025453E File Offset: 0x0025273E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x06007719 RID: 30489 RVA: 0x00254558 File Offset: 0x00252758
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600771A RID: 30490 RVA: 0x00254590 File Offset: 0x00252790
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600771B RID: 30491 RVA: 0x002545A0 File Offset: 0x002527A0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600771C RID: 30492 RVA: 0x002545B8 File Offset: 0x002527B8
		public int Strongholds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x0600771D RID: 30493 RVA: 0x002545F8 File Offset: 0x002527F8
		public int StrongholdsLength
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

		// Token: 0x0600771E RID: 30494 RVA: 0x00254624 File Offset: 0x00252824
		public Span<int> GetStrongholdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600771F RID: 30495 RVA: 0x00254634 File Offset: 0x00252834
		public int[] GetStrongholdsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x06007720 RID: 30496 RVA: 0x0025464C File Offset: 0x0025284C
		public int RecommendLevels(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x06007721 RID: 30497 RVA: 0x0025468C File Offset: 0x0025288C
		public int RecommendLevelsLength
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

		// Token: 0x06007722 RID: 30498 RVA: 0x002546B8 File Offset: 0x002528B8
		public Span<int> GetRecommendLevelsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06007723 RID: 30499 RVA: 0x002546C8 File Offset: 0x002528C8
		public int[] GetRecommendLevelsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x06007724 RID: 30500 RVA: 0x002546E0 File Offset: 0x002528E0
		public string IconPath
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

		// Token: 0x06007725 RID: 30501 RVA: 0x00254718 File Offset: 0x00252918
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007726 RID: 30502 RVA: 0x00254728 File Offset: 0x00252928
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x06007727 RID: 30503 RVA: 0x00254740 File Offset: 0x00252940
		public int UiPos
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

		// Token: 0x06007728 RID: 30504 RVA: 0x0025477D File Offset: 0x0025297D
		[NullableContext(1)]
		public int[] RecommendLevels()
		{
			return this.GetRecommendLevelsArray();
		}

		// Token: 0x06007729 RID: 30505 RVA: 0x00254785 File Offset: 0x00252985
		[NullableContext(1)]
		public IEnumerable<int> RecommendLevelsIter()
		{
			FlagChallengeArea.<RecommendLevelsIter>d__37 <RecommendLevelsIter>d__ = new FlagChallengeArea.<RecommendLevelsIter>d__37(-2);
			<RecommendLevelsIter>d__.<>3__<>4__this = this;
			return <RecommendLevelsIter>d__;
		}

		// Token: 0x0600772A RID: 30506 RVA: 0x0025479A File Offset: 0x0025299A
		[NullableContext(1)]
		public int[] Strongholds()
		{
			return this.GetStrongholdsArray();
		}

		// Token: 0x0600772B RID: 30507 RVA: 0x002547A2 File Offset: 0x002529A2
		[NullableContext(1)]
		public IEnumerable<int> StrongholdsIter()
		{
			FlagChallengeArea.<StrongholdsIter>d__39 <StrongholdsIter>d__ = new FlagChallengeArea.<StrongholdsIter>d__39(-2);
			<StrongholdsIter>d__.<>3__<>4__this = this;
			return <StrongholdsIter>d__;
		}

		// Token: 0x040052CC RID: 21196
		private Table __p;
	}
}
