using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078EA RID: 30954
	public struct ISkiConfig : IFlatbufferObject
	{
		// Token: 0x1700E328 RID: 58152
		// (get) Token: 0x06036817 RID: 223255 RVA: 0x0074C031 File Offset: 0x0074A231
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036818 RID: 223256 RVA: 0x0074C03E File Offset: 0x0074A23E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036819 RID: 223257 RVA: 0x0074C048 File Offset: 0x0074A248
		public static ISkiConfig GetRootAsISkiConfig(ByteBuffer _bb)
		{
			return ISkiConfig.GetRootAsISkiConfig(_bb, default(ISkiConfig));
		}

		// Token: 0x0603681A RID: 223258 RVA: 0x0074C064 File Offset: 0x0074A264
		public static ISkiConfig GetRootAsISkiConfig(ByteBuffer _bb, ISkiConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603681B RID: 223259 RVA: 0x0074C081 File Offset: 0x0074A281
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603681C RID: 223260 RVA: 0x0074C090 File Offset: 0x0074A290
		public ISkiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E329 RID: 58153
		// (get) Token: 0x0603681D RID: 223261 RVA: 0x0074C0A0 File Offset: 0x0074A2A0
		public ESportStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESportStateType.Slide;
				}
				return (ESportStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E32A RID: 58154
		// (get) Token: 0x0603681E RID: 223262 RVA: 0x0074C0DC File Offset: 0x0074A2DC
		public TSkiConfig ConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TSkiConfig.NONE;
				}
				return (TSkiConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603681F RID: 223263 RVA: 0x0074C118 File Offset: 0x0074A318
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036820 RID: 223264 RVA: 0x0074C15C File Offset: 0x0074A35C
		public IAccelerateSkiConfig ConfigAsIAccelerateSkiConfig()
		{
			return this.Config<IAccelerateSkiConfig>().Value;
		}

		// Token: 0x06036821 RID: 223265 RVA: 0x0074C178 File Offset: 0x0074A378
		public ICloseSkiConfig ConfigAsICloseSkiConfig()
		{
			return this.Config<ICloseSkiConfig>().Value;
		}

		// Token: 0x06036822 RID: 223266 RVA: 0x0074C194 File Offset: 0x0074A394
		public IOpenSkiConfig ConfigAsIOpenSkiConfig()
		{
			return this.Config<IOpenSkiConfig>().Value;
		}

		// Token: 0x06036823 RID: 223267 RVA: 0x0074C1AF File Offset: 0x0074A3AF
		public static Offset<ISkiConfig> CreateISkiConfig(FlatBufferBuilder builder, ESportStateType Type = ESportStateType.Slide, TSkiConfig Config_type = TSkiConfig.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(3);
			ISkiConfig.AddConfig(builder, ConfigOffset);
			ISkiConfig.AddConfigType(builder, Config_type);
			ISkiConfig.AddType(builder, Type);
			return ISkiConfig.EndISkiConfig(builder);
		}

		// Token: 0x06036824 RID: 223268 RVA: 0x0074C1D3 File Offset: 0x0074A3D3
		public static void StartISkiConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036825 RID: 223269 RVA: 0x0074C1DC File Offset: 0x0074A3DC
		public static void AddType(FlatBufferBuilder builder, ESportStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036826 RID: 223270 RVA: 0x0074C1E7 File Offset: 0x0074A3E7
		public static void AddConfigType(FlatBufferBuilder builder, TSkiConfig configType)
		{
			builder.AddByte(1, (byte)configType, 0);
		}

		// Token: 0x06036827 RID: 223271 RVA: 0x0074C1F2 File Offset: 0x0074A3F2
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(2, configOffset, 0);
		}

		// Token: 0x06036828 RID: 223272 RVA: 0x0074C1FD File Offset: 0x0074A3FD
		public static Offset<ISkiConfig> EndISkiConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISkiConfig>(builder.EndTable());
		}

		// Token: 0x06036829 RID: 223273 RVA: 0x0074C20C File Offset: 0x0074A40C
		public ISkiConfigT UnPack()
		{
			ISkiConfigT skiConfigT = new ISkiConfigT();
			this.UnPackTo(skiConfigT);
			return skiConfigT;
		}

		// Token: 0x0603682A RID: 223274 RVA: 0x0074C228 File Offset: 0x0074A428
		public void UnPackTo(ISkiConfigT _o)
		{
			_o.Type = this.Type;
			_o.Config = new TSkiConfigUnion();
			_o.Config.Type = this.ConfigType;
			switch (this.ConfigType)
			{
			case TSkiConfig.IAccelerateSkiConfig:
				_o.Config.Value = ((this.Config<IAccelerateSkiConfig>() != null) ? this.Config<IAccelerateSkiConfig>().Value.UnPack() : null);
				return;
			case TSkiConfig.ICloseSkiConfig:
				_o.Config.Value = ((this.Config<ICloseSkiConfig>() != null) ? this.Config<ICloseSkiConfig>().Value.UnPack() : null);
				return;
			case TSkiConfig.IOpenSkiConfig:
				_o.Config.Value = ((this.Config<IOpenSkiConfig>() != null) ? this.Config<IOpenSkiConfig>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0603682B RID: 223275 RVA: 0x0074C31C File Offset: 0x0074A51C
		public static Offset<ISkiConfig> Pack(FlatBufferBuilder builder, ISkiConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkiConfig>);
			}
			TSkiConfig config_type = (_o.Config == null) ? TSkiConfig.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TSkiConfigUnion.Pack(builder, _o.Config);
			return ISkiConfig.CreateISkiConfig(builder, _o.Type, config_type, configOffset);
		}

		// Token: 0x04012B9E RID: 76702
		private Table __p;
	}
}
