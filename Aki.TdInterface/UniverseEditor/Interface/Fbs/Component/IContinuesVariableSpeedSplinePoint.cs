using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005583 RID: 21891
	public struct IContinuesVariableSpeedSplinePoint : IFlatbufferObject
	{
		// Token: 0x17009CB5 RID: 40117
		// (get) Token: 0x06022CB7 RID: 142519 RVA: 0x004CAD40 File Offset: 0x004C8F40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022CB8 RID: 142520 RVA: 0x004CAD4D File Offset: 0x004C8F4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022CB9 RID: 142521 RVA: 0x004CAD54 File Offset: 0x004C8F54
		public static IContinuesVariableSpeedSplinePoint GetRootAsIContinuesVariableSpeedSplinePoint(ByteBuffer _bb)
		{
			return IContinuesVariableSpeedSplinePoint.GetRootAsIContinuesVariableSpeedSplinePoint(_bb, default(IContinuesVariableSpeedSplinePoint));
		}

		// Token: 0x06022CBA RID: 142522 RVA: 0x004CAD70 File Offset: 0x004C8F70
		public static IContinuesVariableSpeedSplinePoint GetRootAsIContinuesVariableSpeedSplinePoint(ByteBuffer _bb, IContinuesVariableSpeedSplinePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022CBB RID: 142523 RVA: 0x004CAD8D File Offset: 0x004C8F8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022CBC RID: 142524 RVA: 0x004CAD9C File Offset: 0x004C8F9C
		public IContinuesVariableSpeedSplinePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CB6 RID: 40118
		// (get) Token: 0x06022CBD RID: 142525 RVA: 0x004CADAC File Offset: 0x004C8FAC
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

		// Token: 0x17009CB7 RID: 40119
		// (get) Token: 0x06022CBE RID: 142526 RVA: 0x004CAE0C File Offset: 0x004C900C
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

		// Token: 0x17009CB8 RID: 40120
		// (get) Token: 0x06022CBF RID: 142527 RVA: 0x004CAE6C File Offset: 0x004C906C
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

		// Token: 0x17009CB9 RID: 40121
		// (get) Token: 0x06022CC0 RID: 142528 RVA: 0x004CAECC File Offset: 0x004C90CC
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

		// Token: 0x17009CBA RID: 40122
		// (get) Token: 0x06022CC1 RID: 142529 RVA: 0x004CAF0C File Offset: 0x004C910C
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

		// Token: 0x17009CBB RID: 40123
		// (get) Token: 0x06022CC2 RID: 142530 RVA: 0x004CAF6C File Offset: 0x004C916C
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

		// Token: 0x06022CC3 RID: 142531 RVA: 0x004CAFCC File Offset: 0x004C91CC
		public IConditionAction? ConditionActions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IConditionAction?(default(IConditionAction).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009CBC RID: 40124
		// (get) Token: 0x06022CC4 RID: 142532 RVA: 0x004CB030 File Offset: 0x004C9230
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

		// Token: 0x17009CBD RID: 40125
		// (get) Token: 0x06022CC5 RID: 142533 RVA: 0x004CB05C File Offset: 0x004C925C
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

		// Token: 0x17009CBE RID: 40126
		// (get) Token: 0x06022CC6 RID: 142534 RVA: 0x004CB0A0 File Offset: 0x004C92A0
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

		// Token: 0x06022CC7 RID: 142535 RVA: 0x004CB0E0 File Offset: 0x004C92E0
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

		// Token: 0x06022CC8 RID: 142536 RVA: 0x004CB140 File Offset: 0x004C9340
		public static void StartIContinuesVariableSpeedSplinePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06022CC9 RID: 142537 RVA: 0x004CB14A File Offset: 0x004C934A
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x06022CCA RID: 142538 RVA: 0x004CB15A File Offset: 0x004C935A
		public static void AddArriveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> arriveTangentOffset)
		{
			builder.AddOffset(1, arriveTangentOffset.Value, 0);
		}

		// Token: 0x06022CCB RID: 142539 RVA: 0x004CB16A File Offset: 0x004C936A
		public static void AddLeaveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> leaveTangentOffset)
		{
			builder.AddOffset(2, leaveTangentOffset.Value, 0);
		}

		// Token: 0x06022CCC RID: 142540 RVA: 0x004CB17A File Offset: 0x004C937A
		public static void AddLineType(FlatBufferBuilder builder, ESplineLine lineType)
		{
			builder.AddByte(3, (byte)lineType, 0);
		}

		// Token: 0x06022CCD RID: 142541 RVA: 0x004CB185 File Offset: 0x004C9385
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(4, rotationOffset.Value, 0);
		}

		// Token: 0x06022CCE RID: 142542 RVA: 0x004CB195 File Offset: 0x004C9395
		public static void AddIntervalTimePathConfig(FlatBufferBuilder builder, Offset<ITimePathConfig> intervalTimePathConfigOffset)
		{
			builder.AddOffset(5, intervalTimePathConfigOffset.Value, 0);
		}

		// Token: 0x06022CCF RID: 142543 RVA: 0x004CB1A5 File Offset: 0x004C93A5
		public static void AddConditionActions(FlatBufferBuilder builder, VectorOffset conditionActionsOffset)
		{
			builder.AddOffset(6, conditionActionsOffset.Value, 0);
		}

		// Token: 0x06022CD0 RID: 142544 RVA: 0x004CB1B8 File Offset: 0x004C93B8
		public static VectorOffset CreateConditionActionsVector(FlatBufferBuilder builder, Offset<IConditionAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022CD1 RID: 142545 RVA: 0x004CB1F8 File Offset: 0x004C93F8
		public static VectorOffset CreateConditionActionsVectorBlock(FlatBufferBuilder builder, Offset<IConditionAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022CD2 RID: 142546 RVA: 0x004CB212 File Offset: 0x004C9412
		public static VectorOffset CreateConditionActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionAction>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022CD3 RID: 142547 RVA: 0x004CB230 File Offset: 0x004C9430
		public static VectorOffset CreateConditionActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionAction>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022CD4 RID: 142548 RVA: 0x004CB249 File Offset: 0x004C9449
		public static void StartConditionActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022CD5 RID: 142549 RVA: 0x004CB254 File Offset: 0x004C9454
		public static void AddKeepSpeed(FlatBufferBuilder builder, float keepSpeed)
		{
			builder.AddFloat(7, keepSpeed, 0.0);
		}

		// Token: 0x06022CD6 RID: 142550 RVA: 0x004CB267 File Offset: 0x004C9467
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06022CD7 RID: 142551 RVA: 0x004CB272 File Offset: 0x004C9472
		public static Offset<IContinuesVariableSpeedSplinePoint> EndIContinuesVariableSpeedSplinePoint(FlatBufferBuilder builder)
		{
			return new Offset<IContinuesVariableSpeedSplinePoint>(builder.EndTable());
		}

		// Token: 0x06022CD8 RID: 142552 RVA: 0x004CB280 File Offset: 0x004C9480
		public IContinuesVariableSpeedSplinePointT UnPack()
		{
			IContinuesVariableSpeedSplinePointT continuesVariableSpeedSplinePointT = new IContinuesVariableSpeedSplinePointT();
			this.UnPackTo(continuesVariableSpeedSplinePointT);
			return continuesVariableSpeedSplinePointT;
		}

		// Token: 0x06022CD9 RID: 142553 RVA: 0x004CB29C File Offset: 0x004C949C
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

		// Token: 0x06022CDA RID: 142554 RVA: 0x004CB414 File Offset: 0x004C9614
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

		// Token: 0x0400EBFB RID: 60411
		private Table __p;
	}
}
