using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200517A RID: 20858
	public struct IEntityGroupComponent : IFlatbufferObject
	{
		// Token: 0x1700985F RID: 39007
		// (get) Token: 0x06021B79 RID: 138105 RVA: 0x004ADC70 File Offset: 0x004ABE70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021B7A RID: 138106 RVA: 0x004ADC7D File Offset: 0x004ABE7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021B7B RID: 138107 RVA: 0x004ADC84 File Offset: 0x004ABE84
		public static IEntityGroupComponent GetRootAsIEntityGroupComponent(ByteBuffer _bb)
		{
			return IEntityGroupComponent.GetRootAsIEntityGroupComponent(_bb, default(IEntityGroupComponent));
		}

		// Token: 0x06021B7C RID: 138108 RVA: 0x004ADCA0 File Offset: 0x004ABEA0
		public static IEntityGroupComponent GetRootAsIEntityGroupComponent(ByteBuffer _bb, IEntityGroupComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021B7D RID: 138109 RVA: 0x004ADCBD File Offset: 0x004ABEBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021B7E RID: 138110 RVA: 0x004ADCCC File Offset: 0x004ABECC
		public IEntityGroupComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009860 RID: 39008
		// (get) Token: 0x06021B7F RID: 138111 RVA: 0x004ADCDC File Offset: 0x004ABEDC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06021B80 RID: 138112 RVA: 0x004ADD1C File Offset: 0x004ABF1C
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009861 RID: 39009
		// (get) Token: 0x06021B81 RID: 138113 RVA: 0x004ADD5C File Offset: 0x004ABF5C
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

		// Token: 0x06021B82 RID: 138114 RVA: 0x004ADD87 File Offset: 0x004ABF87
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06021B83 RID: 138115 RVA: 0x004ADD96 File Offset: 0x004ABF96
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06021B84 RID: 138116 RVA: 0x004ADDA4 File Offset: 0x004ABFA4
		public IEntityStateTrigger? StateTriggers(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IEntityStateTrigger?(default(IEntityStateTrigger).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009862 RID: 39010
		// (get) Token: 0x06021B85 RID: 138117 RVA: 0x004ADE04 File Offset: 0x004AC004
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

		// Token: 0x17009863 RID: 39011
		// (get) Token: 0x06021B86 RID: 138118 RVA: 0x004ADE30 File Offset: 0x004AC030
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

		// Token: 0x17009864 RID: 39012
		// (get) Token: 0x06021B87 RID: 138119 RVA: 0x004ADE90 File Offset: 0x004AC090
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

		// Token: 0x17009865 RID: 39013
		// (get) Token: 0x06021B88 RID: 138120 RVA: 0x004ADEF0 File Offset: 0x004AC0F0
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

		// Token: 0x06021B89 RID: 138121 RVA: 0x004ADF2D File Offset: 0x004AC12D
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

		// Token: 0x06021B8A RID: 138122 RVA: 0x004ADF69 File Offset: 0x004AC169
		public static void StartIEntityGroupComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06021B8B RID: 138123 RVA: 0x004ADF72 File Offset: 0x004AC172
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021B8C RID: 138124 RVA: 0x004ADF7D File Offset: 0x004AC17D
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x06021B8D RID: 138125 RVA: 0x004ADF90 File Offset: 0x004AC190
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06021B8E RID: 138126 RVA: 0x004ADFC7 File Offset: 0x004AC1C7
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06021B8F RID: 138127 RVA: 0x004ADFE1 File Offset: 0x004AC1E1
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06021B90 RID: 138128 RVA: 0x004ADFFF File Offset: 0x004AC1FF
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021B91 RID: 138129 RVA: 0x004AE018 File Offset: 0x004AC218
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021B92 RID: 138130 RVA: 0x004AE023 File Offset: 0x004AC223
		public static void AddStateTriggers(FlatBufferBuilder builder, VectorOffset stateTriggersOffset)
		{
			builder.AddOffset(2, stateTriggersOffset.Value, 0);
		}

		// Token: 0x06021B93 RID: 138131 RVA: 0x004AE034 File Offset: 0x004AC234
		public static VectorOffset CreateStateTriggersVector(FlatBufferBuilder builder, Offset<IEntityStateTrigger>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021B94 RID: 138132 RVA: 0x004AE074 File Offset: 0x004AC274
		public static VectorOffset CreateStateTriggersVectorBlock(FlatBufferBuilder builder, Offset<IEntityStateTrigger>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityStateTrigger>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021B95 RID: 138133 RVA: 0x004AE08E File Offset: 0x004AC28E
		public static VectorOffset CreateStateTriggersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityStateTrigger>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityStateTrigger>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021B96 RID: 138134 RVA: 0x004AE0AC File Offset: 0x004AC2AC
		public static VectorOffset CreateStateTriggersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityStateTrigger>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021B97 RID: 138135 RVA: 0x004AE0C5 File Offset: 0x004AC2C5
		public static void StartStateTriggersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021B98 RID: 138136 RVA: 0x004AE0D0 File Offset: 0x004AC2D0
		public static void AddFinishState(FlatBufferBuilder builder, Offset<IFinishStateTrigger> finishStateOffset)
		{
			builder.AddOffset(3, finishStateOffset.Value, 0);
		}

		// Token: 0x06021B99 RID: 138137 RVA: 0x004AE0E0 File Offset: 0x004AC2E0
		public static void AddFailureState(FlatBufferBuilder builder, Offset<IFailureStateTrigger> failureStateOffset)
		{
			builder.AddOffset(4, failureStateOffset.Value, 0);
		}

		// Token: 0x06021B9A RID: 138138 RVA: 0x004AE0F0 File Offset: 0x004AC2F0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06021B9B RID: 138139 RVA: 0x004AE0FB File Offset: 0x004AC2FB
		public static Offset<IEntityGroupComponent> EndIEntityGroupComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEntityGroupComponent>(builder.EndTable());
		}

		// Token: 0x06021B9C RID: 138140 RVA: 0x004AE108 File Offset: 0x004AC308
		public IEntityGroupComponentT UnPack()
		{
			IEntityGroupComponentT entityGroupComponentT = new IEntityGroupComponentT();
			this.UnPackTo(entityGroupComponentT);
			return entityGroupComponentT;
		}

		// Token: 0x06021B9D RID: 138141 RVA: 0x004AE124 File Offset: 0x004AC324
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

		// Token: 0x06021B9E RID: 138142 RVA: 0x004AE230 File Offset: 0x004AC430
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

		// Token: 0x0400E245 RID: 57925
		private Table __p;
	}
}
