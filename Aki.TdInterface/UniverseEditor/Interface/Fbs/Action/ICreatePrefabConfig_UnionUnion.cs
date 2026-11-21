using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B55 RID: 27477
	public class ICreatePrefabConfig_UnionUnion
	{
		// Token: 0x1700C9BB RID: 51643
		// (get) Token: 0x0602F485 RID: 193669 RVA: 0x00674805 File Offset: 0x00672A05
		// (set) Token: 0x0602F486 RID: 193670 RVA: 0x0067480D File Offset: 0x00672A0D
		public ICreatePrefabConfig_Union Type { get; set; }

		// Token: 0x1700C9BC RID: 51644
		// (get) Token: 0x0602F487 RID: 193671 RVA: 0x00674816 File Offset: 0x00672A16
		// (set) Token: 0x0602F488 RID: 193672 RVA: 0x0067481E File Offset: 0x00672A1E
		public object Value { get; set; }

		// Token: 0x0602F489 RID: 193673 RVA: 0x00674827 File Offset: 0x00672A27
		public ICreatePrefabConfig_UnionUnion()
		{
			this.Type = ICreatePrefabConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F48A RID: 193674 RVA: 0x0067483D File Offset: 0x00672A3D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F48B RID: 193675 RVA: 0x0067484F File Offset: 0x00672A4F
		public ICreatePrefabConfigT AsICreatePrefabConfig()
		{
			return this.As<ICreatePrefabConfigT>();
		}

		// Token: 0x0602F48C RID: 193676 RVA: 0x00674857 File Offset: 0x00672A57
		public static ICreatePrefabConfig_UnionUnion FromICreatePrefabConfig(ICreatePrefabConfigT _icreateprefabconfig)
		{
			return new ICreatePrefabConfig_UnionUnion
			{
				Type = ICreatePrefabConfig_Union.ICreatePrefabConfig,
				Value = _icreateprefabconfig
			};
		}

		// Token: 0x0602F48D RID: 193677 RVA: 0x0067486C File Offset: 0x00672A6C
		public IPrefabConfigT AsIPrefabConfig()
		{
			return this.As<IPrefabConfigT>();
		}

		// Token: 0x0602F48E RID: 193678 RVA: 0x00674874 File Offset: 0x00672A74
		public static ICreatePrefabConfig_UnionUnion FromIPrefabConfig(IPrefabConfigT _iprefabconfig)
		{
			return new ICreatePrefabConfig_UnionUnion
			{
				Type = ICreatePrefabConfig_Union.IPrefabConfig,
				Value = _iprefabconfig
			};
		}

		// Token: 0x0602F48F RID: 193679 RVA: 0x00674889 File Offset: 0x00672A89
		public IRandomPrefabConfigT AsIRandomPrefabConfig()
		{
			return this.As<IRandomPrefabConfigT>();
		}

		// Token: 0x0602F490 RID: 193680 RVA: 0x00674891 File Offset: 0x00672A91
		public static ICreatePrefabConfig_UnionUnion FromIRandomPrefabConfig(IRandomPrefabConfigT _irandomprefabconfig)
		{
			return new ICreatePrefabConfig_UnionUnion
			{
				Type = ICreatePrefabConfig_Union.IRandomPrefabConfig,
				Value = _irandomprefabconfig
			};
		}

		// Token: 0x0602F491 RID: 193681 RVA: 0x006748A6 File Offset: 0x00672AA6
		public ITowerDungeonPrefabConfigT AsITowerDungeonPrefabConfig()
		{
			return this.As<ITowerDungeonPrefabConfigT>();
		}

		// Token: 0x0602F492 RID: 193682 RVA: 0x006748AE File Offset: 0x00672AAE
		public static ICreatePrefabConfig_UnionUnion FromITowerDungeonPrefabConfig(ITowerDungeonPrefabConfigT _itowerdungeonprefabconfig)
		{
			return new ICreatePrefabConfig_UnionUnion
			{
				Type = ICreatePrefabConfig_Union.ITowerDungeonPrefabConfig,
				Value = _itowerdungeonprefabconfig
			};
		}

		// Token: 0x0602F493 RID: 193683 RVA: 0x006748C3 File Offset: 0x00672AC3
		public IRoguePrefabConfigT AsIRoguePrefabConfig()
		{
			return this.As<IRoguePrefabConfigT>();
		}

		// Token: 0x0602F494 RID: 193684 RVA: 0x006748CB File Offset: 0x00672ACB
		public static ICreatePrefabConfig_UnionUnion FromIRoguePrefabConfig(IRoguePrefabConfigT _irogueprefabconfig)
		{
			return new ICreatePrefabConfig_UnionUnion
			{
				Type = ICreatePrefabConfig_Union.IRoguePrefabConfig,
				Value = _irogueprefabconfig
			};
		}

		// Token: 0x0602F495 RID: 193685 RVA: 0x006748E0 File Offset: 0x00672AE0
		public ISlashTowerPrefabConfigT AsISlashTowerPrefabConfig()
		{
			return this.As<ISlashTowerPrefabConfigT>();
		}

		// Token: 0x0602F496 RID: 193686 RVA: 0x006748E8 File Offset: 0x00672AE8
		public static ICreatePrefabConfig_UnionUnion FromISlashTowerPrefabConfig(ISlashTowerPrefabConfigT _islashtowerprefabconfig)
		{
			return new ICreatePrefabConfig_UnionUnion
			{
				Type = ICreatePrefabConfig_Union.ISlashTowerPrefabConfig,
				Value = _islashtowerprefabconfig
			};
		}

		// Token: 0x0602F497 RID: 193687 RVA: 0x006748FD File Offset: 0x00672AFD
		public IRoleTowerPrefabConfigT AsIRoleTowerPrefabConfig()
		{
			return this.As<IRoleTowerPrefabConfigT>();
		}

		// Token: 0x0602F498 RID: 193688 RVA: 0x00674905 File Offset: 0x00672B05
		public static ICreatePrefabConfig_UnionUnion FromIRoleTowerPrefabConfig(IRoleTowerPrefabConfigT _iroletowerprefabconfig)
		{
			return new ICreatePrefabConfig_UnionUnion
			{
				Type = ICreatePrefabConfig_Union.IRoleTowerPrefabConfig,
				Value = _iroletowerprefabconfig
			};
		}

		// Token: 0x0602F499 RID: 193689 RVA: 0x0067491C File Offset: 0x00672B1C
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
