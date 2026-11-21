using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FF0 RID: 4080
	public struct PhotoFightRewardTab : IFlatbufferObject
	{
		// Token: 0x17002849 RID: 10313
		// (get) Token: 0x0600B1EA RID: 45546 RVA: 0x002D7199 File Offset: 0x002D5399
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B1EB RID: 45547 RVA: 0x002D71A6 File Offset: 0x002D53A6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B1EC RID: 45548 RVA: 0x002D71B0 File Offset: 0x002D53B0
		public static PhotoFightRewardTab GetRootAsPhotoFightRewardTab(ByteBuffer _bb)
		{
			return PhotoFightRewardTab.GetRootAsPhotoFightRewardTab(_bb, default(PhotoFightRewardTab));
		}

		// Token: 0x0600B1ED RID: 45549 RVA: 0x002D71CC File Offset: 0x002D53CC
		public static PhotoFightRewardTab GetRootAsPhotoFightRewardTab(ByteBuffer _bb, PhotoFightRewardTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B1EE RID: 45550 RVA: 0x002D71E9 File Offset: 0x002D53E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B1EF RID: 45551 RVA: 0x002D71F8 File Offset: 0x002D53F8
		public PhotoFightRewardTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700284A RID: 10314
		// (get) Token: 0x0600B1F0 RID: 45552 RVA: 0x002D7208 File Offset: 0x002D5408
		public int TabId
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

		// Token: 0x1700284B RID: 10315
		// (get) Token: 0x0600B1F1 RID: 45553 RVA: 0x002D7244 File Offset: 0x002D5444
		public int ActivityId
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

		// Token: 0x1700284C RID: 10316
		// (get) Token: 0x0600B1F2 RID: 45554 RVA: 0x002D7280 File Offset: 0x002D5480
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

		// Token: 0x0600B1F3 RID: 45555 RVA: 0x002D72B7 File Offset: 0x002D54B7
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B1F4 RID: 45556 RVA: 0x002D72C6 File Offset: 0x002D54C6
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700284D RID: 10317
		// (get) Token: 0x0600B1F5 RID: 45557 RVA: 0x002D72E0 File Offset: 0x002D54E0
		public string TabTitle
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

		// Token: 0x0600B1F6 RID: 45558 RVA: 0x002D7318 File Offset: 0x002D5518
		public Span<byte> GetTabTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B1F7 RID: 45559 RVA: 0x002D7328 File Offset: 0x002D5528
		public byte[] GetTabTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040055B8 RID: 21944
		private Table __p;
	}
}
