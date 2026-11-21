using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200123B RID: 4667
	public struct SurvivorsRoleLv : IFlatbufferObject
	{
		// Token: 0x17003C6F RID: 15471
		// (get) Token: 0x0600E8A0 RID: 59552 RVA: 0x0035104D File Offset: 0x0034F24D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E8A1 RID: 59553 RVA: 0x0035105A File Offset: 0x0034F25A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E8A2 RID: 59554 RVA: 0x00351064 File Offset: 0x0034F264
		public static SurvivorsRoleLv GetRootAsSurvivorsRoleLv(ByteBuffer _bb)
		{
			return SurvivorsRoleLv.GetRootAsSurvivorsRoleLv(_bb, default(SurvivorsRoleLv));
		}

		// Token: 0x0600E8A3 RID: 59555 RVA: 0x00351080 File Offset: 0x0034F280
		public static SurvivorsRoleLv GetRootAsSurvivorsRoleLv(ByteBuffer _bb, SurvivorsRoleLv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E8A4 RID: 59556 RVA: 0x0035109D File Offset: 0x0034F29D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E8A5 RID: 59557 RVA: 0x003510AC File Offset: 0x0034F2AC
		public SurvivorsRoleLv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C70 RID: 15472
		// (get) Token: 0x0600E8A6 RID: 59558 RVA: 0x003510BC File Offset: 0x0034F2BC
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

		// Token: 0x17003C71 RID: 15473
		// (get) Token: 0x0600E8A7 RID: 59559 RVA: 0x003510F8 File Offset: 0x0034F2F8
		public int RoleId
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

		// Token: 0x17003C72 RID: 15474
		// (get) Token: 0x0600E8A8 RID: 59560 RVA: 0x00351134 File Offset: 0x0034F334
		public int Level
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

		// Token: 0x17003C73 RID: 15475
		// (get) Token: 0x0600E8A9 RID: 59561 RVA: 0x00351170 File Offset: 0x0034F370
		public int Effect
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

		// Token: 0x17003C74 RID: 15476
		// (get) Token: 0x0600E8AA RID: 59562 RVA: 0x003511B0 File Offset: 0x0034F3B0
		public int BuffCategoryType
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

		// Token: 0x17003C75 RID: 15477
		// (get) Token: 0x0600E8AB RID: 59563 RVA: 0x003511F0 File Offset: 0x0034F3F0
		public int Quality
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

		// Token: 0x17003C76 RID: 15478
		// (get) Token: 0x0600E8AC RID: 59564 RVA: 0x00351230 File Offset: 0x0034F430
		public string Describe
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E8AD RID: 59565 RVA: 0x00351268 File Offset: 0x0034F468
		public Span<byte> GetDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E8AE RID: 59566 RVA: 0x00351278 File Offset: 0x0034F478
		public byte[] GetDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C77 RID: 15479
		// (get) Token: 0x0600E8AF RID: 59567 RVA: 0x00351290 File Offset: 0x0034F490
		public int PropertyId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003C78 RID: 15480
		// (get) Token: 0x0600E8B0 RID: 59568 RVA: 0x003512D0 File Offset: 0x0034F4D0
		public int PropertyValue
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003C79 RID: 15481
		// (get) Token: 0x0600E8B1 RID: 59569 RVA: 0x00351310 File Offset: 0x0034F510
		public bool IsPercent
		{
			get
			{
				int num = this.__p.__offset(22);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005881 RID: 22657
		private Table __p;
	}
}
