using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002950 RID: 10576
	public class IUiOperationType
	{
		// Token: 0x0600EA83 RID: 60035 RVA: 0x0022570A File Offset: 0x0022390A
		[NullableContext(1)]
		public static IUiOperationType Create(IUiOperationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUiOperationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049A5 RID: 18853
		// (get) Token: 0x0600EA84 RID: 60036 RVA: 0x00225729 File Offset: 0x00223929
		public virtual EUiOperationType Type
		{
			get
			{
				return (EUiOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008140 RID: 33088
		private IUiOperationType Instance;
	}
}
