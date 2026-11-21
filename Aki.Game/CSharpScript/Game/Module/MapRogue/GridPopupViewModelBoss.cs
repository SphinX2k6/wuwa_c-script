using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004614 RID: 17940
	[NullableContext(1)]
	[Nullable(0)]
	public class GridPopupViewModelBoss : GridPopupViewModelBase
	{
		// Token: 0x17005AFE RID: 23294
		// (get) Token: 0x0602D12A RID: 184618 RVA: 0x00C99E22 File Offset: 0x00C98022
		public override bool HasBtnDetail
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0602D12B RID: 184619 RVA: 0x00C99E25 File Offset: 0x00C98025
		public GridPopupViewModelBoss(MapGridData gridData, MapRogueGameInfo gameInfo) : base(gridData, gameInfo)
		{
		}

		// Token: 0x0602D12C RID: 184620 RVA: 0x00C99E30 File Offset: 0x00C98030
		public override UniTask Init()
		{
			GridPopupViewModelBoss.<Init>d__6 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<GridPopupViewModelBoss.<Init>d__6>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602D12D RID: 184621 RVA: 0x00C99E73 File Offset: 0x00C98073
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

		// Token: 0x0602D12E RID: 184622 RVA: 0x00C99EAD File Offset: 0x00C980AD
		public override void RefreshTop()
		{
			this.EventCost.Refresh(this.GridData);
		}

		// Token: 0x0602D12F RID: 184623 RVA: 0x00C99EC0 File Offset: 0x00C980C0
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

		// Token: 0x0602D130 RID: 184624 RVA: 0x00C99F78 File Offset: 0x00C98178
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

		// Token: 0x0401830D RID: 99085
		protected PopupComponentRecommendTip RecommendTip;

		// Token: 0x0401830E RID: 99086
		protected PopupComponentFunctionButton Button;

		// Token: 0x0401830F RID: 99087
		protected PopupComponentEventCost EventCost;
	}
}
