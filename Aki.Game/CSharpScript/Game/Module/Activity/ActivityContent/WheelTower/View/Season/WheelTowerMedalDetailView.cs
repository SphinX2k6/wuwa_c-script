using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower.View.Season
{
	// Token: 0x02004F3D RID: 20285
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerMedalDetailView : UiViewBase
	{
		// Token: 0x06032F83 RID: 208771 RVA: 0x00E4802B File Offset: 0x00E4622B
		public WheelTowerMedalDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06032F84 RID: 208772 RVA: 0x00E48034 File Offset: 0x00E46234
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
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
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(13, new Action(this.OnLookBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnSkipBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06032F85 RID: 208773 RVA: 0x00E482D8 File Offset: 0x00E464D8
		protected override UniTask OnBeforeStartAsync()
		{
			WheelTowerMedalDetailView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerMedalDetailView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032F86 RID: 208774 RVA: 0x00E4831C File Offset: 0x00E4651C
		private void RefreshTitle(IWheelTowerMedalGroupData groupData)
		{
			int id = (groupData.CurrentMedalId != 0) ? groupData.CurrentMedalId : groupData.NextMedalId;
			NewTowerMedal? medalConfigById = WheelTowerConfig.Instance.GetMedalConfigById(id);
			if (medalConfigById == null)
			{
				return;
			}
			UUIText text = base.GetText(3);
			if (groupData.CycleId == 0)
			{
				LguiUtil instance = LguiUtil.Instance;
				UUIText uiText = text;
				string name = medalConfigById.Value.Name;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("S");
				defaultInterpolatedStringHandler.AppendFormatted<int>(groupData.SeasonId);
				instance.SetLocalTextNew(uiText, name, new <>z__ReadOnlySingleElementList<object>(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			else if (text != null)
			{
				text.ShowTextNew(medalConfigById.Value.Name);
			}
			UUIText text2 = base.GetText(4);
			if (text2 == null)
			{
				return;
			}
			text2.ShowTextNew(medalConfigById.Value.Desc);
		}

		// Token: 0x06032F87 RID: 208775 RVA: 0x00E483E8 File Offset: 0x00E465E8
		private void RefreshDetail(IWheelTowerMedalGroupData groupData)
		{
			bool flag = groupData.CycleId == 0;
			bool flag2 = this.IsCurrentSeason(groupData);
			long completeTime = groupData.CompleteTime;
			if (completeTime != 0L)
			{
				UUIText text = base.GetText(8);
				if (text != null)
				{
					text.SetText(TimeUtil.Instance.DateFormat4String((double)completeTime), true);
				}
			}
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(completeTime != 0L);
			}
			bool flag3 = flag;
			bool flag4 = !flag;
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(flag3);
			}
			UUIItem item3 = base.GetItem(11);
			if (item3 != null)
			{
				item3.SetUIActive(flag4);
			}
			UUIItem item4 = base.GetItem(9);
			if (item4 != null)
			{
				item4.SetUIActive(false);
			}
			if (!flag3)
			{
				if (flag4)
				{
					int progress = groupData.Progress;
					string newText;
					if (!flag2)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
						defaultInterpolatedStringHandler.AppendLiteral("<color=#fff2bc>");
						defaultInterpolatedStringHandler.AppendFormatted<int>(progress);
						defaultInterpolatedStringHandler.AppendLiteral("</color>");
						newText = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					else
					{
						string text2;
						if (!groupData.IsMaxLevel)
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
							defaultInterpolatedStringHandler.AppendLiteral("<color=#fff2bc>");
							defaultInterpolatedStringHandler.AppendFormatted<int>(progress);
							defaultInterpolatedStringHandler.AppendLiteral("</color>/");
							defaultInterpolatedStringHandler.AppendFormatted<int>(groupData.CurrentTarget);
							text2 = defaultInterpolatedStringHandler.ToStringAndClear();
						}
						else
						{
							text2 = progress.ToString();
						}
						newText = text2;
					}
					UUIText text3 = base.GetText(12);
					if (text3 == null)
					{
						return;
					}
					text3.SetText(newText, true);
				}
				return;
			}
			int progress2 = groupData.Progress;
			int currentTarget = groupData.CurrentTarget;
			string newText2;
			if (!flag2)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
				defaultInterpolatedStringHandler.AppendLiteral("<color=#fff2bc>");
				defaultInterpolatedStringHandler.AppendFormatted<int>(progress2);
				defaultInterpolatedStringHandler.AppendLiteral("</color>");
				newText2 = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				string text4;
				if (progress2 < currentTarget)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
					defaultInterpolatedStringHandler.AppendLiteral("<color=#fff2bc>");
					defaultInterpolatedStringHandler.AppendFormatted<int>(progress2);
					defaultInterpolatedStringHandler.AppendLiteral("</color>/");
					defaultInterpolatedStringHandler.AppendFormatted<int>(currentTarget);
					text4 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					text4 = progress2.ToString();
				}
				newText2 = text4;
			}
			UUIText text5 = base.GetText(6);
			if (text5 == null)
			{
				return;
			}
			text5.SetText(newText2, true);
		}

		// Token: 0x06032F88 RID: 208776 RVA: 0x00E485E8 File Offset: 0x00E467E8
		private void RefreshButtons(IWheelTowerMedalGroupData groupData)
		{
			bool uiactive = this.IsCurrentSeason(groupData);
			UUIButtonComponent button = base.GetButton(13);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(uiactive);
				}
			}
			UUIButtonComponent button2 = base.GetButton(14);
			if (button2 == null)
			{
				return;
			}
			UUIItem uuiitem2 = button2.RootUIComp.Get();
			if (uuiitem2 == null)
			{
				return;
			}
			uuiitem2.SetUIActive(this.IsCurrentMedal(groupData) && !groupData.IsMaxLevel);
		}

		// Token: 0x06032F89 RID: 208777 RVA: 0x00E48660 File Offset: 0x00E46860
		private UniTask CreateMedalItem(IWheelTowerMedalGroupData groupData)
		{
			WheelTowerMedalDetailView.<CreateMedalItem>d__9 <CreateMedalItem>d__;
			<CreateMedalItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateMedalItem>d__.<>4__this = this;
			<CreateMedalItem>d__.<>1__state = -1;
			<CreateMedalItem>d__.<>t__builder.Start<WheelTowerMedalDetailView.<CreateMedalItem>d__9>(ref <CreateMedalItem>d__);
			return <CreateMedalItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032F8A RID: 208778 RVA: 0x00E486A4 File Offset: 0x00E468A4
		private bool IsCurrentSeason(IWheelTowerMedalGroupData groupData)
		{
			WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
			int num = (activityData != null) ? activityData.SeasonId : 0;
			return groupData.SeasonId == num;
		}

		// Token: 0x06032F8B RID: 208779 RVA: 0x00E486D4 File Offset: 0x00E468D4
		private bool IsCurrentCycle(IWheelTowerMedalGroupData groupData)
		{
			int cycleId = groupData.CycleId;
			WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
			int? num = (activityData != null) ? new int?(activityData.CycleId) : null;
			return cycleId == num.GetValueOrDefault() & num != null;
		}

		// Token: 0x06032F8C RID: 208780 RVA: 0x00E4871C File Offset: 0x00E4691C
		private bool IsCurrentMedal(IWheelTowerMedalGroupData groupData)
		{
			if (groupData.CycleId == 0)
			{
				return this.IsCurrentSeason(groupData);
			}
			return this.IsCurrentSeason(groupData) && this.IsCurrentCycle(groupData);
		}

		// Token: 0x06032F8D RID: 208781 RVA: 0x00E48740 File Offset: 0x00E46940
		private void ReportEnterMedalEvent(IWheelTowerMedalGroupData groupData)
		{
			NewTowerClickMedalEvent newTowerClickMedalEvent = new NewTowerClickMedalEvent();
			newTowerClickMedalEvent.i_activity_id = WheelTowerModel.Instance.ActivityData.Id;
			newTowerClickMedalEvent.i_season_id = groupData.SeasonId;
			newTowerClickMedalEvent.i_item_id = ((groupData.CurrentMedalId != 0) ? groupData.CurrentMedalId : groupData.NextMedalId);
			LogReportController.Instance.LogReport(newTowerClickMedalEvent);
		}

		// Token: 0x06032F8E RID: 208782 RVA: 0x00E4879C File Offset: 0x00E4699C
		private void ReportMedalSkipEvent(IWheelTowerMedalGroupData groupData)
		{
			NewTowerClickMedalSkipEvent newTowerClickMedalSkipEvent = new NewTowerClickMedalSkipEvent();
			newTowerClickMedalSkipEvent.i_activity_id = WheelTowerModel.Instance.ActivityData.Id;
			newTowerClickMedalSkipEvent.i_season_id = groupData.SeasonId;
			newTowerClickMedalSkipEvent.i_item_id = ((groupData.CurrentMedalId != 0) ? groupData.CurrentMedalId : groupData.NextMedalId);
			LogReportController.Instance.LogReport(newTowerClickMedalSkipEvent);
		}

		// Token: 0x06032F8F RID: 208783 RVA: 0x00E487F7 File Offset: 0x00E469F7
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06032F90 RID: 208784 RVA: 0x00E48800 File Offset: 0x00E46A00
		private void OnLookBtnClick()
		{
			WheelTowerMedalDetailViewData wheelTowerMedalDetailViewData = this.OpenParam as WheelTowerMedalDetailViewData;
			if (wheelTowerMedalDetailViewData == null)
			{
				return;
			}
			WheelTowerMedalRuleViewData param = new WheelTowerMedalRuleViewData
			{
				GroupId = wheelTowerMedalDetailViewData.GroupId
			};
			UiManager.Instance.OpenView(EUiViewName.WheelTowerMedalRuleView, param, null);
		}

		// Token: 0x06032F91 RID: 208785 RVA: 0x00E48840 File Offset: 0x00E46A40
		private void OnSkipBtnClick()
		{
			WheelTowerMedalDetailViewData wheelTowerMedalDetailViewData = this.OpenParam as WheelTowerMedalDetailViewData;
			if (wheelTowerMedalDetailViewData == null)
			{
				return;
			}
			IWheelTowerMedalGroupData medalGroupData = WheelTowerModel.Instance.GetMedalGroupData(wheelTowerMedalDetailViewData.GroupId);
			if (medalGroupData == null)
			{
				return;
			}
			if (medalGroupData.CycleId == 0)
			{
				UiManager.Instance.OpenView(EUiViewName.WheelTowerSeasonRewardView, null, null);
			}
			else
			{
				UiManager.Instance.OpenView(EUiViewName.WheelTowerPrepareView, null, null);
			}
			this.ReportMedalSkipEvent(medalGroupData);
			base.CloseMe(null);
		}

		// Token: 0x0401B07D RID: 110717
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B07E RID: 110718
		[Nullable(2)]
		private WheelTowerSeasonMedalDetailItem SeasonMedalItem;

		// Token: 0x0401B07F RID: 110719
		[Nullable(2)]
		private WheelTowerStageMedalDetailItem StageMedalItem;
	}
}
