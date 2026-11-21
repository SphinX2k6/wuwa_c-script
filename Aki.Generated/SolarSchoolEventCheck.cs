using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011DF RID: 4575
	public struct SolarSchoolEventCheck : IFlatbufferObject
	{
		// Token: 0x17003945 RID: 14661
		// (get) Token: 0x0600E0AB RID: 57515 RVA: 0x0033F538 File Offset: 0x0033D738
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E0AC RID: 57516 RVA: 0x0033F545 File Offset: 0x0033D745
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E0AD RID: 57517 RVA: 0x0033F54C File Offset: 0x0033D74C
		public static SolarSchoolEventCheck GetRootAsSolarSchoolEventCheck(ByteBuffer _bb)
		{
			return SolarSchoolEventCheck.GetRootAsSolarSchoolEventCheck(_bb, default(SolarSchoolEventCheck));
		}

		// Token: 0x0600E0AE RID: 57518 RVA: 0x0033F568 File Offset: 0x0033D768
		public static SolarSchoolEventCheck GetRootAsSolarSchoolEventCheck(ByteBuffer _bb, SolarSchoolEventCheck obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E0AF RID: 57519 RVA: 0x0033F585 File Offset: 0x0033D785
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E0B0 RID: 57520 RVA: 0x0033F594 File Offset: 0x0033D794
		public SolarSchoolEventCheck __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003946 RID: 14662
		// (get) Token: 0x0600E0B1 RID: 57521 RVA: 0x0033F5A4 File Offset: 0x0033D7A4
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

		// Token: 0x17003947 RID: 14663
		// (get) Token: 0x0600E0B2 RID: 57522 RVA: 0x0033F5E0 File Offset: 0x0033D7E0
		public string DescKey
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E0B3 RID: 57523 RVA: 0x0033F617 File Offset: 0x0033D817
		public Span<byte> GetDescKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E0B4 RID: 57524 RVA: 0x0033F626 File Offset: 0x0033D826
		public byte[] GetDescKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003948 RID: 14664
		// (get) Token: 0x0600E0B5 RID: 57525 RVA: 0x0033F640 File Offset: 0x0033D840
		public int OptionGroupId
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

		// Token: 0x17003949 RID: 14665
		// (get) Token: 0x0600E0B6 RID: 57526 RVA: 0x0033F67C File Offset: 0x0033D87C
		public string BgImage
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

		// Token: 0x0600E0B7 RID: 57527 RVA: 0x0033F6B4 File Offset: 0x0033D8B4
		public Span<byte> GetBgImageBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E0B8 RID: 57528 RVA: 0x0033F6C4 File Offset: 0x0033D8C4
		public byte[] GetBgImageArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0400581C RID: 22556
		private Table __p;
	}
}
