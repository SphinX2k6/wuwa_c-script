using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D78 RID: 19832
	public class MoraleBuffBattleView : BattleVisibleChildView
	{
		// Token: 0x06031C29 RID: 203817 RVA: 0x00DE9E61 File Offset: 0x00DE8061
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.MiniMap);
			base.SetVisible(1, false);
			this.Panel = new BattleUiHoverTipsC();
			this.AddEvents();
		}

		// Token: 0x06031C2A RID: 203818 RVA: 0x00DE9E8A File Offset: 0x00DE808A
		public override void Reset()
		{
			base.Reset();
			this.RemoveEvents();
		}

		// Token: 0x06031C2B RID: 203819 RVA: 0x00DE9E98 File Offset: 0x00DE8098
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

		// Token: 0x06031C2C RID: 203820 RVA: 0x00DE9F3E File Offset: 0x00DE813E
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.BattleUiToggleMoraleBuffInfo, new Action(this.OnToggleMoraleBuffInfoView));
		}

		// Token: 0x06031C2D RID: 203821 RVA: 0x00DE9F5C File Offset: 0x00DE815C
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiToggleMoraleBuffInfo, new Action(this.OnToggleMoraleBuffInfoView));
		}

		// Token: 0x06031C2E RID: 203822 RVA: 0x00DE9F7A File Offset: 0x00DE817A
		public void StartShow()
		{
			this.Panel.UpdateInfo(MoraleModel.Instance.GetInTheBattleBuffInfo());
			base.SetVisible(1, true);
			BattleUiEnvironmentKeyData environmentKeyData = BattleUiModel.Instance.EnvironmentKeyData;
			if (environmentKeyData == null)
			{
				return;
			}
			environmentKeyData.SetEnvironmentKeyVisible(EEnvironmentKey.MoraleBuff, true);
		}

		// Token: 0x06031C2F RID: 203823 RVA: 0x00DE9FB0 File Offset: 0x00DE81B0
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
			environmentKeyData.SetEnvironmentKeyVisible(EEnvironmentKey.MoraleBuff, false);
		}

		// Token: 0x06031C30 RID: 203824 RVA: 0x00DE9FFD File Offset: 0x00DE81FD
		protected override void OnAfterDestroy()
		{
			BattleUiEnvironmentKeyData environmentKeyData = BattleUiModel.Instance.EnvironmentKeyData;
			if (environmentKeyData == null)
			{
				return;
			}
			environmentKeyData.SetEnvironmentKeyVisible(EEnvironmentKey.MoraleBuff, false);
		}

		// Token: 0x06031C31 RID: 203825 RVA: 0x00DEA018 File Offset: 0x00DE8218
		private void OnClickToggle(EToggleState toggleState)
		{
			if (toggleState == EToggleState.ETT_Checked)
			{
				UUIItem item = base.GetItem(1);
				this.Panel.CreateAndShow(item, MoraleModel.Instance.GetInTheBattleBuffInfo());
				return;
			}
			this.Panel.EndShow();
		}

		// Token: 0x06031C32 RID: 203826 RVA: 0x00DEA054 File Offset: 0x00DE8254
		private void OnToggleMoraleBuffInfoView()
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

		// Token: 0x0401A57A RID: 107898
		[Nullable(2)]
		private BattleUiHoverTipsC Panel;

		// Token: 0x0200AA5B RID: 43611
		private enum EVisibleReason
		{
			// Token: 0x04034A67 RID: 215655
			Default = 1
		}

		// Token: 0x0200AA5C RID: 43612
		private enum EChildComponent
		{
			// Token: 0x04034A69 RID: 215657
			Toggle,
			// Token: 0x04034A6A RID: 215658
			PanelNode
		}
	}
}
