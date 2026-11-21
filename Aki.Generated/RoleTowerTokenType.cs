using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200115A RID: 4442
	public struct RoleTowerTokenType : IFlatbufferObject
	{
		// Token: 0x17003478 RID: 13432
		// (get) Token: 0x0600D317 RID: 54039 RVA: 0x0032014C File Offset: 0x0031E34C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D318 RID: 54040 RVA: 0x00320159 File Offset: 0x0031E359
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D319 RID: 54041 RVA: 0x00320160 File Offset: 0x0031E360
		public static RoleTowerTokenType GetRootAsRoleTowerTokenType(ByteBuffer _bb)
		{
			return RoleTowerTokenType.GetRootAsRoleTowerTokenType(_bb, default(RoleTowerTokenType));
		}

		// Token: 0x0600D31A RID: 54042 RVA: 0x0032017C File Offset: 0x0031E37C
		public static RoleTowerTokenType GetRootAsRoleTowerTokenType(ByteBuffer _bb, RoleTowerTokenType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D31B RID: 54043 RVA: 0x00320199 File Offset: 0x0031E399
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D31C RID: 54044 RVA: 0x003201A8 File Offset: 0x0031E3A8
		public RoleTowerTokenType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003479 RID: 13433
		// (get) Token: 0x0600D31D RID: 54045 RVA: 0x003201B8 File Offset: 0x0031E3B8
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

		// Token: 0x1700347A RID: 13434
		// (get) Token: 0x0600D31E RID: 54046 RVA: 0x003201F4 File Offset: 0x0031E3F4
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

		// Token: 0x0600D31F RID: 54047 RVA: 0x0032022B File Offset: 0x0031E42B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D320 RID: 54048 RVA: 0x0032023A File Offset: 0x0031E43A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700347B RID: 13435
		// (get) Token: 0x0600D321 RID: 54049 RVA: 0x00320254 File Offset: 0x0031E454
		public string TagTexture
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

		// Token: 0x0600D322 RID: 54050 RVA: 0x0032028B File Offset: 0x0031E48B
		public Span<byte> GetTagTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D323 RID: 54051 RVA: 0x0032029A File Offset: 0x0031E49A
		public byte[] GetTagTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700347C RID: 13436
		// (get) Token: 0x0600D324 RID: 54052 RVA: 0x003202B4 File Offset: 0x0031E4B4
		public string IconTexture
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

		// Token: 0x0600D325 RID: 54053 RVA: 0x003202EC File Offset: 0x0031E4EC
		public Span<byte> GetIconTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D326 RID: 54054 RVA: 0x003202FC File Offset: 0x0031E4FC
		public byte[] GetIconTextureArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005762 RID: 22370
		private Table __p;
	}
}
