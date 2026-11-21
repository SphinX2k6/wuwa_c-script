using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AD1 RID: 10961
	public class ILandSlideInteract : ILeisureInteractType
	{
		// Token: 0x0600F169 RID: 61801 RVA: 0x0023514A File Offset: 0x0023334A
		public static ILandSlideInteract Create(ILandSlideInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILandSlideInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004875 RID: 18549
		// (get) Token: 0x0600F16A RID: 61802 RVA: 0x00235169 File Offset: 0x00233369
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x0400849F RID: 33951
		private ILandSlideInteract Instance;
	}
}
