using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DE8 RID: 24040
	public struct IGiantTriggerRoleState : IFlatbufferObject
	{
		// Token: 0x1700B3F0 RID: 46064
		// (get) Token: 0x06029268 RID: 168552 RVA: 0x005A5A82 File Offset: 0x005A3C82
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029269 RID: 168553 RVA: 0x005A5A8F File Offset: 0x005A3C8F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602926A RID: 168554 RVA: 0x005A5A98 File Offset: 0x005A3C98
		public static IGiantTriggerRoleState GetRootAsIGiantTriggerRoleState(ByteBuffer _bb)
		{
			return IGiantTriggerRoleState.GetRootAsIGiantTriggerRoleState(_bb, default(IGiantTriggerRoleState));
		}

		// Token: 0x0602926B RID: 168555 RVA: 0x005A5AB4 File Offset: 0x005A3CB4
		public static IGiantTriggerRoleState GetRootAsIGiantTriggerRoleState(ByteBuffer _bb, IGiantTriggerRoleState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602926C RID: 168556 RVA: 0x005A5AD1 File Offset: 0x005A3CD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602926D RID: 168557 RVA: 0x005A5AE0 File Offset: 0x005A3CE0
		public IGiantTriggerRoleState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3F1 RID: 46065
		// (get) Token: 0x0602926E RID: 168558 RVA: 0x005A5AF0 File Offset: 0x005A3CF0
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

		// Token: 0x1700B3F2 RID: 46066
		// (get) Token: 0x0602926F RID: 168559 RVA: 0x005A5B2C File Offset: 0x005A3D2C
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

		// Token: 0x06029270 RID: 168560 RVA: 0x005A5B68 File Offset: 0x005A3D68
		public static Offset<IGiantTriggerRoleState> CreateIGiantTriggerRoleState(FlatBufferBuilder builder, EGiantTriggerType Type = EGiantTriggerType.RoleState, EGiantRoleState RoleState = EGiantRoleState.Death)
		{
			builder.StartTable(2);
			IGiantTriggerRoleState.AddRoleState(builder, RoleState);
			IGiantTriggerRoleState.AddType(builder, Type);
			return IGiantTriggerRoleState.EndIGiantTriggerRoleState(builder);
		}

		// Token: 0x06029271 RID: 168561 RVA: 0x005A5B85 File Offset: 0x005A3D85
		public static void StartIGiantTriggerRoleState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029272 RID: 168562 RVA: 0x005A5B8E File Offset: 0x005A3D8E
		public static void AddType(FlatBufferBuilder builder, EGiantTriggerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029273 RID: 168563 RVA: 0x005A5B99 File Offset: 0x005A3D99
		public static void AddRoleState(FlatBufferBuilder builder, EGiantRoleState roleState)
		{
			builder.AddByte(1, (byte)roleState, 0);
		}

		// Token: 0x06029274 RID: 168564 RVA: 0x005A5BA4 File Offset: 0x005A3DA4
		public static Offset<IGiantTriggerRoleState> EndIGiantTriggerRoleState(FlatBufferBuilder builder)
		{
			return new Offset<IGiantTriggerRoleState>(builder.EndTable());
		}

		// Token: 0x06029275 RID: 168565 RVA: 0x005A5BB4 File Offset: 0x005A3DB4
		public IGiantTriggerRoleStateT UnPack()
		{
			IGiantTriggerRoleStateT giantTriggerRoleStateT = new IGiantTriggerRoleStateT();
			this.UnPackTo(giantTriggerRoleStateT);
			return giantTriggerRoleStateT;
		}

		// Token: 0x06029276 RID: 168566 RVA: 0x005A5BCF File Offset: 0x005A3DCF
		public void UnPackTo(IGiantTriggerRoleStateT _o)
		{
			_o.Type = this.Type;
			_o.RoleState = this.RoleState;
		}

		// Token: 0x06029277 RID: 168567 RVA: 0x005A5BEC File Offset: 0x005A3DEC
		public static Offset<IGiantTriggerRoleState> Pack(FlatBufferBuilder builder, IGiantTriggerRoleStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantTriggerRoleState>);
			}
			return IGiantTriggerRoleState.CreateIGiantTriggerRoleState(builder, _o.Type, _o.RoleState);
		}

		// Token: 0x0400F7D2 RID: 63442
		private Table __p;
	}
}
