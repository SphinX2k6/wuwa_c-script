using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A19 RID: 10777
	public class IRemainStarWarning : ICommonTipType
	{
		// Token: 0x0600EE2D RID: 60973 RVA: 0x0022F7A8 File Offset: 0x0022D9A8
		public static IRemainStarWarning Create(IRemainStarWarning? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemainStarWarning
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046A9 RID: 18089
		// (get) Token: 0x0600EE2E RID: 60974 RVA: 0x0022F7C7 File Offset: 0x0022D9C7
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046AA RID: 18090
		// (get) Token: 0x0600EE2F RID: 60975 RVA: 0x0022F7D4 File Offset: 0x0022D9D4
		public virtual string WarningText
		{
			get
			{
				return this.Instance.WarningText;
			}
		}

		// Token: 0x040082F9 RID: 33529
		private IRemainStarWarning Instance;
	}
}
