using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AD0 RID: 10960
	public class ISunPalaceInteract : ILeisureInteractType
	{
		// Token: 0x0600F166 RID: 61798 RVA: 0x00235116 File Offset: 0x00233316
		public static ISunPalaceInteract Create(ISunPalaceInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISunPalaceInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004874 RID: 18548
		// (get) Token: 0x0600F167 RID: 61799 RVA: 0x00235135 File Offset: 0x00233335
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x0400849E RID: 33950
		private ISunPalaceInteract Instance;
	}
}
