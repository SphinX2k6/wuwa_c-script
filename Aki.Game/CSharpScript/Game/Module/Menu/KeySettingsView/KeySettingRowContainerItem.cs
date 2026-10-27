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
	// Token: 0x02005466 RID: 21606
	[NullableContext(1)]
	[Nullable(0)]
	public class KeySettingRowContainerItem : UiPanelBase, IDynamicScrollItem<KeySettingRowData>
	{
		// Token: 0x0603724A RID: 225866 RVA: 0x00D12088 File Offset: 0x00D10288
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0603724B RID: 225867 RVA: 0x00D120E4 File Offset: 0x00D102E4
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

		// Token: 0x0603724C RID: 225868 RVA: 0x00D12158 File Offset: 0x00D10358
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

		// Token: 0x0603724D RID: 225869 RVA: 0x00D121DD File Offset: 0x00D103DD
		private void OnStateChanged(EToggleState state)
		{
			Action<KeySettingRowContainerItem, EToggleState> onToggleStateChanged = this.OnToggleStateChanged;
			if (onToggleStateChanged == null)
			{
				return;
			}
			onToggleStateChanged(this, state);
		}

		// Token: 0x0603724E RID: 225870 RVA: 0x00D121F1 File Offset: 0x00D103F1
		private void OnHover()
		{
			Action<KeySettingRowData> onHoverCallback = this.OnHoverCallback;
			if (onHoverCallback == null)
			{
				return;
			}
			onHoverCallback(this.KeySettingRowData);
		}

		// Token: 0x0603724F RID: 225871 RVA: 0x00D12209 File Offset: 0x00D10409
		private void OnUnHover()
		{
			Action<KeySettingRowData> onUnHoverCallback = this.OnUnHoverCallback;
			if (onUnHoverCallback == null)
			{
				return;
			}
			onUnHoverCallback(this.KeySettingRowData);
		}

		// Token: 0x06037250 RID: 225872 RVA: 0x00D12221 File Offset: 0x00D10421
		public void BindOnToggleStateChanged(Action<KeySettingRowContainerItem, EToggleState> onToggleStateChanged)
		{
			this.OnToggleStateChanged = onToggleStateChanged;
		}

		// Token: 0x06037251 RID: 225873 RVA: 0x00D1222A File Offset: 0x00D1042A
		public void BindOnHover([Nullable(new byte[]
		{
			1,
			2
		})] Action<KeySettingRowData> onHoverCallback)
		{
			this.OnHoverCallback = onHoverCallback;
		}

		// Token: 0x06037252 RID: 225874 RVA: 0x00D12233 File Offset: 0x00D10433
		public void BindOnUnHover([Nullable(new byte[]
		{
			1,
			2
		})] Action<KeySettingRowData> onUnHoverCallback)
		{
			this.OnUnHoverCallback = onUnHoverCallback;
		}

		// Token: 0x06037253 RID: 225875 RVA: 0x00D1223C File Offset: 0x00D1043C
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

		// Token: 0x06037254 RID: 225876 RVA: 0x00D12287 File Offset: 0x00D10487
		public void ClearItem()
		{
			this.KeySettingRowData = null;
		}

		// Token: 0x06037255 RID: 225877 RVA: 0x00D12290 File Offset: 0x00D10490
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

		// Token: 0x06037256 RID: 225878 RVA: 0x00D12348 File Offset: 0x00D10548
		private UniTask NewKeySettingRowKeyItem()
		{
			KeySettingRowContainerItem.<NewKeySettingRowKeyItem>d__20 <NewKeySettingRowKeyItem>d__;
			<NewKeySettingRowKeyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewKeySettingRowKeyItem>d__.<>4__this = this;
			<NewKeySettingRowKeyItem>d__.<>1__state = -1;
			<NewKeySettingRowKeyItem>d__.<>t__builder.Start<KeySettingRowContainerItem.<NewKeySettingRowKeyItem>d__20>(ref <NewKeySettingRowKeyItem>d__);
			return <NewKeySettingRowKeyItem>d__.<>t__builder.Task;
		}

		// Token: 0x06037257 RID: 225879 RVA: 0x00D1238B File Offset: 0x00D1058B
		private void OnWaitKeyInput(KeySettingRowData keySettingRowData, KeySettingRowKeyItem keySettingRowKeyItem)
		{
			Action<KeySettingRowData, KeySettingRowKeyItem, KeySettingRowContainerItem> onWaitInput = this.OnWaitInput;
			if (onWaitInput == null)
			{
				return;
			}
			onWaitInput(keySettingRowData, keySettingRowKeyItem, this);
		}

		// Token: 0x06037258 RID: 225880 RVA: 0x00D123A0 File Offset: 0x00D105A0
		public void BindOnWaitInput(Action<KeySettingRowData, KeySettingRowKeyItem, KeySettingRowContainerItem> onWaitInput)
		{
			this.OnWaitInput = onWaitInput;
		}

		// Token: 0x06037259 RID: 225881 RVA: 0x00D123AC File Offset: 0x00D105AC
		private UniTask NewKeySettingRowTypeItem()
		{
			KeySettingRowContainerItem.<NewKeySettingRowTypeItem>d__23 <NewKeySettingRowTypeItem>d__;
			<NewKeySettingRowTypeItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewKeySettingRowTypeItem>d__.<>4__this = this;
			<NewKeySettingRowTypeItem>d__.<>1__state = -1;
			<NewKeySettingRowTypeItem>d__.<>t__builder.Start<KeySettingRowContainerItem.<NewKeySettingRowTypeItem>d__23>(ref <NewKeySettingRowTypeItem>d__);
			return <NewKeySettingRowTypeItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603725A RID: 225882 RVA: 0x00D123F0 File Offset: 0x00D105F0
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

		// Token: 0x0603725B RID: 225883 RVA: 0x00D12433 File Offset: 0x00D10633
		public void SetSelected(bool bSelected)
		{
			KeySettingRowKeyItem keySettingRowKeyItem = this.KeySettingRowKeyItem;
			if (keySettingRowKeyItem == null)
			{
				return;
			}
			keySettingRowKeyItem.SetSelected(bSelected);
		}

		// Token: 0x0603725C RID: 225884 RVA: 0x00D12446 File Offset: 0x00D10646
		public void SetDetailItemVisible(bool bVisible)
		{
			KeySettingRowKeyItem keySettingRowKeyItem = this.KeySettingRowKeyItem;
			if (keySettingRowKeyItem != null)
			{
				keySettingRowKeyItem.SetDetailItemVisible(bVisible);
			}
			this.SetToggleState(bVisible);
		}

		// Token: 0x0603725D RID: 225885 RVA: 0x00D12461 File Offset: 0x00D10661
		private void SetToggleState(bool bChecked)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(bChecked ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0401D179 RID: 119161
		[Nullable(2)]
		public KeySettingRowData KeySettingRowData;

		// Token: 0x0401D17A RID: 119162
		[Nullable(2)]
		private KeySettingRowKeyItem KeySettingRowKeyItem;

		// Token: 0x0401D17B RID: 119163
		[Nullable(2)]
		private KeySettingRowTypeItem KeySettingRowTypeItem;

		// Token: 0x0401D17C RID: 119164
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private Action<KeySettingRowData, KeySettingRowKeyItem, KeySettingRowContainerItem> OnWaitInput;

		// Token: 0x0401D17D RID: 119165
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<KeySettingRowContainerItem, EToggleState> OnToggleStateChanged;

		// Token: 0x0401D17E RID: 119166
		[Nullable(2)]
		private Action<KeySettingRowData> OnHoverCallback;

		// Token: 0x0401D17F RID: 119167
		[Nullable(2)]
		private Action<KeySettingRowData> OnUnHoverCallback;

		// Token: 0x0200B6DD RID: 46813
		[NullableContext(0)]
		public class EChildType
		{
			// Token: 0x04037659 RID: 226905
			public const int Toggle = 0;

			// Token: 0x0403765A RID: 226906
			public const int KeyTypeItem = 1;

			// Token: 0x0403765B RID: 226907
			public const int KeySettingItem = 2;
		}
	}
}
