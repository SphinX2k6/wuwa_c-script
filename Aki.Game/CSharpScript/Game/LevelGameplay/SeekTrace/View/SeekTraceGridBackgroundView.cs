using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.SeekTrace.View
{
	// Token: 0x02006A63 RID: 27235
	public class SeekTraceGridBackgroundView : UiPanelBase, IGridProxy<bool>
	{
		// Token: 0x1700991C RID: 39196
		// (get) Token: 0x06043B6F RID: 277359 RVA: 0x010937CA File Offset: 0x010919CA
		// (set) Token: 0x06043B70 RID: 277360 RVA: 0x010937D2 File Offset: 0x010919D2
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public IScrollViewDelegate<IGridProxy<bool>, bool> ScrollViewDelegate { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x1700991D RID: 39197
		// (get) Token: 0x06043B71 RID: 277361 RVA: 0x010937DB File Offset: 0x010919DB
		// (set) Token: 0x06043B72 RID: 277362 RVA: 0x010937E3 File Offset: 0x010919E3
		public int GridIndex { get; set; }

		// Token: 0x1700991E RID: 39198
		// (get) Token: 0x06043B73 RID: 277363 RVA: 0x010937EC File Offset: 0x010919EC
		// (set) Token: 0x06043B74 RID: 277364 RVA: 0x010937F4 File Offset: 0x010919F4
		public int DisplayIndex { get; set; }

		// Token: 0x06043B75 RID: 277365 RVA: 0x010937FD File Offset: 0x010919FD
		public void Refresh(bool enable, bool isSelected, int gridIndex)
		{
			if (!enable)
			{
				base.GetRootItem().SetAlpha(0f);
			}
		}

		// Token: 0x06043B76 RID: 277366 RVA: 0x01093812 File Offset: 0x01091A12
		public void Clear()
		{
		}

		// Token: 0x06043B77 RID: 277367 RVA: 0x01093814 File Offset: 0x01091A14
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x06043B78 RID: 277368 RVA: 0x01093816 File Offset: 0x01091A16
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x06043B79 RID: 277369 RVA: 0x01093818 File Offset: 0x01091A18
		[NullableContext(2)]
		public object GetKey(bool data, int gridIndex)
		{
			return this.GridIndex;
		}
	}
}
