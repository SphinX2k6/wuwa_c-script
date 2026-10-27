using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B00 RID: 2816
	public struct AnsPerform : IFlatbufferObject
	{
		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06004823 RID: 18467 RVA: 0x001D6941 File Offset: 0x001D4B41
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004824 RID: 18468 RVA: 0x001D694E File Offset: 0x001D4B4E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004825 RID: 18469 RVA: 0x001D6958 File Offset: 0x001D4B58
		public static AnsPerform GetRootAsAnsPerform(ByteBuffer _bb)
		{
			return AnsPerform.GetRootAsAnsPerform(_bb, default(AnsPerform));
		}

		// Token: 0x06004826 RID: 18470 RVA: 0x001D6974 File Offset: 0x001D4B74
		public static AnsPerform GetRootAsAnsPerform(ByteBuffer _bb, AnsPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004827 RID: 18471 RVA: 0x001D6991 File Offset: 0x001D4B91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004828 RID: 18472 RVA: 0x001D69A0 File Offset: 0x001D4BA0
		public AnsPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06004829 RID: 18473 RVA: 0x001D69B0 File Offset: 0x001D4BB0
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

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x0600482A RID: 18474 RVA: 0x001D69EC File Offset: 0x001D4BEC
		public string Condition
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

		// Token: 0x0600482B RID: 18475 RVA: 0x001D6A23 File Offset: 0x001D4C23
		public Span<byte> GetConditionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600482C RID: 18476 RVA: 0x001D6A32 File Offset: 0x001D4C32
		public byte[] GetConditionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x0600482D RID: 18477 RVA: 0x001D6A4C File Offset: 0x001D4C4C
		public string Action
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

		// Token: 0x0600482E RID: 18478 RVA: 0x001D6A83 File Offset: 0x001D4C83
		public Span<byte> GetActionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600482F RID: 18479 RVA: 0x001D6A92 File Offset: 0x001D4C92
		public byte[] GetActionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AE1 RID: 19169
		private Table __p;
	}
}
