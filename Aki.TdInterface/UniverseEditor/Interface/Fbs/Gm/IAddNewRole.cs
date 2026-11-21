using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AA1 RID: 19105
	public struct IAddNewRole : IFlatbufferObject
	{
		// Token: 0x170085D2 RID: 34258
		// (get) Token: 0x0601CB76 RID: 117622 RVA: 0x0040C59C File Offset: 0x0040A79C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CB77 RID: 117623 RVA: 0x0040C5A9 File Offset: 0x0040A7A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CB78 RID: 117624 RVA: 0x0040C5B0 File Offset: 0x0040A7B0
		public static IAddNewRole GetRootAsIAddNewRole(ByteBuffer _bb)
		{
			return IAddNewRole.GetRootAsIAddNewRole(_bb, default(IAddNewRole));
		}

		// Token: 0x0601CB79 RID: 117625 RVA: 0x0040C5CC File Offset: 0x0040A7CC
		public static IAddNewRole GetRootAsIAddNewRole(ByteBuffer _bb, IAddNewRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CB7A RID: 117626 RVA: 0x0040C5E9 File Offset: 0x0040A7E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CB7B RID: 117627 RVA: 0x0040C5F8 File Offset: 0x0040A7F8
		public IAddNewRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170085D3 RID: 34259
		// (get) Token: 0x0601CB7C RID: 117628 RVA: 0x0040C608 File Offset: 0x0040A808
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170085D4 RID: 34260
		// (get) Token: 0x0601CB7D RID: 117629 RVA: 0x0040C644 File Offset: 0x0040A844
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

		// Token: 0x0601CB7E RID: 117630 RVA: 0x0040C680 File Offset: 0x0040A880
		public static Offset<IAddNewRole> CreateIAddNewRole(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int RoleId = 0)
		{
			builder.StartTable(2);
			IAddNewRole.AddRoleId(builder, RoleId);
			IAddNewRole.AddType(builder, Type);
			return IAddNewRole.EndIAddNewRole(builder);
		}

		// Token: 0x0601CB7F RID: 117631 RVA: 0x0040C69D File Offset: 0x0040A89D
		public static void StartIAddNewRole(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601CB80 RID: 117632 RVA: 0x0040C6A6 File Offset: 0x0040A8A6
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CB81 RID: 117633 RVA: 0x0040C6B1 File Offset: 0x0040A8B1
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(1, roleId, 0);
		}

		// Token: 0x0601CB82 RID: 117634 RVA: 0x0040C6BC File Offset: 0x0040A8BC
		public static Offset<IAddNewRole> EndIAddNewRole(FlatBufferBuilder builder)
		{
			return new Offset<IAddNewRole>(builder.EndTable());
		}

		// Token: 0x0601CB83 RID: 117635 RVA: 0x0040C6CC File Offset: 0x0040A8CC
		public IAddNewRoleT UnPack()
		{
			IAddNewRoleT addNewRoleT = new IAddNewRoleT();
			this.UnPackTo(addNewRoleT);
			return addNewRoleT;
		}

		// Token: 0x0601CB84 RID: 117636 RVA: 0x0040C6E7 File Offset: 0x0040A8E7
		public void UnPackTo(IAddNewRoleT _o)
		{
			_o.Type = this.Type;
			_o.RoleId = this.RoleId;
		}

		// Token: 0x0601CB85 RID: 117637 RVA: 0x0040C704 File Offset: 0x0040A904
		public static Offset<IAddNewRole> Pack(FlatBufferBuilder builder, IAddNewRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddNewRole>);
			}
			return IAddNewRole.CreateIAddNewRole(builder, _o.Type, _o.RoleId);
		}

		// Token: 0x0400D1DF RID: 53727
		private Table __p;
	}
}
