using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F89 RID: 32649
	public class TPrefabConfigUnion
	{
		// Token: 0x1700F2D3 RID: 62163
		// (get) Token: 0x0603AD5B RID: 240987 RVA: 0x007E83E2 File Offset: 0x007E65E2
		// (set) Token: 0x0603AD5C RID: 240988 RVA: 0x007E83EA File Offset: 0x007E65EA
		public TPrefabConfig Type { get; set; }

		// Token: 0x1700F2D4 RID: 62164
		// (get) Token: 0x0603AD5D RID: 240989 RVA: 0x007E83F3 File Offset: 0x007E65F3
		// (set) Token: 0x0603AD5E RID: 240990 RVA: 0x007E83FB File Offset: 0x007E65FB
		public object Value { get; set; }

		// Token: 0x0603AD5F RID: 240991 RVA: 0x007E8404 File Offset: 0x007E6604
		public TPrefabConfigUnion()
		{
			this.Type = TPrefabConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603AD60 RID: 240992 RVA: 0x007E841A File Offset: 0x007E661A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AD61 RID: 240993 RVA: 0x007E842C File Offset: 0x007E662C
		public IPrefabConfigT AsIPrefabConfig()
		{
			return this.As<IPrefabConfigT>();
		}

		// Token: 0x0603AD62 RID: 240994 RVA: 0x007E8434 File Offset: 0x007E6634
		public static TPrefabConfigUnion FromIPrefabConfig(IPrefabConfigT _iprefabconfig)
		{
			return new TPrefabConfigUnion
			{
				Type = TPrefabConfig.IPrefabConfig,
				Value = _iprefabconfig
			};
		}

		// Token: 0x0603AD63 RID: 240995 RVA: 0x007E8449 File Offset: 0x007E6649
		public IRandomPrefabConfigT AsIRandomPrefabConfig()
		{
			return this.As<IRandomPrefabConfigT>();
		}

		// Token: 0x0603AD64 RID: 240996 RVA: 0x007E8451 File Offset: 0x007E6651
		public static TPrefabConfigUnion FromIRandomPrefabConfig(IRandomPrefabConfigT _irandomprefabconfig)
		{
			return new TPrefabConfigUnion
			{
				Type = TPrefabConfig.IRandomPrefabConfig,
				Value = _irandomprefabconfig
			};
		}

		// Token: 0x0603AD65 RID: 240997 RVA: 0x007E8466 File Offset: 0x007E6666
		public IRoguePrefabConfigT AsIRoguePrefabConfig()
		{
			return this.As<IRoguePrefabConfigT>();
		}

		// Token: 0x0603AD66 RID: 240998 RVA: 0x007E846E File Offset: 0x007E666E
		public static TPrefabConfigUnion FromIRoguePrefabConfig(IRoguePrefabConfigT _irogueprefabconfig)
		{
			return new TPrefabConfigUnion
			{
				Type = TPrefabConfig.IRoguePrefabConfig,
				Value = _irogueprefabconfig
			};
		}

		// Token: 0x0603AD67 RID: 240999 RVA: 0x007E8483 File Offset: 0x007E6683
		public IRoleTowerPrefabConfigT AsIRoleTowerPrefabConfig()
		{
			return this.As<IRoleTowerPrefabConfigT>();
		}

		// Token: 0x0603AD68 RID: 241000 RVA: 0x007E848B File Offset: 0x007E668B
		public static TPrefabConfigUnion FromIRoleTowerPrefabConfig(IRoleTowerPrefabConfigT _iroletowerprefabconfig)
		{
			return new TPrefabConfigUnion
			{
				Type = TPrefabConfig.IRoleTowerPrefabConfig,
				Value = _iroletowerprefabconfig
			};
		}

		// Token: 0x0603AD69 RID: 241001 RVA: 0x007E84A0 File Offset: 0x007E66A0
		public ISlashTowerPrefabConfigT AsISlashTowerPrefabConfig()
		{
			return this.As<ISlashTowerPrefabConfigT>();
		}

		// Token: 0x0603AD6A RID: 241002 RVA: 0x007E84A8 File Offset: 0x007E66A8
		public static TPrefabConfigUnion FromISlashTowerPrefabConfig(ISlashTowerPrefabConfigT _islashtowerprefabconfig)
		{
			return new TPrefabConfigUnion
			{
				Type = TPrefabConfig.ISlashTowerPrefabConfig,
				Value = _islashtowerprefabconfig
			};
		}

		// Token: 0x0603AD6B RID: 241003 RVA: 0x007E84BD File Offset: 0x007E66BD
		public ITowerDungeonPrefabConfigT AsITowerDungeonPrefabConfig()
		{
			return this.As<ITowerDungeonPrefabConfigT>();
		}

		// Token: 0x0603AD6C RID: 241004 RVA: 0x007E84C5 File Offset: 0x007E66C5
		public static TPrefabConfigUnion FromITowerDungeonPrefabConfig(ITowerDungeonPrefabConfigT _itowerdungeonprefabconfig)
		{
			return new TPrefabConfigUnion
			{
				Type = TPrefabConfig.ITowerDungeonPrefabConfig,
				Value = _itowerdungeonprefabconfig
			};
		}

		// Token: 0x0603AD6D RID: 241005 RVA: 0x007E84DC File Offset: 0x007E66DC
		public static int Pack(FlatBufferBuilder builder, TPrefabConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TPrefabConfig.IPrefabConfig:
				return IPrefabConfig.Pack(builder, _o.AsIPrefabConfig()).Value;
			case TPrefabConfig.IRandomPrefabConfig:
				return IRandomPrefabConfig.Pack(builder, _o.AsIRandomPrefabConfig()).Value;
			case TPrefabConfig.IRoguePrefabConfig:
				return IRoguePrefabConfig.Pack(builder, _o.AsIRoguePrefabConfig()).Value;
			case TPrefabConfig.IRoleTowerPrefabConfig:
				return IRoleTowerPrefabConfig.Pack(builder, _o.AsIRoleTowerPrefabConfig()).Value;
			case TPrefabConfig.ISlashTowerPrefabConfig:
				return ISlashTowerPrefabConfig.Pack(builder, _o.AsISlashTowerPrefabConfig()).Value;
			case TPrefabConfig.ITowerDungeonPrefabConfig:
				return ITowerDungeonPrefabConfig.Pack(builder, _o.AsITowerDungeonPrefabConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
