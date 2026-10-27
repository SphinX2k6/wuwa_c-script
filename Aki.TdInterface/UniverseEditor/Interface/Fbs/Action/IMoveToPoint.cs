using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B60 RID: 27488
	public struct IMoveToPoint : IFlatbufferObject
	{
		// Token: 0x1700CC38 RID: 52280
		// (get) Token: 0x06030403 RID: 197635 RVA: 0x0068E574 File Offset: 0x0068C774
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030404 RID: 197636 RVA: 0x0068E581 File Offset: 0x0068C781
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030405 RID: 197637 RVA: 0x0068E588 File Offset: 0x0068C788
		public static IMoveToPoint GetRootAsIMoveToPoint(ByteBuffer _bb)
		{
			return IMoveToPoint.GetRootAsIMoveToPoint(_bb, default(IMoveToPoint));
		}

		// Token: 0x06030406 RID: 197638 RVA: 0x0068E5A4 File Offset: 0x0068C7A4
		public static IMoveToPoint GetRootAsIMoveToPoint(ByteBuffer _bb, IMoveToPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030407 RID: 197639 RVA: 0x0068E5C1 File Offset: 0x0068C7C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030408 RID: 197640 RVA: 0x0068E5D0 File Offset: 0x0068C7D0
		public IMoveToPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC39 RID: 52281
		// (get) Token: 0x06030409 RID: 197641 RVA: 0x0068E5E0 File Offset: 0x0068C7E0
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

		// Token: 0x1700CC3A RID: 52282
		// (get) Token: 0x0603040A RID: 197642 RVA: 0x0068E61C File Offset: 0x0068C81C
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

		// Token: 0x1700CC3B RID: 52283
		// (get) Token: 0x0603040B RID: 197643 RVA: 0x0068E67C File Offset: 0x0068C87C
		public float Time
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CC3C RID: 52284
		// (get) Token: 0x0603040C RID: 197644 RVA: 0x0068E6BC File Offset: 0x0068C8BC
		public TMoveToPointType MoveMotionType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TMoveToPointType.NONE;
				}
				return (TMoveToPointType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603040D RID: 197645 RVA: 0x0068E6FC File Offset: 0x0068C8FC
		public TTable? MoveMotion<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603040E RID: 197646 RVA: 0x0068E744 File Offset: 0x0068C944
		public IUniformMotion MoveMotionAsIUniformMotion()
		{
			return this.MoveMotion<IUniformMotion>().Value;
		}

		// Token: 0x0603040F RID: 197647 RVA: 0x0068E760 File Offset: 0x0068C960
		public IVariableMotion MoveMotionAsIVariableMotion()
		{
			return this.MoveMotion<IVariableMotion>().Value;
		}

		// Token: 0x06030410 RID: 197648 RVA: 0x0068E77B File Offset: 0x0068C97B
		public static Offset<IMoveToPoint> CreateIMoveToPoint(FlatBufferBuilder builder, EMoveSceneItemType Type = EMoveSceneItemType.MoveToPoint, Offset<IVectorInfo> PointOffset = default(Offset<IVectorInfo>), float Time = 0f, TMoveToPointType MoveMotion_type = TMoveToPointType.NONE, int MoveMotionOffset = 0)
		{
			builder.StartTable(5);
			IMoveToPoint.AddMoveMotion(builder, MoveMotionOffset);
			IMoveToPoint.AddTime(builder, Time);
			IMoveToPoint.AddPoint(builder, PointOffset);
			IMoveToPoint.AddMoveMotionType(builder, MoveMotion_type);
			IMoveToPoint.AddType(builder, Type);
			return IMoveToPoint.EndIMoveToPoint(builder);
		}

		// Token: 0x06030411 RID: 197649 RVA: 0x0068E7AF File Offset: 0x0068C9AF
		public static void StartIMoveToPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06030412 RID: 197650 RVA: 0x0068E7B8 File Offset: 0x0068C9B8
		public static void AddType(FlatBufferBuilder builder, EMoveSceneItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030413 RID: 197651 RVA: 0x0068E7C3 File Offset: 0x0068C9C3
		public static void AddPoint(FlatBufferBuilder builder, Offset<IVectorInfo> pointOffset)
		{
			builder.AddOffset(1, pointOffset.Value, 0);
		}

		// Token: 0x06030414 RID: 197652 RVA: 0x0068E7D3 File Offset: 0x0068C9D3
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(2, time, 0.0);
		}

		// Token: 0x06030415 RID: 197653 RVA: 0x0068E7E6 File Offset: 0x0068C9E6
		public static void AddMoveMotionType(FlatBufferBuilder builder, TMoveToPointType moveMotionType)
		{
			builder.AddByte(3, (byte)moveMotionType, 0);
		}

		// Token: 0x06030416 RID: 197654 RVA: 0x0068E7F1 File Offset: 0x0068C9F1
		public static void AddMoveMotion(FlatBufferBuilder builder, int moveMotionOffset)
		{
			builder.AddOffset(4, moveMotionOffset, 0);
		}

		// Token: 0x06030417 RID: 197655 RVA: 0x0068E7FC File Offset: 0x0068C9FC
		public static Offset<IMoveToPoint> EndIMoveToPoint(FlatBufferBuilder builder)
		{
			return new Offset<IMoveToPoint>(builder.EndTable());
		}

		// Token: 0x06030418 RID: 197656 RVA: 0x0068E80C File Offset: 0x0068CA0C
		public IMoveToPointT UnPack()
		{
			IMoveToPointT moveToPointT = new IMoveToPointT();
			this.UnPackTo(moveToPointT);
			return moveToPointT;
		}

		// Token: 0x06030419 RID: 197657 RVA: 0x0068E828 File Offset: 0x0068CA28
		public void UnPackTo(IMoveToPointT _o)
		{
			_o.Type = this.Type;
			_o.Point = ((this.Point != null) ? this.Point.Value.UnPack() : null);
			_o.Time = this.Time;
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

		// Token: 0x0603041A RID: 197658 RVA: 0x0068E918 File Offset: 0x0068CB18
		public static Offset<IMoveToPoint> Pack(FlatBufferBuilder builder, IMoveToPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMoveToPoint>);
			}
			Offset<IVectorInfo> pointOffset = (_o.Point == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Point);
			TMoveToPointType moveMotion_type = (_o.MoveMotion == null) ? TMoveToPointType.NONE : _o.MoveMotion.Type;
			int moveMotionOffset = (_o.MoveMotion == null) ? 0 : TMoveToPointTypeUnion.Pack(builder, _o.MoveMotion);
			return IMoveToPoint.CreateIMoveToPoint(builder, _o.Type, pointOffset, _o.Time, moveMotion_type, moveMotionOffset);
		}

		// Token: 0x0401140B RID: 70667
		private Table __p;
	}
}
