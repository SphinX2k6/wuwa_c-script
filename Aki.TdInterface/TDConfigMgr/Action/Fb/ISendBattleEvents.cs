using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026E7 RID: 9959
	[NullableContext(1)]
	[Nullable(0)]
	public class ISendBattleEvents : IExecBattleActionType
	{
		// Token: 0x0600DE76 RID: 56950 RVA: 0x00210105 File Offset: 0x0020E305
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

		// Token: 0x1700426A RID: 17002
		// (get) Token: 0x0600DE77 RID: 56951 RVA: 0x00210124 File Offset: 0x0020E324
		public override EExecBattleActionType Type
		{
			get
			{
				return (EExecBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x1700426B RID: 17003
		// (get) Token: 0x0600DE78 RID: 56952 RVA: 0x00210134 File Offset: 0x0020E334
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

		// Token: 0x04007B7B RID: 31611
		private ISendBattleEvents Instance;

		// Token: 0x04007B7C RID: 31612
		private List<ISetBattleTagConfig> _ConfigsCache;

		// Token: 0x04007B7D RID: 31613
		private bool _ConfigsInited;
	}
}
