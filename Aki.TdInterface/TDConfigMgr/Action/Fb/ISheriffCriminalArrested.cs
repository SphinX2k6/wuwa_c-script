using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A2A RID: 10794
	public class ISheriffCriminalArrested : ICommonTipType
	{
		// Token: 0x0600EE89 RID: 61065 RVA: 0x0022FD0E File Offset: 0x0022DF0E
		public static ISheriffCriminalArrested Create(ISheriffCriminalArrested? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISheriffCriminalArrested
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046E3 RID: 18147
		// (get) Token: 0x0600EE8A RID: 61066 RVA: 0x0022FD2D File Offset: 0x0022DF2D
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046E4 RID: 18148
		// (get) Token: 0x0600EE8B RID: 61067 RVA: 0x0022FD3A File Offset: 0x0022DF3A
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x0400830A RID: 33546
		private ISheriffCriminalArrested Instance;
	}
}
