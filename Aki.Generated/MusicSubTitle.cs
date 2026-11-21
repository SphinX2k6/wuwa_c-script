using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F60 RID: 3936
	public struct MusicSubTitle : IFlatbufferObject
	{
		// Token: 0x17002331 RID: 9009
		// (get) Token: 0x0600A40A RID: 41994 RVA: 0x002B88AD File Offset: 0x002B6AAD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A40B RID: 41995 RVA: 0x002B88BA File Offset: 0x002B6ABA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A40C RID: 41996 RVA: 0x002B88C4 File Offset: 0x002B6AC4
		public static MusicSubTitle GetRootAsMusicSubTitle(ByteBuffer _bb)
		{
			return MusicSubTitle.GetRootAsMusicSubTitle(_bb, default(MusicSubTitle));
		}

		// Token: 0x0600A40D RID: 41997 RVA: 0x002B88E0 File Offset: 0x002B6AE0
		public static MusicSubTitle GetRootAsMusicSubTitle(ByteBuffer _bb, MusicSubTitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A40E RID: 41998 RVA: 0x002B88FD File Offset: 0x002B6AFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A40F RID: 41999 RVA: 0x002B890C File Offset: 0x002B6B0C
		public MusicSubTitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002332 RID: 9010
		// (get) Token: 0x0600A410 RID: 42000 RVA: 0x002B891C File Offset: 0x002B6B1C
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

		// Token: 0x17002333 RID: 9011
		// (get) Token: 0x0600A411 RID: 42001 RVA: 0x002B8958 File Offset: 0x002B6B58
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

		// Token: 0x0600A412 RID: 42002 RVA: 0x002B898F File Offset: 0x002B6B8F
		public Span<byte> GetSubtitleGroupTagBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A413 RID: 42003 RVA: 0x002B899E File Offset: 0x002B6B9E
		public byte[] GetSubtitleGroupTagArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002334 RID: 9012
		// (get) Token: 0x0600A414 RID: 42004 RVA: 0x002B89B8 File Offset: 0x002B6BB8
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

		// Token: 0x17002335 RID: 9013
		// (get) Token: 0x0600A415 RID: 42005 RVA: 0x002B89F8 File Offset: 0x002B6BF8
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

		// Token: 0x0400550E RID: 21774
		private Table __p;
	}
}
