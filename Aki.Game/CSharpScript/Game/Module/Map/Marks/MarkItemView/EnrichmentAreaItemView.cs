using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044DC RID: 17628
	[NullableContext(1)]
	[Nullable(0)]
	public class EnrichmentAreaItemView : ServerMarkItemView
	{
		// Token: 0x0602C876 RID: 182390 RVA: 0x00C815E2 File Offset: 0x00C7F7E2
		public EnrichmentAreaItemView(EnrichmentAreaItem holder) : base(holder)
		{
		}

		// Token: 0x0602C877 RID: 182391 RVA: 0x00C815EC File Offset: 0x00C7F7EC
		protected override void OnViewRefresh()
		{
			bool visible = this.Holder.CheckCanShowView();
			base.MarkItemRangeHandle.SetVisible(visible);
			this.UpdateMultiMapFloorSelectedState();
			this.OnIconPathChanged(this.Holder.IconPath);
		}

		// Token: 0x0602C878 RID: 182392 RVA: 0x00C81628 File Offset: 0x00C7F828
		public override void RegisterEvents()
		{
			EventSystem.Instance.Add<int>(EEventName.WorldMapSelectMultiMap, new Action<int>(this.OnSubMapChanged));
			EventSystem.Instance.Add<EMarkType, int, bool>(EEventName.TrackMapMark, new Action<EMarkType, int, bool>(this.OnTrackMapMark));
		}

		// Token: 0x0602C879 RID: 182393 RVA: 0x00C81662 File Offset: 0x00C7F862
		public override void UnRegisterEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldMapSelectMultiMap, new Action<int>(this.OnSubMapChanged));
			EventSystem.Instance.Remove(EEventName.TrackMapMark, new Action<EMarkType, int, bool>(this.OnTrackMapMark));
		}

		// Token: 0x0602C87A RID: 182394 RVA: 0x00C8169C File Offset: 0x00C7F89C
		private void OnSubMapChanged(int subMapId)
		{
			EnrichmentAreaItem enrichmentAreaItem = (EnrichmentAreaItem)this.Holder;
			enrichmentAreaItem.IsSelectThisFloor = (enrichmentAreaItem.GetMultiMapId() == subMapId);
			this.OnIconPathChanged(enrichmentAreaItem.IconPath);
		}

		// Token: 0x0602C87B RID: 182395 RVA: 0x00C816D0 File Offset: 0x00C7F8D0
		private void OnTrackMapMark(EMarkType eMarkType, int i, bool arg3)
		{
			EnrichmentAreaItem enrichmentAreaItem = (EnrichmentAreaItem)this.Holder;
			this.OnIconPathChanged(enrichmentAreaItem.IconPath);
		}

		// Token: 0x0602C87C RID: 182396 RVA: 0x00C816F8 File Offset: 0x00C7F8F8
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

		// Token: 0x0602C87D RID: 182397 RVA: 0x00C81740 File Offset: 0x00C7F940
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

		// Token: 0x0602C87E RID: 182398 RVA: 0x00C8178E File Offset: 0x00C7F98E
		protected override IMarkItemHandle CreateRangeHandle<[Nullable(0)] T>(IMarkItemComponentContext markComponentContext)
		{
			return new EnrichmentAreaItemRangeHandle(markComponentContext);
		}
	}
}
