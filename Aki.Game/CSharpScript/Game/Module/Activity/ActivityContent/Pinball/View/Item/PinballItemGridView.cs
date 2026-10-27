using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x02006344 RID: 25412
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class PinballItemGridView<[Nullable(2)] TData> : PinballItemView, IGridProxy<!0>
	{
		// Token: 0x1700930C RID: 37644
		// (get) Token: 0x0603FF25 RID: 261925 RVA: 0x00F79B0B File Offset: 0x00F77D0B
		// (set) Token: 0x0603FF26 RID: 261926 RVA: 0x00F79B13 File Offset: 0x00F77D13
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

		// Token: 0x1700930D RID: 37645
		// (get) Token: 0x0603FF27 RID: 261927 RVA: 0x00F79B1C File Offset: 0x00F77D1C
		// (set) Token: 0x0603FF28 RID: 261928 RVA: 0x00F79B24 File Offset: 0x00F77D24
		public int GridIndex { get; set; }

		// Token: 0x1700930E RID: 37646
		// (get) Token: 0x0603FF29 RID: 261929 RVA: 0x00F79B2D File Offset: 0x00F77D2D
		// (set) Token: 0x0603FF2A RID: 261930 RVA: 0x00F79B35 File Offset: 0x00F77D35
		public int DisplayIndex { get; set; }

		// Token: 0x0603FF2B RID: 261931
		public abstract UniTask RefreshAsync(TData data, bool isSelected, int gridIndex);

		// Token: 0x0603FF2C RID: 261932
		public abstract void Refresh(TData data, bool isSelected, int gridIndex);

		// Token: 0x0603FF2D RID: 261933 RVA: 0x00F79B3E File Offset: 0x00F77D3E
		public void Clear()
		{
		}

		// Token: 0x0603FF2E RID: 261934 RVA: 0x00F79B40 File Offset: 0x00F77D40
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x0603FF2F RID: 261935 RVA: 0x00F79B42 File Offset: 0x00F77D42
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x0603FF30 RID: 261936 RVA: 0x00F79B44 File Offset: 0x00F77D44
		public object GetKey(TData data, int gridIndex)
		{
			return this.GridIndex;
		}
	}
}
