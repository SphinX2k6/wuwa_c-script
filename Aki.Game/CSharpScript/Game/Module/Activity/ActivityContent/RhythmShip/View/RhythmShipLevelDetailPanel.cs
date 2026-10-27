using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02006224 RID: 25124
	[NullableContext(2)]
	[Nullable(0)]
	public class RhythmShipLevelDetailPanel : UiPanelBase
	{
		// Token: 0x0603F5CB RID: 259531 RVA: 0x00F50D24 File Offset: 0x00F4EF24
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUITexture)),
				new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUITexture)),
				new ValueTuple<int, Type>(14, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(15, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(9, new Action(this.OnClickRankingBtn)),
				new ValueTuple<int, Delegate>(10, new Action(this.OnClickStartBtn)),
				new ValueTuple<int, Delegate>(14, new Action(this.OnClickRoleBtn))
			};
		}

		// Token: 0x0603F5CC RID: 259532 RVA: 0x00F50EE4 File Offset: 0x00F4F0E4
		protected override UniTask OnBeforeStartAsync()
		{
			RhythmShipLevelDetailPanel.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipLevelDetailPanel.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F5CD RID: 259533 RVA: 0x00F50F28 File Offset: 0x00F4F128
		protected override void OnStart()
		{
			this.StarLayout = new GenericLayout<StarItem, bool>(base.GetHorizontalLayout(4), new Func<StarItem>(this.InitStarItem), base.GetItem(5).GetOwner() as AUIBaseActor, false, true);
			this.RefreshRolePanel();
			this.RefreshRoleRedDotItem();
			EventSystem.Instance.Add(EEventName.OnRhythmShipSelectRoleRefresh, new Action(this.RefreshRolePanel));
			EventSystem.Instance.Add(EEventName.OnRhythmShipRedDotRefresh, new Action<List<int>, List<int>, List<int>>(this.OnRhythmShipRedDotRefresh));
		}

		// Token: 0x0603F5CE RID: 259534 RVA: 0x00F50FAA File Offset: 0x00F4F1AA
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnRhythmShipSelectRoleRefresh, new Action(this.RefreshRolePanel));
			EventSystem.Instance.Remove(EEventName.OnRhythmShipRedDotRefresh, new Action<List<int>, List<int>, List<int>>(this.OnRhythmShipRedDotRefresh));
		}

		// Token: 0x0603F5CF RID: 259535 RVA: 0x00F50FE4 File Offset: 0x00F4F1E4
		[NullableContext(1)]
		private StarItem InitStarItem()
		{
			return new StarItem();
		}

		// Token: 0x0603F5D0 RID: 259536 RVA: 0x00F50FEC File Offset: 0x00F4F1EC
		public void RefreshPanelByLevelId(int levelId, int? subLevelId = null)
		{
			this.LevelId = levelId;
			RhythmShipLevel? rhythmShipLevelById = RhythmShipConfig.Instance.GetRhythmShipLevelById(levelId);
			if (rhythmShipLevelById == null)
			{
				return;
			}
			SongLevelDetailPanel songDetailPanelIns = this.SongDetailPanelIns;
			if (songDetailPanelIns != null)
			{
				songDetailPanelIns.RefreshPanelByLevelId(this.LevelId);
			}
			RhythmShipPlanet? rhythmShipPlanetById = RhythmShipConfig.Instance.GetRhythmShipPlanetById(rhythmShipLevelById.Value.Planet);
			base.GetItem(11).SetUIActive(rhythmShipPlanetById == null || rhythmShipPlanetById.GetValueOrDefault().Type != 2);
			IReadOnlyList<RhythmSubLevel> rhythmShipSubLevelByLevelId = RhythmShipConfig.Instance.GetRhythmShipSubLevelByLevelId(this.LevelId);
			RhythmShipController.Instance.PlayLoopAudioEvent(rhythmShipLevelById.Value.BgmEvent);
			DifficultyItem easyItem = this.EasyItem;
			if (easyItem != null)
			{
				easyItem.RefreshPanel(this.FindSubLevelId(rhythmShipSubLevelByLevelId, ERhythmShipLevelDifficulty.Easy));
			}
			DifficultyItem middleItem = this.MiddleItem;
			if (middleItem != null)
			{
				middleItem.RefreshPanel(this.FindSubLevelId(rhythmShipSubLevelByLevelId, ERhythmShipLevelDifficulty.Middle));
			}
			DifficultyItem difficultyItemIns = this.DifficultyItemIns;
			if (difficultyItemIns != null)
			{
				difficultyItemIns.RefreshPanel(this.FindSubLevelId(rhythmShipSubLevelByLevelId, ERhythmShipLevelDifficulty.Difficulty));
			}
			this.SelectDifficultyToggleOnRefresh(rhythmShipSubLevelByLevelId, subLevelId);
		}

		// Token: 0x0603F5D1 RID: 259537 RVA: 0x00F510F4 File Offset: 0x00F4F2F4
		private int FindSubLevelId(IReadOnlyList<RhythmSubLevel> subLevelList, ERhythmShipLevelDifficulty difficulty)
		{
			if (subLevelList == null)
			{
				return 0;
			}
			foreach (RhythmSubLevel rhythmSubLevel in subLevelList)
			{
				if (rhythmSubLevel.Difficulty == (int)difficulty)
				{
					return rhythmSubLevel.Id;
				}
			}
			return 0;
		}

		// Token: 0x0603F5D2 RID: 259538 RVA: 0x00F51154 File Offset: 0x00F4F354
		private void SelectDifficultyToggleOnRefresh(IReadOnlyList<RhythmSubLevel> subLevelList, int? subLevelId)
		{
			int num = 0;
			if (subLevelId != null && RhythmShipModel.Instance.GetSubLevelIsUnlock(subLevelId.Value))
			{
				RhythmSubLevel? rhythmSubLevel;
				num = ((RhythmShipConfig.Instance.GetRhythmShipSubLevelById(subLevelId.Value) != null) ? rhythmSubLevel.GetValueOrDefault().Difficulty : 0);
			}
			else if (subLevelList != null)
			{
				foreach (RhythmSubLevel rhythmSubLevel2 in subLevelList)
				{
					Dictionary<int, RhythmSubLevelPb> subLevelInfoMapBySubLevelId = RhythmShipModel.Instance.GetSubLevelInfoMapBySubLevelId(rhythmSubLevel2.Id);
					RhythmSubLevelPb rhythmSubLevelPb = null;
					if (subLevelInfoMapBySubLevelId != null)
					{
						subLevelInfoMapBySubLevelId.TryGetValue(rhythmSubLevel2.Id, out rhythmSubLevelPb);
					}
					if (RhythmShipModel.Instance.GetSubLevelIsUnlock(rhythmSubLevel2.Id) && (rhythmSubLevelPb == null || !rhythmSubLevelPb.Cleared) && num < rhythmSubLevel2.Difficulty)
					{
						num = rhythmSubLevel2.Difficulty;
					}
				}
			}
			switch (num)
			{
			case 1:
			{
				DifficultyItem easyItem = this.EasyItem;
				if (easyItem != null)
				{
					easyItem.SelectToggle();
				}
				break;
			}
			case 2:
			{
				DifficultyItem middleItem = this.MiddleItem;
				if (middleItem != null)
				{
					middleItem.SelectToggle();
				}
				break;
			}
			case 3:
			{
				DifficultyItem difficultyItemIns = this.DifficultyItemIns;
				if (difficultyItemIns != null)
				{
					difficultyItemIns.SelectToggle();
				}
				break;
			}
			default:
			{
				DifficultyItem easyItem2 = this.EasyItem;
				if (easyItem2 != null)
				{
					easyItem2.SelectToggle();
				}
				break;
			}
			}
			this.ReadAllSubLevelRedDot();
		}

		// Token: 0x0603F5D3 RID: 259539 RVA: 0x00F512B4 File Offset: 0x00F4F4B4
		private void ReadAllSubLevelRedDot()
		{
			List<int> list = new List<int>();
			if (this.IsSubLevelNeedClearRedRot(this.EasyItem))
			{
				list.Add(this.EasyItem.SubLevelId);
			}
			if (this.IsSubLevelNeedClearRedRot(this.MiddleItem))
			{
				list.Add(this.MiddleItem.SubLevelId);
			}
			if (this.IsSubLevelNeedClearRedRot(this.DifficultyItemIns))
			{
				list.Add(this.DifficultyItemIns.SubLevelId);
			}
			if (list.Count <= 0)
			{
				return;
			}
			RhythmShipController.Instance.RhythmSetRedDotRequest(null, list, null);
		}

		// Token: 0x0603F5D4 RID: 259540 RVA: 0x00F5133B File Offset: 0x00F4F53B
		private bool IsSubLevelNeedClearRedRot(DifficultyItem difficultyItem)
		{
			return difficultyItem != null && difficultyItem.IsUnLock && difficultyItem.HaveRedDotItem;
		}

		// Token: 0x0603F5D5 RID: 259541 RVA: 0x00F51354 File Offset: 0x00F4F554
		private void RefreshPanelAboutDifficulty()
		{
			IEnumerable<RhythmSubLevel> enumerable = RhythmShipConfig.Instance.GetRhythmShipSubLevelByLevelId(this.LevelId) ?? new List<RhythmSubLevel>();
			int num = 0;
			foreach (RhythmSubLevel rhythmSubLevel in enumerable)
			{
				if (rhythmSubLevel.Id == this.SubLevelId)
				{
					num = rhythmSubLevel.StarLevel;
				}
			}
			List<bool> list = new List<bool>();
			for (int i = 1; i <= 9; i++)
			{
				if (i <= num)
				{
					list.Add(true);
				}
				else
				{
					list.Add(false);
				}
			}
			GenericLayout<StarItem, bool> starLayout = this.StarLayout;
			if (starLayout != null)
			{
				starLayout.RefreshByData(list, null, false);
			}
			RhythmSubLevel? rhythmShipSubLevelById = RhythmShipConfig.Instance.GetRhythmShipSubLevelById(this.SubLevelId);
			base.GetButton(9).RootUIComp.Get().SetUIActive(rhythmShipSubLevelById != null && rhythmShipSubLevelById.GetValueOrDefault().Difficulty == 3);
			Dictionary<int, RhythmSubLevelPb> subLevelInfoMapBySubLevelId = RhythmShipModel.Instance.GetSubLevelInfoMapBySubLevelId(this.SubLevelId);
			RhythmSubLevelPb rhythmSubLevelPb = null;
			if (subLevelInfoMapBySubLevelId != null)
			{
				subLevelInfoMapBySubLevelId.TryGetValue(this.SubLevelId, out rhythmSubLevelPb);
			}
			if (rhythmSubLevelPb == null || rhythmSubLevelPb.BestScore == 0)
			{
				base.GetText(6).SetText("----", true);
				base.GetText(7).SetText("----", true);
				base.GetTexture(8).SetUIActive(false);
				return;
			}
			base.GetText(6).SetText(rhythmSubLevelPb.BestScore.ToString(), true);
			base.GetText(7).SetText((rhythmSubLevelPb.BestAccuracy / 100).ToString() + "%", true);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(RhythmShipDefine.rhythmShipLevelRatingSettlementTexture[(int)rhythmSubLevelPb.BestRank]);
			base.GetTexture(8).SetUIActive(true);
			base.SetTextureByPath(resourcePath, base.GetTexture(8), null, null);
		}

		// Token: 0x0603F5D6 RID: 259542 RVA: 0x00F51544 File Offset: 0x00F4F744
		private void RefreshRolePanel()
		{
			RhythmShipData activityData = RhythmShipModel.Instance.ActivityData;
			if (activityData == null)
			{
				return;
			}
			int currentRole = activityData.CurrentRole;
			if (currentRole == 0)
			{
				base.GetItem(11).SetUIActive(false);
				return;
			}
			RhythmRole? rhythmRoleById = RhythmShipConfig.Instance.GetRhythmRoleById(currentRole);
			if (rhythmRoleById == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(12), rhythmRoleById.Value.RoleNameText, Array.Empty<object>());
			base.SetTextureByPath(rhythmRoleById.Value.RoleHeadTexture, base.GetTexture(13), null, null);
		}

		// Token: 0x0603F5D7 RID: 259543 RVA: 0x00F515E0 File Offset: 0x00F4F7E0
		private void OnClickRankingBtn()
		{
			RhythmShipRatingViewData param = new RhythmShipRatingViewData
			{
				LevelId = this.LevelId,
				SubLevelId = this.SubLevelId
			};
			UiManager.Instance.OpenView(EUiViewName.RhythmShipRatingView, param, null);
		}

		// Token: 0x0603F5D8 RID: 259544 RVA: 0x00F5161C File Offset: 0x00F4F81C
		private void OnClickStartBtn()
		{
			if (!RhythmShipModel.Instance.GetSubLevelIsUnlock(this.SubLevelId))
			{
				RhythmSubLevel? rhythmShipSubLevelById = RhythmShipConfig.Instance.GetRhythmShipSubLevelById(this.SubLevelId);
				ScrollingTipsController.Instance.ShowTipsByTextId(((rhythmShipSubLevelById != null) ? rhythmShipSubLevelById.GetValueOrDefault().LockTips : null) ?? "RhythmShipLevelLockTips", Array.Empty<object>());
				return;
			}
			RhythmShipLevel? rhythmShipLevelById = RhythmShipConfig.Instance.GetRhythmShipLevelById(this.LevelId);
			if (rhythmShipLevelById == null)
			{
				return;
			}
			RhythmShipPlanet? rhythmShipPlanetById = RhythmShipConfig.Instance.GetRhythmShipPlanetById(rhythmShipLevelById.Value.Planet);
			LoadingModel.Instance.SetSpecifiedLoadingConfigId((rhythmShipPlanetById != null) ? new int?(rhythmShipPlanetById.GetValueOrDefault().LoadingId) : null);
			RhythmShipController.Instance.StartRequest(this.SubLevelId, this.LevelId);
		}

		// Token: 0x0603F5D9 RID: 259545 RVA: 0x00F51700 File Offset: 0x00F4F900
		private void OnClickRoleBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.RhythmShipChoseRoleView, null, null);
		}

		// Token: 0x0603F5DA RID: 259546 RVA: 0x00F51714 File Offset: 0x00F4F914
		[NullableContext(1)]
		private void OnClickDifficultyItem(int subLevel, UUIExtendToggle toggle)
		{
			if (this.SubLevelId == subLevel)
			{
				return;
			}
			this.SubLevelId = subLevel;
			if (toggle != this.CurrentSelectToggle)
			{
				UUIExtendToggle currentSelectToggle = this.CurrentSelectToggle;
				if (currentSelectToggle == null || currentSelectToggle.ToggleState != EToggleState.ETT_UnDetermined)
				{
					UUIExtendToggle currentSelectToggle2 = this.CurrentSelectToggle;
					if (currentSelectToggle2 != null)
					{
						currentSelectToggle2.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
					}
				}
			}
			this.CurrentSelectToggle = toggle;
			this.RefreshPanelAboutDifficulty();
		}

		// Token: 0x0603F5DB RID: 259547 RVA: 0x00F51778 File Offset: 0x00F4F978
		private void RefreshRoleRedDotItem()
		{
			base.GetItem(15).SetUIActive(RhythmShipModel.Instance.GetAnyRoleRedDotActive());
		}

		// Token: 0x0603F5DC RID: 259548 RVA: 0x00F51791 File Offset: 0x00F4F991
		private void OnRhythmShipRedDotRefresh(List<int> planet, List<int> subLevel, List<int> role)
		{
			if (role == null)
			{
				return;
			}
			this.RefreshRoleRedDotItem();
		}

		// Token: 0x04021136 RID: 135478
		private int LevelId;

		// Token: 0x04021137 RID: 135479
		private int SubLevelId;

		// Token: 0x04021138 RID: 135480
		private UUIExtendToggle CurrentSelectToggle;

		// Token: 0x04021139 RID: 135481
		private SongLevelDetailPanel SongDetailPanelIns;

		// Token: 0x0402113A RID: 135482
		private DifficultyItem EasyItem;

		// Token: 0x0402113B RID: 135483
		private DifficultyItem MiddleItem;

		// Token: 0x0402113C RID: 135484
		private DifficultyItem DifficultyItemIns;

		// Token: 0x0402113D RID: 135485
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<StarItem, bool> StarLayout;
	}
}
