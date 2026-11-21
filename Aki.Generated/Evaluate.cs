using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D24 RID: 3364
	public struct Evaluate : IFlatbufferObject
	{
		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x0600705C RID: 28764 RVA: 0x00244CE4 File Offset: 0x00242EE4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600705D RID: 28765 RVA: 0x00244CF1 File Offset: 0x00242EF1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600705E RID: 28766 RVA: 0x00244CF8 File Offset: 0x00242EF8
		public static Evaluate GetRootAsEvaluate(ByteBuffer _bb)
		{
			return Evaluate.GetRootAsEvaluate(_bb, default(Evaluate));
		}

		// Token: 0x0600705F RID: 28767 RVA: 0x00244D14 File Offset: 0x00242F14
		public static Evaluate GetRootAsEvaluate(ByteBuffer _bb, Evaluate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007060 RID: 28768 RVA: 0x00244D31 File Offset: 0x00242F31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007061 RID: 28769 RVA: 0x00244D40 File Offset: 0x00242F40
		public Evaluate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x06007062 RID: 28770 RVA: 0x00244D50 File Offset: 0x00242F50
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

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x06007063 RID: 28771 RVA: 0x00244D8C File Offset: 0x00242F8C
		public string Content
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

		// Token: 0x06007064 RID: 28772 RVA: 0x00244DC3 File Offset: 0x00242FC3
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007065 RID: 28773 RVA: 0x00244DD2 File Offset: 0x00242FD2
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x06007066 RID: 28774 RVA: 0x00244DEC File Offset: 0x00242FEC
		public string Color
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

		// Token: 0x06007067 RID: 28775 RVA: 0x00244E23 File Offset: 0x00243023
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007068 RID: 28776 RVA: 0x00244E32 File Offset: 0x00243032
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x06007069 RID: 28777 RVA: 0x00244E4C File Offset: 0x0024304C
		public string SpriteColor
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

		// Token: 0x0600706A RID: 28778 RVA: 0x00244E84 File Offset: 0x00243084
		public Span<byte> GetSpriteColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600706B RID: 28779 RVA: 0x00244E94 File Offset: 0x00243094
		public byte[] GetSpriteColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x0600706C RID: 28780 RVA: 0x00244EAC File Offset: 0x002430AC
		public string Icon
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

		// Token: 0x0600706D RID: 28781 RVA: 0x00244EE4 File Offset: 0x002430E4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600706E RID: 28782 RVA: 0x00244EF4 File Offset: 0x002430F4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005264 RID: 21092
		private Table __p;
	}
}
