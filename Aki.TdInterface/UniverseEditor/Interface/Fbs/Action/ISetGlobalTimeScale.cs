using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FF5 RID: 28661
	public struct ISetGlobalTimeScale : IFlatbufferObject
	{
		// Token: 0x1700D4EA RID: 54506
		// (get) Token: 0x06032B24 RID: 207652 RVA: 0x006D736A File Offset: 0x006D556A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032B25 RID: 207653 RVA: 0x006D7377 File Offset: 0x006D5577
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032B26 RID: 207654 RVA: 0x006D7380 File Offset: 0x006D5580
		public static ISetGlobalTimeScale GetRootAsISetGlobalTimeScale(ByteBuffer _bb)
		{
			return ISetGlobalTimeScale.GetRootAsISetGlobalTimeScale(_bb, default(ISetGlobalTimeScale));
		}

		// Token: 0x06032B27 RID: 207655 RVA: 0x006D739C File Offset: 0x006D559C
		public static ISetGlobalTimeScale GetRootAsISetGlobalTimeScale(ByteBuffer _bb, ISetGlobalTimeScale obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032B28 RID: 207656 RVA: 0x006D73B9 File Offset: 0x006D55B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032B29 RID: 207657 RVA: 0x006D73C8 File Offset: 0x006D55C8
		public ISetGlobalTimeScale __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D4EB RID: 54507
		// (get) Token: 0x06032B2A RID: 207658 RVA: 0x006D73D8 File Offset: 0x006D55D8
		public ETimeScaleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETimeScaleType.Global;
				}
				return (ETimeScaleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D4EC RID: 54508
		// (get) Token: 0x06032B2B RID: 207659 RVA: 0x006D7414 File Offset: 0x006D5614
		public TSetGlobalTimeScale ConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TSetGlobalTimeScale.NONE;
				}
				return (TSetGlobalTimeScale)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032B2C RID: 207660 RVA: 0x006D7450 File Offset: 0x006D5650
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032B2D RID: 207661 RVA: 0x006D7494 File Offset: 0x006D5694
		public ICloseGlobalTimeScale ConfigAsICloseGlobalTimeScale()
		{
			return this.Config<ICloseGlobalTimeScale>().Value;
		}

		// Token: 0x06032B2E RID: 207662 RVA: 0x006D74B0 File Offset: 0x006D56B0
		public IOpenGlobalTimeScale ConfigAsIOpenGlobalTimeScale()
		{
			return this.Config<IOpenGlobalTimeScale>().Value;
		}

		// Token: 0x06032B2F RID: 207663 RVA: 0x006D74CB File Offset: 0x006D56CB
		public static Offset<ISetGlobalTimeScale> CreateISetGlobalTimeScale(FlatBufferBuilder builder, ETimeScaleType Type = ETimeScaleType.Global, TSetGlobalTimeScale Config_type = TSetGlobalTimeScale.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(3);
			ISetGlobalTimeScale.AddConfig(builder, ConfigOffset);
			ISetGlobalTimeScale.AddConfigType(builder, Config_type);
			ISetGlobalTimeScale.AddType(builder, Type);
			return ISetGlobalTimeScale.EndISetGlobalTimeScale(builder);
		}

		// Token: 0x06032B30 RID: 207664 RVA: 0x006D74EF File Offset: 0x006D56EF
		public static void StartISetGlobalTimeScale(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06032B31 RID: 207665 RVA: 0x006D74F8 File Offset: 0x006D56F8
		public static void AddType(FlatBufferBuilder builder, ETimeScaleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032B32 RID: 207666 RVA: 0x006D7503 File Offset: 0x006D5703
		public static void AddConfigType(FlatBufferBuilder builder, TSetGlobalTimeScale configType)
		{
			builder.AddByte(1, (byte)configType, 0);
		}

		// Token: 0x06032B33 RID: 207667 RVA: 0x006D750E File Offset: 0x006D570E
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(2, configOffset, 0);
		}

		// Token: 0x06032B34 RID: 207668 RVA: 0x006D7519 File Offset: 0x006D5719
		public static Offset<ISetGlobalTimeScale> EndISetGlobalTimeScale(FlatBufferBuilder builder)
		{
			return new Offset<ISetGlobalTimeScale>(builder.EndTable());
		}

		// Token: 0x06032B35 RID: 207669 RVA: 0x006D7528 File Offset: 0x006D5728
		public ISetGlobalTimeScaleT UnPack()
		{
			ISetGlobalTimeScaleT setGlobalTimeScaleT = new ISetGlobalTimeScaleT();
			this.UnPackTo(setGlobalTimeScaleT);
			return setGlobalTimeScaleT;
		}

		// Token: 0x06032B36 RID: 207670 RVA: 0x006D7544 File Offset: 0x006D5744
		public void UnPackTo(ISetGlobalTimeScaleT _o)
		{
			_o.Type = this.Type;
			_o.Config = new TSetGlobalTimeScaleUnion();
			_o.Config.Type = this.ConfigType;
			TSetGlobalTimeScale configType = this.ConfigType;
			if (configType == TSetGlobalTimeScale.ICloseGlobalTimeScale)
			{
				_o.Config.Value = ((this.Config<ICloseGlobalTimeScale>() != null) ? this.Config<ICloseGlobalTimeScale>().Value.UnPack() : null);
				return;
			}
			if (configType != TSetGlobalTimeScale.IOpenGlobalTimeScale)
			{
				return;
			}
			_o.Config.Value = ((this.Config<IOpenGlobalTimeScale>() != null) ? this.Config<IOpenGlobalTimeScale>().Value.UnPack() : null);
		}

		// Token: 0x06032B37 RID: 207671 RVA: 0x006D75F4 File Offset: 0x006D57F4
		public static Offset<ISetGlobalTimeScale> Pack(FlatBufferBuilder builder, ISetGlobalTimeScaleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetGlobalTimeScale>);
			}
			TSetGlobalTimeScale config_type = (_o.Config == null) ? TSetGlobalTimeScale.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TSetGlobalTimeScaleUnion.Pack(builder, _o.Config);
			return ISetGlobalTimeScale.CreateISetGlobalTimeScale(builder, _o.Type, config_type, configOffset);
		}

		// Token: 0x04011A16 RID: 72214
		private Table __p;
	}
}
