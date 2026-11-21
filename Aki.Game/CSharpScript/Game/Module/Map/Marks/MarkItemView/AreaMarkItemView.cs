using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044D5 RID: 17621
	public class AreaMarkItemView : ConfigMarkItemView
	{
		// Token: 0x0602C858 RID: 182360 RVA: 0x00C80FB1 File Offset: 0x00C7F1B1
		[NullableContext(1)]
		public AreaMarkItemView(AreaMarkItem holder) : base(holder)
		{
		}

		// Token: 0x0602C859 RID: 182361 RVA: 0x00C80FBA File Offset: 0x00C7F1BA
		protected override void OnViewRefresh()
		{
			this.SetNameText();
		}

		// Token: 0x0602C85A RID: 182362 RVA: 0x00C80FC4 File Offset: 0x00C7F1C4
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
			IReadOnlyList<int> readOnlyList = ConfigCommonParamById.GetIntArrayConfig("MapAreaMarkDisableExploreDungeonList") ?? Array.Empty<int>();
			int[] array = new int[readOnlyList.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = readOnlyList[i];
			}
			if (config.Value.Level == 2 && !config.Value.IsDisableInExplore && Array.IndexOf<int>(array, CreatureModel.Instance.GetInstanceId()) < 0 && WorldMapModel.Instance.AreaMarkProgressVisible)
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

		// Token: 0x0602C85B RID: 182363 RVA: 0x00C8118A File Offset: 0x00C7F38A
		public override bool GetInteractiveFlag()
		{
			return false;
		}

		// Token: 0x04017E8A RID: 97930
		private const int LEVEL_TWO_SIZE = 48;

		// Token: 0x04017E8B RID: 97931
		private const int LEVEL_TREE_SIZE = 36;
	}
}
