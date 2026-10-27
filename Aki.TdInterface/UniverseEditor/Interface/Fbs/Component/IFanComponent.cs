using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200522B RID: 21035
	public struct IFanComponent : IFlatbufferObject
	{
		// Token: 0x17009A0E RID: 39438
		// (get) Token: 0x06022323 RID: 140067 RVA: 0x004BE726 File Offset: 0x004BC926
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022324 RID: 140068 RVA: 0x004BE733 File Offset: 0x004BC933
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022325 RID: 140069 RVA: 0x004BE73C File Offset: 0x004BC93C
		public static IFanComponent GetRootAsIFanComponent(ByteBuffer _bb)
		{
			return IFanComponent.GetRootAsIFanComponent(_bb, default(IFanComponent));
		}

		// Token: 0x06022326 RID: 140070 RVA: 0x004BE758 File Offset: 0x004BC958
		public static IFanComponent GetRootAsIFanComponent(ByteBuffer _bb, IFanComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022327 RID: 140071 RVA: 0x004BE775 File Offset: 0x004BC975
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022328 RID: 140072 RVA: 0x004BE784 File Offset: 0x004BC984
		public IFanComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A0F RID: 39439
		// (get) Token: 0x06022329 RID: 140073 RVA: 0x004BE794 File Offset: 0x004BC994
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009A10 RID: 39440
		// (get) Token: 0x0602232A RID: 140074 RVA: 0x004BE7D4 File Offset: 0x004BC9D4
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

		// Token: 0x17009A11 RID: 39441
		// (get) Token: 0x0602232B RID: 140075 RVA: 0x004BE810 File Offset: 0x004BCA10
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

		// Token: 0x0602232C RID: 140076 RVA: 0x004BE84C File Offset: 0x004BCA4C
		public TTable? InteractType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602232D RID: 140077 RVA: 0x004BE894 File Offset: 0x004BCA94
		public IFanInteractByFKey InteractTypeAsIFanInteractByFKey()
		{
			return this.InteractType<IFanInteractByFKey>().Value;
		}

		// Token: 0x0602232E RID: 140078 RVA: 0x004BE8B0 File Offset: 0x004BCAB0
		public IFanInteractByHit InteractTypeAsIFanInteractByHit()
		{
			return this.InteractType<IFanInteractByHit>().Value;
		}

		// Token: 0x17009A12 RID: 39442
		// (get) Token: 0x0602232F RID: 140079 RVA: 0x004BE8CC File Offset: 0x004BCACC
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

		// Token: 0x17009A13 RID: 39443
		// (get) Token: 0x06022330 RID: 140080 RVA: 0x004BE92C File Offset: 0x004BCB2C
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

		// Token: 0x06022331 RID: 140081 RVA: 0x004BE964 File Offset: 0x004BCB64
		public Span<byte> GetRotateActorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06022332 RID: 140082 RVA: 0x004BE974 File Offset: 0x004BCB74
		public byte[] GetRotateActorArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x17009A14 RID: 39444
		// (get) Token: 0x06022333 RID: 140083 RVA: 0x004BE984 File Offset: 0x004BCB84
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

		// Token: 0x06022334 RID: 140084 RVA: 0x004BE9BC File Offset: 0x004BCBBC
		public Span<byte> GetOffsetActorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06022335 RID: 140085 RVA: 0x004BE9CC File Offset: 0x004BCBCC
		public byte[] GetOffsetActorArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x17009A15 RID: 39445
		// (get) Token: 0x06022336 RID: 140086 RVA: 0x004BE9DC File Offset: 0x004BCBDC
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

		// Token: 0x17009A16 RID: 39446
		// (get) Token: 0x06022337 RID: 140087 RVA: 0x004BEA1C File Offset: 0x004BCC1C
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

		// Token: 0x17009A17 RID: 39447
		// (get) Token: 0x06022338 RID: 140088 RVA: 0x004BEA5C File Offset: 0x004BCC5C
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

		// Token: 0x17009A18 RID: 39448
		// (get) Token: 0x06022339 RID: 140089 RVA: 0x004BEA9C File Offset: 0x004BCC9C
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

		// Token: 0x0602233A RID: 140090 RVA: 0x004BEAFC File Offset: 0x004BCCFC
		public IFanStateEffect? EffectByState(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new IFanStateEffect?(default(IFanStateEffect).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009A19 RID: 39449
		// (get) Token: 0x0602233B RID: 140091 RVA: 0x004BEB60 File Offset: 0x004BCD60
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

		// Token: 0x17009A1A RID: 39450
		// (get) Token: 0x0602233C RID: 140092 RVA: 0x004BEB8C File Offset: 0x004BCD8C
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

		// Token: 0x0602233D RID: 140093 RVA: 0x004BEBCC File Offset: 0x004BCDCC
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

		// Token: 0x0602233E RID: 140094 RVA: 0x004BEC4C File Offset: 0x004BCE4C
		public static void StartIFanComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x0602233F RID: 140095 RVA: 0x004BEC56 File Offset: 0x004BCE56
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022340 RID: 140096 RVA: 0x004BEC61 File Offset: 0x004BCE61
		public static void AddGearType(FlatBufferBuilder builder, EFanGearType gearType)
		{
			builder.AddByte(1, (byte)gearType, 0);
		}

		// Token: 0x06022341 RID: 140097 RVA: 0x004BEC6C File Offset: 0x004BCE6C
		public static void AddInteractTypeType(FlatBufferBuilder builder, TFanInteractOption interactTypeType)
		{
			builder.AddByte(2, (byte)interactTypeType, 0);
		}

		// Token: 0x06022342 RID: 140098 RVA: 0x004BEC77 File Offset: 0x004BCE77
		public static void AddInteractType(FlatBufferBuilder builder, int interactTypeOffset)
		{
			builder.AddOffset(3, interactTypeOffset, 0);
		}

		// Token: 0x06022343 RID: 140099 RVA: 0x004BEC82 File Offset: 0x004BCE82
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(4, conditionOffset.Value, 0);
		}

		// Token: 0x06022344 RID: 140100 RVA: 0x004BEC92 File Offset: 0x004BCE92
		public static void AddRotateActor(FlatBufferBuilder builder, StringOffset rotateActorOffset)
		{
			builder.AddOffset(5, rotateActorOffset.Value, 0);
		}

		// Token: 0x06022345 RID: 140101 RVA: 0x004BECA2 File Offset: 0x004BCEA2
		public static void AddOffsetActor(FlatBufferBuilder builder, StringOffset offsetActorOffset)
		{
			builder.AddOffset(6, offsetActorOffset.Value, 0);
		}

		// Token: 0x06022346 RID: 140102 RVA: 0x004BECB2 File Offset: 0x004BCEB2
		public static void AddCirclePerRound(FlatBufferBuilder builder, int circlePerRound)
		{
			builder.AddInt(7, circlePerRound, 0);
		}

		// Token: 0x06022347 RID: 140103 RVA: 0x004BECBD File Offset: 0x004BCEBD
		public static void AddInitCircle(FlatBufferBuilder builder, int initCircle)
		{
			builder.AddInt(8, initCircle, 0);
		}

		// Token: 0x06022348 RID: 140104 RVA: 0x004BECC8 File Offset: 0x004BCEC8
		public static void AddTargetEntityId(FlatBufferBuilder builder, int targetEntityId)
		{
			builder.AddInt(9, targetEntityId, 0);
		}

		// Token: 0x06022349 RID: 140105 RVA: 0x004BECD4 File Offset: 0x004BCED4
		public static void AddEffectConfig(FlatBufferBuilder builder, Offset<IFanEffectConfig> effectConfigOffset)
		{
			builder.AddOffset(10, effectConfigOffset.Value, 0);
		}

		// Token: 0x0602234A RID: 140106 RVA: 0x004BECE5 File Offset: 0x004BCEE5
		public static void AddEffectByState(FlatBufferBuilder builder, VectorOffset effectByStateOffset)
		{
			builder.AddOffset(11, effectByStateOffset.Value, 0);
		}

		// Token: 0x0602234B RID: 140107 RVA: 0x004BECF8 File Offset: 0x004BCEF8
		public static VectorOffset CreateEffectByStateVector(FlatBufferBuilder builder, Offset<IFanStateEffect>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602234C RID: 140108 RVA: 0x004BED38 File Offset: 0x004BCF38
		public static VectorOffset CreateEffectByStateVectorBlock(FlatBufferBuilder builder, Offset<IFanStateEffect>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFanStateEffect>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602234D RID: 140109 RVA: 0x004BED52 File Offset: 0x004BCF52
		public static VectorOffset CreateEffectByStateVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFanStateEffect>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFanStateEffect>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602234E RID: 140110 RVA: 0x004BED70 File Offset: 0x004BCF70
		public static VectorOffset CreateEffectByStateVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFanStateEffect>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602234F RID: 140111 RVA: 0x004BED89 File Offset: 0x004BCF89
		public static void StartEffectByStateVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022350 RID: 140112 RVA: 0x004BED94 File Offset: 0x004BCF94
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x06022351 RID: 140113 RVA: 0x004BEDA0 File Offset: 0x004BCFA0
		public static Offset<IFanComponent> EndIFanComponent(FlatBufferBuilder builder)
		{
			return new Offset<IFanComponent>(builder.EndTable());
		}

		// Token: 0x06022352 RID: 140114 RVA: 0x004BEDB0 File Offset: 0x004BCFB0
		public IFanComponentT UnPack()
		{
			IFanComponentT fanComponentT = new IFanComponentT();
			this.UnPackTo(fanComponentT);
			return fanComponentT;
		}

		// Token: 0x06022353 RID: 140115 RVA: 0x004BEDCC File Offset: 0x004BCFCC
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

		// Token: 0x06022354 RID: 140116 RVA: 0x004BEF90 File Offset: 0x004BD190
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

		// Token: 0x0400E366 RID: 58214
		private Table __p;
	}
}
