using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002291 RID: 8849
public class WeeklyRogueRewardFetterItem : GridProxyAbstract<int>
{
	// Token: 0x06015DFD RID: 89597 RVA: 0x00657B94 File Offset: 0x00655D94
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x06015DFE RID: 89598 RVA: 0x00657BCD File Offset: 0x00655DCD
	protected override void OnStart()
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(false);
	}

	// Token: 0x06015DFF RID: 89599 RVA: 0x00657BE4 File Offset: 0x00655DE4
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		string fetterElementPath = PhantomBattleConfig.Instance.GetFetterGroupById(data).FetterElementPath;
		base.SetTextureByPath(fetterElementPath, base.GetTexture(1), null, null);
	}

	// Token: 0x020084ED RID: 34029
	private enum EFetter
	{
		// Token: 0x0402AD9F RID: 175519
		Sprite,
		// Token: 0x0402ADA0 RID: 175520
		Texture
	}
}
