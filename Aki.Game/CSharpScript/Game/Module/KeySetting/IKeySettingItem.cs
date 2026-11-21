using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.KeySetting
{
	// Token: 0x0200477B RID: 18299
	[NullableContext(2)]
	public interface IKeySettingItem
	{
		// Token: 0x0602DF3F RID: 188223
		[NullableContext(1)]
		UUIText GetTitleUiText();

		// Token: 0x0602DF40 RID: 188224
		[NullableContext(1)]
		UUIExtendToggle GetKeySetToggle();

		// Token: 0x0602DF41 RID: 188225
		[NullableContext(1)]
		UUIText GetKeyNameUiText();

		// Token: 0x0602DF42 RID: 188226
		[NullableContext(1)]
		UUIItem GetCursorItem();

		// Token: 0x0602DF43 RID: 188227 RVA: 0x00CDC38A File Offset: 0x00CDA58A
		UUIItem GetDetailUiItem()
		{
			return null;
		}

		// Token: 0x0602DF44 RID: 188228 RVA: 0x00CDC38D File Offset: 0x00CDA58D
		UUIText GetDetailUiText()
		{
			return null;
		}

		// Token: 0x0602DF45 RID: 188229 RVA: 0x00CDC390 File Offset: 0x00CDA590
		UUISprite GetDetailSprite()
		{
			return null;
		}

		// Token: 0x0602DF46 RID: 188230 RVA: 0x00CDC393 File Offset: 0x00CDA593
		UUISprite GetLockSprite()
		{
			return null;
		}

		// Token: 0x0602DF47 RID: 188231 RVA: 0x00CDC396 File Offset: 0x00CDA596
		UUISprite GetSelectSprite()
		{
			return null;
		}

		// Token: 0x0602DF48 RID: 188232 RVA: 0x00CDC399 File Offset: 0x00CDA599
		UUIButtonComponent GetCancelButton()
		{
			return null;
		}
	}
}
