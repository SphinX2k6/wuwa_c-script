using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044CF RID: 17615
	[NullableContext(1)]
	[Nullable(0)]
	public class TemporaryTeleportMarkItem : ServerMarkItem
	{
		// Token: 0x1700592C RID: 22828
		// (get) Token: 0x0602C81B RID: 182299 RVA: 0x00C807A0 File Offset: 0x00C7E9A0
		public int TeleportId
		{
			get
			{
				DynamicMarkCreateInfo serverMarkInfo = this.ServerMarkInfo;
				return ((serverMarkInfo != null) ? serverMarkInfo.TeleportId : null).GetValueOrDefault();
			}
		}

		// Token: 0x1700592D RID: 22829
		// (get) Token: 0x0602C81C RID: 182300 RVA: 0x00C807CF File Offset: 0x00C7E9CF
		public override EMarkType MarkType
		{
			get
			{
				return EMarkType.TemporaryTeleport;
			}
		}

		// Token: 0x1700592E RID: 22830
		// (get) Token: 0x0602C81D RID: 182301 RVA: 0x00C807D3 File Offset: 0x00C7E9D3
		public bool IsNewCustomMarkItem
		{
			get
			{
				return this.IsNew;
			}
		}

		// Token: 0x0602C81E RID: 182302 RVA: 0x00C807DB File Offset: 0x00C7E9DB
		protected override void OnUpdate(global::Vector playerLocation)
		{
			base.OnUpdate(playerLocation);
			if (base.MapType == EMapType.MiniMap)
			{
				this.UpdateMultiMapFloorSelectedState();
			}
		}

		// Token: 0x0602C81F RID: 182303 RVA: 0x00C807F4 File Offset: 0x00C7E9F4
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

		// Token: 0x0602C820 RID: 182304 RVA: 0x00C80826 File Offset: 0x00C7EA26
		public void UpdateMultiMapFloorSelectedState()
		{
			bool isSelectThisFloor = base.IsSelectThisFloor;
			base.IsSelectThisFloor = this.GetIsSelectThisFloor();
			if (isSelectThisFloor != base.IsSelectThisFloor)
			{
				this.UpdateViewIcon();
			}
		}

		// Token: 0x0602C821 RID: 182305 RVA: 0x00C80848 File Offset: 0x00C7EA48
		public override bool ShowSecondaryUiMultiMapIcon()
		{
			return this.IsMultiMap();
		}

		// Token: 0x0602C822 RID: 182306 RVA: 0x00C80850 File Offset: 0x00C7EA50
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

		// Token: 0x1700592F RID: 22831
		// (get) Token: 0x0602C823 RID: 182307 RVA: 0x00C80884 File Offset: 0x00C7EA84
		public override int? TrackAreaId
		{
			get
			{
				DynamicMarkCreateInfo serverMarkInfo = this.ServerMarkInfo;
				return new int?(((serverMarkInfo != null) ? serverMarkInfo.AreaId : null).GetValueOrDefault());
			}
		}

		// Token: 0x0602C824 RID: 182308 RVA: 0x00C808B8 File Offset: 0x00C7EAB8
		public TemporaryTeleportMarkItem(DynamicMarkCreateInfo markPointInfo, UUIItem parent, EMapType mapType, float markScale) : base(markPointInfo, parent, mapType, markScale)
		{
		}

		// Token: 0x0602C825 RID: 182309 RVA: 0x00C808C8 File Offset: 0x00C7EAC8
		protected override void OnInitialize()
		{
			base.OnInitialize();
			DynamicMarkCreateInfo serverMarkInfo = this.ServerMarkInfo;
			base.SetTrackData(serverMarkInfo.TrackTarget);
			this.SetConfigId(base.ConfigId);
			this.UpdateVisibleRelativeState();
			this.UpdateMultiMapFloorSelectedState();
		}

		// Token: 0x0602C826 RID: 182310 RVA: 0x00C80906 File Offset: 0x00C7EB06
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.TemporaryTeleportMarkItemView;
		}

		// Token: 0x0602C827 RID: 182311 RVA: 0x00C8090A File Offset: 0x00C7EB0A
		[PreserveBaseOverrides]
		protected new virtual TemporaryTeleportMarkItemView CreateView()
		{
			return new TemporaryTeleportMarkItemView(this);
		}

		// Token: 0x0602C828 RID: 182312 RVA: 0x00C80912 File Offset: 0x00C7EB12
		public void SetConfigId(int configId)
		{
			this.ServerMarkInfo.MarkConfigId = configId;
			this.OnSetConfigId(configId);
		}

		// Token: 0x0602C829 RID: 182313 RVA: 0x00C80928 File Offset: 0x00C7EB28
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

		// Token: 0x0602C82A RID: 182314 RVA: 0x00C809AA File Offset: 0x00C7EBAA
		public void SetIsNew(bool isNew)
		{
			this.IsNew = isNew;
		}

		// Token: 0x0602C82B RID: 182315 RVA: 0x00C809B4 File Offset: 0x00C7EBB4
		[NullableContext(2)]
		public override string GetTitleText()
		{
			return ConfigMultiTextLang.GetLocalTextNew(MapConfig.Instance.GetTemporaryTeleportMarkConfigById(base.ConfigId).Value.MarkTitle, null);
		}

		// Token: 0x0602C82C RID: 182316 RVA: 0x00C809E8 File Offset: 0x00C7EBE8
		[NullableContext(2)]
		public string GetDescText()
		{
			return ConfigMultiTextLang.GetLocalTextNew(MapConfig.Instance.GetTemporaryTeleportMarkConfigById(base.ConfigId).Value.MarkDesc, null);
		}

		// Token: 0x04017E84 RID: 97924
		private bool IsNew;
	}
}
