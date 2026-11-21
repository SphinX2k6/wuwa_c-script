using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F8D RID: 24461
	public struct ISplineComponent : IFlatbufferObject
	{
		// Token: 0x1700B520 RID: 46368
		// (get) Token: 0x060291FF RID: 168447 RVA: 0x0059D7F7 File Offset: 0x0059B9F7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029200 RID: 168448 RVA: 0x0059D804 File Offset: 0x0059BA04
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029201 RID: 168449 RVA: 0x0059D80C File Offset: 0x0059BA0C
		public static ISplineComponent GetRootAsISplineComponent(ByteBuffer _bb)
		{
			return ISplineComponent.GetRootAsISplineComponent(_bb, default(ISplineComponent));
		}

		// Token: 0x06029202 RID: 168450 RVA: 0x0059D828 File Offset: 0x0059BA28
		public static ISplineComponent GetRootAsISplineComponent(ByteBuffer _bb, ISplineComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029203 RID: 168451 RVA: 0x0059D845 File Offset: 0x0059BA45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029204 RID: 168452 RVA: 0x0059D854 File Offset: 0x0059BA54
		public ISplineComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B521 RID: 46369
		// (get) Token: 0x06029205 RID: 168453 RVA: 0x0059D864 File Offset: 0x0059BA64
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B522 RID: 46370
		// (get) Token: 0x06029206 RID: 168454 RVA: 0x0059D8A4 File Offset: 0x0059BAA4
		public TSplineOption OptionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TSplineOption.NONE;
				}
				return (TSplineOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029207 RID: 168455 RVA: 0x0059D8E0 File Offset: 0x0059BAE0
		public TTable? Option<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06029208 RID: 168456 RVA: 0x0059D924 File Offset: 0x0059BB24
		public IAirPassageSpline OptionAsIAirPassageSpline()
		{
			return this.Option<IAirPassageSpline>().Value;
		}

		// Token: 0x06029209 RID: 168457 RVA: 0x0059D940 File Offset: 0x0059BB40
		public IButterflySpline OptionAsIButterflySpline()
		{
			return this.Option<IButterflySpline>().Value;
		}

		// Token: 0x0602920A RID: 168458 RVA: 0x0059D95C File Offset: 0x0059BB5C
		public ICommonSpline OptionAsICommonSpline()
		{
			return this.Option<ICommonSpline>().Value;
		}

		// Token: 0x0602920B RID: 168459 RVA: 0x0059D978 File Offset: 0x0059BB78
		public IContinuesVariableSpeedMovementSpline OptionAsIContinuesVariableSpeedMovementSpline()
		{
			return this.Option<IContinuesVariableSpeedMovementSpline>().Value;
		}

		// Token: 0x0602920C RID: 168460 RVA: 0x0059D994 File Offset: 0x0059BB94
		public IEffectSpline OptionAsIEffectSpline()
		{
			return this.Option<IEffectSpline>().Value;
		}

		// Token: 0x0602920D RID: 168461 RVA: 0x0059D9B0 File Offset: 0x0059BBB0
		public ILevelAISpline OptionAsILevelAISpline()
		{
			return this.Option<ILevelAISpline>().Value;
		}

		// Token: 0x0602920E RID: 168462 RVA: 0x0059D9CC File Offset: 0x0059BBCC
		public IMotorSlideSpline OptionAsIMotorSlideSpline()
		{
			return this.Option<IMotorSlideSpline>().Value;
		}

		// Token: 0x0602920F RID: 168463 RVA: 0x0059D9E8 File Offset: 0x0059BBE8
		public IParkourSpline OptionAsIParkourSpline()
		{
			return this.Option<IParkourSpline>().Value;
		}

		// Token: 0x06029210 RID: 168464 RVA: 0x0059DA04 File Offset: 0x0059BC04
		public IPatrolSpline OptionAsIPatrolSpline()
		{
			return this.Option<IPatrolSpline>().Value;
		}

		// Token: 0x06029211 RID: 168465 RVA: 0x0059DA20 File Offset: 0x0059BC20
		public IRangeSpline OptionAsIRangeSpline()
		{
			return this.Option<IRangeSpline>().Value;
		}

		// Token: 0x06029212 RID: 168466 RVA: 0x0059DA3C File Offset: 0x0059BC3C
		public ISwordRiderRailSpline OptionAsISwordRiderRailSpline()
		{
			return this.Option<ISwordRiderRailSpline>().Value;
		}

		// Token: 0x06029213 RID: 168467 RVA: 0x0059DA58 File Offset: 0x0059BC58
		public ITimePatrolSpline OptionAsITimePatrolSpline()
		{
			return this.Option<ITimePatrolSpline>().Value;
		}

		// Token: 0x06029214 RID: 168468 RVA: 0x0059DA74 File Offset: 0x0059BC74
		public IWaySpline OptionAsIWaySpline()
		{
			return this.Option<IWaySpline>().Value;
		}

		// Token: 0x1700B523 RID: 46371
		// (get) Token: 0x06029215 RID: 168469 RVA: 0x0059DA90 File Offset: 0x0059BC90
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029216 RID: 168470 RVA: 0x0059DACD File Offset: 0x0059BCCD
		public static Offset<ISplineComponent> CreateISplineComponent(FlatBufferBuilder builder, bool Disabled = false, TSplineOption Option_type = TSplineOption.NONE, int OptionOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISplineComponent.AddOption(builder, OptionOffset);
			ISplineComponent.AddNullMask(builder, NullMask);
			ISplineComponent.AddOptionType(builder, Option_type);
			ISplineComponent.AddDisabled(builder, Disabled);
			return ISplineComponent.EndISplineComponent(builder);
		}

		// Token: 0x06029217 RID: 168471 RVA: 0x0059DAF9 File Offset: 0x0059BCF9
		public static void StartISplineComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06029218 RID: 168472 RVA: 0x0059DB02 File Offset: 0x0059BD02
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06029219 RID: 168473 RVA: 0x0059DB0D File Offset: 0x0059BD0D
		public static void AddOptionType(FlatBufferBuilder builder, TSplineOption optionType)
		{
			builder.AddByte(1, (byte)optionType, 0);
		}

		// Token: 0x0602921A RID: 168474 RVA: 0x0059DB18 File Offset: 0x0059BD18
		public static void AddOption(FlatBufferBuilder builder, int optionOffset)
		{
			builder.AddOffset(2, optionOffset, 0);
		}

		// Token: 0x0602921B RID: 168475 RVA: 0x0059DB23 File Offset: 0x0059BD23
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602921C RID: 168476 RVA: 0x0059DB2E File Offset: 0x0059BD2E
		public static Offset<ISplineComponent> EndISplineComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISplineComponent>(builder.EndTable());
		}

		// Token: 0x0602921D RID: 168477 RVA: 0x0059DB3C File Offset: 0x0059BD3C
		public ISplineComponentT UnPack()
		{
			ISplineComponentT splineComponentT = new ISplineComponentT();
			this.UnPackTo(splineComponentT);
			return splineComponentT;
		}

		// Token: 0x0602921E RID: 168478 RVA: 0x0059DB58 File Offset: 0x0059BD58
		public void UnPackTo(ISplineComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Option = new TSplineOptionUnion();
			_o.Option.Type = this.OptionType;
			switch (this.OptionType)
			{
			case TSplineOption.IAirPassageSpline:
				_o.Option.Value = ((this.Option<IAirPassageSpline>() != null) ? this.Option<IAirPassageSpline>().Value.UnPack() : null);
				break;
			case TSplineOption.IButterflySpline:
				_o.Option.Value = ((this.Option<IButterflySpline>() != null) ? this.Option<IButterflySpline>().Value.UnPack() : null);
				break;
			case TSplineOption.ICommonSpline:
				_o.Option.Value = ((this.Option<ICommonSpline>() != null) ? this.Option<ICommonSpline>().Value.UnPack() : null);
				break;
			case TSplineOption.IContinuesVariableSpeedMovementSpline:
				_o.Option.Value = ((this.Option<IContinuesVariableSpeedMovementSpline>() != null) ? this.Option<IContinuesVariableSpeedMovementSpline>().Value.UnPack() : null);
				break;
			case TSplineOption.IEffectSpline:
				_o.Option.Value = ((this.Option<IEffectSpline>() != null) ? this.Option<IEffectSpline>().Value.UnPack() : null);
				break;
			case TSplineOption.ILevelAISpline:
				_o.Option.Value = ((this.Option<ILevelAISpline>() != null) ? this.Option<ILevelAISpline>().Value.UnPack() : null);
				break;
			case TSplineOption.IMotorSlideSpline:
				_o.Option.Value = ((this.Option<IMotorSlideSpline>() != null) ? this.Option<IMotorSlideSpline>().Value.UnPack() : null);
				break;
			case TSplineOption.IParkourSpline:
				_o.Option.Value = ((this.Option<IParkourSpline>() != null) ? this.Option<IParkourSpline>().Value.UnPack() : null);
				break;
			case TSplineOption.IPatrolSpline:
				_o.Option.Value = ((this.Option<IPatrolSpline>() != null) ? this.Option<IPatrolSpline>().Value.UnPack() : null);
				break;
			case TSplineOption.IRangeSpline:
				_o.Option.Value = ((this.Option<IRangeSpline>() != null) ? this.Option<IRangeSpline>().Value.UnPack() : null);
				break;
			case TSplineOption.ISwordRiderRailSpline:
				_o.Option.Value = ((this.Option<ISwordRiderRailSpline>() != null) ? this.Option<ISwordRiderRailSpline>().Value.UnPack() : null);
				break;
			case TSplineOption.ITimePatrolSpline:
				_o.Option.Value = ((this.Option<ITimePatrolSpline>() != null) ? this.Option<ITimePatrolSpline>().Value.UnPack() : null);
				break;
			case TSplineOption.IWaySpline:
				_o.Option.Value = ((this.Option<IWaySpline>() != null) ? this.Option<IWaySpline>().Value.UnPack() : null);
				break;
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602921F RID: 168479 RVA: 0x0059DEE0 File Offset: 0x0059C0E0
		public static Offset<ISplineComponent> Pack(FlatBufferBuilder builder, ISplineComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISplineComponent>);
			}
			TSplineOption option_type = (_o.Option == null) ? TSplineOption.NONE : _o.Option.Type;
			int optionOffset = (_o.Option == null) ? 0 : TSplineOptionUnion.Pack(builder, _o.Option);
			return ISplineComponent.CreateISplineComponent(builder, _o.Disabled, option_type, optionOffset, _o.NullMask);
		}

		// Token: 0x0400FC65 RID: 64613
		private Table __p;
	}
}
