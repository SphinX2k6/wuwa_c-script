using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200276C RID: 10092
	[NullableContext(1)]
	[Nullable(0)]
	public class EnableLevelPlay : ActionParams
	{
		// Token: 0x0600E0C4 RID: 57540 RVA: 0x002136FC File Offset: 0x002118FC
		public static EnableLevelPlay Create(IEnableLevelPlay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableLevelPlay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043AE RID: 17326
		// (get) Token: 0x0600E0C5 RID: 57541 RVA: 0x0021371C File Offset: 0x0021191C
		public virtual List<IEnableLevelPlayConfig> Configs
		{
			get
			{
				if (this._ConfigsInited)
				{
					return this._ConfigsCache;
				}
				this._ConfigsInited = true;
				int configsLength = this.Instance.ConfigsLength;
				this._ConfigsCache = new List<IEnableLevelPlayConfig>(configsLength);
				for (int i = 0; i < configsLength; i++)
				{
					this._ConfigsCache.Add(IEnableLevelPlayConfig.Create(this.Instance.Configs(i)));
				}
				return this._ConfigsCache;
			}
		}

		// Token: 0x170043AF RID: 17327
		// (get) Token: 0x0600E0C6 RID: 57542 RVA: 0x00213788 File Offset: 0x00211988
		public virtual EPlayerType? TargetPlayer
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EPlayerType?((EPlayerType)this.Instance.TargetPlayer);
			}
		}

		// Token: 0x04007C74 RID: 31860
		private IEnableLevelPlay Instance;

		// Token: 0x04007C75 RID: 31861
		private List<IEnableLevelPlayConfig> _ConfigsCache;

		// Token: 0x04007C76 RID: 31862
		private bool _ConfigsInited;
	}
}
