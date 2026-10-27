using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055CB RID: 21963
	[NullableContext(1)]
	[Nullable(0)]
	public class MapUiActorFactory
	{
		// Token: 0x06037F9B RID: 229275 RVA: 0x00D4297F File Offset: 0x00D40B7F
		public MapUiActorFactory(string path, UUIItem poolRoot)
		{
			this.PathInternal = path;
			this.PoolRootInternal = poolRoot;
		}

		// Token: 0x06037F9C RID: 229276 RVA: 0x00D429B8 File Offset: 0x00D40BB8
		public void Clear()
		{
			this.CancelLoad();
			foreach (UiPoolActor uiPoolActor in this.List)
			{
				uiPoolActor.Clear();
			}
			this.List.Clear();
		}

		// Token: 0x06037F9D RID: 229277 RVA: 0x00D42A1C File Offset: 0x00D40C1C
		public void CancelLoad()
		{
			foreach (int id in this.ResourceIdSet)
			{
				ResourceSystem.Instance.CancelAsyncLoad(id);
			}
			this.ResourceIdSet.Clear();
		}

		// Token: 0x06037F9E RID: 229278 RVA: 0x00D42A80 File Offset: 0x00D40C80
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

		// Token: 0x06037F9F RID: 229279 RVA: 0x00D42AD4 File Offset: 0x00D40CD4
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

		// Token: 0x06037FA0 RID: 229280 RVA: 0x00D42B48 File Offset: 0x00D40D48
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

		// Token: 0x06037FA1 RID: 229281 RVA: 0x00D42B8C File Offset: 0x00D40D8C
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

		// Token: 0x0401D667 RID: 120423
		private readonly string PathInternal = "";

		// Token: 0x0401D668 RID: 120424
		private readonly UUIItem PoolRootInternal;

		// Token: 0x0401D669 RID: 120425
		private readonly List<UiPoolActor> List = new List<UiPoolActor>();

		// Token: 0x0401D66A RID: 120426
		private readonly HashSet<int> ResourceIdSet = new HashSet<int>();

		// Token: 0x0401D66B RID: 120427
		private const int ACTOR_MAX_CACHE_COUNT = 0;
	}
}
