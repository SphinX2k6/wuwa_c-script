using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View.Item
{
	// Token: 0x02005C24 RID: 23588
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingBuffTipsPanel : UiPanelBase
	{
		// Token: 0x0603B972 RID: 244082 RVA: 0x00E36910 File Offset: 0x00E34B10
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

		// Token: 0x0603B973 RID: 244083 RVA: 0x00E36A84 File Offset: 0x00E34C84
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

		// Token: 0x0401F063 RID: 127075
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

		// Token: 0x0401F064 RID: 127076
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

		// Token: 0x0200BE0E RID: 48654
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x040394F7 RID: 234743
			TexBg,
			// Token: 0x040394F8 RID: 234744
			TxtName,
			// Token: 0x040394F9 RID: 234745
			TxtTips,
			// Token: 0x040394FA RID: 234746
			TexIcon,
			// Token: 0x040394FB RID: 234747
			SpriteQuality,
			// Token: 0x040394FC RID: 234748
			NiagaraPurple,
			// Token: 0x040394FD RID: 234749
			NiagaraGold,
			// Token: 0x040394FE RID: 234750
			CountItem,
			// Token: 0x040394FF RID: 234751
			TxtCount,
			// Token: 0x04039500 RID: 234752
			NiagaraBlue
		}
	}
}
