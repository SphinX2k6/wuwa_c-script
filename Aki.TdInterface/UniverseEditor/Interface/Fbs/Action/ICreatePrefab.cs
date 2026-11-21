using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B4E RID: 27470
	public struct ICreatePrefab : IFlatbufferObject
	{
		// Token: 0x1700C9B1 RID: 51633
		// (get) Token: 0x0602F44A RID: 193610 RVA: 0x00673E80 File Offset: 0x00672080
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F44B RID: 193611 RVA: 0x00673E8D File Offset: 0x0067208D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F44C RID: 193612 RVA: 0x00673E94 File Offset: 0x00672094
		public static ICreatePrefab GetRootAsICreatePrefab(ByteBuffer _bb)
		{
			return ICreatePrefab.GetRootAsICreatePrefab(_bb, default(ICreatePrefab));
		}

		// Token: 0x0602F44D RID: 193613 RVA: 0x00673EB0 File Offset: 0x006720B0
		public static ICreatePrefab GetRootAsICreatePrefab(ByteBuffer _bb, ICreatePrefab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F44E RID: 193614 RVA: 0x00673ECD File Offset: 0x006720CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F44F RID: 193615 RVA: 0x00673EDC File Offset: 0x006720DC
		public ICreatePrefab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9B2 RID: 51634
		// (get) Token: 0x0602F450 RID: 193616 RVA: 0x00673EEC File Offset: 0x006720EC
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

		// Token: 0x1700C9B3 RID: 51635
		// (get) Token: 0x0602F451 RID: 193617 RVA: 0x00673F28 File Offset: 0x00672128
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

		// Token: 0x0602F452 RID: 193618 RVA: 0x00673F64 File Offset: 0x00672164
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602F453 RID: 193619 RVA: 0x00673FA8 File Offset: 0x006721A8
		public IPrefabConfig ConfigAsIPrefabConfig()
		{
			return this.Config<IPrefabConfig>().Value;
		}

		// Token: 0x0602F454 RID: 193620 RVA: 0x00673FC4 File Offset: 0x006721C4
		public IRandomPrefabConfig ConfigAsIRandomPrefabConfig()
		{
			return this.Config<IRandomPrefabConfig>().Value;
		}

		// Token: 0x0602F455 RID: 193621 RVA: 0x00673FE0 File Offset: 0x006721E0
		public IRoguePrefabConfig ConfigAsIRoguePrefabConfig()
		{
			return this.Config<IRoguePrefabConfig>().Value;
		}

		// Token: 0x0602F456 RID: 193622 RVA: 0x00673FFC File Offset: 0x006721FC
		public IRoleTowerPrefabConfig ConfigAsIRoleTowerPrefabConfig()
		{
			return this.Config<IRoleTowerPrefabConfig>().Value;
		}

		// Token: 0x0602F457 RID: 193623 RVA: 0x00674018 File Offset: 0x00672218
		public ISlashTowerPrefabConfig ConfigAsISlashTowerPrefabConfig()
		{
			return this.Config<ISlashTowerPrefabConfig>().Value;
		}

		// Token: 0x0602F458 RID: 193624 RVA: 0x00674034 File Offset: 0x00672234
		public ITowerDungeonPrefabConfig ConfigAsITowerDungeonPrefabConfig()
		{
			return this.Config<ITowerDungeonPrefabConfig>().Value;
		}

		// Token: 0x1700C9B4 RID: 51636
		// (get) Token: 0x0602F459 RID: 193625 RVA: 0x00674050 File Offset: 0x00672250
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

		// Token: 0x0602F45A RID: 193626 RVA: 0x00674090 File Offset: 0x00672290
		public TTable? VarName<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602F45B RID: 193627 RVA: 0x006740D8 File Offset: 0x006722D8
		public IConstVarRef VarNameAsIConstVarRef()
		{
			return this.VarName<IConstVarRef>().Value;
		}

		// Token: 0x0602F45C RID: 193628 RVA: 0x006740F4 File Offset: 0x006722F4
		public IGlobalVarRef VarNameAsIGlobalVarRef()
		{
			return this.VarName<IGlobalVarRef>().Value;
		}

		// Token: 0x0602F45D RID: 193629 RVA: 0x00674110 File Offset: 0x00672310
		public IOtherVarRef VarNameAsIOtherVarRef()
		{
			return this.VarName<IOtherVarRef>().Value;
		}

		// Token: 0x0602F45E RID: 193630 RVA: 0x0067412C File Offset: 0x0067232C
		public ISelfVarRef VarNameAsISelfVarRef()
		{
			return this.VarName<ISelfVarRef>().Value;
		}

		// Token: 0x0602F45F RID: 193631 RVA: 0x00674148 File Offset: 0x00672348
		public ISystemVarRef VarNameAsISystemVarRef()
		{
			return this.VarName<ISystemVarRef>().Value;
		}

		// Token: 0x0602F460 RID: 193632 RVA: 0x00674163 File Offset: 0x00672363
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

		// Token: 0x0602F461 RID: 193633 RVA: 0x00674197 File Offset: 0x00672397
		public static void StartICreatePrefab(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602F462 RID: 193634 RVA: 0x006741A0 File Offset: 0x006723A0
		public static void AddPosEntityId(FlatBufferBuilder builder, int posEntityId)
		{
			builder.AddInt(0, posEntityId, 0);
		}

		// Token: 0x0602F463 RID: 193635 RVA: 0x006741AB File Offset: 0x006723AB
		public static void AddConfigType(FlatBufferBuilder builder, TPrefabConfig configType)
		{
			builder.AddByte(1, (byte)configType, 0);
		}

		// Token: 0x0602F464 RID: 193636 RVA: 0x006741B6 File Offset: 0x006723B6
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(2, configOffset, 0);
		}

		// Token: 0x0602F465 RID: 193637 RVA: 0x006741C1 File Offset: 0x006723C1
		public static void AddVarNameType(FlatBufferBuilder builder, TVarRef varNameType)
		{
			builder.AddByte(3, (byte)varNameType, 0);
		}

		// Token: 0x0602F466 RID: 193638 RVA: 0x006741CC File Offset: 0x006723CC
		public static void AddVarName(FlatBufferBuilder builder, int varNameOffset)
		{
			builder.AddOffset(4, varNameOffset, 0);
		}

		// Token: 0x0602F467 RID: 193639 RVA: 0x006741D7 File Offset: 0x006723D7
		public static Offset<ICreatePrefab> EndICreatePrefab(FlatBufferBuilder builder)
		{
			return new Offset<ICreatePrefab>(builder.EndTable());
		}

		// Token: 0x0602F468 RID: 193640 RVA: 0x006741E4 File Offset: 0x006723E4
		public ICreatePrefabT UnPack()
		{
			ICreatePrefabT createPrefabT = new ICreatePrefabT();
			this.UnPackTo(createPrefabT);
			return createPrefabT;
		}

		// Token: 0x0602F469 RID: 193641 RVA: 0x00674200 File Offset: 0x00672400
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

		// Token: 0x0602F46A RID: 193642 RVA: 0x00674514 File Offset: 0x00672714
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

		// Token: 0x04011936 RID: 71990
		private Table __p;
	}
}
