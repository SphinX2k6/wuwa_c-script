using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B69 RID: 27497
	public struct IMoveWithSpline : IFlatbufferObject
	{
		// Token: 0x1700CC4D RID: 52301
		// (get) Token: 0x06030459 RID: 197721 RVA: 0x0068F1CF File Offset: 0x0068D3CF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603045A RID: 197722 RVA: 0x0068F1DC File Offset: 0x0068D3DC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603045B RID: 197723 RVA: 0x0068F1E4 File Offset: 0x0068D3E4
		public static IMoveWithSpline GetRootAsIMoveWithSpline(ByteBuffer _bb)
		{
			return IMoveWithSpline.GetRootAsIMoveWithSpline(_bb, default(IMoveWithSpline));
		}

		// Token: 0x0603045C RID: 197724 RVA: 0x0068F200 File Offset: 0x0068D400
		public static IMoveWithSpline GetRootAsIMoveWithSpline(ByteBuffer _bb, IMoveWithSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603045D RID: 197725 RVA: 0x0068F21D File Offset: 0x0068D41D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603045E RID: 197726 RVA: 0x0068F22C File Offset: 0x0068D42C
		public IMoveWithSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC4E RID: 52302
		// (get) Token: 0x0603045F RID: 197727 RVA: 0x0068F23C File Offset: 0x0068D43C
		public TSplineMoveTarget MoveTargetType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TSplineMoveTarget.NONE;
				}
				return (TSplineMoveTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030460 RID: 197728 RVA: 0x0068F278 File Offset: 0x0068D478
		public TTable? MoveTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030461 RID: 197729 RVA: 0x0068F2BC File Offset: 0x0068D4BC
		public IEntitySplineMoveTarget MoveTargetAsIEntitySplineMoveTarget()
		{
			return this.MoveTarget<IEntitySplineMoveTarget>().Value;
		}

		// Token: 0x06030462 RID: 197730 RVA: 0x0068F2D8 File Offset: 0x0068D4D8
		public IPlayerSplineMoveTarget MoveTargetAsIPlayerSplineMoveTarget()
		{
			return this.MoveTarget<IPlayerSplineMoveTarget>().Value;
		}

		// Token: 0x1700CC4F RID: 52303
		// (get) Token: 0x06030463 RID: 197731 RVA: 0x0068F2F4 File Offset: 0x0068D4F4
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CC50 RID: 52304
		// (get) Token: 0x06030464 RID: 197732 RVA: 0x0068F330 File Offset: 0x0068D530
		public ICheckClimb? CheckClimb
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ICheckClimb?(default(ICheckClimb).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CC51 RID: 52305
		// (get) Token: 0x06030465 RID: 197733 RVA: 0x0068F390 File Offset: 0x0068D590
		public IMoveOnWallConfig? MoveOnWallConfig
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IMoveOnWallConfig?(default(IMoveOnWallConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CC52 RID: 52306
		// (get) Token: 0x06030466 RID: 197734 RVA: 0x0068F3F0 File Offset: 0x0068D5F0
		public EMoveSpeed MoveState
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return EMoveSpeed.None;
				}
				return (EMoveSpeed)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CC53 RID: 52307
		// (get) Token: 0x06030467 RID: 197735 RVA: 0x0068F430 File Offset: 0x0068D630
		public int StartPointIndex
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CC54 RID: 52308
		// (get) Token: 0x06030468 RID: 197736 RVA: 0x0068F470 File Offset: 0x0068D670
		public int EndPointIndex
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CC55 RID: 52309
		// (get) Token: 0x06030469 RID: 197737 RVA: 0x0068F4B0 File Offset: 0x0068D6B0
		public bool IsFollowStrictly
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CC56 RID: 52310
		// (get) Token: 0x0603046A RID: 197738 RVA: 0x0068F4F0 File Offset: 0x0068D6F0
		public bool IsForceToFirstPoint
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CC57 RID: 52311
		// (get) Token: 0x0603046B RID: 197739 RVA: 0x0068F530 File Offset: 0x0068D730
		public bool IsLookDir
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CC58 RID: 52312
		// (get) Token: 0x0603046C RID: 197740 RVA: 0x0068F570 File Offset: 0x0068D770
		public INpcFollowConfig? NpcFollow
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return new INpcFollowConfig?(default(INpcFollowConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CC59 RID: 52313
		// (get) Token: 0x0603046D RID: 197741 RVA: 0x0068F5D0 File Offset: 0x0068D7D0
		public bool NpcCollisionEnabled
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CC5A RID: 52314
		// (get) Token: 0x0603046E RID: 197742 RVA: 0x0068F610 File Offset: 0x0068D810
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603046F RID: 197743 RVA: 0x0068F650 File Offset: 0x0068D850
		public static Offset<IMoveWithSpline> CreateIMoveWithSpline(FlatBufferBuilder builder, TSplineMoveTarget MoveTarget_type = TSplineMoveTarget.NONE, int MoveTargetOffset = 0, int SplineEntityId = 0, Offset<ICheckClimb> CheckClimbOffset = default(Offset<ICheckClimb>), Offset<IMoveOnWallConfig> MoveOnWallConfigOffset = default(Offset<IMoveOnWallConfig>), EMoveSpeed MoveState = EMoveSpeed.None, int StartPointIndex = 0, int EndPointIndex = 0, bool IsFollowStrictly = false, bool IsForceToFirstPoint = false, bool IsLookDir = false, Offset<INpcFollowConfig> NpcFollowOffset = default(Offset<INpcFollowConfig>), bool NpcCollisionEnabled = false, byte NullMask = 0)
		{
			builder.StartTable(14);
			IMoveWithSpline.AddNpcFollow(builder, NpcFollowOffset);
			IMoveWithSpline.AddEndPointIndex(builder, EndPointIndex);
			IMoveWithSpline.AddStartPointIndex(builder, StartPointIndex);
			IMoveWithSpline.AddMoveOnWallConfig(builder, MoveOnWallConfigOffset);
			IMoveWithSpline.AddCheckClimb(builder, CheckClimbOffset);
			IMoveWithSpline.AddSplineEntityId(builder, SplineEntityId);
			IMoveWithSpline.AddMoveTarget(builder, MoveTargetOffset);
			IMoveWithSpline.AddNullMask(builder, NullMask);
			IMoveWithSpline.AddNpcCollisionEnabled(builder, NpcCollisionEnabled);
			IMoveWithSpline.AddIsLookDir(builder, IsLookDir);
			IMoveWithSpline.AddIsForceToFirstPoint(builder, IsForceToFirstPoint);
			IMoveWithSpline.AddIsFollowStrictly(builder, IsFollowStrictly);
			IMoveWithSpline.AddMoveState(builder, MoveState);
			IMoveWithSpline.AddMoveTargetType(builder, MoveTarget_type);
			return IMoveWithSpline.EndIMoveWithSpline(builder);
		}

		// Token: 0x06030470 RID: 197744 RVA: 0x0068F6D8 File Offset: 0x0068D8D8
		public static void StartIMoveWithSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(14);
		}

		// Token: 0x06030471 RID: 197745 RVA: 0x0068F6E2 File Offset: 0x0068D8E2
		public static void AddMoveTargetType(FlatBufferBuilder builder, TSplineMoveTarget moveTargetType)
		{
			builder.AddByte(0, (byte)moveTargetType, 0);
		}

		// Token: 0x06030472 RID: 197746 RVA: 0x0068F6ED File Offset: 0x0068D8ED
		public static void AddMoveTarget(FlatBufferBuilder builder, int moveTargetOffset)
		{
			builder.AddOffset(1, moveTargetOffset, 0);
		}

		// Token: 0x06030473 RID: 197747 RVA: 0x0068F6F8 File Offset: 0x0068D8F8
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(2, splineEntityId, 0);
		}

		// Token: 0x06030474 RID: 197748 RVA: 0x0068F703 File Offset: 0x0068D903
		public static void AddCheckClimb(FlatBufferBuilder builder, Offset<ICheckClimb> checkClimbOffset)
		{
			builder.AddOffset(3, checkClimbOffset.Value, 0);
		}

		// Token: 0x06030475 RID: 197749 RVA: 0x0068F713 File Offset: 0x0068D913
		public static void AddMoveOnWallConfig(FlatBufferBuilder builder, Offset<IMoveOnWallConfig> moveOnWallConfigOffset)
		{
			builder.AddOffset(4, moveOnWallConfigOffset.Value, 0);
		}

		// Token: 0x06030476 RID: 197750 RVA: 0x0068F723 File Offset: 0x0068D923
		public static void AddMoveState(FlatBufferBuilder builder, EMoveSpeed moveState)
		{
			builder.AddByte(5, (byte)moveState, 0);
		}

		// Token: 0x06030477 RID: 197751 RVA: 0x0068F72E File Offset: 0x0068D92E
		public static void AddStartPointIndex(FlatBufferBuilder builder, int startPointIndex)
		{
			builder.AddInt(6, startPointIndex, 0);
		}

		// Token: 0x06030478 RID: 197752 RVA: 0x0068F739 File Offset: 0x0068D939
		public static void AddEndPointIndex(FlatBufferBuilder builder, int endPointIndex)
		{
			builder.AddInt(7, endPointIndex, 0);
		}

		// Token: 0x06030479 RID: 197753 RVA: 0x0068F744 File Offset: 0x0068D944
		public static void AddIsFollowStrictly(FlatBufferBuilder builder, bool isFollowStrictly)
		{
			builder.AddBool(8, isFollowStrictly, false);
		}

		// Token: 0x0603047A RID: 197754 RVA: 0x0068F74F File Offset: 0x0068D94F
		public static void AddIsForceToFirstPoint(FlatBufferBuilder builder, bool isForceToFirstPoint)
		{
			builder.AddBool(9, isForceToFirstPoint, false);
		}

		// Token: 0x0603047B RID: 197755 RVA: 0x0068F75B File Offset: 0x0068D95B
		public static void AddIsLookDir(FlatBufferBuilder builder, bool isLookDir)
		{
			builder.AddBool(10, isLookDir, false);
		}

		// Token: 0x0603047C RID: 197756 RVA: 0x0068F767 File Offset: 0x0068D967
		public static void AddNpcFollow(FlatBufferBuilder builder, Offset<INpcFollowConfig> npcFollowOffset)
		{
			builder.AddOffset(11, npcFollowOffset.Value, 0);
		}

		// Token: 0x0603047D RID: 197757 RVA: 0x0068F778 File Offset: 0x0068D978
		public static void AddNpcCollisionEnabled(FlatBufferBuilder builder, bool npcCollisionEnabled)
		{
			builder.AddBool(12, npcCollisionEnabled, false);
		}

		// Token: 0x0603047E RID: 197758 RVA: 0x0068F784 File Offset: 0x0068D984
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(13, nullMask, 0);
		}

		// Token: 0x0603047F RID: 197759 RVA: 0x0068F790 File Offset: 0x0068D990
		public static Offset<IMoveWithSpline> EndIMoveWithSpline(FlatBufferBuilder builder)
		{
			return new Offset<IMoveWithSpline>(builder.EndTable());
		}

		// Token: 0x06030480 RID: 197760 RVA: 0x0068F7A0 File Offset: 0x0068D9A0
		public IMoveWithSplineT UnPack()
		{
			IMoveWithSplineT moveWithSplineT = new IMoveWithSplineT();
			this.UnPackTo(moveWithSplineT);
			return moveWithSplineT;
		}

		// Token: 0x06030481 RID: 197761 RVA: 0x0068F7BC File Offset: 0x0068D9BC
		public void UnPackTo(IMoveWithSplineT _o)
		{
			_o.MoveTarget = new TSplineMoveTargetUnion();
			_o.MoveTarget.Type = this.MoveTargetType;
			TSplineMoveTarget moveTargetType = this.MoveTargetType;
			if (moveTargetType != TSplineMoveTarget.IEntitySplineMoveTarget)
			{
				if (moveTargetType == TSplineMoveTarget.IPlayerSplineMoveTarget)
				{
					_o.MoveTarget.Value = ((this.MoveTarget<IPlayerSplineMoveTarget>() != null) ? this.MoveTarget<IPlayerSplineMoveTarget>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.MoveTarget.Value = ((this.MoveTarget<IEntitySplineMoveTarget>() != null) ? this.MoveTarget<IEntitySplineMoveTarget>().Value.UnPack() : null);
			}
			_o.SplineEntityId = this.SplineEntityId;
			_o.CheckClimb = ((this.CheckClimb != null) ? this.CheckClimb.Value.UnPack() : null);
			_o.MoveOnWallConfig = ((this.MoveOnWallConfig != null) ? this.MoveOnWallConfig.Value.UnPack() : null);
			_o.MoveState = this.MoveState;
			_o.StartPointIndex = this.StartPointIndex;
			_o.EndPointIndex = this.EndPointIndex;
			_o.IsFollowStrictly = this.IsFollowStrictly;
			_o.IsForceToFirstPoint = this.IsForceToFirstPoint;
			_o.IsLookDir = this.IsLookDir;
			_o.NpcFollow = ((this.NpcFollow != null) ? this.NpcFollow.Value.UnPack() : null);
			_o.NpcCollisionEnabled = this.NpcCollisionEnabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030482 RID: 197762 RVA: 0x0068F964 File Offset: 0x0068DB64
		public static Offset<IMoveWithSpline> Pack(FlatBufferBuilder builder, IMoveWithSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMoveWithSpline>);
			}
			TSplineMoveTarget moveTarget_type = (_o.MoveTarget == null) ? TSplineMoveTarget.NONE : _o.MoveTarget.Type;
			int moveTargetOffset = (_o.MoveTarget == null) ? 0 : TSplineMoveTargetUnion.Pack(builder, _o.MoveTarget);
			Offset<ICheckClimb> checkClimbOffset = (_o.CheckClimb == null) ? default(Offset<ICheckClimb>) : ICheckClimb.Pack(builder, _o.CheckClimb);
			Offset<IMoveOnWallConfig> moveOnWallConfigOffset = (_o.MoveOnWallConfig == null) ? default(Offset<IMoveOnWallConfig>) : IMoveOnWallConfig.Pack(builder, _o.MoveOnWallConfig);
			Offset<INpcFollowConfig> npcFollowOffset = (_o.NpcFollow == null) ? default(Offset<INpcFollowConfig>) : INpcFollowConfig.Pack(builder, _o.NpcFollow);
			return IMoveWithSpline.CreateIMoveWithSpline(builder, moveTarget_type, moveTargetOffset, _o.SplineEntityId, checkClimbOffset, moveOnWallConfigOffset, _o.MoveState, _o.StartPointIndex, _o.EndPointIndex, _o.IsFollowStrictly, _o.IsForceToFirstPoint, _o.IsLookDir, npcFollowOffset, _o.NpcCollisionEnabled, _o.NullMask);
		}

		// Token: 0x04011417 RID: 70679
		private Table __p;
	}
}
