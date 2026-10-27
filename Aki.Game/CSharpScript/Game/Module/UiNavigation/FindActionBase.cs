using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020048F1 RID: 18673
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class FindActionBase
	{
		// Token: 0x06030D5B RID: 200027
		public abstract void FindNavigation(FindNavigationResult result);

		// Token: 0x06030D5C RID: 200028 RVA: 0x00B57690 File Offset: 0x00B55890
		public void AddParam(object[] param)
		{
			object[] array = new object[this.Params.Length + param.Length];
			this.Params.CopyTo(array, 0);
			param.CopyTo(array, this.Params.Length);
			this.Params = array;
		}

		// Token: 0x0401A3A3 RID: 107427
		protected object[] Params = new object[0];

		// Token: 0x0401A3A4 RID: 107428
		[Nullable(2)]
		public TsUiNavigationPanelConfig PanelConfig;
	}
}
