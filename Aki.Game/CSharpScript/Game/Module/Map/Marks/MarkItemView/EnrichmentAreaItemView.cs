using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x02005509 RID: 21769
	[NullableContext(1)]
	[Nullable(0)]
	public class EnrichmentAreaItemView : ServerMarkItemView
	{
		// Token: 0x060379A8 RID: 227752 RVA: 0x00D336F6 File Offset: 0x00D318F6
		public EnrichmentAreaItemView(EnrichmentAreaItem holder) : base(holder)
		{
		}

		// Token: 0x060379A9 RID: 227753 RVA: 0x00D33700 File Offset: 0x00D31900
		protected override void OnViewRefresh()
		{
			this.Holder.MarkItemEntity.ViewLifeCircle.EnableVerticalPointer = false;
			bool visible = this.Holder.CheckCanShowView();
			base.MarkItemRangeHandle.SetVisible(visible);
			this.UpdateMultiMapFloorSelectedState();
			this.OnIconPathChanged(this.Holder.IconPath);
		}

		// Token: 0x060379AA RID: 227754 RVA: 0x00D33752 File Offset: 0x00D31952
		public override void RegisterEvents()
		{
			EventSystem.Instance.Add<int>(EEventName.WorldMapSelectMultiMap, new Action<int>(this.OnSubMapChanged));
			EventSystem.Instance.Add<EMarkType, int, bool>(EEventName.TrackMapMark, new Action<EMarkType, int, bool>(this.OnTrackMapMark));
		}

		// Token: 0x060379AB RID: 227755 RVA: 0x00D3378C File Offset: 0x00D3198C
		public override void UnRegisterEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldMapSelectMultiMap, new Action<int>(this.OnSubMapChanged));
			EventSystem.Instance.Remove(EEventName.TrackMapMark, new Action<EMarkType, int, bool>(this.OnTrackMapMark));
		}

		// Token: 0x060379AC RID: 227756 RVA: 0x00D337C8 File Offset: 0x00D319C8
		private void OnSubMapChanged(int subMapId)
		{
			EnrichmentAreaItem enrichmentAreaItem = (EnrichmentAreaItem)this.Holder;
			enrichmentAreaItem.IsSelectThisFloor = (enrichmentAreaItem.GetMultiMapId() == subMapId);
			this.OnIconPathChanged(enrichmentAreaItem.IconPath);
		}

		// Token: 0x060379AD RID: 227757 RVA: 0x00D337FC File Offset: 0x00D319FC
		private void OnTrackMapMark(EMarkType eMarkType, int i, bool arg3)
		{
			EnrichmentAreaItem enrichmentAreaItem = (EnrichmentAreaItem)this.Holder;
			this.OnIconPathChanged(enrichmentAreaItem.IconPath);
		}

		// Token: 0x060379AE RID: 227758 RVA: 0x00D33824 File Offset: 0x00D31A24
		public override void OnIconPathChanged(string iconPath)
		{
			bool flag = ((EnrichmentAreaItem)this.Holder).CheckCanShowIcon();
			UUISprite sprite = base.GetSprite(1);
			if (flag)
			{
				base.LoadIcon(sprite, iconPath);
			}
			else
			{
				sprite.SetUIActive(flag);
			}
			base.MarkItemChildIconHandle.Update();
		}

		// Token: 0x060379AF RID: 227759 RVA: 0x00D3386C File Offset: 0x00D31A6C
		public void UpdateMultiMapFloorSelectedState()
		{
			EnrichmentAreaItem enrichmentAreaItem = (EnrichmentAreaItem)this.Holder;
			bool isSelectThisFloor = this.Holder.IsSelectThisFloor;
			this.Holder.IsSelectThisFloor = enrichmentAreaItem.GetIsSelectThisFloor();
			if (isSelectThisFloor != this.Holder.IsSelectThisFloor)
			{
				this.OnIconPathChanged(enrichmentAreaItem.IconPath);
			}
		}

		// Token: 0x060379B0 RID: 227760 RVA: 0x00D338BA File Offset: 0x00D31ABA
		protected override IMarkItemHandle CreateRangeHandle<[Nullable(0)] T>(IMarkItemComponentContext markComponentContext)
		{
			return new EnrichmentAreaItemRangeHandle(markComponentContext);
		}
	}
}
