using System;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056CB RID: 22219
	public struct IPasserbyNpcMoveState : IFlatbufferObject
	{
		// Token: 0x1700A557 RID: 42327
		// (get) Token: 0x060251D0 RID: 152016 RVA: 0x0051FB46 File Offset: 0x0051DD46
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060251D1 RID: 152017 RVA: 0x0051FB53 File Offset: 0x0051DD53
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060251D2 RID: 152018 RVA: 0x0051FB5C File Offset: 0x0051DD5C
		public static IPasserbyNpcMoveState GetRootAsIPasserbyNpcMoveState(ByteBuffer _bb)
		{
			return IPasserbyNpcMoveState.GetRootAsIPasserbyNpcMoveState(_bb, default(IPasserbyNpcMoveState));
		}

		// Token: 0x060251D3 RID: 152019 RVA: 0x0051FB78 File Offset: 0x0051DD78
		public static IPasserbyNpcMoveState GetRootAsIPasserbyNpcMoveState(ByteBuffer _bb, IPasserbyNpcMoveState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060251D4 RID: 152020 RVA: 0x0051FB95 File Offset: 0x0051DD95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060251D5 RID: 152021 RVA: 0x0051FBA4 File Offset: 0x0051DDA4
		public IPasserbyNpcMoveState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A558 RID: 42328
		// (get) Token: 0x060251D6 RID: 152022 RVA: 0x0051FBB4 File Offset: 0x0051DDB4
		public EPatrolMoveState MoveState
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPatrolMoveState.None;
				}
				return (EPatrolMoveState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A559 RID: 42329
		// (get) Token: 0x060251D7 RID: 152023 RVA: 0x0051FBF0 File Offset: 0x0051DDF0
		public ECharPositionStateType CharPositionState
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECharPositionStateType.Ground;
				}
				return (ECharPositionStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A55A RID: 42330
		// (get) Token: 0x060251D8 RID: 152024 RVA: 0x0051FC2C File Offset: 0x0051DE2C
		public int MoveSpeed
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

		// Token: 0x1700A55B RID: 42331
		// (get) Token: 0x060251D9 RID: 152025 RVA: 0x0051FC68 File Offset: 0x0051DE68
		public bool UseAbpMappingSpeed
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A55C RID: 42332
		// (get) Token: 0x060251DA RID: 152026 RVA: 0x0051FCA8 File Offset: 0x0051DEA8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060251DB RID: 152027 RVA: 0x0051FCE5 File Offset: 0x0051DEE5
		public static Offset<IPasserbyNpcMoveState> CreateIPasserbyNpcMoveState(FlatBufferBuilder builder, EPatrolMoveState MoveState = EPatrolMoveState.None, ECharPositionStateType CharPositionState = ECharPositionStateType.Ground, int MoveSpeed = 0, bool UseAbpMappingSpeed = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IPasserbyNpcMoveState.AddMoveSpeed(builder, MoveSpeed);
			IPasserbyNpcMoveState.AddNullMask(builder, NullMask);
			IPasserbyNpcMoveState.AddUseAbpMappingSpeed(builder, UseAbpMappingSpeed);
			IPasserbyNpcMoveState.AddCharPositionState(builder, CharPositionState);
			IPasserbyNpcMoveState.AddMoveState(builder, MoveState);
			return IPasserbyNpcMoveState.EndIPasserbyNpcMoveState(builder);
		}

		// Token: 0x060251DC RID: 152028 RVA: 0x0051FD19 File Offset: 0x0051DF19
		public static void StartIPasserbyNpcMoveState(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060251DD RID: 152029 RVA: 0x0051FD22 File Offset: 0x0051DF22
		public static void AddMoveState(FlatBufferBuilder builder, EPatrolMoveState moveState)
		{
			builder.AddByte(0, (byte)moveState, 0);
		}

		// Token: 0x060251DE RID: 152030 RVA: 0x0051FD2D File Offset: 0x0051DF2D
		public static void AddCharPositionState(FlatBufferBuilder builder, ECharPositionStateType charPositionState)
		{
			builder.AddByte(1, (byte)charPositionState, 0);
		}

		// Token: 0x060251DF RID: 152031 RVA: 0x0051FD38 File Offset: 0x0051DF38
		public static void AddMoveSpeed(FlatBufferBuilder builder, int moveSpeed)
		{
			builder.AddInt(2, moveSpeed, 0);
		}

		// Token: 0x060251E0 RID: 152032 RVA: 0x0051FD43 File Offset: 0x0051DF43
		public static void AddUseAbpMappingSpeed(FlatBufferBuilder builder, bool useAbpMappingSpeed)
		{
			builder.AddBool(3, useAbpMappingSpeed, false);
		}

		// Token: 0x060251E1 RID: 152033 RVA: 0x0051FD4E File Offset: 0x0051DF4E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060251E2 RID: 152034 RVA: 0x0051FD59 File Offset: 0x0051DF59
		public static Offset<IPasserbyNpcMoveState> EndIPasserbyNpcMoveState(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcMoveState>(builder.EndTable());
		}

		// Token: 0x060251E3 RID: 152035 RVA: 0x0051FD68 File Offset: 0x0051DF68
		public IPasserbyNpcMoveStateT UnPack()
		{
			IPasserbyNpcMoveStateT passerbyNpcMoveStateT = new IPasserbyNpcMoveStateT();
			this.UnPackTo(passerbyNpcMoveStateT);
			return passerbyNpcMoveStateT;
		}

		// Token: 0x060251E4 RID: 152036 RVA: 0x0051FD83 File Offset: 0x0051DF83
		public void UnPackTo(IPasserbyNpcMoveStateT _o)
		{
			_o.MoveState = this.MoveState;
			_o.CharPositionState = this.CharPositionState;
			_o.MoveSpeed = this.MoveSpeed;
			_o.UseAbpMappingSpeed = this.UseAbpMappingSpeed;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060251E5 RID: 152037 RVA: 0x0051FDC4 File Offset: 0x0051DFC4
		public static Offset<IPasserbyNpcMoveState> Pack(FlatBufferBuilder builder, IPasserbyNpcMoveStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcMoveState>);
			}
			return IPasserbyNpcMoveState.CreateIPasserbyNpcMoveState(builder, _o.MoveState, _o.CharPositionState, _o.MoveSpeed, _o.UseAbpMappingSpeed, _o.NullMask);
		}

		// Token: 0x0400EB06 RID: 60166
		private Table __p;
	}
}
