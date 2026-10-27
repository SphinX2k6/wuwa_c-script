using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200563E RID: 22078
	[NullableContext(1)]
	[Nullable(0)]
	public class GridPopupViewModelBoss : GridPopupViewModelBase
	{
		// Token: 0x17008737 RID: 34615
		// (get) Token: 0x0603822C RID: 229932 RVA: 0x00D4C0DA File Offset: 0x00D4A2DA
		public override bool HasBtnDetail
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0603822D RID: 229933 RVA: 0x00D4C0DD File Offset: 0x00D4A2DD
		public GridPopupViewModelBoss(MapGridData gridData, MapRogueGameInfo gameInfo) : base(gridData, gameInfo)
		{
		}

		// Token: 0x0603822E RID: 229934 RVA: 0x00D4C0E8 File Offset: 0x00D4A2E8
		public override UniTask Init()
		{
			GridPopupViewModelBoss.<Init>d__6 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<GridPopupViewModelBoss.<Init>d__6>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0603822F RID: 229935 RVA: 0x00D4C12B File Offset: 0x00D4A32B
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

		// Token: 0x06038230 RID: 229936 RVA: 0x00D4C165 File Offset: 0x00D4A365
		public override void RefreshTop()
		{
			this.EventCost.Refresh(this.GridData);
		}

		// Token: 0x06038231 RID: 229937 RVA: 0x00D4C178 File Offset: 0x00D4A378
		public override void RefreshFunctional()
		{
			this.RecommendTip.SetActive(this.GridData.Lv != 0);
			this.RecommendTip.SetTextChangeColor(this.GameInfo.TeamLv < this.GridData.Lv);
			this.RecommendTip.SetDescriptionByTextId("RogueRes_Block_Recommend_Level", new string[]
			{
				this.GridData.Lv.ToString()
			});
			bool flag = base.EventAvailable();
			this.Button.SetUiActive(flag);
			if (!flag)
			{
				return;
			}
			this.Button.SetButtonTextByTextId("RogueRes_Block_Move", Array.Empty<string>());
			this.Button.SetButtonFunction(new Action<int>(base.MoveButtonFunction));
		}

		// Token: 0x06038232 RID: 229938 RVA: 0x00D4C230 File Offset: 0x00D4A430
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
			else
			{
				if (!(configParams[0] == "goto"))
				{
					return null;
				}
				PopupComponentFunctionButton button = this.Button;
				if (button == null)
				{
					return null;
				}
				return button.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
		}

		// Token: 0x0401D882 RID: 120962
		protected PopupComponentRecommendTip RecommendTip;

		// Token: 0x0401D883 RID: 120963
		protected PopupComponentFunctionButton Button;

		// Token: 0x0401D884 RID: 120964
		protected PopupComponentEventCost EventCost;
	}
}
