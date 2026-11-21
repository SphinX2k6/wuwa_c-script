using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B7C RID: 2940
	public struct AbnormalDamageConfig : IFlatbufferObject
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060044FD RID: 17661 RVA: 0x001E372B File Offset: 0x001E192B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x001E3738 File Offset: 0x001E1938
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x001E3740 File Offset: 0x001E1940
		public static AbnormalDamageConfig GetRootAsAbnormalDamageConfig(ByteBuffer _bb)
		{
			return AbnormalDamageConfig.GetRootAsAbnormalDamageConfig(_bb, default(AbnormalDamageConfig));
		}

		// Token: 0x06004500 RID: 17664 RVA: 0x001E375C File Offset: 0x001E195C
		public static AbnormalDamageConfig GetRootAsAbnormalDamageConfig(ByteBuffer _bb, AbnormalDamageConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x001E3779 File Offset: 0x001E1979
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x001E3788 File Offset: 0x001E1988
		public AbnormalDamageConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06004503 RID: 17667 RVA: 0x001E3798 File Offset: 0x001E1998
		public int Level
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

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06004504 RID: 17668 RVA: 0x001E37D4 File Offset: 0x001E19D4
		public int Abnormal1001
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

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06004505 RID: 17669 RVA: 0x001E3810 File Offset: 0x001E1A10
		public int Abnormal1002
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

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06004506 RID: 17670 RVA: 0x001E384C File Offset: 0x001E1A4C
		public int Abnormal1003
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

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06004507 RID: 17671 RVA: 0x001E388C File Offset: 0x001E1A8C
		public int Abnormal1004
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

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06004508 RID: 17672 RVA: 0x001E38CC File Offset: 0x001E1ACC
		public int Abnormal1005
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

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06004509 RID: 17673 RVA: 0x001E390C File Offset: 0x001E1B0C
		public int Abnormal1006
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

		// Token: 0x0400504A RID: 20554
		private Table __p;
	}
}
