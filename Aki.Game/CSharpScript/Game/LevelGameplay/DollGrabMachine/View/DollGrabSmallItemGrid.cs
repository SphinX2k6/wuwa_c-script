using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006086 RID: 24710
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabSmallItemGrid : SmallItemGrid, IGridProxy<IGrabItemData>
	{
		// Token: 0x17007039 RID: 28729
		// (get) Token: 0x0603B49C RID: 242844 RVA: 0x010C720E File Offset: 0x010C540E
		// (set) Token: 0x0603B49D RID: 242845 RVA: 0x010C7216 File Offset: 0x010C5416
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public IScrollViewDelegate<IGridProxy<IGrabItemData>, IGrabItemData> ScrollViewDelegate { [return: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] set; }

		// Token: 0x1700703A RID: 28730
		// (get) Token: 0x0603B49E RID: 242846 RVA: 0x010C721F File Offset: 0x010C541F
		// (set) Token: 0x0603B49F RID: 242847 RVA: 0x010C7227 File Offset: 0x010C5427
		public int GridIndex { get; set; }

		// Token: 0x1700703B RID: 28731
		// (get) Token: 0x0603B4A0 RID: 242848 RVA: 0x010C7230 File Offset: 0x010C5430
		// (set) Token: 0x0603B4A1 RID: 242849 RVA: 0x010C7238 File Offset: 0x010C5438
		public int DisplayIndex { get; set; }

		// Token: 0x0603B4A2 RID: 242850 RVA: 0x010C7244 File Offset: 0x010C5444
		public void Refresh(IGrabItemData data, bool isSelected, int gridIndex)
		{
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				Data = data,
				ItemConfigId = new int?(data.ItemId),
				BottomText = data.Count.ToString()
			};
			base.Apply<PropSmallItemGrid>(parameters);
		}

		// Token: 0x0603B4A3 RID: 242851 RVA: 0x010C728A File Offset: 0x010C548A
		public void Clear()
		{
		}

		// Token: 0x0603B4A4 RID: 242852 RVA: 0x010C728C File Offset: 0x010C548C
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x0603B4A5 RID: 242853 RVA: 0x010C728E File Offset: 0x010C548E
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x0603B4A6 RID: 242854 RVA: 0x010C7290 File Offset: 0x010C5490
		public object GetKey(IGrabItemData data, int gridIndex)
		{
			return this.GridIndex;
		}
	}
}
