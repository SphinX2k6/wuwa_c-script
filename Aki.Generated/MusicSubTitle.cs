using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E7B RID: 3707
	public struct MusicSubTitle : IFlatbufferObject
	{
		// Token: 0x170022CC RID: 8908
		// (get) Token: 0x06009DEA RID: 40426 RVA: 0x0029B199 File Offset: 0x00299399
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009DEB RID: 40427 RVA: 0x0029B1A6 File Offset: 0x002993A6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009DEC RID: 40428 RVA: 0x0029B1B0 File Offset: 0x002993B0
		public static MusicSubTitle GetRootAsMusicSubTitle(ByteBuffer _bb)
		{
			return MusicSubTitle.GetRootAsMusicSubTitle(_bb, default(MusicSubTitle));
		}

		// Token: 0x06009DED RID: 40429 RVA: 0x0029B1CC File Offset: 0x002993CC
		public static MusicSubTitle GetRootAsMusicSubTitle(ByteBuffer _bb, MusicSubTitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009DEE RID: 40430 RVA: 0x0029B1E9 File Offset: 0x002993E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009DEF RID: 40431 RVA: 0x0029B1F8 File Offset: 0x002993F8
		public MusicSubTitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170022CD RID: 8909
		// (get) Token: 0x06009DF0 RID: 40432 RVA: 0x0029B208 File Offset: 0x00299408
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

		// Token: 0x170022CE RID: 8910
		// (get) Token: 0x06009DF1 RID: 40433 RVA: 0x0029B244 File Offset: 0x00299444
		public string SubtitleGroupTag
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

		// Token: 0x06009DF2 RID: 40434 RVA: 0x0029B27B File Offset: 0x0029947B
		public Span<byte> GetSubtitleGroupTagBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009DF3 RID: 40435 RVA: 0x0029B28A File Offset: 0x0029948A
		public byte[] GetSubtitleGroupTagArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170022CF RID: 8911
		// (get) Token: 0x06009DF4 RID: 40436 RVA: 0x0029B2A4 File Offset: 0x002994A4
		public float AppearTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170022D0 RID: 8912
		// (get) Token: 0x06009DF5 RID: 40437 RVA: 0x0029B2E4 File Offset: 0x002994E4
		public float EndTime
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004F29 RID: 20265
		private Table __p;
	}
}
