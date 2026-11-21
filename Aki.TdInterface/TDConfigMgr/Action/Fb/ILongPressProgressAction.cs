using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028D8 RID: 10456
	public class ILongPressProgressAction
	{
		// Token: 0x0600E8B2 RID: 59570 RVA: 0x00226076 File Offset: 0x00224276
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

		// Token: 0x170043B0 RID: 17328
		// (get) Token: 0x0600E8B3 RID: 59571 RVA: 0x00226095 File Offset: 0x00224295
		public virtual float Percentage
		{
			get
			{
				return this.Instance.Percentage;
			}
		}

		// Token: 0x170043B1 RID: 17329
		// (get) Token: 0x0600E8B4 RID: 59572 RVA: 0x002260A4 File Offset: 0x002242A4
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

		// Token: 0x04008028 RID: 32808
		private ILongPressProgressAction Instance;

		// Token: 0x04008029 RID: 32809
		private List<ActionInfo> _ActionsCache;

		// Token: 0x0400802A RID: 32810
		private bool _ActionsInited;
	}
}
