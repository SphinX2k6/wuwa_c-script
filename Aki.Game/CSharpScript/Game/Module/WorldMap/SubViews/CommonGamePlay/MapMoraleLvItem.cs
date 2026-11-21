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
	// Token: 0x02003770 RID: 14192
	[NullableContext(1)]
	[Nullable(0)]
	public class MapMoraleLvItem : UiPanelBase
	{
		// Token: 0x06024E3E RID: 151102 RVA: 0x00A6C570 File Offset: 0x00A6A770
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

		// Token: 0x06024E3F RID: 151103 RVA: 0x00A6C5C4 File Offset: 0x00A6A7C4
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

		// Token: 0x06024E40 RID: 151104 RVA: 0x00A6C64E File Offset: 0x00A6A84E
		public void UpdateTitle(string titleId)
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(titleId);
		}

		// Token: 0x06024E41 RID: 151105 RVA: 0x00A6C662 File Offset: 0x00A6A862
		public void UpdateLv(int lv)
		{
			UUIArtText artText = base.GetArtText(1);
			if (artText == null)
			{
				return;
			}
			artText.SetText(lv.ToString());
		}

		// Token: 0x06024E42 RID: 151106 RVA: 0x00A6C67C File Offset: 0x00A6A87C
		public void UpdateLvColor(string hexColor)
		{
			UUIArtText artText = base.GetArtText(1);
			if (artText == null)
			{
				return;
			}
			artText.SetColor(FColor.FromHex(hexColor));
		}

		// Token: 0x06024E43 RID: 151107 RVA: 0x00A6C695 File Offset: 0x00A6A895
		public void UpdateBgColor(string hexColor)
		{
			UUITexture texture = base.GetTexture(2);
			if (texture == null)
			{
				return;
			}
			texture.SetColor(FColor.FromHex(hexColor));
		}

		// Token: 0x06024E44 RID: 151108 RVA: 0x00A6C6B0 File Offset: 0x00A6A8B0
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

		// Token: 0x020094CA RID: 38090
		[NullableContext(0)]
		public static class EChildType
		{
			// Token: 0x0402E782 RID: 190338
			public const int TxtTitle = 0;

			// Token: 0x0402E783 RID: 190339
			public const int ArtLv = 1;

			// Token: 0x0402E784 RID: 190340
			public const int TexBg = 2;
		}
	}
}
