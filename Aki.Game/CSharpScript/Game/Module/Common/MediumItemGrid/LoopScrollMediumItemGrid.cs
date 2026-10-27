using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02005B50 RID: 23376
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class LoopScrollMediumItemGrid<[Nullable(2)] TData> : MediumItemGrid, IGridProxy<TData>
	{
		// Token: 0x17008CA7 RID: 36007
		// (get) Token: 0x0603B2EC RID: 242412 RVA: 0x00E1C472 File Offset: 0x00E1A672
		// (set) Token: 0x0603B2ED RID: 242413 RVA: 0x00E1C47A File Offset: 0x00E1A67A
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

		// Token: 0x17008CA8 RID: 36008
		// (get) Token: 0x0603B2EE RID: 242414 RVA: 0x00E1C483 File Offset: 0x00E1A683
		// (set) Token: 0x0603B2EF RID: 242415 RVA: 0x00E1C48B File Offset: 0x00E1A68B
		public int GridIndex { get; set; }

		// Token: 0x17008CA9 RID: 36009
		// (get) Token: 0x0603B2F0 RID: 242416 RVA: 0x00E1C494 File Offset: 0x00E1A694
		// (set) Token: 0x0603B2F1 RID: 242417 RVA: 0x00E1C49C File Offset: 0x00E1A69C
		public int DisplayIndex { get; set; }

		// Token: 0x0603B2F2 RID: 242418 RVA: 0x00E1C4A5 File Offset: 0x00E1A6A5
		public void Refresh(TData data, bool isSelected, int gridIndex)
		{
			this.OnRefresh(data, isSelected, gridIndex);
		}

		// Token: 0x0603B2F3 RID: 242419
		protected abstract void OnRefresh(TData data, bool isSelected, int gridIndex);

		// Token: 0x0603B2F4 RID: 242420 RVA: 0x00E1C4B0 File Offset: 0x00E1A6B0
		public void Clear()
		{
		}

		// Token: 0x0603B2F5 RID: 242421 RVA: 0x00E1C4B2 File Offset: 0x00E1A6B2
		public virtual void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x0603B2F6 RID: 242422 RVA: 0x00E1C4B4 File Offset: 0x00E1A6B4
		public virtual void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x0603B2F7 RID: 242423 RVA: 0x00E1C4B6 File Offset: 0x00E1A6B6
		public virtual void CreateThenShowByActor(AActor actor)
		{
			base.CreateThenShowByActor(actor, null);
		}

		// Token: 0x0603B2F8 RID: 242424 RVA: 0x00E1C4C0 File Offset: 0x00E1A6C0
		public virtual UniTask CreateThenShowByActorAsync(AActor actor)
		{
			LoopScrollMediumItemGrid<TData>.<CreateThenShowByActorAsync>d__18 <CreateThenShowByActorAsync>d__;
			<CreateThenShowByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateThenShowByActorAsync>d__.<>4__this = this;
			<CreateThenShowByActorAsync>d__.actor = actor;
			<CreateThenShowByActorAsync>d__.<>1__state = -1;
			<CreateThenShowByActorAsync>d__.<>t__builder.Start<LoopScrollMediumItemGrid<TData>.<CreateThenShowByActorAsync>d__18>(ref <CreateThenShowByActorAsync>d__);
			return <CreateThenShowByActorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B2F9 RID: 242425 RVA: 0x00E1C50C File Offset: 0x00E1A70C
		public virtual UniTask CreateByActorAsync(AActor actor)
		{
			LoopScrollMediumItemGrid<TData>.<CreateByActorAsync>d__19 <CreateByActorAsync>d__;
			<CreateByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateByActorAsync>d__.<>4__this = this;
			<CreateByActorAsync>d__.actor = actor;
			<CreateByActorAsync>d__.<>1__state = -1;
			<CreateByActorAsync>d__.<>t__builder.Start<LoopScrollMediumItemGrid<TData>.<CreateByActorAsync>d__19>(ref <CreateByActorAsync>d__);
			return <CreateByActorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B2FA RID: 242426 RVA: 0x00E1C557 File Offset: 0x00E1A757
		public virtual object GetKey(TData data, int gridIndex)
		{
			return this.GridIndex;
		}
	}
}
