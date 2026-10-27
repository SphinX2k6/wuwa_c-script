using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200260A RID: 9738
	public class IDurationInteract
	{
		// Token: 0x0600DAB0 RID: 55984 RVA: 0x002094E9 File Offset: 0x002076E9
		[NullableContext(1)]
		public static IDurationInteract Create(IDurationInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDurationInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700405E RID: 16478
		// (get) Token: 0x0600DAB1 RID: 55985 RVA: 0x00209508 File Offset: 0x00207708
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x0400797A RID: 31098
		private IDurationInteract Instance;
	}
}
