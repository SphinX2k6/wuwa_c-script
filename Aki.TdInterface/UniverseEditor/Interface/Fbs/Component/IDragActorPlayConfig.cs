using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200561C RID: 22044
	public struct IDragActorPlayConfig : IFlatbufferObject
	{
		// Token: 0x17009E1F RID: 40479
		// (get) Token: 0x06023295 RID: 144021 RVA: 0x004D6DC7 File Offset: 0x004D4FC7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023296 RID: 144022 RVA: 0x004D6DD4 File Offset: 0x004D4FD4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023297 RID: 144023 RVA: 0x004D6DDC File Offset: 0x004D4FDC
		public static IDragActorPlayConfig GetRootAsIDragActorPlayConfig(ByteBuffer _bb)
		{
			return IDragActorPlayConfig.GetRootAsIDragActorPlayConfig(_bb, default(IDragActorPlayConfig));
		}

		// Token: 0x06023298 RID: 144024 RVA: 0x004D6DF8 File Offset: 0x004D4FF8
		public static IDragActorPlayConfig GetRootAsIDragActorPlayConfig(ByteBuffer _bb, IDragActorPlayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023299 RID: 144025 RVA: 0x004D6E15 File Offset: 0x004D5015
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602329A RID: 144026 RVA: 0x004D6E24 File Offset: 0x004D5024
		public IDragActorPlayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E20 RID: 40480
		// (get) Token: 0x0602329B RID: 144027 RVA: 0x004D6E34 File Offset: 0x004D5034
		public IActorRef? DraggableActor
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009E21 RID: 40481
		// (get) Token: 0x0602329C RID: 144028 RVA: 0x004D6E94 File Offset: 0x004D5094
		public string DragAkEvent
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602329D RID: 144029 RVA: 0x004D6ECB File Offset: 0x004D50CB
		public Span<byte> GetDragAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602329E RID: 144030 RVA: 0x004D6EDA File Offset: 0x004D50DA
		public byte[] GetDragAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009E22 RID: 40482
		// (get) Token: 0x0602329F RID: 144031 RVA: 0x004D6EE8 File Offset: 0x004D50E8
		public int EffectSplineEntityId
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

		// Token: 0x17009E23 RID: 40483
		// (get) Token: 0x060232A0 RID: 144032 RVA: 0x004D6F24 File Offset: 0x004D5124
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

		// Token: 0x17009E24 RID: 40484
		// (get) Token: 0x060232A1 RID: 144033 RVA: 0x004D6F64 File Offset: 0x004D5164
		public string Sequence
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060232A2 RID: 144034 RVA: 0x004D6F9C File Offset: 0x004D519C
		public Span<byte> GetSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060232A3 RID: 144035 RVA: 0x004D6FAC File Offset: 0x004D51AC
		public byte[] GetSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17009E25 RID: 40485
		// (get) Token: 0x060232A4 RID: 144036 RVA: 0x004D6FBC File Offset: 0x004D51BC
		public float MaxPlaySpeed
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009E26 RID: 40486
		// (get) Token: 0x060232A5 RID: 144037 RVA: 0x004D7000 File Offset: 0x004D5200
		public float Stiffness
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009E27 RID: 40487
		// (get) Token: 0x060232A6 RID: 144038 RVA: 0x004D7044 File Offset: 0x004D5244
		public float Damping
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

		// Token: 0x060232A7 RID: 144039 RVA: 0x004D7088 File Offset: 0x004D5288
		public IDragActorPlayKeyPointConfig? KeyPoints(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new IDragActorPlayKeyPointConfig?(default(IDragActorPlayKeyPointConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009E28 RID: 40488
		// (get) Token: 0x060232A8 RID: 144040 RVA: 0x004D70EC File Offset: 0x004D52EC
		public int KeyPointsLength
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

		// Token: 0x17009E29 RID: 40489
		// (get) Token: 0x060232A9 RID: 144041 RVA: 0x004D7118 File Offset: 0x004D5318
		public string DraggableActorEffectDa
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060232AA RID: 144042 RVA: 0x004D7150 File Offset: 0x004D5350
		public Span<byte> GetDraggableActorEffectDaBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060232AB RID: 144043 RVA: 0x004D7160 File Offset: 0x004D5360
		public byte[] GetDraggableActorEffectDaArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x17009E2A RID: 40490
		// (get) Token: 0x060232AC RID: 144044 RVA: 0x004D7170 File Offset: 0x004D5370
		public bool IgnoreRotation
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009E2B RID: 40491
		// (get) Token: 0x060232AD RID: 144045 RVA: 0x004D71B0 File Offset: 0x004D53B0
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009E2C RID: 40492
		// (get) Token: 0x060232AE RID: 144046 RVA: 0x004D7210 File Offset: 0x004D5410
		public EDragHintType DragHintType
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return EDragHintType.Horizontal;
				}
				return (EDragHintType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009E2D RID: 40493
		// (get) Token: 0x060232AF RID: 144047 RVA: 0x004D7250 File Offset: 0x004D5450
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

		// Token: 0x060232B0 RID: 144048 RVA: 0x004D7290 File Offset: 0x004D5490
		public static Offset<IDragActorPlayConfig> CreateIDragActorPlayConfig(FlatBufferBuilder builder, Offset<IActorRef> DraggableActorOffset = default(Offset<IActorRef>), StringOffset DragAkEventOffset = default(StringOffset), int EffectSplineEntityId = 0, int SplineEntityId = 0, StringOffset SequenceOffset = default(StringOffset), float MaxPlaySpeed = 0f, float Stiffness = 0f, float Damping = 0f, VectorOffset KeyPointsOffset = default(VectorOffset), StringOffset DraggableActorEffectDaOffset = default(StringOffset), bool IgnoreRotation = false, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), EDragHintType DragHintType = EDragHintType.Horizontal, byte NullMask = 0)
		{
			builder.StartTable(14);
			IDragActorPlayConfig.AddCondition(builder, ConditionOffset);
			IDragActorPlayConfig.AddDraggableActorEffectDa(builder, DraggableActorEffectDaOffset);
			IDragActorPlayConfig.AddKeyPoints(builder, KeyPointsOffset);
			IDragActorPlayConfig.AddDamping(builder, Damping);
			IDragActorPlayConfig.AddStiffness(builder, Stiffness);
			IDragActorPlayConfig.AddMaxPlaySpeed(builder, MaxPlaySpeed);
			IDragActorPlayConfig.AddSequence(builder, SequenceOffset);
			IDragActorPlayConfig.AddSplineEntityId(builder, SplineEntityId);
			IDragActorPlayConfig.AddEffectSplineEntityId(builder, EffectSplineEntityId);
			IDragActorPlayConfig.AddDragAkEvent(builder, DragAkEventOffset);
			IDragActorPlayConfig.AddDraggableActor(builder, DraggableActorOffset);
			IDragActorPlayConfig.AddNullMask(builder, NullMask);
			IDragActorPlayConfig.AddDragHintType(builder, DragHintType);
			IDragActorPlayConfig.AddIgnoreRotation(builder, IgnoreRotation);
			return IDragActorPlayConfig.EndIDragActorPlayConfig(builder);
		}

		// Token: 0x060232B1 RID: 144049 RVA: 0x004D7318 File Offset: 0x004D5518
		public static void StartIDragActorPlayConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(14);
		}

		// Token: 0x060232B2 RID: 144050 RVA: 0x004D7322 File Offset: 0x004D5522
		public static void AddDraggableActor(FlatBufferBuilder builder, Offset<IActorRef> draggableActorOffset)
		{
			builder.AddOffset(0, draggableActorOffset.Value, 0);
		}

		// Token: 0x060232B3 RID: 144051 RVA: 0x004D7332 File Offset: 0x004D5532
		public static void AddDragAkEvent(FlatBufferBuilder builder, StringOffset dragAkEventOffset)
		{
			builder.AddOffset(1, dragAkEventOffset.Value, 0);
		}

		// Token: 0x060232B4 RID: 144052 RVA: 0x004D7342 File Offset: 0x004D5542
		public static void AddEffectSplineEntityId(FlatBufferBuilder builder, int effectSplineEntityId)
		{
			builder.AddInt(2, effectSplineEntityId, 0);
		}

		// Token: 0x060232B5 RID: 144053 RVA: 0x004D734D File Offset: 0x004D554D
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(3, splineEntityId, 0);
		}

		// Token: 0x060232B6 RID: 144054 RVA: 0x004D7358 File Offset: 0x004D5558
		public static void AddSequence(FlatBufferBuilder builder, StringOffset sequenceOffset)
		{
			builder.AddOffset(4, sequenceOffset.Value, 0);
		}

		// Token: 0x060232B7 RID: 144055 RVA: 0x004D7368 File Offset: 0x004D5568
		public static void AddMaxPlaySpeed(FlatBufferBuilder builder, float maxPlaySpeed)
		{
			builder.AddFloat(5, maxPlaySpeed, 0.0);
		}

		// Token: 0x060232B8 RID: 144056 RVA: 0x004D737B File Offset: 0x004D557B
		public static void AddStiffness(FlatBufferBuilder builder, float stiffness)
		{
			builder.AddFloat(6, stiffness, 0.0);
		}

		// Token: 0x060232B9 RID: 144057 RVA: 0x004D738E File Offset: 0x004D558E
		public static void AddDamping(FlatBufferBuilder builder, float damping)
		{
			builder.AddFloat(7, damping, 0.0);
		}

		// Token: 0x060232BA RID: 144058 RVA: 0x004D73A1 File Offset: 0x004D55A1
		public static void AddKeyPoints(FlatBufferBuilder builder, VectorOffset keyPointsOffset)
		{
			builder.AddOffset(8, keyPointsOffset.Value, 0);
		}

		// Token: 0x060232BB RID: 144059 RVA: 0x004D73B4 File Offset: 0x004D55B4
		public static VectorOffset CreateKeyPointsVector(FlatBufferBuilder builder, Offset<IDragActorPlayKeyPointConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060232BC RID: 144060 RVA: 0x004D73F4 File Offset: 0x004D55F4
		public static VectorOffset CreateKeyPointsVectorBlock(FlatBufferBuilder builder, Offset<IDragActorPlayKeyPointConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDragActorPlayKeyPointConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060232BD RID: 144061 RVA: 0x004D740E File Offset: 0x004D560E
		public static VectorOffset CreateKeyPointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDragActorPlayKeyPointConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDragActorPlayKeyPointConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060232BE RID: 144062 RVA: 0x004D742C File Offset: 0x004D562C
		public static VectorOffset CreateKeyPointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDragActorPlayKeyPointConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060232BF RID: 144063 RVA: 0x004D7445 File Offset: 0x004D5645
		public static void StartKeyPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060232C0 RID: 144064 RVA: 0x004D7450 File Offset: 0x004D5650
		public static void AddDraggableActorEffectDa(FlatBufferBuilder builder, StringOffset draggableActorEffectDaOffset)
		{
			builder.AddOffset(9, draggableActorEffectDaOffset.Value, 0);
		}

		// Token: 0x060232C1 RID: 144065 RVA: 0x004D7461 File Offset: 0x004D5661
		public static void AddIgnoreRotation(FlatBufferBuilder builder, bool ignoreRotation)
		{
			builder.AddBool(10, ignoreRotation, false);
		}

		// Token: 0x060232C2 RID: 144066 RVA: 0x004D746D File Offset: 0x004D566D
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(11, conditionOffset.Value, 0);
		}

		// Token: 0x060232C3 RID: 144067 RVA: 0x004D747E File Offset: 0x004D567E
		public static void AddDragHintType(FlatBufferBuilder builder, EDragHintType dragHintType)
		{
			builder.AddByte(12, (byte)dragHintType, 0);
		}

		// Token: 0x060232C4 RID: 144068 RVA: 0x004D748A File Offset: 0x004D568A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(13, nullMask, 0);
		}

		// Token: 0x060232C5 RID: 144069 RVA: 0x004D7496 File Offset: 0x004D5696
		public static Offset<IDragActorPlayConfig> EndIDragActorPlayConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDragActorPlayConfig>(builder.EndTable());
		}

		// Token: 0x060232C6 RID: 144070 RVA: 0x004D74A4 File Offset: 0x004D56A4
		public IDragActorPlayConfigT UnPack()
		{
			IDragActorPlayConfigT dragActorPlayConfigT = new IDragActorPlayConfigT();
			this.UnPackTo(dragActorPlayConfigT);
			return dragActorPlayConfigT;
		}

		// Token: 0x060232C7 RID: 144071 RVA: 0x004D74C0 File Offset: 0x004D56C0
		public void UnPackTo(IDragActorPlayConfigT _o)
		{
			_o.DraggableActor = ((this.DraggableActor != null) ? this.DraggableActor.Value.UnPack() : null);
			_o.DragAkEvent = this.DragAkEvent;
			_o.EffectSplineEntityId = this.EffectSplineEntityId;
			_o.SplineEntityId = this.SplineEntityId;
			_o.Sequence = this.Sequence;
			_o.MaxPlaySpeed = this.MaxPlaySpeed;
			_o.Stiffness = this.Stiffness;
			_o.Damping = this.Damping;
			_o.KeyPoints = new List<IDragActorPlayKeyPointConfigT>();
			for (int i = 0; i < this.KeyPointsLength; i++)
			{
				_o.KeyPoints.Add((this.KeyPoints(i) != null) ? this.KeyPoints(i).Value.UnPack() : null);
			}
			_o.DraggableActorEffectDa = this.DraggableActorEffectDa;
			_o.IgnoreRotation = this.IgnoreRotation;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.DragHintType = this.DragHintType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060232C8 RID: 144072 RVA: 0x004D7608 File Offset: 0x004D5808
		public static Offset<IDragActorPlayConfig> Pack(FlatBufferBuilder builder, IDragActorPlayConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDragActorPlayConfig>);
			}
			Offset<IActorRef> draggableActorOffset = (_o.DraggableActor == null) ? default(Offset<IActorRef>) : IActorRef.Pack(builder, _o.DraggableActor);
			StringOffset dragAkEventOffset = (_o.DragAkEvent == null) ? default(StringOffset) : builder.CreateString(_o.DragAkEvent);
			StringOffset sequenceOffset = (_o.Sequence == null) ? default(StringOffset) : builder.CreateString(_o.Sequence);
			VectorOffset keyPointsOffset = default(VectorOffset);
			if (_o.KeyPoints != null)
			{
				Offset<IDragActorPlayKeyPointConfig>[] array = new Offset<IDragActorPlayKeyPointConfig>[_o.KeyPoints.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IDragActorPlayKeyPointConfig.Pack(builder, _o.KeyPoints[i]);
				}
				keyPointsOffset = IDragActorPlayConfig.CreateKeyPointsVector(builder, array);
			}
			StringOffset draggableActorEffectDaOffset = (_o.DraggableActorEffectDa == null) ? default(StringOffset) : builder.CreateString(_o.DraggableActorEffectDa);
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return IDragActorPlayConfig.CreateIDragActorPlayConfig(builder, draggableActorOffset, dragAkEventOffset, _o.EffectSplineEntityId, _o.SplineEntityId, sequenceOffset, _o.MaxPlaySpeed, _o.Stiffness, _o.Damping, keyPointsOffset, draggableActorEffectDaOffset, _o.IgnoreRotation, conditionOffset, _o.DragHintType, _o.NullMask);
		}

		// Token: 0x0400ECE1 RID: 60641
		private Table __p;
	}
}
