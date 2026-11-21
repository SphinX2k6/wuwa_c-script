using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D20 RID: 3360
	public struct EntrustRoleLevel : IFlatbufferObject
	{
		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x06007033 RID: 28723 RVA: 0x00244830 File Offset: 0x00242A30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007034 RID: 28724 RVA: 0x0024483D File Offset: 0x00242A3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007035 RID: 28725 RVA: 0x00244844 File Offset: 0x00242A44
		public static EntrustRoleLevel GetRootAsEntrustRoleLevel(ByteBuffer _bb)
		{
			return EntrustRoleLevel.GetRootAsEntrustRoleLevel(_bb, default(EntrustRoleLevel));
		}

		// Token: 0x06007036 RID: 28726 RVA: 0x00244860 File Offset: 0x00242A60
		public static EntrustRoleLevel GetRootAsEntrustRoleLevel(ByteBuffer _bb, EntrustRoleLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007037 RID: 28727 RVA: 0x0024487D File Offset: 0x00242A7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007038 RID: 28728 RVA: 0x0024488C File Offset: 0x00242A8C
		public EntrustRoleLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x06007039 RID: 28729 RVA: 0x0024489C File Offset: 0x00242A9C
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

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x0600703A RID: 28730 RVA: 0x002448D8 File Offset: 0x00242AD8
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

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x0600703B RID: 28731 RVA: 0x00244914 File Offset: 0x00242B14
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

		// Token: 0x04005260 RID: 21088
		private Table __p;
	}
}
