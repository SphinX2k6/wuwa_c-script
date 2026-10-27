using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A2C RID: 10796
	[NullableContext(1)]
	[Nullable(0)]
	public class BvbPlayerOperationConstraint : ActionParams
	{
		// Token: 0x0600EDE2 RID: 60898 RVA: 0x0022AA15 File Offset: 0x00228C15
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

		// Token: 0x17004B4C RID: 19276
		// (get) Token: 0x0600EDE3 RID: 60899 RVA: 0x0022AA34 File Offset: 0x00228C34
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

		// Token: 0x17004B4D RID: 19277
		// (get) Token: 0x0600EDE4 RID: 60900 RVA: 0x0022AA64 File Offset: 0x00228C64
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

		// Token: 0x17004B4E RID: 19278
		// (get) Token: 0x0600EDE5 RID: 60901 RVA: 0x0022AA9A File Offset: 0x00228C9A
		public virtual string TidPromptTxt
		{
			get
			{
				return this.Instance.TidPromptTxt;
			}
		}

		// Token: 0x17004B4F RID: 19279
		// (get) Token: 0x0600EDE6 RID: 60902 RVA: 0x0022AAA7 File Offset: 0x00228CA7
		[Nullable(2)]
		public virtual string EdTidPromptTxt
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x040082EE RID: 33518
		private IBvbPlayerOperationConstraint Instance;

		// Token: 0x040082EF RID: 33519
		private IBvbPlayerOperationType _EnableOperationCache;

		// Token: 0x040082F0 RID: 33520
		private bool _EnableOperationInited;
	}
}
