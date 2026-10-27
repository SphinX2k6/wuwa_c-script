using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200775D RID: 30557
	public class TPrefabConfigUnion
	{
		// Token: 0x1700E681 RID: 59009
		// (get) Token: 0x06037812 RID: 227346 RVA: 0x00783312 File Offset: 0x00781512
		// (set) Token: 0x06037813 RID: 227347 RVA: 0x0078331A File Offset: 0x0078151A
		public TPrefabConfig Type { get; set; }

		// Token: 0x1700E682 RID: 59010
		// (get) Token: 0x06037814 RID: 227348 RVA: 0x00783323 File Offset: 0x00781523
		// (set) Token: 0x06037815 RID: 227349 RVA: 0x0078332B File Offset: 0x0078152B
		public object Value { get; set; }

		// Token: 0x06037816 RID: 227350 RVA: 0x00783334 File Offset: 0x00781534
		public TPrefabConfigUnion()
		{
			this.Type = TPrefabConfig.NONE;
			this.Value = null;
		}

		// Token: 0x06037817 RID: 227351 RVA: 0x0078334A File Offset: 0x0078154A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037818 RID: 227352 RVA: 0x0078335C File Offset: 0x0078155C
		public IPrefabConfigT AsIPrefabConfig()
		{
			return this.As<IPrefabConfigT>();
		}

		// Token: 0x06037819 RID: 227353 RVA: 0x00783364 File Offset: 0x00781564
		public static TPrefabConfigUnion FromIPrefabConfig(IPrefabConfigT _iprefabconfig)
		{
			return new TPrefabConfigUnion
			{
				Type = TPrefabConfig.IPrefabConfig,
				Value = _iprefabconfig
			};
		}

		// Token: 0x0603781A RID: 227354 RVA: 0x00783379 File Offset: 0x00781579
		public IRandomPrefabConfigT AsIRandomPrefabConfig()
		{
			return this.As<IRandomPrefabConfigT>();
		}

		// Token: 0x0603781B RID: 227355 RVA: 0x00783381 File Offset: 0x00781581
		public static TPrefabConfigUnion FromIRandomPrefabConfig(IRandomPrefabConfigT _irandomprefabconfig)
		{
			return new TPrefabConfigUnion
			{
				Type = TPrefabConfig.IRandomPrefabConfig,
				Value = _irandomprefabconfig
			};
		}

		// Token: 0x0603781C RID: 227356 RVA: 0x00783396 File Offset: 0x00781596
		public IRoguePrefabConfigT AsIRoguePrefabConfig()
		{
			return this.As<IRoguePrefabConfigT>();
		}

		// Token: 0x0603781D RID: 227357 RVA: 0x0078339E File Offset: 0x0078159E
		public static TPrefabConfigUnion FromIRoguePrefabConfig(IRoguePrefabConfigT _irogueprefabconfig)
		{
			return new TPrefabConfigUnion
			{
				Type = TPrefabConfig.IRoguePrefabConfig,
				Value = _irogueprefabconfig
			};
		}

		// Token: 0x0603781E RID: 227358 RVA: 0x007833B3 File Offset: 0x007815B3
		public IRoleTowerPrefabConfigT AsIRoleTowerPrefabConfig()
		{
			return this.As<IRoleTowerPrefabConfigT>();
		}

		// Token: 0x0603781F RID: 227359 RVA: 0x007833BB File Offset: 0x007815BB
		public static TPrefabConfigUnion FromIRoleTowerPrefabConfig(IRoleTowerPrefabConfigT _iroletowerprefabconfig)
		{
			return new TPrefabConfigUnion
			{
				Type = TPrefabConfig.IRoleTowerPrefabConfig,
				Value = _iroletowerprefabconfig
			};
		}

		// Token: 0x06037820 RID: 227360 RVA: 0x007833D0 File Offset: 0x007815D0
		public ISlashTowerPrefabConfigT AsISlashTowerPrefabConfig()
		{
			return this.As<ISlashTowerPrefabConfigT>();
		}

		// Token: 0x06037821 RID: 227361 RVA: 0x007833D8 File Offset: 0x007815D8
		public static TPrefabConfigUnion FromISlashTowerPrefabConfig(ISlashTowerPrefabConfigT _islashtowerprefabconfig)
		{
			return new TPrefabConfigUnion
			{
				Type = TPrefabConfig.ISlashTowerPrefabConfig,
				Value = _islashtowerprefabconfig
			};
		}

		// Token: 0x06037822 RID: 227362 RVA: 0x007833ED File Offset: 0x007815ED
		public ITowerDungeonPrefabConfigT AsITowerDungeonPrefabConfig()
		{
			return this.As<ITowerDungeonPrefabConfigT>();
		}

		// Token: 0x06037823 RID: 227363 RVA: 0x007833F5 File Offset: 0x007815F5
		public static TPrefabConfigUnion FromITowerDungeonPrefabConfig(ITowerDungeonPrefabConfigT _itowerdungeonprefabconfig)
		{
			return new TPrefabConfigUnion
			{
				Type = TPrefabConfig.ITowerDungeonPrefabConfig,
				Value = _itowerdungeonprefabconfig
			};
		}

		// Token: 0x06037824 RID: 227364 RVA: 0x0078340C File Offset: 0x0078160C
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
