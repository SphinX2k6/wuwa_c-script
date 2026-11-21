using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CE0 RID: 11488
	public class IAddOrSubAlertValue : ISetAlertValueType
	{
		// Token: 0x0600FBAD RID: 64429 RVA: 0x00247080 File Offset: 0x00245280
		public static IAddOrSubAlertValue Create(IAddOrSubAlertValue? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAddOrSubAlertValue
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E9B RID: 20123
		// (get) Token: 0x0600FBAE RID: 64430 RVA: 0x0024709F File Offset: 0x0024529F
		public override EValueChangeType Type
		{
			get
			{
				return (EValueChangeType)this.Instance.Type;
			}
		}

		// Token: 0x17004E9C RID: 20124
		// (get) Token: 0x0600FBAF RID: 64431 RVA: 0x002470AC File Offset: 0x002452AC
		public virtual float DeltaValue
		{
			get
			{
				return this.Instance.DeltaValue;
			}
		}

		// Token: 0x0400897E RID: 35198
		private IAddOrSubAlertValue Instance;
	}
}
