using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B21 RID: 2849
	public class SwitcherComponent : InteractiveComponent
	{
		// Token: 0x0600411B RID: 16667 RVA: 0x000A6198 File Offset: 0x000A4398
		public static SwitcherComponent Create(ISwitcherComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SwitcherComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x0600411C RID: 16668 RVA: 0x000A61B8 File Offset: 0x000A43B8
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x0600411D RID: 16669 RVA: 0x000A61EE File Offset: 0x000A43EE
		public override string Content
		{
			get
			{
				return this.Instance.Content;
			}
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x0600411E RID: 16670 RVA: 0x000A61FB File Offset: 0x000A43FB
		public override string Icon
		{
			get
			{
				return this.Instance.Icon;
			}
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x0600411F RID: 16671 RVA: 0x000A6208 File Offset: 0x000A4408
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06004120 RID: 16672 RVA: 0x000A6220 File Offset: 0x000A4420
		public virtual List<ActionInfo> OnActions
		{
			get
			{
				if (this._OnActionsInited)
				{
					return this._OnActionsCache;
				}
				this._OnActionsInited = true;
				int onActionsLength = this.Instance.OnActionsLength;
				this._OnActionsCache = new List<ActionInfo>(onActionsLength);
				for (int i = 0; i < onActionsLength; i++)
				{
					this._OnActionsCache.Add(ActionInfo.Create(this.Instance.OnActions(i)));
				}
				return this._OnActionsCache;
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06004121 RID: 16673 RVA: 0x000A628C File Offset: 0x000A448C
		public virtual List<ActionInfo> OffActions
		{
			get
			{
				if (this._OffActionsInited)
				{
					return this._OffActionsCache;
				}
				this._OffActionsInited = true;
				int offActionsLength = this.Instance.OffActionsLength;
				this._OffActionsCache = new List<ActionInfo>(offActionsLength);
				for (int i = 0; i < offActionsLength; i++)
				{
					this._OffActionsCache.Add(ActionInfo.Create(this.Instance.OffActions(i)));
				}
				return this._OffActionsCache;
			}
		}

		// Token: 0x04002412 RID: 9234
		private ISwitcherComponent Instance;

		// Token: 0x04002413 RID: 9235
		private List<ActionInfo> _OnActionsCache;

		// Token: 0x04002414 RID: 9236
		private bool _OnActionsInited;

		// Token: 0x04002415 RID: 9237
		private List<ActionInfo> _OffActionsCache;

		// Token: 0x04002416 RID: 9238
		private bool _OffActionsInited;
	}
}
