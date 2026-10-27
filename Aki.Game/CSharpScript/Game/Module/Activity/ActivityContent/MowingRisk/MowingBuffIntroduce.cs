using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063D9 RID: 25561
	public class MowingBuffIntroduce : UiPanelBase
	{
		// Token: 0x060404A7 RID: 263335 RVA: 0x00F8C8FC File Offset: 0x00F8AAFC
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

		// Token: 0x060404A8 RID: 263336 RVA: 0x00F8CACE File Offset: 0x00F8ACCE
		protected override void OnStart()
		{
			UUISprite sprite = base.GetSprite(8);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(false);
		}

		// Token: 0x060404A9 RID: 263337 RVA: 0x00F8CAE4 File Offset: 0x00F8ACE4
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

		// Token: 0x060404AA RID: 263338 RVA: 0x00F8CC58 File Offset: 0x00F8AE58
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

		// Token: 0x060404AB RID: 263339 RVA: 0x00F8CCDE File Offset: 0x00F8AEDE
		private void OnClickToggle(EToggleState _)
		{
		}

		// Token: 0x04021749 RID: 137033
		private const float GRAY_ALPHA = 0.3f;

		// Token: 0x0200C5D9 RID: 50649
		private class EComponent
		{
			// Token: 0x0403BBC8 RID: 244680
			public const int Toggle = 0;

			// Token: 0x0403BBC9 RID: 244681
			public const int BackgroundTexture = 1;

			// Token: 0x0403BBCA RID: 244682
			public const int LevelText = 2;

			// Token: 0x0403BBCB RID: 244683
			public const int NameText = 3;

			// Token: 0x0403BBCC RID: 244684
			public const int TipsText = 4;

			// Token: 0x0403BBCD RID: 244685
			public const int IconTexture = 5;

			// Token: 0x0403BBCE RID: 244686
			public const int QualityBlueNiagara = 6;

			// Token: 0x0403BBCF RID: 244687
			public const int LockSprite = 7;

			// Token: 0x0403BBD0 RID: 244688
			public const int QualitySprite = 8;

			// Token: 0x0403BBD1 RID: 244689
			public const int QualityPurpleNiagara = 9;

			// Token: 0x0403BBD2 RID: 244690
			public const int QualityGoldNiagara = 10;
		}
	}
}
