using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AC3 RID: 10947
	public class IWindProtagonistParkour5 : ILeisureInteractType
	{
		// Token: 0x0600F13B RID: 61755 RVA: 0x00234E12 File Offset: 0x00233012
		public static IWindProtagonistParkour5 Create(IWindProtagonistParkour5? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindProtagonistParkour5
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004863 RID: 18531
		// (get) Token: 0x0600F13C RID: 61756 RVA: 0x00234E31 File Offset: 0x00233031
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04008491 RID: 33937
		private IWindProtagonistParkour5 Instance;
	}
}
