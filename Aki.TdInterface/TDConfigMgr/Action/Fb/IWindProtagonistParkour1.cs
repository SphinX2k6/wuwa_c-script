using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ABF RID: 10943
	public class IWindProtagonistParkour1 : ILeisureInteractType
	{
		// Token: 0x0600F12F RID: 61743 RVA: 0x00234D42 File Offset: 0x00232F42
		public static IWindProtagonistParkour1 Create(IWindProtagonistParkour1? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindProtagonistParkour1
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700485F RID: 18527
		// (get) Token: 0x0600F130 RID: 61744 RVA: 0x00234D61 File Offset: 0x00232F61
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x0400848D RID: 33933
		private IWindProtagonistParkour1 Instance;
	}
}
