using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E72 RID: 28274
	public struct IFlowActorUnit : IFlatbufferObject
	{
		// Token: 0x1700CF37 RID: 53047
		// (get) Token: 0x06030D8D RID: 200077 RVA: 0x006A08C3 File Offset: 0x0069EAC3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030D8E RID: 200078 RVA: 0x006A08D0 File Offset: 0x0069EAD0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030D8F RID: 200079 RVA: 0x006A08D8 File Offset: 0x0069EAD8
		public static IFlowActorUnit GetRootAsIFlowActorUnit(ByteBuffer _bb)
		{
			return IFlowActorUnit.GetRootAsIFlowActorUnit(_bb, default(IFlowActorUnit));
		}

		// Token: 0x06030D90 RID: 200080 RVA: 0x006A08F4 File Offset: 0x0069EAF4
		public static IFlowActorUnit GetRootAsIFlowActorUnit(ByteBuffer _bb, IFlowActorUnit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030D91 RID: 200081 RVA: 0x006A0911 File Offset: 0x0069EB11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030D92 RID: 200082 RVA: 0x006A0920 File Offset: 0x0069EB20
		public IFlowActorUnit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF38 RID: 53048
		// (get) Token: 0x06030D93 RID: 200083 RVA: 0x006A0930 File Offset: 0x0069EB30
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

		// Token: 0x1700CF39 RID: 53049
		// (get) Token: 0x06030D94 RID: 200084 RVA: 0x006A096C File Offset: 0x0069EB6C
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

		// Token: 0x1700CF3A RID: 53050
		// (get) Token: 0x06030D95 RID: 200085 RVA: 0x006A09A8 File Offset: 0x0069EBA8
		public bool IsPlayer
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CF3B RID: 53051
		// (get) Token: 0x06030D96 RID: 200086 RVA: 0x006A09E8 File Offset: 0x0069EBE8
		public bool IsResetPosition
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CF3C RID: 53052
		// (get) Token: 0x06030D97 RID: 200087 RVA: 0x006A0A28 File Offset: 0x0069EC28
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

		// Token: 0x06030D98 RID: 200088 RVA: 0x006A0A60 File Offset: 0x0069EC60
		public Span<byte> GetSeqFacePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06030D99 RID: 200089 RVA: 0x006A0A70 File Offset: 0x0069EC70
		public byte[] GetSeqFacePathArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700CF3D RID: 53053
		// (get) Token: 0x06030D9A RID: 200090 RVA: 0x006A0A80 File Offset: 0x0069EC80
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

		// Token: 0x06030D9B RID: 200091 RVA: 0x006A0ADE File Offset: 0x0069ECDE
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

		// Token: 0x06030D9C RID: 200092 RVA: 0x006A0B1A File Offset: 0x0069ED1A
		public static void StartIFlowActorUnit(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06030D9D RID: 200093 RVA: 0x006A0B23 File Offset: 0x0069ED23
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06030D9E RID: 200094 RVA: 0x006A0B2E File Offset: 0x0069ED2E
		public static void AddTalkerId(FlatBufferBuilder builder, int talkerId)
		{
			builder.AddInt(1, talkerId, 0);
		}

		// Token: 0x06030D9F RID: 200095 RVA: 0x006A0B39 File Offset: 0x0069ED39
		public static void AddIsPlayer(FlatBufferBuilder builder, bool isPlayer)
		{
			builder.AddBool(2, isPlayer, false);
		}

		// Token: 0x06030DA0 RID: 200096 RVA: 0x006A0B44 File Offset: 0x0069ED44
		public static void AddIsResetPosition(FlatBufferBuilder builder, bool isResetPosition)
		{
			builder.AddBool(3, isResetPosition, false);
		}

		// Token: 0x06030DA1 RID: 200097 RVA: 0x006A0B4F File Offset: 0x0069ED4F
		public static void AddSeqFacePath(FlatBufferBuilder builder, StringOffset seqFacePathOffset)
		{
			builder.AddOffset(4, seqFacePathOffset.Value, 0);
		}

		// Token: 0x06030DA2 RID: 200098 RVA: 0x006A0B5F File Offset: 0x0069ED5F
		public static void AddInitialState(FlatBufferBuilder builder, Offset<IActorInitialState> initialStateOffset)
		{
			builder.AddOffset(5, initialStateOffset.Value, 0);
		}

		// Token: 0x06030DA3 RID: 200099 RVA: 0x006A0B6F File Offset: 0x0069ED6F
		public static Offset<IFlowActorUnit> EndIFlowActorUnit(FlatBufferBuilder builder)
		{
			return new Offset<IFlowActorUnit>(builder.EndTable());
		}

		// Token: 0x06030DA4 RID: 200100 RVA: 0x006A0B7C File Offset: 0x0069ED7C
		public IFlowActorUnitT UnPack()
		{
			IFlowActorUnitT flowActorUnitT = new IFlowActorUnitT();
			this.UnPackTo(flowActorUnitT);
			return flowActorUnitT;
		}

		// Token: 0x06030DA5 RID: 200101 RVA: 0x006A0B98 File Offset: 0x0069ED98
		public void UnPackTo(IFlowActorUnitT _o)
		{
			_o.EntityId = this.EntityId;
			_o.TalkerId = this.TalkerId;
			_o.IsPlayer = this.IsPlayer;
			_o.IsResetPosition = this.IsResetPosition;
			_o.SeqFacePath = this.SeqFacePath;
			_o.InitialState = ((this.InitialState != null) ? this.InitialState.Value.UnPack() : null);
		}

		// Token: 0x06030DA6 RID: 200102 RVA: 0x006A0C10 File Offset: 0x0069EE10
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

		// Token: 0x04011D40 RID: 73024
		private Table __p;
	}
}
