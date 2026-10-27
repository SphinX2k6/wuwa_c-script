using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064E3 RID: 25827
	public struct ICreatePrefab : IFlatbufferObject
	{
		// Token: 0x1700C024 RID: 49188
		// (get) Token: 0x0602CCC6 RID: 183494 RVA: 0x00627D58 File Offset: 0x00625F58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CCC7 RID: 183495 RVA: 0x00627D65 File Offset: 0x00625F65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CCC8 RID: 183496 RVA: 0x00627D6C File Offset: 0x00625F6C
		public static ICreatePrefab GetRootAsICreatePrefab(ByteBuffer _bb)
		{
			return ICreatePrefab.GetRootAsICreatePrefab(_bb, default(ICreatePrefab));
		}

		// Token: 0x0602CCC9 RID: 183497 RVA: 0x00627D88 File Offset: 0x00625F88
		public static ICreatePrefab GetRootAsICreatePrefab(ByteBuffer _bb, ICreatePrefab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CCCA RID: 183498 RVA: 0x00627DA5 File Offset: 0x00625FA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CCCB RID: 183499 RVA: 0x00627DB4 File Offset: 0x00625FB4
		public ICreatePrefab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C025 RID: 49189
		// (get) Token: 0x0602CCCC RID: 183500 RVA: 0x00627DC4 File Offset: 0x00625FC4
		public int PosEntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C026 RID: 49190
		// (get) Token: 0x0602CCCD RID: 183501 RVA: 0x00627E00 File Offset: 0x00626000
		public TPrefabConfig ConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TPrefabConfig.NONE;
				}
				return (TPrefabConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CCCE RID: 183502 RVA: 0x00627E3C File Offset: 0x0062603C
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602CCCF RID: 183503 RVA: 0x00627E80 File Offset: 0x00626080
		public IPrefabConfig ConfigAsIPrefabConfig()
		{
			return this.Config<IPrefabConfig>().Value;
		}

		// Token: 0x0602CCD0 RID: 183504 RVA: 0x00627E9C File Offset: 0x0062609C
		public IRandomPrefabConfig ConfigAsIRandomPrefabConfig()
		{
			return this.Config<IRandomPrefabConfig>().Value;
		}

		// Token: 0x0602CCD1 RID: 183505 RVA: 0x00627EB8 File Offset: 0x006260B8
		public IRoguePrefabConfig ConfigAsIRoguePrefabConfig()
		{
			return this.Config<IRoguePrefabConfig>().Value;
		}

		// Token: 0x0602CCD2 RID: 183506 RVA: 0x00627ED4 File Offset: 0x006260D4
		public IRoleTowerPrefabConfig ConfigAsIRoleTowerPrefabConfig()
		{
			return this.Config<IRoleTowerPrefabConfig>().Value;
		}

		// Token: 0x0602CCD3 RID: 183507 RVA: 0x00627EF0 File Offset: 0x006260F0
		public ISlashTowerPrefabConfig ConfigAsISlashTowerPrefabConfig()
		{
			return this.Config<ISlashTowerPrefabConfig>().Value;
		}

		// Token: 0x0602CCD4 RID: 183508 RVA: 0x00627F0C File Offset: 0x0062610C
		public ITowerDungeonPrefabConfig ConfigAsITowerDungeonPrefabConfig()
		{
			return this.Config<ITowerDungeonPrefabConfig>().Value;
		}

		// Token: 0x1700C027 RID: 49191
		// (get) Token: 0x0602CCD5 RID: 183509 RVA: 0x00627F28 File Offset: 0x00626128
		public TVarRef VarNameType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CCD6 RID: 183510 RVA: 0x00627F68 File Offset: 0x00626168
		public TTable? VarName<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602CCD7 RID: 183511 RVA: 0x00627FB0 File Offset: 0x006261B0
		public IConstVarRef VarNameAsIConstVarRef()
		{
			return this.VarName<IConstVarRef>().Value;
		}

		// Token: 0x0602CCD8 RID: 183512 RVA: 0x00627FCC File Offset: 0x006261CC
		public IGlobalVarRef VarNameAsIGlobalVarRef()
		{
			return this.VarName<IGlobalVarRef>().Value;
		}

		// Token: 0x0602CCD9 RID: 183513 RVA: 0x00627FE8 File Offset: 0x006261E8
		public IOtherVarRef VarNameAsIOtherVarRef()
		{
			return this.VarName<IOtherVarRef>().Value;
		}

		// Token: 0x0602CCDA RID: 183514 RVA: 0x00628004 File Offset: 0x00626204
		public ISelfVarRef VarNameAsISelfVarRef()
		{
			return this.VarName<ISelfVarRef>().Value;
		}

		// Token: 0x0602CCDB RID: 183515 RVA: 0x00628020 File Offset: 0x00626220
		public ISystemVarRef VarNameAsISystemVarRef()
		{
			return this.VarName<ISystemVarRef>().Value;
		}

		// Token: 0x0602CCDC RID: 183516 RVA: 0x0062803B File Offset: 0x0062623B
		public static Offset<ICreatePrefab> CreateICreatePrefab(FlatBufferBuilder builder, int PosEntityId = 0, TPrefabConfig Config_type = TPrefabConfig.NONE, int ConfigOffset = 0, TVarRef VarName_type = TVarRef.NONE, int VarNameOffset = 0)
		{
			builder.StartTable(5);
			ICreatePrefab.AddVarName(builder, VarNameOffset);
			ICreatePrefab.AddConfig(builder, ConfigOffset);
			ICreatePrefab.AddPosEntityId(builder, PosEntityId);
			ICreatePrefab.AddVarNameType(builder, VarName_type);
			ICreatePrefab.AddConfigType(builder, Config_type);
			return ICreatePrefab.EndICreatePrefab(builder);
		}

		// Token: 0x0602CCDD RID: 183517 RVA: 0x0062806F File Offset: 0x0062626F
		public static void StartICreatePrefab(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602CCDE RID: 183518 RVA: 0x00628078 File Offset: 0x00626278
		public static void AddPosEntityId(FlatBufferBuilder builder, int posEntityId)
		{
			builder.AddInt(0, posEntityId, 0);
		}

		// Token: 0x0602CCDF RID: 183519 RVA: 0x00628083 File Offset: 0x00626283
		public static void AddConfigType(FlatBufferBuilder builder, TPrefabConfig configType)
		{
			builder.AddByte(1, (byte)configType, 0);
		}

		// Token: 0x0602CCE0 RID: 183520 RVA: 0x0062808E File Offset: 0x0062628E
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(2, configOffset, 0);
		}

		// Token: 0x0602CCE1 RID: 183521 RVA: 0x00628099 File Offset: 0x00626299
		public static void AddVarNameType(FlatBufferBuilder builder, TVarRef varNameType)
		{
			builder.AddByte(3, (byte)varNameType, 0);
		}

		// Token: 0x0602CCE2 RID: 183522 RVA: 0x006280A4 File Offset: 0x006262A4
		public static void AddVarName(FlatBufferBuilder builder, int varNameOffset)
		{
			builder.AddOffset(4, varNameOffset, 0);
		}

		// Token: 0x0602CCE3 RID: 183523 RVA: 0x006280AF File Offset: 0x006262AF
		public static Offset<ICreatePrefab> EndICreatePrefab(FlatBufferBuilder builder)
		{
			return new Offset<ICreatePrefab>(builder.EndTable());
		}

		// Token: 0x0602CCE4 RID: 183524 RVA: 0x006280BC File Offset: 0x006262BC
		public ICreatePrefabT UnPack()
		{
			ICreatePrefabT createPrefabT = new ICreatePrefabT();
			this.UnPackTo(createPrefabT);
			return createPrefabT;
		}

		// Token: 0x0602CCE5 RID: 183525 RVA: 0x006280D8 File Offset: 0x006262D8
		public void UnPackTo(ICreatePrefabT _o)
		{
			_o.PosEntityId = this.PosEntityId;
			_o.Config = new TPrefabConfigUnion();
			_o.Config.Type = this.ConfigType;
			switch (this.ConfigType)
			{
			case TPrefabConfig.IPrefabConfig:
				_o.Config.Value = ((this.Config<IPrefabConfig>() != null) ? this.Config<IPrefabConfig>().Value.UnPack() : null);
				break;
			case TPrefabConfig.IRandomPrefabConfig:
				_o.Config.Value = ((this.Config<IRandomPrefabConfig>() != null) ? this.Config<IRandomPrefabConfig>().Value.UnPack() : null);
				break;
			case TPrefabConfig.IRoguePrefabConfig:
				_o.Config.Value = ((this.Config<IRoguePrefabConfig>() != null) ? this.Config<IRoguePrefabConfig>().Value.UnPack() : null);
				break;
			case TPrefabConfig.IRoleTowerPrefabConfig:
				_o.Config.Value = ((this.Config<IRoleTowerPrefabConfig>() != null) ? this.Config<IRoleTowerPrefabConfig>().Value.UnPack() : null);
				break;
			case TPrefabConfig.ISlashTowerPrefabConfig:
				_o.Config.Value = ((this.Config<ISlashTowerPrefabConfig>() != null) ? this.Config<ISlashTowerPrefabConfig>().Value.UnPack() : null);
				break;
			case TPrefabConfig.ITowerDungeonPrefabConfig:
				_o.Config.Value = ((this.Config<ITowerDungeonPrefabConfig>() != null) ? this.Config<ITowerDungeonPrefabConfig>().Value.UnPack() : null);
				break;
			}
			_o.VarName = new TVarRefUnion();
			_o.VarName.Type = this.VarNameType;
			switch (this.VarNameType)
			{
			case TVarRef.IConstVarRef:
				_o.VarName.Value = ((this.VarName<IConstVarRef>() != null) ? this.VarName<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.VarName.Value = ((this.VarName<IGlobalVarRef>() != null) ? this.VarName<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.VarName.Value = ((this.VarName<IOtherVarRef>() != null) ? this.VarName<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.VarName.Value = ((this.VarName<ISelfVarRef>() != null) ? this.VarName<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.VarName.Value = ((this.VarName<ISystemVarRef>() != null) ? this.VarName<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602CCE6 RID: 183526 RVA: 0x006283EC File Offset: 0x006265EC
		public static Offset<ICreatePrefab> Pack(FlatBufferBuilder builder, ICreatePrefabT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICreatePrefab>);
			}
			TPrefabConfig config_type = (_o.Config == null) ? TPrefabConfig.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TPrefabConfigUnion.Pack(builder, _o.Config);
			TVarRef varName_type = (_o.VarName == null) ? TVarRef.NONE : _o.VarName.Type;
			int varNameOffset = (_o.VarName == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarName);
			return ICreatePrefab.CreateICreatePrefab(builder, _o.PosEntityId, config_type, configOffset, varName_type, varNameOffset);
		}

		// Token: 0x04010B20 RID: 68384
		private Table __p;
	}
}
