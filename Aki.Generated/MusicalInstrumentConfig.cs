using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E77 RID: 3703
	public struct MusicalInstrumentConfig : IFlatbufferObject
	{
		// Token: 0x170022B9 RID: 8889
		// (get) Token: 0x06009DAE RID: 40366 RVA: 0x0029AAAD File Offset: 0x00298CAD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009DAF RID: 40367 RVA: 0x0029AABA File Offset: 0x00298CBA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009DB0 RID: 40368 RVA: 0x0029AAC4 File Offset: 0x00298CC4
		public static MusicalInstrumentConfig GetRootAsMusicalInstrumentConfig(ByteBuffer _bb)
		{
			return MusicalInstrumentConfig.GetRootAsMusicalInstrumentConfig(_bb, default(MusicalInstrumentConfig));
		}

		// Token: 0x06009DB1 RID: 40369 RVA: 0x0029AAE0 File Offset: 0x00298CE0
		public static MusicalInstrumentConfig GetRootAsMusicalInstrumentConfig(ByteBuffer _bb, MusicalInstrumentConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009DB2 RID: 40370 RVA: 0x0029AAFD File Offset: 0x00298CFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009DB3 RID: 40371 RVA: 0x0029AB0C File Offset: 0x00298D0C
		public MusicalInstrumentConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170022BA RID: 8890
		// (get) Token: 0x06009DB4 RID: 40372 RVA: 0x0029AB1C File Offset: 0x00298D1C
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

		// Token: 0x170022BB RID: 8891
		// (get) Token: 0x06009DB5 RID: 40373 RVA: 0x0029AB58 File Offset: 0x00298D58
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

		// Token: 0x170022BC RID: 8892
		// (get) Token: 0x06009DB6 RID: 40374 RVA: 0x0029AB94 File Offset: 0x00298D94
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

		// Token: 0x06009DB7 RID: 40375 RVA: 0x0029ABCB File Offset: 0x00298DCB
		public Span<byte> GetKeyConfigsBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009DB8 RID: 40376 RVA: 0x0029ABDA File Offset: 0x00298DDA
		public byte[] GetKeyConfigsArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F25 RID: 20261
		private Table __p;
	}
}
