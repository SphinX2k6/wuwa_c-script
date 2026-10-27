using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02004CDF RID: 19679
	public class RoleAttributeItem : UiPanelBase
	{
		// Token: 0x06032CC0 RID: 208064 RVA: 0x00BD6070 File Offset: 0x00BD4270
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

		// Token: 0x06032CC1 RID: 208065 RVA: 0x00BD610C File Offset: 0x00BD430C
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

		// Token: 0x06032CC2 RID: 208066 RVA: 0x00BD61C0 File Offset: 0x00BD43C0
		[NullableContext(2)]
		private void RefreshIcon(string path)
		{
			if (path != null)
			{
				base.SetTextureByPath(path, base.GetTexture(4), null, null);
			}
			base.GetTexture(4).SetUIActive(path != null);
		}

		// Token: 0x06032CC3 RID: 208067 RVA: 0x00BD61F8 File Offset: 0x00BD43F8
		[NullableContext(2)]
		private void RefreshName(string textId)
		{
			if (textId != null)
			{
				base.GetText(0).ShowTextNew(textId);
			}
			base.GetText(0).SetUIActive(textId != null);
		}

		// Token: 0x06032CC4 RID: 208068 RVA: 0x00BD621A File Offset: 0x00BD441A
		[NullableContext(1)]
		private void RefreshValueText(UUIText textItem, [Nullable(2)] string text)
		{
			if (text != null)
			{
				textItem.SetText(text, true);
			}
			textItem.SetUIActive(text != null);
		}

		// Token: 0x06032CC5 RID: 208069 RVA: 0x00BD6234 File Offset: 0x00BD4434
		private void RefreshBgActive(bool bActive)
		{
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(bActive);
			}
		}

		// Token: 0x0200AE5A RID: 44634
		private enum EAttributeItemNode
		{
			// Token: 0x04034F07 RID: 216839
			AttributeText,
			// Token: 0x04034F08 RID: 216840
			ValueText,
			// Token: 0x04034F09 RID: 216841
			ArrowItem,
			// Token: 0x04034F0A RID: 216842
			PreValueText,
			// Token: 0x04034F0B RID: 216843
			AttributeIcon,
			// Token: 0x04034F0C RID: 216844
			Bg
		}
	}
}
