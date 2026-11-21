using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045A2 RID: 17826
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueActorPool
	{
		// Token: 0x0602CEA0 RID: 183968 RVA: 0x00C90928 File Offset: 0x00C8EB28
		public void Init()
		{
			this.PoolRootActor = UiLayer.Instance.GetLayerRootUiItem(ELayerType.Pool);
			if (this.PoolRootActor == null)
			{
				Log.Instance.Error(ELogModule.Pool, ELogAuthor.YYZ, "[MapRogueActorPool] 初始缓存池有问题,挂载根节点为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x0602CEA1 RID: 183969 RVA: 0x00C90970 File Offset: 0x00C8EB70
		public void Tick(float deltaTime)
		{
			this.PeriodDeltaTime += deltaTime;
			if (this.PeriodDeltaTime < 100f)
			{
				return;
			}
			this.PeriodDeltaTime = 0f;
			int num = 0;
			foreach (MapUiActorFactory mapUiActorFactory in this.FactoryMap.Values)
			{
				num += mapUiActorFactory.GarbageCollect(10);
				if (num >= 10)
				{
					break;
				}
			}
		}

		// Token: 0x0602CEA2 RID: 183970 RVA: 0x00C909FC File Offset: 0x00C8EBFC
		public void Clear()
		{
			foreach (MapUiActorFactory mapUiActorFactory in this.FactoryMap.Values)
			{
				mapUiActorFactory.Clear();
			}
			this.PoolRootActor = null;
			this.FactoryMap.Clear();
		}

		// Token: 0x0602CEA3 RID: 183971 RVA: 0x00C90A64 File Offset: 0x00C8EC64
		public void CancelLoad()
		{
			foreach (MapUiActorFactory mapUiActorFactory in this.FactoryMap.Values)
			{
				mapUiActorFactory.CancelLoad();
			}
		}

		// Token: 0x0602CEA4 RID: 183972 RVA: 0x00C90ABC File Offset: 0x00C8ECBC
		private MapUiActorFactory TryGetFactory(string path)
		{
			MapUiActorFactory mapUiActorFactory;
			if (!this.FactoryMap.TryGetValue(path, out mapUiActorFactory))
			{
				mapUiActorFactory = new MapUiActorFactory(path, this.PoolRootActor);
				this.FactoryMap[path] = mapUiActorFactory;
			}
			return mapUiActorFactory;
		}

		// Token: 0x0602CEA5 RID: 183973 RVA: 0x00C90AF4 File Offset: 0x00C8ECF4
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<UiPoolActor> GetAsync(string path, [Nullable(2)] UUIItem parent = null)
		{
			return this.TryGetFactory(path).GetAsync(path, parent);
		}

		// Token: 0x0602CEA6 RID: 183974 RVA: 0x00C90B04 File Offset: 0x00C8ED04
		public void RecycleAsync(UiPoolActor uiPoolActor, string path)
		{
			this.TryGetFactory(path).Release(uiPoolActor);
		}

		// Token: 0x040180F7 RID: 98551
		private readonly Dictionary<string, MapUiActorFactory> FactoryMap = new Dictionary<string, MapUiActorFactory>();

		// Token: 0x040180F8 RID: 98552
		[Nullable(2)]
		private UUIItem PoolRootActor;

		// Token: 0x040180F9 RID: 98553
		private float PeriodDeltaTime;

		// Token: 0x040180FA RID: 98554
		private const int TICK_GARBAGE_MAXCOUNT = 10;

		// Token: 0x040180FB RID: 98555
		public const int PROCESSING_INTERVAL = 100;
	}
}
