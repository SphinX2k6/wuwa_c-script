using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002509 RID: 9481
	public class ITalkOptionPreConditionBase
	{
		// Token: 0x0600D389 RID: 54153 RVA: 0x001F59CA File Offset: 0x001F3BCA
		[NullableContext(1)]
		public static ITalkOptionPreConditionBase Create(ITalkOptionPreConditionBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionPreConditionBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B39 RID: 15161
		// (get) Token: 0x0600D38A RID: 54154 RVA: 0x001F59E9 File Offset: 0x001F3BE9
		public virtual ETalkOptionPreConditionType Type
		{
			get
			{
				return (ETalkOptionPreConditionType)this.Instance.Type;
			}
		}

		// Token: 0x040073F5 RID: 29685
		private ITalkOptionPreConditionBase Instance;
	}
}
