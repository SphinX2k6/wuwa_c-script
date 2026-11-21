using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapLifeEvent
{
	// Token: 0x02004487 RID: 17543
	public class MapSceneGameplayUnlock : MapLifeEventListener
	{
		// Token: 0x0602C52D RID: 181549 RVA: 0x00C76D9C File Offset: 0x00C74F9C
		[NullableContext(1)]
		public MapSceneGameplayUnlock(BaseMap map) : base(map)
		{
		}

		// Token: 0x0602C52E RID: 181550 RVA: 0x00C76DA8 File Offset: 0x00C74FA8
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

		// Token: 0x0602C52F RID: 181551 RVA: 0x00C76E90 File Offset: 0x00C75090
		public override void OnWorldMapAfterShow()
		{
			this.TargetExpressionMap.HandleSceneGamePlayMarkItemOpen(EMarkType.FixedSceneGameplay, this.Data.RelativeType, this.Data.RelativeSubType);
			this.TargetExpressionMap.HandleSceneGamePlayMarkItemOpen(EMarkType.SceneGameplay, this.Data.RelativeType, this.Data.RelativeSubType);
			MapModel.Instance.MapLifeEventListenerTriggerMap[EMapLifeEventListenerType.SceneGameplayUnlock].State = false;
		}

		// Token: 0x04017D4E RID: 97614
		[Nullable(2)]
		private IMapSceneGameplayUnlockData Data;
	}
}
