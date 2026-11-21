using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Playback
{
	// Token: 0x020057B0 RID: 22448
	public class DangoBrawlBattleFatigueDamageManager
	{
		// Token: 0x060376E5 RID: 227045 RVA: 0x00F7C026 File Offset: 0x00F7A226
		public void Init()
		{
		}

		// Token: 0x060376E6 RID: 227046 RVA: 0x00F7C028 File Offset: 0x00F7A228
		[NullableContext(1)]
		public void OnActivateGroup(IBattleActionGroup group)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			DangoBrawlDamageReporter dangoBrawlDamageReporter = (battleManager != null) ? battleManager.Damage : null;
			if (dangoBrawlDamageReporter == null)
			{
				return;
			}
			foreach (IDangoBrawlBattleAction dangoBrawlBattleAction in group.Actions)
			{
				DangoBrawlFightActionFatigueDamageInfo fatigueDamage = dangoBrawlBattleAction.FatigueDamage;
				if (fatigueDamage != null)
				{
					dangoBrawlDamageReporter.Report(new DangoBrawlDamageEvent
					{
						Source = EDangoBrawlDamageSource.Fatigue,
						SourceConfigId = 0,
						SourceFighterUid = 0,
						TargetFighterUid = fatigueDamage.TargetFighterUId,
						Value = fatigueDamage.Damage,
						IsCrit = false
					});
				}
			}
		}

		// Token: 0x060376E7 RID: 227047 RVA: 0x00F7C0D8 File Offset: 0x00F7A2D8
		public void Destroy()
		{
		}
	}
}
