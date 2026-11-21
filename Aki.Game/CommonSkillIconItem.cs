using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000CB5 RID: 3253
public class CommonSkillIconItem : UiPanelBase
{
	// Token: 0x060087B7 RID: 34743 RVA: 0x002948D2 File Offset: 0x00292AD2
	[NullableContext(1)]
	public CommonSkillIconItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x060087B8 RID: 34744 RVA: 0x002948E7 File Offset: 0x00292AE7
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture))
		};
	}

	// Token: 0x060087B9 RID: 34745 RVA: 0x0029490C File Offset: 0x00292B0C
	[NullableContext(1)]
	public void UpdateItem(string path)
	{
		UUITexture texture = base.GetTexture(0);
		if (!string.IsNullOrEmpty(path))
		{
			base.SetTextureByPath(path, texture, null, null);
			this.SetActive(true);
			return;
		}
		this.SetActive(false);
	}

	// Token: 0x02006F7F RID: 28543
	private enum ECommonSkillItem
	{
		// Token: 0x040246CB RID: 149195
		SkillIcon
	}
}
