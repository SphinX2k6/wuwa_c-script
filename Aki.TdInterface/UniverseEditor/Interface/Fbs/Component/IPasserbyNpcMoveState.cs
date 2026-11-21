using System;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C99 RID: 23705
	public struct IPasserbyNpcMoveState : IFlatbufferObject
	{
		// Token: 0x1700AE18 RID: 44568
		// (get) Token: 0x06027515 RID: 161045 RVA: 0x0056214C File Offset: 0x0056034C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027516 RID: 161046 RVA: 0x00562159 File Offset: 0x00560359
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027517 RID: 161047 RVA: 0x00562160 File Offset: 0x00560360
		public static IPasserbyNpcMoveState GetRootAsIPasserbyNpcMoveState(ByteBuffer _bb)
		{
			return IPasserbyNpcMoveState.GetRootAsIPasserbyNpcMoveState(_bb, default(IPasserbyNpcMoveState));
		}

		// Token: 0x06027518 RID: 161048 RVA: 0x0056217C File Offset: 0x0056037C
		public static IPasserbyNpcMoveState GetRootAsIPasserbyNpcMoveState(ByteBuffer _bb, IPasserbyNpcMoveState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027519 RID: 161049 RVA: 0x00562199 File Offset: 0x00560399
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602751A RID: 161050 RVA: 0x005621A8 File Offset: 0x005603A8
		public IPasserbyNpcMoveState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE19 RID: 44569
		// (get) Token: 0x0602751B RID: 161051 RVA: 0x005621B8 File Offset: 0x005603B8
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

		// Token: 0x1700AE1A RID: 44570
		// (get) Token: 0x0602751C RID: 161052 RVA: 0x005621F4 File Offset: 0x005603F4
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

		// Token: 0x1700AE1B RID: 44571
		// (get) Token: 0x0602751D RID: 161053 RVA: 0x00562230 File Offset: 0x00560430
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

		// Token: 0x1700AE1C RID: 44572
		// (get) Token: 0x0602751E RID: 161054 RVA: 0x0056226C File Offset: 0x0056046C
		public bool UseAbpMappingSpeed
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AE1D RID: 44573
		// (get) Token: 0x0602751F RID: 161055 RVA: 0x005622AC File Offset: 0x005604AC
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

		// Token: 0x06027520 RID: 161056 RVA: 0x005622E9 File Offset: 0x005604E9
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

		// Token: 0x06027521 RID: 161057 RVA: 0x0056231D File Offset: 0x0056051D
		public static void StartIPasserbyNpcMoveState(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06027522 RID: 161058 RVA: 0x00562326 File Offset: 0x00560526
		public static void AddMoveState(FlatBufferBuilder builder, EPatrolMoveState moveState)
		{
			builder.AddByte(0, (byte)moveState, 0);
		}

		// Token: 0x06027523 RID: 161059 RVA: 0x00562331 File Offset: 0x00560531
		public static void AddCharPositionState(FlatBufferBuilder builder, ECharPositionStateType charPositionState)
		{
			builder.AddByte(1, (byte)charPositionState, 0);
		}

		// Token: 0x06027524 RID: 161060 RVA: 0x0056233C File Offset: 0x0056053C
		public static void AddMoveSpeed(FlatBufferBuilder builder, int moveSpeed)
		{
			builder.AddInt(2, moveSpeed, 0);
		}

		// Token: 0x06027525 RID: 161061 RVA: 0x00562347 File Offset: 0x00560547
		public static void AddUseAbpMappingSpeed(FlatBufferBuilder builder, bool useAbpMappingSpeed)
		{
			builder.AddBool(3, useAbpMappingSpeed, false);
		}

		// Token: 0x06027526 RID: 161062 RVA: 0x00562352 File Offset: 0x00560552
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06027527 RID: 161063 RVA: 0x0056235D File Offset: 0x0056055D
		public static Offset<IPasserbyNpcMoveState> EndIPasserbyNpcMoveState(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcMoveState>(builder.EndTable());
		}

		// Token: 0x06027528 RID: 161064 RVA: 0x0056236C File Offset: 0x0056056C
		public IPasserbyNpcMoveStateT UnPack()
		{
			IPasserbyNpcMoveStateT passerbyNpcMoveStateT = new IPasserbyNpcMoveStateT();
			this.UnPackTo(passerbyNpcMoveStateT);
			return passerbyNpcMoveStateT;
		}

		// Token: 0x06027529 RID: 161065 RVA: 0x00562387 File Offset: 0x00560587
		public void UnPackTo(IPasserbyNpcMoveStateT _o)
		{
			_o.MoveState = this.MoveState;
			_o.CharPositionState = this.CharPositionState;
			_o.MoveSpeed = this.MoveSpeed;
			_o.UseAbpMappingSpeed = this.UseAbpMappingSpeed;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602752A RID: 161066 RVA: 0x005623C8 File Offset: 0x005605C8
		public static Offset<IPasserbyNpcMoveState> Pack(FlatBufferBuilder builder, IPasserbyNpcMoveStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcMoveState>);
			}
			return IPasserbyNpcMoveState.CreateIPasserbyNpcMoveState(builder, _o.MoveState, _o.CharPositionState, _o.MoveSpeed, _o.UseAbpMappingSpeed, _o.NullMask);
		}

		// Token: 0x0400F7A7 RID: 63399
		private Table __p;
	}
}
