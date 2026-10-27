using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Render;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.Effect
{
	// Token: 0x02006DF6 RID: 28150
	public class ItemInspectEffectPlayPerform : ItemInspectEffectBase
	{
		// Token: 0x06044AC9 RID: 281289 RVA: 0x010F3868 File Offset: 0x010F1A68
		[NullableContext(1)]
		protected override void Execute(IInteractEffect @params)
		{
			int curItemId = ItemInspectModel.Instance.CurItemId;
			foreach (int tagId in ((IExecuteTag)@params).Tags)
			{
				FGameplayTag? gameplayTagById = GameplayTagUtils.GetGameplayTagById(tagId);
				if (gameplayTagById != null)
				{
					SceneInteractionManager.Get().PlayExtraEffectByTag(curItemId, gameplayTagById.Value, false);
				}
			}
			base.FinishExecute(true);
		}
	}
}
