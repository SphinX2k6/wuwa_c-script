using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026E6 RID: 9958
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetBattleTags : IExecBattleActionType
	{
		// Token: 0x0600DE72 RID: 56946 RVA: 0x00210066 File Offset: 0x0020E266
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

		// Token: 0x17004268 RID: 17000
		// (get) Token: 0x0600DE73 RID: 56947 RVA: 0x00210085 File Offset: 0x0020E285
		public override EExecBattleActionType Type
		{
			get
			{
				return (EExecBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x17004269 RID: 17001
		// (get) Token: 0x0600DE74 RID: 56948 RVA: 0x00210094 File Offset: 0x0020E294
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

		// Token: 0x04007B78 RID: 31608
		private ISetBattleTags Instance;

		// Token: 0x04007B79 RID: 31609
		private List<ISetBattleTagConfig> _ConfigsCache;

		// Token: 0x04007B7A RID: 31610
		private bool _ConfigsInited;
	}
}
