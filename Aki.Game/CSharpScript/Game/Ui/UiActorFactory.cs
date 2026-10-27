using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046C7 RID: 18119
	[NullableContext(1)]
	[Nullable(0)]
	internal class UiActorFactory
	{
		// Token: 0x0602EB9B RID: 191387 RVA: 0x00AD0152 File Offset: 0x00ACE352
		private UiPoolActor Creator()
		{
			return new UiPoolActor(this.PathInternal)
			{
				EndTime = Time.Instance.Now + 30000.0
			};
		}

		// Token: 0x0602EB9C RID: 191388 RVA: 0x00AD0179 File Offset: 0x00ACE379
		private void Clearer(UiPoolActor uiPoolActor)
		{
			uiPoolActor.Clear();
		}

		// Token: 0x0602EB9D RID: 191389 RVA: 0x00AD0184 File Offset: 0x00ACE384
		public UiActorFactory(string path, [Nullable(2)] UUIItem poolRoot)
		{
			this.PathInternal = path;
			this.PoolRootInternal = poolRoot;
			Func<int> func;
			this.PoolCacheCount = (UiActorPool.Instance.PrepareConfigMap.TryGetValue(path, out func) ? func() : 0);
			if (poolRoot == null)
			{
				Log.Instance.Error(ELogModule.Pool, ELogAuthor.XXJ, "[UiActorFactory:constructor]初始化缓存池有问题,缓存池挂载根节点为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x0602EB9E RID: 191390 RVA: 0x00AD0210 File Offset: 0x00ACE410
		public UniTask PreloadActor(Func<int> cacheCount)
		{
			UiActorFactory.<PreloadActor>d__8 <PreloadActor>d__;
			<PreloadActor>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadActor>d__.<>4__this = this;
			<PreloadActor>d__.cacheCount = cacheCount;
			<PreloadActor>d__.<>1__state = -1;
			<PreloadActor>d__.<>t__builder.Start<UiActorFactory.<PreloadActor>d__8>(ref <PreloadActor>d__);
			return <PreloadActor>d__.<>t__builder.Task;
		}

		// Token: 0x0602EB9F RID: 191391 RVA: 0x00AD025C File Offset: 0x00ACE45C
		public bool Release(UiPoolActor uiPoolActor)
		{
			if (uiPoolActor == null)
			{
				Log.Instance.Error(ELogModule.Pool, ELogAuthor.TL, "回收UiPoolActor对象不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.CancelGetAsync();
				return false;
			}
			this.Queue.Push(uiPoolActor);
			if (uiPoolActor.IsValid)
			{
				UUIItem uiItem = uiPoolActor.UiItem;
				if (uiItem != null)
				{
					uiItem.SetUIParent(this.PoolRootInternal, false);
				}
				uiPoolActor.EndTime = Time.Instance.Now + 30000.0;
			}
			else
			{
				uiPoolActor.EndTime = Time.Instance.Now;
			}
			return true;
		}

		// Token: 0x0602EBA0 RID: 191392 RVA: 0x00AD02EC File Offset: 0x00ACE4EC
		public int GarbageCollect(int allowGarbageCount)
		{
			if (this.Queue.Size <= this.PoolCacheCount)
			{
				return allowGarbageCount;
			}
			int num = 0;
			int num2 = 0;
			while (num2 < allowGarbageCount && !this.Queue.Empty)
			{
				UiPoolActor front = this.Queue.Front;
				if (front.EndTime > Time.Instance.Now)
				{
					break;
				}
				this.Queue.Pop();
				this.Clearer(front);
				num++;
				num2++;
			}
			return allowGarbageCount - num;
		}

		// Token: 0x0602EBA1 RID: 191393 RVA: 0x00AD0364 File Offset: 0x00ACE564
		public void Clear()
		{
			while (!this.Queue.Empty)
			{
				UiPoolActor uiPoolActor = this.Queue.Pop();
				this.Clearer(uiPoolActor);
			}
			this.Queue.Clear();
		}

		// Token: 0x0602EBA2 RID: 191394 RVA: 0x00AD03A0 File Offset: 0x00ACE5A0
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<AActor> LoadActorAsync()
		{
			UiActorFactory.<LoadActorAsync>d__13 <LoadActorAsync>d__;
			<LoadActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<AActor>.Create();
			<LoadActorAsync>d__.<>4__this = this;
			<LoadActorAsync>d__.<>1__state = -1;
			<LoadActorAsync>d__.<>t__builder.Start<UiActorFactory.<LoadActorAsync>d__13>(ref <LoadActorAsync>d__);
			return <LoadActorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EBA3 RID: 191395 RVA: 0x00AD03E4 File Offset: 0x00ACE5E4
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<UiPoolActor> GetAsync(string path, [Nullable(2)] UUIItem parent = null)
		{
			UiActorFactory.<GetAsync>d__14 <GetAsync>d__;
			<GetAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<UiPoolActor>.Create();
			<GetAsync>d__.<>4__this = this;
			<GetAsync>d__.path = path;
			<GetAsync>d__.parent = parent;
			<GetAsync>d__.<>1__state = -1;
			<GetAsync>d__.<>t__builder.Start<UiActorFactory.<GetAsync>d__14>(ref <GetAsync>d__);
			return <GetAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EBA4 RID: 191396 RVA: 0x00AD0437 File Offset: 0x00ACE637
		public void CancelGetAsync()
		{
			LguiResourceManager.Instance.CancelLoadPrefab(this.AsyncHandleId);
			this.AsyncHandleId = LguiResourceManager.Instance.InvalidId;
		}

		// Token: 0x040196FA RID: 104186
		private readonly string PathInternal = "";

		// Token: 0x040196FB RID: 104187
		[Nullable(2)]
		private readonly UUIItem PoolRootInternal;

		// Token: 0x040196FC RID: 104188
		private int PoolCacheCount;

		// Token: 0x040196FD RID: 104189
		public bool IsKeepWhileCleaning;

		// Token: 0x040196FE RID: 104190
		private readonly Queue<UiPoolActor> Queue = new Queue<UiPoolActor>(15);

		// Token: 0x040196FF RID: 104191
		private int AsyncHandleId = LguiResourceManager.Instance.InvalidId;
	}
}
