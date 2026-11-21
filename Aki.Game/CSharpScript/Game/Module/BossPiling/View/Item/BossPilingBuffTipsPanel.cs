using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View.Item
{
	// Token: 0x02004C04 RID: 19460
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingBuffTipsPanel : UiPanelBase
	{
		// Token: 0x060308BD RID: 198845 RVA: 0x00D86C6C File Offset: 0x00D84E6C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060308BE RID: 198846 RVA: 0x00D86DE0 File Offset: 0x00D84FE0
		public void Refresh(BossPilingBuffCountInfo buffInfo)
		{
			UUISprite sprite = base.GetSprite(4);
			if (sprite != null)
			{
				sprite.SetUIActive(true);
			}
			BossPilingBuff value = BossPilingConfig.Instance.GetBuffInfo(buffInfo.BuffId).Value;
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.ShowTextNew(value.Name);
			}
			base.SetTextureByPath(value.Icon, base.GetTexture(3), null, null);
			UUINiagara uiNiagara = base.GetUiNiagara(5);
			if (uiNiagara != null)
			{
				uiNiagara.SetUIActive(value.Quality == 3);
			}
			UUINiagara uiNiagara2 = base.GetUiNiagara(5);
			if (uiNiagara2 != null)
			{
				uiNiagara2.SetUIActive(value.Quality == 4);
			}
			UUINiagara uiNiagara3 = base.GetUiNiagara(6);
			if (uiNiagara3 != null)
			{
				uiNiagara3.SetUIActive(value.Quality == 5);
			}
			string valueOrDefault = BossPilingBuffTipsPanel.QualityTexMap.GetValueOrDefault(value.Quality, "");
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(valueOrDefault);
			base.SetTextureByPath(resourcePath, base.GetTexture(0), null, null);
			string valueOrDefault2 = BossPilingBuffTipsPanel.QualitySpriteMap.GetValueOrDefault(value.Quality, "");
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath(valueOrDefault2);
			this.SetSpriteByPath(resourcePath2, base.GetSprite(4), false, null, null);
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(buffInfo.Count > 1);
			}
			if (buffInfo.Count > 1)
			{
				UUIText text2 = base.GetText(8);
				if (text2 != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
					defaultInterpolatedStringHandler.AppendLiteral("x");
					defaultInterpolatedStringHandler.AppendFormatted<int>(buffInfo.Count);
					text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				}
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), value.Desc, value.DescArgs());
		}

		// Token: 0x04019B14 RID: 105236
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<int, string> QualityTexMap = new Dictionary<int, string>
		{
			{
				3,
				"T_BossPilingCollectionQualityBlue"
			},
			{
				4,
				"T_BossPilingCollectionQualityPurple"
			},
			{
				5,
				"T_BossPilingCollectionQualityGold"
			}
		};

		// Token: 0x04019B15 RID: 105237
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<int, string> QualitySpriteMap = new Dictionary<int, string>
		{
			{
				3,
				"SP_QualityBlueA"
			},
			{
				4,
				"SP_QualityPurpleA"
			},
			{
				5,
				"SP_QualityGlodA"
			}
		};

		// Token: 0x0200A816 RID: 43030
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x04033EBA RID: 212666
			TexBg,
			// Token: 0x04033EBB RID: 212667
			TxtName,
			// Token: 0x04033EBC RID: 212668
			TxtTips,
			// Token: 0x04033EBD RID: 212669
			TexIcon,
			// Token: 0x04033EBE RID: 212670
			SpriteQuality,
			// Token: 0x04033EBF RID: 212671
			NiagaraPurple,
			// Token: 0x04033EC0 RID: 212672
			NiagaraGold,
			// Token: 0x04033EC1 RID: 212673
			CountItem,
			// Token: 0x04033EC2 RID: 212674
			TxtCount,
			// Token: 0x04033EC3 RID: 212675
			NiagaraBlue
		}
	}
}
