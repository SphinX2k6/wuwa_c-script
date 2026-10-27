using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001284 RID: 4740
[Nullable(new byte[]
{
	0,
	1
})]
public class FightPhotoTaskTargetItem : GridProxyAbstract<string>
{
	// Token: 0x06008170 RID: 33136 RVA: 0x001B7584 File Offset: 0x001B5784
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06008171 RID: 33137 RVA: 0x001B75DE File Offset: 0x001B57DE
	[NullableContext(1)]
	public override void Refresh(string data, bool isSelected, int gridIndex)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data, Array.Empty<object>());
	}

	// Token: 0x06008172 RID: 33138 RVA: 0x001B75F7 File Offset: 0x001B57F7
	public void SetIsFinished(bool isFinished)
	{
		base.GetSprite(1).SetUIActive(isFinished);
		base.GetSprite(0).SetUIActive(!isFinished);
	}

	// Token: 0x0200789C RID: 30876
	private enum EComponents
	{
		// Token: 0x04027BD4 RID: 162772
		SpriteUnFinished,
		// Token: 0x04027BD5 RID: 162773
		SpriteFinished,
		// Token: 0x04027BD6 RID: 162774
		TextGoal
	}
}
