using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070BE RID: 28862
	public struct ISheriffChangeCriminalState : IFlatbufferObject
	{
		// Token: 0x1700D669 RID: 54889
		// (get) Token: 0x060331E8 RID: 209384 RVA: 0x006E4CEE File Offset: 0x006E2EEE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060331E9 RID: 209385 RVA: 0x006E4CFB File Offset: 0x006E2EFB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060331EA RID: 209386 RVA: 0x006E4D04 File Offset: 0x006E2F04
		public static ISheriffChangeCriminalState GetRootAsISheriffChangeCriminalState(ByteBuffer _bb)
		{
			return ISheriffChangeCriminalState.GetRootAsISheriffChangeCriminalState(_bb, default(ISheriffChangeCriminalState));
		}

		// Token: 0x060331EB RID: 209387 RVA: 0x006E4D20 File Offset: 0x006E2F20
		public static ISheriffChangeCriminalState GetRootAsISheriffChangeCriminalState(ByteBuffer _bb, ISheriffChangeCriminalState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060331EC RID: 209388 RVA: 0x006E4D3D File Offset: 0x006E2F3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060331ED RID: 209389 RVA: 0x006E4D4C File Offset: 0x006E2F4C
		public ISheriffChangeCriminalState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D66A RID: 54890
		// (get) Token: 0x060331EE RID: 209390 RVA: 0x006E4D5C File Offset: 0x006E2F5C
		public int CriminalId
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

		// Token: 0x1700D66B RID: 54891
		// (get) Token: 0x060331EF RID: 209391 RVA: 0x006E4D98 File Offset: 0x006E2F98
		public ESheriffCriminalState CriminalState
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ESheriffCriminalState.None;
				}
				return (ESheriffCriminalState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060331F0 RID: 209392 RVA: 0x006E4DD4 File Offset: 0x006E2FD4
		public static Offset<ISheriffChangeCriminalState> CreateISheriffChangeCriminalState(FlatBufferBuilder builder, int CriminalId = 0, ESheriffCriminalState CriminalState = ESheriffCriminalState.None)
		{
			builder.StartTable(2);
			ISheriffChangeCriminalState.AddCriminalId(builder, CriminalId);
			ISheriffChangeCriminalState.AddCriminalState(builder, CriminalState);
			return ISheriffChangeCriminalState.EndISheriffChangeCriminalState(builder);
		}

		// Token: 0x060331F1 RID: 209393 RVA: 0x006E4DF1 File Offset: 0x006E2FF1
		public static void StartISheriffChangeCriminalState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060331F2 RID: 209394 RVA: 0x006E4DFA File Offset: 0x006E2FFA
		public static void AddCriminalId(FlatBufferBuilder builder, int criminalId)
		{
			builder.AddInt(0, criminalId, 0);
		}

		// Token: 0x060331F3 RID: 209395 RVA: 0x006E4E05 File Offset: 0x006E3005
		public static void AddCriminalState(FlatBufferBuilder builder, ESheriffCriminalState criminalState)
		{
			builder.AddByte(1, (byte)criminalState, 0);
		}

		// Token: 0x060331F4 RID: 209396 RVA: 0x006E4E10 File Offset: 0x006E3010
		public static Offset<ISheriffChangeCriminalState> EndISheriffChangeCriminalState(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffChangeCriminalState>(builder.EndTable());
		}

		// Token: 0x060331F5 RID: 209397 RVA: 0x006E4E20 File Offset: 0x006E3020
		public ISheriffChangeCriminalStateT UnPack()
		{
			ISheriffChangeCriminalStateT sheriffChangeCriminalStateT = new ISheriffChangeCriminalStateT();
			this.UnPackTo(sheriffChangeCriminalStateT);
			return sheriffChangeCriminalStateT;
		}

		// Token: 0x060331F6 RID: 209398 RVA: 0x006E4E3B File Offset: 0x006E303B
		public void UnPackTo(ISheriffChangeCriminalStateT _o)
		{
			_o.CriminalId = this.CriminalId;
			_o.CriminalState = this.CriminalState;
		}

		// Token: 0x060331F7 RID: 209399 RVA: 0x006E4E58 File Offset: 0x006E3058
		public static Offset<ISheriffChangeCriminalState> Pack(FlatBufferBuilder builder, ISheriffChangeCriminalStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffChangeCriminalState>);
			}
			return ISheriffChangeCriminalState.CreateISheriffChangeCriminalState(builder, _o.CriminalId, _o.CriminalState);
		}

		// Token: 0x04011B2D RID: 72493
		private Table __p;
	}
}
