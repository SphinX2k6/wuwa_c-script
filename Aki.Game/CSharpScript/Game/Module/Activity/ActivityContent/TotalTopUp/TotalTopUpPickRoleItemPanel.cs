using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F86 RID: 20358
	public class TotalTopUpPickRoleItemPanel : UiPanelBase
	{
		// Token: 0x060330FB RID: 209147 RVA: 0x00E4FF5C File Offset: 0x00E4E15C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnClickCheck))
			};
		}

		// Token: 0x060330FC RID: 209148 RVA: 0x00E4FFC4 File Offset: 0x00E4E1C4
		[NullableContext(1)]
		public void Refresh(TotalTopUpPickRoleViewModel viewModel)
		{
			if (viewModel.CurrentRoleId > 0)
			{
				return;
			}
			this.ItemId = viewModel.CurrentItemId;
			CSharpScript.Game.Module.Inventory.ItemConfig currentSelectItemConfigData = viewModel.CurrentSelectItemConfigData;
			UUIText text = base.GetText(0);
			TableTextArgNew tableTextArgNew = new TableTextArgNew((currentSelectItemConfigData != null) ? currentSelectItemConfigData.Name : null, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(text, "Text_ItemNameShowCount_Text", new <>z__ReadOnlyArray<object>(new object[]
			{
				tableTextArgNew,
				viewModel.CurrentItemCount
			}));
		}

		// Token: 0x060330FD RID: 209149 RVA: 0x00E50039 File Offset: 0x00E4E239
		private void OnClickCheck()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ItemId, false, null, false);
		}

		// Token: 0x0401B1B9 RID: 111033
		private int ItemId;
	}
}
