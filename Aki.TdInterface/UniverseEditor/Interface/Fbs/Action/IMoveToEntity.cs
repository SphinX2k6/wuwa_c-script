using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072A3 RID: 29347
	public struct IMoveToEntity : IFlatbufferObject
	{
		// Token: 0x1700D716 RID: 55062
		// (get) Token: 0x0603323C RID: 209468 RVA: 0x006E6724 File Offset: 0x006E4924
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603323D RID: 209469 RVA: 0x006E6731 File Offset: 0x006E4931
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603323E RID: 209470 RVA: 0x006E6738 File Offset: 0x006E4938
		public static IMoveToEntity GetRootAsIMoveToEntity(ByteBuffer _bb)
		{
			return IMoveToEntity.GetRootAsIMoveToEntity(_bb, default(IMoveToEntity));
		}

		// Token: 0x0603323F RID: 209471 RVA: 0x006E6754 File Offset: 0x006E4954
		public static IMoveToEntity GetRootAsIMoveToEntity(ByteBuffer _bb, IMoveToEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033240 RID: 209472 RVA: 0x006E6771 File Offset: 0x006E4971
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033241 RID: 209473 RVA: 0x006E6780 File Offset: 0x006E4980
		public IMoveToEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D717 RID: 55063
		// (get) Token: 0x06033242 RID: 209474 RVA: 0x006E6790 File Offset: 0x006E4990
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

		// Token: 0x1700D718 RID: 55064
		// (get) Token: 0x06033243 RID: 209475 RVA: 0x006E67CC File Offset: 0x006E49CC
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

		// Token: 0x1700D719 RID: 55065
		// (get) Token: 0x06033244 RID: 209476 RVA: 0x006E6808 File Offset: 0x006E4A08
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

		// Token: 0x06033245 RID: 209477 RVA: 0x006E6844 File Offset: 0x006E4A44
		public TTable? MoveMotion<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033246 RID: 209478 RVA: 0x006E688C File Offset: 0x006E4A8C
		public IUniformMotion MoveMotionAsIUniformMotion()
		{
			return this.MoveMotion<IUniformMotion>().Value;
		}

		// Token: 0x06033247 RID: 209479 RVA: 0x006E68A8 File Offset: 0x006E4AA8
		public IVariableMotion MoveMotionAsIVariableMotion()
		{
			return this.MoveMotion<IVariableMotion>().Value;
		}

		// Token: 0x06033248 RID: 209480 RVA: 0x006E68C3 File Offset: 0x006E4AC3
		public static Offset<IMoveToEntity> CreateIMoveToEntity(FlatBufferBuilder builder, EMoveSceneItemType Type = EMoveSceneItemType.MoveToPoint, int EntityId = 0, TMoveToPointType MoveMotion_type = TMoveToPointType.NONE, int MoveMotionOffset = 0)
		{
			builder.StartTable(4);
			IMoveToEntity.AddMoveMotion(builder, MoveMotionOffset);
			IMoveToEntity.AddEntityId(builder, EntityId);
			IMoveToEntity.AddMoveMotionType(builder, MoveMotion_type);
			IMoveToEntity.AddType(builder, Type);
			return IMoveToEntity.EndIMoveToEntity(builder);
		}

		// Token: 0x06033249 RID: 209481 RVA: 0x006E68EF File Offset: 0x006E4AEF
		public static void StartIMoveToEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603324A RID: 209482 RVA: 0x006E68F8 File Offset: 0x006E4AF8
		public static void AddType(FlatBufferBuilder builder, EMoveSceneItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603324B RID: 209483 RVA: 0x006E6903 File Offset: 0x006E4B03
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0603324C RID: 209484 RVA: 0x006E690E File Offset: 0x006E4B0E
		public static void AddMoveMotionType(FlatBufferBuilder builder, TMoveToPointType moveMotionType)
		{
			builder.AddByte(2, (byte)moveMotionType, 0);
		}

		// Token: 0x0603324D RID: 209485 RVA: 0x006E6919 File Offset: 0x006E4B19
		public static void AddMoveMotion(FlatBufferBuilder builder, int moveMotionOffset)
		{
			builder.AddOffset(3, moveMotionOffset, 0);
		}

		// Token: 0x0603324E RID: 209486 RVA: 0x006E6924 File Offset: 0x006E4B24
		public static Offset<IMoveToEntity> EndIMoveToEntity(FlatBufferBuilder builder)
		{
			return new Offset<IMoveToEntity>(builder.EndTable());
		}

		// Token: 0x0603324F RID: 209487 RVA: 0x006E6934 File Offset: 0x006E4B34
		public IMoveToEntityT UnPack()
		{
			IMoveToEntityT moveToEntityT = new IMoveToEntityT();
			this.UnPackTo(moveToEntityT);
			return moveToEntityT;
		}

		// Token: 0x06033250 RID: 209488 RVA: 0x006E6950 File Offset: 0x006E4B50
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

		// Token: 0x06033251 RID: 209489 RVA: 0x006E6A0C File Offset: 0x006E4C0C
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

		// Token: 0x04012330 RID: 74544
		private Table __p;
	}
}
