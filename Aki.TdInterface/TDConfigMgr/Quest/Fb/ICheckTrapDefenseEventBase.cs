using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013DA RID: 5082
	public class ICheckTrapDefenseEventBase
	{
		// Token: 0x060073F0 RID: 29680 RVA: 0x00115DEE File Offset: 0x00113FEE
		[NullableContext(1)]
		public static ICheckTrapDefenseEventBase Create(ICheckTrapDefenseEventBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckTrapDefenseEventBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700260F RID: 9743
		// (get) Token: 0x060073F1 RID: 29681 RVA: 0x00115E0D File Offset: 0x0011400D
		public virtual ECheckTrapDefenseEvent Type
		{
			get
			{
				return (ECheckTrapDefenseEvent)this.Instance.Type;
			}
		}

		// Token: 0x0400431E RID: 17182
		private ICheckTrapDefenseEventBase Instance;
	}
}
