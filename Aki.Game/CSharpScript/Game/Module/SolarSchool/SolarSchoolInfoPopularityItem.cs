using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059B6 RID: 22966
	public class SolarSchoolInfoPopularityItem : UiPanelBase
	{
		// Token: 0x060389C4 RID: 231876 RVA: 0x00FD7198 File Offset: 0x00FD5398
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060389C5 RID: 231877 RVA: 0x00FD72C7 File Offset: 0x00FD54C7
		protected override void OnStart()
		{
			this.SetHelpGroupId();
		}

		// Token: 0x060389C6 RID: 231878 RVA: 0x00FD72D0 File Offset: 0x00FD54D0
		private void SetHelpGroupId()
		{
			UUIItem item = base.GetItem(5);
			object obj;
			if (item == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = item.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(UUIExtendButtonComponent.StaticClass()) : null);
			}
			UUIExtendButtonComponent uuiextendButtonComponent = obj as UUIExtendButtonComponent;
			if (uuiextendButtonComponent != null)
			{
				uuiextendButtonComponent.HelpGroupId = 702;
			}
		}

		// Token: 0x060389C7 RID: 231879 RVA: 0x00FD731C File Offset: 0x00FD551C
		public void Refresh(SolarSchoolInfoAttrData data)
		{
			UUISprite sprite = base.GetSprite(7);
			if (sprite != null)
			{
				sprite.SetUIActive(SolarSchoolGamePlayModel.Instance.PlayerData.IsAttrImportant(data.Attr));
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), data.NameTextId, Array.Empty<object>());
			base.TrySetTextureByPath(data.RankIconPath, base.GetTexture(1), null, null);
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(data.RankIconPath != null);
			}
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetText(data.Value.ToString(), true);
			}
			UUISliderComponent slider = base.GetSlider(4);
			if (slider == null)
			{
				return;
			}
			slider.SetValue(data.RankRatio, true);
		}

		// Token: 0x0200B561 RID: 46433
		private class EComponent
		{
			// Token: 0x04038147 RID: 229703
			public const int SprDesc = 0;

			// Token: 0x04038148 RID: 229704
			public const int TexScore = 1;

			// Token: 0x04038149 RID: 229705
			public const int TxtName = 2;

			// Token: 0x0403814A RID: 229706
			public const int TxtValue = 3;

			// Token: 0x0403814B RID: 229707
			public const int SldHorDefault = 4;

			// Token: 0x0403814C RID: 229708
			public const int BtnHelpInfo = 5;

			// Token: 0x0403814D RID: 229709
			public const int PnlLevel = 6;

			// Token: 0x0403814E RID: 229710
			public const int SprScratch = 7;
		}
	}
}
