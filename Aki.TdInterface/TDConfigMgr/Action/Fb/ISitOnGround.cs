using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AA8 RID: 10920
	public class ISitOnGround : ILeisureInteractType
	{
		// Token: 0x0600F0CA RID: 61642 RVA: 0x0023437E File Offset: 0x0023257E
		public static ISitOnGround Create(ISitOnGround? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISitOnGround
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004828 RID: 18472
		// (get) Token: 0x0600F0CB RID: 61643 RVA: 0x0023439D File Offset: 0x0023259D
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04008460 RID: 33888
		private ISitOnGround Instance;
	}
}
