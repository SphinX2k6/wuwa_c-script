using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B66 RID: 27494
	public struct IMoveToRelativePosition : IFlatbufferObject
	{
		// Token: 0x1700CC46 RID: 52294
		// (get) Token: 0x0603043B RID: 197691 RVA: 0x0068ED40 File Offset: 0x0068CF40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603043C RID: 197692 RVA: 0x0068ED4D File Offset: 0x0068CF4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603043D RID: 197693 RVA: 0x0068ED54 File Offset: 0x0068CF54
		public static IMoveToRelativePosition GetRootAsIMoveToRelativePosition(ByteBuffer _bb)
		{
			return IMoveToRelativePosition.GetRootAsIMoveToRelativePosition(_bb, default(IMoveToRelativePosition));
		}

		// Token: 0x0603043E RID: 197694 RVA: 0x0068ED70 File Offset: 0x0068CF70
		public static IMoveToRelativePosition GetRootAsIMoveToRelativePosition(ByteBuffer _bb, IMoveToRelativePosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603043F RID: 197695 RVA: 0x0068ED8D File Offset: 0x0068CF8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030440 RID: 197696 RVA: 0x0068ED9C File Offset: 0x0068CF9C
		public IMoveToRelativePosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC47 RID: 52295
		// (get) Token: 0x06030441 RID: 197697 RVA: 0x0068EDAC File Offset: 0x0068CFAC
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

		// Token: 0x1700CC48 RID: 52296
		// (get) Token: 0x06030442 RID: 197698 RVA: 0x0068EDE8 File Offset: 0x0068CFE8
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

		// Token: 0x1700CC49 RID: 52297
		// (get) Token: 0x06030443 RID: 197699 RVA: 0x0068EE48 File Offset: 0x0068D048
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

		// Token: 0x06030444 RID: 197700 RVA: 0x0068EE84 File Offset: 0x0068D084
		public TTable? MoveMotion<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030445 RID: 197701 RVA: 0x0068EECC File Offset: 0x0068D0CC
		public IUniformMotion MoveMotionAsIUniformMotion()
		{
			return this.MoveMotion<IUniformMotion>().Value;
		}

		// Token: 0x06030446 RID: 197702 RVA: 0x0068EEE8 File Offset: 0x0068D0E8
		public IVariableMotion MoveMotionAsIVariableMotion()
		{
			return this.MoveMotion<IVariableMotion>().Value;
		}

		// Token: 0x06030447 RID: 197703 RVA: 0x0068EF03 File Offset: 0x0068D103
		public static Offset<IMoveToRelativePosition> CreateIMoveToRelativePosition(FlatBufferBuilder builder, EMoveSceneItemType Type = EMoveSceneItemType.MoveToPoint, Offset<IVectorInfo> PointOffset = default(Offset<IVectorInfo>), TMoveToPointType MoveMotion_type = TMoveToPointType.NONE, int MoveMotionOffset = 0)
		{
			builder.StartTable(4);
			IMoveToRelativePosition.AddMoveMotion(builder, MoveMotionOffset);
			IMoveToRelativePosition.AddPoint(builder, PointOffset);
			IMoveToRelativePosition.AddMoveMotionType(builder, MoveMotion_type);
			IMoveToRelativePosition.AddType(builder, Type);
			return IMoveToRelativePosition.EndIMoveToRelativePosition(builder);
		}

		// Token: 0x06030448 RID: 197704 RVA: 0x0068EF2F File Offset: 0x0068D12F
		public static void StartIMoveToRelativePosition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06030449 RID: 197705 RVA: 0x0068EF38 File Offset: 0x0068D138
		public static void AddType(FlatBufferBuilder builder, EMoveSceneItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603044A RID: 197706 RVA: 0x0068EF43 File Offset: 0x0068D143
		public static void AddPoint(FlatBufferBuilder builder, Offset<IVectorInfo> pointOffset)
		{
			builder.AddOffset(1, pointOffset.Value, 0);
		}

		// Token: 0x0603044B RID: 197707 RVA: 0x0068EF53 File Offset: 0x0068D153
		public static void AddMoveMotionType(FlatBufferBuilder builder, TMoveToPointType moveMotionType)
		{
			builder.AddByte(2, (byte)moveMotionType, 0);
		}

		// Token: 0x0603044C RID: 197708 RVA: 0x0068EF5E File Offset: 0x0068D15E
		public static void AddMoveMotion(FlatBufferBuilder builder, int moveMotionOffset)
		{
			builder.AddOffset(3, moveMotionOffset, 0);
		}

		// Token: 0x0603044D RID: 197709 RVA: 0x0068EF69 File Offset: 0x0068D169
		public static Offset<IMoveToRelativePosition> EndIMoveToRelativePosition(FlatBufferBuilder builder)
		{
			return new Offset<IMoveToRelativePosition>(builder.EndTable());
		}

		// Token: 0x0603044E RID: 197710 RVA: 0x0068EF78 File Offset: 0x0068D178
		public IMoveToRelativePositionT UnPack()
		{
			IMoveToRelativePositionT moveToRelativePositionT = new IMoveToRelativePositionT();
			this.UnPackTo(moveToRelativePositionT);
			return moveToRelativePositionT;
		}

		// Token: 0x0603044F RID: 197711 RVA: 0x0068EF94 File Offset: 0x0068D194
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

		// Token: 0x06030450 RID: 197712 RVA: 0x0068F078 File Offset: 0x0068D278
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

		// Token: 0x04011413 RID: 70675
		private Table __p;
	}
}
