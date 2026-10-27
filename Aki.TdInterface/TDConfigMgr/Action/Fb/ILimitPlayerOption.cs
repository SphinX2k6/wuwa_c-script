using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027C9 RID: 10185
	public class ILimitPlayerOption
	{
		// Token: 0x0600E27B RID: 57979 RVA: 0x00217250 File Offset: 0x00215450
		[NullableContext(1)]
		public static ILimitPlayerOption Create(ILimitPlayerOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044AB RID: 17579
		// (get) Token: 0x0600E27C RID: 57980 RVA: 0x0021726F File Offset: 0x0021546F
		public virtual ELimitPlayOperation Type
		{
			get
			{
				return (ELimitPlayOperation)this.Instance.Type;
			}
		}

		// Token: 0x04007D9B RID: 32155
		private ILimitPlayerOption Instance;
	}
}
