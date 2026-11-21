using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029AB RID: 10667
	public class ISendBattleEvents : IExecBattleActionType
	{
		// Token: 0x0600EC52 RID: 60498 RVA: 0x0022C945 File Offset: 0x0022AB45
		public static ISendBattleEvents Create(ISendBattleEvents? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISendBattleEvents
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045AA RID: 17834
		// (get) Token: 0x0600EC53 RID: 60499 RVA: 0x0022C964 File Offset: 0x0022AB64
		public override EExecBattleActionType Type
		{
			get
			{
				return (EExecBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x170045AB RID: 17835
		// (get) Token: 0x0600EC54 RID: 60500 RVA: 0x0022C974 File Offset: 0x0022AB74
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

		// Token: 0x0400821B RID: 33307
		private ISendBattleEvents Instance;

		// Token: 0x0400821C RID: 33308
		private List<ISetBattleTagConfig> _ConfigsCache;

		// Token: 0x0400821D RID: 33309
		private bool _ConfigsInited;
	}
}
