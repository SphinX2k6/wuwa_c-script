using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051B9 RID: 20921
	public struct IEntityStateComponent : IFlatbufferObject
	{
		// Token: 0x170098F3 RID: 39155
		// (get) Token: 0x06021E10 RID: 138768 RVA: 0x004B2FCB File Offset: 0x004B11CB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021E11 RID: 138769 RVA: 0x004B2FD8 File Offset: 0x004B11D8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021E12 RID: 138770 RVA: 0x004B2FE0 File Offset: 0x004B11E0
		public static IEntityStateComponent GetRootAsIEntityStateComponent(ByteBuffer _bb)
		{
			return IEntityStateComponent.GetRootAsIEntityStateComponent(_bb, default(IEntityStateComponent));
		}

		// Token: 0x06021E13 RID: 138771 RVA: 0x004B2FFC File Offset: 0x004B11FC
		public static IEntityStateComponent GetRootAsIEntityStateComponent(ByteBuffer _bb, IEntityStateComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021E14 RID: 138772 RVA: 0x004B3019 File Offset: 0x004B1219
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021E15 RID: 138773 RVA: 0x004B3028 File Offset: 0x004B1228
		public IEntityStateComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170098F4 RID: 39156
		// (get) Token: 0x06021E16 RID: 138774 RVA: 0x004B3038 File Offset: 0x004B1238
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

		// Token: 0x06021E17 RID: 138775 RVA: 0x004B306F File Offset: 0x004B126F
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06021E18 RID: 138776 RVA: 0x004B307E File Offset: 0x004B127E
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170098F5 RID: 39157
		// (get) Token: 0x06021E19 RID: 138777 RVA: 0x004B308C File Offset: 0x004B128C
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

		// Token: 0x06021E1A RID: 138778 RVA: 0x004B30C3 File Offset: 0x004B12C3
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06021E1B RID: 138779 RVA: 0x004B30D2 File Offset: 0x004B12D2
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170098F6 RID: 39158
		// (get) Token: 0x06021E1C RID: 138780 RVA: 0x004B30E0 File Offset: 0x004B12E0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170098F7 RID: 39159
		// (get) Token: 0x06021E1D RID: 138781 RVA: 0x004B3120 File Offset: 0x004B1320
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

		// Token: 0x06021E1E RID: 138782 RVA: 0x004B3180 File Offset: 0x004B1380
		public IStateChangeBehavior? StateChangeBehaviors(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IStateChangeBehavior?(default(IStateChangeBehavior).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170098F8 RID: 39160
		// (get) Token: 0x06021E1F RID: 138783 RVA: 0x004B31E4 File Offset: 0x004B13E4
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

		// Token: 0x170098F9 RID: 39161
		// (get) Token: 0x06021E20 RID: 138784 RVA: 0x004B3210 File Offset: 0x004B1410
		public bool InstantActionsOnStateChange
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170098FA RID: 39162
		// (get) Token: 0x06021E21 RID: 138785 RVA: 0x004B3250 File Offset: 0x004B1450
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

		// Token: 0x06021E22 RID: 138786 RVA: 0x004B32B0 File Offset: 0x004B14B0
		public IStateConfig? StateConfigs(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new IStateConfig?(default(IStateConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170098FB RID: 39163
		// (get) Token: 0x06021E23 RID: 138787 RVA: 0x004B3314 File Offset: 0x004B1514
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

		// Token: 0x06021E24 RID: 138788 RVA: 0x004B3340 File Offset: 0x004B1540
		public string CycleStates(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170098FC RID: 39164
		// (get) Token: 0x06021E25 RID: 138789 RVA: 0x004B337C File Offset: 0x004B157C
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

		// Token: 0x170098FD RID: 39165
		// (get) Token: 0x06021E26 RID: 138790 RVA: 0x004B33A8 File Offset: 0x004B15A8
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

		// Token: 0x06021E27 RID: 138791 RVA: 0x004B33E0 File Offset: 0x004B15E0
		public Span<byte> GetPrefabPerformanceTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06021E28 RID: 138792 RVA: 0x004B33F0 File Offset: 0x004B15F0
		public byte[] GetPrefabPerformanceTypeArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x170098FE RID: 39166
		// (get) Token: 0x06021E29 RID: 138793 RVA: 0x004B3400 File Offset: 0x004B1600
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

		// Token: 0x06021E2A RID: 138794 RVA: 0x004B3440 File Offset: 0x004B1640
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

		// Token: 0x06021E2B RID: 138795 RVA: 0x004B34B0 File Offset: 0x004B16B0
		public static void StartIEntityStateComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06021E2C RID: 138796 RVA: 0x004B34BA File Offset: 0x004B16BA
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(0, typeOffset.Value, 0);
		}

		// Token: 0x06021E2D RID: 138797 RVA: 0x004B34CA File Offset: 0x004B16CA
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x06021E2E RID: 138798 RVA: 0x004B34DA File Offset: 0x004B16DA
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(2, disabled, false);
		}

		// Token: 0x06021E2F RID: 138799 RVA: 0x004B34E5 File Offset: 0x004B16E5
		public static void AddStateChangeCondition(FlatBufferBuilder builder, Offset<IConditionGroup> stateChangeConditionOffset)
		{
			builder.AddOffset(3, stateChangeConditionOffset.Value, 0);
		}

		// Token: 0x06021E30 RID: 138800 RVA: 0x004B34F5 File Offset: 0x004B16F5
		public static void AddStateChangeBehaviors(FlatBufferBuilder builder, VectorOffset stateChangeBehaviorsOffset)
		{
			builder.AddOffset(4, stateChangeBehaviorsOffset.Value, 0);
		}

		// Token: 0x06021E31 RID: 138801 RVA: 0x004B3508 File Offset: 0x004B1708
		public static VectorOffset CreateStateChangeBehaviorsVector(FlatBufferBuilder builder, Offset<IStateChangeBehavior>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021E32 RID: 138802 RVA: 0x004B3548 File Offset: 0x004B1748
		public static VectorOffset CreateStateChangeBehaviorsVectorBlock(FlatBufferBuilder builder, Offset<IStateChangeBehavior>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IStateChangeBehavior>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021E33 RID: 138803 RVA: 0x004B3562 File Offset: 0x004B1762
		public static VectorOffset CreateStateChangeBehaviorsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IStateChangeBehavior>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IStateChangeBehavior>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021E34 RID: 138804 RVA: 0x004B3580 File Offset: 0x004B1780
		public static VectorOffset CreateStateChangeBehaviorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IStateChangeBehavior>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021E35 RID: 138805 RVA: 0x004B3599 File Offset: 0x004B1799
		public static void StartStateChangeBehaviorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021E36 RID: 138806 RVA: 0x004B35A4 File Offset: 0x004B17A4
		public static void AddInstantActionsOnStateChange(FlatBufferBuilder builder, bool instantActionsOnStateChange)
		{
			builder.AddBool(5, instantActionsOnStateChange, false);
		}

		// Token: 0x06021E37 RID: 138807 RVA: 0x004B35AF File Offset: 0x004B17AF
		public static void AddLockConfig(FlatBufferBuilder builder, Offset<ILockConfig> lockConfigOffset)
		{
			builder.AddOffset(6, lockConfigOffset.Value, 0);
		}

		// Token: 0x06021E38 RID: 138808 RVA: 0x004B35BF File Offset: 0x004B17BF
		public static void AddStateConfigs(FlatBufferBuilder builder, VectorOffset stateConfigsOffset)
		{
			builder.AddOffset(7, stateConfigsOffset.Value, 0);
		}

		// Token: 0x06021E39 RID: 138809 RVA: 0x004B35D0 File Offset: 0x004B17D0
		public static VectorOffset CreateStateConfigsVector(FlatBufferBuilder builder, Offset<IStateConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021E3A RID: 138810 RVA: 0x004B3610 File Offset: 0x004B1810
		public static VectorOffset CreateStateConfigsVectorBlock(FlatBufferBuilder builder, Offset<IStateConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IStateConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021E3B RID: 138811 RVA: 0x004B362A File Offset: 0x004B182A
		public static VectorOffset CreateStateConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IStateConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IStateConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021E3C RID: 138812 RVA: 0x004B3648 File Offset: 0x004B1848
		public static VectorOffset CreateStateConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IStateConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021E3D RID: 138813 RVA: 0x004B3661 File Offset: 0x004B1861
		public static void StartStateConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021E3E RID: 138814 RVA: 0x004B366C File Offset: 0x004B186C
		public static void AddCycleStates(FlatBufferBuilder builder, VectorOffset cycleStatesOffset)
		{
			builder.AddOffset(8, cycleStatesOffset.Value, 0);
		}

		// Token: 0x06021E3F RID: 138815 RVA: 0x004B367C File Offset: 0x004B187C
		public static VectorOffset CreateCycleStatesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021E40 RID: 138816 RVA: 0x004B36BC File Offset: 0x004B18BC
		public static VectorOffset CreateCycleStatesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06021E41 RID: 138817 RVA: 0x004B36D6 File Offset: 0x004B18D6
		public static VectorOffset CreateCycleStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06021E42 RID: 138818 RVA: 0x004B36F4 File Offset: 0x004B18F4
		public static VectorOffset CreateCycleStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021E43 RID: 138819 RVA: 0x004B370D File Offset: 0x004B190D
		public static void StartCycleStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021E44 RID: 138820 RVA: 0x004B3718 File Offset: 0x004B1918
		public static void AddPrefabPerformanceType(FlatBufferBuilder builder, StringOffset prefabPerformanceTypeOffset)
		{
			builder.AddOffset(9, prefabPerformanceTypeOffset.Value, 0);
		}

		// Token: 0x06021E45 RID: 138821 RVA: 0x004B3729 File Offset: 0x004B1929
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x06021E46 RID: 138822 RVA: 0x004B3735 File Offset: 0x004B1935
		public static Offset<IEntityStateComponent> EndIEntityStateComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEntityStateComponent>(builder.EndTable());
		}

		// Token: 0x06021E47 RID: 138823 RVA: 0x004B3744 File Offset: 0x004B1944
		public IEntityStateComponentT UnPack()
		{
			IEntityStateComponentT entityStateComponentT = new IEntityStateComponentT();
			this.UnPackTo(entityStateComponentT);
			return entityStateComponentT;
		}

		// Token: 0x06021E48 RID: 138824 RVA: 0x004B3760 File Offset: 0x004B1960
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

		// Token: 0x06021E49 RID: 138825 RVA: 0x004B38F8 File Offset: 0x004B1AF8
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

		// Token: 0x0400E2A6 RID: 58022
		private Table __p;
	}
}
