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
	// Token: 0x020051A2 RID: 20898
	[NullableContext(2)]
	[Nullable(0)]
	public class RhythmShipLevelDetailPanel : UiPanelBase
	{
		// Token: 0x0603428C RID: 213644 RVA: 0x00E97C7C File Offset: 0x00E95E7C
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

		// Token: 0x0603428D RID: 213645 RVA: 0x00E97E3C File Offset: 0x00E9603C
		protected override UniTask OnBeforeStartAsync()
		{
			RhythmShipLevelDetailPanel.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipLevelDetailPanel.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603428E RID: 213646 RVA: 0x00E97E80 File Offset: 0x00E96080
		protected override void OnStart()
		{
			this.StarLayout = new GenericLayout<StarItem, bool>(base.GetHorizontalLayout(4), new Func<StarItem>(this.InitStarItem), base.GetItem(5).GetOwner() as AUIBaseActor, false, true);
			this.RefreshRolePanel();
			this.RefreshRoleRedDotItem();
			EventSystem.Instance.Add(EEventName.OnRhythmShipSelectRoleRefresh, new Action(this.RefreshRolePanel));
			EventSystem.Instance.Add(EEventName.OnRhythmShipRedDotRefresh, new Action<List<int>, List<int>, List<int>>(this.OnRhythmShipRedDotRefresh));
		}

		// Token: 0x0603428F RID: 213647 RVA: 0x00E97F02 File Offset: 0x00E96102
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnRhythmShipSelectRoleRefresh, new Action(this.RefreshRolePanel));
			EventSystem.Instance.Remove(EEventName.OnRhythmShipRedDotRefresh, new Action<List<int>, List<int>, List<int>>(this.OnRhythmShipRedDotRefresh));
		}

		// Token: 0x06034290 RID: 213648 RVA: 0x00E97F3C File Offset: 0x00E9613C
		[NullableContext(1)]
		private StarItem InitStarItem()
		{
			return new StarItem();
		}

		// Token: 0x06034291 RID: 213649 RVA: 0x00E97F44 File Offset: 0x00E96144
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

		// Token: 0x06034292 RID: 213650 RVA: 0x00E9804C File Offset: 0x00E9624C
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

		// Token: 0x06034293 RID: 213651 RVA: 0x00E980AC File Offset: 0x00E962AC
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

		// Token: 0x06034294 RID: 213652 RVA: 0x00E9820C File Offset: 0x00E9640C
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

		// Token: 0x06034295 RID: 213653 RVA: 0x00E98293 File Offset: 0x00E96493
		private bool IsSubLevelNeedClearRedRot(DifficultyItem difficultyItem)
		{
			return difficultyItem != null && difficultyItem.IsUnLock && difficultyItem.HaveRedDotItem;
		}

		// Token: 0x06034296 RID: 213654 RVA: 0x00E982AC File Offset: 0x00E964AC
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

		// Token: 0x06034297 RID: 213655 RVA: 0x00E9849C File Offset: 0x00E9669C
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

		// Token: 0x06034298 RID: 213656 RVA: 0x00E98538 File Offset: 0x00E96738
		private void OnClickRankingBtn()
		{
			RhythmShipRatingViewData param = new RhythmShipRatingViewData
			{
				LevelId = this.LevelId,
				SubLevelId = this.SubLevelId
			};
			UiManager.Instance.OpenView(EUiViewName.RhythmShipRatingView, param, null);
		}

		// Token: 0x06034299 RID: 213657 RVA: 0x00E98574 File Offset: 0x00E96774
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

		// Token: 0x0603429A RID: 213658 RVA: 0x00E98658 File Offset: 0x00E96858
		private void OnClickRoleBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.RhythmShipChoseRoleView, null, null);
		}

		// Token: 0x0603429B RID: 213659 RVA: 0x00E9866C File Offset: 0x00E9686C
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

		// Token: 0x0603429C RID: 213660 RVA: 0x00E986D0 File Offset: 0x00E968D0
		private void RefreshRoleRedDotItem()
		{
			base.GetItem(15).SetUIActive(RhythmShipModel.Instance.GetAnyRoleRedDotActive());
		}

		// Token: 0x0603429D RID: 213661 RVA: 0x00E986E9 File Offset: 0x00E968E9
		private void OnRhythmShipRedDotRefresh(List<int> planet, List<int> subLevel, List<int> role)
		{
			if (role == null)
			{
				return;
			}
			this.RefreshRoleRedDotItem();
		}

		// Token: 0x0401BA65 RID: 113253
		private int LevelId;

		// Token: 0x0401BA66 RID: 113254
		private int SubLevelId;

		// Token: 0x0401BA67 RID: 113255
		private UUIExtendToggle CurrentSelectToggle;

		// Token: 0x0401BA68 RID: 113256
		private SongLevelDetailPanel SongDetailPanelIns;

		// Token: 0x0401BA69 RID: 113257
		private DifficultyItem EasyItem;

		// Token: 0x0401BA6A RID: 113258
		private DifficultyItem MiddleItem;

		// Token: 0x0401BA6B RID: 113259
		private DifficultyItem DifficultyItemIns;

		// Token: 0x0401BA6C RID: 113260
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<StarItem, bool> StarLayout;
	}
}
