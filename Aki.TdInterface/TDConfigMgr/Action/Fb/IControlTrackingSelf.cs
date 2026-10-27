using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002767 RID: 10087
	public class IControlTrackingSelf : IControlTrackingType
	{
		// Token: 0x0600E0B1 RID: 57521 RVA: 0x0021351D File Offset: 0x0021171D
		[NullableContext(1)]
		public static IControlTrackingSelf Create(IControlTrackingSelf? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IControlTrackingSelf
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043A5 RID: 17317
		// (get) Token: 0x0600E0B2 RID: 57522 RVA: 0x0021353C File Offset: 0x0021173C
		public override EControlTrackingType Type
		{
			get
			{
				return (EControlTrackingType)this.Instance.Type;
			}
		}

		// Token: 0x04007C6B RID: 31851
		private IControlTrackingSelf Instance;
	}
}
