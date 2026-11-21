using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C92 RID: 3218
	public struct DailyAdventureActivity : IFlatbufferObject
	{
		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x060060A9 RID: 24745 RVA: 0x00222997 File Offset: 0x00220B97
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060060AA RID: 24746 RVA: 0x002229A4 File Offset: 0x00220BA4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060060AB RID: 24747 RVA: 0x002229AC File Offset: 0x00220BAC
		public static DailyAdventureActivity GetRootAsDailyAdventureActivity(ByteBuffer _bb)
		{
			return DailyAdventureActivity.GetRootAsDailyAdventureActivity(_bb, default(DailyAdventureActivity));
		}

		// Token: 0x060060AC RID: 24748 RVA: 0x002229C8 File Offset: 0x00220BC8
		public static DailyAdventureActivity GetRootAsDailyAdventureActivity(ByteBuffer _bb, DailyAdventureActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060060AD RID: 24749 RVA: 0x002229E5 File Offset: 0x00220BE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060060AE RID: 24750 RVA: 0x002229F4 File Offset: 0x00220BF4
		public DailyAdventureActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x060060AF RID: 24751 RVA: 0x00222A04 File Offset: 0x00220C04
		public int ActivityId
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

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x060060B0 RID: 24752 RVA: 0x00222A40 File Offset: 0x00220C40
		public string AreaTitle
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060060B1 RID: 24753 RVA: 0x00222A77 File Offset: 0x00220C77
		public Span<byte> GetAreaTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060060B2 RID: 24754 RVA: 0x00222A86 File Offset: 0x00220C86
		public byte[] GetAreaTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x060060B3 RID: 24755 RVA: 0x00222AA0 File Offset: 0x00220CA0
		public string AreaDescription
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

		// Token: 0x060060B4 RID: 24756 RVA: 0x00222AD7 File Offset: 0x00220CD7
		public Span<byte> GetAreaDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060060B5 RID: 24757 RVA: 0x00222AE6 File Offset: 0x00220CE6
		public byte[] GetAreaDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x060060B6 RID: 24758 RVA: 0x00222B00 File Offset: 0x00220D00
		public string AreaPic
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

		// Token: 0x060060B7 RID: 24759 RVA: 0x00222B38 File Offset: 0x00220D38
		public Span<byte> GetAreaPicBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060060B8 RID: 24760 RVA: 0x00222B48 File Offset: 0x00220D48
		public byte[] GetAreaPicArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x060060B9 RID: 24761 RVA: 0x00222B60 File Offset: 0x00220D60
		public int AreaDefaultMarkId
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

		// Token: 0x060060BA RID: 24762 RVA: 0x00222BA0 File Offset: 0x00220DA0
		public int TaskList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x060060BB RID: 24763 RVA: 0x00222BE0 File Offset: 0x00220DE0
		public int TaskListLength
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

		// Token: 0x060060BC RID: 24764 RVA: 0x00222C0C File Offset: 0x00220E0C
		public Span<int> GetTaskListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x060060BD RID: 24765 RVA: 0x00222C1C File Offset: 0x00220E1C
		public int[] GetTaskListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x060060BE RID: 24766 RVA: 0x00222C34 File Offset: 0x00220E34
		public int RewardList(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x060060BF RID: 24767 RVA: 0x00222C74 File Offset: 0x00220E74
		public int RewardListLength
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

		// Token: 0x060060C0 RID: 24768 RVA: 0x00222CA0 File Offset: 0x00220EA0
		public Span<int> GetRewardListBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x060060C1 RID: 24769 RVA: 0x00222CB0 File Offset: 0x00220EB0
		public int[] GetRewardListArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x060060C2 RID: 24770 RVA: 0x00222CC8 File Offset: 0x00220EC8
		public int TaskRefreshNum
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060060C3 RID: 24771 RVA: 0x00222D05 File Offset: 0x00220F05
		[NullableContext(1)]
		public int[] RewardList()
		{
			return this.GetRewardListArray();
		}

		// Token: 0x060060C4 RID: 24772 RVA: 0x00222D0D File Offset: 0x00220F0D
		[NullableContext(1)]
		public IEnumerable<int> RewardListIter()
		{
			DailyAdventureActivity.<RewardListIter>d__37 <RewardListIter>d__ = new DailyAdventureActivity.<RewardListIter>d__37(-2);
			<RewardListIter>d__.<>3__<>4__this = this;
			return <RewardListIter>d__;
		}

		// Token: 0x060060C5 RID: 24773 RVA: 0x00222D22 File Offset: 0x00220F22
		[NullableContext(1)]
		public int[] TaskList()
		{
			return this.GetTaskListArray();
		}

		// Token: 0x060060C6 RID: 24774 RVA: 0x00222D2A File Offset: 0x00220F2A
		[NullableContext(1)]
		public IEnumerable<int> TaskListIter()
		{
			DailyAdventureActivity.<TaskListIter>d__39 <TaskListIter>d__ = new DailyAdventureActivity.<TaskListIter>d__39(-2);
			<TaskListIter>d__.<>3__<>4__this = this;
			return <TaskListIter>d__;
		}

		// Token: 0x040051B5 RID: 20917
		private Table __p;
	}
}
