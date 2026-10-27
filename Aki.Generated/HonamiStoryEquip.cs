using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D35 RID: 3381
	public struct HonamiStoryEquip : IFlatbufferObject
	{
		// Token: 0x17001783 RID: 6019
		// (get) Token: 0x06007F74 RID: 32628 RVA: 0x002566DD File Offset: 0x002548DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007F75 RID: 32629 RVA: 0x002566EA File Offset: 0x002548EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007F76 RID: 32630 RVA: 0x002566F4 File Offset: 0x002548F4
		public static HonamiStoryEquip GetRootAsHonamiStoryEquip(ByteBuffer _bb)
		{
			return HonamiStoryEquip.GetRootAsHonamiStoryEquip(_bb, default(HonamiStoryEquip));
		}

		// Token: 0x06007F77 RID: 32631 RVA: 0x00256710 File Offset: 0x00254910
		public static HonamiStoryEquip GetRootAsHonamiStoryEquip(ByteBuffer _bb, HonamiStoryEquip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007F78 RID: 32632 RVA: 0x0025672D File Offset: 0x0025492D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007F79 RID: 32633 RVA: 0x0025673C File Offset: 0x0025493C
		public HonamiStoryEquip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001784 RID: 6020
		// (get) Token: 0x06007F7A RID: 32634 RVA: 0x0025674C File Offset: 0x0025494C
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

		// Token: 0x17001785 RID: 6021
		// (get) Token: 0x06007F7B RID: 32635 RVA: 0x00256788 File Offset: 0x00254988
		public int EnhanceLevel
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

		// Token: 0x17001786 RID: 6022
		// (get) Token: 0x06007F7C RID: 32636 RVA: 0x002567C4 File Offset: 0x002549C4
		public int RoleId
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

		// Token: 0x17001787 RID: 6023
		// (get) Token: 0x06007F7D RID: 32637 RVA: 0x00256800 File Offset: 0x00254A00
		public int RoleEnhanceLevel
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

		// Token: 0x17001788 RID: 6024
		// (get) Token: 0x06007F7E RID: 32638 RVA: 0x00256840 File Offset: 0x00254A40
		public int Tag
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

		// Token: 0x17001789 RID: 6025
		// (get) Token: 0x06007F7F RID: 32639 RVA: 0x00256880 File Offset: 0x00254A80
		public int TagEnhanceLevel
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

		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x06007F80 RID: 32640 RVA: 0x002568C0 File Offset: 0x00254AC0
		public int GroupId
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

		// Token: 0x04004DAF RID: 19887
		private Table __p;
	}
}
