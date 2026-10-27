using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054D9 RID: 21721
	public struct ILevelAISplinePoint : IFlatbufferObject
	{
		// Token: 0x1700A013 RID: 40979
		// (get) Token: 0x06023CD6 RID: 146646 RVA: 0x004F2F83 File Offset: 0x004F1183
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023CD7 RID: 146647 RVA: 0x004F2F90 File Offset: 0x004F1190
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023CD8 RID: 146648 RVA: 0x004F2F98 File Offset: 0x004F1198
		public static ILevelAISplinePoint GetRootAsILevelAISplinePoint(ByteBuffer _bb)
		{
			return ILevelAISplinePoint.GetRootAsILevelAISplinePoint(_bb, default(ILevelAISplinePoint));
		}

		// Token: 0x06023CD9 RID: 146649 RVA: 0x004F2FB4 File Offset: 0x004F11B4
		public static ILevelAISplinePoint GetRootAsILevelAISplinePoint(ByteBuffer _bb, ILevelAISplinePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023CDA RID: 146650 RVA: 0x004F2FD1 File Offset: 0x004F11D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023CDB RID: 146651 RVA: 0x004F2FE0 File Offset: 0x004F11E0
		public ILevelAISplinePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A014 RID: 40980
		// (get) Token: 0x06023CDC RID: 146652 RVA: 0x004F2FF0 File Offset: 0x004F11F0
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

		// Token: 0x1700A015 RID: 40981
		// (get) Token: 0x06023CDD RID: 146653 RVA: 0x004F3050 File Offset: 0x004F1250
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

		// Token: 0x1700A016 RID: 40982
		// (get) Token: 0x06023CDE RID: 146654 RVA: 0x004F30B0 File Offset: 0x004F12B0
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

		// Token: 0x1700A017 RID: 40983
		// (get) Token: 0x06023CDF RID: 146655 RVA: 0x004F3110 File Offset: 0x004F1310
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

		// Token: 0x1700A018 RID: 40984
		// (get) Token: 0x06023CE0 RID: 146656 RVA: 0x004F3150 File Offset: 0x004F1350
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

		// Token: 0x1700A019 RID: 40985
		// (get) Token: 0x06023CE1 RID: 146657 RVA: 0x004F31B0 File Offset: 0x004F13B0
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

		// Token: 0x1700A01A RID: 40986
		// (get) Token: 0x06023CE2 RID: 146658 RVA: 0x004F31F0 File Offset: 0x004F13F0
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

		// Token: 0x1700A01B RID: 40987
		// (get) Token: 0x06023CE3 RID: 146659 RVA: 0x004F3230 File Offset: 0x004F1430
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

		// Token: 0x06023CE4 RID: 146660 RVA: 0x004F3270 File Offset: 0x004F1470
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A01C RID: 40988
		// (get) Token: 0x06023CE5 RID: 146661 RVA: 0x004F32D4 File Offset: 0x004F14D4
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

		// Token: 0x1700A01D RID: 40989
		// (get) Token: 0x06023CE6 RID: 146662 RVA: 0x004F3300 File Offset: 0x004F1500
		public bool IsEnableIk
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A01E RID: 40990
		// (get) Token: 0x06023CE7 RID: 146663 RVA: 0x004F3340 File Offset: 0x004F1540
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

		// Token: 0x1700A01F RID: 40991
		// (get) Token: 0x06023CE8 RID: 146664 RVA: 0x004F33A0 File Offset: 0x004F15A0
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

		// Token: 0x06023CE9 RID: 146665 RVA: 0x004F33E0 File Offset: 0x004F15E0
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

		// Token: 0x06023CEA RID: 146666 RVA: 0x004F3458 File Offset: 0x004F1658
		public static void StartILevelAISplinePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x06023CEB RID: 146667 RVA: 0x004F3462 File Offset: 0x004F1662
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x06023CEC RID: 146668 RVA: 0x004F3472 File Offset: 0x004F1672
		public static void AddArriveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> arriveTangentOffset)
		{
			builder.AddOffset(1, arriveTangentOffset.Value, 0);
		}

		// Token: 0x06023CED RID: 146669 RVA: 0x004F3482 File Offset: 0x004F1682
		public static void AddLeaveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> leaveTangentOffset)
		{
			builder.AddOffset(2, leaveTangentOffset.Value, 0);
		}

		// Token: 0x06023CEE RID: 146670 RVA: 0x004F3492 File Offset: 0x004F1692
		public static void AddLineType(FlatBufferBuilder builder, ESplineLine lineType)
		{
			builder.AddByte(3, (byte)lineType, 0);
		}

		// Token: 0x06023CEF RID: 146671 RVA: 0x004F349D File Offset: 0x004F169D
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(4, rotationOffset.Value, 0);
		}

		// Token: 0x06023CF0 RID: 146672 RVA: 0x004F34AD File Offset: 0x004F16AD
		public static void AddMoveState(FlatBufferBuilder builder, EPatrolMoveState moveState)
		{
			builder.AddByte(5, (byte)moveState, 0);
		}

		// Token: 0x06023CF1 RID: 146673 RVA: 0x004F34B8 File Offset: 0x004F16B8
		public static void AddCharPositionState(FlatBufferBuilder builder, ECharPositionStateType charPositionState)
		{
			builder.AddByte(6, (byte)charPositionState, 0);
		}

		// Token: 0x06023CF2 RID: 146674 RVA: 0x004F34C3 File Offset: 0x004F16C3
		public static void AddMoveSpeed(FlatBufferBuilder builder, int moveSpeed)
		{
			builder.AddInt(7, moveSpeed, 0);
		}

		// Token: 0x06023CF3 RID: 146675 RVA: 0x004F34CE File Offset: 0x004F16CE
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(8, actionsOffset.Value, 0);
		}

		// Token: 0x06023CF4 RID: 146676 RVA: 0x004F34E0 File Offset: 0x004F16E0
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023CF5 RID: 146677 RVA: 0x004F3520 File Offset: 0x004F1720
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023CF6 RID: 146678 RVA: 0x004F353A File Offset: 0x004F173A
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023CF7 RID: 146679 RVA: 0x004F3558 File Offset: 0x004F1758
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023CF8 RID: 146680 RVA: 0x004F3571 File Offset: 0x004F1771
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023CF9 RID: 146681 RVA: 0x004F357C File Offset: 0x004F177C
		public static void AddIsEnableIk(FlatBufferBuilder builder, bool isEnableIk)
		{
			builder.AddBool(9, isEnableIk, false);
		}

		// Token: 0x06023CFA RID: 146682 RVA: 0x004F3588 File Offset: 0x004F1788
		public static void AddPointOffsetConfig(FlatBufferBuilder builder, Offset<ILevelAiPointOffsetConfig> pointOffsetConfigOffset)
		{
			builder.AddOffset(10, pointOffsetConfigOffset.Value, 0);
		}

		// Token: 0x06023CFB RID: 146683 RVA: 0x004F3599 File Offset: 0x004F1799
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(11, nullMask, 0);
		}

		// Token: 0x06023CFC RID: 146684 RVA: 0x004F35A5 File Offset: 0x004F17A5
		public static Offset<ILevelAISplinePoint> EndILevelAISplinePoint(FlatBufferBuilder builder)
		{
			return new Offset<ILevelAISplinePoint>(builder.EndTable());
		}

		// Token: 0x06023CFD RID: 146685 RVA: 0x004F35B4 File Offset: 0x004F17B4
		public ILevelAISplinePointT UnPack()
		{
			ILevelAISplinePointT levelAISplinePointT = new ILevelAISplinePointT();
			this.UnPackTo(levelAISplinePointT);
			return levelAISplinePointT;
		}

		// Token: 0x06023CFE RID: 146686 RVA: 0x004F35D0 File Offset: 0x004F17D0
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

		// Token: 0x06023CFF RID: 146687 RVA: 0x004F3768 File Offset: 0x004F1968
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

		// Token: 0x0400E79E RID: 59294
		private Table __p;
	}
}
