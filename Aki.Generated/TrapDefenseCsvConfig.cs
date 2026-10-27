using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200115F RID: 4447
	public struct TrapDefenseCsvConfig : IFlatbufferObject
	{
		// Token: 0x17003C16 RID: 15382
		// (get) Token: 0x0600E351 RID: 58193 RVA: 0x003380F9 File Offset: 0x003362F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E352 RID: 58194 RVA: 0x00338106 File Offset: 0x00336306
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E353 RID: 58195 RVA: 0x00338110 File Offset: 0x00336310
		public static TrapDefenseCsvConfig GetRootAsTrapDefenseCsvConfig(ByteBuffer _bb)
		{
			return TrapDefenseCsvConfig.GetRootAsTrapDefenseCsvConfig(_bb, default(TrapDefenseCsvConfig));
		}

		// Token: 0x0600E354 RID: 58196 RVA: 0x0033812C File Offset: 0x0033632C
		public static TrapDefenseCsvConfig GetRootAsTrapDefenseCsvConfig(ByteBuffer _bb, TrapDefenseCsvConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E355 RID: 58197 RVA: 0x00338149 File Offset: 0x00336349
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E356 RID: 58198 RVA: 0x00338158 File Offset: 0x00336358
		public TrapDefenseCsvConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C17 RID: 15383
		// (get) Token: 0x0600E357 RID: 58199 RVA: 0x00338168 File Offset: 0x00336368
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

		// Token: 0x17003C18 RID: 15384
		// (get) Token: 0x0600E358 RID: 58200 RVA: 0x003381A4 File Offset: 0x003363A4
		public string Batches
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

		// Token: 0x0600E359 RID: 58201 RVA: 0x003381DB File Offset: 0x003363DB
		public Span<byte> GetBatchesBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E35A RID: 58202 RVA: 0x003381EA File Offset: 0x003363EA
		public byte[] GetBatchesArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040052A4 RID: 21156
		private Table __p;
	}
}
