using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048C7 RID: 18631
	[NullableContext(1)]
	public interface IGridProxy<[Nullable(2)] TData>
	{
		// Token: 0x17007982 RID: 31106
		// (get) Token: 0x06030B29 RID: 199465
		// (set) Token: 0x06030B2A RID: 199466
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

		// Token: 0x17007983 RID: 31107
		// (get) Token: 0x06030B2B RID: 199467
		// (set) Token: 0x06030B2C RID: 199468
		int GridIndex { get; set; }

		// Token: 0x17007984 RID: 31108
		// (get) Token: 0x06030B2D RID: 199469
		// (set) Token: 0x06030B2E RID: 199470
		int DisplayIndex { get; set; }

		// Token: 0x06030B2F RID: 199471 RVA: 0x00B4EE47 File Offset: 0x00B4D047
		void Refresh(TData data, bool isSelected, int gridIndex)
		{
		}

		// Token: 0x06030B30 RID: 199472 RVA: 0x00B4EE4C File Offset: 0x00B4D04C
		UniTask RefreshAsync(TData data, bool isSelected, int gridIndex)
		{
			IGridProxy<TData>.<RefreshAsync>d__10 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<IGridProxy<TData>.<RefreshAsync>d__10>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030B31 RID: 199473
		void Clear();

		// Token: 0x06030B32 RID: 199474
		void OnSelected(bool fireEvent);

		// Token: 0x06030B33 RID: 199475
		void OnDeselected(bool fireEvent);

		// Token: 0x06030B34 RID: 199476
		void CreateThenShowByActor(AActor actor, [Nullable(2)] object parameters = null);

		// Token: 0x06030B35 RID: 199477
		UniTask CreateThenShowByActorAsync(AActor actor, [Nullable(2)] object parameters = null, bool usePool = false);

		// Token: 0x06030B36 RID: 199478
		UniTask CreateByActorAsync(AActor actor, [Nullable(2)] object parameters = null, bool usePool = false);

		// Token: 0x06030B37 RID: 199479
		object GetKey(TData data, int gridIndex);
	}
}
