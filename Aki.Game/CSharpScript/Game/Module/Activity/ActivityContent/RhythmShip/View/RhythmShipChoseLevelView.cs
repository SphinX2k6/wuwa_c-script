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
	// Token: 0x02005196 RID: 20886
	[NullableContext(2)]
	[Nullable(0)]
	public class RhythmShipChoseLevelView : UiTickViewBase
	{
		// Token: 0x0603423B RID: 213563 RVA: 0x00E957AA File Offset: 0x00E939AA
		[NullableContext(1)]
		public RhythmShipChoseLevelView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603423C RID: 213564 RVA: 0x00E957E4 File Offset: 0x00E939E4
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

		// Token: 0x0603423D RID: 213565 RVA: 0x00E95CA0 File Offset: 0x00E93EA0
		protected override UniTask OnBeforeStartAsync()
		{
			RhythmShipChoseLevelView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipChoseLevelView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603423E RID: 213566 RVA: 0x00E95CE3 File Offset: 0x00E93EE3
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnRhythmShipJumpLevel, new Action<int, int, int>(this.OnRhythmShipJumpLevel));
			EventSystem.Instance.Add(EEventName.OnRhythmShipRedDotRefresh, new Action<List<int>, List<int>, List<int>>(this.OnRhythmShipRedDotRefresh));
		}

		// Token: 0x0603423F RID: 213567 RVA: 0x00E95D1D File Offset: 0x00E93F1D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnRhythmShipJumpLevel, new Action<int, int, int>(this.OnRhythmShipJumpLevel));
			EventSystem.Instance.Remove(EEventName.OnRhythmShipRedDotRefresh, new Action<List<int>, List<int>, List<int>>(this.OnRhythmShipRedDotRefresh));
		}

		// Token: 0x06034240 RID: 213568 RVA: 0x00E95D58 File Offset: 0x00E93F58
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

		// Token: 0x06034241 RID: 213569 RVA: 0x00E95E32 File Offset: 0x00E94032
		protected override void OnBeforeDestroy()
		{
			this.StopLastMusic();
		}

		// Token: 0x06034242 RID: 213570 RVA: 0x00E95E3C File Offset: 0x00E9403C
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

		// Token: 0x06034243 RID: 213571 RVA: 0x00E95EFC File Offset: 0x00E940FC
		private void PlayMainViewMusic()
		{
			RhythmShipController.Instance.PlayLoopAudioEvent("play_ui_jiezoufeichuan_interface");
		}

		// Token: 0x06034244 RID: 213572 RVA: 0x00E95F0D File Offset: 0x00E9410D
		private void StopLastMusic()
		{
			RhythmShipController.Instance.StopLoopAudioEvent();
		}

		// Token: 0x06034245 RID: 213573 RVA: 0x00E95F1C File Offset: 0x00E9411C
		protected override void OnAfterPlayStartSequence()
		{
			IRhythmShipChoseLevelViewData rhythmShipChoseLevelViewData = this.OpenParam as IRhythmShipChoseLevelViewData;
			if (rhythmShipChoseLevelViewData.LevelId != null && rhythmShipChoseLevelViewData.SubLevelId != null)
			{
				this.OnClickLevelItem(rhythmShipChoseLevelViewData.LevelId.Value, new int?(rhythmShipChoseLevelViewData.SubLevelId.Value));
			}
		}

		// Token: 0x06034246 RID: 213574 RVA: 0x00E95F7C File Offset: 0x00E9417C
		protected override void OnBeforeHide()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RhythmShipTask, base.GetItem(31), 0);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RhythmShipTimeLimitTask, base.GetItem(30), 0);
		}

		// Token: 0x06034247 RID: 213575 RVA: 0x00E95FAE File Offset: 0x00E941AE
		protected override void OnTick(float delta)
		{
			if (this.RefreshTime > 500f)
			{
				this.RefreshTimeText();
				this.RefreshTime = 0f;
			}
			this.RefreshTime += delta;
		}

		// Token: 0x06034248 RID: 213576 RVA: 0x00E95FDC File Offset: 0x00E941DC
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

		// Token: 0x06034249 RID: 213577 RVA: 0x00E9603C File Offset: 0x00E9423C
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

		// Token: 0x0603424A RID: 213578 RVA: 0x00E96144 File Offset: 0x00E94344
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

		// Token: 0x0603424B RID: 213579 RVA: 0x00E9629C File Offset: 0x00E9449C
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

		// Token: 0x0603424C RID: 213580 RVA: 0x00E9643C File Offset: 0x00E9463C
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

		// Token: 0x0603424D RID: 213581 RVA: 0x00E965B0 File Offset: 0x00E947B0
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

		// Token: 0x0603424E RID: 213582 RVA: 0x00E96671 File Offset: 0x00E94871
		private void OnClickKeyBindingsBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.RhythmShipSetView, null, null);
		}

		// Token: 0x0603424F RID: 213583 RVA: 0x00E96684 File Offset: 0x00E94884
		private void OnClickLeftBtn()
		{
			this.CurrentShowPlanetIndex--;
			this.RefreshNextBgView();
			this.RefreshView(null);
		}

		// Token: 0x06034250 RID: 213584 RVA: 0x00E966B4 File Offset: 0x00E948B4
		private void OnClickRightBtn()
		{
			this.CurrentShowPlanetIndex++;
			this.RefreshNextBgView();
			this.RefreshView(null);
		}

		// Token: 0x06034251 RID: 213585 RVA: 0x00E966E4 File Offset: 0x00E948E4
		private void OnClickLevelDetailLeftBtn()
		{
			int num = this.LevelList.IndexOf(this.CurrentShowDetailLevel);
			int levelId = this.LevelList[num - 1];
			this.RefreshPanelOnLevelDetailBtnClick(levelId);
		}

		// Token: 0x06034252 RID: 213586 RVA: 0x00E9671C File Offset: 0x00E9491C
		private void OnClickLevelDetailRightBtn()
		{
			int num = this.LevelList.IndexOf(this.CurrentShowDetailLevel);
			int levelId = this.LevelList[num + 1];
			this.RefreshPanelOnLevelDetailBtnClick(levelId);
		}

		// Token: 0x06034253 RID: 213587 RVA: 0x00E96754 File Offset: 0x00E94954
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

		// Token: 0x06034254 RID: 213588 RVA: 0x00E967A1 File Offset: 0x00E949A1
		private void OnClickTaskBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.RhythmShipTaskView, null, null);
		}

		// Token: 0x06034255 RID: 213589 RVA: 0x00E967B4 File Offset: 0x00E949B4
		private void OnClickLimitTaskBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.RhythmShipLimitTaskView, null, null);
		}

		// Token: 0x06034256 RID: 213590 RVA: 0x00E967C8 File Offset: 0x00E949C8
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

		// Token: 0x06034257 RID: 213591 RVA: 0x00E96864 File Offset: 0x00E94A64
		private void OnClickFastTravelBtn()
		{
			RhythmShipQuickSelectLevelViewData param = new RhythmShipQuickSelectLevelViewData
			{
				OpenShowType = this.CurrentShowType
			};
			UiManager.Instance.OpenView(EUiViewName.RhythmShipQuickSelectLevelView, param, null);
		}

		// Token: 0x06034258 RID: 213592 RVA: 0x00E96894 File Offset: 0x00E94A94
		private void OnClickLevelItem(int levelId)
		{
			this.OnClickLevelItem(levelId, null);
		}

		// Token: 0x06034259 RID: 213593 RVA: 0x00E968B4 File Offset: 0x00E94AB4
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

		// Token: 0x0603425A RID: 213594 RVA: 0x00E96958 File Offset: 0x00E94B58
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

		// Token: 0x0603425B RID: 213595 RVA: 0x00E969C0 File Offset: 0x00E94BC0
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

		// Token: 0x0603425C RID: 213596 RVA: 0x00E96A28 File Offset: 0x00E94C28
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

		// Token: 0x0603425D RID: 213597 RVA: 0x00E96AB4 File Offset: 0x00E94CB4
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

		// Token: 0x0603425E RID: 213598 RVA: 0x00E96B40 File Offset: 0x00E94D40
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

		// Token: 0x0603425F RID: 213599 RVA: 0x00E96BE8 File Offset: 0x00E94DE8
		private void OnRhythmShipRedDotRefresh(List<int> planet, List<int> subLevel, List<int> role)
		{
			this.RefreshLinkageRedDot();
		}

		// Token: 0x06034260 RID: 213600 RVA: 0x00E96BF0 File Offset: 0x00E94DF0
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

		// Token: 0x06034261 RID: 213601 RVA: 0x00E96C61 File Offset: 0x00E94E61
		[NullableContext(1)]
		private void SwitchSequenceEnd(string seqName)
		{
			if (seqName == "Sle")
			{
				this.RefreshBgItem();
			}
		}

		// Token: 0x06034262 RID: 213602 RVA: 0x00E96C76 File Offset: 0x00E94E76
		[NullableContext(1)]
		private void BgMaskLevelSequencePlayerEnd(string seqName)
		{
			if (seqName == "Out")
			{
				base.GetItem(34).SetUIActive(false);
			}
		}

		// Token: 0x06034263 RID: 213603 RVA: 0x00E96C94 File Offset: 0x00E94E94
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

		// Token: 0x06034264 RID: 213604 RVA: 0x00E96D00 File Offset: 0x00E94F00
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

		// Token: 0x0401BA16 RID: 113174
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401BA17 RID: 113175
		private ERhythmShipPlanetType CurrentShowType = ERhythmShipPlanetType.Normal;

		// Token: 0x0401BA18 RID: 113176
		[Nullable(1)]
		private List<int> PlanetList = new List<int>();

		// Token: 0x0401BA19 RID: 113177
		[Nullable(1)]
		private List<int> LevelList = new List<int>();

		// Token: 0x0401BA1A RID: 113178
		private int CurrentShowPlanetIndex;

		// Token: 0x0401BA1B RID: 113179
		private int CurrentShowDetailLevel;

		// Token: 0x0401BA1C RID: 113180
		private LevelSequencePlayer StartLevelSequencePlayer;

		// Token: 0x0401BA1D RID: 113181
		private LevelSequencePlayer SwitchLevelSequencePlayer;

		// Token: 0x0401BA1E RID: 113182
		private LevelSequencePlayer TipsLevelSequencePlayer;

		// Token: 0x0401BA1F RID: 113183
		private LevelSequencePlayer BgMaskLevelSequencePlayer;

		// Token: 0x0401BA20 RID: 113184
		[Nullable(1)]
		private readonly Dictionary<int, RhythmShipChoseLevelItem> RhythmShipChoseLevelItemMap = new Dictionary<int, RhythmShipChoseLevelItem>();

		// Token: 0x0401BA21 RID: 113185
		private RhythmShipChoseLevelItem RhythmShipChoseLevelDetailItem;

		// Token: 0x0401BA22 RID: 113186
		private RhythmShipLevelDetailPanel LevelDetailPanel;

		// Token: 0x0401BA23 RID: 113187
		private RhythmShipLinkageBtnItem RhythmShipLinkageItem;

		// Token: 0x0401BA24 RID: 113188
		private float RefreshTime;

		// Token: 0x0401BA25 RID: 113189
		private bool DoNotPlayStartSequence = true;

		// Token: 0x0401BA26 RID: 113190
		private double NextCanClickTime;

		// Token: 0x0401BA27 RID: 113191
		private bool HandleOpenQuickSelectLevelView;
	}
}
