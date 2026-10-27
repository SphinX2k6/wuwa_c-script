using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C59 RID: 3161
	public class IWaySplineCommonPoint : IWaySplinePointType
	{
		// Token: 0x0600486B RID: 18539 RVA: 0x000B6015 File Offset: 0x000B4215
		[NullableContext(1)]
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

		// Token: 0x17001576 RID: 5494
		// (get) Token: 0x0600486C RID: 18540 RVA: 0x000B6034 File Offset: 0x000B4234
		public override EWaySplinePointType Type
		{
			get
			{
				return (EWaySplinePointType)this.Instance.Type;
			}
		}

		// Token: 0x04002944 RID: 10564
		private IWaySplineCommonPoint Instance;
	}
}
