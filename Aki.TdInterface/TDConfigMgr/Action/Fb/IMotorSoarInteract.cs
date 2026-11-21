using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AD6 RID: 10966
	public class IMotorSoarInteract : ILeisureInteractType
	{
		// Token: 0x0600F179 RID: 61817 RVA: 0x0023525B File Offset: 0x0023345B
		public static IMotorSoarInteract Create(IMotorSoarInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorSoarInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700487B RID: 18555
		// (get) Token: 0x0600F17A RID: 61818 RVA: 0x0023527A File Offset: 0x0023347A
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x040084A4 RID: 33956
		private IMotorSoarInteract Instance;
	}
}
