using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AC7 RID: 2759
	public struct ActivityPermanentFilter : IFlatbufferObject
	{
		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600438A RID: 17290 RVA: 0x001CC89C File Offset: 0x001CAA9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600438B RID: 17291 RVA: 0x001CC8A9 File Offset: 0x001CAAA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600438C RID: 17292 RVA: 0x001CC8B0 File Offset: 0x001CAAB0
		public static ActivityPermanentFilter GetRootAsActivityPermanentFilter(ByteBuffer _bb)
		{
			return ActivityPermanentFilter.GetRootAsActivityPermanentFilter(_bb, default(ActivityPermanentFilter));
		}

		// Token: 0x0600438D RID: 17293 RVA: 0x001CC8CC File Offset: 0x001CAACC
		public static ActivityPermanentFilter GetRootAsActivityPermanentFilter(ByteBuffer _bb, ActivityPermanentFilter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600438E RID: 17294 RVA: 0x001CC8E9 File Offset: 0x001CAAE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600438F RID: 17295 RVA: 0x001CC8F8 File Offset: 0x001CAAF8
		public ActivityPermanentFilter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06004390 RID: 17296 RVA: 0x001CC908 File Offset: 0x001CAB08
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

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06004391 RID: 17297 RVA: 0x001CC944 File Offset: 0x001CAB44
		public string FilterName
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

		// Token: 0x06004392 RID: 17298 RVA: 0x001CC97B File Offset: 0x001CAB7B
		public Span<byte> GetFilterNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004393 RID: 17299 RVA: 0x001CC98A File Offset: 0x001CAB8A
		public byte[] GetFilterNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AA4 RID: 19108
		private Table __p;
	}
}
