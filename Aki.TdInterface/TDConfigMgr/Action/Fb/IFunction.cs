using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002605 RID: 9733
	[NullableContext(1)]
	[Nullable(0)]
	public class IFunction
	{
		// Token: 0x0600DA9E RID: 55966 RVA: 0x002092DA File Offset: 0x002074DA
		public static IFunction Create(IFunction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFunction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004056 RID: 16470
		// (get) Token: 0x0600DA9F RID: 55967 RVA: 0x002092F9 File Offset: 0x002074F9
		public virtual string Name
		{
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17004057 RID: 16471
		// (get) Token: 0x0600DAA0 RID: 55968 RVA: 0x00209308 File Offset: 0x00207508
		public virtual List<ActionInfo> Actions
		{
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				int actionsLength = this.Instance.ActionsLength;
				this._ActionsCache = new List<ActionInfo>(actionsLength);
				for (int i = 0; i < actionsLength; i++)
				{
					this._ActionsCache.Add(ActionInfo.Create(this.Instance.Actions(i)));
				}
				return this._ActionsCache;
			}
		}

		// Token: 0x0400796F RID: 31087
		private IFunction Instance;

		// Token: 0x04007970 RID: 31088
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007971 RID: 31089
		private bool _ActionsInited;
	}
}
