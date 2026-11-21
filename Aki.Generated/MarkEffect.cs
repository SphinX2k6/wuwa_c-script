using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EDC RID: 3804
	public struct MarkEffect : IFlatbufferObject
	{
		// Token: 0x17001EC5 RID: 7877
		// (get) Token: 0x0600982E RID: 38958 RVA: 0x0029EEDA File Offset: 0x0029D0DA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600982F RID: 38959 RVA: 0x0029EEE7 File Offset: 0x0029D0E7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009830 RID: 38960 RVA: 0x0029EEF0 File Offset: 0x0029D0F0
		public static MarkEffect GetRootAsMarkEffect(ByteBuffer _bb)
		{
			return MarkEffect.GetRootAsMarkEffect(_bb, default(MarkEffect));
		}

		// Token: 0x06009831 RID: 38961 RVA: 0x0029EF0C File Offset: 0x0029D10C
		public static MarkEffect GetRootAsMarkEffect(ByteBuffer _bb, MarkEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009832 RID: 38962 RVA: 0x0029EF29 File Offset: 0x0029D129
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009833 RID: 38963 RVA: 0x0029EF38 File Offset: 0x0029D138
		public MarkEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001EC6 RID: 7878
		// (get) Token: 0x06009834 RID: 38964 RVA: 0x0029EF48 File Offset: 0x0029D148
		public int MarkId
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

		// Token: 0x17001EC7 RID: 7879
		// (get) Token: 0x06009835 RID: 38965 RVA: 0x0029EF84 File Offset: 0x0029D184
		public string EffectResourcePath
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

		// Token: 0x06009836 RID: 38966 RVA: 0x0029EFBB File Offset: 0x0029D1BB
		public Span<byte> GetEffectResourcePathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009837 RID: 38967 RVA: 0x0029EFCA File Offset: 0x0029D1CA
		public byte[] GetEffectResourcePathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400547C RID: 21628
		private Table __p;
	}
}
