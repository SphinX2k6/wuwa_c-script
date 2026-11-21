using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200571E RID: 22302
	public struct IEntityStateComponent : IFlatbufferObject
	{
		// Token: 0x1700A0E2 RID: 41186
		// (get) Token: 0x06023D68 RID: 146792 RVA: 0x004ED033 File Offset: 0x004EB233
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023D69 RID: 146793 RVA: 0x004ED040 File Offset: 0x004EB240
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023D6A RID: 146794 RVA: 0x004ED048 File Offset: 0x004EB248
		public static IEntityStateComponent GetRootAsIEntityStateComponent(ByteBuffer _bb)
		{
			return IEntityStateComponent.GetRootAsIEntityStateComponent(_bb, default(IEntityStateComponent));
		}

		// Token: 0x06023D6B RID: 146795 RVA: 0x004ED064 File Offset: 0x004EB264
		public static IEntityStateComponent GetRootAsIEntityStateComponent(ByteBuffer _bb, IEntityStateComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023D6C RID: 146796 RVA: 0x004ED081 File Offset: 0x004EB281
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023D6D RID: 146797 RVA: 0x004ED090 File Offset: 0x004EB290
		public IEntityStateComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A0E3 RID: 41187
		// (get) Token: 0x06023D6E RID: 146798 RVA: 0x004ED0A0 File Offset: 0x004EB2A0
		public string Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023D6F RID: 146799 RVA: 0x004ED0D7 File Offset: 0x004EB2D7
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06023D70 RID: 146800 RVA: 0x004ED0E6 File Offset: 0x004EB2E6
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A0E4 RID: 41188
		// (get) Token: 0x06023D71 RID: 146801 RVA: 0x004ED0F4 File Offset: 0x004EB2F4
		public string State
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

		// Token: 0x06023D72 RID: 146802 RVA: 0x004ED12B File Offset: 0x004EB32B
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06023D73 RID: 146803 RVA: 0x004ED13A File Offset: 0x004EB33A
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A0E5 RID: 41189
		// (get) Token: 0x06023D74 RID: 146804 RVA: 0x004ED148 File Offset: 0x004EB348
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A0E6 RID: 41190
		// (get) Token: 0x06023D75 RID: 146805 RVA: 0x004ED188 File Offset: 0x004EB388
		public IConditionGroup? StateChangeCondition
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06023D76 RID: 146806 RVA: 0x004ED1E8 File Offset: 0x004EB3E8
		public IStateChangeBehavior? StateChangeBehaviors(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IStateChangeBehavior?(default(IStateChangeBehavior).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A0E7 RID: 41191
		// (get) Token: 0x06023D77 RID: 146807 RVA: 0x004ED24C File Offset: 0x004EB44C
		public int StateChangeBehaviorsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A0E8 RID: 41192
		// (get) Token: 0x06023D78 RID: 146808 RVA: 0x004ED278 File Offset: 0x004EB478
		public bool InstantActionsOnStateChange
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A0E9 RID: 41193
		// (get) Token: 0x06023D79 RID: 146809 RVA: 0x004ED2B8 File Offset: 0x004EB4B8
		public ILockConfig? LockConfig
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new ILockConfig?(default(ILockConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06023D7A RID: 146810 RVA: 0x004ED318 File Offset: 0x004EB518
		public IStateConfig? StateConfigs(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new IStateConfig?(default(IStateConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A0EA RID: 41194
		// (get) Token: 0x06023D7B RID: 146811 RVA: 0x004ED37C File Offset: 0x004EB57C
		public int StateConfigsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06023D7C RID: 146812 RVA: 0x004ED3A8 File Offset: 0x004EB5A8
		public string CycleStates(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A0EB RID: 41195
		// (get) Token: 0x06023D7D RID: 146813 RVA: 0x004ED3E4 File Offset: 0x004EB5E4
		public int CycleStatesLength
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

		// Token: 0x1700A0EC RID: 41196
		// (get) Token: 0x06023D7E RID: 146814 RVA: 0x004ED410 File Offset: 0x004EB610
		public string PrefabPerformanceType
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

		// Token: 0x06023D7F RID: 146815 RVA: 0x004ED448 File Offset: 0x004EB648
		public Span<byte> GetPrefabPerformanceTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06023D80 RID: 146816 RVA: 0x004ED458 File Offset: 0x004EB658
		public byte[] GetPrefabPerformanceTypeArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x1700A0ED RID: 41197
		// (get) Token: 0x06023D81 RID: 146817 RVA: 0x004ED468 File Offset: 0x004EB668
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023D82 RID: 146818 RVA: 0x004ED4A8 File Offset: 0x004EB6A8
		public static Offset<IEntityStateComponent> CreateIEntityStateComponent(FlatBufferBuilder builder, StringOffset TypeOffset = default(StringOffset), StringOffset StateOffset = default(StringOffset), bool Disabled = false, Offset<IConditionGroup> StateChangeConditionOffset = default(Offset<IConditionGroup>), VectorOffset StateChangeBehaviorsOffset = default(VectorOffset), bool InstantActionsOnStateChange = false, Offset<ILockConfig> LockConfigOffset = default(Offset<ILockConfig>), VectorOffset StateConfigsOffset = default(VectorOffset), VectorOffset CycleStatesOffset = default(VectorOffset), StringOffset PrefabPerformanceTypeOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(11);
			IEntityStateComponent.AddPrefabPerformanceType(builder, PrefabPerformanceTypeOffset);
			IEntityStateComponent.AddCycleStates(builder, CycleStatesOffset);
			IEntityStateComponent.AddStateConfigs(builder, StateConfigsOffset);
			IEntityStateComponent.AddLockConfig(builder, LockConfigOffset);
			IEntityStateComponent.AddStateChangeBehaviors(builder, StateChangeBehaviorsOffset);
			IEntityStateComponent.AddStateChangeCondition(builder, StateChangeConditionOffset);
			IEntityStateComponent.AddState(builder, StateOffset);
			IEntityStateComponent.AddType(builder, TypeOffset);
			IEntityStateComponent.AddNullMask(builder, NullMask);
			IEntityStateComponent.AddInstantActionsOnStateChange(builder, InstantActionsOnStateChange);
			IEntityStateComponent.AddDisabled(builder, Disabled);
			return IEntityStateComponent.EndIEntityStateComponent(builder);
		}

		// Token: 0x06023D83 RID: 146819 RVA: 0x004ED518 File Offset: 0x004EB718
		public static void StartIEntityStateComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06023D84 RID: 146820 RVA: 0x004ED522 File Offset: 0x004EB722
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(0, typeOffset.Value, 0);
		}

		// Token: 0x06023D85 RID: 146821 RVA: 0x004ED532 File Offset: 0x004EB732
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x06023D86 RID: 146822 RVA: 0x004ED542 File Offset: 0x004EB742
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(2, disabled, false);
		}

		// Token: 0x06023D87 RID: 146823 RVA: 0x004ED54D File Offset: 0x004EB74D
		public static void AddStateChangeCondition(FlatBufferBuilder builder, Offset<IConditionGroup> stateChangeConditionOffset)
		{
			builder.AddOffset(3, stateChangeConditionOffset.Value, 0);
		}

		// Token: 0x06023D88 RID: 146824 RVA: 0x004ED55D File Offset: 0x004EB75D
		public static void AddStateChangeBehaviors(FlatBufferBuilder builder, VectorOffset stateChangeBehaviorsOffset)
		{
			builder.AddOffset(4, stateChangeBehaviorsOffset.Value, 0);
		}

		// Token: 0x06023D89 RID: 146825 RVA: 0x004ED570 File Offset: 0x004EB770
		public static VectorOffset CreateStateChangeBehaviorsVector(FlatBufferBuilder builder, Offset<IStateChangeBehavior>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023D8A RID: 146826 RVA: 0x004ED5B0 File Offset: 0x004EB7B0
		public static VectorOffset CreateStateChangeBehaviorsVectorBlock(FlatBufferBuilder builder, Offset<IStateChangeBehavior>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IStateChangeBehavior>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023D8B RID: 146827 RVA: 0x004ED5CA File Offset: 0x004EB7CA
		public static VectorOffset CreateStateChangeBehaviorsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IStateChangeBehavior>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IStateChangeBehavior>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023D8C RID: 146828 RVA: 0x004ED5E8 File Offset: 0x004EB7E8
		public static VectorOffset CreateStateChangeBehaviorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IStateChangeBehavior>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023D8D RID: 146829 RVA: 0x004ED601 File Offset: 0x004EB801
		public static void StartStateChangeBehaviorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023D8E RID: 146830 RVA: 0x004ED60C File Offset: 0x004EB80C
		public static void AddInstantActionsOnStateChange(FlatBufferBuilder builder, bool instantActionsOnStateChange)
		{
			builder.AddBool(5, instantActionsOnStateChange, false);
		}

		// Token: 0x06023D8F RID: 146831 RVA: 0x004ED617 File Offset: 0x004EB817
		public static void AddLockConfig(FlatBufferBuilder builder, Offset<ILockConfig> lockConfigOffset)
		{
			builder.AddOffset(6, lockConfigOffset.Value, 0);
		}

		// Token: 0x06023D90 RID: 146832 RVA: 0x004ED627 File Offset: 0x004EB827
		public static void AddStateConfigs(FlatBufferBuilder builder, VectorOffset stateConfigsOffset)
		{
			builder.AddOffset(7, stateConfigsOffset.Value, 0);
		}

		// Token: 0x06023D91 RID: 146833 RVA: 0x004ED638 File Offset: 0x004EB838
		public static VectorOffset CreateStateConfigsVector(FlatBufferBuilder builder, Offset<IStateConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023D92 RID: 146834 RVA: 0x004ED678 File Offset: 0x004EB878
		public static VectorOffset CreateStateConfigsVectorBlock(FlatBufferBuilder builder, Offset<IStateConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IStateConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023D93 RID: 146835 RVA: 0x004ED692 File Offset: 0x004EB892
		public static VectorOffset CreateStateConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IStateConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IStateConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023D94 RID: 146836 RVA: 0x004ED6B0 File Offset: 0x004EB8B0
		public static VectorOffset CreateStateConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IStateConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023D95 RID: 146837 RVA: 0x004ED6C9 File Offset: 0x004EB8C9
		public static void StartStateConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023D96 RID: 146838 RVA: 0x004ED6D4 File Offset: 0x004EB8D4
		public static void AddCycleStates(FlatBufferBuilder builder, VectorOffset cycleStatesOffset)
		{
			builder.AddOffset(8, cycleStatesOffset.Value, 0);
		}

		// Token: 0x06023D97 RID: 146839 RVA: 0x004ED6E4 File Offset: 0x004EB8E4
		public static VectorOffset CreateCycleStatesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023D98 RID: 146840 RVA: 0x004ED724 File Offset: 0x004EB924
		public static VectorOffset CreateCycleStatesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06023D99 RID: 146841 RVA: 0x004ED73E File Offset: 0x004EB93E
		public static VectorOffset CreateCycleStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06023D9A RID: 146842 RVA: 0x004ED75C File Offset: 0x004EB95C
		public static VectorOffset CreateCycleStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023D9B RID: 146843 RVA: 0x004ED775 File Offset: 0x004EB975
		public static void StartCycleStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023D9C RID: 146844 RVA: 0x004ED780 File Offset: 0x004EB980
		public static void AddPrefabPerformanceType(FlatBufferBuilder builder, StringOffset prefabPerformanceTypeOffset)
		{
			builder.AddOffset(9, prefabPerformanceTypeOffset.Value, 0);
		}

		// Token: 0x06023D9D RID: 146845 RVA: 0x004ED791 File Offset: 0x004EB991
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x06023D9E RID: 146846 RVA: 0x004ED79D File Offset: 0x004EB99D
		public static Offset<IEntityStateComponent> EndIEntityStateComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEntityStateComponent>(builder.EndTable());
		}

		// Token: 0x06023D9F RID: 146847 RVA: 0x004ED7AC File Offset: 0x004EB9AC
		public IEntityStateComponentT UnPack()
		{
			IEntityStateComponentT entityStateComponentT = new IEntityStateComponentT();
			this.UnPackTo(entityStateComponentT);
			return entityStateComponentT;
		}

		// Token: 0x06023DA0 RID: 146848 RVA: 0x004ED7C8 File Offset: 0x004EB9C8
		public void UnPackTo(IEntityStateComponentT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
			_o.Disabled = this.Disabled;
			_o.StateChangeCondition = ((this.StateChangeCondition != null) ? this.StateChangeCondition.Value.UnPack() : null);
			_o.StateChangeBehaviors = new List<IStateChangeBehaviorT>();
			for (int i = 0; i < this.StateChangeBehaviorsLength; i++)
			{
				_o.StateChangeBehaviors.Add((this.StateChangeBehaviors(i) != null) ? this.StateChangeBehaviors(i).Value.UnPack() : null);
			}
			_o.InstantActionsOnStateChange = this.InstantActionsOnStateChange;
			_o.LockConfig = ((this.LockConfig != null) ? this.LockConfig.Value.UnPack() : null);
			_o.StateConfigs = new List<IStateConfigT>();
			for (int j = 0; j < this.StateConfigsLength; j++)
			{
				_o.StateConfigs.Add((this.StateConfigs(j) != null) ? this.StateConfigs(j).Value.UnPack() : null);
			}
			_o.CycleStates = new List<string>();
			for (int k = 0; k < this.CycleStatesLength; k++)
			{
				_o.CycleStates.Add(this.CycleStates(k));
			}
			_o.PrefabPerformanceType = this.PrefabPerformanceType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023DA1 RID: 146849 RVA: 0x004ED960 File Offset: 0x004EBB60
		public static Offset<IEntityStateComponent> Pack(FlatBufferBuilder builder, IEntityStateComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityStateComponent>);
			}
			StringOffset typeOffset = (_o.Type == null) ? default(StringOffset) : builder.CreateString(_o.Type);
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			Offset<IConditionGroup> stateChangeConditionOffset = (_o.StateChangeCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.StateChangeCondition);
			VectorOffset stateChangeBehaviorsOffset = default(VectorOffset);
			if (_o.StateChangeBehaviors != null)
			{
				Offset<IStateChangeBehavior>[] array = new Offset<IStateChangeBehavior>[_o.StateChangeBehaviors.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IStateChangeBehavior.Pack(builder, _o.StateChangeBehaviors[i]);
				}
				stateChangeBehaviorsOffset = IEntityStateComponent.CreateStateChangeBehaviorsVector(builder, array);
			}
			Offset<ILockConfig> lockConfigOffset = (_o.LockConfig == null) ? default(Offset<ILockConfig>) : ILockConfig.Pack(builder, _o.LockConfig);
			VectorOffset stateConfigsOffset = default(VectorOffset);
			if (_o.StateConfigs != null)
			{
				Offset<IStateConfig>[] array2 = new Offset<IStateConfig>[_o.StateConfigs.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IStateConfig.Pack(builder, _o.StateConfigs[j]);
				}
				stateConfigsOffset = IEntityStateComponent.CreateStateConfigsVector(builder, array2);
			}
			VectorOffset cycleStatesOffset = default(VectorOffset);
			if (_o.CycleStates != null)
			{
				StringOffset[] array3 = new StringOffset[_o.CycleStates.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = builder.CreateString(_o.CycleStates[k]);
				}
				cycleStatesOffset = IEntityStateComponent.CreateCycleStatesVector(builder, array3);
			}
			StringOffset prefabPerformanceTypeOffset = (_o.PrefabPerformanceType == null) ? default(StringOffset) : builder.CreateString(_o.PrefabPerformanceType);
			return IEntityStateComponent.CreateIEntityStateComponent(builder, typeOffset, stateOffset, _o.Disabled, stateChangeConditionOffset, stateChangeBehaviorsOffset, _o.InstantActionsOnStateChange, lockConfigOffset, stateConfigsOffset, cycleStatesOffset, prefabPerformanceTypeOffset, _o.NullMask);
		}

		// Token: 0x0400EEA4 RID: 61092
		private Table __p;
	}
}
