using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D1A RID: 23834
	public struct IPatrolSplinePoint : IFlatbufferObject
	{
		// Token: 0x1700AF1D RID: 44829
		// (get) Token: 0x0602797C RID: 162172 RVA: 0x0056A9A6 File Offset: 0x00568BA6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602797D RID: 162173 RVA: 0x0056A9B3 File Offset: 0x00568BB3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602797E RID: 162174 RVA: 0x0056A9BC File Offset: 0x00568BBC
		public static IPatrolSplinePoint GetRootAsIPatrolSplinePoint(ByteBuffer _bb)
		{
			return IPatrolSplinePoint.GetRootAsIPatrolSplinePoint(_bb, default(IPatrolSplinePoint));
		}

		// Token: 0x0602797F RID: 162175 RVA: 0x0056A9D8 File Offset: 0x00568BD8
		public static IPatrolSplinePoint GetRootAsIPatrolSplinePoint(ByteBuffer _bb, IPatrolSplinePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027980 RID: 162176 RVA: 0x0056A9F5 File Offset: 0x00568BF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027981 RID: 162177 RVA: 0x0056AA04 File Offset: 0x00568C04
		public IPatrolSplinePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF1E RID: 44830
		// (get) Token: 0x06027982 RID: 162178 RVA: 0x0056AA14 File Offset: 0x00568C14
		public IVectorInfo? Position
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AF1F RID: 44831
		// (get) Token: 0x06027983 RID: 162179 RVA: 0x0056AA74 File Offset: 0x00568C74
		public IVectorInfo? ArriveTangent
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

		// Token: 0x1700AF20 RID: 44832
		// (get) Token: 0x06027984 RID: 162180 RVA: 0x0056AAD4 File Offset: 0x00568CD4
		public IVectorInfo? LeaveTangent
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AF21 RID: 44833
		// (get) Token: 0x06027985 RID: 162181 RVA: 0x0056AB34 File Offset: 0x00568D34
		public ESplineLine LineType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ESplineLine.Linear;
				}
				return (ESplineLine)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AF22 RID: 44834
		// (get) Token: 0x06027986 RID: 162182 RVA: 0x0056AB74 File Offset: 0x00568D74
		public IVectorInfo? Rotation
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AF23 RID: 44835
		// (get) Token: 0x06027987 RID: 162183 RVA: 0x0056ABD4 File Offset: 0x00568DD4
		public EPatrolMoveState MoveState
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return EPatrolMoveState.None;
				}
				return (EPatrolMoveState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AF24 RID: 44836
		// (get) Token: 0x06027988 RID: 162184 RVA: 0x0056AC14 File Offset: 0x00568E14
		public ECharPositionStateType CharPositionState
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return ECharPositionStateType.Ground;
				}
				return (ECharPositionStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AF25 RID: 44837
		// (get) Token: 0x06027989 RID: 162185 RVA: 0x0056AC54 File Offset: 0x00568E54
		public int MoveSpeed
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

		// Token: 0x1700AF26 RID: 44838
		// (get) Token: 0x0602798A RID: 162186 RVA: 0x0056AC94 File Offset: 0x00568E94
		public int TurnSpeed
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AF27 RID: 44839
		// (get) Token: 0x0602798B RID: 162187 RVA: 0x0056ACD4 File Offset: 0x00568ED4
		public bool IgnorePoint
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AF28 RID: 44840
		// (get) Token: 0x0602798C RID: 162188 RVA: 0x0056AD14 File Offset: 0x00568F14
		public int StayTime
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AF29 RID: 44841
		// (get) Token: 0x0602798D RID: 162189 RVA: 0x0056AD54 File Offset: 0x00568F54
		public bool IsHide
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602798E RID: 162190 RVA: 0x0056AD94 File Offset: 0x00568F94
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AF2A RID: 44842
		// (get) Token: 0x0602798F RID: 162191 RVA: 0x0056ADF8 File Offset: 0x00568FF8
		public int ActionsLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700AF2B RID: 44843
		// (get) Token: 0x06027990 RID: 162192 RVA: 0x0056AE24 File Offset: 0x00569024
		public bool IsEnableIk
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AF2C RID: 44844
		// (get) Token: 0x06027991 RID: 162193 RVA: 0x0056AE64 File Offset: 0x00569064
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027992 RID: 162194 RVA: 0x0056AEA4 File Offset: 0x005690A4
		public static Offset<IPatrolSplinePoint> CreateIPatrolSplinePoint(FlatBufferBuilder builder, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArriveTangentOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> LeaveTangentOffset = default(Offset<IVectorInfo>), ESplineLine LineType = ESplineLine.Linear, Offset<IVectorInfo> RotationOffset = default(Offset<IVectorInfo>), EPatrolMoveState MoveState = EPatrolMoveState.None, ECharPositionStateType CharPositionState = ECharPositionStateType.Ground, int MoveSpeed = 0, int TurnSpeed = 0, bool IgnorePoint = false, int StayTime = 0, bool IsHide = false, VectorOffset ActionsOffset = default(VectorOffset), bool IsEnableIk = false, byte NullMask = 0)
		{
			builder.StartTable(15);
			IPatrolSplinePoint.AddActions(builder, ActionsOffset);
			IPatrolSplinePoint.AddStayTime(builder, StayTime);
			IPatrolSplinePoint.AddTurnSpeed(builder, TurnSpeed);
			IPatrolSplinePoint.AddMoveSpeed(builder, MoveSpeed);
			IPatrolSplinePoint.AddRotation(builder, RotationOffset);
			IPatrolSplinePoint.AddLeaveTangent(builder, LeaveTangentOffset);
			IPatrolSplinePoint.AddArriveTangent(builder, ArriveTangentOffset);
			IPatrolSplinePoint.AddPosition(builder, PositionOffset);
			IPatrolSplinePoint.AddNullMask(builder, NullMask);
			IPatrolSplinePoint.AddIsEnableIk(builder, IsEnableIk);
			IPatrolSplinePoint.AddIsHide(builder, IsHide);
			IPatrolSplinePoint.AddIgnorePoint(builder, IgnorePoint);
			IPatrolSplinePoint.AddCharPositionState(builder, CharPositionState);
			IPatrolSplinePoint.AddMoveState(builder, MoveState);
			IPatrolSplinePoint.AddLineType(builder, LineType);
			return IPatrolSplinePoint.EndIPatrolSplinePoint(builder);
		}

		// Token: 0x06027993 RID: 162195 RVA: 0x0056AF34 File Offset: 0x00569134
		public static void StartIPatrolSplinePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(15);
		}

		// Token: 0x06027994 RID: 162196 RVA: 0x0056AF3E File Offset: 0x0056913E
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x06027995 RID: 162197 RVA: 0x0056AF4E File Offset: 0x0056914E
		public static void AddArriveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> arriveTangentOffset)
		{
			builder.AddOffset(1, arriveTangentOffset.Value, 0);
		}

		// Token: 0x06027996 RID: 162198 RVA: 0x0056AF5E File Offset: 0x0056915E
		public static void AddLeaveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> leaveTangentOffset)
		{
			builder.AddOffset(2, leaveTangentOffset.Value, 0);
		}

		// Token: 0x06027997 RID: 162199 RVA: 0x0056AF6E File Offset: 0x0056916E
		public static void AddLineType(FlatBufferBuilder builder, ESplineLine lineType)
		{
			builder.AddByte(3, (byte)lineType, 0);
		}

		// Token: 0x06027998 RID: 162200 RVA: 0x0056AF79 File Offset: 0x00569179
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(4, rotationOffset.Value, 0);
		}

		// Token: 0x06027999 RID: 162201 RVA: 0x0056AF89 File Offset: 0x00569189
		public static void AddMoveState(FlatBufferBuilder builder, EPatrolMoveState moveState)
		{
			builder.AddByte(5, (byte)moveState, 0);
		}

		// Token: 0x0602799A RID: 162202 RVA: 0x0056AF94 File Offset: 0x00569194
		public static void AddCharPositionState(FlatBufferBuilder builder, ECharPositionStateType charPositionState)
		{
			builder.AddByte(6, (byte)charPositionState, 0);
		}

		// Token: 0x0602799B RID: 162203 RVA: 0x0056AF9F File Offset: 0x0056919F
		public static void AddMoveSpeed(FlatBufferBuilder builder, int moveSpeed)
		{
			builder.AddInt(7, moveSpeed, 0);
		}

		// Token: 0x0602799C RID: 162204 RVA: 0x0056AFAA File Offset: 0x005691AA
		public static void AddTurnSpeed(FlatBufferBuilder builder, int turnSpeed)
		{
			builder.AddInt(8, turnSpeed, 0);
		}

		// Token: 0x0602799D RID: 162205 RVA: 0x0056AFB5 File Offset: 0x005691B5
		public static void AddIgnorePoint(FlatBufferBuilder builder, bool ignorePoint)
		{
			builder.AddBool(9, ignorePoint, false);
		}

		// Token: 0x0602799E RID: 162206 RVA: 0x0056AFC1 File Offset: 0x005691C1
		public static void AddStayTime(FlatBufferBuilder builder, int stayTime)
		{
			builder.AddInt(10, stayTime, 0);
		}

		// Token: 0x0602799F RID: 162207 RVA: 0x0056AFCD File Offset: 0x005691CD
		public static void AddIsHide(FlatBufferBuilder builder, bool isHide)
		{
			builder.AddBool(11, isHide, false);
		}

		// Token: 0x060279A0 RID: 162208 RVA: 0x0056AFD9 File Offset: 0x005691D9
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(12, actionsOffset.Value, 0);
		}

		// Token: 0x060279A1 RID: 162209 RVA: 0x0056AFEC File Offset: 0x005691EC
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060279A2 RID: 162210 RVA: 0x0056B02C File Offset: 0x0056922C
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060279A3 RID: 162211 RVA: 0x0056B046 File Offset: 0x00569246
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060279A4 RID: 162212 RVA: 0x0056B064 File Offset: 0x00569264
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060279A5 RID: 162213 RVA: 0x0056B07D File Offset: 0x0056927D
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060279A6 RID: 162214 RVA: 0x0056B088 File Offset: 0x00569288
		public static void AddIsEnableIk(FlatBufferBuilder builder, bool isEnableIk)
		{
			builder.AddBool(13, isEnableIk, false);
		}

		// Token: 0x060279A7 RID: 162215 RVA: 0x0056B094 File Offset: 0x00569294
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(14, nullMask, 0);
		}

		// Token: 0x060279A8 RID: 162216 RVA: 0x0056B0A0 File Offset: 0x005692A0
		public static Offset<IPatrolSplinePoint> EndIPatrolSplinePoint(FlatBufferBuilder builder)
		{
			return new Offset<IPatrolSplinePoint>(builder.EndTable());
		}

		// Token: 0x060279A9 RID: 162217 RVA: 0x0056B0B0 File Offset: 0x005692B0
		public IPatrolSplinePointT UnPack()
		{
			IPatrolSplinePointT patrolSplinePointT = new IPatrolSplinePointT();
			this.UnPackTo(patrolSplinePointT);
			return patrolSplinePointT;
		}

		// Token: 0x060279AA RID: 162218 RVA: 0x0056B0CC File Offset: 0x005692CC
		public void UnPackTo(IPatrolSplinePointT _o)
		{
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.ArriveTangent = ((this.ArriveTangent != null) ? this.ArriveTangent.Value.UnPack() : null);
			_o.LeaveTangent = ((this.LeaveTangent != null) ? this.LeaveTangent.Value.UnPack() : null);
			_o.LineType = this.LineType;
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
			_o.MoveState = this.MoveState;
			_o.CharPositionState = this.CharPositionState;
			_o.MoveSpeed = this.MoveSpeed;
			_o.TurnSpeed = this.TurnSpeed;
			_o.IgnorePoint = this.IgnorePoint;
			_o.StayTime = this.StayTime;
			_o.IsHide = this.IsHide;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.IsEnableIk = this.IsEnableIk;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060279AB RID: 162219 RVA: 0x0056B260 File Offset: 0x00569460
		public static Offset<IPatrolSplinePoint> Pack(FlatBufferBuilder builder, IPatrolSplinePointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPatrolSplinePoint>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			Offset<IVectorInfo> arriveTangentOffset = (_o.ArriveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ArriveTangent);
			Offset<IVectorInfo> leaveTangentOffset = (_o.LeaveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.LeaveTangent);
			Offset<IVectorInfo> rotationOffset = (_o.Rotation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotation);
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IPatrolSplinePoint.CreateActionsVector(builder, array);
			}
			return IPatrolSplinePoint.CreateIPatrolSplinePoint(builder, positionOffset, arriveTangentOffset, leaveTangentOffset, _o.LineType, rotationOffset, _o.MoveState, _o.CharPositionState, _o.MoveSpeed, _o.TurnSpeed, _o.IgnorePoint, _o.StayTime, _o.IsHide, actionsOffset, _o.IsEnableIk, _o.NullMask);
		}

		// Token: 0x0400F860 RID: 63584
		private Table __p;
	}
}
