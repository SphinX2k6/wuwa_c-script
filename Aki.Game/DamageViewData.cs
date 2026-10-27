using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02001A09 RID: 6665
[NullableContext(1)]
[Nullable(0)]
public class DamageViewData
{
	// Token: 0x0600C346 RID: 49990 RVA: 0x002C2C00 File Offset: 0x002C0E00
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

	// Token: 0x0600C347 RID: 49991 RVA: 0x002C2CC7 File Offset: 0x002C0EC7
	public int GetConfigId()
	{
		return this.ConfigId;
	}

	// Token: 0x0600C348 RID: 49992 RVA: 0x002C2CCF File Offset: 0x002C0ECF
	public float GetRandomOffsetX()
	{
		return MathUtils.Instance.GetRandomFloatNumber(this.MinRandomOffsetX, this.MaxRandomOffsetX);
	}

	// Token: 0x0600C349 RID: 49993 RVA: 0x002C2CE7 File Offset: 0x002C0EE7
	public float GetRandomOffsetY()
	{
		return MathUtils.Instance.GetRandomFloatNumber(this.MinRandomOffsetY, this.MaxRandomOffsetY);
	}

	// Token: 0x0600C34A RID: 49994 RVA: 0x002C2CFF File Offset: 0x002C0EFF
	public FColor? GetTextColor()
	{
		return this.TextColor;
	}

	// Token: 0x0600C34B RID: 49995 RVA: 0x002C2D07 File Offset: 0x002C0F07
	public FColor? GetCriticalTextColor()
	{
		return this.CriticalTextColor;
	}

	// Token: 0x0600C34C RID: 49996 RVA: 0x002C2D0F File Offset: 0x002C0F0F
	public FColor? GetStrokeColor()
	{
		return this.StrokeColor;
	}

	// Token: 0x0600C34D RID: 49997 RVA: 0x002C2D17 File Offset: 0x002C0F17
	public FColor? GetCriticalStrokeColor()
	{
		return this.CriticalStrokeColor;
	}

	// Token: 0x0600C34E RID: 49998 RVA: 0x002C2D1F File Offset: 0x002C0F1F
	public string GetCriticalNiagaraPath()
	{
		return this.CriticalNiagaraPath;
	}

	// Token: 0x0600C34F RID: 49999 RVA: 0x002C2D28 File Offset: 0x002C0F28
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

	// Token: 0x04005A1F RID: 23071
	public int ConfigId;

	// Token: 0x04005A20 RID: 23072
	public DamageText? DamageTextConfig;

	// Token: 0x04005A21 RID: 23073
	public float MinRandomOffsetX;

	// Token: 0x04005A22 RID: 23074
	public float MinRandomOffsetY;

	// Token: 0x04005A23 RID: 23075
	public float MaxRandomOffsetX;

	// Token: 0x04005A24 RID: 23076
	public float MaxRandomOffsetY;

	// Token: 0x04005A25 RID: 23077
	public FColor? TextColor;

	// Token: 0x04005A26 RID: 23078
	public FColor? CriticalTextColor;

	// Token: 0x04005A27 RID: 23079
	public FColor? StrokeColor;

	// Token: 0x04005A28 RID: 23080
	public FColor? CriticalStrokeColor;

	// Token: 0x04005A29 RID: 23081
	public string CriticalNiagaraPath = "";

	// Token: 0x04005A2A RID: 23082
	public int CriticalNiagaraId = -1;
}
