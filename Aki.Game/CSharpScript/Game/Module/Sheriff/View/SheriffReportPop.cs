using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View
{
	// Token: 0x02003C0A RID: 15370
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffReportPop : UiTickViewBase
	{
		// Token: 0x06027632 RID: 161330 RVA: 0x00B0A3AF File Offset: 0x00B085AF
		public SheriffReportPop(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06027633 RID: 161331 RVA: 0x00B0A3CC File Offset: 0x00B085CC
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

		// Token: 0x06027634 RID: 161332 RVA: 0x00B0A560 File Offset: 0x00B08760
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

		// Token: 0x06027635 RID: 161333 RVA: 0x00B0A61D File Offset: 0x00B0881D
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

		// Token: 0x06027636 RID: 161334 RVA: 0x00B0A644 File Offset: 0x00B08844
		protected override void OnBeforeDestroy()
		{
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent != null)
			{
				tabViewComponent.DestroyTabViewComponent();
			}
			this.TabViewComponent = null;
		}

		// Token: 0x06027637 RID: 161335 RVA: 0x00B0A660 File Offset: 0x00B08860
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

		// Token: 0x06027638 RID: 161336 RVA: 0x00B0A76D File Offset: 0x00B0896D
		private void OnClickBackBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x06027639 RID: 161337 RVA: 0x00B0A778 File Offset: 0x00B08978
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

		// Token: 0x0602763A RID: 161338 RVA: 0x00B0A7EC File Offset: 0x00B089EC
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

		// Token: 0x0602763B RID: 161339 RVA: 0x00B0A848 File Offset: 0x00B08A48
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

		// Token: 0x040157BA RID: 87994
		private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x040157BB RID: 87995
		[Nullable(2)]
		protected SheriffAnomalyInfo AnomalyInfo;

		// Token: 0x040157BC RID: 87996
		[Nullable(2)]
		protected SheriffCriminalInfo CriminalInfo;

		// Token: 0x040157BD RID: 87997
		[Nullable(2)]
		protected TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x040157BE RID: 87998
		protected int CriminalId;

		// Token: 0x040157BF RID: 87999
		protected bool BothPage = true;

		// Token: 0x0200981B RID: 38939
		[NullableContext(0)]
		private static class EDefine
		{
			// Token: 0x0402F730 RID: 194352
			public const int BackBtn = 0;

			// Token: 0x0402F731 RID: 194353
			public const int PanelTab = 1;

			// Token: 0x0402F732 RID: 194354
			public const int TogSkyEyeTab = 2;

			// Token: 0x0402F733 RID: 194355
			public const int TogSkyEyeTab2 = 3;

			// Token: 0x0402F734 RID: 194356
			public const int TxtTitle = 4;

			// Token: 0x0402F735 RID: 194357
			public const int Content = 5;

			// Token: 0x0402F736 RID: 194358
			public const int TxtProgress = 6;
		}
	}
}
