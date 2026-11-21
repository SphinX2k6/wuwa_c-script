using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x02004352 RID: 17234
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class MusicalInstrumentBaseView : UiViewBase
	{
		// Token: 0x0602B86C RID: 178284 RVA: 0x00C3B4AF File Offset: 0x00C396AF
		[NullableContext(1)]
		protected MusicalInstrumentBaseView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602B86D RID: 178285
		protected abstract EInstrumentType GetMusicalInstrumentType();

		// Token: 0x0602B86E RID: 178286 RVA: 0x00C3B4C3 File Offset: 0x00C396C3
		protected virtual void OnQtePerformance(int rowIndex, int columnIndex, bool success)
		{
		}

		// Token: 0x0602B86F RID: 178287 RVA: 0x00C3B4C8 File Offset: 0x00C396C8
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

		// Token: 0x0602B870 RID: 178288 RVA: 0x00C3B50C File Offset: 0x00C3970C
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

		// Token: 0x0602B871 RID: 178289 RVA: 0x00C3B57D File Offset: 0x00C3977D
		protected virtual MusicalInstrumentSubModel GetSubModel()
		{
			return MusicalInstrumentModel.Instance.GetSubModel(this.GetMusicalInstrumentType());
		}

		// Token: 0x0602B872 RID: 178290 RVA: 0x00C3B58F File Offset: 0x00C3978F
		protected MusicalInstrumentSubController GetSubController()
		{
			return MusicalInstrumentController.Instance.GetSubController(this.GetMusicalInstrumentType());
		}

		// Token: 0x0602B873 RID: 178291 RVA: 0x00C3B5A1 File Offset: 0x00C397A1
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

		// Token: 0x0602B874 RID: 178292
		protected abstract void PostAudioEventByIndex(int rowIndex, int columnIndex);

		// Token: 0x0602B875 RID: 178293 RVA: 0x00C3B5C8 File Offset: 0x00C397C8
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

		// Token: 0x0602B876 RID: 178294 RVA: 0x00C3B6E7 File Offset: 0x00C398E7
		protected void Exit()
		{
			MusicalInstrumentController.Instance.Exit(new MusicalInstrumentExitParam
			{
				Type = this.GetMusicalInstrumentType()
			}).Forget<bool>();
		}

		// Token: 0x04017821 RID: 96289
		protected int QteCurrentIndex;

		// Token: 0x04017822 RID: 96290
		[Nullable(1)]
		protected readonly List<List<MusicalInstrumentKeyItem>> KeyItems = new List<List<MusicalInstrumentKeyItem>>();
	}
}
