using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001126 RID: 4390
	public struct RoleDescription : IFlatbufferObject
	{
		// Token: 0x1700328D RID: 12941
		// (get) Token: 0x0600CDD6 RID: 52694 RVA: 0x003141DC File Offset: 0x003123DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CDD7 RID: 52695 RVA: 0x003141E9 File Offset: 0x003123E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CDD8 RID: 52696 RVA: 0x003141F0 File Offset: 0x003123F0
		public static RoleDescription GetRootAsRoleDescription(ByteBuffer _bb)
		{
			return RoleDescription.GetRootAsRoleDescription(_bb, default(RoleDescription));
		}

		// Token: 0x0600CDD9 RID: 52697 RVA: 0x0031420C File Offset: 0x0031240C
		public static RoleDescription GetRootAsRoleDescription(ByteBuffer _bb, RoleDescription obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CDDA RID: 52698 RVA: 0x00314229 File Offset: 0x00312429
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CDDB RID: 52699 RVA: 0x00314238 File Offset: 0x00312438
		public RoleDescription __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700328E RID: 12942
		// (get) Token: 0x0600CDDC RID: 52700 RVA: 0x00314248 File Offset: 0x00312448
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

		// Token: 0x1700328F RID: 12943
		// (get) Token: 0x0600CDDD RID: 52701 RVA: 0x00314284 File Offset: 0x00312484
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

		// Token: 0x17003290 RID: 12944
		// (get) Token: 0x0600CDDE RID: 52702 RVA: 0x003142C0 File Offset: 0x003124C0
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

		// Token: 0x0600CDDF RID: 52703 RVA: 0x003142F7 File Offset: 0x003124F7
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CDE0 RID: 52704 RVA: 0x00314306 File Offset: 0x00312506
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003291 RID: 12945
		// (get) Token: 0x0600CDE1 RID: 52705 RVA: 0x00314320 File Offset: 0x00312520
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

		// Token: 0x0600CDE2 RID: 52706 RVA: 0x00314358 File Offset: 0x00312558
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CDE3 RID: 52707 RVA: 0x00314368 File Offset: 0x00312568
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005724 RID: 22308
		private Table __p;
	}
}
