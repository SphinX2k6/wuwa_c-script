using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029F2 RID: 10738
	public class ISetAlertValueType
	{
		// Token: 0x0600ED13 RID: 60691 RVA: 0x002296C8 File Offset: 0x002278C8
		[NullableContext(1)]
		public static ISetAlertValueType Create(ISetAlertValueType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetAlertValueType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AF1 RID: 19185
		// (get) Token: 0x0600ED14 RID: 60692 RVA: 0x002296E7 File Offset: 0x002278E7
		public virtual EValueChangeType Type
		{
			get
			{
				return (EValueChangeType)this.Instance.Type;
			}
		}

		// Token: 0x0400828C RID: 33420
		private ISetAlertValueType Instance;
	}
}
