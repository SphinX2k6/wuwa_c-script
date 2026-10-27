using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02006218 RID: 25112
	[NullableContext(2)]
	[Nullable(0)]
	public class RhythmShipChoseLevelView : UiTickViewBase
	{
		// Token: 0x0603F57A RID: 259450 RVA: 0x00F4E852 File Offset: 0x00F4CA52
		[NullableContext(1)]
		public RhythmShipChoseLevelView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603F57B RID: 259451 RVA: 0x00F4E88C File Offset: 0x00F4CA8C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIDraggableComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(9, typeof(UUIText)),
				new ValueTuple<int, Type>(10, typeof(UUIText)),
				new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(12, typeof(UUIText)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIItem)),
				new ValueTuple<int, Type>(15, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(16, typeof(UUIItem)),
				new ValueTuple<int, Type>(17, typeof(UUIItem)),
				new ValueTuple<int, Type>(18, typeof(UUIItem)),
				new ValueTuple<int, Type>(19, typeof(UUIItem)),
				new ValueTuple<int, Type>(20, typeof(UUIItem)),
				new ValueTuple<int, Type>(21, typeof(UUIItem)),
				new ValueTuple<int, Type>(22, typeof(UUIItem)),
				new ValueTuple<int, Type>(23, typeof(UUIItem)),
				new ValueTuple<int, Type>(24, typeof(UUIItem)),
				new ValueTuple<int, Type>(25, typeof(UUIItem)),
				new ValueTuple<int, Type>(26, typeof(UUIItem)),
				new ValueTuple<int, Type>(27, typeof(UUIItem)),
				new ValueTuple<int, Type>(28, typeof(UUIItem)),
				new ValueTuple<int, Type>(29, typeof(UUIItem)),
				new ValueTuple<int, Type>(30, typeof(UUIItem)),
				new ValueTuple<int, Type>(31, typeof(UUIItem)),
				new ValueTuple<int, Type>(32, typeof(UUIItem)),
				new ValueTuple<int, Type>(33, typeof(UUIItem)),
				new ValueTuple<int, Type>(34, typeof(UUIItem)),
				new ValueTuple<int, Type>(35, typeof(UUIItem)),
				new ValueTuple<int, Type>(36, typeof(UUINiagara)),
				new ValueTuple<int, Type>(37, typeof(UUITexture)),
				new ValueTuple<int, Type>(38, typeof(UUIItem)),
				new ValueTuple<int, Type>(39, typeof(UUIItem)),
				new ValueTuple<int, Type>(40, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(41, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(42, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnClickKeyBindingsBtn)),
				new ValueTuple<int, Delegate>(4, new Action(this.OnClickLeftBtn)),
				new ValueTuple<int, Delegate>(5, new Action(this.OnClickRightBtn)),
				new ValueTuple<int, Delegate>(11, new Action(this.OnClickTaskBtn)),
				new ValueTuple<int, Delegate>(8, new Action(this.OnClickLimitTaskBtn)),
				new ValueTuple<int, Delegate>(15, new Action(this.OnClickFastTravelBtn)),
				new ValueTuple<int, Delegate>(40, new Action(this.OnClickLevelDetailLeftBtn)),
				new ValueTuple<int, Delegate>(41, new Action(this.OnClickLevelDetailRightBtn))
			};
		}

		// Token: 0x0603F57C RID: 259452 RVA: 0x00F4ED48 File Offset: 0x00F4CF48
		protected override UniTask OnBeforeStartAsync()
		{
			RhythmShipChoseLevelView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipChoseLevelView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F57D RID: 259453 RVA: 0x00F4ED8B File Offset: 0x00F4CF8B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnRhythmShipJumpLevel, new Action<int, int, int>(this.OnRhythmShipJumpLevel));
			EventSystem.Instance.Add(EEventName.OnRhythmShipRedDotRefresh, new Action<List<int>, List<int>, List<int>>(this.OnRhythmShipRedDotRefresh));
		}

		// Token: 0x0603F57E RID: 259454 RVA: 0x00F4EDC5 File Offset: 0x00F4CFC5
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnRhythmShipJumpLevel, new Action<int, int, int>(this.OnRhythmShipJumpLevel));
			EventSystem.Instance.Remove(EEventName.OnRhythmShipRedDotRefresh, new Action<List<int>, List<int>, List<int>>(this.OnRhythmShipRedDotRefresh));
		}

		// Token: 0x0603F57F RID: 259455 RVA: 0x00F4EE00 File Offset: 0x00F4D000
		protected override void OnStart()
		{
			this.PlayMainViewMusic();
			IRhythmShipChoseLevelViewData rhythmShipChoseLevelViewData = this.OpenParam as IRhythmShipChoseLevelViewData;
			this.CurrentShowType = rhythmShipChoseLevelViewData.OpenShowType;
			if (this.CurrentShowType == ERhythmShipPlanetType.MainLine)
			{
				base.GetItem(38).SetUIActive(false);
				base.GetItem(13).SetUIActive(false);
				base.GetButton(15).RootUIComp.Get().SetUIActive(false);
				base.GetItem(42).SetUIActive(false);
				this.RhythmShipLinkageItem.GetRootItem().SetUIActive(false);
			}
			this.PlanetList = RhythmShipConfig.Instance.GetRhythmShipPlanetIdListByType((int)this.CurrentShowType, RhythmShipModel.Instance.ActivityId);
			RhythmShipLevelDetailPanel levelDetailPanel = this.LevelDetailPanel;
			if (levelDetailPanel != null)
			{
				levelDetailPanel.SetUiActive(false);
			}
			this.RefreshView(rhythmShipChoseLevelViewData.PlanetId);
			this.RefreshBgItem();
			this.RefreshTimeText();
			this.RefreshLinkageRedDot();
		}

		// Token: 0x0603F580 RID: 259456 RVA: 0x00F4EEDA File Offset: 0x00F4D0DA
		protected override void OnBeforeDestroy()
		{
			this.StopLastMusic();
		}

		// Token: 0x0603F581 RID: 259457 RVA: 0x00F4EEE4 File Offset: 0x00F4D0E4
		protected override void OnBeforeShow()
		{
			base.GetText(12).SetText(RhythmShipModel.Instance.GetTaskProgressString(0), true);
			base.GetText(9).SetText(RhythmShipModel.Instance.GetTaskProgressString(1), true);
			RedDotController.Instance.BindRedDot(ERedDotName.RhythmShipTask, base.GetItem(31), null, 0);
			RedDotController.Instance.BindRedDot(ERedDotName.RhythmShipTimeLimitTask, base.GetItem(30), null, 0);
			foreach (KeyValuePair<int, RhythmShipChoseLevelItem> keyValuePair in this.RhythmShipChoseLevelItemMap)
			{
				keyValuePair.Value.SetToggleSelect(false);
			}
		}

		// Token: 0x0603F582 RID: 259458 RVA: 0x00F4EFA4 File Offset: 0x00F4D1A4
		private void PlayMainViewMusic()
		{
			RhythmShipController.Instance.PlayLoopAudioEvent("play_ui_jiezoufeichuan_interface");
		}

		// Token: 0x0603F583 RID: 259459 RVA: 0x00F4EFB5 File Offset: 0x00F4D1B5
		private void StopLastMusic()
		{
			RhythmShipController.Instance.StopLoopAudioEvent();
		}

		// Token: 0x0603F584 RID: 259460 RVA: 0x00F4EFC4 File Offset: 0x00F4D1C4
		protected override void OnAfterPlayStartSequence()
		{
			IRhythmShipChoseLevelViewData rhythmShipChoseLevelViewData = this.OpenParam as IRhythmShipChoseLevelViewData;
			if (rhythmShipChoseLevelViewData.LevelId != null && rhythmShipChoseLevelViewData.SubLevelId != null)
			{
				this.OnClickLevelItem(rhythmShipChoseLevelViewData.LevelId.Value, new int?(rhythmShipChoseLevelViewData.SubLevelId.Value));
			}
		}

		// Token: 0x0603F585 RID: 259461 RVA: 0x00F4F024 File Offset: 0x00F4D224
		protected override void OnBeforeHide()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RhythmShipTask, base.GetItem(31), 0);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RhythmShipTimeLimitTask, base.GetItem(30), 0);
		}

		// Token: 0x0603F586 RID: 259462 RVA: 0x00F4F056 File Offset: 0x00F4D256
		protected override void OnTick(float delta)
		{
			if (this.RefreshTime > 500f)
			{
				this.RefreshTimeText();
				this.RefreshTime = 0f;
			}
			this.RefreshTime += delta;
		}

		// Token: 0x0603F587 RID: 259463 RVA: 0x00F4F084 File Offset: 0x00F4D284
		private void RefreshTimeText()
		{
			RhythmShipData activityData = RhythmShipModel.Instance.ActivityData;
			if (activityData == null)
			{
				return;
			}
			bool uiactive = activityData.CheckIfInLimitTime();
			base.GetItem(39).SetUIActive(uiactive);
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(activityData.EndRewardTime, "{0}");
			base.GetText(10).SetText(remainTimeText ?? "", true);
		}

		// Token: 0x0603F588 RID: 259464 RVA: 0x00F4F0E4 File Offset: 0x00F4D2E4
		private void RefreshLevelItem()
		{
			List<int> rhythmShipLevelIdListByPlanet = RhythmShipConfig.Instance.GetRhythmShipLevelIdListByPlanet(this.PlanetList[this.CurrentShowPlanetIndex]);
			this.LevelList = (rhythmShipLevelIdListByPlanet ?? new List<int>());
			if (rhythmShipLevelIdListByPlanet == null)
			{
				return;
			}
			int count = rhythmShipLevelIdListByPlanet.Count;
			List<int> list;
			if (!RhythmShipChoseLevelViewDefine.rhythmShipLevelItemShow.TryGetValue(count, out list))
			{
				return;
			}
			for (int i = 0; i < rhythmShipLevelIdListByPlanet.Count; i++)
			{
				int key = list[i];
				RhythmShipChoseLevelItem rhythmShipChoseLevelItem;
				this.RhythmShipChoseLevelItemMap.TryGetValue(key, out rhythmShipChoseLevelItem);
				if (rhythmShipChoseLevelItem != null)
				{
					rhythmShipChoseLevelItem.RefreshItem(rhythmShipLevelIdListByPlanet[i], false);
				}
			}
			foreach (KeyValuePair<int, RhythmShipChoseLevelItem> keyValuePair in this.RhythmShipChoseLevelItemMap)
			{
				int key2 = keyValuePair.Key;
				RhythmShipChoseLevelItem value = keyValuePair.Value;
				if (value != null)
				{
					UUIItem parentAsUIItem = value.GetRootItem().GetParentAsUIItem();
					if (parentAsUIItem != null)
					{
						parentAsUIItem.SetUIActive(list.Contains(key2));
					}
				}
			}
		}

		// Token: 0x0603F589 RID: 259465 RVA: 0x00F4F1EC File Offset: 0x00F4D3EC
		private void RefreshNextBgView()
		{
			int id = this.PlanetList[this.CurrentShowPlanetIndex];
			RhythmShipPlanet? rhythmShipPlanetById = RhythmShipConfig.Instance.GetRhythmShipPlanetById(id);
			if (rhythmShipPlanetById == null)
			{
				return;
			}
			RhythmBg? rhythmShipBgById = RhythmShipConfig.Instance.GetRhythmShipBgById(rhythmShipPlanetById.Value.BgId);
			if (rhythmShipBgById == null)
			{
				return;
			}
			base.GetItem(35).SetUIActive(true);
			base.GetItem(35).SetColor(FColor.FromHex(rhythmShipBgById.Value.BgItemColor));
			LevelSequencePlayer switchLevelSequencePlayer = this.SwitchLevelSequencePlayer;
			if (switchLevelSequencePlayer != null)
			{
				switchLevelSequencePlayer.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer switchLevelSequencePlayer2 = this.SwitchLevelSequencePlayer;
			if (switchLevelSequencePlayer2 != null)
			{
				switchLevelSequencePlayer2.PlayLevelSequenceByName("Sle", false, null, false);
			}
			if (StringUtils.IsEmpty(rhythmShipBgById.Value.BgMaskItemColor))
			{
				if (base.GetItem(34).IsUIActiveSelf())
				{
					LevelSequencePlayer bgMaskLevelSequencePlayer = this.BgMaskLevelSequencePlayer;
					if (bgMaskLevelSequencePlayer == null)
					{
						return;
					}
					bgMaskLevelSequencePlayer.PlayLevelSequenceByName("Out", false, null, false);
					return;
				}
			}
			else
			{
				base.GetItem(34).SetUIActive(true);
				base.GetItem(34).SetColor(FColor.FromHex(rhythmShipBgById.Value.BgMaskItemColor));
				LevelSequencePlayer bgMaskLevelSequencePlayer2 = this.BgMaskLevelSequencePlayer;
				if (bgMaskLevelSequencePlayer2 == null)
				{
					return;
				}
				bgMaskLevelSequencePlayer2.PlayLevelSequenceByName("In", false, null, false);
			}
		}

		// Token: 0x0603F58A RID: 259466 RVA: 0x00F4F344 File Offset: 0x00F4D544
		private void RefreshView(int? targetPlanet = null)
		{
			if (targetPlanet != null)
			{
				this.CurrentShowPlanetIndex = this.PlanetList.IndexOf(targetPlanet.Value);
			}
			int num = this.PlanetList[this.CurrentShowPlanetIndex];
			RhythmShipPlanet? rhythmShipPlanetById = RhythmShipConfig.Instance.GetRhythmShipPlanetById(num);
			if (rhythmShipPlanetById == null)
			{
				return;
			}
			RhythmShipData activityData = RhythmShipModel.Instance.ActivityData;
			if (activityData != null)
			{
				RhythmRedDotPb redDotInfo = activityData.RedDotInfo;
				if (redDotInfo == null || !redDotInfo.ReadPlanet.Contains(num))
				{
					RhythmShipController.Instance.RhythmSetRedDotRequest(new List<int>
					{
						num
					}, null, null);
				}
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), rhythmShipPlanetById.Value.Name, Array.Empty<object>());
			bool flag = this.CurrentShowType == ERhythmShipPlanetType.Linkage;
			base.GetItem(24).SetUIActive(flag);
			this.RhythmShipLinkageItem.RefreshItem(!flag);
			base.GetButton(15).RootUIComp.Get().SetUIActive(this.CurrentShowType == ERhythmShipPlanetType.Normal);
			base.GetItem(2).SetUIActive(this.CurrentShowType != ERhythmShipPlanetType.Linkage);
			base.GetText(3).SetUIActive(!flag);
			this.RefreshLevelItem();
			this.RefreshLeftAndRightBtnActive();
			RhythmBg? rhythmShipBgById = RhythmShipConfig.Instance.GetRhythmShipBgById(rhythmShipPlanetById.Value.BgId);
			if (rhythmShipBgById != null && !this.DoNotPlayStartSequence)
			{
				LevelSequencePlayer startLevelSequencePlayer = this.StartLevelSequencePlayer;
				if (startLevelSequencePlayer != null)
				{
					startLevelSequencePlayer.PlayLevelSequenceByName(rhythmShipBgById.Value.StartLevelSequence, false, null, false);
				}
				this.DoNotPlayStartSequence = true;
			}
		}

		// Token: 0x0603F58B RID: 259467 RVA: 0x00F4F4E4 File Offset: 0x00F4D6E4
		private void RefreshBgItem()
		{
			int id = this.PlanetList[this.CurrentShowPlanetIndex];
			RhythmShipPlanet? rhythmShipPlanetById = RhythmShipConfig.Instance.GetRhythmShipPlanetById(id);
			if (rhythmShipPlanetById == null)
			{
				return;
			}
			RhythmBg? rhythmShipBgById = RhythmShipConfig.Instance.GetRhythmShipBgById(rhythmShipPlanetById.Value.BgId);
			if (rhythmShipBgById == null)
			{
				return;
			}
			base.GetItem(17).SetColor(FColor.FromHex(rhythmShipBgById.Value.BgItemColor));
			base.GetItem(35).SetUIActive(false);
			if (StringUtils.IsEmpty(rhythmShipBgById.Value.BgMaskItemColor))
			{
				base.GetItem(34).SetUIActive(false);
			}
			else
			{
				base.GetItem(34).SetUIActive(true);
				base.GetItem(34).SetColor(FColor.FromHex(rhythmShipBgById.Value.BgMaskItemColor));
			}
			ResourceSystem.Instance.LoadAsync<UMaterialInterface>(rhythmShipBgById.Value.GlowItemMaterial, delegate([Nullable(2)] UMaterialInterface material, string _)
			{
				base.GetTexture(37).SetCustomUIMaterial(material);
			}, ResourceSystem.EResourceLoadPriority.Ui, this.MemoryTag);
			base.SetTextureByPath(rhythmShipBgById.Value.GlowItemTexture, base.GetTexture(37), null, null);
			FColor fcolor = FColor.FromHex(rhythmShipBgById.Value.NiaSphereParWhiteColor);
			base.GetUiNiagara(36).ColorParameter.Get("Color_01").Constant = FLinearColor.FromSRGBColor(fcolor);
		}

		// Token: 0x0603F58C RID: 259468 RVA: 0x00F4F658 File Offset: 0x00F4D858
		private void RefreshLeftAndRightBtnActive()
		{
			bool flag = this.CurrentShowPlanetIndex < this.PlanetList.Count - 1;
			bool flag2 = this.CurrentShowPlanetIndex > 0;
			base.GetButton(5).RootUIComp.Get().SetUIActive(flag);
			base.GetButton(4).RootUIComp.Get().SetUIActive(flag2);
			if (flag2)
			{
				bool planetRedDotActive = RhythmShipModel.Instance.GetPlanetRedDotActive(this.PlanetList[this.CurrentShowPlanetIndex - 1]);
				base.GetItem(32).SetUIActive(planetRedDotActive);
			}
			if (flag)
			{
				bool planetRedDotActive2 = RhythmShipModel.Instance.GetPlanetRedDotActive(this.PlanetList[this.CurrentShowPlanetIndex + 1]);
				base.GetItem(33).SetUIActive(planetRedDotActive2);
			}
		}

		// Token: 0x0603F58D RID: 259469 RVA: 0x00F4F719 File Offset: 0x00F4D919
		private void OnClickKeyBindingsBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.RhythmShipSetView, null, null);
		}

		// Token: 0x0603F58E RID: 259470 RVA: 0x00F4F72C File Offset: 0x00F4D92C
		private void OnClickLeftBtn()
		{
			this.CurrentShowPlanetIndex--;
			this.RefreshNextBgView();
			this.RefreshView(null);
		}

		// Token: 0x0603F58F RID: 259471 RVA: 0x00F4F75C File Offset: 0x00F4D95C
		private void OnClickRightBtn()
		{
			this.CurrentShowPlanetIndex++;
			this.RefreshNextBgView();
			this.RefreshView(null);
		}

		// Token: 0x0603F590 RID: 259472 RVA: 0x00F4F78C File Offset: 0x00F4D98C
		private void OnClickLevelDetailLeftBtn()
		{
			int num = this.LevelList.IndexOf(this.CurrentShowDetailLevel);
			int levelId = this.LevelList[num - 1];
			this.RefreshPanelOnLevelDetailBtnClick(levelId);
		}

		// Token: 0x0603F591 RID: 259473 RVA: 0x00F4F7C4 File Offset: 0x00F4D9C4
		private void OnClickLevelDetailRightBtn()
		{
			int num = this.LevelList.IndexOf(this.CurrentShowDetailLevel);
			int levelId = this.LevelList[num + 1];
			this.RefreshPanelOnLevelDetailBtnClick(levelId);
		}

		// Token: 0x0603F592 RID: 259474 RVA: 0x00F4F7FC File Offset: 0x00F4D9FC
		private void RefreshPanelOnLevelDetailBtnClick(int levelId)
		{
			RhythmShipLevelDetailPanel levelDetailPanel = this.LevelDetailPanel;
			if (levelDetailPanel != null)
			{
				levelDetailPanel.RefreshPanelByLevelId(levelId, null);
			}
			RhythmShipLevelDetailPanel levelDetailPanel2 = this.LevelDetailPanel;
			if (levelDetailPanel2 != null)
			{
				levelDetailPanel2.SetUiActive(true);
			}
			this.CurrentShowDetailLevel = levelId;
			this.RefreshDetailLevel();
			this.RefreshLevelDetailBtn();
		}

		// Token: 0x0603F593 RID: 259475 RVA: 0x00F4F849 File Offset: 0x00F4DA49
		private void OnClickTaskBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.RhythmShipTaskView, null, null);
		}

		// Token: 0x0603F594 RID: 259476 RVA: 0x00F4F85C File Offset: 0x00F4DA5C
		private void OnClickLimitTaskBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.RhythmShipLimitTaskView, null, null);
		}

		// Token: 0x0603F595 RID: 259477 RVA: 0x00F4F870 File Offset: 0x00F4DA70
		private void OnClickLinkageBtn()
		{
			if (TimeUtil.Instance.GetServerTime() < this.NextCanClickTime)
			{
				return;
			}
			this.NextCanClickTime = TimeUtil.Instance.GetServerTime() + 1.0;
			this.DoNotPlayStartSequence = false;
			if (this.CurrentShowType != ERhythmShipPlanetType.Linkage)
			{
				this.CurrentShowType = ERhythmShipPlanetType.Linkage;
			}
			else
			{
				this.CurrentShowType = ERhythmShipPlanetType.Normal;
			}
			this.PlanetList = RhythmShipConfig.Instance.GetRhythmShipPlanetIdListByType((int)this.CurrentShowType, RhythmShipModel.Instance.ActivityId);
			this.CurrentShowPlanetIndex = 0;
			this.RefreshView(null);
			this.RefreshBgItem();
			this.RefreshLinkageRedDot();
		}

		// Token: 0x0603F596 RID: 259478 RVA: 0x00F4F90C File Offset: 0x00F4DB0C
		private void OnClickFastTravelBtn()
		{
			RhythmShipQuickSelectLevelViewData param = new RhythmShipQuickSelectLevelViewData
			{
				OpenShowType = this.CurrentShowType
			};
			UiManager.Instance.OpenView(EUiViewName.RhythmShipQuickSelectLevelView, param, null);
		}

		// Token: 0x0603F597 RID: 259479 RVA: 0x00F4F93C File Offset: 0x00F4DB3C
		private void OnClickLevelItem(int levelId)
		{
			this.OnClickLevelItem(levelId, null);
		}

		// Token: 0x0603F598 RID: 259480 RVA: 0x00F4F95C File Offset: 0x00F4DB5C
		private void OnClickLevelItem(int levelId, int? subLevelId)
		{
			if (!this.LevelPreQuestHandle(levelId))
			{
				return;
			}
			RhythmShipLevelDetailPanel levelDetailPanel = this.LevelDetailPanel;
			if (levelDetailPanel != null)
			{
				levelDetailPanel.RefreshPanelByLevelId(levelId, subLevelId);
			}
			RhythmShipLevelDetailPanel levelDetailPanel2 = this.LevelDetailPanel;
			if (levelDetailPanel2 != null)
			{
				levelDetailPanel2.SetUiActive(true);
			}
			LevelSequencePlayer tipsLevelSequencePlayer = this.TipsLevelSequencePlayer;
			if (tipsLevelSequencePlayer != null)
			{
				tipsLevelSequencePlayer.PlayLevelSequenceByName("TipStart", false, null, false);
			}
			base.GetButton(15).RootUIComp.Get().SetUIActive(false);
			this.CurrentShowDetailLevel = levelId;
			base.GetItem(18).SetUIActive(false);
			base.GetItem(25).SetUIActive(true);
			this.RefreshDetailLevel();
		}

		// Token: 0x0603F599 RID: 259481 RVA: 0x00F4FA00 File Offset: 0x00F4DC00
		private bool LevelPreQuestHandle(int levelId)
		{
			if (RhythmShipModel.Instance.GetLevelPreQuestFinish(levelId))
			{
				return true;
			}
			if (RhythmShipModel.Instance.GetIsInRhythmShipLevel())
			{
				RhythmShipModel.Instance.TrackLevelPreQuest(levelId);
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
				return false;
			}
			int levelUnFinishPreQuestId = RhythmShipModel.Instance.GetLevelUnFinishPreQuestId(levelId);
			UiManager.Instance.OpenView(EUiViewName.QuestView, levelUnFinishPreQuestId, null);
			return false;
		}

		// Token: 0x0603F59A RID: 259482 RVA: 0x00F4FA68 File Offset: 0x00F4DC68
		private void OnRhythmShipJumpLevel(int showType, int planetId, int levelId)
		{
			this.CurrentShowType = (ERhythmShipPlanetType)showType;
			this.RefreshView(new int?(planetId));
			this.RefreshBgItem();
			if (!RhythmShipModel.Instance.GetLevelIsUnlock(levelId))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId(RhythmShipModel.Instance.GetLevelLockTips(levelId) ?? "RhythmShipLevelLockTips", Array.Empty<object>());
				return;
			}
			this.OnClickLevelItem(levelId);
			this.HandleOpenQuickSelectLevelView = true;
		}

		// Token: 0x0603F59B RID: 259483 RVA: 0x00F4FAD0 File Offset: 0x00F4DCD0
		private void OnClickDetailPanelMask()
		{
			RhythmShipLevelDetailPanel levelDetailPanel = this.LevelDetailPanel;
			if (levelDetailPanel != null)
			{
				levelDetailPanel.SetUiActive(false);
			}
			this.PlayMainViewMusic();
			LevelSequencePlayer tipsLevelSequencePlayer = this.TipsLevelSequencePlayer;
			if (tipsLevelSequencePlayer != null)
			{
				tipsLevelSequencePlayer.PlayLevelSequenceByName("TipClose", false, null, false);
			}
			base.GetButton(15).RootUIComp.Get().SetUIActive(this.CurrentShowType == ERhythmShipPlanetType.Normal);
			this.CurrentShowDetailLevel = 0;
			base.GetItem(18).SetUIActive(true);
			base.GetItem(25).SetUIActive(false);
		}

		// Token: 0x0603F59C RID: 259484 RVA: 0x00F4FB5C File Offset: 0x00F4DD5C
		private void RefreshDetailLevel()
		{
			RhythmShipChoseLevelItem rhythmShipChoseLevelDetailItem = this.RhythmShipChoseLevelDetailItem;
			if (rhythmShipChoseLevelDetailItem != null)
			{
				rhythmShipChoseLevelDetailItem.SetToggleSelect(true);
			}
			RhythmShipChoseLevelItem rhythmShipChoseLevelDetailItem2 = this.RhythmShipChoseLevelDetailItem;
			if (rhythmShipChoseLevelDetailItem2 != null)
			{
				rhythmShipChoseLevelDetailItem2.RefreshItem(this.CurrentShowDetailLevel, true);
			}
			foreach (KeyValuePair<int, RhythmShipChoseLevelItem> keyValuePair in this.RhythmShipChoseLevelItemMap)
			{
				keyValuePair.Value.SetToggleSelect(false);
			}
			this.RefreshLevelDetailBtn();
		}

		// Token: 0x0603F59D RID: 259485 RVA: 0x00F4FBE8 File Offset: 0x00F4DDE8
		private void RefreshLinkageRedDot()
		{
			if (this.CurrentShowType == ERhythmShipPlanetType.Normal)
			{
				base.GetItem(14).SetUIActive(RhythmShipModel.Instance.GetPlanetRedDotActive(5));
				return;
			}
			if (this.CurrentShowType == ERhythmShipPlanetType.Linkage)
			{
				List<int> rhythmShipPlanetIdListByType = RhythmShipConfig.Instance.GetRhythmShipPlanetIdListByType(1, RhythmShipModel.Instance.ActivityId);
				bool uiactive = false;
				foreach (int planet in rhythmShipPlanetIdListByType)
				{
					if (RhythmShipModel.Instance.GetPlanetRedDotActive(planet))
					{
						uiactive = true;
						break;
					}
				}
				base.GetItem(14).SetUIActive(uiactive);
			}
		}

		// Token: 0x0603F59E RID: 259486 RVA: 0x00F4FC90 File Offset: 0x00F4DE90
		private void OnRhythmShipRedDotRefresh(List<int> planet, List<int> subLevel, List<int> role)
		{
			this.RefreshLinkageRedDot();
		}

		// Token: 0x0603F59F RID: 259487 RVA: 0x00F4FC98 File Offset: 0x00F4DE98
		[NullableContext(1)]
		private void SequenceEvent(string seqName, string eventName)
		{
			List<string> list;
			if (!RhythmShipChoseLevelViewDefine.rhythmShipLevelItemSequenceName.TryGetValue(this.LevelList.Count, out list))
			{
				return;
			}
			int num = int.Parse(eventName[eventName.Length - 1].ToString());
			string text = list[num - 1];
			if (StringUtils.IsEmpty(text))
			{
				return;
			}
			RhythmShipChoseLevelItem rhythmShipChoseLevelItem;
			this.RhythmShipChoseLevelItemMap.TryGetValue(num, out rhythmShipChoseLevelItem);
			if (rhythmShipChoseLevelItem != null)
			{
				rhythmShipChoseLevelItem.LevelSequencePlayerPlay(text);
			}
		}

		// Token: 0x0603F5A0 RID: 259488 RVA: 0x00F4FD09 File Offset: 0x00F4DF09
		[NullableContext(1)]
		private void SwitchSequenceEnd(string seqName)
		{
			if (seqName == "Sle")
			{
				this.RefreshBgItem();
			}
		}

		// Token: 0x0603F5A1 RID: 259489 RVA: 0x00F4FD1E File Offset: 0x00F4DF1E
		[NullableContext(1)]
		private void BgMaskLevelSequencePlayerEnd(string seqName)
		{
			if (seqName == "Out")
			{
				base.GetItem(34).SetUIActive(false);
			}
		}

		// Token: 0x0603F5A2 RID: 259490 RVA: 0x00F4FD3C File Offset: 0x00F4DF3C
		private void OnClickCloseBtn()
		{
			if (this.HandleOpenQuickSelectLevelView)
			{
				this.OnClickDetailPanelMask();
				this.OnClickFastTravelBtn();
				this.HandleOpenQuickSelectLevelView = false;
				return;
			}
			if (this.CurrentShowDetailLevel != 0)
			{
				this.OnClickDetailPanelMask();
				return;
			}
			if (this.CurrentShowType == ERhythmShipPlanetType.Linkage)
			{
				this.OnClickLinkageBtn();
				return;
			}
			base.CloseMe(null);
			if (!RhythmShipModel.Instance.GetIsInRhythmShipLevel())
			{
				return;
			}
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
		}

		// Token: 0x0603F5A3 RID: 259491 RVA: 0x00F4FDA8 File Offset: 0x00F4DFA8
		private void RefreshLevelDetailBtn()
		{
			if (this.CurrentShowDetailLevel == 0)
			{
				UUIButtonComponent button = base.GetButton(40);
				if (button != null)
				{
					button.RootUIComp.Get().SetUIActive(false);
				}
				UUIButtonComponent button2 = base.GetButton(41);
				if (button2 == null)
				{
					return;
				}
				button2.RootUIComp.Get().SetUIActive(false);
				return;
			}
			else
			{
				int num = this.LevelList.IndexOf(this.CurrentShowDetailLevel);
				int num2 = num - 1;
				UUIButtonComponent button3 = base.GetButton(40);
				if (button3 != null)
				{
					button3.RootUIComp.Get().SetUIActive(num2 >= 0 && RhythmShipModel.Instance.GetLevelIsUnlock(this.LevelList[num2]));
				}
				int num3 = num + 1;
				UUIButtonComponent button4 = base.GetButton(41);
				if (button4 == null)
				{
					return;
				}
				button4.RootUIComp.Get().SetUIActive(num3 < this.LevelList.Count && RhythmShipModel.Instance.GetLevelIsUnlock(this.LevelList[num3]));
				return;
			}
		}

		// Token: 0x040210E7 RID: 135399
		private PopupCaptionItem CaptionItem;

		// Token: 0x040210E8 RID: 135400
		private ERhythmShipPlanetType CurrentShowType = ERhythmShipPlanetType.Normal;

		// Token: 0x040210E9 RID: 135401
		[Nullable(1)]
		private List<int> PlanetList = new List<int>();

		// Token: 0x040210EA RID: 135402
		[Nullable(1)]
		private List<int> LevelList = new List<int>();

		// Token: 0x040210EB RID: 135403
		private int CurrentShowPlanetIndex;

		// Token: 0x040210EC RID: 135404
		private int CurrentShowDetailLevel;

		// Token: 0x040210ED RID: 135405
		private LevelSequencePlayer StartLevelSequencePlayer;

		// Token: 0x040210EE RID: 135406
		private LevelSequencePlayer SwitchLevelSequencePlayer;

		// Token: 0x040210EF RID: 135407
		private LevelSequencePlayer TipsLevelSequencePlayer;

		// Token: 0x040210F0 RID: 135408
		private LevelSequencePlayer BgMaskLevelSequencePlayer;

		// Token: 0x040210F1 RID: 135409
		[Nullable(1)]
		private readonly Dictionary<int, RhythmShipChoseLevelItem> RhythmShipChoseLevelItemMap = new Dictionary<int, RhythmShipChoseLevelItem>();

		// Token: 0x040210F2 RID: 135410
		private RhythmShipChoseLevelItem RhythmShipChoseLevelDetailItem;

		// Token: 0x040210F3 RID: 135411
		private RhythmShipLevelDetailPanel LevelDetailPanel;

		// Token: 0x040210F4 RID: 135412
		private RhythmShipLinkageBtnItem RhythmShipLinkageItem;

		// Token: 0x040210F5 RID: 135413
		private float RefreshTime;

		// Token: 0x040210F6 RID: 135414
		private bool DoNotPlayStartSequence = true;

		// Token: 0x040210F7 RID: 135415
		private double NextCanClickTime;

		// Token: 0x040210F8 RID: 135416
		private bool HandleOpenQuickSelectLevelView;
	}
}
