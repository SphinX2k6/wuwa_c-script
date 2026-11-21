using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F5C RID: 3932
	public struct MusicalInstrumentConfig : IFlatbufferObject
	{
		// Token: 0x1700231E RID: 8990
		// (get) Token: 0x0600A3CE RID: 41934 RVA: 0x002B81DF File Offset: 0x002B63DF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A3CF RID: 41935 RVA: 0x002B81EC File Offset: 0x002B63EC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A3D0 RID: 41936 RVA: 0x002B81F4 File Offset: 0x002B63F4
		public static MusicalInstrumentConfig GetRootAsMusicalInstrumentConfig(ByteBuffer _bb)
		{
			return MusicalInstrumentConfig.GetRootAsMusicalInstrumentConfig(_bb, default(MusicalInstrumentConfig));
		}

		// Token: 0x0600A3D1 RID: 41937 RVA: 0x002B8210 File Offset: 0x002B6410
		public static MusicalInstrumentConfig GetRootAsMusicalInstrumentConfig(ByteBuffer _bb, MusicalInstrumentConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A3D2 RID: 41938 RVA: 0x002B822D File Offset: 0x002B642D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A3D3 RID: 41939 RVA: 0x002B823C File Offset: 0x002B643C
		public MusicalInstrumentConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700231F RID: 8991
		// (get) Token: 0x0600A3D4 RID: 41940 RVA: 0x002B824C File Offset: 0x002B644C
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

		// Token: 0x17002320 RID: 8992
		// (get) Token: 0x0600A3D5 RID: 41941 RVA: 0x002B8288 File Offset: 0x002B6488
		public int InstrumentType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002321 RID: 8993
		// (get) Token: 0x0600A3D6 RID: 41942 RVA: 0x002B82C4 File Offset: 0x002B64C4
		public string KeyConfigs
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

		// Token: 0x0600A3D7 RID: 41943 RVA: 0x002B82FB File Offset: 0x002B64FB
		public Span<byte> GetKeyConfigsBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A3D8 RID: 41944 RVA: 0x002B830A File Offset: 0x002B650A
		public byte[] GetKeyConfigsArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400550A RID: 21770
		private Table __p;
	}
}
