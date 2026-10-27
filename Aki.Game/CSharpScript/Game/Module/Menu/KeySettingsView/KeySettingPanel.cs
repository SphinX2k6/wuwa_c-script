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
	// Token: 0x02005463 RID: 21603
	[NullableContext(1)]
	[Nullable(0)]
	public class KeySettingPanel : UiPanelBase
	{
		// Token: 0x0603722F RID: 225839 RVA: 0x00D11B94 File Offset: 0x00D0FD94
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIDynScrollViewComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06037230 RID: 225840 RVA: 0x00D11BD0 File Offset: 0x00D0FDD0
		protected override UniTask OnBeforeStartAsync()
		{
			KeySettingPanel.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KeySettingPanel.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037231 RID: 225841 RVA: 0x00D11C13 File Offset: 0x00D0FE13
		protected override void OnBeforeDestroy()
		{
			this.KeySettingRowBaseItem = null;
			this.DynamicScrollView = null;
			this.DetailEnableKeySettingRow = null;
			this.SelectedKeySettingRow = null;
			this.OnWaitInput = null;
			this.KeySettingScrollingFlag = 0;
		}

		// Token: 0x06037232 RID: 225842 RVA: 0x00D11C40 File Offset: 0x00D0FE40
		private KeySettingRowContainerItem OnItemCreate(KeySettingRowData data, UUIItem uiItem, int index)
		{
			KeySettingRowContainerItem keySettingRowContainerItem = new KeySettingRowContainerItem();
			keySettingRowContainerItem.BindOnToggleStateChanged(new Action<KeySettingRowContainerItem, EToggleState>(this.OnToggleStateChanged));
			keySettingRowContainerItem.BindOnHover(new Action<KeySettingRowData>(this.OnHover));
			keySettingRowContainerItem.BindOnUnHover(new Action<KeySettingRowData>(this.OnUnHover));
			keySettingRowContainerItem.BindOnWaitInput(new Action<KeySettingRowData, KeySettingRowKeyItem, KeySettingRowContainerItem>(this.OnWaitKeyInput));
			return keySettingRowContainerItem;
		}

		// Token: 0x06037233 RID: 225843 RVA: 0x00D11C9A File Offset: 0x00D0FE9A
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

		// Token: 0x06037234 RID: 225844 RVA: 0x00D11CD3 File Offset: 0x00D0FED3
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

		// Token: 0x06037235 RID: 225845 RVA: 0x00D11CE6 File Offset: 0x00D0FEE6
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

		// Token: 0x06037236 RID: 225846 RVA: 0x00D11CF9 File Offset: 0x00D0FEF9
		private void OnWaitKeyInput(KeySettingRowData keySettingRowData, KeySettingRowKeyItem keySettingRowKeyItem, KeySettingRowContainerItem keySettingRowContainerItem)
		{
			Action<KeySettingRowData, KeySettingRowKeyItem, KeySettingRowContainerItem> onWaitInput = this.OnWaitInput;
			if (onWaitInput == null)
			{
				return;
			}
			onWaitInput(keySettingRowData, keySettingRowKeyItem, keySettingRowContainerItem);
		}

		// Token: 0x06037237 RID: 225847 RVA: 0x00D11D0E File Offset: 0x00D0FF0E
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

		// Token: 0x06037238 RID: 225848 RVA: 0x00D11D3A File Offset: 0x00D0FF3A
		public void BindOnWaitInput(Action<KeySettingRowData, KeySettingRowKeyItem, KeySettingRowContainerItem> onWaitInput)
		{
			this.OnWaitInput = onWaitInput;
		}

		// Token: 0x06037239 RID: 225849 RVA: 0x00D11D43 File Offset: 0x00D0FF43
		public void BindOnHover([Nullable(new byte[]
		{
			1,
			2
		})] Action<KeySettingRowData> onHoverCallback)
		{
			this.OnHoverCallback = onHoverCallback;
		}

		// Token: 0x0603723A RID: 225850 RVA: 0x00D11D4C File Offset: 0x00D0FF4C
		public void BindOnUnHover([Nullable(new byte[]
		{
			1,
			2
		})] Action<KeySettingRowData> onUnHoverCallback)
		{
			this.OnUnHoverCallback = onUnHoverCallback;
		}

		// Token: 0x0603723B RID: 225851 RVA: 0x00D11D58 File Offset: 0x00D0FF58
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

		// Token: 0x0603723C RID: 225852 RVA: 0x00D11DD8 File Offset: 0x00D0FFD8
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

		// Token: 0x0603723D RID: 225853 RVA: 0x00D11E14 File Offset: 0x00D10014
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

		// Token: 0x0603723E RID: 225854 RVA: 0x00D11EA8 File Offset: 0x00D100A8
		public void StopScroll()
		{
			base.GetUIDynScrollViewComponent(0).StopMovement();
		}

		// Token: 0x0401D16F RID: 119151
		private const int SCROLL_TO_OFFSET = 3;

		// Token: 0x0401D170 RID: 119152
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private DynamicScrollView<KeySettingRowContainerItem, KeySettingRowBaseItem, KeySettingRowData> DynamicScrollView;

		// Token: 0x0401D171 RID: 119153
		[Nullable(2)]
		private KeySettingRowBaseItem KeySettingRowBaseItem;

		// Token: 0x0401D172 RID: 119154
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private Action<KeySettingRowData, KeySettingRowKeyItem, KeySettingRowContainerItem> OnWaitInput;

		// Token: 0x0401D173 RID: 119155
		[Nullable(2)]
		private Action<KeySettingRowData> OnHoverCallback;

		// Token: 0x0401D174 RID: 119156
		[Nullable(2)]
		private Action<KeySettingRowData> OnUnHoverCallback;

		// Token: 0x0401D175 RID: 119157
		[Nullable(2)]
		private KeySettingRowContainerItem DetailEnableKeySettingRow;

		// Token: 0x0401D176 RID: 119158
		[Nullable(2)]
		private KeySettingRowContainerItem SelectedKeySettingRow;

		// Token: 0x0401D177 RID: 119159
		private List<KeySettingRowData> KeySettingRowDataList = new List<KeySettingRowData>();

		// Token: 0x0401D178 RID: 119160
		private int KeySettingScrollingFlag;

		// Token: 0x0200B6D7 RID: 46807
		[NullableContext(0)]
		public class EChildType
		{
			// Token: 0x04037646 RID: 226886
			public const int DynamicScrollView = 0;

			// Token: 0x04037647 RID: 226887
			public const int TemplateItem = 1;
		}
	}
}
