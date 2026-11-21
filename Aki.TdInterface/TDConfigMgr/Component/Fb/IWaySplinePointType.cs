using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D31 RID: 3377
	public class IWaySplinePointType
	{
		// Token: 0x06004CED RID: 19693 RVA: 0x000C05D5 File Offset: 0x000BE7D5
		public static IWaySplinePointType Create(IWaySplinePointType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWaySplinePointType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001686 RID: 5766
		// (get) Token: 0x06004CEE RID: 19694 RVA: 0x000C05F4 File Offset: 0x000BE7F4
		public virtual EWaySplinePointType Type
		{
			get
			{
				return (EWaySplinePointType)this.Instance.Type;
			}
		}

		// Token: 0x04002BA4 RID: 11172
		private IWaySplinePointType Instance;
	}
}
