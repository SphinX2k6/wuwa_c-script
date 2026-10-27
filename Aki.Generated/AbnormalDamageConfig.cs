using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AA7 RID: 2727
	public struct AbnormalDamageConfig : IFlatbufferObject
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06003FFF RID: 16383 RVA: 0x001C4397 File Offset: 0x001C2597
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004000 RID: 16384 RVA: 0x001C43A4 File Offset: 0x001C25A4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x001C43AC File Offset: 0x001C25AC
		public static AbnormalDamageConfig GetRootAsAbnormalDamageConfig(ByteBuffer _bb)
		{
			return AbnormalDamageConfig.GetRootAsAbnormalDamageConfig(_bb, default(AbnormalDamageConfig));
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x001C43C8 File Offset: 0x001C25C8
		public static AbnormalDamageConfig GetRootAsAbnormalDamageConfig(ByteBuffer _bb, AbnormalDamageConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004003 RID: 16387 RVA: 0x001C43E5 File Offset: 0x001C25E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004004 RID: 16388 RVA: 0x001C43F4 File Offset: 0x001C25F4
		public AbnormalDamageConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06004005 RID: 16389 RVA: 0x001C4404 File Offset: 0x001C2604
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
		// (get) Token: 0x06004006 RID: 16390 RVA: 0x001C4440 File Offset: 0x001C2640
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
		// (get) Token: 0x06004007 RID: 16391 RVA: 0x001C447C File Offset: 0x001C267C
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
		// (get) Token: 0x06004008 RID: 16392 RVA: 0x001C44B8 File Offset: 0x001C26B8
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
		// (get) Token: 0x06004009 RID: 16393 RVA: 0x001C44F8 File Offset: 0x001C26F8
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
		// (get) Token: 0x0600400A RID: 16394 RVA: 0x001C4538 File Offset: 0x001C2738
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
		// (get) Token: 0x0600400B RID: 16395 RVA: 0x001C4578 File Offset: 0x001C2778
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

		// Token: 0x04004A77 RID: 19063
		private Table __p;
	}
}
