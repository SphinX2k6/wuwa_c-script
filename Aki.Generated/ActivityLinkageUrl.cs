using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BA0 RID: 2976
	public struct ActivityLinkageUrl : IFlatbufferObject
	{
		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060048C3 RID: 18627 RVA: 0x001EC278 File Offset: 0x001EA478
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060048C4 RID: 18628 RVA: 0x001EC285 File Offset: 0x001EA485
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060048C5 RID: 18629 RVA: 0x001EC28C File Offset: 0x001EA48C
		public static ActivityLinkageUrl GetRootAsActivityLinkageUrl(ByteBuffer _bb)
		{
			return ActivityLinkageUrl.GetRootAsActivityLinkageUrl(_bb, default(ActivityLinkageUrl));
		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x001EC2A8 File Offset: 0x001EA4A8
		public static ActivityLinkageUrl GetRootAsActivityLinkageUrl(ByteBuffer _bb, ActivityLinkageUrl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x001EC2C5 File Offset: 0x001EA4C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060048C8 RID: 18632 RVA: 0x001EC2D4 File Offset: 0x001EA4D4
		public ActivityLinkageUrl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060048C9 RID: 18633 RVA: 0x001EC2E4 File Offset: 0x001EA4E4
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

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060048CA RID: 18634 RVA: 0x001EC320 File Offset: 0x001EA520
		public int ActivityLinkageId
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

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060048CB RID: 18635 RVA: 0x001EC35C File Offset: 0x001EA55C
		public bool IsNational
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060048CC RID: 18636 RVA: 0x001EC39C File Offset: 0x001EA59C
		public bool IsInternalLink
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060048CD RID: 18637 RVA: 0x001EC3DC File Offset: 0x001EA5DC
		public bool IsNeedToken
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060048CE RID: 18638 RVA: 0x001EC41C File Offset: 0x001EA61C
		public string LinkUrl
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

		// Token: 0x060048CF RID: 18639 RVA: 0x001EC454 File Offset: 0x001EA654
		public Span<byte> GetLinkUrlBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060048D0 RID: 18640 RVA: 0x001EC464 File Offset: 0x001EA664
		public byte[] GetLinkUrlArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0400507D RID: 20605
		private Table __p;
	}
}
