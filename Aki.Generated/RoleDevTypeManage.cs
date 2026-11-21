using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001130 RID: 4400
	public struct RoleDevTypeManage : IFlatbufferObject
	{
		// Token: 0x170032CE RID: 13006
		// (get) Token: 0x0600CE9D RID: 52893 RVA: 0x00315B35 File Offset: 0x00313D35
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CE9E RID: 52894 RVA: 0x00315B42 File Offset: 0x00313D42
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CE9F RID: 52895 RVA: 0x00315B4C File Offset: 0x00313D4C
		public static RoleDevTypeManage GetRootAsRoleDevTypeManage(ByteBuffer _bb)
		{
			return RoleDevTypeManage.GetRootAsRoleDevTypeManage(_bb, default(RoleDevTypeManage));
		}

		// Token: 0x0600CEA0 RID: 52896 RVA: 0x00315B68 File Offset: 0x00313D68
		public static RoleDevTypeManage GetRootAsRoleDevTypeManage(ByteBuffer _bb, RoleDevTypeManage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CEA1 RID: 52897 RVA: 0x00315B85 File Offset: 0x00313D85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CEA2 RID: 52898 RVA: 0x00315B94 File Offset: 0x00313D94
		public RoleDevTypeManage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032CF RID: 13007
		// (get) Token: 0x0600CEA3 RID: 52899 RVA: 0x00315BA4 File Offset: 0x00313DA4
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

		// Token: 0x170032D0 RID: 13008
		// (get) Token: 0x0600CEA4 RID: 52900 RVA: 0x00315BE0 File Offset: 0x00313DE0
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

		// Token: 0x0600CEA5 RID: 52901 RVA: 0x00315C17 File Offset: 0x00313E17
		public Span<byte> GetTypeDecribeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CEA6 RID: 52902 RVA: 0x00315C26 File Offset: 0x00313E26
		public byte[] GetTypeDecribeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170032D1 RID: 13009
		// (get) Token: 0x0600CEA7 RID: 52903 RVA: 0x00315C40 File Offset: 0x00313E40
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

		// Token: 0x0600CEA8 RID: 52904 RVA: 0x00315C77 File Offset: 0x00313E77
		public Span<byte> GetTypeDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CEA9 RID: 52905 RVA: 0x00315C86 File Offset: 0x00313E86
		public byte[] GetTypeDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400572E RID: 22318
		private Table __p;
	}
}
