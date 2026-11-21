using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ABD RID: 10941
	public class IGameplayPose3Interact : ILeisureInteractType
	{
		// Token: 0x0600F129 RID: 61737 RVA: 0x00234CDA File Offset: 0x00232EDA
		public static IGameplayPose3Interact Create(IGameplayPose3Interact? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGameplayPose3Interact
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700485D RID: 18525
		// (get) Token: 0x0600F12A RID: 61738 RVA: 0x00234CF9 File Offset: 0x00232EF9
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x0400848B RID: 33931
		private IGameplayPose3Interact Instance;
	}
}
