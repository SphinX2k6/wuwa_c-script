using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FF1 RID: 4081
	public struct PhotoFilter : IFlatbufferObject
	{
		// Token: 0x1700284E RID: 10318
		// (get) Token: 0x0600B1F8 RID: 45560 RVA: 0x002D7340 File Offset: 0x002D5540
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B1F9 RID: 45561 RVA: 0x002D734D File Offset: 0x002D554D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B1FA RID: 45562 RVA: 0x002D7354 File Offset: 0x002D5554
		public static PhotoFilter GetRootAsPhotoFilter(ByteBuffer _bb)
		{
			return PhotoFilter.GetRootAsPhotoFilter(_bb, default(PhotoFilter));
		}

		// Token: 0x0600B1FB RID: 45563 RVA: 0x002D7370 File Offset: 0x002D5570
		public static PhotoFilter GetRootAsPhotoFilter(ByteBuffer _bb, PhotoFilter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B1FC RID: 45564 RVA: 0x002D738D File Offset: 0x002D558D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B1FD RID: 45565 RVA: 0x002D739C File Offset: 0x002D559C
		public PhotoFilter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700284F RID: 10319
		// (get) Token: 0x0600B1FE RID: 45566 RVA: 0x002D73AC File Offset: 0x002D55AC
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

		// Token: 0x17002850 RID: 10320
		// (get) Token: 0x0600B1FF RID: 45567 RVA: 0x002D73E8 File Offset: 0x002D55E8
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

		// Token: 0x0600B200 RID: 45568 RVA: 0x002D741F File Offset: 0x002D561F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B201 RID: 45569 RVA: 0x002D742E File Offset: 0x002D562E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002851 RID: 10321
		// (get) Token: 0x0600B202 RID: 45570 RVA: 0x002D7448 File Offset: 0x002D5648
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

		// Token: 0x0600B203 RID: 45571 RVA: 0x002D747F File Offset: 0x002D567F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B204 RID: 45572 RVA: 0x002D748E File Offset: 0x002D568E
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002852 RID: 10322
		// (get) Token: 0x0600B205 RID: 45573 RVA: 0x002D74A8 File Offset: 0x002D56A8
		public string LUTPath
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

		// Token: 0x0600B206 RID: 45574 RVA: 0x002D74E0 File Offset: 0x002D56E0
		public Span<byte> GetLUTPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B207 RID: 45575 RVA: 0x002D74F0 File Offset: 0x002D56F0
		public byte[] GetLUTPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002853 RID: 10323
		// (get) Token: 0x0600B208 RID: 45576 RVA: 0x002D7508 File Offset: 0x002D5708
		public string PPVName
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

		// Token: 0x0600B209 RID: 45577 RVA: 0x002D7540 File Offset: 0x002D5740
		public Span<byte> GetPPVNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B20A RID: 45578 RVA: 0x002D7550 File Offset: 0x002D5750
		public byte[] GetPPVNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040055B9 RID: 21945
		private Table __p;
	}
}
