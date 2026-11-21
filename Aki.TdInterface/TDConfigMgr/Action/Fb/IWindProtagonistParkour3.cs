using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AC1 RID: 10945
	public class IWindProtagonistParkour3 : ILeisureInteractType
	{
		// Token: 0x0600F135 RID: 61749 RVA: 0x00234DAA File Offset: 0x00232FAA
		public static IWindProtagonistParkour3 Create(IWindProtagonistParkour3? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindProtagonistParkour3
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004861 RID: 18529
		// (get) Token: 0x0600F136 RID: 61750 RVA: 0x00234DC9 File Offset: 0x00232FC9
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x0400848F RID: 33935
		private IWindProtagonistParkour3 Instance;
	}
}
