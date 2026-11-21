using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C65 RID: 3173
	public struct ClueContent : IFlatbufferObject
	{
		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06005C0A RID: 23562 RVA: 0x00217960 File Offset: 0x00215B60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005C0B RID: 23563 RVA: 0x0021796D File Offset: 0x00215B6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005C0C RID: 23564 RVA: 0x00217974 File Offset: 0x00215B74
		public static ClueContent GetRootAsClueContent(ByteBuffer _bb)
		{
			return ClueContent.GetRootAsClueContent(_bb, default(ClueContent));
		}

		// Token: 0x06005C0D RID: 23565 RVA: 0x00217990 File Offset: 0x00215B90
		public static ClueContent GetRootAsClueContent(ByteBuffer _bb, ClueContent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005C0E RID: 23566 RVA: 0x002179AD File Offset: 0x00215BAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005C0F RID: 23567 RVA: 0x002179BC File Offset: 0x00215BBC
		public ClueContent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06005C10 RID: 23568 RVA: 0x002179CC File Offset: 0x00215BCC
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

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06005C11 RID: 23569 RVA: 0x00217A08 File Offset: 0x00215C08
		public int GroupId
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

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06005C12 RID: 23570 RVA: 0x00217A44 File Offset: 0x00215C44
		public string Texture
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

		// Token: 0x06005C13 RID: 23571 RVA: 0x00217A7B File Offset: 0x00215C7B
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005C14 RID: 23572 RVA: 0x00217A8A File Offset: 0x00215C8A
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06005C15 RID: 23573 RVA: 0x00217AA4 File Offset: 0x00215CA4
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

		// Token: 0x06005C16 RID: 23574 RVA: 0x00217ADC File Offset: 0x00215CDC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005C17 RID: 23575 RVA: 0x00217AEC File Offset: 0x00215CEC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005169 RID: 20841
		private Table __p;
	}
}
