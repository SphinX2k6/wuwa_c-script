using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item
{
	// Token: 0x020041A7 RID: 16807
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CommonGridCardItem<[Nullable(2)] TItemData> : CommonBaseCardItem<TItemData>, IGridProxy<TItemData>
	{
		// Token: 0x17005577 RID: 21879
		// (get) Token: 0x0602A8E4 RID: 174308 RVA: 0x00C01903 File Offset: 0x00BFFB03
		// (set) Token: 0x0602A8E5 RID: 174309 RVA: 0x00C0190B File Offset: 0x00BFFB0B
		public IScrollViewDelegate<IGridProxy<TItemData>, TItemData> ScrollViewDelegate { get; set; }

		// Token: 0x17005578 RID: 21880
		// (get) Token: 0x0602A8E6 RID: 174310 RVA: 0x00C01914 File Offset: 0x00BFFB14
		// (set) Token: 0x0602A8E7 RID: 174311 RVA: 0x00C0191C File Offset: 0x00BFFB1C
		public int GridIndex { get; set; }

		// Token: 0x17005579 RID: 21881
		// (get) Token: 0x0602A8E8 RID: 174312 RVA: 0x00C01925 File Offset: 0x00BFFB25
		// (set) Token: 0x0602A8E9 RID: 174313 RVA: 0x00C0192D File Offset: 0x00BFFB2D
		public int DisplayIndex { get; set; }

		// Token: 0x0602A8EA RID: 174314 RVA: 0x00C01936 File Offset: 0x00BFFB36
		public override void Refresh(TItemData data)
		{
		}

		// Token: 0x0602A8EB RID: 174315 RVA: 0x00C01938 File Offset: 0x00BFFB38
		public virtual void Refresh(TItemData data, bool isSelected, int gridIndex)
		{
		}

		// Token: 0x0602A8EC RID: 174316 RVA: 0x00C0193A File Offset: 0x00BFFB3A
		public virtual UniTask RefreshAsync(TItemData data, bool isSelected, int gridIndex)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602A8ED RID: 174317 RVA: 0x00C01941 File Offset: 0x00BFFB41
		public void Clear()
		{
		}

		// Token: 0x0602A8EE RID: 174318 RVA: 0x00C01943 File Offset: 0x00BFFB43
		public virtual void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x0602A8EF RID: 174319 RVA: 0x00C01945 File Offset: 0x00BFFB45
		public virtual void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x0602A8F0 RID: 174320 RVA: 0x00C01947 File Offset: 0x00BFFB47
		public virtual object GetKey(TItemData data, int gridIndex)
		{
			return this.GridIndex;
		}
	}
}
