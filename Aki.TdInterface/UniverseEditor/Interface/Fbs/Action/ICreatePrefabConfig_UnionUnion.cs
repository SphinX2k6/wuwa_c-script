using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064EA RID: 25834
	public class ICreatePrefabConfig_UnionUnion
	{
		// Token: 0x1700C02E RID: 49198
		// (get) Token: 0x0602CD01 RID: 183553 RVA: 0x006286DD File Offset: 0x006268DD
		// (set) Token: 0x0602CD02 RID: 183554 RVA: 0x006286E5 File Offset: 0x006268E5
		public ICreatePrefabConfig_Union Type { get; set; }

		// Token: 0x1700C02F RID: 49199
		// (get) Token: 0x0602CD03 RID: 183555 RVA: 0x006286EE File Offset: 0x006268EE
		// (set) Token: 0x0602CD04 RID: 183556 RVA: 0x006286F6 File Offset: 0x006268F6
		public object Value { get; set; }

		// Token: 0x0602CD05 RID: 183557 RVA: 0x006286FF File Offset: 0x006268FF
		public ICreatePrefabConfig_UnionUnion()
		{
			this.Type = ICreatePrefabConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602CD06 RID: 183558 RVA: 0x00628715 File Offset: 0x00626915
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602CD07 RID: 183559 RVA: 0x00628727 File Offset: 0x00626927
		public ICreatePrefabConfigT AsICreatePrefabConfig()
		{
			return this.As<ICreatePrefabConfigT>();
		}

		// Token: 0x0602CD08 RID: 183560 RVA: 0x0062872F File Offset: 0x0062692F
		public static ICreatePrefabConfig_UnionUnion FromICreatePrefabConfig(ICreatePrefabConfigT _icreateprefabconfig)
		{
			return new ICreatePrefabConfig_UnionUnion
			{
				Type = ICreatePrefabConfig_Union.ICreatePrefabConfig,
				Value = _icreateprefabconfig
			};
		}

		// Token: 0x0602CD09 RID: 183561 RVA: 0x00628744 File Offset: 0x00626944
		public IPrefabConfigT AsIPrefabConfig()
		{
			return this.As<IPrefabConfigT>();
		}

		// Token: 0x0602CD0A RID: 183562 RVA: 0x0062874C File Offset: 0x0062694C
		public static ICreatePrefabConfig_UnionUnion FromIPrefabConfig(IPrefabConfigT _iprefabconfig)
		{
			return new ICreatePrefabConfig_UnionUnion
			{
				Type = ICreatePrefabConfig_Union.IPrefabConfig,
				Value = _iprefabconfig
			};
		}

		// Token: 0x0602CD0B RID: 183563 RVA: 0x00628761 File Offset: 0x00626961
		public IRandomPrefabConfigT AsIRandomPrefabConfig()
		{
			return this.As<IRandomPrefabConfigT>();
		}

		// Token: 0x0602CD0C RID: 183564 RVA: 0x00628769 File Offset: 0x00626969
		public static ICreatePrefabConfig_UnionUnion FromIRandomPrefabConfig(IRandomPrefabConfigT _irandomprefabconfig)
		{
			return new ICreatePrefabConfig_UnionUnion
			{
				Type = ICreatePrefabConfig_Union.IRandomPrefabConfig,
				Value = _irandomprefabconfig
			};
		}

		// Token: 0x0602CD0D RID: 183565 RVA: 0x0062877E File Offset: 0x0062697E
		public ITowerDungeonPrefabConfigT AsITowerDungeonPrefabConfig()
		{
			return this.As<ITowerDungeonPrefabConfigT>();
		}

		// Token: 0x0602CD0E RID: 183566 RVA: 0x00628786 File Offset: 0x00626986
		public static ICreatePrefabConfig_UnionUnion FromITowerDungeonPrefabConfig(ITowerDungeonPrefabConfigT _itowerdungeonprefabconfig)
		{
			return new ICreatePrefabConfig_UnionUnion
			{
				Type = ICreatePrefabConfig_Union.ITowerDungeonPrefabConfig,
				Value = _itowerdungeonprefabconfig
			};
		}

		// Token: 0x0602CD0F RID: 183567 RVA: 0x0062879B File Offset: 0x0062699B
		public IRoguePrefabConfigT AsIRoguePrefabConfig()
		{
			return this.As<IRoguePrefabConfigT>();
		}

		// Token: 0x0602CD10 RID: 183568 RVA: 0x006287A3 File Offset: 0x006269A3
		public static ICreatePrefabConfig_UnionUnion FromIRoguePrefabConfig(IRoguePrefabConfigT _irogueprefabconfig)
		{
			return new ICreatePrefabConfig_UnionUnion
			{
				Type = ICreatePrefabConfig_Union.IRoguePrefabConfig,
				Value = _irogueprefabconfig
			};
		}

		// Token: 0x0602CD11 RID: 183569 RVA: 0x006287B8 File Offset: 0x006269B8
		public ISlashTowerPrefabConfigT AsISlashTowerPrefabConfig()
		{
			return this.As<ISlashTowerPrefabConfigT>();
		}

		// Token: 0x0602CD12 RID: 183570 RVA: 0x006287C0 File Offset: 0x006269C0
		public static ICreatePrefabConfig_UnionUnion FromISlashTowerPrefabConfig(ISlashTowerPrefabConfigT _islashtowerprefabconfig)
		{
			return new ICreatePrefabConfig_UnionUnion
			{
				Type = ICreatePrefabConfig_Union.ISlashTowerPrefabConfig,
				Value = _islashtowerprefabconfig
			};
		}

		// Token: 0x0602CD13 RID: 183571 RVA: 0x006287D5 File Offset: 0x006269D5
		public IRoleTowerPrefabConfigT AsIRoleTowerPrefabConfig()
		{
			return this.As<IRoleTowerPrefabConfigT>();
		}

		// Token: 0x0602CD14 RID: 183572 RVA: 0x006287DD File Offset: 0x006269DD
		public static ICreatePrefabConfig_UnionUnion FromIRoleTowerPrefabConfig(IRoleTowerPrefabConfigT _iroletowerprefabconfig)
		{
			return new ICreatePrefabConfig_UnionUnion
			{
				Type = ICreatePrefabConfig_Union.IRoleTowerPrefabConfig,
				Value = _iroletowerprefabconfig
			};
		}

		// Token: 0x0602CD15 RID: 183573 RVA: 0x006287F4 File Offset: 0x006269F4
		public static int Pack(FlatBufferBuilder builder, ICreatePrefabConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICreatePrefabConfig_Union.ICreatePrefabConfig:
				return ICreatePrefabConfig.Pack(builder, _o.AsICreatePrefabConfig()).Value;
			case ICreatePrefabConfig_Union.IPrefabConfig:
				return IPrefabConfig.Pack(builder, _o.AsIPrefabConfig()).Value;
			case ICreatePrefabConfig_Union.IRandomPrefabConfig:
				return IRandomPrefabConfig.Pack(builder, _o.AsIRandomPrefabConfig()).Value;
			case ICreatePrefabConfig_Union.ITowerDungeonPrefabConfig:
				return ITowerDungeonPrefabConfig.Pack(builder, _o.AsITowerDungeonPrefabConfig()).Value;
			case ICreatePrefabConfig_Union.IRoguePrefabConfig:
				return IRoguePrefabConfig.Pack(builder, _o.AsIRoguePrefabConfig()).Value;
			case ICreatePrefabConfig_Union.ISlashTowerPrefabConfig:
				return ISlashTowerPrefabConfig.Pack(builder, _o.AsISlashTowerPrefabConfig()).Value;
			case ICreatePrefabConfig_Union.IRoleTowerPrefabConfig:
				return IRoleTowerPrefabConfig.Pack(builder, _o.AsIRoleTowerPrefabConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
