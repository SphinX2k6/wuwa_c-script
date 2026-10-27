using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using UnrealEngine;

// Token: 0x020018BB RID: 6331
[NullableContext(1)]
public interface IItemGrid
{
	// Token: 0x17000F5C RID: 3932
	// (get) Token: 0x0600B999 RID: 47513
	bool IsItemGrid { get; }

	// Token: 0x0600B99A RID: 47514
	void RefreshQualitySprite();

	// Token: 0x0600B99B RID: 47515
	void RefreshTextureIcon();

	// Token: 0x0600B99C RID: 47516
	void RefreshTextDown(bool showState, string text);

	// Token: 0x0600B99D RID: 47517
	void SetToggleClickEvent(Action<int, ItemConfig> call);

	// Token: 0x0600B99E RID: 47518
	void SetToggleClickStateEvent(Action<EToggleState> call);

	// Token: 0x0600B99F RID: 47519
	[NullableContext(2)]
	UUIExtendToggle GetClickToggle();

	// Token: 0x0600B9A0 RID: 47520
	[NullableContext(2)]
	UUIText GetDownText();

	// Token: 0x0600B9A1 RID: 47521
	void BindRedPointWithKeyAndId(ERedDotName name, int uid);

	// Token: 0x0600B9A2 RID: 47522
	void RefreshCdPanel(bool showState, float cdFillAmount, string cdText);

	// Token: 0x0600B9A3 RID: 47523
	void RefreshDarkSprite(bool showState);

	// Token: 0x0600B9A4 RID: 47524
	void RefreshLockSprite(bool showState);
}
