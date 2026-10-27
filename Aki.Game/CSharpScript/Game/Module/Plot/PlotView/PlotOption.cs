using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02005055 RID: 20565
	[RequiredMember]
	public class PlotOption
	{
		// Token: 0x060349EF RID: 215535 RVA: 0x00C6E844 File Offset: 0x00C6CA44
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public PlotOption()
		{
		}

		// Token: 0x0401C0B2 RID: 114866
		[Nullable(1)]
		[RequiredMember]
		public ITalkOption Config;

		// Token: 0x0401C0B3 RID: 114867
		[RequiredMember]
		public bool ConditionCheck;

		// Token: 0x0401C0B4 RID: 114868
		[Nullable(2)]
		public Action OnClick;
	}
}
