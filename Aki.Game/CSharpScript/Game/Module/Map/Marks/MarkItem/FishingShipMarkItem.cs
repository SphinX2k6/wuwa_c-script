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
	// Token: 0x020044B7 RID: 17591
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingShipMarkItem : ServerMarkItem
	{
		// Token: 0x170058CB RID: 22731
		// (get) Token: 0x0602C68A RID: 181898 RVA: 0x00C7BE70 File Offset: 0x00C7A070
		// (set) Token: 0x0602C68B RID: 181899 RVA: 0x00C7BE7D File Offset: 0x00C7A07D
		public MapMark MarkConfig
		{
			get
			{
				return this.MarkConfigInternal.Value;
			}
			set
			{
				this.MarkConfigInternal = new MapMark?(value);
			}
		}

		// Token: 0x170058CC RID: 22732
		// (get) Token: 0x0602C68C RID: 181900 RVA: 0x00C7BE8B File Offset: 0x00C7A08B
		public override int MapId
		{
			get
			{
				return this.ServerMarkInfo.MapId;
			}
		}

		// Token: 0x170058CD RID: 22733
		// (get) Token: 0x0602C68D RID: 181901 RVA: 0x00C7BE98 File Offset: 0x00C7A098
		public override int? InstanceDungeonId
		{
			get
			{
				return this.ServerMarkInfo.InstanceDungeonId;
			}
		}

		// Token: 0x170058CE RID: 22734
		// (get) Token: 0x0602C68E RID: 181902 RVA: 0x00C7BEA5 File Offset: 0x00C7A0A5
		public override int? TrackAreaId
		{
			get
			{
				return new int?(0);
			}
		}

		// Token: 0x0602C68F RID: 181903 RVA: 0x00C7BEAD File Offset: 0x00C7A0AD
		public override int GetMultiMapId()
		{
			return 0;
		}

		// Token: 0x0602C690 RID: 181904 RVA: 0x00C7BEB0 File Offset: 0x00C7A0B0
		public FishingShipMarkItem(FishingShipMarkCreateInfo markPointInfo, UUIItem parent, EMapType mapType, float markScale) : base(markPointInfo, parent, mapType, markScale)
		{
		}

		// Token: 0x0602C691 RID: 181905 RVA: 0x00C7BEC0 File Offset: 0x00C7A0C0
		public override string GetTitleText()
		{
			return TextConfig.Instance.GetMultiText(this.MarkConfig.MarkTitle, Array.Empty<string>());
		}

		// Token: 0x0602C692 RID: 181906 RVA: 0x00C7BEEA File Offset: 0x00C7A0EA
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.FishingShipMarkItemView;
		}

		// Token: 0x0602C693 RID: 181907 RVA: 0x00C7BEEE File Offset: 0x00C7A0EE
		[PreserveBaseOverrides]
		protected new virtual FishingShipMarkItemView CreateView()
		{
			return new FishingShipMarkItemView(this);
		}

		// Token: 0x0602C694 RID: 181908 RVA: 0x00C7BEF8 File Offset: 0x00C7A0F8
		protected override void OnInitialize()
		{
			base.OnInitialize();
			this.EnableCachePosition = false;
			FishingShipMarkCreateInfo fishingShipMarkCreateInfo = this.ServerMarkInfo as FishingShipMarkCreateInfo;
			base.SetTrackData(fishingShipMarkCreateInfo.TrackTarget);
			this.SetConfigId(fishingShipMarkCreateInfo.MarkConfigId);
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x0602C695 RID: 181909 RVA: 0x00C7BF3C File Offset: 0x00C7A13C
		public void SetConfigId(int configId)
		{
			this.OnSetConfigId(configId);
		}

		// Token: 0x0602C696 RID: 181910 RVA: 0x00C7BF48 File Offset: 0x00C7A148
		public void OnSetConfigId(int configId)
		{
			MapMark value = MapConfig.Instance.GetConfigMark(configId).Value;
			this.MarkConfigInternal = new MapMark?(value);
			this.Config = new MapMarkConfig(value);
			this.OnAfterSetConfigId(new MarkItemData
			{
				ShowRange = value.ShowRange(),
				MarkPic = value.UnlockMarkPic,
				ShowPriority = new int?(value.ShowPriority),
				Scale = new float?(value.Scale),
				CornerScale = new float?(value.CornerScale)
			});
		}

		// Token: 0x0602C697 RID: 181911 RVA: 0x00C7BFDC File Offset: 0x00C7A1DC
		public override bool CheckCanShowView()
		{
			bool flag = FishingModel.Instance.IsOnShipVehicle();
			return base.CheckCanShowView() && !flag;
		}

		// Token: 0x04017E1B RID: 97819
		private MapMark? MarkConfigInternal;
	}
}
