using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D14 RID: 3348
	public struct GuideData : IFlatbufferObject
	{
		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x06007C52 RID: 31826 RVA: 0x0024F4CD File Offset: 0x0024D6CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007C53 RID: 31827 RVA: 0x0024F4DA File Offset: 0x0024D6DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007C54 RID: 31828 RVA: 0x0024F4E4 File Offset: 0x0024D6E4
		public static GuideData GetRootAsGuideData(ByteBuffer _bb)
		{
			return GuideData.GetRootAsGuideData(_bb, default(GuideData));
		}

		// Token: 0x06007C55 RID: 31829 RVA: 0x0024F500 File Offset: 0x0024D700
		public static GuideData GetRootAsGuideData(ByteBuffer _bb, GuideData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007C56 RID: 31830 RVA: 0x0024F51D File Offset: 0x0024D71D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007C57 RID: 31831 RVA: 0x0024F52C File Offset: 0x0024D72C
		public GuideData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x06007C58 RID: 31832 RVA: 0x0024F53C File Offset: 0x0024D73C
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

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x06007C59 RID: 31833 RVA: 0x0024F578 File Offset: 0x0024D778
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

		// Token: 0x06007C5A RID: 31834 RVA: 0x0024F5AF File Offset: 0x0024D7AF
		public Span<byte> GetTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007C5B RID: 31835 RVA: 0x0024F5BE File Offset: 0x0024D7BE
		public byte[] GetTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x06007C5C RID: 31836 RVA: 0x0024F5D8 File Offset: 0x0024D7D8
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

		// Token: 0x06007C5D RID: 31837 RVA: 0x0024F60F File Offset: 0x0024D80F
		public Span<byte> GetNoteTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007C5E RID: 31838 RVA: 0x0024F61E File Offset: 0x0024D81E
		public byte[] GetNoteTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x06007C5F RID: 31839 RVA: 0x0024F638 File Offset: 0x0024D838
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

		// Token: 0x06007C60 RID: 31840 RVA: 0x0024F670 File Offset: 0x0024D870
		public Span<byte> GetBgTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007C61 RID: 31841 RVA: 0x0024F680 File Offset: 0x0024D880
		public byte[] GetBgTextureArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x06007C62 RID: 31842 RVA: 0x0024F698 File Offset: 0x0024D898
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

		// Token: 0x06007C63 RID: 31843 RVA: 0x0024F6D0 File Offset: 0x0024D8D0
		public Span<byte> GetChildViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007C64 RID: 31844 RVA: 0x0024F6E0 File Offset: 0x0024D8E0
		public byte[] GetChildViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D8C RID: 19852
		private Table __p;
	}
}
