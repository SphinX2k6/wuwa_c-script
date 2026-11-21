using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02004025 RID: 16421
	[RequiredMember]
	public class PlotOption
	{
		// Token: 0x060298E2 RID: 170210 RVA: 0x00BBBAE4 File Offset: 0x00BB9CE4
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public PlotOption()
		{
		}

		// Token: 0x04016ADD RID: 92893
		[Nullable(1)]
		[RequiredMember]
		public ITalkOption Config;

		// Token: 0x04016ADE RID: 92894
		[RequiredMember]
		public bool ConditionCheck;

		// Token: 0x04016ADF RID: 92895
		[Nullable(2)]
		public Action OnClick;
	}
}
