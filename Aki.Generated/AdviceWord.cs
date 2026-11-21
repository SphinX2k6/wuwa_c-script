using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BBE RID: 3006
	public struct AdviceWord : IFlatbufferObject
	{
		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06004B51 RID: 19281 RVA: 0x001F1519 File Offset: 0x001EF719
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004B52 RID: 19282 RVA: 0x001F1526 File Offset: 0x001EF726
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004B53 RID: 19283 RVA: 0x001F1530 File Offset: 0x001EF730
		public static AdviceWord GetRootAsAdviceWord(ByteBuffer _bb)
		{
			return AdviceWord.GetRootAsAdviceWord(_bb, default(AdviceWord));
		}

		// Token: 0x06004B54 RID: 19284 RVA: 0x001F154C File Offset: 0x001EF74C
		public static AdviceWord GetRootAsAdviceWord(ByteBuffer _bb, AdviceWord obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004B55 RID: 19285 RVA: 0x001F1569 File Offset: 0x001EF769
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004B56 RID: 19286 RVA: 0x001F1578 File Offset: 0x001EF778
		public AdviceWord __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06004B57 RID: 19287 RVA: 0x001F1588 File Offset: 0x001EF788
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

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06004B58 RID: 19288 RVA: 0x001F15C4 File Offset: 0x001EF7C4
		public int Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06004B59 RID: 19289 RVA: 0x001F1600 File Offset: 0x001EF800
		public string Text
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

		// Token: 0x06004B5A RID: 19290 RVA: 0x001F1637 File Offset: 0x001EF837
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004B5B RID: 19291 RVA: 0x001F1646 File Offset: 0x001EF846
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400509E RID: 20638
		private Table __p;
	}
}
