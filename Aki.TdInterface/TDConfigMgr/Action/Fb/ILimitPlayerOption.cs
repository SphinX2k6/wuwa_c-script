using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A9C RID: 10908
	public class ILimitPlayerOption
	{
		// Token: 0x0600F09D RID: 61597 RVA: 0x00234024 File Offset: 0x00232224
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

		// Token: 0x17004813 RID: 18451
		// (get) Token: 0x0600F09E RID: 61598 RVA: 0x00234043 File Offset: 0x00232243
		public virtual ELimitPlayOperation Type
		{
			get
			{
				return (ELimitPlayOperation)this.Instance.Type;
			}
		}

		// Token: 0x04008452 RID: 33874
		private ILimitPlayerOption Instance;
	}
}
