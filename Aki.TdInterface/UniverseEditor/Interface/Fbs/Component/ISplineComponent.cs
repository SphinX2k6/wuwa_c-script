using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005980 RID: 22912
	public struct ISplineComponent : IFlatbufferObject
	{
		// Token: 0x1700ABEC RID: 44012
		// (get) Token: 0x06026C95 RID: 158869 RVA: 0x00556B8B File Offset: 0x00554D8B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026C96 RID: 158870 RVA: 0x00556B98 File Offset: 0x00554D98
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026C97 RID: 158871 RVA: 0x00556BA0 File Offset: 0x00554DA0
		public static ISplineComponent GetRootAsISplineComponent(ByteBuffer _bb)
		{
			return ISplineComponent.GetRootAsISplineComponent(_bb, default(ISplineComponent));
		}

		// Token: 0x06026C98 RID: 158872 RVA: 0x00556BBC File Offset: 0x00554DBC
		public static ISplineComponent GetRootAsISplineComponent(ByteBuffer _bb, ISplineComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026C99 RID: 158873 RVA: 0x00556BD9 File Offset: 0x00554DD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026C9A RID: 158874 RVA: 0x00556BE8 File Offset: 0x00554DE8
		public ISplineComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ABED RID: 44013
		// (get) Token: 0x06026C9B RID: 158875 RVA: 0x00556BF8 File Offset: 0x00554DF8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ABEE RID: 44014
		// (get) Token: 0x06026C9C RID: 158876 RVA: 0x00556C38 File Offset: 0x00554E38
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

		// Token: 0x06026C9D RID: 158877 RVA: 0x00556C74 File Offset: 0x00554E74
		public TTable? Option<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06026C9E RID: 158878 RVA: 0x00556CB8 File Offset: 0x00554EB8
		public IAirPassageSpline OptionAsIAirPassageSpline()
		{
			return this.Option<IAirPassageSpline>().Value;
		}

		// Token: 0x06026C9F RID: 158879 RVA: 0x00556CD4 File Offset: 0x00554ED4
		public IButterflySpline OptionAsIButterflySpline()
		{
			return this.Option<IButterflySpline>().Value;
		}

		// Token: 0x06026CA0 RID: 158880 RVA: 0x00556CF0 File Offset: 0x00554EF0
		public ICommonSpline OptionAsICommonSpline()
		{
			return this.Option<ICommonSpline>().Value;
		}

		// Token: 0x06026CA1 RID: 158881 RVA: 0x00556D0C File Offset: 0x00554F0C
		public IContinuesVariableSpeedMovementSpline OptionAsIContinuesVariableSpeedMovementSpline()
		{
			return this.Option<IContinuesVariableSpeedMovementSpline>().Value;
		}

		// Token: 0x06026CA2 RID: 158882 RVA: 0x00556D28 File Offset: 0x00554F28
		public IEffectSpline OptionAsIEffectSpline()
		{
			return this.Option<IEffectSpline>().Value;
		}

		// Token: 0x06026CA3 RID: 158883 RVA: 0x00556D44 File Offset: 0x00554F44
		public ILevelAISpline OptionAsILevelAISpline()
		{
			return this.Option<ILevelAISpline>().Value;
		}

		// Token: 0x06026CA4 RID: 158884 RVA: 0x00556D60 File Offset: 0x00554F60
		public IMotorSlideSpline OptionAsIMotorSlideSpline()
		{
			return this.Option<IMotorSlideSpline>().Value;
		}

		// Token: 0x06026CA5 RID: 158885 RVA: 0x00556D7C File Offset: 0x00554F7C
		public IParkourSpline OptionAsIParkourSpline()
		{
			return this.Option<IParkourSpline>().Value;
		}

		// Token: 0x06026CA6 RID: 158886 RVA: 0x00556D98 File Offset: 0x00554F98
		public IPatrolSpline OptionAsIPatrolSpline()
		{
			return this.Option<IPatrolSpline>().Value;
		}

		// Token: 0x06026CA7 RID: 158887 RVA: 0x00556DB4 File Offset: 0x00554FB4
		public IRangeSpline OptionAsIRangeSpline()
		{
			return this.Option<IRangeSpline>().Value;
		}

		// Token: 0x06026CA8 RID: 158888 RVA: 0x00556DD0 File Offset: 0x00554FD0
		public ISwordRiderRailSpline OptionAsISwordRiderRailSpline()
		{
			return this.Option<ISwordRiderRailSpline>().Value;
		}

		// Token: 0x06026CA9 RID: 158889 RVA: 0x00556DEC File Offset: 0x00554FEC
		public ITimePatrolSpline OptionAsITimePatrolSpline()
		{
			return this.Option<ITimePatrolSpline>().Value;
		}

		// Token: 0x06026CAA RID: 158890 RVA: 0x00556E08 File Offset: 0x00555008
		public IWaySpline OptionAsIWaySpline()
		{
			return this.Option<IWaySpline>().Value;
		}

		// Token: 0x1700ABEF RID: 44015
		// (get) Token: 0x06026CAB RID: 158891 RVA: 0x00556E24 File Offset: 0x00555024
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

		// Token: 0x06026CAC RID: 158892 RVA: 0x00556E61 File Offset: 0x00555061
		public static Offset<ISplineComponent> CreateISplineComponent(FlatBufferBuilder builder, bool Disabled = false, TSplineOption Option_type = TSplineOption.NONE, int OptionOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISplineComponent.AddOption(builder, OptionOffset);
			ISplineComponent.AddNullMask(builder, NullMask);
			ISplineComponent.AddOptionType(builder, Option_type);
			ISplineComponent.AddDisabled(builder, Disabled);
			return ISplineComponent.EndISplineComponent(builder);
		}

		// Token: 0x06026CAD RID: 158893 RVA: 0x00556E8D File Offset: 0x0055508D
		public static void StartISplineComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06026CAE RID: 158894 RVA: 0x00556E96 File Offset: 0x00555096
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026CAF RID: 158895 RVA: 0x00556EA1 File Offset: 0x005550A1
		public static void AddOptionType(FlatBufferBuilder builder, TSplineOption optionType)
		{
			builder.AddByte(1, (byte)optionType, 0);
		}

		// Token: 0x06026CB0 RID: 158896 RVA: 0x00556EAC File Offset: 0x005550AC
		public static void AddOption(FlatBufferBuilder builder, int optionOffset)
		{
			builder.AddOffset(2, optionOffset, 0);
		}

		// Token: 0x06026CB1 RID: 158897 RVA: 0x00556EB7 File Offset: 0x005550B7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06026CB2 RID: 158898 RVA: 0x00556EC2 File Offset: 0x005550C2
		public static Offset<ISplineComponent> EndISplineComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISplineComponent>(builder.EndTable());
		}

		// Token: 0x06026CB3 RID: 158899 RVA: 0x00556ED0 File Offset: 0x005550D0
		public ISplineComponentT UnPack()
		{
			ISplineComponentT splineComponentT = new ISplineComponentT();
			this.UnPackTo(splineComponentT);
			return splineComponentT;
		}

		// Token: 0x06026CB4 RID: 158900 RVA: 0x00556EEC File Offset: 0x005550EC
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

		// Token: 0x06026CB5 RID: 158901 RVA: 0x00557274 File Offset: 0x00555474
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

		// Token: 0x0400EF70 RID: 61296
		private Table __p;
	}
}
