using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024D6 RID: 9430
	public class FinishCondition : ActionParams
	{
		// Token: 0x0600D29E RID: 53918 RVA: 0x001F3EFB File Offset: 0x001F20FB
		[NullableContext(1)]
		public static FinishCondition Create(IFinishCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FinishCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04007384 RID: 29572
		private IFinishCondition Instance;
	}
}
