using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003F9A RID: 16282
	public struct ICheckpointDisplayRole : IFlatbufferObject
	{
		// Token: 0x17006E21 RID: 28193
		// (get) Token: 0x060162FE RID: 90878 RVA: 0x0032E57D File Offset: 0x0032C77D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060162FF RID: 90879 RVA: 0x0032E58A File Offset: 0x0032C78A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016300 RID: 90880 RVA: 0x0032E594 File Offset: 0x0032C794
		public static ICheckpointDisplayRole GetRootAsICheckpointDisplayRole(ByteBuffer _bb)
		{
			return ICheckpointDisplayRole.GetRootAsICheckpointDisplayRole(_bb, default(ICheckpointDisplayRole));
		}

		// Token: 0x06016301 RID: 90881 RVA: 0x0032E5B0 File Offset: 0x0032C7B0
		public static ICheckpointDisplayRole GetRootAsICheckpointDisplayRole(ByteBuffer _bb, ICheckpointDisplayRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016302 RID: 90882 RVA: 0x0032E5CD File Offset: 0x0032C7CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016303 RID: 90883 RVA: 0x0032E5DC File Offset: 0x0032C7DC
		public ICheckpointDisplayRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E22 RID: 28194
		// (get) Token: 0x06016304 RID: 90884 RVA: 0x0032E5EC File Offset: 0x0032C7EC
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

		// Token: 0x17006E23 RID: 28195
		// (get) Token: 0x06016305 RID: 90885 RVA: 0x0032E628 File Offset: 0x0032C828
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

		// Token: 0x06016306 RID: 90886 RVA: 0x0032E664 File Offset: 0x0032C864
		public static Offset<ICheckpointDisplayRole> CreateICheckpointDisplayRole(FlatBufferBuilder builder, ECheckpointDisplayType Type = ECheckpointDisplayType.Role, int RoleId = 0)
		{
			builder.StartTable(2);
			ICheckpointDisplayRole.AddRoleId(builder, RoleId);
			ICheckpointDisplayRole.AddType(builder, Type);
			return ICheckpointDisplayRole.EndICheckpointDisplayRole(builder);
		}

		// Token: 0x06016307 RID: 90887 RVA: 0x0032E681 File Offset: 0x0032C881
		public static void StartICheckpointDisplayRole(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016308 RID: 90888 RVA: 0x0032E68A File Offset: 0x0032C88A
		public static void AddType(FlatBufferBuilder builder, ECheckpointDisplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016309 RID: 90889 RVA: 0x0032E695 File Offset: 0x0032C895
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(1, roleId, 0);
		}

		// Token: 0x0601630A RID: 90890 RVA: 0x0032E6A0 File Offset: 0x0032C8A0
		public static Offset<ICheckpointDisplayRole> EndICheckpointDisplayRole(FlatBufferBuilder builder)
		{
			return new Offset<ICheckpointDisplayRole>(builder.EndTable());
		}

		// Token: 0x0601630B RID: 90891 RVA: 0x0032E6B0 File Offset: 0x0032C8B0
		public ICheckpointDisplayRoleT UnPack()
		{
			ICheckpointDisplayRoleT checkpointDisplayRoleT = new ICheckpointDisplayRoleT();
			this.UnPackTo(checkpointDisplayRoleT);
			return checkpointDisplayRoleT;
		}

		// Token: 0x0601630C RID: 90892 RVA: 0x0032E6CB File Offset: 0x0032C8CB
		public void UnPackTo(ICheckpointDisplayRoleT _o)
		{
			_o.Type = this.Type;
			_o.RoleId = this.RoleId;
		}

		// Token: 0x0601630D RID: 90893 RVA: 0x0032E6E8 File Offset: 0x0032C8E8
		public static Offset<ICheckpointDisplayRole> Pack(FlatBufferBuilder builder, ICheckpointDisplayRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckpointDisplayRole>);
			}
			return ICheckpointDisplayRole.CreateICheckpointDisplayRole(builder, _o.Type, _o.RoleId);
		}

		// Token: 0x0400BA76 RID: 47734
		private Table __p;
	}
}
