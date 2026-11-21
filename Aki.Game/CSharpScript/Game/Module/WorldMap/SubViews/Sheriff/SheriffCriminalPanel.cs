using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Sheriff;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap.ViewComponent;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Sheriff
{
	// Token: 0x0200371F RID: 14111
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffCriminalPanel : WorldMapSecondaryUi
	{
		// Token: 0x06024B76 RID: 150390 RVA: 0x00A5DB39 File Offset: 0x00A5BD39
		public override string GetResourceId()
		{
			return "UiItem_SkyEyeMapNpcPopup";
		}

		// Token: 0x06024B77 RID: 150391 RVA: 0x00A5DB40 File Offset: 0x00A5BD40
		[PreserveBaseOverrides]
		protected new virtual SheriffPopupRightItem GetPopupRightItem()
		{
			return new SheriffPopupRightItem();
		}

		// Token: 0x06024B78 RID: 150392 RVA: 0x00A5DB48 File Offset: 0x00A5BD48
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06024B79 RID: 150393 RVA: 0x00A5DBB4 File Offset: 0x00A5BDB4
		protected override UniTask OnBeforeStartAsync()
		{
			SheriffCriminalPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SheriffCriminalPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024B7A RID: 150394 RVA: 0x00A5DBF7 File Offset: 0x00A5BDF7
		private void InitScroll()
		{
			this.LoopScroll = new LoopScrollView<SheriffCriminalListItem, SheriffCriminalInfo>(base.GetLoopScrollViewComponent(0), (AUIBaseActor)base.GetItem(1).GetOwner(), new Func<SheriffCriminalListItem>(this.CreateGrid), false);
		}

		// Token: 0x06024B7B RID: 150395 RVA: 0x00A5DC29 File Offset: 0x00A5BE29
		private SheriffCriminalListItem CreateGrid()
		{
			return new SheriffCriminalListItem
			{
				ClickCallBack = new Action<SheriffCriminalInfo>(this.OnClickCriminal)
			};
		}

		// Token: 0x06024B7C RID: 150396 RVA: 0x00A5DC44 File Offset: 0x00A5BE44
		private void OnClickCriminal(SheriffCriminalInfo data)
		{
			SheriffAnomalyInfo anomalyInfo = SheriffModel.Instance.GetAnomalyInfo(data.AnomalyId);
			if (anomalyInfo == null)
			{
				return;
			}
			if (anomalyInfo.State == ESheriffAnomalyState.Lock)
			{
				SheriffController.Instance.OpenAnomalyConditionView(data.AnomalyId);
				return;
			}
			base.CloseWithCallBack(delegate
			{
				EventSystem.Instance.Emit<NavigateMark>(EEventName.WorldMapNavigate, new NavigateMark
				{
					MarkId = anomalyInfo.MarkId,
					MarkType = EMarkType.SheriffAnomaly,
					Focal = new bool?(true)
				});
			}, true);
		}

		// Token: 0x06024B7D RID: 150397 RVA: 0x00A5DCA8 File Offset: 0x00A5BEA8
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length == 0)
			{
				return;
			}
			int zoneId = (int)param[0];
			List<SheriffCriminalInfo> criminalList = SheriffModel.Instance.GetCriminalList(zoneId);
			criminalList.Sort(new Comparison<SheriffCriminalInfo>(this.CompareCriminal));
			LoopScrollView<SheriffCriminalListItem, SheriffCriminalInfo> loopScroll = this.LoopScroll;
			if (loopScroll == null)
			{
				return;
			}
			loopScroll.RefreshByData(criminalList, false, null, false);
		}

		// Token: 0x06024B7E RID: 150398 RVA: 0x00A5DCF8 File Offset: 0x00A5BEF8
		private int CompareCriminal(SheriffCriminalInfo a, SheriffCriminalInfo b)
		{
			SheriffAnomalyInfo anomalyInfo = SheriffModel.Instance.GetAnomalyInfo(a.AnomalyId);
			SheriffAnomalyInfo anomalyInfo2 = SheriffModel.Instance.GetAnomalyInfo(b.AnomalyId);
			int sortGroup = this.GetSortGroup((anomalyInfo != null) ? new ESheriffAnomalyState?(anomalyInfo.State) : null);
			int sortGroup2 = this.GetSortGroup((anomalyInfo2 != null) ? new ESheriffAnomalyState?(anomalyInfo2.State) : null);
			if (sortGroup != sortGroup2)
			{
				return sortGroup - sortGroup2;
			}
			if (sortGroup == 0 && anomalyInfo != null && anomalyInfo2 != null && anomalyInfo.Progress != anomalyInfo2.Progress)
			{
				return anomalyInfo2.Progress - anomalyInfo.Progress;
			}
			SheriffCriminal? criminalConfigById = SheriffConfig.Instance.GetCriminalConfigById(a.CriminalId);
			int num = (criminalConfigById != null) ? criminalConfigById.GetValueOrDefault().Priority : 0;
			criminalConfigById = SheriffConfig.Instance.GetCriminalConfigById(b.CriminalId);
			return ((criminalConfigById != null) ? criminalConfigById.GetValueOrDefault().Priority : 0) - num;
		}

		// Token: 0x06024B7F RID: 150399 RVA: 0x00A5DDF8 File Offset: 0x00A5BFF8
		private int GetSortGroup(ESheriffAnomalyState? state)
		{
			if (state != null)
			{
				switch (state.GetValueOrDefault())
				{
				case ESheriffAnomalyState.Lock:
					return 2;
				case ESheriffAnomalyState.UnActivated:
					return 1;
				case ESheriffAnomalyState.UnOpened:
					return 0;
				case ESheriffAnomalyState.Opened:
					return 0;
				case ESheriffAnomalyState.Completed:
					return 3;
				}
			}
			return 4;
		}

		// Token: 0x04014620 RID: 83488
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<SheriffCriminalListItem, SheriffCriminalInfo> LoopScroll;

		// Token: 0x02009463 RID: 37987
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x0402E653 RID: 190035
			public const int Loop = 0;

			// Token: 0x0402E654 RID: 190036
			public const int LoopItem = 1;
		}
	}
}
