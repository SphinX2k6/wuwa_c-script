using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200675B RID: 26459
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlDataController
	{
		// Token: 0x0604217E RID: 270718 RVA: 0x01009CBD File Offset: 0x01007EBD
		public DangoBrawlDataController(ActivityDangoBrawlData data)
		{
			this.ActivityData = data;
		}

		// Token: 0x0604217F RID: 270719 RVA: 0x01009CD4 File Offset: 0x01007ED4
		public void Start()
		{
			EventSystem.Instance.Add(EEventName.OnDangoBrawlBagOperated, new Action<EBagOpKind, int>(this.OnBagOperated));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlDragBegin, new Action<EDragSourceKind, int>(this.OnDragBegin));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlDragEnd, new Action(this.OnDragEnd));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlBagUpdated, new Action(this.OnDangoBrawlBagUpdated));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlShopBought, new Action<int, int, int, bool>(this.OnDangoBrawlShopBought));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlShopSold, new Action<int>(this.OnShopSold));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlShopComposed, new Action<int, int, int, bool, int[], EDragSourceKind[]>(this.OnShopBench));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlInteractionStateChanged, new Action<EInteractionState>(this.OnInteractionStateChanged));
			this.UpdateViewCost();
		}

		// Token: 0x06042180 RID: 270720 RVA: 0x01009DC8 File Offset: 0x01007FC8
		public void Stop()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBagOperated, new Action<EBagOpKind, int>(this.OnBagOperated));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlDragBegin, new Action<EDragSourceKind, int>(this.OnDragBegin));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlDragEnd, new Action(this.OnDragEnd));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBagUpdated, new Action(this.OnDangoBrawlBagUpdated));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopBought, new Action<int, int, int, bool>(this.OnDangoBrawlShopBought));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopSold, new Action<int>(this.OnShopSold));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopComposed, new Action<int, int, int, bool, int[], EDragSourceKind[]>(this.OnShopBench));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlInteractionStateChanged, new Action<EInteractionState>(this.OnInteractionStateChanged));
		}

		// Token: 0x06042181 RID: 270721 RVA: 0x01009EB5 File Offset: 0x010080B5
		public void SetViewIsInThreeChoose(bool value)
		{
			this.ViewIsInThreeChoose = value;
		}

		// Token: 0x06042182 RID: 270722 RVA: 0x01009EBE File Offset: 0x010080BE
		public bool GetViewIsInThreeChoose()
		{
			return this.ViewIsInThreeChoose;
		}

		// Token: 0x06042183 RID: 270723 RVA: 0x01009EC6 File Offset: 0x010080C6
		public void SetViewLayerMode(bool value)
		{
			this.ViewLayerMode = value;
		}

		// Token: 0x06042184 RID: 270724 RVA: 0x01009ECF File Offset: 0x010080CF
		public bool GetViewLayerMode()
		{
			return this.ViewLayerMode;
		}

		// Token: 0x06042185 RID: 270725 RVA: 0x01009ED7 File Offset: 0x010080D7
		public void SetLastEventSelectIndex(int index)
		{
			this.LastEventSelectIndex = index;
		}

		// Token: 0x06042186 RID: 270726 RVA: 0x01009EE0 File Offset: 0x010080E0
		public int GetLastEventSelectIndex()
		{
			return this.LastEventSelectIndex;
		}

		// Token: 0x06042187 RID: 270727 RVA: 0x01009EE8 File Offset: 0x010080E8
		public int GetViewCost()
		{
			return this.ViewCost;
		}

		// Token: 0x06042188 RID: 270728 RVA: 0x01009EF0 File Offset: 0x010080F0
		public void UpdateViewCost()
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			this.ViewCost = ((activityData != null) ? activityData.GetBagWeight() : 0);
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlCostChanged);
		}

		// Token: 0x06042189 RID: 270729 RVA: 0x01009F1A File Offset: 0x0100811A
		public int GetDisplayCost()
		{
			return this.ViewCost + this.GetPreviewCost();
		}

		// Token: 0x0604218A RID: 270730 RVA: 0x01009F2C File Offset: 0x0100812C
		private int GetPreviewCost()
		{
			DangoBrawlModel instance = DangoBrawlModel.Instance;
			DangoBrawlTouchController dangoBrawlTouchController = (instance != null) ? instance.GetTouchController() : null;
			if (dangoBrawlTouchController == null)
			{
				return 0;
			}
			IDragVisual dragVisual;
			if ((dragVisual = dangoBrawlTouchController.DraggingVisual) == null)
			{
				InteractionStateMachine interactionFsm = dangoBrawlTouchController.GetInteractionFsm();
				if (interactionFsm == null)
				{
					dragVisual = null;
				}
				else
				{
					InteractionPayload payLoad = interactionFsm.GetPayLoad();
					dragVisual = ((payLoad != null) ? payLoad.Visual : null);
				}
			}
			IDragVisual dragVisual2 = dragVisual;
			if (dragVisual2 == null || (dragVisual2.Source != EDragSourceKind.Shop && dragVisual2.Source != EDragSourceKind.Bench))
			{
				return 0;
			}
			if (DangoBrawlConfig.Instance.GetDangoBrawlItemById(dragVisual2.ConfigId) == null)
			{
				return 0;
			}
			DangoBrawlItem? dangoBrawlItem;
			return dangoBrawlItem.GetValueOrDefault().Cost;
		}

		// Token: 0x0604218B RID: 270731 RVA: 0x01009FBA File Offset: 0x010081BA
		private void OnBagOperated(EBagOpKind kind, int uid)
		{
			if (kind == EBagOpKind.BagToBench || kind == EBagOpKind.BenchToBag)
			{
				this.UpdateViewCost();
			}
		}

		// Token: 0x0604218C RID: 270732 RVA: 0x01009FCA File Offset: 0x010081CA
		private void OnDragBegin(EDragSourceKind source, int configId)
		{
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlCostChanged);
		}

		// Token: 0x0604218D RID: 270733 RVA: 0x01009FDC File Offset: 0x010081DC
		private void OnDragEnd()
		{
			this.UpdateViewCost();
		}

		// Token: 0x0604218E RID: 270734 RVA: 0x01009FE4 File Offset: 0x010081E4
		private void OnInteractionStateChanged(EInteractionState state)
		{
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlCostChanged);
		}

		// Token: 0x0604218F RID: 270735 RVA: 0x01009FF6 File Offset: 0x010081F6
		private void OnDangoBrawlBagUpdated()
		{
			this.UpdateViewCost();
		}

		// Token: 0x06042190 RID: 270736 RVA: 0x01009FFE File Offset: 0x010081FE
		private void OnDangoBrawlShopBought(int slotIndex, int uid, int configId, bool toBench)
		{
			this.UpdateViewCost();
		}

		// Token: 0x06042191 RID: 270737 RVA: 0x0100A006 File Offset: 0x01008206
		private void OnShopSold(int itemUid)
		{
			this.UpdateViewCost();
		}

		// Token: 0x06042192 RID: 270738 RVA: 0x0100A00E File Offset: 0x0100820E
		private void OnShopBench(int mainUid, int uid, int configId, bool toBench, int[] sourceUids, EDragSourceKind[] sourceKinds)
		{
			this.UpdateViewCost();
		}

		// Token: 0x0402268B RID: 140939
		[Nullable(2)]
		private readonly ActivityDangoBrawlData ActivityData;

		// Token: 0x0402268C RID: 140940
		private bool ViewIsInThreeChoose;

		// Token: 0x0402268D RID: 140941
		private bool ViewLayerMode;

		// Token: 0x0402268E RID: 140942
		private int LastEventSelectIndex = -1;

		// Token: 0x0402268F RID: 140943
		private int ViewCost;
	}
}
