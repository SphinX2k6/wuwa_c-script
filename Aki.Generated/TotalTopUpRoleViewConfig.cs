using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001131 RID: 4401
	public struct TotalTopUpRoleViewConfig : IFlatbufferObject
	{
		// Token: 0x17003A8A RID: 14986
		// (get) Token: 0x0600DF22 RID: 57122 RVA: 0x0032E8ED File Offset: 0x0032CAED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DF23 RID: 57123 RVA: 0x0032E8FA File Offset: 0x0032CAFA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DF24 RID: 57124 RVA: 0x0032E904 File Offset: 0x0032CB04
		public static TotalTopUpRoleViewConfig GetRootAsTotalTopUpRoleViewConfig(ByteBuffer _bb)
		{
			return TotalTopUpRoleViewConfig.GetRootAsTotalTopUpRoleViewConfig(_bb, default(TotalTopUpRoleViewConfig));
		}

		// Token: 0x0600DF25 RID: 57125 RVA: 0x0032E920 File Offset: 0x0032CB20
		public static TotalTopUpRoleViewConfig GetRootAsTotalTopUpRoleViewConfig(ByteBuffer _bb, TotalTopUpRoleViewConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DF26 RID: 57126 RVA: 0x0032E93D File Offset: 0x0032CB3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DF27 RID: 57127 RVA: 0x0032E94C File Offset: 0x0032CB4C
		public TotalTopUpRoleViewConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A8B RID: 14987
		// (get) Token: 0x0600DF28 RID: 57128 RVA: 0x0032E95C File Offset: 0x0032CB5C
		public int ItemId
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

		// Token: 0x17003A8C RID: 14988
		// (get) Token: 0x0600DF29 RID: 57129 RVA: 0x0032E998 File Offset: 0x0032CB98
		public string SpinePrefabResource
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

		// Token: 0x0600DF2A RID: 57130 RVA: 0x0032E9CF File Offset: 0x0032CBCF
		public Span<byte> GetSpinePrefabResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DF2B RID: 57131 RVA: 0x0032E9DE File Offset: 0x0032CBDE
		public byte[] GetSpinePrefabResourceArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A8D RID: 14989
		// (get) Token: 0x0600DF2C RID: 57132 RVA: 0x0032E9F8 File Offset: 0x0032CBF8
		public string TexturePath
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

		// Token: 0x0600DF2D RID: 57133 RVA: 0x0032EA2F File Offset: 0x0032CC2F
		public Span<byte> GetTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DF2E RID: 57134 RVA: 0x0032EA3E File Offset: 0x0032CC3E
		public byte[] GetTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A8E RID: 14990
		// (get) Token: 0x0600DF2F RID: 57135 RVA: 0x0032EA58 File Offset: 0x0032CC58
		public string RoleBackgroundPath
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

		// Token: 0x0600DF30 RID: 57136 RVA: 0x0032EA90 File Offset: 0x0032CC90
		public Span<byte> GetRoleBackgroundPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DF31 RID: 57137 RVA: 0x0032EAA0 File Offset: 0x0032CCA0
		public byte[] GetRoleBackgroundPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005272 RID: 21106
		private Table __p;
	}
}
