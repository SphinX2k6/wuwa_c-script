using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C2E RID: 3118
	public struct BroadcastImage : IFlatbufferObject
	{
		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06005560 RID: 21856 RVA: 0x00208AFD File Offset: 0x00206CFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005561 RID: 21857 RVA: 0x00208B0A File Offset: 0x00206D0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005562 RID: 21858 RVA: 0x00208B14 File Offset: 0x00206D14
		public static BroadcastImage GetRootAsBroadcastImage(ByteBuffer _bb)
		{
			return BroadcastImage.GetRootAsBroadcastImage(_bb, default(BroadcastImage));
		}

		// Token: 0x06005563 RID: 21859 RVA: 0x00208B30 File Offset: 0x00206D30
		public static BroadcastImage GetRootAsBroadcastImage(ByteBuffer _bb, BroadcastImage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005564 RID: 21860 RVA: 0x00208B4D File Offset: 0x00206D4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005565 RID: 21861 RVA: 0x00208B5C File Offset: 0x00206D5C
		public BroadcastImage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06005566 RID: 21862 RVA: 0x00208B6C File Offset: 0x00206D6C
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

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06005567 RID: 21863 RVA: 0x00208BA8 File Offset: 0x00206DA8
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

		// Token: 0x06005568 RID: 21864 RVA: 0x00208BDF File Offset: 0x00206DDF
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005569 RID: 21865 RVA: 0x00208BEE File Offset: 0x00206DEE
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x0600556A RID: 21866 RVA: 0x00208C08 File Offset: 0x00206E08
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

		// Token: 0x0600556B RID: 21867 RVA: 0x00208C3F File Offset: 0x00206E3F
		public Span<byte> GetImageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600556C RID: 21868 RVA: 0x00208C4E File Offset: 0x00206E4E
		public byte[] GetImageArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x0600556D RID: 21869 RVA: 0x00208C68 File Offset: 0x00206E68
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

		// Token: 0x0600556E RID: 21870 RVA: 0x00208CA0 File Offset: 0x00206EA0
		public Span<byte> GetImageMBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600556F RID: 21871 RVA: 0x00208CB0 File Offset: 0x00206EB0
		public byte[] GetImageMArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06005570 RID: 21872 RVA: 0x00208CC8 File Offset: 0x00206EC8
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

		// Token: 0x06005571 RID: 21873 RVA: 0x00208D00 File Offset: 0x00206F00
		public Span<byte> GetImageFBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005572 RID: 21874 RVA: 0x00208D10 File Offset: 0x00206F10
		public byte[] GetImageFArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06005573 RID: 21875 RVA: 0x00208D28 File Offset: 0x00206F28
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

		// Token: 0x06005574 RID: 21876 RVA: 0x00208D60 File Offset: 0x00206F60
		public Span<byte> GetUmgIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005575 RID: 21877 RVA: 0x00208D70 File Offset: 0x00206F70
		public byte[] GetUmgIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005129 RID: 20777
		private Table __p;
	}
}
