using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027F2 RID: 10226
	public class ISystemOption
	{
		// Token: 0x0600E278 RID: 57976 RVA: 0x00215081 File Offset: 0x00213281
		public static ISystemOption Create(ISystemOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISystemOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F42 RID: 16194
		// (get) Token: 0x0600E279 RID: 57977 RVA: 0x002150A0 File Offset: 0x002132A0
		public virtual int? OptionId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.OptionId);
			}
		}

		// Token: 0x17003F43 RID: 16195
		// (get) Token: 0x0600E27A RID: 57978 RVA: 0x002150D8 File Offset: 0x002132D8
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

		// Token: 0x04007B58 RID: 31576
		private ISystemOption Instance;

		// Token: 0x04007B59 RID: 31577
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007B5A RID: 31578
		private bool _ActionsInited;
	}
}
