using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D86 RID: 3462
	public class MonsterGachaBaseComponent : IComponentBase
	{
		// Token: 0x06004EA7 RID: 20135 RVA: 0x000C4094 File Offset: 0x000C2294
		public static MonsterGachaBaseComponent Create(IMonsterGachaBaseComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new MonsterGachaBaseComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001796 RID: 6038
		// (get) Token: 0x06004EA8 RID: 20136 RVA: 0x000C40B4 File Offset: 0x000C22B4
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001797 RID: 6039
		// (get) Token: 0x06004EA9 RID: 20137 RVA: 0x000C40EC File Offset: 0x000C22EC
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001798 RID: 6040
		// (get) Token: 0x06004EAA RID: 20138 RVA: 0x000C4104 File Offset: 0x000C2304
		public virtual List<int> MonsterEntityIds
		{
			get
			{
				if (this._MonsterEntityIdsInited)
				{
					return this._MonsterEntityIdsCache;
				}
				this._MonsterEntityIdsInited = true;
				int monsterEntityIdsLength = this.Instance.MonsterEntityIdsLength;
				this._MonsterEntityIdsCache = new List<int>(monsterEntityIdsLength);
				for (int i = 0; i < monsterEntityIdsLength; i++)
				{
					this._MonsterEntityIdsCache.Add(this.Instance.MonsterEntityIds(i));
				}
				return this._MonsterEntityIdsCache;
			}
		}

		// Token: 0x17001799 RID: 6041
		// (get) Token: 0x06004EAB RID: 20139 RVA: 0x000C4168 File Offset: 0x000C2368
		public virtual List<IMonsterGachaSlot> Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				int configLength = this.Instance.ConfigLength;
				this._ConfigCache = new List<IMonsterGachaSlot>(configLength);
				for (int i = 0; i < configLength; i++)
				{
					this._ConfigCache.Add(IMonsterGachaSlot.Create(this.Instance.Config(i)));
				}
				return this._ConfigCache;
			}
		}

		// Token: 0x1700179A RID: 6042
		// (get) Token: 0x06004EAC RID: 20140 RVA: 0x000C41D4 File Offset: 0x000C23D4
		public virtual List<IMonsterFormation> Formation
		{
			get
			{
				if (this._FormationInited)
				{
					return this._FormationCache;
				}
				this._FormationInited = true;
				int formationLength = this.Instance.FormationLength;
				this._FormationCache = new List<IMonsterFormation>(formationLength);
				for (int i = 0; i < formationLength; i++)
				{
					this._FormationCache.Add(IMonsterFormation.Create(this.Instance.Formation(i)));
				}
				return this._FormationCache;
			}
		}

		// Token: 0x04002CBD RID: 11453
		private IMonsterGachaBaseComponent Instance;

		// Token: 0x04002CBE RID: 11454
		private List<int> _MonsterEntityIdsCache;

		// Token: 0x04002CBF RID: 11455
		private bool _MonsterEntityIdsInited;

		// Token: 0x04002CC0 RID: 11456
		private List<IMonsterGachaSlot> _ConfigCache;

		// Token: 0x04002CC1 RID: 11457
		private bool _ConfigInited;

		// Token: 0x04002CC2 RID: 11458
		private List<IMonsterFormation> _FormationCache;

		// Token: 0x04002CC3 RID: 11459
		private bool _FormationInited;
	}
}
