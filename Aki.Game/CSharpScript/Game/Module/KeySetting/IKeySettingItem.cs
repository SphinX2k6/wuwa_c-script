using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.KeySetting
{
	// Token: 0x020057A4 RID: 22436
	[NullableContext(2)]
	public interface IKeySettingItem
	{
		// Token: 0x0603902F RID: 233519
		[NullableContext(1)]
		UUIText GetTitleUiText();

		// Token: 0x06039030 RID: 233520
		[NullableContext(1)]
		UUIExtendToggle GetKeySetToggle();

		// Token: 0x06039031 RID: 233521
		[NullableContext(1)]
		UUIText GetKeyNameUiText();

		// Token: 0x06039032 RID: 233522
		[NullableContext(1)]
		UUIItem GetCursorItem();

		// Token: 0x06039033 RID: 233523 RVA: 0x00D8D5CE File Offset: 0x00D8B7CE
		UUIItem GetDetailUiItem()
		{
			return null;
		}

		// Token: 0x06039034 RID: 233524 RVA: 0x00D8D5D1 File Offset: 0x00D8B7D1
		UUIText GetDetailUiText()
		{
			return null;
		}

		// Token: 0x06039035 RID: 233525 RVA: 0x00D8D5D4 File Offset: 0x00D8B7D4
		UUISprite GetDetailSprite()
		{
			return null;
		}

		// Token: 0x06039036 RID: 233526 RVA: 0x00D8D5D7 File Offset: 0x00D8B7D7
		UUISprite GetLockSprite()
		{
			return null;
		}

		// Token: 0x06039037 RID: 233527 RVA: 0x00D8D5DA File Offset: 0x00D8B7DA
		UUISprite GetSelectSprite()
		{
			return null;
		}

		// Token: 0x06039038 RID: 233528 RVA: 0x00D8D5DD File Offset: 0x00D8B7DD
		UUIButtonComponent GetCancelButton()
		{
			return null;
		}
	}
}
