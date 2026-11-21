using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BFD RID: 3069
	public struct BabelTowerDailyTask : IFlatbufferObject
	{
		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x0600505D RID: 20573 RVA: 0x001FCDF0 File Offset: 0x001FAFF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600505E RID: 20574 RVA: 0x001FCDFD File Offset: 0x001FAFFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600505F RID: 20575 RVA: 0x001FCE04 File Offset: 0x001FB004
		public static BabelTowerDailyTask GetRootAsBabelTowerDailyTask(ByteBuffer _bb)
		{
			return BabelTowerDailyTask.GetRootAsBabelTowerDailyTask(_bb, default(BabelTowerDailyTask));
		}

		// Token: 0x06005060 RID: 20576 RVA: 0x001FCE20 File Offset: 0x001FB020
		public static BabelTowerDailyTask GetRootAsBabelTowerDailyTask(ByteBuffer _bb, BabelTowerDailyTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005061 RID: 20577 RVA: 0x001FCE3D File Offset: 0x001FB03D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005062 RID: 20578 RVA: 0x001FCE4C File Offset: 0x001FB04C
		public BabelTowerDailyTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06005063 RID: 20579 RVA: 0x001FCE5C File Offset: 0x001FB05C
		public int TaskId
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

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06005064 RID: 20580 RVA: 0x001FCE98 File Offset: 0x001FB098
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

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06005065 RID: 20581 RVA: 0x001FCED4 File Offset: 0x001FB0D4
		public int GroupId
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

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06005066 RID: 20582 RVA: 0x001FCF10 File Offset: 0x001FB110
		public int Weight
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

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06005067 RID: 20583 RVA: 0x001FCF50 File Offset: 0x001FB150
		public int DropId
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

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06005068 RID: 20584 RVA: 0x001FCF90 File Offset: 0x001FB190
		public string Title
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

		// Token: 0x06005069 RID: 20585 RVA: 0x001FCFC8 File Offset: 0x001FB1C8
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600506A RID: 20586 RVA: 0x001FCFD8 File Offset: 0x001FB1D8
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600506B RID: 20587 RVA: 0x001FCFF0 File Offset: 0x001FB1F0
		public int ShowDeTerm(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x0600506C RID: 20588 RVA: 0x001FD030 File Offset: 0x001FB230
		public int ShowDeTermLength
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

		// Token: 0x0600506D RID: 20589 RVA: 0x001FD05C File Offset: 0x001FB25C
		public Span<int> GetShowDeTermBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600506E RID: 20590 RVA: 0x001FD06C File Offset: 0x001FB26C
		public int[] GetShowDeTermArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600506F RID: 20591 RVA: 0x001FD084 File Offset: 0x001FB284
		public int ShowBuff(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06005070 RID: 20592 RVA: 0x001FD0C4 File Offset: 0x001FB2C4
		public int ShowBuffLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005071 RID: 20593 RVA: 0x001FD0F0 File Offset: 0x001FB2F0
		public Span<int> GetShowBuffBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06005072 RID: 20594 RVA: 0x001FD100 File Offset: 0x001FB300
		public int[] GetShowBuffArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06005073 RID: 20595 RVA: 0x001FD118 File Offset: 0x001FB318
		public int JumpToLevelId
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

		// Token: 0x06005074 RID: 20596 RVA: 0x001FD155 File Offset: 0x001FB355
		[NullableContext(1)]
		public int[] ShowBuff()
		{
			return this.GetShowBuffArray();
		}

		// Token: 0x06005075 RID: 20597 RVA: 0x001FD15D File Offset: 0x001FB35D
		[NullableContext(1)]
		public IEnumerable<int> ShowBuffIter()
		{
			BabelTowerDailyTask.<ShowBuffIter>d__35 <ShowBuffIter>d__ = new BabelTowerDailyTask.<ShowBuffIter>d__35(-2);
			<ShowBuffIter>d__.<>3__<>4__this = this;
			return <ShowBuffIter>d__;
		}

		// Token: 0x06005076 RID: 20598 RVA: 0x001FD172 File Offset: 0x001FB372
		[NullableContext(1)]
		public int[] ShowDeTerm()
		{
			return this.GetShowDeTermArray();
		}

		// Token: 0x06005077 RID: 20599 RVA: 0x001FD17A File Offset: 0x001FB37A
		[NullableContext(1)]
		public IEnumerable<int> ShowDeTermIter()
		{
			BabelTowerDailyTask.<ShowDeTermIter>d__37 <ShowDeTermIter>d__ = new BabelTowerDailyTask.<ShowDeTermIter>d__37(-2);
			<ShowDeTermIter>d__.<>3__<>4__this = this;
			return <ShowDeTermIter>d__;
		}

		// Token: 0x040050ED RID: 20717
		private Table __p;
	}
}
