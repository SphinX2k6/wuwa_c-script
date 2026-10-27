using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DC3 RID: 24003
	public class SilentAreaView : BattleVisibleChildView
	{
		// Token: 0x17008E6C RID: 36460
		// (get) Token: 0x0603CFE3 RID: 249827 RVA: 0x00EAA326 File Offset: 0x00EA8526
		public long Id
		{
			get
			{
				return this.TreeIncId;
			}
		}

		// Token: 0x0603CFE4 RID: 249828 RVA: 0x00EAA32E File Offset: 0x00EA852E
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.MiniMap);
			base.SetVisible(1, false);
			this.Panel = new SilentAreaInfoPanel();
			this.AddEvents();
		}

		// Token: 0x0603CFE5 RID: 249829 RVA: 0x00EAA357 File Offset: 0x00EA8557
		public override void Reset()
		{
			base.Reset();
			this.RemoveEvents();
		}

		// Token: 0x0603CFE6 RID: 249830 RVA: 0x00EAA368 File Offset: 0x00EA8568
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

		// Token: 0x0603CFE7 RID: 249831 RVA: 0x00EAA40E File Offset: 0x00EA860E
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.BattleUiToggleSilentAreaInfoView, new Action(this.OnToggleSilentAreaInfoView));
		}

		// Token: 0x0603CFE8 RID: 249832 RVA: 0x00EAA42C File Offset: 0x00EA862C
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiToggleSilentAreaInfoView, new Action(this.OnToggleSilentAreaInfoView));
		}

		// Token: 0x0603CFE9 RID: 249833 RVA: 0x00EAA44A File Offset: 0x00EA864A
		[NullableContext(1)]
		public void StartShow(long treeIncId, BaseBehaviorTree tree)
		{
			this.TreeIncId = treeIncId;
			this.Tree = tree;
			this.Panel.UpdateInfo(tree.GetSilentAreaShowInfo());
			base.SetVisible(1, true);
			BattleUiEnvironmentKeyData environmentKeyData = BattleUiModel.Instance.EnvironmentKeyData;
			if (environmentKeyData == null)
			{
				return;
			}
			environmentKeyData.SetEnvironmentKeyVisible(EEnvironmentKey.SilentArea, true);
		}

		// Token: 0x0603CFEA RID: 249834 RVA: 0x00EAA48C File Offset: 0x00EA868C
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
			environmentKeyData.SetEnvironmentKeyVisible(EEnvironmentKey.SilentArea, false);
		}

		// Token: 0x0603CFEB RID: 249835 RVA: 0x00EAA4D9 File Offset: 0x00EA86D9
		protected override void OnAfterDestroy()
		{
			BattleUiEnvironmentKeyData environmentKeyData = BattleUiModel.Instance.EnvironmentKeyData;
			if (environmentKeyData == null)
			{
				return;
			}
			environmentKeyData.SetEnvironmentKeyVisible(EEnvironmentKey.SilentArea, false);
		}

		// Token: 0x0603CFEC RID: 249836 RVA: 0x00EAA4F4 File Offset: 0x00EA86F4
		private void OnClickToggle(EToggleState toggleState)
		{
			if (toggleState == EToggleState.ETT_Checked)
			{
				UUIItem item = base.GetItem(1);
				BaseBehaviorTree tree = this.Tree;
				SilentAreaShowInfo silentAreaInfo = (tree != null) ? tree.GetSilentAreaShowInfo() : null;
				this.Panel.CreateAndShow("UiItem_HoverTipsC", item, silentAreaInfo);
				return;
			}
			this.Panel.EndShow();
		}

		// Token: 0x0603CFED RID: 249837 RVA: 0x00EAA540 File Offset: 0x00EA8740
		private void OnToggleSilentAreaInfoView()
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

		// Token: 0x0401FC70 RID: 130160
		[Nullable(2)]
		private SilentAreaInfoPanel Panel;

		// Token: 0x0401FC71 RID: 130161
		private long TreeIncId;

		// Token: 0x0401FC72 RID: 130162
		[Nullable(2)]
		private BaseBehaviorTree Tree;

		// Token: 0x0200C0C6 RID: 49350
		private enum EVisibleReason
		{
			// Token: 0x0403A29E RID: 238238
			Default = 1
		}

		// Token: 0x0200C0C7 RID: 49351
		private enum EChildComponent
		{
			// Token: 0x0403A2A0 RID: 238240
			Toggle,
			// Token: 0x0403A2A1 RID: 238241
			PanelNode
		}
	}
}
