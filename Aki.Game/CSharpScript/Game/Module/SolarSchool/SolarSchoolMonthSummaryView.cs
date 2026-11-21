using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A62 RID: 23138
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolMonthSummaryView : SolarSchoolHideHudViewBase
	{
		// Token: 0x06038FFE RID: 233470 RVA: 0x00FF718A File Offset: 0x00FF538A
		public SolarSchoolMonthSummaryView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06038FFF RID: 233471 RVA: 0x00FF719C File Offset: 0x00FF539C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.NextBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06039000 RID: 233472 RVA: 0x00FF72E7 File Offset: 0x00FF54E7
		private void NextBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06039001 RID: 233473 RVA: 0x00FF72F0 File Offset: 0x00FF54F0
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolMonthSummaryView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolMonthSummaryView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039002 RID: 233474 RVA: 0x00FF7334 File Offset: 0x00FF5534
		private void InitAttributePanel()
		{
			List<ValueTuple<ESolarSchoolSecondAttr, int>> list = new List<ValueTuple<ESolarSchoolSecondAttr, int>>();
			SolarSchoolSummaryData monthSummaryData = SolarSchoolGamePlayModel.Instance.SummaryRecordData.MonthSummaryData;
			foreach (ESolarSchoolSecondAttr esolarSchoolSecondAttr in SolarSchoolDefine.AttrsShowList)
			{
				int attrChange = monthSummaryData.GetAttrChange(esolarSchoolSecondAttr);
				list.Add(new ValueTuple<ESolarSchoolSecondAttr, int>(esolarSchoolSecondAttr, attrChange));
			}
			SolarSchoolSummaryAttributePanel attributePanel = this.AttributePanel;
			if (attributePanel != null)
			{
				attributePanel.SetAttrChangeTuples(list);
			}
			float[] currentAttr = new float[SolarSchoolDefine.AttrsShowList.Length];
			this.AttributePanel.SetCurrentAttr(currentAttr);
			this.AttributePanel.SetAttrItemsTextVisible(false);
		}

		// Token: 0x06039003 RID: 233475 RVA: 0x00FF73C5 File Offset: 0x00FF55C5
		private SolarSchoolMonthSummaryItem InitItem()
		{
			return new SolarSchoolMonthSummaryItem();
		}

		// Token: 0x06039004 RID: 233476 RVA: 0x00FF73CC File Offset: 0x00FF55CC
		protected override void OnStart()
		{
			this.CloseCallback = (this.OpenParam as Action);
			this.RefreshStatisticsView();
			base.SetButtonUiActive(5, false);
			this.InitAttributePanel();
		}

		// Token: 0x06039005 RID: 233477 RVA: 0x00FF73F3 File Offset: 0x00FF55F3
		protected override void OnAfterPlayStartSequence()
		{
			this.PlayAttributePanelShowAnim().Forget();
		}

		// Token: 0x06039006 RID: 233478 RVA: 0x00FF7400 File Offset: 0x00FF5600
		private void RefreshStatisticsView()
		{
			int num = 0;
			List<SolarSchoolMonthSummaryData> list = new List<SolarSchoolMonthSummaryData>();
			SolarSchoolSummaryData monthSummaryData = SolarSchoolGamePlayModel.Instance.SummaryRecordData.MonthSummaryData;
			for (int i = 0; i < SolarSchoolDefine.SummaryAttrs.Length; i++)
			{
				ESolarSchoolSecondAttr esolarSchoolSecondAttr = SolarSchoolDefine.SummaryAttrs[i];
				int attrChange = monthSummaryData.GetAttrChange(esolarSchoolSecondAttr);
				if (i >= this.StatisticsShowAttrStartIndex && attrChange != 0)
				{
					SolarSchoolMonthSummaryData item = new SolarSchoolMonthSummaryData
					{
						Attr = new ESolarSchoolSecondAttr?(esolarSchoolSecondAttr),
						Value = attrChange
					};
					list.Add(item);
				}
				num += attrChange;
			}
			if (monthSummaryData.CompletedNoticeCount > 0)
			{
				SolarSchoolMonthSummaryData item2 = new SolarSchoolMonthSummaryData
				{
					Value = monthSummaryData.CompletedNoticeCount,
					IsNotice = true
				};
				list.Add(item2);
			}
			GenericLayout<SolarSchoolMonthSummaryItem, SolarSchoolMonthSummaryData> layout = this.Layout;
			if (layout != null)
			{
				layout.RefreshByData(list, null, false);
			}
			SolarSchoolSpan? solarSchoolSpan = this.FindMonthTipsSpan(num);
			if (solarSchoolSpan != null)
			{
				string spanParam = this.GetSpanParam(solarSchoolSpan.Value, "TextId");
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(7), spanParam, Array.Empty<object>());
			}
		}

		// Token: 0x06039007 RID: 233479 RVA: 0x00FF7504 File Offset: 0x00FF5704
		private string GetSpanParam(SolarSchoolSpan span, string key)
		{
			for (int i = 0; i < span.ModifierParamsLength; i++)
			{
				DicStringString? dicStringString = span.ModifierParams(i);
				if (dicStringString != null && dicStringString.Value.Key == key)
				{
					return dicStringString.Value.Value;
				}
			}
			return "";
		}

		// Token: 0x06039008 RID: 233480 RVA: 0x00FF7564 File Offset: 0x00FF5764
		private bool IsValueInTipsSpan(SolarSchoolSpan span, int value)
		{
			int num;
			int num2;
			if (!int.TryParse(this.GetSpanParam(span, "MinValue"), out num) || !int.TryParse(this.GetSpanParam(span, "MaxValue"), out num2))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 月度评语区间缺少 MinValue/MaxValue 参数，检查 SolarSchoolSpan 的 ModifierParams";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("spanId", span.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			return value >= num && value <= num2;
		}

		// Token: 0x06039009 RID: 233481 RVA: 0x00FF75E0 File Offset: 0x00FF57E0
		private SolarSchoolSpan? FindMonthTipsSpan(int value)
		{
			IReadOnlyList<SolarSchoolSpan> spanList = SolarSchoolConfig.Instance.GetSpanList(SolarSchoolGamePlayModel.Instance.ActivityId);
			if (spanList == null)
			{
				return null;
			}
			SolarSchoolSpan? result = null;
			foreach (SolarSchoolSpan solarSchoolSpan in spanList)
			{
				if (!(solarSchoolSpan.ModifierType != "MoonSummaryTips") && this.IsValueInTipsSpan(solarSchoolSpan, value) && (result == null || solarSchoolSpan.Priority > result.Value.Priority))
				{
					result = new SolarSchoolSpan?(solarSchoolSpan);
				}
			}
			return result;
		}

		// Token: 0x0603900A RID: 233482 RVA: 0x00FF7698 File Offset: 0x00FF5898
		private UniTask PlayAttributePanelShowAnim()
		{
			SolarSchoolMonthSummaryView.<PlayAttributePanelShowAnim>d__17 <PlayAttributePanelShowAnim>d__;
			<PlayAttributePanelShowAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAttributePanelShowAnim>d__.<>4__this = this;
			<PlayAttributePanelShowAnim>d__.<>1__state = -1;
			<PlayAttributePanelShowAnim>d__.<>t__builder.Start<SolarSchoolMonthSummaryView.<PlayAttributePanelShowAnim>d__17>(ref <PlayAttributePanelShowAnim>d__);
			return <PlayAttributePanelShowAnim>d__.<>t__builder.Task;
		}

		// Token: 0x0603900B RID: 233483 RVA: 0x00FF76DB File Offset: 0x00FF58DB
		protected override void OnBeforeDestroy()
		{
			Action closeCallback = this.CloseCallback;
			if (closeCallback != null)
			{
				closeCallback();
			}
			this.CloseCallback = null;
		}

		// Token: 0x0401E001 RID: 122881
		[Nullable(2)]
		private SolarSchoolSummaryAttributePanel AttributePanel;

		// Token: 0x0401E002 RID: 122882
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<SolarSchoolMonthSummaryItem, SolarSchoolMonthSummaryData> Layout;

		// Token: 0x0401E003 RID: 122883
		[Nullable(2)]
		private Action CloseCallback;

		// Token: 0x0401E004 RID: 122884
		private readonly int StatisticsShowAttrStartIndex = 5;

		// Token: 0x0200B64E RID: 46670
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04038652 RID: 230994
			public const int AttrItem = 0;

			// Token: 0x04038653 RID: 230995
			public const int PnlAttrItem = 1;

			// Token: 0x04038654 RID: 230996
			public const int PnlStatisticsItem = 2;

			// Token: 0x04038655 RID: 230997
			public const int Layout = 3;

			// Token: 0x04038656 RID: 230998
			public const int LayoutItem = 4;

			// Token: 0x04038657 RID: 230999
			public const int SaveBtn = 5;

			// Token: 0x04038658 RID: 231000
			public const int NextBtn = 6;

			// Token: 0x04038659 RID: 231001
			public const int TipsText = 7;

			// Token: 0x0403865A RID: 231002
			public const int ContentItem = 8;
		}
	}
}
