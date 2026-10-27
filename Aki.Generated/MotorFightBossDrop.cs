using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E3D RID: 3645
	public struct MotorFightBossDrop : IFlatbufferObject
	{
		// Token: 0x1700208A RID: 8330
		// (get) Token: 0x060097E3 RID: 38883 RVA: 0x0028DC10 File Offset: 0x0028BE10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060097E4 RID: 38884 RVA: 0x0028DC1D File Offset: 0x0028BE1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060097E5 RID: 38885 RVA: 0x0028DC24 File Offset: 0x0028BE24
		public static MotorFightBossDrop GetRootAsMotorFightBossDrop(ByteBuffer _bb)
		{
			return MotorFightBossDrop.GetRootAsMotorFightBossDrop(_bb, default(MotorFightBossDrop));
		}

		// Token: 0x060097E6 RID: 38886 RVA: 0x0028DC40 File Offset: 0x0028BE40
		public static MotorFightBossDrop GetRootAsMotorFightBossDrop(ByteBuffer _bb, MotorFightBossDrop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060097E7 RID: 38887 RVA: 0x0028DC5D File Offset: 0x0028BE5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060097E8 RID: 38888 RVA: 0x0028DC6C File Offset: 0x0028BE6C
		public MotorFightBossDrop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700208B RID: 8331
		// (get) Token: 0x060097E9 RID: 38889 RVA: 0x0028DC7C File Offset: 0x0028BE7C
		public int DropId
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

		// Token: 0x1700208C RID: 8332
		// (get) Token: 0x060097EA RID: 38890 RVA: 0x0028DCB8 File Offset: 0x0028BEB8
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

		// Token: 0x1700208D RID: 8333
		// (get) Token: 0x060097EB RID: 38891 RVA: 0x0028DCF4 File Offset: 0x0028BEF4
		public int Weight
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

		// Token: 0x1700208E RID: 8334
		// (get) Token: 0x060097EC RID: 38892 RVA: 0x0028DD30 File Offset: 0x0028BF30
		public int CollectionGroup1
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

		// Token: 0x1700208F RID: 8335
		// (get) Token: 0x060097ED RID: 38893 RVA: 0x0028DD70 File Offset: 0x0028BF70
		public int CollectionGroup2
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

		// Token: 0x17002090 RID: 8336
		// (get) Token: 0x060097EE RID: 38894 RVA: 0x0028DDB0 File Offset: 0x0028BFB0
		public int CollectionGroup3
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

		// Token: 0x17002091 RID: 8337
		// (get) Token: 0x060097EF RID: 38895 RVA: 0x0028DDF0 File Offset: 0x0028BFF0
		public int UpperLimitItemGroup
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

		// Token: 0x04004EE5 RID: 20197
		private Table __p;
	}
}
