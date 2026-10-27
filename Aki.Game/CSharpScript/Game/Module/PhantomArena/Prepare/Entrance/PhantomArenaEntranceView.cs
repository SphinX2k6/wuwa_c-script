using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x0200516B RID: 20843
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaEntranceView : PhantomArenaRootViewBase<PhantomArenaEntranceViewModel>
	{
		// Token: 0x0603549A RID: 218266 RVA: 0x00C9E617 File Offset: 0x00C9C817
		public PhantomArenaEntranceView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603549B RID: 218267 RVA: 0x00C9E620 File Offset: 0x00C9C820
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUISprite)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUITexture)),
				new ValueTuple<int, Type>(11, typeof(UUITexture)),
				new ValueTuple<int, Type>(12, typeof(UUIText)),
				new ValueTuple<int, Type>(13, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(13, new Action(this.OnClickedLevel))
			};
		}

		// Token: 0x0603549C RID: 218268 RVA: 0x00C9E795 File Offset: 0x00C9C995
		protected override void OnRegisterDefaultChildView()
		{
			this.DefaultChildViewName = new EPhantomArenaChildViewName?(EPhantomArenaChildViewName.PhantomArenaEntranceGymTabView);
		}

		// Token: 0x0603549D RID: 218269 RVA: 0x00C9E7A3 File Offset: 0x00C9C9A3
		protected override void OnRegisterContentItem()
		{
			this.ContentItem = base.GetItem(7);
		}

		// Token: 0x0603549E RID: 218270 RVA: 0x00C9E7B2 File Offset: 0x00C9C9B2
		protected override void OnRegisterViewData()
		{
			this.ViewModel = new PhantomArenaEntranceViewModel();
			this.ViewModel.Bind(new Action<EViewData>(this.OnViewModelUpdate));
		}

		// Token: 0x0603549F RID: 218271 RVA: 0x00C9E7D8 File Offset: 0x00C9C9D8
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaEntranceView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaEntranceView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060354A0 RID: 218272 RVA: 0x00C9E81C File Offset: 0x00C9CA1C
		private UniTask InitTab()
		{
			PhantomArenaEntranceView.<InitTab>d__12 <InitTab>d__;
			<InitTab>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTab>d__.<>4__this = this;
			<InitTab>d__.<>1__state = -1;
			<InitTab>d__.<>t__builder.Start<PhantomArenaEntranceView.<InitTab>d__12>(ref <InitTab>d__);
			return <InitTab>d__.<>t__builder.Task;
		}

		// Token: 0x060354A1 RID: 218273 RVA: 0x00C9E85F File Offset: 0x00C9CA5F
		protected override void OnStart()
		{
			base.GetItem(8).SetUIActive(false);
			this.UiViewSequence.AddSequenceFinishEvent("MatchStart", new Action<string>(this.OnMatchStartFinish), false);
		}

		// Token: 0x060354A2 RID: 218274 RVA: 0x00C9E88B File Offset: 0x00C9CA8B
		protected override void OnBeforeShow()
		{
			this.RefreshInfo();
			this.BindRedDot();
		}

		// Token: 0x060354A3 RID: 218275 RVA: 0x00C9E899 File Offset: 0x00C9CA99
		protected override void OnBeforeHide()
		{
			this.UnbindRedDot();
		}

		// Token: 0x060354A4 RID: 218276 RVA: 0x00C9E8A4 File Offset: 0x00C9CAA4
		protected override void OnBeforeDestroy()
		{
			this.ViewModel.UnBind(new Action<EViewData>(this.OnViewModelUpdate));
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent != null)
			{
				tabViewComponent.DestroyTabViewComponent();
			}
			this.TabViewComponent = null;
			if (this.TimeHandle != null)
			{
				if (TimerSystem.RealTimeInstance.Has(this.TimeHandle))
				{
					TimerSystem.RealTimeInstance.Remove(this.TimeHandle);
				}
				this.TimeHandle = null;
			}
		}

		// Token: 0x060354A5 RID: 218277 RVA: 0x00C9E914 File Offset: 0x00C9CB14
		private void RefreshInfo()
		{
			PhantomArenaModel instance = PhantomArenaModel.Instance;
			int masterLevel = instance.GetMasterLevel(this.ActivityId);
			base.GetText(1).SetText(masterLevel.ToString(), true);
			string newText = StringUtils.Format("/{0}", new string[]
			{
				instance.GetMasterExpNextNeed(this.ActivityId).ToString()
			});
			base.GetText(5).SetText(newText, true);
			int masterExpNow = instance.GetMasterExpNow(this.ActivityId, null);
			base.GetText(4).SetText(masterExpNow.ToString(), true);
			PhantomBattleMasterLevel? masterLevelConfig = instance.GetMasterLevelConfig(masterLevel, this.ActivityId);
			if (masterLevelConfig == null)
			{
				return;
			}
			int titleId = masterLevelConfig.Value.TitleId;
			PhantomBattleMasterTitle phantomBattleMasterTitleById = PhantomArenaConfig.Instance.GetPhantomBattleMasterTitleById(titleId);
			base.SetTextureByPath(phantomBattleMasterTitleById.Icon, base.GetTexture(10), null, null);
			base.SetTextureByPath(phantomBattleMasterTitleById.IconBg, base.GetTexture(11), null, null);
			float fillAmount = (float)(masterExpNow - masterLevelConfig.Value.ExpNeed) / (float)masterLevelConfig.Value.ExpNext;
			base.GetSprite(6).SetFillAmount(fillAmount);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(12), phantomBattleMasterTitleById.Name, Array.Empty<object>());
			ValueTuple<bool, string> valueTuple = PhantomArenaModel.Instance.IsInLimitTime(this.ActivityId, null);
			bool item = valueTuple.Item1;
			string item2 = valueTuple.Item2;
			ActivityButtonItem btnMission = this.BtnMission;
			if (btnMission != null)
			{
				btnMission.SetUiActive(item);
			}
			if (item)
			{
				this.TimeHandle = TimerSystem.RealTimeInstance.Forever(new TTimerAction(this.OnTimerRefresh), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
				ActivityButtonItem btnMission2 = this.BtnMission;
				if (btnMission2 != null)
				{
					btnMission2.SetText(item2);
				}
			}
			int masterLevelMax = instance.GetMasterLevelMax(this.ActivityId);
			ActivityButtonItem btnLevel = this.BtnLevel;
			if (btnLevel == null)
			{
				return;
			}
			btnLevel.SetLocalTextNew("PhantomBattle_1025", new object[]
			{
				masterLevel,
				masterLevelMax
			});
		}

		// Token: 0x060354A6 RID: 218278 RVA: 0x00C9EB2C File Offset: 0x00C9CD2C
		private void RefreshMatchView()
		{
			base.GetItem(8).SetUIActive(true);
			this.UiViewSequence.PlaySequence("MatchStart", false, null);
		}

		// Token: 0x060354A7 RID: 218279 RVA: 0x00C9EB60 File Offset: 0x00C9CD60
		private void OnMatchStartFinish(string _)
		{
			int repeatChallenge = this.ViewModel.GetRepeatChallenge();
			EPhantomArenaChildViewName openView = PhantomArenaModel.Instance.IsNewPhantomArenaActivity(this.ActivityId) ? EPhantomArenaChildViewName.PhantomArenaChallengeDetailTabViewNew : EPhantomArenaChildViewName.PhantomArenaChallengeDetailTabView;
			PhantomArenaMainViewOpenParam param = new PhantomArenaMainViewOpenParam
			{
				ChallengeId = repeatChallenge,
				OpenView = openView,
				ActivityId = this.ActivityId
			};
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaMainView, param, delegate(bool _, int _)
			{
				base.GetItem(8).SetUIActive(false);
			});
		}

		// Token: 0x060354A8 RID: 218280 RVA: 0x00C9EBCC File Offset: 0x00C9CDCC
		private void OnClickBtnBack()
		{
			base.Back();
		}

		// Token: 0x060354A9 RID: 218281 RVA: 0x00C9EBD4 File Offset: 0x00C9CDD4
		private void OnClickedMission()
		{
			BattleShopViewOpenParam param = new BattleShopViewOpenParam
			{
				TabViewName = EUiTabViewName.PhantomArenaEntranceTaskTabView,
				ActivityId = this.ActivityId
			};
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaEntranceShopMainView, param, null);
		}

		// Token: 0x060354AA RID: 218282 RVA: 0x00C9EC0F File Offset: 0x00C9CE0F
		private void OnClickedLevel()
		{
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaMasterInfoView, this.ActivityId, null);
		}

		// Token: 0x060354AB RID: 218283 RVA: 0x00C9EC2C File Offset: 0x00C9CE2C
		private void OnClickedHelp()
		{
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaHelpView, 334, null);
		}

		// Token: 0x060354AC RID: 218284 RVA: 0x00C9EC48 File Offset: 0x00C9CE48
		private void OnViewModelUpdate(EViewData data)
		{
			if (data == EViewData.TabViewName)
			{
				EPhantomArenaChildViewName tabView = this.ViewModel.GetTabView();
				base.OpenChildView(tabView);
				return;
			}
			if (data == EViewData.RepeatChallengeId)
			{
				this.RefreshMatchView();
			}
		}

		// Token: 0x060354AD RID: 218285 RVA: 0x00C9EC76 File Offset: 0x00C9CE76
		private CommonTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x060354AE RID: 218286 RVA: 0x00C9EC7D File Offset: 0x00C9CE7D
		private void ToggleCallBack(int index)
		{
		}

		// Token: 0x060354AF RID: 218287 RVA: 0x00C9EC7F File Offset: 0x00C9CE7F
		private CommonTabData GetCommonData(int index)
		{
			return new CommonTabData("", null, null);
		}

		// Token: 0x060354B0 RID: 218288 RVA: 0x00C9EC8D File Offset: 0x00C9CE8D
		private void BindRedDot()
		{
			ActivityButtonItem btnMission = this.BtnMission;
			if (btnMission != null)
			{
				btnMission.BindRedDot(ERedDotName.RedDotPhantomArenaLimitReward, this.ActivityId);
			}
			ActivityButtonItem btnLevel = this.BtnLevel;
			if (btnLevel == null)
			{
				return;
			}
			btnLevel.BindRedDot(ERedDotName.RedDotPhantomArenaLevelReward, this.ActivityId);
		}

		// Token: 0x060354B1 RID: 218289 RVA: 0x00C9ECC6 File Offset: 0x00C9CEC6
		private void UnbindRedDot()
		{
			ActivityButtonItem btnMission = this.BtnMission;
			if (btnMission != null)
			{
				btnMission.UnBindRedDot();
			}
			ActivityButtonItem btnLevel = this.BtnLevel;
			if (btnLevel == null)
			{
				return;
			}
			btnLevel.UnBindRedDot();
		}

		// Token: 0x060354B2 RID: 218290 RVA: 0x00C9ECEC File Offset: 0x00C9CEEC
		private void OnTimerRefresh(float gap)
		{
			ValueTuple<bool, string> valueTuple = PhantomArenaModel.Instance.IsInLimitTime(this.ActivityId, null);
			bool item = valueTuple.Item1;
			string item2 = valueTuple.Item2;
			ActivityButtonItem btnMission = this.BtnMission;
			if (btnMission != null)
			{
				btnMission.SetUiActive(item);
			}
			if (item)
			{
				ActivityButtonItem btnMission2 = this.BtnMission;
				if (btnMission2 == null)
				{
					return;
				}
				btnMission2.SetText(item2);
			}
		}

		// Token: 0x060354B3 RID: 218291 RVA: 0x00C9ED3D File Offset: 0x00C9CF3D
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams == null || configParams.Length == 0)
			{
				return null;
			}
			if (!(configParams[0] == "GuideHook"))
			{
				return null;
			}
			if (configParams.Length < 2)
			{
				return null;
			}
			PhantomArenaChildViewBase curChildView = base.GetCurChildView();
			if (curChildView == null)
			{
				return null;
			}
			return curChildView.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x0401C580 RID: 116096
		[Nullable(2)]
		protected TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x0401C581 RID: 116097
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x0401C582 RID: 116098
		[Nullable(2)]
		private ActivityButtonItem BtnMission;

		// Token: 0x0401C583 RID: 116099
		[Nullable(2)]
		private ActivityButtonItem BtnLevel;

		// Token: 0x0401C584 RID: 116100
		[Nullable(2)]
		private TimerHandle TimeHandle;

		// Token: 0x0200B2CE RID: 45774
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040362CC RID: 221900
			public const int ItemCaption = 0;

			// Token: 0x040362CD RID: 221901
			public const int TextLevel = 1;

			// Token: 0x040362CE RID: 221902
			public const int ItemBtnMission = 2;

			// Token: 0x040362CF RID: 221903
			public const int ItemBtnLevel = 3;

			// Token: 0x040362D0 RID: 221904
			public const int TextExpNow = 4;

			// Token: 0x040362D1 RID: 221905
			public const int TextExpMax = 5;

			// Token: 0x040362D2 RID: 221906
			public const int SpriteExp = 6;

			// Token: 0x040362D3 RID: 221907
			public const int ItemContent = 7;

			// Token: 0x040362D4 RID: 221908
			public const int PanelMatch = 8;

			// Token: 0x040362D5 RID: 221909
			public const int PanelMatchTips = 9;

			// Token: 0x040362D6 RID: 221910
			public const int IconTitle = 10;

			// Token: 0x040362D7 RID: 221911
			public const int IconTitleBg = 11;

			// Token: 0x040362D8 RID: 221912
			public const int TextTitle = 12;

			// Token: 0x040362D9 RID: 221913
			public const int BtnLevel = 13;
		}
	}
}
