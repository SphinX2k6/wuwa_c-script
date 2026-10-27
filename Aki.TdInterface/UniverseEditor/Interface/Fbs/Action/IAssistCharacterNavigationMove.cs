using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061A0 RID: 24992
	public struct IAssistCharacterNavigationMove : IFlatbufferObject
	{
		// Token: 0x1700BA46 RID: 47686
		// (get) Token: 0x0602B0B8 RID: 176312 RVA: 0x005EFD04 File Offset: 0x005EDF04
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B0B9 RID: 176313 RVA: 0x005EFD11 File Offset: 0x005EDF11
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B0BA RID: 176314 RVA: 0x005EFD18 File Offset: 0x005EDF18
		public static IAssistCharacterNavigationMove GetRootAsIAssistCharacterNavigationMove(ByteBuffer _bb)
		{
			return IAssistCharacterNavigationMove.GetRootAsIAssistCharacterNavigationMove(_bb, default(IAssistCharacterNavigationMove));
		}

		// Token: 0x0602B0BB RID: 176315 RVA: 0x005EFD34 File Offset: 0x005EDF34
		public static IAssistCharacterNavigationMove GetRootAsIAssistCharacterNavigationMove(ByteBuffer _bb, IAssistCharacterNavigationMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B0BC RID: 176316 RVA: 0x005EFD51 File Offset: 0x005EDF51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B0BD RID: 176317 RVA: 0x005EFD60 File Offset: 0x005EDF60
		public IAssistCharacterNavigationMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA47 RID: 47687
		// (get) Token: 0x0602B0BE RID: 176318 RVA: 0x005EFD70 File Offset: 0x005EDF70
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

		// Token: 0x1700BA48 RID: 47688
		// (get) Token: 0x0602B0BF RID: 176319 RVA: 0x005EFDAC File Offset: 0x005EDFAC
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

		// Token: 0x1700BA49 RID: 47689
		// (get) Token: 0x0602B0C0 RID: 176320 RVA: 0x005EFE0C File Offset: 0x005EE00C
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

		// Token: 0x0602B0C1 RID: 176321 RVA: 0x005EFE48 File Offset: 0x005EE048
		public static Offset<IAssistCharacterNavigationMove> CreateIAssistCharacterNavigationMove(FlatBufferBuilder builder, EAssistCharacterMoveType Type = EAssistCharacterMoveType.Navigation, Offset<IPosA> DestinationOffset = default(Offset<IPosA>), EMoveState MoveState = EMoveState.None)
		{
			builder.StartTable(3);
			IAssistCharacterNavigationMove.AddDestination(builder, DestinationOffset);
			IAssistCharacterNavigationMove.AddMoveState(builder, MoveState);
			IAssistCharacterNavigationMove.AddType(builder, Type);
			return IAssistCharacterNavigationMove.EndIAssistCharacterNavigationMove(builder);
		}

		// Token: 0x0602B0C2 RID: 176322 RVA: 0x005EFE6C File Offset: 0x005EE06C
		public static void StartIAssistCharacterNavigationMove(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602B0C3 RID: 176323 RVA: 0x005EFE75 File Offset: 0x005EE075
		public static void AddType(FlatBufferBuilder builder, EAssistCharacterMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B0C4 RID: 176324 RVA: 0x005EFE80 File Offset: 0x005EE080
		public static void AddDestination(FlatBufferBuilder builder, Offset<IPosA> destinationOffset)
		{
			builder.AddOffset(1, destinationOffset.Value, 0);
		}

		// Token: 0x0602B0C5 RID: 176325 RVA: 0x005EFE90 File Offset: 0x005EE090
		public static void AddMoveState(FlatBufferBuilder builder, EMoveState moveState)
		{
			builder.AddByte(2, (byte)moveState, 0);
		}

		// Token: 0x0602B0C6 RID: 176326 RVA: 0x005EFE9B File Offset: 0x005EE09B
		public static Offset<IAssistCharacterNavigationMove> EndIAssistCharacterNavigationMove(FlatBufferBuilder builder)
		{
			return new Offset<IAssistCharacterNavigationMove>(builder.EndTable());
		}

		// Token: 0x0602B0C7 RID: 176327 RVA: 0x005EFEA8 File Offset: 0x005EE0A8
		public IAssistCharacterNavigationMoveT UnPack()
		{
			IAssistCharacterNavigationMoveT assistCharacterNavigationMoveT = new IAssistCharacterNavigationMoveT();
			this.UnPackTo(assistCharacterNavigationMoveT);
			return assistCharacterNavigationMoveT;
		}

		// Token: 0x0602B0C8 RID: 176328 RVA: 0x005EFEC4 File Offset: 0x005EE0C4
		public void UnPackTo(IAssistCharacterNavigationMoveT _o)
		{
			_o.Type = this.Type;
			_o.Destination = ((this.Destination != null) ? this.Destination.Value.UnPack() : null);
			_o.MoveState = this.MoveState;
		}

		// Token: 0x0602B0C9 RID: 176329 RVA: 0x005EFF18 File Offset: 0x005EE118
		public static Offset<IAssistCharacterNavigationMove> Pack(FlatBufferBuilder builder, IAssistCharacterNavigationMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAssistCharacterNavigationMove>);
			}
			Offset<IPosA> destinationOffset = (_o.Destination == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.Destination);
			return IAssistCharacterNavigationMove.CreateIAssistCharacterNavigationMove(builder, _o.Type, destinationOffset, _o.MoveState);
		}

		// Token: 0x040106B3 RID: 67251
		private Table __p;
	}
}
