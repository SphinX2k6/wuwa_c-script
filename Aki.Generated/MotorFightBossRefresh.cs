using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E3E RID: 3646
	public struct MotorFightBossRefresh : IFlatbufferObject
	{
		// Token: 0x17002092 RID: 8338
		// (get) Token: 0x060097F0 RID: 38896 RVA: 0x0028DE2D File Offset: 0x0028C02D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060097F1 RID: 38897 RVA: 0x0028DE3A File Offset: 0x0028C03A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060097F2 RID: 38898 RVA: 0x0028DE44 File Offset: 0x0028C044
		public static MotorFightBossRefresh GetRootAsMotorFightBossRefresh(ByteBuffer _bb)
		{
			return MotorFightBossRefresh.GetRootAsMotorFightBossRefresh(_bb, default(MotorFightBossRefresh));
		}

		// Token: 0x060097F3 RID: 38899 RVA: 0x0028DE60 File Offset: 0x0028C060
		public static MotorFightBossRefresh GetRootAsMotorFightBossRefresh(ByteBuffer _bb, MotorFightBossRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060097F4 RID: 38900 RVA: 0x0028DE7D File Offset: 0x0028C07D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060097F5 RID: 38901 RVA: 0x0028DE8C File Offset: 0x0028C08C
		public MotorFightBossRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002093 RID: 8339
		// (get) Token: 0x060097F6 RID: 38902 RVA: 0x0028DE9C File Offset: 0x0028C09C
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

		// Token: 0x17002094 RID: 8340
		// (get) Token: 0x060097F7 RID: 38903 RVA: 0x0028DED8 File Offset: 0x0028C0D8
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

		// Token: 0x17002095 RID: 8341
		// (get) Token: 0x060097F8 RID: 38904 RVA: 0x0028DF14 File Offset: 0x0028C114
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

		// Token: 0x17002096 RID: 8342
		// (get) Token: 0x060097F9 RID: 38905 RVA: 0x0028DF50 File Offset: 0x0028C150
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

		// Token: 0x17002097 RID: 8343
		// (get) Token: 0x060097FA RID: 38906 RVA: 0x0028DF90 File Offset: 0x0028C190
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

		// Token: 0x17002098 RID: 8344
		// (get) Token: 0x060097FB RID: 38907 RVA: 0x0028DFD0 File Offset: 0x0028C1D0
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

		// Token: 0x04004EE6 RID: 20198
		private Table __p;
	}
}
