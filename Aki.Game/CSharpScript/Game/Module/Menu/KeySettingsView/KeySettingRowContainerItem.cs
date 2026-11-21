using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x02004449 RID: 17481
	[NullableContext(1)]
	[Nullable(0)]
	public class KeySettingRowContainerItem : UiPanelBase, IDynamicScrollItem<KeySettingRowData>
	{
		// Token: 0x0602C193 RID: 180627 RVA: 0x00C614A0 File Offset: 0x00C5F6A0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0602C194 RID: 180628 RVA: 0x00C614FC File Offset: 0x00C5F6FC
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnStateChanged));
			}
			if (extendToggle != null)
			{
				extendToggle.OnHover.Add(new Action(this.OnHover));
			}
			if (extendToggle != null)
			{
				extendToggle.OnUnHover.Add(new Action(this.OnUnHover));
			}
			this.SetActive(true);
		}

		// Token: 0x0602C195 RID: 180629 RVA: 0x00C61570 File Offset: 0x00C5F770
		protected override void OnBeforeDestroy()
		{
			this.KeySettingRowData = null;
			this.KeySettingRowKeyItem = null;
			this.KeySettingRowTypeItem = null;
			this.OnWaitInput = null;
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.OnStateChange.Remove(new Action<EToggleState>(this.OnStateChanged));
			}
			if (extendToggle != null)
			{
				extendToggle.OnHover.Remove(new Action(this.OnHover));
			}
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnUnHover.Remove(new Action(this.OnUnHover));
		}

		// Token: 0x0602C196 RID: 180630 RVA: 0x00C615F5 File Offset: 0x00C5F7F5
		private void OnStateChanged(EToggleState state)
		{
			Action<KeySettingRowContainerItem, EToggleState> onToggleStateChanged = this.OnToggleStateChanged;
			if (onToggleStateChanged == null)
			{
				return;
			}
			onToggleStateChanged(this, state);
		}

		// Token: 0x0602C197 RID: 180631 RVA: 0x00C61609 File Offset: 0x00C5F809
		private void OnHover()
		{
			Action<KeySettingRowData> onHoverCallback = this.OnHoverCallback;
			if (onHoverCallback == null)
			{
				return;
			}
			onHoverCallback(this.KeySettingRowData);
		}

		// Token: 0x0602C198 RID: 180632 RVA: 0x00C61621 File Offset: 0x00C5F821
		private void OnUnHover()
		{
			Action<KeySettingRowData> onUnHoverCallback = this.OnUnHoverCallback;
			if (onUnHoverCallback == null)
			{
				return;
			}
			onUnHoverCallback(this.KeySettingRowData);
		}

		// Token: 0x0602C199 RID: 180633 RVA: 0x00C61639 File Offset: 0x00C5F839
		public void BindOnToggleStateChanged(Action<KeySettingRowContainerItem, EToggleState> onToggleStateChanged)
		{
			this.OnToggleStateChanged = onToggleStateChanged;
		}

		// Token: 0x0602C19A RID: 180634 RVA: 0x00C61642 File Offset: 0x00C5F842
		public void BindOnHover([Nullable(new byte[]
		{
			1,
			2
		})] Action<KeySettingRowData> onHoverCallback)
		{
			this.OnHoverCallback = onHoverCallback;
		}

		// Token: 0x0602C19B RID: 180635 RVA: 0x00C6164B File Offset: 0x00C5F84B
		public void BindOnUnHover([Nullable(new byte[]
		{
			1,
			2
		})] Action<KeySettingRowData> onUnHoverCallback)
		{
			this.OnUnHoverCallback = onUnHoverCallback;
		}

		// Token: 0x0602C19C RID: 180636 RVA: 0x00C61654 File Offset: 0x00C5F854
		public UniTask Init(UUIItem actor)
		{
			KeySettingRowContainerItem.<Init>d__17 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<KeySettingRowContainerItem.<Init>d__17>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602C19D RID: 180637 RVA: 0x00C6169F File Offset: 0x00C5F89F
		public void ClearItem()
		{
			this.KeySettingRowData = null;
		}

		// Token: 0x0602C19E RID: 180638 RVA: 0x00C616A8 File Offset: 0x00C5F8A8
		public void Update(KeySettingRowData data, int index)
		{
			EInputControllerType keySettingInputControllerType = MenuModel.Instance.KeySettingInputControllerType;
			this.KeySettingRowData = data;
			EKeySettingRowType rowType = data.GetRowType();
			if (rowType != EKeySettingRowType.KeyType)
			{
				if (rowType == EKeySettingRowType.KeySetting)
				{
					UUIExtendToggle extendToggle = base.GetExtendToggle(0);
					if (extendToggle != null)
					{
						extendToggle.SetSelfInteractive(true);
					}
					this.KeySettingRowKeyItem.Refresh(data, keySettingInputControllerType);
					base.GetItem(2).SetUIActive(true);
					base.GetItem(1).SetUIActive(false);
				}
			}
			else
			{
				UUIExtendToggle extendToggle2 = base.GetExtendToggle(0);
				if (extendToggle2 != null)
				{
					extendToggle2.SetSelfInteractive(false);
				}
				this.KeySettingRowTypeItem.Refresh(data);
				base.GetItem(2).SetUIActive(false);
				base.GetItem(1).SetUIActive(true);
			}
			this.SetSelected(false);
			this.SetToggleState(data.IsExpandDetail);
		}

		// Token: 0x0602C19F RID: 180639 RVA: 0x00C61760 File Offset: 0x00C5F960
		private UniTask NewKeySettingRowKeyItem()
		{
			KeySettingRowContainerItem.<NewKeySettingRowKeyItem>d__20 <NewKeySettingRowKeyItem>d__;
			<NewKeySettingRowKeyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewKeySettingRowKeyItem>d__.<>4__this = this;
			<NewKeySettingRowKeyItem>d__.<>1__state = -1;
			<NewKeySettingRowKeyItem>d__.<>t__builder.Start<KeySettingRowContainerItem.<NewKeySettingRowKeyItem>d__20>(ref <NewKeySettingRowKeyItem>d__);
			return <NewKeySettingRowKeyItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602C1A0 RID: 180640 RVA: 0x00C617A3 File Offset: 0x00C5F9A3
		private void OnWaitKeyInput(KeySettingRowData keySettingRowData, KeySettingRowKeyItem keySettingRowKeyItem)
		{
			Action<KeySettingRowData, KeySettingRowKeyItem, KeySettingRowContainerItem> onWaitInput = this.OnWaitInput;
			if (onWaitInput == null)
			{
				return;
			}
			onWaitInput(keySettingRowData, keySettingRowKeyItem, this);
		}

		// Token: 0x0602C1A1 RID: 180641 RVA: 0x00C617B8 File Offset: 0x00C5F9B8
		public void BindOnWaitInput(Action<KeySettingRowData, KeySettingRowKeyItem, KeySettingRowContainerItem> onWaitInput)
		{
			this.OnWaitInput = onWaitInput;
		}

		// Token: 0x0602C1A2 RID: 180642 RVA: 0x00C617C4 File Offset: 0x00C5F9C4
		private UniTask NewKeySettingRowTypeItem()
		{
			KeySettingRowContainerItem.<NewKeySettingRowTypeItem>d__23 <NewKeySettingRowTypeItem>d__;
			<NewKeySettingRowTypeItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewKeySettingRowTypeItem>d__.<>4__this = this;
			<NewKeySettingRowTypeItem>d__.<>1__state = -1;
			<NewKeySettingRowTypeItem>d__.<>t__builder.Start<KeySettingRowContainerItem.<NewKeySettingRowTypeItem>d__23>(ref <NewKeySettingRowTypeItem>d__);
			return <NewKeySettingRowTypeItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602C1A3 RID: 180643 RVA: 0x00C61808 File Offset: 0x00C5FA08
		[return: Nullable(2)]
		public AUIBaseActor GetUsingItem(KeySettingRowData data)
		{
			EKeySettingRowType rowType = data.GetRowType();
			if (rowType == EKeySettingRowType.KeyType)
			{
				return base.GetItem(1).GetOwner() as AUIBaseActor;
			}
			if (rowType != EKeySettingRowType.KeySetting)
			{
				return null;
			}
			return base.GetItem(2).GetOwner() as AUIBaseActor;
		}

		// Token: 0x0602C1A4 RID: 180644 RVA: 0x00C6184B File Offset: 0x00C5FA4B
		public void SetSelected(bool bSelected)
		{
			KeySettingRowKeyItem keySettingRowKeyItem = this.KeySettingRowKeyItem;
			if (keySettingRowKeyItem == null)
			{
				return;
			}
			keySettingRowKeyItem.SetSelected(bSelected);
		}

		// Token: 0x0602C1A5 RID: 180645 RVA: 0x00C6185E File Offset: 0x00C5FA5E
		public void SetDetailItemVisible(bool bVisible)
		{
			KeySettingRowKeyItem keySettingRowKeyItem = this.KeySettingRowKeyItem;
			if (keySettingRowKeyItem != null)
			{
				keySettingRowKeyItem.SetDetailItemVisible(bVisible);
			}
			this.SetToggleState(bVisible);
		}

		// Token: 0x0602C1A6 RID: 180646 RVA: 0x00C61879 File Offset: 0x00C5FA79
		private void SetToggleState(bool bChecked)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(bChecked ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x04017C12 RID: 97298
		[Nullable(2)]
		public KeySettingRowData KeySettingRowData;

		// Token: 0x04017C13 RID: 97299
		[Nullable(2)]
		private KeySettingRowKeyItem KeySettingRowKeyItem;

		// Token: 0x04017C14 RID: 97300
		[Nullable(2)]
		private KeySettingRowTypeItem KeySettingRowTypeItem;

		// Token: 0x04017C15 RID: 97301
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private Action<KeySettingRowData, KeySettingRowKeyItem, KeySettingRowContainerItem> OnWaitInput;

		// Token: 0x04017C16 RID: 97302
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<KeySettingRowContainerItem, EToggleState> OnToggleStateChanged;

		// Token: 0x04017C17 RID: 97303
		[Nullable(2)]
		private Action<KeySettingRowData> OnHoverCallback;

		// Token: 0x04017C18 RID: 97304
		[Nullable(2)]
		private Action<KeySettingRowData> OnUnHoverCallback;

		// Token: 0x0200A115 RID: 41237
		[NullableContext(0)]
		public class EChildType
		{
			// Token: 0x040320AE RID: 204974
			public const int Toggle = 0;

			// Token: 0x040320AF RID: 204975
			public const int KeyTypeItem = 1;

			// Token: 0x040320B0 RID: 204976
			public const int KeySettingItem = 2;
		}
	}
}
