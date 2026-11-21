using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020019B9 RID: 6585
[NullableContext(1)]
[Nullable(0)]
public class VisionNameText
{
	// Token: 0x06010411 RID: 66577 RVA: 0x004BF31F File Offset: 0x004BD51F
	public VisionNameText(UUIText textComponent)
	{
		this.TextComponent = textComponent;
	}

	// Token: 0x06010412 RID: 66578 RVA: 0x004BF330 File Offset: 0x004BD530
	public void Update(PhantomDataBase data)
	{
		string monsterName = data.GetMonsterName();
		LguiUtil.Instance.SetLocalTextNew(this.TextComponent, monsterName, Array.Empty<object>());
		this.TextComponent.SetColor(FColor.FromHex(data.GetNameColor()));
	}

	// Token: 0x04009009 RID: 36873
	[Nullable(2)]
	private readonly UUIText TextComponent;
}
