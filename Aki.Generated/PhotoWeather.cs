using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001001 RID: 4097
	public struct PhotoWeather : IFlatbufferObject
	{
		// Token: 0x17002911 RID: 10513
		// (get) Token: 0x0600B3A5 RID: 45989 RVA: 0x002DB288 File Offset: 0x002D9488
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B3A6 RID: 45990 RVA: 0x002DB295 File Offset: 0x002D9495
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B3A7 RID: 45991 RVA: 0x002DB29C File Offset: 0x002D949C
		public static PhotoWeather GetRootAsPhotoWeather(ByteBuffer _bb)
		{
			return PhotoWeather.GetRootAsPhotoWeather(_bb, default(PhotoWeather));
		}

		// Token: 0x0600B3A8 RID: 45992 RVA: 0x002DB2B8 File Offset: 0x002D94B8
		public static PhotoWeather GetRootAsPhotoWeather(ByteBuffer _bb, PhotoWeather obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B3A9 RID: 45993 RVA: 0x002DB2D5 File Offset: 0x002D94D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B3AA RID: 45994 RVA: 0x002DB2E4 File Offset: 0x002D94E4
		public PhotoWeather __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002912 RID: 10514
		// (get) Token: 0x0600B3AB RID: 45995 RVA: 0x002DB2F4 File Offset: 0x002D94F4
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

		// Token: 0x17002913 RID: 10515
		// (get) Token: 0x0600B3AC RID: 45996 RVA: 0x002DB330 File Offset: 0x002D9530
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

		// Token: 0x0600B3AD RID: 45997 RVA: 0x002DB367 File Offset: 0x002D9567
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B3AE RID: 45998 RVA: 0x002DB376 File Offset: 0x002D9576
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002914 RID: 10516
		// (get) Token: 0x0600B3AF RID: 45999 RVA: 0x002DB390 File Offset: 0x002D9590
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

		// Token: 0x0600B3B0 RID: 46000 RVA: 0x002DB3C7 File Offset: 0x002D95C7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B3B1 RID: 46001 RVA: 0x002DB3D6 File Offset: 0x002D95D6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002915 RID: 10517
		// (get) Token: 0x0600B3B2 RID: 46002 RVA: 0x002DB3F0 File Offset: 0x002D95F0
		public bool IsDefault
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040055CA RID: 21962
		private Table __p;
	}
}
