using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020005B8 RID: 1464
public class ArtemisQteRingSingleAreaItem : UiPanelBase
{
	// Token: 0x06004532 RID: 17714 RVA: 0x0017C748 File Offset: 0x0017A948
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x06004533 RID: 17715 RVA: 0x0017C781 File Offset: 0x0017A981
	protected override void OnBeforeDestroy()
	{
		this.ProgressParamName = null;
	}

	// Token: 0x06004534 RID: 17716 RVA: 0x0017C78F File Offset: 0x0017A98F
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

	// Token: 0x06004535 RID: 17717 RVA: 0x0017C7B6 File Offset: 0x0017A9B6
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

	// Token: 0x06004536 RID: 17718 RVA: 0x0017C7E9 File Offset: 0x0017A9E9
	public void SetHighLight(bool isHighLight)
	{
		base.GetTexture(0).SetUIActive(!isHighLight);
		base.GetTexture(1).SetUIActive(isHighLight);
	}

	// Token: 0x0400355D RID: 13661
	private FName ProgressParamName = new FName("Progress");

	// Token: 0x0200685A RID: 26714
	private class EComponents
	{
		// Token: 0x0402267E RID: 140926
		public const int TextureArea = 0;

		// Token: 0x0402267F RID: 140927
		public const int TextureAreaHighLight = 1;
	}
}
