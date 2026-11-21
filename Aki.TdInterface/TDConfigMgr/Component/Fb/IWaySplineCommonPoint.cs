using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D32 RID: 3378
	public class IWaySplineCommonPoint : IWaySplinePointType
	{
		// Token: 0x06004CF0 RID: 19696 RVA: 0x000C0609 File Offset: 0x000BE809
		public static IWaySplineCommonPoint Create(IWaySplineCommonPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWaySplineCommonPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001687 RID: 5767
		// (get) Token: 0x06004CF1 RID: 19697 RVA: 0x000C0628 File Offset: 0x000BE828
		public override EWaySplinePointType Type
		{
			get
			{
				return (EWaySplinePointType)this.Instance.Type;
			}
		}

		// Token: 0x04002BA5 RID: 11173
		private IWaySplineCommonPoint Instance;
	}
}
