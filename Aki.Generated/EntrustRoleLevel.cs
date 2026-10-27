using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C3D RID: 3133
	public struct EntrustRoleLevel : IFlatbufferObject
	{
		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x06006A31 RID: 27185 RVA: 0x002254E8 File Offset: 0x002236E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006A32 RID: 27186 RVA: 0x002254F5 File Offset: 0x002236F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006A33 RID: 27187 RVA: 0x002254FC File Offset: 0x002236FC
		public static EntrustRoleLevel GetRootAsEntrustRoleLevel(ByteBuffer _bb)
		{
			return EntrustRoleLevel.GetRootAsEntrustRoleLevel(_bb, default(EntrustRoleLevel));
		}

		// Token: 0x06006A34 RID: 27188 RVA: 0x00225518 File Offset: 0x00223718
		public static EntrustRoleLevel GetRootAsEntrustRoleLevel(ByteBuffer _bb, EntrustRoleLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006A35 RID: 27189 RVA: 0x00225535 File Offset: 0x00223735
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006A36 RID: 27190 RVA: 0x00225544 File Offset: 0x00223744
		public EntrustRoleLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06006A37 RID: 27191 RVA: 0x00225554 File Offset: 0x00223754
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

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x06006A38 RID: 27192 RVA: 0x00225590 File Offset: 0x00223790
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

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06006A39 RID: 27193 RVA: 0x002255CC File Offset: 0x002237CC
		public int NeedLike
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

		// Token: 0x04004C7D RID: 19581
		private Table __p;
	}
}
