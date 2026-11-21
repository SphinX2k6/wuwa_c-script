using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C0E RID: 31758
	public struct IToggleTimerPauseState : IFlatbufferObject
	{
		// Token: 0x1700EDCD RID: 60877
		// (get) Token: 0x060393C6 RID: 234438 RVA: 0x007BB334 File Offset: 0x007B9534
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060393C7 RID: 234439 RVA: 0x007BB341 File Offset: 0x007B9541
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060393C8 RID: 234440 RVA: 0x007BB348 File Offset: 0x007B9548
		public static IToggleTimerPauseState GetRootAsIToggleTimerPauseState(ByteBuffer _bb)
		{
			return IToggleTimerPauseState.GetRootAsIToggleTimerPauseState(_bb, default(IToggleTimerPauseState));
		}

		// Token: 0x060393C9 RID: 234441 RVA: 0x007BB364 File Offset: 0x007B9564
		public static IToggleTimerPauseState GetRootAsIToggleTimerPauseState(ByteBuffer _bb, IToggleTimerPauseState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060393CA RID: 234442 RVA: 0x007BB381 File Offset: 0x007B9581
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060393CB RID: 234443 RVA: 0x007BB390 File Offset: 0x007B9590
		public IToggleTimerPauseState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EDCE RID: 60878
		// (get) Token: 0x060393CC RID: 234444 RVA: 0x007BB3A0 File Offset: 0x007B95A0
		public ETimerType TimerType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETimerType.CountDownChallenge;
				}
				return (ETimerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EDCF RID: 60879
		// (get) Token: 0x060393CD RID: 234445 RVA: 0x007BB3DC File Offset: 0x007B95DC
		public bool IsPause
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060393CE RID: 234446 RVA: 0x007BB41B File Offset: 0x007B961B
		public static Offset<IToggleTimerPauseState> CreateIToggleTimerPauseState(FlatBufferBuilder builder, ETimerType TimerType = ETimerType.CountDownChallenge, bool IsPause = false)
		{
			builder.StartTable(2);
			IToggleTimerPauseState.AddIsPause(builder, IsPause);
			IToggleTimerPauseState.AddTimerType(builder, TimerType);
			return IToggleTimerPauseState.EndIToggleTimerPauseState(builder);
		}

		// Token: 0x060393CF RID: 234447 RVA: 0x007BB438 File Offset: 0x007B9638
		public static void StartIToggleTimerPauseState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060393D0 RID: 234448 RVA: 0x007BB441 File Offset: 0x007B9641
		public static void AddTimerType(FlatBufferBuilder builder, ETimerType timerType)
		{
			builder.AddByte(0, (byte)timerType, 0);
		}

		// Token: 0x060393D1 RID: 234449 RVA: 0x007BB44C File Offset: 0x007B964C
		public static void AddIsPause(FlatBufferBuilder builder, bool isPause)
		{
			builder.AddBool(1, isPause, false);
		}

		// Token: 0x060393D2 RID: 234450 RVA: 0x007BB457 File Offset: 0x007B9657
		public static Offset<IToggleTimerPauseState> EndIToggleTimerPauseState(FlatBufferBuilder builder)
		{
			return new Offset<IToggleTimerPauseState>(builder.EndTable());
		}

		// Token: 0x060393D3 RID: 234451 RVA: 0x007BB464 File Offset: 0x007B9664
		public IToggleTimerPauseStateT UnPack()
		{
			IToggleTimerPauseStateT toggleTimerPauseStateT = new IToggleTimerPauseStateT();
			this.UnPackTo(toggleTimerPauseStateT);
			return toggleTimerPauseStateT;
		}

		// Token: 0x060393D4 RID: 234452 RVA: 0x007BB47F File Offset: 0x007B967F
		public void UnPackTo(IToggleTimerPauseStateT _o)
		{
			_o.TimerType = this.TimerType;
			_o.IsPause = this.IsPause;
		}

		// Token: 0x060393D5 RID: 234453 RVA: 0x007BB49C File Offset: 0x007B969C
		public static Offset<IToggleTimerPauseState> Pack(FlatBufferBuilder builder, IToggleTimerPauseStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToggleTimerPauseState>);
			}
			return IToggleTimerPauseState.CreateIToggleTimerPauseState(builder, _o.TimerType, _o.IsPause);
		}

		// Token: 0x040132B8 RID: 78520
		private Table __p;
	}
}
