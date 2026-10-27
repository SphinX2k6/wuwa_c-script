using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200563F RID: 22079
	[NullableContext(1)]
	[Nullable(0)]
	public class GridPopupViewModelEvent : GridPopupViewModelBase
	{
		// Token: 0x17008738 RID: 34616
		// (get) Token: 0x06038233 RID: 229939 RVA: 0x00D4C288 File Offset: 0x00D4A488
		public override bool HasBtnDetail
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06038234 RID: 229940 RVA: 0x00D4C28B File Offset: 0x00D4A48B
		public GridPopupViewModelEvent(MapGridData gridData, MapRogueGameInfo gameInfo) : base(gridData, gameInfo)
		{
		}

		// Token: 0x06038235 RID: 229941 RVA: 0x00D4C298 File Offset: 0x00D4A498
		public override UniTask Init()
		{
			GridPopupViewModelEvent.<Init>d__7 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<GridPopupViewModelEvent.<Init>d__7>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06038236 RID: 229942 RVA: 0x00D4C2DB File Offset: 0x00D4A4DB
		public override void RefreshTop()
		{
			this.EventCost.Refresh(this.GridData);
		}

		// Token: 0x06038237 RID: 229943 RVA: 0x00D4C2EE File Offset: 0x00D4A4EE
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

		// Token: 0x06038238 RID: 229944 RVA: 0x00D4C328 File Offset: 0x00D4A528
		public override void RefreshBottom()
		{
			this.InfoList.Refresh(this.GridData);
		}

		// Token: 0x06038239 RID: 229945 RVA: 0x00D4C33C File Offset: 0x00D4A53C
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

		// Token: 0x0603823A RID: 229946 RVA: 0x00D4C400 File Offset: 0x00D4A600
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

		// Token: 0x0401D885 RID: 120965
		protected PopupComponentRecommendTip RecommendTip;

		// Token: 0x0401D886 RID: 120966
		protected PopupComponentFunctionButton Button;

		// Token: 0x0401D887 RID: 120967
		protected PopupComponentInfoList InfoList;

		// Token: 0x0401D888 RID: 120968
		protected PopupComponentEventCost EventCost;
	}
}
