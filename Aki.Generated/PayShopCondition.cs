using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EB1 RID: 3761
	public struct PayShopCondition : IFlatbufferObject
	{
		// Token: 0x170024BA RID: 9402
		// (get) Token: 0x0600A313 RID: 41747 RVA: 0x002A6975 File Offset: 0x002A4B75
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A314 RID: 41748 RVA: 0x002A6982 File Offset: 0x002A4B82
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A315 RID: 41749 RVA: 0x002A698C File Offset: 0x002A4B8C
		public static PayShopCondition GetRootAsPayShopCondition(ByteBuffer _bb)
		{
			return PayShopCondition.GetRootAsPayShopCondition(_bb, default(PayShopCondition));
		}

		// Token: 0x0600A316 RID: 41750 RVA: 0x002A69A8 File Offset: 0x002A4BA8
		public static PayShopCondition GetRootAsPayShopCondition(ByteBuffer _bb, PayShopCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A317 RID: 41751 RVA: 0x002A69C5 File Offset: 0x002A4BC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A318 RID: 41752 RVA: 0x002A69D4 File Offset: 0x002A4BD4
		public PayShopCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170024BB RID: 9403
		// (get) Token: 0x0600A319 RID: 41753 RVA: 0x002A69E4 File Offset: 0x002A4BE4
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

		// Token: 0x170024BC RID: 9404
		// (get) Token: 0x0600A31A RID: 41754 RVA: 0x002A6A20 File Offset: 0x002A4C20
		public string ConditionText
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

		// Token: 0x0600A31B RID: 41755 RVA: 0x002A6A57 File Offset: 0x002A4C57
		public Span<byte> GetConditionTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A31C RID: 41756 RVA: 0x002A6A66 File Offset: 0x002A4C66
		public byte[] GetConditionTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F67 RID: 20327
		private Table __p;
	}
}
