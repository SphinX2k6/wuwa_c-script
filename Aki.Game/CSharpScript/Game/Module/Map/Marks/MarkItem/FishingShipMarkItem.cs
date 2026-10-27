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
	// Token: 0x020054E4 RID: 21732
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingShipMarkItem : ServerMarkItem
	{
		// Token: 0x1700853D RID: 34109
		// (get) Token: 0x060377CE RID: 227278 RVA: 0x00D2DD84 File Offset: 0x00D2BF84
		// (set) Token: 0x060377CF RID: 227279 RVA: 0x00D2DD91 File Offset: 0x00D2BF91
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

		// Token: 0x1700853E RID: 34110
		// (get) Token: 0x060377D0 RID: 227280 RVA: 0x00D2DD9F File Offset: 0x00D2BF9F
		public override int MapId
		{
			get
			{
				return this.ServerMarkInfo.MapId;
			}
		}

		// Token: 0x1700853F RID: 34111
		// (get) Token: 0x060377D1 RID: 227281 RVA: 0x00D2DDAC File Offset: 0x00D2BFAC
		public override int? InstanceDungeonId
		{
			get
			{
				return this.ServerMarkInfo.InstanceDungeonId;
			}
		}

		// Token: 0x17008540 RID: 34112
		// (get) Token: 0x060377D2 RID: 227282 RVA: 0x00D2DDB9 File Offset: 0x00D2BFB9
		public override int? TrackAreaId
		{
			get
			{
				return new int?(0);
			}
		}

		// Token: 0x060377D3 RID: 227283 RVA: 0x00D2DDC1 File Offset: 0x00D2BFC1
		public override int GetMultiMapId()
		{
			return 0;
		}

		// Token: 0x060377D4 RID: 227284 RVA: 0x00D2DDC4 File Offset: 0x00D2BFC4
		public FishingShipMarkItem(FishingShipMarkCreateInfo markPointInfo, UUIItem parent, EMapType mapType, float markScale) : base(markPointInfo, parent, mapType, markScale)
		{
		}

		// Token: 0x060377D5 RID: 227285 RVA: 0x00D2DDD4 File Offset: 0x00D2BFD4
		public override string GetTitleText()
		{
			return TextConfig.Instance.GetMultiText(this.MarkConfig.MarkTitle, Array.Empty<string>());
		}

		// Token: 0x060377D6 RID: 227286 RVA: 0x00D2DDFE File Offset: 0x00D2BFFE
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.FishingShipMarkItemView;
		}

		// Token: 0x060377D7 RID: 227287 RVA: 0x00D2DE02 File Offset: 0x00D2C002
		[PreserveBaseOverrides]
		protected new virtual FishingShipMarkItemView CreateView()
		{
			return new FishingShipMarkItemView(this);
		}

		// Token: 0x060377D8 RID: 227288 RVA: 0x00D2DE0C File Offset: 0x00D2C00C
		protected override void OnInitialize()
		{
			base.OnInitialize();
			this.EnableCachePosition = false;
			FishingShipMarkCreateInfo fishingShipMarkCreateInfo = this.ServerMarkInfo as FishingShipMarkCreateInfo;
			base.SetTrackData(fishingShipMarkCreateInfo.TrackTarget);
			this.SetConfigId(fishingShipMarkCreateInfo.MarkConfigId);
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x060377D9 RID: 227289 RVA: 0x00D2DE50 File Offset: 0x00D2C050
		public void SetConfigId(int configId)
		{
			this.OnSetConfigId(configId);
		}

		// Token: 0x060377DA RID: 227290 RVA: 0x00D2DE5C File Offset: 0x00D2C05C
		public void OnSetConfigId(int configId)
		{
			MapMark value = MapConfig.Instance.GetConfigMark(configId).Value;
			this.MarkConfigInternal = new MapMark?(value);
			base.MarkItemEntity.GetComponent<MarkConfigComponent>(EMapComponent.MarkConfig).Config = value;
			this.OnAfterSetConfigId(new MarkItemData
			{
				ShowRange = value.ShowRange(),
				MarkPic = value.UnlockMarkPic,
				ShowPriority = new int?(value.ShowPriority),
				Scale = new float?(value.Scale),
				CornerScale = new float?(value.CornerScale)
			});
		}

		// Token: 0x060377DB RID: 227291 RVA: 0x00D2DEFC File Offset: 0x00D2C0FC
		public override bool CheckCanShowView()
		{
			bool flag = FishingModel.Instance.IsOnShipVehicle();
			return base.CheckCanShowView() && !flag;
		}

		// Token: 0x0401D39F RID: 119711
		private MapMark? MarkConfigInternal;
	}
}
