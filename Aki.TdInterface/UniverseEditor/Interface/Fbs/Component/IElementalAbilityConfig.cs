using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005688 RID: 22152
	public struct IElementalAbilityConfig : IFlatbufferObject
	{
		// Token: 0x17009F3B RID: 40763
		// (get) Token: 0x060236DA RID: 145114 RVA: 0x004DF55D File Offset: 0x004DD75D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060236DB RID: 145115 RVA: 0x004DF56A File Offset: 0x004DD76A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060236DC RID: 145116 RVA: 0x004DF574 File Offset: 0x004DD774
		public static IElementalAbilityConfig GetRootAsIElementalAbilityConfig(ByteBuffer _bb)
		{
			return IElementalAbilityConfig.GetRootAsIElementalAbilityConfig(_bb, default(IElementalAbilityConfig));
		}

		// Token: 0x060236DD RID: 145117 RVA: 0x004DF590 File Offset: 0x004DD790
		public static IElementalAbilityConfig GetRootAsIElementalAbilityConfig(ByteBuffer _bb, IElementalAbilityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060236DE RID: 145118 RVA: 0x004DF5AD File Offset: 0x004DD7AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060236DF RID: 145119 RVA: 0x004DF5BC File Offset: 0x004DD7BC
		public IElementalAbilityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F3C RID: 40764
		// (get) Token: 0x060236E0 RID: 145120 RVA: 0x004DF5CC File Offset: 0x004DD7CC
		public EElementalType ElementalType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EElementalType.Fire;
				}
				return (EElementalType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009F3D RID: 40765
		// (get) Token: 0x060236E1 RID: 145121 RVA: 0x004DF608 File Offset: 0x004DD808
		public bool IsInitialActive
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009F3E RID: 40766
		// (get) Token: 0x060236E2 RID: 145122 RVA: 0x004DF648 File Offset: 0x004DD848
		public TTriggerShape RangeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TTriggerShape.NONE;
				}
				return (TTriggerShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060236E3 RID: 145123 RVA: 0x004DF684 File Offset: 0x004DD884
		public TTable? Range<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060236E4 RID: 145124 RVA: 0x004DF6CC File Offset: 0x004DD8CC
		public IActorCollisionTriggerShape RangeAsIActorCollisionTriggerShape()
		{
			return this.Range<IActorCollisionTriggerShape>().Value;
		}

		// Token: 0x060236E5 RID: 145125 RVA: 0x004DF6E8 File Offset: 0x004DD8E8
		public IActorRefVolume RangeAsIActorRefVolume()
		{
			return this.Range<IActorRefVolume>().Value;
		}

		// Token: 0x060236E6 RID: 145126 RVA: 0x004DF704 File Offset: 0x004DD904
		public IBoxTriggerShape RangeAsIBoxTriggerShape()
		{
			return this.Range<IBoxTriggerShape>().Value;
		}

		// Token: 0x060236E7 RID: 145127 RVA: 0x004DF720 File Offset: 0x004DD920
		public ICombinationTriggerShape RangeAsICombinationTriggerShape()
		{
			return this.Range<ICombinationTriggerShape>().Value;
		}

		// Token: 0x060236E8 RID: 145128 RVA: 0x004DF73C File Offset: 0x004DD93C
		public IConeTriggerShape RangeAsIConeTriggerShape()
		{
			return this.Range<IConeTriggerShape>().Value;
		}

		// Token: 0x060236E9 RID: 145129 RVA: 0x004DF758 File Offset: 0x004DD958
		public ICylinderTriggerShape RangeAsICylinderTriggerShape()
		{
			return this.Range<ICylinderTriggerShape>().Value;
		}

		// Token: 0x060236EA RID: 145130 RVA: 0x004DF774 File Offset: 0x004DD974
		public IHollowCylinderTriggerShape RangeAsIHollowCylinderTriggerShape()
		{
			return this.Range<IHollowCylinderTriggerShape>().Value;
		}

		// Token: 0x060236EB RID: 145131 RVA: 0x004DF790 File Offset: 0x004DD990
		public IHollowSphereTriggerShape RangeAsIHollowSphereTriggerShape()
		{
			return this.Range<IHollowSphereTriggerShape>().Value;
		}

		// Token: 0x060236EC RID: 145132 RVA: 0x004DF7AC File Offset: 0x004DD9AC
		public ISphereTriggerShape RangeAsISphereTriggerShape()
		{
			return this.Range<ISphereTriggerShape>().Value;
		}

		// Token: 0x060236ED RID: 145133 RVA: 0x004DF7C8 File Offset: 0x004DD9C8
		public ISpotlightTriggerShape RangeAsISpotlightTriggerShape()
		{
			return this.Range<ISpotlightTriggerShape>().Value;
		}

		// Token: 0x060236EE RID: 145134 RVA: 0x004DF7E4 File Offset: 0x004DD9E4
		public IVolumeTriggerShape RangeAsIVolumeTriggerShape()
		{
			return this.Range<IVolumeTriggerShape>().Value;
		}

		// Token: 0x17009F3F RID: 40767
		// (get) Token: 0x060236EF RID: 145135 RVA: 0x004DF800 File Offset: 0x004DDA00
		public bool IsEnableEnvEffect
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060236F0 RID: 145136 RVA: 0x004DF840 File Offset: 0x004DDA40
		public IStateElementalEnableConfig? StateEnableConfigs(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IStateElementalEnableConfig?(default(IStateElementalEnableConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009F40 RID: 40768
		// (get) Token: 0x060236F1 RID: 145137 RVA: 0x004DF8A4 File Offset: 0x004DDAA4
		public int StateEnableConfigsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009F41 RID: 40769
		// (get) Token: 0x060236F2 RID: 145138 RVA: 0x004DF8D0 File Offset: 0x004DDAD0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060236F3 RID: 145139 RVA: 0x004DF910 File Offset: 0x004DDB10
		public static Offset<IElementalAbilityConfig> CreateIElementalAbilityConfig(FlatBufferBuilder builder, EElementalType ElementalType = EElementalType.Fire, bool IsInitialActive = false, TTriggerShape Range_type = TTriggerShape.NONE, int RangeOffset = 0, bool IsEnableEnvEffect = false, VectorOffset StateEnableConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(7);
			IElementalAbilityConfig.AddStateEnableConfigs(builder, StateEnableConfigsOffset);
			IElementalAbilityConfig.AddRange(builder, RangeOffset);
			IElementalAbilityConfig.AddNullMask(builder, NullMask);
			IElementalAbilityConfig.AddIsEnableEnvEffect(builder, IsEnableEnvEffect);
			IElementalAbilityConfig.AddRangeType(builder, Range_type);
			IElementalAbilityConfig.AddIsInitialActive(builder, IsInitialActive);
			IElementalAbilityConfig.AddElementalType(builder, ElementalType);
			return IElementalAbilityConfig.EndIElementalAbilityConfig(builder);
		}

		// Token: 0x060236F4 RID: 145140 RVA: 0x004DF95F File Offset: 0x004DDB5F
		public static void StartIElementalAbilityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060236F5 RID: 145141 RVA: 0x004DF968 File Offset: 0x004DDB68
		public static void AddElementalType(FlatBufferBuilder builder, EElementalType elementalType)
		{
			builder.AddByte(0, (byte)elementalType, 0);
		}

		// Token: 0x060236F6 RID: 145142 RVA: 0x004DF973 File Offset: 0x004DDB73
		public static void AddIsInitialActive(FlatBufferBuilder builder, bool isInitialActive)
		{
			builder.AddBool(1, isInitialActive, false);
		}

		// Token: 0x060236F7 RID: 145143 RVA: 0x004DF97E File Offset: 0x004DDB7E
		public static void AddRangeType(FlatBufferBuilder builder, TTriggerShape rangeType)
		{
			builder.AddByte(2, (byte)rangeType, 0);
		}

		// Token: 0x060236F8 RID: 145144 RVA: 0x004DF989 File Offset: 0x004DDB89
		public static void AddRange(FlatBufferBuilder builder, int rangeOffset)
		{
			builder.AddOffset(3, rangeOffset, 0);
		}

		// Token: 0x060236F9 RID: 145145 RVA: 0x004DF994 File Offset: 0x004DDB94
		public static void AddIsEnableEnvEffect(FlatBufferBuilder builder, bool isEnableEnvEffect)
		{
			builder.AddBool(4, isEnableEnvEffect, false);
		}

		// Token: 0x060236FA RID: 145146 RVA: 0x004DF99F File Offset: 0x004DDB9F
		public static void AddStateEnableConfigs(FlatBufferBuilder builder, VectorOffset stateEnableConfigsOffset)
		{
			builder.AddOffset(5, stateEnableConfigsOffset.Value, 0);
		}

		// Token: 0x060236FB RID: 145147 RVA: 0x004DF9B0 File Offset: 0x004DDBB0
		public static VectorOffset CreateStateEnableConfigsVector(FlatBufferBuilder builder, Offset<IStateElementalEnableConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060236FC RID: 145148 RVA: 0x004DF9F0 File Offset: 0x004DDBF0
		public static VectorOffset CreateStateEnableConfigsVectorBlock(FlatBufferBuilder builder, Offset<IStateElementalEnableConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IStateElementalEnableConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060236FD RID: 145149 RVA: 0x004DFA0A File Offset: 0x004DDC0A
		public static VectorOffset CreateStateEnableConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IStateElementalEnableConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IStateElementalEnableConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060236FE RID: 145150 RVA: 0x004DFA28 File Offset: 0x004DDC28
		public static VectorOffset CreateStateEnableConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IStateElementalEnableConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060236FF RID: 145151 RVA: 0x004DFA41 File Offset: 0x004DDC41
		public static void StartStateEnableConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023700 RID: 145152 RVA: 0x004DFA4C File Offset: 0x004DDC4C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06023701 RID: 145153 RVA: 0x004DFA57 File Offset: 0x004DDC57
		public static Offset<IElementalAbilityConfig> EndIElementalAbilityConfig(FlatBufferBuilder builder)
		{
			return new Offset<IElementalAbilityConfig>(builder.EndTable());
		}

		// Token: 0x06023702 RID: 145154 RVA: 0x004DFA64 File Offset: 0x004DDC64
		public IElementalAbilityConfigT UnPack()
		{
			IElementalAbilityConfigT elementalAbilityConfigT = new IElementalAbilityConfigT();
			this.UnPackTo(elementalAbilityConfigT);
			return elementalAbilityConfigT;
		}

		// Token: 0x06023703 RID: 145155 RVA: 0x004DFA80 File Offset: 0x004DDC80
		public void UnPackTo(IElementalAbilityConfigT _o)
		{
			_o.ElementalType = this.ElementalType;
			_o.IsInitialActive = this.IsInitialActive;
			_o.Range = new TTriggerShapeUnion();
			_o.Range.Type = this.RangeType;
			switch (this.RangeType)
			{
			case TTriggerShape.IActorCollisionTriggerShape:
				_o.Range.Value = ((this.Range<IActorCollisionTriggerShape>() != null) ? this.Range<IActorCollisionTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IActorRefVolume:
				_o.Range.Value = ((this.Range<IActorRefVolume>() != null) ? this.Range<IActorRefVolume>().Value.UnPack() : null);
				break;
			case TTriggerShape.IBoxTriggerShape:
				_o.Range.Value = ((this.Range<IBoxTriggerShape>() != null) ? this.Range<IBoxTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.ICombinationTriggerShape:
				_o.Range.Value = ((this.Range<ICombinationTriggerShape>() != null) ? this.Range<ICombinationTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IConeTriggerShape:
				_o.Range.Value = ((this.Range<IConeTriggerShape>() != null) ? this.Range<IConeTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.ICylinderTriggerShape:
				_o.Range.Value = ((this.Range<ICylinderTriggerShape>() != null) ? this.Range<ICylinderTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IHollowCylinderTriggerShape:
				_o.Range.Value = ((this.Range<IHollowCylinderTriggerShape>() != null) ? this.Range<IHollowCylinderTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IHollowSphereTriggerShape:
				_o.Range.Value = ((this.Range<IHollowSphereTriggerShape>() != null) ? this.Range<IHollowSphereTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.ISphereTriggerShape:
				_o.Range.Value = ((this.Range<ISphereTriggerShape>() != null) ? this.Range<ISphereTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.ISpotlightTriggerShape:
				_o.Range.Value = ((this.Range<ISpotlightTriggerShape>() != null) ? this.Range<ISpotlightTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IVolumeTriggerShape:
				_o.Range.Value = ((this.Range<IVolumeTriggerShape>() != null) ? this.Range<IVolumeTriggerShape>().Value.UnPack() : null);
				break;
			}
			_o.IsEnableEnvEffect = this.IsEnableEnvEffect;
			_o.StateEnableConfigs = new List<IStateElementalEnableConfigT>();
			for (int i = 0; i < this.StateEnableConfigsLength; i++)
			{
				_o.StateEnableConfigs.Add((this.StateEnableConfigs(i) != null) ? this.StateEnableConfigs(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023704 RID: 145156 RVA: 0x004DFDF8 File Offset: 0x004DDFF8
		public static Offset<IElementalAbilityConfig> Pack(FlatBufferBuilder builder, IElementalAbilityConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalAbilityConfig>);
			}
			TTriggerShape range_type = (_o.Range == null) ? TTriggerShape.NONE : _o.Range.Type;
			int rangeOffset = (_o.Range == null) ? 0 : TTriggerShapeUnion.Pack(builder, _o.Range);
			VectorOffset stateEnableConfigsOffset = default(VectorOffset);
			if (_o.StateEnableConfigs != null)
			{
				Offset<IStateElementalEnableConfig>[] array = new Offset<IStateElementalEnableConfig>[_o.StateEnableConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IStateElementalEnableConfig.Pack(builder, _o.StateEnableConfigs[i]);
				}
				stateEnableConfigsOffset = IElementalAbilityConfig.CreateStateEnableConfigsVector(builder, array);
			}
			return IElementalAbilityConfig.CreateIElementalAbilityConfig(builder, _o.ElementalType, _o.IsInitialActive, range_type, rangeOffset, _o.IsEnableEnvEffect, stateEnableConfigsOffset, _o.NullMask);
		}

		// Token: 0x0400ED94 RID: 60820
		private Table __p;
	}
}
