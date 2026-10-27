using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050B7 RID: 20663
	public struct IDragActorPlayConfig : IFlatbufferObject
	{
		// Token: 0x17009632 RID: 38450
		// (get) Token: 0x06021341 RID: 136001 RVA: 0x0049CE3B File Offset: 0x0049B03B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021342 RID: 136002 RVA: 0x0049CE48 File Offset: 0x0049B048
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021343 RID: 136003 RVA: 0x0049CE50 File Offset: 0x0049B050
		public static IDragActorPlayConfig GetRootAsIDragActorPlayConfig(ByteBuffer _bb)
		{
			return IDragActorPlayConfig.GetRootAsIDragActorPlayConfig(_bb, default(IDragActorPlayConfig));
		}

		// Token: 0x06021344 RID: 136004 RVA: 0x0049CE6C File Offset: 0x0049B06C
		public static IDragActorPlayConfig GetRootAsIDragActorPlayConfig(ByteBuffer _bb, IDragActorPlayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021345 RID: 136005 RVA: 0x0049CE89 File Offset: 0x0049B089
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021346 RID: 136006 RVA: 0x0049CE98 File Offset: 0x0049B098
		public IDragActorPlayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009633 RID: 38451
		// (get) Token: 0x06021347 RID: 136007 RVA: 0x0049CEA8 File Offset: 0x0049B0A8
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

		// Token: 0x17009634 RID: 38452
		// (get) Token: 0x06021348 RID: 136008 RVA: 0x0049CF08 File Offset: 0x0049B108
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

		// Token: 0x06021349 RID: 136009 RVA: 0x0049CF3F File Offset: 0x0049B13F
		public Span<byte> GetDragAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602134A RID: 136010 RVA: 0x0049CF4E File Offset: 0x0049B14E
		public byte[] GetDragAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009635 RID: 38453
		// (get) Token: 0x0602134B RID: 136011 RVA: 0x0049CF5C File Offset: 0x0049B15C
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

		// Token: 0x17009636 RID: 38454
		// (get) Token: 0x0602134C RID: 136012 RVA: 0x0049CF98 File Offset: 0x0049B198
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

		// Token: 0x17009637 RID: 38455
		// (get) Token: 0x0602134D RID: 136013 RVA: 0x0049CFD8 File Offset: 0x0049B1D8
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

		// Token: 0x0602134E RID: 136014 RVA: 0x0049D010 File Offset: 0x0049B210
		public Span<byte> GetSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602134F RID: 136015 RVA: 0x0049D020 File Offset: 0x0049B220
		public byte[] GetSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17009638 RID: 38456
		// (get) Token: 0x06021350 RID: 136016 RVA: 0x0049D030 File Offset: 0x0049B230
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

		// Token: 0x17009639 RID: 38457
		// (get) Token: 0x06021351 RID: 136017 RVA: 0x0049D074 File Offset: 0x0049B274
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

		// Token: 0x1700963A RID: 38458
		// (get) Token: 0x06021352 RID: 136018 RVA: 0x0049D0B8 File Offset: 0x0049B2B8
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

		// Token: 0x06021353 RID: 136019 RVA: 0x0049D0FC File Offset: 0x0049B2FC
		public IDragActorPlayKeyPointConfig? KeyPoints(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new IDragActorPlayKeyPointConfig?(default(IDragActorPlayKeyPointConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700963B RID: 38459
		// (get) Token: 0x06021354 RID: 136020 RVA: 0x0049D160 File Offset: 0x0049B360
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

		// Token: 0x1700963C RID: 38460
		// (get) Token: 0x06021355 RID: 136021 RVA: 0x0049D18C File Offset: 0x0049B38C
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

		// Token: 0x06021356 RID: 136022 RVA: 0x0049D1C4 File Offset: 0x0049B3C4
		public Span<byte> GetDraggableActorEffectDaBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06021357 RID: 136023 RVA: 0x0049D1D4 File Offset: 0x0049B3D4
		public byte[] GetDraggableActorEffectDaArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x1700963D RID: 38461
		// (get) Token: 0x06021358 RID: 136024 RVA: 0x0049D1E4 File Offset: 0x0049B3E4
		public bool IgnoreRotation
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700963E RID: 38462
		// (get) Token: 0x06021359 RID: 136025 RVA: 0x0049D224 File Offset: 0x0049B424
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

		// Token: 0x1700963F RID: 38463
		// (get) Token: 0x0602135A RID: 136026 RVA: 0x0049D284 File Offset: 0x0049B484
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

		// Token: 0x17009640 RID: 38464
		// (get) Token: 0x0602135B RID: 136027 RVA: 0x0049D2C4 File Offset: 0x0049B4C4
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

		// Token: 0x0602135C RID: 136028 RVA: 0x0049D304 File Offset: 0x0049B504
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

		// Token: 0x0602135D RID: 136029 RVA: 0x0049D38C File Offset: 0x0049B58C
		public static void StartIDragActorPlayConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(14);
		}

		// Token: 0x0602135E RID: 136030 RVA: 0x0049D396 File Offset: 0x0049B596
		public static void AddDraggableActor(FlatBufferBuilder builder, Offset<IActorRef> draggableActorOffset)
		{
			builder.AddOffset(0, draggableActorOffset.Value, 0);
		}

		// Token: 0x0602135F RID: 136031 RVA: 0x0049D3A6 File Offset: 0x0049B5A6
		public static void AddDragAkEvent(FlatBufferBuilder builder, StringOffset dragAkEventOffset)
		{
			builder.AddOffset(1, dragAkEventOffset.Value, 0);
		}

		// Token: 0x06021360 RID: 136032 RVA: 0x0049D3B6 File Offset: 0x0049B5B6
		public static void AddEffectSplineEntityId(FlatBufferBuilder builder, int effectSplineEntityId)
		{
			builder.AddInt(2, effectSplineEntityId, 0);
		}

		// Token: 0x06021361 RID: 136033 RVA: 0x0049D3C1 File Offset: 0x0049B5C1
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(3, splineEntityId, 0);
		}

		// Token: 0x06021362 RID: 136034 RVA: 0x0049D3CC File Offset: 0x0049B5CC
		public static void AddSequence(FlatBufferBuilder builder, StringOffset sequenceOffset)
		{
			builder.AddOffset(4, sequenceOffset.Value, 0);
		}

		// Token: 0x06021363 RID: 136035 RVA: 0x0049D3DC File Offset: 0x0049B5DC
		public static void AddMaxPlaySpeed(FlatBufferBuilder builder, float maxPlaySpeed)
		{
			builder.AddFloat(5, maxPlaySpeed, 0.0);
		}

		// Token: 0x06021364 RID: 136036 RVA: 0x0049D3EF File Offset: 0x0049B5EF
		public static void AddStiffness(FlatBufferBuilder builder, float stiffness)
		{
			builder.AddFloat(6, stiffness, 0.0);
		}

		// Token: 0x06021365 RID: 136037 RVA: 0x0049D402 File Offset: 0x0049B602
		public static void AddDamping(FlatBufferBuilder builder, float damping)
		{
			builder.AddFloat(7, damping, 0.0);
		}

		// Token: 0x06021366 RID: 136038 RVA: 0x0049D415 File Offset: 0x0049B615
		public static void AddKeyPoints(FlatBufferBuilder builder, VectorOffset keyPointsOffset)
		{
			builder.AddOffset(8, keyPointsOffset.Value, 0);
		}

		// Token: 0x06021367 RID: 136039 RVA: 0x0049D428 File Offset: 0x0049B628
		public static VectorOffset CreateKeyPointsVector(FlatBufferBuilder builder, Offset<IDragActorPlayKeyPointConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021368 RID: 136040 RVA: 0x0049D468 File Offset: 0x0049B668
		public static VectorOffset CreateKeyPointsVectorBlock(FlatBufferBuilder builder, Offset<IDragActorPlayKeyPointConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDragActorPlayKeyPointConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021369 RID: 136041 RVA: 0x0049D482 File Offset: 0x0049B682
		public static VectorOffset CreateKeyPointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDragActorPlayKeyPointConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDragActorPlayKeyPointConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602136A RID: 136042 RVA: 0x0049D4A0 File Offset: 0x0049B6A0
		public static VectorOffset CreateKeyPointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDragActorPlayKeyPointConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602136B RID: 136043 RVA: 0x0049D4B9 File Offset: 0x0049B6B9
		public static void StartKeyPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602136C RID: 136044 RVA: 0x0049D4C4 File Offset: 0x0049B6C4
		public static void AddDraggableActorEffectDa(FlatBufferBuilder builder, StringOffset draggableActorEffectDaOffset)
		{
			builder.AddOffset(9, draggableActorEffectDaOffset.Value, 0);
		}

		// Token: 0x0602136D RID: 136045 RVA: 0x0049D4D5 File Offset: 0x0049B6D5
		public static void AddIgnoreRotation(FlatBufferBuilder builder, bool ignoreRotation)
		{
			builder.AddBool(10, ignoreRotation, false);
		}

		// Token: 0x0602136E RID: 136046 RVA: 0x0049D4E1 File Offset: 0x0049B6E1
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(11, conditionOffset.Value, 0);
		}

		// Token: 0x0602136F RID: 136047 RVA: 0x0049D4F2 File Offset: 0x0049B6F2
		public static void AddDragHintType(FlatBufferBuilder builder, EDragHintType dragHintType)
		{
			builder.AddByte(12, (byte)dragHintType, 0);
		}

		// Token: 0x06021370 RID: 136048 RVA: 0x0049D4FE File Offset: 0x0049B6FE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(13, nullMask, 0);
		}

		// Token: 0x06021371 RID: 136049 RVA: 0x0049D50A File Offset: 0x0049B70A
		public static Offset<IDragActorPlayConfig> EndIDragActorPlayConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDragActorPlayConfig>(builder.EndTable());
		}

		// Token: 0x06021372 RID: 136050 RVA: 0x0049D518 File Offset: 0x0049B718
		public IDragActorPlayConfigT UnPack()
		{
			IDragActorPlayConfigT dragActorPlayConfigT = new IDragActorPlayConfigT();
			this.UnPackTo(dragActorPlayConfigT);
			return dragActorPlayConfigT;
		}

		// Token: 0x06021373 RID: 136051 RVA: 0x0049D534 File Offset: 0x0049B734
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

		// Token: 0x06021374 RID: 136052 RVA: 0x0049D67C File Offset: 0x0049B87C
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

		// Token: 0x0400E0E4 RID: 57572
		private Table __p;
	}
}
