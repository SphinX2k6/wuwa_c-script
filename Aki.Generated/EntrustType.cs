using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D21 RID: 3361
	public struct EntrustType : IFlatbufferObject
	{
		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x0600703C RID: 28732 RVA: 0x00244950 File Offset: 0x00242B50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600703D RID: 28733 RVA: 0x0024495D File Offset: 0x00242B5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600703E RID: 28734 RVA: 0x00244964 File Offset: 0x00242B64
		public static EntrustType GetRootAsEntrustType(ByteBuffer _bb)
		{
			return EntrustType.GetRootAsEntrustType(_bb, default(EntrustType));
		}

		// Token: 0x0600703F RID: 28735 RVA: 0x00244980 File Offset: 0x00242B80
		public static EntrustType GetRootAsEntrustType(ByteBuffer _bb, EntrustType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007040 RID: 28736 RVA: 0x0024499D File Offset: 0x00242B9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007041 RID: 28737 RVA: 0x002449AC File Offset: 0x00242BAC
		public EntrustType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x06007042 RID: 28738 RVA: 0x002449BC File Offset: 0x00242BBC
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

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x06007043 RID: 28739 RVA: 0x002449F8 File Offset: 0x00242BF8
		public string Icon
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

		// Token: 0x06007044 RID: 28740 RVA: 0x00244A2F File Offset: 0x00242C2F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007045 RID: 28741 RVA: 0x00244A3E File Offset: 0x00242C3E
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005261 RID: 21089
		private Table __p;
	}
}
