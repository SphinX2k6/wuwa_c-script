using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C25 RID: 3109
	public struct ElementalReaction : IFlatbufferObject
	{
		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x060067CD RID: 26573 RVA: 0x0022080C File Offset: 0x0021EA0C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060067CE RID: 26574 RVA: 0x00220819 File Offset: 0x0021EA19
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060067CF RID: 26575 RVA: 0x00220820 File Offset: 0x0021EA20
		public static ElementalReaction GetRootAsElementalReaction(ByteBuffer _bb)
		{
			return ElementalReaction.GetRootAsElementalReaction(_bb, default(ElementalReaction));
		}

		// Token: 0x060067D0 RID: 26576 RVA: 0x0022083C File Offset: 0x0021EA3C
		public static ElementalReaction GetRootAsElementalReaction(ByteBuffer _bb, ElementalReaction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060067D1 RID: 26577 RVA: 0x00220859 File Offset: 0x0021EA59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060067D2 RID: 26578 RVA: 0x00220868 File Offset: 0x0021EA68
		public ElementalReaction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x060067D3 RID: 26579 RVA: 0x00220878 File Offset: 0x0021EA78
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

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x060067D4 RID: 26580 RVA: 0x002208B4 File Offset: 0x0021EAB4
		public int ReactionId
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

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x060067D5 RID: 26581 RVA: 0x002208F0 File Offset: 0x0021EAF0
		public string ReactionName
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

		// Token: 0x060067D6 RID: 26582 RVA: 0x00220927 File Offset: 0x0021EB27
		public Span<byte> GetReactionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060067D7 RID: 26583 RVA: 0x00220936 File Offset: 0x0021EB36
		public byte[] GetReactionNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x060067D8 RID: 26584 RVA: 0x00220950 File Offset: 0x0021EB50
		public int SortIndex
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

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x060067D9 RID: 26585 RVA: 0x00220990 File Offset: 0x0021EB90
		public string ReactionTexturePath
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

		// Token: 0x060067DA RID: 26586 RVA: 0x002209C8 File Offset: 0x0021EBC8
		public Span<byte> GetReactionTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060067DB RID: 26587 RVA: 0x002209D8 File Offset: 0x0021EBD8
		public byte[] GetReactionTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x060067DC RID: 26588 RVA: 0x002209F0 File Offset: 0x0021EBF0
		public string ReactionColor
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060067DD RID: 26589 RVA: 0x00220A28 File Offset: 0x0021EC28
		public Span<byte> GetReactionColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060067DE RID: 26590 RVA: 0x00220A38 File Offset: 0x0021EC38
		public byte[] GetReactionColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x060067DF RID: 26591 RVA: 0x00220A50 File Offset: 0x0021EC50
		public bool IsVisible
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x060067E0 RID: 26592 RVA: 0x00220A90 File Offset: 0x0021EC90
		public string ReactionDescription
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060067E1 RID: 26593 RVA: 0x00220AC8 File Offset: 0x0021ECC8
		public Span<byte> GetReactionDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060067E2 RID: 26594 RVA: 0x00220AD8 File Offset: 0x0021ECD8
		public byte[] GetReactionDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C65 RID: 19557
		private Table __p;
	}
}
