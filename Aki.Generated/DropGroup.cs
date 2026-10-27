using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C11 RID: 3089
	public struct DropGroup : IFlatbufferObject
	{
		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x060065F2 RID: 26098 RVA: 0x0021C39C File Offset: 0x0021A59C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060065F3 RID: 26099 RVA: 0x0021C3A9 File Offset: 0x0021A5A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060065F4 RID: 26100 RVA: 0x0021C3B0 File Offset: 0x0021A5B0
		public static DropGroup GetRootAsDropGroup(ByteBuffer _bb)
		{
			return DropGroup.GetRootAsDropGroup(_bb, default(DropGroup));
		}

		// Token: 0x060065F5 RID: 26101 RVA: 0x0021C3CC File Offset: 0x0021A5CC
		public static DropGroup GetRootAsDropGroup(ByteBuffer _bb, DropGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060065F6 RID: 26102 RVA: 0x0021C3E9 File Offset: 0x0021A5E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060065F7 RID: 26103 RVA: 0x0021C3F8 File Offset: 0x0021A5F8
		public DropGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x060065F8 RID: 26104 RVA: 0x0021C408 File Offset: 0x0021A608
		public int UnitId
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

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x060065F9 RID: 26105 RVA: 0x0021C444 File Offset: 0x0021A644
		public int GroupId
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

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x060065FA RID: 26106 RVA: 0x0021C480 File Offset: 0x0021A680
		public int MinNum
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

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x060065FB RID: 26107 RVA: 0x0021C4BC File Offset: 0x0021A6BC
		public int MaxNum
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

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x060065FC RID: 26108 RVA: 0x0021C4FC File Offset: 0x0021A6FC
		public int Interval
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

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x060065FD RID: 26109 RVA: 0x0021C53C File Offset: 0x0021A73C
		public int DropShowPlan
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004C4E RID: 19534
		private Table __p;
	}
}
