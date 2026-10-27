using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x0200542D RID: 21549
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ResolutionListView : LanguageSettingViewBase<ResolutionToggle>
	{
		// Token: 0x060370B6 RID: 225462 RVA: 0x00D0B5A7 File Offset: 0x00D097A7
		public ResolutionListView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060370B7 RID: 225463 RVA: 0x00D0B5BC File Offset: 0x00D097BC
		[return: Nullable(2)]
		protected override ResolutionToggle CreateToggle(UUIItem uiItem, int index, bool isToggled)
		{
			ResolutionToggle resolutionToggle = new ResolutionToggle();
			resolutionToggle.Initialize(uiItem, index, isToggled);
			return resolutionToggle;
		}

		// Token: 0x060370B8 RID: 225464 RVA: 0x00D0B5CC File Offset: 0x00D097CC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		protected override ILayoutItem<UiPanelBase> DoRefreshScrollView(object index, UUIItem uiItem, int _)
		{
			bool flag = MenuController.Instance.GetTargetConfig(EFunction.RESOLUTION) == (int)index;
			ResolutionToggle resolutionToggle = this.CreateToggle(uiItem, (int)index, flag);
			if (resolutionToggle == null)
			{
				return null;
			}
			if (flag)
			{
				this.SelectedToggle = resolutionToggle;
			}
			else
			{
				resolutionToggle.UnSelect();
			}
			resolutionToggle.SetSelectedCallBack(new Action<LanguageToggleBase, EToggleState>(base.DoSelected));
			this.OnRefreshView(resolutionToggle);
			return null;
		}

		// Token: 0x060370B9 RID: 225465 RVA: 0x00D0B630 File Offset: 0x00D09830
		protected override void OnRefreshView(ResolutionToggle newToggle)
		{
			FIntPoint fintPoint = this.ResolutionList[newToggle.GetIndex()];
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(fintPoint.X);
			defaultInterpolatedStringHandler.AppendLiteral("x");
			defaultInterpolatedStringHandler.AppendFormatted<int>(fintPoint.Y);
			newToggle.SetMainRawText(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x060370BA RID: 225466 RVA: 0x00D0B68B File Offset: 0x00D0988B
		protected override void OnSelected(ResolutionToggle newToggle, EToggleState newToggleState)
		{
		}

		// Token: 0x060370BB RID: 225467 RVA: 0x00D0B690 File Offset: 0x00D09890
		protected override void InitScrollViewData()
		{
			List<int> allowResolutionList = MenuModel.Instance.AllowResolutionList;
			if (allowResolutionList == null)
			{
				return;
			}
			int num = 0;
			int i = 1;
			HashSet<float> hashSet = new HashSet<float>();
			while (i < allowResolutionList.Count)
			{
				int num2 = allowResolutionList[num];
				int num3 = allowResolutionList[i];
				hashSet.Add((float)num2 / (float)num3);
				num += 2;
				i += 2;
			}
			this.ResolutionList = GameSettingsDeviceRender.Instance.GetResolutionList().ToArray();
			List<int> list = new List<int>();
			for (int j = 0; j < this.ResolutionList.Length; j++)
			{
				FIntPoint fintPoint = this.ResolutionList[j];
				float item = (float)fintPoint.X / (float)fintPoint.Y;
				if (hashSet.Contains(item))
				{
					list.Add(j);
				}
			}
			this.ScrollView.RefreshByData<int>(list, null);
		}

		// Token: 0x0401D0C0 RID: 118976
		private FIntPoint[] ResolutionList = new FIntPoint[0];
	}
}
