using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DA2 RID: 19874
	public class ShipTowerBuffBattleView : BattleVisibleChildView
	{
		// Token: 0x06031F2E RID: 204590 RVA: 0x00DFA5C8 File Offset: 0x00DF87C8
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.MiniMap);
			base.SetVisible(1, false);
			this.Panel = new BattleUiHoverTipsD();
			this.AddEvents();
		}

		// Token: 0x06031F2F RID: 204591 RVA: 0x00DFA5F1 File Offset: 0x00DF87F1
		public override void Reset()
		{
			base.Reset();
			this.RemoveEvents();
		}

		// Token: 0x06031F30 RID: 204592 RVA: 0x00DFA600 File Offset: 0x00DF8800
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

		// Token: 0x06031F31 RID: 204593 RVA: 0x00DFA6A6 File Offset: 0x00DF88A6
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.BattleUiToggleShipTowerBuffInfo, new Action(this.OnToggleShipTowerBuffInfoView));
		}

		// Token: 0x06031F32 RID: 204594 RVA: 0x00DFA6C4 File Offset: 0x00DF88C4
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiToggleShipTowerBuffInfo, new Action(this.OnToggleShipTowerBuffInfoView));
		}

		// Token: 0x06031F33 RID: 204595 RVA: 0x00DFA6E2 File Offset: 0x00DF88E2
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

		// Token: 0x06031F34 RID: 204596 RVA: 0x00DFA718 File Offset: 0x00DF8918
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

		// Token: 0x06031F35 RID: 204597 RVA: 0x00DFA765 File Offset: 0x00DF8965
		protected override void OnAfterDestroy()
		{
			BattleUiEnvironmentKeyData environmentKeyData = BattleUiModel.Instance.EnvironmentKeyData;
			if (environmentKeyData == null)
			{
				return;
			}
			environmentKeyData.SetEnvironmentKeyVisible(EEnvironmentKey.ShipTowerBuff, false);
		}

		// Token: 0x06031F36 RID: 204598 RVA: 0x00DFA780 File Offset: 0x00DF8980
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

		// Token: 0x06031F37 RID: 204599 RVA: 0x00DFA7BC File Offset: 0x00DF89BC
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

		// Token: 0x0401A724 RID: 108324
		[Nullable(2)]
		private BattleUiHoverTipsD Panel;

		// Token: 0x0200AAC4 RID: 43716
		private enum EVisibleReason
		{
			// Token: 0x04034C4E RID: 216142
			Default = 1
		}

		// Token: 0x0200AAC5 RID: 43717
		private enum EChildComponent
		{
			// Token: 0x04034C50 RID: 216144
			Toggle,
			// Token: 0x04034C51 RID: 216145
			PanelNode
		}
	}
}
