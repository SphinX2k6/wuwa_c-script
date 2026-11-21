using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B82 RID: 2946
	public struct AbyssInst : IFlatbufferObject
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06004557 RID: 17751 RVA: 0x001E4221 File Offset: 0x001E2421
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004558 RID: 17752 RVA: 0x001E422E File Offset: 0x001E242E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x001E4238 File Offset: 0x001E2438
		public static AbyssInst GetRootAsAbyssInst(ByteBuffer _bb)
		{
			return AbyssInst.GetRootAsAbyssInst(_bb, default(AbyssInst));
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x001E4254 File Offset: 0x001E2454
		public static AbyssInst GetRootAsAbyssInst(ByteBuffer _bb, AbyssInst obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600455B RID: 17755 RVA: 0x001E4271 File Offset: 0x001E2471
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600455C RID: 17756 RVA: 0x001E4280 File Offset: 0x001E2480
		public AbyssInst __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600455D RID: 17757 RVA: 0x001E4290 File Offset: 0x001E2490
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
		// (get) Token: 0x0600455E RID: 17758 RVA: 0x001E42CC File Offset: 0x001E24CC
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
		// (get) Token: 0x0600455F RID: 17759 RVA: 0x001E4308 File Offset: 0x001E2508
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
		// (get) Token: 0x06004560 RID: 17760 RVA: 0x001E4344 File Offset: 0x001E2544
		public bool PlanarDungeon
		{
			get
			{
				int num = this.__p.__offset(10);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06004561 RID: 17761 RVA: 0x001E4384 File Offset: 0x001E2584
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
		// (get) Token: 0x06004562 RID: 17762 RVA: 0x001E43C4 File Offset: 0x001E25C4
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
		// (get) Token: 0x06004563 RID: 17763 RVA: 0x001E4404 File Offset: 0x001E2604
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
		// (get) Token: 0x06004564 RID: 17764 RVA: 0x001E4444 File Offset: 0x001E2644
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
		// (get) Token: 0x06004565 RID: 17765 RVA: 0x001E4484 File Offset: 0x001E2684
		public bool IsEndless
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06004566 RID: 17766 RVA: 0x001E44C4 File Offset: 0x001E26C4
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

		// Token: 0x06004567 RID: 17767 RVA: 0x001E4504 File Offset: 0x001E2704
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
		// (get) Token: 0x06004568 RID: 17768 RVA: 0x001E4568 File Offset: 0x001E2768
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

		// Token: 0x06004569 RID: 17769 RVA: 0x001E4594 File Offset: 0x001E2794
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(26);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600456A RID: 17770 RVA: 0x001E45E0 File Offset: 0x001E27E0
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

		// Token: 0x0600456B RID: 17771 RVA: 0x001E460C File Offset: 0x001E280C
		public Span<long> GetBuffIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(26, 8));
		}

		// Token: 0x0600456C RID: 17772 RVA: 0x001E4621 File Offset: 0x001E2821
		public long[] GetBuffIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(26) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600456D RID: 17773 RVA: 0x001E4660 File Offset: 0x001E2860
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
		// (get) Token: 0x0600456E RID: 17774 RVA: 0x001E46A0 File Offset: 0x001E28A0
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

		// Token: 0x0600456F RID: 17775 RVA: 0x001E46CC File Offset: 0x001E28CC
		public Span<int> GetReviveTimesBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x06004570 RID: 17776 RVA: 0x001E46DC File Offset: 0x001E28DC
		public int[] GetReviveTimesArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06004571 RID: 17777 RVA: 0x001E46F4 File Offset: 0x001E28F4
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
		// (get) Token: 0x06004572 RID: 17778 RVA: 0x001E4734 File Offset: 0x001E2934
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

		// Token: 0x06004573 RID: 17779 RVA: 0x001E4774 File Offset: 0x001E2974
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
		// (get) Token: 0x06004574 RID: 17780 RVA: 0x001E47B4 File Offset: 0x001E29B4
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

		// Token: 0x06004575 RID: 17781 RVA: 0x001E47E0 File Offset: 0x001E29E0
		public Span<int> GetUnlockLittleRoleBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x06004576 RID: 17782 RVA: 0x001E47F0 File Offset: 0x001E29F0
		public int[] GetUnlockLittleRoleArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06004577 RID: 17783 RVA: 0x001E4808 File Offset: 0x001E2A08
		public bool RankOpen
		{
			get
			{
				int num = this.__p.__offset(36);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06004578 RID: 17784 RVA: 0x001E4848 File Offset: 0x001E2A48
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

		// Token: 0x06004579 RID: 17785 RVA: 0x001E4888 File Offset: 0x001E2A88
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
		// (get) Token: 0x0600457A RID: 17786 RVA: 0x001E48EC File Offset: 0x001E2AEC
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
		// (get) Token: 0x0600457B RID: 17787 RVA: 0x001E4918 File Offset: 0x001E2B18
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

		// Token: 0x0600457C RID: 17788 RVA: 0x001E4958 File Offset: 0x001E2B58
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
		// (get) Token: 0x0600457D RID: 17789 RVA: 0x001E49BC File Offset: 0x001E2BBC
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

		// Token: 0x0600457E RID: 17790 RVA: 0x001E49E8 File Offset: 0x001E2BE8
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
		// (get) Token: 0x0600457F RID: 17791 RVA: 0x001E4A4C File Offset: 0x001E2C4C
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
		// (get) Token: 0x06004580 RID: 17792 RVA: 0x001E4A78 File Offset: 0x001E2C78
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
		// (get) Token: 0x06004581 RID: 17793 RVA: 0x001E4AB8 File Offset: 0x001E2CB8
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

		// Token: 0x06004582 RID: 17794 RVA: 0x001E4AF0 File Offset: 0x001E2CF0
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x06004583 RID: 17795 RVA: 0x001E4B00 File Offset: 0x001E2D00
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06004584 RID: 17796 RVA: 0x001E4B18 File Offset: 0x001E2D18
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

		// Token: 0x06004585 RID: 17797 RVA: 0x001E4B50 File Offset: 0x001E2D50
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x06004586 RID: 17798 RVA: 0x001E4B60 File Offset: 0x001E2D60
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06004587 RID: 17799 RVA: 0x001E4B78 File Offset: 0x001E2D78
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

		// Token: 0x06004588 RID: 17800 RVA: 0x001E4BB0 File Offset: 0x001E2DB0
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x06004589 RID: 17801 RVA: 0x001E4BC0 File Offset: 0x001E2DC0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600458A RID: 17802 RVA: 0x001E4BD8 File Offset: 0x001E2DD8
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

		// Token: 0x0600458B RID: 17803 RVA: 0x001E4C10 File Offset: 0x001E2E10
		public Span<byte> GetGoatBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x0600458C RID: 17804 RVA: 0x001E4C20 File Offset: 0x001E2E20
		public byte[] GetGoatArray()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600458D RID: 17805 RVA: 0x001E4C38 File Offset: 0x001E2E38
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

		// Token: 0x0600458E RID: 17806 RVA: 0x001E4C70 File Offset: 0x001E2E70
		public Span<byte> GetUnLockDescBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x0600458F RID: 17807 RVA: 0x001E4C80 File Offset: 0x001E2E80
		public byte[] GetUnLockDescArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06004590 RID: 17808 RVA: 0x001E4C98 File Offset: 0x001E2E98
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

		// Token: 0x06004591 RID: 17809 RVA: 0x001E4CD0 File Offset: 0x001E2ED0
		public Span<byte> GetAbyssColorBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x06004592 RID: 17810 RVA: 0x001E4CE0 File Offset: 0x001E2EE0
		public byte[] GetAbyssColorArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06004593 RID: 17811 RVA: 0x001E4CF8 File Offset: 0x001E2EF8
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

		// Token: 0x06004594 RID: 17812 RVA: 0x001E4D30 File Offset: 0x001E2F30
		public Span<byte> GetSmallWorldShowSceneItemBytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x06004595 RID: 17813 RVA: 0x001E4D40 File Offset: 0x001E2F40
		public byte[] GetSmallWorldShowSceneItemArray()
		{
			return this.__p.__vector_as_array<byte>(62) ?? Array.Empty<byte>();
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06004596 RID: 17814 RVA: 0x001E4D58 File Offset: 0x001E2F58
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

		// Token: 0x06004597 RID: 17815 RVA: 0x001E4D90 File Offset: 0x001E2F90
		public Span<byte> GetAbyssShowCakeBytes()
		{
			return this.__p.__vector_as_span<byte>(64, 1);
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x001E4DA0 File Offset: 0x001E2FA0
		public byte[] GetAbyssShowCakeArray()
		{
			return this.__p.__vector_as_array<byte>(64) ?? Array.Empty<byte>();
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x001E4DB8 File Offset: 0x001E2FB8
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
		// (get) Token: 0x0600459A RID: 17818 RVA: 0x001E4DF8 File Offset: 0x001E2FF8
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

		// Token: 0x0600459B RID: 17819 RVA: 0x001E4E24 File Offset: 0x001E3024
		public Span<int> GetRecommendLittleRoleBytes()
		{
			return this.__p.__vector_as_span<int>(66, 4);
		}

		// Token: 0x0600459C RID: 17820 RVA: 0x001E4E34 File Offset: 0x001E3034
		public int[] GetRecommendLittleRoleArray()
		{
			return this.__p.__vector_as_array<int>(66) ?? Array.Empty<int>();
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600459D RID: 17821 RVA: 0x001E4E4C File Offset: 0x001E304C
		public bool AbyssDevelopEntr
		{
			get
			{
				int num = this.__p.__offset(68);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600459E RID: 17822 RVA: 0x001E4E8C File Offset: 0x001E308C
		public bool AbyssStoreEntr
		{
			get
			{
				int num = this.__p.__offset(70);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600459F RID: 17823 RVA: 0x001E4ECC File Offset: 0x001E30CC
		public bool AbyssSynthesisEntr
		{
			get
			{
				int num = this.__p.__offset(72);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060045A0 RID: 17824 RVA: 0x001E4F0C File Offset: 0x001E310C
		public bool AbyssRank
		{
			get
			{
				int num = this.__p.__offset(74);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060045A1 RID: 17825 RVA: 0x001E4F4C File Offset: 0x001E314C
		public bool IfStoryChallenge
		{
			get
			{
				int num = this.__p.__offset(76);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060045A2 RID: 17826 RVA: 0x001E4F8C File Offset: 0x001E318C
		[NullableContext(1)]
		public Dictionary<int, string> BtPropName()
		{
			return this.BtPropNameIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x060045A3 RID: 17827 RVA: 0x001E4FE2 File Offset: 0x001E31E2
		[NullableContext(1)]
		public IEnumerable<DicIntString> BtPropNameIter()
		{
			AbyssInst.<BtPropNameIter>d__115 <BtPropNameIter>d__ = new AbyssInst.<BtPropNameIter>d__115(-2);
			<BtPropNameIter>d__.<>3__<>4__this = this;
			return <BtPropNameIter>d__;
		}

		// Token: 0x060045A4 RID: 17828 RVA: 0x001E4FF7 File Offset: 0x001E31F7
		[NullableContext(1)]
		public long[] BuffIds()
		{
			return this.GetBuffIdsArray();
		}

		// Token: 0x060045A5 RID: 17829 RVA: 0x001E4FFF File Offset: 0x001E31FF
		[NullableContext(1)]
		public IEnumerable<long> BuffIdsIter()
		{
			AbyssInst.<BuffIdsIter>d__117 <BuffIdsIter>d__ = new AbyssInst.<BuffIdsIter>d__117(-2);
			<BuffIdsIter>d__.<>3__<>4__this = this;
			return <BuffIdsIter>d__;
		}

		// Token: 0x060045A6 RID: 17830 RVA: 0x001E5014 File Offset: 0x001E3214
		[NullableContext(1)]
		public Dictionary<int, int> ConsumeItem()
		{
			return this.ConsumeItemIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060045A7 RID: 17831 RVA: 0x001E506A File Offset: 0x001E326A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ConsumeItemIter()
		{
			AbyssInst.<ConsumeItemIter>d__119 <ConsumeItemIter>d__ = new AbyssInst.<ConsumeItemIter>d__119(-2);
			<ConsumeItemIter>d__.<>3__<>4__this = this;
			return <ConsumeItemIter>d__;
		}

		// Token: 0x060045A8 RID: 17832 RVA: 0x001E5080 File Offset: 0x001E3280
		[NullableContext(1)]
		public Dictionary<int, int> MonsterTypeScore()
		{
			return this.MonsterTypeScoreIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060045A9 RID: 17833 RVA: 0x001E50D6 File Offset: 0x001E32D6
		[NullableContext(1)]
		public IEnumerable<DicIntInt> MonsterTypeScoreIter()
		{
			AbyssInst.<MonsterTypeScoreIter>d__121 <MonsterTypeScoreIter>d__ = new AbyssInst.<MonsterTypeScoreIter>d__121(-2);
			<MonsterTypeScoreIter>d__.<>3__<>4__this = this;
			return <MonsterTypeScoreIter>d__;
		}

		// Token: 0x060045AA RID: 17834 RVA: 0x001E50EB File Offset: 0x001E32EB
		[NullableContext(1)]
		public int[] RecommendLittleRole()
		{
			return this.GetRecommendLittleRoleArray();
		}

		// Token: 0x060045AB RID: 17835 RVA: 0x001E50F3 File Offset: 0x001E32F3
		[NullableContext(1)]
		public IEnumerable<int> RecommendLittleRoleIter()
		{
			AbyssInst.<RecommendLittleRoleIter>d__123 <RecommendLittleRoleIter>d__ = new AbyssInst.<RecommendLittleRoleIter>d__123(-2);
			<RecommendLittleRoleIter>d__.<>3__<>4__this = this;
			return <RecommendLittleRoleIter>d__;
		}

		// Token: 0x060045AC RID: 17836 RVA: 0x001E5108 File Offset: 0x001E3308
		[NullableContext(1)]
		public int[] ReviveTimes()
		{
			return this.GetReviveTimesArray();
		}

		// Token: 0x060045AD RID: 17837 RVA: 0x001E5110 File Offset: 0x001E3310
		[NullableContext(1)]
		public IEnumerable<int> ReviveTimesIter()
		{
			AbyssInst.<ReviveTimesIter>d__125 <ReviveTimesIter>d__ = new AbyssInst.<ReviveTimesIter>d__125(-2);
			<ReviveTimesIter>d__.<>3__<>4__this = this;
			return <ReviveTimesIter>d__;
		}

		// Token: 0x060045AE RID: 17838 RVA: 0x001E5128 File Offset: 0x001E3328
		[NullableContext(1)]
		public Dictionary<int, int> RewardTime()
		{
			return this.RewardTimeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060045AF RID: 17839 RVA: 0x001E517E File Offset: 0x001E337E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RewardTimeIter()
		{
			AbyssInst.<RewardTimeIter>d__127 <RewardTimeIter>d__ = new AbyssInst.<RewardTimeIter>d__127(-2);
			<RewardTimeIter>d__.<>3__<>4__this = this;
			return <RewardTimeIter>d__;
		}

		// Token: 0x060045B0 RID: 17840 RVA: 0x001E5193 File Offset: 0x001E3393
		[NullableContext(1)]
		public int[] UnlockLittleRole()
		{
			return this.GetUnlockLittleRoleArray();
		}

		// Token: 0x060045B1 RID: 17841 RVA: 0x001E519B File Offset: 0x001E339B
		[NullableContext(1)]
		public IEnumerable<int> UnlockLittleRoleIter()
		{
			AbyssInst.<UnlockLittleRoleIter>d__129 <UnlockLittleRoleIter>d__ = new AbyssInst.<UnlockLittleRoleIter>d__129(-2);
			<UnlockLittleRoleIter>d__.<>3__<>4__this = this;
			return <UnlockLittleRoleIter>d__;
		}

		// Token: 0x060045B2 RID: 17842 RVA: 0x001E51B0 File Offset: 0x001E33B0
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

		// Token: 0x060045B3 RID: 17843 RVA: 0x001E51D8 File Offset: 0x001E33D8
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

		// Token: 0x060045B4 RID: 17844 RVA: 0x001E520C File Offset: 0x001E340C
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

		// Token: 0x060045B5 RID: 17845 RVA: 0x001E5240 File Offset: 0x001E3440
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

		// Token: 0x060045B6 RID: 17846 RVA: 0x001E5274 File Offset: 0x001E3474
		private void EnsureBtPropNameCacheIfNeeded()
		{
			if (this.BtPropNameCache != null)
			{
				return;
			}
			this.BtPropNameCache = this.BtPropNameIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x060045B7 RID: 17847 RVA: 0x001E52DC File Offset: 0x001E34DC
		private void EnsureConsumeItemCacheIfNeeded()
		{
			if (this.ConsumeItemCache != null)
			{
				return;
			}
			this.ConsumeItemCache = this.ConsumeItemIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x001E5344 File Offset: 0x001E3544
		private void EnsureMonsterTypeScoreCacheIfNeeded()
		{
			if (this.MonsterTypeScoreCache != null)
			{
				return;
			}
			this.MonsterTypeScoreCache = this.MonsterTypeScoreIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x001E53AC File Offset: 0x001E35AC
		private void EnsureRewardTimeCacheIfNeeded()
		{
			if (this.RewardTimeCache != null)
			{
				return;
			}
			this.RewardTimeCache = this.RewardTimeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060045BA RID: 17850 RVA: 0x001E5412 File Offset: 0x001E3612
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetBtPropNameFrozenDict()
		{
			this.EnsureBtPropNameCacheIfNeeded();
			return this.BtPropNameCache;
		}

		// Token: 0x060045BB RID: 17851 RVA: 0x001E5420 File Offset: 0x001E3620
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetConsumeItemFrozenDict()
		{
			this.EnsureConsumeItemCacheIfNeeded();
			return this.ConsumeItemCache;
		}

		// Token: 0x060045BC RID: 17852 RVA: 0x001E542E File Offset: 0x001E362E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetMonsterTypeScoreFrozenDict()
		{
			this.EnsureMonsterTypeScoreCacheIfNeeded();
			return this.MonsterTypeScoreCache;
		}

		// Token: 0x060045BD RID: 17853 RVA: 0x001E543C File Offset: 0x001E363C
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRewardTimeFrozenDict()
		{
			this.EnsureRewardTimeCacheIfNeeded();
			return this.RewardTimeCache;
		}

		// Token: 0x04005050 RID: 20560
		private Table __p;

		// Token: 0x04005051 RID: 20561
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> BtPropNameCache;

		// Token: 0x04005052 RID: 20562
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeItemCache;

		// Token: 0x04005053 RID: 20563
		[Nullable(2)]
		private FrozenDictionary<int, int> MonsterTypeScoreCache;

		// Token: 0x04005054 RID: 20564
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardTimeCache;
	}
}
