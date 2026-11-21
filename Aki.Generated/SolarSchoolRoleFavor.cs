using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011FD RID: 4605
	public struct SolarSchoolRoleFavor : IFlatbufferObject
	{
		// Token: 0x17003A62 RID: 14946
		// (get) Token: 0x0600E356 RID: 58198 RVA: 0x003453DC File Offset: 0x003435DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E357 RID: 58199 RVA: 0x003453E9 File Offset: 0x003435E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E358 RID: 58200 RVA: 0x003453F0 File Offset: 0x003435F0
		public static SolarSchoolRoleFavor GetRootAsSolarSchoolRoleFavor(ByteBuffer _bb)
		{
			return SolarSchoolRoleFavor.GetRootAsSolarSchoolRoleFavor(_bb, default(SolarSchoolRoleFavor));
		}

		// Token: 0x0600E359 RID: 58201 RVA: 0x0034540C File Offset: 0x0034360C
		public static SolarSchoolRoleFavor GetRootAsSolarSchoolRoleFavor(ByteBuffer _bb, SolarSchoolRoleFavor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E35A RID: 58202 RVA: 0x00345429 File Offset: 0x00343629
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E35B RID: 58203 RVA: 0x00345438 File Offset: 0x00343638
		public SolarSchoolRoleFavor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A63 RID: 14947
		// (get) Token: 0x0600E35C RID: 58204 RVA: 0x00345448 File Offset: 0x00343648
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

		// Token: 0x17003A64 RID: 14948
		// (get) Token: 0x0600E35D RID: 58205 RVA: 0x00345484 File Offset: 0x00343684
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

		// Token: 0x17003A65 RID: 14949
		// (get) Token: 0x0600E35E RID: 58206 RVA: 0x003454C0 File Offset: 0x003436C0
		public int ItemId
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

		// Token: 0x17003A66 RID: 14950
		// (get) Token: 0x0600E35F RID: 58207 RVA: 0x003454FC File Offset: 0x003436FC
		public int PreferenceType
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

		// Token: 0x17003A67 RID: 14951
		// (get) Token: 0x0600E360 RID: 58208 RVA: 0x0034553C File Offset: 0x0034373C
		public int FavorValue
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

		// Token: 0x17003A68 RID: 14952
		// (get) Token: 0x0600E361 RID: 58209 RVA: 0x0034557C File Offset: 0x0034377C
		public int ConditionId
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

		// Token: 0x0400583B RID: 22587
		private Table __p;
	}
}
