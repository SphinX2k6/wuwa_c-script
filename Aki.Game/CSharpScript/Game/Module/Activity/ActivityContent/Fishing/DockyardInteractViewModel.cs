using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065AC RID: 26028
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardInteractViewModel : IDockyardBackpackInterface, IDockyardConfirmProvider
	{
		// Token: 0x0604143C RID: 267324 RVA: 0x00FD0D7C File Offset: 0x00FCEF7C
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

		// Token: 0x0604143D RID: 267325 RVA: 0x00FD0DEC File Offset: 0x00FCEFEC
		public bool IsTrawlInteractive()
		{
			return false;
		}

		// Token: 0x0604143E RID: 267326 RVA: 0x00FD0DEF File Offset: 0x00FCEFEF
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

		// Token: 0x0604143F RID: 267327 RVA: 0x00FD0E04 File Offset: 0x00FCF004
		public void NotifyItemBlockToWareHouse(DockyardItemBlockOriginalData data)
		{
		}

		// Token: 0x06041440 RID: 267328 RVA: 0x00FD0E06 File Offset: 0x00FCF006
		[NullableContext(2)]
		public UUIItem GetQuicklySellPanelParentItem()
		{
			return null;
		}

		// Token: 0x06041441 RID: 267329 RVA: 0x00FD0E09 File Offset: 0x00FCF009
		public void NotifyQuicklySellActive(bool isActive)
		{
		}

		// Token: 0x06041442 RID: 267330 RVA: 0x00FD0E0B File Offset: 0x00FCF00B
		[NullableContext(0)]
		public UniTask<bool> TrySetSelectedItemBlockToWareHouse()
		{
			return UniTask.FromResult<bool>(false);
		}

		// Token: 0x06041443 RID: 267331 RVA: 0x00FD0E13 File Offset: 0x00FCF013
		[NullableContext(0)]
		public UniTask<bool> TrySetSelectedItemBlockToBackpack()
		{
			return UniTask.FromResult<bool>(false);
		}

		// Token: 0x06041444 RID: 267332 RVA: 0x00FD0E1B File Offset: 0x00FCF01B
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

		// Token: 0x06041445 RID: 267333 RVA: 0x00FD0E50 File Offset: 0x00FCF050
		public bool CheckCurrencyItemClick(int itemId)
		{
			return false;
		}

		// Token: 0x06041446 RID: 267334 RVA: 0x00FD0E53 File Offset: 0x00FCF053
		public bool CheckCurrencyItemClick()
		{
			if (this.BackpackPanelModel.IsInSelectState)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_SelectingQuit", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x06041447 RID: 267335 RVA: 0x00FD0E79 File Offset: 0x00FCF079
		public void ItemBlockClick(int id)
		{
			DockyardInteractView view = this.View;
			if (view == null)
			{
				return;
			}
			view.ShowTipsPanel(id);
		}

		// Token: 0x06041448 RID: 267336 RVA: 0x00FD0E8C File Offset: 0x00FCF08C
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

		// Token: 0x06041449 RID: 267337 RVA: 0x00FD0F10 File Offset: 0x00FCF110
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

		// Token: 0x0604144A RID: 267338 RVA: 0x00FD0F50 File Offset: 0x00FCF150
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

		// Token: 0x0604144B RID: 267339 RVA: 0x00FD1045 File Offset: 0x00FCF245
		public void TrawlClick(bool isSelected)
		{
		}

		// Token: 0x0604144C RID: 267340 RVA: 0x00FD1047 File Offset: 0x00FCF247
		public void AllSellClick()
		{
		}

		// Token: 0x0604144D RID: 267341 RVA: 0x00FD1049 File Offset: 0x00FCF249
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

		// Token: 0x0604144E RID: 267342 RVA: 0x00FD1080 File Offset: 0x00FCF280
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

		// Token: 0x0604144F RID: 267343 RVA: 0x00FD1140 File Offset: 0x00FCF340
		public void BackpackTick(float deltaTime)
		{
			this.InteractPanelModel.Tick(deltaTime);
			this.BackpackPanelModel.Tick();
		}

		// Token: 0x06041450 RID: 267344 RVA: 0x00FD1159 File Offset: 0x00FCF359
		public bool IsConfirmInteractive()
		{
			return this.InteractPanelModel.CanConfirm() || !this.BackpackPanelModel.IsSetFail;
		}

		// Token: 0x06041451 RID: 267345 RVA: 0x00FD1178 File Offset: 0x00FCF378
		public bool IsConfirmNiagaraActive()
		{
			return this.InteractPanelModel.CanConfirm() || this.BackpackPanelModel.IsInCanConfirm;
		}

		// Token: 0x06041452 RID: 267346 RVA: 0x00FD1194 File Offset: 0x00FCF394
		public DockyardItemBlockOriginalData GetItemBlockDataByIncId(int incId)
		{
			return this.BackpackPanelModel.Panel.GetOriginalItemBlockDataByIncId(incId);
		}

		// Token: 0x06041453 RID: 267347 RVA: 0x00FD11A8 File Offset: 0x00FCF3A8
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

		// Token: 0x06041454 RID: 267348 RVA: 0x00FD1284 File Offset: 0x00FCF484
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

		// Token: 0x06041455 RID: 267349 RVA: 0x00FD12E4 File Offset: 0x00FCF4E4
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

		// Token: 0x04021F9A RID: 139162
		[Nullable(2)]
		private DockyardInteractView View;

		// Token: 0x04021F9B RID: 139163
		public int ConfigId = -1;

		// Token: 0x04021F9C RID: 139164
		public int ActionIncId = -1;

		// Token: 0x04021F9D RID: 139165
		public bool IsComplete;

		// Token: 0x04021F9E RID: 139166
		public readonly DockyardInteractBackpackPanelModel BackpackPanelModel = new DockyardInteractBackpackPanelModel();

		// Token: 0x04021F9F RID: 139167
		public readonly DockyardInteractPanelModel InteractPanelModel = new DockyardInteractPanelModel();

		// Token: 0x04021FA0 RID: 139168
		[Nullable(2)]
		private object TempPanelModel;
	}
}
