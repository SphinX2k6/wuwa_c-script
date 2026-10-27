using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x02005525 RID: 21797
	[NullableContext(1)]
	[Nullable(0)]
	public class TeleportMarkItemView : ConfigMarkItemView
	{
		// Token: 0x06037A7F RID: 227967 RVA: 0x00D36246 File Offset: 0x00D34446
		public TeleportMarkItemView(TeleportMarkItem holder) : base(holder)
		{
		}

		// Token: 0x06037A80 RID: 227968 RVA: 0x00D36250 File Offset: 0x00D34450
		public override void RegisterEvents()
		{
			EventSystem.Instance.Add(EEventName.OnMarkItemShowStateChange, new Action<int>(this.OnMarkItemStateChange));
			EventSystem.Instance.Add<int>(EEventName.WorldMapSelectMultiMap, new Action<int>(this.OnSubMapChanged));
			EventSystem.Instance.Add(EEventName.UnlockTeleport, new Action<int>(this.OnUnlockTeleport));
		}

		// Token: 0x06037A81 RID: 227969 RVA: 0x00D362B4 File Offset: 0x00D344B4
		public override void UnRegisterEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnMarkItemShowStateChange, new Action<int>(this.OnMarkItemStateChange));
			EventSystem.Instance.Remove(EEventName.WorldMapSelectMultiMap, new Action<int>(this.OnSubMapChanged));
			EventSystem.Instance.Remove(EEventName.UnlockTeleport, new Action<int>(this.OnUnlockTeleport));
		}

		// Token: 0x06037A82 RID: 227970 RVA: 0x00D36316 File Offset: 0x00D34516
		protected override void OnViewRefresh()
		{
			this.Refresh();
		}

		// Token: 0x06037A83 RID: 227971 RVA: 0x00D3631E File Offset: 0x00D3451E
		private void Refresh()
		{
			base.UpdateMultiMapFloorSelectState(true);
			this.OnIconPathChanged(this.Holder.IconPath);
		}

		// Token: 0x06037A84 RID: 227972 RVA: 0x00D36338 File Offset: 0x00D34538
		protected override void OnSafeUpdate(global::Vector playerLocation, bool bDragging = false, bool bIsScale = false)
		{
			base.UpdateMultiMapFloorSelectState(false);
		}

		// Token: 0x06037A85 RID: 227973 RVA: 0x00D36344 File Offset: 0x00D34544
		protected override void OnSubMapChanged(int subMapId)
		{
			TeleportMarkItem teleportMarkItem = (TeleportMarkItem)this.Holder;
			teleportMarkItem.IsSelectThisFloor = (teleportMarkItem.GetMultiMapId() == subMapId);
			this.OnIconPathChanged(teleportMarkItem.IconPath);
		}

		// Token: 0x06037A86 RID: 227974 RVA: 0x00D36378 File Offset: 0x00D34578
		private void OnUnlockTeleport(int markId)
		{
			if (base.MarkConfig.Value.MarkId == markId)
			{
				this.OnIconPathChanged(this.Holder.IconPath);
			}
		}

		// Token: 0x06037A87 RID: 227975 RVA: 0x00D363AF File Offset: 0x00D345AF
		public void OnMarkItemStateChange(int markId)
		{
			if (MapModel.Instance.GetMarkExtraShowState(this.Holder.MarkId).ShowFlag == MapMarkShowFlag.ShowDisable)
			{
				base.GetSprite(2).SetUIActive(true);
				return;
			}
			base.GetSprite(2).SetUIActive(false);
		}

		// Token: 0x06037A88 RID: 227976 RVA: 0x00D363EC File Offset: 0x00D345EC
		public override void OnIconPathChanged(string iconPath)
		{
			if (base.MarkItemChildIconHandle == null)
			{
				return;
			}
			UUISprite sprite = base.GetSprite(1);
			base.LoadIcon(sprite, iconPath);
			base.MarkItemChildIconHandle.Update();
			base.MarkItemChildIconHandle.ApplyModified();
		}

		// Token: 0x06037A89 RID: 227977 RVA: 0x00D36428 File Offset: 0x00D34628
		protected override void OnSelectedStateChange(bool newState)
		{
			if (!newState)
			{
				return;
			}
			if (MapModel.Instance.GetMarkExtraShowState(this.Holder.MarkId).ShowFlag == MapMarkShowFlag.ShowDisable)
			{
				if (MapModel.Instance.IsMarkForbidGravityTeleport(this.Holder.MarkId, this.Holder.MarkType))
				{
					GenericPromptController.Instance.ShowPromptByCode("MultiModeCannotTeleport", Array.Empty<object>());
					return;
				}
				ScrollingTipsController.Instance.ShowTipsById("Map_TeleportMark_Disable_Tips", Array.Empty<object>());
			}
		}

		// Token: 0x06037A8A RID: 227978 RVA: 0x00D364A1 File Offset: 0x00D346A1
		[PreserveBaseOverrides]
		protected new virtual MarkItemChildIconHandle CreateChildIconHandle(IMarkItemComponentContext markComponentContext)
		{
			return new TeleportMarkItemChildIconHandle(markComponentContext);
		}
	}
}
