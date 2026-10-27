using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020024D2 RID: 9426
[NullableContext(1)]
[Nullable(0)]
public class VisionNameText
{
	// Token: 0x06012F52 RID: 77650 RVA: 0x004B171F File Offset: 0x004AF91F
	public VisionNameText(UUIText textComponent)
	{
		this.TextComponent = textComponent;
	}

	// Token: 0x06012F53 RID: 77651 RVA: 0x004B1730 File Offset: 0x004AF930
	public void Update(PhantomDataBase data)
	{
		string monsterName = data.GetMonsterName();
		LguiUtil.Instance.SetLocalTextNew(this.TextComponent, monsterName, Array.Empty<object>());
		this.TextComponent.SetColor(FColor.FromHex(data.GetNameColor()));
	}

	// Token: 0x04008EBF RID: 36543
	[Nullable(2)]
	private readonly UUIText TextComponent;
}
