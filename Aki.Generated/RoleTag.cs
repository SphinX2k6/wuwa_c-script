using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001149 RID: 4425
	public struct RoleTag : IFlatbufferObject
	{
		// Token: 0x170033F0 RID: 13296
		// (get) Token: 0x0600D1B1 RID: 53681 RVA: 0x0031CED8 File Offset: 0x0031B0D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D1B2 RID: 53682 RVA: 0x0031CEE5 File Offset: 0x0031B0E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D1B3 RID: 53683 RVA: 0x0031CEEC File Offset: 0x0031B0EC
		public static RoleTag GetRootAsRoleTag(ByteBuffer _bb)
		{
			return RoleTag.GetRootAsRoleTag(_bb, default(RoleTag));
		}

		// Token: 0x0600D1B4 RID: 53684 RVA: 0x0031CF08 File Offset: 0x0031B108
		public static RoleTag GetRootAsRoleTag(ByteBuffer _bb, RoleTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D1B5 RID: 53685 RVA: 0x0031CF25 File Offset: 0x0031B125
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D1B6 RID: 53686 RVA: 0x0031CF34 File Offset: 0x0031B134
		public RoleTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170033F1 RID: 13297
		// (get) Token: 0x0600D1B7 RID: 53687 RVA: 0x0031CF44 File Offset: 0x0031B144
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

		// Token: 0x170033F2 RID: 13298
		// (get) Token: 0x0600D1B8 RID: 53688 RVA: 0x0031CF80 File Offset: 0x0031B180
		public int SortId
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

		// Token: 0x170033F3 RID: 13299
		// (get) Token: 0x0600D1B9 RID: 53689 RVA: 0x0031CFBC File Offset: 0x0031B1BC
		public string TagName
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

		// Token: 0x0600D1BA RID: 53690 RVA: 0x0031CFF3 File Offset: 0x0031B1F3
		public Span<byte> GetTagNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D1BB RID: 53691 RVA: 0x0031D002 File Offset: 0x0031B202
		public byte[] GetTagNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170033F4 RID: 13300
		// (get) Token: 0x0600D1BC RID: 53692 RVA: 0x0031D01C File Offset: 0x0031B21C
		public string TagIcon
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

		// Token: 0x0600D1BD RID: 53693 RVA: 0x0031D054 File Offset: 0x0031B254
		public Span<byte> GetTagIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D1BE RID: 53694 RVA: 0x0031D064 File Offset: 0x0031B264
		public byte[] GetTagIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170033F5 RID: 13301
		// (get) Token: 0x0600D1BF RID: 53695 RVA: 0x0031D07C File Offset: 0x0031B27C
		public string TagNameColor
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

		// Token: 0x0600D1C0 RID: 53696 RVA: 0x0031D0B4 File Offset: 0x0031B2B4
		public Span<byte> GetTagNameColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D1C1 RID: 53697 RVA: 0x0031D0C4 File Offset: 0x0031B2C4
		public byte[] GetTagNameColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170033F6 RID: 13302
		// (get) Token: 0x0600D1C2 RID: 53698 RVA: 0x0031D0DC File Offset: 0x0031B2DC
		public string TagDesc
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

		// Token: 0x0600D1C3 RID: 53699 RVA: 0x0031D114 File Offset: 0x0031B314
		public Span<byte> GetTagDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D1C4 RID: 53700 RVA: 0x0031D124 File Offset: 0x0031B324
		public byte[] GetTagDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0400574D RID: 22349
		private Table __p;
	}
}
