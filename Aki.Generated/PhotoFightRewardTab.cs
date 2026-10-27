using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F0B RID: 3851
	public struct PhotoFightRewardTab : IFlatbufferObject
	{
		// Token: 0x170027E3 RID: 10211
		// (get) Token: 0x0600ABC9 RID: 43977 RVA: 0x002BA4ED File Offset: 0x002B86ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ABCA RID: 43978 RVA: 0x002BA4FA File Offset: 0x002B86FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ABCB RID: 43979 RVA: 0x002BA504 File Offset: 0x002B8704
		public static PhotoFightRewardTab GetRootAsPhotoFightRewardTab(ByteBuffer _bb)
		{
			return PhotoFightRewardTab.GetRootAsPhotoFightRewardTab(_bb, default(PhotoFightRewardTab));
		}

		// Token: 0x0600ABCC RID: 43980 RVA: 0x002BA520 File Offset: 0x002B8720
		public static PhotoFightRewardTab GetRootAsPhotoFightRewardTab(ByteBuffer _bb, PhotoFightRewardTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ABCD RID: 43981 RVA: 0x002BA53D File Offset: 0x002B873D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ABCE RID: 43982 RVA: 0x002BA54C File Offset: 0x002B874C
		public PhotoFightRewardTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170027E4 RID: 10212
		// (get) Token: 0x0600ABCF RID: 43983 RVA: 0x002BA55C File Offset: 0x002B875C
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

		// Token: 0x170027E5 RID: 10213
		// (get) Token: 0x0600ABD0 RID: 43984 RVA: 0x002BA598 File Offset: 0x002B8798
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

		// Token: 0x170027E6 RID: 10214
		// (get) Token: 0x0600ABD1 RID: 43985 RVA: 0x002BA5D4 File Offset: 0x002B87D4
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

		// Token: 0x0600ABD2 RID: 43986 RVA: 0x002BA60B File Offset: 0x002B880B
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600ABD3 RID: 43987 RVA: 0x002BA61A File Offset: 0x002B881A
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170027E7 RID: 10215
		// (get) Token: 0x0600ABD4 RID: 43988 RVA: 0x002BA634 File Offset: 0x002B8834
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

		// Token: 0x0600ABD5 RID: 43989 RVA: 0x002BA66C File Offset: 0x002B886C
		public Span<byte> GetTabTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600ABD6 RID: 43990 RVA: 0x002BA67C File Offset: 0x002B887C
		public byte[] GetTabTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004FD3 RID: 20435
		private Table __p;
	}
}
