using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200507E RID: 20606
	public struct IDelayChangeState : IFlatbufferObject
	{
		// Token: 0x1700957B RID: 38267
		// (get) Token: 0x06021083 RID: 135299 RVA: 0x00496989 File Offset: 0x00494B89
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021084 RID: 135300 RVA: 0x00496996 File Offset: 0x00494B96
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021085 RID: 135301 RVA: 0x004969A0 File Offset: 0x00494BA0
		public static IDelayChangeState GetRootAsIDelayChangeState(ByteBuffer _bb)
		{
			return IDelayChangeState.GetRootAsIDelayChangeState(_bb, default(IDelayChangeState));
		}

		// Token: 0x06021086 RID: 135302 RVA: 0x004969BC File Offset: 0x00494BBC
		public static IDelayChangeState GetRootAsIDelayChangeState(ByteBuffer _bb, IDelayChangeState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021087 RID: 135303 RVA: 0x004969D9 File Offset: 0x00494BD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021088 RID: 135304 RVA: 0x004969E8 File Offset: 0x00494BE8
		public IDelayChangeState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700957C RID: 38268
		// (get) Token: 0x06021089 RID: 135305 RVA: 0x004969F8 File Offset: 0x00494BF8
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

		// Token: 0x1700957D RID: 38269
		// (get) Token: 0x0602108A RID: 135306 RVA: 0x00496A38 File Offset: 0x00494C38
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

		// Token: 0x0602108B RID: 135307 RVA: 0x00496A6F File Offset: 0x00494C6F
		public Span<byte> GetNewStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602108C RID: 135308 RVA: 0x00496A7E File Offset: 0x00494C7E
		public byte[] GetNewStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700957E RID: 38270
		// (get) Token: 0x0602108D RID: 135309 RVA: 0x00496A8C File Offset: 0x00494C8C
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

		// Token: 0x1700957F RID: 38271
		// (get) Token: 0x0602108E RID: 135310 RVA: 0x00496AEC File Offset: 0x00494CEC
		public bool WaitActionGroupEnd
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009580 RID: 38272
		// (get) Token: 0x0602108F RID: 135311 RVA: 0x00496B2C File Offset: 0x00494D2C
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

		// Token: 0x06021090 RID: 135312 RVA: 0x00496B69 File Offset: 0x00494D69
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

		// Token: 0x06021091 RID: 135313 RVA: 0x00496B9D File Offset: 0x00494D9D
		public static void StartIDelayChangeState(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06021092 RID: 135314 RVA: 0x00496BA6 File Offset: 0x00494DA6
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(0, time, 0.0);
		}

		// Token: 0x06021093 RID: 135315 RVA: 0x00496BB9 File Offset: 0x00494DB9
		public static void AddNewState(FlatBufferBuilder builder, StringOffset newStateOffset)
		{
			builder.AddOffset(1, newStateOffset.Value, 0);
		}

		// Token: 0x06021094 RID: 135316 RVA: 0x00496BC9 File Offset: 0x00494DC9
		public static void AddDelayInterval(FlatBufferBuilder builder, Offset<IVarInterval> delayIntervalOffset)
		{
			builder.AddOffset(2, delayIntervalOffset.Value, 0);
		}

		// Token: 0x06021095 RID: 135317 RVA: 0x00496BD9 File Offset: 0x00494DD9
		public static void AddWaitActionGroupEnd(FlatBufferBuilder builder, bool waitActionGroupEnd)
		{
			builder.AddBool(3, waitActionGroupEnd, false);
		}

		// Token: 0x06021096 RID: 135318 RVA: 0x00496BE4 File Offset: 0x00494DE4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06021097 RID: 135319 RVA: 0x00496BEF File Offset: 0x00494DEF
		public static Offset<IDelayChangeState> EndIDelayChangeState(FlatBufferBuilder builder)
		{
			return new Offset<IDelayChangeState>(builder.EndTable());
		}

		// Token: 0x06021098 RID: 135320 RVA: 0x00496BFC File Offset: 0x00494DFC
		public IDelayChangeStateT UnPack()
		{
			IDelayChangeStateT delayChangeStateT = new IDelayChangeStateT();
			this.UnPackTo(delayChangeStateT);
			return delayChangeStateT;
		}

		// Token: 0x06021099 RID: 135321 RVA: 0x00496C18 File Offset: 0x00494E18
		public void UnPackTo(IDelayChangeStateT _o)
		{
			_o.Time = this.Time;
			_o.NewState = this.NewState;
			_o.DelayInterval = ((this.DelayInterval != null) ? this.DelayInterval.Value.UnPack() : null);
			_o.WaitActionGroupEnd = this.WaitActionGroupEnd;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602109A RID: 135322 RVA: 0x00496C84 File Offset: 0x00494E84
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

		// Token: 0x0400E080 RID: 57472
		private Table __p;
	}
}
