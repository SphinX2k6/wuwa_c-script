using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004615 RID: 17941
	[NullableContext(1)]
	[Nullable(0)]
	public class GridPopupViewModelEvent : GridPopupViewModelBase
	{
		// Token: 0x17005AFF RID: 23295
		// (get) Token: 0x0602D131 RID: 184625 RVA: 0x00C99FD0 File Offset: 0x00C981D0
		public override bool HasBtnDetail
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0602D132 RID: 184626 RVA: 0x00C99FD3 File Offset: 0x00C981D3
		public GridPopupViewModelEvent(MapGridData gridData, MapRogueGameInfo gameInfo) : base(gridData, gameInfo)
		{
		}

		// Token: 0x0602D133 RID: 184627 RVA: 0x00C99FE0 File Offset: 0x00C981E0
		public override UniTask Init()
		{
			GridPopupViewModelEvent.<Init>d__7 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<GridPopupViewModelEvent.<Init>d__7>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602D134 RID: 184628 RVA: 0x00C9A023 File Offset: 0x00C98223
		public override void RefreshTop()
		{
			this.EventCost.Refresh(this.GridData);
		}

		// Token: 0x0602D135 RID: 184629 RVA: 0x00C9A036 File Offset: 0x00C98236
		[NullableContext(2)]
		public override string GetSubTxtInfo()
		{
			if (this.GridData.Lv == 0)
			{
				return null;
			}
			return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("RogueRes_Block_Level", null), new string[]
			{
				this.GridData.Lv.ToString()
			});
		}

		// Token: 0x0602D136 RID: 184630 RVA: 0x00C9A070 File Offset: 0x00C98270
		public override void RefreshBottom()
		{
			this.InfoList.Refresh(this.GridData);
		}

		// Token: 0x0602D137 RID: 184631 RVA: 0x00C9A084 File Offset: 0x00C98284
		public override void RefreshFunctional()
		{
			if (!this.GridData.IsExplore)
			{
				this.RecommendTip.SetActive(this.GridData.Lv != 0);
				this.RecommendTip.SetTextChangeColor(this.GameInfo.TeamLv < this.GridData.Lv);
				this.RecommendTip.SetDescriptionByTextId("RogueRes_Block_Recommend_Level", new string[]
				{
					this.GridData.Lv.ToString()
				});
			}
			bool flag = base.EventAvailable();
			this.Button.SetUiActive(flag);
			if (!flag)
			{
				return;
			}
			this.Button.SetButtonTextByTextId("RogueRes_Block_Move", Array.Empty<string>());
			this.Button.SetButtonFunction(new Action<int>(base.MoveButtonFunction));
		}

		// Token: 0x0602D138 RID: 184632 RVA: 0x00C9A148 File Offset: 0x00C98348
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			if (configParams[0] == "EventCost")
			{
				PopupComponentEventCost eventCost = this.EventCost;
				if (eventCost == null)
				{
					return null;
				}
				return eventCost.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
			else if (configParams[0] == "goto")
			{
				PopupComponentFunctionButton button = this.Button;
				if (button == null)
				{
					return null;
				}
				return button.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
			else
			{
				if (!(configParams[0] == "InfoList"))
				{
					return null;
				}
				PopupComponentInfoList infoList = this.InfoList;
				UUIItem uuiitem = (infoList != null) ? infoList.GetRootItem() : null;
				if (uuiitem == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem,
					uuiitem
				};
			}
		}

		// Token: 0x04018310 RID: 99088
		protected PopupComponentRecommendTip RecommendTip;

		// Token: 0x04018311 RID: 99089
		protected PopupComponentFunctionButton Button;

		// Token: 0x04018312 RID: 99090
		protected PopupComponentInfoList InfoList;

		// Token: 0x04018313 RID: 99091
		protected PopupComponentEventCost EventCost;
	}
}
