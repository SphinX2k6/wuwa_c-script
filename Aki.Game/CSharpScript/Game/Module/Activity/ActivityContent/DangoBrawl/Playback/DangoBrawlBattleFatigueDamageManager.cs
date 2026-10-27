using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Playback
{
	// Token: 0x02006860 RID: 26720
	public class DangoBrawlBattleFatigueDamageManager
	{
		// Token: 0x06042B90 RID: 273296 RVA: 0x0103AADA File Offset: 0x01038CDA
		public void Init()
		{
		}

		// Token: 0x06042B91 RID: 273297 RVA: 0x0103AADC File Offset: 0x01038CDC
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

		// Token: 0x06042B92 RID: 273298 RVA: 0x0103AB8C File Offset: 0x01038D8C
		public void Destroy()
		{
		}
	}
}
