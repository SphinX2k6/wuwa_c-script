using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x02005502 RID: 21762
	public class AreaMarkItemView : ConfigMarkItemView
	{
		// Token: 0x06037989 RID: 227721 RVA: 0x00D3301F File Offset: 0x00D3121F
		[NullableContext(1)]
		public AreaMarkItemView(AreaMarkItem holder) : base(holder)
		{
		}

		// Token: 0x0603798A RID: 227722 RVA: 0x00D33028 File Offset: 0x00D31228
		protected override void OnViewRefresh()
		{
			this.SetNameText();
		}

		// Token: 0x0603798B RID: 227723 RVA: 0x00D33030 File Offset: 0x00D31230
		public void SetNameText()
		{
			Aki.Config.Area? config = ConfigAreaByDeliveryMarkId.GetConfig(this.Holder.MarkId, true);
			if (config == null)
			{
				base.MarkItemNameHandle.SetVisible(false);
				return;
			}
			ExploreAreaData exploreAreaData = ExploreProgressModel.Instance.GetExploreAreaData(config.Value.AreaId);
			string markTitle = ((AreaMarkItem)this.Holder).MarkConfig.Value.MarkTitle;
			int value = 36;
			string text = "";
			string id = "SmallAreaName";
			IReadOnlyList<int> source = ConfigCommonParamById.GetIntArrayConfig("MapAreaMarkDisableExploreDungeonList") ?? Array.Empty<int>();
			if (config.Value.Level == 2 && !config.Value.IsDisableInExplore && !source.Contains(CreatureModel.Instance.GetInstanceId()) && WorldMapModel.Instance.AreaMarkProgressVisible)
			{
				string text2 = ((exploreAreaData != null) ? exploreAreaData.GetProgress().ToString() : null) ?? "0";
				if (exploreAreaData != null && exploreAreaData.IsReachMaxProgress)
				{
					text = "<color=#ffd12f>" + text2 + "%</color>";
				}
				else
				{
					text = text2 + "%";
				}
				value = 48;
				id = "BigAreaName";
			}
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(id, null);
			string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(markTitle, null);
			base.MarkItemNameHandle.SetName(new MarkItemParam
			{
				Txt = StringUtils.Format(localTextNew, new string[]
				{
					localTextNew2,
					text
				}),
				FontSize = new int?(value)
			});
			base.MarkItemNameHandle.SetVisible(true);
		}

		// Token: 0x0603798C RID: 227724 RVA: 0x00D331BC File Offset: 0x00D313BC
		public override bool GetInteractiveFlag()
		{
			return false;
		}

		// Token: 0x0401D406 RID: 119814
		private const int LEVEL_TWO_SIZE = 48;

		// Token: 0x0401D407 RID: 119815
		private const int LEVEL_TREE_SIZE = 36;
	}
}
