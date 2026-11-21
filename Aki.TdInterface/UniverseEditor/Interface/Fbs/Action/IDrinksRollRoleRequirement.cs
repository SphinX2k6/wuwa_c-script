using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C80 RID: 27776
	public struct IDrinksRollRoleRequirement : IFlatbufferObject
	{
		// Token: 0x1700CBBD RID: 52157
		// (get) Token: 0x0602FDA8 RID: 196008 RVA: 0x006842A9 File Offset: 0x006824A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FDA9 RID: 196009 RVA: 0x006842B6 File Offset: 0x006824B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FDAA RID: 196010 RVA: 0x006842C0 File Offset: 0x006824C0
		public static IDrinksRollRoleRequirement GetRootAsIDrinksRollRoleRequirement(ByteBuffer _bb)
		{
			return IDrinksRollRoleRequirement.GetRootAsIDrinksRollRoleRequirement(_bb, default(IDrinksRollRoleRequirement));
		}

		// Token: 0x0602FDAB RID: 196011 RVA: 0x006842DC File Offset: 0x006824DC
		public static IDrinksRollRoleRequirement GetRootAsIDrinksRollRoleRequirement(ByteBuffer _bb, IDrinksRollRoleRequirement obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FDAC RID: 196012 RVA: 0x006842F9 File Offset: 0x006824F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FDAD RID: 196013 RVA: 0x00684308 File Offset: 0x00682508
		public IDrinksRollRoleRequirement __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBBE RID: 52158
		// (get) Token: 0x0602FDAE RID: 196014 RVA: 0x00684318 File Offset: 0x00682518
		public int RoleId
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

		// Token: 0x1700CBBF RID: 52159
		// (get) Token: 0x0602FDAF RID: 196015 RVA: 0x00684354 File Offset: 0x00682554
		public int RequirementId
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

		// Token: 0x1700CBC0 RID: 52160
		// (get) Token: 0x0602FDB0 RID: 196016 RVA: 0x00684390 File Offset: 0x00682590
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FDB1 RID: 196017 RVA: 0x006843CC File Offset: 0x006825CC
		public static Offset<IDrinksRollRoleRequirement> CreateIDrinksRollRoleRequirement(FlatBufferBuilder builder, int RoleId = 0, int RequirementId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IDrinksRollRoleRequirement.AddRequirementId(builder, RequirementId);
			IDrinksRollRoleRequirement.AddRoleId(builder, RoleId);
			IDrinksRollRoleRequirement.AddNullMask(builder, NullMask);
			return IDrinksRollRoleRequirement.EndIDrinksRollRoleRequirement(builder);
		}

		// Token: 0x0602FDB2 RID: 196018 RVA: 0x006843F0 File Offset: 0x006825F0
		public static void StartIDrinksRollRoleRequirement(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602FDB3 RID: 196019 RVA: 0x006843F9 File Offset: 0x006825F9
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(0, roleId, 0);
		}

		// Token: 0x0602FDB4 RID: 196020 RVA: 0x00684404 File Offset: 0x00682604
		public static void AddRequirementId(FlatBufferBuilder builder, int requirementId)
		{
			builder.AddInt(1, requirementId, 0);
		}

		// Token: 0x0602FDB5 RID: 196021 RVA: 0x0068440F File Offset: 0x0068260F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602FDB6 RID: 196022 RVA: 0x0068441A File Offset: 0x0068261A
		public static Offset<IDrinksRollRoleRequirement> EndIDrinksRollRoleRequirement(FlatBufferBuilder builder)
		{
			return new Offset<IDrinksRollRoleRequirement>(builder.EndTable());
		}

		// Token: 0x0602FDB7 RID: 196023 RVA: 0x00684428 File Offset: 0x00682628
		public IDrinksRollRoleRequirementT UnPack()
		{
			IDrinksRollRoleRequirementT drinksRollRoleRequirementT = new IDrinksRollRoleRequirementT();
			this.UnPackTo(drinksRollRoleRequirementT);
			return drinksRollRoleRequirementT;
		}

		// Token: 0x0602FDB8 RID: 196024 RVA: 0x00684443 File Offset: 0x00682643
		public void UnPackTo(IDrinksRollRoleRequirementT _o)
		{
			_o.RoleId = this.RoleId;
			_o.RequirementId = this.RequirementId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602FDB9 RID: 196025 RVA: 0x0068446C File Offset: 0x0068266C
		public static Offset<IDrinksRollRoleRequirement> Pack(FlatBufferBuilder builder, IDrinksRollRoleRequirementT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDrinksRollRoleRequirement>);
			}
			return IDrinksRollRoleRequirement.CreateIDrinksRollRoleRequirement(builder, _o.RoleId, _o.RequirementId, _o.NullMask);
		}

		// Token: 0x04011AB0 RID: 72368
		private Table __p;
	}
}
