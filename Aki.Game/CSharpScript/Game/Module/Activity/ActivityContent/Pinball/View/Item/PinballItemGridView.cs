using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x020052C2 RID: 21186
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class PinballItemGridView<[Nullable(2)] TData> : PinballItemView, IGridProxy<!0>
	{
		// Token: 0x1700666E RID: 26222
		// (get) Token: 0x06034BE6 RID: 216038 RVA: 0x00EC0A6B File Offset: 0x00EBEC6B
		// (set) Token: 0x06034BE7 RID: 216039 RVA: 0x00EC0A73 File Offset: 0x00EBEC73
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public IScrollViewDelegate<IGridProxy<TData>, TData> ScrollViewDelegate { [return: Nullable(new byte[]
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

		// Token: 0x1700666F RID: 26223
		// (get) Token: 0x06034BE8 RID: 216040 RVA: 0x00EC0A7C File Offset: 0x00EBEC7C
		// (set) Token: 0x06034BE9 RID: 216041 RVA: 0x00EC0A84 File Offset: 0x00EBEC84
		public int GridIndex { get; set; }

		// Token: 0x17006670 RID: 26224
		// (get) Token: 0x06034BEA RID: 216042 RVA: 0x00EC0A8D File Offset: 0x00EBEC8D
		// (set) Token: 0x06034BEB RID: 216043 RVA: 0x00EC0A95 File Offset: 0x00EBEC95
		public int DisplayIndex { get; set; }

		// Token: 0x06034BEC RID: 216044
		public abstract UniTask RefreshAsync(TData data, bool isSelected, int gridIndex);

		// Token: 0x06034BED RID: 216045
		public abstract void Refresh(TData data, bool isSelected, int gridIndex);

		// Token: 0x06034BEE RID: 216046 RVA: 0x00EC0A9E File Offset: 0x00EBEC9E
		public void Clear()
		{
		}

		// Token: 0x06034BEF RID: 216047 RVA: 0x00EC0AA0 File Offset: 0x00EBECA0
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x06034BF0 RID: 216048 RVA: 0x00EC0AA2 File Offset: 0x00EBECA2
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x06034BF1 RID: 216049 RVA: 0x00EC0AA4 File Offset: 0x00EBECA4
		public object GetKey(TData data, int gridIndex)
		{
			return this.GridIndex;
		}
	}
}
