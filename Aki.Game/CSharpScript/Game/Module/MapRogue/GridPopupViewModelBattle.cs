using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200563C RID: 22076
	[NullableContext(1)]
	[Nullable(0)]
	public class GridPopupViewModelBattle : GridPopupViewModelBase
	{
		// Token: 0x17008735 RID: 34613
		// (get) Token: 0x0603821F RID: 229919 RVA: 0x00D4BDDE File Offset: 0x00D49FDE
		public override bool HasBtnDetail
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06038220 RID: 229920 RVA: 0x00D4BDE1 File Offset: 0x00D49FE1
		public GridPopupViewModelBattle(MapGridData gridData, MapRogueGameInfo gameInfo) : base(gridData, gameInfo)
		{
		}

		// Token: 0x06038221 RID: 229921 RVA: 0x00D4BDEC File Offset: 0x00D49FEC
		public override UniTask Init()
		{
			GridPopupViewModelBattle.<Init>d__8 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<GridPopupViewModelBattle.<Init>d__8>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06038222 RID: 229922 RVA: 0x00D4BE2F File Offset: 0x00D4A02F
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

		// Token: 0x06038223 RID: 229923 RVA: 0x00D4BE69 File Offset: 0x00D4A069
		public override void RefreshBottom()
		{
			this.InfoList.Refresh(this.GridData);
			this.RewardList.Refresh(this.GridData);
		}

		// Token: 0x06038224 RID: 229924 RVA: 0x00D4BE8D File Offset: 0x00D4A08D
		public override void RefreshTop()
		{
			this.EventCost.Refresh(this.GridData);
		}

		// Token: 0x06038225 RID: 229925 RVA: 0x00D4BEA0 File Offset: 0x00D4A0A0
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

		// Token: 0x06038226 RID: 229926 RVA: 0x00D4BF64 File Offset: 0x00D4A164
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

		// Token: 0x0401D87C RID: 120956
		protected PopupComponentRecommendTip RecommendTip;

		// Token: 0x0401D87D RID: 120957
		protected PopupComponentFunctionButton Button;

		// Token: 0x0401D87E RID: 120958
		protected PopupComponentInfoList InfoList;

		// Token: 0x0401D87F RID: 120959
		protected PopupComponentEventCost EventCost;

		// Token: 0x0401D880 RID: 120960
		protected PopupComponentRewardList RewardList;
	}
}
