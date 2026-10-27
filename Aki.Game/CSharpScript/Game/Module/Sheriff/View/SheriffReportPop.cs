using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View
{
	// Token: 0x02004C59 RID: 19545
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffReportPop : UiTickViewBase
	{
		// Token: 0x0603287F RID: 206975 RVA: 0x00BC5763 File Offset: 0x00BC3963
		public SheriffReportPop(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06032880 RID: 206976 RVA: 0x00BC5780 File Offset: 0x00BC3980
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBackBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnClickTogSkyEyeTab));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnClickTogSkyEyeTab2));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06032881 RID: 206977 RVA: 0x00BC5914 File Offset: 0x00BC3B14
		protected override void OnStart()
		{
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor != null)
			{
				rootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnSequenceEventStart));
			}
			this.InitData();
			bool uiactive = this.BothPage && this.AnomalyInfo.EndingTime != 0L;
			UUIExtendToggle extendToggle = base.GetExtendToggle(2);
			if (extendToggle != null)
			{
				extendToggle.RootUIComp.Get().SetUIActive(uiactive);
			}
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(3);
			if (extendToggle2 != null)
			{
				extendToggle2.RootUIComp.Get().SetUIActive(uiactive);
			}
			this.TabDataList = DynamicTabConfig.Instance.GetViewTabList(EUiViewName.SheriffReportPop);
			this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(5), EKeyMode.Default);
		}

		// Token: 0x06032882 RID: 206978 RVA: 0x00BC59D1 File Offset: 0x00BC3BD1
		protected override void OnBeforeShow()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(2);
			if (extendToggle != null)
			{
				extendToggle.SetSelfInteractive(false);
			}
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(3);
			if (extendToggle2 == null)
			{
				return;
			}
			extendToggle2.SetSelfInteractive(false);
		}

		// Token: 0x06032883 RID: 206979 RVA: 0x00BC59F8 File Offset: 0x00BC3BF8
		protected override void OnBeforeDestroy()
		{
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent != null)
			{
				tabViewComponent.DestroyTabViewComponent();
			}
			this.TabViewComponent = null;
		}

		// Token: 0x06032884 RID: 206980 RVA: 0x00BC5A14 File Offset: 0x00BC3C14
		private void InitData()
		{
			ISheriffReportPopViewParam sheriffReportPopViewParam = this.OpenParam as ISheriffReportPopViewParam;
			this.CriminalId = sheriffReportPopViewParam.CriminalId;
			this.BothPage = sheriffReportPopViewParam.BothPage;
			this.CriminalInfo = SheriffModel.Instance.GetCriminalInfo(this.CriminalId);
			SheriffCriminal value = SheriffConfig.Instance.GetCriminalConfigById(this.CriminalId).Value;
			this.AnomalyInfo = SheriffModel.Instance.GetAnomalyInfo(value.SheriffAnomalyId);
			SheriffAnomaly value2 = SheriffConfig.Instance.GetAnomalyConfigById(value.SheriffAnomalyId).Value;
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.ShowTextNew(value2.Name);
			}
			int anomalyProgressPercent = SheriffModel.Instance.GetAnomalyProgressPercent(value.SheriffAnomalyId);
			string text2 = (anomalyProgressPercent == 100) ? "Sheriff_EventProgress_19" : "Sheriff_EventProgress_1";
			LguiUtil instance = LguiUtil.Instance;
			UUIText text3 = base.GetText(6);
			string textStringId = text2;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(anomalyProgressPercent);
			defaultInterpolatedStringHandler.AppendLiteral("%");
			instance.SetLocalTextNew(text3, textStringId, new <>z__ReadOnlySingleElementList<object>(defaultInterpolatedStringHandler.ToStringAndClear()));
		}

		// Token: 0x06032885 RID: 206981 RVA: 0x00BC5B21 File Offset: 0x00BC3D21
		private void OnClickBackBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x06032886 RID: 206982 RVA: 0x00BC5B2C File Offset: 0x00BC3D2C
		private void OnClickTogSkyEyeTab(EToggleState state)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(3);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			SheriffReportPopParam extraParams = new SheriffReportPopParam
			{
				CriminalId = this.CriminalId,
				CloseCallback = delegate
				{
					this.OnClickBackBtn();
				}
			};
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent == null)
			{
				return;
			}
			tabViewComponent.ToggleCallBack(this.TabDataList[0], EUiTabViewName.SheriffReportDetailItem, null, extraParams, null);
		}

		// Token: 0x06032887 RID: 206983 RVA: 0x00BC5BA0 File Offset: 0x00BC3DA0
		private void OnClickTogSkyEyeTab2(EToggleState state)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(2);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent == null)
			{
				return;
			}
			tabViewComponent.ToggleCallBack(this.TabDataList[1], EUiTabViewName.SheriffReportRecordItem, null, this.CriminalId, null);
		}

		// Token: 0x06032888 RID: 206984 RVA: 0x00BC5BFC File Offset: 0x00BC3DFC
		private void OnSequenceEventStart(string sequenceName, string eventName)
		{
			if (sequenceName != "Start" || eventName != "Start")
			{
				return;
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(2);
			if (extendToggle != null)
			{
				extendToggle.SetSelfInteractive(true);
			}
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(3);
			if (extendToggle2 != null)
			{
				extendToggle2.SetSelfInteractive(true);
			}
			if (this.BothPage)
			{
				if (this.AnomalyInfo.EndingTime == 0L)
				{
					UUIExtendToggle extendToggle3 = base.GetExtendToggle(2);
					if (extendToggle3 == null)
					{
						return;
					}
					extendToggle3.SetToggleState(EToggleState.ETT_Checked, true, false, false);
					return;
				}
				else
				{
					UUIExtendToggle extendToggle4 = base.GetExtendToggle(3);
					if (extendToggle4 == null)
					{
						return;
					}
					extendToggle4.SetToggleState(EToggleState.ETT_Checked, true, false, false);
					return;
				}
			}
			else
			{
				UUIExtendToggle extendToggle5 = base.GetExtendToggle(3);
				if (extendToggle5 == null)
				{
					return;
				}
				extendToggle5.SetToggleState(EToggleState.ETT_Checked, true, false, false);
				return;
			}
		}

		// Token: 0x0401AE5D RID: 110173
		private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x0401AE5E RID: 110174
		[Nullable(2)]
		protected SheriffAnomalyInfo AnomalyInfo;

		// Token: 0x0401AE5F RID: 110175
		[Nullable(2)]
		protected SheriffCriminalInfo CriminalInfo;

		// Token: 0x0401AE60 RID: 110176
		[Nullable(2)]
		protected TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x0401AE61 RID: 110177
		protected int CriminalId;

		// Token: 0x0401AE62 RID: 110178
		protected bool BothPage = true;

		// Token: 0x0200ADFD RID: 44541
		[NullableContext(0)]
		private static class EDefine
		{
			// Token: 0x04034D8B RID: 216459
			public const int BackBtn = 0;

			// Token: 0x04034D8C RID: 216460
			public const int PanelTab = 1;

			// Token: 0x04034D8D RID: 216461
			public const int TogSkyEyeTab = 2;

			// Token: 0x04034D8E RID: 216462
			public const int TogSkyEyeTab2 = 3;

			// Token: 0x04034D8F RID: 216463
			public const int TxtTitle = 4;

			// Token: 0x04034D90 RID: 216464
			public const int Content = 5;

			// Token: 0x04034D91 RID: 216465
			public const int TxtProgress = 6;
		}
	}
}
