using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006425 RID: 25637
	public struct IGiantTriggerRoleState : IFlatbufferObject
	{
		// Token: 0x1700BD56 RID: 48470
		// (get) Token: 0x0602B8F2 RID: 178418 RVA: 0x005EE7B2 File Offset: 0x005EC9B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B8F3 RID: 178419 RVA: 0x005EE7BF File Offset: 0x005EC9BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B8F4 RID: 178420 RVA: 0x005EE7C8 File Offset: 0x005EC9C8
		public static IGiantTriggerRoleState GetRootAsIGiantTriggerRoleState(ByteBuffer _bb)
		{
			return IGiantTriggerRoleState.GetRootAsIGiantTriggerRoleState(_bb, default(IGiantTriggerRoleState));
		}

		// Token: 0x0602B8F5 RID: 178421 RVA: 0x005EE7E4 File Offset: 0x005EC9E4
		public static IGiantTriggerRoleState GetRootAsIGiantTriggerRoleState(ByteBuffer _bb, IGiantTriggerRoleState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B8F6 RID: 178422 RVA: 0x005EE801 File Offset: 0x005ECA01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B8F7 RID: 178423 RVA: 0x005EE810 File Offset: 0x005ECA10
		public IGiantTriggerRoleState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD57 RID: 48471
		// (get) Token: 0x0602B8F8 RID: 178424 RVA: 0x005EE820 File Offset: 0x005ECA20
		public EGiantTriggerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGiantTriggerType.RoleState;
				}
				return (EGiantTriggerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BD58 RID: 48472
		// (get) Token: 0x0602B8F9 RID: 178425 RVA: 0x005EE85C File Offset: 0x005ECA5C
		public EGiantRoleState RoleState
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EGiantRoleState.Death;
				}
				return (EGiantRoleState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B8FA RID: 178426 RVA: 0x005EE898 File Offset: 0x005ECA98
		public static Offset<IGiantTriggerRoleState> CreateIGiantTriggerRoleState(FlatBufferBuilder builder, EGiantTriggerType Type = EGiantTriggerType.RoleState, EGiantRoleState RoleState = EGiantRoleState.Death)
		{
			builder.StartTable(2);
			IGiantTriggerRoleState.AddRoleState(builder, RoleState);
			IGiantTriggerRoleState.AddType(builder, Type);
			return IGiantTriggerRoleState.EndIGiantTriggerRoleState(builder);
		}

		// Token: 0x0602B8FB RID: 178427 RVA: 0x005EE8B5 File Offset: 0x005ECAB5
		public static void StartIGiantTriggerRoleState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B8FC RID: 178428 RVA: 0x005EE8BE File Offset: 0x005ECABE
		public static void AddType(FlatBufferBuilder builder, EGiantTriggerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B8FD RID: 178429 RVA: 0x005EE8C9 File Offset: 0x005ECAC9
		public static void AddRoleState(FlatBufferBuilder builder, EGiantRoleState roleState)
		{
			builder.AddByte(1, (byte)roleState, 0);
		}

		// Token: 0x0602B8FE RID: 178430 RVA: 0x005EE8D4 File Offset: 0x005ECAD4
		public static Offset<IGiantTriggerRoleState> EndIGiantTriggerRoleState(FlatBufferBuilder builder)
		{
			return new Offset<IGiantTriggerRoleState>(builder.EndTable());
		}

		// Token: 0x0602B8FF RID: 178431 RVA: 0x005EE8E4 File Offset: 0x005ECAE4
		public IGiantTriggerRoleStateT UnPack()
		{
			IGiantTriggerRoleStateT giantTriggerRoleStateT = new IGiantTriggerRoleStateT();
			this.UnPackTo(giantTriggerRoleStateT);
			return giantTriggerRoleStateT;
		}

		// Token: 0x0602B900 RID: 178432 RVA: 0x005EE8FF File Offset: 0x005ECAFF
		public void UnPackTo(IGiantTriggerRoleStateT _o)
		{
			_o.Type = this.Type;
			_o.RoleState = this.RoleState;
		}

		// Token: 0x0602B901 RID: 178433 RVA: 0x005EE91C File Offset: 0x005ECB1C
		public static Offset<IGiantTriggerRoleState> Pack(FlatBufferBuilder builder, IGiantTriggerRoleStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantTriggerRoleState>);
			}
			return IGiantTriggerRoleState.CreateIGiantTriggerRoleState(builder, _o.Type, _o.RoleState);
		}

		// Token: 0x0401052D RID: 66861
		private Table __p;
	}
}
