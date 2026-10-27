using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x02005468 RID: 21608
	public class KeySettingRowTypeItem : UiPanelBase
	{
		// Token: 0x06037270 RID: 225904 RVA: 0x00D12BE6 File Offset: 0x00D10DE6
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x06037271 RID: 225905 RVA: 0x00D12C20 File Offset: 0x00D10E20
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

		// Token: 0x0200B6E2 RID: 46818
		public class EChildType
		{
			// Token: 0x04037673 RID: 226931
			public const int TypeSprite = 0;

			// Token: 0x04037674 RID: 226932
			public const int TypeNameText = 1;
		}
	}
}
