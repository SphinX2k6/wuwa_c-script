using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005129 RID: 20777
	public struct IElementalEffectComponent : IFlatbufferObject
	{
		// Token: 0x1700976C RID: 38764
		// (get) Token: 0x060217F9 RID: 137209 RVA: 0x004A6946 File Offset: 0x004A4B46
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060217FA RID: 137210 RVA: 0x004A6953 File Offset: 0x004A4B53
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060217FB RID: 137211 RVA: 0x004A695C File Offset: 0x004A4B5C
		public static IElementalEffectComponent GetRootAsIElementalEffectComponent(ByteBuffer _bb)
		{
			return IElementalEffectComponent.GetRootAsIElementalEffectComponent(_bb, default(IElementalEffectComponent));
		}

		// Token: 0x060217FC RID: 137212 RVA: 0x004A6978 File Offset: 0x004A4B78
		public static IElementalEffectComponent GetRootAsIElementalEffectComponent(ByteBuffer _bb, IElementalEffectComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060217FD RID: 137213 RVA: 0x004A6995 File Offset: 0x004A4B95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060217FE RID: 137214 RVA: 0x004A69A4 File Offset: 0x004A4BA4
		public IElementalEffectComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700976D RID: 38765
		// (get) Token: 0x060217FF RID: 137215 RVA: 0x004A69B4 File Offset: 0x004A4BB4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700976E RID: 38766
		// (get) Token: 0x06021800 RID: 137216 RVA: 0x004A69F4 File Offset: 0x004A4BF4
		public TElementalMatchConfig MatchConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TElementalMatchConfig.NONE;
				}
				return (TElementalMatchConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021801 RID: 137217 RVA: 0x004A6A30 File Offset: 0x004A4C30
		public TTable? MatchConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06021802 RID: 137218 RVA: 0x004A6A74 File Offset: 0x004A4C74
		public IFireElementalMatch MatchConfigAsIFireElementalMatch()
		{
			return this.MatchConfig<IFireElementalMatch>().Value;
		}

		// Token: 0x06021803 RID: 137219 RVA: 0x004A6A90 File Offset: 0x004A4C90
		public IWaterElementalMatch MatchConfigAsIWaterElementalMatch()
		{
			return this.MatchConfig<IWaterElementalMatch>().Value;
		}

		// Token: 0x06021804 RID: 137220 RVA: 0x004A6AAC File Offset: 0x004A4CAC
		public IWoodElementalMatch MatchConfigAsIWoodElementalMatch()
		{
			return this.MatchConfig<IWoodElementalMatch>().Value;
		}

		// Token: 0x1700976F RID: 38767
		// (get) Token: 0x06021805 RID: 137221 RVA: 0x004A6AC8 File Offset: 0x004A4CC8
		public TElementalRange RangeType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TElementalRange.NONE;
				}
				return (TElementalRange)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021806 RID: 137222 RVA: 0x004A6B08 File Offset: 0x004A4D08
		public TTable? Range<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06021807 RID: 137223 RVA: 0x004A6B50 File Offset: 0x004A4D50
		public IBaseShapeElementalRange RangeAsIBaseShapeElementalRange()
		{
			return this.Range<IBaseShapeElementalRange>().Value;
		}

		// Token: 0x06021808 RID: 137224 RVA: 0x004A6B6C File Offset: 0x004A4D6C
		public ITransportBoxElementalRange RangeAsITransportBoxElementalRange()
		{
			return this.Range<ITransportBoxElementalRange>().Value;
		}

		// Token: 0x06021809 RID: 137225 RVA: 0x004A6B88 File Offset: 0x004A4D88
		public IElementalMatchActions? OnActiveEffectActions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IElementalMatchActions?(default(IElementalMatchActions).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009770 RID: 38768
		// (get) Token: 0x0602180A RID: 137226 RVA: 0x004A6BEC File Offset: 0x004A4DEC
		public int OnActiveEffectActionsLength
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

		// Token: 0x0602180B RID: 137227 RVA: 0x004A6C18 File Offset: 0x004A4E18
		public IElementalMatchActions? OnLoseEffectActions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IElementalMatchActions?(default(IElementalMatchActions).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009771 RID: 38769
		// (get) Token: 0x0602180C RID: 137228 RVA: 0x004A6C7C File Offset: 0x004A4E7C
		public int OnLoseEffectActionsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009772 RID: 38770
		// (get) Token: 0x0602180D RID: 137229 RVA: 0x004A6CA8 File Offset: 0x004A4EA8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602180E RID: 137230 RVA: 0x004A6CE8 File Offset: 0x004A4EE8
		public static Offset<IElementalEffectComponent> CreateIElementalEffectComponent(FlatBufferBuilder builder, bool Disabled = false, TElementalMatchConfig MatchConfig_type = TElementalMatchConfig.NONE, int MatchConfigOffset = 0, TElementalRange Range_type = TElementalRange.NONE, int RangeOffset = 0, VectorOffset OnActiveEffectActionsOffset = default(VectorOffset), VectorOffset OnLoseEffectActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(8);
			IElementalEffectComponent.AddOnLoseEffectActions(builder, OnLoseEffectActionsOffset);
			IElementalEffectComponent.AddOnActiveEffectActions(builder, OnActiveEffectActionsOffset);
			IElementalEffectComponent.AddRange(builder, RangeOffset);
			IElementalEffectComponent.AddMatchConfig(builder, MatchConfigOffset);
			IElementalEffectComponent.AddNullMask(builder, NullMask);
			IElementalEffectComponent.AddRangeType(builder, Range_type);
			IElementalEffectComponent.AddMatchConfigType(builder, MatchConfig_type);
			IElementalEffectComponent.AddDisabled(builder, Disabled);
			return IElementalEffectComponent.EndIElementalEffectComponent(builder);
		}

		// Token: 0x0602180F RID: 137231 RVA: 0x004A6D3F File Offset: 0x004A4F3F
		public static void StartIElementalEffectComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06021810 RID: 137232 RVA: 0x004A6D48 File Offset: 0x004A4F48
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021811 RID: 137233 RVA: 0x004A6D53 File Offset: 0x004A4F53
		public static void AddMatchConfigType(FlatBufferBuilder builder, TElementalMatchConfig matchConfigType)
		{
			builder.AddByte(1, (byte)matchConfigType, 0);
		}

		// Token: 0x06021812 RID: 137234 RVA: 0x004A6D5E File Offset: 0x004A4F5E
		public static void AddMatchConfig(FlatBufferBuilder builder, int matchConfigOffset)
		{
			builder.AddOffset(2, matchConfigOffset, 0);
		}

		// Token: 0x06021813 RID: 137235 RVA: 0x004A6D69 File Offset: 0x004A4F69
		public static void AddRangeType(FlatBufferBuilder builder, TElementalRange rangeType)
		{
			builder.AddByte(3, (byte)rangeType, 0);
		}

		// Token: 0x06021814 RID: 137236 RVA: 0x004A6D74 File Offset: 0x004A4F74
		public static void AddRange(FlatBufferBuilder builder, int rangeOffset)
		{
			builder.AddOffset(4, rangeOffset, 0);
		}

		// Token: 0x06021815 RID: 137237 RVA: 0x004A6D7F File Offset: 0x004A4F7F
		public static void AddOnActiveEffectActions(FlatBufferBuilder builder, VectorOffset onActiveEffectActionsOffset)
		{
			builder.AddOffset(5, onActiveEffectActionsOffset.Value, 0);
		}

		// Token: 0x06021816 RID: 137238 RVA: 0x004A6D90 File Offset: 0x004A4F90
		public static VectorOffset CreateOnActiveEffectActionsVector(FlatBufferBuilder builder, Offset<IElementalMatchActions>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021817 RID: 137239 RVA: 0x004A6DD0 File Offset: 0x004A4FD0
		public static VectorOffset CreateOnActiveEffectActionsVectorBlock(FlatBufferBuilder builder, Offset<IElementalMatchActions>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IElementalMatchActions>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021818 RID: 137240 RVA: 0x004A6DEA File Offset: 0x004A4FEA
		public static VectorOffset CreateOnActiveEffectActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IElementalMatchActions>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IElementalMatchActions>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021819 RID: 137241 RVA: 0x004A6E08 File Offset: 0x004A5008
		public static VectorOffset CreateOnActiveEffectActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IElementalMatchActions>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602181A RID: 137242 RVA: 0x004A6E21 File Offset: 0x004A5021
		public static void StartOnActiveEffectActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602181B RID: 137243 RVA: 0x004A6E2C File Offset: 0x004A502C
		public static void AddOnLoseEffectActions(FlatBufferBuilder builder, VectorOffset onLoseEffectActionsOffset)
		{
			builder.AddOffset(6, onLoseEffectActionsOffset.Value, 0);
		}

		// Token: 0x0602181C RID: 137244 RVA: 0x004A6E3C File Offset: 0x004A503C
		public static VectorOffset CreateOnLoseEffectActionsVector(FlatBufferBuilder builder, Offset<IElementalMatchActions>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602181D RID: 137245 RVA: 0x004A6E7C File Offset: 0x004A507C
		public static VectorOffset CreateOnLoseEffectActionsVectorBlock(FlatBufferBuilder builder, Offset<IElementalMatchActions>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IElementalMatchActions>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602181E RID: 137246 RVA: 0x004A6E96 File Offset: 0x004A5096
		public static VectorOffset CreateOnLoseEffectActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IElementalMatchActions>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IElementalMatchActions>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602181F RID: 137247 RVA: 0x004A6EB4 File Offset: 0x004A50B4
		public static VectorOffset CreateOnLoseEffectActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IElementalMatchActions>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021820 RID: 137248 RVA: 0x004A6ECD File Offset: 0x004A50CD
		public static void StartOnLoseEffectActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021821 RID: 137249 RVA: 0x004A6ED8 File Offset: 0x004A50D8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06021822 RID: 137250 RVA: 0x004A6EE3 File Offset: 0x004A50E3
		public static Offset<IElementalEffectComponent> EndIElementalEffectComponent(FlatBufferBuilder builder)
		{
			return new Offset<IElementalEffectComponent>(builder.EndTable());
		}

		// Token: 0x06021823 RID: 137251 RVA: 0x004A6EF0 File Offset: 0x004A50F0
		public IElementalEffectComponentT UnPack()
		{
			IElementalEffectComponentT elementalEffectComponentT = new IElementalEffectComponentT();
			this.UnPackTo(elementalEffectComponentT);
			return elementalEffectComponentT;
		}

		// Token: 0x06021824 RID: 137252 RVA: 0x004A6F0C File Offset: 0x004A510C
		public void UnPackTo(IElementalEffectComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.MatchConfig = new TElementalMatchConfigUnion();
			_o.MatchConfig.Type = this.MatchConfigType;
			switch (this.MatchConfigType)
			{
			case TElementalMatchConfig.IFireElementalMatch:
				_o.MatchConfig.Value = ((this.MatchConfig<IFireElementalMatch>() != null) ? this.MatchConfig<IFireElementalMatch>().Value.UnPack() : null);
				break;
			case TElementalMatchConfig.IWaterElementalMatch:
				_o.MatchConfig.Value = ((this.MatchConfig<IWaterElementalMatch>() != null) ? this.MatchConfig<IWaterElementalMatch>().Value.UnPack() : null);
				break;
			case TElementalMatchConfig.IWoodElementalMatch:
				_o.MatchConfig.Value = ((this.MatchConfig<IWoodElementalMatch>() != null) ? this.MatchConfig<IWoodElementalMatch>().Value.UnPack() : null);
				break;
			}
			_o.Range = new TElementalRangeUnion();
			_o.Range.Type = this.RangeType;
			TElementalRange rangeType = this.RangeType;
			if (rangeType != TElementalRange.IBaseShapeElementalRange)
			{
				if (rangeType == TElementalRange.ITransportBoxElementalRange)
				{
					_o.Range.Value = ((this.Range<ITransportBoxElementalRange>() != null) ? this.Range<ITransportBoxElementalRange>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Range.Value = ((this.Range<IBaseShapeElementalRange>() != null) ? this.Range<IBaseShapeElementalRange>().Value.UnPack() : null);
			}
			_o.OnActiveEffectActions = new List<IElementalMatchActionsT>();
			for (int i = 0; i < this.OnActiveEffectActionsLength; i++)
			{
				_o.OnActiveEffectActions.Add((this.OnActiveEffectActions(i) != null) ? this.OnActiveEffectActions(i).Value.UnPack() : null);
			}
			_o.OnLoseEffectActions = new List<IElementalMatchActionsT>();
			for (int j = 0; j < this.OnLoseEffectActionsLength; j++)
			{
				_o.OnLoseEffectActions.Add((this.OnLoseEffectActions(j) != null) ? this.OnLoseEffectActions(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021825 RID: 137253 RVA: 0x004A7168 File Offset: 0x004A5368
		public static Offset<IElementalEffectComponent> Pack(FlatBufferBuilder builder, IElementalEffectComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalEffectComponent>);
			}
			TElementalMatchConfig matchConfig_type = (_o.MatchConfig == null) ? TElementalMatchConfig.NONE : _o.MatchConfig.Type;
			int matchConfigOffset = (_o.MatchConfig == null) ? 0 : TElementalMatchConfigUnion.Pack(builder, _o.MatchConfig);
			TElementalRange range_type = (_o.Range == null) ? TElementalRange.NONE : _o.Range.Type;
			int rangeOffset = (_o.Range == null) ? 0 : TElementalRangeUnion.Pack(builder, _o.Range);
			VectorOffset onActiveEffectActionsOffset = default(VectorOffset);
			if (_o.OnActiveEffectActions != null)
			{
				Offset<IElementalMatchActions>[] array = new Offset<IElementalMatchActions>[_o.OnActiveEffectActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IElementalMatchActions.Pack(builder, _o.OnActiveEffectActions[i]);
				}
				onActiveEffectActionsOffset = IElementalEffectComponent.CreateOnActiveEffectActionsVector(builder, array);
			}
			VectorOffset onLoseEffectActionsOffset = default(VectorOffset);
			if (_o.OnLoseEffectActions != null)
			{
				Offset<IElementalMatchActions>[] array2 = new Offset<IElementalMatchActions>[_o.OnLoseEffectActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IElementalMatchActions.Pack(builder, _o.OnLoseEffectActions[j]);
				}
				onLoseEffectActionsOffset = IElementalEffectComponent.CreateOnLoseEffectActionsVector(builder, array2);
			}
			return IElementalEffectComponent.CreateIElementalEffectComponent(builder, _o.Disabled, matchConfig_type, matchConfigOffset, range_type, rangeOffset, onActiveEffectActionsOffset, onLoseEffectActionsOffset, _o.NullMask);
		}

		// Token: 0x0400E1A7 RID: 57767
		private Table __p;
	}
}
