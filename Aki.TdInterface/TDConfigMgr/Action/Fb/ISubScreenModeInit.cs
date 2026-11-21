using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A71 RID: 10865
	public class ISubScreenModeInit : ISubScreenModeConfig
	{
		// Token: 0x0600EFD7 RID: 61399 RVA: 0x0023275E File Offset: 0x0023095E
		public static ISubScreenModeInit Create(ISubScreenModeInit? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreenModeInit
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047A3 RID: 18339
		// (get) Token: 0x0600EFD8 RID: 61400 RVA: 0x0023277D File Offset: 0x0023097D
		public override ESubScreenOperationType Type
		{
			get
			{
				return (ESubScreenOperationType)this.Instance.Type;
			}
		}

		// Token: 0x170047A4 RID: 18340
		// (get) Token: 0x0600EFD9 RID: 61401 RVA: 0x0023278A File Offset: 0x0023098A
		public virtual List<ISubScreenInitData> InitConfigs
		{
			get
			{
				if (this._InitConfigsInited)
				{
					return this._InitConfigsCache;
				}
				this._InitConfigsInited = true;
				this._InitConfigsCache = ActionReadHelper.ReadISubScreenModeInit_InitConfigs(this.Instance);
				return this._InitConfigsCache;
			}
		}

		// Token: 0x040083DF RID: 33759
		private ISubScreenModeInit Instance;

		// Token: 0x040083E0 RID: 33760
		private List<ISubScreenInitData> _InitConfigsCache;

		// Token: 0x040083E1 RID: 33761
		private bool _InitConfigsInited;
	}
}
