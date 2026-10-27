using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200630E RID: 25358
	public struct IChangeNpcPerformState : IFlatbufferObject
	{
		// Token: 0x1700BD4D RID: 48461
		// (get) Token: 0x0602BDAD RID: 179629 RVA: 0x00607EC1 File Offset: 0x006060C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BDAE RID: 179630 RVA: 0x00607ECE File Offset: 0x006060CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BDAF RID: 179631 RVA: 0x00607ED8 File Offset: 0x006060D8
		public static IChangeNpcPerformState GetRootAsIChangeNpcPerformState(ByteBuffer _bb)
		{
			return IChangeNpcPerformState.GetRootAsIChangeNpcPerformState(_bb, default(IChangeNpcPerformState));
		}

		// Token: 0x0602BDB0 RID: 179632 RVA: 0x00607EF4 File Offset: 0x006060F4
		public static IChangeNpcPerformState GetRootAsIChangeNpcPerformState(ByteBuffer _bb, IChangeNpcPerformState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BDB1 RID: 179633 RVA: 0x00607F11 File Offset: 0x00606111
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BDB2 RID: 179634 RVA: 0x00607F20 File Offset: 0x00606120
		public IChangeNpcPerformState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD4E RID: 48462
		// (get) Token: 0x0602BDB3 RID: 179635 RVA: 0x00607F30 File Offset: 0x00606130
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

		// Token: 0x1700BD4F RID: 48463
		// (get) Token: 0x0602BDB4 RID: 179636 RVA: 0x00607F6C File Offset: 0x0060616C
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

		// Token: 0x0602BDB5 RID: 179637 RVA: 0x00607FA3 File Offset: 0x006061A3
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602BDB6 RID: 179638 RVA: 0x00607FB2 File Offset: 0x006061B2
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602BDB7 RID: 179639 RVA: 0x00607FC0 File Offset: 0x006061C0
		public static Offset<IChangeNpcPerformState> CreateIChangeNpcPerformState(FlatBufferBuilder builder, int EntityId = 0, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IChangeNpcPerformState.AddState(builder, StateOffset);
			IChangeNpcPerformState.AddEntityId(builder, EntityId);
			return IChangeNpcPerformState.EndIChangeNpcPerformState(builder);
		}

		// Token: 0x0602BDB8 RID: 179640 RVA: 0x00607FDD File Offset: 0x006061DD
		public static void StartIChangeNpcPerformState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BDB9 RID: 179641 RVA: 0x00607FE6 File Offset: 0x006061E6
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0602BDBA RID: 179642 RVA: 0x00607FF1 File Offset: 0x006061F1
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x0602BDBB RID: 179643 RVA: 0x00608001 File Offset: 0x00606201
		public static Offset<IChangeNpcPerformState> EndIChangeNpcPerformState(FlatBufferBuilder builder)
		{
			return new Offset<IChangeNpcPerformState>(builder.EndTable());
		}

		// Token: 0x0602BDBC RID: 179644 RVA: 0x00608010 File Offset: 0x00606210
		public IChangeNpcPerformStateT UnPack()
		{
			IChangeNpcPerformStateT changeNpcPerformStateT = new IChangeNpcPerformStateT();
			this.UnPackTo(changeNpcPerformStateT);
			return changeNpcPerformStateT;
		}

		// Token: 0x0602BDBD RID: 179645 RVA: 0x0060802B File Offset: 0x0060622B
		public void UnPackTo(IChangeNpcPerformStateT _o)
		{
			_o.EntityId = this.EntityId;
			_o.State = this.State;
		}

		// Token: 0x0602BDBE RID: 179646 RVA: 0x00608048 File Offset: 0x00606248
		public static Offset<IChangeNpcPerformState> Pack(FlatBufferBuilder builder, IChangeNpcPerformStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeNpcPerformState>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IChangeNpcPerformState.CreateIChangeNpcPerformState(builder, _o.EntityId, stateOffset);
		}

		// Token: 0x040108D0 RID: 67792
		private Table __p;
	}
}
