using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007088 RID: 28808
	public struct ISetTeleControl : IFlatbufferObject
	{
		// Token: 0x1700D615 RID: 54805
		// (get) Token: 0x0603302B RID: 208939 RVA: 0x006E1870 File Offset: 0x006DFA70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603302C RID: 208940 RVA: 0x006E187D File Offset: 0x006DFA7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603302D RID: 208941 RVA: 0x006E1884 File Offset: 0x006DFA84
		public static ISetTeleControl GetRootAsISetTeleControl(ByteBuffer _bb)
		{
			return ISetTeleControl.GetRootAsISetTeleControl(_bb, default(ISetTeleControl));
		}

		// Token: 0x0603302E RID: 208942 RVA: 0x006E18A0 File Offset: 0x006DFAA0
		public static ISetTeleControl GetRootAsISetTeleControl(ByteBuffer _bb, ISetTeleControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603302F RID: 208943 RVA: 0x006E18BD File Offset: 0x006DFABD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033030 RID: 208944 RVA: 0x006E18CC File Offset: 0x006DFACC
		public ISetTeleControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D616 RID: 54806
		// (get) Token: 0x06033031 RID: 208945 RVA: 0x006E18DC File Offset: 0x006DFADC
		public TSetTeleControlConfig ConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TSetTeleControlConfig.NONE;
				}
				return (TSetTeleControlConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033032 RID: 208946 RVA: 0x006E1918 File Offset: 0x006DFB18
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033033 RID: 208947 RVA: 0x006E195C File Offset: 0x006DFB5C
		public IOpenGravity ConfigAsIOpenGravity()
		{
			return this.Config<IOpenGravity>().Value;
		}

		// Token: 0x06033034 RID: 208948 RVA: 0x006E1978 File Offset: 0x006DFB78
		public ISetResetPosition ConfigAsISetResetPosition()
		{
			return this.Config<ISetResetPosition>().Value;
		}

		// Token: 0x06033035 RID: 208949 RVA: 0x006E1993 File Offset: 0x006DFB93
		public static Offset<ISetTeleControl> CreateISetTeleControl(FlatBufferBuilder builder, TSetTeleControlConfig Config_type = TSetTeleControlConfig.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(2);
			ISetTeleControl.AddConfig(builder, ConfigOffset);
			ISetTeleControl.AddConfigType(builder, Config_type);
			return ISetTeleControl.EndISetTeleControl(builder);
		}

		// Token: 0x06033036 RID: 208950 RVA: 0x006E19B0 File Offset: 0x006DFBB0
		public static void StartISetTeleControl(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033037 RID: 208951 RVA: 0x006E19B9 File Offset: 0x006DFBB9
		public static void AddConfigType(FlatBufferBuilder builder, TSetTeleControlConfig configType)
		{
			builder.AddByte(0, (byte)configType, 0);
		}

		// Token: 0x06033038 RID: 208952 RVA: 0x006E19C4 File Offset: 0x006DFBC4
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(1, configOffset, 0);
		}

		// Token: 0x06033039 RID: 208953 RVA: 0x006E19CF File Offset: 0x006DFBCF
		public static Offset<ISetTeleControl> EndISetTeleControl(FlatBufferBuilder builder)
		{
			return new Offset<ISetTeleControl>(builder.EndTable());
		}

		// Token: 0x0603303A RID: 208954 RVA: 0x006E19DC File Offset: 0x006DFBDC
		public ISetTeleControlT UnPack()
		{
			ISetTeleControlT setTeleControlT = new ISetTeleControlT();
			this.UnPackTo(setTeleControlT);
			return setTeleControlT;
		}

		// Token: 0x0603303B RID: 208955 RVA: 0x006E19F8 File Offset: 0x006DFBF8
		public void UnPackTo(ISetTeleControlT _o)
		{
			_o.Config = new TSetTeleControlConfigUnion();
			_o.Config.Type = this.ConfigType;
			TSetTeleControlConfig configType = this.ConfigType;
			if (configType == TSetTeleControlConfig.IOpenGravity)
			{
				_o.Config.Value = ((this.Config<IOpenGravity>() != null) ? this.Config<IOpenGravity>().Value.UnPack() : null);
				return;
			}
			if (configType != TSetTeleControlConfig.ISetResetPosition)
			{
				return;
			}
			_o.Config.Value = ((this.Config<ISetResetPosition>() != null) ? this.Config<ISetResetPosition>().Value.UnPack() : null);
		}

		// Token: 0x0603303C RID: 208956 RVA: 0x006E1A9C File Offset: 0x006DFC9C
		public static Offset<ISetTeleControl> Pack(FlatBufferBuilder builder, ISetTeleControlT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetTeleControl>);
			}
			TSetTeleControlConfig config_type = (_o.Config == null) ? TSetTeleControlConfig.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TSetTeleControlConfigUnion.Pack(builder, _o.Config);
			return ISetTeleControl.CreateISetTeleControl(builder, config_type, configOffset);
		}

		// Token: 0x04011AEF RID: 72431
		private Table __p;
	}
}
