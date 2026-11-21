using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200115D RID: 4445
	public struct RoleTrainingDegree : IFlatbufferObject
	{
		// Token: 0x17003487 RID: 13447
		// (get) Token: 0x0600D341 RID: 54081 RVA: 0x00320638 File Offset: 0x0031E838
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D342 RID: 54082 RVA: 0x00320645 File Offset: 0x0031E845
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D343 RID: 54083 RVA: 0x0032064C File Offset: 0x0031E84C
		public static RoleTrainingDegree GetRootAsRoleTrainingDegree(ByteBuffer _bb)
		{
			return RoleTrainingDegree.GetRootAsRoleTrainingDegree(_bb, default(RoleTrainingDegree));
		}

		// Token: 0x0600D344 RID: 54084 RVA: 0x00320668 File Offset: 0x0031E868
		public static RoleTrainingDegree GetRootAsRoleTrainingDegree(ByteBuffer _bb, RoleTrainingDegree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D345 RID: 54085 RVA: 0x00320685 File Offset: 0x0031E885
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D346 RID: 54086 RVA: 0x00320694 File Offset: 0x0031E894
		public RoleTrainingDegree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003488 RID: 13448
		// (get) Token: 0x0600D347 RID: 54087 RVA: 0x003206A4 File Offset: 0x0031E8A4
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

		// Token: 0x17003489 RID: 13449
		// (get) Token: 0x0600D348 RID: 54088 RVA: 0x003206E0 File Offset: 0x0031E8E0
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

		// Token: 0x1700348A RID: 13450
		// (get) Token: 0x0600D349 RID: 54089 RVA: 0x0032071C File Offset: 0x0031E91C
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

		// Token: 0x1700348B RID: 13451
		// (get) Token: 0x0600D34A RID: 54090 RVA: 0x00320758 File Offset: 0x0031E958
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

		// Token: 0x1700348C RID: 13452
		// (get) Token: 0x0600D34B RID: 54091 RVA: 0x00320798 File Offset: 0x0031E998
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

		// Token: 0x04005765 RID: 22373
		private Table __p;
	}
}
