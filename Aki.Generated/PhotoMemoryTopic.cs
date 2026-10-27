using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F12 RID: 3858
	public struct PhotoMemoryTopic : IFlatbufferObject
	{
		// Token: 0x17002847 RID: 10311
		// (get) Token: 0x0600AC96 RID: 44182 RVA: 0x002BC459 File Offset: 0x002BA659
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AC97 RID: 44183 RVA: 0x002BC466 File Offset: 0x002BA666
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AC98 RID: 44184 RVA: 0x002BC470 File Offset: 0x002BA670
		public static PhotoMemoryTopic GetRootAsPhotoMemoryTopic(ByteBuffer _bb)
		{
			return PhotoMemoryTopic.GetRootAsPhotoMemoryTopic(_bb, default(PhotoMemoryTopic));
		}

		// Token: 0x0600AC99 RID: 44185 RVA: 0x002BC48C File Offset: 0x002BA68C
		public static PhotoMemoryTopic GetRootAsPhotoMemoryTopic(ByteBuffer _bb, PhotoMemoryTopic obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AC9A RID: 44186 RVA: 0x002BC4A9 File Offset: 0x002BA6A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AC9B RID: 44187 RVA: 0x002BC4B8 File Offset: 0x002BA6B8
		public PhotoMemoryTopic __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002848 RID: 10312
		// (get) Token: 0x0600AC9C RID: 44188 RVA: 0x002BC4C8 File Offset: 0x002BA6C8
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

		// Token: 0x17002849 RID: 10313
		// (get) Token: 0x0600AC9D RID: 44189 RVA: 0x002BC504 File Offset: 0x002BA704
		public int Rank
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

		// Token: 0x1700284A RID: 10314
		// (get) Token: 0x0600AC9E RID: 44190 RVA: 0x002BC540 File Offset: 0x002BA740
		public string BgResourceLight
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

		// Token: 0x0600AC9F RID: 44191 RVA: 0x002BC577 File Offset: 0x002BA777
		public Span<byte> GetBgResourceLightBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600ACA0 RID: 44192 RVA: 0x002BC586 File Offset: 0x002BA786
		public byte[] GetBgResourceLightArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700284B RID: 10315
		// (get) Token: 0x0600ACA1 RID: 44193 RVA: 0x002BC5A0 File Offset: 0x002BA7A0
		public string BgResource
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

		// Token: 0x0600ACA2 RID: 44194 RVA: 0x002BC5D8 File Offset: 0x002BA7D8
		public Span<byte> GetBgResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600ACA3 RID: 44195 RVA: 0x002BC5E8 File Offset: 0x002BA7E8
		public byte[] GetBgResourceArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700284C RID: 10316
		// (get) Token: 0x0600ACA4 RID: 44196 RVA: 0x002BC600 File Offset: 0x002BA800
		public string TopicTexture
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

		// Token: 0x0600ACA5 RID: 44197 RVA: 0x002BC638 File Offset: 0x002BA838
		public Span<byte> GetTopicTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600ACA6 RID: 44198 RVA: 0x002BC648 File Offset: 0x002BA848
		public byte[] GetTopicTextureArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700284D RID: 10317
		// (get) Token: 0x0600ACA7 RID: 44199 RVA: 0x002BC660 File Offset: 0x002BA860
		public string Title
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ACA8 RID: 44200 RVA: 0x002BC698 File Offset: 0x002BA898
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600ACA9 RID: 44201 RVA: 0x002BC6A8 File Offset: 0x002BA8A8
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700284E RID: 10318
		// (get) Token: 0x0600ACAA RID: 44202 RVA: 0x002BC6C0 File Offset: 0x002BA8C0
		public int ClueId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700284F RID: 10319
		// (get) Token: 0x0600ACAB RID: 44203 RVA: 0x002BC700 File Offset: 0x002BA900
		public int ConditionGroupId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004FDA RID: 20442
		private Table __p;
	}
}
