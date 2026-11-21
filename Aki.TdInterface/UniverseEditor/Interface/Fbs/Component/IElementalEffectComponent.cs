using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200568E RID: 22158
	public struct IElementalEffectComponent : IFlatbufferObject
	{
		// Token: 0x17009F59 RID: 40793
		// (get) Token: 0x0602374D RID: 145229 RVA: 0x004E08D2 File Offset: 0x004DEAD2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602374E RID: 145230 RVA: 0x004E08DF File Offset: 0x004DEADF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602374F RID: 145231 RVA: 0x004E08E8 File Offset: 0x004DEAE8
		public static IElementalEffectComponent GetRootAsIElementalEffectComponent(ByteBuffer _bb)
		{
			return IElementalEffectComponent.GetRootAsIElementalEffectComponent(_bb, default(IElementalEffectComponent));
		}

		// Token: 0x06023750 RID: 145232 RVA: 0x004E0904 File Offset: 0x004DEB04
		public static IElementalEffectComponent GetRootAsIElementalEffectComponent(ByteBuffer _bb, IElementalEffectComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023751 RID: 145233 RVA: 0x004E0921 File Offset: 0x004DEB21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023752 RID: 145234 RVA: 0x004E0930 File Offset: 0x004DEB30
		public IElementalEffectComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F5A RID: 40794
		// (get) Token: 0x06023753 RID: 145235 RVA: 0x004E0940 File Offset: 0x004DEB40
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009F5B RID: 40795
		// (get) Token: 0x06023754 RID: 145236 RVA: 0x004E0980 File Offset: 0x004DEB80
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

		// Token: 0x06023755 RID: 145237 RVA: 0x004E09BC File Offset: 0x004DEBBC
		public TTable? MatchConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06023756 RID: 145238 RVA: 0x004E0A00 File Offset: 0x004DEC00
		public IFireElementalMatch MatchConfigAsIFireElementalMatch()
		{
			return this.MatchConfig<IFireElementalMatch>().Value;
		}

		// Token: 0x06023757 RID: 145239 RVA: 0x004E0A1C File Offset: 0x004DEC1C
		public IWaterElementalMatch MatchConfigAsIWaterElementalMatch()
		{
			return this.MatchConfig<IWaterElementalMatch>().Value;
		}

		// Token: 0x06023758 RID: 145240 RVA: 0x004E0A38 File Offset: 0x004DEC38
		public IWoodElementalMatch MatchConfigAsIWoodElementalMatch()
		{
			return this.MatchConfig<IWoodElementalMatch>().Value;
		}

		// Token: 0x17009F5C RID: 40796
		// (get) Token: 0x06023759 RID: 145241 RVA: 0x004E0A54 File Offset: 0x004DEC54
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

		// Token: 0x0602375A RID: 145242 RVA: 0x004E0A94 File Offset: 0x004DEC94
		public TTable? Range<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602375B RID: 145243 RVA: 0x004E0ADC File Offset: 0x004DECDC
		public IBaseShapeElementalRange RangeAsIBaseShapeElementalRange()
		{
			return this.Range<IBaseShapeElementalRange>().Value;
		}

		// Token: 0x0602375C RID: 145244 RVA: 0x004E0AF8 File Offset: 0x004DECF8
		public ITransportBoxElementalRange RangeAsITransportBoxElementalRange()
		{
			return this.Range<ITransportBoxElementalRange>().Value;
		}

		// Token: 0x0602375D RID: 145245 RVA: 0x004E0B14 File Offset: 0x004DED14
		public IElementalMatchActions? OnActiveEffectActions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IElementalMatchActions?(default(IElementalMatchActions).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009F5D RID: 40797
		// (get) Token: 0x0602375E RID: 145246 RVA: 0x004E0B78 File Offset: 0x004DED78
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

		// Token: 0x0602375F RID: 145247 RVA: 0x004E0BA4 File Offset: 0x004DEDA4
		public IElementalMatchActions? OnLoseEffectActions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IElementalMatchActions?(default(IElementalMatchActions).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009F5E RID: 40798
		// (get) Token: 0x06023760 RID: 145248 RVA: 0x004E0C08 File Offset: 0x004DEE08
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

		// Token: 0x17009F5F RID: 40799
		// (get) Token: 0x06023761 RID: 145249 RVA: 0x004E0C34 File Offset: 0x004DEE34
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

		// Token: 0x06023762 RID: 145250 RVA: 0x004E0C74 File Offset: 0x004DEE74
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

		// Token: 0x06023763 RID: 145251 RVA: 0x004E0CCB File Offset: 0x004DEECB
		public static void StartIElementalEffectComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06023764 RID: 145252 RVA: 0x004E0CD4 File Offset: 0x004DEED4
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023765 RID: 145253 RVA: 0x004E0CDF File Offset: 0x004DEEDF
		public static void AddMatchConfigType(FlatBufferBuilder builder, TElementalMatchConfig matchConfigType)
		{
			builder.AddByte(1, (byte)matchConfigType, 0);
		}

		// Token: 0x06023766 RID: 145254 RVA: 0x004E0CEA File Offset: 0x004DEEEA
		public static void AddMatchConfig(FlatBufferBuilder builder, int matchConfigOffset)
		{
			builder.AddOffset(2, matchConfigOffset, 0);
		}

		// Token: 0x06023767 RID: 145255 RVA: 0x004E0CF5 File Offset: 0x004DEEF5
		public static void AddRangeType(FlatBufferBuilder builder, TElementalRange rangeType)
		{
			builder.AddByte(3, (byte)rangeType, 0);
		}

		// Token: 0x06023768 RID: 145256 RVA: 0x004E0D00 File Offset: 0x004DEF00
		public static void AddRange(FlatBufferBuilder builder, int rangeOffset)
		{
			builder.AddOffset(4, rangeOffset, 0);
		}

		// Token: 0x06023769 RID: 145257 RVA: 0x004E0D0B File Offset: 0x004DEF0B
		public static void AddOnActiveEffectActions(FlatBufferBuilder builder, VectorOffset onActiveEffectActionsOffset)
		{
			builder.AddOffset(5, onActiveEffectActionsOffset.Value, 0);
		}

		// Token: 0x0602376A RID: 145258 RVA: 0x004E0D1C File Offset: 0x004DEF1C
		public static VectorOffset CreateOnActiveEffectActionsVector(FlatBufferBuilder builder, Offset<IElementalMatchActions>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602376B RID: 145259 RVA: 0x004E0D5C File Offset: 0x004DEF5C
		public static VectorOffset CreateOnActiveEffectActionsVectorBlock(FlatBufferBuilder builder, Offset<IElementalMatchActions>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IElementalMatchActions>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602376C RID: 145260 RVA: 0x004E0D76 File Offset: 0x004DEF76
		public static VectorOffset CreateOnActiveEffectActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IElementalMatchActions>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IElementalMatchActions>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602376D RID: 145261 RVA: 0x004E0D94 File Offset: 0x004DEF94
		public static VectorOffset CreateOnActiveEffectActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IElementalMatchActions>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602376E RID: 145262 RVA: 0x004E0DAD File Offset: 0x004DEFAD
		public static void StartOnActiveEffectActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602376F RID: 145263 RVA: 0x004E0DB8 File Offset: 0x004DEFB8
		public static void AddOnLoseEffectActions(FlatBufferBuilder builder, VectorOffset onLoseEffectActionsOffset)
		{
			builder.AddOffset(6, onLoseEffectActionsOffset.Value, 0);
		}

		// Token: 0x06023770 RID: 145264 RVA: 0x004E0DC8 File Offset: 0x004DEFC8
		public static VectorOffset CreateOnLoseEffectActionsVector(FlatBufferBuilder builder, Offset<IElementalMatchActions>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023771 RID: 145265 RVA: 0x004E0E08 File Offset: 0x004DF008
		public static VectorOffset CreateOnLoseEffectActionsVectorBlock(FlatBufferBuilder builder, Offset<IElementalMatchActions>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IElementalMatchActions>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023772 RID: 145266 RVA: 0x004E0E22 File Offset: 0x004DF022
		public static VectorOffset CreateOnLoseEffectActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IElementalMatchActions>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IElementalMatchActions>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023773 RID: 145267 RVA: 0x004E0E40 File Offset: 0x004DF040
		public static VectorOffset CreateOnLoseEffectActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IElementalMatchActions>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023774 RID: 145268 RVA: 0x004E0E59 File Offset: 0x004DF059
		public static void StartOnLoseEffectActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023775 RID: 145269 RVA: 0x004E0E64 File Offset: 0x004DF064
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06023776 RID: 145270 RVA: 0x004E0E6F File Offset: 0x004DF06F
		public static Offset<IElementalEffectComponent> EndIElementalEffectComponent(FlatBufferBuilder builder)
		{
			return new Offset<IElementalEffectComponent>(builder.EndTable());
		}

		// Token: 0x06023777 RID: 145271 RVA: 0x004E0E7C File Offset: 0x004DF07C
		public IElementalEffectComponentT UnPack()
		{
			IElementalEffectComponentT elementalEffectComponentT = new IElementalEffectComponentT();
			this.UnPackTo(elementalEffectComponentT);
			return elementalEffectComponentT;
		}

		// Token: 0x06023778 RID: 145272 RVA: 0x004E0E98 File Offset: 0x004DF098
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

		// Token: 0x06023779 RID: 145273 RVA: 0x004E10F4 File Offset: 0x004DF2F4
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

		// Token: 0x0400EDA4 RID: 60836
		private Table __p;
	}
}
