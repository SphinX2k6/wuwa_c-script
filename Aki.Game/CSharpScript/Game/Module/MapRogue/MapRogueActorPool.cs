using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055CC RID: 21964
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueActorPool
	{
		// Token: 0x06037FA2 RID: 229282 RVA: 0x00D42BE0 File Offset: 0x00D40DE0
		public void Init()
		{
			this.PoolRootActor = UiLayer.Instance.GetLayerRootUiItem(ELayerType.Pool);
			if (this.PoolRootActor == null)
			{
				Log.Instance.Error(ELogModule.Pool, ELogAuthor.YYZ, "[MapRogueActorPool] 初始缓存池有问题,挂载根节点为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x06037FA3 RID: 229283 RVA: 0x00D42C28 File Offset: 0x00D40E28
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

		// Token: 0x06037FA4 RID: 229284 RVA: 0x00D42CB4 File Offset: 0x00D40EB4
		public void Clear()
		{
			foreach (MapUiActorFactory mapUiActorFactory in this.FactoryMap.Values)
			{
				mapUiActorFactory.Clear();
			}
			this.PoolRootActor = null;
			this.FactoryMap.Clear();
		}

		// Token: 0x06037FA5 RID: 229285 RVA: 0x00D42D1C File Offset: 0x00D40F1C
		public void CancelLoad()
		{
			foreach (MapUiActorFactory mapUiActorFactory in this.FactoryMap.Values)
			{
				mapUiActorFactory.CancelLoad();
			}
		}

		// Token: 0x06037FA6 RID: 229286 RVA: 0x00D42D74 File Offset: 0x00D40F74
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

		// Token: 0x06037FA7 RID: 229287 RVA: 0x00D42DAC File Offset: 0x00D40FAC
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<UiPoolActor> GetAsync(string path, [Nullable(2)] UUIItem parent = null)
		{
			return this.TryGetFactory(path).GetAsync(path, parent);
		}

		// Token: 0x06037FA8 RID: 229288 RVA: 0x00D42DBC File Offset: 0x00D40FBC
		public void RecycleAsync(UiPoolActor uiPoolActor, string path)
		{
			this.TryGetFactory(path).Release(uiPoolActor);
		}

		// Token: 0x0401D66C RID: 120428
		private readonly Dictionary<string, MapUiActorFactory> FactoryMap = new Dictionary<string, MapUiActorFactory>();

		// Token: 0x0401D66D RID: 120429
		[Nullable(2)]
		private UUIItem PoolRootActor;

		// Token: 0x0401D66E RID: 120430
		private float PeriodDeltaTime;

		// Token: 0x0401D66F RID: 120431
		private const int TICK_GARBAGE_MAXCOUNT = 10;

		// Token: 0x0401D670 RID: 120432
		public const int PROCESSING_INTERVAL = 100;
	}
}
