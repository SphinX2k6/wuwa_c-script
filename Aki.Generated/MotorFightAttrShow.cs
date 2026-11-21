using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F21 RID: 3873
	public struct MotorFightAttrShow : IFlatbufferObject
	{
		// Token: 0x170020E4 RID: 8420
		// (get) Token: 0x06009DEF RID: 40431 RVA: 0x002AB549 File Offset: 0x002A9749
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009DF0 RID: 40432 RVA: 0x002AB556 File Offset: 0x002A9756
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009DF1 RID: 40433 RVA: 0x002AB560 File Offset: 0x002A9760
		public static MotorFightAttrShow GetRootAsMotorFightAttrShow(ByteBuffer _bb)
		{
			return MotorFightAttrShow.GetRootAsMotorFightAttrShow(_bb, default(MotorFightAttrShow));
		}

		// Token: 0x06009DF2 RID: 40434 RVA: 0x002AB57C File Offset: 0x002A977C
		public static MotorFightAttrShow GetRootAsMotorFightAttrShow(ByteBuffer _bb, MotorFightAttrShow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009DF3 RID: 40435 RVA: 0x002AB599 File Offset: 0x002A9799
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009DF4 RID: 40436 RVA: 0x002AB5A8 File Offset: 0x002A97A8
		public MotorFightAttrShow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170020E5 RID: 8421
		// (get) Token: 0x06009DF5 RID: 40437 RVA: 0x002AB5B8 File Offset: 0x002A97B8
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

		// Token: 0x170020E6 RID: 8422
		// (get) Token: 0x06009DF6 RID: 40438 RVA: 0x002AB5F4 File Offset: 0x002A97F4
		public int AttriId
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

		// Token: 0x170020E7 RID: 8423
		// (get) Token: 0x06009DF7 RID: 40439 RVA: 0x002AB630 File Offset: 0x002A9830
		public string Name
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009DF8 RID: 40440 RVA: 0x002AB667 File Offset: 0x002A9867
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009DF9 RID: 40441 RVA: 0x002AB676 File Offset: 0x002A9876
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170020E8 RID: 8424
		// (get) Token: 0x06009DFA RID: 40442 RVA: 0x002AB690 File Offset: 0x002A9890
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009DFB RID: 40443 RVA: 0x002AB6C8 File Offset: 0x002A98C8
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009DFC RID: 40444 RVA: 0x002AB6D8 File Offset: 0x002A98D8
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170020E9 RID: 8425
		// (get) Token: 0x06009DFD RID: 40445 RVA: 0x002AB6F0 File Offset: 0x002A98F0
		public bool ShowInMainGun
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170020EA RID: 8426
		// (get) Token: 0x06009DFE RID: 40446 RVA: 0x002AB730 File Offset: 0x002A9930
		public bool ShowInWingman
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170020EB RID: 8427
		// (get) Token: 0x06009DFF RID: 40447 RVA: 0x002AB770 File Offset: 0x002A9970
		public bool ShowInCommon
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170020EC RID: 8428
		// (get) Token: 0x06009E00 RID: 40448 RVA: 0x002AB7B0 File Offset: 0x002A99B0
		public int SortId
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

		// Token: 0x170020ED RID: 8429
		// (get) Token: 0x06009E01 RID: 40449 RVA: 0x002AB7F0 File Offset: 0x002A99F0
		public int Ratio
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170020EE RID: 8430
		// (get) Token: 0x06009E02 RID: 40450 RVA: 0x002AB834 File Offset: 0x002A9A34
		public bool IsNeedPercentSign
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040054C9 RID: 21705
		private Table __p;
	}
}
