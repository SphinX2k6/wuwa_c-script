using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Item
{
	// Token: 0x02004C74 RID: 19572
	[NullableContext(2)]
	[Nullable(0)]
	public class SheriffReportDetailItem : UiTabViewBase
	{
		// Token: 0x0603296D RID: 207213 RVA: 0x00BCB778 File Offset: 0x00BC9978
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(13, new Action(this.OnClickBtnFunctionA));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603296E RID: 207214 RVA: 0x00BCB9F8 File Offset: 0x00BC9BF8
		protected override void OnBeforeShow()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x0603296F RID: 207215 RVA: 0x00BCBA24 File Offset: 0x00BC9C24
		protected override void OnStart()
		{
			ISheriffReportPopParam sheriffReportPopParam = this.ExtraParams as ISheriffReportPopParam;
			int criminalId = sheriffReportPopParam.CriminalId;
			this.CloseViewCallback = sheriffReportPopParam.CloseCallback;
			this.CriminalInfo = SheriffModel.Instance.GetCriminalInfo(criminalId);
			this.AnomalyInfo = SheriffModel.Instance.GetAnomalyInfo(this.CriminalInfo.AnomalyId);
			this.ConfirmBtn = new ButtonItem(base.GetItem(14));
			this.ConfirmBtn.SetFunction(new Action<int>(this.OnClickBtnConfirmB));
			this.RefreshPanelRole();
			this.RewardList = new LoopScrollView<CommonItemSmallItemGrid, TItem>(base.GetLoopScrollViewComponent(5), base.GetItem(6).GetOwner() as AUIBaseActor, new Func<CommonItemSmallItemGrid>(this.CreateGrid), false);
			this.ProgressScroll = new GenericScrollViewNew<SheriffReportDetailItemProgress, ISheriffProgressPopInfo>(base.GetScrollViewWithScrollbar(7), new Func<SheriffReportDetailItemProgress>(this.CreateProgressGrid), null, false, null);
			this.RefreshRewardList();
			this.RefreshProgressScroll();
		}

		// Token: 0x06032970 RID: 207216 RVA: 0x00BCBB0C File Offset: 0x00BC9D0C
		private void OnClickBtnFunctionA()
		{
			SheriffShowClueViewPopInfo param = new SheriffShowClueViewPopInfo
			{
				AnomalyId = this.AnomalyInfo.AnomalyId
			};
			UiManager.Instance.OpenView(EUiViewName.SheriffShowClueViewPop, param, null);
		}

		// Token: 0x06032971 RID: 207217 RVA: 0x00BCBB44 File Offset: 0x00BC9D44
		private void OnClickBtnConfirmB(int id)
		{
			if (!SheriffModel.Instance.CheckGameplayActivated(this.AnomalyInfo.AnomalyId))
			{
				EventSystem.Instance.Emit<int>(EEventName.OnGotoAnomaly, this.AnomalyInfo.AnomalyId);
				Action closeViewCallback = this.CloseViewCallback;
				if (closeViewCallback == null)
				{
					return;
				}
				closeViewCallback();
				return;
			}
			else if (!SheriffModel.Instance.CheckInBehaviorTreeRange(this.AnomalyInfo.AnomalyId))
			{
				EventSystem.Instance.Emit<int>(EEventName.OnGotoAnomaly, this.AnomalyInfo.AnomalyId);
				Action closeViewCallback2 = this.CloseViewCallback;
				if (closeViewCallback2 == null)
				{
					return;
				}
				closeViewCallback2();
				return;
			}
			else if (SheriffModel.Instance.CheckInReasoningNode(this.AnomalyInfo.AnomalyId))
			{
				SheriffAnomaly value = SheriffConfig.Instance.GetAnomalyConfigById(this.AnomalyInfo.AnomalyId).Value;
				SheriffController.Instance.OpenAnalysisClueView(value.QuestionId);
				Action closeViewCallback3 = this.CloseViewCallback;
				if (closeViewCallback3 == null)
				{
					return;
				}
				closeViewCallback3();
				return;
			}
			else
			{
				EventSystem.Instance.Emit<int>(EEventName.OnGotoAnomaly, this.AnomalyInfo.AnomalyId);
				Action closeViewCallback4 = this.CloseViewCallback;
				if (closeViewCallback4 == null)
				{
					return;
				}
				closeViewCallback4();
				return;
			}
		}

		// Token: 0x06032972 RID: 207218 RVA: 0x00BCBC5C File Offset: 0x00BC9E5C
		private void RefreshPanelRole()
		{
			ESheriffCriminalState state = this.CriminalInfo.State;
			bool flag = state == ESheriffCriminalState.Unconfirmed;
			SheriffIdentity value = SheriffConfig.Instance.GetIdentityConfigById(this.CriminalInfo.Identity).Value;
			bool flag2 = flag;
			bool uiactive = state == ESheriffCriminalState.Arrested;
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(flag2);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(!flag2);
			}
			UUIItem item3 = base.GetItem(4);
			if (item3 != null)
			{
				item3.SetUIActive(uiactive);
			}
			if (flag2)
			{
				return;
			}
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.ShowTextNew(value.Name);
			}
			base.SetTextureByPath(value.IconReport, base.GetTexture(2), null, null);
		}

		// Token: 0x06032973 RID: 207219 RVA: 0x00BCBD14 File Offset: 0x00BC9F14
		private void RefreshRewardList()
		{
			SheriffAnomaly value = SheriffConfig.Instance.GetAnomalyConfigById(this.AnomalyInfo.AnomalyId).Value;
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(value.DropId);
			LoopScrollView<CommonItemSmallItemGrid, TItem> rewardList = this.RewardList;
			if (rewardList == null)
			{
				return;
			}
			rewardList.RefreshByData(dropPackagePreviewItemList, false, null, false);
		}

		// Token: 0x06032974 RID: 207220 RVA: 0x00BCBD68 File Offset: 0x00BC9F68
		private void RefreshProgressScroll()
		{
			int anomalyId = this.AnomalyInfo.AnomalyId;
			List<int> progressList = this.GetProgressList();
			List<ISheriffProgressPopInfo> list = new List<ISheriffProgressPopInfo>();
			foreach (int id in progressList)
			{
				SheriffProgress value = SheriffConfig.Instance.GetProgressConfigById(id).Value;
				SheriffProgressPopInfo item = new SheriffProgressPopInfo
				{
					Progress = value,
					NeedAnim = false
				};
				list.Add(item);
			}
			if (list.Count > 0)
			{
				list[list.Count - 1].NeedAnim = true;
			}
			GenericScrollViewNew<SheriffReportDetailItemProgress, ISheriffProgressPopInfo> progressScroll = this.ProgressScroll;
			if (progressScroll != null)
			{
				progressScroll.RefreshByData(list, new Action(this.OnAfterRefreshProgressScroll), true);
			}
			bool flag = this.AnomalyInfo.EndingTime != 0L;
			UUIItem item2 = base.GetItem(15);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			UUIItem item3 = base.GetItem(9);
			if (item3 != null)
			{
				item3.SetUIActive(!flag);
			}
			UUIItem item4 = base.GetItem(11);
			if (item4 != null)
			{
				item4.SetUIActive(!flag);
			}
			if (!flag)
			{
				int type = SheriffConfig.Instance.GetAnomalyConfigById(anomalyId).Value.Type;
				UUIText text = base.GetText(12);
				if (text != null)
				{
					text.SetUIActive(type > 0);
				}
				List<int> clueListByAnomalyId = SheriffModel.Instance.GetClueListByAnomalyId(anomalyId);
				int count = this.AnomalyInfo.ClueIds.Count;
				bool uiactive = count > 0 && type > 0;
				UUIButtonComponent button = base.GetButton(13);
				if (button != null)
				{
					button.RootUIComp.Get().SetUIActive(uiactive);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(12), "Sheriff_EventProgress_9", new <>z__ReadOnlyArray<object>(new object[]
				{
					Math.Min(count, clueListByAnomalyId.Count),
					clueListByAnomalyId.Count
				}));
				FColor changeColor = base.GetText(12).changeColor;
				UUIText text2 = base.GetText(12);
				if (text2 != null)
				{
					bool bUseChangeColor = count != clueListByAnomalyId.Count;
					FColor? fcolor = new FColor?(changeColor);
					text2.SetChangeColor(bUseChangeColor, fcolor);
				}
				this.RefreshTargetPanel();
			}
		}

		// Token: 0x06032975 RID: 207221 RVA: 0x00BCBFA0 File Offset: 0x00BCA1A0
		[NullableContext(1)]
		private List<int> GetProgressList()
		{
			int anomalyId = this.AnomalyInfo.AnomalyId;
			IEnumerable<SheriffProgress> progressConfigListByAnomalyId = SheriffConfig.Instance.GetProgressConfigListByAnomalyId(anomalyId);
			List<int> list = new List<int>();
			foreach (SheriffProgress sheriffProgress in progressConfigListByAnomalyId)
			{
				if (sheriffProgress.ProgressType == 1)
				{
					list.Add(sheriffProgress.Id);
				}
			}
			list.AddRange(this.AnomalyInfo.ProgressIds);
			return list;
		}

		// Token: 0x06032976 RID: 207222 RVA: 0x00BCC028 File Offset: 0x00BCA228
		protected void RefreshTargetPanel()
		{
			if (!SheriffModel.Instance.CheckGameplayActivated(this.AnomalyInfo.AnomalyId))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "Sheriff_EventProgress_6", Array.Empty<object>());
				ButtonItem confirmBtn = this.ConfirmBtn;
				if (confirmBtn == null)
				{
					return;
				}
				confirmBtn.SetShowText("Sheriff_EventProgress_10");
				return;
			}
			else if (!SheriffModel.Instance.CheckInBehaviorTreeRange(this.AnomalyInfo.AnomalyId))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "Sheriff_EventProgress_7", Array.Empty<object>());
				ButtonItem confirmBtn2 = this.ConfirmBtn;
				if (confirmBtn2 == null)
				{
					return;
				}
				confirmBtn2.SetShowText("Sheriff_EventProgress_10");
				return;
			}
			else if (SheriffModel.Instance.CheckInReasoningNode(this.AnomalyInfo.AnomalyId))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "Sheriff_EventProgress_8", Array.Empty<object>());
				ButtonItem confirmBtn3 = this.ConfirmBtn;
				if (confirmBtn3 == null)
				{
					return;
				}
				confirmBtn3.SetShowText("Sheriff_EventProgress_11");
				return;
			}
			else
			{
				string currentBehaviorTreeNodeText = SheriffModel.Instance.GetCurrentBehaviorTreeNodeText(this.AnomalyInfo.AnomalyId);
				if (StringUtils.IsBlank(currentBehaviorTreeNodeText))
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "Sheriff_EventProgress_7", Array.Empty<object>());
				}
				else
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(10), currentBehaviorTreeNodeText, Array.Empty<object>());
				}
				ButtonItem confirmBtn4 = this.ConfirmBtn;
				if (confirmBtn4 == null)
				{
					return;
				}
				confirmBtn4.SetShowText("Sheriff_EventProgress_10");
				return;
			}
		}

		// Token: 0x06032977 RID: 207223 RVA: 0x00BCC179 File Offset: 0x00BCA379
		[NullableContext(1)]
		private CommonItemSmallItemGrid CreateGrid()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = new Func<TItem, bool>(this.CheckLevelFinished)
			};
		}

		// Token: 0x06032978 RID: 207224 RVA: 0x00BCC192 File Offset: 0x00BCA392
		private bool CheckLevelFinished(TItem data)
		{
			return this.AnomalyInfo.EndingTime != 0L;
		}

		// Token: 0x06032979 RID: 207225 RVA: 0x00BCC1A3 File Offset: 0x00BCA3A3
		[NullableContext(1)]
		private SheriffReportDetailItemProgress CreateProgressGrid()
		{
			return new SheriffReportDetailItemProgress();
		}

		// Token: 0x0603297A RID: 207226 RVA: 0x00BCC1AA File Offset: 0x00BCA3AA
		private void OnAfterRefreshProgressScroll()
		{
			TimerSystem.GameplayTimeInstance.Next(delegate(float _)
			{
				this.OnLateUpdate();
			}, null, null);
		}

		// Token: 0x0603297B RID: 207227 RVA: 0x00BCC1C5 File Offset: 0x00BCA3C5
		protected void OnLateUpdate()
		{
			base.GetScrollViewWithScrollbar(7).OnLateUpdate.Bind(delegate(float _)
			{
				base.GetScrollViewWithScrollbar(7).ScrollToEnd();
				base.GetScrollViewWithScrollbar(7).OnLateUpdate.Unbind();
			});
		}

		// Token: 0x0401AEB3 RID: 110259
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoopScrollView<CommonItemSmallItemGrid, TItem> RewardList;

		// Token: 0x0401AEB4 RID: 110260
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<SheriffReportDetailItemProgress, ISheriffProgressPopInfo> ProgressScroll;

		// Token: 0x0401AEB5 RID: 110261
		protected ButtonItem ConfirmBtn;

		// Token: 0x0401AEB6 RID: 110262
		protected SheriffAnomalyInfo AnomalyInfo;

		// Token: 0x0401AEB7 RID: 110263
		protected SheriffCriminalInfo CriminalInfo;

		// Token: 0x0401AEB8 RID: 110264
		protected Action CloseViewCallback;

		// Token: 0x0200AE29 RID: 44585
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x04034E57 RID: 216663
			PanelLock,
			// Token: 0x04034E58 RID: 216664
			PanelUnlock,
			// Token: 0x04034E59 RID: 216665
			TexRole,
			// Token: 0x04034E5A RID: 216666
			TxtName,
			// Token: 0x04034E5B RID: 216667
			PanelDone,
			// Token: 0x04034E5C RID: 216668
			SvInfo,
			// Token: 0x04034E5D RID: 216669
			UiItemItemBaseB,
			// Token: 0x04034E5E RID: 216670
			SvInfoAlt,
			// Token: 0x04034E5F RID: 216671
			PanelInfo,
			// Token: 0x04034E60 RID: 216672
			PanelMission,
			// Token: 0x04034E61 RID: 216673
			TxtMission,
			// Token: 0x04034E62 RID: 216674
			PanelButton,
			// Token: 0x04034E63 RID: 216675
			TxtNum,
			// Token: 0x04034E64 RID: 216676
			BtnFunctionA,
			// Token: 0x04034E65 RID: 216677
			BtnConfirmB,
			// Token: 0x04034E66 RID: 216678
			PanelDoneAlt
		}
	}
}
