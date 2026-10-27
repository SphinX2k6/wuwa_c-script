using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E05 RID: 3589
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoInteractStateAction
	{
		// Token: 0x06005143 RID: 20803 RVA: 0x000C882E File Offset: 0x000C6A2E
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

		// Token: 0x17001AF6 RID: 6902
		// (get) Token: 0x06005144 RID: 20804 RVA: 0x000C884D File Offset: 0x000C6A4D
		public virtual string EntityState
		{
			get
			{
				return this.Instance.EntityState;
			}
		}

		// Token: 0x17001AF7 RID: 6903
		// (get) Token: 0x06005145 RID: 20805 RVA: 0x000C885C File Offset: 0x000C6A5C
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

		// Token: 0x04002EC4 RID: 11972
		private IWuWaGoInteractStateAction Instance;

		// Token: 0x04002EC5 RID: 11973
		private List<ActionInfo> _ActionListCache;

		// Token: 0x04002EC6 RID: 11974
		private bool _ActionListInited;
	}
}
