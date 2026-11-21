using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F1D RID: 3869
	public class IElementalRangeTypeBase
	{
		// Token: 0x060056FF RID: 22271 RVA: 0x000D54ED File Offset: 0x000D36ED
		public static IElementalRangeTypeBase Create(IElementalRangeTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IElementalRangeTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001CC0 RID: 7360
		// (get) Token: 0x06005700 RID: 22272 RVA: 0x000D550C File Offset: 0x000D370C
		public virtual EElementalRangeType Type
		{
			get
			{
				return (EElementalRangeType)this.Instance.Type;
			}
		}

		// Token: 0x040031EC RID: 12780
		private IElementalRangeTypeBase Instance;
	}
}
