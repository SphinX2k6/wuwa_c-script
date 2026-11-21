using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EB2 RID: 3762
	public class DynamicSpawnMonsterComponent : IComponentBase
	{
		// Token: 0x060054D7 RID: 21719 RVA: 0x000D0C75 File Offset: 0x000CEE75
		public static DynamicSpawnMonsterComponent Create(IDynamicSpawnMonsterComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DynamicSpawnMonsterComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B6E RID: 7022
		// (get) Token: 0x060054D8 RID: 21720 RVA: 0x000D0C94 File Offset: 0x000CEE94
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

		// Token: 0x17001B6F RID: 7023
		// (get) Token: 0x060054D9 RID: 21721 RVA: 0x000D0CCC File Offset: 0x000CEECC
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B70 RID: 7024
		// (get) Token: 0x060054DA RID: 21722 RVA: 0x000D0CE4 File Offset: 0x000CEEE4
		public virtual List<IConditionSpawnMonster> Group
		{
			get
			{
				if (this._GroupInited)
				{
					return this._GroupCache;
				}
				this._GroupInited = true;
				int groupLength = this.Instance.GroupLength;
				this._GroupCache = new List<IConditionSpawnMonster>(groupLength);
				for (int i = 0; i < groupLength; i++)
				{
					this._GroupCache.Add(IConditionSpawnMonster.Create(this.Instance.Group(i)));
				}
				return this._GroupCache;
			}
		}

		// Token: 0x04003083 RID: 12419
		private IDynamicSpawnMonsterComponent Instance;

		// Token: 0x04003084 RID: 12420
		private List<IConditionSpawnMonster> _GroupCache;

		// Token: 0x04003085 RID: 12421
		private bool _GroupInited;
	}
}
