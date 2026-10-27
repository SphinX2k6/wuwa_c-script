using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020058F2 RID: 22770
	public class LordGymExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x06039D1A RID: 236826 RVA: 0x00DBBBB4 File Offset: 0x00DB9DB4
		public override bool Checker()
		{
			return LordGymController.Instance.IsInLordGymDungeon();
		}

		// Token: 0x06039D1B RID: 236827 RVA: 0x00DBBBC0 File Offset: 0x00DB9DC0
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

		// Token: 0x06039D1C RID: 236828 RVA: 0x00DBBC50 File Offset: 0x00DB9E50
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

		// Token: 0x06039D1D RID: 236829 RVA: 0x00DBBCEC File Offset: 0x00DB9EEC
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

		// Token: 0x06039D1E RID: 236830 RVA: 0x00DBBDBC File Offset: 0x00DB9FBC
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

		// Token: 0x06039D1F RID: 236831 RVA: 0x00DBBDF4 File Offset: 0x00DB9FF4
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

		// Token: 0x06039D20 RID: 236832 RVA: 0x00DBBE50 File Offset: 0x00DBA050
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
