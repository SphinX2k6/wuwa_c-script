using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012D8 RID: 4824
	public struct WeekCardContent : IFlatbufferObject
	{
		// Token: 0x170041BB RID: 16827
		// (get) Token: 0x0600F668 RID: 63080 RVA: 0x0036FDA4 File Offset: 0x0036DFA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F669 RID: 63081 RVA: 0x0036FDB1 File Offset: 0x0036DFB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F66A RID: 63082 RVA: 0x0036FDB8 File Offset: 0x0036DFB8
		public static WeekCardContent GetRootAsWeekCardContent(ByteBuffer _bb)
		{
			return WeekCardContent.GetRootAsWeekCardContent(_bb, default(WeekCardContent));
		}

		// Token: 0x0600F66B RID: 63083 RVA: 0x0036FDD4 File Offset: 0x0036DFD4
		public static WeekCardContent GetRootAsWeekCardContent(ByteBuffer _bb, WeekCardContent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F66C RID: 63084 RVA: 0x0036FDF1 File Offset: 0x0036DFF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F66D RID: 63085 RVA: 0x0036FE00 File Offset: 0x0036E000
		public WeekCardContent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170041BC RID: 16828
		// (get) Token: 0x0600F66E RID: 63086 RVA: 0x0036FE10 File Offset: 0x0036E010
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

		// Token: 0x170041BD RID: 16829
		// (get) Token: 0x0600F66F RID: 63087 RVA: 0x0036FE4C File Offset: 0x0036E04C
		public string RewardTexture
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

		// Token: 0x0600F670 RID: 63088 RVA: 0x0036FE83 File Offset: 0x0036E083
		public Span<byte> GetRewardTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F671 RID: 63089 RVA: 0x0036FE92 File Offset: 0x0036E092
		public byte[] GetRewardTextureArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005931 RID: 22833
		private Table __p;
	}
}
