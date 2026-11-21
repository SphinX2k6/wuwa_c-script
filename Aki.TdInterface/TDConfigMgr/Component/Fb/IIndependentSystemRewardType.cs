using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B7B RID: 2939
	public class IIndependentSystemRewardType
	{
		// Token: 0x06004347 RID: 17223 RVA: 0x000AACE2 File Offset: 0x000A8EE2
		public static IIndependentSystemRewardType Create(IIndependentSystemRewardType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IIndependentSystemRewardType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x06004348 RID: 17224 RVA: 0x000AAD01 File Offset: 0x000A8F01
		public virtual EIndependentSystemRewardType Type
		{
			get
			{
				return (EIndependentSystemRewardType)this.Instance.Type;
			}
		}

		// Token: 0x0400252C RID: 9516
		private IIndependentSystemRewardType Instance;
	}
}
