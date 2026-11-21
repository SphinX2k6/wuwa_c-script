using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F94 RID: 3988
	public struct PayItem : IFlatbufferObject
	{
		// Token: 0x1700250C RID: 9484
		// (get) Token: 0x0600A909 RID: 43273 RVA: 0x002C36E4 File Offset: 0x002C18E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A90A RID: 43274 RVA: 0x002C36F1 File Offset: 0x002C18F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A90B RID: 43275 RVA: 0x002C36F8 File Offset: 0x002C18F8
		public static PayItem GetRootAsPayItem(ByteBuffer _bb)
		{
			return PayItem.GetRootAsPayItem(_bb, default(PayItem));
		}

		// Token: 0x0600A90C RID: 43276 RVA: 0x002C3714 File Offset: 0x002C1914
		public static PayItem GetRootAsPayItem(ByteBuffer _bb, PayItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A90D RID: 43277 RVA: 0x002C3731 File Offset: 0x002C1931
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A90E RID: 43278 RVA: 0x002C3740 File Offset: 0x002C1940
		public PayItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700250D RID: 9485
		// (get) Token: 0x0600A90F RID: 43279 RVA: 0x002C3750 File Offset: 0x002C1950
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

		// Token: 0x1700250E RID: 9486
		// (get) Token: 0x0600A910 RID: 43280 RVA: 0x002C378C File Offset: 0x002C198C
		public int ItemId
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

		// Token: 0x1700250F RID: 9487
		// (get) Token: 0x0600A911 RID: 43281 RVA: 0x002C37C8 File Offset: 0x002C19C8
		public int ItemCount
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002510 RID: 9488
		// (get) Token: 0x0600A912 RID: 43282 RVA: 0x002C3804 File Offset: 0x002C1A04
		public int PayId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002511 RID: 9489
		// (get) Token: 0x0600A913 RID: 43283 RVA: 0x002C3844 File Offset: 0x002C1A44
		public string StageImage
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A914 RID: 43284 RVA: 0x002C387C File Offset: 0x002C1A7C
		public Span<byte> GetStageImageBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A915 RID: 43285 RVA: 0x002C388C File Offset: 0x002C1A8C
		public byte[] GetStageImageArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002512 RID: 9490
		// (get) Token: 0x0600A916 RID: 43286 RVA: 0x002C38A4 File Offset: 0x002C1AA4
		public int BonusItemCount
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002513 RID: 9491
		// (get) Token: 0x0600A917 RID: 43287 RVA: 0x002C38E4 File Offset: 0x002C1AE4
		public int SpecialBonusItemCount
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400554A RID: 21834
		private Table __p;
	}
}
