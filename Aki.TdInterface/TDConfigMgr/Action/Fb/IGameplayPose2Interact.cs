using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ABC RID: 10940
	public class IGameplayPose2Interact : ILeisureInteractType
	{
		// Token: 0x0600F126 RID: 61734 RVA: 0x00234CA6 File Offset: 0x00232EA6
		public static IGameplayPose2Interact Create(IGameplayPose2Interact? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGameplayPose2Interact
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700485C RID: 18524
		// (get) Token: 0x0600F127 RID: 61735 RVA: 0x00234CC5 File Offset: 0x00232EC5
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x0400848A RID: 33930
		private IGameplayPose2Interact Instance;
	}
}
