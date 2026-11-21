using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B51 RID: 2897
	public class IPatrolAction
	{
		// Token: 0x0600423A RID: 16954 RVA: 0x000A861D File Offset: 0x000A681D
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

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x0600423B RID: 16955 RVA: 0x000A863C File Offset: 0x000A683C
		public virtual int Point
		{
			get
			{
				return this.Instance.Point;
			}
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x0600423C RID: 16956 RVA: 0x000A864C File Offset: 0x000A684C
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

		// Token: 0x040024B0 RID: 9392
		private IPatrolAction Instance;

		// Token: 0x040024B1 RID: 9393
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040024B2 RID: 9394
		private bool _ActionsInited;
	}
}
