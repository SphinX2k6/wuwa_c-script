using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002766 RID: 10086
	public class IControlTrackingType
	{
		// Token: 0x0600E0AE RID: 57518 RVA: 0x002134E9 File Offset: 0x002116E9
		[NullableContext(1)]
		public static IControlTrackingType Create(IControlTrackingType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IControlTrackingType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043A4 RID: 17316
		// (get) Token: 0x0600E0AF RID: 57519 RVA: 0x00213508 File Offset: 0x00211708
		public virtual EControlTrackingType Type
		{
			get
			{
				return (EControlTrackingType)this.Instance.Type;
			}
		}

		// Token: 0x04007C6A RID: 31850
		private IControlTrackingType Instance;
	}
}
