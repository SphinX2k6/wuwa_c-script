using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E2C RID: 3628
	public class IPickInteraction
	{
		// Token: 0x06005230 RID: 21040 RVA: 0x000CB3CD File Offset: 0x000C95CD
		public static IPickInteraction Create(IPickInteraction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPickInteraction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170019D3 RID: 6611
		// (get) Token: 0x06005231 RID: 21041 RVA: 0x000CB3EC File Offset: 0x000C95EC
		public virtual EPickInteraction Type
		{
			get
			{
				return (EPickInteraction)this.Instance.Type;
			}
		}

		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x06005232 RID: 21042 RVA: 0x000CB3FC File Offset: 0x000C95FC
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> CheckedActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._CheckedActionsInited)
				{
					return this._CheckedActionsCache;
				}
				this._CheckedActionsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int checkedActionsLength = this.Instance.CheckedActionsLength;
				this._CheckedActionsCache = new List<ActionInfo>(checkedActionsLength);
				for (int i = 0; i < checkedActionsLength; i++)
				{
					this._CheckedActionsCache.Add(ActionInfo.Create(this.Instance.CheckedActions(i)));
				}
				return this._CheckedActionsCache;
			}
		}

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x06005233 RID: 21043 RVA: 0x000CB478 File Offset: 0x000C9678
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> UncheckedActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._UncheckedActionsInited)
				{
					return this._UncheckedActionsCache;
				}
				this._UncheckedActionsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int uncheckedActionsLength = this.Instance.UncheckedActionsLength;
				this._UncheckedActionsCache = new List<ActionInfo>(uncheckedActionsLength);
				for (int i = 0; i < uncheckedActionsLength; i++)
				{
					this._UncheckedActionsCache.Add(ActionInfo.Create(this.Instance.UncheckedActions(i)));
				}
				return this._UncheckedActionsCache;
			}
		}

		// Token: 0x04002EEB RID: 12011
		private IPickInteraction Instance;

		// Token: 0x04002EEC RID: 12012
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _CheckedActionsCache;

		// Token: 0x04002EED RID: 12013
		private bool _CheckedActionsInited;

		// Token: 0x04002EEE RID: 12014
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _UncheckedActionsCache;

		// Token: 0x04002EEF RID: 12015
		private bool _UncheckedActionsInited;
	}
}
