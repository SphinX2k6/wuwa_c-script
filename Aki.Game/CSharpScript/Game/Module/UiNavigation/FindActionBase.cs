using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003868 RID: 14440
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class FindActionBase
	{
		// Token: 0x06025888 RID: 153736
		public abstract void FindNavigation(FindNavigationResult result);

		// Token: 0x06025889 RID: 153737 RVA: 0x00A92500 File Offset: 0x00A90700
		public void AddParam(object[] param)
		{
			object[] array = new object[this.Params.Length + param.Length];
			this.Params.CopyTo(array, 0);
			param.CopyTo(array, this.Params.Length);
			this.Params = array;
		}

		// Token: 0x04014C16 RID: 85014
		protected object[] Params = new object[0];

		// Token: 0x04014C17 RID: 85015
		[Nullable(2)]
		public TsUiNavigationPanelConfig PanelConfig;
	}
}
