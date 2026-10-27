using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001104 RID: 4356
public class ArtemisQteRingSingleAreaItem : UiPanelBase
{
	// Token: 0x0600719C RID: 29084 RVA: 0x00173D8C File Offset: 0x00171F8C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x0600719D RID: 29085 RVA: 0x00173DC5 File Offset: 0x00171FC5
	protected override void OnBeforeDestroy()
	{
		this.ProgressParamName = null;
	}

	// Token: 0x0600719E RID: 29086 RVA: 0x00173DD3 File Offset: 0x00171FD3
	public void SetFillAmount(float amount)
	{
		UUITexture texture = base.GetTexture(0);
		if (texture != null)
		{
			texture.SetFillAmount(amount);
		}
		UUITexture texture2 = base.GetTexture(1);
		if (texture2 == null)
		{
			return;
		}
		texture2.SetFillAmount(amount);
	}

	// Token: 0x0600719F RID: 29087 RVA: 0x00173DFA File Offset: 0x00171FFA
	public void SetCustomMaterialScalarParameter(float amount)
	{
		UUITexture texture = base.GetTexture(0);
		if (texture != null)
		{
			texture.SetCustomMaterialScalarParameter(this.ProgressParamName, amount);
		}
		UUITexture texture2 = base.GetTexture(1);
		if (texture2 == null)
		{
			return;
		}
		texture2.SetCustomMaterialScalarParameter(this.ProgressParamName, amount);
	}

	// Token: 0x060071A0 RID: 29088 RVA: 0x00173E2D File Offset: 0x0017202D
	public void SetHighLight(bool isHighLight)
	{
		base.GetTexture(0).SetUIActive(!isHighLight);
		base.GetTexture(1).SetUIActive(isHighLight);
	}

	// Token: 0x040034C4 RID: 13508
	private FName ProgressParamName = new FName("Progress");

	// Token: 0x020076C6 RID: 30406
	private class EComponents
	{
		// Token: 0x04027335 RID: 160565
		public const int TextureArea = 0;

		// Token: 0x04027336 RID: 160566
		public const int TextureAreaHighLight = 1;
	}
}
