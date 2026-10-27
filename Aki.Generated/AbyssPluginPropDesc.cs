using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AB0 RID: 2736
	public struct AbyssPluginPropDesc : IFlatbufferObject
	{
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600413C RID: 16700 RVA: 0x001C74BD File Offset: 0x001C56BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600413D RID: 16701 RVA: 0x001C74CA File Offset: 0x001C56CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600413E RID: 16702 RVA: 0x001C74D4 File Offset: 0x001C56D4
		public static AbyssPluginPropDesc GetRootAsAbyssPluginPropDesc(ByteBuffer _bb)
		{
			return AbyssPluginPropDesc.GetRootAsAbyssPluginPropDesc(_bb, default(AbyssPluginPropDesc));
		}

		// Token: 0x0600413F RID: 16703 RVA: 0x001C74F0 File Offset: 0x001C56F0
		public static AbyssPluginPropDesc GetRootAsAbyssPluginPropDesc(ByteBuffer _bb, AbyssPluginPropDesc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004140 RID: 16704 RVA: 0x001C750D File Offset: 0x001C570D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004141 RID: 16705 RVA: 0x001C751C File Offset: 0x001C571C
		public AbyssPluginPropDesc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06004142 RID: 16706 RVA: 0x001C752C File Offset: 0x001C572C
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
		// (get) Token: 0x06004143 RID: 16707 RVA: 0x001C7568 File Offset: 0x001C5768
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

		// Token: 0x06004144 RID: 16708 RVA: 0x001C759F File Offset: 0x001C579F
		public Span<byte> GetBgColorBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004145 RID: 16709 RVA: 0x001C75AE File Offset: 0x001C57AE
		public byte[] GetBgColorArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06004146 RID: 16710 RVA: 0x001C75C8 File Offset: 0x001C57C8
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
		// (get) Token: 0x06004147 RID: 16711 RVA: 0x001C7604 File Offset: 0x001C5804
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

		// Token: 0x06004148 RID: 16712 RVA: 0x001C763C File Offset: 0x001C583C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004149 RID: 16713 RVA: 0x001C764C File Offset: 0x001C584C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600414A RID: 16714 RVA: 0x001C7664 File Offset: 0x001C5864
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

		// Token: 0x0600414B RID: 16715 RVA: 0x001C769C File Offset: 0x001C589C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600414C RID: 16716 RVA: 0x001C76AC File Offset: 0x001C58AC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600414D RID: 16717 RVA: 0x001C76C4 File Offset: 0x001C58C4
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

		// Token: 0x0600414E RID: 16718 RVA: 0x001C76FC File Offset: 0x001C58FC
		public Span<byte> GetNoMaxTextFormatBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600414F RID: 16719 RVA: 0x001C770C File Offset: 0x001C590C
		public byte[] GetNoMaxTextFormatArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06004150 RID: 16720 RVA: 0x001C7724 File Offset: 0x001C5924
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

		// Token: 0x06004151 RID: 16721 RVA: 0x001C775C File Offset: 0x001C595C
		public Span<byte> GetTextFormatBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004152 RID: 16722 RVA: 0x001C776C File Offset: 0x001C596C
		public byte[] GetTextFormatArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06004153 RID: 16723 RVA: 0x001C7784 File Offset: 0x001C5984
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

		// Token: 0x06004154 RID: 16724 RVA: 0x001C77BC File Offset: 0x001C59BC
		public Span<byte> GetMaxTextFormatBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004155 RID: 16725 RVA: 0x001C77CC File Offset: 0x001C59CC
		public byte[] GetMaxTextFormatArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06004156 RID: 16726 RVA: 0x001C77E4 File Offset: 0x001C59E4
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

		// Token: 0x04004A86 RID: 19078
		private Table __p;
	}
}
