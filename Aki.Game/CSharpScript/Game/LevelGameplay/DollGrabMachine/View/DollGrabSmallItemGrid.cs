using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006F05 RID: 28421
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabSmallItemGrid : SmallItemGrid, IGridProxy<IGrabItemData>
	{
		// Token: 0x17009AFA RID: 39674
		// (get) Token: 0x060452EE RID: 283374 RVA: 0x0111D26E File Offset: 0x0111B46E
		// (set) Token: 0x060452EF RID: 283375 RVA: 0x0111D276 File Offset: 0x0111B476
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

		// Token: 0x17009AFB RID: 39675
		// (get) Token: 0x060452F0 RID: 283376 RVA: 0x0111D27F File Offset: 0x0111B47F
		// (set) Token: 0x060452F1 RID: 283377 RVA: 0x0111D287 File Offset: 0x0111B487
		public int GridIndex { get; set; }

		// Token: 0x17009AFC RID: 39676
		// (get) Token: 0x060452F2 RID: 283378 RVA: 0x0111D290 File Offset: 0x0111B490
		// (set) Token: 0x060452F3 RID: 283379 RVA: 0x0111D298 File Offset: 0x0111B498
		public int DisplayIndex { get; set; }

		// Token: 0x060452F4 RID: 283380 RVA: 0x0111D2A4 File Offset: 0x0111B4A4
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

		// Token: 0x060452F5 RID: 283381 RVA: 0x0111D2EA File Offset: 0x0111B4EA
		public void Clear()
		{
		}

		// Token: 0x060452F6 RID: 283382 RVA: 0x0111D2EC File Offset: 0x0111B4EC
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x060452F7 RID: 283383 RVA: 0x0111D2EE File Offset: 0x0111B4EE
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x060452F8 RID: 283384 RVA: 0x0111D2F0 File Offset: 0x0111B4F0
		public object GetKey(IGrabItemData data, int gridIndex)
		{
			return this.GridIndex;
		}
	}
}
