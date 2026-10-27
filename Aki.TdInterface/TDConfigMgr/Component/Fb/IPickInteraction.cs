using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D32 RID: 3378
	public class IPickInteraction
	{
		// Token: 0x06004D14 RID: 19732 RVA: 0x000BFC89 File Offset: 0x000BDE89
		[NullableContext(1)]
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

		// Token: 0x1700186D RID: 6253
		// (get) Token: 0x06004D15 RID: 19733 RVA: 0x000BFCA8 File Offset: 0x000BDEA8
		public virtual EPickInteraction Type
		{
			get
			{
				return (EPickInteraction)this.Instance.Type;
			}
		}

		// Token: 0x1700186E RID: 6254
		// (get) Token: 0x06004D16 RID: 19734 RVA: 0x000BFCB8 File Offset: 0x000BDEB8
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> CheckedActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x1700186F RID: 6255
		// (get) Token: 0x06004D17 RID: 19735 RVA: 0x000BFD34 File Offset: 0x000BDF34
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> UncheckedActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x04002C2B RID: 11307
		private IPickInteraction Instance;

		// Token: 0x04002C2C RID: 11308
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _CheckedActionsCache;

		// Token: 0x04002C2D RID: 11309
		private bool _CheckedActionsInited;

		// Token: 0x04002C2E RID: 11310
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _UncheckedActionsCache;

		// Token: 0x04002C2F RID: 11311
		private bool _UncheckedActionsInited;
	}
}
