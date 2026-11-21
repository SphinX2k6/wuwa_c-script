using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BA1 RID: 2977
	public struct ActivityPermanentFilter : IFlatbufferObject
	{
		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060048D1 RID: 18641 RVA: 0x001EC47C File Offset: 0x001EA67C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060048D2 RID: 18642 RVA: 0x001EC489 File Offset: 0x001EA689
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060048D3 RID: 18643 RVA: 0x001EC490 File Offset: 0x001EA690
		public static ActivityPermanentFilter GetRootAsActivityPermanentFilter(ByteBuffer _bb)
		{
			return ActivityPermanentFilter.GetRootAsActivityPermanentFilter(_bb, default(ActivityPermanentFilter));
		}

		// Token: 0x060048D4 RID: 18644 RVA: 0x001EC4AC File Offset: 0x001EA6AC
		public static ActivityPermanentFilter GetRootAsActivityPermanentFilter(ByteBuffer _bb, ActivityPermanentFilter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060048D5 RID: 18645 RVA: 0x001EC4C9 File Offset: 0x001EA6C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060048D6 RID: 18646 RVA: 0x001EC4D8 File Offset: 0x001EA6D8
		public ActivityPermanentFilter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060048D7 RID: 18647 RVA: 0x001EC4E8 File Offset: 0x001EA6E8
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

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060048D8 RID: 18648 RVA: 0x001EC524 File Offset: 0x001EA724
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

		// Token: 0x060048D9 RID: 18649 RVA: 0x001EC55B File Offset: 0x001EA75B
		public Span<byte> GetFilterNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060048DA RID: 18650 RVA: 0x001EC56A File Offset: 0x001EA76A
		public byte[] GetFilterNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400507E RID: 20606
		private Table __p;
	}
}
