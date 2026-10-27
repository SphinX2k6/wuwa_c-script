using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AC6 RID: 2758
	public struct ActivityLinkageUrl : IFlatbufferObject
	{
		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600437C RID: 17276 RVA: 0x001CC698 File Offset: 0x001CA898
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600437D RID: 17277 RVA: 0x001CC6A5 File Offset: 0x001CA8A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600437E RID: 17278 RVA: 0x001CC6AC File Offset: 0x001CA8AC
		public static ActivityLinkageUrl GetRootAsActivityLinkageUrl(ByteBuffer _bb)
		{
			return ActivityLinkageUrl.GetRootAsActivityLinkageUrl(_bb, default(ActivityLinkageUrl));
		}

		// Token: 0x0600437F RID: 17279 RVA: 0x001CC6C8 File Offset: 0x001CA8C8
		public static ActivityLinkageUrl GetRootAsActivityLinkageUrl(ByteBuffer _bb, ActivityLinkageUrl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004380 RID: 17280 RVA: 0x001CC6E5 File Offset: 0x001CA8E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004381 RID: 17281 RVA: 0x001CC6F4 File Offset: 0x001CA8F4
		public ActivityLinkageUrl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06004382 RID: 17282 RVA: 0x001CC704 File Offset: 0x001CA904
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

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06004383 RID: 17283 RVA: 0x001CC740 File Offset: 0x001CA940
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

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06004384 RID: 17284 RVA: 0x001CC77C File Offset: 0x001CA97C
		public bool IsNational
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06004385 RID: 17285 RVA: 0x001CC7BC File Offset: 0x001CA9BC
		public bool IsInternalLink
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06004386 RID: 17286 RVA: 0x001CC7FC File Offset: 0x001CA9FC
		public bool IsNeedToken
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06004387 RID: 17287 RVA: 0x001CC83C File Offset: 0x001CAA3C
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

		// Token: 0x06004388 RID: 17288 RVA: 0x001CC874 File Offset: 0x001CAA74
		public Span<byte> GetLinkUrlBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x001CC884 File Offset: 0x001CAA84
		public byte[] GetLinkUrlArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AA3 RID: 19107
		private Table __p;
	}
}
