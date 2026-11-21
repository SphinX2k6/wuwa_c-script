using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CE2 RID: 11490
	public class IMinAlertValue : ISetAlertValueType
	{
		// Token: 0x0600FBB5 RID: 64437 RVA: 0x00247102 File Offset: 0x00245302
		public static IMinAlertValue Create(IMinAlertValue? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMinAlertValue
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E9F RID: 20127
		// (get) Token: 0x0600FBB6 RID: 64438 RVA: 0x00247121 File Offset: 0x00245321
		public override EValueChangeType Type
		{
			get
			{
				return (EValueChangeType)this.Instance.Type;
			}
		}

		// Token: 0x04008980 RID: 35200
		private IMinAlertValue Instance;
	}
}
