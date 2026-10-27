using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E41 RID: 3649
	public struct MotorFightBuffGateRefresh : IFlatbufferObject
	{
		// Token: 0x170020AA RID: 8362
		// (get) Token: 0x06009828 RID: 38952 RVA: 0x0028E63B File Offset: 0x0028C83B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009829 RID: 38953 RVA: 0x0028E648 File Offset: 0x0028C848
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600982A RID: 38954 RVA: 0x0028E650 File Offset: 0x0028C850
		public static MotorFightBuffGateRefresh GetRootAsMotorFightBuffGateRefresh(ByteBuffer _bb)
		{
			return MotorFightBuffGateRefresh.GetRootAsMotorFightBuffGateRefresh(_bb, default(MotorFightBuffGateRefresh));
		}

		// Token: 0x0600982B RID: 38955 RVA: 0x0028E66C File Offset: 0x0028C86C
		public static MotorFightBuffGateRefresh GetRootAsMotorFightBuffGateRefresh(ByteBuffer _bb, MotorFightBuffGateRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600982C RID: 38956 RVA: 0x0028E689 File Offset: 0x0028C889
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600982D RID: 38957 RVA: 0x0028E698 File Offset: 0x0028C898
		public MotorFightBuffGateRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170020AB RID: 8363
		// (get) Token: 0x0600982E RID: 38958 RVA: 0x0028E6A8 File Offset: 0x0028C8A8
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

		// Token: 0x170020AC RID: 8364
		// (get) Token: 0x0600982F RID: 38959 RVA: 0x0028E6E4 File Offset: 0x0028C8E4
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

		// Token: 0x170020AD RID: 8365
		// (get) Token: 0x06009830 RID: 38960 RVA: 0x0028E720 File Offset: 0x0028C920
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

		// Token: 0x170020AE RID: 8366
		// (get) Token: 0x06009831 RID: 38961 RVA: 0x0028E75C File Offset: 0x0028C95C
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

		// Token: 0x170020AF RID: 8367
		// (get) Token: 0x06009832 RID: 38962 RVA: 0x0028E79C File Offset: 0x0028C99C
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

		// Token: 0x04004EE9 RID: 20201
		private Table __p;
	}
}
