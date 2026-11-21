using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DF9 RID: 3577
	public struct GuideData : IFlatbufferObject
	{
		// Token: 0x170016A3 RID: 5795
		// (get) Token: 0x0600826A RID: 33386 RVA: 0x0026DEED File Offset: 0x0026C0ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600826B RID: 33387 RVA: 0x0026DEFA File Offset: 0x0026C0FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600826C RID: 33388 RVA: 0x0026DF04 File Offset: 0x0026C104
		public static GuideData GetRootAsGuideData(ByteBuffer _bb)
		{
			return GuideData.GetRootAsGuideData(_bb, default(GuideData));
		}

		// Token: 0x0600826D RID: 33389 RVA: 0x0026DF20 File Offset: 0x0026C120
		public static GuideData GetRootAsGuideData(ByteBuffer _bb, GuideData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600826E RID: 33390 RVA: 0x0026DF3D File Offset: 0x0026C13D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600826F RID: 33391 RVA: 0x0026DF4C File Offset: 0x0026C14C
		public GuideData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170016A4 RID: 5796
		// (get) Token: 0x06008270 RID: 33392 RVA: 0x0026DF5C File Offset: 0x0026C15C
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

		// Token: 0x170016A5 RID: 5797
		// (get) Token: 0x06008271 RID: 33393 RVA: 0x0026DF98 File Offset: 0x0026C198
		public string TitleText
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

		// Token: 0x06008272 RID: 33394 RVA: 0x0026DFCF File Offset: 0x0026C1CF
		public Span<byte> GetTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008273 RID: 33395 RVA: 0x0026DFDE File Offset: 0x0026C1DE
		public byte[] GetTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170016A6 RID: 5798
		// (get) Token: 0x06008274 RID: 33396 RVA: 0x0026DFF8 File Offset: 0x0026C1F8
		public string NoteText
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

		// Token: 0x06008275 RID: 33397 RVA: 0x0026E02F File Offset: 0x0026C22F
		public Span<byte> GetNoteTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008276 RID: 33398 RVA: 0x0026E03E File Offset: 0x0026C23E
		public byte[] GetNoteTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170016A7 RID: 5799
		// (get) Token: 0x06008277 RID: 33399 RVA: 0x0026E058 File Offset: 0x0026C258
		public string BgTexture
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

		// Token: 0x06008278 RID: 33400 RVA: 0x0026E090 File Offset: 0x0026C290
		public Span<byte> GetBgTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008279 RID: 33401 RVA: 0x0026E0A0 File Offset: 0x0026C2A0
		public byte[] GetBgTextureArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170016A8 RID: 5800
		// (get) Token: 0x0600827A RID: 33402 RVA: 0x0026E0B8 File Offset: 0x0026C2B8
		public string ChildViewName
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600827B RID: 33403 RVA: 0x0026E0F0 File Offset: 0x0026C2F0
		public Span<byte> GetChildViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600827C RID: 33404 RVA: 0x0026E100 File Offset: 0x0026C300
		public byte[] GetChildViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005371 RID: 21361
		private Table __p;
	}
}
