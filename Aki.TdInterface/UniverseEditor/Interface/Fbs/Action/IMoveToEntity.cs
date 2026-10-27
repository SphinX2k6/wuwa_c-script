using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B5D RID: 27485
	public struct IMoveToEntity : IFlatbufferObject
	{
		// Token: 0x1700CC31 RID: 52273
		// (get) Token: 0x060303E5 RID: 197605 RVA: 0x0068E168 File Offset: 0x0068C368
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060303E6 RID: 197606 RVA: 0x0068E175 File Offset: 0x0068C375
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060303E7 RID: 197607 RVA: 0x0068E17C File Offset: 0x0068C37C
		public static IMoveToEntity GetRootAsIMoveToEntity(ByteBuffer _bb)
		{
			return IMoveToEntity.GetRootAsIMoveToEntity(_bb, default(IMoveToEntity));
		}

		// Token: 0x060303E8 RID: 197608 RVA: 0x0068E198 File Offset: 0x0068C398
		public static IMoveToEntity GetRootAsIMoveToEntity(ByteBuffer _bb, IMoveToEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060303E9 RID: 197609 RVA: 0x0068E1B5 File Offset: 0x0068C3B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060303EA RID: 197610 RVA: 0x0068E1C4 File Offset: 0x0068C3C4
		public IMoveToEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC32 RID: 52274
		// (get) Token: 0x060303EB RID: 197611 RVA: 0x0068E1D4 File Offset: 0x0068C3D4
		public EMoveSceneItemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMoveSceneItemType.MoveToPoint;
				}
				return (EMoveSceneItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CC33 RID: 52275
		// (get) Token: 0x060303EC RID: 197612 RVA: 0x0068E210 File Offset: 0x0068C410
		public int EntityId
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

		// Token: 0x1700CC34 RID: 52276
		// (get) Token: 0x060303ED RID: 197613 RVA: 0x0068E24C File Offset: 0x0068C44C
		public TMoveToPointType MoveMotionType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TMoveToPointType.NONE;
				}
				return (TMoveToPointType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060303EE RID: 197614 RVA: 0x0068E288 File Offset: 0x0068C488
		public TTable? MoveMotion<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060303EF RID: 197615 RVA: 0x0068E2D0 File Offset: 0x0068C4D0
		public IUniformMotion MoveMotionAsIUniformMotion()
		{
			return this.MoveMotion<IUniformMotion>().Value;
		}

		// Token: 0x060303F0 RID: 197616 RVA: 0x0068E2EC File Offset: 0x0068C4EC
		public IVariableMotion MoveMotionAsIVariableMotion()
		{
			return this.MoveMotion<IVariableMotion>().Value;
		}

		// Token: 0x060303F1 RID: 197617 RVA: 0x0068E307 File Offset: 0x0068C507
		public static Offset<IMoveToEntity> CreateIMoveToEntity(FlatBufferBuilder builder, EMoveSceneItemType Type = EMoveSceneItemType.MoveToPoint, int EntityId = 0, TMoveToPointType MoveMotion_type = TMoveToPointType.NONE, int MoveMotionOffset = 0)
		{
			builder.StartTable(4);
			IMoveToEntity.AddMoveMotion(builder, MoveMotionOffset);
			IMoveToEntity.AddEntityId(builder, EntityId);
			IMoveToEntity.AddMoveMotionType(builder, MoveMotion_type);
			IMoveToEntity.AddType(builder, Type);
			return IMoveToEntity.EndIMoveToEntity(builder);
		}

		// Token: 0x060303F2 RID: 197618 RVA: 0x0068E333 File Offset: 0x0068C533
		public static void StartIMoveToEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060303F3 RID: 197619 RVA: 0x0068E33C File Offset: 0x0068C53C
		public static void AddType(FlatBufferBuilder builder, EMoveSceneItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060303F4 RID: 197620 RVA: 0x0068E347 File Offset: 0x0068C547
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x060303F5 RID: 197621 RVA: 0x0068E352 File Offset: 0x0068C552
		public static void AddMoveMotionType(FlatBufferBuilder builder, TMoveToPointType moveMotionType)
		{
			builder.AddByte(2, (byte)moveMotionType, 0);
		}

		// Token: 0x060303F6 RID: 197622 RVA: 0x0068E35D File Offset: 0x0068C55D
		public static void AddMoveMotion(FlatBufferBuilder builder, int moveMotionOffset)
		{
			builder.AddOffset(3, moveMotionOffset, 0);
		}

		// Token: 0x060303F7 RID: 197623 RVA: 0x0068E368 File Offset: 0x0068C568
		public static Offset<IMoveToEntity> EndIMoveToEntity(FlatBufferBuilder builder)
		{
			return new Offset<IMoveToEntity>(builder.EndTable());
		}

		// Token: 0x060303F8 RID: 197624 RVA: 0x0068E378 File Offset: 0x0068C578
		public IMoveToEntityT UnPack()
		{
			IMoveToEntityT moveToEntityT = new IMoveToEntityT();
			this.UnPackTo(moveToEntityT);
			return moveToEntityT;
		}

		// Token: 0x060303F9 RID: 197625 RVA: 0x0068E394 File Offset: 0x0068C594
		public void UnPackTo(IMoveToEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.MoveMotion = new TMoveToPointTypeUnion();
			_o.MoveMotion.Type = this.MoveMotionType;
			TMoveToPointType moveMotionType = this.MoveMotionType;
			if (moveMotionType == TMoveToPointType.IUniformMotion)
			{
				_o.MoveMotion.Value = ((this.MoveMotion<IUniformMotion>() != null) ? this.MoveMotion<IUniformMotion>().Value.UnPack() : null);
				return;
			}
			if (moveMotionType != TMoveToPointType.IVariableMotion)
			{
				return;
			}
			_o.MoveMotion.Value = ((this.MoveMotion<IVariableMotion>() != null) ? this.MoveMotion<IVariableMotion>().Value.UnPack() : null);
		}

		// Token: 0x060303FA RID: 197626 RVA: 0x0068E450 File Offset: 0x0068C650
		public static Offset<IMoveToEntity> Pack(FlatBufferBuilder builder, IMoveToEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMoveToEntity>);
			}
			TMoveToPointType moveMotion_type = (_o.MoveMotion == null) ? TMoveToPointType.NONE : _o.MoveMotion.Type;
			int moveMotionOffset = (_o.MoveMotion == null) ? 0 : TMoveToPointTypeUnion.Pack(builder, _o.MoveMotion);
			return IMoveToEntity.CreateIMoveToEntity(builder, _o.Type, _o.EntityId, moveMotion_type, moveMotionOffset);
		}

		// Token: 0x04011407 RID: 70663
		private Table __p;
	}
}
