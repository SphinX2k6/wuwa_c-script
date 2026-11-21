using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BBC RID: 3004
	public struct AdviceParams : IFlatbufferObject
	{
		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06004B37 RID: 19255 RVA: 0x001F1249 File Offset: 0x001EF449
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004B38 RID: 19256 RVA: 0x001F1256 File Offset: 0x001EF456
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004B39 RID: 19257 RVA: 0x001F1260 File Offset: 0x001EF460
		public static AdviceParams GetRootAsAdviceParams(ByteBuffer _bb)
		{
			return AdviceParams.GetRootAsAdviceParams(_bb, default(AdviceParams));
		}

		// Token: 0x06004B3A RID: 19258 RVA: 0x001F127C File Offset: 0x001EF47C
		public static AdviceParams GetRootAsAdviceParams(ByteBuffer _bb, AdviceParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004B3B RID: 19259 RVA: 0x001F1299 File Offset: 0x001EF499
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004B3C RID: 19260 RVA: 0x001F12A8 File Offset: 0x001EF4A8
		public AdviceParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06004B3D RID: 19261 RVA: 0x001F12B8 File Offset: 0x001EF4B8
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

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06004B3E RID: 19262 RVA: 0x001F12F4 File Offset: 0x001EF4F4
		public string Title
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

		// Token: 0x06004B3F RID: 19263 RVA: 0x001F132B File Offset: 0x001EF52B
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004B40 RID: 19264 RVA: 0x001F133A File Offset: 0x001EF53A
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06004B41 RID: 19265 RVA: 0x001F1354 File Offset: 0x001EF554
		public string Content
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

		// Token: 0x06004B42 RID: 19266 RVA: 0x001F138B File Offset: 0x001EF58B
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004B43 RID: 19267 RVA: 0x001F139A File Offset: 0x001EF59A
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06004B44 RID: 19268 RVA: 0x001F13B4 File Offset: 0x001EF5B4
		public string MotionImg
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

		// Token: 0x06004B45 RID: 19269 RVA: 0x001F13EC File Offset: 0x001EF5EC
		public Span<byte> GetMotionImgBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004B46 RID: 19270 RVA: 0x001F13FC File Offset: 0x001EF5FC
		public byte[] GetMotionImgArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0400509C RID: 20636
		private Table __p;
	}
}
