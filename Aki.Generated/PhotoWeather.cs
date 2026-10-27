using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F1C RID: 3868
	public struct PhotoWeather : IFlatbufferObject
	{
		// Token: 0x170028AB RID: 10411
		// (get) Token: 0x0600AD84 RID: 44420 RVA: 0x002BE6AC File Offset: 0x002BC8AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AD85 RID: 44421 RVA: 0x002BE6B9 File Offset: 0x002BC8B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AD86 RID: 44422 RVA: 0x002BE6C0 File Offset: 0x002BC8C0
		public static PhotoWeather GetRootAsPhotoWeather(ByteBuffer _bb)
		{
			return PhotoWeather.GetRootAsPhotoWeather(_bb, default(PhotoWeather));
		}

		// Token: 0x0600AD87 RID: 44423 RVA: 0x002BE6DC File Offset: 0x002BC8DC
		public static PhotoWeather GetRootAsPhotoWeather(ByteBuffer _bb, PhotoWeather obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AD88 RID: 44424 RVA: 0x002BE6F9 File Offset: 0x002BC8F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AD89 RID: 44425 RVA: 0x002BE708 File Offset: 0x002BC908
		public PhotoWeather __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170028AC RID: 10412
		// (get) Token: 0x0600AD8A RID: 44426 RVA: 0x002BE718 File Offset: 0x002BC918
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

		// Token: 0x170028AD RID: 10413
		// (get) Token: 0x0600AD8B RID: 44427 RVA: 0x002BE754 File Offset: 0x002BC954
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

		// Token: 0x0600AD8C RID: 44428 RVA: 0x002BE78B File Offset: 0x002BC98B
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600AD8D RID: 44429 RVA: 0x002BE79A File Offset: 0x002BC99A
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170028AE RID: 10414
		// (get) Token: 0x0600AD8E RID: 44430 RVA: 0x002BE7B4 File Offset: 0x002BC9B4
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

		// Token: 0x0600AD8F RID: 44431 RVA: 0x002BE7EB File Offset: 0x002BC9EB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AD90 RID: 44432 RVA: 0x002BE7FA File Offset: 0x002BC9FA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170028AF RID: 10415
		// (get) Token: 0x0600AD91 RID: 44433 RVA: 0x002BE814 File Offset: 0x002BCA14
		public bool IsDefault
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004FE5 RID: 20453
		private Table __p;
	}
}
