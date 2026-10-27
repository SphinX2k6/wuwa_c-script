using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067F2 RID: 26610
	public struct IFlowActorUnit : IFlatbufferObject
	{
		// Token: 0x1700C581 RID: 50561
		// (get) Token: 0x0602E547 RID: 189767 RVA: 0x0065317F File Offset: 0x0065137F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E548 RID: 189768 RVA: 0x0065318C File Offset: 0x0065138C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E549 RID: 189769 RVA: 0x00653194 File Offset: 0x00651394
		public static IFlowActorUnit GetRootAsIFlowActorUnit(ByteBuffer _bb)
		{
			return IFlowActorUnit.GetRootAsIFlowActorUnit(_bb, default(IFlowActorUnit));
		}

		// Token: 0x0602E54A RID: 189770 RVA: 0x006531B0 File Offset: 0x006513B0
		public static IFlowActorUnit GetRootAsIFlowActorUnit(ByteBuffer _bb, IFlowActorUnit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E54B RID: 189771 RVA: 0x006531CD File Offset: 0x006513CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E54C RID: 189772 RVA: 0x006531DC File Offset: 0x006513DC
		public IFlowActorUnit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C582 RID: 50562
		// (get) Token: 0x0602E54D RID: 189773 RVA: 0x006531EC File Offset: 0x006513EC
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

		// Token: 0x1700C583 RID: 50563
		// (get) Token: 0x0602E54E RID: 189774 RVA: 0x00653228 File Offset: 0x00651428
		public int TalkerId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C584 RID: 50564
		// (get) Token: 0x0602E54F RID: 189775 RVA: 0x00653264 File Offset: 0x00651464
		public bool IsPlayer
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C585 RID: 50565
		// (get) Token: 0x0602E550 RID: 189776 RVA: 0x006532A4 File Offset: 0x006514A4
		public bool IsResetPosition
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C586 RID: 50566
		// (get) Token: 0x0602E551 RID: 189777 RVA: 0x006532E4 File Offset: 0x006514E4
		public string SeqFacePath
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E552 RID: 189778 RVA: 0x0065331C File Offset: 0x0065151C
		public Span<byte> GetSeqFacePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602E553 RID: 189779 RVA: 0x0065332C File Offset: 0x0065152C
		public byte[] GetSeqFacePathArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700C587 RID: 50567
		// (get) Token: 0x0602E554 RID: 189780 RVA: 0x0065333C File Offset: 0x0065153C
		public IActorInitialState? InitialState
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IActorInitialState?(default(IActorInitialState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602E555 RID: 189781 RVA: 0x0065339A File Offset: 0x0065159A
		public static Offset<IFlowActorUnit> CreateIFlowActorUnit(FlatBufferBuilder builder, int EntityId = 0, int TalkerId = 0, bool IsPlayer = false, bool IsResetPosition = false, StringOffset SeqFacePathOffset = default(StringOffset), Offset<IActorInitialState> InitialStateOffset = default(Offset<IActorInitialState>))
		{
			builder.StartTable(6);
			IFlowActorUnit.AddInitialState(builder, InitialStateOffset);
			IFlowActorUnit.AddSeqFacePath(builder, SeqFacePathOffset);
			IFlowActorUnit.AddTalkerId(builder, TalkerId);
			IFlowActorUnit.AddEntityId(builder, EntityId);
			IFlowActorUnit.AddIsResetPosition(builder, IsResetPosition);
			IFlowActorUnit.AddIsPlayer(builder, IsPlayer);
			return IFlowActorUnit.EndIFlowActorUnit(builder);
		}

		// Token: 0x0602E556 RID: 189782 RVA: 0x006533D6 File Offset: 0x006515D6
		public static void StartIFlowActorUnit(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602E557 RID: 189783 RVA: 0x006533DF File Offset: 0x006515DF
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0602E558 RID: 189784 RVA: 0x006533EA File Offset: 0x006515EA
		public static void AddTalkerId(FlatBufferBuilder builder, int talkerId)
		{
			builder.AddInt(1, talkerId, 0);
		}

		// Token: 0x0602E559 RID: 189785 RVA: 0x006533F5 File Offset: 0x006515F5
		public static void AddIsPlayer(FlatBufferBuilder builder, bool isPlayer)
		{
			builder.AddBool(2, isPlayer, false);
		}

		// Token: 0x0602E55A RID: 189786 RVA: 0x00653400 File Offset: 0x00651600
		public static void AddIsResetPosition(FlatBufferBuilder builder, bool isResetPosition)
		{
			builder.AddBool(3, isResetPosition, false);
		}

		// Token: 0x0602E55B RID: 189787 RVA: 0x0065340B File Offset: 0x0065160B
		public static void AddSeqFacePath(FlatBufferBuilder builder, StringOffset seqFacePathOffset)
		{
			builder.AddOffset(4, seqFacePathOffset.Value, 0);
		}

		// Token: 0x0602E55C RID: 189788 RVA: 0x0065341B File Offset: 0x0065161B
		public static void AddInitialState(FlatBufferBuilder builder, Offset<IActorInitialState> initialStateOffset)
		{
			builder.AddOffset(5, initialStateOffset.Value, 0);
		}

		// Token: 0x0602E55D RID: 189789 RVA: 0x0065342B File Offset: 0x0065162B
		public static Offset<IFlowActorUnit> EndIFlowActorUnit(FlatBufferBuilder builder)
		{
			return new Offset<IFlowActorUnit>(builder.EndTable());
		}

		// Token: 0x0602E55E RID: 189790 RVA: 0x00653438 File Offset: 0x00651638
		public IFlowActorUnitT UnPack()
		{
			IFlowActorUnitT flowActorUnitT = new IFlowActorUnitT();
			this.UnPackTo(flowActorUnitT);
			return flowActorUnitT;
		}

		// Token: 0x0602E55F RID: 189791 RVA: 0x00653454 File Offset: 0x00651654
		public void UnPackTo(IFlowActorUnitT _o)
		{
			_o.EntityId = this.EntityId;
			_o.TalkerId = this.TalkerId;
			_o.IsPlayer = this.IsPlayer;
			_o.IsResetPosition = this.IsResetPosition;
			_o.SeqFacePath = this.SeqFacePath;
			_o.InitialState = ((this.InitialState != null) ? this.InitialState.Value.UnPack() : null);
		}

		// Token: 0x0602E560 RID: 189792 RVA: 0x006534CC File Offset: 0x006516CC
		public static Offset<IFlowActorUnit> Pack(FlatBufferBuilder builder, IFlowActorUnitT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowActorUnit>);
			}
			StringOffset seqFacePathOffset = (_o.SeqFacePath == null) ? default(StringOffset) : builder.CreateString(_o.SeqFacePath);
			Offset<IActorInitialState> initialStateOffset = (_o.InitialState == null) ? default(Offset<IActorInitialState>) : IActorInitialState.Pack(builder, _o.InitialState);
			return IFlowActorUnit.CreateIFlowActorUnit(builder, _o.EntityId, _o.TalkerId, _o.IsPlayer, _o.IsResetPosition, seqFacePathOffset, initialStateOffset);
		}

		// Token: 0x04010F0E RID: 69390
		private Table __p;
	}
}
