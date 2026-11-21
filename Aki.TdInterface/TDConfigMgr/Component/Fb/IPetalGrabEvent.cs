using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BEC RID: 3052
	public class IPetalGrabEvent
	{
		// Token: 0x06004613 RID: 17939 RVA: 0x000B2ADA File Offset: 0x000B0CDA
		public static IPetalGrabEvent Create(IPetalGrabEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPetalGrabEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x06004614 RID: 17940 RVA: 0x000B2AF9 File Offset: 0x000B0CF9
		public virtual EPetalGrabEventType EventType
		{
			get
			{
				return (EPetalGrabEventType)this.Instance.EventType;
			}
		}

		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x06004615 RID: 17941 RVA: 0x000B2B06 File Offset: 0x000B0D06
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x04002757 RID: 10071
		private IPetalGrabEvent Instance;
	}
}
