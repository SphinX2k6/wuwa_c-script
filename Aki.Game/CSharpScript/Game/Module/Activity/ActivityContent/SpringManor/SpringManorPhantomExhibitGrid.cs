using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x0200604B RID: 24651
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SpringManorPhantomExhibitGrid : GridProxyAbstract<SpringManorPhantomDisplayItem>
	{
		// Token: 0x0603E61F RID: 255519 RVA: 0x00F11038 File Offset: 0x00F0F238
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleClick))
			};
		}

		// Token: 0x0603E620 RID: 255520 RVA: 0x00F110E4 File Offset: 0x00F0F2E4
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.CanExecuteChange.Bind(() => this.CanToggleChange == null || this.CanToggleChange(base.GridIndex));
			}
			this.MonsterItem = new SpringManorPhantomExhibitIconItem();
			this.MonsterItem.CreateThenShowByActor(base.GetItem(1).GetOwner());
			this.MonsterItem.SetToggleInteractive(false);
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0603E621 RID: 255521 RVA: 0x00F11154 File Offset: 0x00F0F354
		[NullableContext(1)]
		public override void Refresh(SpringManorPhantomDisplayItem data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.MonsterItem.Refresh(data);
			EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			PhantomItem? phantomItem;
			string key = ((PhantomBattleConfig.Instance.GetPhantomItemById(data.PhantomId) != null) ? phantomItem.GetValueOrDefault().MonsterName : null) ?? "";
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.ShowTextNew(key);
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(state, false, false, false);
			}
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(data.IsSelected);
		}

		// Token: 0x0603E622 RID: 255522 RVA: 0x00F111F2 File Offset: 0x00F0F3F2
		private void ToggleClick(EToggleState state)
		{
			if (this.Data == null)
			{
				return;
			}
			Action<int, int> onToggleClick = this.OnToggleClick;
			if (onToggleClick == null)
			{
				return;
			}
			onToggleClick(this.Data.PhantomId, base.GridIndex);
		}

		// Token: 0x0603E623 RID: 255523 RVA: 0x00F1121E File Offset: 0x00F0F41E
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x0603E624 RID: 255524 RVA: 0x00F11231 File Offset: 0x00F0F431
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x04020978 RID: 133496
		private SpringManorPhantomExhibitIconItem MonsterItem;

		// Token: 0x04020979 RID: 133497
		public Func<int, bool> CanToggleChange;

		// Token: 0x0402097A RID: 133498
		public Action<int, int> OnToggleClick;

		// Token: 0x0402097B RID: 133499
		private SpringManorPhantomDisplayItem Data;
	}
}
