using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EC0 RID: 3776
	public struct LongShanStage : IFlatbufferObject
	{
		// Token: 0x17001DC1 RID: 7617
		// (get) Token: 0x06009590 RID: 38288 RVA: 0x002990BD File Offset: 0x002972BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009591 RID: 38289 RVA: 0x002990CA File Offset: 0x002972CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009592 RID: 38290 RVA: 0x002990D4 File Offset: 0x002972D4
		public static LongShanStage GetRootAsLongShanStage(ByteBuffer _bb)
		{
			return LongShanStage.GetRootAsLongShanStage(_bb, default(LongShanStage));
		}

		// Token: 0x06009593 RID: 38291 RVA: 0x002990F0 File Offset: 0x002972F0
		public static LongShanStage GetRootAsLongShanStage(ByteBuffer _bb, LongShanStage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009594 RID: 38292 RVA: 0x0029910D File Offset: 0x0029730D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009595 RID: 38293 RVA: 0x0029911C File Offset: 0x0029731C
		public LongShanStage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DC2 RID: 7618
		// (get) Token: 0x06009596 RID: 38294 RVA: 0x0029912C File Offset: 0x0029732C
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

		// Token: 0x17001DC3 RID: 7619
		// (get) Token: 0x06009597 RID: 38295 RVA: 0x00299168 File Offset: 0x00297368
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

		// Token: 0x17001DC4 RID: 7620
		// (get) Token: 0x06009598 RID: 38296 RVA: 0x002991A4 File Offset: 0x002973A4
		public string Title
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

		// Token: 0x06009599 RID: 38297 RVA: 0x002991DB File Offset: 0x002973DB
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600959A RID: 38298 RVA: 0x002991EA File Offset: 0x002973EA
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DC5 RID: 7621
		// (get) Token: 0x0600959B RID: 38299 RVA: 0x00299204 File Offset: 0x00297404
		public string TitleDetail
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

		// Token: 0x0600959C RID: 38300 RVA: 0x0029923C File Offset: 0x0029743C
		public Span<byte> GetTitleDetailBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600959D RID: 38301 RVA: 0x0029924C File Offset: 0x0029744C
		public byte[] GetTitleDetailArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DC6 RID: 7622
		// (get) Token: 0x0600959E RID: 38302 RVA: 0x00299264 File Offset: 0x00297464
		public int OpenConditionId
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

		// Token: 0x17001DC7 RID: 7623
		// (get) Token: 0x0600959F RID: 38303 RVA: 0x002992A4 File Offset: 0x002974A4
		public int QuestionId
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

		// Token: 0x17001DC8 RID: 7624
		// (get) Token: 0x060095A0 RID: 38304 RVA: 0x002992E4 File Offset: 0x002974E4
		public string Picture
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

		// Token: 0x060095A1 RID: 38305 RVA: 0x0029931C File Offset: 0x0029751C
		public Span<byte> GetPictureBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060095A2 RID: 38306 RVA: 0x0029932C File Offset: 0x0029752C
		public byte[] GetPictureArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DC9 RID: 7625
		// (get) Token: 0x060095A3 RID: 38307 RVA: 0x00299344 File Offset: 0x00297544
		public string RomeNumSprite
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060095A4 RID: 38308 RVA: 0x0029937C File Offset: 0x0029757C
		public Span<byte> GetRomeNumSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060095A5 RID: 38309 RVA: 0x0029938C File Offset: 0x0029758C
		public byte[] GetRomeNumSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DCA RID: 7626
		// (get) Token: 0x060095A6 RID: 38310 RVA: 0x002993A4 File Offset: 0x002975A4
		public int JumpId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400545B RID: 21595
		private Table __p;
	}
}
