using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C37 RID: 11319
	public class IEnablePlayerAiControl : IPlayerAiControlBase
	{
		// Token: 0x0600F90C RID: 63756 RVA: 0x00243196 File Offset: 0x00241396
		public static IEnablePlayerAiControl Create(IEnablePlayerAiControl? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnablePlayerAiControl
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D4C RID: 19788
		// (get) Token: 0x0600F90D RID: 63757 RVA: 0x002431B5 File Offset: 0x002413B5
		public override EPlayerAiControlType Type
		{
			get
			{
				return (EPlayerAiControlType)this.Instance.Type;
			}
		}

		// Token: 0x17004D4D RID: 19789
		// (get) Token: 0x0600F90E RID: 63758 RVA: 0x002431C2 File Offset: 0x002413C2
		public virtual int BehaviorTree
		{
			get
			{
				return this.Instance.BehaviorTree;
			}
		}

		// Token: 0x04008823 RID: 34851
		private IEnablePlayerAiControl Instance;
	}
}
