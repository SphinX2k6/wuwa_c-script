using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200103E RID: 4158
	public struct RoleDescription : IFlatbufferObject
	{
		// Token: 0x17003212 RID: 12818
		// (get) Token: 0x0600C78C RID: 51084 RVA: 0x002F8368 File Offset: 0x002F6568
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C78D RID: 51085 RVA: 0x002F8375 File Offset: 0x002F6575
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C78E RID: 51086 RVA: 0x002F837C File Offset: 0x002F657C
		public static RoleDescription GetRootAsRoleDescription(ByteBuffer _bb)
		{
			return RoleDescription.GetRootAsRoleDescription(_bb, default(RoleDescription));
		}

		// Token: 0x0600C78F RID: 51087 RVA: 0x002F8398 File Offset: 0x002F6598
		public static RoleDescription GetRootAsRoleDescription(ByteBuffer _bb, RoleDescription obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C790 RID: 51088 RVA: 0x002F83B5 File Offset: 0x002F65B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C791 RID: 51089 RVA: 0x002F83C4 File Offset: 0x002F65C4
		public RoleDescription __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003213 RID: 12819
		// (get) Token: 0x0600C792 RID: 51090 RVA: 0x002F83D4 File Offset: 0x002F65D4
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

		// Token: 0x17003214 RID: 12820
		// (get) Token: 0x0600C793 RID: 51091 RVA: 0x002F8410 File Offset: 0x002F6610
		public int RoleId
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

		// Token: 0x17003215 RID: 12821
		// (get) Token: 0x0600C794 RID: 51092 RVA: 0x002F844C File Offset: 0x002F664C
		public string Texture
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

		// Token: 0x0600C795 RID: 51093 RVA: 0x002F8483 File Offset: 0x002F6683
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C796 RID: 51094 RVA: 0x002F8492 File Offset: 0x002F6692
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003216 RID: 12822
		// (get) Token: 0x0600C797 RID: 51095 RVA: 0x002F84AC File Offset: 0x002F66AC
		public string Description
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

		// Token: 0x0600C798 RID: 51096 RVA: 0x002F84E4 File Offset: 0x002F66E4
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C799 RID: 51097 RVA: 0x002F84F4 File Offset: 0x002F66F4
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0400513C RID: 20796
		private Table __p;
	}
}
