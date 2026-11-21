using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AD9 RID: 10969
	public class IFoxPutDown : ILeisureInteractType
	{
		// Token: 0x0600F185 RID: 61829 RVA: 0x0023534A File Offset: 0x0023354A
		public static IFoxPutDown Create(IFoxPutDown? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFoxPutDown
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004881 RID: 18561
		// (get) Token: 0x0600F186 RID: 61830 RVA: 0x00235369 File Offset: 0x00233569
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x040084A7 RID: 33959
		private IFoxPutDown Instance;
	}
}
