using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044B6 RID: 17590
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingPointMarkItem : ServerMarkItem
	{
		// Token: 0x0602C67E RID: 181886 RVA: 0x00C7BBEC File Offset: 0x00C79DEC
		public FishingPointMarkItem(FishingPointMarkCreateInfo markPointInfo, UUIItem parent, EMapType mapType, float markScale) : base(markPointInfo, parent, mapType, markScale)
		{
		}

		// Token: 0x170058C8 RID: 22728
		// (get) Token: 0x0602C67F RID: 181887 RVA: 0x00C7BBF9 File Offset: 0x00C79DF9
		// (set) Token: 0x0602C680 RID: 181888 RVA: 0x00C7BC01 File Offset: 0x00C79E01
		public MapMark MarkConfig { get; set; }

		// Token: 0x170058C9 RID: 22729
		// (get) Token: 0x0602C681 RID: 181889 RVA: 0x00C7BC0A File Offset: 0x00C79E0A
		public override int MapId
		{
			get
			{
				return this.ServerMarkInfo.MapId;
			}
		}

		// Token: 0x170058CA RID: 22730
		// (get) Token: 0x0602C682 RID: 181890 RVA: 0x00C7BC17 File Offset: 0x00C79E17
		public override int? InstanceDungeonId
		{
			get
			{
				return this.ServerMarkInfo.InstanceDungeonId;
			}
		}

		// Token: 0x0602C683 RID: 181891 RVA: 0x00C7BC24 File Offset: 0x00C79E24
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.FishingPointMarkItemView;
		}

		// Token: 0x0602C684 RID: 181892 RVA: 0x00C7BC28 File Offset: 0x00C79E28
		protected override MarkItemView CreateView()
		{
			return new FishingPointMarkItemView(this);
		}

		// Token: 0x0602C685 RID: 181893 RVA: 0x00C7BC30 File Offset: 0x00C79E30
		public override string GetTitleText()
		{
			int entityConfigId = base.EntityConfigId;
			string fishingPointNameLocalKey = FishingModel.Instance.GetFishingPointNameLocalKey(entityConfigId);
			string multiText = TextConfig.Instance.GetMultiText(fishingPointNameLocalKey, Array.Empty<string>());
			return TextConfig.Instance.GetMultiText(this.MarkConfig.MarkTitle, new string[]
			{
				multiText
			});
		}

		// Token: 0x0602C686 RID: 181894 RVA: 0x00C7BC84 File Offset: 0x00C79E84
		protected override void OnInitialize()
		{
			base.OnInitialize();
			FishingPointMarkCreateInfo fishingPointMarkCreateInfo = this.ServerMarkInfo as FishingPointMarkCreateInfo;
			base.SetTrackData(fishingPointMarkCreateInfo.TrackTarget);
			int valueOrDefault = ConfigCommonParamById.GetIntConfig("FishingWherfRange").GetValueOrDefault(1);
			this.RangeSize = (float)valueOrDefault;
			this.SetConfigId(fishingPointMarkCreateInfo.MarkConfigId);
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x0602C687 RID: 181895 RVA: 0x00C7BCDD File Offset: 0x00C79EDD
		public void SetConfigId(int configId)
		{
			this.OnSetConfigId(configId);
		}

		// Token: 0x0602C688 RID: 181896 RVA: 0x00C7BCE8 File Offset: 0x00C79EE8
		public void OnSetConfigId(int configId)
		{
			MapMark value = MapConfig.Instance.GetConfigMark(configId).Value;
			this.MarkConfig = value;
			this.Config = new MapMarkConfig(value);
			int[] array = new int[value.ShowRangeLength];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = value.ShowRange(i);
			}
			this.OnAfterSetConfigId(new MarkItemData
			{
				ShowRange = array,
				MarkPic = value.UnlockMarkPic,
				ShowPriority = new int?(value.ShowPriority),
				Scale = new float?(value.Scale),
				CornerScale = new float?(value.CornerScale)
			});
			this.UpdateIconPath();
		}

		// Token: 0x0602C689 RID: 181897 RVA: 0x00C7BDA0 File Offset: 0x00C79FA0
		public void UpdateIconPath()
		{
			if ((this.ServerMarkInfo as FishingPointMarkCreateInfo).FishPointDetectSourceType == EFishPointDetectSourceType.Entrust)
			{
				this.IconPath = MapConfig.Instance.GetTaskMarkConfig(20).Value.MarkPic;
				return;
			}
			int showItem = FishingConfig.Instance.GetFishingPointConfigByEntityId(base.EntityConfigId).Value.ShowItem;
			EFishItemType type = (EFishItemType)FishingConfig.Instance.GetFishingItemConfig(showItem).Value.Type;
			if (type == EFishItemType.Fish)
			{
				this.IconPath = UiResourceConfig.Instance.GetResourcePath("T_IconMap_Activity_Navigation_4_UI");
				return;
			}
			if (type != EFishItemType.Material)
			{
				this.IconPath = this.MarkConfig.UnlockMarkPic;
				return;
			}
			this.IconPath = UiResourceConfig.Instance.GetResourcePath("T_IconMap_Activity_Navigation_6_UI");
		}
	}
}
