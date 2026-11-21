using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200573A RID: 22330
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlCombineGuideLineHost
	{
		// Token: 0x17006A46 RID: 27206
		// (get) Token: 0x06036FBB RID: 225211 RVA: 0x00F576CD File Offset: 0x00F558CD
		public bool IsShowing
		{
			get
			{
				return this.ShowReasonMask > ECombineLineShowReason.None;
			}
		}

		// Token: 0x06036FBC RID: 225212 RVA: 0x00F576D8 File Offset: 0x00F558D8
		public int GetCachedUid()
		{
			return this.OwnerUid;
		}

		// Token: 0x06036FBD RID: 225213 RVA: 0x00F576E0 File Offset: 0x00F558E0
		public DangoBrawlCombineGuideLineHost(ICombineLineOwner owner, EDragSourceKind ownerSource, ActivityDangoBrawlData actData, UUIItem lineTemplate, UUIItem lineContainer)
		{
			this.Owner = owner;
			this.OwnerSource = ownerSource;
			this.ActData = actData;
			this.LineTemplate = lineTemplate;
			this.LineContainer = lineContainer;
			this.LineTemplate.SetUIActive(false);
			this.OwnerUid = owner.GetOwnerUid();
			EventSystem.Instance.Add<EInteractionState>(EEventName.OnDangoBrawlInteractionStateChanged, new Action<EInteractionState>(this.OnInteractionStateChanged));
		}

		// Token: 0x06036FBE RID: 225214 RVA: 0x00F57778 File Offset: 0x00F55978
		public void Destroy()
		{
			EventSystem.Instance.Remove<EInteractionState>(EEventName.OnDangoBrawlInteractionStateChanged, new Action<EInteractionState>(this.OnInteractionStateChanged));
			this.HideAll();
			this.PartnerRequesterUids.Clear();
			this.LinePool.Clear();
		}

		// Token: 0x06036FBF RID: 225215 RVA: 0x00F577B4 File Offset: 0x00F559B4
		public void SetReason(ECombineLineShowReason reason, bool on)
		{
			ECombineLineShowReason showReasonMask = this.ShowReasonMask;
			ECombineLineShowReason ecombineLineShowReason = on ? (showReasonMask | reason) : (showReasonMask & ~reason);
			if (ecombineLineShowReason == showReasonMask)
			{
				return;
			}
			this.ShowReasonMask = ecombineLineShowReason;
			if (ecombineLineShowReason == ECombineLineShowReason.None)
			{
				this.HideAll();
				return;
			}
			bool flag = (showReasonMask & ~ECombineLineShowReason.Partner) > ECombineLineShowReason.None;
			bool flag2 = (ecombineLineShowReason & ~ECombineLineShowReason.Partner) > ECombineLineShowReason.None;
			bool flag3 = this.OwnerSource == EDragSourceKind.Shop && DangoBrawlCombineGuideLineHost.HasHotzoneReason(showReasonMask) != DangoBrawlCombineGuideLineHost.HasHotzoneReason(ecombineLineShowReason);
			if (showReasonMask == ECombineLineShowReason.None || flag != flag2 || flag3)
			{
				bool cascadeToPartners = DangoBrawlCombineGuideLineHost.HasHotzoneReason(ecombineLineShowReason);
				this.RebuildLines(cascadeToPartners);
			}
		}

		// Token: 0x06036FC0 RID: 225216 RVA: 0x00F5783B File Offset: 0x00F55A3B
		private static bool HasHotzoneReason(ECombineLineShowReason mask)
		{
			return (mask & (ECombineLineShowReason.Hover | ECombineLineShowReason.Drag | ECombineLineShowReason.Holding)) > ECombineLineShowReason.None;
		}

		// Token: 0x06036FC1 RID: 225217 RVA: 0x00F57844 File Offset: 0x00F55A44
		public void SetPartnerReason(int requesterUid, bool on)
		{
			int num2;
			int num = this.PartnerRequesterUids.TryGetValue(requesterUid, out num2) ? num2 : 0;
			int num3 = on ? (num + 1) : (num - 1);
			if (num3 <= 0)
			{
				this.PartnerRequesterUids.Remove(requesterUid);
			}
			else
			{
				this.PartnerRequesterUids[requesterUid] = num3;
			}
			bool flag = num == 0 != num3 <= 0;
			this.SetReason(ECombineLineShowReason.Partner, this.PartnerRequesterUids.Count > 0);
			if (flag && this.ShowReasonMask != ECombineLineShowReason.None)
			{
				this.RebuildLines(false);
			}
		}

		// Token: 0x06036FC2 RID: 225218 RVA: 0x00F578C8 File Offset: 0x00F55AC8
		private void OnInteractionStateChanged(EInteractionState state)
		{
			if (state == EInteractionState.Idle)
			{
				this.SetReason(ECombineLineShowReason.Holding, false);
				return;
			}
			DangoBrawlTouchController touchController = DangoBrawlModel.Instance.GetTouchController();
			InteractionPayload interactionPayload = (touchController != null) ? touchController.GetInteractionFsm().GetPayLoad() : null;
			IDragVisual dragVisual = (interactionPayload != null) ? interactionPayload.Visual : null;
			bool on = dragVisual != null && dragVisual.Source == this.OwnerSource && dragVisual.SourceUid == this.OwnerUid;
			this.SetReason(ECombineLineShowReason.Holding, on);
		}

		// Token: 0x06036FC3 RID: 225219 RVA: 0x00F57934 File Offset: 0x00F55B34
		public void RefreshAnglesAndPartners()
		{
			this.RefreshAngles();
			foreach (ICombineLineOwner combineLineOwner in this.CurrentPartnerOwners)
			{
				combineLineOwner.RefreshLineAngles();
			}
		}

		// Token: 0x06036FC4 RID: 225220 RVA: 0x00F5798C File Offset: 0x00F55B8C
		public void RebuildSelf()
		{
			if (this.ShowReasonMask == ECombineLineShowReason.None)
			{
				return;
			}
			this.RebuildLines(false);
			foreach (ICombineLineOwner combineLineOwner in this.CurrentPartnerOwners)
			{
				combineLineOwner.RefreshLineAngles();
			}
		}

		// Token: 0x06036FC5 RID: 225221 RVA: 0x00F579EC File Offset: 0x00F55BEC
		public void RebuildShowing()
		{
			if (this.ShowReasonMask == ECombineLineShowReason.None)
			{
				return;
			}
			bool cascadeToPartners = DangoBrawlCombineGuideLineHost.HasHotzoneReason(this.ShowReasonMask);
			this.RebuildLines(cascadeToPartners);
		}

		// Token: 0x06036FC6 RID: 225222 RVA: 0x00F57A18 File Offset: 0x00F55C18
		public void RefreshAngles()
		{
			if (this.ShowReasonMask == ECombineLineShowReason.None || this.Partners.Length == 0)
			{
				return;
			}
			FVector2D? ownerStartLgui = this.GetOwnerStartLgui();
			if (ownerStartLgui == null)
			{
				return;
			}
			DangoBrawlItemViewRegistry viewRegistry = DangoBrawlModel.Instance.GetViewRegistry();
			for (int i = 0; i < this.Partners.Length; i++)
			{
				CombineItem combineItem = this.Partners[i];
				if (i >= this.LinePool.Count)
				{
					break;
				}
				UUIItem uuiitem = this.LinePool[i];
				if (uuiitem.IsValid())
				{
					FVector2D? partnerStartLgui = DangoBrawlCombineGuideLineHost.GetPartnerStartLgui(combineItem.Uid, viewRegistry);
					if (partnerStartLgui == null)
					{
						uuiitem.SetUIActive(false);
					}
					else
					{
						uuiitem.SetUIActive(true);
						float inYaw = DangoBrawlCombineUtil.CalcCombineLineAngleDeg(ownerStartLgui.Value, partnerStartLgui.Value);
						UUIItem uuiitem2 = uuiitem;
						FRotator frotator = new FRotator(0f, inYaw, 0f);
						uuiitem2.SetUIRelativeRotation(frotator);
						float num = partnerStartLgui.Value.X - ownerStartLgui.Value.X;
						float num2 = partnerStartLgui.Value.Y - ownerStartLgui.Value.Y;
						float value = (float)Math.Sqrt((double)(num * num + num2 * num2)) * 0.5f;
						uuiitem.SetWidth(Math.Clamp(value, 60f, 136f));
					}
				}
			}
		}

		// Token: 0x06036FC7 RID: 225223 RVA: 0x00F57B64 File Offset: 0x00F55D64
		private void RebuildLines(bool cascadeToPartners = true)
		{
			bool flag = this.OwnerSource == EDragSourceKind.Shop && !DangoBrawlCombineGuideLineHost.HasHotzoneReason(this.ShowReasonMask);
			CombineItem[] array2;
			if (this.ShowReasonMask == ECombineLineShowReason.Partner && this.PartnerRequesterUids.Count > 0)
			{
				CombineItem[] array = new CombineItem[this.PartnerRequesterUids.Count];
				int num = 0;
				foreach (int uid in this.PartnerRequesterUids.Keys)
				{
					array[num++] = new CombineItem
					{
						Uid = uid
					};
				}
				array2 = array;
			}
			else
			{
				EDragSourceKind[] array3;
				if (!flag)
				{
					array3 = null;
				}
				else
				{
					EDragSourceKind[] array4 = new EDragSourceKind[2];
					array4[0] = EDragSourceKind.Bag;
					array3 = array4;
					array4[1] = EDragSourceKind.Bench;
				}
				EDragSourceKind[] validSources = array3;
				array2 = DangoBrawlCombineUtil.GetCombinePartnerUids(this.OwnerUid, this.ActData, this.OwnerSource, validSources);
				if (flag && this.PartnerRequesterUids.Count > 0)
				{
					List<CombineItem> list = new List<CombineItem>(array2);
					foreach (int num2 in this.PartnerRequesterUids.Keys)
					{
						bool flag2 = false;
						CombineItem[] array5 = array2;
						for (int i = 0; i < array5.Length; i++)
						{
							if (array5[i].Uid == num2)
							{
								flag2 = true;
								break;
							}
						}
						if (!flag2)
						{
							list.Add(new CombineItem
							{
								Uid = num2
							});
						}
					}
					array2 = list.ToArray();
				}
			}
			this.Partners = array2;
			foreach (ICombineLineOwner combineLineOwner in this.CurrentPartnerOwners)
			{
				combineLineOwner.NotifyAsPartner(this.OwnerUid, false);
			}
			this.CurrentPartnerOwners.Clear();
			this.EnsurePoolSize(array2.Length);
			foreach (UUIItem uuiitem in this.LinePool)
			{
				uuiitem.SetUIActive(false);
			}
			if (array2.Length == 0)
			{
				return;
			}
			this.LineContainer.SetUIActive(true);
			FVector2D ownerStartLocalPos = this.GetOwnerStartLocalPos();
			DangoBrawlItemViewRegistry viewRegistry = DangoBrawlModel.Instance.GetViewRegistry();
			int num3 = 0;
			while (num3 < array2.Length && num3 < this.LinePool.Count)
			{
				UUIItem uuiitem2 = this.LinePool[num3];
				if (uuiitem2 != null && uuiitem2.IsValid())
				{
					uuiitem2.SetUIRelativeLocation(new FVector(ownerStartLocalPos.X, ownerStartLocalPos.Y, 0f));
					uuiitem2.SetUIActive(true);
					if (cascadeToPartners)
					{
						ICombineLineOwner combineLineOwner2 = (viewRegistry != null) ? viewRegistry.GetLineOwner(array2[num3].Uid) : null;
						if (combineLineOwner2 != null)
						{
							combineLineOwner2.NotifyAsPartner(this.OwnerUid, true);
							this.CurrentPartnerOwners.Add(combineLineOwner2);
						}
					}
				}
				num3++;
			}
			this.RefreshAngles();
		}

		// Token: 0x06036FC8 RID: 225224 RVA: 0x00F57E84 File Offset: 0x00F56084
		private void HideAll()
		{
			foreach (UUIItem uuiitem in this.LinePool)
			{
				uuiitem.SetUIActive(false);
			}
			this.LineContainer.SetUIActive(false);
			foreach (ICombineLineOwner combineLineOwner in this.CurrentPartnerOwners)
			{
				combineLineOwner.NotifyAsPartner(this.OwnerUid, false);
			}
			this.CurrentPartnerOwners.Clear();
			this.Partners = Array.Empty<CombineItem>();
		}

		// Token: 0x06036FC9 RID: 225225 RVA: 0x00F57F40 File Offset: 0x00F56140
		private void EnsurePoolSize(int size)
		{
			while (this.LinePool.Count < size)
			{
				UUIItem uuiitem = LguiUtil.Instance.CopyItem(this.LineTemplate, this.LineContainer);
				uuiitem.SetUIActive(false);
				this.LinePool.Add(uuiitem);
			}
		}

		// Token: 0x06036FCA RID: 225226 RVA: 0x00F57F88 File Offset: 0x00F56188
		private FVector2D? GetOwnerStartLgui()
		{
			UUIItem ownerRootItem = this.Owner.GetOwnerRootItem();
			if (ownerRootItem == null || !ownerRootItem.IsValid())
			{
				return null;
			}
			return DangoBrawlCombineUtil.GetItemStartLguiPos(ownerRootItem, this.Owner.GetOwnerConfigId());
		}

		// Token: 0x06036FCB RID: 225227 RVA: 0x00F57FC8 File Offset: 0x00F561C8
		[NullableContext(2)]
		private static FVector2D? GetPartnerStartLgui(int partnerUid, DangoBrawlItemViewRegistry registry)
		{
			ICombineLineOwner combineLineOwner = (registry != null) ? registry.GetLineOwner(partnerUid) : null;
			UUIItem uuiitem = (combineLineOwner != null) ? combineLineOwner.GetOwnerRootItem() : null;
			if (uuiitem != null && uuiitem.IsValid())
			{
				return DangoBrawlCombineUtil.GetItemStartLguiPos(uuiitem, combineLineOwner.GetOwnerConfigId());
			}
			IDangoBrawlDraggableView dangoBrawlDraggableView = (registry != null) ? registry.GetView(partnerUid) : null;
			if (dangoBrawlDraggableView == null)
			{
				return null;
			}
			UUIItem draggableRootItem = dangoBrawlDraggableView.GetDraggableRootItem();
			if (!draggableRootItem.IsValid())
			{
				return null;
			}
			return DangoBrawlCombineUtil.GetItemStartLguiPos(draggableRootItem, dangoBrawlDraggableView.MyConfigId);
		}

		// Token: 0x06036FCC RID: 225228 RVA: 0x00F5804C File Offset: 0x00F5624C
		private FVector2D GetOwnerStartLocalPos()
		{
			int ownerConfigId = this.Owner.GetOwnerConfigId();
			if (ownerConfigId <= 0)
			{
				return new FVector2D(0f, 0f);
			}
			FVector2D linkCenterOffset = DangoBrawlCombineUtil.GetLinkCenterOffset(DangoBrawlUtil.GetTemplateId(ownerConfigId));
			return new FVector2D(linkCenterOffset.X, linkCenterOffset.Y);
		}

		// Token: 0x0401D196 RID: 119190
		private readonly ICombineLineOwner Owner;

		// Token: 0x0401D197 RID: 119191
		private readonly EDragSourceKind OwnerSource;

		// Token: 0x0401D198 RID: 119192
		private readonly ActivityDangoBrawlData ActData;

		// Token: 0x0401D199 RID: 119193
		private readonly UUIItem LineTemplate;

		// Token: 0x0401D19A RID: 119194
		private readonly UUIItem LineContainer;

		// Token: 0x0401D19B RID: 119195
		private readonly List<UUIItem> LinePool = new List<UUIItem>();

		// Token: 0x0401D19C RID: 119196
		private CombineItem[] Partners = Array.Empty<CombineItem>();

		// Token: 0x0401D19D RID: 119197
		private readonly List<ICombineLineOwner> CurrentPartnerOwners = new List<ICombineLineOwner>();

		// Token: 0x0401D19E RID: 119198
		private readonly Dictionary<int, int> PartnerRequesterUids = new Dictionary<int, int>();

		// Token: 0x0401D19F RID: 119199
		private ECombineLineShowReason ShowReasonMask;

		// Token: 0x0401D1A0 RID: 119200
		private readonly int OwnerUid;
	}
}
