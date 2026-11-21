using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02000EC8 RID: 3784
[NullableContext(1)]
[Nullable(0)]
public class DamageViewData
{
	// Token: 0x06009756 RID: 38742 RVA: 0x002CDC70 File Offset: 0x002CBE70
	public void Initialize(DamageText damageTextConfig)
	{
		this.ConfigId = damageTextConfig.Id;
		this.DamageTextConfig = new DamageText?(damageTextConfig);
		this.CriticalNiagaraPath = damageTextConfig.CritNiagaraPath;
		this.MinRandomOffsetX = (float)damageTextConfig.MinDeviationX;
		this.MinRandomOffsetY = (float)damageTextConfig.MinDeviationY;
		this.MaxRandomOffsetX = (float)damageTextConfig.MaxDeviationX;
		this.MaxRandomOffsetY = (float)damageTextConfig.MaxDeviationX;
		this.TextColor = new FColor?(FColor.FromHex(damageTextConfig.TextColor));
		this.CriticalTextColor = new FColor?(FColor.FromHex(damageTextConfig.CritTextColor));
		this.StrokeColor = new FColor?(FColor.FromHex(damageTextConfig.StrokeColor));
		this.CriticalStrokeColor = new FColor?(FColor.FromHex(damageTextConfig.CritStrokeColor));
	}

	// Token: 0x06009757 RID: 38743 RVA: 0x002CDD37 File Offset: 0x002CBF37
	public int GetConfigId()
	{
		return this.ConfigId;
	}

	// Token: 0x06009758 RID: 38744 RVA: 0x002CDD3F File Offset: 0x002CBF3F
	public float GetRandomOffsetX()
	{
		return MathUtils.Instance.GetRandomFloatNumber(this.MinRandomOffsetX, this.MaxRandomOffsetX);
	}

	// Token: 0x06009759 RID: 38745 RVA: 0x002CDD57 File Offset: 0x002CBF57
	public float GetRandomOffsetY()
	{
		return MathUtils.Instance.GetRandomFloatNumber(this.MinRandomOffsetY, this.MaxRandomOffsetY);
	}

	// Token: 0x0600975A RID: 38746 RVA: 0x002CDD6F File Offset: 0x002CBF6F
	public FColor? GetTextColor()
	{
		return this.TextColor;
	}

	// Token: 0x0600975B RID: 38747 RVA: 0x002CDD77 File Offset: 0x002CBF77
	public FColor? GetCriticalTextColor()
	{
		return this.CriticalTextColor;
	}

	// Token: 0x0600975C RID: 38748 RVA: 0x002CDD7F File Offset: 0x002CBF7F
	public FColor? GetStrokeColor()
	{
		return this.StrokeColor;
	}

	// Token: 0x0600975D RID: 38749 RVA: 0x002CDD87 File Offset: 0x002CBF87
	public FColor? GetCriticalStrokeColor()
	{
		return this.CriticalStrokeColor;
	}

	// Token: 0x0600975E RID: 38750 RVA: 0x002CDD8F File Offset: 0x002CBF8F
	public string GetCriticalNiagaraPath()
	{
		return this.CriticalNiagaraPath;
	}

	// Token: 0x0600975F RID: 38751 RVA: 0x002CDD98 File Offset: 0x002CBF98
	public string GetSequencePath(bool bOwnPlayerDamage, bool bCritical, bool bCustomText)
	{
		if (bCustomText)
		{
			return this.DamageTextConfig.Value.DamageTextSequence;
		}
		if (bOwnPlayerDamage)
		{
			if (bCritical)
			{
				return this.DamageTextConfig.Value.OwnCriticalDamageSequence;
			}
			return this.DamageTextConfig.Value.OwnDamageSequence;
		}
		else
		{
			if (bCritical)
			{
				return this.DamageTextConfig.Value.MonsterCriticalDamageSequence;
			}
			return this.DamageTextConfig.Value.MonsterDamageSequence;
		}
	}

	// Token: 0x04005AEE RID: 23278
	public int ConfigId;

	// Token: 0x04005AEF RID: 23279
	public DamageText? DamageTextConfig;

	// Token: 0x04005AF0 RID: 23280
	public float MinRandomOffsetX;

	// Token: 0x04005AF1 RID: 23281
	public float MinRandomOffsetY;

	// Token: 0x04005AF2 RID: 23282
	public float MaxRandomOffsetX;

	// Token: 0x04005AF3 RID: 23283
	public float MaxRandomOffsetY;

	// Token: 0x04005AF4 RID: 23284
	public FColor? TextColor;

	// Token: 0x04005AF5 RID: 23285
	public FColor? CriticalTextColor;

	// Token: 0x04005AF6 RID: 23286
	public FColor? StrokeColor;

	// Token: 0x04005AF7 RID: 23287
	public FColor? CriticalStrokeColor;

	// Token: 0x04005AF8 RID: 23288
	public string CriticalNiagaraPath = "";

	// Token: 0x04005AF9 RID: 23289
	public int CriticalNiagaraId = -1;
}
