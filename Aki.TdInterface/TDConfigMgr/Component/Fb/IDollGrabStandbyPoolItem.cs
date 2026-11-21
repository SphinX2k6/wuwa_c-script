using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EF0 RID: 3824
	public class IDollGrabStandbyPoolItem
	{
		// Token: 0x06005613 RID: 22035 RVA: 0x000D3557 File Offset: 0x000D1757
		public static IDollGrabStandbyPoolItem Create(IDollGrabStandbyPoolItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollGrabStandbyPoolItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C2E RID: 7214
		// (get) Token: 0x06005614 RID: 22036 RVA: 0x000D3576 File Offset: 0x000D1776
		public virtual int UniqueId
		{
			get
			{
				return this.Instance.UniqueId;
			}
		}

		// Token: 0x17001C2F RID: 7215
		// (get) Token: 0x06005615 RID: 22037 RVA: 0x000D3583 File Offset: 0x000D1783
		public virtual int ItemId
		{
			get
			{
				return this.Instance.ItemId;
			}
		}

		// Token: 0x0400314D RID: 12621
		private IDollGrabStandbyPoolItem Instance;
	}
}
