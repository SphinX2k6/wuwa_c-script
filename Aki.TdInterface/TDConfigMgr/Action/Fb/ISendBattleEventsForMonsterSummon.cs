using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026E9 RID: 9961
	[NullableContext(1)]
	[Nullable(0)]
	public class ISendBattleEventsForMonsterSummon : IExecBattleActionType
	{
		// Token: 0x0600DE7E RID: 56958 RVA: 0x00210212 File Offset: 0x0020E412
		public static ISendBattleEventsForMonsterSummon Create(ISendBattleEventsForMonsterSummon? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISendBattleEventsForMonsterSummon
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700426E RID: 17006
		// (get) Token: 0x0600DE7F RID: 56959 RVA: 0x00210231 File Offset: 0x0020E431
		public override EExecBattleActionType Type
		{
			get
			{
				return (EExecBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x1700426F RID: 17007
		// (get) Token: 0x0600DE80 RID: 56960 RVA: 0x00210240 File Offset: 0x0020E440
		public virtual List<ISendBattleEventsForMonsterSummonConfig> Configs
		{
			get
			{
				if (this._ConfigsInited)
				{
					return this._ConfigsCache;
				}
				this._ConfigsInited = true;
				int configsLength = this.Instance.ConfigsLength;
				this._ConfigsCache = new List<ISendBattleEventsForMonsterSummonConfig>(configsLength);
				for (int i = 0; i < configsLength; i++)
				{
					this._ConfigsCache.Add(ISendBattleEventsForMonsterSummonConfig.Create(this.Instance.Configs(i)));
				}
				return this._ConfigsCache;
			}
		}

		// Token: 0x04007B7F RID: 31615
		private ISendBattleEventsForMonsterSummon Instance;

		// Token: 0x04007B80 RID: 31616
		private List<ISendBattleEventsForMonsterSummonConfig> _ConfigsCache;

		// Token: 0x04007B81 RID: 31617
		private bool _ConfigsInited;
	}
}
