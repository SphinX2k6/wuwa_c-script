using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004639 RID: 17977
	public struct IAddNewRole : IFlatbufferObject
	{
		// Token: 0x17007F91 RID: 32657
		// (get) Token: 0x0601B3A1 RID: 111521 RVA: 0x003E0300 File Offset: 0x003DE500
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B3A2 RID: 111522 RVA: 0x003E030D File Offset: 0x003DE50D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B3A3 RID: 111523 RVA: 0x003E0314 File Offset: 0x003DE514
		public static IAddNewRole GetRootAsIAddNewRole(ByteBuffer _bb)
		{
			return IAddNewRole.GetRootAsIAddNewRole(_bb, default(IAddNewRole));
		}

		// Token: 0x0601B3A4 RID: 111524 RVA: 0x003E0330 File Offset: 0x003DE530
		public static IAddNewRole GetRootAsIAddNewRole(ByteBuffer _bb, IAddNewRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B3A5 RID: 111525 RVA: 0x003E034D File Offset: 0x003DE54D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B3A6 RID: 111526 RVA: 0x003E035C File Offset: 0x003DE55C
		public IAddNewRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F92 RID: 32658
		// (get) Token: 0x0601B3A7 RID: 111527 RVA: 0x003E036C File Offset: 0x003DE56C
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

		// Token: 0x17007F93 RID: 32659
		// (get) Token: 0x0601B3A8 RID: 111528 RVA: 0x003E03A8 File Offset: 0x003DE5A8
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

		// Token: 0x0601B3A9 RID: 111529 RVA: 0x003E03E4 File Offset: 0x003DE5E4
		public static Offset<IAddNewRole> CreateIAddNewRole(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int RoleId = 0)
		{
			builder.StartTable(2);
			IAddNewRole.AddRoleId(builder, RoleId);
			IAddNewRole.AddType(builder, Type);
			return IAddNewRole.EndIAddNewRole(builder);
		}

		// Token: 0x0601B3AA RID: 111530 RVA: 0x003E0401 File Offset: 0x003DE601
		public static void StartIAddNewRole(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B3AB RID: 111531 RVA: 0x003E040A File Offset: 0x003DE60A
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B3AC RID: 111532 RVA: 0x003E0415 File Offset: 0x003DE615
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(1, roleId, 0);
		}

		// Token: 0x0601B3AD RID: 111533 RVA: 0x003E0420 File Offset: 0x003DE620
		public static Offset<IAddNewRole> EndIAddNewRole(FlatBufferBuilder builder)
		{
			return new Offset<IAddNewRole>(builder.EndTable());
		}

		// Token: 0x0601B3AE RID: 111534 RVA: 0x003E0430 File Offset: 0x003DE630
		public IAddNewRoleT UnPack()
		{
			IAddNewRoleT addNewRoleT = new IAddNewRoleT();
			this.UnPackTo(addNewRoleT);
			return addNewRoleT;
		}

		// Token: 0x0601B3AF RID: 111535 RVA: 0x003E044B File Offset: 0x003DE64B
		public void UnPackTo(IAddNewRoleT _o)
		{
			_o.Type = this.Type;
			_o.RoleId = this.RoleId;
		}

		// Token: 0x0601B3B0 RID: 111536 RVA: 0x003E0468 File Offset: 0x003DE668
		public static Offset<IAddNewRole> Pack(FlatBufferBuilder builder, IAddNewRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddNewRole>);
			}
			return IAddNewRole.CreateIAddNewRole(builder, _o.Type, _o.RoleId);
		}

		// Token: 0x0400C7B0 RID: 51120
		private Table __p;
	}
}
