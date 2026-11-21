using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007860 RID: 30816
	public struct ISetTimeLockState : IFlatbufferObject
	{
		// Token: 0x1700E20B RID: 57867
		// (get) Token: 0x0603632C RID: 221996 RVA: 0x00742A70 File Offset: 0x00740C70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603632D RID: 221997 RVA: 0x00742A7D File Offset: 0x00740C7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603632E RID: 221998 RVA: 0x00742A84 File Offset: 0x00740C84
		public static ISetTimeLockState GetRootAsISetTimeLockState(ByteBuffer _bb)
		{
			return ISetTimeLockState.GetRootAsISetTimeLockState(_bb, default(ISetTimeLockState));
		}

		// Token: 0x0603632F RID: 221999 RVA: 0x00742AA0 File Offset: 0x00740CA0
		public static ISetTimeLockState GetRootAsISetTimeLockState(ByteBuffer _bb, ISetTimeLockState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036330 RID: 222000 RVA: 0x00742ABD File Offset: 0x00740CBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036331 RID: 222001 RVA: 0x00742ACC File Offset: 0x00740CCC
		public ISetTimeLockState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E20C RID: 57868
		// (get) Token: 0x06036332 RID: 222002 RVA: 0x00742ADC File Offset: 0x00740CDC
		public ELockState LockState
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELockState.Lock;
				}
				return (ELockState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036333 RID: 222003 RVA: 0x00742B18 File Offset: 0x00740D18
		public static Offset<ISetTimeLockState> CreateISetTimeLockState(FlatBufferBuilder builder, ELockState LockState = ELockState.Lock)
		{
			builder.StartTable(1);
			ISetTimeLockState.AddLockState(builder, LockState);
			return ISetTimeLockState.EndISetTimeLockState(builder);
		}

		// Token: 0x06036334 RID: 222004 RVA: 0x00742B2E File Offset: 0x00740D2E
		public static void StartISetTimeLockState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036335 RID: 222005 RVA: 0x00742B37 File Offset: 0x00740D37
		public static void AddLockState(FlatBufferBuilder builder, ELockState lockState)
		{
			builder.AddByte(0, (byte)lockState, 0);
		}

		// Token: 0x06036336 RID: 222006 RVA: 0x00742B42 File Offset: 0x00740D42
		public static Offset<ISetTimeLockState> EndISetTimeLockState(FlatBufferBuilder builder)
		{
			return new Offset<ISetTimeLockState>(builder.EndTable());
		}

		// Token: 0x06036337 RID: 222007 RVA: 0x00742B50 File Offset: 0x00740D50
		public ISetTimeLockStateT UnPack()
		{
			ISetTimeLockStateT setTimeLockStateT = new ISetTimeLockStateT();
			this.UnPackTo(setTimeLockStateT);
			return setTimeLockStateT;
		}

		// Token: 0x06036338 RID: 222008 RVA: 0x00742B6B File Offset: 0x00740D6B
		public void UnPackTo(ISetTimeLockStateT _o)
		{
			_o.LockState = this.LockState;
		}

		// Token: 0x06036339 RID: 222009 RVA: 0x00742B7C File Offset: 0x00740D7C
		public static Offset<ISetTimeLockState> Pack(FlatBufferBuilder builder, ISetTimeLockStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetTimeLockState>);
			}
			return ISetTimeLockState.CreateISetTimeLockState(builder, _o.LockState);
		}

		// Token: 0x04012AEE RID: 76526
		private Table __p;
	}
}
