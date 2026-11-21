using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B20 RID: 2848
	public class TriggerUe5Component : IComponentBase
	{
		// Token: 0x06004114 RID: 16660 RVA: 0x000A60D2 File Offset: 0x000A42D2
		public static TriggerUe5Component Create(ITriggerUe5Component? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TriggerUe5Component
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06004115 RID: 16661 RVA: 0x000A60F4 File Offset: 0x000A42F4
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

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06004116 RID: 16662 RVA: 0x000A612C File Offset: 0x000A432C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06004117 RID: 16663 RVA: 0x000A6142 File Offset: 0x000A4342
		public virtual int MaxTriggerTimes
		{
			get
			{
				return this.Instance.MaxTriggerTimes;
			}
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06004118 RID: 16664 RVA: 0x000A614F File Offset: 0x000A434F
		public virtual bool IsNotLoad
		{
			get
			{
				return this.Instance.IsNotLoad;
			}
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06004119 RID: 16665 RVA: 0x000A615C File Offset: 0x000A435C
		public virtual ITriggerActions TriggerActions
		{
			get
			{
				if (this._TriggerActionsInited)
				{
					return this._TriggerActionsCache;
				}
				this._TriggerActionsInited = true;
				this._TriggerActionsCache = ITriggerActions.Create(this.Instance.TriggerActions);
				return this._TriggerActionsCache;
			}
		}

		// Token: 0x0400240F RID: 9231
		private ITriggerUe5Component Instance;

		// Token: 0x04002410 RID: 9232
		[Nullable(2)]
		private ITriggerActions _TriggerActionsCache;

		// Token: 0x04002411 RID: 9233
		private bool _TriggerActionsInited;
	}
}
