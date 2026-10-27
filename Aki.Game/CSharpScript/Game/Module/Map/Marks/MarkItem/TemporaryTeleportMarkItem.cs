using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054FC RID: 21756
	[NullableContext(1)]
	[Nullable(0)]
	public class TemporaryTeleportMarkItem : ServerMarkItem
	{
		// Token: 0x17008591 RID: 34193
		// (get) Token: 0x0603794C RID: 227660 RVA: 0x00D327C4 File Offset: 0x00D309C4
		public int TeleportId
		{
			get
			{
				DynamicMarkCreateInfo serverMarkInfo = this.ServerMarkInfo;
				return ((serverMarkInfo != null) ? serverMarkInfo.TeleportId : null).GetValueOrDefault();
			}
		}

		// Token: 0x17008592 RID: 34194
		// (get) Token: 0x0603794D RID: 227661 RVA: 0x00D327F3 File Offset: 0x00D309F3
		public override EMarkType MarkType
		{
			get
			{
				return EMarkType.TemporaryTeleport;
			}
		}

		// Token: 0x17008593 RID: 34195
		// (get) Token: 0x0603794E RID: 227662 RVA: 0x00D327F7 File Offset: 0x00D309F7
		public bool IsNewCustomMarkItem
		{
			get
			{
				return this.IsNew;
			}
		}

		// Token: 0x0603794F RID: 227663 RVA: 0x00D327FF File Offset: 0x00D309FF
		protected override void OnUpdate(global::Vector playerLocation)
		{
			base.OnUpdate(playerLocation);
			if (base.MapType == EMapType.MiniMap)
			{
				this.UpdateMultiMapFloorSelectedState();
			}
		}

		// Token: 0x06037950 RID: 227664 RVA: 0x00D32818 File Offset: 0x00D30A18
		private void UpdateViewIcon()
		{
			if (base.View != null && !base.IsDestroy)
			{
				TemporaryTeleportMarkItemView temporaryTeleportMarkItemView = base.View as TemporaryTeleportMarkItemView;
				if (temporaryTeleportMarkItemView != null)
				{
					temporaryTeleportMarkItemView.UpdateIcon();
				}
			}
		}

		// Token: 0x06037951 RID: 227665 RVA: 0x00D3284A File Offset: 0x00D30A4A
		public void UpdateMultiMapFloorSelectedState()
		{
			bool isSelectThisFloor = base.IsSelectThisFloor;
			base.IsSelectThisFloor = this.GetIsSelectThisFloor();
			if (isSelectThisFloor != base.IsSelectThisFloor)
			{
				this.UpdateViewIcon();
			}
		}

		// Token: 0x06037952 RID: 227666 RVA: 0x00D3286C File Offset: 0x00D30A6C
		public override bool ShowSecondaryUiMultiMapIcon()
		{
			return this.IsMultiMap();
		}

		// Token: 0x06037953 RID: 227667 RVA: 0x00D32874 File Offset: 0x00D30A74
		public override int GetMultiMapId()
		{
			int? trackAreaId = this.TrackAreaId;
			int num = 0;
			if (trackAreaId.GetValueOrDefault() == num & trackAreaId != null)
			{
				return 0;
			}
			return base.GetMultiMapIdSub();
		}

		// Token: 0x17008594 RID: 34196
		// (get) Token: 0x06037954 RID: 227668 RVA: 0x00D328A8 File Offset: 0x00D30AA8
		public override int? TrackAreaId
		{
			get
			{
				DynamicMarkCreateInfo serverMarkInfo = this.ServerMarkInfo;
				return new int?(((serverMarkInfo != null) ? serverMarkInfo.AreaId : null).GetValueOrDefault());
			}
		}

		// Token: 0x06037955 RID: 227669 RVA: 0x00D328DC File Offset: 0x00D30ADC
		public TemporaryTeleportMarkItem(DynamicMarkCreateInfo markPointInfo, UUIItem parent, EMapType mapType, float markScale) : base(markPointInfo, parent, mapType, markScale)
		{
		}

		// Token: 0x06037956 RID: 227670 RVA: 0x00D328EC File Offset: 0x00D30AEC
		protected override void OnInitialize()
		{
			base.OnInitialize();
			DynamicMarkCreateInfo serverMarkInfo = this.ServerMarkInfo;
			base.SetTrackData(serverMarkInfo.TrackTarget);
			this.SetConfigId(base.ConfigId);
			this.UpdateVisibleRelativeState();
			this.UpdateMultiMapFloorSelectedState();
		}

		// Token: 0x06037957 RID: 227671 RVA: 0x00D3292A File Offset: 0x00D30B2A
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.TemporaryTeleportMarkItemView;
		}

		// Token: 0x06037958 RID: 227672 RVA: 0x00D3292E File Offset: 0x00D30B2E
		[PreserveBaseOverrides]
		protected new virtual TemporaryTeleportMarkItemView CreateView()
		{
			return new TemporaryTeleportMarkItemView(this);
		}

		// Token: 0x06037959 RID: 227673 RVA: 0x00D32936 File Offset: 0x00D30B36
		public void SetConfigId(int configId)
		{
			this.ServerMarkInfo.MarkConfigId = configId;
			this.OnSetConfigId(configId);
		}

		// Token: 0x0603795A RID: 227674 RVA: 0x00D3294C File Offset: 0x00D30B4C
		public void OnSetConfigId(int configId)
		{
			TemporaryTeleportMark? temporaryTeleportMarkConfigById = MapConfig.Instance.GetTemporaryTeleportMarkConfigById(configId);
			this.OnAfterSetConfigId(new MarkItemData
			{
				MarkPic = temporaryTeleportMarkConfigById.Value.MarkPic,
				Scale = new float?(temporaryTeleportMarkConfigById.Value.Scale),
				ShowPriority = new int?(temporaryTeleportMarkConfigById.Value.ShowPriority),
				ShowRange = temporaryTeleportMarkConfigById.Value.ShowRange()
			});
		}

		// Token: 0x0603795B RID: 227675 RVA: 0x00D329CE File Offset: 0x00D30BCE
		public void SetIsNew(bool isNew)
		{
			this.IsNew = isNew;
		}

		// Token: 0x0603795C RID: 227676 RVA: 0x00D329D8 File Offset: 0x00D30BD8
		[NullableContext(2)]
		public override string GetTitleText()
		{
			return ConfigMultiTextLang.GetLocalTextNew(MapConfig.Instance.GetTemporaryTeleportMarkConfigById(base.ConfigId).Value.MarkTitle, null);
		}

		// Token: 0x0603795D RID: 227677 RVA: 0x00D32A0C File Offset: 0x00D30C0C
		[NullableContext(2)]
		public string GetDescText()
		{
			return ConfigMultiTextLang.GetLocalTextNew(MapConfig.Instance.GetTemporaryTeleportMarkConfigById(base.ConfigId).Value.MarkDesc, null);
		}

		// Token: 0x0401D3FE RID: 119806
		private bool IsNew;
	}
}
