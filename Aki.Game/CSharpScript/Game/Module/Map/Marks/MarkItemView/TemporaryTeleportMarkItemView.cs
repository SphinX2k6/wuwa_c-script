using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044F9 RID: 17657
	[NullableContext(1)]
	[Nullable(0)]
	public class TemporaryTeleportMarkItemView : ServerMarkItemView
	{
		// Token: 0x0602C95B RID: 182619 RVA: 0x00C841D6 File Offset: 0x00C823D6
		public TemporaryTeleportMarkItemView(TemporaryTeleportMarkItem holder) : base(holder)
		{
		}

		// Token: 0x0602C95C RID: 182620 RVA: 0x00C841DF File Offset: 0x00C823DF
		public override void RegisterEvents()
		{
			MarkItem holder = this.Holder;
			if (holder != null && holder.MapType == EMapType.WorldMap)
			{
				EventSystem.Instance.Add<int>(EEventName.WorldMapSubMapChangedFromUpdate, new Action<int>(this.OnSubMapChanged));
			}
		}

		// Token: 0x0602C95D RID: 182621 RVA: 0x00C84214 File Offset: 0x00C82414
		public override void UnRegisterEvents()
		{
			MarkItem holder = this.Holder;
			if (holder != null && holder.MapType == EMapType.WorldMap)
			{
				EventSystem.Instance.Remove<int>(EEventName.WorldMapSubMapChangedFromUpdate, new Action<int>(this.OnSubMapChanged));
			}
		}

		// Token: 0x0602C95E RID: 182622 RVA: 0x00C84249 File Offset: 0x00C82449
		protected override void OnViewRefresh()
		{
			this.OnIconPathChanged(this.Holder.IconPath);
			this.UpdateDisableState();
		}

		// Token: 0x0602C95F RID: 182623 RVA: 0x00C84262 File Offset: 0x00C82462
		protected override void OnSelectedStateChange(bool newState)
		{
			if (((TemporaryTeleportMarkItem)this.Holder).IsServerDisable)
			{
				ScrollingTipsController.Instance.ShowTipsById("Map_TeleportMark_Disable_Tips", Array.Empty<object>());
			}
		}

		// Token: 0x0602C960 RID: 182624 RVA: 0x00C8428A File Offset: 0x00C8248A
		protected override void OnSafeUpdate(Vector playerLocation, bool bDragging = false, bool bIsScale = false)
		{
			if (this.Holder != null)
			{
				this.UpdateDisableState();
			}
		}

		// Token: 0x0602C961 RID: 182625 RVA: 0x00C8429C File Offset: 0x00C8249C
		private void UpdateDisableState()
		{
			TemporaryTeleportMarkItem temporaryTeleportMarkItem = (TemporaryTeleportMarkItem)this.Holder;
			UUISprite sprite = base.GetSprite(2);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(temporaryTeleportMarkItem.IsServerDisable);
		}

		// Token: 0x0602C962 RID: 182626 RVA: 0x00C842CC File Offset: 0x00C824CC
		[PreserveBaseOverrides]
		protected new virtual MarkItemChildIconHandle CreateChildIconHandle(IMarkItemComponentContext markComponentContext)
		{
			return new TemporaryTeleportMarkItemChildIconHandle(markComponentContext);
		}

		// Token: 0x0602C963 RID: 182627 RVA: 0x00C842D4 File Offset: 0x00C824D4
		public void UpdateIcon()
		{
			base.MarkItemChildIconHandle.Update();
			base.MarkItemChildIconHandle.ApplyModified();
		}

		// Token: 0x0602C964 RID: 182628 RVA: 0x00C842EC File Offset: 0x00C824EC
		private void OnSubMapChanged(int floorIndex)
		{
			TemporaryTeleportMarkItem temporaryTeleportMarkItem = this.Holder as TemporaryTeleportMarkItem;
			if (temporaryTeleportMarkItem == null)
			{
				return;
			}
			temporaryTeleportMarkItem.UpdateMultiMapFloorSelectedState();
		}
	}
}
