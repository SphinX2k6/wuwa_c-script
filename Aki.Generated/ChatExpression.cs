using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B6B RID: 2923
	public struct ChatExpression : IFlatbufferObject
	{
		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x060053C0 RID: 21440 RVA: 0x001F2461 File Offset: 0x001F0661
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060053C1 RID: 21441 RVA: 0x001F246E File Offset: 0x001F066E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060053C2 RID: 21442 RVA: 0x001F2478 File Offset: 0x001F0678
		public static ChatExpression GetRootAsChatExpression(ByteBuffer _bb)
		{
			return ChatExpression.GetRootAsChatExpression(_bb, default(ChatExpression));
		}

		// Token: 0x060053C3 RID: 21443 RVA: 0x001F2494 File Offset: 0x001F0694
		public static ChatExpression GetRootAsChatExpression(ByteBuffer _bb, ChatExpression obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060053C4 RID: 21444 RVA: 0x001F24B1 File Offset: 0x001F06B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060053C5 RID: 21445 RVA: 0x001F24C0 File Offset: 0x001F06C0
		public ChatExpression __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x060053C6 RID: 21446 RVA: 0x001F24D0 File Offset: 0x001F06D0
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

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x060053C7 RID: 21447 RVA: 0x001F250C File Offset: 0x001F070C
		public int GroupId
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

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060053C8 RID: 21448 RVA: 0x001F2548 File Offset: 0x001F0748
		public string Name
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

		// Token: 0x060053C9 RID: 21449 RVA: 0x001F257F File Offset: 0x001F077F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060053CA RID: 21450 RVA: 0x001F258E File Offset: 0x001F078E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x060053CB RID: 21451 RVA: 0x001F25A8 File Offset: 0x001F07A8
		public string ExpressionTexturePath
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060053CC RID: 21452 RVA: 0x001F25E0 File Offset: 0x001F07E0
		public Span<byte> GetExpressionTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060053CD RID: 21453 RVA: 0x001F25F0 File Offset: 0x001F07F0
		public byte[] GetExpressionTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060053CE RID: 21454 RVA: 0x001F2608 File Offset: 0x001F0808
		public string MaleVariant
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

		// Token: 0x060053CF RID: 21455 RVA: 0x001F2640 File Offset: 0x001F0840
		public Span<byte> GetMaleVariantBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060053D0 RID: 21456 RVA: 0x001F2650 File Offset: 0x001F0850
		public byte[] GetMaleVariantArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B6D RID: 19309
		private Table __p;
	}
}
