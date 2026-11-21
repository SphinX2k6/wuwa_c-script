using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041D6 RID: 16854
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CardDetailAttributeItem : GridProxyAbstract<CardDetailAttributeItemData>
	{
		// Token: 0x0602AA7C RID: 174716 RVA: 0x00C05770 File Offset: 0x00C03970
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x0602AA7D RID: 174717 RVA: 0x00C057CC File Offset: 0x00C039CC
		public override void Refresh(CardDetailAttributeItemData data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.AttributeName, Array.Empty<object>());
			base.GetText(2).SetText(data.AttributeValue.ToString(), true);
			this.RefreshHighLightState(data.IsHighLight);
		}

		// Token: 0x0602AA7E RID: 174718 RVA: 0x00C0581C File Offset: 0x00C03A1C
		public void RefreshHighLightState(bool isHighLight)
		{
			if (this.IsHighLight == isHighLight)
			{
				return;
			}
			this.IsHighLight = isHighLight;
			UUISprite sprite = base.GetSprite(0);
			UUIText text = base.GetText(1);
			UUIText text2 = base.GetText(2);
			string path = isHighLight ? "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity24/SoundRemnantArena/Outside/SP_CardAttrBg1.SP_CardAttrBg1" : "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity24/SoundRemnantArena/Outside/SP_CardAttrBg2.SP_CardAttrBg2";
			this.SetSpriteByPath(path, sprite, false, null, null);
			bool flag = !isHighLight;
			UUIItem uuiitem = sprite;
			bool bUseChangeColor = flag;
			FColor? fcolor = new FColor?(sprite.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			UUIItem uuiitem2 = text;
			bool bUseChangeColor2 = flag;
			fcolor = new FColor?(text.changeColor);
			uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
			UUIItem uuiitem3 = text2;
			bool bUseChangeColor3 = flag;
			fcolor = new FColor?(text2.changeColor);
			uuiitem3.SetChangeColor(bUseChangeColor3, fcolor);
		}

		// Token: 0x040171E2 RID: 94690
		private const string HIGH_LIGHT_BG_PATH = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity24/SoundRemnantArena/Outside/SP_CardAttrBg1.SP_CardAttrBg1";

		// Token: 0x040171E3 RID: 94691
		private const string BG_PATH = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity24/SoundRemnantArena/Outside/SP_CardAttrBg2.SP_CardAttrBg2";

		// Token: 0x040171E4 RID: 94692
		private bool IsHighLight = true;

		// Token: 0x02009DE4 RID: 40420
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x040311A0 RID: 201120
			public const int BgSprite = 0;

			// Token: 0x040311A1 RID: 201121
			public const int AttributeNameText = 1;

			// Token: 0x040311A2 RID: 201122
			public const int AttributeValueText = 2;
		}
	}
}
