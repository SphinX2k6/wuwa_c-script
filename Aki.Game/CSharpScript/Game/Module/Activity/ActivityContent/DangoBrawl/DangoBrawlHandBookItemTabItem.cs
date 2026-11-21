using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005757 RID: 22359
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlHandBookItemTabItem : GridProxyAbstract<DangoBrawlHandBookItemTabData>
	{
		// Token: 0x06037200 RID: 225792 RVA: 0x00F62670 File Offset: 0x00F60870
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06037201 RID: 225793 RVA: 0x00F62779 File Offset: 0x00F60979
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(4);
			if (extendToggle != null)
			{
				extendToggle.CanExecuteChange.Unbind();
			}
			if (extendToggle != null)
			{
				extendToggle.CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
			}
			this.SetToggleState(false, false);
		}

		// Token: 0x06037202 RID: 225794 RVA: 0x00F627B8 File Offset: 0x00F609B8
		public override void Refresh(DangoBrawlHandBookItemTabData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			EDangoBrawlHandBookItemType itemType = data.ItemType;
			if (itemType == EDangoBrawlHandBookItemType.All)
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_DangoBrawl_HandBook_All");
				base.SetTextureByPath(resourcePath, base.GetTexture(0), null, null);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Text_FilterTextAll_Text", Array.Empty<object>());
			}
			else
			{
				DangoBrawlItemType? itemTypeConfigById = DangoBrawlConfig.Instance.GetItemTypeConfigById((int)itemType);
				if (itemTypeConfigById != null)
				{
					base.SetTextureByPath(itemTypeConfigById.Value.Icon, base.GetTexture(0), null, null);
					LguiUtil.Instance.SetLocalTextNew(base.GetText(1), itemTypeConfigById.Value.Name, Array.Empty<object>());
				}
			}
			UUISprite sprite = base.GetSprite(2);
			if (sprite != null)
			{
				sprite.SetUIActive(data.IsShowLine);
			}
			this.SetRedDotVisible(data.HasNew);
		}

		// Token: 0x06037203 RID: 225795 RVA: 0x00F628A1 File Offset: 0x00F60AA1
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true, fireEvent);
		}

		// Token: 0x06037204 RID: 225796 RVA: 0x00F628AB File Offset: 0x00F60AAB
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false, fireEvent);
		}

		// Token: 0x06037205 RID: 225797 RVA: 0x00F628B8 File Offset: 0x00F60AB8
		private void SetToggleState(bool state, bool fireEvent)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(4);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(state2, fireEvent, false, false);
		}

		// Token: 0x06037206 RID: 225798 RVA: 0x00F628E2 File Offset: 0x00F60AE2
		public void SetRedDotVisible(bool visible)
		{
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(visible);
		}

		// Token: 0x06037207 RID: 225799 RVA: 0x00F628F8 File Offset: 0x00F60AF8
		private bool OnCanExecuteChange()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(4);
			return extendToggle == null || extendToggle.GetToggleState() != EToggleState.ETT_Checked;
		}

		// Token: 0x06037208 RID: 225800 RVA: 0x00F6291E File Offset: 0x00F60B1E
		private void OnToggleClick(EToggleState state)
		{
			if (this.Data == null)
			{
				return;
			}
			Action<int, DangoBrawlHandBookItemTabData> onClickToggleBack = this.OnClickToggleBack;
			if (onClickToggleBack == null)
			{
				return;
			}
			onClickToggleBack(base.GridIndex, this.Data);
		}

		// Token: 0x0401D23F RID: 119359
		private const string ALL_ICON_PATH = "T_DangoBrawl_HandBook_All";

		// Token: 0x0401D240 RID: 119360
		private const string ALL_NAME = "Text_FilterTextAll_Text";

		// Token: 0x0401D241 RID: 119361
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, DangoBrawlHandBookItemTabData> OnClickToggleBack;

		// Token: 0x0401D242 RID: 119362
		[Nullable(2)]
		private DangoBrawlHandBookItemTabData Data;

		// Token: 0x0200B347 RID: 45895
		[NullableContext(0)]
		private enum EItemComponent
		{
			// Token: 0x0403765F RID: 226911
			TexIcon,
			// Token: 0x04037660 RID: 226912
			TxtName,
			// Token: 0x04037661 RID: 226913
			SprLine,
			// Token: 0x04037662 RID: 226914
			RedDotItem,
			// Token: 0x04037663 RID: 226915
			TogItem
		}
	}
}
