using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Views.Backpack
{
	// Token: 0x0200684E RID: 26702
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlPnlBench : UiPanelBase, IDangoBrawlBenchDropZoneExtra, IDangoBrawlItemZone
	{
		// Token: 0x1700975C RID: 38748
		// (get) Token: 0x06042A81 RID: 273025 RVA: 0x01035A05 File Offset: 0x01033C05
		private DangoBrawlTouchController Touch
		{
			get
			{
				return DangoBrawlModel.Instance.GetTouchController();
			}
		}

		// Token: 0x1700975D RID: 38749
		// (get) Token: 0x06042A82 RID: 273026 RVA: 0x01035A11 File Offset: 0x01033C11
		private DangoBrawlItemViewRegistry ViewRegistry
		{
			get
			{
				return DangoBrawlModel.Instance.GetViewRegistry();
			}
		}

		// Token: 0x06042A83 RID: 273027 RVA: 0x01035A20 File Offset: 0x01033C20
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06042A84 RID: 273028 RVA: 0x01035A68 File Offset: 0x01033C68
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlPnlBench.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlPnlBench.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042A85 RID: 273029 RVA: 0x01035AAC File Offset: 0x01033CAC
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlSelectionChanged, new Action(this.OnSelectionChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopComposed, new Action<int, int, int, bool, int[], EDragSourceKind[]>(this.OnShopComposed));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopSold, new Action<int>(this.OnShopSold));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBagOperated, new Action<EBagOpKind, int>(this.OnBagOperated));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBagUpdated, new Action(this.OnBagUpdated));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBackpackModified, new Action<EDangoBrawlModifyType, int>(this.OnBackpackOrBenchModified));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBenchModified, new Action<EDangoBrawlModifyType, int>(this.OnBackpackOrBenchModified));
		}

		// Token: 0x1700975E RID: 38750
		// (get) Token: 0x06042A86 RID: 273030 RVA: 0x01035B7D File Offset: 0x01033D7D
		public UUIItem HitItem
		{
			get
			{
				return base.GetItem(0);
			}
		}

		// Token: 0x06042A87 RID: 273031 RVA: 0x01035B86 File Offset: 0x01033D86
		public void SetBagTemplate(UUIItem template)
		{
			this.BagTemplate = template;
		}

		// Token: 0x06042A88 RID: 273032 RVA: 0x01035B8F File Offset: 0x01033D8F
		public void SetBagItemTemplate(UUIItem template)
		{
			this.BagItemTemplate = template;
		}

		// Token: 0x06042A89 RID: 273033 RVA: 0x01035B98 File Offset: 0x01033D98
		public void SetGridSize(int size)
		{
			this.GridSize = size;
		}

		// Token: 0x06042A8A RID: 273034 RVA: 0x01035BA1 File Offset: 0x01033DA1
		public void SetItemTips(DangoBrawlItemTipsBase tips)
		{
			this.ItemTips = tips;
		}

		// Token: 0x06042A8B RID: 273035 RVA: 0x01035BAA File Offset: 0x01033DAA
		public void SetOffsetY(float offsetY)
		{
			this.ItemTipsOffsetY = offsetY;
		}

		// Token: 0x06042A8C RID: 273036 RVA: 0x01035BB4 File Offset: 0x01033DB4
		public void SetDragOtherVisualState(bool enable, IReadOnlySet<int> excludeUids = null)
		{
			foreach (DangoBrawlPnlBagView dangoBrawlPnlBagView in this.BagPanels.Values)
			{
				if (excludeUids == null || !excludeUids.Contains(dangoBrawlPnlBagView.MyUid))
				{
					dangoBrawlPnlBagView.SetDragOtherVisualState(enable);
				}
			}
			foreach (DangoBrawlPnlBagItemView dangoBrawlPnlBagItemView in this.BagItemPanels.Values)
			{
				if (excludeUids == null || !excludeUids.Contains(dangoBrawlPnlBagItemView.MyUid))
				{
					dangoBrawlPnlBagItemView.SetDragOtherVisualState(enable);
				}
			}
		}

		// Token: 0x06042A8D RID: 273037 RVA: 0x01035C78 File Offset: 0x01033E78
		public void RemoveItemPanel(int uid)
		{
			DangoBrawlPnlBagView dangoBrawlPnlBagView;
			if (!this.BagPanels.TryGetValue(uid, out dangoBrawlPnlBagView))
			{
				DangoBrawlPnlBagItemView dangoBrawlPnlBagItemView;
				if (this.BagItemPanels.TryGetValue(uid, out dangoBrawlPnlBagItemView))
				{
					DangoBrawlItemViewRegistry viewRegistry = this.ViewRegistry;
					if (viewRegistry != null)
					{
						viewRegistry.Unregister(uid);
					}
					dangoBrawlPnlBagItemView.Destroy(null);
					this.BagItemPanels.Remove(uid);
					DangoBrawlModel instance = DangoBrawlModel.Instance;
					if (instance == null)
					{
						return;
					}
					DangoBrawlTouchController touchController = instance.GetTouchController();
					if (touchController == null)
					{
						return;
					}
					touchController.GetContext().ClearSelectionIfMatch(EDragSourceKind.Bench, uid);
				}
				return;
			}
			DangoBrawlItemViewRegistry viewRegistry2 = this.ViewRegistry;
			if (viewRegistry2 != null)
			{
				viewRegistry2.Unregister(uid);
			}
			dangoBrawlPnlBagView.Destroy(null);
			this.BagPanels.Remove(uid);
			DangoBrawlModel instance2 = DangoBrawlModel.Instance;
			if (instance2 == null)
			{
				return;
			}
			DangoBrawlTouchController touchController2 = instance2.GetTouchController();
			if (touchController2 == null)
			{
				return;
			}
			touchController2.GetContext().ClearSelectionIfMatch(EDragSourceKind.Bench, uid);
		}

		// Token: 0x06042A8E RID: 273038 RVA: 0x01035D34 File Offset: 0x01033F34
		private void MoveBenchItem(int uid)
		{
			UUIItem item = base.GetItem(0);
			DangoBrawlBenchData benchData = this.ActData.BenchData;
			DangoBrawlBenchItemData dangoBrawlBenchItemData = (benchData != null) ? benchData.GetItem(uid) : null;
			if (item == null || dangoBrawlBenchItemData == null)
			{
				return;
			}
			DangoBrawlViewItemBase dangoBrawlViewItemBase = this.BagPanels.GetValueOrDefault(uid) ?? this.BagItemPanels.GetValueOrDefault(uid);
			UUIItem uuiitem = (dangoBrawlViewItemBase != null) ? dangoBrawlViewItemBase.GetRootItem() : null;
			if (uuiitem == null || !uuiitem.IsValid())
			{
				return;
			}
			if (uuiitem.GetParentAsUIItem() != item)
			{
				DangoBrawlUtil.ReparentMoveKeepWorld(uuiitem, item);
			}
			if (dangoBrawlViewItemBase != null)
			{
				dangoBrawlViewItemBase.SetDraggableRotation(dangoBrawlBenchItemData.MyRotation);
			}
			if (dangoBrawlBenchItemData.MyDropLguiPos == null)
			{
				this.LayoutBenchItem(uid);
				return;
			}
			this.ApplyDropLguiPos(uuiitem, dangoBrawlBenchItemData);
		}

		// Token: 0x06042A8F RID: 273039 RVA: 0x01035DE0 File Offset: 0x01033FE0
		[NullableContext(1)]
		private void ApplyDropLguiPos(UUIItem itemUi, DangoBrawlBenchItemData itemData)
		{
			UUIItem item = base.GetItem(0);
			if (item == null || !item.IsValid())
			{
				return;
			}
			FVector2D? myDropLguiPos = itemData.MyDropLguiPos;
			if (myDropLguiPos == null)
			{
				return;
			}
			FVector lguispaceAbsolutePosition = item.GetLGUISpaceAbsolutePosition();
			ValueTuple<float, float, float, float> uiBounds = DangoBrawlUtil.GetUiBounds(item);
			float width = itemUi.GetWidth();
			float height = itemUi.GetHeight();
			float num = myDropLguiPos.Value.X;
			float num2 = myDropLguiPos.Value.Y;
			num = Math.Min(num, uiBounds.Item2 - width);
			num = Math.Max(num, uiBounds.Item1);
			num2 = Math.Min(num2, uiBounds.Item3);
			num2 = Math.Max(num2, uiBounds.Item4 + height);
			FVector2D pivot = itemUi.GetPivot();
			float num3 = num + pivot.X * width;
			float num4 = num2 - (1f - pivot.Y) * height;
			float inX = num3 - lguispaceAbsolutePosition.X;
			float inY = num4 - lguispaceAbsolutePosition.Y;
			itemUi.SetUIRelativeLocation(new FVector(inX, inY, 0f));
			itemData.MyDropLguiPos = new FVector2D?(new FVector2D(num, num2));
		}

		// Token: 0x06042A90 RID: 273040 RVA: 0x01035EF4 File Offset: 0x010340F4
		[NullableContext(1)]
		private UniTask RebuildBenchAsync(Dictionary<int, DangoBrawlBenchItemData> newDataMap, HashSet<int> oldUids)
		{
			DangoBrawlPnlBench.<RebuildBenchAsync>d__27 <RebuildBenchAsync>d__;
			<RebuildBenchAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RebuildBenchAsync>d__.<>4__this = this;
			<RebuildBenchAsync>d__.newDataMap = newDataMap;
			<RebuildBenchAsync>d__.oldUids = oldUids;
			<RebuildBenchAsync>d__.<>1__state = -1;
			<RebuildBenchAsync>d__.<>t__builder.Start<DangoBrawlPnlBench.<RebuildBenchAsync>d__27>(ref <RebuildBenchAsync>d__);
			return <RebuildBenchAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042A91 RID: 273041 RVA: 0x01035F48 File Offset: 0x01034148
		private DangoBrawlViewItemBase FindBenchPanel(int uid)
		{
			DangoBrawlPnlBagView result;
			if (this.BagPanels.TryGetValue(uid, out result))
			{
				return result;
			}
			DangoBrawlPnlBagItemView result2;
			if (this.BagItemPanels.TryGetValue(uid, out result2))
			{
				return result2;
			}
			return null;
		}

		// Token: 0x06042A92 RID: 273042 RVA: 0x01035F7C File Offset: 0x0103417C
		[NullableContext(1)]
		private static bool PanelStateChanged(DangoBrawlViewItemBase panel, DangoBrawlBenchItemData newData)
		{
			DangoBrawlBenchItemData dangoBrawlBenchItemData = panel.MyItemData as DangoBrawlBenchItemData;
			return dangoBrawlBenchItemData == null || dangoBrawlBenchItemData.MyConfigId != newData.MyConfigId;
		}

		// Token: 0x06042A93 RID: 273043 RVA: 0x01035FAC File Offset: 0x010341AC
		public void RefreshItemTips(int selectedUid, EDangoBrawlTipsOperationMode operationMode)
		{
			if (selectedUid == -1 || this.ItemTips == null)
			{
				return;
			}
			DangoBrawlViewItemBase dangoBrawlViewItemBase = this.BagPanels.GetValueOrDefault(selectedUid) ?? this.BagItemPanels.GetValueOrDefault(selectedUid);
			if (dangoBrawlViewItemBase == null)
			{
				return;
			}
			DangoBrawlItemTipsData data = new DangoBrawlItemTipsData
			{
				ItemId = dangoBrawlViewItemBase.MyConfigId,
				ItemUid = new int?(selectedUid),
				From = EDangoBrawlItemTipsFrom.Bench,
				GridItem = dangoBrawlViewItemBase.GetRootItem(),
				GridSize = new float?((float)this.GridSize),
				ChangeY = new float?(this.ItemTipsOffsetY),
				ShowCombine = new bool?(true),
				OperationMode = operationMode
			};
			this.ItemTips.RefreshAndShow(data).Forget();
		}

		// Token: 0x06042A94 RID: 273044 RVA: 0x01036060 File Offset: 0x01034260
		private UniTask CreateBenchItemPanels()
		{
			DangoBrawlPnlBench.<CreateBenchItemPanels>d__31 <CreateBenchItemPanels>d__;
			<CreateBenchItemPanels>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBenchItemPanels>d__.<>4__this = this;
			<CreateBenchItemPanels>d__.<>1__state = -1;
			<CreateBenchItemPanels>d__.<>t__builder.Start<DangoBrawlPnlBench.<CreateBenchItemPanels>d__31>(ref <CreateBenchItemPanels>d__);
			return <CreateBenchItemPanels>d__.<>t__builder.Task;
		}

		// Token: 0x06042A95 RID: 273045 RVA: 0x010360A4 File Offset: 0x010342A4
		[NullableContext(1)]
		private UniTask AddItemPanel(DangoBrawlBenchItemData itemData, bool playEnterSeq = true)
		{
			DangoBrawlPnlBench.<AddItemPanel>d__32 <AddItemPanel>d__;
			<AddItemPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AddItemPanel>d__.<>4__this = this;
			<AddItemPanel>d__.itemData = itemData;
			<AddItemPanel>d__.playEnterSeq = playEnterSeq;
			<AddItemPanel>d__.<>1__state = -1;
			<AddItemPanel>d__.<>t__builder.Start<DangoBrawlPnlBench.<AddItemPanel>d__32>(ref <AddItemPanel>d__);
			return <AddItemPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06042A96 RID: 273046 RVA: 0x010360F8 File Offset: 0x010342F8
		[NullableContext(1)]
		private UniTask CreateBagPanel(DangoBrawlBenchItemData itemData, bool playEnterSeq)
		{
			DangoBrawlPnlBench.<CreateBagPanel>d__33 <CreateBagPanel>d__;
			<CreateBagPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBagPanel>d__.<>4__this = this;
			<CreateBagPanel>d__.itemData = itemData;
			<CreateBagPanel>d__.playEnterSeq = playEnterSeq;
			<CreateBagPanel>d__.<>1__state = -1;
			<CreateBagPanel>d__.<>t__builder.Start<DangoBrawlPnlBench.<CreateBagPanel>d__33>(ref <CreateBagPanel>d__);
			return <CreateBagPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06042A97 RID: 273047 RVA: 0x0103614C File Offset: 0x0103434C
		[NullableContext(1)]
		private UniTask CreateBagItemPanel(DangoBrawlBenchItemData itemData, bool playEnterSeq)
		{
			DangoBrawlPnlBench.<CreateBagItemPanel>d__34 <CreateBagItemPanel>d__;
			<CreateBagItemPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBagItemPanel>d__.<>4__this = this;
			<CreateBagItemPanel>d__.itemData = itemData;
			<CreateBagItemPanel>d__.playEnterSeq = playEnterSeq;
			<CreateBagItemPanel>d__.<>1__state = -1;
			<CreateBagItemPanel>d__.<>t__builder.Start<DangoBrawlPnlBench.<CreateBagItemPanel>d__34>(ref <CreateBagItemPanel>d__);
			return <CreateBagItemPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06042A98 RID: 273048 RVA: 0x010361A0 File Offset: 0x010343A0
		public int CalcGridIndex(FVector2D lguiPos)
		{
			UUIItem item = base.GetItem(0);
			ActivityDangoBrawlData actData = this.ActData;
			int? num;
			if (actData == null)
			{
				num = null;
			}
			else
			{
				DangoBrawlBenchData benchData = actData.BenchData;
				num = ((benchData != null) ? new int?(benchData.GetAreaCount()) : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault(1);
			if (item == null || !item.IsValid() || valueOrDefault <= 1)
			{
				return 0;
			}
			ValueTuple<float, float, float, float> uiBounds = DangoBrawlUtil.GetUiBounds(item);
			float num3 = uiBounds.Item2 - uiBounds.Item1;
			if (num3 <= 0f)
			{
				return 0;
			}
			float num4 = (lguiPos.X - uiBounds.Item1) / num3;
			return Math.Max(0, Math.Min(valueOrDefault - 1, (int)Math.Floor((double)(num4 * (float)valueOrDefault))));
		}

		// Token: 0x06042A99 RID: 273049 RVA: 0x01036250 File Offset: 0x01034450
		private int PickLeastLoadedArea(int selfUid, int n)
		{
			if (n <= 1)
			{
				return 0;
			}
			int[] array = new int[n];
			DangoBrawlBenchData benchData = this.ActData.BenchData;
			List<DangoBrawlBenchItemData> list = (benchData != null) ? benchData.GetItemList() : null;
			if (list != null)
			{
				foreach (DangoBrawlBenchItemData dangoBrawlBenchItemData in list)
				{
					if (dangoBrawlBenchItemData.MyUid != selfUid && dangoBrawlBenchItemData.MyDropLguiPos != null)
					{
						FVector2D value = dangoBrawlBenchItemData.MyDropLguiPos.Value;
						DangoBrawlViewItemBase dangoBrawlViewItemBase = this.FindBenchPanel(dangoBrawlBenchItemData.MyUid);
						UUIItem uuiitem = (dangoBrawlViewItemBase != null) ? dangoBrawlViewItemBase.GetRootItem() : null;
						float inX = value.X;
						if (uuiitem != null && uuiitem.IsValid())
						{
							inX = value.X + uuiitem.GetWidth() * 0.5f;
						}
						int num = this.CalcGridIndex(new FVector2D(inX, value.Y));
						if (num >= 0 && num < n)
						{
							array[num]++;
						}
					}
				}
			}
			int num2 = int.MaxValue;
			List<int> list2 = new List<int>();
			for (int i = 0; i < n; i++)
			{
				if (array[i] < num2)
				{
					num2 = array[i];
					list2.Clear();
					list2.Add(i);
				}
				else if (array[i] == num2)
				{
					list2.Add(i);
				}
			}
			return list2[Random.Shared.Next(list2.Count)];
		}

		// Token: 0x06042A9A RID: 273050 RVA: 0x010363D0 File Offset: 0x010345D0
		private void LayoutBenchItem(int uid)
		{
			DangoBrawlBenchData benchData = this.ActData.BenchData;
			DangoBrawlBenchItemData dangoBrawlBenchItemData = (benchData != null) ? benchData.GetItem(uid) : null;
			UUIItem item = base.GetItem(0);
			if (dangoBrawlBenchItemData == null || item == null || !item.IsValid())
			{
				return;
			}
			DangoBrawlPnlBagView dangoBrawlPnlBagView = this.BagPanels.GetValueOrDefault(uid) ?? this.BagItemPanels.GetValueOrDefault(uid);
			UUIItem uuiitem = (dangoBrawlPnlBagView != null) ? dangoBrawlPnlBagView.GetRootItem() : null;
			if (uuiitem == null || !uuiitem.IsValid())
			{
				return;
			}
			DangoBrawlBenchData benchData2 = this.ActData.BenchData;
			int num = (benchData2 != null) ? benchData2.GetAreaCount() : 1;
			ValueTuple<float, float, float, float> uiBounds = DangoBrawlUtil.GetUiBounds(item);
			float num2 = (uiBounds.Item2 - uiBounds.Item1) / (float)num;
			float width = uuiitem.GetWidth();
			float height = uuiitem.GetHeight();
			int num3 = this.PickLeastLoadedArea(uid, num);
			float num4 = uiBounds.Item1 + (float)num3 * num2;
			float inX;
			if (width > num2)
			{
				inX = num4 + num2 * 0.5f - width * 0.5f;
			}
			else
			{
				float num5 = Math.Max(0f, num2 - width);
				inX = num4 + (float)Random.Shared.NextDouble() * num5;
			}
			float num6 = Math.Max(0f, uiBounds.Item3 - uiBounds.Item4 - height);
			float inY = uiBounds.Item4 + height + (float)Random.Shared.NextDouble() * num6;
			dangoBrawlBenchItemData.MyDropLguiPos = new FVector2D?(new FVector2D(inX, inY));
			this.ApplyDropLguiPos(uuiitem, dangoBrawlBenchItemData);
		}

		// Token: 0x06042A9B RID: 273051 RVA: 0x01036538 File Offset: 0x01034738
		[NullableContext(1)]
		private void OnShopComposed(int mainUid, int uid, int configId, bool toBench, int[] sourceUids, EDragSourceKind[] sourceKinds)
		{
			for (int i = 0; i < sourceUids.Length; i++)
			{
				if (((i < sourceKinds.Length) ? sourceKinds[i] : EDragSourceKind.Bag) == EDragSourceKind.Bench)
				{
					this.RemoveItemPanel(sourceUids[i]);
				}
			}
			if (!toBench)
			{
				return;
			}
			DangoBrawlBenchData benchData = this.ActData.BenchData;
			DangoBrawlBenchItemData dangoBrawlBenchItemData = (benchData != null) ? benchData.GetItem(uid) : null;
			if (dangoBrawlBenchItemData == null)
			{
				return;
			}
			this.AddItemPanel(dangoBrawlBenchItemData, true).Forget();
		}

		// Token: 0x06042A9C RID: 273052 RVA: 0x0103659E File Offset: 0x0103479E
		private void OnShopSold(int uid)
		{
			this.RemoveItemPanel(uid);
		}

		// Token: 0x06042A9D RID: 273053 RVA: 0x010365A7 File Offset: 0x010347A7
		private void OnBackpackOrBenchModified(EDangoBrawlModifyType type, int _)
		{
			if (type == EDangoBrawlModifyType.Modify)
			{
				return;
			}
			this.RefreshBagItemGuideLines();
		}

		// Token: 0x06042A9E RID: 273054 RVA: 0x010365B4 File Offset: 0x010347B4
		private void RefreshBagItemGuideLines()
		{
			foreach (DangoBrawlPnlBagItemView dangoBrawlPnlBagItemView in this.BagItemPanels.Values)
			{
				dangoBrawlPnlBagItemView.RebuildCombineGuideLinesIfShowing();
			}
		}

		// Token: 0x06042A9F RID: 273055 RVA: 0x0103660C File Offset: 0x0103480C
		private void OnBagOperated(EBagOpKind kind, int uid)
		{
			if (kind > EBagOpKind.BenchToBag && kind == EBagOpKind.BenchToBench)
			{
				this.MoveBenchItem(uid);
				DangoBrawlViewItemBase dangoBrawlViewItemBase = this.FindBenchPanel(uid);
				if (dangoBrawlViewItemBase == null)
				{
					return;
				}
				dangoBrawlViewItemBase.PlayEnterSequence("BgReturn");
			}
		}

		// Token: 0x06042AA0 RID: 273056 RVA: 0x01036634 File Offset: 0x01034834
		private void OnBagUpdated()
		{
			DangoBrawlBenchData benchData = this.ActData.BenchData;
			Dictionary<int, DangoBrawlBenchItemData> dictionary;
			if (benchData == null)
			{
				dictionary = null;
			}
			else
			{
				dictionary = benchData.GetItemList().ToDictionary((DangoBrawlBenchItemData d) => d.MyUid);
			}
			Dictionary<int, DangoBrawlBenchItemData> dictionary2 = dictionary ?? new Dictionary<int, DangoBrawlBenchItemData>();
			HashSet<int> hashSet = new HashSet<int>();
			hashSet.UnionWith(this.BagPanels.Keys);
			hashSet.UnionWith(this.BagItemPanels.Keys);
			foreach (int num in hashSet)
			{
				if (!dictionary2.ContainsKey(num))
				{
					this.RemoveItemPanel(num);
				}
			}
			foreach (KeyValuePair<int, DangoBrawlBenchItemData> keyValuePair in dictionary2)
			{
				if (hashSet.Contains(keyValuePair.Key))
				{
					DangoBrawlViewItemBase dangoBrawlViewItemBase = this.FindBenchPanel(keyValuePair.Key);
					if (dangoBrawlViewItemBase != null)
					{
						bool flag = DangoBrawlPnlBench.PanelStateChanged(dangoBrawlViewItemBase, keyValuePair.Value);
						dangoBrawlViewItemBase.BindData(this.ActData, keyValuePair.Value, this.GridSize);
						if (flag)
						{
							dangoBrawlViewItemBase.RefreshView();
							keyValuePair.Value.MyDropLguiPos = null;
							this.LayoutBenchItem(keyValuePair.Key);
						}
					}
				}
			}
			this.RebuildBenchAsync(dictionary2, hashSet).Forget();
		}

		// Token: 0x06042AA1 RID: 273057 RVA: 0x010367C0 File Offset: 0x010349C0
		private void OnSelectionChanged()
		{
			DangoBrawlModel instance = DangoBrawlModel.Instance;
			DangoBrawlSelection dangoBrawlSelection;
			if (instance == null)
			{
				dangoBrawlSelection = null;
			}
			else
			{
				DangoBrawlTouchController touchController = instance.GetTouchController();
				dangoBrawlSelection = ((touchController != null) ? touchController.GetContext().GetSelection() : null);
			}
			DangoBrawlSelection dangoBrawlSelection2 = dangoBrawlSelection;
			int num = (dangoBrawlSelection2 != null && dangoBrawlSelection2.Source == EDragSourceKind.Bench) ? dangoBrawlSelection2.Id : -1;
			foreach (DangoBrawlPnlBagView dangoBrawlPnlBagView in this.BagPanels.Values)
			{
				dangoBrawlPnlBagView.SetSelectedVisualState(dangoBrawlPnlBagView.MyUid == num);
			}
			foreach (DangoBrawlPnlBagItemView dangoBrawlPnlBagItemView in this.BagItemPanels.Values)
			{
				dangoBrawlPnlBagItemView.SetSelectedVisualState(dangoBrawlPnlBagItemView.MyUid == num);
			}
		}

		// Token: 0x06042AA2 RID: 273058 RVA: 0x010368A4 File Offset: 0x01034AA4
		[NullableContext(1)]
		public void CollectPanelUids(List<int> result)
		{
			result.AddRange(this.BagPanels.Keys);
			result.AddRange(this.BagItemPanels.Keys);
		}

		// Token: 0x06042AA3 RID: 273059 RVA: 0x010368C8 File Offset: 0x01034AC8
		public DangoBrawlViewItemBase DetachPanel(int uid)
		{
			DangoBrawlViewItemBase dangoBrawlViewItemBase = null;
			DangoBrawlPnlBagView dangoBrawlPnlBagView;
			DangoBrawlPnlBagItemView dangoBrawlPnlBagItemView;
			if (this.BagPanels.TryGetValue(uid, out dangoBrawlPnlBagView))
			{
				dangoBrawlViewItemBase = dangoBrawlPnlBagView;
				this.BagPanels.Remove(uid);
			}
			else if (this.BagItemPanels.TryGetValue(uid, out dangoBrawlPnlBagItemView))
			{
				dangoBrawlViewItemBase = dangoBrawlPnlBagItemView;
				this.BagItemPanels.Remove(uid);
			}
			if (dangoBrawlViewItemBase == null)
			{
				return null;
			}
			DangoBrawlItemViewRegistry viewRegistry = this.ViewRegistry;
			if (viewRegistry != null)
			{
				viewRegistry.Unregister(uid);
			}
			DangoBrawlTouchController touch = this.Touch;
			if (touch != null)
			{
				touch.GetContext().ClearSelectionIfMatch(EDragSourceKind.Bench, uid);
			}
			return dangoBrawlViewItemBase;
		}

		// Token: 0x06042AA4 RID: 273060 RVA: 0x01036948 File Offset: 0x01034B48
		[NullableContext(1)]
		public void AcceptPanel(DangoBrawlViewItemBase panel, DangoBrawlItemBase itemData, bool playEnterSeq = true)
		{
			DangoBrawlBenchItemData dangoBrawlBenchItemData = itemData as DangoBrawlBenchItemData;
			if (dangoBrawlBenchItemData == null)
			{
				return;
			}
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			panel.Migrate(item, EDragSourceKind.Bench, dangoBrawlBenchItemData, this.GridSize);
			DangoBrawlPnlBagView dangoBrawlPnlBagView = panel as DangoBrawlPnlBagView;
			if (dangoBrawlPnlBagView == null)
			{
				DangoBrawlPnlBagItemView dangoBrawlPnlBagItemView = panel as DangoBrawlPnlBagItemView;
				if (dangoBrawlPnlBagItemView != null)
				{
					this.BagItemPanels[dangoBrawlBenchItemData.MyUid] = dangoBrawlPnlBagItemView;
				}
			}
			else
			{
				this.BagPanels[dangoBrawlBenchItemData.MyUid] = dangoBrawlPnlBagView;
			}
			UUIItem rootItem = panel.GetRootItem();
			if (rootItem != null && rootItem.IsValid())
			{
				if (dangoBrawlBenchItemData.MyDropLguiPos != null)
				{
					this.ApplyDropLguiPos(rootItem, dangoBrawlBenchItemData);
				}
				else
				{
					this.LayoutBenchItem(dangoBrawlBenchItemData.MyUid);
				}
			}
			DangoBrawlItemViewRegistry viewRegistry = DangoBrawlModel.Instance.GetViewRegistry();
			if (viewRegistry != null)
			{
				viewRegistry.Register(dangoBrawlBenchItemData.MyUid, panel);
			}
			ICombineLineOwner combineLineOwner = panel as ICombineLineOwner;
			if (combineLineOwner != null)
			{
				DangoBrawlItemViewRegistry viewRegistry2 = DangoBrawlModel.Instance.GetViewRegistry();
				if (viewRegistry2 != null)
				{
					viewRegistry2.RegisterLineOwner(dangoBrawlBenchItemData.MyUid, combineLineOwner);
				}
			}
			if (playEnterSeq)
			{
				panel.PlayEnterSequence("BgReturn");
			}
		}

		// Token: 0x06042AA5 RID: 273061 RVA: 0x01036A48 File Offset: 0x01034C48
		public bool TryRefreshPanel(int uid)
		{
			DangoBrawlViewItemBase dangoBrawlViewItemBase = this.BagPanels.GetValueOrDefault(uid) ?? this.BagItemPanels.GetValueOrDefault(uid);
			if (dangoBrawlViewItemBase == null)
			{
				return false;
			}
			this.MoveBenchItem(uid);
			dangoBrawlViewItemBase.RefreshView();
			return true;
		}

		// Token: 0x06042AA6 RID: 273062 RVA: 0x01036A88 File Offset: 0x01034C88
		public void FallbackAddItemPanel(int uid, bool playEnterSeq = true)
		{
			DangoBrawlBenchData benchData = this.ActData.BenchData;
			DangoBrawlBenchItemData dangoBrawlBenchItemData = (benchData != null) ? benchData.GetItem(uid) : null;
			if (dangoBrawlBenchItemData != null)
			{
				this.AddItemPanel(dangoBrawlBenchItemData, playEnterSeq).Forget();
			}
		}

		// Token: 0x04022B68 RID: 142184
		[Nullable(1)]
		public ActivityDangoBrawlData ActData;

		// Token: 0x04022B69 RID: 142185
		[Nullable(1)]
		private readonly Dictionary<int, DangoBrawlPnlBagView> BagPanels = new Dictionary<int, DangoBrawlPnlBagView>();

		// Token: 0x04022B6A RID: 142186
		[Nullable(1)]
		private readonly Dictionary<int, DangoBrawlPnlBagItemView> BagItemPanels = new Dictionary<int, DangoBrawlPnlBagItemView>();

		// Token: 0x04022B6B RID: 142187
		private int GridSize;

		// Token: 0x04022B6C RID: 142188
		private float ItemTipsOffsetY;

		// Token: 0x04022B6D RID: 142189
		private DangoBrawlItemTipsBase ItemTips;

		// Token: 0x04022B6E RID: 142190
		private UUIItem BagTemplate;

		// Token: 0x04022B6F RID: 142191
		private UUIItem BagItemTemplate;

		// Token: 0x0200CA16 RID: 51734
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403D11D RID: 250141
			PnlContent
		}
	}
}
