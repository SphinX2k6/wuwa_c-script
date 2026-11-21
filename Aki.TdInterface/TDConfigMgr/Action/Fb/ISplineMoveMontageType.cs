using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029E7 RID: 10727
	public class ISplineMoveMontageType
	{
		// Token: 0x0600ED4D RID: 60749 RVA: 0x0022E3DE File Offset: 0x0022C5DE
		public static ISplineMoveMontageType Create(ISplineMoveMontageType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISplineMoveMontageType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700462D RID: 17965
		// (get) Token: 0x0600ED4E RID: 60750 RVA: 0x0022E3FD File Offset: 0x0022C5FD
		public virtual ESplineMoveMontageType Type
		{
			get
			{
				return (ESplineMoveMontageType)this.Instance.Type;
			}
		}

		// Token: 0x0400829B RID: 33435
		private ISplineMoveMontageType Instance;
	}
}
