using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item
{
	// Token: 0x020051D7 RID: 20951
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CommonGridCardItem<[Nullable(2)] TItemData> : CommonBaseCardItem<TItemData>, IGridProxy<TItemData>
	{
		// Token: 0x170081B7 RID: 33207
		// (get) Token: 0x060359E9 RID: 219625 RVA: 0x00CB42C7 File Offset: 0x00CB24C7
		// (set) Token: 0x060359EA RID: 219626 RVA: 0x00CB42CF File Offset: 0x00CB24CF
		public IScrollViewDelegate<IGridProxy<TItemData>, TItemData> ScrollViewDelegate { get; set; }

		// Token: 0x170081B8 RID: 33208
		// (get) Token: 0x060359EB RID: 219627 RVA: 0x00CB42D8 File Offset: 0x00CB24D8
		// (set) Token: 0x060359EC RID: 219628 RVA: 0x00CB42E0 File Offset: 0x00CB24E0
		public int GridIndex { get; set; }

		// Token: 0x170081B9 RID: 33209
		// (get) Token: 0x060359ED RID: 219629 RVA: 0x00CB42E9 File Offset: 0x00CB24E9
		// (set) Token: 0x060359EE RID: 219630 RVA: 0x00CB42F1 File Offset: 0x00CB24F1
		public int DisplayIndex { get; set; }

		// Token: 0x060359EF RID: 219631 RVA: 0x00CB42FA File Offset: 0x00CB24FA
		public override void Refresh(TItemData data)
		{
		}

		// Token: 0x060359F0 RID: 219632 RVA: 0x00CB42FC File Offset: 0x00CB24FC
		public virtual void Refresh(TItemData data, bool isSelected, int gridIndex)
		{
		}

		// Token: 0x060359F1 RID: 219633 RVA: 0x00CB42FE File Offset: 0x00CB24FE
		public virtual UniTask RefreshAsync(TItemData data, bool isSelected, int gridIndex)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x060359F2 RID: 219634 RVA: 0x00CB4305 File Offset: 0x00CB2505
		public void Clear()
		{
		}

		// Token: 0x060359F3 RID: 219635 RVA: 0x00CB4307 File Offset: 0x00CB2507
		public virtual void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x060359F4 RID: 219636 RVA: 0x00CB4309 File Offset: 0x00CB2509
		public virtual void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x060359F5 RID: 219637 RVA: 0x00CB430B File Offset: 0x00CB250B
		public virtual object GetKey(TItemData data, int gridIndex)
		{
			return this.GridIndex;
		}
	}
}
