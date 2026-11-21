using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044F8 RID: 17656
	[NullableContext(1)]
	[Nullable(0)]
	public class TeleportMarkItemView : ConfigMarkItemView
	{
		// Token: 0x0602C94F RID: 182607 RVA: 0x00C83F93 File Offset: 0x00C82193
		public TeleportMarkItemView(TeleportMarkItem holder) : base(holder)
		{
		}

		// Token: 0x0602C950 RID: 182608 RVA: 0x00C83F9C File Offset: 0x00C8219C
		public override void RegisterEvents()
		{
			EventSystem.Instance.Add(EEventName.OnMarkItemShowStateChange, new Action<int>(this.OnMarkItemStateChange));
			EventSystem.Instance.Add<int>(EEventName.WorldMapSelectMultiMap, new Action<int>(this.OnSubMapChanged));
			EventSystem.Instance.Add(EEventName.UnlockTeleport, new Action<int>(this.OnUnlockTeleport));
		}

		// Token: 0x0602C951 RID: 182609 RVA: 0x00C84000 File Offset: 0x00C82200
		public override void UnRegisterEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnMarkItemShowStateChange, new Action<int>(this.OnMarkItemStateChange));
			EventSystem.Instance.Remove(EEventName.WorldMapSelectMultiMap, new Action<int>(this.OnSubMapChanged));
			EventSystem.Instance.Remove(EEventName.UnlockTeleport, new Action<int>(this.OnUnlockTeleport));
		}

		// Token: 0x0602C952 RID: 182610 RVA: 0x00C84062 File Offset: 0x00C82262
		protected override void OnViewRefresh()
		{
			this.Refresh();
		}

		// Token: 0x0602C953 RID: 182611 RVA: 0x00C8406A File Offset: 0x00C8226A
		private void Refresh()
		{
			base.UpdateMultiMapFloorSelectState(true);
			this.OnIconPathChanged(this.Holder.IconPath);
		}

		// Token: 0x0602C954 RID: 182612 RVA: 0x00C84084 File Offset: 0x00C82284
		protected override void OnSafeUpdate(global::Vector playerLocation, bool bDragging = false, bool bIsScale = false)
		{
			base.UpdateMultiMapFloorSelectState(false);
		}

		// Token: 0x0602C955 RID: 182613 RVA: 0x00C84090 File Offset: 0x00C82290
		protected override void OnSubMapChanged(int subMapId)
		{
			TeleportMarkItem teleportMarkItem = (TeleportMarkItem)this.Holder;
			teleportMarkItem.IsSelectThisFloor = (teleportMarkItem.GetMultiMapId() == subMapId);
			this.OnIconPathChanged(teleportMarkItem.IconPath);
		}

		// Token: 0x0602C956 RID: 182614 RVA: 0x00C840C4 File Offset: 0x00C822C4
		private void OnUnlockTeleport(int markId)
		{
			if (this.Holder.MarkId == markId)
			{
				this.OnIconPathChanged(this.Holder.IconPath);
			}
		}

		// Token: 0x0602C957 RID: 182615 RVA: 0x00C840E8 File Offset: 0x00C822E8
		private void OnMarkItemStateChange(int markId)
		{
			IMarkShowState markExtraShowState = MapModel.Instance.GetMarkExtraShowState(this.Holder.MarkId);
			base.GetSprite(2).SetUIActive(markExtraShowState.ShowFlag == MapMarkShowFlag.ShowDisable);
		}

		// Token: 0x0602C958 RID: 182616 RVA: 0x00C84120 File Offset: 0x00C82320
		public override void OnIconPathChanged(string iconPath)
		{
			UUISprite sprite = base.GetSprite(1);
			base.LoadIcon(sprite, iconPath);
			base.MarkItemChildIconHandle.Update();
			base.MarkItemChildIconHandle.ApplyModified();
		}

		// Token: 0x0602C959 RID: 182617 RVA: 0x00C84154 File Offset: 0x00C82354
		protected override void OnSelectedStateChange(bool newState)
		{
			if (!newState)
			{
				return;
			}
			if (MapModel.Instance.GetMarkExtraShowState(this.Holder.MarkId).ShowFlag != MapMarkShowFlag.ShowDisable)
			{
				return;
			}
			if (MapModel.Instance.IsMarkForbidGravityTeleport(this.Holder.MarkId, this.Holder.MarkType))
			{
				GenericPromptController.Instance.ShowPromptByCode("MultiModeCannotTeleport", Array.Empty<object>());
				return;
			}
			ScrollingTipsController.Instance.ShowTipsById("Map_TeleportMark_Disable_Tips", Array.Empty<object>());
		}

		// Token: 0x0602C95A RID: 182618 RVA: 0x00C841CE File Offset: 0x00C823CE
		[PreserveBaseOverrides]
		protected new virtual MarkItemChildIconHandle CreateChildIconHandle(IMarkItemComponentContext markComponentContext)
		{
			return new TeleportMarkItemChildIconHandle(markComponentContext);
		}
	}
}
