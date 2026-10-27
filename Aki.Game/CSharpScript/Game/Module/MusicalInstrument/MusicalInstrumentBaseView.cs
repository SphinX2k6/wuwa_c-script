using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x0200536F RID: 21359
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class MusicalInstrumentBaseView : UiViewBase
	{
		// Token: 0x06036926 RID: 223526 RVA: 0x00CEC623 File Offset: 0x00CEA823
		[NullableContext(1)]
		protected MusicalInstrumentBaseView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036927 RID: 223527
		protected abstract EInstrumentType GetMusicalInstrumentType();

		// Token: 0x06036928 RID: 223528 RVA: 0x00CEC637 File Offset: 0x00CEA837
		protected virtual void OnQtePerformance(int rowIndex, int columnIndex, bool success)
		{
		}

		// Token: 0x06036929 RID: 223529 RVA: 0x00CEC63C File Offset: 0x00CEA83C
		protected MusicalInstrumentKeyItem GetKeyItem(int rowIndex, int columnIndex)
		{
			if (rowIndex < 0 || rowIndex >= this.KeyItems.Count)
			{
				return null;
			}
			List<MusicalInstrumentKeyItem> list = this.KeyItems[rowIndex];
			if (columnIndex < 0 || columnIndex >= list.Count)
			{
				return null;
			}
			return list[columnIndex];
		}

		// Token: 0x0603692A RID: 223530 RVA: 0x00CEC680 File Offset: 0x00CEA880
		protected void FocusCurrentQte()
		{
			MusicalInstrumentSubModel subModel = this.GetSubModel();
			List<MusicalInstrumentQteItemData> list;
			if (subModel == null)
			{
				list = null;
			}
			else
			{
				MusicalInstrumentQteData qteData = subModel.GetQteData();
				list = ((qteData != null) ? qteData.ItemDataList : null);
			}
			List<MusicalInstrumentQteItemData> list2 = list;
			if (list2 == null || this.QteCurrentIndex < 0 || this.QteCurrentIndex >= list2.Count)
			{
				return;
			}
			MusicalInstrumentQteItemData musicalInstrumentQteItemData = list2[this.QteCurrentIndex];
			MusicalInstrumentKeyItem keyItem = this.GetKeyItem(musicalInstrumentQteItemData.RowIndex, musicalInstrumentQteItemData.ColumnIndex);
			if (keyItem == null)
			{
				return;
			}
			keyItem.OnQteFocus(true);
		}

		// Token: 0x0603692B RID: 223531 RVA: 0x00CEC6F1 File Offset: 0x00CEA8F1
		protected virtual MusicalInstrumentSubModel GetSubModel()
		{
			return MusicalInstrumentModel.Instance.GetSubModel(this.GetMusicalInstrumentType());
		}

		// Token: 0x0603692C RID: 223532 RVA: 0x00CEC703 File Offset: 0x00CEA903
		protected MusicalInstrumentSubController GetSubController()
		{
			return MusicalInstrumentController.Instance.GetSubController(this.GetMusicalInstrumentType());
		}

		// Token: 0x0603692D RID: 223533 RVA: 0x00CEC715 File Offset: 0x00CEA915
		protected void OnKeyItemPointerDown(int rowIndex, int columnIndex)
		{
			MusicalInstrumentSubModel subModel = this.GetSubModel();
			if (((subModel != null) ? subModel.GetQteData() : null) != null)
			{
				this.CheckQteSuccess(rowIndex, columnIndex);
				return;
			}
			this.PostAudioEventByIndex(rowIndex, columnIndex);
		}

		// Token: 0x0603692E RID: 223534
		protected abstract void PostAudioEventByIndex(int rowIndex, int columnIndex);

		// Token: 0x0603692F RID: 223535 RVA: 0x00CEC73C File Offset: 0x00CEA93C
		protected void CheckQteSuccess(int rowIndex, int columnIndex)
		{
			MusicalInstrumentSubModel subModel = this.GetSubModel();
			MusicalInstrumentQteData musicalInstrumentQteData = (subModel != null) ? subModel.GetQteData() : null;
			if (musicalInstrumentQteData == null)
			{
				return;
			}
			List<MusicalInstrumentQteItemData> itemDataList = musicalInstrumentQteData.ItemDataList;
			if (this.QteCurrentIndex >= itemDataList.Count)
			{
				return;
			}
			MusicalInstrumentQteItemData musicalInstrumentQteItemData = musicalInstrumentQteData.ItemDataList[this.QteCurrentIndex];
			if (rowIndex != musicalInstrumentQteItemData.RowIndex || columnIndex != musicalInstrumentQteItemData.ColumnIndex)
			{
				MusicalInstrumentKeyItem keyItem = this.GetKeyItem(rowIndex, columnIndex);
				if (keyItem != null)
				{
					keyItem.OnQtePerformance(false);
				}
				this.OnQtePerformance(rowIndex, columnIndex, false);
				return;
			}
			musicalInstrumentQteItemData.Finished = true;
			musicalInstrumentQteItemData.IsFocus = false;
			MusicalInstrumentKeyItem keyItem2 = this.GetKeyItem(rowIndex, columnIndex);
			if (keyItem2 != null)
			{
				keyItem2.OnQteFocus(false);
			}
			MusicalInstrumentKeyItem keyItem3 = this.GetKeyItem(rowIndex, columnIndex);
			if (keyItem3 != null)
			{
				keyItem3.OnQtePerformance(true);
			}
			this.OnQtePerformance(rowIndex, columnIndex, true);
			this.QteCurrentIndex++;
			if (this.QteCurrentIndex >= itemDataList.Count)
			{
				MusicalInstrumentSubController subController = this.GetSubController();
				if (subController == null)
				{
					return;
				}
				subController.OnQteCompleted();
				return;
			}
			else
			{
				MusicalInstrumentQteItemData musicalInstrumentQteItemData2 = itemDataList[this.QteCurrentIndex];
				musicalInstrumentQteItemData2.IsFocus = true;
				MusicalInstrumentKeyItem keyItem4 = this.GetKeyItem(musicalInstrumentQteItemData2.RowIndex, musicalInstrumentQteItemData2.ColumnIndex);
				if (keyItem4 == null)
				{
					return;
				}
				keyItem4.OnQteFocus(true);
				return;
			}
		}

		// Token: 0x06036930 RID: 223536 RVA: 0x00CEC85B File Offset: 0x00CEAA5B
		protected void Exit()
		{
			MusicalInstrumentController.Instance.Exit(new MusicalInstrumentExitParam
			{
				Type = this.GetMusicalInstrumentType()
			}).Forget<bool>();
		}

		// Token: 0x0401CD8B RID: 118155
		protected int QteCurrentIndex;

		// Token: 0x0401CD8C RID: 118156
		[Nullable(1)]
		protected readonly List<List<MusicalInstrumentKeyItem>> KeyItems = new List<List<MusicalInstrumentKeyItem>>();
	}
}
