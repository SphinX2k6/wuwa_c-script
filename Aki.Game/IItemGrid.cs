using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using UnrealEngine;

// Token: 0x02000D74 RID: 3444
[NullableContext(1)]
public interface IItemGrid
{
	// Token: 0x17000F7F RID: 3967
	// (get) Token: 0x06008D82 RID: 36226
	bool IsItemGrid { get; }

	// Token: 0x06008D83 RID: 36227
	void RefreshQualitySprite();

	// Token: 0x06008D84 RID: 36228
	void RefreshTextureIcon();

	// Token: 0x06008D85 RID: 36229
	void RefreshTextDown(bool showState, string text);

	// Token: 0x06008D86 RID: 36230
	void SetToggleClickEvent(Action<int, ItemConfig> call);

	// Token: 0x06008D87 RID: 36231
	void SetToggleClickStateEvent(Action<EToggleState> call);

	// Token: 0x06008D88 RID: 36232
	[NullableContext(2)]
	UUIExtendToggle GetClickToggle();

	// Token: 0x06008D89 RID: 36233
	[NullableContext(2)]
	UUIText GetDownText();

	// Token: 0x06008D8A RID: 36234
	void BindRedPointWithKeyAndId(ERedDotName name, int uid);

	// Token: 0x06008D8B RID: 36235
	void RefreshCdPanel(bool showState, float cdFillAmount, string cdText);

	// Token: 0x06008D8C RID: 36236
	void RefreshDarkSprite(bool showState);

	// Token: 0x06008D8D RID: 36237
	void RefreshLockSprite(bool showState);
}
