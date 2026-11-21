using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005793 RID: 22419
	public struct IFanComponent : IFlatbufferObject
	{
		// Token: 0x1700A20A RID: 41482
		// (get) Token: 0x060242B9 RID: 148153 RVA: 0x004F91EA File Offset: 0x004F73EA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060242BA RID: 148154 RVA: 0x004F91F7 File Offset: 0x004F73F7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060242BB RID: 148155 RVA: 0x004F9200 File Offset: 0x004F7400
		public static IFanComponent GetRootAsIFanComponent(ByteBuffer _bb)
		{
			return IFanComponent.GetRootAsIFanComponent(_bb, default(IFanComponent));
		}

		// Token: 0x060242BC RID: 148156 RVA: 0x004F921C File Offset: 0x004F741C
		public static IFanComponent GetRootAsIFanComponent(ByteBuffer _bb, IFanComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060242BD RID: 148157 RVA: 0x004F9239 File Offset: 0x004F7439
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060242BE RID: 148158 RVA: 0x004F9248 File Offset: 0x004F7448
		public IFanComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A20B RID: 41483
		// (get) Token: 0x060242BF RID: 148159 RVA: 0x004F9258 File Offset: 0x004F7458
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A20C RID: 41484
		// (get) Token: 0x060242C0 RID: 148160 RVA: 0x004F9298 File Offset: 0x004F7498
		public EFanGearType GearType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EFanGearType.ReboundPlateGear;
				}
				return (EFanGearType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A20D RID: 41485
		// (get) Token: 0x060242C1 RID: 148161 RVA: 0x004F92D4 File Offset: 0x004F74D4
		public TFanInteractOption InteractTypeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TFanInteractOption.NONE;
				}
				return (TFanInteractOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060242C2 RID: 148162 RVA: 0x004F9310 File Offset: 0x004F7510
		public TTable? InteractType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060242C3 RID: 148163 RVA: 0x004F9358 File Offset: 0x004F7558
		public IFanInteractByFKey InteractTypeAsIFanInteractByFKey()
		{
			return this.InteractType<IFanInteractByFKey>().Value;
		}

		// Token: 0x060242C4 RID: 148164 RVA: 0x004F9374 File Offset: 0x004F7574
		public IFanInteractByHit InteractTypeAsIFanInteractByHit()
		{
			return this.InteractType<IFanInteractByHit>().Value;
		}

		// Token: 0x1700A20E RID: 41486
		// (get) Token: 0x060242C5 RID: 148165 RVA: 0x004F9390 File Offset: 0x004F7590
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A20F RID: 41487
		// (get) Token: 0x060242C6 RID: 148166 RVA: 0x004F93F0 File Offset: 0x004F75F0
		public string RotateActor
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060242C7 RID: 148167 RVA: 0x004F9428 File Offset: 0x004F7628
		public Span<byte> GetRotateActorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060242C8 RID: 148168 RVA: 0x004F9438 File Offset: 0x004F7638
		public byte[] GetRotateActorArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700A210 RID: 41488
		// (get) Token: 0x060242C9 RID: 148169 RVA: 0x004F9448 File Offset: 0x004F7648
		public string OffsetActor
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060242CA RID: 148170 RVA: 0x004F9480 File Offset: 0x004F7680
		public Span<byte> GetOffsetActorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060242CB RID: 148171 RVA: 0x004F9490 File Offset: 0x004F7690
		public byte[] GetOffsetActorArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x1700A211 RID: 41489
		// (get) Token: 0x060242CC RID: 148172 RVA: 0x004F94A0 File Offset: 0x004F76A0
		public int CirclePerRound
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

		// Token: 0x1700A212 RID: 41490
		// (get) Token: 0x060242CD RID: 148173 RVA: 0x004F94E0 File Offset: 0x004F76E0
		public int InitCircle
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

		// Token: 0x1700A213 RID: 41491
		// (get) Token: 0x060242CE RID: 148174 RVA: 0x004F9520 File Offset: 0x004F7720
		public int TargetEntityId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A214 RID: 41492
		// (get) Token: 0x060242CF RID: 148175 RVA: 0x004F9560 File Offset: 0x004F7760
		public IFanEffectConfig? EffectConfig
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new IFanEffectConfig?(default(IFanEffectConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060242D0 RID: 148176 RVA: 0x004F95C0 File Offset: 0x004F77C0
		public IFanStateEffect? EffectByState(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new IFanStateEffect?(default(IFanStateEffect).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A215 RID: 41493
		// (get) Token: 0x060242D1 RID: 148177 RVA: 0x004F9624 File Offset: 0x004F7824
		public int EffectByStateLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A216 RID: 41494
		// (get) Token: 0x060242D2 RID: 148178 RVA: 0x004F9650 File Offset: 0x004F7850
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060242D3 RID: 148179 RVA: 0x004F9690 File Offset: 0x004F7890
		public static Offset<IFanComponent> CreateIFanComponent(FlatBufferBuilder builder, bool Disabled = false, EFanGearType GearType = EFanGearType.ReboundPlateGear, TFanInteractOption InteractType_type = TFanInteractOption.NONE, int InteractTypeOffset = 0, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), StringOffset RotateActorOffset = default(StringOffset), StringOffset OffsetActorOffset = default(StringOffset), int CirclePerRound = 0, int InitCircle = 0, int TargetEntityId = 0, Offset<IFanEffectConfig> EffectConfigOffset = default(Offset<IFanEffectConfig>), VectorOffset EffectByStateOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(13);
			IFanComponent.AddEffectByState(builder, EffectByStateOffset);
			IFanComponent.AddEffectConfig(builder, EffectConfigOffset);
			IFanComponent.AddTargetEntityId(builder, TargetEntityId);
			IFanComponent.AddInitCircle(builder, InitCircle);
			IFanComponent.AddCirclePerRound(builder, CirclePerRound);
			IFanComponent.AddOffsetActor(builder, OffsetActorOffset);
			IFanComponent.AddRotateActor(builder, RotateActorOffset);
			IFanComponent.AddCondition(builder, ConditionOffset);
			IFanComponent.AddInteractType(builder, InteractTypeOffset);
			IFanComponent.AddNullMask(builder, NullMask);
			IFanComponent.AddInteractTypeType(builder, InteractType_type);
			IFanComponent.AddGearType(builder, GearType);
			IFanComponent.AddDisabled(builder, Disabled);
			return IFanComponent.EndIFanComponent(builder);
		}

		// Token: 0x060242D4 RID: 148180 RVA: 0x004F9710 File Offset: 0x004F7910
		public static void StartIFanComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x060242D5 RID: 148181 RVA: 0x004F971A File Offset: 0x004F791A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060242D6 RID: 148182 RVA: 0x004F9725 File Offset: 0x004F7925
		public static void AddGearType(FlatBufferBuilder builder, EFanGearType gearType)
		{
			builder.AddByte(1, (byte)gearType, 0);
		}

		// Token: 0x060242D7 RID: 148183 RVA: 0x004F9730 File Offset: 0x004F7930
		public static void AddInteractTypeType(FlatBufferBuilder builder, TFanInteractOption interactTypeType)
		{
			builder.AddByte(2, (byte)interactTypeType, 0);
		}

		// Token: 0x060242D8 RID: 148184 RVA: 0x004F973B File Offset: 0x004F793B
		public static void AddInteractType(FlatBufferBuilder builder, int interactTypeOffset)
		{
			builder.AddOffset(3, interactTypeOffset, 0);
		}

		// Token: 0x060242D9 RID: 148185 RVA: 0x004F9746 File Offset: 0x004F7946
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(4, conditionOffset.Value, 0);
		}

		// Token: 0x060242DA RID: 148186 RVA: 0x004F9756 File Offset: 0x004F7956
		public static void AddRotateActor(FlatBufferBuilder builder, StringOffset rotateActorOffset)
		{
			builder.AddOffset(5, rotateActorOffset.Value, 0);
		}

		// Token: 0x060242DB RID: 148187 RVA: 0x004F9766 File Offset: 0x004F7966
		public static void AddOffsetActor(FlatBufferBuilder builder, StringOffset offsetActorOffset)
		{
			builder.AddOffset(6, offsetActorOffset.Value, 0);
		}

		// Token: 0x060242DC RID: 148188 RVA: 0x004F9776 File Offset: 0x004F7976
		public static void AddCirclePerRound(FlatBufferBuilder builder, int circlePerRound)
		{
			builder.AddInt(7, circlePerRound, 0);
		}

		// Token: 0x060242DD RID: 148189 RVA: 0x004F9781 File Offset: 0x004F7981
		public static void AddInitCircle(FlatBufferBuilder builder, int initCircle)
		{
			builder.AddInt(8, initCircle, 0);
		}

		// Token: 0x060242DE RID: 148190 RVA: 0x004F978C File Offset: 0x004F798C
		public static void AddTargetEntityId(FlatBufferBuilder builder, int targetEntityId)
		{
			builder.AddInt(9, targetEntityId, 0);
		}

		// Token: 0x060242DF RID: 148191 RVA: 0x004F9798 File Offset: 0x004F7998
		public static void AddEffectConfig(FlatBufferBuilder builder, Offset<IFanEffectConfig> effectConfigOffset)
		{
			builder.AddOffset(10, effectConfigOffset.Value, 0);
		}

		// Token: 0x060242E0 RID: 148192 RVA: 0x004F97A9 File Offset: 0x004F79A9
		public static void AddEffectByState(FlatBufferBuilder builder, VectorOffset effectByStateOffset)
		{
			builder.AddOffset(11, effectByStateOffset.Value, 0);
		}

		// Token: 0x060242E1 RID: 148193 RVA: 0x004F97BC File Offset: 0x004F79BC
		public static VectorOffset CreateEffectByStateVector(FlatBufferBuilder builder, Offset<IFanStateEffect>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060242E2 RID: 148194 RVA: 0x004F97FC File Offset: 0x004F79FC
		public static VectorOffset CreateEffectByStateVectorBlock(FlatBufferBuilder builder, Offset<IFanStateEffect>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFanStateEffect>>(data);
			return builder.EndVector();
		}

		// Token: 0x060242E3 RID: 148195 RVA: 0x004F9816 File Offset: 0x004F7A16
		public static VectorOffset CreateEffectByStateVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFanStateEffect>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFanStateEffect>>(data);
			return builder.EndVector();
		}

		// Token: 0x060242E4 RID: 148196 RVA: 0x004F9834 File Offset: 0x004F7A34
		public static VectorOffset CreateEffectByStateVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFanStateEffect>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060242E5 RID: 148197 RVA: 0x004F984D File Offset: 0x004F7A4D
		public static void StartEffectByStateVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060242E6 RID: 148198 RVA: 0x004F9858 File Offset: 0x004F7A58
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x060242E7 RID: 148199 RVA: 0x004F9864 File Offset: 0x004F7A64
		public static Offset<IFanComponent> EndIFanComponent(FlatBufferBuilder builder)
		{
			return new Offset<IFanComponent>(builder.EndTable());
		}

		// Token: 0x060242E8 RID: 148200 RVA: 0x004F9874 File Offset: 0x004F7A74
		public IFanComponentT UnPack()
		{
			IFanComponentT fanComponentT = new IFanComponentT();
			this.UnPackTo(fanComponentT);
			return fanComponentT;
		}

		// Token: 0x060242E9 RID: 148201 RVA: 0x004F9890 File Offset: 0x004F7A90
		public void UnPackTo(IFanComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.GearType = this.GearType;
			_o.InteractType = new TFanInteractOptionUnion();
			_o.InteractType.Type = this.InteractTypeType;
			TFanInteractOption interactTypeType = this.InteractTypeType;
			if (interactTypeType != TFanInteractOption.IFanInteractByFKey)
			{
				if (interactTypeType == TFanInteractOption.IFanInteractByHit)
				{
					_o.InteractType.Value = ((this.InteractType<IFanInteractByHit>() != null) ? this.InteractType<IFanInteractByHit>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.InteractType.Value = ((this.InteractType<IFanInteractByFKey>() != null) ? this.InteractType<IFanInteractByFKey>().Value.UnPack() : null);
			}
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.RotateActor = this.RotateActor;
			_o.OffsetActor = this.OffsetActor;
			_o.CirclePerRound = this.CirclePerRound;
			_o.InitCircle = this.InitCircle;
			_o.TargetEntityId = this.TargetEntityId;
			_o.EffectConfig = ((this.EffectConfig != null) ? this.EffectConfig.Value.UnPack() : null);
			_o.EffectByState = new List<IFanStateEffectT>();
			for (int i = 0; i < this.EffectByStateLength; i++)
			{
				_o.EffectByState.Add((this.EffectByState(i) != null) ? this.EffectByState(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060242EA RID: 148202 RVA: 0x004F9A54 File Offset: 0x004F7C54
		public static Offset<IFanComponent> Pack(FlatBufferBuilder builder, IFanComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFanComponent>);
			}
			TFanInteractOption interactType_type = (_o.InteractType == null) ? TFanInteractOption.NONE : _o.InteractType.Type;
			int interactTypeOffset = (_o.InteractType == null) ? 0 : TFanInteractOptionUnion.Pack(builder, _o.InteractType);
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			StringOffset rotateActorOffset = (_o.RotateActor == null) ? default(StringOffset) : builder.CreateString(_o.RotateActor);
			StringOffset offsetActorOffset = (_o.OffsetActor == null) ? default(StringOffset) : builder.CreateString(_o.OffsetActor);
			Offset<IFanEffectConfig> effectConfigOffset = (_o.EffectConfig == null) ? default(Offset<IFanEffectConfig>) : IFanEffectConfig.Pack(builder, _o.EffectConfig);
			VectorOffset effectByStateOffset = default(VectorOffset);
			if (_o.EffectByState != null)
			{
				Offset<IFanStateEffect>[] array = new Offset<IFanStateEffect>[_o.EffectByState.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IFanStateEffect.Pack(builder, _o.EffectByState[i]);
				}
				effectByStateOffset = IFanComponent.CreateEffectByStateVector(builder, array);
			}
			return IFanComponent.CreateIFanComponent(builder, _o.Disabled, _o.GearType, interactType_type, interactTypeOffset, conditionOffset, rotateActorOffset, offsetActorOffset, _o.CirclePerRound, _o.InitCircle, _o.TargetEntityId, effectConfigOffset, effectByStateOffset, _o.NullMask);
		}

		// Token: 0x0400EF6C RID: 61292
		private Table __p;
	}
}
