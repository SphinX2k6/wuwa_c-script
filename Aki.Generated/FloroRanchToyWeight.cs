using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DA1 RID: 3489
	public struct FloroRanchToyWeight : IFlatbufferObject
	{
		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x06007B22 RID: 31522 RVA: 0x0025E196 File Offset: 0x0025C396
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007B23 RID: 31523 RVA: 0x0025E1A3 File Offset: 0x0025C3A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007B24 RID: 31524 RVA: 0x0025E1AC File Offset: 0x0025C3AC
		public static FloroRanchToyWeight GetRootAsFloroRanchToyWeight(ByteBuffer _bb)
		{
			return FloroRanchToyWeight.GetRootAsFloroRanchToyWeight(_bb, default(FloroRanchToyWeight));
		}

		// Token: 0x06007B25 RID: 31525 RVA: 0x0025E1C8 File Offset: 0x0025C3C8
		public static FloroRanchToyWeight GetRootAsFloroRanchToyWeight(ByteBuffer _bb, FloroRanchToyWeight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007B26 RID: 31526 RVA: 0x0025E1E5 File Offset: 0x0025C3E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007B27 RID: 31527 RVA: 0x0025E1F4 File Offset: 0x0025C3F4
		public FloroRanchToyWeight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x06007B28 RID: 31528 RVA: 0x0025E204 File Offset: 0x0025C404
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

		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x06007B29 RID: 31529 RVA: 0x0025E240 File Offset: 0x0025C440
		public int Group
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

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x06007B2A RID: 31530 RVA: 0x0025E27C File Offset: 0x0025C47C
		public int Stage
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

		// Token: 0x04005311 RID: 21265
		private Table __p;
	}
}
