using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AC1 RID: 10945
	public class IPhoneRecordActionConfig
	{
		// Token: 0x0600F02F RID: 61487 RVA: 0x0022E279 File Offset: 0x0022C479
		[NullableContext(1)]
		public static IPhoneRecordActionConfig Create(IPhoneRecordActionConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhoneRecordActionConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C6F RID: 19567
		// (get) Token: 0x0600F030 RID: 61488 RVA: 0x0022E298 File Offset: 0x0022C498
		public virtual int? PhoneMessageId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.PhoneMessageId);
			}
		}

		// Token: 0x17004C70 RID: 19568
		// (get) Token: 0x0600F031 RID: 61489 RVA: 0x0022E2D0 File Offset: 0x0022C4D0
		public virtual int? DialogProgress
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.DialogProgress);
			}
		}

		// Token: 0x0400841D RID: 33821
		private IPhoneRecordActionConfig Instance;
	}
}
