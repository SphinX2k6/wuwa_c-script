using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A87 RID: 2695
	[NullableContext(1)]
	[Nullable(0)]
	public class IPatrolAction
	{
		// Token: 0x06003E11 RID: 15889 RVA: 0x0009F065 File Offset: 0x0009D265
		public static IPatrolAction Create(IPatrolAction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrolAction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x06003E12 RID: 15890 RVA: 0x0009F084 File Offset: 0x0009D284
		public virtual int Point
		{
			get
			{
				return this.Instance.Point;
			}
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06003E13 RID: 15891 RVA: 0x0009F094 File Offset: 0x0009D294
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

		// Token: 0x04002294 RID: 8852
		private IPatrolAction Instance;

		// Token: 0x04002295 RID: 8853
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04002296 RID: 8854
		private bool _ActionsInited;
	}
}
