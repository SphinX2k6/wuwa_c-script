using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001048 RID: 4168
	public struct RoleDevTypeManage : IFlatbufferObject
	{
		// Token: 0x17003253 RID: 12883
		// (get) Token: 0x0600C853 RID: 51283 RVA: 0x002F9E4D File Offset: 0x002F804D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C854 RID: 51284 RVA: 0x002F9E5A File Offset: 0x002F805A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C855 RID: 51285 RVA: 0x002F9E64 File Offset: 0x002F8064
		public static RoleDevTypeManage GetRootAsRoleDevTypeManage(ByteBuffer _bb)
		{
			return RoleDevTypeManage.GetRootAsRoleDevTypeManage(_bb, default(RoleDevTypeManage));
		}

		// Token: 0x0600C856 RID: 51286 RVA: 0x002F9E80 File Offset: 0x002F8080
		public static RoleDevTypeManage GetRootAsRoleDevTypeManage(ByteBuffer _bb, RoleDevTypeManage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C857 RID: 51287 RVA: 0x002F9E9D File Offset: 0x002F809D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C858 RID: 51288 RVA: 0x002F9EAC File Offset: 0x002F80AC
		public RoleDevTypeManage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003254 RID: 12884
		// (get) Token: 0x0600C859 RID: 51289 RVA: 0x002F9EBC File Offset: 0x002F80BC
		public int ItemType
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

		// Token: 0x17003255 RID: 12885
		// (get) Token: 0x0600C85A RID: 51290 RVA: 0x002F9EF8 File Offset: 0x002F80F8
		public string TypeDecribe
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

		// Token: 0x0600C85B RID: 51291 RVA: 0x002F9F2F File Offset: 0x002F812F
		public Span<byte> GetTypeDecribeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C85C RID: 51292 RVA: 0x002F9F3E File Offset: 0x002F813E
		public byte[] GetTypeDecribeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003256 RID: 12886
		// (get) Token: 0x0600C85D RID: 51293 RVA: 0x002F9F58 File Offset: 0x002F8158
		public string TypeDescribe
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

		// Token: 0x0600C85E RID: 51294 RVA: 0x002F9F8F File Offset: 0x002F818F
		public Span<byte> GetTypeDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C85F RID: 51295 RVA: 0x002F9F9E File Offset: 0x002F819E
		public byte[] GetTypeDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005146 RID: 20806
		private Table __p;
	}
}
