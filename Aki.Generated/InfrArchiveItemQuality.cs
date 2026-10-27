using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D61 RID: 3425
	public struct InfrArchiveItemQuality : IFlatbufferObject
	{
		// Token: 0x170018D8 RID: 6360
		// (get) Token: 0x06008310 RID: 33552 RVA: 0x0025E205 File Offset: 0x0025C405
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008311 RID: 33553 RVA: 0x0025E212 File Offset: 0x0025C412
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008312 RID: 33554 RVA: 0x0025E21C File Offset: 0x0025C41C
		public static InfrArchiveItemQuality GetRootAsInfrArchiveItemQuality(ByteBuffer _bb)
		{
			return InfrArchiveItemQuality.GetRootAsInfrArchiveItemQuality(_bb, default(InfrArchiveItemQuality));
		}

		// Token: 0x06008313 RID: 33555 RVA: 0x0025E238 File Offset: 0x0025C438
		public static InfrArchiveItemQuality GetRootAsInfrArchiveItemQuality(ByteBuffer _bb, InfrArchiveItemQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008314 RID: 33556 RVA: 0x0025E255 File Offset: 0x0025C455
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008315 RID: 33557 RVA: 0x0025E264 File Offset: 0x0025C464
		public InfrArchiveItemQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170018D9 RID: 6361
		// (get) Token: 0x06008316 RID: 33558 RVA: 0x0025E274 File Offset: 0x0025C474
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

		// Token: 0x170018DA RID: 6362
		// (get) Token: 0x06008317 RID: 33559 RVA: 0x0025E2B0 File Offset: 0x0025C4B0
		public string Path
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

		// Token: 0x06008318 RID: 33560 RVA: 0x0025E2E7 File Offset: 0x0025C4E7
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008319 RID: 33561 RVA: 0x0025E2F6 File Offset: 0x0025C4F6
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004DE0 RID: 19936
		private Table __p;
	}
}
