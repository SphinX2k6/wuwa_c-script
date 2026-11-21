using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028C5 RID: 10437
	public class IFunction
	{
		// Token: 0x0600E86B RID: 59499 RVA: 0x00225A2E File Offset: 0x00223C2E
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

		// Token: 0x1700438F RID: 17295
		// (get) Token: 0x0600E86C RID: 59500 RVA: 0x00225A4D File Offset: 0x00223C4D
		public virtual string Name
		{
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17004390 RID: 17296
		// (get) Token: 0x0600E86D RID: 59501 RVA: 0x00225A5C File Offset: 0x00223C5C
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

		// Token: 0x04008009 RID: 32777
		private IFunction Instance;

		// Token: 0x0400800A RID: 32778
		private List<ActionInfo> _ActionsCache;

		// Token: 0x0400800B RID: 32779
		private bool _ActionsInited;
	}
}
