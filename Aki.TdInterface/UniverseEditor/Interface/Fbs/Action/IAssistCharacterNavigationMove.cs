using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200680B RID: 26635
	public struct IAssistCharacterNavigationMove : IFlatbufferObject
	{
		// Token: 0x1700C3C4 RID: 50116
		// (get) Token: 0x0602D7E9 RID: 186345 RVA: 0x0063A578 File Offset: 0x00638778
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D7EA RID: 186346 RVA: 0x0063A585 File Offset: 0x00638785
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D7EB RID: 186347 RVA: 0x0063A58C File Offset: 0x0063878C
		public static IAssistCharacterNavigationMove GetRootAsIAssistCharacterNavigationMove(ByteBuffer _bb)
		{
			return IAssistCharacterNavigationMove.GetRootAsIAssistCharacterNavigationMove(_bb, default(IAssistCharacterNavigationMove));
		}

		// Token: 0x0602D7EC RID: 186348 RVA: 0x0063A5A8 File Offset: 0x006387A8
		public static IAssistCharacterNavigationMove GetRootAsIAssistCharacterNavigationMove(ByteBuffer _bb, IAssistCharacterNavigationMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D7ED RID: 186349 RVA: 0x0063A5C5 File Offset: 0x006387C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D7EE RID: 186350 RVA: 0x0063A5D4 File Offset: 0x006387D4
		public IAssistCharacterNavigationMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3C5 RID: 50117
		// (get) Token: 0x0602D7EF RID: 186351 RVA: 0x0063A5E4 File Offset: 0x006387E4
		public EAssistCharacterMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAssistCharacterMoveType.Navigation;
				}
				return (EAssistCharacterMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C3C6 RID: 50118
		// (get) Token: 0x0602D7F0 RID: 186352 RVA: 0x0063A620 File Offset: 0x00638820
		public IPosA? Destination
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C3C7 RID: 50119
		// (get) Token: 0x0602D7F1 RID: 186353 RVA: 0x0063A680 File Offset: 0x00638880
		public EMoveState MoveState
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EMoveState.None;
				}
				return (EMoveState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D7F2 RID: 186354 RVA: 0x0063A6BC File Offset: 0x006388BC
		public static Offset<IAssistCharacterNavigationMove> CreateIAssistCharacterNavigationMove(FlatBufferBuilder builder, EAssistCharacterMoveType Type = EAssistCharacterMoveType.Navigation, Offset<IPosA> DestinationOffset = default(Offset<IPosA>), EMoveState MoveState = EMoveState.None)
		{
			builder.StartTable(3);
			IAssistCharacterNavigationMove.AddDestination(builder, DestinationOffset);
			IAssistCharacterNavigationMove.AddMoveState(builder, MoveState);
			IAssistCharacterNavigationMove.AddType(builder, Type);
			return IAssistCharacterNavigationMove.EndIAssistCharacterNavigationMove(builder);
		}

		// Token: 0x0602D7F3 RID: 186355 RVA: 0x0063A6E0 File Offset: 0x006388E0
		public static void StartIAssistCharacterNavigationMove(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602D7F4 RID: 186356 RVA: 0x0063A6E9 File Offset: 0x006388E9
		public static void AddType(FlatBufferBuilder builder, EAssistCharacterMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D7F5 RID: 186357 RVA: 0x0063A6F4 File Offset: 0x006388F4
		public static void AddDestination(FlatBufferBuilder builder, Offset<IPosA> destinationOffset)
		{
			builder.AddOffset(1, destinationOffset.Value, 0);
		}

		// Token: 0x0602D7F6 RID: 186358 RVA: 0x0063A704 File Offset: 0x00638904
		public static void AddMoveState(FlatBufferBuilder builder, EMoveState moveState)
		{
			builder.AddByte(2, (byte)moveState, 0);
		}

		// Token: 0x0602D7F7 RID: 186359 RVA: 0x0063A70F File Offset: 0x0063890F
		public static Offset<IAssistCharacterNavigationMove> EndIAssistCharacterNavigationMove(FlatBufferBuilder builder)
		{
			return new Offset<IAssistCharacterNavigationMove>(builder.EndTable());
		}

		// Token: 0x0602D7F8 RID: 186360 RVA: 0x0063A71C File Offset: 0x0063891C
		public IAssistCharacterNavigationMoveT UnPack()
		{
			IAssistCharacterNavigationMoveT assistCharacterNavigationMoveT = new IAssistCharacterNavigationMoveT();
			this.UnPackTo(assistCharacterNavigationMoveT);
			return assistCharacterNavigationMoveT;
		}

		// Token: 0x0602D7F9 RID: 186361 RVA: 0x0063A738 File Offset: 0x00638938
		public void UnPackTo(IAssistCharacterNavigationMoveT _o)
		{
			_o.Type = this.Type;
			_o.Destination = ((this.Destination != null) ? this.Destination.Value.UnPack() : null);
			_o.MoveState = this.MoveState;
		}

		// Token: 0x0602D7FA RID: 186362 RVA: 0x0063A78C File Offset: 0x0063898C
		public static Offset<IAssistCharacterNavigationMove> Pack(FlatBufferBuilder builder, IAssistCharacterNavigationMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAssistCharacterNavigationMove>);
			}
			Offset<IPosA> destinationOffset = (_o.Destination == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.Destination);
			return IAssistCharacterNavigationMove.CreateIAssistCharacterNavigationMove(builder, _o.Type, destinationOffset, _o.MoveState);
		}

		// Token: 0x040114C2 RID: 70850
		private Table __p;
	}
}
