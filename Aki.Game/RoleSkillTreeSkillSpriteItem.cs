using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020028C7 RID: 10439
public class RoleSkillTreeSkillSpriteItem : UiPanelBase
{
	// Token: 0x060158DF RID: 88287 RVA: 0x0057176B File Offset: 0x0056F96B
	[NullableContext(1)]
	public RoleSkillTreeSkillSpriteItem(AActor actor)
	{
		base.CreateThenShowByActor(actor, null);
	}

	// Token: 0x060158E0 RID: 88288 RVA: 0x0057177C File Offset: 0x0056F97C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060158E1 RID: 88289 RVA: 0x005717C4 File Offset: 0x0056F9C4
	public void Update(int skillId)
	{
		this.SetSpriteByPath(RoleSkillConfig.Instance.GetSkillConfigById(skillId).Value.Icon, base.GetSprite(0), false, null, null);
	}

	// Token: 0x02008ED9 RID: 36569
	private enum EComponents
	{
		// Token: 0x0402E53E RID: 189758
		IconSprite
	}
}
