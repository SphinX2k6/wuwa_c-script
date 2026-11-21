using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056DF RID: 22239
	public struct IEntityGroupComponent : IFlatbufferObject
	{
		// Token: 0x1700A04E RID: 41038
		// (get) Token: 0x06023AD1 RID: 146129 RVA: 0x004E7C90 File Offset: 0x004E5E90
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023AD2 RID: 146130 RVA: 0x004E7C9D File Offset: 0x004E5E9D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023AD3 RID: 146131 RVA: 0x004E7CA4 File Offset: 0x004E5EA4
		public static IEntityGroupComponent GetRootAsIEntityGroupComponent(ByteBuffer _bb)
		{
			return IEntityGroupComponent.GetRootAsIEntityGroupComponent(_bb, default(IEntityGroupComponent));
		}

		// Token: 0x06023AD4 RID: 146132 RVA: 0x004E7CC0 File Offset: 0x004E5EC0
		public static IEntityGroupComponent GetRootAsIEntityGroupComponent(ByteBuffer _bb, IEntityGroupComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023AD5 RID: 146133 RVA: 0x004E7CDD File Offset: 0x004E5EDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023AD6 RID: 146134 RVA: 0x004E7CEC File Offset: 0x004E5EEC
		public IEntityGroupComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A04F RID: 41039
		// (get) Token: 0x06023AD7 RID: 146135 RVA: 0x004E7CFC File Offset: 0x004E5EFC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06023AD8 RID: 146136 RVA: 0x004E7D3C File Offset: 0x004E5F3C
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A050 RID: 41040
		// (get) Token: 0x06023AD9 RID: 146137 RVA: 0x004E7D7C File Offset: 0x004E5F7C
		public int EntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06023ADA RID: 146138 RVA: 0x004E7DA7 File Offset: 0x004E5FA7
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06023ADB RID: 146139 RVA: 0x004E7DB6 File Offset: 0x004E5FB6
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06023ADC RID: 146140 RVA: 0x004E7DC4 File Offset: 0x004E5FC4
		public IEntityStateTrigger? StateTriggers(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IEntityStateTrigger?(default(IEntityStateTrigger).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A051 RID: 41041
		// (get) Token: 0x06023ADD RID: 146141 RVA: 0x004E7E24 File Offset: 0x004E6024
		public int StateTriggersLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A052 RID: 41042
		// (get) Token: 0x06023ADE RID: 146142 RVA: 0x004E7E50 File Offset: 0x004E6050
		public IFinishStateTrigger? FinishState
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IFinishStateTrigger?(default(IFinishStateTrigger).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A053 RID: 41043
		// (get) Token: 0x06023ADF RID: 146143 RVA: 0x004E7EB0 File Offset: 0x004E60B0
		public IFailureStateTrigger? FailureState
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IFailureStateTrigger?(default(IFailureStateTrigger).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A054 RID: 41044
		// (get) Token: 0x06023AE0 RID: 146144 RVA: 0x004E7F10 File Offset: 0x004E6110
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023AE1 RID: 146145 RVA: 0x004E7F4D File Offset: 0x004E614D
		public static Offset<IEntityGroupComponent> CreateIEntityGroupComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset EntityIdsOffset = default(VectorOffset), VectorOffset StateTriggersOffset = default(VectorOffset), Offset<IFinishStateTrigger> FinishStateOffset = default(Offset<IFinishStateTrigger>), Offset<IFailureStateTrigger> FailureStateOffset = default(Offset<IFailureStateTrigger>), byte NullMask = 0)
		{
			builder.StartTable(6);
			IEntityGroupComponent.AddFailureState(builder, FailureStateOffset);
			IEntityGroupComponent.AddFinishState(builder, FinishStateOffset);
			IEntityGroupComponent.AddStateTriggers(builder, StateTriggersOffset);
			IEntityGroupComponent.AddEntityIds(builder, EntityIdsOffset);
			IEntityGroupComponent.AddNullMask(builder, NullMask);
			IEntityGroupComponent.AddDisabled(builder, Disabled);
			return IEntityGroupComponent.EndIEntityGroupComponent(builder);
		}

		// Token: 0x06023AE2 RID: 146146 RVA: 0x004E7F89 File Offset: 0x004E6189
		public static void StartIEntityGroupComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06023AE3 RID: 146147 RVA: 0x004E7F92 File Offset: 0x004E6192
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023AE4 RID: 146148 RVA: 0x004E7F9D File Offset: 0x004E619D
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x06023AE5 RID: 146149 RVA: 0x004E7FB0 File Offset: 0x004E61B0
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06023AE6 RID: 146150 RVA: 0x004E7FE7 File Offset: 0x004E61E7
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023AE7 RID: 146151 RVA: 0x004E8001 File Offset: 0x004E6201
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023AE8 RID: 146152 RVA: 0x004E801F File Offset: 0x004E621F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023AE9 RID: 146153 RVA: 0x004E8038 File Offset: 0x004E6238
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023AEA RID: 146154 RVA: 0x004E8043 File Offset: 0x004E6243
		public static void AddStateTriggers(FlatBufferBuilder builder, VectorOffset stateTriggersOffset)
		{
			builder.AddOffset(2, stateTriggersOffset.Value, 0);
		}

		// Token: 0x06023AEB RID: 146155 RVA: 0x004E8054 File Offset: 0x004E6254
		public static VectorOffset CreateStateTriggersVector(FlatBufferBuilder builder, Offset<IEntityStateTrigger>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023AEC RID: 146156 RVA: 0x004E8094 File Offset: 0x004E6294
		public static VectorOffset CreateStateTriggersVectorBlock(FlatBufferBuilder builder, Offset<IEntityStateTrigger>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityStateTrigger>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023AED RID: 146157 RVA: 0x004E80AE File Offset: 0x004E62AE
		public static VectorOffset CreateStateTriggersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityStateTrigger>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityStateTrigger>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023AEE RID: 146158 RVA: 0x004E80CC File Offset: 0x004E62CC
		public static VectorOffset CreateStateTriggersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityStateTrigger>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023AEF RID: 146159 RVA: 0x004E80E5 File Offset: 0x004E62E5
		public static void StartStateTriggersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023AF0 RID: 146160 RVA: 0x004E80F0 File Offset: 0x004E62F0
		public static void AddFinishState(FlatBufferBuilder builder, Offset<IFinishStateTrigger> finishStateOffset)
		{
			builder.AddOffset(3, finishStateOffset.Value, 0);
		}

		// Token: 0x06023AF1 RID: 146161 RVA: 0x004E8100 File Offset: 0x004E6300
		public static void AddFailureState(FlatBufferBuilder builder, Offset<IFailureStateTrigger> failureStateOffset)
		{
			builder.AddOffset(4, failureStateOffset.Value, 0);
		}

		// Token: 0x06023AF2 RID: 146162 RVA: 0x004E8110 File Offset: 0x004E6310
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06023AF3 RID: 146163 RVA: 0x004E811B File Offset: 0x004E631B
		public static Offset<IEntityGroupComponent> EndIEntityGroupComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEntityGroupComponent>(builder.EndTable());
		}

		// Token: 0x06023AF4 RID: 146164 RVA: 0x004E8128 File Offset: 0x004E6328
		public IEntityGroupComponentT UnPack()
		{
			IEntityGroupComponentT entityGroupComponentT = new IEntityGroupComponentT();
			this.UnPackTo(entityGroupComponentT);
			return entityGroupComponentT;
		}

		// Token: 0x06023AF5 RID: 146165 RVA: 0x004E8144 File Offset: 0x004E6344
		public void UnPackTo(IEntityGroupComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.StateTriggers = new List<IEntityStateTriggerT>();
			for (int j = 0; j < this.StateTriggersLength; j++)
			{
				_o.StateTriggers.Add((this.StateTriggers(j) != null) ? this.StateTriggers(j).Value.UnPack() : null);
			}
			_o.FinishState = ((this.FinishState != null) ? this.FinishState.Value.UnPack() : null);
			_o.FailureState = ((this.FailureState != null) ? this.FailureState.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023AF6 RID: 146166 RVA: 0x004E8250 File Offset: 0x004E6450
		public static Offset<IEntityGroupComponent> Pack(FlatBufferBuilder builder, IEntityGroupComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityGroupComponent>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IEntityGroupComponent.CreateEntityIdsVector(builder, data);
			}
			VectorOffset stateTriggersOffset = default(VectorOffset);
			if (_o.StateTriggers != null)
			{
				Offset<IEntityStateTrigger>[] array = new Offset<IEntityStateTrigger>[_o.StateTriggers.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityStateTrigger.Pack(builder, _o.StateTriggers[i]);
				}
				stateTriggersOffset = IEntityGroupComponent.CreateStateTriggersVector(builder, array);
			}
			Offset<IFinishStateTrigger> finishStateOffset = (_o.FinishState == null) ? default(Offset<IFinishStateTrigger>) : IFinishStateTrigger.Pack(builder, _o.FinishState);
			Offset<IFailureStateTrigger> failureStateOffset = (_o.FailureState == null) ? default(Offset<IFailureStateTrigger>) : IFailureStateTrigger.Pack(builder, _o.FailureState);
			return IEntityGroupComponent.CreateIEntityGroupComponent(builder, _o.Disabled, entityIdsOffset, stateTriggersOffset, finishStateOffset, failureStateOffset, _o.NullMask);
		}

		// Token: 0x0400EE43 RID: 60995
		private Table __p;
	}
}
