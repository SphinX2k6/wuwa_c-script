using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028CC RID: 10444
	public class ICommonConfirmBox : IInteractionConfirmBoxType
	{
		// Token: 0x0600E883 RID: 59523 RVA: 0x00225CA5 File Offset: 0x00223EA5
		public static ICommonConfirmBox Create(ICommonConfirmBox? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonConfirmBox
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004399 RID: 17305
		// (get) Token: 0x0600E884 RID: 59524 RVA: 0x00225CC4 File Offset: 0x00223EC4
		public override EInteractionConfirmBoxType Type
		{
			get
			{
				return (EInteractionConfirmBoxType)this.Instance.Type;
			}
		}

		// Token: 0x1700439A RID: 17306
		// (get) Token: 0x0600E885 RID: 59525 RVA: 0x00225CD1 File Offset: 0x00223ED1
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04008016 RID: 32790
		private ICommonConfirmBox Instance;
	}
}
