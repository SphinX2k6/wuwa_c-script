using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BBD RID: 3005
	public struct AdviceSentence : IFlatbufferObject
	{
		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06004B47 RID: 19271 RVA: 0x001F1414 File Offset: 0x001EF614
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004B48 RID: 19272 RVA: 0x001F1421 File Offset: 0x001EF621
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004B49 RID: 19273 RVA: 0x001F1428 File Offset: 0x001EF628
		public static AdviceSentence GetRootAsAdviceSentence(ByteBuffer _bb)
		{
			return AdviceSentence.GetRootAsAdviceSentence(_bb, default(AdviceSentence));
		}

		// Token: 0x06004B4A RID: 19274 RVA: 0x001F1444 File Offset: 0x001EF644
		public static AdviceSentence GetRootAsAdviceSentence(ByteBuffer _bb, AdviceSentence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004B4B RID: 19275 RVA: 0x001F1461 File Offset: 0x001EF661
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004B4C RID: 19276 RVA: 0x001F1470 File Offset: 0x001EF670
		public AdviceSentence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06004B4D RID: 19277 RVA: 0x001F1480 File Offset: 0x001EF680
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

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06004B4E RID: 19278 RVA: 0x001F14BC File Offset: 0x001EF6BC
		public string Text
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

		// Token: 0x06004B4F RID: 19279 RVA: 0x001F14F3 File Offset: 0x001EF6F3
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004B50 RID: 19280 RVA: 0x001F1502 File Offset: 0x001EF702
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400509D RID: 20637
		private Table __p;
	}
}
