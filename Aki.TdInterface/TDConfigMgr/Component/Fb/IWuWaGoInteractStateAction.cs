using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F01 RID: 3841
	public class IWuWaGoInteractStateAction
	{
		// Token: 0x0600566A RID: 22122 RVA: 0x000D40F6 File Offset: 0x000D22F6
		public static IWuWaGoInteractStateAction Create(IWuWaGoInteractStateAction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoInteractStateAction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C63 RID: 7267
		// (get) Token: 0x0600566B RID: 22123 RVA: 0x000D4115 File Offset: 0x000D2315
		public virtual string EntityState
		{
			get
			{
				return this.Instance.EntityState;
			}
		}

		// Token: 0x17001C64 RID: 7268
		// (get) Token: 0x0600566C RID: 22124 RVA: 0x000D4124 File Offset: 0x000D2324
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

		// Token: 0x0400318C RID: 12684
		private IWuWaGoInteractStateAction Instance;

		// Token: 0x0400318D RID: 12685
		private List<ActionInfo> _ActionListCache;

		// Token: 0x0400318E RID: 12686
		private bool _ActionListInited;
	}
}
