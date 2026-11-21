using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CDB RID: 11483
	public class IDisableAlertAreaCondition
	{
		// Token: 0x0600FB99 RID: 64409 RVA: 0x00246F19 File Offset: 0x00245119
		public static IDisableAlertAreaCondition Create(IDisableAlertAreaCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableAlertAreaCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E91 RID: 20113
		// (get) Token: 0x0600FB9A RID: 64410 RVA: 0x00246F38 File Offset: 0x00245138
		public virtual EDisableAlertAreaCondition Type
		{
			get
			{
				return (EDisableAlertAreaCondition)this.Instance.Type;
			}
		}

		// Token: 0x04008977 RID: 35191
		private IDisableAlertAreaCondition Instance;
	}
}
