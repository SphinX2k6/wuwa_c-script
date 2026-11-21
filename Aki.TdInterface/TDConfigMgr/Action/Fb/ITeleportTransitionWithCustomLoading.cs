using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002957 RID: 10583
	public class ITeleportTransitionWithCustomLoading : ITeleportTransitionType
	{
		// Token: 0x0600EAF0 RID: 60144 RVA: 0x0022A3F7 File Offset: 0x002285F7
		public static ITeleportTransitionWithCustomLoading Create(ITeleportTransitionWithCustomLoading? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionWithCustomLoading
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044F0 RID: 17648
		// (get) Token: 0x0600EAF1 RID: 60145 RVA: 0x0022A416 File Offset: 0x00228616
		public override ETeleportTransitionType Type
		{
			get
			{
				return (ETeleportTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x170044F1 RID: 17649
		// (get) Token: 0x0600EAF2 RID: 60146 RVA: 0x0022A423 File Offset: 0x00228623
		public virtual int ConfigId
		{
			get
			{
				return this.Instance.ConfigId;
			}
		}

		// Token: 0x0400816B RID: 33131
		private ITeleportTransitionWithCustomLoading Instance;
	}
}
