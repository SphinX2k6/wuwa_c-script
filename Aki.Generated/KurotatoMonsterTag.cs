using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DAC RID: 3500
	public struct KurotatoMonsterTag : IFlatbufferObject
	{
		// Token: 0x17001BE7 RID: 7143
		// (get) Token: 0x06008AF4 RID: 35572 RVA: 0x00270FA8 File Offset: 0x0026F1A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008AF5 RID: 35573 RVA: 0x00270FB5 File Offset: 0x0026F1B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008AF6 RID: 35574 RVA: 0x00270FBC File Offset: 0x0026F1BC
		public static KurotatoMonsterTag GetRootAsKurotatoMonsterTag(ByteBuffer _bb)
		{
			return KurotatoMonsterTag.GetRootAsKurotatoMonsterTag(_bb, default(KurotatoMonsterTag));
		}

		// Token: 0x06008AF7 RID: 35575 RVA: 0x00270FD8 File Offset: 0x0026F1D8
		public static KurotatoMonsterTag GetRootAsKurotatoMonsterTag(ByteBuffer _bb, KurotatoMonsterTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008AF8 RID: 35576 RVA: 0x00270FF5 File Offset: 0x0026F1F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008AF9 RID: 35577 RVA: 0x00271004 File Offset: 0x0026F204
		public KurotatoMonsterTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001BE8 RID: 7144
		// (get) Token: 0x06008AFA RID: 35578 RVA: 0x00271014 File Offset: 0x0026F214
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

		// Token: 0x17001BE9 RID: 7145
		// (get) Token: 0x06008AFB RID: 35579 RVA: 0x00271050 File Offset: 0x0026F250
		public string Icon
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

		// Token: 0x06008AFC RID: 35580 RVA: 0x00271087 File Offset: 0x0026F287
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008AFD RID: 35581 RVA: 0x00271096 File Offset: 0x0026F296
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BEA RID: 7146
		// (get) Token: 0x06008AFE RID: 35582 RVA: 0x002710B0 File Offset: 0x0026F2B0
		public string Name
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

		// Token: 0x06008AFF RID: 35583 RVA: 0x002710E7 File Offset: 0x0026F2E7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008B00 RID: 35584 RVA: 0x002710F6 File Offset: 0x0026F2F6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BEB RID: 7147
		// (get) Token: 0x06008B01 RID: 35585 RVA: 0x00271110 File Offset: 0x0026F310
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008B02 RID: 35586 RVA: 0x00271148 File Offset: 0x0026F348
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008B03 RID: 35587 RVA: 0x00271158 File Offset: 0x0026F358
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E3E RID: 20030
		private Table __p;
	}
}
