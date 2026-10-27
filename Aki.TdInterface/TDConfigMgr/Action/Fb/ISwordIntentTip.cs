using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002760 RID: 10080
	public class ISwordIntentTip : ICommonTipType
	{
		// Token: 0x0600E095 RID: 57493 RVA: 0x0021329A File Offset: 0x0021149A
		[NullableContext(1)]
		public static ISwordIntentTip Create(ISwordIntentTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwordIntentTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004397 RID: 17303
		// (get) Token: 0x0600E096 RID: 57494 RVA: 0x002132B9 File Offset: 0x002114B9
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x04007C60 RID: 31840
		private ISwordIntentTip Instance;
	}
}
