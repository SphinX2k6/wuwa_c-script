using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072DD RID: 29405
	public struct INewMoveWithSpline : IFlatbufferObject
	{
		// Token: 0x1700D79B RID: 55195
		// (get) Token: 0x06033447 RID: 209991 RVA: 0x006EA6CB File Offset: 0x006E88CB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033448 RID: 209992 RVA: 0x006EA6D8 File Offset: 0x006E88D8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033449 RID: 209993 RVA: 0x006EA6E0 File Offset: 0x006E88E0
		public static INewMoveWithSpline GetRootAsINewMoveWithSpline(ByteBuffer _bb)
		{
			return INewMoveWithSpline.GetRootAsINewMoveWithSpline(_bb, default(INewMoveWithSpline));
		}

		// Token: 0x0603344A RID: 209994 RVA: 0x006EA6FC File Offset: 0x006E88FC
		public static INewMoveWithSpline GetRootAsINewMoveWithSpline(ByteBuffer _bb, INewMoveWithSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603344B RID: 209995 RVA: 0x006EA719 File Offset: 0x006E8919
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603344C RID: 209996 RVA: 0x006EA728 File Offset: 0x006E8928
		public INewMoveWithSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D79C RID: 55196
		// (get) Token: 0x0603344D RID: 209997 RVA: 0x006EA738 File Offset: 0x006E8938
		public TNewSplineMoveTarget MoveTargetType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TNewSplineMoveTarget.NONE;
				}
				return (TNewSplineMoveTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603344E RID: 209998 RVA: 0x006EA774 File Offset: 0x006E8974
		public TTable? MoveTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603344F RID: 209999 RVA: 0x006EA7B8 File Offset: 0x006E89B8
		public INpcNewSplineMoveTarget MoveTargetAsINpcNewSplineMoveTarget()
		{
			return this.MoveTarget<INpcNewSplineMoveTarget>().Value;
		}

		// Token: 0x06033450 RID: 210000 RVA: 0x006EA7D4 File Offset: 0x006E89D4
		public IPlayerNewSplineMoveTarget MoveTargetAsIPlayerNewSplineMoveTarget()
		{
			return this.MoveTarget<IPlayerNewSplineMoveTarget>().Value;
		}

		// Token: 0x06033451 RID: 210001 RVA: 0x006EA7F0 File Offset: 0x006E89F0
		public ISceneItemNewSplineMoveTarget MoveTargetAsISceneItemNewSplineMoveTarget()
		{
			return this.MoveTarget<ISceneItemNewSplineMoveTarget>().Value;
		}

		// Token: 0x06033452 RID: 210002 RVA: 0x006EA80C File Offset: 0x006E8A0C
		public IVehicleNewSplineMoveTarget MoveTargetAsIVehicleNewSplineMoveTarget()
		{
			return this.MoveTarget<IVehicleNewSplineMoveTarget>().Value;
		}

		// Token: 0x1700D79D RID: 55197
		// (get) Token: 0x06033453 RID: 210003 RVA: 0x006EA828 File Offset: 0x006E8A28
		public IFrontAxleTrackingSplineMove? Move
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IFrontAxleTrackingSplineMove?(default(IFrontAxleTrackingSplineMove).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D79E RID: 55198
		// (get) Token: 0x06033454 RID: 210004 RVA: 0x006EA888 File Offset: 0x006E8A88
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D79F RID: 55199
		// (get) Token: 0x06033455 RID: 210005 RVA: 0x006EA8C8 File Offset: 0x006E8AC8
		public int StartPointIndex
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D7A0 RID: 55200
		// (get) Token: 0x06033456 RID: 210006 RVA: 0x006EA908 File Offset: 0x006E8B08
		public int EndPointIndex
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D7A1 RID: 55201
		// (get) Token: 0x06033457 RID: 210007 RVA: 0x006EA948 File Offset: 0x006E8B48
		public bool IsStartFromCurrentPos
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D7A2 RID: 55202
		// (get) Token: 0x06033458 RID: 210008 RVA: 0x006EA988 File Offset: 0x006E8B88
		public bool IsFollowStrictly
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D7A3 RID: 55203
		// (get) Token: 0x06033459 RID: 210009 RVA: 0x006EA9C8 File Offset: 0x006E8BC8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603345A RID: 210010 RVA: 0x006EAA08 File Offset: 0x006E8C08
		public static Offset<INewMoveWithSpline> CreateINewMoveWithSpline(FlatBufferBuilder builder, TNewSplineMoveTarget MoveTarget_type = TNewSplineMoveTarget.NONE, int MoveTargetOffset = 0, Offset<IFrontAxleTrackingSplineMove> MoveOffset = default(Offset<IFrontAxleTrackingSplineMove>), int SplineEntityId = 0, int StartPointIndex = 0, int EndPointIndex = 0, bool IsStartFromCurrentPos = false, bool IsFollowStrictly = false, byte NullMask = 0)
		{
			builder.StartTable(9);
			INewMoveWithSpline.AddEndPointIndex(builder, EndPointIndex);
			INewMoveWithSpline.AddStartPointIndex(builder, StartPointIndex);
			INewMoveWithSpline.AddSplineEntityId(builder, SplineEntityId);
			INewMoveWithSpline.AddMove(builder, MoveOffset);
			INewMoveWithSpline.AddMoveTarget(builder, MoveTargetOffset);
			INewMoveWithSpline.AddNullMask(builder, NullMask);
			INewMoveWithSpline.AddIsFollowStrictly(builder, IsFollowStrictly);
			INewMoveWithSpline.AddIsStartFromCurrentPos(builder, IsStartFromCurrentPos);
			INewMoveWithSpline.AddMoveTargetType(builder, MoveTarget_type);
			return INewMoveWithSpline.EndINewMoveWithSpline(builder);
		}

		// Token: 0x0603345B RID: 210011 RVA: 0x006EAA68 File Offset: 0x006E8C68
		public static void StartINewMoveWithSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0603345C RID: 210012 RVA: 0x006EAA72 File Offset: 0x006E8C72
		public static void AddMoveTargetType(FlatBufferBuilder builder, TNewSplineMoveTarget moveTargetType)
		{
			builder.AddByte(0, (byte)moveTargetType, 0);
		}

		// Token: 0x0603345D RID: 210013 RVA: 0x006EAA7D File Offset: 0x006E8C7D
		public static void AddMoveTarget(FlatBufferBuilder builder, int moveTargetOffset)
		{
			builder.AddOffset(1, moveTargetOffset, 0);
		}

		// Token: 0x0603345E RID: 210014 RVA: 0x006EAA88 File Offset: 0x006E8C88
		public static void AddMove(FlatBufferBuilder builder, Offset<IFrontAxleTrackingSplineMove> moveOffset)
		{
			builder.AddOffset(2, moveOffset.Value, 0);
		}

		// Token: 0x0603345F RID: 210015 RVA: 0x006EAA98 File Offset: 0x006E8C98
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(3, splineEntityId, 0);
		}

		// Token: 0x06033460 RID: 210016 RVA: 0x006EAAA3 File Offset: 0x006E8CA3
		public static void AddStartPointIndex(FlatBufferBuilder builder, int startPointIndex)
		{
			builder.AddInt(4, startPointIndex, 0);
		}

		// Token: 0x06033461 RID: 210017 RVA: 0x006EAAAE File Offset: 0x006E8CAE
		public static void AddEndPointIndex(FlatBufferBuilder builder, int endPointIndex)
		{
			builder.AddInt(5, endPointIndex, 0);
		}

		// Token: 0x06033462 RID: 210018 RVA: 0x006EAAB9 File Offset: 0x006E8CB9
		public static void AddIsStartFromCurrentPos(FlatBufferBuilder builder, bool isStartFromCurrentPos)
		{
			builder.AddBool(6, isStartFromCurrentPos, false);
		}

		// Token: 0x06033463 RID: 210019 RVA: 0x006EAAC4 File Offset: 0x006E8CC4
		public static void AddIsFollowStrictly(FlatBufferBuilder builder, bool isFollowStrictly)
		{
			builder.AddBool(7, isFollowStrictly, false);
		}

		// Token: 0x06033464 RID: 210020 RVA: 0x006EAACF File Offset: 0x006E8CCF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06033465 RID: 210021 RVA: 0x006EAADA File Offset: 0x006E8CDA
		public static Offset<INewMoveWithSpline> EndINewMoveWithSpline(FlatBufferBuilder builder)
		{
			return new Offset<INewMoveWithSpline>(builder.EndTable());
		}

		// Token: 0x06033466 RID: 210022 RVA: 0x006EAAE8 File Offset: 0x006E8CE8
		public INewMoveWithSplineT UnPack()
		{
			INewMoveWithSplineT newMoveWithSplineT = new INewMoveWithSplineT();
			this.UnPackTo(newMoveWithSplineT);
			return newMoveWithSplineT;
		}

		// Token: 0x06033467 RID: 210023 RVA: 0x006EAB04 File Offset: 0x006E8D04
		public void UnPackTo(INewMoveWithSplineT _o)
		{
			_o.MoveTarget = new TNewSplineMoveTargetUnion();
			_o.MoveTarget.Type = this.MoveTargetType;
			switch (this.MoveTargetType)
			{
			case TNewSplineMoveTarget.INpcNewSplineMoveTarget:
				_o.MoveTarget.Value = ((this.MoveTarget<INpcNewSplineMoveTarget>() != null) ? this.MoveTarget<INpcNewSplineMoveTarget>().Value.UnPack() : null);
				break;
			case TNewSplineMoveTarget.IPlayerNewSplineMoveTarget:
				_o.MoveTarget.Value = ((this.MoveTarget<IPlayerNewSplineMoveTarget>() != null) ? this.MoveTarget<IPlayerNewSplineMoveTarget>().Value.UnPack() : null);
				break;
			case TNewSplineMoveTarget.ISceneItemNewSplineMoveTarget:
				_o.MoveTarget.Value = ((this.MoveTarget<ISceneItemNewSplineMoveTarget>() != null) ? this.MoveTarget<ISceneItemNewSplineMoveTarget>().Value.UnPack() : null);
				break;
			case TNewSplineMoveTarget.IVehicleNewSplineMoveTarget:
				_o.MoveTarget.Value = ((this.MoveTarget<IVehicleNewSplineMoveTarget>() != null) ? this.MoveTarget<IVehicleNewSplineMoveTarget>().Value.UnPack() : null);
				break;
			}
			_o.Move = ((this.Move != null) ? this.Move.Value.UnPack() : null);
			_o.SplineEntityId = this.SplineEntityId;
			_o.StartPointIndex = this.StartPointIndex;
			_o.EndPointIndex = this.EndPointIndex;
			_o.IsStartFromCurrentPos = this.IsStartFromCurrentPos;
			_o.IsFollowStrictly = this.IsFollowStrictly;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06033468 RID: 210024 RVA: 0x006EACAC File Offset: 0x006E8EAC
		public static Offset<INewMoveWithSpline> Pack(FlatBufferBuilder builder, INewMoveWithSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<INewMoveWithSpline>);
			}
			TNewSplineMoveTarget moveTarget_type = (_o.MoveTarget == null) ? TNewSplineMoveTarget.NONE : _o.MoveTarget.Type;
			int moveTargetOffset = (_o.MoveTarget == null) ? 0 : TNewSplineMoveTargetUnion.Pack(builder, _o.MoveTarget);
			Offset<IFrontAxleTrackingSplineMove> moveOffset = (_o.Move == null) ? default(Offset<IFrontAxleTrackingSplineMove>) : IFrontAxleTrackingSplineMove.Pack(builder, _o.Move);
			return INewMoveWithSpline.CreateINewMoveWithSpline(builder, moveTarget_type, moveTargetOffset, moveOffset, _o.SplineEntityId, _o.StartPointIndex, _o.EndPointIndex, _o.IsStartFromCurrentPos, _o.IsFollowStrictly, _o.NullMask);
		}

		// Token: 0x04012381 RID: 74625
		private Table __p;
	}
}
