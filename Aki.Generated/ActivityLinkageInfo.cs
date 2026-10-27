using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AC5 RID: 2757
	public struct ActivityLinkageInfo : IFlatbufferObject
	{
		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600436A RID: 17258 RVA: 0x001CC458 File Offset: 0x001CA658
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600436B RID: 17259 RVA: 0x001CC465 File Offset: 0x001CA665
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600436C RID: 17260 RVA: 0x001CC46C File Offset: 0x001CA66C
		public static ActivityLinkageInfo GetRootAsActivityLinkageInfo(ByteBuffer _bb)
		{
			return ActivityLinkageInfo.GetRootAsActivityLinkageInfo(_bb, default(ActivityLinkageInfo));
		}

		// Token: 0x0600436D RID: 17261 RVA: 0x001CC488 File Offset: 0x001CA688
		public static ActivityLinkageInfo GetRootAsActivityLinkageInfo(ByteBuffer _bb, ActivityLinkageInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600436E RID: 17262 RVA: 0x001CC4A5 File Offset: 0x001CA6A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600436F RID: 17263 RVA: 0x001CC4B4 File Offset: 0x001CA6B4
		public ActivityLinkageInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06004370 RID: 17264 RVA: 0x001CC4C4 File Offset: 0x001CA6C4
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

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06004371 RID: 17265 RVA: 0x001CC500 File Offset: 0x001CA700
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

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06004372 RID: 17266 RVA: 0x001CC53C File Offset: 0x001CA73C
		public int Language
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

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06004373 RID: 17267 RVA: 0x001CC578 File Offset: 0x001CA778
		public string BigImage
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

		// Token: 0x06004374 RID: 17268 RVA: 0x001CC5B0 File Offset: 0x001CA7B0
		public Span<byte> GetBigImageBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004375 RID: 17269 RVA: 0x001CC5C0 File Offset: 0x001CA7C0
		public byte[] GetBigImageArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06004376 RID: 17270 RVA: 0x001CC5D8 File Offset: 0x001CA7D8
		public string LinkUrl
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

		// Token: 0x06004377 RID: 17271 RVA: 0x001CC610 File Offset: 0x001CA810
		public Span<byte> GetLinkUrlBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004378 RID: 17272 RVA: 0x001CC620 File Offset: 0x001CA820
		public byte[] GetLinkUrlArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06004379 RID: 17273 RVA: 0x001CC638 File Offset: 0x001CA838
		public string QRCode
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

		// Token: 0x0600437A RID: 17274 RVA: 0x001CC670 File Offset: 0x001CA870
		public Span<byte> GetQRCodeBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600437B RID: 17275 RVA: 0x001CC680 File Offset: 0x001CA880
		public byte[] GetQRCodeArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AA2 RID: 19106
		private Table __p;
	}
}
