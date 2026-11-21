using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A5F RID: 23135
	public struct ILevelAISplinePoint : IFlatbufferObject
	{
		// Token: 0x1700A84D RID: 43085
		// (get) Token: 0x06025D8E RID: 155022 RVA: 0x0052FFF7 File Offset: 0x0052E1F7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025D8F RID: 155023 RVA: 0x00530004 File Offset: 0x0052E204
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025D90 RID: 155024 RVA: 0x0053000C File Offset: 0x0052E20C
		public static ILevelAISplinePoint GetRootAsILevelAISplinePoint(ByteBuffer _bb)
		{
			return ILevelAISplinePoint.GetRootAsILevelAISplinePoint(_bb, default(ILevelAISplinePoint));
		}

		// Token: 0x06025D91 RID: 155025 RVA: 0x00530028 File Offset: 0x0052E228
		public static ILevelAISplinePoint GetRootAsILevelAISplinePoint(ByteBuffer _bb, ILevelAISplinePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025D92 RID: 155026 RVA: 0x00530045 File Offset: 0x0052E245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025D93 RID: 155027 RVA: 0x00530054 File Offset: 0x0052E254
		public ILevelAISplinePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A84E RID: 43086
		// (get) Token: 0x06025D94 RID: 155028 RVA: 0x00530064 File Offset: 0x0052E264
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

		// Token: 0x1700A84F RID: 43087
		// (get) Token: 0x06025D95 RID: 155029 RVA: 0x005300C4 File Offset: 0x0052E2C4
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

		// Token: 0x1700A850 RID: 43088
		// (get) Token: 0x06025D96 RID: 155030 RVA: 0x00530124 File Offset: 0x0052E324
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

		// Token: 0x1700A851 RID: 43089
		// (get) Token: 0x06025D97 RID: 155031 RVA: 0x00530184 File Offset: 0x0052E384
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

		// Token: 0x1700A852 RID: 43090
		// (get) Token: 0x06025D98 RID: 155032 RVA: 0x005301C4 File Offset: 0x0052E3C4
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

		// Token: 0x1700A853 RID: 43091
		// (get) Token: 0x06025D99 RID: 155033 RVA: 0x00530224 File Offset: 0x0052E424
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

		// Token: 0x1700A854 RID: 43092
		// (get) Token: 0x06025D9A RID: 155034 RVA: 0x00530264 File Offset: 0x0052E464
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

		// Token: 0x1700A855 RID: 43093
		// (get) Token: 0x06025D9B RID: 155035 RVA: 0x005302A4 File Offset: 0x0052E4A4
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

		// Token: 0x06025D9C RID: 155036 RVA: 0x005302E4 File Offset: 0x0052E4E4
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A856 RID: 43094
		// (get) Token: 0x06025D9D RID: 155037 RVA: 0x00530348 File Offset: 0x0052E548
		public int ActionsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A857 RID: 43095
		// (get) Token: 0x06025D9E RID: 155038 RVA: 0x00530374 File Offset: 0x0052E574
		public bool IsEnableIk
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A858 RID: 43096
		// (get) Token: 0x06025D9F RID: 155039 RVA: 0x005303B4 File Offset: 0x0052E5B4
		public ILevelAiPointOffsetConfig? PointOffsetConfig
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new ILevelAiPointOffsetConfig?(default(ILevelAiPointOffsetConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A859 RID: 43097
		// (get) Token: 0x06025DA0 RID: 155040 RVA: 0x00530414 File Offset: 0x0052E614
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025DA1 RID: 155041 RVA: 0x00530454 File Offset: 0x0052E654
		public static Offset<ILevelAISplinePoint> CreateILevelAISplinePoint(FlatBufferBuilder builder, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArriveTangentOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> LeaveTangentOffset = default(Offset<IVectorInfo>), ESplineLine LineType = ESplineLine.Linear, Offset<IVectorInfo> RotationOffset = default(Offset<IVectorInfo>), EPatrolMoveState MoveState = EPatrolMoveState.None, ECharPositionStateType CharPositionState = ECharPositionStateType.Ground, int MoveSpeed = 0, VectorOffset ActionsOffset = default(VectorOffset), bool IsEnableIk = false, Offset<ILevelAiPointOffsetConfig> PointOffsetConfigOffset = default(Offset<ILevelAiPointOffsetConfig>), byte NullMask = 0)
		{
			builder.StartTable(12);
			ILevelAISplinePoint.AddPointOffsetConfig(builder, PointOffsetConfigOffset);
			ILevelAISplinePoint.AddActions(builder, ActionsOffset);
			ILevelAISplinePoint.AddMoveSpeed(builder, MoveSpeed);
			ILevelAISplinePoint.AddRotation(builder, RotationOffset);
			ILevelAISplinePoint.AddLeaveTangent(builder, LeaveTangentOffset);
			ILevelAISplinePoint.AddArriveTangent(builder, ArriveTangentOffset);
			ILevelAISplinePoint.AddPosition(builder, PositionOffset);
			ILevelAISplinePoint.AddNullMask(builder, NullMask);
			ILevelAISplinePoint.AddIsEnableIk(builder, IsEnableIk);
			ILevelAISplinePoint.AddCharPositionState(builder, CharPositionState);
			ILevelAISplinePoint.AddMoveState(builder, MoveState);
			ILevelAISplinePoint.AddLineType(builder, LineType);
			return ILevelAISplinePoint.EndILevelAISplinePoint(builder);
		}

		// Token: 0x06025DA2 RID: 155042 RVA: 0x005304CC File Offset: 0x0052E6CC
		public static void StartILevelAISplinePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x06025DA3 RID: 155043 RVA: 0x005304D6 File Offset: 0x0052E6D6
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x06025DA4 RID: 155044 RVA: 0x005304E6 File Offset: 0x0052E6E6
		public static void AddArriveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> arriveTangentOffset)
		{
			builder.AddOffset(1, arriveTangentOffset.Value, 0);
		}

		// Token: 0x06025DA5 RID: 155045 RVA: 0x005304F6 File Offset: 0x0052E6F6
		public static void AddLeaveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> leaveTangentOffset)
		{
			builder.AddOffset(2, leaveTangentOffset.Value, 0);
		}

		// Token: 0x06025DA6 RID: 155046 RVA: 0x00530506 File Offset: 0x0052E706
		public static void AddLineType(FlatBufferBuilder builder, ESplineLine lineType)
		{
			builder.AddByte(3, (byte)lineType, 0);
		}

		// Token: 0x06025DA7 RID: 155047 RVA: 0x00530511 File Offset: 0x0052E711
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(4, rotationOffset.Value, 0);
		}

		// Token: 0x06025DA8 RID: 155048 RVA: 0x00530521 File Offset: 0x0052E721
		public static void AddMoveState(FlatBufferBuilder builder, EPatrolMoveState moveState)
		{
			builder.AddByte(5, (byte)moveState, 0);
		}

		// Token: 0x06025DA9 RID: 155049 RVA: 0x0053052C File Offset: 0x0052E72C
		public static void AddCharPositionState(FlatBufferBuilder builder, ECharPositionStateType charPositionState)
		{
			builder.AddByte(6, (byte)charPositionState, 0);
		}

		// Token: 0x06025DAA RID: 155050 RVA: 0x00530537 File Offset: 0x0052E737
		public static void AddMoveSpeed(FlatBufferBuilder builder, int moveSpeed)
		{
			builder.AddInt(7, moveSpeed, 0);
		}

		// Token: 0x06025DAB RID: 155051 RVA: 0x00530542 File Offset: 0x0052E742
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(8, actionsOffset.Value, 0);
		}

		// Token: 0x06025DAC RID: 155052 RVA: 0x00530554 File Offset: 0x0052E754
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025DAD RID: 155053 RVA: 0x00530594 File Offset: 0x0052E794
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025DAE RID: 155054 RVA: 0x005305AE File Offset: 0x0052E7AE
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025DAF RID: 155055 RVA: 0x005305CC File Offset: 0x0052E7CC
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025DB0 RID: 155056 RVA: 0x005305E5 File Offset: 0x0052E7E5
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025DB1 RID: 155057 RVA: 0x005305F0 File Offset: 0x0052E7F0
		public static void AddIsEnableIk(FlatBufferBuilder builder, bool isEnableIk)
		{
			builder.AddBool(9, isEnableIk, false);
		}

		// Token: 0x06025DB2 RID: 155058 RVA: 0x005305FC File Offset: 0x0052E7FC
		public static void AddPointOffsetConfig(FlatBufferBuilder builder, Offset<ILevelAiPointOffsetConfig> pointOffsetConfigOffset)
		{
			builder.AddOffset(10, pointOffsetConfigOffset.Value, 0);
		}

		// Token: 0x06025DB3 RID: 155059 RVA: 0x0053060D File Offset: 0x0052E80D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(11, nullMask, 0);
		}

		// Token: 0x06025DB4 RID: 155060 RVA: 0x00530619 File Offset: 0x0052E819
		public static Offset<ILevelAISplinePoint> EndILevelAISplinePoint(FlatBufferBuilder builder)
		{
			return new Offset<ILevelAISplinePoint>(builder.EndTable());
		}

		// Token: 0x06025DB5 RID: 155061 RVA: 0x00530628 File Offset: 0x0052E828
		public ILevelAISplinePointT UnPack()
		{
			ILevelAISplinePointT levelAISplinePointT = new ILevelAISplinePointT();
			this.UnPackTo(levelAISplinePointT);
			return levelAISplinePointT;
		}

		// Token: 0x06025DB6 RID: 155062 RVA: 0x00530644 File Offset: 0x0052E844
		public void UnPackTo(ILevelAISplinePointT _o)
		{
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.ArriveTangent = ((this.ArriveTangent != null) ? this.ArriveTangent.Value.UnPack() : null);
			_o.LeaveTangent = ((this.LeaveTangent != null) ? this.LeaveTangent.Value.UnPack() : null);
			_o.LineType = this.LineType;
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
			_o.MoveState = this.MoveState;
			_o.CharPositionState = this.CharPositionState;
			_o.MoveSpeed = this.MoveSpeed;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.IsEnableIk = this.IsEnableIk;
			_o.PointOffsetConfig = ((this.PointOffsetConfig != null) ? this.PointOffsetConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025DB7 RID: 155063 RVA: 0x005307DC File Offset: 0x0052E9DC
		public static Offset<ILevelAISplinePoint> Pack(FlatBufferBuilder builder, ILevelAISplinePointT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelAISplinePoint>);
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
				actionsOffset = ILevelAISplinePoint.CreateActionsVector(builder, array);
			}
			Offset<ILevelAiPointOffsetConfig> pointOffsetConfigOffset = (_o.PointOffsetConfig == null) ? default(Offset<ILevelAiPointOffsetConfig>) : ILevelAiPointOffsetConfig.Pack(builder, _o.PointOffsetConfig);
			return ILevelAISplinePoint.CreateILevelAISplinePoint(builder, positionOffset, arriveTangentOffset, leaveTangentOffset, _o.LineType, rotationOffset, _o.MoveState, _o.CharPositionState, _o.MoveSpeed, actionsOffset, _o.IsEnableIk, pointOffsetConfigOffset, _o.NullMask);
		}

		// Token: 0x0400F3CF RID: 62415
		private Table __p;
	}
}
