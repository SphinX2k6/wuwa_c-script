using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200552A RID: 21802
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardInteractViewModel : IDockyardBackpackInterface, IDockyardConfirmProvider
	{
		// Token: 0x06036101 RID: 221441 RVA: 0x00F17D80 File Offset: 0x00F15F80
		public void RegisterView(DockyardInteractView view)
		{
			this.View = view;
			this.BackpackPanelModel.ConfigId = this.ConfigId;
			this.BackpackPanelModel.RegisterViewModel(this);
			this.InteractPanelModel.ConfigId = this.ConfigId;
			this.InteractPanelModel.RegisterViewModel(this);
			this.BackpackPanelModel.RegisterInteractPanel(this.InteractPanelModel);
			this.InteractPanelModel.RegisterBackpackPanel(this.BackpackPanelModel);
		}

		// Token: 0x06036102 RID: 221442 RVA: 0x00F17DF0 File Offset: 0x00F15FF0
		public bool IsTrawlInteractive()
		{
			return false;
		}

		// Token: 0x06036103 RID: 221443 RVA: 0x00F17DF3 File Offset: 0x00F15FF3
		public void SetInSelectState(bool isInSelectState)
		{
			if (!isInSelectState)
			{
				DockyardInteractView view = this.View;
				if (view == null)
				{
					return;
				}
				view.HideTipsPanel();
			}
		}

		// Token: 0x06036104 RID: 221444 RVA: 0x00F17E08 File Offset: 0x00F16008
		public void NotifyItemBlockToWareHouse(DockyardItemBlockOriginalData data)
		{
		}

		// Token: 0x06036105 RID: 221445 RVA: 0x00F17E0A File Offset: 0x00F1600A
		[NullableContext(2)]
		public UUIItem GetQuicklySellPanelParentItem()
		{
			return null;
		}

		// Token: 0x06036106 RID: 221446 RVA: 0x00F17E0D File Offset: 0x00F1600D
		public void NotifyQuicklySellActive(bool isActive)
		{
		}

		// Token: 0x06036107 RID: 221447 RVA: 0x00F17E0F File Offset: 0x00F1600F
		[NullableContext(0)]
		public UniTask<bool> TrySetSelectedItemBlockToWareHouse()
		{
			return UniTask.FromResult<bool>(false);
		}

		// Token: 0x06036108 RID: 221448 RVA: 0x00F17E17 File Offset: 0x00F16017
		[NullableContext(0)]
		public UniTask<bool> TrySetSelectedItemBlockToBackpack()
		{
			return UniTask.FromResult<bool>(false);
		}

		// Token: 0x06036109 RID: 221449 RVA: 0x00F17E1F File Offset: 0x00F1601F
		public void CloseClick()
		{
			if (this.BackpackPanelModel.IsInSelectState)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_SelectingQuit", Array.Empty<object>());
				return;
			}
			DockyardInteractView view = this.View;
			if (view == null)
			{
				return;
			}
			view.CloseMe(null);
		}

		// Token: 0x0603610A RID: 221450 RVA: 0x00F17E54 File Offset: 0x00F16054
		public bool CheckCurrencyItemClick(int itemId)
		{
			return false;
		}

		// Token: 0x0603610B RID: 221451 RVA: 0x00F17E57 File Offset: 0x00F16057
		public bool CheckCurrencyItemClick()
		{
			if (this.BackpackPanelModel.IsInSelectState)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_SelectingQuit", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x0603610C RID: 221452 RVA: 0x00F17E7D File Offset: 0x00F1607D
		public void ItemBlockClick(int id)
		{
			DockyardInteractView view = this.View;
			if (view == null)
			{
				return;
			}
			view.ShowTipsPanel(id);
		}

		// Token: 0x0603610D RID: 221453 RVA: 0x00F17E90 File Offset: 0x00F16090
		public void DeleteClick()
		{
			List<FishingItemInfo> leftPanelItemBlockDataListExcludeSelected = this.GetLeftPanelItemBlockDataListExcludeSelected();
			List<FishingItemInfo> itemBlockDataListExcludeSelected = this.BackpackPanelModel.Panel.GetItemBlockDataListExcludeSelected();
			RequestHandleIn requestData = new RequestHandleIn
			{
				InteractId = this.ConfigId,
				LeftDataList = leftPanelItemBlockDataListExcludeSelected,
				RightDataList = itemBlockDataListExcludeSelected,
				ActionIncId = this.ActionIncId,
				RemoveIncId = new int?(this.BackpackPanelModel.InSelectedBlockId),
				Callback = delegate(bool isSuccess, bool _)
				{
					if (isSuccess)
					{
						this.BackpackPanelModel.Panel.DestroySelectItemBlock();
					}
				}
			};
			FishingController.Instance.RequestFishingHandIn(requestData);
		}

		// Token: 0x0603610E RID: 221454 RVA: 0x00F17F14 File Offset: 0x00F16114
		public void RotateClick()
		{
			if (!this.BackpackPanelModel.IsOutOfRange)
			{
				this.BackpackPanelModel.Panel.RotateClick();
				return;
			}
			if (!this.InteractPanelModel.IsOutOfRange)
			{
				this.InteractPanelModel.Panel.RotateClick();
			}
		}

		// Token: 0x0603610F RID: 221455 RVA: 0x00F17F54 File Offset: 0x00F16154
		public void ConfirmClick()
		{
			if (this.TempPanelModel == null)
			{
				return;
			}
			DockyardInteractBackpackPanelModel dockyardInteractBackpackPanelModel = this.TempPanelModel as DockyardInteractBackpackPanelModel;
			if (dockyardInteractBackpackPanelModel != null)
			{
				if (!dockyardInteractBackpackPanelModel.CanConfirm())
				{
					dockyardInteractBackpackPanelModel.ShowScrollingTips();
					return;
				}
			}
			else
			{
				DockyardInteractPanelModel dockyardInteractPanelModel = this.TempPanelModel as DockyardInteractPanelModel;
				if (dockyardInteractPanelModel != null && !dockyardInteractPanelModel.CanConfirm())
				{
					dockyardInteractPanelModel.ShowScrollingTips();
					return;
				}
			}
			DockyardInteractBackpackPanelModel dockyardInteractBackpackPanelModel2 = this.TempPanelModel as DockyardInteractBackpackPanelModel;
			if (dockyardInteractBackpackPanelModel2 != null && dockyardInteractBackpackPanelModel2.IsOverlap())
			{
				dockyardInteractBackpackPanelModel2.Panel.HandleOverlapConfirm();
				return;
			}
			DockyardInteractPanelModel dockyardInteractPanelModel2 = this.TempPanelModel as DockyardInteractPanelModel;
			if (dockyardInteractPanelModel2 != null && dockyardInteractPanelModel2.IsOverlap())
			{
				dockyardInteractPanelModel2.Panel.HandleOverlapConfirm();
				return;
			}
			List<FishingItemInfo> leftPanelItemBlockDataList = this.GetLeftPanelItemBlockDataList();
			List<FishingItemInfo> rightPanelItemBlockDataList = this.GetRightPanelItemBlockDataList();
			RequestHandleIn requestData = new RequestHandleIn
			{
				InteractId = this.ConfigId,
				LeftDataList = leftPanelItemBlockDataList,
				RightDataList = rightPanelItemBlockDataList,
				ActionIncId = this.ActionIncId,
				Callback = delegate(bool isSuccess, bool isComplete)
				{
					this.IsComplete = isComplete;
					if (isSuccess)
					{
						DockyardInteractBackpackPanelModel dockyardInteractBackpackPanelModel3 = this.TempPanelModel as DockyardInteractBackpackPanelModel;
						if (dockyardInteractBackpackPanelModel3 != null)
						{
							dockyardInteractBackpackPanelModel3.Panel.HandleFinishConfirm();
						}
						else
						{
							DockyardInteractPanelModel dockyardInteractPanelModel3 = this.TempPanelModel as DockyardInteractPanelModel;
							if (dockyardInteractPanelModel3 != null)
							{
								dockyardInteractPanelModel3.Panel.HandleFinishConfirm();
							}
						}
					}
					if (isComplete)
					{
						DockyardInteractView view = this.View;
						if (view == null)
						{
							return;
						}
						view.OpenInteractFinishTipsView();
					}
				}
			};
			FishingController.Instance.RequestFishingHandIn(requestData);
		}

		// Token: 0x06036110 RID: 221456 RVA: 0x00F18049 File Offset: 0x00F16249
		public void TrawlClick(bool isSelected)
		{
		}

		// Token: 0x06036111 RID: 221457 RVA: 0x00F1804B File Offset: 0x00F1624B
		public void AllSellClick()
		{
		}

		// Token: 0x06036112 RID: 221458 RVA: 0x00F1804D File Offset: 0x00F1624D
		public void HandleDragBegin()
		{
			if (this.InteractPanelModel.LastCanTickState)
			{
				this.TempPanelModel = this.InteractPanelModel;
				return;
			}
			if (!this.BackpackPanelModel.IsOutOfRange)
			{
				this.TempPanelModel = this.BackpackPanelModel;
			}
		}

		// Token: 0x06036113 RID: 221459 RVA: 0x00F18084 File Offset: 0x00F16284
		public void HandleDragResult()
		{
			if (!this.BackpackPanelModel.IsOutOfRange)
			{
				this.TempPanelModel = this.BackpackPanelModel;
				this.BackpackPanelModel.Panel.HandleDragSuccess();
				return;
			}
			if (!this.InteractPanelModel.IsOutOfRange)
			{
				this.TempPanelModel = this.InteractPanelModel;
				this.InteractPanelModel.Panel.HandleDragSuccess();
				return;
			}
			if (this.InteractPanelModel.LastCanTickState)
			{
				this.TempPanelModel = this.InteractPanelModel;
				this.InteractPanelModel.Panel.HandleDragFail();
				return;
			}
			DockyardInteractBackpackPanelModel dockyardInteractBackpackPanelModel = this.TempPanelModel as DockyardInteractBackpackPanelModel;
			if (dockyardInteractBackpackPanelModel != null)
			{
				dockyardInteractBackpackPanelModel.Panel.HandleDragFail();
				return;
			}
			DockyardInteractPanelModel dockyardInteractPanelModel = this.TempPanelModel as DockyardInteractPanelModel;
			if (dockyardInteractPanelModel != null)
			{
				dockyardInteractPanelModel.Panel.HandleDragFail();
			}
		}

		// Token: 0x06036114 RID: 221460 RVA: 0x00F18144 File Offset: 0x00F16344
		public void BackpackTick(float deltaTime)
		{
			this.InteractPanelModel.Tick(deltaTime);
			this.BackpackPanelModel.Tick();
		}

		// Token: 0x06036115 RID: 221461 RVA: 0x00F1815D File Offset: 0x00F1635D
		public bool IsConfirmInteractive()
		{
			return this.InteractPanelModel.CanConfirm() || !this.BackpackPanelModel.IsSetFail;
		}

		// Token: 0x06036116 RID: 221462 RVA: 0x00F1817C File Offset: 0x00F1637C
		public bool IsConfirmNiagaraActive()
		{
			return this.InteractPanelModel.CanConfirm() || this.BackpackPanelModel.IsInCanConfirm;
		}

		// Token: 0x06036117 RID: 221463 RVA: 0x00F18198 File Offset: 0x00F16398
		public DockyardItemBlockOriginalData GetItemBlockDataByIncId(int incId)
		{
			return this.BackpackPanelModel.Panel.GetOriginalItemBlockDataByIncId(incId);
		}

		// Token: 0x06036118 RID: 221464 RVA: 0x00F181AC File Offset: 0x00F163AC
		private List<FishingItemInfo> GetLeftPanelItemBlockDataList()
		{
			List<FishingItemInfo> list = new List<FishingItemInfo>();
			foreach (DockyardInteractItemBlockData dockyardInteractItemBlockData in this.InteractPanelModel.ShowItemMap.Values)
			{
				FishingItemInfo item = DockyardPanelUtil.CreateFishingItemInfo(dockyardInteractItemBlockData.Data, (FishingItemRotate)dockyardInteractItemBlockData.Rotate, dockyardInteractItemBlockData.Pos);
				list.Add(item);
			}
			DockyardInteractPanelModel dockyardInteractPanelModel = this.TempPanelModel as DockyardInteractPanelModel;
			if (dockyardInteractPanelModel != null)
			{
				DockyardItemBlockData data = this.BackpackPanelModel.Panel.InSelectItemBlock.GetData();
				IPanelPos leftTopPanelPos = dockyardInteractPanelModel.Panel.GetLeftTopPanelPos(data.Data.ItemId);
				FishingItemInfo item2 = DockyardPanelUtil.CreateFishingItemInfo(data.Data, data.Rotate, leftTopPanelPos);
				list.Add(item2);
			}
			return list;
		}

		// Token: 0x06036119 RID: 221465 RVA: 0x00F18288 File Offset: 0x00F16488
		private List<FishingItemInfo> GetRightPanelItemBlockDataList()
		{
			List<FishingItemInfo> itemBlockDataList = this.BackpackPanelModel.Panel.GetItemBlockDataList();
			if (this.TempPanelModel is DockyardInteractPanelModel)
			{
				for (int i = 0; i < itemBlockDataList.Count; i++)
				{
					if (itemBlockDataList[i].IncrId == this.BackpackPanelModel.InSelectedBlockId)
					{
						itemBlockDataList.RemoveAt(i);
						break;
					}
				}
			}
			return itemBlockDataList;
		}

		// Token: 0x0603611A RID: 221466 RVA: 0x00F182E8 File Offset: 0x00F164E8
		private List<FishingItemInfo> GetLeftPanelItemBlockDataListExcludeSelected()
		{
			List<FishingItemInfo> list = new List<FishingItemInfo>();
			foreach (DockyardInteractItemBlockData dockyardInteractItemBlockData in this.InteractPanelModel.ShowItemMap.Values)
			{
				if (dockyardInteractItemBlockData.Data.IncId != this.BackpackPanelModel.InSelectedBlockId)
				{
					FishingItemInfo item = DockyardPanelUtil.CreateFishingItemInfo(dockyardInteractItemBlockData.Data, (FishingItemRotate)dockyardInteractItemBlockData.Rotate, dockyardInteractItemBlockData.Pos);
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x0401C8CB RID: 116939
		[Nullable(2)]
		private DockyardInteractView View;

		// Token: 0x0401C8CC RID: 116940
		public int ConfigId = -1;

		// Token: 0x0401C8CD RID: 116941
		public int ActionIncId = -1;

		// Token: 0x0401C8CE RID: 116942
		public bool IsComplete;

		// Token: 0x0401C8CF RID: 116943
		public readonly DockyardInteractBackpackPanelModel BackpackPanelModel = new DockyardInteractBackpackPanelModel();

		// Token: 0x0401C8D0 RID: 116944
		public readonly DockyardInteractPanelModel InteractPanelModel = new DockyardInteractPanelModel();

		// Token: 0x0401C8D1 RID: 116945
		[Nullable(2)]
		private object TempPanelModel;
	}
}
