using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A03 RID: 10755
	public class IRecordTimeStampType : IDungeonEventType
	{
		// Token: 0x0600ED54 RID: 60756 RVA: 0x00229B7F File Offset: 0x00227D7F
		[NullableContext(1)]
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

		// Token: 0x17004B10 RID: 19216
		// (get) Token: 0x0600ED55 RID: 60757 RVA: 0x00229B9E File Offset: 0x00227D9E
		public override EDungeonEventType Type
		{
			get
			{
				return (EDungeonEventType)this.Instance.Type;
			}
		}

		// Token: 0x17004B11 RID: 19217
		// (get) Token: 0x0600ED56 RID: 60758 RVA: 0x00229BAB File Offset: 0x00227DAB
		public virtual ETimeStampType TimeStampType
		{
			get
			{
				return (ETimeStampType)this.Instance.TimeStampType;
			}
		}

		// Token: 0x040082A5 RID: 33445
		private IRecordTimeStampType Instance;
	}
}
