using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x02005370 RID: 21360
	public abstract class MusicalInstrumentKeyItem : UiPanelBase
	{
		// Token: 0x06036931 RID: 223537 RVA: 0x00CEC87D File Offset: 0x00CEAA7D
		public virtual void OnQteFocus(bool isFocus)
		{
		}

		// Token: 0x06036932 RID: 223538 RVA: 0x00CEC87F File Offset: 0x00CEAA7F
		public virtual void OnQtePerformance(bool success)
		{
		}

		// Token: 0x0401CD8D RID: 118157
		public int RowIndex;

		// Token: 0x0401CD8E RID: 118158
		public int ColumnIndex;

		// Token: 0x0401CD8F RID: 118159
		[Nullable(2)]
		public Action<int, int> OnPointerDownCallback;
	}
}
