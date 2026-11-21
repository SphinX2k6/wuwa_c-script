using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BA8 RID: 2984
	public struct ActivityTab : IFlatbufferObject
	{
		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600494B RID: 18763 RVA: 0x001ED449 File Offset: 0x001EB649
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600494C RID: 18764 RVA: 0x001ED456 File Offset: 0x001EB656
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600494D RID: 18765 RVA: 0x001ED460 File Offset: 0x001EB660
		public static ActivityTab GetRootAsActivityTab(ByteBuffer _bb)
		{
			return ActivityTab.GetRootAsActivityTab(_bb, default(ActivityTab));
		}

		// Token: 0x0600494E RID: 18766 RVA: 0x001ED47C File Offset: 0x001EB67C
		public static ActivityTab GetRootAsActivityTab(ByteBuffer _bb, ActivityTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600494F RID: 18767 RVA: 0x001ED499 File Offset: 0x001EB699
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004950 RID: 18768 RVA: 0x001ED4A8 File Offset: 0x001EB6A8
		public ActivityTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06004951 RID: 18769 RVA: 0x001ED4B8 File Offset: 0x001EB6B8
		public int Type
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

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06004952 RID: 18770 RVA: 0x001ED4F4 File Offset: 0x001EB6F4
		public string Tag
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

		// Token: 0x06004953 RID: 18771 RVA: 0x001ED52B File Offset: 0x001EB72B
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004954 RID: 18772 RVA: 0x001ED53A File Offset: 0x001EB73A
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06004955 RID: 18773 RVA: 0x001ED554 File Offset: 0x001EB754
		public string Icon
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

		// Token: 0x06004956 RID: 18774 RVA: 0x001ED58B File Offset: 0x001EB78B
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004957 RID: 18775 RVA: 0x001ED59A File Offset: 0x001EB79A
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005085 RID: 20613
		private Table __p;
	}
}
