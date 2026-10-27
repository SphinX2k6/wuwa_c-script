using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F10 RID: 3856
	public struct PhotoMemoryActivity : IFlatbufferObject
	{
		// Token: 0x17002830 RID: 10288
		// (get) Token: 0x0600AC60 RID: 44128 RVA: 0x002BBCC5 File Offset: 0x002B9EC5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AC61 RID: 44129 RVA: 0x002BBCD2 File Offset: 0x002B9ED2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AC62 RID: 44130 RVA: 0x002BBCDC File Offset: 0x002B9EDC
		public static PhotoMemoryActivity GetRootAsPhotoMemoryActivity(ByteBuffer _bb)
		{
			return PhotoMemoryActivity.GetRootAsPhotoMemoryActivity(_bb, default(PhotoMemoryActivity));
		}

		// Token: 0x0600AC63 RID: 44131 RVA: 0x002BBCF8 File Offset: 0x002B9EF8
		public static PhotoMemoryActivity GetRootAsPhotoMemoryActivity(ByteBuffer _bb, PhotoMemoryActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AC64 RID: 44132 RVA: 0x002BBD15 File Offset: 0x002B9F15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AC65 RID: 44133 RVA: 0x002BBD24 File Offset: 0x002B9F24
		public PhotoMemoryActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002831 RID: 10289
		// (get) Token: 0x0600AC66 RID: 44134 RVA: 0x002BBD34 File Offset: 0x002B9F34
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

		// Token: 0x17002832 RID: 10290
		// (get) Token: 0x0600AC67 RID: 44135 RVA: 0x002BBD70 File Offset: 0x002B9F70
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

		// Token: 0x17002833 RID: 10291
		// (get) Token: 0x0600AC68 RID: 44136 RVA: 0x002BBDAC File Offset: 0x002B9FAC
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

		// Token: 0x0600AC69 RID: 44137 RVA: 0x002BBDE3 File Offset: 0x002B9FE3
		public Span<byte> GetGuideTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AC6A RID: 44138 RVA: 0x002BBDF2 File Offset: 0x002B9FF2
		public byte[] GetGuideTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002834 RID: 10292
		// (get) Token: 0x0600AC6B RID: 44139 RVA: 0x002BBE0C File Offset: 0x002BA00C
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

		// Token: 0x0600AC6C RID: 44140 RVA: 0x002BBE44 File Offset: 0x002BA044
		public Span<byte> GetViewJumpBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600AC6D RID: 44141 RVA: 0x002BBE54 File Offset: 0x002BA054
		public byte[] GetViewJumpArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004FD8 RID: 20440
		private Table __p;
	}
}
