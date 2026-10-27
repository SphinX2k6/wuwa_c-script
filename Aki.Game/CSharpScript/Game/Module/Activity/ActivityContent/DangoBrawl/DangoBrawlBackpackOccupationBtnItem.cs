using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067E3 RID: 26595
	public class DangoBrawlBackpackOccupationBtnItem : UiPanelBase
	{
		// Token: 0x060423BD RID: 271293 RVA: 0x01012138 File Offset: 0x01010338
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

		// Token: 0x060423BE RID: 271294 RVA: 0x01012220 File Offset: 0x01010420
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

		// Token: 0x060423BF RID: 271295 RVA: 0x010122FC File Offset: 0x010104FC
		private void OnClickItem()
		{
			DangoBrawlHandBookViewOpenData param = new DangoBrawlHandBookViewOpenData
			{
				Tab = EDangoBrawlHandBookTab.Occupation,
				SelectedOccupationId = new int?(this.OccupationId)
			};
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlHandBookView, param, null);
		}

		// Token: 0x04022909 RID: 141577
		private int OccupationId;

		// Token: 0x0200C8FA RID: 51450
		private enum EBtnComponents
		{
			// Token: 0x0403CAC5 RID: 248517
			BtnItem,
			// Token: 0x0403CAC6 RID: 248518
			TexIcon,
			// Token: 0x0403CAC7 RID: 248519
			TxtDesc,
			// Token: 0x0403CAC8 RID: 248520
			TxtDescExtra
		}
	}
}
