using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035F8 RID: 13816
	[NullableContext(1)]
	[Nullable(0)]
	internal class UiActorFactory
	{
		// Token: 0x060232E7 RID: 144103 RVA: 0x009FEAE6 File Offset: 0x009FCCE6
		private UiPoolActor Creator()
		{
			return new UiPoolActor(this.PathInternal)
			{
				EndTime = Time.Instance.Now + 30000.0
			};
		}

		// Token: 0x060232E8 RID: 144104 RVA: 0x009FEB0D File Offset: 0x009FCD0D
		private void Clearer(UiPoolActor uiPoolActor)
		{
			uiPoolActor.Clear();
		}

		// Token: 0x060232E9 RID: 144105 RVA: 0x009FEB18 File Offset: 0x009FCD18
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

		// Token: 0x060232EA RID: 144106 RVA: 0x009FEBA4 File Offset: 0x009FCDA4
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

		// Token: 0x060232EB RID: 144107 RVA: 0x009FEBF0 File Offset: 0x009FCDF0
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

		// Token: 0x060232EC RID: 144108 RVA: 0x009FEC80 File Offset: 0x009FCE80
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

		// Token: 0x060232ED RID: 144109 RVA: 0x009FECF8 File Offset: 0x009FCEF8
		public void Clear()
		{
			while (!this.Queue.Empty)
			{
				UiPoolActor uiPoolActor = this.Queue.Pop();
				this.Clearer(uiPoolActor);
			}
			this.Queue.Clear();
		}

		// Token: 0x060232EE RID: 144110 RVA: 0x009FED34 File Offset: 0x009FCF34
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

		// Token: 0x060232EF RID: 144111 RVA: 0x009FED78 File Offset: 0x009FCF78
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

		// Token: 0x060232F0 RID: 144112 RVA: 0x009FEDCB File Offset: 0x009FCFCB
		public void CancelGetAsync()
		{
			LguiResourceManager.Instance.CancelLoadPrefab(this.AsyncHandleId);
			this.AsyncHandleId = LguiResourceManager.Instance.InvalidId;
		}

		// Token: 0x04013DA1 RID: 81313
		private readonly string PathInternal = "";

		// Token: 0x04013DA2 RID: 81314
		[Nullable(2)]
		private readonly UUIItem PoolRootInternal;

		// Token: 0x04013DA3 RID: 81315
		private int PoolCacheCount;

		// Token: 0x04013DA4 RID: 81316
		public bool IsKeepWhileCleaning;

		// Token: 0x04013DA5 RID: 81317
		private readonly Queue<UiPoolActor> Queue = new Queue<UiPoolActor>(15);

		// Token: 0x04013DA6 RID: 81318
		private int AsyncHandleId = LguiResourceManager.Instance.InvalidId;
	}
}
