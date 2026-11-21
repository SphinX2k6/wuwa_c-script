using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001133 RID: 4403
	public struct RoleExpItem : IFlatbufferObject
	{
		// Token: 0x170032DD RID: 13021
		// (get) Token: 0x0600CECA RID: 52938 RVA: 0x00316078 File Offset: 0x00314278
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CECB RID: 52939 RVA: 0x00316085 File Offset: 0x00314285
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CECC RID: 52940 RVA: 0x0031608C File Offset: 0x0031428C
		public static RoleExpItem GetRootAsRoleExpItem(ByteBuffer _bb)
		{
			return RoleExpItem.GetRootAsRoleExpItem(_bb, default(RoleExpItem));
		}

		// Token: 0x0600CECD RID: 52941 RVA: 0x003160A8 File Offset: 0x003142A8
		public static RoleExpItem GetRootAsRoleExpItem(ByteBuffer _bb, RoleExpItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CECE RID: 52942 RVA: 0x003160C5 File Offset: 0x003142C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CECF RID: 52943 RVA: 0x003160D4 File Offset: 0x003142D4
		public RoleExpItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032DE RID: 13022
		// (get) Token: 0x0600CED0 RID: 52944 RVA: 0x003160E4 File Offset: 0x003142E4
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

		// Token: 0x170032DF RID: 13023
		// (get) Token: 0x0600CED1 RID: 52945 RVA: 0x00316120 File Offset: 0x00314320
		public int BasicExp
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

		// Token: 0x04005731 RID: 22321
		private Table __p;
	}
}
