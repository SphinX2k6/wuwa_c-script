using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200117A RID: 4474
	public struct RoverRogueLoot : IFlatbufferObject
	{
		// Token: 0x17003582 RID: 13698
		// (get) Token: 0x0600D620 RID: 54816 RVA: 0x003268C2 File Offset: 0x00324AC2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D621 RID: 54817 RVA: 0x003268CF File Offset: 0x00324ACF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D622 RID: 54818 RVA: 0x003268D8 File Offset: 0x00324AD8
		public static RoverRogueLoot GetRootAsRoverRogueLoot(ByteBuffer _bb)
		{
			return RoverRogueLoot.GetRootAsRoverRogueLoot(_bb, default(RoverRogueLoot));
		}

		// Token: 0x0600D623 RID: 54819 RVA: 0x003268F4 File Offset: 0x00324AF4
		public static RoverRogueLoot GetRootAsRoverRogueLoot(ByteBuffer _bb, RoverRogueLoot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D624 RID: 54820 RVA: 0x00326911 File Offset: 0x00324B11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D625 RID: 54821 RVA: 0x00326920 File Offset: 0x00324B20
		public RoverRogueLoot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003583 RID: 13699
		// (get) Token: 0x0600D626 RID: 54822 RVA: 0x00326930 File Offset: 0x00324B30
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

		// Token: 0x17003584 RID: 13700
		// (get) Token: 0x0600D627 RID: 54823 RVA: 0x0032696C File Offset: 0x00324B6C
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

		// Token: 0x17003585 RID: 13701
		// (get) Token: 0x0600D628 RID: 54824 RVA: 0x003269A8 File Offset: 0x00324BA8
		public int MaxLevel
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003586 RID: 13702
		// (get) Token: 0x0600D629 RID: 54825 RVA: 0x003269E4 File Offset: 0x00324BE4
		public int EffectTrigger
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

		// Token: 0x17003587 RID: 13703
		// (get) Token: 0x0600D62A RID: 54826 RVA: 0x00326A24 File Offset: 0x00324C24
		public int OutGameUnlockConditionId
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

		// Token: 0x0600D62B RID: 54827 RVA: 0x00326A64 File Offset: 0x00324C64
		public int RoomPassedRequired(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003588 RID: 13704
		// (get) Token: 0x0600D62C RID: 54828 RVA: 0x00326AA4 File Offset: 0x00324CA4
		public int RoomPassedRequiredLength
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

		// Token: 0x0600D62D RID: 54829 RVA: 0x00326AD0 File Offset: 0x00324CD0
		public Span<int> GetRoomPassedRequiredBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600D62E RID: 54830 RVA: 0x00326AE0 File Offset: 0x00324CE0
		public int[] GetRoomPassedRequiredArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17003589 RID: 13705
		// (get) Token: 0x0600D62F RID: 54831 RVA: 0x00326AF8 File Offset: 0x00324CF8
		public string Name
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

		// Token: 0x0600D630 RID: 54832 RVA: 0x00326B30 File Offset: 0x00324D30
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D631 RID: 54833 RVA: 0x00326B40 File Offset: 0x00324D40
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700358A RID: 13706
		// (get) Token: 0x0600D632 RID: 54834 RVA: 0x00326B58 File Offset: 0x00324D58
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D633 RID: 54835 RVA: 0x00326B90 File Offset: 0x00324D90
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D634 RID: 54836 RVA: 0x00326BA0 File Offset: 0x00324DA0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D635 RID: 54837 RVA: 0x00326BB8 File Offset: 0x00324DB8
		public string DescParams(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700358B RID: 13707
		// (get) Token: 0x0600D636 RID: 54838 RVA: 0x00326BF4 File Offset: 0x00324DF4
		public int DescParamsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D637 RID: 54839 RVA: 0x00326C20 File Offset: 0x00324E20
		public string LevelDesc(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700358C RID: 13708
		// (get) Token: 0x0600D638 RID: 54840 RVA: 0x00326C5C File Offset: 0x00324E5C
		public int LevelDescLength
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

		// Token: 0x0600D639 RID: 54841 RVA: 0x00326C88 File Offset: 0x00324E88
		public IntArray? LevelDescParams(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700358D RID: 13709
		// (get) Token: 0x0600D63A RID: 54842 RVA: 0x00326CEC File Offset: 0x00324EEC
		public int LevelDescParamsLength
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

		// Token: 0x1700358E RID: 13710
		// (get) Token: 0x0600D63B RID: 54843 RVA: 0x00326D18 File Offset: 0x00324F18
		public string Icon
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

		// Token: 0x0600D63C RID: 54844 RVA: 0x00326D50 File Offset: 0x00324F50
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600D63D RID: 54845 RVA: 0x00326D60 File Offset: 0x00324F60
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700358F RID: 13711
		// (get) Token: 0x0600D63E RID: 54846 RVA: 0x00326D78 File Offset: 0x00324F78
		public int RarityId
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003590 RID: 13712
		// (get) Token: 0x0600D63F RID: 54847 RVA: 0x00326DB8 File Offset: 0x00324FB8
		public int ApplyRoleType
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

		// Token: 0x17003591 RID: 13713
		// (get) Token: 0x0600D640 RID: 54848 RVA: 0x00326DF8 File Offset: 0x00324FF8
		public string ApplyRoleTypeLockDesc
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

		// Token: 0x0600D641 RID: 54849 RVA: 0x00326E30 File Offset: 0x00325030
		public Span<byte> GetApplyRoleTypeLockDescBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600D642 RID: 54850 RVA: 0x00326E40 File Offset: 0x00325040
		public byte[] GetApplyRoleTypeLockDescArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D643 RID: 54851 RVA: 0x00326E58 File Offset: 0x00325058
		[NullableContext(1)]
		public string[] DescParams()
		{
			return this.DescParamsIter().ToArray<string>();
		}

		// Token: 0x0600D644 RID: 54852 RVA: 0x00326E65 File Offset: 0x00325065
		[NullableContext(1)]
		public IEnumerable<string> DescParamsIter()
		{
			RoverRogueLoot.<DescParamsIter>d__53 <DescParamsIter>d__ = new RoverRogueLoot.<DescParamsIter>d__53(-2);
			<DescParamsIter>d__.<>3__<>4__this = this;
			return <DescParamsIter>d__;
		}

		// Token: 0x0600D645 RID: 54853 RVA: 0x00326E7A File Offset: 0x0032507A
		[NullableContext(1)]
		public string[] LevelDesc()
		{
			return this.LevelDescIter().ToArray<string>();
		}

		// Token: 0x0600D646 RID: 54854 RVA: 0x00326E87 File Offset: 0x00325087
		[NullableContext(1)]
		public IEnumerable<string> LevelDescIter()
		{
			RoverRogueLoot.<LevelDescIter>d__55 <LevelDescIter>d__ = new RoverRogueLoot.<LevelDescIter>d__55(-2);
			<LevelDescIter>d__.<>3__<>4__this = this;
			return <LevelDescIter>d__;
		}

		// Token: 0x0600D647 RID: 54855 RVA: 0x00326E9C File Offset: 0x0032509C
		[NullableContext(1)]
		public IntArray[] LevelDescParams()
		{
			return this.LevelDescParamsIter().ToArray<IntArray>();
		}

		// Token: 0x0600D648 RID: 54856 RVA: 0x00326EA9 File Offset: 0x003250A9
		[NullableContext(1)]
		public IEnumerable<IntArray> LevelDescParamsIter()
		{
			RoverRogueLoot.<LevelDescParamsIter>d__57 <LevelDescParamsIter>d__ = new RoverRogueLoot.<LevelDescParamsIter>d__57(-2);
			<LevelDescParamsIter>d__.<>3__<>4__this = this;
			return <LevelDescParamsIter>d__;
		}

		// Token: 0x0600D649 RID: 54857 RVA: 0x00326EBE File Offset: 0x003250BE
		[NullableContext(1)]
		public int[] RoomPassedRequired()
		{
			return this.GetRoomPassedRequiredArray();
		}

		// Token: 0x0600D64A RID: 54858 RVA: 0x00326EC6 File Offset: 0x003250C6
		[NullableContext(1)]
		public IEnumerable<int> RoomPassedRequiredIter()
		{
			RoverRogueLoot.<RoomPassedRequiredIter>d__59 <RoomPassedRequiredIter>d__ = new RoverRogueLoot.<RoomPassedRequiredIter>d__59(-2);
			<RoomPassedRequiredIter>d__.<>3__<>4__this = this;
			return <RoomPassedRequiredIter>d__;
		}

		// Token: 0x04005788 RID: 22408
		private Table __p;
	}
}
