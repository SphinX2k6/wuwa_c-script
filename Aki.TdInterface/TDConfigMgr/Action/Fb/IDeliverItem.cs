using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002663 RID: 9827
	public class IDeliverItem
	{
		// Token: 0x0600DC3E RID: 56382 RVA: 0x0020C3C9 File Offset: 0x0020A5C9
		[NullableContext(1)]
		public static IDeliverItem Create(IDeliverItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeliverItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700413A RID: 16698
		// (get) Token: 0x0600DC3F RID: 56383 RVA: 0x0020C3E8 File Offset: 0x0020A5E8
		public virtual int ItemId
		{
			get
			{
				return this.Instance.ItemId;
			}
		}

		// Token: 0x1700413B RID: 16699
		// (get) Token: 0x0600DC40 RID: 56384 RVA: 0x0020C3F5 File Offset: 0x0020A5F5
		public virtual int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x04007A67 RID: 31335
		private IDeliverItem Instance;
	}
}
