using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x0200444B RID: 17483
	public class KeySettingRowTypeItem : UiPanelBase
	{
		// Token: 0x0602C1B9 RID: 180665 RVA: 0x00C61FFE File Offset: 0x00C601FE
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0602C1BA RID: 180666 RVA: 0x00C62038 File Offset: 0x00C60238
		[NullableContext(1)]
		public void Refresh(KeySettingRowData keySettingRowData)
		{
			if (keySettingRowData.GetRowType() != EKeySettingRowType.KeyType)
			{
				return;
			}
			string keyTypeIconSpritePath = keySettingRowData.KeyTypeIconSpritePath;
			UUISprite sprite = base.GetSprite(0);
			UUIText text = base.GetText(1);
			if (StringUtils.IsEmpty(keyTypeIconSpritePath))
			{
				sprite.SetUIActive(false);
			}
			else
			{
				this.SetSpriteByPath(keySettingRowData.KeyTypeIconSpritePath, sprite, false, null, null);
				sprite.SetUIActive(true);
			}
			string keyTypeName = keySettingRowData.KeyTypeName;
			if (StringUtils.IsEmpty(keyTypeName))
			{
				text.SetUIActive(false);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(text, keyTypeName, Array.Empty<object>());
			text.SetUIActive(true);
		}

		// Token: 0x0200A11A RID: 41242
		public class EChildType
		{
			// Token: 0x040320C8 RID: 205000
			public const int TypeSprite = 0;

			// Token: 0x040320C9 RID: 205001
			public const int TypeNameText = 1;
		}
	}
}
