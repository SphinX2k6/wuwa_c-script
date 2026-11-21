using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F23 RID: 3875
	public struct MotorFightBossRefresh : IFlatbufferObject
	{
		// Token: 0x170020F7 RID: 8439
		// (get) Token: 0x06009E10 RID: 40464 RVA: 0x002ABA91 File Offset: 0x002A9C91
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009E11 RID: 40465 RVA: 0x002ABA9E File Offset: 0x002A9C9E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009E12 RID: 40466 RVA: 0x002ABAA8 File Offset: 0x002A9CA8
		public static MotorFightBossRefresh GetRootAsMotorFightBossRefresh(ByteBuffer _bb)
		{
			return MotorFightBossRefresh.GetRootAsMotorFightBossRefresh(_bb, default(MotorFightBossRefresh));
		}

		// Token: 0x06009E13 RID: 40467 RVA: 0x002ABAC4 File Offset: 0x002A9CC4
		public static MotorFightBossRefresh GetRootAsMotorFightBossRefresh(ByteBuffer _bb, MotorFightBossRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009E14 RID: 40468 RVA: 0x002ABAE1 File Offset: 0x002A9CE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009E15 RID: 40469 RVA: 0x002ABAF0 File Offset: 0x002A9CF0
		public MotorFightBossRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170020F8 RID: 8440
		// (get) Token: 0x06009E16 RID: 40470 RVA: 0x002ABB00 File Offset: 0x002A9D00
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

		// Token: 0x170020F9 RID: 8441
		// (get) Token: 0x06009E17 RID: 40471 RVA: 0x002ABB3C File Offset: 0x002A9D3C
		public int BossType
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

		// Token: 0x170020FA RID: 8442
		// (get) Token: 0x06009E18 RID: 40472 RVA: 0x002ABB78 File Offset: 0x002A9D78
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

		// Token: 0x170020FB RID: 8443
		// (get) Token: 0x06009E19 RID: 40473 RVA: 0x002ABBB4 File Offset: 0x002A9DB4
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

		// Token: 0x170020FC RID: 8444
		// (get) Token: 0x06009E1A RID: 40474 RVA: 0x002ABBF4 File Offset: 0x002A9DF4
		public int MonsterId
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

		// Token: 0x170020FD RID: 8445
		// (get) Token: 0x06009E1B RID: 40475 RVA: 0x002ABC34 File Offset: 0x002A9E34
		public int DropGroupId
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

		// Token: 0x040054CB RID: 21707
		private Table __p;
	}
}
