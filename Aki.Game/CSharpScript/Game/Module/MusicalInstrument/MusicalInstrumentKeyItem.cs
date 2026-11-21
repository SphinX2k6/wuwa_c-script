using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x02004353 RID: 17235
	public abstract class MusicalInstrumentKeyItem : UiPanelBase
	{
		// Token: 0x0602B877 RID: 178295 RVA: 0x00C3B709 File Offset: 0x00C39909
		public virtual void OnQteFocus(bool isFocus)
		{
		}

		// Token: 0x0602B878 RID: 178296 RVA: 0x00C3B70B File Offset: 0x00C3990B
		public virtual void OnQtePerformance(bool success)
		{
		}

		// Token: 0x04017823 RID: 96291
		public int RowIndex;

		// Token: 0x04017824 RID: 96292
		public int ColumnIndex;

		// Token: 0x04017825 RID: 96293
		[Nullable(2)]
		public Action<int, int> OnPointerDownCallback;
	}
}
