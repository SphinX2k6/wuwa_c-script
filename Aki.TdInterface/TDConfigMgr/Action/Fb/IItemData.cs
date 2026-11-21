using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028FF RID: 10495
	public class IItemData
	{
		// Token: 0x0600E97F RID: 59775 RVA: 0x00227A8A File Offset: 0x00225C8A
		public static IItemData Create(IItemData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700442F RID: 17455
		// (get) Token: 0x0600E980 RID: 59776 RVA: 0x00227AA9 File Offset: 0x00225CA9
		public virtual int ItemId
		{
			get
			{
				return this.Instance.ItemId;
			}
		}

		// Token: 0x17004430 RID: 17456
		// (get) Token: 0x0600E981 RID: 59777 RVA: 0x00227AB6 File Offset: 0x00225CB6
		public virtual int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x040080AF RID: 32943
		private IItemData Instance;
	}
}
