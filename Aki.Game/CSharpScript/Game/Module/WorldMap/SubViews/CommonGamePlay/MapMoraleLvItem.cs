using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.CommonGamePlay
{
	// Token: 0x0200483F RID: 18495
	[NullableContext(1)]
	[Nullable(0)]
	public class MapMoraleLvItem : UiPanelBase
	{
		// Token: 0x0603066E RID: 198254 RVA: 0x00B3C388 File Offset: 0x00B3A588
		public UniTask Init(UUIItem parentItem, string resId = "UiItem_MapTipMorale")
		{
			MapMoraleLvItem.<Init>d__1 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.parentItem = parentItem;
			<Init>d__.resId = resId;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MapMoraleLvItem.<Init>d__1>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0603066F RID: 198255 RVA: 0x00B3C3DC File Offset: 0x00B3A5DC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06030670 RID: 198256 RVA: 0x00B3C466 File Offset: 0x00B3A666
		public void UpdateTitle(string titleId)
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(titleId);
		}

		// Token: 0x06030671 RID: 198257 RVA: 0x00B3C47A File Offset: 0x00B3A67A
		public void UpdateLv(int lv)
		{
			UUIArtText artText = base.GetArtText(1);
			if (artText == null)
			{
				return;
			}
			artText.SetText(lv.ToString());
		}

		// Token: 0x06030672 RID: 198258 RVA: 0x00B3C494 File Offset: 0x00B3A694
		public void UpdateLvColor(string hexColor)
		{
			UUIArtText artText = base.GetArtText(1);
			if (artText == null)
			{
				return;
			}
			artText.SetColor(FColor.FromHex(hexColor));
		}

		// Token: 0x06030673 RID: 198259 RVA: 0x00B3C4AD File Offset: 0x00B3A6AD
		public void UpdateBgColor(string hexColor)
		{
			UUITexture texture = base.GetTexture(2);
			if (texture == null)
			{
				return;
			}
			texture.SetColor(FColor.FromHex(hexColor));
		}

		// Token: 0x06030674 RID: 198260 RVA: 0x00B3C4C8 File Offset: 0x00B3A6C8
		public void UpdateData(IMapMoraleLvItemData data)
		{
			this.UpdateTitle(data.TitleId);
			this.UpdateLv(data.Lv);
			if (!string.IsNullOrEmpty(data.LvColor))
			{
				this.UpdateLvColor(data.LvColor);
			}
			if (!string.IsNullOrEmpty(data.BgColor))
			{
				this.UpdateBgColor(data.BgColor);
			}
		}

		// Token: 0x0200AB1C RID: 43804
		[NullableContext(0)]
		public static class EChildType
		{
			// Token: 0x04034007 RID: 212999
			public const int TxtTitle = 0;

			// Token: 0x04034008 RID: 213000
			public const int ArtLv = 1;

			// Token: 0x04034009 RID: 213001
			public const int TexBg = 2;
		}
	}
}
