using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AD0 RID: 2768
	public struct ActivityTitleTags : IFlatbufferObject
	{
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600442A RID: 17450 RVA: 0x001CDD41 File Offset: 0x001CBF41
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600442B RID: 17451 RVA: 0x001CDD4E File Offset: 0x001CBF4E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600442C RID: 17452 RVA: 0x001CDD58 File Offset: 0x001CBF58
		public static ActivityTitleTags GetRootAsActivityTitleTags(ByteBuffer _bb)
		{
			return ActivityTitleTags.GetRootAsActivityTitleTags(_bb, default(ActivityTitleTags));
		}

		// Token: 0x0600442D RID: 17453 RVA: 0x001CDD74 File Offset: 0x001CBF74
		public static ActivityTitleTags GetRootAsActivityTitleTags(ByteBuffer _bb, ActivityTitleTags obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600442E RID: 17454 RVA: 0x001CDD91 File Offset: 0x001CBF91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600442F RID: 17455 RVA: 0x001CDDA0 File Offset: 0x001CBFA0
		public ActivityTitleTags __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06004430 RID: 17456 RVA: 0x001CDDB0 File Offset: 0x001CBFB0
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

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06004431 RID: 17457 RVA: 0x001CDDEC File Offset: 0x001CBFEC
		public string TogIcon
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

		// Token: 0x06004432 RID: 17458 RVA: 0x001CDE23 File Offset: 0x001CC023
		public Span<byte> GetTogIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004433 RID: 17459 RVA: 0x001CDE32 File Offset: 0x001CC032
		public byte[] GetTogIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06004434 RID: 17460 RVA: 0x001CDE4C File Offset: 0x001CC04C
		public string TagIcon
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

		// Token: 0x06004435 RID: 17461 RVA: 0x001CDE83 File Offset: 0x001CC083
		public Span<byte> GetTagIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x001CDE92 File Offset: 0x001CC092
		public byte[] GetTagIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06004437 RID: 17463 RVA: 0x001CDEAC File Offset: 0x001CC0AC
		public string TagName
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

		// Token: 0x06004438 RID: 17464 RVA: 0x001CDEE4 File Offset: 0x001CC0E4
		public Span<byte> GetTagNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004439 RID: 17465 RVA: 0x001CDEF4 File Offset: 0x001CC0F4
		public byte[] GetTagNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600443A RID: 17466 RVA: 0x001CDF0C File Offset: 0x001CC10C
		public string DescInTip
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

		// Token: 0x0600443B RID: 17467 RVA: 0x001CDF44 File Offset: 0x001CC144
		public Span<byte> GetDescInTipBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600443C RID: 17468 RVA: 0x001CDF54 File Offset: 0x001CC154
		public byte[] GetDescInTipArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AAD RID: 19117
		private Table __p;
	}
}
