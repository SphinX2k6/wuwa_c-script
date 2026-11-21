using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056AB RID: 22187
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlDataController
	{
		// Token: 0x06036CD4 RID: 224468 RVA: 0x00F4B0A1 File Offset: 0x00F492A1
		public DangoBrawlDataController(ActivityDangoBrawlData data)
		{
			this.ActivityData = data;
		}

		// Token: 0x06036CD5 RID: 224469 RVA: 0x00F4B0B8 File Offset: 0x00F492B8
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

		// Token: 0x06036CD6 RID: 224470 RVA: 0x00F4B1AC File Offset: 0x00F493AC
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

		// Token: 0x06036CD7 RID: 224471 RVA: 0x00F4B299 File Offset: 0x00F49499
		public void SetViewIsInThreeChoose(bool value)
		{
			this.ViewIsInThreeChoose = value;
		}

		// Token: 0x06036CD8 RID: 224472 RVA: 0x00F4B2A2 File Offset: 0x00F494A2
		public bool GetViewIsInThreeChoose()
		{
			return this.ViewIsInThreeChoose;
		}

		// Token: 0x06036CD9 RID: 224473 RVA: 0x00F4B2AA File Offset: 0x00F494AA
		public void SetViewLayerMode(bool value)
		{
			this.ViewLayerMode = value;
		}

		// Token: 0x06036CDA RID: 224474 RVA: 0x00F4B2B3 File Offset: 0x00F494B3
		public bool GetViewLayerMode()
		{
			return this.ViewLayerMode;
		}

		// Token: 0x06036CDB RID: 224475 RVA: 0x00F4B2BB File Offset: 0x00F494BB
		public void SetLastEventSelectIndex(int index)
		{
			this.LastEventSelectIndex = index;
		}

		// Token: 0x06036CDC RID: 224476 RVA: 0x00F4B2C4 File Offset: 0x00F494C4
		public int GetLastEventSelectIndex()
		{
			return this.LastEventSelectIndex;
		}

		// Token: 0x06036CDD RID: 224477 RVA: 0x00F4B2CC File Offset: 0x00F494CC
		public int GetViewCost()
		{
			return this.ViewCost;
		}

		// Token: 0x06036CDE RID: 224478 RVA: 0x00F4B2D4 File Offset: 0x00F494D4
		public void UpdateViewCost()
		{
			ActivityDangoBrawlData activityData = this.ActivityData;
			this.ViewCost = ((activityData != null) ? activityData.GetBagWeight() : 0);
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlCostChanged);
		}

		// Token: 0x06036CDF RID: 224479 RVA: 0x00F4B2FE File Offset: 0x00F494FE
		public int GetDisplayCost()
		{
			return this.ViewCost + this.GetPreviewCost();
		}

		// Token: 0x06036CE0 RID: 224480 RVA: 0x00F4B310 File Offset: 0x00F49510
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

		// Token: 0x06036CE1 RID: 224481 RVA: 0x00F4B39E File Offset: 0x00F4959E
		private void OnBagOperated(EBagOpKind kind, int uid)
		{
			if (kind == EBagOpKind.BagToBench || kind == EBagOpKind.BenchToBag)
			{
				this.UpdateViewCost();
			}
		}

		// Token: 0x06036CE2 RID: 224482 RVA: 0x00F4B3AE File Offset: 0x00F495AE
		private void OnDragBegin(EDragSourceKind source, int configId)
		{
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlCostChanged);
		}

		// Token: 0x06036CE3 RID: 224483 RVA: 0x00F4B3C0 File Offset: 0x00F495C0
		private void OnDragEnd()
		{
			this.UpdateViewCost();
		}

		// Token: 0x06036CE4 RID: 224484 RVA: 0x00F4B3C8 File Offset: 0x00F495C8
		private void OnInteractionStateChanged(EInteractionState state)
		{
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlCostChanged);
		}

		// Token: 0x06036CE5 RID: 224485 RVA: 0x00F4B3DA File Offset: 0x00F495DA
		private void OnDangoBrawlBagUpdated()
		{
			this.UpdateViewCost();
		}

		// Token: 0x06036CE6 RID: 224486 RVA: 0x00F4B3E2 File Offset: 0x00F495E2
		private void OnDangoBrawlShopBought(int slotIndex, int uid, int configId, bool toBench)
		{
			this.UpdateViewCost();
		}

		// Token: 0x06036CE7 RID: 224487 RVA: 0x00F4B3EA File Offset: 0x00F495EA
		private void OnShopSold(int itemUid)
		{
			this.UpdateViewCost();
		}

		// Token: 0x06036CE8 RID: 224488 RVA: 0x00F4B3F2 File Offset: 0x00F495F2
		private void OnShopBench(int mainUid, int uid, int configId, bool toBench, int[] sourceUids, EDragSourceKind[] sourceKinds)
		{
			this.UpdateViewCost();
		}

		// Token: 0x0401CEE8 RID: 118504
		[Nullable(2)]
		private readonly ActivityDangoBrawlData ActivityData;

		// Token: 0x0401CEE9 RID: 118505
		private bool ViewIsInThreeChoose;

		// Token: 0x0401CEEA RID: 118506
		private bool ViewLayerMode;

		// Token: 0x0401CEEB RID: 118507
		private int LastEventSelectIndex = -1;

		// Token: 0x0401CEEC RID: 118508
		private int ViewCost;
	}
}
