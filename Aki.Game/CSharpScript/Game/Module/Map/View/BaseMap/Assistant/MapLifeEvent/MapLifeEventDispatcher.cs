using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapLifeEvent
{
	// Token: 0x02004484 RID: 17540
	[NullableContext(1)]
	[Nullable(0)]
	public class MapLifeEventDispatcher
	{
		// Token: 0x0602C520 RID: 181536 RVA: 0x00C76BFE File Offset: 0x00C74DFE
		public MapLifeEventDispatcher(BaseMap map)
		{
			this.TargetExpressionMap = map;
			Dictionary<EMapLifeEventListenerType, MapLifeEventListener> dictionary = new Dictionary<EMapLifeEventListenerType, MapLifeEventListener>();
			dictionary[EMapLifeEventListenerType.SceneGameplayUnlock] = new MapSceneGameplayUnlock(this.TargetExpressionMap);
			this.Listeners = dictionary;
		}

		// Token: 0x0602C521 RID: 181537 RVA: 0x00C76C2C File Offset: 0x00C74E2C
		public UniTask OnWorldMapBeforeStartAsync()
		{
			MapLifeEventDispatcher.<OnWorldMapBeforeStartAsync>d__3 <OnWorldMapBeforeStartAsync>d__;
			<OnWorldMapBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnWorldMapBeforeStartAsync>d__.<>4__this = this;
			<OnWorldMapBeforeStartAsync>d__.<>1__state = -1;
			<OnWorldMapBeforeStartAsync>d__.<>t__builder.Start<MapLifeEventDispatcher.<OnWorldMapBeforeStartAsync>d__3>(ref <OnWorldMapBeforeStartAsync>d__);
			return <OnWorldMapBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C522 RID: 181538 RVA: 0x00C76C70 File Offset: 0x00C74E70
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

		// Token: 0x0602C523 RID: 181539 RVA: 0x00C76CF8 File Offset: 0x00C74EF8
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

		// Token: 0x0602C524 RID: 181540 RVA: 0x00C76D80 File Offset: 0x00C74F80
		public void OnWorldBeforeDestroy()
		{
		}

		// Token: 0x04017D4B RID: 97611
		[Nullable(2)]
		private readonly BaseMap TargetExpressionMap;

		// Token: 0x04017D4C RID: 97612
		private readonly Dictionary<EMapLifeEventListenerType, MapLifeEventListener> Listeners;
	}
}
