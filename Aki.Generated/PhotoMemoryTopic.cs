using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FF7 RID: 4087
	public struct PhotoMemoryTopic : IFlatbufferObject
	{
		// Token: 0x170028AD RID: 10413
		// (get) Token: 0x0600B2B7 RID: 45751 RVA: 0x002D90CD File Offset: 0x002D72CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B2B8 RID: 45752 RVA: 0x002D90DA File Offset: 0x002D72DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B2B9 RID: 45753 RVA: 0x002D90E4 File Offset: 0x002D72E4
		public static PhotoMemoryTopic GetRootAsPhotoMemoryTopic(ByteBuffer _bb)
		{
			return PhotoMemoryTopic.GetRootAsPhotoMemoryTopic(_bb, default(PhotoMemoryTopic));
		}

		// Token: 0x0600B2BA RID: 45754 RVA: 0x002D9100 File Offset: 0x002D7300
		public static PhotoMemoryTopic GetRootAsPhotoMemoryTopic(ByteBuffer _bb, PhotoMemoryTopic obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B2BB RID: 45755 RVA: 0x002D911D File Offset: 0x002D731D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B2BC RID: 45756 RVA: 0x002D912C File Offset: 0x002D732C
		public PhotoMemoryTopic __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170028AE RID: 10414
		// (get) Token: 0x0600B2BD RID: 45757 RVA: 0x002D913C File Offset: 0x002D733C
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

		// Token: 0x170028AF RID: 10415
		// (get) Token: 0x0600B2BE RID: 45758 RVA: 0x002D9178 File Offset: 0x002D7378
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

		// Token: 0x170028B0 RID: 10416
		// (get) Token: 0x0600B2BF RID: 45759 RVA: 0x002D91B4 File Offset: 0x002D73B4
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

		// Token: 0x0600B2C0 RID: 45760 RVA: 0x002D91EB File Offset: 0x002D73EB
		public Span<byte> GetBgResourceLightBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B2C1 RID: 45761 RVA: 0x002D91FA File Offset: 0x002D73FA
		public byte[] GetBgResourceLightArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170028B1 RID: 10417
		// (get) Token: 0x0600B2C2 RID: 45762 RVA: 0x002D9214 File Offset: 0x002D7414
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

		// Token: 0x0600B2C3 RID: 45763 RVA: 0x002D924C File Offset: 0x002D744C
		public Span<byte> GetBgResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B2C4 RID: 45764 RVA: 0x002D925C File Offset: 0x002D745C
		public byte[] GetBgResourceArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170028B2 RID: 10418
		// (get) Token: 0x0600B2C5 RID: 45765 RVA: 0x002D9274 File Offset: 0x002D7474
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

		// Token: 0x0600B2C6 RID: 45766 RVA: 0x002D92AC File Offset: 0x002D74AC
		public Span<byte> GetTopicTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B2C7 RID: 45767 RVA: 0x002D92BC File Offset: 0x002D74BC
		public byte[] GetTopicTextureArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170028B3 RID: 10419
		// (get) Token: 0x0600B2C8 RID: 45768 RVA: 0x002D92D4 File Offset: 0x002D74D4
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

		// Token: 0x0600B2C9 RID: 45769 RVA: 0x002D930C File Offset: 0x002D750C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B2CA RID: 45770 RVA: 0x002D931C File Offset: 0x002D751C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170028B4 RID: 10420
		// (get) Token: 0x0600B2CB RID: 45771 RVA: 0x002D9334 File Offset: 0x002D7534
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

		// Token: 0x170028B5 RID: 10421
		// (get) Token: 0x0600B2CC RID: 45772 RVA: 0x002D9374 File Offset: 0x002D7574
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

		// Token: 0x040055BF RID: 21951
		private Table __p;
	}
}
