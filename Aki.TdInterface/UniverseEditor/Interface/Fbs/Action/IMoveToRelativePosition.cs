using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072AC RID: 29356
	public struct IMoveToRelativePosition : IFlatbufferObject
	{
		// Token: 0x1700D72B RID: 55083
		// (get) Token: 0x06033292 RID: 209554 RVA: 0x006E72FC File Offset: 0x006E54FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033293 RID: 209555 RVA: 0x006E7309 File Offset: 0x006E5509
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033294 RID: 209556 RVA: 0x006E7310 File Offset: 0x006E5510
		public static IMoveToRelativePosition GetRootAsIMoveToRelativePosition(ByteBuffer _bb)
		{
			return IMoveToRelativePosition.GetRootAsIMoveToRelativePosition(_bb, default(IMoveToRelativePosition));
		}

		// Token: 0x06033295 RID: 209557 RVA: 0x006E732C File Offset: 0x006E552C
		public static IMoveToRelativePosition GetRootAsIMoveToRelativePosition(ByteBuffer _bb, IMoveToRelativePosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033296 RID: 209558 RVA: 0x006E7349 File Offset: 0x006E5549
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033297 RID: 209559 RVA: 0x006E7358 File Offset: 0x006E5558
		public IMoveToRelativePosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D72C RID: 55084
		// (get) Token: 0x06033298 RID: 209560 RVA: 0x006E7368 File Offset: 0x006E5568
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

		// Token: 0x1700D72D RID: 55085
		// (get) Token: 0x06033299 RID: 209561 RVA: 0x006E73A4 File Offset: 0x006E55A4
		public IVectorInfo? Point
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D72E RID: 55086
		// (get) Token: 0x0603329A RID: 209562 RVA: 0x006E7404 File Offset: 0x006E5604
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

		// Token: 0x0603329B RID: 209563 RVA: 0x006E7440 File Offset: 0x006E5640
		public TTable? MoveMotion<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603329C RID: 209564 RVA: 0x006E7488 File Offset: 0x006E5688
		public IUniformMotion MoveMotionAsIUniformMotion()
		{
			return this.MoveMotion<IUniformMotion>().Value;
		}

		// Token: 0x0603329D RID: 209565 RVA: 0x006E74A4 File Offset: 0x006E56A4
		public IVariableMotion MoveMotionAsIVariableMotion()
		{
			return this.MoveMotion<IVariableMotion>().Value;
		}

		// Token: 0x0603329E RID: 209566 RVA: 0x006E74BF File Offset: 0x006E56BF
		public static Offset<IMoveToRelativePosition> CreateIMoveToRelativePosition(FlatBufferBuilder builder, EMoveSceneItemType Type = EMoveSceneItemType.MoveToPoint, Offset<IVectorInfo> PointOffset = default(Offset<IVectorInfo>), TMoveToPointType MoveMotion_type = TMoveToPointType.NONE, int MoveMotionOffset = 0)
		{
			builder.StartTable(4);
			IMoveToRelativePosition.AddMoveMotion(builder, MoveMotionOffset);
			IMoveToRelativePosition.AddPoint(builder, PointOffset);
			IMoveToRelativePosition.AddMoveMotionType(builder, MoveMotion_type);
			IMoveToRelativePosition.AddType(builder, Type);
			return IMoveToRelativePosition.EndIMoveToRelativePosition(builder);
		}

		// Token: 0x0603329F RID: 209567 RVA: 0x006E74EB File Offset: 0x006E56EB
		public static void StartIMoveToRelativePosition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060332A0 RID: 209568 RVA: 0x006E74F4 File Offset: 0x006E56F4
		public static void AddType(FlatBufferBuilder builder, EMoveSceneItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060332A1 RID: 209569 RVA: 0x006E74FF File Offset: 0x006E56FF
		public static void AddPoint(FlatBufferBuilder builder, Offset<IVectorInfo> pointOffset)
		{
			builder.AddOffset(1, pointOffset.Value, 0);
		}

		// Token: 0x060332A2 RID: 209570 RVA: 0x006E750F File Offset: 0x006E570F
		public static void AddMoveMotionType(FlatBufferBuilder builder, TMoveToPointType moveMotionType)
		{
			builder.AddByte(2, (byte)moveMotionType, 0);
		}

		// Token: 0x060332A3 RID: 209571 RVA: 0x006E751A File Offset: 0x006E571A
		public static void AddMoveMotion(FlatBufferBuilder builder, int moveMotionOffset)
		{
			builder.AddOffset(3, moveMotionOffset, 0);
		}

		// Token: 0x060332A4 RID: 209572 RVA: 0x006E7525 File Offset: 0x006E5725
		public static Offset<IMoveToRelativePosition> EndIMoveToRelativePosition(FlatBufferBuilder builder)
		{
			return new Offset<IMoveToRelativePosition>(builder.EndTable());
		}

		// Token: 0x060332A5 RID: 209573 RVA: 0x006E7534 File Offset: 0x006E5734
		public IMoveToRelativePositionT UnPack()
		{
			IMoveToRelativePositionT moveToRelativePositionT = new IMoveToRelativePositionT();
			this.UnPackTo(moveToRelativePositionT);
			return moveToRelativePositionT;
		}

		// Token: 0x060332A6 RID: 209574 RVA: 0x006E7550 File Offset: 0x006E5750
		public void UnPackTo(IMoveToRelativePositionT _o)
		{
			_o.Type = this.Type;
			_o.Point = ((this.Point != null) ? this.Point.Value.UnPack() : null);
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

		// Token: 0x060332A7 RID: 209575 RVA: 0x006E7634 File Offset: 0x006E5834
		public static Offset<IMoveToRelativePosition> Pack(FlatBufferBuilder builder, IMoveToRelativePositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMoveToRelativePosition>);
			}
			Offset<IVectorInfo> pointOffset = (_o.Point == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Point);
			TMoveToPointType moveMotion_type = (_o.MoveMotion == null) ? TMoveToPointType.NONE : _o.MoveMotion.Type;
			int moveMotionOffset = (_o.MoveMotion == null) ? 0 : TMoveToPointTypeUnion.Pack(builder, _o.MoveMotion);
			return IMoveToRelativePosition.CreateIMoveToRelativePosition(builder, _o.Type, pointOffset, moveMotion_type, moveMotionOffset);
		}

		// Token: 0x0401233C RID: 74556
		private Table __p;
	}
}
