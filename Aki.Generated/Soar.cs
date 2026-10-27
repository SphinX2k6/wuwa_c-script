using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010D4 RID: 4308
	public struct Soar : IFlatbufferObject
	{
		// Token: 0x1700377D RID: 14205
		// (get) Token: 0x0600D70D RID: 55053 RVA: 0x0031C2D0 File Offset: 0x0031A4D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D70E RID: 55054 RVA: 0x0031C2DD File Offset: 0x0031A4DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D70F RID: 55055 RVA: 0x0031C2E4 File Offset: 0x0031A4E4
		public static Soar GetRootAsSoar(ByteBuffer _bb)
		{
			return Soar.GetRootAsSoar(_bb, default(Soar));
		}

		// Token: 0x0600D710 RID: 55056 RVA: 0x0031C300 File Offset: 0x0031A500
		public static Soar GetRootAsSoar(ByteBuffer _bb, Soar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D711 RID: 55057 RVA: 0x0031C31D File Offset: 0x0031A51D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D712 RID: 55058 RVA: 0x0031C32C File Offset: 0x0031A52C
		public Soar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700377E RID: 14206
		// (get) Token: 0x0600D713 RID: 55059 RVA: 0x0031C33C File Offset: 0x0031A53C
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D714 RID: 55060 RVA: 0x0031C373 File Offset: 0x0031A573
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600D715 RID: 55061 RVA: 0x0031C382 File Offset: 0x0031A582
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x1700377F RID: 14207
		// (get) Token: 0x0600D716 RID: 55062 RVA: 0x0031C39C File Offset: 0x0031A59C
		public string HangSocket
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

		// Token: 0x0600D717 RID: 55063 RVA: 0x0031C3D3 File Offset: 0x0031A5D3
		public Span<byte> GetHangSocketBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D718 RID: 55064 RVA: 0x0031C3E2 File Offset: 0x0031A5E2
		public byte[] GetHangSocketArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003780 RID: 14208
		// (get) Token: 0x0600D719 RID: 55065 RVA: 0x0031C3FC File Offset: 0x0031A5FC
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005207 RID: 20999
		private Table __p;
	}
}
