using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DBE RID: 23998
	public class ShipTowerBuffBattleView : BattleVisibleChildView
	{
		// Token: 0x0603CFB7 RID: 249783 RVA: 0x00EA96EC File Offset: 0x00EA78EC
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.MiniMap);
			base.SetVisible(1, false);
			this.Panel = new BattleUiHoverTipsD();
			this.AddEvents();
		}

		// Token: 0x0603CFB8 RID: 249784 RVA: 0x00EA9715 File Offset: 0x00EA7915
		public override void Reset()
		{
			base.Reset();
			this.RemoveEvents();
		}

		// Token: 0x0603CFB9 RID: 249785 RVA: 0x00EA9724 File Offset: 0x00EA7924
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603CFBA RID: 249786 RVA: 0x00EA97CA File Offset: 0x00EA79CA
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.BattleUiToggleShipTowerBuffInfo, new Action(this.OnToggleShipTowerBuffInfoView));
		}

		// Token: 0x0603CFBB RID: 249787 RVA: 0x00EA97E8 File Offset: 0x00EA79E8
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiToggleShipTowerBuffInfo, new Action(this.OnToggleShipTowerBuffInfoView));
		}

		// Token: 0x0603CFBC RID: 249788 RVA: 0x00EA9806 File Offset: 0x00EA7A06
		public void StartShow()
		{
			this.Panel.UpdateInfo(ShipTowerModel.Instance.GetInTheBattleBuffInfo());
			base.SetVisible(1, true);
			BattleUiEnvironmentKeyData environmentKeyData = BattleUiModel.Instance.EnvironmentKeyData;
			if (environmentKeyData == null)
			{
				return;
			}
			environmentKeyData.SetEnvironmentKeyVisible(EEnvironmentKey.ShipTowerBuff, true);
		}

		// Token: 0x0603CFBD RID: 249789 RVA: 0x00EA983C File Offset: 0x00EA7A3C
		public void EndShow()
		{
			this.Panel.EndShow();
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
			}
			base.SetVisible(1, false);
			BattleUiEnvironmentKeyData environmentKeyData = BattleUiModel.Instance.EnvironmentKeyData;
			if (environmentKeyData == null)
			{
				return;
			}
			environmentKeyData.SetEnvironmentKeyVisible(EEnvironmentKey.ShipTowerBuff, false);
		}

		// Token: 0x0603CFBE RID: 249790 RVA: 0x00EA9889 File Offset: 0x00EA7A89
		protected override void OnAfterDestroy()
		{
			BattleUiEnvironmentKeyData environmentKeyData = BattleUiModel.Instance.EnvironmentKeyData;
			if (environmentKeyData == null)
			{
				return;
			}
			environmentKeyData.SetEnvironmentKeyVisible(EEnvironmentKey.ShipTowerBuff, false);
		}

		// Token: 0x0603CFBF RID: 249791 RVA: 0x00EA98A4 File Offset: 0x00EA7AA4
		private void OnClickToggle(EToggleState toggleState)
		{
			if (toggleState == EToggleState.ETT_Checked)
			{
				UUIItem item = base.GetItem(1);
				this.Panel.CreateAndShow(item, ShipTowerModel.Instance.GetInTheBattleBuffInfo());
				return;
			}
			this.Panel.EndShow();
		}

		// Token: 0x0603CFC0 RID: 249792 RVA: 0x00EA98E0 File Offset: 0x00EA7AE0
		private void OnToggleShipTowerBuffInfoView()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				if (extendToggle.GetToggleState() == EToggleState.ETT_Checked)
				{
					extendToggle.SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
					return;
				}
				extendToggle.SetToggleState(EToggleState.ETT_Checked, true, false, false);
			}
		}

		// Token: 0x0401FC67 RID: 130151
		[Nullable(2)]
		private BattleUiHoverTipsD Panel;

		// Token: 0x0200C0BB RID: 49339
		private enum EVisibleReason
		{
			// Token: 0x0403A27C RID: 238204
			Default = 1
		}

		// Token: 0x0200C0BC RID: 49340
		private enum EChildComponent
		{
			// Token: 0x0403A27E RID: 238206
			Toggle,
			// Token: 0x0403A27F RID: 238207
			PanelNode
		}
	}
}
