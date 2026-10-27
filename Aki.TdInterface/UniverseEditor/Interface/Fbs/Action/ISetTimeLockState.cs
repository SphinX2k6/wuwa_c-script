using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007094 RID: 28820
	public struct ISetTimeLockState : IFlatbufferObject
	{
		// Token: 0x1700D628 RID: 54824
		// (get) Token: 0x0603308A RID: 209034 RVA: 0x006E2464 File Offset: 0x006E0664
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603308B RID: 209035 RVA: 0x006E2471 File Offset: 0x006E0671
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603308C RID: 209036 RVA: 0x006E2478 File Offset: 0x006E0678
		public static ISetTimeLockState GetRootAsISetTimeLockState(ByteBuffer _bb)
		{
			return ISetTimeLockState.GetRootAsISetTimeLockState(_bb, default(ISetTimeLockState));
		}

		// Token: 0x0603308D RID: 209037 RVA: 0x006E2494 File Offset: 0x006E0694
		public static ISetTimeLockState GetRootAsISetTimeLockState(ByteBuffer _bb, ISetTimeLockState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603308E RID: 209038 RVA: 0x006E24B1 File Offset: 0x006E06B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603308F RID: 209039 RVA: 0x006E24C0 File Offset: 0x006E06C0
		public ISetTimeLockState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D629 RID: 54825
		// (get) Token: 0x06033090 RID: 209040 RVA: 0x006E24D0 File Offset: 0x006E06D0
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

		// Token: 0x06033091 RID: 209041 RVA: 0x006E250C File Offset: 0x006E070C
		public static Offset<ISetTimeLockState> CreateISetTimeLockState(FlatBufferBuilder builder, ELockState LockState = ELockState.Lock)
		{
			builder.StartTable(1);
			ISetTimeLockState.AddLockState(builder, LockState);
			return ISetTimeLockState.EndISetTimeLockState(builder);
		}

		// Token: 0x06033092 RID: 209042 RVA: 0x006E2522 File Offset: 0x006E0722
		public static void StartISetTimeLockState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033093 RID: 209043 RVA: 0x006E252B File Offset: 0x006E072B
		public static void AddLockState(FlatBufferBuilder builder, ELockState lockState)
		{
			builder.AddByte(0, (byte)lockState, 0);
		}

		// Token: 0x06033094 RID: 209044 RVA: 0x006E2536 File Offset: 0x006E0736
		public static Offset<ISetTimeLockState> EndISetTimeLockState(FlatBufferBuilder builder)
		{
			return new Offset<ISetTimeLockState>(builder.EndTable());
		}

		// Token: 0x06033095 RID: 209045 RVA: 0x006E2544 File Offset: 0x006E0744
		public ISetTimeLockStateT UnPack()
		{
			ISetTimeLockStateT setTimeLockStateT = new ISetTimeLockStateT();
			this.UnPackTo(setTimeLockStateT);
			return setTimeLockStateT;
		}

		// Token: 0x06033096 RID: 209046 RVA: 0x006E255F File Offset: 0x006E075F
		public void UnPackTo(ISetTimeLockStateT _o)
		{
			_o.LockState = this.LockState;
		}

		// Token: 0x06033097 RID: 209047 RVA: 0x006E2570 File Offset: 0x006E0770
		public static Offset<ISetTimeLockState> Pack(FlatBufferBuilder builder, ISetTimeLockStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetTimeLockState>);
			}
			return ISetTimeLockState.CreateISetTimeLockState(builder, _o.LockState);
		}

		// Token: 0x04011B00 RID: 72448
		private Table __p;
	}
}
