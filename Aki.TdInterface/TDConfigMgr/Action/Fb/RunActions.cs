using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200273F RID: 10047
	[NullableContext(1)]
	[Nullable(0)]
	public class RunActions : ActionParams
	{
		// Token: 0x0600DFE8 RID: 57320 RVA: 0x00212855 File Offset: 0x00210A55
		public static RunActions Create(IRunActions? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RunActions
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700432C RID: 17196
		// (get) Token: 0x0600DFE9 RID: 57321 RVA: 0x00212874 File Offset: 0x00210A74
		public virtual List<ActionInfo> ActionList
		{
			get
			{
				if (this._ActionListInited)
				{
					return this._ActionListCache;
				}
				this._ActionListInited = true;
				int actionListLength = this.Instance.ActionListLength;
				this._ActionListCache = new List<ActionInfo>(actionListLength);
				for (int i = 0; i < actionListLength; i++)
				{
					this._ActionListCache.Add(ActionInfo.Create(this.Instance.ActionList(i)));
				}
				return this._ActionListCache;
			}
		}

		// Token: 0x04007C3B RID: 31803
		private IRunActions Instance;

		// Token: 0x04007C3C RID: 31804
		private List<ActionInfo> _ActionListCache;

		// Token: 0x04007C3D RID: 31805
		private bool _ActionListInited;
	}
}
