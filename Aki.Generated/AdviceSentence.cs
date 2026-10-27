using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AE3 RID: 2787
	public struct AdviceSentence : IFlatbufferObject
	{
		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06004600 RID: 17920 RVA: 0x001D197C File Offset: 0x001CFB7C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x001D1989 File Offset: 0x001CFB89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004602 RID: 17922 RVA: 0x001D1990 File Offset: 0x001CFB90
		public static AdviceSentence GetRootAsAdviceSentence(ByteBuffer _bb)
		{
			return AdviceSentence.GetRootAsAdviceSentence(_bb, default(AdviceSentence));
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x001D19AC File Offset: 0x001CFBAC
		public static AdviceSentence GetRootAsAdviceSentence(ByteBuffer _bb, AdviceSentence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004604 RID: 17924 RVA: 0x001D19C9 File Offset: 0x001CFBC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x001D19D8 File Offset: 0x001CFBD8
		public AdviceSentence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06004606 RID: 17926 RVA: 0x001D19E8 File Offset: 0x001CFBE8
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

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06004607 RID: 17927 RVA: 0x001D1A24 File Offset: 0x001CFC24
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

		// Token: 0x06004608 RID: 17928 RVA: 0x001D1A5B File Offset: 0x001CFC5B
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004609 RID: 17929 RVA: 0x001D1A6A File Offset: 0x001CFC6A
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AC3 RID: 19139
		private Table __p;
	}
}
