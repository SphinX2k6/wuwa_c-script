using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02004410 RID: 17424
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ResolutionListView : LanguageSettingViewBase<ResolutionToggle>
	{
		// Token: 0x0602BFFF RID: 180223 RVA: 0x00C5A9C7 File Offset: 0x00C58BC7
		public ResolutionListView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602C000 RID: 180224 RVA: 0x00C5A9DC File Offset: 0x00C58BDC
		[return: Nullable(2)]
		protected override ResolutionToggle CreateToggle(UUIItem uiItem, int index, bool isToggled)
		{
			ResolutionToggle resolutionToggle = new ResolutionToggle();
			resolutionToggle.Initialize(uiItem, index, isToggled);
			return resolutionToggle;
		}

		// Token: 0x0602C001 RID: 180225 RVA: 0x00C5A9EC File Offset: 0x00C58BEC
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

		// Token: 0x0602C002 RID: 180226 RVA: 0x00C5AA50 File Offset: 0x00C58C50
		protected override void OnRefreshView(ResolutionToggle newToggle)
		{
			FIntPoint fintPoint = this.ResolutionList[newToggle.GetIndex()];
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(fintPoint.X);
			defaultInterpolatedStringHandler.AppendLiteral("x");
			defaultInterpolatedStringHandler.AppendFormatted<int>(fintPoint.Y);
			newToggle.SetMainRawText(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x0602C003 RID: 180227 RVA: 0x00C5AAAB File Offset: 0x00C58CAB
		protected override void OnSelected(ResolutionToggle newToggle, EToggleState newToggleState)
		{
		}

		// Token: 0x0602C004 RID: 180228 RVA: 0x00C5AAB0 File Offset: 0x00C58CB0
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

		// Token: 0x04017B59 RID: 97113
		private FIntPoint[] ResolutionList = new FIntPoint[0];
	}
}
