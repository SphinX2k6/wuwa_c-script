using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007082 RID: 28802
	public struct ISetSubScreenMode : IFlatbufferObject
	{
		// Token: 0x1700D609 RID: 54793
		// (get) Token: 0x06032FEF RID: 208879 RVA: 0x006E0F61 File Offset: 0x006DF161
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032FF0 RID: 208880 RVA: 0x006E0F6E File Offset: 0x006DF16E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032FF1 RID: 208881 RVA: 0x006E0F78 File Offset: 0x006DF178
		public static ISetSubScreenMode GetRootAsISetSubScreenMode(ByteBuffer _bb)
		{
			return ISetSubScreenMode.GetRootAsISetSubScreenMode(_bb, default(ISetSubScreenMode));
		}

		// Token: 0x06032FF2 RID: 208882 RVA: 0x006E0F94 File Offset: 0x006DF194
		public static ISetSubScreenMode GetRootAsISetSubScreenMode(ByteBuffer _bb, ISetSubScreenMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032FF3 RID: 208883 RVA: 0x006E0FB1 File Offset: 0x006DF1B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032FF4 RID: 208884 RVA: 0x006E0FC0 File Offset: 0x006DF1C0
		public ISetSubScreenMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D60A RID: 54794
		// (get) Token: 0x06032FF5 RID: 208885 RVA: 0x006E0FD0 File Offset: 0x006DF1D0
		public TSubScreenMode ConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TSubScreenMode.NONE;
				}
				return (TSubScreenMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032FF6 RID: 208886 RVA: 0x006E100C File Offset: 0x006DF20C
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032FF7 RID: 208887 RVA: 0x006E1050 File Offset: 0x006DF250
		public ISubScreenModeAdjust ConfigAsISubScreenModeAdjust()
		{
			return this.Config<ISubScreenModeAdjust>().Value;
		}

		// Token: 0x06032FF8 RID: 208888 RVA: 0x006E106C File Offset: 0x006DF26C
		public ISubScreenModeExit ConfigAsISubScreenModeExit()
		{
			return this.Config<ISubScreenModeExit>().Value;
		}

		// Token: 0x06032FF9 RID: 208889 RVA: 0x006E1088 File Offset: 0x006DF288
		public ISubScreenModeInit ConfigAsISubScreenModeInit()
		{
			return this.Config<ISubScreenModeInit>().Value;
		}

		// Token: 0x06032FFA RID: 208890 RVA: 0x006E10A3 File Offset: 0x006DF2A3
		public static Offset<ISetSubScreenMode> CreateISetSubScreenMode(FlatBufferBuilder builder, TSubScreenMode Config_type = TSubScreenMode.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(2);
			ISetSubScreenMode.AddConfig(builder, ConfigOffset);
			ISetSubScreenMode.AddConfigType(builder, Config_type);
			return ISetSubScreenMode.EndISetSubScreenMode(builder);
		}

		// Token: 0x06032FFB RID: 208891 RVA: 0x006E10C0 File Offset: 0x006DF2C0
		public static void StartISetSubScreenMode(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032FFC RID: 208892 RVA: 0x006E10C9 File Offset: 0x006DF2C9
		public static void AddConfigType(FlatBufferBuilder builder, TSubScreenMode configType)
		{
			builder.AddByte(0, (byte)configType, 0);
		}

		// Token: 0x06032FFD RID: 208893 RVA: 0x006E10D4 File Offset: 0x006DF2D4
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(1, configOffset, 0);
		}

		// Token: 0x06032FFE RID: 208894 RVA: 0x006E10DF File Offset: 0x006DF2DF
		public static Offset<ISetSubScreenMode> EndISetSubScreenMode(FlatBufferBuilder builder)
		{
			return new Offset<ISetSubScreenMode>(builder.EndTable());
		}

		// Token: 0x06032FFF RID: 208895 RVA: 0x006E10EC File Offset: 0x006DF2EC
		public ISetSubScreenModeT UnPack()
		{
			ISetSubScreenModeT setSubScreenModeT = new ISetSubScreenModeT();
			this.UnPackTo(setSubScreenModeT);
			return setSubScreenModeT;
		}

		// Token: 0x06033000 RID: 208896 RVA: 0x006E1108 File Offset: 0x006DF308
		public void UnPackTo(ISetSubScreenModeT _o)
		{
			_o.Config = new TSubScreenModeUnion();
			_o.Config.Type = this.ConfigType;
			switch (this.ConfigType)
			{
			case TSubScreenMode.ISubScreenModeAdjust:
				_o.Config.Value = ((this.Config<ISubScreenModeAdjust>() != null) ? this.Config<ISubScreenModeAdjust>().Value.UnPack() : null);
				return;
			case TSubScreenMode.ISubScreenModeExit:
				_o.Config.Value = ((this.Config<ISubScreenModeExit>() != null) ? this.Config<ISubScreenModeExit>().Value.UnPack() : null);
				return;
			case TSubScreenMode.ISubScreenModeInit:
				_o.Config.Value = ((this.Config<ISubScreenModeInit>() != null) ? this.Config<ISubScreenModeInit>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06033001 RID: 208897 RVA: 0x006E11F0 File Offset: 0x006DF3F0
		public static Offset<ISetSubScreenMode> Pack(FlatBufferBuilder builder, ISetSubScreenModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetSubScreenMode>);
			}
			TSubScreenMode config_type = (_o.Config == null) ? TSubScreenMode.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TSubScreenModeUnion.Pack(builder, _o.Config);
			return ISetSubScreenMode.CreateISetSubScreenMode(builder, config_type, configOffset);
		}

		// Token: 0x04011AE8 RID: 72424
		private Table __p;
	}
}
