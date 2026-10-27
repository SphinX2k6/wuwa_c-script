using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005123 RID: 20771
	public struct IElementalAbilityConfig : IFlatbufferObject
	{
		// Token: 0x1700974E RID: 38734
		// (get) Token: 0x06021786 RID: 137094 RVA: 0x004A55D1 File Offset: 0x004A37D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021787 RID: 137095 RVA: 0x004A55DE File Offset: 0x004A37DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021788 RID: 137096 RVA: 0x004A55E8 File Offset: 0x004A37E8
		public static IElementalAbilityConfig GetRootAsIElementalAbilityConfig(ByteBuffer _bb)
		{
			return IElementalAbilityConfig.GetRootAsIElementalAbilityConfig(_bb, default(IElementalAbilityConfig));
		}

		// Token: 0x06021789 RID: 137097 RVA: 0x004A5604 File Offset: 0x004A3804
		public static IElementalAbilityConfig GetRootAsIElementalAbilityConfig(ByteBuffer _bb, IElementalAbilityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602178A RID: 137098 RVA: 0x004A5621 File Offset: 0x004A3821
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602178B RID: 137099 RVA: 0x004A5630 File Offset: 0x004A3830
		public IElementalAbilityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700974F RID: 38735
		// (get) Token: 0x0602178C RID: 137100 RVA: 0x004A5640 File Offset: 0x004A3840
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

		// Token: 0x17009750 RID: 38736
		// (get) Token: 0x0602178D RID: 137101 RVA: 0x004A567C File Offset: 0x004A387C
		public bool IsInitialActive
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009751 RID: 38737
		// (get) Token: 0x0602178E RID: 137102 RVA: 0x004A56BC File Offset: 0x004A38BC
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

		// Token: 0x0602178F RID: 137103 RVA: 0x004A56F8 File Offset: 0x004A38F8
		public TTable? Range<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06021790 RID: 137104 RVA: 0x004A5740 File Offset: 0x004A3940
		public IActorCollisionTriggerShape RangeAsIActorCollisionTriggerShape()
		{
			return this.Range<IActorCollisionTriggerShape>().Value;
		}

		// Token: 0x06021791 RID: 137105 RVA: 0x004A575C File Offset: 0x004A395C
		public IActorRefVolume RangeAsIActorRefVolume()
		{
			return this.Range<IActorRefVolume>().Value;
		}

		// Token: 0x06021792 RID: 137106 RVA: 0x004A5778 File Offset: 0x004A3978
		public IBoxTriggerShape RangeAsIBoxTriggerShape()
		{
			return this.Range<IBoxTriggerShape>().Value;
		}

		// Token: 0x06021793 RID: 137107 RVA: 0x004A5794 File Offset: 0x004A3994
		public ICombinationTriggerShape RangeAsICombinationTriggerShape()
		{
			return this.Range<ICombinationTriggerShape>().Value;
		}

		// Token: 0x06021794 RID: 137108 RVA: 0x004A57B0 File Offset: 0x004A39B0
		public IConeTriggerShape RangeAsIConeTriggerShape()
		{
			return this.Range<IConeTriggerShape>().Value;
		}

		// Token: 0x06021795 RID: 137109 RVA: 0x004A57CC File Offset: 0x004A39CC
		public ICylinderTriggerShape RangeAsICylinderTriggerShape()
		{
			return this.Range<ICylinderTriggerShape>().Value;
		}

		// Token: 0x06021796 RID: 137110 RVA: 0x004A57E8 File Offset: 0x004A39E8
		public IHollowCylinderTriggerShape RangeAsIHollowCylinderTriggerShape()
		{
			return this.Range<IHollowCylinderTriggerShape>().Value;
		}

		// Token: 0x06021797 RID: 137111 RVA: 0x004A5804 File Offset: 0x004A3A04
		public IHollowSphereTriggerShape RangeAsIHollowSphereTriggerShape()
		{
			return this.Range<IHollowSphereTriggerShape>().Value;
		}

		// Token: 0x06021798 RID: 137112 RVA: 0x004A5820 File Offset: 0x004A3A20
		public ISphereTriggerShape RangeAsISphereTriggerShape()
		{
			return this.Range<ISphereTriggerShape>().Value;
		}

		// Token: 0x06021799 RID: 137113 RVA: 0x004A583C File Offset: 0x004A3A3C
		public ISpotlightTriggerShape RangeAsISpotlightTriggerShape()
		{
			return this.Range<ISpotlightTriggerShape>().Value;
		}

		// Token: 0x0602179A RID: 137114 RVA: 0x004A5858 File Offset: 0x004A3A58
		public IVolumeTriggerShape RangeAsIVolumeTriggerShape()
		{
			return this.Range<IVolumeTriggerShape>().Value;
		}

		// Token: 0x17009752 RID: 38738
		// (get) Token: 0x0602179B RID: 137115 RVA: 0x004A5874 File Offset: 0x004A3A74
		public bool IsEnableEnvEffect
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602179C RID: 137116 RVA: 0x004A58B4 File Offset: 0x004A3AB4
		public IStateElementalEnableConfig? StateEnableConfigs(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IStateElementalEnableConfig?(default(IStateElementalEnableConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009753 RID: 38739
		// (get) Token: 0x0602179D RID: 137117 RVA: 0x004A5918 File Offset: 0x004A3B18
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

		// Token: 0x17009754 RID: 38740
		// (get) Token: 0x0602179E RID: 137118 RVA: 0x004A5944 File Offset: 0x004A3B44
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

		// Token: 0x0602179F RID: 137119 RVA: 0x004A5984 File Offset: 0x004A3B84
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

		// Token: 0x060217A0 RID: 137120 RVA: 0x004A59D3 File Offset: 0x004A3BD3
		public static void StartIElementalAbilityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060217A1 RID: 137121 RVA: 0x004A59DC File Offset: 0x004A3BDC
		public static void AddElementalType(FlatBufferBuilder builder, EElementalType elementalType)
		{
			builder.AddByte(0, (byte)elementalType, 0);
		}

		// Token: 0x060217A2 RID: 137122 RVA: 0x004A59E7 File Offset: 0x004A3BE7
		public static void AddIsInitialActive(FlatBufferBuilder builder, bool isInitialActive)
		{
			builder.AddBool(1, isInitialActive, false);
		}

		// Token: 0x060217A3 RID: 137123 RVA: 0x004A59F2 File Offset: 0x004A3BF2
		public static void AddRangeType(FlatBufferBuilder builder, TTriggerShape rangeType)
		{
			builder.AddByte(2, (byte)rangeType, 0);
		}

		// Token: 0x060217A4 RID: 137124 RVA: 0x004A59FD File Offset: 0x004A3BFD
		public static void AddRange(FlatBufferBuilder builder, int rangeOffset)
		{
			builder.AddOffset(3, rangeOffset, 0);
		}

		// Token: 0x060217A5 RID: 137125 RVA: 0x004A5A08 File Offset: 0x004A3C08
		public static void AddIsEnableEnvEffect(FlatBufferBuilder builder, bool isEnableEnvEffect)
		{
			builder.AddBool(4, isEnableEnvEffect, false);
		}

		// Token: 0x060217A6 RID: 137126 RVA: 0x004A5A13 File Offset: 0x004A3C13
		public static void AddStateEnableConfigs(FlatBufferBuilder builder, VectorOffset stateEnableConfigsOffset)
		{
			builder.AddOffset(5, stateEnableConfigsOffset.Value, 0);
		}

		// Token: 0x060217A7 RID: 137127 RVA: 0x004A5A24 File Offset: 0x004A3C24
		public static VectorOffset CreateStateEnableConfigsVector(FlatBufferBuilder builder, Offset<IStateElementalEnableConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060217A8 RID: 137128 RVA: 0x004A5A64 File Offset: 0x004A3C64
		public static VectorOffset CreateStateEnableConfigsVectorBlock(FlatBufferBuilder builder, Offset<IStateElementalEnableConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IStateElementalEnableConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060217A9 RID: 137129 RVA: 0x004A5A7E File Offset: 0x004A3C7E
		public static VectorOffset CreateStateEnableConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IStateElementalEnableConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IStateElementalEnableConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060217AA RID: 137130 RVA: 0x004A5A9C File Offset: 0x004A3C9C
		public static VectorOffset CreateStateEnableConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IStateElementalEnableConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060217AB RID: 137131 RVA: 0x004A5AB5 File Offset: 0x004A3CB5
		public static void StartStateEnableConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060217AC RID: 137132 RVA: 0x004A5AC0 File Offset: 0x004A3CC0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060217AD RID: 137133 RVA: 0x004A5ACB File Offset: 0x004A3CCB
		public static Offset<IElementalAbilityConfig> EndIElementalAbilityConfig(FlatBufferBuilder builder)
		{
			return new Offset<IElementalAbilityConfig>(builder.EndTable());
		}

		// Token: 0x060217AE RID: 137134 RVA: 0x004A5AD8 File Offset: 0x004A3CD8
		public IElementalAbilityConfigT UnPack()
		{
			IElementalAbilityConfigT elementalAbilityConfigT = new IElementalAbilityConfigT();
			this.UnPackTo(elementalAbilityConfigT);
			return elementalAbilityConfigT;
		}

		// Token: 0x060217AF RID: 137135 RVA: 0x004A5AF4 File Offset: 0x004A3CF4
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

		// Token: 0x060217B0 RID: 137136 RVA: 0x004A5E6C File Offset: 0x004A406C
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

		// Token: 0x0400E197 RID: 57751
		private Table __p;
	}
}
