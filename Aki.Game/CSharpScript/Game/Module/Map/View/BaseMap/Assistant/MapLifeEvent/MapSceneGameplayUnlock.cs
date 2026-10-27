using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapLifeEvent
{
	// Token: 0x020054A4 RID: 21668
	public class MapSceneGameplayUnlock : MapLifeEventListener
	{
		// Token: 0x060375D9 RID: 226777 RVA: 0x00D27148 File Offset: 0x00D25348
		[NullableContext(1)]
		public MapSceneGameplayUnlock(BaseMap map) : base(map)
		{
		}

		// Token: 0x060375DA RID: 226778 RVA: 0x00D27154 File Offset: 0x00D25354
		public override void OnWorldMapBeforeShow()
		{
			this.Data = (MapModel.Instance.MapLifeEventListenerTriggerMap[EMapLifeEventListenerType.SceneGameplayUnlock].Data as IMapSceneGameplayUnlockData);
			List<MarkItem> list = new List<MarkItem>();
			Dictionary<int, MarkItem> markItemsByType = this.TargetExpressionMap.GetMarkItemsByType(EMarkType.FixedSceneGameplay, true);
			Dictionary<int, MarkItem> markItemsByType2 = this.TargetExpressionMap.GetMarkItemsByType(EMarkType.SceneGameplay, true);
			if (markItemsByType != null)
			{
				list.AddRange(markItemsByType.Values);
			}
			if (markItemsByType2 != null)
			{
				list.AddRange(markItemsByType2.Values);
			}
			foreach (MarkItem markItem in list)
			{
				ConfigMarkItem configMarkItem = markItem as ConfigMarkItem;
				if (configMarkItem != null && configMarkItem.MarkConfig != null)
				{
					configMarkItem.IsCanShowView = false;
					configMarkItem.ViewUpdateAsync(GeneralLogicTreeUtil.Instance.GetPlayerLocation(), false, false).Forget();
				}
			}
		}

		// Token: 0x060375DB RID: 226779 RVA: 0x00D27238 File Offset: 0x00D25438
		public override void OnWorldMapAfterShow()
		{
			this.TargetExpressionMap.HandleSceneGamePlayMarkItemOpen(EMarkType.FixedSceneGameplay, this.Data.RelativeType, this.Data.RelativeSubType);
			this.TargetExpressionMap.HandleSceneGamePlayMarkItemOpen(EMarkType.SceneGameplay, this.Data.RelativeType, this.Data.RelativeSubType);
			MapModel.Instance.MapLifeEventListenerTriggerMap[EMapLifeEventListenerType.SceneGameplayUnlock].State = false;
		}

		// Token: 0x0401D2B2 RID: 119474
		[Nullable(2)]
		private IMapSceneGameplayUnlockData Data;
	}
}
