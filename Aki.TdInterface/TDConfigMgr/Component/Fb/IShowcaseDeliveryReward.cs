using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DFE RID: 3582
	public class IShowcaseDeliveryReward
	{
		// Token: 0x0600511E RID: 20766 RVA: 0x000C8330 File Offset: 0x000C6530
		[NullableContext(1)]
		public static IShowcaseDeliveryReward Create(IShowcaseDeliveryReward? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowcaseDeliveryReward
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001ADF RID: 6879
		// (get) Token: 0x0600511F RID: 20767 RVA: 0x000C834F File Offset: 0x000C654F
		public virtual int AchievedDollCount
		{
			get
			{
				return this.Instance.AchievedDollCount;
			}
		}

		// Token: 0x17001AE0 RID: 6880
		// (get) Token: 0x06005120 RID: 20768 RVA: 0x000C835C File Offset: 0x000C655C
		public virtual int DropId
		{
			get
			{
				return this.Instance.DropId;
			}
		}

		// Token: 0x04002EA7 RID: 11943
		private IShowcaseDeliveryReward Instance;
	}
}
