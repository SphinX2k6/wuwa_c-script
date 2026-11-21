using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BBF RID: 3007
	public struct AdviceWordType : IFlatbufferObject
	{
		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06004B5C RID: 19292 RVA: 0x001F165D File Offset: 0x001EF85D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004B5D RID: 19293 RVA: 0x001F166A File Offset: 0x001EF86A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004B5E RID: 19294 RVA: 0x001F1674 File Offset: 0x001EF874
		public static AdviceWordType GetRootAsAdviceWordType(ByteBuffer _bb)
		{
			return AdviceWordType.GetRootAsAdviceWordType(_bb, default(AdviceWordType));
		}

		// Token: 0x06004B5F RID: 19295 RVA: 0x001F1690 File Offset: 0x001EF890
		public static AdviceWordType GetRootAsAdviceWordType(ByteBuffer _bb, AdviceWordType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004B60 RID: 19296 RVA: 0x001F16AD File Offset: 0x001EF8AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004B61 RID: 19297 RVA: 0x001F16BC File Offset: 0x001EF8BC
		public AdviceWordType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06004B62 RID: 19298 RVA: 0x001F16CC File Offset: 0x001EF8CC
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

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06004B63 RID: 19299 RVA: 0x001F1708 File Offset: 0x001EF908
		public string Name
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

		// Token: 0x06004B64 RID: 19300 RVA: 0x001F173F File Offset: 0x001EF93F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004B65 RID: 19301 RVA: 0x001F174E File Offset: 0x001EF94E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400509F RID: 20639
		private Table __p;
	}
}
