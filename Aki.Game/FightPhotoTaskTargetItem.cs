using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000738 RID: 1848
[Nullable(new byte[]
{
	0,
	1
})]
public class FightPhotoTaskTargetItem : GridProxyAbstract<string>
{
	// Token: 0x06005507 RID: 21767 RVA: 0x001C0254 File Offset: 0x001BE454
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06005508 RID: 21768 RVA: 0x001C02AE File Offset: 0x001BE4AE
	[NullableContext(1)]
	public override void Refresh(string data, bool isSelected, int gridIndex)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data, Array.Empty<object>());
	}

	// Token: 0x06005509 RID: 21769 RVA: 0x001C02C7 File Offset: 0x001BE4C7
	public void SetIsFinished(bool isFinished)
	{
		base.GetSprite(1).SetUIActive(isFinished);
		base.GetSprite(0).SetUIActive(!isFinished);
	}

	// Token: 0x02006A27 RID: 27175
	private enum EComponents
	{
		// Token: 0x04022F05 RID: 143109
		SpriteUnFinished,
		// Token: 0x04022F06 RID: 143110
		SpriteFinished,
		// Token: 0x04022F07 RID: 143111
		TextGoal
	}
}
