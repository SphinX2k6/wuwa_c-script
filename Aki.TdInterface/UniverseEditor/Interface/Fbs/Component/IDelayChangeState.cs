using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055E3 RID: 21987
	public struct IDelayChangeState : IFlatbufferObject
	{
		// Token: 0x17009D68 RID: 40296
		// (get) Token: 0x06022FD7 RID: 143319 RVA: 0x004D08CD File Offset: 0x004CEACD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022FD8 RID: 143320 RVA: 0x004D08DA File Offset: 0x004CEADA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022FD9 RID: 143321 RVA: 0x004D08E4 File Offset: 0x004CEAE4
		public static IDelayChangeState GetRootAsIDelayChangeState(ByteBuffer _bb)
		{
			return IDelayChangeState.GetRootAsIDelayChangeState(_bb, default(IDelayChangeState));
		}

		// Token: 0x06022FDA RID: 143322 RVA: 0x004D0900 File Offset: 0x004CEB00
		public static IDelayChangeState GetRootAsIDelayChangeState(ByteBuffer _bb, IDelayChangeState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022FDB RID: 143323 RVA: 0x004D091D File Offset: 0x004CEB1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022FDC RID: 143324 RVA: 0x004D092C File Offset: 0x004CEB2C
		public IDelayChangeState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D69 RID: 40297
		// (get) Token: 0x06022FDD RID: 143325 RVA: 0x004D093C File Offset: 0x004CEB3C
		public float Time
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009D6A RID: 40298
		// (get) Token: 0x06022FDE RID: 143326 RVA: 0x004D097C File Offset: 0x004CEB7C
		public string NewState
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022FDF RID: 143327 RVA: 0x004D09B3 File Offset: 0x004CEBB3
		public Span<byte> GetNewStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06022FE0 RID: 143328 RVA: 0x004D09C2 File Offset: 0x004CEBC2
		public byte[] GetNewStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009D6B RID: 40299
		// (get) Token: 0x06022FE1 RID: 143329 RVA: 0x004D09D0 File Offset: 0x004CEBD0
		public IVarInterval? DelayInterval
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVarInterval?(default(IVarInterval).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009D6C RID: 40300
		// (get) Token: 0x06022FE2 RID: 143330 RVA: 0x004D0A30 File Offset: 0x004CEC30
		public bool WaitActionGroupEnd
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009D6D RID: 40301
		// (get) Token: 0x06022FE3 RID: 143331 RVA: 0x004D0A70 File Offset: 0x004CEC70
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

		// Token: 0x06022FE4 RID: 143332 RVA: 0x004D0AAD File Offset: 0x004CECAD
		public static Offset<IDelayChangeState> CreateIDelayChangeState(FlatBufferBuilder builder, float Time = 0f, StringOffset NewStateOffset = default(StringOffset), Offset<IVarInterval> DelayIntervalOffset = default(Offset<IVarInterval>), bool WaitActionGroupEnd = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IDelayChangeState.AddDelayInterval(builder, DelayIntervalOffset);
			IDelayChangeState.AddNewState(builder, NewStateOffset);
			IDelayChangeState.AddTime(builder, Time);
			IDelayChangeState.AddNullMask(builder, NullMask);
			IDelayChangeState.AddWaitActionGroupEnd(builder, WaitActionGroupEnd);
			return IDelayChangeState.EndIDelayChangeState(builder);
		}

		// Token: 0x06022FE5 RID: 143333 RVA: 0x004D0AE1 File Offset: 0x004CECE1
		public static void StartIDelayChangeState(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06022FE6 RID: 143334 RVA: 0x004D0AEA File Offset: 0x004CECEA
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(0, time, 0.0);
		}

		// Token: 0x06022FE7 RID: 143335 RVA: 0x004D0AFD File Offset: 0x004CECFD
		public static void AddNewState(FlatBufferBuilder builder, StringOffset newStateOffset)
		{
			builder.AddOffset(1, newStateOffset.Value, 0);
		}

		// Token: 0x06022FE8 RID: 143336 RVA: 0x004D0B0D File Offset: 0x004CED0D
		public static void AddDelayInterval(FlatBufferBuilder builder, Offset<IVarInterval> delayIntervalOffset)
		{
			builder.AddOffset(2, delayIntervalOffset.Value, 0);
		}

		// Token: 0x06022FE9 RID: 143337 RVA: 0x004D0B1D File Offset: 0x004CED1D
		public static void AddWaitActionGroupEnd(FlatBufferBuilder builder, bool waitActionGroupEnd)
		{
			builder.AddBool(3, waitActionGroupEnd, false);
		}

		// Token: 0x06022FEA RID: 143338 RVA: 0x004D0B28 File Offset: 0x004CED28
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06022FEB RID: 143339 RVA: 0x004D0B33 File Offset: 0x004CED33
		public static Offset<IDelayChangeState> EndIDelayChangeState(FlatBufferBuilder builder)
		{
			return new Offset<IDelayChangeState>(builder.EndTable());
		}

		// Token: 0x06022FEC RID: 143340 RVA: 0x004D0B40 File Offset: 0x004CED40
		public IDelayChangeStateT UnPack()
		{
			IDelayChangeStateT delayChangeStateT = new IDelayChangeStateT();
			this.UnPackTo(delayChangeStateT);
			return delayChangeStateT;
		}

		// Token: 0x06022FED RID: 143341 RVA: 0x004D0B5C File Offset: 0x004CED5C
		public void UnPackTo(IDelayChangeStateT _o)
		{
			_o.Time = this.Time;
			_o.NewState = this.NewState;
			_o.DelayInterval = ((this.DelayInterval != null) ? this.DelayInterval.Value.UnPack() : null);
			_o.WaitActionGroupEnd = this.WaitActionGroupEnd;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022FEE RID: 143342 RVA: 0x004D0BC8 File Offset: 0x004CEDC8
		public static Offset<IDelayChangeState> Pack(FlatBufferBuilder builder, IDelayChangeStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDelayChangeState>);
			}
			StringOffset newStateOffset = (_o.NewState == null) ? default(StringOffset) : builder.CreateString(_o.NewState);
			Offset<IVarInterval> delayIntervalOffset = (_o.DelayInterval == null) ? default(Offset<IVarInterval>) : IVarInterval.Pack(builder, _o.DelayInterval);
			return IDelayChangeState.CreateIDelayChangeState(builder, _o.Time, newStateOffset, delayIntervalOffset, _o.WaitActionGroupEnd, _o.NullMask);
		}

		// Token: 0x0400EC7D RID: 60541
		private Table __p;
	}
}
