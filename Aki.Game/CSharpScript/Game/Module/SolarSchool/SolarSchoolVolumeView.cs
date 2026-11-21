using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A59 RID: 23129
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolVolumeView : UiViewBase
	{
		// Token: 0x06038FCC RID: 233420 RVA: 0x00FF63CC File Offset: 0x00FF45CC
		public SolarSchoolVolumeView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038FCD RID: 233421 RVA: 0x00FF63E0 File Offset: 0x00FF45E0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIMultiTemplateScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038FCE RID: 233422 RVA: 0x00FF644C File Offset: 0x00FF464C
		protected override void OnStart()
		{
			CommonTabComponentData<CommonTabItem> data = new CommonTabComponentData<CommonTabItem>(new Func<UUIItem, int?, CommonTabItem>(this.CreateTabItem), new Action<int>(this.OnTabSelected), new Func<int, CommonTabData>(this.GetTabData));
			this.TabComponent = new TabComponentWithCaptionItem<CommonTabItem>(base.GetItem(1), data, new Action(this.CloseSelf), false);
			this.TabComponent.SetHelpButtonShowState(false);
			this.ScrollView = new MultiTemplateScrollView(base.GetMultiTemplateScrollViewComponent(0));
			this.SettingItems.Add(new SolarSchoolVolumeTitleData());
			this.AddSliderItem(EFunction.MASTERVOLUMEFUNCTION);
			this.AddSliderItem(EFunction.VOICEVOLUMEFUNCTION);
			this.AddSliderItem(EFunction.MUSICVOLUMEFUNCTION);
			this.AddSliderItem(EFunction.SFXVOLUMEFUNCTION);
			this.AddSliderItem(EFunction.AMBVOLUMEFUNCTION);
			this.AddSliderItem(EFunction.UIVOLUMEFUNCTION);
			this.AddSwitchItem(EFunction.BackendVolume);
			this.TabComponent.RefreshTabItemByLength(1, delegate
			{
				TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
				if (tabComponent == null)
				{
					return;
				}
				tabComponent.SelectToggleByIndex(0, false);
			});
		}

		// Token: 0x06038FCF RID: 233423 RVA: 0x00FF6521 File Offset: 0x00FF4721
		private void AddSliderItem(EFunction functionId)
		{
			if (GameSettingsManager.Instance.IsValid(functionId, true))
			{
				this.SettingItems.Add(new SolarSchoolVolumeSliderData(functionId));
			}
		}

		// Token: 0x06038FD0 RID: 233424 RVA: 0x00FF6542 File Offset: 0x00FF4742
		private void AddSwitchItem(EFunction functionId)
		{
			if (GameSettingsManager.Instance.IsValid(functionId, true))
			{
				this.SettingItems.Add(new SolarSchoolVolumeSwitchData(functionId));
			}
		}

		// Token: 0x06038FD1 RID: 233425 RVA: 0x00FF6563 File Offset: 0x00FF4763
		private CommonTabItem CreateTabItem([Nullable(2)] UUIItem item, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x06038FD2 RID: 233426 RVA: 0x00FF656A File Offset: 0x00FF476A
		private void OnTabSelected(int index)
		{
			this.RefreshSettings();
		}

		// Token: 0x06038FD3 RID: 233427 RVA: 0x00FF6574 File Offset: 0x00FF4774
		private CommonTabData GetTabData(int index)
		{
			MainType? mainTypeConfigById = MenuBaseConfig.Instance.GetMainTypeConfigById(1);
			if (mainTypeConfigById == null)
			{
				return new CommonTabData(string.Empty, new CommonTabTitleData(string.Empty, Array.Empty<object>()), null);
			}
			return new CommonTabData(mainTypeConfigById.Value.MainIcon, new CommonTabTitleData(mainTypeConfigById.Value.MainName, Array.Empty<object>()), null);
		}

		// Token: 0x06038FD4 RID: 233428 RVA: 0x00FF65DF File Offset: 0x00FF47DF
		protected override void OnBeforeShow()
		{
			this.RefreshSettings();
		}

		// Token: 0x06038FD5 RID: 233429 RVA: 0x00FF65E7 File Offset: 0x00FF47E7
		private void RefreshSettings()
		{
			MultiTemplateScrollView scrollView = this.ScrollView;
			if (scrollView == null)
			{
				return;
			}
			scrollView.RefreshByData(new MultiTemplateScrollViewRefreshContext(this.SettingItems)
			{
				ScrollToGridIndex = 0
			});
		}

		// Token: 0x06038FD6 RID: 233430 RVA: 0x00FF660B File Offset: 0x00FF480B
		protected override void OnAfterDestroy()
		{
			if (!this.IsDestroyByClear && SolarSchoolGamePlayModel.Instance.IsInGamePlay)
			{
				SolarSchoolModel.Instance.ShowSettingView();
			}
		}

		// Token: 0x0401DFF2 RID: 122866
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x0401DFF3 RID: 122867
		[Nullable(2)]
		private MultiTemplateScrollView ScrollView;

		// Token: 0x0401DFF4 RID: 122868
		private readonly List<IMultiTemplateGridData> SettingItems = new List<IMultiTemplateGridData>();

		// Token: 0x0200B648 RID: 46664
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403863A RID: 230970
			public const int ScrollView = 0;

			// Token: 0x0403863B RID: 230971
			public const int Caption = 1;
		}
	}
}
