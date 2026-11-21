using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AC0 RID: 10944
	public class IWindProtagonistParkour2 : ILeisureInteractType
	{
		// Token: 0x0600F132 RID: 61746 RVA: 0x00234D76 File Offset: 0x00232F76
		public static IWindProtagonistParkour2 Create(IWindProtagonistParkour2? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindProtagonistParkour2
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004860 RID: 18528
		// (get) Token: 0x0600F133 RID: 61747 RVA: 0x00234D95 File Offset: 0x00232F95
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x0400848E RID: 33934
		private IWindProtagonistParkour2 Instance;
	}
}
