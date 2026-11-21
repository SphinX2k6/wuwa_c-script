using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x02005660 RID: 22112
	[NullableContext(1)]
	[Nullable(0)]
	internal class DropCatchGameplayPanelViewPool<[Nullable(0)] T> where T : DropCatchGameplayPoolPanelBase
	{
		// Token: 0x060369B2 RID: 223666 RVA: 0x00F3D7C2 File Offset: 0x00F3B9C2
		public void Init([Nullable(new byte[]
		{
			1,
			0,
			1
		})] Func<UniTask<T>> createFn)
		{
			this.CreateFn = createFn;
		}

		// Token: 0x060369B3 RID: 223667 RVA: 0x00F3D7CC File Offset: 0x00F3B9CC
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

		// Token: 0x060369B4 RID: 223668 RVA: 0x00F3D80F File Offset: 0x00F3BA0F
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

		// Token: 0x060369B5 RID: 223669 RVA: 0x00F3D848 File Offset: 0x00F3BA48
		public void RecycleAll()
		{
			foreach (T t in this.Active)
			{
				t.Hide(null);
				this.Pool.Add(t);
			}
			this.Active.Clear();
		}

		// Token: 0x060369B6 RID: 223670 RVA: 0x00F3D8B8 File Offset: 0x00F3BAB8
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

		// Token: 0x0401CDCE RID: 118222
		private readonly List<T> Pool = new List<T>();

		// Token: 0x0401CDCF RID: 118223
		private readonly HashSet<T> Active = new HashSet<T>();

		// Token: 0x0401CDD0 RID: 118224
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private Func<UniTask<T>> CreateFn;
	}
}
