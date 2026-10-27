using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A38 RID: 10808
	public class ActivateGiantTotalProgressNode : ActionParams
	{
		// Token: 0x0600EE0D RID: 60941 RVA: 0x0022AD92 File Offset: 0x00228F92
		[NullableContext(1)]
		public static ActivateGiantTotalProgressNode Create(IActivateGiantTotalProgressNode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ActivateGiantTotalProgressNode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04008302 RID: 33538
		private IActivateGiantTotalProgressNode Instance;
	}
}
