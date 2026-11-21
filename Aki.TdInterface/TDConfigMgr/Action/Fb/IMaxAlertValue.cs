using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CE3 RID: 11491
	public class IMaxAlertValue : ISetAlertValueType
	{
		// Token: 0x0600FBB8 RID: 64440 RVA: 0x00247136 File Offset: 0x00245336
		public static IMaxAlertValue Create(IMaxAlertValue? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMaxAlertValue
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EA0 RID: 20128
		// (get) Token: 0x0600FBB9 RID: 64441 RVA: 0x00247155 File Offset: 0x00245355
		public override EValueChangeType Type
		{
			get
			{
				return (EValueChangeType)this.Instance.Type;
			}
		}

		// Token: 0x04008981 RID: 35201
		private IMaxAlertValue Instance;
	}
}
