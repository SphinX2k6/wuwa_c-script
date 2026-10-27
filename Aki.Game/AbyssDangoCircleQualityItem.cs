using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A21 RID: 6689
[NullableContext(1)]
[Nullable(0)]
public class AbyssDangoCircleQualityItem : UiPanelBase
{
	// Token: 0x0600C4D9 RID: 50393 RVA: 0x002CA21C File Offset: 0x002C841C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C4DA RID: 50394 RVA: 0x002CA370 File Offset: 0x002C8570
	protected override void OnStart()
	{
		this.SpriteList.Add(base.GetSprite(0));
		this.QualitySpriteMap[0] = base.GetSprite(0);
		this.SpriteList.Add(base.GetSprite(2));
		this.QualitySpriteMap[1] = base.GetSprite(2);
		this.SpriteList.Add(base.GetSprite(1));
		this.QualitySpriteMap[2] = base.GetSprite(1);
		for (int i = 0; i < 6; i++)
		{
			UUISprite sprite = base.GetSprite(8 - i);
			this.SpriteList.Add(sprite);
			this.QualitySpriteMap[i + 3] = sprite;
		}
		foreach (UUISprite uuisprite in this.SpriteList)
		{
			uuisprite.SetUIActive(false);
		}
	}

	// Token: 0x0600C4DB RID: 50395 RVA: 0x002CA464 File Offset: 0x002C8664
	public void RefreshData(DangoCircleQualityData data)
	{
		foreach (UUISprite uuisprite in this.SpriteList)
		{
			uuisprite.SetUIActive(false);
		}
		foreach (KeyValuePair<int, int> keyValuePair in data.PluginIdMap)
		{
			if (keyValuePair.Key == 0)
			{
				this.RefreshMiddleSprite(keyValuePair.Value);
			}
			else
			{
				this.RefreshOtherSprite(keyValuePair.Key, keyValuePair.Value);
			}
		}
	}

	// Token: 0x0600C4DC RID: 50396 RVA: 0x002CA51C File Offset: 0x002C871C
	private void RefreshMiddleSprite(int configId)
	{
		if (configId == 0)
		{
			this.QualitySpriteMap[0].SetUIActive(false);
			return;
		}
		this.QualitySpriteMap[0].SetUIActive(true);
		int qualityId = DangoAbyssConfig.Instance.GetDangoItemById(configId).Value.QualityId;
		AbyssQuality? abyssQualityById = DangoAbyssConfig.Instance.GetAbyssQualityById(qualityId);
		this.SetSpriteByPath(((abyssQualityById != null) ? abyssQualityById.GetValueOrDefault().AbyssCoreItemFormationBg : null) ?? "", this.QualitySpriteMap[0], false, null, null);
	}

	// Token: 0x0600C4DD RID: 50397 RVA: 0x002CA5BC File Offset: 0x002C87BC
	private void RefreshOtherSprite(int index, int configId)
	{
		UUISprite uuisprite;
		if (!this.QualitySpriteMap.TryGetValue(index, out uuisprite))
		{
			return;
		}
		if (configId == 0)
		{
			uuisprite.SetUIActive(false);
			return;
		}
		uuisprite.SetUIActive(true);
		int qualityId = DangoAbyssConfig.Instance.GetDangoItemById(configId).Value.QualityId;
		AbyssQuality? abyssQualityById = DangoAbyssConfig.Instance.GetAbyssQualityById(qualityId);
		this.SetSpriteByPath(((abyssQualityById != null) ? abyssQualityById.GetValueOrDefault().AbyssItemFormationBg : null) ?? "", uuisprite, false, null, null);
		FColor color = FColor.FromHex(((abyssQualityById != null) ? abyssQualityById.GetValueOrDefault().AbyssItemFormationBgColor : null) ?? "");
		uuisprite.SetColor(color);
	}

	// Token: 0x04005ABD RID: 23229
	private readonly Dictionary<int, UUISprite> QualitySpriteMap = new Dictionary<int, UUISprite>();

	// Token: 0x04005ABE RID: 23230
	private readonly List<UUISprite> SpriteList = new List<UUISprite>();

	// Token: 0x02007F66 RID: 32614
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04029975 RID: 170357
		public const int MiddleSprite = 0;

		// Token: 0x04029976 RID: 170358
		public const int TopSprite = 1;

		// Token: 0x04029977 RID: 170359
		public const int LeftTopSprite = 2;

		// Token: 0x04029978 RID: 170360
		public const int LeftSprite = 3;

		// Token: 0x04029979 RID: 170361
		public const int LeftBottomSprite = 4;

		// Token: 0x0402997A RID: 170362
		public const int BottomSprite = 5;

		// Token: 0x0402997B RID: 170363
		public const int RightBottomSprite = 6;

		// Token: 0x0402997C RID: 170364
		public const int RightSprite = 7;

		// Token: 0x0402997D RID: 170365
		public const int RightTopSprite = 8;
	}
}
