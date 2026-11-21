using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02003C91 RID: 15505
	public class RoleAttributeItem : UiPanelBase
	{
		// Token: 0x06027A95 RID: 162453 RVA: 0x00B1B778 File Offset: 0x00B19978
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
		}

		// Token: 0x06027A96 RID: 162454 RVA: 0x00B1B814 File Offset: 0x00B19A14
		[NullableContext(1)]
		public void Refresh(IAttributeInfo attrInfo)
		{
			this.RefreshName(attrInfo.Name);
			this.RefreshIcon(attrInfo.IconPath);
			base.GetItem(2).SetUIActive(attrInfo.ShowArrow.GetValueOrDefault(true));
			UUIText[] array = new UUIText[]
			{
				base.GetText(3),
				base.GetText(1)
			};
			string[] array2 = new string[]
			{
				attrInfo.PreText,
				attrInfo.CurText
			};
			for (int i = 0; i < array.Length; i++)
			{
				this.RefreshValueText(array[i], array2[i]);
			}
			if (attrInfo.InnerShowBg != null)
			{
				this.RefreshBgActive(attrInfo.InnerShowBg.Value);
			}
		}

		// Token: 0x06027A97 RID: 162455 RVA: 0x00B1B8C8 File Offset: 0x00B19AC8
		[NullableContext(2)]
		private void RefreshIcon(string path)
		{
			if (path != null)
			{
				base.SetTextureByPath(path, base.GetTexture(4), null, null);
			}
			base.GetTexture(4).SetUIActive(path != null);
		}

		// Token: 0x06027A98 RID: 162456 RVA: 0x00B1B900 File Offset: 0x00B19B00
		[NullableContext(2)]
		private void RefreshName(string textId)
		{
			if (textId != null)
			{
				base.GetText(0).ShowTextNew(textId);
			}
			base.GetText(0).SetUIActive(textId != null);
		}

		// Token: 0x06027A99 RID: 162457 RVA: 0x00B1B922 File Offset: 0x00B19B22
		[NullableContext(1)]
		private void RefreshValueText(UUIText textItem, [Nullable(2)] string text)
		{
			if (text != null)
			{
				textItem.SetText(text, true);
			}
			textItem.SetUIActive(text != null);
		}

		// Token: 0x06027A9A RID: 162458 RVA: 0x00B1B93C File Offset: 0x00B19B3C
		private void RefreshBgActive(bool bActive)
		{
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(bActive);
			}
		}

		// Token: 0x02009879 RID: 39033
		private enum EAttributeItemNode
		{
			// Token: 0x0402F8AF RID: 194735
			AttributeText,
			// Token: 0x0402F8B0 RID: 194736
			ValueText,
			// Token: 0x0402F8B1 RID: 194737
			ArrowItem,
			// Token: 0x0402F8B2 RID: 194738
			PreValueText,
			// Token: 0x0402F8B3 RID: 194739
			AttributeIcon,
			// Token: 0x0402F8B4 RID: 194740
			Bg
		}
	}
}
