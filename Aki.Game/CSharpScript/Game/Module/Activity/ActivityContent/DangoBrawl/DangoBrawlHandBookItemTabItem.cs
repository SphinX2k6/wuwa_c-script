using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006807 RID: 26631
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlHandBookItemTabItem : GridProxyAbstract<DangoBrawlHandBookItemTabData>
	{
		// Token: 0x060426AB RID: 272043 RVA: 0x0102112C File Offset: 0x0101F32C
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

		// Token: 0x060426AC RID: 272044 RVA: 0x01021235 File Offset: 0x0101F435
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

		// Token: 0x060426AD RID: 272045 RVA: 0x01021274 File Offset: 0x0101F474
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

		// Token: 0x060426AE RID: 272046 RVA: 0x0102135D File Offset: 0x0101F55D
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true, fireEvent);
		}

		// Token: 0x060426AF RID: 272047 RVA: 0x01021367 File Offset: 0x0101F567
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false, fireEvent);
		}

		// Token: 0x060426B0 RID: 272048 RVA: 0x01021374 File Offset: 0x0101F574
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

		// Token: 0x060426B1 RID: 272049 RVA: 0x0102139E File Offset: 0x0101F59E
		public void SetRedDotVisible(bool visible)
		{
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(visible);
		}

		// Token: 0x060426B2 RID: 272050 RVA: 0x010213B4 File Offset: 0x0101F5B4
		private bool OnCanExecuteChange()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(4);
			return extendToggle == null || extendToggle.GetToggleState() != EToggleState.ETT_Checked;
		}

		// Token: 0x060426B3 RID: 272051 RVA: 0x010213DA File Offset: 0x0101F5DA
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

		// Token: 0x040229E2 RID: 141794
		private const string ALL_ICON_PATH = "T_DangoBrawl_HandBook_All";

		// Token: 0x040229E3 RID: 141795
		private const string ALL_NAME = "Text_FilterTextAll_Text";

		// Token: 0x040229E4 RID: 141796
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, DangoBrawlHandBookItemTabData> OnClickToggleBack;

		// Token: 0x040229E5 RID: 141797
		[Nullable(2)]
		private DangoBrawlHandBookItemTabData Data;

		// Token: 0x0200C97A RID: 51578
		[NullableContext(0)]
		private enum EItemComponent
		{
			// Token: 0x0403CD72 RID: 249202
			TexIcon,
			// Token: 0x0403CD73 RID: 249203
			TxtName,
			// Token: 0x0403CD74 RID: 249204
			SprLine,
			// Token: 0x0403CD75 RID: 249205
			RedDotItem,
			// Token: 0x0403CD76 RID: 249206
			TogItem
		}
	}
}
