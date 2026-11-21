using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FC9 RID: 20425
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SpringManorPhantomExhibitGrid : GridProxyAbstract<SpringManorPhantomDisplayItem>
	{
		// Token: 0x060332E3 RID: 209635 RVA: 0x00E57DFC File Offset: 0x00E55FFC
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

		// Token: 0x060332E4 RID: 209636 RVA: 0x00E57EA8 File Offset: 0x00E560A8
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

		// Token: 0x060332E5 RID: 209637 RVA: 0x00E57F18 File Offset: 0x00E56118
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

		// Token: 0x060332E6 RID: 209638 RVA: 0x00E57FB6 File Offset: 0x00E561B6
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

		// Token: 0x060332E7 RID: 209639 RVA: 0x00E57FE2 File Offset: 0x00E561E2
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x060332E8 RID: 209640 RVA: 0x00E57FF5 File Offset: 0x00E561F5
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0401B2A5 RID: 111269
		private SpringManorPhantomExhibitIconItem MonsterItem;

		// Token: 0x0401B2A6 RID: 111270
		public Func<int, bool> CanToggleChange;

		// Token: 0x0401B2A7 RID: 111271
		public Action<int, int> OnToggleClick;

		// Token: 0x0401B2A8 RID: 111272
		private SpringManorPhantomDisplayItem Data;
	}
}
