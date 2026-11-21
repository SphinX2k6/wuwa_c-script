using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004612 RID: 17938
	[NullableContext(1)]
	[Nullable(0)]
	public class GridPopupViewModelBattle : GridPopupViewModelBase
	{
		// Token: 0x17005AFC RID: 23292
		// (get) Token: 0x0602D11D RID: 184605 RVA: 0x00C99B26 File Offset: 0x00C97D26
		public override bool HasBtnDetail
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0602D11E RID: 184606 RVA: 0x00C99B29 File Offset: 0x00C97D29
		public GridPopupViewModelBattle(MapGridData gridData, MapRogueGameInfo gameInfo) : base(gridData, gameInfo)
		{
		}

		// Token: 0x0602D11F RID: 184607 RVA: 0x00C99B34 File Offset: 0x00C97D34
		public override UniTask Init()
		{
			GridPopupViewModelBattle.<Init>d__8 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<GridPopupViewModelBattle.<Init>d__8>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602D120 RID: 184608 RVA: 0x00C99B77 File Offset: 0x00C97D77
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

		// Token: 0x0602D121 RID: 184609 RVA: 0x00C99BB1 File Offset: 0x00C97DB1
		public override void RefreshBottom()
		{
			this.InfoList.Refresh(this.GridData);
			this.RewardList.Refresh(this.GridData);
		}

		// Token: 0x0602D122 RID: 184610 RVA: 0x00C99BD5 File Offset: 0x00C97DD5
		public override void RefreshTop()
		{
			this.EventCost.Refresh(this.GridData);
		}

		// Token: 0x0602D123 RID: 184611 RVA: 0x00C99BE8 File Offset: 0x00C97DE8
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

		// Token: 0x0602D124 RID: 184612 RVA: 0x00C99CAC File Offset: 0x00C97EAC
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
				UUIItem uuiitem = (button != null) ? button.GetRootItem() : null;
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
			else
			{
				if (!(configParams[0] == "InfoList"))
				{
					return null;
				}
				PopupComponentInfoList infoList = this.InfoList;
				UUIItem uuiitem2 = (infoList != null) ? infoList.GetRootItem() : null;
				if (uuiitem2 == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem2,
					uuiitem2
				};
			}
		}

		// Token: 0x04018307 RID: 99079
		protected PopupComponentRecommendTip RecommendTip;

		// Token: 0x04018308 RID: 99080
		protected PopupComponentFunctionButton Button;

		// Token: 0x04018309 RID: 99081
		protected PopupComponentInfoList InfoList;

		// Token: 0x0401830A RID: 99082
		protected PopupComponentEventCost EventCost;

		// Token: 0x0401830B RID: 99083
		protected PopupComponentRewardList RewardList;
	}
}
