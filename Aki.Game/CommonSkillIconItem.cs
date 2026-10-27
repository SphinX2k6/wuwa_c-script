using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017FC RID: 6140
public class CommonSkillIconItem : UiPanelBase
{
	// Token: 0x0600B3CD RID: 46029 RVA: 0x0028A1D6 File Offset: 0x002883D6
	[NullableContext(1)]
	public CommonSkillIconItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600B3CE RID: 46030 RVA: 0x0028A1EB File Offset: 0x002883EB
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture))
		};
	}

	// Token: 0x0600B3CF RID: 46031 RVA: 0x0028A210 File Offset: 0x00288410
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

	// Token: 0x02007DF9 RID: 32249
	private enum ECommonSkillItem
	{
		// Token: 0x040293A0 RID: 168864
		SkillIcon
	}
}
