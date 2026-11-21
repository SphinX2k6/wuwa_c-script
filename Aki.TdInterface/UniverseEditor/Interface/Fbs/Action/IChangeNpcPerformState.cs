using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200697F RID: 27007
	public struct IChangeNpcPerformState : IFlatbufferObject
	{
		// Token: 0x1700C6D7 RID: 50903
		// (get) Token: 0x0602E516 RID: 189718 RVA: 0x00652ECD File Offset: 0x006510CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E517 RID: 189719 RVA: 0x00652EDA File Offset: 0x006510DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E518 RID: 189720 RVA: 0x00652EE4 File Offset: 0x006510E4
		public static IChangeNpcPerformState GetRootAsIChangeNpcPerformState(ByteBuffer _bb)
		{
			return IChangeNpcPerformState.GetRootAsIChangeNpcPerformState(_bb, default(IChangeNpcPerformState));
		}

		// Token: 0x0602E519 RID: 189721 RVA: 0x00652F00 File Offset: 0x00651100
		public static IChangeNpcPerformState GetRootAsIChangeNpcPerformState(ByteBuffer _bb, IChangeNpcPerformState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E51A RID: 189722 RVA: 0x00652F1D File Offset: 0x0065111D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E51B RID: 189723 RVA: 0x00652F2C File Offset: 0x0065112C
		public IChangeNpcPerformState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6D8 RID: 50904
		// (get) Token: 0x0602E51C RID: 189724 RVA: 0x00652F3C File Offset: 0x0065113C
		public int EntityId
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

		// Token: 0x1700C6D9 RID: 50905
		// (get) Token: 0x0602E51D RID: 189725 RVA: 0x00652F78 File Offset: 0x00651178
		public string State
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

		// Token: 0x0602E51E RID: 189726 RVA: 0x00652FAF File Offset: 0x006511AF
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602E51F RID: 189727 RVA: 0x00652FBE File Offset: 0x006511BE
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602E520 RID: 189728 RVA: 0x00652FCC File Offset: 0x006511CC
		public static Offset<IChangeNpcPerformState> CreateIChangeNpcPerformState(FlatBufferBuilder builder, int EntityId = 0, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IChangeNpcPerformState.AddState(builder, StateOffset);
			IChangeNpcPerformState.AddEntityId(builder, EntityId);
			return IChangeNpcPerformState.EndIChangeNpcPerformState(builder);
		}

		// Token: 0x0602E521 RID: 189729 RVA: 0x00652FE9 File Offset: 0x006511E9
		public static void StartIChangeNpcPerformState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E522 RID: 189730 RVA: 0x00652FF2 File Offset: 0x006511F2
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0602E523 RID: 189731 RVA: 0x00652FFD File Offset: 0x006511FD
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x0602E524 RID: 189732 RVA: 0x0065300D File Offset: 0x0065120D
		public static Offset<IChangeNpcPerformState> EndIChangeNpcPerformState(FlatBufferBuilder builder)
		{
			return new Offset<IChangeNpcPerformState>(builder.EndTable());
		}

		// Token: 0x0602E525 RID: 189733 RVA: 0x0065301C File Offset: 0x0065121C
		public IChangeNpcPerformStateT UnPack()
		{
			IChangeNpcPerformStateT changeNpcPerformStateT = new IChangeNpcPerformStateT();
			this.UnPackTo(changeNpcPerformStateT);
			return changeNpcPerformStateT;
		}

		// Token: 0x0602E526 RID: 189734 RVA: 0x00653037 File Offset: 0x00651237
		public void UnPackTo(IChangeNpcPerformStateT _o)
		{
			_o.EntityId = this.EntityId;
			_o.State = this.State;
		}

		// Token: 0x0602E527 RID: 189735 RVA: 0x00653054 File Offset: 0x00651254
		public static Offset<IChangeNpcPerformState> Pack(FlatBufferBuilder builder, IChangeNpcPerformStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeNpcPerformState>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IChangeNpcPerformState.CreateIChangeNpcPerformState(builder, _o.EntityId, stateOffset);
		}

		// Token: 0x040116E6 RID: 71398
		private Table __p;
	}
}
