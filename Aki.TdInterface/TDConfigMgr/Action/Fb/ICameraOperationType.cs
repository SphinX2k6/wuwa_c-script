using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C2B RID: 11307
	public class ICameraOperationType
	{
		// Token: 0x0600F8D7 RID: 63703 RVA: 0x00242B0E File Offset: 0x00240D0E
		public static ICameraOperationType Create(ICameraOperationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraOperationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D2F RID: 19759
		// (get) Token: 0x0600F8D8 RID: 63704 RVA: 0x00242B2D File Offset: 0x00240D2D
		public virtual ECameraOperationType Type
		{
			get
			{
				return (ECameraOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008815 RID: 34837
		private ICameraOperationType Instance;
	}
}
