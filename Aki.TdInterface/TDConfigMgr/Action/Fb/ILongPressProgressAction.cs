using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002618 RID: 9752
	[NullableContext(1)]
	[Nullable(0)]
	public class ILongPressProgressAction
	{
		// Token: 0x0600DAE5 RID: 56037 RVA: 0x00209922 File Offset: 0x00207B22
		public static ILongPressProgressAction Create(ILongPressProgressAction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressProgressAction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004077 RID: 16503
		// (get) Token: 0x0600DAE6 RID: 56038 RVA: 0x00209941 File Offset: 0x00207B41
		public virtual float Percentage
		{
			get
			{
				return this.Instance.Percentage;
			}
		}

		// Token: 0x17004078 RID: 16504
		// (get) Token: 0x0600DAE7 RID: 56039 RVA: 0x00209950 File Offset: 0x00207B50
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

		// Token: 0x0400798E RID: 31118
		private ILongPressProgressAction Instance;

		// Token: 0x0400798F RID: 31119
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007990 RID: 31120
		private bool _ActionsInited;
	}
}
