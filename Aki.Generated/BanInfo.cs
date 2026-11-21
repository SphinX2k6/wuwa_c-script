using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C06 RID: 3078
	public struct BanInfo : IFlatbufferObject
	{
		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x0600516F RID: 20847 RVA: 0x001FF291 File Offset: 0x001FD491
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005170 RID: 20848 RVA: 0x001FF29E File Offset: 0x001FD49E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005171 RID: 20849 RVA: 0x001FF2A8 File Offset: 0x001FD4A8
		public static BanInfo GetRootAsBanInfo(ByteBuffer _bb)
		{
			return BanInfo.GetRootAsBanInfo(_bb, default(BanInfo));
		}

		// Token: 0x06005172 RID: 20850 RVA: 0x001FF2C4 File Offset: 0x001FD4C4
		public static BanInfo GetRootAsBanInfo(ByteBuffer _bb, BanInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005173 RID: 20851 RVA: 0x001FF2E1 File Offset: 0x001FD4E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005174 RID: 20852 RVA: 0x001FF2F0 File Offset: 0x001FD4F0
		public BanInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06005175 RID: 20853 RVA: 0x001FF300 File Offset: 0x001FD500
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

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06005176 RID: 20854 RVA: 0x001FF33C File Offset: 0x001FD53C
		public int BanType
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

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06005177 RID: 20855 RVA: 0x001FF378 File Offset: 0x001FD578
		public int BanReason
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

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06005178 RID: 20856 RVA: 0x001FF3B4 File Offset: 0x001FD5B4
		public string BanDescribe
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

		// Token: 0x06005179 RID: 20857 RVA: 0x001FF3EC File Offset: 0x001FD5EC
		public Span<byte> GetBanDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600517A RID: 20858 RVA: 0x001FF3FC File Offset: 0x001FD5FC
		public byte[] GetBanDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040050F8 RID: 20728
		private Table __p;
	}
}
