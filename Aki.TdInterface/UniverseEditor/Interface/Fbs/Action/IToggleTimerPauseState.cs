using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200741B RID: 29723
	public struct IToggleTimerPauseState : IFlatbufferObject
	{
		// Token: 0x1700E1B0 RID: 57776
		// (get) Token: 0x06035FDD RID: 221149 RVA: 0x00758608 File Offset: 0x00756808
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035FDE RID: 221150 RVA: 0x00758615 File Offset: 0x00756815
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035FDF RID: 221151 RVA: 0x0075861C File Offset: 0x0075681C
		public static IToggleTimerPauseState GetRootAsIToggleTimerPauseState(ByteBuffer _bb)
		{
			return IToggleTimerPauseState.GetRootAsIToggleTimerPauseState(_bb, default(IToggleTimerPauseState));
		}

		// Token: 0x06035FE0 RID: 221152 RVA: 0x00758638 File Offset: 0x00756838
		public static IToggleTimerPauseState GetRootAsIToggleTimerPauseState(ByteBuffer _bb, IToggleTimerPauseState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035FE1 RID: 221153 RVA: 0x00758655 File Offset: 0x00756855
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035FE2 RID: 221154 RVA: 0x00758664 File Offset: 0x00756864
		public IToggleTimerPauseState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1B1 RID: 57777
		// (get) Token: 0x06035FE3 RID: 221155 RVA: 0x00758674 File Offset: 0x00756874
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

		// Token: 0x1700E1B2 RID: 57778
		// (get) Token: 0x06035FE4 RID: 221156 RVA: 0x007586B0 File Offset: 0x007568B0
		public bool IsPause
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06035FE5 RID: 221157 RVA: 0x007586EF File Offset: 0x007568EF
		public static Offset<IToggleTimerPauseState> CreateIToggleTimerPauseState(FlatBufferBuilder builder, ETimerType TimerType = ETimerType.CountDownChallenge, bool IsPause = false)
		{
			builder.StartTable(2);
			IToggleTimerPauseState.AddIsPause(builder, IsPause);
			IToggleTimerPauseState.AddTimerType(builder, TimerType);
			return IToggleTimerPauseState.EndIToggleTimerPauseState(builder);
		}

		// Token: 0x06035FE6 RID: 221158 RVA: 0x0075870C File Offset: 0x0075690C
		public static void StartIToggleTimerPauseState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035FE7 RID: 221159 RVA: 0x00758715 File Offset: 0x00756915
		public static void AddTimerType(FlatBufferBuilder builder, ETimerType timerType)
		{
			builder.AddByte(0, (byte)timerType, 0);
		}

		// Token: 0x06035FE8 RID: 221160 RVA: 0x00758720 File Offset: 0x00756920
		public static void AddIsPause(FlatBufferBuilder builder, bool isPause)
		{
			builder.AddBool(1, isPause, false);
		}

		// Token: 0x06035FE9 RID: 221161 RVA: 0x0075872B File Offset: 0x0075692B
		public static Offset<IToggleTimerPauseState> EndIToggleTimerPauseState(FlatBufferBuilder builder)
		{
			return new Offset<IToggleTimerPauseState>(builder.EndTable());
		}

		// Token: 0x06035FEA RID: 221162 RVA: 0x00758738 File Offset: 0x00756938
		public IToggleTimerPauseStateT UnPack()
		{
			IToggleTimerPauseStateT toggleTimerPauseStateT = new IToggleTimerPauseStateT();
			this.UnPackTo(toggleTimerPauseStateT);
			return toggleTimerPauseStateT;
		}

		// Token: 0x06035FEB RID: 221163 RVA: 0x00758753 File Offset: 0x00756953
		public void UnPackTo(IToggleTimerPauseStateT _o)
		{
			_o.TimerType = this.TimerType;
			_o.IsPause = this.IsPause;
		}

		// Token: 0x06035FEC RID: 221164 RVA: 0x00758770 File Offset: 0x00756970
		public static Offset<IToggleTimerPauseState> Pack(FlatBufferBuilder builder, IToggleTimerPauseStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToggleTimerPauseState>);
			}
			return IToggleTimerPauseState.CreateIToggleTimerPauseState(builder, _o.TimerType, _o.IsPause);
		}

		// Token: 0x04012291 RID: 74385
		private Table __p;
	}
}
