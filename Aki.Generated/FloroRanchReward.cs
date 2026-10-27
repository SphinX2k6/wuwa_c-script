using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CAF RID: 3247
	public struct FloroRanchReward : IFlatbufferObject
	{
		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x060073B8 RID: 29624 RVA: 0x0023BD94 File Offset: 0x00239F94
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060073B9 RID: 29625 RVA: 0x0023BDA1 File Offset: 0x00239FA1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060073BA RID: 29626 RVA: 0x0023BDA8 File Offset: 0x00239FA8
		public static FloroRanchReward GetRootAsFloroRanchReward(ByteBuffer _bb)
		{
			return FloroRanchReward.GetRootAsFloroRanchReward(_bb, default(FloroRanchReward));
		}

		// Token: 0x060073BB RID: 29627 RVA: 0x0023BDC4 File Offset: 0x00239FC4
		public static FloroRanchReward GetRootAsFloroRanchReward(ByteBuffer _bb, FloroRanchReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060073BC RID: 29628 RVA: 0x0023BDE1 File Offset: 0x00239FE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060073BD RID: 29629 RVA: 0x0023BDF0 File Offset: 0x00239FF0
		public FloroRanchReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x060073BE RID: 29630 RVA: 0x0023BE00 File Offset: 0x0023A000
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

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x060073BF RID: 29631 RVA: 0x0023BE3C File Offset: 0x0023A03C
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

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x060073C0 RID: 29632 RVA: 0x0023BE78 File Offset: 0x0023A078
		public int Index
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

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x060073C1 RID: 29633 RVA: 0x0023BEB4 File Offset: 0x0023A0B4
		public int NeedNum
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

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x060073C2 RID: 29634 RVA: 0x0023BEF4 File Offset: 0x0023A0F4
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

		// Token: 0x04004D13 RID: 19731
		private Table __p;
	}
}
