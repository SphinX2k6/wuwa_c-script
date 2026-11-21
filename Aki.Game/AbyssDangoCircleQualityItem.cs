using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000EE0 RID: 3808
[NullableContext(1)]
[Nullable(0)]
public class AbyssDangoCircleQualityItem : UiPanelBase
{
	// Token: 0x060098E9 RID: 39145 RVA: 0x002D5334 File Offset: 0x002D3534
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

	// Token: 0x060098EA RID: 39146 RVA: 0x002D5488 File Offset: 0x002D3688
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

	// Token: 0x060098EB RID: 39147 RVA: 0x002D557C File Offset: 0x002D377C
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

	// Token: 0x060098EC RID: 39148 RVA: 0x002D5634 File Offset: 0x002D3834
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

	// Token: 0x060098ED RID: 39149 RVA: 0x002D56D4 File Offset: 0x002D38D4
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

	// Token: 0x04005B8C RID: 23436
	private readonly Dictionary<int, UUISprite> QualitySpriteMap = new Dictionary<int, UUISprite>();

	// Token: 0x04005B8D RID: 23437
	private readonly List<UUISprite> SpriteList = new List<UUISprite>();

	// Token: 0x020070F5 RID: 28917
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04024CB2 RID: 150706
		public const int MiddleSprite = 0;

		// Token: 0x04024CB3 RID: 150707
		public const int TopSprite = 1;

		// Token: 0x04024CB4 RID: 150708
		public const int LeftTopSprite = 2;

		// Token: 0x04024CB5 RID: 150709
		public const int LeftSprite = 3;

		// Token: 0x04024CB6 RID: 150710
		public const int LeftBottomSprite = 4;

		// Token: 0x04024CB7 RID: 150711
		public const int BottomSprite = 5;

		// Token: 0x04024CB8 RID: 150712
		public const int RightBottomSprite = 6;

		// Token: 0x04024CB9 RID: 150713
		public const int RightSprite = 7;

		// Token: 0x04024CBA RID: 150714
		public const int RightTopSprite = 8;
	}
}
