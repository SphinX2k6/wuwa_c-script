using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E42 RID: 7746
public class RoleSkillTreeSkillSpriteItem : UiPanelBase
{
	// Token: 0x060132DF RID: 78559 RVA: 0x0059C62F File Offset: 0x0059A82F
	[NullableContext(1)]
	public RoleSkillTreeSkillSpriteItem(AActor actor)
	{
		base.CreateThenShowByActor(actor, null);
	}

	// Token: 0x060132E0 RID: 78560 RVA: 0x0059C640 File Offset: 0x0059A840
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

	// Token: 0x060132E1 RID: 78561 RVA: 0x0059C688 File Offset: 0x0059A888
	public void Update(int skillId)
	{
		this.SetSpriteByPath(RoleSkillConfig.Instance.GetSkillConfigById(skillId).Value.Icon, base.GetSprite(0), false, null, null);
	}

	// Token: 0x02008121 RID: 33057
	private enum EComponents
	{
		// Token: 0x04029C39 RID: 171065
		IconSprite
	}
}
