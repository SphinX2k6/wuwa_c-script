using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x0200383E RID: 14398
	[NullableContext(1)]
	public interface IGridProxy<[Nullable(2)] TData>
	{
		// Token: 0x17004CEA RID: 19690
		// (get) Token: 0x06025655 RID: 153173
		// (set) Token: 0x06025656 RID: 153174
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		IScrollViewDelegate<IGridProxy<TData>, TData> ScrollViewDelegate { [return: Nullable(new byte[]
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

		// Token: 0x17004CEB RID: 19691
		// (get) Token: 0x06025657 RID: 153175
		// (set) Token: 0x06025658 RID: 153176
		int GridIndex { get; set; }

		// Token: 0x17004CEC RID: 19692
		// (get) Token: 0x06025659 RID: 153177
		// (set) Token: 0x0602565A RID: 153178
		int DisplayIndex { get; set; }

		// Token: 0x0602565B RID: 153179 RVA: 0x00A89C4F File Offset: 0x00A87E4F
		void Refresh(TData data, bool isSelected, int gridIndex)
		{
		}

		// Token: 0x0602565C RID: 153180 RVA: 0x00A89C54 File Offset: 0x00A87E54
		UniTask RefreshAsync(TData data, bool isSelected, int gridIndex)
		{
			IGridProxy<TData>.<RefreshAsync>d__10 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<IGridProxy<TData>.<RefreshAsync>d__10>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602565D RID: 153181
		void Clear();

		// Token: 0x0602565E RID: 153182
		void OnSelected(bool fireEvent);

		// Token: 0x0602565F RID: 153183
		void OnDeselected(bool fireEvent);

		// Token: 0x06025660 RID: 153184
		void CreateThenShowByActor(AActor actor, [Nullable(2)] object parameters = null);

		// Token: 0x06025661 RID: 153185
		UniTask CreateThenShowByActorAsync(AActor actor, [Nullable(2)] object parameters = null, bool usePool = false);

		// Token: 0x06025662 RID: 153186
		UniTask CreateByActorAsync(AActor actor, [Nullable(2)] object parameters = null, bool usePool = false);

		// Token: 0x06025663 RID: 153187
		object GetKey(TData data, int gridIndex);
	}
}
