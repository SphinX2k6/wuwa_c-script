using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EEF RID: 3823
	public class IDollGrabItem
	{
		// Token: 0x0600560F RID: 22031 RVA: 0x000D3516 File Offset: 0x000D1716
		public static IDollGrabItem Create(IDollGrabItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollGrabItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C2C RID: 7212
		// (get) Token: 0x06005610 RID: 22032 RVA: 0x000D3535 File Offset: 0x000D1735
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17001C2D RID: 7213
		// (get) Token: 0x06005611 RID: 22033 RVA: 0x000D3542 File Offset: 0x000D1742
		public virtual int ItemId
		{
			get
			{
				return this.Instance.ItemId;
			}
		}

		// Token: 0x0400314C RID: 12620
		private IDollGrabItem Instance;
	}
}
