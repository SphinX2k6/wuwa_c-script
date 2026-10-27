using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x02006710 RID: 26384
	[NullableContext(1)]
	[Nullable(0)]
	internal class DropCatchGameplayPanelViewPool<[Nullable(0)] T> where T : DropCatchGameplayPoolPanelBase
	{
		// Token: 0x06041E66 RID: 269926 RVA: 0x00FFC3F6 File Offset: 0x00FFA5F6
		public void Init([Nullable(new byte[]
		{
			1,
			0,
			1
		})] Func<UniTask<T>> createFn)
		{
			this.CreateFn = createFn;
		}

		// Token: 0x06041E67 RID: 269927 RVA: 0x00FFC400 File Offset: 0x00FFA600
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<T> GetAsync()
		{
			DropCatchGameplayPanelViewPool<T>.<GetAsync>d__4 <GetAsync>d__;
			<GetAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<T>.Create();
			<GetAsync>d__.<>4__this = this;
			<GetAsync>d__.<>1__state = -1;
			<GetAsync>d__.<>t__builder.Start<DropCatchGameplayPanelViewPool<T>.<GetAsync>d__4>(ref <GetAsync>d__);
			return <GetAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041E68 RID: 269928 RVA: 0x00FFC443 File Offset: 0x00FFA643
		public void Recycle(T view)
		{
			if (!this.Active.Contains(view))
			{
				return;
			}
			this.Active.Remove(view);
			view.Hide(null);
			this.Pool.Add(view);
		}

		// Token: 0x06041E69 RID: 269929 RVA: 0x00FFC47C File Offset: 0x00FFA67C
		public void RecycleAll()
		{
			foreach (T t in this.Active)
			{
				t.Hide(null);
				this.Pool.Add(t);
			}
			this.Active.Clear();
		}

		// Token: 0x06041E6A RID: 269930 RVA: 0x00FFC4EC File Offset: 0x00FFA6EC
		public void DestroyAll()
		{
			foreach (T t in this.Active)
			{
				t.Destroy(null);
			}
			this.Active.Clear();
			foreach (T t2 in this.Pool)
			{
				t2.Destroy(null);
			}
			this.Pool.Clear();
		}

		// Token: 0x04022575 RID: 140661
		private readonly List<T> Pool = new List<T>();

		// Token: 0x04022576 RID: 140662
		private readonly HashSet<T> Active = new HashSet<T>();

		// Token: 0x04022577 RID: 140663
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private Func<UniTask<T>> CreateFn;
	}
}
