using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020048CA RID: 18634
	public class LordGymExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x0602EC3D RID: 191549 RVA: 0x00D0AB18 File Offset: 0x00D08D18
		public override bool Checker()
		{
			return LordGymController.Instance.IsInLordGymDungeon();
		}

		// Token: 0x0602EC3E RID: 191550 RVA: 0x00D0AB24 File Offset: 0x00D08D24
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			LordGymExitHandler.<>c__DisplayClass1_0 CS$<>8__locals1 = new LordGymExitHandler.<>c__DisplayClass1_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.data = data;
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(this.GetExitConfirmBoxId());
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			Dictionary<int, Action> functionMap = confirmBoxDataNew.FunctionMap;
			int key = 0;
			InstanceDungeonExitHandlerData data2 = CS$<>8__locals1.data;
			functionMap[key] = ((data2 != null) ? data2.CancelBack : null);
			confirmBoxDataNew.FunctionMap[1] = new Action(CS$<>8__locals1.<HandleExit>g__Leave|0);
			confirmBoxDataNew.FunctionMap[2] = new Action(CS$<>8__locals1.<HandleExit>g__ReChallenge|1);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602EC3F RID: 191551 RVA: 0x00D0ABB4 File Offset: 0x00D08DB4
		private void OpenDifficultySelectViewOnLeave()
		{
			ELordGymVersion? curLordGymVersion = this.GetCurLordGymVersion();
			if (curLordGymVersion == null)
			{
				return;
			}
			LordGymDifficultyViewInfo? difficultyViewInfo = this.GetDifficultyViewInfo(curLordGymVersion.Value);
			if (difficultyViewInfo == null)
			{
				return;
			}
			int curLordGymEntranceId = this.GetCurLordGymEntranceId();
			if (curLordGymEntranceId <= 0)
			{
				return;
			}
			TowerController.Instance.ClearAllHatredInTower();
			LordGymDifficultySelectViewParam param = new LordGymDifficultySelectViewParam
			{
				LordEntranceSetId = difficultyViewInfo.Value.EntranceSetId,
				LordEntranceId = curLordGymEntranceId,
				IsPlaySpecialSequence = true,
				DefaultLordId = LordGymModel.Instance.CurrentChallengeLordGymId
			};
			UiManager.Instance.OpenView(difficultyViewInfo.Value.ViewName, param, null);
		}

		// Token: 0x0602EC40 RID: 191552 RVA: 0x00D0AC50 File Offset: 0x00D08E50
		private LordGymDifficultyViewInfo? GetDifficultyViewInfo(ELordGymVersion version)
		{
			switch (version)
			{
			case ELordGymVersion.First:
				return new LordGymDifficultyViewInfo?(new LordGymDifficultyViewInfo
				{
					ViewName = EUiViewName.LordGymFirstDifficultySelectView,
					EntranceSetId = 200105
				});
			case ELordGymVersion.Second:
				return new LordGymDifficultyViewInfo?(new LordGymDifficultyViewInfo
				{
					ViewName = EUiViewName.LordGymSecondDifficultySelectView,
					EntranceSetId = 200102
				});
			case ELordGymVersion.Third:
				return new LordGymDifficultyViewInfo?(new LordGymDifficultyViewInfo
				{
					ViewName = EUiViewName.LordGymThirdDifficultySelectView,
					EntranceSetId = 200103
				});
			case ELordGymVersion.Third5:
				return new LordGymDifficultyViewInfo?(new LordGymDifficultyViewInfo
				{
					ViewName = EUiViewName.LordGymThird5DifficultySelectView,
					EntranceSetId = 200104
				});
			default:
				return null;
			}
		}

		// Token: 0x0602EC41 RID: 191553 RVA: 0x00D0AD20 File Offset: 0x00D08F20
		private int GetCurLordGymEntranceId()
		{
			int currentChallengeLordGymId = LordGymModel.Instance.CurrentChallengeLordGymId;
			if (currentChallengeLordGymId > 0)
			{
				int entranceIdByLordId = LordGymModel.Instance.GetEntranceIdByLordId(currentChallengeLordGymId);
				if (entranceIdByLordId > 0)
				{
					return entranceIdByLordId;
				}
			}
			return LordGymModel.Instance.EntranceEntityId;
		}

		// Token: 0x0602EC42 RID: 191554 RVA: 0x00D0AD58 File Offset: 0x00D08F58
		private EConfirmBoxConfigId GetExitConfirmBoxId()
		{
			ELordGymVersion? curLordGymVersion = this.GetCurLordGymVersion();
			if (curLordGymVersion != null)
			{
				switch (curLordGymVersion.GetValueOrDefault())
				{
				case ELordGymVersion.First:
					return EConfirmBoxConfigId.GuideLordGymExitDungeonConfirm;
				case ELordGymVersion.Second:
					return EConfirmBoxConfigId.GuideLordGymExitDungeonConfirm;
				case ELordGymVersion.Third:
					return EConfirmBoxConfigId.LordGymExitConfirm;
				case ELordGymVersion.Third5:
					return EConfirmBoxConfigId.LordGymThird5ExitConfirm;
				}
			}
			return EConfirmBoxConfigId.LordGymExitConfirm;
		}

		// Token: 0x0602EC43 RID: 191555 RVA: 0x00D0ADB4 File Offset: 0x00D08FB4
		private ELordGymVersion? GetCurLordGymVersion()
		{
			int currentChallengeLordGymId = LordGymModel.Instance.CurrentChallengeLordGymId;
			if (currentChallengeLordGymId <= 0)
			{
				return null;
			}
			LordGym? lordGymConfig = LordGymConfig.Instance.GetLordGymConfig(currentChallengeLordGymId);
			if (lordGymConfig == null)
			{
				return null;
			}
			return new ELordGymVersion?((ELordGymVersion)lordGymConfig.Value.Version);
		}
	}
}
