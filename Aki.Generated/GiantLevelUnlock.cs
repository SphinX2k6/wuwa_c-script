using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CFD RID: 3325
	public struct GiantLevelUnlock : IFlatbufferObject
	{
		// Token: 0x1700159B RID: 5531
		// (get) Token: 0x06007A87 RID: 31367 RVA: 0x0024B52C File Offset: 0x0024972C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007A88 RID: 31368 RVA: 0x0024B539 File Offset: 0x00249739
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007A89 RID: 31369 RVA: 0x0024B540 File Offset: 0x00249740
		public static GiantLevelUnlock GetRootAsGiantLevelUnlock(ByteBuffer _bb)
		{
			return GiantLevelUnlock.GetRootAsGiantLevelUnlock(_bb, default(GiantLevelUnlock));
		}

		// Token: 0x06007A8A RID: 31370 RVA: 0x0024B55C File Offset: 0x0024975C
		public static GiantLevelUnlock GetRootAsGiantLevelUnlock(ByteBuffer _bb, GiantLevelUnlock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007A8B RID: 31371 RVA: 0x0024B579 File Offset: 0x00249779
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007A8C RID: 31372 RVA: 0x0024B588 File Offset: 0x00249788
		public GiantLevelUnlock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x06007A8D RID: 31373 RVA: 0x0024B598 File Offset: 0x00249798
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

		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x06007A8E RID: 31374 RVA: 0x0024B5D4 File Offset: 0x002497D4
		public int EcoType
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

		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x06007A8F RID: 31375 RVA: 0x0024B610 File Offset: 0x00249810
		public int Level
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

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x06007A90 RID: 31376 RVA: 0x0024B64C File Offset: 0x0024984C
		public string PreUnlockDesc
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

		// Token: 0x06007A91 RID: 31377 RVA: 0x0024B684 File Offset: 0x00249884
		public Span<byte> GetPreUnlockDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007A92 RID: 31378 RVA: 0x0024B694 File Offset: 0x00249894
		public byte[] GetPreUnlockDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x06007A93 RID: 31379 RVA: 0x0024B6AC File Offset: 0x002498AC
		public string PostUnlockDesc1
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

		// Token: 0x06007A94 RID: 31380 RVA: 0x0024B6E4 File Offset: 0x002498E4
		public Span<byte> GetPostUnlockDesc1Bytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007A95 RID: 31381 RVA: 0x0024B6F4 File Offset: 0x002498F4
		public byte[] GetPostUnlockDesc1Array()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x06007A96 RID: 31382 RVA: 0x0024B70C File Offset: 0x0024990C
		public string PostUnlockDesc2
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

		// Token: 0x06007A97 RID: 31383 RVA: 0x0024B744 File Offset: 0x00249944
		public Span<byte> GetPostUnlockDesc2Bytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007A98 RID: 31384 RVA: 0x0024B754 File Offset: 0x00249954
		public byte[] GetPostUnlockDesc2Array()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x06007A99 RID: 31385 RVA: 0x0024B76C File Offset: 0x0024996C
		public string NodeUnlockDesc
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007A9A RID: 31386 RVA: 0x0024B7A4 File Offset: 0x002499A4
		public Span<byte> GetNodeUnlockDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007A9B RID: 31387 RVA: 0x0024B7B4 File Offset: 0x002499B4
		public byte[] GetNodeUnlockDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x06007A9C RID: 31388 RVA: 0x0024B7CC File Offset: 0x002499CC
		public int PicWeight
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

		// Token: 0x04004D71 RID: 19825
		private Table __p;
	}
}
