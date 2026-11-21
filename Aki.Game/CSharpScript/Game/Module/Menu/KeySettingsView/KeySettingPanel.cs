using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x02004446 RID: 17478
	[NullableContext(1)]
	[Nullable(0)]
	public class KeySettingPanel : UiPanelBase
	{
		// Token: 0x0602C178 RID: 180600 RVA: 0x00C60FAC File Offset: 0x00C5F1AC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIDynScrollViewComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0602C179 RID: 180601 RVA: 0x00C60FE8 File Offset: 0x00C5F1E8
		protected override UniTask OnBeforeStartAsync()
		{
			KeySettingPanel.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KeySettingPanel.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C17A RID: 180602 RVA: 0x00C6102B File Offset: 0x00C5F22B
		protected override void OnBeforeDestroy()
		{
			this.KeySettingRowBaseItem = null;
			this.DynamicScrollView = null;
			this.DetailEnableKeySettingRow = null;
			this.SelectedKeySettingRow = null;
			this.OnWaitInput = null;
			this.KeySettingScrollingFlag = 0;
		}

		// Token: 0x0602C17B RID: 180603 RVA: 0x00C61058 File Offset: 0x00C5F258
		private KeySettingRowContainerItem OnItemCreate(KeySettingRowData data, UUIItem uiItem, int index)
		{
			KeySettingRowContainerItem keySettingRowContainerItem = new KeySettingRowContainerItem();
			keySettingRowContainerItem.BindOnToggleStateChanged(new Action<KeySettingRowContainerItem, EToggleState>(this.OnToggleStateChanged));
			keySettingRowContainerItem.BindOnHover(new Action<KeySettingRowData>(this.OnHover));
			keySettingRowContainerItem.BindOnUnHover(new Action<KeySettingRowData>(this.OnUnHover));
			keySettingRowContainerItem.BindOnWaitInput(new Action<KeySettingRowData, KeySettingRowKeyItem, KeySettingRowContainerItem>(this.OnWaitKeyInput));
			return keySettingRowContainerItem;
		}

		// Token: 0x0602C17C RID: 180604 RVA: 0x00C610B2 File Offset: 0x00C5F2B2
		private void OnToggleStateChanged(KeySettingRowContainerItem keySettingRowContainerItem, EToggleState state)
		{
			if (state == EToggleState.ETT_UnChecked)
			{
				keySettingRowContainerItem.SetDetailItemVisible(false);
				this.DetailEnableKeySettingRow = null;
				return;
			}
			KeySettingRowContainerItem detailEnableKeySettingRow = this.DetailEnableKeySettingRow;
			if (detailEnableKeySettingRow != null)
			{
				detailEnableKeySettingRow.SetDetailItemVisible(false);
			}
			this.DetailEnableKeySettingRow = keySettingRowContainerItem;
			this.DetailEnableKeySettingRow.SetDetailItemVisible(true);
		}

		// Token: 0x0602C17D RID: 180605 RVA: 0x00C610EB File Offset: 0x00C5F2EB
		[NullableContext(2)]
		private void OnHover(KeySettingRowData keySettingRowData)
		{
			Action<KeySettingRowData> onHoverCallback = this.OnHoverCallback;
			if (onHoverCallback == null)
			{
				return;
			}
			onHoverCallback(keySettingRowData);
		}

		// Token: 0x0602C17E RID: 180606 RVA: 0x00C610FE File Offset: 0x00C5F2FE
		[NullableContext(2)]
		private void OnUnHover(KeySettingRowData keySettingRowData)
		{
			Action<KeySettingRowData> onUnHoverCallback = this.OnUnHoverCallback;
			if (onUnHoverCallback == null)
			{
				return;
			}
			onUnHoverCallback(keySettingRowData);
		}

		// Token: 0x0602C17F RID: 180607 RVA: 0x00C61111 File Offset: 0x00C5F311
		private void OnWaitKeyInput(KeySettingRowData keySettingRowData, KeySettingRowKeyItem keySettingRowKeyItem, KeySettingRowContainerItem keySettingRowContainerItem)
		{
			Action<KeySettingRowData, KeySettingRowKeyItem, KeySettingRowContainerItem> onWaitInput = this.OnWaitInput;
			if (onWaitInput == null)
			{
				return;
			}
			onWaitInput(keySettingRowData, keySettingRowKeyItem, keySettingRowContainerItem);
		}

		// Token: 0x0602C180 RID: 180608 RVA: 0x00C61126 File Offset: 0x00C5F326
		[NullableContext(2)]
		public void SelectKeySettingRow(KeySettingRowContainerItem keySettingRowContainerItem = null)
		{
			KeySettingRowContainerItem selectedKeySettingRow = this.SelectedKeySettingRow;
			if (selectedKeySettingRow != null)
			{
				selectedKeySettingRow.SetSelected(false);
			}
			this.SelectedKeySettingRow = keySettingRowContainerItem;
			KeySettingRowContainerItem selectedKeySettingRow2 = this.SelectedKeySettingRow;
			if (selectedKeySettingRow2 == null)
			{
				return;
			}
			selectedKeySettingRow2.SetSelected(true);
		}

		// Token: 0x0602C181 RID: 180609 RVA: 0x00C61152 File Offset: 0x00C5F352
		public void BindOnWaitInput(Action<KeySettingRowData, KeySettingRowKeyItem, KeySettingRowContainerItem> onWaitInput)
		{
			this.OnWaitInput = onWaitInput;
		}

		// Token: 0x0602C182 RID: 180610 RVA: 0x00C6115B File Offset: 0x00C5F35B
		public void BindOnHover([Nullable(new byte[]
		{
			1,
			2
		})] Action<KeySettingRowData> onHoverCallback)
		{
			this.OnHoverCallback = onHoverCallback;
		}

		// Token: 0x0602C183 RID: 180611 RVA: 0x00C61164 File Offset: 0x00C5F364
		public void BindOnUnHover([Nullable(new byte[]
		{
			1,
			2
		})] Action<KeySettingRowData> onUnHoverCallback)
		{
			this.OnUnHoverCallback = onUnHoverCallback;
		}

		// Token: 0x0602C184 RID: 180612 RVA: 0x00C61170 File Offset: 0x00C5F370
		public void Refresh(List<KeySettingRowData> keySettingRowDataList, EInputControllerType inputControllerType)
		{
			foreach (KeySettingRowData keySettingRowData in keySettingRowDataList)
			{
				keySettingRowData.IsExpandDetail = false;
			}
			MenuModel.Instance.KeySettingInputControllerType = inputControllerType;
			DynamicScrollView<KeySettingRowContainerItem, KeySettingRowBaseItem, KeySettingRowData> dynamicScrollView = this.DynamicScrollView;
			if (dynamicScrollView != null)
			{
				dynamicScrollView.RefreshByData(keySettingRowDataList.ToArray(), false, false);
			}
			this.KeySettingRowDataList = keySettingRowDataList;
			this.DetailEnableKeySettingRow = null;
		}

		// Token: 0x0602C185 RID: 180613 RVA: 0x00C611F0 File Offset: 0x00C5F3F0
		public void RefreshRow(KeySettingRowData keySettingRowData)
		{
			int index = this.KeySettingRowDataList.IndexOf(keySettingRowData);
			DynamicScrollView<KeySettingRowContainerItem, KeySettingRowBaseItem, KeySettingRowData> dynamicScrollView = this.DynamicScrollView;
			KeySettingRowContainerItem keySettingRowContainerItem = (dynamicScrollView != null) ? dynamicScrollView.GetScrollItemFromIndex(index) : null;
			if (keySettingRowContainerItem == null)
			{
				return;
			}
			keySettingRowContainerItem.Update(keySettingRowData, index);
		}

		// Token: 0x0602C186 RID: 180614 RVA: 0x00C6122C File Offset: 0x00C5F42C
		[return: Nullable(2)]
		public KeySettingRowContainerItem GetRowByData(KeySettingRowData data, bool needScrollTo = false)
		{
			int num = this.KeySettingRowDataList.IndexOf(data);
			DynamicScrollView<KeySettingRowContainerItem, KeySettingRowBaseItem, KeySettingRowData> dynamicScrollView = this.DynamicScrollView;
			if (dynamicScrollView == null)
			{
				return null;
			}
			if (needScrollTo && this.KeySettingScrollingFlag == 0)
			{
				this.KeySettingScrollingFlag = 1;
				dynamicScrollView.ScrollToItemIndex(num - 3, true, false).ContinueWith(delegate()
				{
					this.KeySettingScrollingFlag = 2;
				});
			}
			if (this.KeySettingScrollingFlag == 1)
			{
				return null;
			}
			this.KeySettingScrollingFlag = 0;
			dynamicScrollView.AddListenerOnItemClear(num, delegate
			{
				EventSystem.Instance.Emit<string>(EEventName.FinishGuideStepByEvent, "MenuView");
			});
			return dynamicScrollView.GetScrollItemFromIndex(num);
		}

		// Token: 0x0602C187 RID: 180615 RVA: 0x00C612C0 File Offset: 0x00C5F4C0
		public void StopScroll()
		{
			base.GetUIDynScrollViewComponent(0).StopMovement();
		}

		// Token: 0x04017C08 RID: 97288
		private const int SCROLL_TO_OFFSET = 3;

		// Token: 0x04017C09 RID: 97289
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private DynamicScrollView<KeySettingRowContainerItem, KeySettingRowBaseItem, KeySettingRowData> DynamicScrollView;

		// Token: 0x04017C0A RID: 97290
		[Nullable(2)]
		private KeySettingRowBaseItem KeySettingRowBaseItem;

		// Token: 0x04017C0B RID: 97291
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private Action<KeySettingRowData, KeySettingRowKeyItem, KeySettingRowContainerItem> OnWaitInput;

		// Token: 0x04017C0C RID: 97292
		[Nullable(2)]
		private Action<KeySettingRowData> OnHoverCallback;

		// Token: 0x04017C0D RID: 97293
		[Nullable(2)]
		private Action<KeySettingRowData> OnUnHoverCallback;

		// Token: 0x04017C0E RID: 97294
		[Nullable(2)]
		private KeySettingRowContainerItem DetailEnableKeySettingRow;

		// Token: 0x04017C0F RID: 97295
		[Nullable(2)]
		private KeySettingRowContainerItem SelectedKeySettingRow;

		// Token: 0x04017C10 RID: 97296
		private List<KeySettingRowData> KeySettingRowDataList = new List<KeySettingRowData>();

		// Token: 0x04017C11 RID: 97297
		private int KeySettingScrollingFlag;

		// Token: 0x0200A10F RID: 41231
		[NullableContext(0)]
		public class EChildType
		{
			// Token: 0x0403209B RID: 204955
			public const int DynamicScrollView = 0;

			// Token: 0x0403209C RID: 204956
			public const int TemplateItem = 1;
		}
	}
}
