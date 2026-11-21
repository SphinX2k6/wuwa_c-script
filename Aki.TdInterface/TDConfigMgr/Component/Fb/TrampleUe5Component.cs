using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B36 RID: 2870
	public class TrampleUe5Component : IComponentBase
	{
		// Token: 0x060041A8 RID: 16808 RVA: 0x000A7359 File Offset: 0x000A5559
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

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x060041A9 RID: 16809 RVA: 0x000A7378 File Offset: 0x000A5578
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

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x060041AA RID: 16810 RVA: 0x000A73B0 File Offset: 0x000A55B0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x060041AB RID: 16811 RVA: 0x000A73C6 File Offset: 0x000A55C6
		public virtual bool IsDisposable
		{
			get
			{
				return this.Instance.IsDisposable;
			}
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x060041AC RID: 16812 RVA: 0x000A73D4 File Offset: 0x000A55D4
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

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x060041AD RID: 16813 RVA: 0x000A7440 File Offset: 0x000A5640
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

		// Token: 0x0400245D RID: 9309
		private ITrampleUe5Component Instance;

		// Token: 0x0400245E RID: 9310
		private List<ActionInfo> _TriggerActionsCache;

		// Token: 0x0400245F RID: 9311
		private bool _TriggerActionsInited;

		// Token: 0x04002460 RID: 9312
		private List<ActionInfo> _RecoveryActionsCache;

		// Token: 0x04002461 RID: 9313
		private bool _RecoveryActionsInited;
	}
}
