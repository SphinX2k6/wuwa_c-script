using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AC2 RID: 10946
	public class IWindProtagonistParkour4 : ILeisureInteractType
	{
		// Token: 0x0600F138 RID: 61752 RVA: 0x00234DDE File Offset: 0x00232FDE
		public static IWindProtagonistParkour4 Create(IWindProtagonistParkour4? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindProtagonistParkour4
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004862 RID: 18530
		// (get) Token: 0x0600F139 RID: 61753 RVA: 0x00234DFD File Offset: 0x00232FFD
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04008490 RID: 33936
		private IWindProtagonistParkour4 Instance;
	}
}
