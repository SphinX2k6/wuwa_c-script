using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Render;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.Effect
{
	// Token: 0x02005F75 RID: 24437
	public class ItemInspectEffectPlayPerform : ItemInspectEffectBase
	{
		// Token: 0x0603AC2D RID: 240685 RVA: 0x0109DB30 File Offset: 0x0109BD30
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
