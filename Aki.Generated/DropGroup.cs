using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CF3 RID: 3315
	public struct DropGroup : IFlatbufferObject
	{
		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x06006BD1 RID: 27601 RVA: 0x0023B670 File Offset: 0x00239870
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006BD2 RID: 27602 RVA: 0x0023B67D File Offset: 0x0023987D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006BD3 RID: 27603 RVA: 0x0023B684 File Offset: 0x00239884
		public static DropGroup GetRootAsDropGroup(ByteBuffer _bb)
		{
			return DropGroup.GetRootAsDropGroup(_bb, default(DropGroup));
		}

		// Token: 0x06006BD4 RID: 27604 RVA: 0x0023B6A0 File Offset: 0x002398A0
		public static DropGroup GetRootAsDropGroup(ByteBuffer _bb, DropGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006BD5 RID: 27605 RVA: 0x0023B6BD File Offset: 0x002398BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006BD6 RID: 27606 RVA: 0x0023B6CC File Offset: 0x002398CC
		public DropGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06006BD7 RID: 27607 RVA: 0x0023B6DC File Offset: 0x002398DC
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

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06006BD8 RID: 27608 RVA: 0x0023B718 File Offset: 0x00239918
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

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06006BD9 RID: 27609 RVA: 0x0023B754 File Offset: 0x00239954
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

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06006BDA RID: 27610 RVA: 0x0023B790 File Offset: 0x00239990
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

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06006BDB RID: 27611 RVA: 0x0023B7D0 File Offset: 0x002399D0
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

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06006BDC RID: 27612 RVA: 0x0023B810 File Offset: 0x00239A10
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

		// Token: 0x04005230 RID: 21040
		private Table __p;
	}
}
