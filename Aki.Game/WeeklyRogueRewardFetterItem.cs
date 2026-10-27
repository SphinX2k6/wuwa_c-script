using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002D37 RID: 11575
public class WeeklyRogueRewardFetterItem : GridProxyAbstract<int>
{
	// Token: 0x0601855B RID: 99675 RVA: 0x00631B84 File Offset: 0x0062FD84
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x0601855C RID: 99676 RVA: 0x00631BBD File Offset: 0x0062FDBD
	protected override void OnStart()
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(false);
	}

	// Token: 0x0601855D RID: 99677 RVA: 0x00631BD4 File Offset: 0x0062FDD4
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		string fetterElementPath = PhantomBattleConfig.Instance.GetFetterGroupById(data).FetterElementPath;
		base.SetTextureByPath(fetterElementPath, base.GetTexture(1), null, null);
	}

	// Token: 0x020092C6 RID: 37574
	private enum EFetter
	{
		// Token: 0x0402F717 RID: 194327
		Sprite,
		// Token: 0x0402F718 RID: 194328
		Texture
	}
}
