using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CF0 RID: 11504
	public class IRecordTimeStampType : IDungeonEventType
	{
		// Token: 0x0600FBEB RID: 64491 RVA: 0x00247503 File Offset: 0x00245703
		public static IRecordTimeStampType Create(IRecordTimeStampType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecordTimeStampType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EB9 RID: 20153
		// (get) Token: 0x0600FBEC RID: 64492 RVA: 0x00247522 File Offset: 0x00245722
		public override EDungeonEventType Type
		{
			get
			{
				return (EDungeonEventType)this.Instance.Type;
			}
		}

		// Token: 0x17004EBA RID: 20154
		// (get) Token: 0x0600FBED RID: 64493 RVA: 0x0024752F File Offset: 0x0024572F
		public virtual ETimeStampType TimeStampType
		{
			get
			{
				return (ETimeStampType)this.Instance.TimeStampType;
			}
		}

		// Token: 0x04008996 RID: 35222
		private IRecordTimeStampType Instance;
	}
}
