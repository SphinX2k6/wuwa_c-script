using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02004B2F RID: 19247
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class LoopScrollMediumItemGrid<[Nullable(2)] TData> : MediumItemGrid, IGridProxy<TData>
	{
		// Token: 0x17006079 RID: 24697
		// (get) Token: 0x06030235 RID: 197173 RVA: 0x00D6C8BA File Offset: 0x00D6AABA
		// (set) Token: 0x06030236 RID: 197174 RVA: 0x00D6C8C2 File Offset: 0x00D6AAC2
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

		// Token: 0x1700607A RID: 24698
		// (get) Token: 0x06030237 RID: 197175 RVA: 0x00D6C8CB File Offset: 0x00D6AACB
		// (set) Token: 0x06030238 RID: 197176 RVA: 0x00D6C8D3 File Offset: 0x00D6AAD3
		public int GridIndex { get; set; }

		// Token: 0x1700607B RID: 24699
		// (get) Token: 0x06030239 RID: 197177 RVA: 0x00D6C8DC File Offset: 0x00D6AADC
		// (set) Token: 0x0603023A RID: 197178 RVA: 0x00D6C8E4 File Offset: 0x00D6AAE4
		public int DisplayIndex { get; set; }

		// Token: 0x0603023B RID: 197179 RVA: 0x00D6C8ED File Offset: 0x00D6AAED
		public void Refresh(TData data, bool isSelected, int gridIndex)
		{
			this.OnRefresh(data, isSelected, gridIndex);
		}

		// Token: 0x0603023C RID: 197180
		protected abstract void OnRefresh(TData data, bool isSelected, int gridIndex);

		// Token: 0x0603023D RID: 197181 RVA: 0x00D6C8F8 File Offset: 0x00D6AAF8
		public void Clear()
		{
		}

		// Token: 0x0603023E RID: 197182 RVA: 0x00D6C8FA File Offset: 0x00D6AAFA
		public virtual void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x0603023F RID: 197183 RVA: 0x00D6C8FC File Offset: 0x00D6AAFC
		public virtual void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x06030240 RID: 197184 RVA: 0x00D6C8FE File Offset: 0x00D6AAFE
		public virtual void CreateThenShowByActor(AActor actor)
		{
			base.CreateThenShowByActor(actor, null);
		}

		// Token: 0x06030241 RID: 197185 RVA: 0x00D6C908 File Offset: 0x00D6AB08
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

		// Token: 0x06030242 RID: 197186 RVA: 0x00D6C954 File Offset: 0x00D6AB54
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

		// Token: 0x06030243 RID: 197187 RVA: 0x00D6C99F File Offset: 0x00D6AB9F
		public virtual object GetKey(TData data, int gridIndex)
		{
			return this.GridIndex;
		}
	}
}
