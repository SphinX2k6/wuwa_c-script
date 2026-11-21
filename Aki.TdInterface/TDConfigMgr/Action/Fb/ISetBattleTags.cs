using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029AA RID: 10666
	public class ISetBattleTags : IExecBattleActionType
	{
		// Token: 0x0600EC4E RID: 60494 RVA: 0x0022C8A6 File Offset: 0x0022AAA6
		public static ISetBattleTags Create(ISetBattleTags? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetBattleTags
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045A8 RID: 17832
		// (get) Token: 0x0600EC4F RID: 60495 RVA: 0x0022C8C5 File Offset: 0x0022AAC5
		public override EExecBattleActionType Type
		{
			get
			{
				return (EExecBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x170045A9 RID: 17833
		// (get) Token: 0x0600EC50 RID: 60496 RVA: 0x0022C8D4 File Offset: 0x0022AAD4
		public virtual List<ISetBattleTagConfig> Configs
		{
			get
			{
				if (this._ConfigsInited)
				{
					return this._ConfigsCache;
				}
				this._ConfigsInited = true;
				int configsLength = this.Instance.ConfigsLength;
				this._ConfigsCache = new List<ISetBattleTagConfig>(configsLength);
				for (int i = 0; i < configsLength; i++)
				{
					this._ConfigsCache.Add(ISetBattleTagConfig.Create(this.Instance.Configs(i)));
				}
				return this._ConfigsCache;
			}
		}

		// Token: 0x04008218 RID: 33304
		private ISetBattleTags Instance;

		// Token: 0x04008219 RID: 33305
		private List<ISetBattleTagConfig> _ConfigsCache;

		// Token: 0x0400821A RID: 33306
		private bool _ConfigsInited;
	}
}
