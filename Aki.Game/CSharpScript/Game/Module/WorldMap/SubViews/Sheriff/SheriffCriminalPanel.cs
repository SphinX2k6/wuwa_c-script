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
	// Token: 0x020047EE RID: 18414
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffCriminalPanel : WorldMapSecondaryUi
	{
		// Token: 0x060303A6 RID: 197542 RVA: 0x00B2DBF5 File Offset: 0x00B2BDF5
		public override string GetResourceId()
		{
			return "UiItem_SkyEyeMapNpcPopup";
		}

		// Token: 0x060303A7 RID: 197543 RVA: 0x00B2DBFC File Offset: 0x00B2BDFC
		[PreserveBaseOverrides]
		protected new virtual SheriffPopupRightItem GetPopupRightItem()
		{
			return new SheriffPopupRightItem();
		}

		// Token: 0x060303A8 RID: 197544 RVA: 0x00B2DC04 File Offset: 0x00B2BE04
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

		// Token: 0x060303A9 RID: 197545 RVA: 0x00B2DC70 File Offset: 0x00B2BE70
		protected override UniTask OnBeforeStartAsync()
		{
			SheriffCriminalPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SheriffCriminalPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060303AA RID: 197546 RVA: 0x00B2DCB3 File Offset: 0x00B2BEB3
		private void InitScroll()
		{
			this.LoopScroll = new LoopScrollView<SheriffCriminalListItem, SheriffCriminalInfo>(base.GetLoopScrollViewComponent(0), (AUIBaseActor)base.GetItem(1).GetOwner(), new Func<SheriffCriminalListItem>(this.CreateGrid), false);
		}

		// Token: 0x060303AB RID: 197547 RVA: 0x00B2DCE5 File Offset: 0x00B2BEE5
		private SheriffCriminalListItem CreateGrid()
		{
			return new SheriffCriminalListItem
			{
				ClickCallBack = new Action<SheriffCriminalInfo>(this.OnClickCriminal)
			};
		}

		// Token: 0x060303AC RID: 197548 RVA: 0x00B2DD00 File Offset: 0x00B2BF00
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

		// Token: 0x060303AD RID: 197549 RVA: 0x00B2DD64 File Offset: 0x00B2BF64
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

		// Token: 0x060303AE RID: 197550 RVA: 0x00B2DDB4 File Offset: 0x00B2BFB4
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

		// Token: 0x060303AF RID: 197551 RVA: 0x00B2DEB4 File Offset: 0x00B2C0B4
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

		// Token: 0x04019F6C RID: 106348
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<SheriffCriminalListItem, SheriffCriminalInfo> LoopScroll;

		// Token: 0x0200AAB1 RID: 43697
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x04033ECD RID: 212685
			public const int Loop = 0;

			// Token: 0x04033ECE RID: 212686
			public const int LoopItem = 1;
		}
	}
}
