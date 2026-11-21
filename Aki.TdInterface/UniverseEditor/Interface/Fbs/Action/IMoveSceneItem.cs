using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200729A RID: 29338
	public struct IMoveSceneItem : IFlatbufferObject
	{
		// Token: 0x1700D706 RID: 55046
		// (get) Token: 0x060331F0 RID: 209392 RVA: 0x006E5DF8 File Offset: 0x006E3FF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060331F1 RID: 209393 RVA: 0x006E5E05 File Offset: 0x006E4005
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060331F2 RID: 209394 RVA: 0x006E5E0C File Offset: 0x006E400C
		public static IMoveSceneItem GetRootAsIMoveSceneItem(ByteBuffer _bb)
		{
			return IMoveSceneItem.GetRootAsIMoveSceneItem(_bb, default(IMoveSceneItem));
		}

		// Token: 0x060331F3 RID: 209395 RVA: 0x006E5E28 File Offset: 0x006E4028
		public static IMoveSceneItem GetRootAsIMoveSceneItem(ByteBuffer _bb, IMoveSceneItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060331F4 RID: 209396 RVA: 0x006E5E45 File Offset: 0x006E4045
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060331F5 RID: 209397 RVA: 0x006E5E54 File Offset: 0x006E4054
		public IMoveSceneItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D707 RID: 55047
		// (get) Token: 0x060331F6 RID: 209398 RVA: 0x006E5E64 File Offset: 0x006E4064
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

		// Token: 0x1700D708 RID: 55048
		// (get) Token: 0x060331F7 RID: 209399 RVA: 0x006E5EA0 File Offset: 0x006E40A0
		public bool StopBeforeMove
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D709 RID: 55049
		// (get) Token: 0x060331F8 RID: 209400 RVA: 0x006E5EE0 File Offset: 0x006E40E0
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

		// Token: 0x060331F9 RID: 209401 RVA: 0x006E5F1C File Offset: 0x006E411C
		public TTable? MoveConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060331FA RID: 209402 RVA: 0x006E5F64 File Offset: 0x006E4164
		public ICycleMoveToPoints MoveConfigAsICycleMoveToPoints()
		{
			return this.MoveConfig<ICycleMoveToPoints>().Value;
		}

		// Token: 0x060331FB RID: 209403 RVA: 0x006E5F80 File Offset: 0x006E4180
		public IMoveToEntity MoveConfigAsIMoveToEntity()
		{
			return this.MoveConfig<IMoveToEntity>().Value;
		}

		// Token: 0x060331FC RID: 209404 RVA: 0x006E5F9C File Offset: 0x006E419C
		public IMoveToPoint MoveConfigAsIMoveToPoint()
		{
			return this.MoveConfig<IMoveToPoint>().Value;
		}

		// Token: 0x060331FD RID: 209405 RVA: 0x006E5FB8 File Offset: 0x006E41B8
		public IMoveToRelativePosition MoveConfigAsIMoveToRelativePosition()
		{
			return this.MoveConfig<IMoveToRelativePosition>().Value;
		}

		// Token: 0x1700D70A RID: 55050
		// (get) Token: 0x060331FE RID: 209406 RVA: 0x006E5FD4 File Offset: 0x006E41D4
		public bool BypassClientResponse
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D70B RID: 55051
		// (get) Token: 0x060331FF RID: 209407 RVA: 0x006E6014 File Offset: 0x006E4214
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

		// Token: 0x06033200 RID: 209408 RVA: 0x006E6051 File Offset: 0x006E4251
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

		// Token: 0x06033201 RID: 209409 RVA: 0x006E608D File Offset: 0x006E428D
		public static void StartIMoveSceneItem(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06033202 RID: 209410 RVA: 0x006E6096 File Offset: 0x006E4296
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06033203 RID: 209411 RVA: 0x006E60A1 File Offset: 0x006E42A1
		public static void AddStopBeforeMove(FlatBufferBuilder builder, bool stopBeforeMove)
		{
			builder.AddBool(1, stopBeforeMove, false);
		}

		// Token: 0x06033204 RID: 209412 RVA: 0x006E60AC File Offset: 0x006E42AC
		public static void AddMoveConfigType(FlatBufferBuilder builder, TMoveSceneItem moveConfigType)
		{
			builder.AddByte(2, (byte)moveConfigType, 0);
		}

		// Token: 0x06033205 RID: 209413 RVA: 0x006E60B7 File Offset: 0x006E42B7
		public static void AddMoveConfig(FlatBufferBuilder builder, int moveConfigOffset)
		{
			builder.AddOffset(3, moveConfigOffset, 0);
		}

		// Token: 0x06033206 RID: 209414 RVA: 0x006E60C2 File Offset: 0x006E42C2
		public static void AddBypassClientResponse(FlatBufferBuilder builder, bool bypassClientResponse)
		{
			builder.AddBool(4, bypassClientResponse, false);
		}

		// Token: 0x06033207 RID: 209415 RVA: 0x006E60CD File Offset: 0x006E42CD
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06033208 RID: 209416 RVA: 0x006E60D8 File Offset: 0x006E42D8
		public static Offset<IMoveSceneItem> EndIMoveSceneItem(FlatBufferBuilder builder)
		{
			return new Offset<IMoveSceneItem>(builder.EndTable());
		}

		// Token: 0x06033209 RID: 209417 RVA: 0x006E60E8 File Offset: 0x006E42E8
		public IMoveSceneItemT UnPack()
		{
			IMoveSceneItemT moveSceneItemT = new IMoveSceneItemT();
			this.UnPackTo(moveSceneItemT);
			return moveSceneItemT;
		}

		// Token: 0x0603320A RID: 209418 RVA: 0x006E6104 File Offset: 0x006E4304
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

		// Token: 0x0603320B RID: 209419 RVA: 0x006E6264 File Offset: 0x006E4464
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

		// Token: 0x0401231F RID: 74527
		private Table __p;
	}
}
