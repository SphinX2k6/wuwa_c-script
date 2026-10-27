using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BEC RID: 3052
	public struct DevicePlatform : IFlatbufferObject
	{
		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x060061AE RID: 25006 RVA: 0x002121F5 File Offset: 0x002103F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060061AF RID: 25007 RVA: 0x00212202 File Offset: 0x00210402
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060061B0 RID: 25008 RVA: 0x0021220C File Offset: 0x0021040C
		public static DevicePlatform GetRootAsDevicePlatform(ByteBuffer _bb)
		{
			return DevicePlatform.GetRootAsDevicePlatform(_bb, default(DevicePlatform));
		}

		// Token: 0x060061B1 RID: 25009 RVA: 0x00212228 File Offset: 0x00210428
		public static DevicePlatform GetRootAsDevicePlatform(ByteBuffer _bb, DevicePlatform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060061B2 RID: 25010 RVA: 0x00212245 File Offset: 0x00210445
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060061B3 RID: 25011 RVA: 0x00212254 File Offset: 0x00210454
		public DevicePlatform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x060061B4 RID: 25012 RVA: 0x00212264 File Offset: 0x00210464
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

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x060061B5 RID: 25013 RVA: 0x002122A0 File Offset: 0x002104A0
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

		// Token: 0x060061B6 RID: 25014 RVA: 0x002122D7 File Offset: 0x002104D7
		public Span<byte> GetPidAndVidBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060061B7 RID: 25015 RVA: 0x002122E6 File Offset: 0x002104E6
		public byte[] GetPidAndVidArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x060061B8 RID: 25016 RVA: 0x00212300 File Offset: 0x00210500
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

		// Token: 0x04004C19 RID: 19481
		private Table __p;
	}
}
