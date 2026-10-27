using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BEB RID: 3051
	public struct DeviceInfo : IFlatbufferObject
	{
		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x060061A1 RID: 24993 RVA: 0x00212090 File Offset: 0x00210290
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060061A2 RID: 24994 RVA: 0x0021209D File Offset: 0x0021029D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060061A3 RID: 24995 RVA: 0x002120A4 File Offset: 0x002102A4
		public static DeviceInfo GetRootAsDeviceInfo(ByteBuffer _bb)
		{
			return DeviceInfo.GetRootAsDeviceInfo(_bb, default(DeviceInfo));
		}

		// Token: 0x060061A4 RID: 24996 RVA: 0x002120C0 File Offset: 0x002102C0
		public static DeviceInfo GetRootAsDeviceInfo(ByteBuffer _bb, DeviceInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060061A5 RID: 24997 RVA: 0x002120DD File Offset: 0x002102DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060061A6 RID: 24998 RVA: 0x002120EC File Offset: 0x002102EC
		public DeviceInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x060061A7 RID: 24999 RVA: 0x002120FC File Offset: 0x002102FC
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

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x060061A8 RID: 25000 RVA: 0x00212138 File Offset: 0x00210338
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

		// Token: 0x060061A9 RID: 25001 RVA: 0x0021216F File Offset: 0x0021036F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060061AA RID: 25002 RVA: 0x0021217E File Offset: 0x0021037E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x060061AB RID: 25003 RVA: 0x00212198 File Offset: 0x00210398
		public string LowTips
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

		// Token: 0x060061AC RID: 25004 RVA: 0x002121CF File Offset: 0x002103CF
		public Span<byte> GetLowTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060061AD RID: 25005 RVA: 0x002121DE File Offset: 0x002103DE
		public byte[] GetLowTipsArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C18 RID: 19480
		private Table __p;
	}
}
