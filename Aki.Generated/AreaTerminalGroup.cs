using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BE4 RID: 3044
	public struct AreaTerminalGroup : IFlatbufferObject
	{
		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06004E5C RID: 20060 RVA: 0x001F8563 File Offset: 0x001F6763
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004E5D RID: 20061 RVA: 0x001F8570 File Offset: 0x001F6770
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004E5E RID: 20062 RVA: 0x001F8578 File Offset: 0x001F6778
		public static AreaTerminalGroup GetRootAsAreaTerminalGroup(ByteBuffer _bb)
		{
			return AreaTerminalGroup.GetRootAsAreaTerminalGroup(_bb, default(AreaTerminalGroup));
		}

		// Token: 0x06004E5F RID: 20063 RVA: 0x001F8594 File Offset: 0x001F6794
		public static AreaTerminalGroup GetRootAsAreaTerminalGroup(ByteBuffer _bb, AreaTerminalGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004E60 RID: 20064 RVA: 0x001F85B1 File Offset: 0x001F67B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004E61 RID: 20065 RVA: 0x001F85C0 File Offset: 0x001F67C0
		public AreaTerminalGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06004E62 RID: 20066 RVA: 0x001F85D0 File Offset: 0x001F67D0
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

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06004E63 RID: 20067 RVA: 0x001F860C File Offset: 0x001F680C
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

		// Token: 0x06004E64 RID: 20068 RVA: 0x001F8643 File Offset: 0x001F6843
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004E65 RID: 20069 RVA: 0x001F8652 File Offset: 0x001F6852
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06004E66 RID: 20070 RVA: 0x001F866C File Offset: 0x001F686C
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

		// Token: 0x06004E67 RID: 20071 RVA: 0x001F86A3 File Offset: 0x001F68A3
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004E68 RID: 20072 RVA: 0x001F86B2 File Offset: 0x001F68B2
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06004E69 RID: 20073 RVA: 0x001F86CC File Offset: 0x001F68CC
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

		// Token: 0x06004E6A RID: 20074 RVA: 0x001F8704 File Offset: 0x001F6904
		public Span<byte> GetIconShadowBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004E6B RID: 20075 RVA: 0x001F8714 File Offset: 0x001F6914
		public byte[] GetIconShadowArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06004E6C RID: 20076 RVA: 0x001F872C File Offset: 0x001F692C
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

		// Token: 0x040050C9 RID: 20681
		private Table __p;
	}
}
