using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005733 RID: 22323
	public class DangoBrawlBackpackOccupationBtnItem : UiPanelBase
	{
		// Token: 0x06036F13 RID: 225043 RVA: 0x00F535D0 File Offset: 0x00F517D0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickItem));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06036F14 RID: 225044 RVA: 0x00F536B8 File Offset: 0x00F518B8
		public void Refresh(int occupationId)
		{
			this.OccupationId = occupationId;
			DangoBrawlOccupation? occupationConfigById = DangoBrawlConfig.Instance.GetOccupationConfigById(occupationId);
			string text = ((occupationConfigById != null) ? occupationConfigById.GetValueOrDefault().ColorBackpack : null) ?? "";
			string path = ((occupationConfigById != null) ? occupationConfigById.GetValueOrDefault().IconRound : null) ?? "";
			base.SetTextureByPath(path, base.GetTexture(1), null, null);
			if (!string.IsNullOrEmpty(text))
			{
				FColor fontOutlineColor = FColor.FromHex(text);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "DangoBrawlGeneral_1030", Array.Empty<object>());
				LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "DangoBrawlGeneral_1030", Array.Empty<object>());
				UUIText text2 = base.GetText(3);
				if (text2 == null)
				{
					return;
				}
				text2.SetFontOutlineColor(fontOutlineColor);
			}
		}

		// Token: 0x06036F15 RID: 225045 RVA: 0x00F53794 File Offset: 0x00F51994
		private void OnClickItem()
		{
			DangoBrawlHandBookViewOpenData param = new DangoBrawlHandBookViewOpenData
			{
				Tab = EDangoBrawlHandBookTab.Occupation,
				SelectedOccupationId = new int?(this.OccupationId)
			};
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlHandBookView, param, null);
		}

		// Token: 0x0401D166 RID: 119142
		private int OccupationId;

		// Token: 0x0200B2CA RID: 45770
		private enum EBtnComponents
		{
			// Token: 0x040373BA RID: 226234
			BtnItem,
			// Token: 0x040373BB RID: 226235
			TexIcon,
			// Token: 0x040373BC RID: 226236
			TxtDesc,
			// Token: 0x040373BD RID: 226237
			TxtDescExtra
		}
	}
}
