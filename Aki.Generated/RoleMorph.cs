using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200113C RID: 4412
	public struct RoleMorph : IFlatbufferObject
	{
		// Token: 0x17003352 RID: 13138
		// (get) Token: 0x0600CFE6 RID: 53222 RVA: 0x00318AD9 File Offset: 0x00316CD9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CFE7 RID: 53223 RVA: 0x00318AE6 File Offset: 0x00316CE6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CFE8 RID: 53224 RVA: 0x00318AF0 File Offset: 0x00316CF0
		public static RoleMorph GetRootAsRoleMorph(ByteBuffer _bb)
		{
			return RoleMorph.GetRootAsRoleMorph(_bb, default(RoleMorph));
		}

		// Token: 0x0600CFE9 RID: 53225 RVA: 0x00318B0C File Offset: 0x00316D0C
		public static RoleMorph GetRootAsRoleMorph(ByteBuffer _bb, RoleMorph obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CFEA RID: 53226 RVA: 0x00318B29 File Offset: 0x00316D29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CFEB RID: 53227 RVA: 0x00318B38 File Offset: 0x00316D38
		public RoleMorph __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003353 RID: 13139
		// (get) Token: 0x0600CFEC RID: 53228 RVA: 0x00318B48 File Offset: 0x00316D48
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

		// Token: 0x17003354 RID: 13140
		// (get) Token: 0x0600CFED RID: 53229 RVA: 0x00318B84 File Offset: 0x00316D84
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

		// Token: 0x17003355 RID: 13141
		// (get) Token: 0x0600CFEE RID: 53230 RVA: 0x00318BC0 File Offset: 0x00316DC0
		public int Morph
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

		// Token: 0x17003356 RID: 13142
		// (get) Token: 0x0600CFEF RID: 53231 RVA: 0x00318BFC File Offset: 0x00316DFC
		public int SkinId
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

		// Token: 0x17003357 RID: 13143
		// (get) Token: 0x0600CFF0 RID: 53232 RVA: 0x00318C3C File Offset: 0x00316E3C
		public int MeshId
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

		// Token: 0x17003358 RID: 13144
		// (get) Token: 0x0600CFF1 RID: 53233 RVA: 0x00318C7C File Offset: 0x00316E7C
		public int UiMeshId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003359 RID: 13145
		// (get) Token: 0x0600CFF2 RID: 53234 RVA: 0x00318CBC File Offset: 0x00316EBC
		public string UiScenePerformanceABP
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

		// Token: 0x0600CFF3 RID: 53235 RVA: 0x00318CF4 File Offset: 0x00316EF4
		public Span<byte> GetUiScenePerformanceABPBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600CFF4 RID: 53236 RVA: 0x00318D04 File Offset: 0x00316F04
		public byte[] GetUiScenePerformanceABPArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700335A RID: 13146
		// (get) Token: 0x0600CFF5 RID: 53237 RVA: 0x00318D1C File Offset: 0x00316F1C
		public string RoleBody
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

		// Token: 0x0600CFF6 RID: 53238 RVA: 0x00318D54 File Offset: 0x00316F54
		public Span<byte> GetRoleBodyBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600CFF7 RID: 53239 RVA: 0x00318D64 File Offset: 0x00316F64
		public byte[] GetRoleBodyArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0400573D RID: 22333
		private Table __p;
	}
}
