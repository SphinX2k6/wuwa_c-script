using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006323 RID: 25379
	public struct IChangeState : IFlatbufferObject
	{
		// Token: 0x1700BD70 RID: 48496
		// (get) Token: 0x0602BE5D RID: 179805 RVA: 0x0060905C File Offset: 0x0060725C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BE5E RID: 179806 RVA: 0x00609069 File Offset: 0x00607269
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BE5F RID: 179807 RVA: 0x00609070 File Offset: 0x00607270
		public static IChangeState GetRootAsIChangeState(ByteBuffer _bb)
		{
			return IChangeState.GetRootAsIChangeState(_bb, default(IChangeState));
		}

		// Token: 0x0602BE60 RID: 179808 RVA: 0x0060908C File Offset: 0x0060728C
		public static IChangeState GetRootAsIChangeState(ByteBuffer _bb, IChangeState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BE61 RID: 179809 RVA: 0x006090A9 File Offset: 0x006072A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BE62 RID: 179810 RVA: 0x006090B8 File Offset: 0x006072B8
		public IChangeState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD71 RID: 48497
		// (get) Token: 0x0602BE63 RID: 179811 RVA: 0x006090C8 File Offset: 0x006072C8
		public int StateId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BE64 RID: 179812 RVA: 0x00609104 File Offset: 0x00607304
		public static Offset<IChangeState> CreateIChangeState(FlatBufferBuilder builder, int StateId = 0)
		{
			builder.StartTable(1);
			IChangeState.AddStateId(builder, StateId);
			return IChangeState.EndIChangeState(builder);
		}

		// Token: 0x0602BE65 RID: 179813 RVA: 0x0060911A File Offset: 0x0060731A
		public static void StartIChangeState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BE66 RID: 179814 RVA: 0x00609123 File Offset: 0x00607323
		public static void AddStateId(FlatBufferBuilder builder, int stateId)
		{
			builder.AddInt(0, stateId, 0);
		}

		// Token: 0x0602BE67 RID: 179815 RVA: 0x0060912E File Offset: 0x0060732E
		public static Offset<IChangeState> EndIChangeState(FlatBufferBuilder builder)
		{
			return new Offset<IChangeState>(builder.EndTable());
		}

		// Token: 0x0602BE68 RID: 179816 RVA: 0x0060913C File Offset: 0x0060733C
		public IChangeStateT UnPack()
		{
			IChangeStateT changeStateT = new IChangeStateT();
			this.UnPackTo(changeStateT);
			return changeStateT;
		}

		// Token: 0x0602BE69 RID: 179817 RVA: 0x00609157 File Offset: 0x00607357
		public void UnPackTo(IChangeStateT _o)
		{
			_o.StateId = this.StateId;
		}

		// Token: 0x0602BE6A RID: 179818 RVA: 0x00609168 File Offset: 0x00607368
		public static Offset<IChangeState> Pack(FlatBufferBuilder builder, IChangeStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeState>);
			}
			return IChangeState.CreateIChangeState(builder, _o.StateId);
		}

		// Token: 0x040108E5 RID: 67813
		private Table __p;
	}
}
