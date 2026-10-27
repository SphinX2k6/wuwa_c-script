using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200660F RID: 26127
	public struct IDrinksRollRoleRequirement : IFlatbufferObject
	{
		// Token: 0x1700C21F RID: 49695
		// (get) Token: 0x0602D5D7 RID: 185815 RVA: 0x00637741 File Offset: 0x00635941
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D5D8 RID: 185816 RVA: 0x0063774E File Offset: 0x0063594E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D5D9 RID: 185817 RVA: 0x00637758 File Offset: 0x00635958
		public static IDrinksRollRoleRequirement GetRootAsIDrinksRollRoleRequirement(ByteBuffer _bb)
		{
			return IDrinksRollRoleRequirement.GetRootAsIDrinksRollRoleRequirement(_bb, default(IDrinksRollRoleRequirement));
		}

		// Token: 0x0602D5DA RID: 185818 RVA: 0x00637774 File Offset: 0x00635974
		public static IDrinksRollRoleRequirement GetRootAsIDrinksRollRoleRequirement(ByteBuffer _bb, IDrinksRollRoleRequirement obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D5DB RID: 185819 RVA: 0x00637791 File Offset: 0x00635991
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D5DC RID: 185820 RVA: 0x006377A0 File Offset: 0x006359A0
		public IDrinksRollRoleRequirement __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C220 RID: 49696
		// (get) Token: 0x0602D5DD RID: 185821 RVA: 0x006377B0 File Offset: 0x006359B0
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

		// Token: 0x1700C221 RID: 49697
		// (get) Token: 0x0602D5DE RID: 185822 RVA: 0x006377EC File Offset: 0x006359EC
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

		// Token: 0x1700C222 RID: 49698
		// (get) Token: 0x0602D5DF RID: 185823 RVA: 0x00637828 File Offset: 0x00635A28
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

		// Token: 0x0602D5E0 RID: 185824 RVA: 0x00637864 File Offset: 0x00635A64
		public static Offset<IDrinksRollRoleRequirement> CreateIDrinksRollRoleRequirement(FlatBufferBuilder builder, int RoleId = 0, int RequirementId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IDrinksRollRoleRequirement.AddRequirementId(builder, RequirementId);
			IDrinksRollRoleRequirement.AddRoleId(builder, RoleId);
			IDrinksRollRoleRequirement.AddNullMask(builder, NullMask);
			return IDrinksRollRoleRequirement.EndIDrinksRollRoleRequirement(builder);
		}

		// Token: 0x0602D5E1 RID: 185825 RVA: 0x00637888 File Offset: 0x00635A88
		public static void StartIDrinksRollRoleRequirement(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602D5E2 RID: 185826 RVA: 0x00637891 File Offset: 0x00635A91
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(0, roleId, 0);
		}

		// Token: 0x0602D5E3 RID: 185827 RVA: 0x0063789C File Offset: 0x00635A9C
		public static void AddRequirementId(FlatBufferBuilder builder, int requirementId)
		{
			builder.AddInt(1, requirementId, 0);
		}

		// Token: 0x0602D5E4 RID: 185828 RVA: 0x006378A7 File Offset: 0x00635AA7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602D5E5 RID: 185829 RVA: 0x006378B2 File Offset: 0x00635AB2
		public static Offset<IDrinksRollRoleRequirement> EndIDrinksRollRoleRequirement(FlatBufferBuilder builder)
		{
			return new Offset<IDrinksRollRoleRequirement>(builder.EndTable());
		}

		// Token: 0x0602D5E6 RID: 185830 RVA: 0x006378C0 File Offset: 0x00635AC0
		public IDrinksRollRoleRequirementT UnPack()
		{
			IDrinksRollRoleRequirementT drinksRollRoleRequirementT = new IDrinksRollRoleRequirementT();
			this.UnPackTo(drinksRollRoleRequirementT);
			return drinksRollRoleRequirementT;
		}

		// Token: 0x0602D5E7 RID: 185831 RVA: 0x006378DB File Offset: 0x00635ADB
		public void UnPackTo(IDrinksRollRoleRequirementT _o)
		{
			_o.RoleId = this.RoleId;
			_o.RequirementId = this.RequirementId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D5E8 RID: 185832 RVA: 0x00637904 File Offset: 0x00635B04
		public static Offset<IDrinksRollRoleRequirement> Pack(FlatBufferBuilder builder, IDrinksRollRoleRequirementT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDrinksRollRoleRequirement>);
			}
			return IDrinksRollRoleRequirement.CreateIDrinksRollRoleRequirement(builder, _o.RoleId, _o.RequirementId, _o.NullMask);
		}

		// Token: 0x04010C95 RID: 68757
		private Table __p;
	}
}
