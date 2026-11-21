using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D08 RID: 3336
	public struct ElementalReaction : IFlatbufferObject
	{
		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06006DC0 RID: 28096 RVA: 0x0023FBB0 File Offset: 0x0023DDB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006DC1 RID: 28097 RVA: 0x0023FBBD File Offset: 0x0023DDBD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006DC2 RID: 28098 RVA: 0x0023FBC4 File Offset: 0x0023DDC4
		public static ElementalReaction GetRootAsElementalReaction(ByteBuffer _bb)
		{
			return ElementalReaction.GetRootAsElementalReaction(_bb, default(ElementalReaction));
		}

		// Token: 0x06006DC3 RID: 28099 RVA: 0x0023FBE0 File Offset: 0x0023DDE0
		public static ElementalReaction GetRootAsElementalReaction(ByteBuffer _bb, ElementalReaction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006DC4 RID: 28100 RVA: 0x0023FBFD File Offset: 0x0023DDFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006DC5 RID: 28101 RVA: 0x0023FC0C File Offset: 0x0023DE0C
		public ElementalReaction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06006DC6 RID: 28102 RVA: 0x0023FC1C File Offset: 0x0023DE1C
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

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06006DC7 RID: 28103 RVA: 0x0023FC58 File Offset: 0x0023DE58
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

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06006DC8 RID: 28104 RVA: 0x0023FC94 File Offset: 0x0023DE94
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

		// Token: 0x06006DC9 RID: 28105 RVA: 0x0023FCCB File Offset: 0x0023DECB
		public Span<byte> GetReactionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006DCA RID: 28106 RVA: 0x0023FCDA File Offset: 0x0023DEDA
		public byte[] GetReactionNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06006DCB RID: 28107 RVA: 0x0023FCF4 File Offset: 0x0023DEF4
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

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x06006DCC RID: 28108 RVA: 0x0023FD34 File Offset: 0x0023DF34
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

		// Token: 0x06006DCD RID: 28109 RVA: 0x0023FD6C File Offset: 0x0023DF6C
		public Span<byte> GetReactionTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006DCE RID: 28110 RVA: 0x0023FD7C File Offset: 0x0023DF7C
		public byte[] GetReactionTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x06006DCF RID: 28111 RVA: 0x0023FD94 File Offset: 0x0023DF94
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

		// Token: 0x06006DD0 RID: 28112 RVA: 0x0023FDCC File Offset: 0x0023DFCC
		public Span<byte> GetReactionColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006DD1 RID: 28113 RVA: 0x0023FDDC File Offset: 0x0023DFDC
		public byte[] GetReactionColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x06006DD2 RID: 28114 RVA: 0x0023FDF4 File Offset: 0x0023DFF4
		public bool IsVisible
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x06006DD3 RID: 28115 RVA: 0x0023FE34 File Offset: 0x0023E034
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

		// Token: 0x06006DD4 RID: 28116 RVA: 0x0023FE6C File Offset: 0x0023E06C
		public Span<byte> GetReactionDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06006DD5 RID: 28117 RVA: 0x0023FE7C File Offset: 0x0023E07C
		public byte[] GetReactionDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04005248 RID: 21064
		private Table __p;
	}
}
