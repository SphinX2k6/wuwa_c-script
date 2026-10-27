using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A90 RID: 14992
	public struct IConstVarRef : IFlatbufferObject
	{
		// Token: 0x170066B2 RID: 26290
		// (get) Token: 0x0601455F RID: 83295 RVA: 0x002F7849 File Offset: 0x002F5A49
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014560 RID: 83296 RVA: 0x002F7856 File Offset: 0x002F5A56
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014561 RID: 83297 RVA: 0x002F7860 File Offset: 0x002F5A60
		public static IConstVarRef GetRootAsIConstVarRef(ByteBuffer _bb)
		{
			return IConstVarRef.GetRootAsIConstVarRef(_bb, default(IConstVarRef));
		}

		// Token: 0x06014562 RID: 83298 RVA: 0x002F787C File Offset: 0x002F5A7C
		public static IConstVarRef GetRootAsIConstVarRef(ByteBuffer _bb, IConstVarRef obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014563 RID: 83299 RVA: 0x002F7899 File Offset: 0x002F5A99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014564 RID: 83300 RVA: 0x002F78A8 File Offset: 0x002F5AA8
		public IConstVarRef __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170066B3 RID: 26291
		// (get) Token: 0x06014565 RID: 83301 RVA: 0x002F78B8 File Offset: 0x002F5AB8
		public EVar Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVar.Boolean;
				}
				return (EVar)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170066B4 RID: 26292
		// (get) Token: 0x06014566 RID: 83302 RVA: 0x002F78F4 File Offset: 0x002F5AF4
		public EVarRefSource Source
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EVarRefSource.Constant;
				}
				return (EVarRefSource)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170066B5 RID: 26293
		// (get) Token: 0x06014567 RID: 83303 RVA: 0x002F7930 File Offset: 0x002F5B30
		public TVarValue ValueType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TVarValue.NONE;
				}
				return (TVarValue)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014568 RID: 83304 RVA: 0x002F796C File Offset: 0x002F5B6C
		public TTable? Value<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06014569 RID: 83305 RVA: 0x002F79B4 File Offset: 0x002F5BB4
		public BooleanValue ValueAsBooleanValue()
		{
			return this.Value<BooleanValue>().Value;
		}

		// Token: 0x0601456A RID: 83306 RVA: 0x002F79D0 File Offset: 0x002F5BD0
		public IntValue ValueAsIntValue()
		{
			return this.Value<IntValue>().Value;
		}

		// Token: 0x0601456B RID: 83307 RVA: 0x002F79EC File Offset: 0x002F5BEC
		public FloatValue ValueAsFloatValue()
		{
			return this.Value<FloatValue>().Value;
		}

		// Token: 0x0601456C RID: 83308 RVA: 0x002F7A08 File Offset: 0x002F5C08
		public StringValue ValueAsStringValue()
		{
			return this.Value<StringValue>().Value;
		}

		// Token: 0x0601456D RID: 83309 RVA: 0x002F7A24 File Offset: 0x002F5C24
		public QuestStateValue ValueAsQuestStateValue()
		{
			return this.Value<QuestStateValue>().Value;
		}

		// Token: 0x0601456E RID: 83310 RVA: 0x002F7A40 File Offset: 0x002F5C40
		public EntityValue ValueAsEntityValue()
		{
			return this.Value<EntityValue>().Value;
		}

		// Token: 0x0601456F RID: 83311 RVA: 0x002F7A5C File Offset: 0x002F5C5C
		public QuestValue ValueAsQuestValue()
		{
			return this.Value<QuestValue>().Value;
		}

		// Token: 0x06014570 RID: 83312 RVA: 0x002F7A78 File Offset: 0x002F5C78
		public PrefabValue ValueAsPrefabValue()
		{
			return this.Value<PrefabValue>().Value;
		}

		// Token: 0x06014571 RID: 83313 RVA: 0x002F7A94 File Offset: 0x002F5C94
		public TransformValue ValueAsTransformValue()
		{
			return this.Value<TransformValue>().Value;
		}

		// Token: 0x06014572 RID: 83314 RVA: 0x002F7AAF File Offset: 0x002F5CAF
		public static Offset<IConstVarRef> CreateIConstVarRef(FlatBufferBuilder builder, EVar Type = EVar.Boolean, EVarRefSource Source = EVarRefSource.Constant, TVarValue Value_type = TVarValue.NONE, int ValueOffset = 0)
		{
			builder.StartTable(4);
			IConstVarRef.AddValue(builder, ValueOffset);
			IConstVarRef.AddValueType(builder, Value_type);
			IConstVarRef.AddSource(builder, Source);
			IConstVarRef.AddType(builder, Type);
			return IConstVarRef.EndIConstVarRef(builder);
		}

		// Token: 0x06014573 RID: 83315 RVA: 0x002F7ADB File Offset: 0x002F5CDB
		public static void StartIConstVarRef(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06014574 RID: 83316 RVA: 0x002F7AE4 File Offset: 0x002F5CE4
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014575 RID: 83317 RVA: 0x002F7AEF File Offset: 0x002F5CEF
		public static void AddSource(FlatBufferBuilder builder, EVarRefSource source)
		{
			builder.AddByte(1, (byte)source, 0);
		}

		// Token: 0x06014576 RID: 83318 RVA: 0x002F7AFA File Offset: 0x002F5CFA
		public static void AddValueType(FlatBufferBuilder builder, TVarValue valueType)
		{
			builder.AddByte(2, (byte)valueType, 0);
		}

		// Token: 0x06014577 RID: 83319 RVA: 0x002F7B05 File Offset: 0x002F5D05
		public static void AddValue(FlatBufferBuilder builder, int valueOffset)
		{
			builder.AddOffset(3, valueOffset, 0);
		}

		// Token: 0x06014578 RID: 83320 RVA: 0x002F7B10 File Offset: 0x002F5D10
		public static Offset<IConstVarRef> EndIConstVarRef(FlatBufferBuilder builder)
		{
			return new Offset<IConstVarRef>(builder.EndTable());
		}

		// Token: 0x06014579 RID: 83321 RVA: 0x002F7B20 File Offset: 0x002F5D20
		public IConstVarRefT UnPack()
		{
			IConstVarRefT constVarRefT = new IConstVarRefT();
			this.UnPackTo(constVarRefT);
			return constVarRefT;
		}

		// Token: 0x0601457A RID: 83322 RVA: 0x002F7B3C File Offset: 0x002F5D3C
		public void UnPackTo(IConstVarRefT _o)
		{
			_o.Type = this.Type;
			_o.Source = this.Source;
			_o.Value = new TVarValueUnion();
			_o.Value.Type = this.ValueType;
			switch (this.ValueType)
			{
			case TVarValue.BooleanValue:
				_o.Value.Value = ((this.Value<BooleanValue>() != null) ? this.Value<BooleanValue>().Value.UnPack() : null);
				return;
			case TVarValue.IntValue:
				_o.Value.Value = ((this.Value<IntValue>() != null) ? this.Value<IntValue>().Value.UnPack() : null);
				return;
			case TVarValue.FloatValue:
				_o.Value.Value = ((this.Value<FloatValue>() != null) ? this.Value<FloatValue>().Value.UnPack() : null);
				return;
			case TVarValue.StringValue:
				_o.Value.Value = ((this.Value<StringValue>() != null) ? this.Value<StringValue>().Value.UnPack() : null);
				return;
			case TVarValue.QuestStateValue:
				_o.Value.Value = ((this.Value<QuestStateValue>() != null) ? this.Value<QuestStateValue>().Value.UnPack() : null);
				return;
			case TVarValue.EntityValue:
				_o.Value.Value = ((this.Value<EntityValue>() != null) ? this.Value<EntityValue>().Value.UnPack() : null);
				return;
			case TVarValue.QuestValue:
				_o.Value.Value = ((this.Value<QuestValue>() != null) ? this.Value<QuestValue>().Value.UnPack() : null);
				return;
			case TVarValue.PrefabValue:
				_o.Value.Value = ((this.Value<PrefabValue>() != null) ? this.Value<PrefabValue>().Value.UnPack() : null);
				return;
			case TVarValue.TransformValue:
				_o.Value.Value = ((this.Value<TransformValue>() != null) ? this.Value<TransformValue>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0601457B RID: 83323 RVA: 0x002F7DA4 File Offset: 0x002F5FA4
		public static Offset<IConstVarRef> Pack(FlatBufferBuilder builder, IConstVarRefT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConstVarRef>);
			}
			TVarValue value_type = (_o.Value == null) ? TVarValue.NONE : _o.Value.Type;
			int valueOffset = (_o.Value == null) ? 0 : TVarValueUnion.Pack(builder, _o.Value);
			return IConstVarRef.CreateIConstVarRef(builder, _o.Type, _o.Source, value_type, valueOffset);
		}

		// Token: 0x0400AF0E RID: 44814
		private Table __p;
	}
}
