using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005F9F RID: 24479
	public class TotalTopUpPickRoleItemPanel : UiPanelBase
	{
		// Token: 0x0603E161 RID: 254305 RVA: 0x00EFE2A4 File Offset: 0x00EFC4A4
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

		// Token: 0x0603E162 RID: 254306 RVA: 0x00EFE30C File Offset: 0x00EFC50C
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

		// Token: 0x0603E163 RID: 254307 RVA: 0x00EFE381 File Offset: 0x00EFC581
		private void OnClickCheck()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ItemId, false, null);
		}

		// Token: 0x040206E7 RID: 132839
		private int ItemId;
	}
}
