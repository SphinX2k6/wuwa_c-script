using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CCE RID: 3278
	public struct DevicePlatform : IFlatbufferObject
	{
		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x06006787 RID: 26503 RVA: 0x00231821 File Offset: 0x0022FA21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006788 RID: 26504 RVA: 0x0023182E File Offset: 0x0022FA2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006789 RID: 26505 RVA: 0x00231838 File Offset: 0x0022FA38
		public static DevicePlatform GetRootAsDevicePlatform(ByteBuffer _bb)
		{
			return DevicePlatform.GetRootAsDevicePlatform(_bb, default(DevicePlatform));
		}

		// Token: 0x0600678A RID: 26506 RVA: 0x00231854 File Offset: 0x0022FA54
		public static DevicePlatform GetRootAsDevicePlatform(ByteBuffer _bb, DevicePlatform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600678B RID: 26507 RVA: 0x00231871 File Offset: 0x0022FA71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600678C RID: 26508 RVA: 0x00231880 File Offset: 0x0022FA80
		public DevicePlatform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x0600678D RID: 26509 RVA: 0x00231890 File Offset: 0x0022FA90
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

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x0600678E RID: 26510 RVA: 0x002318CC File Offset: 0x0022FACC
		public string PidAndVid
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

		// Token: 0x0600678F RID: 26511 RVA: 0x00231903 File Offset: 0x0022FB03
		public Span<byte> GetPidAndVidBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006790 RID: 26512 RVA: 0x00231912 File Offset: 0x0022FB12
		public byte[] GetPidAndVidArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06006791 RID: 26513 RVA: 0x0023192C File Offset: 0x0022FB2C
		public int PlatformType
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

		// Token: 0x040051FB RID: 20987
		private Table __p;
	}
}
