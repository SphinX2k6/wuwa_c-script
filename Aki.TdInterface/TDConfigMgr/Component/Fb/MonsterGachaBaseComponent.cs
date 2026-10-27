using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CA4 RID: 3236
	[NullableContext(1)]
	[Nullable(0)]
	public class MonsterGachaBaseComponent : IComponentBase
	{
		// Token: 0x060049F9 RID: 18937 RVA: 0x000B9684 File Offset: 0x000B7884
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

		// Token: 0x1700166E RID: 5742
		// (get) Token: 0x060049FA RID: 18938 RVA: 0x000B96A4 File Offset: 0x000B78A4
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

		// Token: 0x1700166F RID: 5743
		// (get) Token: 0x060049FB RID: 18939 RVA: 0x000B96DC File Offset: 0x000B78DC
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001670 RID: 5744
		// (get) Token: 0x060049FC RID: 18940 RVA: 0x000B96F4 File Offset: 0x000B78F4
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

		// Token: 0x17001671 RID: 5745
		// (get) Token: 0x060049FD RID: 18941 RVA: 0x000B9758 File Offset: 0x000B7958
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

		// Token: 0x17001672 RID: 5746
		// (get) Token: 0x060049FE RID: 18942 RVA: 0x000B97C4 File Offset: 0x000B79C4
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

		// Token: 0x04002A43 RID: 10819
		private IMonsterGachaBaseComponent Instance;

		// Token: 0x04002A44 RID: 10820
		private List<int> _MonsterEntityIdsCache;

		// Token: 0x04002A45 RID: 10821
		private bool _MonsterEntityIdsInited;

		// Token: 0x04002A46 RID: 10822
		private List<IMonsterGachaSlot> _ConfigCache;

		// Token: 0x04002A47 RID: 10823
		private bool _ConfigInited;

		// Token: 0x04002A48 RID: 10824
		private List<IMonsterFormation> _FormationCache;

		// Token: 0x04002A49 RID: 10825
		private bool _FormationInited;
	}
}
