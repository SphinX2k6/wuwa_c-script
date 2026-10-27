using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003B92 RID: 15250
	public struct ICheckpointDisplayRole : IFlatbufferObject
	{
		// Token: 0x17006882 RID: 26754
		// (get) Token: 0x06014E34 RID: 85556 RVA: 0x00307FE5 File Offset: 0x003061E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014E35 RID: 85557 RVA: 0x00307FF2 File Offset: 0x003061F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014E36 RID: 85558 RVA: 0x00307FFC File Offset: 0x003061FC
		public static ICheckpointDisplayRole GetRootAsICheckpointDisplayRole(ByteBuffer _bb)
		{
			return ICheckpointDisplayRole.GetRootAsICheckpointDisplayRole(_bb, default(ICheckpointDisplayRole));
		}

		// Token: 0x06014E37 RID: 85559 RVA: 0x00308018 File Offset: 0x00306218
		public static ICheckpointDisplayRole GetRootAsICheckpointDisplayRole(ByteBuffer _bb, ICheckpointDisplayRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014E38 RID: 85560 RVA: 0x00308035 File Offset: 0x00306235
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014E39 RID: 85561 RVA: 0x00308044 File Offset: 0x00306244
		public ICheckpointDisplayRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006883 RID: 26755
		// (get) Token: 0x06014E3A RID: 85562 RVA: 0x00308054 File Offset: 0x00306254
		public ECheckpointDisplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckpointDisplayType.Role;
				}
				return (ECheckpointDisplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006884 RID: 26756
		// (get) Token: 0x06014E3B RID: 85563 RVA: 0x00308090 File Offset: 0x00306290
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

		// Token: 0x06014E3C RID: 85564 RVA: 0x003080CC File Offset: 0x003062CC
		public static Offset<ICheckpointDisplayRole> CreateICheckpointDisplayRole(FlatBufferBuilder builder, ECheckpointDisplayType Type = ECheckpointDisplayType.Role, int RoleId = 0)
		{
			builder.StartTable(2);
			ICheckpointDisplayRole.AddRoleId(builder, RoleId);
			ICheckpointDisplayRole.AddType(builder, Type);
			return ICheckpointDisplayRole.EndICheckpointDisplayRole(builder);
		}

		// Token: 0x06014E3D RID: 85565 RVA: 0x003080E9 File Offset: 0x003062E9
		public static void StartICheckpointDisplayRole(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06014E3E RID: 85566 RVA: 0x003080F2 File Offset: 0x003062F2
		public static void AddType(FlatBufferBuilder builder, ECheckpointDisplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014E3F RID: 85567 RVA: 0x003080FD File Offset: 0x003062FD
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(1, roleId, 0);
		}

		// Token: 0x06014E40 RID: 85568 RVA: 0x00308108 File Offset: 0x00306308
		public static Offset<ICheckpointDisplayRole> EndICheckpointDisplayRole(FlatBufferBuilder builder)
		{
			return new Offset<ICheckpointDisplayRole>(builder.EndTable());
		}

		// Token: 0x06014E41 RID: 85569 RVA: 0x00308118 File Offset: 0x00306318
		public ICheckpointDisplayRoleT UnPack()
		{
			ICheckpointDisplayRoleT checkpointDisplayRoleT = new ICheckpointDisplayRoleT();
			this.UnPackTo(checkpointDisplayRoleT);
			return checkpointDisplayRoleT;
		}

		// Token: 0x06014E42 RID: 85570 RVA: 0x00308133 File Offset: 0x00306333
		public void UnPackTo(ICheckpointDisplayRoleT _o)
		{
			_o.Type = this.Type;
			_o.RoleId = this.RoleId;
		}

		// Token: 0x06014E43 RID: 85571 RVA: 0x00308150 File Offset: 0x00306350
		public static Offset<ICheckpointDisplayRole> Pack(FlatBufferBuilder builder, ICheckpointDisplayRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckpointDisplayRole>);
			}
			return ICheckpointDisplayRole.CreateICheckpointDisplayRole(builder, _o.Type, _o.RoleId);
		}

		// Token: 0x0400B0F9 RID: 45305
		private Table __p;
	}
}
