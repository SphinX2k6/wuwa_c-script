using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005024 RID: 20516
	public struct IContinuesVariableSpeedSplinePoint : IFlatbufferObject
	{
		// Token: 0x170094D4 RID: 38100
		// (get) Token: 0x06020D97 RID: 134551 RVA: 0x004912F0 File Offset: 0x0048F4F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020D98 RID: 134552 RVA: 0x004912FD File Offset: 0x0048F4FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020D99 RID: 134553 RVA: 0x00491304 File Offset: 0x0048F504
		public static IContinuesVariableSpeedSplinePoint GetRootAsIContinuesVariableSpeedSplinePoint(ByteBuffer _bb)
		{
			return IContinuesVariableSpeedSplinePoint.GetRootAsIContinuesVariableSpeedSplinePoint(_bb, default(IContinuesVariableSpeedSplinePoint));
		}

		// Token: 0x06020D9A RID: 134554 RVA: 0x00491320 File Offset: 0x0048F520
		public static IContinuesVariableSpeedSplinePoint GetRootAsIContinuesVariableSpeedSplinePoint(ByteBuffer _bb, IContinuesVariableSpeedSplinePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020D9B RID: 134555 RVA: 0x0049133D File Offset: 0x0048F53D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020D9C RID: 134556 RVA: 0x0049134C File Offset: 0x0048F54C
		public IContinuesVariableSpeedSplinePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170094D5 RID: 38101
		// (get) Token: 0x06020D9D RID: 134557 RVA: 0x0049135C File Offset: 0x0048F55C
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

		// Token: 0x170094D6 RID: 38102
		// (get) Token: 0x06020D9E RID: 134558 RVA: 0x004913BC File Offset: 0x0048F5BC
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

		// Token: 0x170094D7 RID: 38103
		// (get) Token: 0x06020D9F RID: 134559 RVA: 0x0049141C File Offset: 0x0048F61C
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

		// Token: 0x170094D8 RID: 38104
		// (get) Token: 0x06020DA0 RID: 134560 RVA: 0x0049147C File Offset: 0x0048F67C
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

		// Token: 0x170094D9 RID: 38105
		// (get) Token: 0x06020DA1 RID: 134561 RVA: 0x004914BC File Offset: 0x0048F6BC
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

		// Token: 0x170094DA RID: 38106
		// (get) Token: 0x06020DA2 RID: 134562 RVA: 0x0049151C File Offset: 0x0048F71C
		public ITimePathConfig? IntervalTimePathConfig
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new ITimePathConfig?(default(ITimePathConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06020DA3 RID: 134563 RVA: 0x0049157C File Offset: 0x0048F77C
		public IConditionAction? ConditionActions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IConditionAction?(default(IConditionAction).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170094DB RID: 38107
		// (get) Token: 0x06020DA4 RID: 134564 RVA: 0x004915E0 File Offset: 0x0048F7E0
		public int ConditionActionsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170094DC RID: 38108
		// (get) Token: 0x06020DA5 RID: 134565 RVA: 0x0049160C File Offset: 0x0048F80C
		public float KeepSpeed
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170094DD RID: 38109
		// (get) Token: 0x06020DA6 RID: 134566 RVA: 0x00491650 File Offset: 0x0048F850
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

		// Token: 0x06020DA7 RID: 134567 RVA: 0x00491690 File Offset: 0x0048F890
		public static Offset<IContinuesVariableSpeedSplinePoint> CreateIContinuesVariableSpeedSplinePoint(FlatBufferBuilder builder, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArriveTangentOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> LeaveTangentOffset = default(Offset<IVectorInfo>), ESplineLine LineType = ESplineLine.Linear, Offset<IVectorInfo> RotationOffset = default(Offset<IVectorInfo>), Offset<ITimePathConfig> IntervalTimePathConfigOffset = default(Offset<ITimePathConfig>), VectorOffset ConditionActionsOffset = default(VectorOffset), float KeepSpeed = 0f, byte NullMask = 0)
		{
			builder.StartTable(9);
			IContinuesVariableSpeedSplinePoint.AddKeepSpeed(builder, KeepSpeed);
			IContinuesVariableSpeedSplinePoint.AddConditionActions(builder, ConditionActionsOffset);
			IContinuesVariableSpeedSplinePoint.AddIntervalTimePathConfig(builder, IntervalTimePathConfigOffset);
			IContinuesVariableSpeedSplinePoint.AddRotation(builder, RotationOffset);
			IContinuesVariableSpeedSplinePoint.AddLeaveTangent(builder, LeaveTangentOffset);
			IContinuesVariableSpeedSplinePoint.AddArriveTangent(builder, ArriveTangentOffset);
			IContinuesVariableSpeedSplinePoint.AddPosition(builder, PositionOffset);
			IContinuesVariableSpeedSplinePoint.AddNullMask(builder, NullMask);
			IContinuesVariableSpeedSplinePoint.AddLineType(builder, LineType);
			return IContinuesVariableSpeedSplinePoint.EndIContinuesVariableSpeedSplinePoint(builder);
		}

		// Token: 0x06020DA8 RID: 134568 RVA: 0x004916F0 File Offset: 0x0048F8F0
		public static void StartIContinuesVariableSpeedSplinePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06020DA9 RID: 134569 RVA: 0x004916FA File Offset: 0x0048F8FA
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x06020DAA RID: 134570 RVA: 0x0049170A File Offset: 0x0048F90A
		public static void AddArriveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> arriveTangentOffset)
		{
			builder.AddOffset(1, arriveTangentOffset.Value, 0);
		}

		// Token: 0x06020DAB RID: 134571 RVA: 0x0049171A File Offset: 0x0048F91A
		public static void AddLeaveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> leaveTangentOffset)
		{
			builder.AddOffset(2, leaveTangentOffset.Value, 0);
		}

		// Token: 0x06020DAC RID: 134572 RVA: 0x0049172A File Offset: 0x0048F92A
		public static void AddLineType(FlatBufferBuilder builder, ESplineLine lineType)
		{
			builder.AddByte(3, (byte)lineType, 0);
		}

		// Token: 0x06020DAD RID: 134573 RVA: 0x00491735 File Offset: 0x0048F935
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(4, rotationOffset.Value, 0);
		}

		// Token: 0x06020DAE RID: 134574 RVA: 0x00491745 File Offset: 0x0048F945
		public static void AddIntervalTimePathConfig(FlatBufferBuilder builder, Offset<ITimePathConfig> intervalTimePathConfigOffset)
		{
			builder.AddOffset(5, intervalTimePathConfigOffset.Value, 0);
		}

		// Token: 0x06020DAF RID: 134575 RVA: 0x00491755 File Offset: 0x0048F955
		public static void AddConditionActions(FlatBufferBuilder builder, VectorOffset conditionActionsOffset)
		{
			builder.AddOffset(6, conditionActionsOffset.Value, 0);
		}

		// Token: 0x06020DB0 RID: 134576 RVA: 0x00491768 File Offset: 0x0048F968
		public static VectorOffset CreateConditionActionsVector(FlatBufferBuilder builder, Offset<IConditionAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020DB1 RID: 134577 RVA: 0x004917A8 File Offset: 0x0048F9A8
		public static VectorOffset CreateConditionActionsVectorBlock(FlatBufferBuilder builder, Offset<IConditionAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020DB2 RID: 134578 RVA: 0x004917C2 File Offset: 0x0048F9C2
		public static VectorOffset CreateConditionActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionAction>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020DB3 RID: 134579 RVA: 0x004917E0 File Offset: 0x0048F9E0
		public static VectorOffset CreateConditionActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionAction>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020DB4 RID: 134580 RVA: 0x004917F9 File Offset: 0x0048F9F9
		public static void StartConditionActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020DB5 RID: 134581 RVA: 0x00491804 File Offset: 0x0048FA04
		public static void AddKeepSpeed(FlatBufferBuilder builder, float keepSpeed)
		{
			builder.AddFloat(7, keepSpeed, 0.0);
		}

		// Token: 0x06020DB6 RID: 134582 RVA: 0x00491817 File Offset: 0x0048FA17
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06020DB7 RID: 134583 RVA: 0x00491822 File Offset: 0x0048FA22
		public static Offset<IContinuesVariableSpeedSplinePoint> EndIContinuesVariableSpeedSplinePoint(FlatBufferBuilder builder)
		{
			return new Offset<IContinuesVariableSpeedSplinePoint>(builder.EndTable());
		}

		// Token: 0x06020DB8 RID: 134584 RVA: 0x00491830 File Offset: 0x0048FA30
		public IContinuesVariableSpeedSplinePointT UnPack()
		{
			IContinuesVariableSpeedSplinePointT continuesVariableSpeedSplinePointT = new IContinuesVariableSpeedSplinePointT();
			this.UnPackTo(continuesVariableSpeedSplinePointT);
			return continuesVariableSpeedSplinePointT;
		}

		// Token: 0x06020DB9 RID: 134585 RVA: 0x0049184C File Offset: 0x0048FA4C
		public void UnPackTo(IContinuesVariableSpeedSplinePointT _o)
		{
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.ArriveTangent = ((this.ArriveTangent != null) ? this.ArriveTangent.Value.UnPack() : null);
			_o.LeaveTangent = ((this.LeaveTangent != null) ? this.LeaveTangent.Value.UnPack() : null);
			_o.LineType = this.LineType;
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
			_o.IntervalTimePathConfig = ((this.IntervalTimePathConfig != null) ? this.IntervalTimePathConfig.Value.UnPack() : null);
			_o.ConditionActions = new List<IConditionActionT>();
			for (int i = 0; i < this.ConditionActionsLength; i++)
			{
				_o.ConditionActions.Add((this.ConditionActions(i) != null) ? this.ConditionActions(i).Value.UnPack() : null);
			}
			_o.KeepSpeed = this.KeepSpeed;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06020DBA RID: 134586 RVA: 0x004919C4 File Offset: 0x0048FBC4
		public static Offset<IContinuesVariableSpeedSplinePoint> Pack(FlatBufferBuilder builder, IContinuesVariableSpeedSplinePointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IContinuesVariableSpeedSplinePoint>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			Offset<IVectorInfo> arriveTangentOffset = (_o.ArriveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ArriveTangent);
			Offset<IVectorInfo> leaveTangentOffset = (_o.LeaveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.LeaveTangent);
			Offset<IVectorInfo> rotationOffset = (_o.Rotation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotation);
			Offset<ITimePathConfig> intervalTimePathConfigOffset = (_o.IntervalTimePathConfig == null) ? default(Offset<ITimePathConfig>) : ITimePathConfig.Pack(builder, _o.IntervalTimePathConfig);
			VectorOffset conditionActionsOffset = default(VectorOffset);
			if (_o.ConditionActions != null)
			{
				Offset<IConditionAction>[] array = new Offset<IConditionAction>[_o.ConditionActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IConditionAction.Pack(builder, _o.ConditionActions[i]);
				}
				conditionActionsOffset = IContinuesVariableSpeedSplinePoint.CreateConditionActionsVector(builder, array);
			}
			return IContinuesVariableSpeedSplinePoint.CreateIContinuesVariableSpeedSplinePoint(builder, positionOffset, arriveTangentOffset, leaveTangentOffset, _o.LineType, rotationOffset, intervalTimePathConfigOffset, conditionActionsOffset, _o.KeepSpeed, _o.NullMask);
		}

		// Token: 0x0400E005 RID: 57349
		private Table __p;
	}
}
