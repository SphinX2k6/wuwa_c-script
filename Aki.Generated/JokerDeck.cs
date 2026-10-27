using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D86 RID: 3462
	public struct JokerDeck : IFlatbufferObject
	{
		// Token: 0x17001A43 RID: 6723
		// (get) Token: 0x06008707 RID: 34567 RVA: 0x00267840 File Offset: 0x00265A40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008708 RID: 34568 RVA: 0x0026784D File Offset: 0x00265A4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008709 RID: 34569 RVA: 0x00267854 File Offset: 0x00265A54
		public static JokerDeck GetRootAsJokerDeck(ByteBuffer _bb)
		{
			return JokerDeck.GetRootAsJokerDeck(_bb, default(JokerDeck));
		}

		// Token: 0x0600870A RID: 34570 RVA: 0x00267870 File Offset: 0x00265A70
		public static JokerDeck GetRootAsJokerDeck(ByteBuffer _bb, JokerDeck obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600870B RID: 34571 RVA: 0x0026788D File Offset: 0x00265A8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600870C RID: 34572 RVA: 0x0026789C File Offset: 0x00265A9C
		public JokerDeck __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A44 RID: 6724
		// (get) Token: 0x0600870D RID: 34573 RVA: 0x002678AC File Offset: 0x00265AAC
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

		// Token: 0x17001A45 RID: 6725
		// (get) Token: 0x0600870E RID: 34574 RVA: 0x002678E8 File Offset: 0x00265AE8
		public int CardType
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

		// Token: 0x17001A46 RID: 6726
		// (get) Token: 0x0600870F RID: 34575 RVA: 0x00267924 File Offset: 0x00265B24
		public int CardNumber
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x06008710 RID: 34576 RVA: 0x00267960 File Offset: 0x00265B60
		public string TexturePath
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

		// Token: 0x06008711 RID: 34577 RVA: 0x00267998 File Offset: 0x00265B98
		public Span<byte> GetTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008712 RID: 34578 RVA: 0x002679A8 File Offset: 0x00265BA8
		public byte[] GetTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E12 RID: 19986
		private Table __p;
	}
}
