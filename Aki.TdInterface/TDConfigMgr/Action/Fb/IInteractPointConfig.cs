using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002844 RID: 10308
	public class IInteractPointConfig
	{
		// Token: 0x0600E487 RID: 58503 RVA: 0x0021A1F2 File Offset: 0x002183F2
		[NullableContext(1)]
		public static IInteractPointConfig Create(IInteractPointConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractPointConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045C1 RID: 17857
		// (get) Token: 0x0600E488 RID: 58504 RVA: 0x0021A211 File Offset: 0x00218411
		public virtual EInteractUnlockType Type
		{
			get
			{
				return (EInteractUnlockType)this.Instance.Type;
			}
		}

		// Token: 0x04007E6E RID: 32366
		private IInteractPointConfig Instance;
	}
}
