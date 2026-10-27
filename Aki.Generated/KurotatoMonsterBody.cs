using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DAA RID: 3498
	public struct KurotatoMonsterBody : IFlatbufferObject
	{
		// Token: 0x17001BDE RID: 7134
		// (get) Token: 0x06008AD7 RID: 35543 RVA: 0x00270C78 File Offset: 0x0026EE78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008AD8 RID: 35544 RVA: 0x00270C85 File Offset: 0x0026EE85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008AD9 RID: 35545 RVA: 0x00270C8C File Offset: 0x0026EE8C
		public static KurotatoMonsterBody GetRootAsKurotatoMonsterBody(ByteBuffer _bb)
		{
			return KurotatoMonsterBody.GetRootAsKurotatoMonsterBody(_bb, default(KurotatoMonsterBody));
		}

		// Token: 0x06008ADA RID: 35546 RVA: 0x00270CA8 File Offset: 0x0026EEA8
		public static KurotatoMonsterBody GetRootAsKurotatoMonsterBody(ByteBuffer _bb, KurotatoMonsterBody obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008ADB RID: 35547 RVA: 0x00270CC5 File Offset: 0x0026EEC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008ADC RID: 35548 RVA: 0x00270CD4 File Offset: 0x0026EED4
		public KurotatoMonsterBody __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001BDF RID: 7135
		// (get) Token: 0x06008ADD RID: 35549 RVA: 0x00270CE4 File Offset: 0x0026EEE4
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

		// Token: 0x17001BE0 RID: 7136
		// (get) Token: 0x06008ADE RID: 35550 RVA: 0x00270D20 File Offset: 0x0026EF20
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

		// Token: 0x06008ADF RID: 35551 RVA: 0x00270D57 File Offset: 0x0026EF57
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008AE0 RID: 35552 RVA: 0x00270D66 File Offset: 0x0026EF66
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E3C RID: 20028
		private Table __p;
	}
}
