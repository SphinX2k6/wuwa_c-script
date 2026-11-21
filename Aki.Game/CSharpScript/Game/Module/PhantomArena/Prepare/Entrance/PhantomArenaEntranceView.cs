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
	// Token: 0x0200413B RID: 16699
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaEntranceView : PhantomArenaRootViewBase<PhantomArenaEntranceViewModel>
	{
		// Token: 0x0602A396 RID: 172950 RVA: 0x00BEBB63 File Offset: 0x00BE9D63
		public PhantomArenaEntranceView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602A397 RID: 172951 RVA: 0x00BEBB6C File Offset: 0x00BE9D6C
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

		// Token: 0x0602A398 RID: 172952 RVA: 0x00BEBCE1 File Offset: 0x00BE9EE1
		protected override void OnRegisterDefaultChildView()
		{
			this.DefaultChildViewName = new EPhantomArenaChildViewName?(EPhantomArenaChildViewName.PhantomArenaEntranceGymTabView);
		}

		// Token: 0x0602A399 RID: 172953 RVA: 0x00BEBCEF File Offset: 0x00BE9EEF
		protected override void OnRegisterContentItem()
		{
			this.ContentItem = base.GetItem(7);
		}

		// Token: 0x0602A39A RID: 172954 RVA: 0x00BEBCFE File Offset: 0x00BE9EFE
		protected override void OnRegisterViewData()
		{
			this.ViewModel = new PhantomArenaEntranceViewModel();
			this.ViewModel.Bind(new Action<EViewData>(this.OnViewModelUpdate));
		}

		// Token: 0x0602A39B RID: 172955 RVA: 0x00BEBD24 File Offset: 0x00BE9F24
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaEntranceView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaEntranceView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A39C RID: 172956 RVA: 0x00BEBD68 File Offset: 0x00BE9F68
		private UniTask InitTab()
		{
			PhantomArenaEntranceView.<InitTab>d__12 <InitTab>d__;
			<InitTab>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTab>d__.<>4__this = this;
			<InitTab>d__.<>1__state = -1;
			<InitTab>d__.<>t__builder.Start<PhantomArenaEntranceView.<InitTab>d__12>(ref <InitTab>d__);
			return <InitTab>d__.<>t__builder.Task;
		}

		// Token: 0x0602A39D RID: 172957 RVA: 0x00BEBDAB File Offset: 0x00BE9FAB
		protected override void OnStart()
		{
			base.GetItem(8).SetUIActive(false);
			this.UiViewSequence.AddSequenceFinishEvent("MatchStart", new Action<string>(this.OnMatchStartFinish), false);
		}

		// Token: 0x0602A39E RID: 172958 RVA: 0x00BEBDD7 File Offset: 0x00BE9FD7
		protected override void OnBeforeShow()
		{
			this.RefreshInfo();
			this.BindRedDot();
		}

		// Token: 0x0602A39F RID: 172959 RVA: 0x00BEBDE5 File Offset: 0x00BE9FE5
		protected override void OnBeforeHide()
		{
			this.UnbindRedDot();
		}

		// Token: 0x0602A3A0 RID: 172960 RVA: 0x00BEBDF0 File Offset: 0x00BE9FF0
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

		// Token: 0x0602A3A1 RID: 172961 RVA: 0x00BEBE60 File Offset: 0x00BEA060
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

		// Token: 0x0602A3A2 RID: 172962 RVA: 0x00BEC078 File Offset: 0x00BEA278
		private void RefreshMatchView()
		{
			base.GetItem(8).SetUIActive(true);
			this.UiViewSequence.PlaySequence("MatchStart", false, null);
		}

		// Token: 0x0602A3A3 RID: 172963 RVA: 0x00BEC0AC File Offset: 0x00BEA2AC
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

		// Token: 0x0602A3A4 RID: 172964 RVA: 0x00BEC118 File Offset: 0x00BEA318
		private void OnClickBtnBack()
		{
			base.Back();
		}

		// Token: 0x0602A3A5 RID: 172965 RVA: 0x00BEC120 File Offset: 0x00BEA320
		private void OnClickedMission()
		{
			BattleShopViewOpenParam param = new BattleShopViewOpenParam
			{
				TabViewName = EUiTabViewName.PhantomArenaEntranceTaskTabView,
				ActivityId = this.ActivityId
			};
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaEntranceShopMainView, param, null);
		}

		// Token: 0x0602A3A6 RID: 172966 RVA: 0x00BEC15B File Offset: 0x00BEA35B
		private void OnClickedLevel()
		{
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaMasterInfoView, this.ActivityId, null);
		}

		// Token: 0x0602A3A7 RID: 172967 RVA: 0x00BEC178 File Offset: 0x00BEA378
		private void OnClickedHelp()
		{
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaHelpView, 334, null);
		}

		// Token: 0x0602A3A8 RID: 172968 RVA: 0x00BEC194 File Offset: 0x00BEA394
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

		// Token: 0x0602A3A9 RID: 172969 RVA: 0x00BEC1C2 File Offset: 0x00BEA3C2
		private CommonTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x0602A3AA RID: 172970 RVA: 0x00BEC1C9 File Offset: 0x00BEA3C9
		private void ToggleCallBack(int index)
		{
		}

		// Token: 0x0602A3AB RID: 172971 RVA: 0x00BEC1CB File Offset: 0x00BEA3CB
		private CommonTabData GetCommonData(int index)
		{
			return new CommonTabData("", null, null);
		}

		// Token: 0x0602A3AC RID: 172972 RVA: 0x00BEC1D9 File Offset: 0x00BEA3D9
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

		// Token: 0x0602A3AD RID: 172973 RVA: 0x00BEC212 File Offset: 0x00BEA412
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

		// Token: 0x0602A3AE RID: 172974 RVA: 0x00BEC238 File Offset: 0x00BEA438
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

		// Token: 0x0602A3AF RID: 172975 RVA: 0x00BEC289 File Offset: 0x00BEA489
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

		// Token: 0x04016FB5 RID: 94133
		[Nullable(2)]
		protected TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x04016FB6 RID: 94134
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x04016FB7 RID: 94135
		[Nullable(2)]
		private ActivityButtonItem BtnMission;

		// Token: 0x04016FB8 RID: 94136
		[Nullable(2)]
		private ActivityButtonItem BtnLevel;

		// Token: 0x04016FB9 RID: 94137
		[Nullable(2)]
		private TimerHandle TimeHandle;

		// Token: 0x02009D08 RID: 40200
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04030D23 RID: 199971
			public const int ItemCaption = 0;

			// Token: 0x04030D24 RID: 199972
			public const int TextLevel = 1;

			// Token: 0x04030D25 RID: 199973
			public const int ItemBtnMission = 2;

			// Token: 0x04030D26 RID: 199974
			public const int ItemBtnLevel = 3;

			// Token: 0x04030D27 RID: 199975
			public const int TextExpNow = 4;

			// Token: 0x04030D28 RID: 199976
			public const int TextExpMax = 5;

			// Token: 0x04030D29 RID: 199977
			public const int SpriteExp = 6;

			// Token: 0x04030D2A RID: 199978
			public const int ItemContent = 7;

			// Token: 0x04030D2B RID: 199979
			public const int PanelMatch = 8;

			// Token: 0x04030D2C RID: 199980
			public const int PanelMatchTips = 9;

			// Token: 0x04030D2D RID: 199981
			public const int IconTitle = 10;

			// Token: 0x04030D2E RID: 199982
			public const int IconTitleBg = 11;

			// Token: 0x04030D2F RID: 199983
			public const int TextTitle = 12;

			// Token: 0x04030D30 RID: 199984
			public const int BtnLevel = 13;
		}
	}
}
