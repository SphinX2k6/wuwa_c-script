using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E46 RID: 3654
	public struct InfrArchiveItemQuality : IFlatbufferObject
	{
		// Token: 0x1700193B RID: 6459
		// (get) Token: 0x0600892A RID: 35114 RVA: 0x0027C8B5 File Offset: 0x0027AAB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600892B RID: 35115 RVA: 0x0027C8C2 File Offset: 0x0027AAC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600892C RID: 35116 RVA: 0x0027C8CC File Offset: 0x0027AACC
		public static InfrArchiveItemQuality GetRootAsInfrArchiveItemQuality(ByteBuffer _bb)
		{
			return InfrArchiveItemQuality.GetRootAsInfrArchiveItemQuality(_bb, default(InfrArchiveItemQuality));
		}

		// Token: 0x0600892D RID: 35117 RVA: 0x0027C8E8 File Offset: 0x0027AAE8
		public static InfrArchiveItemQuality GetRootAsInfrArchiveItemQuality(ByteBuffer _bb, InfrArchiveItemQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600892E RID: 35118 RVA: 0x0027C905 File Offset: 0x0027AB05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600892F RID: 35119 RVA: 0x0027C914 File Offset: 0x0027AB14
		public InfrArchiveItemQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700193C RID: 6460
		// (get) Token: 0x06008930 RID: 35120 RVA: 0x0027C924 File Offset: 0x0027AB24
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

		// Token: 0x1700193D RID: 6461
		// (get) Token: 0x06008931 RID: 35121 RVA: 0x0027C960 File Offset: 0x0027AB60
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

		// Token: 0x06008932 RID: 35122 RVA: 0x0027C997 File Offset: 0x0027AB97
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008933 RID: 35123 RVA: 0x0027C9A6 File Offset: 0x0027ABA6
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040053C5 RID: 21445
		private Table __p;
	}
}
