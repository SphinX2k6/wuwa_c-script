using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067EA RID: 26602
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlCombineGuideLineHost
	{
		// Token: 0x17009705 RID: 38661
		// (get) Token: 0x06042465 RID: 271461 RVA: 0x01016235 File Offset: 0x01014435
		public bool IsShowing
		{
			get
			{
				return this.ShowReasonMask > ECombineLineShowReason.None;
			}
		}

		// Token: 0x06042466 RID: 271462 RVA: 0x01016240 File Offset: 0x01014440
		public int GetCachedUid()
		{
			return this.OwnerUid;
		}

		// Token: 0x06042467 RID: 271463 RVA: 0x01016248 File Offset: 0x01014448
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

		// Token: 0x06042468 RID: 271464 RVA: 0x010162E0 File Offset: 0x010144E0
		public void Destroy()
		{
			EventSystem.Instance.Remove<EInteractionState>(EEventName.OnDangoBrawlInteractionStateChanged, new Action<EInteractionState>(this.OnInteractionStateChanged));
			this.HideAll();
			this.PartnerRequesterUids.Clear();
			this.LinePool.Clear();
		}

		// Token: 0x06042469 RID: 271465 RVA: 0x0101631C File Offset: 0x0101451C
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

		// Token: 0x0604246A RID: 271466 RVA: 0x010163A3 File Offset: 0x010145A3
		private static bool HasHotzoneReason(ECombineLineShowReason mask)
		{
			return (mask & (ECombineLineShowReason.Hover | ECombineLineShowReason.Drag | ECombineLineShowReason.Holding)) > ECombineLineShowReason.None;
		}

		// Token: 0x0604246B RID: 271467 RVA: 0x010163AC File Offset: 0x010145AC
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

		// Token: 0x0604246C RID: 271468 RVA: 0x01016430 File Offset: 0x01014630
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

		// Token: 0x0604246D RID: 271469 RVA: 0x0101649C File Offset: 0x0101469C
		public void RefreshAnglesAndPartners()
		{
			this.RefreshAngles();
			foreach (ICombineLineOwner combineLineOwner in this.CurrentPartnerOwners)
			{
				combineLineOwner.RefreshLineAngles();
			}
		}

		// Token: 0x0604246E RID: 271470 RVA: 0x010164F4 File Offset: 0x010146F4
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

		// Token: 0x0604246F RID: 271471 RVA: 0x01016554 File Offset: 0x01014754
		public void RebuildShowing()
		{
			if (this.ShowReasonMask == ECombineLineShowReason.None)
			{
				return;
			}
			bool cascadeToPartners = DangoBrawlCombineGuideLineHost.HasHotzoneReason(this.ShowReasonMask);
			this.RebuildLines(cascadeToPartners);
		}

		// Token: 0x06042470 RID: 271472 RVA: 0x01016580 File Offset: 0x01014780
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

		// Token: 0x06042471 RID: 271473 RVA: 0x010166CC File Offset: 0x010148CC
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

		// Token: 0x06042472 RID: 271474 RVA: 0x010169EC File Offset: 0x01014BEC
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

		// Token: 0x06042473 RID: 271475 RVA: 0x01016AA8 File Offset: 0x01014CA8
		private void EnsurePoolSize(int size)
		{
			while (this.LinePool.Count < size)
			{
				UUIItem uuiitem = LguiUtil.Instance.CopyItem(this.LineTemplate, this.LineContainer);
				uuiitem.SetUIActive(false);
				this.LinePool.Add(uuiitem);
			}
		}

		// Token: 0x06042474 RID: 271476 RVA: 0x01016AF0 File Offset: 0x01014CF0
		private FVector2D? GetOwnerStartLgui()
		{
			UUIItem ownerRootItem = this.Owner.GetOwnerRootItem();
			if (ownerRootItem == null || !ownerRootItem.IsValid())
			{
				return null;
			}
			return DangoBrawlCombineUtil.GetItemStartLguiPos(ownerRootItem, this.Owner.GetOwnerConfigId());
		}

		// Token: 0x06042475 RID: 271477 RVA: 0x01016B30 File Offset: 0x01014D30
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

		// Token: 0x06042476 RID: 271478 RVA: 0x01016BB4 File Offset: 0x01014DB4
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

		// Token: 0x04022939 RID: 141625
		private readonly ICombineLineOwner Owner;

		// Token: 0x0402293A RID: 141626
		private readonly EDragSourceKind OwnerSource;

		// Token: 0x0402293B RID: 141627
		private readonly ActivityDangoBrawlData ActData;

		// Token: 0x0402293C RID: 141628
		private readonly UUIItem LineTemplate;

		// Token: 0x0402293D RID: 141629
		private readonly UUIItem LineContainer;

		// Token: 0x0402293E RID: 141630
		private readonly List<UUIItem> LinePool = new List<UUIItem>();

		// Token: 0x0402293F RID: 141631
		private CombineItem[] Partners = Array.Empty<CombineItem>();

		// Token: 0x04022940 RID: 141632
		private readonly List<ICombineLineOwner> CurrentPartnerOwners = new List<ICombineLineOwner>();

		// Token: 0x04022941 RID: 141633
		private readonly Dictionary<int, int> PartnerRequesterUids = new Dictionary<int, int>();

		// Token: 0x04022942 RID: 141634
		private ECombineLineShowReason ShowReasonMask;

		// Token: 0x04022943 RID: 141635
		private readonly int OwnerUid;
	}
}
