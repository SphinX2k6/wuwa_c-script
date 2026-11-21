using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A1A RID: 10778
	public class ISlashAndTowerTip : ICommonTipType
	{
		// Token: 0x0600EE31 RID: 60977 RVA: 0x0022F7E9 File Offset: 0x0022D9E9
		public static ISlashAndTowerTip Create(ISlashAndTowerTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlashAndTowerTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046AB RID: 18091
		// (get) Token: 0x0600EE32 RID: 60978 RVA: 0x0022F808 File Offset: 0x0022DA08
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046AC RID: 18092
		// (get) Token: 0x0600EE33 RID: 60979 RVA: 0x0022F815 File Offset: 0x0022DA15
		public virtual string WarningText
		{
			get
			{
				return this.Instance.WarningText;
			}
		}

		// Token: 0x040082FA RID: 33530
		private ISlashAndTowerTip Instance;
	}
}
