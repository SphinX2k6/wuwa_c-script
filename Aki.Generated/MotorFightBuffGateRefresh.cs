using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F26 RID: 3878
	public struct MotorFightBuffGateRefresh : IFlatbufferObject
	{
		// Token: 0x1700210F RID: 8463
		// (get) Token: 0x06009E48 RID: 40520 RVA: 0x002AC261 File Offset: 0x002AA461
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009E49 RID: 40521 RVA: 0x002AC26E File Offset: 0x002AA46E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009E4A RID: 40522 RVA: 0x002AC278 File Offset: 0x002AA478
		public static MotorFightBuffGateRefresh GetRootAsMotorFightBuffGateRefresh(ByteBuffer _bb)
		{
			return MotorFightBuffGateRefresh.GetRootAsMotorFightBuffGateRefresh(_bb, default(MotorFightBuffGateRefresh));
		}

		// Token: 0x06009E4B RID: 40523 RVA: 0x002AC294 File Offset: 0x002AA494
		public static MotorFightBuffGateRefresh GetRootAsMotorFightBuffGateRefresh(ByteBuffer _bb, MotorFightBuffGateRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009E4C RID: 40524 RVA: 0x002AC2B1 File Offset: 0x002AA4B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009E4D RID: 40525 RVA: 0x002AC2C0 File Offset: 0x002AA4C0
		public MotorFightBuffGateRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002110 RID: 8464
		// (get) Token: 0x06009E4E RID: 40526 RVA: 0x002AC2D0 File Offset: 0x002AA4D0
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

		// Token: 0x17002111 RID: 8465
		// (get) Token: 0x06009E4F RID: 40527 RVA: 0x002AC30C File Offset: 0x002AA50C
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

		// Token: 0x17002112 RID: 8466
		// (get) Token: 0x06009E50 RID: 40528 RVA: 0x002AC348 File Offset: 0x002AA548
		public int Type
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

		// Token: 0x17002113 RID: 8467
		// (get) Token: 0x06009E51 RID: 40529 RVA: 0x002AC384 File Offset: 0x002AA584
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

		// Token: 0x17002114 RID: 8468
		// (get) Token: 0x06009E52 RID: 40530 RVA: 0x002AC3C4 File Offset: 0x002AA5C4
		public int BuffGateId
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

		// Token: 0x040054CE RID: 21710
		private Table __p;
	}
}
