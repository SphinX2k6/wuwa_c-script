using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B0A RID: 2826
	public struct AreaTerminalGroup : IFlatbufferObject
	{
		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06004915 RID: 18709 RVA: 0x001D8D95 File Offset: 0x001D6F95
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004916 RID: 18710 RVA: 0x001D8DA2 File Offset: 0x001D6FA2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004917 RID: 18711 RVA: 0x001D8DAC File Offset: 0x001D6FAC
		public static AreaTerminalGroup GetRootAsAreaTerminalGroup(ByteBuffer _bb)
		{
			return AreaTerminalGroup.GetRootAsAreaTerminalGroup(_bb, default(AreaTerminalGroup));
		}

		// Token: 0x06004918 RID: 18712 RVA: 0x001D8DC8 File Offset: 0x001D6FC8
		public static AreaTerminalGroup GetRootAsAreaTerminalGroup(ByteBuffer _bb, AreaTerminalGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004919 RID: 18713 RVA: 0x001D8DE5 File Offset: 0x001D6FE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600491A RID: 18714 RVA: 0x001D8DF4 File Offset: 0x001D6FF4
		public AreaTerminalGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x0600491B RID: 18715 RVA: 0x001D8E04 File Offset: 0x001D7004
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

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x0600491C RID: 18716 RVA: 0x001D8E40 File Offset: 0x001D7040
		public string Name
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

		// Token: 0x0600491D RID: 18717 RVA: 0x001D8E77 File Offset: 0x001D7077
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600491E RID: 18718 RVA: 0x001D8E86 File Offset: 0x001D7086
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x0600491F RID: 18719 RVA: 0x001D8EA0 File Offset: 0x001D70A0
		public string Icon
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

		// Token: 0x06004920 RID: 18720 RVA: 0x001D8ED7 File Offset: 0x001D70D7
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004921 RID: 18721 RVA: 0x001D8EE6 File Offset: 0x001D70E6
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06004922 RID: 18722 RVA: 0x001D8F00 File Offset: 0x001D7100
		public string IconShadow
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

		// Token: 0x06004923 RID: 18723 RVA: 0x001D8F38 File Offset: 0x001D7138
		public Span<byte> GetIconShadowBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004924 RID: 18724 RVA: 0x001D8F48 File Offset: 0x001D7148
		public byte[] GetIconShadowArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06004925 RID: 18725 RVA: 0x001D8F60 File Offset: 0x001D7160
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004AEF RID: 19183
		private Table __p;
	}
}
