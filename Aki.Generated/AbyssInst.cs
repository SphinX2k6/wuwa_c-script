using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AAD RID: 2733
	public struct AbyssInst : IFlatbufferObject
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06004059 RID: 16473 RVA: 0x001C4EA9 File Offset: 0x001C30A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600405A RID: 16474 RVA: 0x001C4EB6 File Offset: 0x001C30B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600405B RID: 16475 RVA: 0x001C4EC0 File Offset: 0x001C30C0
		public static AbyssInst GetRootAsAbyssInst(ByteBuffer _bb)
		{
			return AbyssInst.GetRootAsAbyssInst(_bb, default(AbyssInst));
		}

		// Token: 0x0600405C RID: 16476 RVA: 0x001C4EDC File Offset: 0x001C30DC
		public static AbyssInst GetRootAsAbyssInst(ByteBuffer _bb, AbyssInst obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600405D RID: 16477 RVA: 0x001C4EF9 File Offset: 0x001C30F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x001C4F08 File Offset: 0x001C3108
		public AbyssInst __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600405F RID: 16479 RVA: 0x001C4F18 File Offset: 0x001C3118
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

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06004060 RID: 16480 RVA: 0x001C4F54 File Offset: 0x001C3154
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

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06004061 RID: 16481 RVA: 0x001C4F90 File Offset: 0x001C3190
		public int ActivityId
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

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06004062 RID: 16482 RVA: 0x001C4FCC File Offset: 0x001C31CC
		public bool PlanarDungeon
		{
			get
			{
				int num = this.__p.__offset(10);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06004063 RID: 16483 RVA: 0x001C500C File Offset: 0x001C320C
		public int InstEntranceId
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

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06004064 RID: 16484 RVA: 0x001C504C File Offset: 0x001C324C
		public int RouteId
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

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06004065 RID: 16485 RVA: 0x001C508C File Offset: 0x001C328C
		public int Difficulty
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

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06004066 RID: 16486 RVA: 0x001C50CC File Offset: 0x001C32CC
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

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06004067 RID: 16487 RVA: 0x001C510C File Offset: 0x001C330C
		public bool IsEndless
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06004068 RID: 16488 RVA: 0x001C514C File Offset: 0x001C334C
		public int ConditionId
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

		// Token: 0x06004069 RID: 16489 RVA: 0x001C518C File Offset: 0x001C338C
		public DicIntInt? ConsumeItem(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600406A RID: 16490 RVA: 0x001C51F0 File Offset: 0x001C33F0
		public int ConsumeItemLength
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

		// Token: 0x0600406B RID: 16491 RVA: 0x001C521C File Offset: 0x001C341C
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(26);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600406C RID: 16492 RVA: 0x001C5268 File Offset: 0x001C3468
		public int BuffIdsLength
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

		// Token: 0x0600406D RID: 16493 RVA: 0x001C5294 File Offset: 0x001C3494
		public Span<long> GetBuffIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(26, 8));
		}

		// Token: 0x0600406E RID: 16494 RVA: 0x001C52A9 File Offset: 0x001C34A9
		public long[] GetBuffIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(26) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600406F RID: 16495 RVA: 0x001C52E8 File Offset: 0x001C34E8
		public int ReviveTimes(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06004070 RID: 16496 RVA: 0x001C5328 File Offset: 0x001C3528
		public int ReviveTimesLength
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

		// Token: 0x06004071 RID: 16497 RVA: 0x001C5354 File Offset: 0x001C3554
		public Span<int> GetReviveTimesBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x06004072 RID: 16498 RVA: 0x001C5364 File Offset: 0x001C3564
		public int[] GetReviveTimesArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06004073 RID: 16499 RVA: 0x001C537C File Offset: 0x001C357C
		public int SingleReviveDelay
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06004074 RID: 16500 RVA: 0x001C53BC File Offset: 0x001C35BC
		public int MultiReviveDelay
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

		// Token: 0x06004075 RID: 16501 RVA: 0x001C53FC File Offset: 0x001C35FC
		public int UnlockLittleRole(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06004076 RID: 16502 RVA: 0x001C543C File Offset: 0x001C363C
		public int UnlockLittleRoleLength
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

		// Token: 0x06004077 RID: 16503 RVA: 0x001C5468 File Offset: 0x001C3668
		public Span<int> GetUnlockLittleRoleBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x06004078 RID: 16504 RVA: 0x001C5478 File Offset: 0x001C3678
		public int[] GetUnlockLittleRoleArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06004079 RID: 16505 RVA: 0x001C5490 File Offset: 0x001C3690
		public bool RankOpen
		{
			get
			{
				int num = this.__p.__offset(36);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600407A RID: 16506 RVA: 0x001C54D0 File Offset: 0x001C36D0
		public int TotalTime
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

		// Token: 0x0600407B RID: 16507 RVA: 0x001C5510 File Offset: 0x001C3710
		public DicIntString? BtPropName(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600407C RID: 16508 RVA: 0x001C5574 File Offset: 0x001C3774
		public int BtPropNameLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600407D RID: 16509 RVA: 0x001C55A0 File Offset: 0x001C37A0
		public int TotalScore
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600407E RID: 16510 RVA: 0x001C55E0 File Offset: 0x001C37E0
		public DicIntInt? MonsterTypeScore(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600407F RID: 16511 RVA: 0x001C5644 File Offset: 0x001C3844
		public int MonsterTypeScoreLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004080 RID: 16512 RVA: 0x001C5670 File Offset: 0x001C3870
		public DicIntInt? RewardTime(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06004081 RID: 16513 RVA: 0x001C56D4 File Offset: 0x001C38D4
		public int RewardTimeLength
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06004082 RID: 16514 RVA: 0x001C5700 File Offset: 0x001C3900
		public int DropPreviewId
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06004083 RID: 16515 RVA: 0x001C5740 File Offset: 0x001C3940
		public string Title
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

		// Token: 0x06004084 RID: 16516 RVA: 0x001C5778 File Offset: 0x001C3978
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x06004085 RID: 16517 RVA: 0x001C5788 File Offset: 0x001C3988
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06004086 RID: 16518 RVA: 0x001C57A0 File Offset: 0x001C39A0
		public string SubTitle
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

		// Token: 0x06004087 RID: 16519 RVA: 0x001C57D8 File Offset: 0x001C39D8
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x06004088 RID: 16520 RVA: 0x001C57E8 File Offset: 0x001C39E8
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06004089 RID: 16521 RVA: 0x001C5800 File Offset: 0x001C3A00
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600408A RID: 16522 RVA: 0x001C5838 File Offset: 0x001C3A38
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x0600408B RID: 16523 RVA: 0x001C5848 File Offset: 0x001C3A48
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600408C RID: 16524 RVA: 0x001C5860 File Offset: 0x001C3A60
		public string Goat
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600408D RID: 16525 RVA: 0x001C5898 File Offset: 0x001C3A98
		public Span<byte> GetGoatBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x0600408E RID: 16526 RVA: 0x001C58A8 File Offset: 0x001C3AA8
		public byte[] GetGoatArray()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600408F RID: 16527 RVA: 0x001C58C0 File Offset: 0x001C3AC0
		public string UnLockDesc
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x001C58F8 File Offset: 0x001C3AF8
		public Span<byte> GetUnLockDescBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x001C5908 File Offset: 0x001C3B08
		public byte[] GetUnLockDescArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06004092 RID: 16530 RVA: 0x001C5920 File Offset: 0x001C3B20
		public string AbyssColor
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004093 RID: 16531 RVA: 0x001C5958 File Offset: 0x001C3B58
		public Span<byte> GetAbyssColorBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x001C5968 File Offset: 0x001C3B68
		public byte[] GetAbyssColorArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06004095 RID: 16533 RVA: 0x001C5980 File Offset: 0x001C3B80
		public string SmallWorldShowSceneItem
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004096 RID: 16534 RVA: 0x001C59B8 File Offset: 0x001C3BB8
		public Span<byte> GetSmallWorldShowSceneItemBytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x06004097 RID: 16535 RVA: 0x001C59C8 File Offset: 0x001C3BC8
		public byte[] GetSmallWorldShowSceneItemArray()
		{
			return this.__p.__vector_as_array<byte>(62) ?? Array.Empty<byte>();
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06004098 RID: 16536 RVA: 0x001C59E0 File Offset: 0x001C3BE0
		public string AbyssShowCake
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004099 RID: 16537 RVA: 0x001C5A18 File Offset: 0x001C3C18
		public Span<byte> GetAbyssShowCakeBytes()
		{
			return this.__p.__vector_as_span<byte>(64, 1);
		}

		// Token: 0x0600409A RID: 16538 RVA: 0x001C5A28 File Offset: 0x001C3C28
		public byte[] GetAbyssShowCakeArray()
		{
			return this.__p.__vector_as_array<byte>(64) ?? Array.Empty<byte>();
		}

		// Token: 0x0600409B RID: 16539 RVA: 0x001C5A40 File Offset: 0x001C3C40
		public int RecommendLittleRole(int j)
		{
			int num = this.__p.__offset(66);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600409C RID: 16540 RVA: 0x001C5A80 File Offset: 0x001C3C80
		public int RecommendLittleRoleLength
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600409D RID: 16541 RVA: 0x001C5AAC File Offset: 0x001C3CAC
		public Span<int> GetRecommendLittleRoleBytes()
		{
			return this.__p.__vector_as_span<int>(66, 4);
		}

		// Token: 0x0600409E RID: 16542 RVA: 0x001C5ABC File Offset: 0x001C3CBC
		public int[] GetRecommendLittleRoleArray()
		{
			return this.__p.__vector_as_array<int>(66) ?? Array.Empty<int>();
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600409F RID: 16543 RVA: 0x001C5AD4 File Offset: 0x001C3CD4
		public bool AbyssDevelopEntr
		{
			get
			{
				int num = this.__p.__offset(68);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060040A0 RID: 16544 RVA: 0x001C5B14 File Offset: 0x001C3D14
		public bool AbyssStoreEntr
		{
			get
			{
				int num = this.__p.__offset(70);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060040A1 RID: 16545 RVA: 0x001C5B54 File Offset: 0x001C3D54
		public bool AbyssSynthesisEntr
		{
			get
			{
				int num = this.__p.__offset(72);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060040A2 RID: 16546 RVA: 0x001C5B94 File Offset: 0x001C3D94
		public bool AbyssRank
		{
			get
			{
				int num = this.__p.__offset(74);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060040A3 RID: 16547 RVA: 0x001C5BD4 File Offset: 0x001C3DD4
		public bool IfStoryChallenge
		{
			get
			{
				int num = this.__p.__offset(76);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060040A4 RID: 16548 RVA: 0x001C5C14 File Offset: 0x001C3E14
		[NullableContext(1)]
		[Obsolete("已废弃，请使用BtPropNameFrozenDict()缓存字典，遍历请使用BtPropNameIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> BtPropName()
		{
			return this.BtPropNameIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x060040A5 RID: 16549 RVA: 0x001C5C6A File Offset: 0x001C3E6A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> BtPropNameIter()
		{
			AbyssInst.<BtPropNameIter>d__115 <BtPropNameIter>d__ = new AbyssInst.<BtPropNameIter>d__115(-2);
			<BtPropNameIter>d__.<>3__<>4__this = this;
			return <BtPropNameIter>d__;
		}

		// Token: 0x060040A6 RID: 16550 RVA: 0x001C5C80 File Offset: 0x001C3E80
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffIdsIter()或GetBuffIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BuffIds()
		{
			AbyssInst abyssInst = this;
			return abyssInst.GetBuffIdsArray() ?? Array.Empty<long>();
		}

		// Token: 0x060040A7 RID: 16551 RVA: 0x001C5CA4 File Offset: 0x001C3EA4
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffIdsIter()
		{
			AbyssInst.<BuffIdsIter>d__117 <BuffIdsIter>d__ = new AbyssInst.<BuffIdsIter>d__117(-2);
			<BuffIdsIter>d__.<>3__<>4__this = this;
			return <BuffIdsIter>d__;
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x001C5CBC File Offset: 0x001C3EBC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ConsumeItemFrozenDict()缓存字典，遍历请使用ConsumeItemIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ConsumeItem()
		{
			return this.ConsumeItemIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x001C5D12 File Offset: 0x001C3F12
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ConsumeItemIter()
		{
			AbyssInst.<ConsumeItemIter>d__119 <ConsumeItemIter>d__ = new AbyssInst.<ConsumeItemIter>d__119(-2);
			<ConsumeItemIter>d__.<>3__<>4__this = this;
			return <ConsumeItemIter>d__;
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x001C5D28 File Offset: 0x001C3F28
		[NullableContext(1)]
		[Obsolete("已废弃，请使用MonsterTypeScoreFrozenDict()缓存字典，遍历请使用MonsterTypeScoreIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> MonsterTypeScore()
		{
			return this.MonsterTypeScoreIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x001C5D7E File Offset: 0x001C3F7E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> MonsterTypeScoreIter()
		{
			AbyssInst.<MonsterTypeScoreIter>d__121 <MonsterTypeScoreIter>d__ = new AbyssInst.<MonsterTypeScoreIter>d__121(-2);
			<MonsterTypeScoreIter>d__.<>3__<>4__this = this;
			return <MonsterTypeScoreIter>d__;
		}

		// Token: 0x060040AC RID: 16556 RVA: 0x001C5D94 File Offset: 0x001C3F94
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendLittleRoleIter()或GetRecommendLittleRoleBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendLittleRole()
		{
			AbyssInst abyssInst = this;
			return abyssInst.GetRecommendLittleRoleArray() ?? Array.Empty<int>();
		}

		// Token: 0x060040AD RID: 16557 RVA: 0x001C5DB8 File Offset: 0x001C3FB8
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendLittleRoleIter()
		{
			AbyssInst.<RecommendLittleRoleIter>d__123 <RecommendLittleRoleIter>d__ = new AbyssInst.<RecommendLittleRoleIter>d__123(-2);
			<RecommendLittleRoleIter>d__.<>3__<>4__this = this;
			return <RecommendLittleRoleIter>d__;
		}

		// Token: 0x060040AE RID: 16558 RVA: 0x001C5DD0 File Offset: 0x001C3FD0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ReviveTimesIter()或GetReviveTimesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ReviveTimes()
		{
			AbyssInst abyssInst = this;
			return abyssInst.GetReviveTimesArray() ?? Array.Empty<int>();
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x001C5DF4 File Offset: 0x001C3FF4
		[NullableContext(1)]
		public readonly IEnumerable<int> ReviveTimesIter()
		{
			AbyssInst.<ReviveTimesIter>d__125 <ReviveTimesIter>d__ = new AbyssInst.<ReviveTimesIter>d__125(-2);
			<ReviveTimesIter>d__.<>3__<>4__this = this;
			return <ReviveTimesIter>d__;
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x001C5E0C File Offset: 0x001C400C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RewardTimeFrozenDict()缓存字典，遍历请使用RewardTimeIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> RewardTime()
		{
			return this.RewardTimeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x001C5E62 File Offset: 0x001C4062
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RewardTimeIter()
		{
			AbyssInst.<RewardTimeIter>d__127 <RewardTimeIter>d__ = new AbyssInst.<RewardTimeIter>d__127(-2);
			<RewardTimeIter>d__.<>3__<>4__this = this;
			return <RewardTimeIter>d__;
		}

		// Token: 0x060040B2 RID: 16562 RVA: 0x001C5E78 File Offset: 0x001C4078
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UnlockLittleRoleIter()或GetUnlockLittleRoleBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] UnlockLittleRole()
		{
			AbyssInst abyssInst = this;
			return abyssInst.GetUnlockLittleRoleArray() ?? Array.Empty<int>();
		}

		// Token: 0x060040B3 RID: 16563 RVA: 0x001C5E9C File Offset: 0x001C409C
		[NullableContext(1)]
		public readonly IEnumerable<int> UnlockLittleRoleIter()
		{
			AbyssInst.<UnlockLittleRoleIter>d__129 <UnlockLittleRoleIter>d__ = new AbyssInst.<UnlockLittleRoleIter>d__129(-2);
			<UnlockLittleRoleIter>d__.<>3__<>4__this = this;
			return <UnlockLittleRoleIter>d__;
		}

		// Token: 0x060040B4 RID: 16564 RVA: 0x001C5EB4 File Offset: 0x001C40B4
		[NullableContext(2)]
		public string GetBtPropName(int key)
		{
			this.EnsureBtPropNameCacheIfNeeded();
			string result;
			if (!this.BtPropNameCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060040B5 RID: 16565 RVA: 0x001C5EDC File Offset: 0x001C40DC
		public int? GetConsumeItem(int key)
		{
			this.EnsureConsumeItemCacheIfNeeded();
			int value;
			if (!this.ConsumeItemCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060040B6 RID: 16566 RVA: 0x001C5F10 File Offset: 0x001C4110
		public int? GetMonsterTypeScore(int key)
		{
			this.EnsureMonsterTypeScoreCacheIfNeeded();
			int value;
			if (!this.MonsterTypeScoreCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060040B7 RID: 16567 RVA: 0x001C5F44 File Offset: 0x001C4144
		public int? GetRewardTime(int key)
		{
			this.EnsureRewardTimeCacheIfNeeded();
			int value;
			if (!this.RewardTimeCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060040B8 RID: 16568 RVA: 0x001C5F78 File Offset: 0x001C4178
		private void EnsureBtPropNameCacheIfNeeded()
		{
			if (this.BtPropNameCache != null)
			{
				return;
			}
			this.BtPropNameCache = this.BtPropNameIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x060040B9 RID: 16569 RVA: 0x001C5FE0 File Offset: 0x001C41E0
		private void EnsureConsumeItemCacheIfNeeded()
		{
			if (this.ConsumeItemCache != null)
			{
				return;
			}
			this.ConsumeItemCache = this.ConsumeItemIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060040BA RID: 16570 RVA: 0x001C6048 File Offset: 0x001C4248
		private void EnsureMonsterTypeScoreCacheIfNeeded()
		{
			if (this.MonsterTypeScoreCache != null)
			{
				return;
			}
			this.MonsterTypeScoreCache = this.MonsterTypeScoreIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060040BB RID: 16571 RVA: 0x001C60B0 File Offset: 0x001C42B0
		private void EnsureRewardTimeCacheIfNeeded()
		{
			if (this.RewardTimeCache != null)
			{
				return;
			}
			this.RewardTimeCache = this.RewardTimeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060040BC RID: 16572 RVA: 0x001C6116 File Offset: 0x001C4316
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetBtPropNameFrozenDict(int key)
		{
			this.EnsureBtPropNameCacheIfNeeded();
			return this.BtPropNameCache;
		}

		// Token: 0x060040BD RID: 16573 RVA: 0x001C6124 File Offset: 0x001C4324
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetConsumeItemFrozenDict(int key)
		{
			this.EnsureConsumeItemCacheIfNeeded();
			return this.ConsumeItemCache;
		}

		// Token: 0x060040BE RID: 16574 RVA: 0x001C6132 File Offset: 0x001C4332
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetMonsterTypeScoreFrozenDict(int key)
		{
			this.EnsureMonsterTypeScoreCacheIfNeeded();
			return this.MonsterTypeScoreCache;
		}

		// Token: 0x060040BF RID: 16575 RVA: 0x001C6140 File Offset: 0x001C4340
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRewardTimeFrozenDict(int key)
		{
			this.EnsureRewardTimeCacheIfNeeded();
			return this.RewardTimeCache;
		}

		// Token: 0x04004A7D RID: 19069
		private Table __p;

		// Token: 0x04004A7E RID: 19070
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> BtPropNameCache;

		// Token: 0x04004A7F RID: 19071
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeItemCache;

		// Token: 0x04004A80 RID: 19072
		[Nullable(2)]
		private FrozenDictionary<int, int> MonsterTypeScoreCache;

		// Token: 0x04004A81 RID: 19073
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardTimeCache;
	}
}
