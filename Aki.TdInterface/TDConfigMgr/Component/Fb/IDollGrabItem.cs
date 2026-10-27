using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DF3 RID: 3571
	public class IDollGrabItem
	{
		// Token: 0x060050E8 RID: 20712 RVA: 0x000C7C4E File Offset: 0x000C5E4E
		[NullableContext(1)]
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

		// Token: 0x17001ABF RID: 6847
		// (get) Token: 0x060050E9 RID: 20713 RVA: 0x000C7C6D File Offset: 0x000C5E6D
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17001AC0 RID: 6848
		// (get) Token: 0x060050EA RID: 20714 RVA: 0x000C7C7A File Offset: 0x000C5E7A
		public virtual int ItemId
		{
			get
			{
				return this.Instance.ItemId;
			}
		}

		// Token: 0x04002E84 RID: 11908
		private IDollGrabItem Instance;
	}
}
