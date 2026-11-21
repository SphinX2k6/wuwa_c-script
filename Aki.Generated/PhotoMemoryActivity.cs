using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FF5 RID: 4085
	public struct PhotoMemoryActivity : IFlatbufferObject
	{
		// Token: 0x17002896 RID: 10390
		// (get) Token: 0x0600B281 RID: 45697 RVA: 0x002D8955 File Offset: 0x002D6B55
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B282 RID: 45698 RVA: 0x002D8962 File Offset: 0x002D6B62
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B283 RID: 45699 RVA: 0x002D896C File Offset: 0x002D6B6C
		public static PhotoMemoryActivity GetRootAsPhotoMemoryActivity(ByteBuffer _bb)
		{
			return PhotoMemoryActivity.GetRootAsPhotoMemoryActivity(_bb, default(PhotoMemoryActivity));
		}

		// Token: 0x0600B284 RID: 45700 RVA: 0x002D8988 File Offset: 0x002D6B88
		public static PhotoMemoryActivity GetRootAsPhotoMemoryActivity(ByteBuffer _bb, PhotoMemoryActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B285 RID: 45701 RVA: 0x002D89A5 File Offset: 0x002D6BA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B286 RID: 45702 RVA: 0x002D89B4 File Offset: 0x002D6BB4
		public PhotoMemoryActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002897 RID: 10391
		// (get) Token: 0x0600B287 RID: 45703 RVA: 0x002D89C4 File Offset: 0x002D6BC4
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

		// Token: 0x17002898 RID: 10392
		// (get) Token: 0x0600B288 RID: 45704 RVA: 0x002D8A00 File Offset: 0x002D6C00
		public int TopicId
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

		// Token: 0x17002899 RID: 10393
		// (get) Token: 0x0600B289 RID: 45705 RVA: 0x002D8A3C File Offset: 0x002D6C3C
		public string GuideText
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

		// Token: 0x0600B28A RID: 45706 RVA: 0x002D8A73 File Offset: 0x002D6C73
		public Span<byte> GetGuideTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B28B RID: 45707 RVA: 0x002D8A82 File Offset: 0x002D6C82
		public byte[] GetGuideTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700289A RID: 10394
		// (get) Token: 0x0600B28C RID: 45708 RVA: 0x002D8A9C File Offset: 0x002D6C9C
		public string ViewJump
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

		// Token: 0x0600B28D RID: 45709 RVA: 0x002D8AD4 File Offset: 0x002D6CD4
		public Span<byte> GetViewJumpBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B28E RID: 45710 RVA: 0x002D8AE4 File Offset: 0x002D6CE4
		public byte[] GetViewJumpArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040055BD RID: 21949
		private Table __p;
	}
}
