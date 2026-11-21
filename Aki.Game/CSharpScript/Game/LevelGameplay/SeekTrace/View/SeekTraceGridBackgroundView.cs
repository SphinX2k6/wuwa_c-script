using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.SeekTrace.View
{
	// Token: 0x02005BC0 RID: 23488
	public class SeekTraceGridBackgroundView : UiPanelBase, IGridProxy<bool>
	{
		// Token: 0x17006E01 RID: 28161
		// (get) Token: 0x06039BBD RID: 236477 RVA: 0x01037FFE File Offset: 0x010361FE
		// (set) Token: 0x06039BBE RID: 236478 RVA: 0x01038006 File Offset: 0x01036206
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

		// Token: 0x17006E02 RID: 28162
		// (get) Token: 0x06039BBF RID: 236479 RVA: 0x0103800F File Offset: 0x0103620F
		// (set) Token: 0x06039BC0 RID: 236480 RVA: 0x01038017 File Offset: 0x01036217
		public int GridIndex { get; set; }

		// Token: 0x17006E03 RID: 28163
		// (get) Token: 0x06039BC1 RID: 236481 RVA: 0x01038020 File Offset: 0x01036220
		// (set) Token: 0x06039BC2 RID: 236482 RVA: 0x01038028 File Offset: 0x01036228
		public int DisplayIndex { get; set; }

		// Token: 0x06039BC3 RID: 236483 RVA: 0x01038031 File Offset: 0x01036231
		public void Refresh(bool enable, bool isSelected, int gridIndex)
		{
			if (!enable)
			{
				base.GetRootItem().SetAlpha(0f);
			}
		}

		// Token: 0x06039BC4 RID: 236484 RVA: 0x01038046 File Offset: 0x01036246
		public void Clear()
		{
		}

		// Token: 0x06039BC5 RID: 236485 RVA: 0x01038048 File Offset: 0x01036248
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x06039BC6 RID: 236486 RVA: 0x0103804A File Offset: 0x0103624A
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x06039BC7 RID: 236487 RVA: 0x0103804C File Offset: 0x0103624C
		[NullableContext(2)]
		public object GetKey(bool data, int gridIndex)
		{
			return this.GridIndex;
		}
	}
}
