using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072AF RID: 29359
	public struct IMoveWithSpline : IFlatbufferObject
	{
		// Token: 0x1700D732 RID: 55090
		// (get) Token: 0x060332B0 RID: 209584 RVA: 0x006E778B File Offset: 0x006E598B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060332B1 RID: 209585 RVA: 0x006E7798 File Offset: 0x006E5998
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060332B2 RID: 209586 RVA: 0x006E77A0 File Offset: 0x006E59A0
		public static IMoveWithSpline GetRootAsIMoveWithSpline(ByteBuffer _bb)
		{
			return IMoveWithSpline.GetRootAsIMoveWithSpline(_bb, default(IMoveWithSpline));
		}

		// Token: 0x060332B3 RID: 209587 RVA: 0x006E77BC File Offset: 0x006E59BC
		public static IMoveWithSpline GetRootAsIMoveWithSpline(ByteBuffer _bb, IMoveWithSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060332B4 RID: 209588 RVA: 0x006E77D9 File Offset: 0x006E59D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060332B5 RID: 209589 RVA: 0x006E77E8 File Offset: 0x006E59E8
		public IMoveWithSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D733 RID: 55091
		// (get) Token: 0x060332B6 RID: 209590 RVA: 0x006E77F8 File Offset: 0x006E59F8
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

		// Token: 0x060332B7 RID: 209591 RVA: 0x006E7834 File Offset: 0x006E5A34
		public TTable? MoveTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060332B8 RID: 209592 RVA: 0x006E7878 File Offset: 0x006E5A78
		public IAssistCharacterSplineMoveTarget MoveTargetAsIAssistCharacterSplineMoveTarget()
		{
			return this.MoveTarget<IAssistCharacterSplineMoveTarget>().Value;
		}

		// Token: 0x060332B9 RID: 209593 RVA: 0x006E7894 File Offset: 0x006E5A94
		public IEntitySplineMoveTarget MoveTargetAsIEntitySplineMoveTarget()
		{
			return this.MoveTarget<IEntitySplineMoveTarget>().Value;
		}

		// Token: 0x060332BA RID: 209594 RVA: 0x006E78B0 File Offset: 0x006E5AB0
		public IPlayerSplineMoveTarget MoveTargetAsIPlayerSplineMoveTarget()
		{
			return this.MoveTarget<IPlayerSplineMoveTarget>().Value;
		}

		// Token: 0x1700D734 RID: 55092
		// (get) Token: 0x060332BB RID: 209595 RVA: 0x006E78CC File Offset: 0x006E5ACC
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

		// Token: 0x1700D735 RID: 55093
		// (get) Token: 0x060332BC RID: 209596 RVA: 0x006E7908 File Offset: 0x006E5B08
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

		// Token: 0x1700D736 RID: 55094
		// (get) Token: 0x060332BD RID: 209597 RVA: 0x006E7968 File Offset: 0x006E5B68
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

		// Token: 0x1700D737 RID: 55095
		// (get) Token: 0x060332BE RID: 209598 RVA: 0x006E79C8 File Offset: 0x006E5BC8
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

		// Token: 0x1700D738 RID: 55096
		// (get) Token: 0x060332BF RID: 209599 RVA: 0x006E7A08 File Offset: 0x006E5C08
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

		// Token: 0x1700D739 RID: 55097
		// (get) Token: 0x060332C0 RID: 209600 RVA: 0x006E7A48 File Offset: 0x006E5C48
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

		// Token: 0x1700D73A RID: 55098
		// (get) Token: 0x060332C1 RID: 209601 RVA: 0x006E7A88 File Offset: 0x006E5C88
		public bool IsFollowStrictly
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D73B RID: 55099
		// (get) Token: 0x060332C2 RID: 209602 RVA: 0x006E7AC8 File Offset: 0x006E5CC8
		public bool IsForceToFirstPoint
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D73C RID: 55100
		// (get) Token: 0x060332C3 RID: 209603 RVA: 0x006E7B08 File Offset: 0x006E5D08
		public bool IsLookDir
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D73D RID: 55101
		// (get) Token: 0x060332C4 RID: 209604 RVA: 0x006E7B48 File Offset: 0x006E5D48
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

		// Token: 0x1700D73E RID: 55102
		// (get) Token: 0x060332C5 RID: 209605 RVA: 0x006E7BA8 File Offset: 0x006E5DA8
		public bool NpcCollisionEnabled
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D73F RID: 55103
		// (get) Token: 0x060332C6 RID: 209606 RVA: 0x006E7BE8 File Offset: 0x006E5DE8
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

		// Token: 0x060332C7 RID: 209607 RVA: 0x006E7C28 File Offset: 0x006E5E28
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

		// Token: 0x060332C8 RID: 209608 RVA: 0x006E7CB0 File Offset: 0x006E5EB0
		public static void StartIMoveWithSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(14);
		}

		// Token: 0x060332C9 RID: 209609 RVA: 0x006E7CBA File Offset: 0x006E5EBA
		public static void AddMoveTargetType(FlatBufferBuilder builder, TSplineMoveTarget moveTargetType)
		{
			builder.AddByte(0, (byte)moveTargetType, 0);
		}

		// Token: 0x060332CA RID: 209610 RVA: 0x006E7CC5 File Offset: 0x006E5EC5
		public static void AddMoveTarget(FlatBufferBuilder builder, int moveTargetOffset)
		{
			builder.AddOffset(1, moveTargetOffset, 0);
		}

		// Token: 0x060332CB RID: 209611 RVA: 0x006E7CD0 File Offset: 0x006E5ED0
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(2, splineEntityId, 0);
		}

		// Token: 0x060332CC RID: 209612 RVA: 0x006E7CDB File Offset: 0x006E5EDB
		public static void AddCheckClimb(FlatBufferBuilder builder, Offset<ICheckClimb> checkClimbOffset)
		{
			builder.AddOffset(3, checkClimbOffset.Value, 0);
		}

		// Token: 0x060332CD RID: 209613 RVA: 0x006E7CEB File Offset: 0x006E5EEB
		public static void AddMoveOnWallConfig(FlatBufferBuilder builder, Offset<IMoveOnWallConfig> moveOnWallConfigOffset)
		{
			builder.AddOffset(4, moveOnWallConfigOffset.Value, 0);
		}

		// Token: 0x060332CE RID: 209614 RVA: 0x006E7CFB File Offset: 0x006E5EFB
		public static void AddMoveState(FlatBufferBuilder builder, EMoveSpeed moveState)
		{
			builder.AddByte(5, (byte)moveState, 0);
		}

		// Token: 0x060332CF RID: 209615 RVA: 0x006E7D06 File Offset: 0x006E5F06
		public static void AddStartPointIndex(FlatBufferBuilder builder, int startPointIndex)
		{
			builder.AddInt(6, startPointIndex, 0);
		}

		// Token: 0x060332D0 RID: 209616 RVA: 0x006E7D11 File Offset: 0x006E5F11
		public static void AddEndPointIndex(FlatBufferBuilder builder, int endPointIndex)
		{
			builder.AddInt(7, endPointIndex, 0);
		}

		// Token: 0x060332D1 RID: 209617 RVA: 0x006E7D1C File Offset: 0x006E5F1C
		public static void AddIsFollowStrictly(FlatBufferBuilder builder, bool isFollowStrictly)
		{
			builder.AddBool(8, isFollowStrictly, false);
		}

		// Token: 0x060332D2 RID: 209618 RVA: 0x006E7D27 File Offset: 0x006E5F27
		public static void AddIsForceToFirstPoint(FlatBufferBuilder builder, bool isForceToFirstPoint)
		{
			builder.AddBool(9, isForceToFirstPoint, false);
		}

		// Token: 0x060332D3 RID: 209619 RVA: 0x006E7D33 File Offset: 0x006E5F33
		public static void AddIsLookDir(FlatBufferBuilder builder, bool isLookDir)
		{
			builder.AddBool(10, isLookDir, false);
		}

		// Token: 0x060332D4 RID: 209620 RVA: 0x006E7D3F File Offset: 0x006E5F3F
		public static void AddNpcFollow(FlatBufferBuilder builder, Offset<INpcFollowConfig> npcFollowOffset)
		{
			builder.AddOffset(11, npcFollowOffset.Value, 0);
		}

		// Token: 0x060332D5 RID: 209621 RVA: 0x006E7D50 File Offset: 0x006E5F50
		public static void AddNpcCollisionEnabled(FlatBufferBuilder builder, bool npcCollisionEnabled)
		{
			builder.AddBool(12, npcCollisionEnabled, false);
		}

		// Token: 0x060332D6 RID: 209622 RVA: 0x006E7D5C File Offset: 0x006E5F5C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(13, nullMask, 0);
		}

		// Token: 0x060332D7 RID: 209623 RVA: 0x006E7D68 File Offset: 0x006E5F68
		public static Offset<IMoveWithSpline> EndIMoveWithSpline(FlatBufferBuilder builder)
		{
			return new Offset<IMoveWithSpline>(builder.EndTable());
		}

		// Token: 0x060332D8 RID: 209624 RVA: 0x006E7D78 File Offset: 0x006E5F78
		public IMoveWithSplineT UnPack()
		{
			IMoveWithSplineT moveWithSplineT = new IMoveWithSplineT();
			this.UnPackTo(moveWithSplineT);
			return moveWithSplineT;
		}

		// Token: 0x060332D9 RID: 209625 RVA: 0x006E7D94 File Offset: 0x006E5F94
		public void UnPackTo(IMoveWithSplineT _o)
		{
			_o.MoveTarget = new TSplineMoveTargetUnion();
			_o.MoveTarget.Type = this.MoveTargetType;
			switch (this.MoveTargetType)
			{
			case TSplineMoveTarget.IAssistCharacterSplineMoveTarget:
				_o.MoveTarget.Value = ((this.MoveTarget<IAssistCharacterSplineMoveTarget>() != null) ? this.MoveTarget<IAssistCharacterSplineMoveTarget>().Value.UnPack() : null);
				break;
			case TSplineMoveTarget.IEntitySplineMoveTarget:
				_o.MoveTarget.Value = ((this.MoveTarget<IEntitySplineMoveTarget>() != null) ? this.MoveTarget<IEntitySplineMoveTarget>().Value.UnPack() : null);
				break;
			case TSplineMoveTarget.IPlayerSplineMoveTarget:
				_o.MoveTarget.Value = ((this.MoveTarget<IPlayerSplineMoveTarget>() != null) ? this.MoveTarget<IPlayerSplineMoveTarget>().Value.UnPack() : null);
				break;
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

		// Token: 0x060332DA RID: 209626 RVA: 0x006E7F84 File Offset: 0x006E6184
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

		// Token: 0x04012340 RID: 74560
		private Table __p;
	}
}
