using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D96 RID: 23958
	public class MoraleBuffBattleView : BattleVisibleChildView
	{
		// Token: 0x0603CCCC RID: 249036 RVA: 0x00E995A9 File Offset: 0x00E977A9
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.MiniMap);
			base.SetVisible(1, false);
			this.Panel = new BattleUiHoverTipsC();
			this.AddEvents();
		}

		// Token: 0x0603CCCD RID: 249037 RVA: 0x00E995D2 File Offset: 0x00E977D2
		public override void Reset()
		{
			base.Reset();
			this.RemoveEvents();
		}

		// Token: 0x0603CCCE RID: 249038 RVA: 0x00E995E0 File Offset: 0x00E977E0
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

		// Token: 0x0603CCCF RID: 249039 RVA: 0x00E99686 File Offset: 0x00E97886
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.BattleUiToggleMoraleBuffInfo, new Action(this.OnToggleMoraleBuffInfoView));
		}

		// Token: 0x0603CCD0 RID: 249040 RVA: 0x00E996A4 File Offset: 0x00E978A4
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiToggleMoraleBuffInfo, new Action(this.OnToggleMoraleBuffInfoView));
		}

		// Token: 0x0603CCD1 RID: 249041 RVA: 0x00E996C2 File Offset: 0x00E978C2
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

		// Token: 0x0603CCD2 RID: 249042 RVA: 0x00E996F8 File Offset: 0x00E978F8
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

		// Token: 0x0603CCD3 RID: 249043 RVA: 0x00E99745 File Offset: 0x00E97945
		protected override void OnAfterDestroy()
		{
			BattleUiEnvironmentKeyData environmentKeyData = BattleUiModel.Instance.EnvironmentKeyData;
			if (environmentKeyData == null)
			{
				return;
			}
			environmentKeyData.SetEnvironmentKeyVisible(EEnvironmentKey.MoraleBuff, false);
		}

		// Token: 0x0603CCD4 RID: 249044 RVA: 0x00E99760 File Offset: 0x00E97960
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

		// Token: 0x0603CCD5 RID: 249045 RVA: 0x00E9979C File Offset: 0x00E9799C
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

		// Token: 0x0401FAC2 RID: 129730
		[Nullable(2)]
		private BattleUiHoverTipsC Panel;

		// Token: 0x0200C055 RID: 49237
		private enum EVisibleReason
		{
			// Token: 0x0403A0A4 RID: 237732
			Default = 1
		}

		// Token: 0x0200C056 RID: 49238
		private enum EChildComponent
		{
			// Token: 0x0403A0A6 RID: 237734
			Toggle,
			// Token: 0x0403A0A7 RID: 237735
			PanelNode
		}
	}
}
