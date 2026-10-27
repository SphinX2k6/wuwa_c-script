using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A57 RID: 2647
	[NullableContext(1)]
	[Nullable(0)]
	public class TriggerUe5Component : IComponentBase
	{
		// Token: 0x06003CF4 RID: 15604 RVA: 0x0009CC5A File Offset: 0x0009AE5A
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

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06003CF5 RID: 15605 RVA: 0x0009CC7C File Offset: 0x0009AE7C
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

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06003CF6 RID: 15606 RVA: 0x0009CCB4 File Offset: 0x0009AEB4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06003CF7 RID: 15607 RVA: 0x0009CCCA File Offset: 0x0009AECA
		public virtual int MaxTriggerTimes
		{
			get
			{
				return this.Instance.MaxTriggerTimes;
			}
		}

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06003CF8 RID: 15608 RVA: 0x0009CCD7 File Offset: 0x0009AED7
		public virtual bool IsNotLoad
		{
			get
			{
				return this.Instance.IsNotLoad;
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06003CF9 RID: 15609 RVA: 0x0009CCE4 File Offset: 0x0009AEE4
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

		// Token: 0x040021F8 RID: 8696
		private ITriggerUe5Component Instance;

		// Token: 0x040021F9 RID: 8697
		[Nullable(2)]
		private ITriggerActions _TriggerActionsCache;

		// Token: 0x040021FA RID: 8698
		private bool _TriggerActionsInited;
	}
}
