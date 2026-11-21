using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D19 RID: 11545
	public class BvbPlayerOperationConstraint : ActionParams
	{
		// Token: 0x0600FC7A RID: 64634 RVA: 0x002483C9 File Offset: 0x002465C9
		public static BvbPlayerOperationConstraint Create(IBvbPlayerOperationConstraint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BvbPlayerOperationConstraint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EF6 RID: 20214
		// (get) Token: 0x0600FC7B RID: 64635 RVA: 0x002483E8 File Offset: 0x002465E8
		public virtual IBvbPlayerOperationType EnableOperation
		{
			get
			{
				if (this._EnableOperationInited)
				{
					return this._EnableOperationCache;
				}
				this._EnableOperationInited = true;
				this._EnableOperationCache = ActionReadHelper.ReadBvbPlayerOperationConstraint_EnableOperation(this.Instance);
				return this._EnableOperationCache;
			}
		}

		// Token: 0x17004EF7 RID: 20215
		// (get) Token: 0x0600FC7C RID: 64636 RVA: 0x00248418 File Offset: 0x00246618
		public virtual bool? IsTheLast
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsTheLast);
			}
		}

		// Token: 0x17004EF8 RID: 20216
		// (get) Token: 0x0600FC7D RID: 64637 RVA: 0x0024844E File Offset: 0x0024664E
		public virtual string TidPromptTxt
		{
			get
			{
				return this.Instance.TidPromptTxt;
			}
		}

		// Token: 0x17004EF9 RID: 20217
		// (get) Token: 0x0600FC7E RID: 64638 RVA: 0x0024845B File Offset: 0x0024665B
		[Nullable(2)]
		public virtual string EdTidPromptTxt
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x040089E1 RID: 35297
		private IBvbPlayerOperationConstraint Instance;

		// Token: 0x040089E2 RID: 35298
		private IBvbPlayerOperationType _EnableOperationCache;

		// Token: 0x040089E3 RID: 35299
		private bool _EnableOperationInited;
	}
}
