using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045A1 RID: 17825
	[NullableContext(1)]
	[Nullable(0)]
	public class MapUiActorFactory
	{
		// Token: 0x0602CE99 RID: 183961 RVA: 0x00C906C7 File Offset: 0x00C8E8C7
		public MapUiActorFactory(string path, UUIItem poolRoot)
		{
			this.PathInternal = path;
			this.PoolRootInternal = poolRoot;
		}

		// Token: 0x0602CE9A RID: 183962 RVA: 0x00C90700 File Offset: 0x00C8E900
		public void Clear()
		{
			this.CancelLoad();
			foreach (UiPoolActor uiPoolActor in this.List)
			{
				uiPoolActor.Clear();
			}
			this.List.Clear();
		}

		// Token: 0x0602CE9B RID: 183963 RVA: 0x00C90764 File Offset: 0x00C8E964
		public void CancelLoad()
		{
			foreach (int id in this.ResourceIdSet)
			{
				ResourceSystem.Instance.CancelAsyncLoad(id);
			}
			this.ResourceIdSet.Clear();
		}

		// Token: 0x0602CE9C RID: 183964 RVA: 0x00C907C8 File Offset: 0x00C8E9C8
		public bool Release(UiPoolActor uiPoolActor)
		{
			if (uiPoolActor == null)
			{
				return false;
			}
			if (uiPoolActor.IsValid)
			{
				UUIItem uiItem = uiPoolActor.UiItem;
				if (uiItem != null)
				{
					uiItem.SetUIActive(false);
				}
				UUIItem uiItem2 = uiPoolActor.UiItem;
				if (uiItem2 != null)
				{
					uiItem2.SetUIParent(this.PoolRootInternal, false);
				}
				this.List.Add(uiPoolActor);
				return true;
			}
			return false;
		}

		// Token: 0x0602CE9D RID: 183965 RVA: 0x00C9081C File Offset: 0x00C8EA1C
		public int GarbageCollect(int allowGarbageCount)
		{
			if (this.List.Count <= 0)
			{
				return 0;
			}
			int num = 0;
			int num2 = 0;
			while (num2 < allowGarbageCount && this.List.Count != 0)
			{
				UiPoolActor uiPoolActor = this.List[this.List.Count - 1];
				this.List.RemoveAt(this.List.Count - 1);
				uiPoolActor.Clear();
				num++;
				num2++;
			}
			return num;
		}

		// Token: 0x0602CE9E RID: 183966 RVA: 0x00C90890 File Offset: 0x00C8EA90
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<AActor> LoadActorAsync()
		{
			MapUiActorFactory.<LoadActorAsync>d__10 <LoadActorAsync>d__;
			<LoadActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<AActor>.Create();
			<LoadActorAsync>d__.<>4__this = this;
			<LoadActorAsync>d__.<>1__state = -1;
			<LoadActorAsync>d__.<>t__builder.Start<MapUiActorFactory.<LoadActorAsync>d__10>(ref <LoadActorAsync>d__);
			return <LoadActorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602CE9F RID: 183967 RVA: 0x00C908D4 File Offset: 0x00C8EAD4
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<UiPoolActor> GetAsync(string path, [Nullable(2)] UUIItem parent = null)
		{
			MapUiActorFactory.<GetAsync>d__11 <GetAsync>d__;
			<GetAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<UiPoolActor>.Create();
			<GetAsync>d__.<>4__this = this;
			<GetAsync>d__.path = path;
			<GetAsync>d__.parent = parent;
			<GetAsync>d__.<>1__state = -1;
			<GetAsync>d__.<>t__builder.Start<MapUiActorFactory.<GetAsync>d__11>(ref <GetAsync>d__);
			return <GetAsync>d__.<>t__builder.Task;
		}

		// Token: 0x040180F2 RID: 98546
		private readonly string PathInternal = "";

		// Token: 0x040180F3 RID: 98547
		private readonly UUIItem PoolRootInternal;

		// Token: 0x040180F4 RID: 98548
		private readonly List<UiPoolActor> List = new List<UiPoolActor>();

		// Token: 0x040180F5 RID: 98549
		private readonly HashSet<int> ResourceIdSet = new HashSet<int>();

		// Token: 0x040180F6 RID: 98550
		private const int ACTOR_MAX_CACHE_COUNT = 0;
	}
}
