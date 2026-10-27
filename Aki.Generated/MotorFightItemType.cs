using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E45 RID: 3653
	public struct MotorFightItemType : IFlatbufferObject
	{
		// Token: 0x170020C9 RID: 8393
		// (get) Token: 0x0600986B RID: 39019 RVA: 0x0028EFD5 File Offset: 0x0028D1D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600986C RID: 39020 RVA: 0x0028EFE2 File Offset: 0x0028D1E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600986D RID: 39021 RVA: 0x0028EFEC File Offset: 0x0028D1EC
		public static MotorFightItemType GetRootAsMotorFightItemType(ByteBuffer _bb)
		{
			return MotorFightItemType.GetRootAsMotorFightItemType(_bb, default(MotorFightItemType));
		}

		// Token: 0x0600986E RID: 39022 RVA: 0x0028F008 File Offset: 0x0028D208
		public static MotorFightItemType GetRootAsMotorFightItemType(ByteBuffer _bb, MotorFightItemType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600986F RID: 39023 RVA: 0x0028F025 File Offset: 0x0028D225
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009870 RID: 39024 RVA: 0x0028F034 File Offset: 0x0028D234
		public MotorFightItemType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170020CA RID: 8394
		// (get) Token: 0x06009871 RID: 39025 RVA: 0x0028F044 File Offset: 0x0028D244
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

		// Token: 0x170020CB RID: 8395
		// (get) Token: 0x06009872 RID: 39026 RVA: 0x0028F080 File Offset: 0x0028D280
		public string Name
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

		// Token: 0x06009873 RID: 39027 RVA: 0x0028F0B7 File Offset: 0x0028D2B7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009874 RID: 39028 RVA: 0x0028F0C6 File Offset: 0x0028D2C6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170020CC RID: 8396
		// (get) Token: 0x06009875 RID: 39029 RVA: 0x0028F0E0 File Offset: 0x0028D2E0
		public string Icon
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

		// Token: 0x06009876 RID: 39030 RVA: 0x0028F117 File Offset: 0x0028D317
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009877 RID: 39031 RVA: 0x0028F126 File Offset: 0x0028D326
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170020CD RID: 8397
		// (get) Token: 0x06009878 RID: 39032 RVA: 0x0028F140 File Offset: 0x0028D340
		public string DropBuffGateIcon
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

		// Token: 0x06009879 RID: 39033 RVA: 0x0028F178 File Offset: 0x0028D378
		public Span<byte> GetDropBuffGateIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600987A RID: 39034 RVA: 0x0028F188 File Offset: 0x0028D388
		public byte[] GetDropBuffGateIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170020CE RID: 8398
		// (get) Token: 0x0600987B RID: 39035 RVA: 0x0028F1A0 File Offset: 0x0028D3A0
		public string TextureIcon
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

		// Token: 0x0600987C RID: 39036 RVA: 0x0028F1D8 File Offset: 0x0028D3D8
		public Span<byte> GetTextureIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600987D RID: 39037 RVA: 0x0028F1E8 File Offset: 0x0028D3E8
		public byte[] GetTextureIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004EED RID: 20205
		private Table __p;
	}
}
