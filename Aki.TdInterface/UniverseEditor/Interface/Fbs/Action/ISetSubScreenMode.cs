using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200784E RID: 30798
	public struct ISetSubScreenMode : IFlatbufferObject
	{
		// Token: 0x1700E1EC RID: 57836
		// (get) Token: 0x06036291 RID: 221841 RVA: 0x0074156D File Offset: 0x0073F76D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036292 RID: 221842 RVA: 0x0074157A File Offset: 0x0073F77A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036293 RID: 221843 RVA: 0x00741584 File Offset: 0x0073F784
		public static ISetSubScreenMode GetRootAsISetSubScreenMode(ByteBuffer _bb)
		{
			return ISetSubScreenMode.GetRootAsISetSubScreenMode(_bb, default(ISetSubScreenMode));
		}

		// Token: 0x06036294 RID: 221844 RVA: 0x007415A0 File Offset: 0x0073F7A0
		public static ISetSubScreenMode GetRootAsISetSubScreenMode(ByteBuffer _bb, ISetSubScreenMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036295 RID: 221845 RVA: 0x007415BD File Offset: 0x0073F7BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036296 RID: 221846 RVA: 0x007415CC File Offset: 0x0073F7CC
		public ISetSubScreenMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1ED RID: 57837
		// (get) Token: 0x06036297 RID: 221847 RVA: 0x007415DC File Offset: 0x0073F7DC
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

		// Token: 0x06036298 RID: 221848 RVA: 0x00741618 File Offset: 0x0073F818
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036299 RID: 221849 RVA: 0x0074165C File Offset: 0x0073F85C
		public ISubScreenModeAdjust ConfigAsISubScreenModeAdjust()
		{
			return this.Config<ISubScreenModeAdjust>().Value;
		}

		// Token: 0x0603629A RID: 221850 RVA: 0x00741678 File Offset: 0x0073F878
		public ISubScreenModeExit ConfigAsISubScreenModeExit()
		{
			return this.Config<ISubScreenModeExit>().Value;
		}

		// Token: 0x0603629B RID: 221851 RVA: 0x00741694 File Offset: 0x0073F894
		public ISubScreenModeInit ConfigAsISubScreenModeInit()
		{
			return this.Config<ISubScreenModeInit>().Value;
		}

		// Token: 0x0603629C RID: 221852 RVA: 0x007416AF File Offset: 0x0073F8AF
		public static Offset<ISetSubScreenMode> CreateISetSubScreenMode(FlatBufferBuilder builder, TSubScreenMode Config_type = TSubScreenMode.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(2);
			ISetSubScreenMode.AddConfig(builder, ConfigOffset);
			ISetSubScreenMode.AddConfigType(builder, Config_type);
			return ISetSubScreenMode.EndISetSubScreenMode(builder);
		}

		// Token: 0x0603629D RID: 221853 RVA: 0x007416CC File Offset: 0x0073F8CC
		public static void StartISetSubScreenMode(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603629E RID: 221854 RVA: 0x007416D5 File Offset: 0x0073F8D5
		public static void AddConfigType(FlatBufferBuilder builder, TSubScreenMode configType)
		{
			builder.AddByte(0, (byte)configType, 0);
		}

		// Token: 0x0603629F RID: 221855 RVA: 0x007416E0 File Offset: 0x0073F8E0
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(1, configOffset, 0);
		}

		// Token: 0x060362A0 RID: 221856 RVA: 0x007416EB File Offset: 0x0073F8EB
		public static Offset<ISetSubScreenMode> EndISetSubScreenMode(FlatBufferBuilder builder)
		{
			return new Offset<ISetSubScreenMode>(builder.EndTable());
		}

		// Token: 0x060362A1 RID: 221857 RVA: 0x007416F8 File Offset: 0x0073F8F8
		public ISetSubScreenModeT UnPack()
		{
			ISetSubScreenModeT setSubScreenModeT = new ISetSubScreenModeT();
			this.UnPackTo(setSubScreenModeT);
			return setSubScreenModeT;
		}

		// Token: 0x060362A2 RID: 221858 RVA: 0x00741714 File Offset: 0x0073F914
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

		// Token: 0x060362A3 RID: 221859 RVA: 0x007417FC File Offset: 0x0073F9FC
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

		// Token: 0x04012AD6 RID: 76502
		private Table __p;
	}
}
