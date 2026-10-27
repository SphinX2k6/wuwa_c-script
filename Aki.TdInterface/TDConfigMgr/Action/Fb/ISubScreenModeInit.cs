using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200279F RID: 10143
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubScreenModeInit : ISubScreenModeConfig
	{
		// Token: 0x0600E1B9 RID: 57785 RVA: 0x002159CA File Offset: 0x00213BCA
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

		// Token: 0x1700443D RID: 17469
		// (get) Token: 0x0600E1BA RID: 57786 RVA: 0x002159E9 File Offset: 0x00213BE9
		public override ESubScreenOperationType Type
		{
			get
			{
				return (ESubScreenOperationType)this.Instance.Type;
			}
		}

		// Token: 0x1700443E RID: 17470
		// (get) Token: 0x0600E1BB RID: 57787 RVA: 0x002159F6 File Offset: 0x00213BF6
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

		// Token: 0x04007D29 RID: 32041
		private ISubScreenModeInit Instance;

		// Token: 0x04007D2A RID: 32042
		private List<ISubScreenInitData> _InitConfigsCache;

		// Token: 0x04007D2B RID: 32043
		private bool _InitConfigsInited;
	}
}
