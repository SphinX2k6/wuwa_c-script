using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F0A RID: 3850
	public struct PhotoFightReward : IFlatbufferObject
	{
		// Token: 0x170027DC RID: 10204
		// (get) Token: 0x0600ABBB RID: 43963 RVA: 0x002BA2ED File Offset: 0x002B84ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ABBC RID: 43964 RVA: 0x002BA2FA File Offset: 0x002B84FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ABBD RID: 43965 RVA: 0x002BA304 File Offset: 0x002B8504
		public static PhotoFightReward GetRootAsPhotoFightReward(ByteBuffer _bb)
		{
			return PhotoFightReward.GetRootAsPhotoFightReward(_bb, default(PhotoFightReward));
		}

		// Token: 0x0600ABBE RID: 43966 RVA: 0x002BA320 File Offset: 0x002B8520
		public static PhotoFightReward GetRootAsPhotoFightReward(ByteBuffer _bb, PhotoFightReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ABBF RID: 43967 RVA: 0x002BA33D File Offset: 0x002B853D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ABC0 RID: 43968 RVA: 0x002BA34C File Offset: 0x002B854C
		public PhotoFightReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170027DD RID: 10205
		// (get) Token: 0x0600ABC1 RID: 43969 RVA: 0x002BA35C File Offset: 0x002B855C
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

		// Token: 0x170027DE RID: 10206
		// (get) Token: 0x0600ABC2 RID: 43970 RVA: 0x002BA398 File Offset: 0x002B8598
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

		// Token: 0x170027DF RID: 10207
		// (get) Token: 0x0600ABC3 RID: 43971 RVA: 0x002BA3D4 File Offset: 0x002B85D4
		public int TabId
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

		// Token: 0x170027E0 RID: 10208
		// (get) Token: 0x0600ABC4 RID: 43972 RVA: 0x002BA410 File Offset: 0x002B8610
		public string Title
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

		// Token: 0x0600ABC5 RID: 43973 RVA: 0x002BA448 File Offset: 0x002B8648
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600ABC6 RID: 43974 RVA: 0x002BA458 File Offset: 0x002B8658
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170027E1 RID: 10209
		// (get) Token: 0x0600ABC7 RID: 43975 RVA: 0x002BA470 File Offset: 0x002B8670
		public int Target
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170027E2 RID: 10210
		// (get) Token: 0x0600ABC8 RID: 43976 RVA: 0x002BA4B0 File Offset: 0x002B86B0
		public int RewardId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004FD2 RID: 20434
		private Table __p;
	}
}
