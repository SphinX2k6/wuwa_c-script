using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200130B RID: 4875
[Nullable(new byte[]
{
	0,
	1
})]
public class CharacterValueItem : GridProxyAbstract<CharacterData>
{
	// Token: 0x06008713 RID: 34579 RVA: 0x001CD490 File Offset: 0x001CB690
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

	// Token: 0x06008714 RID: 34580 RVA: 0x001CD500 File Offset: 0x001CB700
	protected override void OnStart()
	{
		this.OriginalProgressWidth = base.GetSprite(1).Width;
		base.GetSprite(2).SetFillAmount(0f);
	}

	// Token: 0x06008715 RID: 34581 RVA: 0x001CD528 File Offset: 0x001CB728
	[NullableContext(1)]
	public override void Refresh(CharacterData data, bool isSelected, int gridIndex)
	{
		base.GetText(0).SetText(data.CurrentValue.ToString(), true);
		this.RefreshProgress(data.CurrentValue, data.MaxValue);
		this.RefreshSprite(data.Id);
	}

	// Token: 0x06008716 RID: 34582 RVA: 0x001CD56E File Offset: 0x001CB76E
	public void RefreshCurrentValue(int value)
	{
		base.GetText(0).SetText(value.ToString(), true);
	}

	// Token: 0x06008717 RID: 34583 RVA: 0x001CD584 File Offset: 0x001CB784
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

	// Token: 0x06008718 RID: 34584 RVA: 0x001CD5C0 File Offset: 0x001CB7C0
	public void RefreshSprite(int characterId)
	{
		this.SetSpriteByPath(BusinessConfig.Instance.GetCharacterConfig(characterId).BarSprite, base.GetSprite(1), false, null, null);
	}

	// Token: 0x06008719 RID: 34585 RVA: 0x001CD5F8 File Offset: 0x001CB7F8
	public void RefreshProgressAdd(int value, int maxValue)
	{
		float fillAmount = (float)value / (float)maxValue;
		base.GetSprite(2).SetFillAmount(fillAmount);
	}

	// Token: 0x0600871A RID: 34586 RVA: 0x001CD618 File Offset: 0x001CB818
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

	// Token: 0x04003C56 RID: 15446
	protected float OriginalProgressWidth;

	// Token: 0x0200794A RID: 31050
	private static class EComponentDefine
	{
		// Token: 0x04027F2A RID: 163626
		public const int CurrentValue = 0;

		// Token: 0x04027F2B RID: 163627
		public const int Progress = 1;

		// Token: 0x04027F2C RID: 163628
		public const int ProgressAdd = 2;

		// Token: 0x04027F2D RID: 163629
		public const int LightProgress = 3;
	}
}
