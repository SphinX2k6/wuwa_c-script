using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DA7 RID: 19879
	public class SilentAreaView : BattleVisibleChildView
	{
		// Token: 0x1700623E RID: 25150
		// (get) Token: 0x06031F5A RID: 204634 RVA: 0x00DFB202 File Offset: 0x00DF9402
		public long Id
		{
			get
			{
				return this.TreeIncId;
			}
		}

		// Token: 0x06031F5B RID: 204635 RVA: 0x00DFB20A File Offset: 0x00DF940A
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.MiniMap);
			base.SetVisible(1, false);
			this.Panel = new SilentAreaInfoPanel();
			this.AddEvents();
		}

		// Token: 0x06031F5C RID: 204636 RVA: 0x00DFB233 File Offset: 0x00DF9433
		public override void Reset()
		{
			base.Reset();
			this.RemoveEvents();
		}

		// Token: 0x06031F5D RID: 204637 RVA: 0x00DFB244 File Offset: 0x00DF9444
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

		// Token: 0x06031F5E RID: 204638 RVA: 0x00DFB2EA File Offset: 0x00DF94EA
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.BattleUiToggleSilentAreaInfoView, new Action(this.OnToggleSilentAreaInfoView));
		}

		// Token: 0x06031F5F RID: 204639 RVA: 0x00DFB308 File Offset: 0x00DF9508
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiToggleSilentAreaInfoView, new Action(this.OnToggleSilentAreaInfoView));
		}

		// Token: 0x06031F60 RID: 204640 RVA: 0x00DFB326 File Offset: 0x00DF9526
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

		// Token: 0x06031F61 RID: 204641 RVA: 0x00DFB368 File Offset: 0x00DF9568
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

		// Token: 0x06031F62 RID: 204642 RVA: 0x00DFB3B5 File Offset: 0x00DF95B5
		protected override void OnAfterDestroy()
		{
			BattleUiEnvironmentKeyData environmentKeyData = BattleUiModel.Instance.EnvironmentKeyData;
			if (environmentKeyData == null)
			{
				return;
			}
			environmentKeyData.SetEnvironmentKeyVisible(EEnvironmentKey.SilentArea, false);
		}

		// Token: 0x06031F63 RID: 204643 RVA: 0x00DFB3D0 File Offset: 0x00DF95D0
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

		// Token: 0x06031F64 RID: 204644 RVA: 0x00DFB41C File Offset: 0x00DF961C
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

		// Token: 0x0401A72D RID: 108333
		[Nullable(2)]
		private SilentAreaInfoPanel Panel;

		// Token: 0x0401A72E RID: 108334
		private long TreeIncId;

		// Token: 0x0401A72F RID: 108335
		[Nullable(2)]
		private BaseBehaviorTree Tree;

		// Token: 0x0200AACF RID: 43727
		private enum EVisibleReason
		{
			// Token: 0x04034C70 RID: 216176
			Default = 1
		}

		// Token: 0x0200AAD0 RID: 43728
		private enum EChildComponent
		{
			// Token: 0x04034C72 RID: 216178
			Toggle,
			// Token: 0x04034C73 RID: 216179
			PanelNode
		}
	}
}
