using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B54 RID: 27476
	public struct IMoveSceneItem : IFlatbufferObject
	{
		// Token: 0x1700CC21 RID: 52257
		// (get) Token: 0x06030399 RID: 197529 RVA: 0x0068D83C File Offset: 0x0068BA3C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603039A RID: 197530 RVA: 0x0068D849 File Offset: 0x0068BA49
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603039B RID: 197531 RVA: 0x0068D850 File Offset: 0x0068BA50
		public static IMoveSceneItem GetRootAsIMoveSceneItem(ByteBuffer _bb)
		{
			return IMoveSceneItem.GetRootAsIMoveSceneItem(_bb, default(IMoveSceneItem));
		}

		// Token: 0x0603039C RID: 197532 RVA: 0x0068D86C File Offset: 0x0068BA6C
		public static IMoveSceneItem GetRootAsIMoveSceneItem(ByteBuffer _bb, IMoveSceneItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603039D RID: 197533 RVA: 0x0068D889 File Offset: 0x0068BA89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603039E RID: 197534 RVA: 0x0068D898 File Offset: 0x0068BA98
		public IMoveSceneItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC22 RID: 52258
		// (get) Token: 0x0603039F RID: 197535 RVA: 0x0068D8A8 File Offset: 0x0068BAA8
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

		// Token: 0x1700CC23 RID: 52259
		// (get) Token: 0x060303A0 RID: 197536 RVA: 0x0068D8E4 File Offset: 0x0068BAE4
		public bool StopBeforeMove
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CC24 RID: 52260
		// (get) Token: 0x060303A1 RID: 197537 RVA: 0x0068D924 File Offset: 0x0068BB24
		public TMoveSceneItem MoveConfigType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TMoveSceneItem.NONE;
				}
				return (TMoveSceneItem)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060303A2 RID: 197538 RVA: 0x0068D960 File Offset: 0x0068BB60
		public TTable? MoveConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060303A3 RID: 197539 RVA: 0x0068D9A8 File Offset: 0x0068BBA8
		public ICycleMoveToPoints MoveConfigAsICycleMoveToPoints()
		{
			return this.MoveConfig<ICycleMoveToPoints>().Value;
		}

		// Token: 0x060303A4 RID: 197540 RVA: 0x0068D9C4 File Offset: 0x0068BBC4
		public IMoveToEntity MoveConfigAsIMoveToEntity()
		{
			return this.MoveConfig<IMoveToEntity>().Value;
		}

		// Token: 0x060303A5 RID: 197541 RVA: 0x0068D9E0 File Offset: 0x0068BBE0
		public IMoveToPoint MoveConfigAsIMoveToPoint()
		{
			return this.MoveConfig<IMoveToPoint>().Value;
		}

		// Token: 0x060303A6 RID: 197542 RVA: 0x0068D9FC File Offset: 0x0068BBFC
		public IMoveToRelativePosition MoveConfigAsIMoveToRelativePosition()
		{
			return this.MoveConfig<IMoveToRelativePosition>().Value;
		}

		// Token: 0x1700CC25 RID: 52261
		// (get) Token: 0x060303A7 RID: 197543 RVA: 0x0068DA18 File Offset: 0x0068BC18
		public bool BypassClientResponse
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CC26 RID: 52262
		// (get) Token: 0x060303A8 RID: 197544 RVA: 0x0068DA58 File Offset: 0x0068BC58
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060303A9 RID: 197545 RVA: 0x0068DA95 File Offset: 0x0068BC95
		public static Offset<IMoveSceneItem> CreateIMoveSceneItem(FlatBufferBuilder builder, int EntityId = 0, bool StopBeforeMove = false, TMoveSceneItem MoveConfig_type = TMoveSceneItem.NONE, int MoveConfigOffset = 0, bool BypassClientResponse = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			IMoveSceneItem.AddMoveConfig(builder, MoveConfigOffset);
			IMoveSceneItem.AddEntityId(builder, EntityId);
			IMoveSceneItem.AddNullMask(builder, NullMask);
			IMoveSceneItem.AddBypassClientResponse(builder, BypassClientResponse);
			IMoveSceneItem.AddMoveConfigType(builder, MoveConfig_type);
			IMoveSceneItem.AddStopBeforeMove(builder, StopBeforeMove);
			return IMoveSceneItem.EndIMoveSceneItem(builder);
		}

		// Token: 0x060303AA RID: 197546 RVA: 0x0068DAD1 File Offset: 0x0068BCD1
		public static void StartIMoveSceneItem(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060303AB RID: 197547 RVA: 0x0068DADA File Offset: 0x0068BCDA
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x060303AC RID: 197548 RVA: 0x0068DAE5 File Offset: 0x0068BCE5
		public static void AddStopBeforeMove(FlatBufferBuilder builder, bool stopBeforeMove)
		{
			builder.AddBool(1, stopBeforeMove, false);
		}

		// Token: 0x060303AD RID: 197549 RVA: 0x0068DAF0 File Offset: 0x0068BCF0
		public static void AddMoveConfigType(FlatBufferBuilder builder, TMoveSceneItem moveConfigType)
		{
			builder.AddByte(2, (byte)moveConfigType, 0);
		}

		// Token: 0x060303AE RID: 197550 RVA: 0x0068DAFB File Offset: 0x0068BCFB
		public static void AddMoveConfig(FlatBufferBuilder builder, int moveConfigOffset)
		{
			builder.AddOffset(3, moveConfigOffset, 0);
		}

		// Token: 0x060303AF RID: 197551 RVA: 0x0068DB06 File Offset: 0x0068BD06
		public static void AddBypassClientResponse(FlatBufferBuilder builder, bool bypassClientResponse)
		{
			builder.AddBool(4, bypassClientResponse, false);
		}

		// Token: 0x060303B0 RID: 197552 RVA: 0x0068DB11 File Offset: 0x0068BD11
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060303B1 RID: 197553 RVA: 0x0068DB1C File Offset: 0x0068BD1C
		public static Offset<IMoveSceneItem> EndIMoveSceneItem(FlatBufferBuilder builder)
		{
			return new Offset<IMoveSceneItem>(builder.EndTable());
		}

		// Token: 0x060303B2 RID: 197554 RVA: 0x0068DB2C File Offset: 0x0068BD2C
		public IMoveSceneItemT UnPack()
		{
			IMoveSceneItemT moveSceneItemT = new IMoveSceneItemT();
			this.UnPackTo(moveSceneItemT);
			return moveSceneItemT;
		}

		// Token: 0x060303B3 RID: 197555 RVA: 0x0068DB48 File Offset: 0x0068BD48
		public void UnPackTo(IMoveSceneItemT _o)
		{
			_o.EntityId = this.EntityId;
			_o.StopBeforeMove = this.StopBeforeMove;
			_o.MoveConfig = new TMoveSceneItemUnion();
			_o.MoveConfig.Type = this.MoveConfigType;
			switch (this.MoveConfigType)
			{
			case TMoveSceneItem.ICycleMoveToPoints:
				_o.MoveConfig.Value = ((this.MoveConfig<ICycleMoveToPoints>() != null) ? this.MoveConfig<ICycleMoveToPoints>().Value.UnPack() : null);
				break;
			case TMoveSceneItem.IMoveToEntity:
				_o.MoveConfig.Value = ((this.MoveConfig<IMoveToEntity>() != null) ? this.MoveConfig<IMoveToEntity>().Value.UnPack() : null);
				break;
			case TMoveSceneItem.IMoveToPoint:
				_o.MoveConfig.Value = ((this.MoveConfig<IMoveToPoint>() != null) ? this.MoveConfig<IMoveToPoint>().Value.UnPack() : null);
				break;
			case TMoveSceneItem.IMoveToRelativePosition:
				_o.MoveConfig.Value = ((this.MoveConfig<IMoveToRelativePosition>() != null) ? this.MoveConfig<IMoveToRelativePosition>().Value.UnPack() : null);
				break;
			}
			_o.BypassClientResponse = this.BypassClientResponse;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060303B4 RID: 197556 RVA: 0x0068DCA8 File Offset: 0x0068BEA8
		public static Offset<IMoveSceneItem> Pack(FlatBufferBuilder builder, IMoveSceneItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMoveSceneItem>);
			}
			TMoveSceneItem moveConfig_type = (_o.MoveConfig == null) ? TMoveSceneItem.NONE : _o.MoveConfig.Type;
			int moveConfigOffset = (_o.MoveConfig == null) ? 0 : TMoveSceneItemUnion.Pack(builder, _o.MoveConfig);
			return IMoveSceneItem.CreateIMoveSceneItem(builder, _o.EntityId, _o.StopBeforeMove, moveConfig_type, moveConfigOffset, _o.BypassClientResponse, _o.NullMask);
		}

		// Token: 0x040113F6 RID: 70646
		private Table __p;
	}
}
