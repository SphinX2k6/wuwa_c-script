using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x02005357 RID: 21335
	public class MowingBuffIntroduce : UiPanelBase
	{
		// Token: 0x06035168 RID: 217448 RVA: 0x00ED3894 File Offset: 0x00ED1A94
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06035169 RID: 217449 RVA: 0x00ED3A66 File Offset: 0x00ED1C66
		protected override void OnStart()
		{
			UUISprite sprite = base.GetSprite(8);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(false);
		}

		// Token: 0x0603516A RID: 217450 RVA: 0x00ED3A7C File Offset: 0x00ED1C7C
		[NullableContext(1)]
		public void RefreshByCustomData(IMowingBuffIntroduceData data)
		{
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetUIActive(data.LevelTextId != null);
			}
			if (!string.IsNullOrEmpty(data.LevelTextId))
			{
				LguiUtil.Instance.SetLocalTextNew(text, data.LevelTextId, data.LevelTextArgs);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), data.NameTextId, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), data.TipsTextId, data.TipsArgs);
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				texture.SetUIActive(data.BackgroundPath != null);
			}
			if (!string.IsNullOrEmpty(data.BackgroundPath))
			{
				base.SetTextureByPath(data.BackgroundPath, texture, null, null);
			}
			UUITexture texture2 = base.GetTexture(5);
			if (texture2 != null)
			{
				texture2.SetUIActive(data.IconPath != null);
			}
			if (!string.IsNullOrEmpty(data.IconPath))
			{
				base.SetTextureByPath(data.IconPath, texture2, null, null);
			}
			this.RefreshNiagaraByEnum(data.HexColor);
			UUISprite sprite = base.GetSprite(7);
			if (sprite != null)
			{
				sprite.SetUIActive(!data.IsUnlock);
			}
			if (text != null)
			{
				UUIItem uuiitem = text;
				bool bUseChangeColor = !data.IsUnlock;
				FColor? fcolor = null;
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			}
			if (texture2 != null)
			{
				texture2.SetIsGray(!data.IsUnlock);
			}
			if (texture2 != null)
			{
				texture2.SetAlpha(data.IsUnlock ? 1f : 0.3f);
			}
		}

		// Token: 0x0603516B RID: 217451 RVA: 0x00ED3BF0 File Offset: 0x00ED1DF0
		[NullableContext(1)]
		private void RefreshNiagaraByEnum(string enumValue)
		{
			UUINiagara uiNiagara = base.GetUiNiagara(6);
			if (uiNiagara != null)
			{
				uiNiagara.SetUIActive(enumValue == EMowingBuffQualityHexColor.Blue.ToString());
			}
			UUINiagara uiNiagara2 = base.GetUiNiagara(9);
			if (uiNiagara2 != null)
			{
				uiNiagara2.SetUIActive(enumValue == EMowingBuffQualityHexColor.Purple.ToString());
			}
			UUINiagara uiNiagara3 = base.GetUiNiagara(10);
			if (uiNiagara3 == null)
			{
				return;
			}
			uiNiagara3.SetUIActive(enumValue == EMowingBuffQualityHexColor.Gold.ToString());
		}

		// Token: 0x0603516C RID: 217452 RVA: 0x00ED3C76 File Offset: 0x00ED1E76
		private void OnClickToggle(EToggleState _)
		{
		}

		// Token: 0x0401C078 RID: 114808
		private const float GRAY_ALPHA = 0.3f;

		// Token: 0x0200AFC0 RID: 44992
		private class EComponent
		{
			// Token: 0x04036527 RID: 222503
			public const int Toggle = 0;

			// Token: 0x04036528 RID: 222504
			public const int BackgroundTexture = 1;

			// Token: 0x04036529 RID: 222505
			public const int LevelText = 2;

			// Token: 0x0403652A RID: 222506
			public const int NameText = 3;

			// Token: 0x0403652B RID: 222507
			public const int TipsText = 4;

			// Token: 0x0403652C RID: 222508
			public const int IconTexture = 5;

			// Token: 0x0403652D RID: 222509
			public const int QualityBlueNiagara = 6;

			// Token: 0x0403652E RID: 222510
			public const int LockSprite = 7;

			// Token: 0x0403652F RID: 222511
			public const int QualitySprite = 8;

			// Token: 0x04036530 RID: 222512
			public const int QualityPurpleNiagara = 9;

			// Token: 0x04036531 RID: 222513
			public const int QualityGoldNiagara = 10;
		}
	}
}
