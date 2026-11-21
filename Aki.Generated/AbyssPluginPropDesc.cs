using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B85 RID: 2949
	public struct AbyssPluginPropDesc : IFlatbufferObject
	{
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600463A RID: 17978 RVA: 0x001E6720 File Offset: 0x001E4920
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600463B RID: 17979 RVA: 0x001E672D File Offset: 0x001E492D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600463C RID: 17980 RVA: 0x001E6734 File Offset: 0x001E4934
		public static AbyssPluginPropDesc GetRootAsAbyssPluginPropDesc(ByteBuffer _bb)
		{
			return AbyssPluginPropDesc.GetRootAsAbyssPluginPropDesc(_bb, default(AbyssPluginPropDesc));
		}

		// Token: 0x0600463D RID: 17981 RVA: 0x001E6750 File Offset: 0x001E4950
		public static AbyssPluginPropDesc GetRootAsAbyssPluginPropDesc(ByteBuffer _bb, AbyssPluginPropDesc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600463E RID: 17982 RVA: 0x001E676D File Offset: 0x001E496D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600463F RID: 17983 RVA: 0x001E677C File Offset: 0x001E497C
		public AbyssPluginPropDesc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06004640 RID: 17984 RVA: 0x001E678C File Offset: 0x001E498C
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

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06004641 RID: 17985 RVA: 0x001E67C8 File Offset: 0x001E49C8
		public string BgColor
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

		// Token: 0x06004642 RID: 17986 RVA: 0x001E67FF File Offset: 0x001E49FF
		public Span<byte> GetBgColorBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004643 RID: 17987 RVA: 0x001E680E File Offset: 0x001E4A0E
		public byte[] GetBgColorArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06004644 RID: 17988 RVA: 0x001E6828 File Offset: 0x001E4A28
		public int AddType
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

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06004645 RID: 17989 RVA: 0x001E6864 File Offset: 0x001E4A64
		public string Name
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

		// Token: 0x06004646 RID: 17990 RVA: 0x001E689C File Offset: 0x001E4A9C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004647 RID: 17991 RVA: 0x001E68AC File Offset: 0x001E4AAC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06004648 RID: 17992 RVA: 0x001E68C4 File Offset: 0x001E4AC4
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

		// Token: 0x06004649 RID: 17993 RVA: 0x001E68FC File Offset: 0x001E4AFC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600464A RID: 17994 RVA: 0x001E690C File Offset: 0x001E4B0C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600464B RID: 17995 RVA: 0x001E6924 File Offset: 0x001E4B24
		public string NoMaxTextFormat
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

		// Token: 0x0600464C RID: 17996 RVA: 0x001E695C File Offset: 0x001E4B5C
		public Span<byte> GetNoMaxTextFormatBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600464D RID: 17997 RVA: 0x001E696C File Offset: 0x001E4B6C
		public byte[] GetNoMaxTextFormatArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600464E RID: 17998 RVA: 0x001E6984 File Offset: 0x001E4B84
		public string TextFormat
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600464F RID: 17999 RVA: 0x001E69BC File Offset: 0x001E4BBC
		public Span<byte> GetTextFormatBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004650 RID: 18000 RVA: 0x001E69CC File Offset: 0x001E4BCC
		public byte[] GetTextFormatArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06004651 RID: 18001 RVA: 0x001E69E4 File Offset: 0x001E4BE4
		public string MaxTextFormat
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

		// Token: 0x06004652 RID: 18002 RVA: 0x001E6A1C File Offset: 0x001E4C1C
		public Span<byte> GetMaxTextFormatBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004653 RID: 18003 RVA: 0x001E6A2C File Offset: 0x001E4C2C
		public byte[] GetMaxTextFormatArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06004654 RID: 18004 RVA: 0x001E6A44 File Offset: 0x001E4C44
		public int MaxValue
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005059 RID: 20569
		private Table __p;
	}
}
