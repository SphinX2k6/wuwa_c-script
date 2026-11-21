using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020007BF RID: 1983
[Nullable(new byte[]
{
	0,
	1
})]
public class CharacterValueItem : GridProxyAbstract<CharacterData>
{
	// Token: 0x06005AAE RID: 23214 RVA: 0x001D62FC File Offset: 0x001D44FC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUISprite))
		};
	}

	// Token: 0x06005AAF RID: 23215 RVA: 0x001D636C File Offset: 0x001D456C
	protected override void OnStart()
	{
		this.OriginalProgressWidth = base.GetSprite(1).Width;
		base.GetSprite(2).SetFillAmount(0f);
	}

	// Token: 0x06005AB0 RID: 23216 RVA: 0x001D6394 File Offset: 0x001D4594
	[NullableContext(1)]
	public override void Refresh(CharacterData data, bool isSelected, int gridIndex)
	{
		base.GetText(0).SetText(data.CurrentValue.ToString(), true);
		this.RefreshProgress(data.CurrentValue, data.MaxValue);
		this.RefreshSprite(data.Id);
	}

	// Token: 0x06005AB1 RID: 23217 RVA: 0x001D63DA File Offset: 0x001D45DA
	public void RefreshCurrentValue(int value)
	{
		base.GetText(0).SetText(value.ToString(), true);
	}

	// Token: 0x06005AB2 RID: 23218 RVA: 0x001D63F0 File Offset: 0x001D45F0
	public void RefreshProgress(int value, int maxValue)
	{
		float num = (value < maxValue) ? ((float)value / (float)maxValue) : 1f;
		float width = this.OriginalProgressWidth * num;
		UUISprite sprite = base.GetSprite(1);
		if (sprite == null)
		{
			return;
		}
		sprite.SetWidth(width);
	}

	// Token: 0x06005AB3 RID: 23219 RVA: 0x001D642C File Offset: 0x001D462C
	public void RefreshSprite(int characterId)
	{
		this.SetSpriteByPath(BusinessConfig.Instance.GetCharacterConfig(characterId).BarSprite, base.GetSprite(1), false, null, null);
	}

	// Token: 0x06005AB4 RID: 23220 RVA: 0x001D6464 File Offset: 0x001D4664
	public void RefreshProgressAdd(int value, int maxValue)
	{
		float fillAmount = (float)value / (float)maxValue;
		base.GetSprite(2).SetFillAmount(fillAmount);
	}

	// Token: 0x06005AB5 RID: 23221 RVA: 0x001D6484 File Offset: 0x001D4684
	public void SetLightProgressWidth()
	{
		float width = base.GetSprite(1).GetWidth();
		UUISprite sprite = base.GetSprite(3);
		if (sprite == null)
		{
			return;
		}
		sprite.SetWidth(width);
	}

	// Token: 0x04003CEE RID: 15598
	protected float OriginalProgressWidth;

	// Token: 0x02006AD4 RID: 27348
	private static class EComponentDefine
	{
		// Token: 0x04023257 RID: 143959
		public const int CurrentValue = 0;

		// Token: 0x04023258 RID: 143960
		public const int Progress = 1;

		// Token: 0x04023259 RID: 143961
		public const int ProgressAdd = 2;

		// Token: 0x0402325A RID: 143962
		public const int LightProgress = 3;
	}
}
