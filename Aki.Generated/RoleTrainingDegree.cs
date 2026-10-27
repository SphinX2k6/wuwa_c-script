using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001062 RID: 4194
	public struct RoleTrainingDegree : IFlatbufferObject
	{
		// Token: 0x1700337A RID: 13178
		// (get) Token: 0x0600CB6E RID: 52078 RVA: 0x00300D44 File Offset: 0x002FEF44
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CB6F RID: 52079 RVA: 0x00300D51 File Offset: 0x002FEF51
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CB70 RID: 52080 RVA: 0x00300D58 File Offset: 0x002FEF58
		public static RoleTrainingDegree GetRootAsRoleTrainingDegree(ByteBuffer _bb)
		{
			return RoleTrainingDegree.GetRootAsRoleTrainingDegree(_bb, default(RoleTrainingDegree));
		}

		// Token: 0x0600CB71 RID: 52081 RVA: 0x00300D74 File Offset: 0x002FEF74
		public static RoleTrainingDegree GetRootAsRoleTrainingDegree(ByteBuffer _bb, RoleTrainingDegree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CB72 RID: 52082 RVA: 0x00300D91 File Offset: 0x002FEF91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CB73 RID: 52083 RVA: 0x00300DA0 File Offset: 0x002FEFA0
		public RoleTrainingDegree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700337B RID: 13179
		// (get) Token: 0x0600CB74 RID: 52084 RVA: 0x00300DB0 File Offset: 0x002FEFB0
		public int DifficultyLevel
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

		// Token: 0x1700337C RID: 13180
		// (get) Token: 0x0600CB75 RID: 52085 RVA: 0x00300DEC File Offset: 0x002FEFEC
		public int RoleLevel
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

		// Token: 0x1700337D RID: 13181
		// (get) Token: 0x0600CB76 RID: 52086 RVA: 0x00300E28 File Offset: 0x002FF028
		public int WeaponLevel
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

		// Token: 0x1700337E RID: 13182
		// (get) Token: 0x0600CB77 RID: 52087 RVA: 0x00300E64 File Offset: 0x002FF064
		public int EquipLevel
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

		// Token: 0x1700337F RID: 13183
		// (get) Token: 0x0600CB78 RID: 52088 RVA: 0x00300EA4 File Offset: 0x002FF0A4
		public int SkillLevel
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

		// Token: 0x04005166 RID: 20838
		private Table __p;
	}
}
