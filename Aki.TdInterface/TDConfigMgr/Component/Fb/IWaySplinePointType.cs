using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C58 RID: 3160
	public class IWaySplinePointType
	{
		// Token: 0x06004868 RID: 18536 RVA: 0x000B5FE1 File Offset: 0x000B41E1
		[NullableContext(1)]
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

		// Token: 0x17001575 RID: 5493
		// (get) Token: 0x06004869 RID: 18537 RVA: 0x000B6000 File Offset: 0x000B4200
		public virtual EWaySplinePointType Type
		{
			get
			{
				return (EWaySplinePointType)this.Instance.Type;
			}
		}

		// Token: 0x04002943 RID: 10563
		private IWaySplinePointType Instance;
	}
}
