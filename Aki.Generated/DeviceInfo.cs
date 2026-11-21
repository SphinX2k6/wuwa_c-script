using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CCD RID: 3277
	public struct DeviceInfo : IFlatbufferObject
	{
		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x0600677A RID: 26490 RVA: 0x002316BC File Offset: 0x0022F8BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600677B RID: 26491 RVA: 0x002316C9 File Offset: 0x0022F8C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600677C RID: 26492 RVA: 0x002316D0 File Offset: 0x0022F8D0
		public static DeviceInfo GetRootAsDeviceInfo(ByteBuffer _bb)
		{
			return DeviceInfo.GetRootAsDeviceInfo(_bb, default(DeviceInfo));
		}

		// Token: 0x0600677D RID: 26493 RVA: 0x002316EC File Offset: 0x0022F8EC
		public static DeviceInfo GetRootAsDeviceInfo(ByteBuffer _bb, DeviceInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600677E RID: 26494 RVA: 0x00231709 File Offset: 0x0022F909
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600677F RID: 26495 RVA: 0x00231718 File Offset: 0x0022F918
		public DeviceInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06006780 RID: 26496 RVA: 0x00231728 File Offset: 0x0022F928
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

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x06006781 RID: 26497 RVA: 0x00231764 File Offset: 0x0022F964
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

		// Token: 0x06006782 RID: 26498 RVA: 0x0023179B File Offset: 0x0022F99B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006783 RID: 26499 RVA: 0x002317AA File Offset: 0x0022F9AA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x06006784 RID: 26500 RVA: 0x002317C4 File Offset: 0x0022F9C4
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

		// Token: 0x06006785 RID: 26501 RVA: 0x002317FB File Offset: 0x0022F9FB
		public Span<byte> GetLowTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006786 RID: 26502 RVA: 0x0023180A File Offset: 0x0022FA0A
		public byte[] GetLowTipsArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040051FA RID: 20986
		private Table __p;
	}
}
