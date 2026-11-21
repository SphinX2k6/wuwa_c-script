using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E96 RID: 3734
	public struct KurotatoRewardTab : IFlatbufferObject
	{
		// Token: 0x17001C7F RID: 7295
		// (get) Token: 0x06009193 RID: 37267 RVA: 0x00290A5C File Offset: 0x0028EC5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009194 RID: 37268 RVA: 0x00290A69 File Offset: 0x0028EC69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009195 RID: 37269 RVA: 0x00290A70 File Offset: 0x0028EC70
		public static KurotatoRewardTab GetRootAsKurotatoRewardTab(ByteBuffer _bb)
		{
			return KurotatoRewardTab.GetRootAsKurotatoRewardTab(_bb, default(KurotatoRewardTab));
		}

		// Token: 0x06009196 RID: 37270 RVA: 0x00290A8C File Offset: 0x0028EC8C
		public static KurotatoRewardTab GetRootAsKurotatoRewardTab(ByteBuffer _bb, KurotatoRewardTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009197 RID: 37271 RVA: 0x00290AA9 File Offset: 0x0028ECA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009198 RID: 37272 RVA: 0x00290AB8 File Offset: 0x0028ECB8
		public KurotatoRewardTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C80 RID: 7296
		// (get) Token: 0x06009199 RID: 37273 RVA: 0x00290AC8 File Offset: 0x0028ECC8
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

		// Token: 0x17001C81 RID: 7297
		// (get) Token: 0x0600919A RID: 37274 RVA: 0x00290B04 File Offset: 0x0028ED04
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

		// Token: 0x17001C82 RID: 7298
		// (get) Token: 0x0600919B RID: 37275 RVA: 0x00290B40 File Offset: 0x0028ED40
		public string Name
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

		// Token: 0x0600919C RID: 37276 RVA: 0x00290B77 File Offset: 0x0028ED77
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600919D RID: 37277 RVA: 0x00290B86 File Offset: 0x0028ED86
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005428 RID: 21544
		private Table __p;
	}
}
