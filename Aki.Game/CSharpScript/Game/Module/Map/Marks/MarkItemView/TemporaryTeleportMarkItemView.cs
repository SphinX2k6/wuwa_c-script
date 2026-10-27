using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x02005526 RID: 21798
	[NullableContext(1)]
	[Nullable(0)]
	public class TemporaryTeleportMarkItemView : ServerMarkItemView
	{
		// Token: 0x06037A8B RID: 227979 RVA: 0x00D364A9 File Offset: 0x00D346A9
		public TemporaryTeleportMarkItemView(TemporaryTeleportMarkItem holder) : base(holder)
		{
		}

		// Token: 0x06037A8C RID: 227980 RVA: 0x00D364B2 File Offset: 0x00D346B2
		public override void RegisterEvents()
		{
			MarkItem holder = this.Holder;
			if (holder != null && holder.MapType == EMapType.WorldMap)
			{
				EventSystem.Instance.Add<int>(EEventName.WorldMapSubMapChangedFromUpdate, new Action<int>(this.OnSubMapChanged));
			}
		}

		// Token: 0x06037A8D RID: 227981 RVA: 0x00D364E7 File Offset: 0x00D346E7
		public override void UnRegisterEvents()
		{
			MarkItem holder = this.Holder;
			if (holder != null && holder.MapType == EMapType.WorldMap)
			{
				EventSystem.Instance.Remove<int>(EEventName.WorldMapSubMapChangedFromUpdate, new Action<int>(this.OnSubMapChanged));
			}
		}

		// Token: 0x06037A8E RID: 227982 RVA: 0x00D3651C File Offset: 0x00D3471C
		protected override void OnViewRefresh()
		{
			this.OnIconPathChanged(this.Holder.IconPath);
			this.UpdateDisableState();
		}

		// Token: 0x06037A8F RID: 227983 RVA: 0x00D36535 File Offset: 0x00D34735
		protected override void OnSelectedStateChange(bool newState)
		{
			if (((TemporaryTeleportMarkItem)this.Holder).IsServerDisable)
			{
				ScrollingTipsController.Instance.ShowTipsById("Map_TeleportMark_Disable_Tips", Array.Empty<object>());
			}
		}

		// Token: 0x06037A90 RID: 227984 RVA: 0x00D3655D File Offset: 0x00D3475D
		protected override void OnSafeUpdate(Vector playerLocation, bool bDragging = false, bool bIsScale = false)
		{
			if (this.Holder != null)
			{
				this.UpdateDisableState();
			}
		}

		// Token: 0x06037A91 RID: 227985 RVA: 0x00D36570 File Offset: 0x00D34770
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

		// Token: 0x06037A92 RID: 227986 RVA: 0x00D365A0 File Offset: 0x00D347A0
		[PreserveBaseOverrides]
		protected new virtual MarkItemChildIconHandle CreateChildIconHandle(IMarkItemComponentContext markComponentContext)
		{
			return new TemporaryTeleportMarkItemChildIconHandle(markComponentContext);
		}

		// Token: 0x06037A93 RID: 227987 RVA: 0x00D365A8 File Offset: 0x00D347A8
		public void UpdateIcon()
		{
			base.MarkItemChildIconHandle.Update();
			base.MarkItemChildIconHandle.ApplyModified();
		}

		// Token: 0x06037A94 RID: 227988 RVA: 0x00D365C0 File Offset: 0x00D347C0
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
