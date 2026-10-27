using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapLifeEvent
{
	// Token: 0x020054A1 RID: 21665
	[NullableContext(1)]
	[Nullable(0)]
	public class MapLifeEventDispatcher
	{
		// Token: 0x060375CC RID: 226764 RVA: 0x00D26FAA File Offset: 0x00D251AA
		public MapLifeEventDispatcher(BaseMap map)
		{
			this.TargetExpressionMap = map;
			Dictionary<EMapLifeEventListenerType, MapLifeEventListener> dictionary = new Dictionary<EMapLifeEventListenerType, MapLifeEventListener>();
			dictionary[EMapLifeEventListenerType.SceneGameplayUnlock] = new MapSceneGameplayUnlock(this.TargetExpressionMap);
			this.Listeners = dictionary;
		}

		// Token: 0x060375CD RID: 226765 RVA: 0x00D26FD8 File Offset: 0x00D251D8
		public UniTask OnWorldMapBeforeStartAsync()
		{
			MapLifeEventDispatcher.<OnWorldMapBeforeStartAsync>d__3 <OnWorldMapBeforeStartAsync>d__;
			<OnWorldMapBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnWorldMapBeforeStartAsync>d__.<>4__this = this;
			<OnWorldMapBeforeStartAsync>d__.<>1__state = -1;
			<OnWorldMapBeforeStartAsync>d__.<>t__builder.Start<MapLifeEventDispatcher.<OnWorldMapBeforeStartAsync>d__3>(ref <OnWorldMapBeforeStartAsync>d__);
			return <OnWorldMapBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060375CE RID: 226766 RVA: 0x00D2701C File Offset: 0x00D2521C
		public void OnWorldMapBeforeShow()
		{
			foreach (KeyValuePair<EMapLifeEventListenerType, MapLifeEventListener> keyValuePair in this.Listeners)
			{
				EMapLifeEventListenerType key = keyValuePair.Key;
				MapLifeEventListener value = keyValuePair.Value;
				Dictionary<EMapLifeEventListenerType, IMapLifeEventTriggerParam> mapLifeEventListenerTriggerMap = MapModel.Instance.MapLifeEventListenerTriggerMap;
				IMapLifeEventTriggerParam mapLifeEventTriggerParam;
				if (mapLifeEventListenerTriggerMap != null && mapLifeEventListenerTriggerMap.TryGetValue(key, out mapLifeEventTriggerParam) && mapLifeEventTriggerParam.State)
				{
					value.OnWorldMapBeforeShow();
				}
			}
		}

		// Token: 0x060375CF RID: 226767 RVA: 0x00D270A4 File Offset: 0x00D252A4
		public void OnWorldMapAfterShow()
		{
			foreach (KeyValuePair<EMapLifeEventListenerType, MapLifeEventListener> keyValuePair in this.Listeners)
			{
				EMapLifeEventListenerType key = keyValuePair.Key;
				MapLifeEventListener value = keyValuePair.Value;
				Dictionary<EMapLifeEventListenerType, IMapLifeEventTriggerParam> mapLifeEventListenerTriggerMap = MapModel.Instance.MapLifeEventListenerTriggerMap;
				IMapLifeEventTriggerParam mapLifeEventTriggerParam;
				if (mapLifeEventListenerTriggerMap != null && mapLifeEventListenerTriggerMap.TryGetValue(key, out mapLifeEventTriggerParam) && mapLifeEventTriggerParam.State)
				{
					value.OnWorldMapAfterShow();
				}
			}
		}

		// Token: 0x060375D0 RID: 226768 RVA: 0x00D2712C File Offset: 0x00D2532C
		public void OnWorldBeforeDestroy()
		{
		}

		// Token: 0x0401D2AF RID: 119471
		[Nullable(2)]
		private readonly BaseMap TargetExpressionMap;

		// Token: 0x0401D2B0 RID: 119472
		private readonly Dictionary<EMapLifeEventListenerType, MapLifeEventListener> Listeners;
	}
}
