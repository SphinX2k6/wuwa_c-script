using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DF4 RID: 3572
	public class IDollGrabStandbyPoolItem
	{
		// Token: 0x060050EC RID: 20716 RVA: 0x000C7C8F File Offset: 0x000C5E8F
		[NullableContext(1)]
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

		// Token: 0x17001AC1 RID: 6849
		// (get) Token: 0x060050ED RID: 20717 RVA: 0x000C7CAE File Offset: 0x000C5EAE
		public virtual int UniqueId
		{
			get
			{
				return this.Instance.UniqueId;
			}
		}

		// Token: 0x17001AC2 RID: 6850
		// (get) Token: 0x060050EE RID: 20718 RVA: 0x000C7CBB File Offset: 0x000C5EBB
		public virtual int ItemId
		{
			get
			{
				return this.Instance.ItemId;
			}
		}

		// Token: 0x04002E85 RID: 11909
		private IDollGrabStandbyPoolItem Instance;
	}
}
