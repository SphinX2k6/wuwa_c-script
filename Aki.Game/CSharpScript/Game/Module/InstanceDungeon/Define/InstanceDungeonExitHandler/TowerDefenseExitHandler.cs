using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.TowerDefence;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020048D4 RID: 18644
	public class TowerDefenseExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x0602EC65 RID: 191589 RVA: 0x00D0B48B File Offset: 0x00D0968B
		public override bool Checker()
		{
			return TowerDefenseController.Instance.CheckInInstanceDungeon();
		}

		// Token: 0x0602EC66 RID: 191590 RVA: 0x00D0B498 File Offset: 0x00D09698
		[NullableContext(2)]
		public unsafe override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			bool flag = TowerDefenseController.Instance.CheckInBossRushInstance();
			TowerDefensePopupViewArgs towerDefensePopupViewArgs = new TowerDefensePopupViewArgs();
			towerDefensePopupViewArgs.TextTitle = "TowerDefence_ExitTitle";
			towerDefensePopupViewArgs.TextTips = (flag ? "TowerDefence_ExitTipsMulti" : "TowerDefence_ExitTipsSingle");
			List<object> textTipsArgs;
			if (!flag)
			{
				textTipsArgs = null;
			}
			else
			{
				int num = 1;
				List<object> list = new List<object>(num);
				CollectionsMarshal.SetCount<object>(list, num);
				textTipsArgs = list;
				Span<object> span = CollectionsMarshal.AsSpan<object>(list);
				int index = 0;
				*span[index] = BattleScoreModel.Instance.GetCurScore();
			}
			towerDefensePopupViewArgs.TextTipsArgs = textTipsArgs;
			towerDefensePopupViewArgs.TextContent = "TowerDefence_ExitContent";
			towerDefensePopupViewArgs.ConfirmBack = delegate()
			{
				TowerDefenseController.Instance.RequestChallengeQuit();
			};
			TowerDefensePopupViewArgs param = towerDefensePopupViewArgs;
			UiManager.Instance.OpenView(EUiViewName.TowerDefensePopupView, param, null);
		}
	}
}
