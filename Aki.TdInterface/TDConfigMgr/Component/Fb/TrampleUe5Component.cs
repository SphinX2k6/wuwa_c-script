using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A6C RID: 2668
	[NullableContext(1)]
	[Nullable(0)]
	public class TrampleUe5Component : IComponentBase
	{
		// Token: 0x06003D7F RID: 15743 RVA: 0x0009DDA1 File Offset: 0x0009BFA1
		public static TrampleUe5Component Create(ITrampleUe5Component? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TrampleUe5Component
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06003D80 RID: 15744 RVA: 0x0009DDC0 File Offset: 0x0009BFC0
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

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06003D81 RID: 15745 RVA: 0x0009DDF8 File Offset: 0x0009BFF8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06003D82 RID: 15746 RVA: 0x0009DE0E File Offset: 0x0009C00E
		public virtual bool IsDisposable
		{
			get
			{
				return this.Instance.IsDisposable;
			}
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06003D83 RID: 15747 RVA: 0x0009DE1C File Offset: 0x0009C01C
		public virtual List<ActionInfo> TriggerActions
		{
			get
			{
				if (this._TriggerActionsInited)
				{
					return this._TriggerActionsCache;
				}
				this._TriggerActionsInited = true;
				int triggerActionsLength = this.Instance.TriggerActionsLength;
				this._TriggerActionsCache = new List<ActionInfo>(triggerActionsLength);
				for (int i = 0; i < triggerActionsLength; i++)
				{
					this._TriggerActionsCache.Add(ActionInfo.Create(this.Instance.TriggerActions(i)));
				}
				return this._TriggerActionsCache;
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06003D84 RID: 15748 RVA: 0x0009DE88 File Offset: 0x0009C088
		public virtual List<ActionInfo> RecoveryActions
		{
			get
			{
				if (this._RecoveryActionsInited)
				{
					return this._RecoveryActionsCache;
				}
				this._RecoveryActionsInited = true;
				int recoveryActionsLength = this.Instance.RecoveryActionsLength;
				this._RecoveryActionsCache = new List<ActionInfo>(recoveryActionsLength);
				for (int i = 0; i < recoveryActionsLength; i++)
				{
					this._RecoveryActionsCache.Add(ActionInfo.Create(this.Instance.RecoveryActions(i)));
				}
				return this._RecoveryActionsCache;
			}
		}

		// Token: 0x04002241 RID: 8769
		private ITrampleUe5Component Instance;

		// Token: 0x04002242 RID: 8770
		private List<ActionInfo> _TriggerActionsCache;

		// Token: 0x04002243 RID: 8771
		private bool _TriggerActionsInited;

		// Token: 0x04002244 RID: 8772
		private List<ActionInfo> _RecoveryActionsCache;

		// Token: 0x04002245 RID: 8773
		private bool _RecoveryActionsInited;
	}
}
