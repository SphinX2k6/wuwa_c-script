using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.TowerDefence;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020058FB RID: 22779
	public class TowerDefenseExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x06039D3F RID: 236863 RVA: 0x00DBC4BF File Offset: 0x00DBA6BF
		public override bool Checker()
		{
			return TowerDefenseController.Instance.CheckInInstanceDungeon();
		}

		// Token: 0x06039D40 RID: 236864 RVA: 0x00DBC4CC File Offset: 0x00DBA6CC
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
