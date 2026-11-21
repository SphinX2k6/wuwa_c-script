using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028C9 RID: 10441
	public class IInteractActions : IInteractType
	{
		// Token: 0x0600E879 RID: 59513 RVA: 0x00225B9D File Offset: 0x00223D9D
		public static IInteractActions Create(IInteractActions? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractActions
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004395 RID: 17301
		// (get) Token: 0x0600E87A RID: 59514 RVA: 0x00225BBC File Offset: 0x00223DBC
		public override EInteractOption Type
		{
			get
			{
				return (EInteractOption)this.Instance.Type;
			}
		}

		// Token: 0x17004396 RID: 17302
		// (get) Token: 0x0600E87B RID: 59515 RVA: 0x00225BCC File Offset: 0x00223DCC
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

		// Token: 0x04008011 RID: 32785
		private IInteractActions Instance;

		// Token: 0x04008012 RID: 32786
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04008013 RID: 32787
		private bool _ActionsInited;
	}
}
