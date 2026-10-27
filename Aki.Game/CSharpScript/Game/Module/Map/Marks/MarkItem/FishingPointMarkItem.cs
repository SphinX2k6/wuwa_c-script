using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Mark.Component;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054E3 RID: 21731
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingPointMarkItem : ServerMarkItem
	{
		// Token: 0x1700853A RID: 34106
		// (get) Token: 0x060377C2 RID: 227266 RVA: 0x00D2DB05 File Offset: 0x00D2BD05
		// (set) Token: 0x060377C3 RID: 227267 RVA: 0x00D2DB0D File Offset: 0x00D2BD0D
		public MapMark MarkConfig
		{
			get
			{
				return this.MarkConfigInternal;
			}
			set
			{
				this.MarkConfigInternal = value;
			}
		}

		// Token: 0x1700853B RID: 34107
		// (get) Token: 0x060377C4 RID: 227268 RVA: 0x00D2DB16 File Offset: 0x00D2BD16
		public override int MapId
		{
			get
			{
				return this.ServerMarkInfo.MapId;
			}
		}

		// Token: 0x1700853C RID: 34108
		// (get) Token: 0x060377C5 RID: 227269 RVA: 0x00D2DB23 File Offset: 0x00D2BD23
		public override int? InstanceDungeonId
		{
			get
			{
				return this.ServerMarkInfo.InstanceDungeonId;
			}
		}

		// Token: 0x060377C6 RID: 227270 RVA: 0x00D2DB30 File Offset: 0x00D2BD30
		public FishingPointMarkItem(FishingPointMarkCreateInfo markPointInfo, UUIItem parent, EMapType mapType, float markScale) : base(markPointInfo, parent, mapType, markScale)
		{
		}

		// Token: 0x060377C7 RID: 227271 RVA: 0x00D2DB3D File Offset: 0x00D2BD3D
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.FishingPointMarkItemView;
		}

		// Token: 0x060377C8 RID: 227272 RVA: 0x00D2DB41 File Offset: 0x00D2BD41
		protected override MarkItemView CreateView()
		{
			return new FishingPointMarkItemView(this);
		}

		// Token: 0x060377C9 RID: 227273 RVA: 0x00D2DB4C File Offset: 0x00D2BD4C
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

		// Token: 0x060377CA RID: 227274 RVA: 0x00D2DBA0 File Offset: 0x00D2BDA0
		protected override void OnInitialize()
		{
			base.OnInitialize();
			FishingPointMarkCreateInfo fishingPointMarkCreateInfo = this.ServerMarkInfo as FishingPointMarkCreateInfo;
			base.SetTrackData(fishingPointMarkCreateInfo.TrackTarget);
			MarkFishingPointComponent component = base.MarkItemEntity.GetComponent<MarkFishingPointComponent>(EMapComponent.MarkFishingPoint);
			component.FishingPointEntityId = (fishingPointMarkCreateInfo.TrackTarget as TTrackTarget_Int);
			component.Update();
			this.SetConfigId(fishingPointMarkCreateInfo.MarkConfigId);
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x060377CB RID: 227275 RVA: 0x00D2DC05 File Offset: 0x00D2BE05
		public void SetConfigId(int configId)
		{
			this.OnSetConfigId(configId);
		}

		// Token: 0x060377CC RID: 227276 RVA: 0x00D2DC10 File Offset: 0x00D2BE10
		public void OnSetConfigId(int configId)
		{
			MapMark value = MapConfig.Instance.GetConfigMark(configId).Value;
			this.MarkConfigInternal = value;
			base.MarkItemEntity.GetComponent<MarkConfigComponent>(EMapComponent.MarkConfig).Config = value;
			this.OnAfterSetConfigId(new MarkItemData
			{
				ShowRange = value.ShowRange(),
				MarkPic = value.UnlockMarkPic,
				ShowPriority = new int?(value.ShowPriority),
				Scale = new float?(value.Scale),
				CornerScale = new float?(value.CornerScale)
			});
			this.UpdateIconPath();
		}

		// Token: 0x060377CD RID: 227277 RVA: 0x00D2DCB4 File Offset: 0x00D2BEB4
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

		// Token: 0x0401D39E RID: 119710
		private MapMark MarkConfigInternal;
	}
}
