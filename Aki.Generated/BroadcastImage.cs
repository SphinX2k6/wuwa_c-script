using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B4E RID: 2894
	public struct BroadcastImage : IFlatbufferObject
	{
		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06004F9E RID: 20382 RVA: 0x001E89BD File Offset: 0x001E6BBD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004F9F RID: 20383 RVA: 0x001E89CA File Offset: 0x001E6BCA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004FA0 RID: 20384 RVA: 0x001E89D4 File Offset: 0x001E6BD4
		public static BroadcastImage GetRootAsBroadcastImage(ByteBuffer _bb)
		{
			return BroadcastImage.GetRootAsBroadcastImage(_bb, default(BroadcastImage));
		}

		// Token: 0x06004FA1 RID: 20385 RVA: 0x001E89F0 File Offset: 0x001E6BF0
		public static BroadcastImage GetRootAsBroadcastImage(ByteBuffer _bb, BroadcastImage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004FA2 RID: 20386 RVA: 0x001E8A0D File Offset: 0x001E6C0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004FA3 RID: 20387 RVA: 0x001E8A1C File Offset: 0x001E6C1C
		public BroadcastImage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06004FA4 RID: 20388 RVA: 0x001E8A2C File Offset: 0x001E6C2C
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

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06004FA5 RID: 20389 RVA: 0x001E8A68 File Offset: 0x001E6C68
		public string Icon
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

		// Token: 0x06004FA6 RID: 20390 RVA: 0x001E8A9F File Offset: 0x001E6C9F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004FA7 RID: 20391 RVA: 0x001E8AAE File Offset: 0x001E6CAE
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06004FA8 RID: 20392 RVA: 0x001E8AC8 File Offset: 0x001E6CC8
		public string Image
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

		// Token: 0x06004FA9 RID: 20393 RVA: 0x001E8AFF File Offset: 0x001E6CFF
		public Span<byte> GetImageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004FAA RID: 20394 RVA: 0x001E8B0E File Offset: 0x001E6D0E
		public byte[] GetImageArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06004FAB RID: 20395 RVA: 0x001E8B28 File Offset: 0x001E6D28
		public string ImageM
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

		// Token: 0x06004FAC RID: 20396 RVA: 0x001E8B60 File Offset: 0x001E6D60
		public Span<byte> GetImageMBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004FAD RID: 20397 RVA: 0x001E8B70 File Offset: 0x001E6D70
		public byte[] GetImageMArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06004FAE RID: 20398 RVA: 0x001E8B88 File Offset: 0x001E6D88
		public string ImageF
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004FAF RID: 20399 RVA: 0x001E8BC0 File Offset: 0x001E6DC0
		public Span<byte> GetImageFBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004FB0 RID: 20400 RVA: 0x001E8BD0 File Offset: 0x001E6DD0
		public byte[] GetImageFArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06004FB1 RID: 20401 RVA: 0x001E8BE8 File Offset: 0x001E6DE8
		public string UmgIcon
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004FB2 RID: 20402 RVA: 0x001E8C20 File Offset: 0x001E6E20
		public Span<byte> GetUmgIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004FB3 RID: 20403 RVA: 0x001E8C30 File Offset: 0x001E6E30
		public byte[] GetUmgIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B49 RID: 19273
		private Table __p;
	}
}
